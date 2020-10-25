using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lab4.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "LastName")]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "LastName")]
        public string FirstName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        public string FullName
        {
            set
            {
                FullName = LastName + ", " + FirstName;
            }
        }

        public int MembershipID { get; set; }

        public ICollection<CommunityMembership> Memberships { get; set; }

    }
}
