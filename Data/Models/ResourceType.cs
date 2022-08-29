using Data.Interfaces;


namespace Data.Models
{
    public class ResourceType: IModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString() => Name;
    }
}
