namespace FilesManager;

class Program {
    static void Main() {
        string sourcePath = "/home/arch/Documentos/text.txt";
        string targetPath = "/home/arch/Documentos/text2.txt";

        try {
            FileInfo fileInfo = new FileInfo(sourcePath);
            fileInfo.CopyTo(targetPath);
        }

        catch (IOException e) {
            System.Console.WriteLine("Unexpected error: " + e.Message);
        }

    }
}