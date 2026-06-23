namespace PortalApi.Models;
public class User
{
    public int Id { get; set; }
    public string Username { get; set; }="";
    public string PasswordHash { get; set; }="";
    public string Role { get; set; }="User";
    public virtual List<Attempt> Attempts { get; set; }=[];
}