public class NormalPrinter : Device, IScanner, IPrinter {

    public override void ProcessDoc(string document) {
        System.Console.WriteLine($"Document processed:{document}");
    }

    public void ScanDocument(string document) {
        System.Console.WriteLine($"{document} scanned");
    }

    public void PrintDocument(string document) {
        System.Console.WriteLine("{document} printed!");
    }

}