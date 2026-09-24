namespace RestEmployee.Feactures.Employees.Dto;

public record CreateEmployeeRequest(
    string FullName,
    string Email,
    DateTime DateOfBirth,
    int PositionId
    );

public  record UpdateEmployeeRequest(
        int EmployeeId,
        string FullName,
        string Email,
        DateOnly DateOfBirth,
        int PositionId
    );