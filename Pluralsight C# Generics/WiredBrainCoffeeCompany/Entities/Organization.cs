namespace WiredBrainCoffeeCompany.Entites
{
    public class Organization : EntityBase
    {
        public string? Name { get; set; }

        public override string ToString() => $"Id: {this.Id}, Name: {this.Name}";
    }
}