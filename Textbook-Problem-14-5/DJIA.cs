using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbook_Problem_14_5;

internal class DJIA
{
    // PROPERTIES
    public DateTime Date { get; set; }
    public decimal ClosingValue { get; set; }
    public decimal OpeningValue { get; set; }
    public decimal HighValue { get; set; }
    public decimal LowValue { get; set; }

    // CONSTRUCTOR
    public DJIA(DateTime date, decimal closing, decimal opening, decimal high, decimal low)
    {
        Date = date;
        ClosingValue = closing;
        OpeningValue = opening;
        HighValue = high;
        LowValue = low;
    }
}
