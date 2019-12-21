using System;
using System.Collections.Generic;

namespace CenedexUniversity.Model
{
    public partial class Lecturer
    {
        public Lecturer()
        {
            CourseLecturer = new HashSet<CourseLecturer>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual ICollection<CourseLecturer> CourseLecturer { get; set; }
    }
}
