using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarketingNotifications.Web.Models
{
    public class Subscriber
    {
        public int Id { get; set; }
        public String PhoneNumber { get; set; }
        public bool Subscribed { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool Boat { get; set; }
        public bool Rv { get; set; }
        public bool Bridal { get; set; }
        public bool TestGroup { get; set; }
    }
}
