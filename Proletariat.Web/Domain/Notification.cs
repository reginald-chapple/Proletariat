using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proletariat.Web.Domain
{
    public class Notification : Entity
    {
        public long Id { get; set; }
        public string Text { get; set; } = string.Empty;
        public virtual List<UserNotification> Users { get; set; } = [];
    }
}