﻿using Microsoft.AspNetCore.Identity;

namespace WebApp.Data.Domain
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
