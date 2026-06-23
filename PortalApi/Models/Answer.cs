namespace PortalApi.Models;
public class Answer
{
    public int Id { get; set; }
    public string AnswerText { get; set; }="";
    public double Weight { get; set; }
    public virtual Question? Question{get;set;}
}