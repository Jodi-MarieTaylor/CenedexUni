using System;
using System.Collections.Generic;

namespace CenedexUniversity.Model
{
    public partial class Course
    {
        public Course()
        {
            CourseLecturer = new HashSet<CourseLecturer>();
            StudentGrades = new HashSet<StudentGrades>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public short Credit { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual ICollection<CourseLecturer> CourseLecturer { get; set; }
        public virtual ICollection<StudentGrades> StudentGrades { get; set; }
    }
}
