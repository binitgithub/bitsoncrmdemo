using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bitsoncrmdemo.Models
{
    public class Deal
    {
    public int DealId { get; set; }
    public string DealName { get; set; }
    public decimal Amount { get; set; }
    public string Stage { get; set; }
    public DateTime CloseDate { get; set; }
    public int LeadId { get; set; }
    public int AccountId { get; set; }

    public Lead Lead { get; set; }
    public Account Account { get; set; }
    }
}