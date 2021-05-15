using System;
using System.Collections.Generic;

namespace TheaterApp.Employee.Models
{
    public class Reservation
    {
        public int ID { get; set; }
        public string ReservationShow { get; set; }
        public string ReservationDate { get; set; }
        public string ReservationTime { get; set; }
        public bool IsGroupSale { get; set; }
        public int ReservationGuestAmount { get; set; }
        public string ReservationGuestNames { get; set; }
        public string ReservationGuestAlergey { get; set; }
        public string ReservationSeatingPreference { get; set; }
        public string ReservationCustomerName { get; set; }
        public bool AddBirthdayPackage { get; set; }
        public bool AddAnniversaryPackage { get; set; }
        public bool WasReservationPrePaid { get; set; }
        public string ReservationPaymentDetails { get; set; }
    }
}