namespace Elsa.API.Domain;

public class Tenant
{
    public int Id { get; set; }
    public string Name { get; set; }


    public ICollection<int> UnitIds { get; set; } 
}
