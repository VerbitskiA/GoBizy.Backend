using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoBizy.Infrastructure.Identity;

public class ApplicationUser : IdentityUser
{
    [Column("LastName", TypeName = "varchar(100)")]
    public string LastName { get; set; }

    [Column("FirstName", TypeName = "varchar(100)")]
    public string FirstName { get; set; }

    [Column("Patronymic", TypeName = "varchar(100)")]
    public string Patronymic { get; set; }

    [Column("IsRegistrationComplete", TypeName = "boolean")]
    public bool IsRegistrationComplete { get; set; } = false;
    
    [Column("UserRole", TypeName = "varchar(20)")]
    public string UserRole { get; set; }
    
    [Column("UserIcon", TypeName = "text")]
    public string UserIcon { get; set; }
        
    [Column("RegisterDateUtc", TypeName = "timestamp")]
    public DateTime RegisterDateUtc { get; set; }

    [Column("City", TypeName = "varchar(200)")]
    public string City { get; set; }
    
    [Column("ConfirmationCode", TypeName = "varchar(5)")]
    public string ConfirmationCode { get; set; }

    public string? RefreshToken { get; set; }

    public DateTime RefreshTokenExpiryTime { get; set; }
}
