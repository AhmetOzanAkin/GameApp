using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.Entities;

public class Campaign
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal DiscountRate { get; set; } 
    public DateTime StartDate { get; set; } 
    public DateTime EndDate { get; set; } 
}
