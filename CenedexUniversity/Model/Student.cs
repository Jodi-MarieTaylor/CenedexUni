using System;
using System.Collections.Generic;

namespace CenedexUniversity.Model
{
    public partial class Student
    {
        public Student()
        {
            StudentGrades = new HashSet<StudentGrades>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual ICollection<StudentGrades> StudentGrades { get; set; }
    }
}
