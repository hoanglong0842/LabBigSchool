using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BiggSchool.Models.ViewModels
{
    public class CourseViewModel
    {
        [Required(ErrorMessage = "Vui lòng nhập Place")]
        public string Place { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập Date")]
        [FutureDate]
        public string Date { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập Time")]
        [ValidTime]
        public string Time { get; set; }
        [required]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }

}