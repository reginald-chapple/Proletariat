﻿using Microsoft.AspNetCore.Identity;

namespace Proletariat.Web.Domain
{
    public class ApplicationUserRole : IdentityUserRole<string>
    {
        public virtual ApplicationUser? User { get; set; }
        public virtual ApplicationRole? Role { get; set; }
    }
}
