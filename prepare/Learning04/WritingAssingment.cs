public class WritingAssignment : Assingment
{
    private string _title;
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        // Here we set the MathAssignment specific variables
        _title = title;
    }
    public string GetWritingInformation()
    {
         string studentName = GetStudentName();
        return $"Title: {_title} by {studentName}";
    }
}