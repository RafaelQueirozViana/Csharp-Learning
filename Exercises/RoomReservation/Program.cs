using RoomReservation.Entities;

namespace RoomReservation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("=== Create a reservation ===");

            System.Console.Write("Type the room: ");
            int room = int.Parse(Console.ReadLine());

            System.Console.Write("Checkin date: ");
            DateTime checkin = DateTime.Parse(Console.ReadLine());

            System.Console.Write("Checkout date: ");
            DateTime checkout = DateTime.Parse(Console.ReadLine());

            if (checkout <= checkin)
            {
                System.Console.WriteLine("Error: the checkout can't be earlier than the checkin date");
            }

            else
            {
                Reservation reservation = new Reservation(room, checkin, checkout);
                System.Console.WriteLine(reservation.GetReservationInfo());

                System.Console.WriteLine("=== Update your reservation date ===");
                System.Console.WriteLine("");

                System.Console.Write("New checkin:");
                checkin = DateTime.Parse(Console.ReadLine());

                System.Console.Write("New checkout:");
                checkout = DateTime.Parse(Console.ReadLine());


                DateTime now = DateTime.Now;

                if (checkin < now || checkout < now)
                {
                    System.Console.WriteLine("Error: the new date can't be before today");
                }

                else
                {
                    reservation.UpdateDates(checkin, checkout);
                    System.Console.WriteLine(reservation.GetReservationInfo());
                }



            }











        }

    }
}


