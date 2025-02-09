﻿using REST.DTOs;
using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.Repositories.Interfaces
{
    public interface IUsersRepo
    {
        public List<users> GetUsers();
        public users ChangePassword(int id, string pass);
        public users Register(UsersDTO users);
    }
}
