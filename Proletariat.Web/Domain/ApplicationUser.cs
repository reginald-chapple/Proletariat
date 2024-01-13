using Proletariat.Web.Infrastructure.Validation;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proletariat.Web.Domain
{
    public class ApplicationUser : IdentityUser<string>
    {
        public virtual Member? Member { get; set; }

        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; } = [];
        public virtual ICollection<UserNotification> Notifications { get; set; } = [];
        public virtual ICollection<ChatUser> Chats { get; set; } = [];
    }
}