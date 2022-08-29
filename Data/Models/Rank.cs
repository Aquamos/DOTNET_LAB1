using Data.Interfaces;


namespace Data.Models
{
    public class Rank: IModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString() => Name;
    }
}
