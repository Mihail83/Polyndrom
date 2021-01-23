using System;
using System.Collections.Generic;
using System.Text;

namespace Polyndrom.DAL.EntityModels
{
    public class User
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
