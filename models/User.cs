
using System.ComponentModel.DataAnnotations;

public class User
{
    [Key]
    public string? userName { get; set; }
    public string? password { get; set; }
    public string? gender { get; set; }

    public int phoneNumber { get; set; }
    public string? country { get; set; }
}