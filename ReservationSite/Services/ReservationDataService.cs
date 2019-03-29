using ReservationSite.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationSite.Services
{
    public interface IReservationDataService
    {
        Reservation GetReservation(Guid Id);
        IQueryable<Reservation> GetReservationAll();
        Reservation AddReservation(Reservation reservation);
        bool RemoveReservation(Reservation reservation);
        bool UpdateReservation(Reservation reservation);
    }


    public class ReservationSQLService : IReservationDataService
    {
        private readonly ReservationsDbContext dbContext;

        public ReservationSQLService(ReservationsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Reservation AddReservation(Reservation reservation)
        {
            throw new NotImplementedException();
        }

        public Reservation GetReservation(Guid Id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Reservation> GetReservationAll()
        {
            var data = (from Reservation in dbContext.Reservations select Reservation);
            return data;
        }

        public bool RemoveReservation(Reservation reservation)
        {
            throw new NotImplementedException();
        }

        public bool UpdateReservation(Reservation reservation)
        {
            throw new NotImplementedException();
        }
    }
}
