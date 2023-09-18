using Microsoft.EntityFrameworkCore;
using PaymentWebApi;
using PaymentWebApi.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaymentApp;
public class Card : BaseModel
{

    [MaxLength(16)]
    public string CardNumber { get; set; } = string.Empty;

    [MaxLength(4)]
    public string CardPassword { get; set; } = string.Empty;

    public double CardBalans { get; set; }

    public DateOnly ExpirationDate { get; set; }

    public DateTime CreatedAt { get; set; }

    #region Connection
    public long VirtualCardId { get ; set; }
    public VirtualCard VirtualCards { get; set; }

    public long PaymentId { get; set; }
    public ICollection<Payment> Payments { get; set; }

    #endregion

}

