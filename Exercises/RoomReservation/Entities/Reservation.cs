namespace RoomReservation.Entities
{
    public class Reservation
    {
        public int RoomNumber { get; private set; }
        public DateTime Checkin { get; private set; }
        public DateTime Checkout { get; private set; }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            RoomNumber = roomNumber;
            Checkin = checkin;
            Checkout = checkout;
        }

        public int GetDuration()
        {
            return (Checkout - Checkin).Days;
        }

        public void UpdateDates(DateTime newCheckin, DateTime newCheckout)
        {
            Checkin = newCheckin;
            Checkout = newCheckout;
        }

        public string GetReservationInfo()
        {
            return $"Room number {RoomNumber}: checkin: {Checkin} until checkout: {Checkout} ({GetDuration()} days)";
        }
    }

}