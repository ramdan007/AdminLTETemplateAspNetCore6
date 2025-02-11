using System;

namespace KaracadanWebApp.Core.Domain
{
    public partial class Transaction : BaseEntity
    {
        public string SerialNumber { get; set; }
        public int CustomId { get; set; }
        public int CustomerId { get; set; }
        public string AccountNumber { get; set; }
        public int AccountId { get; set; }
        public int AmountUsd { get; set; }
        public int Amount { get; set; }
        public int Method { get; set; }
        public string ReferenceNumber { get; set; }
        public string Currency { get; set; }
        public int Status { get; set; }
        public int Type { get; set; }
        public string TransactionId { get; set; }
        public string Note { get; set; }
        public PaymentStatus PaymentStatus
        {
            get => (PaymentStatus)Status;
            set => Status = (int)value;
        }

        public TransactionType TransactionType
        {
            get => (TransactionType)Type;
            set => Type = (int)value;
        }

        public PaymentMethod PaymentMethod
        {
            get => (PaymentMethod)Method;
            set => Method = (int)value;
        }

        public int BranchId { get; set; }

        public Branch Branch
        {
            get => (Branch)BranchId;
            set => BranchId = (int)value;
        }
        public DateTime CreatedOnUtc { get; set; }
        public int CreatorId { get; set; }

    }
}
