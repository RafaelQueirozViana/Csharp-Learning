public class Post {
    public DateTime Moment;
    public string Title;
    public string Content;
    public int Likes;

    public List<Comment> CommentsList { get; private set; } = [];

    public Post(DateTime date, string title, string description, int likes) {
        Moment = date;
        Title = title;
        Content = description;
        Likes = likes;
    }

    public void AddComment(string commentText) {
        CommentsList.Add(new Comment(commentText));
    }
}