
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace WebApp.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
        public virtual List<Note> Notes { get; set; }
    }
}