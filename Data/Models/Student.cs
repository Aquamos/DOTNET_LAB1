

namespace Data.Models
{
    public class Student: Person
    {
        public int GroupId { get; set; }
        public decimal GPA { get; set; }
        public string Topic { get; set; }
        public DateTime DateOfDefence { get; set; }
    }
}
