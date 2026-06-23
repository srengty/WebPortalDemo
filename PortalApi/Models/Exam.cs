namespace PortalApi.Models;
public class Exam
{
    public int Id { get; set; }
    public string Title { get; set; }="";
    public DateTime DateStart { get; set; }
    public DateTime DateEnd { get; set; }
    public virtual List<Question> Questions { get; set; }=[];
    public virtual List<Attempt> Attempts { get; set; }=[];
}