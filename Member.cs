using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace abyssiness
{
    public partial class Member
    {
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "帳號")]
        public string Account { get; set; }

        [Required]
        [Display(Name = "密碼")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        public TimeSpan CreateTime { get; set; }

        [Required]
        [Display(Name = "姓名")]
        public string Name { get; set; }

        [Display(Name = "聯絡電話")]
        public string Phone { get; set; }
    }
}
