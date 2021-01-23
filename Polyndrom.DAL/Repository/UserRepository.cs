using System;
using System.Collections.Generic;
using System.Text;
using Polyndrom.BLL.Interfaces;
using Polyndrom.BLL.Models;
using Polyndrom.DAL.EntityModels;
using Polyndrom.DAL.EF;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Polyndrom.DAL.Repository
{
    public class UserRepository : IRepository
    {
        private UserContext _context;
        public UserRepository(UserContext context)
        {
            _context = context;

        }
        public  bool CheckLoginPassword(BLLUser blluser)
        {
            var user = _context.Users.Where(user => user.Email == blluser.Email && user.Password == blluser.Password).FirstOrDefault();
            if (user != null) return true;
            return false;
        }
    }
}
