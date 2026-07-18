namespace RoomReservation {
    internal class Program {
        static void Main(string[] args) {
            int totalHotelRooms = 10;

            ClientRegister[] roomsArray = new ClientRegister[totalHotelRooms];




            Console.WriteLine("Welcome to our hotel!");
            Console.WriteLine("For how many people do you wanna make a reservation?");
            int reservationsNum = int.Parse(Console.ReadLine());

            for (int i = 1; i <= reservationsNum; i++) {

                bool verifyError = true;

                while (verifyError == true) {
                    verifyError = false;

                    Console.WriteLine("-----------");
                    Console.WriteLine($"Person {i} reservation");

                    Console.WriteLine($"Make the register:");

                    Console.WriteLine("Provide the name:");
                    string name = Console.ReadLine();

                    Console.WriteLine("Provide the email:");
                    string email = Console.ReadLine();

                    Console.WriteLine("Provide the age:");
                    int age = int.Parse(Console.ReadLine());

                    Console.WriteLine($"These are the available rooms:");
                    showAvailableRooms(roomsArray);


                    Console.WriteLine($"Choose the room:");
                    int choosedRoom = int.Parse(Console.ReadLine());

                    string result = makeReservation(roomsArray, new ClientRegister(name, email, age), choosedRoom);

                    Console.WriteLine(roomsArray[2]);

                    if (result != "") {
                        verifyError = true;
                        Console.WriteLine(result);
                    }

                    else {
                        Console.WriteLine($"The reservation for {name} was sucessfull made in the room {choosedRoom}");
                    }
                }
            }

        }

        static void showAvailableRooms(ClientRegister[] array) {
            for (int i = 0; i < array.Length; i++) {
                if (array[i] == null) {
                    Console.Write($"{i}; ");

                }
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }


        static string makeReservation(ClientRegister[] array, ClientRegister clientData, int choosedRoom) {
            string statusMessage = "";

            if (!(choosedRoom >= 0 && choosedRoom <= 10)) {
                statusMessage = "Enter a valid number";
            }

            else if (array[choosedRoom] != null) {
                statusMessage = "The choosed room is already reserved";
            }

            else {
                array[choosedRoom] = clientData;
            }

            return statusMessage;
        }

    }
}
