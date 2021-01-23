using System;
using System.Collections.Generic;
using System.Text;
using Polyndrom.BLL.Models;

namespace Polyndrom.BLL.Interfaces
{
    public interface IRepository
    {
        public bool CheckLoginPassword(BLLUser user) ;
    }
}
