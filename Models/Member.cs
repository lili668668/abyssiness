using System;
using System.ComponentModel.DataAnnotations;

namespace abyssiness.Models
{
    public class Member
    {
        [Required]
        [Display(Name = "帳號")]
        public string account { get; set; }
        [Required]
        [Display(Name = "密碼")]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Required]
        [Display(Name = "姓名")]
        public string name { get; set; }
        [Display(Name = "聯絡電話")]
        public string phone { get; set; }
    }
}
