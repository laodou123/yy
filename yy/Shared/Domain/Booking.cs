using System.Data;

namespace yy.Shared.Domain
{
    public class Booking : BaseDomianinModel
    {
        public DateTime DateOut { get; set; }
        public DateTime DataIn { get; set; }
        public int VehicleId { get; set; }
        public virtual Vehicle? Vehicle { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }




    }
}