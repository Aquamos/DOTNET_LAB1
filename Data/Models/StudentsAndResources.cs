using Data.Interfaces;


namespace Data.Models
{
    public class StudentsAndResources: IModel
    {
        public int Id { get; set; }
        public int StudentId  { get; set; }
        public int ResourceId { get; set; }
    }
}
