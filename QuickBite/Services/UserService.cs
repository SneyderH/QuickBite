using Microsoft.EntityFrameworkCore;
using QuickBite.Context;
using QuickBite.Models.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickBite.Services
{
    public class UserService
    {
        public Users? AuthLogin(string user)
        {
            using var context = new QuickBiteContext();
            return context.Users
                .Include(u => u.Role)
                .FirstOrDefault(u => u.UserName.ToLower() == user.ToLower());
        }   
    }
}
