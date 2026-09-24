namespace RestEmployee.Shared.Models;

public class Employee
{
    public int Id { get; set; }
    public string Fullname { get; set; }
    public string Email { get; set; }
    public DateOnly BirthDate { get; set; }
    public int PositionId { get; set; }
    public virtual Position Position { get; set; }
}