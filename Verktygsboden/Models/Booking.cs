
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Verktygsboden.Models;
public class Booking
{
    public int Id { get; set; }

    [DisplayName("Noteringar")]
    public string Notes { get; set; }

    [DisplayName("Från datum")]
    [DataType(DataType.Date)]
    public DateTime FromTime { get; set; }

    [DisplayName("Till datum")]
    public DateTime ToTime { get; set; }

    public virtual Asset? Asset { get; set; }
    public int AssetId { get; set; }
    public virtual User? User { get; set; }
    public int UserId { get; set; }

}
