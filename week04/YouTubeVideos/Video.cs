// _title : string
// _author : string
// _lengthInSeconds : int
// _comments : List<Comment>
// Video(title : string, author : string, lengthInSeconds : int)
// AddComment(comment : Comment) : void
// GetCommentCount() : int

class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments;

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }
}