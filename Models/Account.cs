using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bitsoncrmdemo.Models
{
    public class Account
    {
    public int AccountId { get; set; }
    public string AccountName { get; set; }
    public string Industry { get; set; }
    public string Website { get; set; }
    public string Phone { get; set; }

    public ICollection<Lead> Leads { get; set; }
    public ICollection<Deal> Deals { get; set; }
    }
}