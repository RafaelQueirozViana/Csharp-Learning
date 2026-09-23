namespace Composition {
    internal class Program {
        static void Main(string[] args) {

            Post firstPost = new Post(DateTime.Now, "Traveling to new Zeeland", "I'm going to visit this wonderful country!", 12);

            Post secondPost = new Post(DateTime.Now, "Good night guys", "I'm going to visit this wonderful country!", 12);

            firstPost.AddComment("Have a nice trip!");
            firstPost.AddComment("Wow that's awesome!");

            secondPost.AddComment("We'll be waiting for the country photos!");

            System.Console.WriteLine("First Post Comments:");

            foreach (Comment comment in firstPost.CommentsList) {
                System.Console.WriteLine(comment.Text);
            }

            System.Console.WriteLine("");

            foreach (Comment comment in secondPost.CommentsList) {
                System.Console.WriteLine("Second Post Comments:");
                System.Console.WriteLine(comment.Text);
            }




        }
    }
}
