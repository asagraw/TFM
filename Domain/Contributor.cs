using System;

namespace Domain
{
    public class Contributor
    {
        public Guid Id { get; set; }
        public Guid FundraiserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public decimal Donation { get; set; }
        public DateTime DateOfDonation { get; set; }
        public string Comment { get; set; }
    }
}