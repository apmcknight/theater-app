using System;

namespace TheaterApp.Api
{
    public class Customers
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDay { get; set; }

        public DateTime Aniversery { get; set; }

        public int Phone { get; set; }

        public string EMail { get; set; }


        // Cusmoers Physical Address

        public string StreetName { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int PostalCode { get; set; }


        // Customer Alergey Informaiton
        public bool HasAlergey { get; set; }

        public string AlergeyDetails { get; set; }

        public int EmergencyContactNumber { get; set; }



        // Season Ticket Holder
        public bool IsSeasonTicketHolder { get; set; }

        public DateTime SeasonTicketAnivereryDate { get; set; }

    }
}