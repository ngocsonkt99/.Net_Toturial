using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bai2.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage =" Pls enter your name: ")]
        public string Name { get; set; }
        [Required(ErrorMessage = " Pls enter your mail: ")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = " Pls enter a valis mail! ")]
        public string Email { get; set; }
        [Required(ErrorMessage = " Pls enter your phone: ")]
        [RegularExpression(@"[0-9]{9}", ErrorMessage = " Phone is valid!!! ")]
        public string Phone { get; set; }
        [Required(ErrorMessage = " Pls specify wether will you attend! ")]
        public bool? WillAttend { get; set; }

        public override bool Equals(object obj)
        {
            if(obj != null)
            {
                if(obj is GuestResponse)
                {
                    GuestResponse s = (GuestResponse)obj;
                    if (s.Name == this.Name)
                        return true;
                }
            }
            return false;
        }
    }
}