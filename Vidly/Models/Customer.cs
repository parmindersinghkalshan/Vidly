using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        //Add annotaion on top of property to override the bydefault behavior of EF to create columns in db
        //With [Required] annotation our column will not be nullable anymore
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

        //EntityFramework recognize this type of convention
        // and treat MembershipTypeId as a foreign key
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        //Nullable type because its not mandatory to have value in the db
        [Min18YearsIfAMember]
        public DateTime? DateOfBirth { get; set; }
    }
}