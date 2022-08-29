using System.Collections.Generic;
using Data.Models;

namespace Data
{
    public sealed class Context
    {
        private static Context _context;
        private Context() {
            Departments = new List<Department>();
            Groups = new List<Group>();
            People = new List<Person>();
            Ranks = new List<Rank>();
            Resources = new List<Resource>();
            ResourceTypes = new List<ResourceType>();
            StudentsAndResources = new List<StudentsAndResources>();  
            StudentsAndTeachers = new List<StudentsAndTeachers>();
        }
        public static Context GetContext()
        {
            if (_context == null)
            {
                _context = new Context();
            }
            return _context;
        }
        public List<Department> Departments { get; set; }
        public List<Group> Groups { get; set; }
        public List<Person> People { get; set; }
        public List<Rank> Ranks { get; set; }
        public List<Resource> Resources { get; set; }
        public List<ResourceType> ResourceTypes { get; set; }
        public List<StudentsAndResources> StudentsAndResources { get; set; }
        public List<StudentsAndTeachers> StudentsAndTeachers { get; set; }
    }
}