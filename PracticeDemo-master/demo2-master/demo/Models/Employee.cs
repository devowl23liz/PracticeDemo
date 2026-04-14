namespace demo.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string Role { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;
}
