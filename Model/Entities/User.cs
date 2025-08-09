using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

public class User
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("USER_ID")]
    public int UserId { get; set; }
    [Required, MaxLength(50), Column("FIRST_NAME")]
    public required string FirstName { get; set; }
    [Required, MaxLength(50), Column("LAST_NAME")]
    public required string LastName { get; set; }
    [Required, MaxLength(50), Column("PASSWORD")]
    public required string Password { get; set; }
    
    [Required, Column("ROLE")]
    public ERole Role { get; set; }
}

public enum ERole
{
    Administrator,
    User
    
}