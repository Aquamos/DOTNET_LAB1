using Data.Interfaces;


namespace Data.Models
{
    public class StudentsAndTeachers : IModel
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int TeacherId { get; set; }
    }
}
