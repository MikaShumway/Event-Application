using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EventApplication.Models
{
    public class EventType
    {
        [Key]
        public virtual int Id { get; set; }

        [Display(Name = "Event Type")]
        [Required(ErrorMessage = "Event Type is required.")]
        [StringLength(50, ErrorMessage = "Event Type cannot be more than 50 characters long.")]
        public virtual string Name { get; set; }
    }
}