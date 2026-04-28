using BO;

namespace BO;

public class Customer
{
    public int ID { get; set; }
    public string? Name { get; set; }
    public string? Address { get; set; }
    public string? Phone { get; set; }
    public bool IsClubMember { get; set; }

    public override string ToString() => this.ToStringProperty();
}