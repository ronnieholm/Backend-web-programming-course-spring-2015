using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetWebApiDemo.Models.ViewModels
{
    public class PersonRequest
    {
        [Required]
        public string Name { get; set; }

        [Range(0, 99)]
        public int Age { get; set; }
    }
}