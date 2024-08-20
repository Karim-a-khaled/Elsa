namespace Elsa.API.Domain;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsMarried { get; set; }
    public bool HasNewBorn { get; set; }
    public float YearsOfService { get; set; }
    public int Gender { get; set; }

    public ICollection<int> LeaveRequestIds { get; set; } 

    public int UnitId { get; set; }

    public int CountryId { get; set; }
}
