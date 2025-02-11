using System;

namespace KaracadanWebApp.Core.Domain
{
    public partial class Expence : BaseEntity
    {
        public int SupplierId { get; set; }
        public string Title { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string Note { get; set; }
        public int Status { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public int EmployeeId { get; set; }
        public int CreatorId { get; set; }
        public PaymentStatus PaymentStatus
        {
            get => (PaymentStatus)Status;
            set => Status = (int)value;
        }
    }
}
