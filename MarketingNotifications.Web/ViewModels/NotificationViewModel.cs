using System;
using System.ComponentModel.DataAnnotations;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MarketingNotifications.Web.ViewModels
{
    public class NotificationViewModel
    {
        [Required]
        public string Message { get; set; }

        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; }

        public bool Rv { get; set; }

        public bool Boat { get; set; }

        public bool Bridal { get; set; }

//        protected void ClearTextBoxes(Control p1)
//        {
//            foreach (Control ctrl in p1.Controls)
//            {
//                if (ctrl is TextBox)
//                {
//                    TextBox t = ctrl as TextBox;
//
//                    if (t != null)
//                    {
//                        t.Text = String.Empty;
//                    }
//                }
//                else
//                {
//                    if (ctrl.Controls.Count > 0)
//                    {
//                        ClearTextBoxes(ctrl);
//                    }
//                }
//            }
//        }
    }
}