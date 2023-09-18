using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaymentApp;
public class Payment
{
    public long Id { get; set; }    

    public double Amount { get; set; }

    public double Cashback { get; set; }

    public double ServicePrice { get; set; }

    [MaxLength(16)]
    public string CardNumber { get; set; } = string.Empty;

    [MaxLength(4)]
    public string CardPassword { get; set; } = string.Empty;

}
