
namespace Exceptions {
    public class Person {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public int Rg { get; private set; }

        public Person(string name, int age, int rg) {
            Name = name;
            Age = age;
            Rg = rg;
        }

        public string CheckEntry(List<int> validRgList) {
            int? result = validRgList.Find(rg => rg == Rg);
            if (Age < 18) {
                throw new DomainException("You're younger than 18");
            }

            if (result == null) {
                throw new DomainException("This RG is not valid");
            }

            return "You can be free to join to the party!";


        }

    }

}