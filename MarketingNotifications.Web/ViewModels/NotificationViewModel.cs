using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using MarketingNotifications.Web.Models;

namespace MarketingNotifications.Web.ViewModels
{
    public class NotificationViewModel
    {
        [Required]
        [DataType(DataType.MultilineText)]
        [StringLength(160, ErrorMessage = "Text shoudln't be longer than 160 characters.")]
        public string Message { get; set; }

        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; }

        [Display(Name = "RV Show Subscribers")]
        public bool Rv { get; set; }

        [Display(Name = "Boat Show Subscribers")]
        public bool Boat { get; set; }

        [Display(Name = "Bridal Show Subscribers")]
        public bool Bridal { get; set; }

        [Display(Name = "Test Group - Office Numbers")]
        public bool TestGroup { get; set; }
    }
}