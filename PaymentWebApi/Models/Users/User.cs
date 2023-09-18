using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using PaymentWebApi.Models;
using PaymentApp;

namespace PaymentWebApi;
public class User : BaseModel
{
    [MaxLength(30)]
    public string FirstName { get; set; } = string.Empty;

    [MaxLength(30)]
    public string LastName { get; set; } = string.Empty;

    public string UserName { get; set; } = string.Empty;

    [MaxLength(13)]
    public string PhoneNumber { get; set; } = string.Empty;

    #region Connection
    public long CardId { get; set; }

    public ICollection<Card> Cards { get; set; }

    #endregion 
}
