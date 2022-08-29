using Data.Interfaces;


namespace Data.Models
{
    public abstract class Person : IModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DepartmentId { get; set; }
        public DateTime BirthDate { get; set; }
        public override string ToString() => $"{FirstName} {LastName}";
        public bool Equals(Person other)
        {
            return other != null &&
                   FirstName == other.FirstName &&
                   LastName == other.LastName &&
                   DepartmentId == other.DepartmentId &&
                   BirthDate == other.BirthDate;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(FirstName, LastName, DepartmentId, BirthDate);
        }
    }
}
