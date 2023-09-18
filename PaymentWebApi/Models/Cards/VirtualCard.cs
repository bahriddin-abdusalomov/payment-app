using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaymentApp;
public class VirtualCard
{
    public long Id { get; set; }

    [MaxLength(16)]
    public string CardNumber { get; set; } = string.Empty;

    public double CardBalans { get; set; }

    public DateTime CreatedAt { get; set; }

}
