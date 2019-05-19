using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventApplication.Models
{
    public class Event
    {
        [Key]
        public virtual int Id { get; set; }

        [ForeignKey("EventType")]
        public virtual int EventTypeId { get; set; }

        [Display(Name = "Event Title")]
        [Required(ErrorMessage = "Event Title is required.")]
        [StringLength(50, ErrorMessage = "Event Title cannot be more than 50 characters long.")]
        public virtual string Title { get; set; }

        [Display(Name = "Event Description")]
        [StringLength(150, ErrorMessage = "Event Description cannot be more than 150 characters long.")]
        public virtual string Description { get; set; }

        [Display(Name = "Event Starting Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Event Starting Date is required.")]
        [DataType(DataType.Date, ErrorMessage = "Event Starting Date must be a valid date.")]
        public virtual DateTime StartDate { get; set; }

        [Display(Name = "Event Starting Time")]
        [DisplayFormat(DataFormatString = "{0:hh:mm tt}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Event Starting Time is required.")]
        [DataType(DataType.Time, ErrorMessage = "Event Starting Time must be a valid time (0-24 Hours : 0-60 Minutes).")]
        public virtual DateTime StartTime { get; set; }

        [Display(Name = "Event Ending Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Event Ending Date is required.")]
        [DataType(DataType.Date, ErrorMessage = "Event Ending Date must be a valid date.")]
        public virtual DateTime EndDate { get; set; }

        [Display(Name = "Event Ending Time")]
        [DisplayFormat(DataFormatString = "{0:hh:mm tt}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Event Ending Time is required.")]
        [DataType(DataType.Time, ErrorMessage = "Event Ending Time must be a valid time.")]
        public virtual DateTime EndTime { get; set; }

        [Display(Name = "Event Location")]
        [Required(ErrorMessage = "Event Location is required.")]
        public virtual string Location { get; set; }

        [Display(Name = "Organizer Name")]
        [Required(ErrorMessage = "Organizer Name is required.")]
        [StringLength(100, ErrorMessage = "Organizer Name cannot be more than 100 characters long.")]
        public virtual string OrganizerName { get; set; }

        [Display(Name = "Organizer Contact Info")]
        [Required(ErrorMessage = "Organizer Contact Info is required.")]
        [StringLength(150, ErrorMessage = "Organizer Contact Info cannot contain more than 150 characters.")]
        public virtual string OrganizerContact { get; set; }

        public virtual EventType EventType { get; set; }

        [Display(Name = "Number of Tickets")]
        [Required(ErrorMessage = "Number of Tickets is required.")]
        [Range(1, 100, ErrorMessage = "Max tickets allowed is 100. / At least 1 ticket needs to be available.")]
        public virtual int Tickets { get; set;}
    }
}