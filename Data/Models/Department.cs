using Data.Interfaces;


namespace Data.Models
{
    public class Department: IModel 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameAbbreviation { get; set; }
        public override string ToString() => Name;
    }
}
