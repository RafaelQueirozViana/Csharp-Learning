namespace RoomReservation {
    internal class ClientRegister {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public int Age { get; private set; }

        public ClientRegister(string name, string email, int age) {
            Name = name;
            Email = email;
            Age = age;
        }



    }
}
