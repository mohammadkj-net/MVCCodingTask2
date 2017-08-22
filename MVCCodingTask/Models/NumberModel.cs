using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCodingTask.Models
{
    public class NumberModel
    {
        [Display(Name = "Integer Number")]
        [Required(ErrorMessage = "Integer Number is required")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Only integer numbers allowed")]
        public int intNumber { get; set; }
    }
}