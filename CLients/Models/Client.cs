using Microsoft.EntityFrameworkCore;

namespace CLients.Models;

public class Client
{
    
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public int Age { get; set; }
}
