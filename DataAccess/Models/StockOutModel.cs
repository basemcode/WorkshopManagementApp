using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models;

public class StockOutModel
{
    public int StockOutID { get; set; }
    public DateTime Date { get; set; }
    public int UserID { get; set; }
    public string UserFullName { get; set; }
    public string Note { get; set; }
}
