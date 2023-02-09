using ELibrary.Models;
using ELibrary.Interface;
using ELibrary.ViewModel;

namespace ELibrary.Services

{
    public class ReservationServices : IReservationServices
    {
        private readonly LibraryDbContext _context;

        public ReservationServices(LibraryDbContext context)
        {
            _context = context;
        }
        public Book GetBookById(int Id)
        {

            return _context.Books.FirstOrDefault(s => s.BookId == Id);

        }
        public bool HasBookAlreadyRezervation(int Id)
        {
            var existingRezervation = _context.Reservations.FirstOrDefault(a => a.ReservationId == Id);
            return existingRezervation != null;
        }


        public void Add(ReservationViewModel reservation)
        {
            var book = GetBookById(reservation.BookId);
            if (book == null)
            {
                throw new BookNotFoundException("You can't Reservation!");
            }
            var isAlreadyReservation = _context.Reservations.Any(a => a.BookId == reservation.BookId);
            if (isAlreadyReservation)
            {
                throw new BookNotFoundException("You have already Reservation.");
            }
            var _reservation = new Reservation()
            {
                RezervationData = reservation.RezervationData,
                RezervationStatus = reservation.RezervationStatus,
                BookId = reservation.BookId,
                MemberId = reservation.MemberId
            };
            _context.Reservations.Add(_reservation);
            _context.SaveChanges();
        }
        public List<Reservation> Get() => _context.Reservations.ToList();
        public Reservation GetById(int ReservationId) => _context.Reservations.FirstOrDefault(n => n.ReservationId == ReservationId);

        public Reservation UpdatebyId(int ReservationId, ReservationViewModel reservation)
        {
            var _reservation = _context.Reservations.FirstOrDefault(n => n.ReservationId == ReservationId);
            if (_reservation != null)
            {
                _reservation.RezervationData = reservation.RezervationData;
                _reservation.RezervationStatus = reservation.RezervationStatus;
                _reservation.BookId = reservation.BookId;
                _reservation.MemberId = reservation.MemberId;

                _context.SaveChanges();
            }
            return _reservation;
        }
        public void DeleteReservation(int id)
        {
            var _reservation = _context.Reservations.FirstOrDefault(x => x.ReservationId == id);
            if (_reservation != null)
            {
                _context.Reservations.Remove(_reservation);
                _context.SaveChanges();
            }
        }
    }
}
