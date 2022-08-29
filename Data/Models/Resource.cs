using Data.Interfaces;


namespace Data.Models
{
    public class Resource : IModel
    {
       public int Id { get; set; }
       public string Name { get; set; }
       public int ResourceTypeId { get; set; }
       public override string ToString() => Name;
       public override bool Equals(object? obj)
       {
           if (obj is Resource resource) return Name == resource.Name;
           return false;
       }
       public override int GetHashCode() => Name.GetHashCode();

    }
}
