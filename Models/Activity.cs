using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bitsoncrmdemo.Models
{
    public class Activity
    {
    public int ActivityId { get; set; }
    public string Type { get; set; }
    public string Subject { get; set; }
    public DateTime ActivityDate { get; set; }
    public int LeadId { get; set; }

    public Lead Lead { get; set; }
    }
}