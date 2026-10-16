using System.Linq.Expressions;

namespace MultipleInheritance {
    internal class Program {
        static void Main(string[] args) {

            Device epsonPrinter = new NormalPrinter();
            IPrinter brotherPrinter = new NormalPrinter();
            IScanner hpPrinter = new NormalPrinter();


            NormalPrinter goodPrinter = new NormalPrinter();

            System.Console.WriteLine(epsonPrinter.MacAddress);
            epsonPrinter.ProcessDoc("document.txt");


            goodPrinter.ProcessDoc("document.txt");
            System.Console.WriteLine(goodPrinter.MacAddress);
            goodPrinter.ScanDocument("document2.txt");






        }
    }
}
