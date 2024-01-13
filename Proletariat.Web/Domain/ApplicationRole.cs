#nullable disable
using Microsoft.AspNetCore.Identity;

namespace Proletariat.Web.Domain
{
    public class ApplicationRole : IdentityRole
    {
        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
