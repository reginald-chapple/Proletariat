using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Proletariat.Web.Domain;

public class Organization : Entity
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    [DataType(DataType.Text)]
    public string About { get; set; } = string.Empty;

    public List<string> Sectors { get; set; } = [];

    public string AdministratorId { get; set; } = string.Empty;
    public virtual ApplicationUser? Administator { get; set; }

    public ICollection<LocalGroup> Groups { get; set; } = [];
}
