using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proletariat.Web.Domain
{
    public class ChatMessage : Entity
    {
        public long Id { get; set; }

        [DataType(DataType.Text)]
        public string Content { get; set; } = string.Empty;

        public string AuthorId { get; set; } = string.Empty;
        public virtual ApplicationUser? Author { get; set; }

        public long ChatId { get; set; }
        public virtual Chat? Chat { get; set; }
    }
}
