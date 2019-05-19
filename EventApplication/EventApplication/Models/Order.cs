using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventApplication.Models
{
    public class Order
    {
        [Key]
        public virtual int Id { get; set; }

        public virtual string Key { get; set; }

        [ForeignKey("EventSelected")]
        public virtual int EventId { get; set; }

        [ForeignKey("UserSelected")]
        public virtual int UserId { get; set; }

        [Display(Name = "Order Number")]
        [DisplayFormat(DataFormatString = "# {0}")]
        public virtual int Number { get; set; }

        [Display(Name = "Number of Tickets")]
        [Required(ErrorMessage = "Number of Tickets is required.")]
        public virtual int Tickets { get; set; }

        [Display(Name = "Date Ordered")]
        [DisplayFormat(DataFormatString = "{0:hh:mm tt}")]
        [DataType(DataType.Date)]
        public virtual DateTime OrderDate { get; set; }

        public virtual Event EventSelected { get; set; }
        public virtual User UserSelected { get; set; }

        [Display(Name = "Order Status")]
        public virtual int Status { get; set; }
    }
}