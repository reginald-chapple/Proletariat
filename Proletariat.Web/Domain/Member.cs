using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Proletariat.Web.Infrastructure.Validation;

namespace Proletariat.Web.Domain;

public class Member : Entity
{
    public long Id { get; set; }

    [Display(Name = "Full Name")]
    [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 4)]
    public string FullName { get; set; } = string.Empty;

    public string Image { get; set; } = string.Empty;

    [NotMapped]
    [PhotoExtension]
    public IFormFile? ImageUpload { get; set; }

    public MemberType Type { get; set; } = MemberType.Registered;

    public string UserId { get; set; } = string.Empty;
    public virtual ApplicationUser? User { get; set; }

    public long? GroupId { get; set; }
    public virtual LocalGroup? Group { get; set; }
}

public enum MemberType
{
    [Description("Registered")]
    Registered,
    [Description("Member")]
    Member,
    [Description("Local Lead")]
    LocalLead,
    [Description("National Administrator")]
    NationalAdministrator
}