using System;
namespace Homework_1st.Models
{
    public class User : BaseEntity
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

    }
}

