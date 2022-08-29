using Data.Interfaces;


namespace Data.Models
{
    public class Group : IModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public override string ToString() => $"{Name}-{Number}";
    }
}
