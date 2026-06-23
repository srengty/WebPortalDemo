namespace PortalApi.Models;
public class Attempt
{
    public int Id { get; set; }
    public DateTime AttemptDate { get; set; }
    public virtual List<Question> Questions { get; set; }=[];
    public virtual Exam? Exam { get; set; }
    public virtual User? User { get; set; }
}