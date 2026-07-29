using QuickBite.Models.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickBite
{
    public static class CurrentSession
    {
        public static Users? CurrentUser { get; set; }
        public static bool ActiveSessionExists => CurrentUser != null;

        public static void LogOut()
        {
            CurrentUser = null;
        }
    }
}
