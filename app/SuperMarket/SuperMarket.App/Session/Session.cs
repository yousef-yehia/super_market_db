﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMaker.Database.Models;

namespace SuperMarket.App
{
    public static class Session
    {
        public static User LoggedInUser;
        public static bool IsAdmin;
    }
}
