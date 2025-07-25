using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly GorevContext _context;
    private readonly IConfiguration _config;

    public UserController(GorevContext context, IConfiguration config)
    {
        _context = context;
        _config = config;
    }

    [HttpPost("register")]
    public IActionResult Register([FromBody] User user)
    {
        if (_context.Users.Any(u => u.Username == user.Username || u.Email == user.Email))
            return BadRequest("Kullanıcı adı veya e-posta zaten kayıtlı.");
        _context.Users.Add(user);
        _context.SaveChanges();
        return Ok("Kayıt başarılı.");
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] User login)
    {
        var user = _context.Users.FirstOrDefault(u => u.Username == login.Username && u.Password == login.Password);
        if (user == null)
            return Unauthorized("Kullanıcı adı veya şifre hatalı.");
        var token = GenerateJwtToken(user);
        return Ok(new { token });
    }

    [HttpPut("update")]
    public IActionResult UpdateUser([FromBody] User updatedUser)
    {
        // JWT'den kullanıcı adını al
        var username = User.Identity?.Name;
        if (string.IsNullOrEmpty(username))
            return Unauthorized("Kullanıcı doğrulanamadı.");

        var user = _context.Users.FirstOrDefault(u => u.Username == username);
        if (user == null)
            return NotFound("Kullanıcı bulunamadı.");

        // Kullanıcı adı veya e-posta başka bir kullanıcıya ait mi kontrol et
        if (_context.Users.Any(u => (u.Username == updatedUser.Username || u.Email == updatedUser.Email) && u.Id != user.Id))
            return BadRequest("Kullanıcı adı veya e-posta başka bir kullanıcıya ait.");

        user.Username = updatedUser.Username;
        user.Email = updatedUser.Email;
        if (!string.IsNullOrWhiteSpace(updatedUser.Password))
            user.Password = updatedUser.Password;

        _context.SaveChanges();
        return Ok("Kullanıcı bilgileri güncellendi.");
    }

    [HttpGet("me")]
    public IActionResult GetMe()
    {
        var username = User.Identity?.Name;
        if (string.IsNullOrEmpty(username))
            return Unauthorized("Kullanıcı doğrulanamadı.");
        var user = _context.Users.FirstOrDefault(u => u.Username == username);
        if (user == null)
            return NotFound("Kullanıcı bulunamadı.");
        // Şifreyi göndermiyoruz
        return Ok(new { user.Username, user.Email });
    }

    private string GenerateJwtToken(User user)
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
        var claims = new[]
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Name, user.Username),
            new Claim(ClaimTypes.Email, user.Email)
        };
        var token = new JwtSecurityToken(
            issuer: _config["Jwt:Issuer"],
            audience: _config["Jwt:Issuer"],
            claims: claims,
            expires: DateTime.UtcNow.AddHours(2),
            signingCredentials: credentials
        );
        return new JwtSecurityTokenHandler().WriteToken(token);
    }
} 