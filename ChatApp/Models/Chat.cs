using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChatApp.Models
{
    public class Chat
    {
        [Key]
        public int ChatID { get; set; }
        [MaxLength(150)]
        public string ChatText { get; set; }
        public DateTime ChatTimeStamp { get; set; }

        public virtual ApplicationUser Username { get; set; }
    }
}