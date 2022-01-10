using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bai2.Models
{
    public class User
    {
        [Required(ErrorMessage ="User khong duoc rong!!!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password khong duoc rong!!!")]
        [RegularExpression(@"[0-9]{6,11}", ErrorMessage = "Password sai!!! ")]
        public string Password { get; set; }
    }
}   