using System;
using System.Collections.Generic;

namespace CenedexUniversity.Model
{
    public partial class CourseLecturer
    {
        public int CourseId { get; set; }
        public int LecturerId { get; set; }

        public virtual Course Course { get; set; }
        public virtual Lecturer Lecturer { get; set; }
    }
}
