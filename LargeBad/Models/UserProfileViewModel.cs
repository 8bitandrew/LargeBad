using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LargeBad.Models
{
    public class UserProfileViewModel : PageModel
    {
        public string EmailAddress { get; set; }
        public string Name { get; set; }
        public string ProfileImage { get; set; }
        public string Username { get; set; }
        public string Nickname { get; set; }
    }
}