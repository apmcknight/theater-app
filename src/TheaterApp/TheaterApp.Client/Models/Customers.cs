using System;
namespace TheaterApp.Client.Models
{
    public class Customers
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMailAddress { get; set; }
        public string MailingAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PhoneNumber { get; set; }
        public string SeatingPreference { get; set; }
        public bool IsSeasonTicketHolder { get; set; }
        public bool HasFoodAlergey { get; set; }
        public string FoodAlergey { get; set; }
        public string EmergencyContactFullName { get; set; }
        public int EmergencyContactPhone { get; set; }
    }
}
