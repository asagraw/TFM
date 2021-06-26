using System;
using System.Collections.Generic;

namespace Domain
{
    public class Fundraiser
    {
        public Guid Id { get; set; }
        public string Name { get; set; }    
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public decimal TargetAmount { get; set; }
        public decimal CurrentAmount { get; set; }
        public List<Contributor> Contributors { get; set; }
    }
}