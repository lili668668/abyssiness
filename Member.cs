using System;
using System.Collections.Generic;

namespace abyssiness
{
    public partial class Member
    {
        public Guid Id { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public TimeSpan CreateTime { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}
