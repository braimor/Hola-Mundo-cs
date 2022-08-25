public class Review{
    public Review( 
        int Grade,
        string Comment)
    {
        Grade = Grade;
        Comment = Comment;
    }

    public int Grade { get; }
    public string Comment { get; }
}