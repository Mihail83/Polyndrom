using System;
using System.Collections.Generic;
using System.Text;
using Polyndrom.DAL.EntityModels;
using Polyndrom.BLL.Models;

namespace Polyndrom.DAL.Mapping
{
    public  static class Extensionscs
    {
        public static User MapToDALUser(this BLLUser blluser)
        {
            return new User { ID = blluser.ID, Email = blluser.Email, Password = blluser.Password };
        }
        public static BLLUser MapToBLLUser(this User user)
        {
            return new BLLUser { ID = user.ID, Email = user.Email, Password = user.Password };
        }

    }
}
