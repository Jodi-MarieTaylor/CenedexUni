using System;
using System.Collections.Generic;

namespace CenedexUniversity.Model
{
    public partial class StudentGrades
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public double? FinalPercentageGrade { get; set; }
        public string FinalLetterGrade { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
