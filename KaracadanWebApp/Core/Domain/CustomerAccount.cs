namespace KaracadanWebApp.Core.Domain
{
    public class CustomerAccount: BaseEntity
    {
        public int CustomerId{ get; set; }
        public string Title { get; set; }
        public string Number { get; set; }
    }
}
