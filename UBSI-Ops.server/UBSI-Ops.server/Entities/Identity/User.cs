﻿using Microsoft.AspNetCore.Identity;

namespace UBSI_Ops.server.Entities.Identity
{
    public class User : IdentityUser<int>
    {
        public string UserId { get; set; }

        public string Password { get; set; }

        public string EnrolledOn { get; set; }

        public string LockedOn { get; set; }

        public string Name { get; set; }

    }
}
