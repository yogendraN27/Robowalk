using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RoboWalk.Models
{
    public class RoboInputModel
    {
        [Required]
        [Display(Name = "X - Cordination")]
        public int XCordinationValue { get; set; }

        [Required]
        [Display(Name = "Y - Cordination")]
        public int YCordinationValue { get; set; }

        [Required]
        [Display(Name = "Direction")]
        public string Direction { get; set; }

        [Required]
        [Display(Name = "WalkInput")]
        public string WalkInput { get; set; }

        
        [Display(Name = "Result")]
        public string ResultValue { get; set; }
    }
}