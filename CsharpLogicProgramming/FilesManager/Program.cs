namespace FilesManager;

class Program {
    static void Main() {

        /* Using FileStream and StreamReader */
        /* Using these functionalities, the c# will really open the file and be able to read and edit anything, execulting the really OS operations to do it */
        /* At the end, it will be necessary to close the file, because if not, the dotnet will still keep the file open. */

        string sourcePath = "/home/arch/Documentos/text.txt";


        FileStream fs = null;
        StreamReader sr = null;
        try {
            fs = new FileStream(sourcePath, FileMode.Open);
            sr = new StreamReader(fs);

            string line = sr.ReadLine();
        }

        catch (IOException e) {
            System.Console.WriteLine("Unexpected error: " + e.Message);
        }

        finally {
            if (fs != null) fs.Close();
            if (sr != null) sr.Close();
        }




        /* The simple method to get some informations of the file: */
        /* Usign the FileInfo, the system isn't really passing and openning the file to read, it just is looking to the file from outside and can be able to get just some informations */
        /*       try {
                  FileInfo fileInfo = new FileInfo(sourcePath);
                  fileInfo.CopyTo(targetPath);

                  string[] lines = File.ReadAllLines(sourcePath);

                  foreach (string line in lines) {
                      System.Console.WriteLine(line);
                  }
              }

              catch (IOException e) {
                  System.Console.WriteLine("Unexpected error: " + e.Message);
              } */

    }
}