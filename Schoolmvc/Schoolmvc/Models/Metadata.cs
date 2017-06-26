using System.ComponentModel.DataAnnotations;

namespace Schoolmvc.Models
{
    [MetadataType(typeof(RequestMetadata))]

    public partial class Request
    {
    }

    public class RequestMetadata
    {
        [Display(Name = "First Name")]
        public string FirstName;

        [Display(Name = "Last Name")]
        public string LastName;

        [Display(Name = "Phone Number")]
        public string PhoneNumber;

        [Display(Name = "Email Address")]
        public string EmailAddress;

        [Display(Name = "State")]
        public string StateId;
    }

    [MetadataType(typeof(CourseMetadata))]

    public partial class Course
    {
    }

    public class CourseMetadata
    {
        [Display(Name = "Course Title")]
        public string CourseTitle;

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:MI}", ApplyFormatInEditMode = true)]
        [Display(Name = "Time")]
        public string CourseTime;

        [Display(Name = "Day")]
        public string CourseDay;

        [Display(Name = "Fee")]
        public string CourseFee;

        [Display(Name = "Core Course")]
        public string CoreCourse;
    }
}