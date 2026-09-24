namespace RestEmployee.Feactures.Employees.Dto;

public record GetEmployeeResponse(
    int EmployeeId,
    string FulltName,
    string Email,
    DateOnly BirthDate,
    int PositionId,
    string Position
    );