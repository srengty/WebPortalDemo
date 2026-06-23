namespace PortalApi.Models;
public class Question
{
    public int Id { get; set; }
    public string QuestionText { get; set; }="";
    public virtual List<Answer> Answers { get; set; }=[];
    public List<int> CorrectAnswerIds { get; set; }=[];
    public virtual Exam? Exam { get; set; }
}