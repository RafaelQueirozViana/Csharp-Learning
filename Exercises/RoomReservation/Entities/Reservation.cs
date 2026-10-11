namespace RoomReservation.Entities
{
    public class Reservation
    {
        public int RoomNumber { get; private set; }
        public DateTime Checkin { get; private set; }
        public DateTime Checkout { get; private set; }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;

            if (checkout < checkin)
            {
                throw new DomainException("The checkout date can't be earlier than the checkout");
            }

            if (checkin < now || checkout < now)
            {
                throw new DomainException("Error, the new date can't be before today");
            }

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
            DateTime now = DateTime.Now;

            if (newCheckin < now || newCheckout < now)
            {
                throw new DomainException("Error, the new date can't be before today");
            }

            if (Checkout <= Checkin)
            {
                throw new DomainException("Check-out date must be ");
            }

            Checkin = newCheckin;
            Checkout = newCheckout;
        }

        public string GetReservationInfo()
        {
            return $"Room number {RoomNumber}: checkin: {Checkin} until checkout: {Checkout} ({GetDuration()} days)";
        }
    }

}