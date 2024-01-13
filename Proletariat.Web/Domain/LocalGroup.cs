namespace Proletariat.Web.Domain;

public class LocalGroup : Entity
{
    public long Id { get; set; }

    public string Name { get; set; } = string.Empty;
    
    public long OrganizationId { get; set; }
    public virtual Organization? Organization { get; set; }

    public ICollection<Member> Members { get; set; } = [];
}