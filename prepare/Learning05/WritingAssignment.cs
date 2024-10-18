public class WritingAssignment : Assignment
{
    private string _essayTitle;

    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _essayTitle = title;
    }

    public string getWritingInformation()
    {
        string studentName = getStudentName();

        return $"{_essayTitle} by {studentName}";
    }
}