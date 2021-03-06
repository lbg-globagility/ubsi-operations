using Microsoft.AspNetCore.Identity;
using System;

namespace Ropes.API.Entities.Identity
{
    public class UserRole : IdentityUserRole<string>
    {
        public int UserRoleId { get; set; }

        public string Type { get; set; }

        public int BranchId { get; set; }

        public DateTime CreatedAt { get; private set; }

        public string CreatedById { get; set; }

        public DateTime UpdatedAt { get; private set; }

        public string UpdatedById { get; set; }

        public Role Role { get; set; }
    }
}
