using ELibrary.Interface;
using Microsoft.AspNetCore.Mvc;
using ELibrary.Models;
using ELibrary.Services;
using ELibrary.ViewModel;
namespace ELibrary.Controller
{
    public class ReservationController :ControllerBase
    {
        private readonly IReservationServices _reservationServices;

        public ReservationController(IReservationServices reservationServices)
        {
            _reservationServices = reservationServices;
        }

        [HttpPost("addReservation")]
        public IActionResult Add(ReservationViewModel reservation)
        {
            try
            {
                _reservationServices.Add(reservation);
                return Ok("Reservation submitted successfully.");
            }
            catch (BookNotFoundException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (BookAlreadyRezervationException ex)
            {
                return BadRequest(ex.Message);

            }

        }

        [HttpGet]
        public IActionResult Get()
        {
            var allReservation = _reservationServices.Get();
            return Ok(allReservation);

        }

        [HttpGet("get-by-id /{ReservationId}")]
        public IActionResult GetById(int id)
        {
            var _reservation = _reservationServices.GetById(id);
            return Ok(_reservation);
        }

        [HttpPut("update-by-id/{ReservationId}")]
        public IActionResult UpdateById(int reservationId, [FromBody] ReservationViewModel reservation)
        {
            var updateReservation = _reservationServices.UpdatebyId(reservationId, reservation);
            return Ok(updateReservation);
        }

        [HttpDelete("delete-Borrow/{id}")]
        public IActionResult DeleteReservation(int id)
        {
            _reservationServices.DeleteReservation(id);
            return Ok();
        }
    }
}

