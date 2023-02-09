using ELibrary.ViewModel;
using ELibrary.Models;

namespace ELibrary.Interface
{
    public interface IReservationServices
    {
     
        public void Add(ReservationViewModel reservation);
        public Reservation GetById(int ReservationId);
        public Reservation UpdatebyId(int ReservationId, ReservationViewModel rezervation);
        public void DeleteReservation(int id);
        public List<Reservation> Get();

    }
}
