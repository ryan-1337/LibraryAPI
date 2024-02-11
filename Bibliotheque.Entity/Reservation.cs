namespace Bibliotheque.Entity;

public class Reservation : IEntity
{
    public int Id { get; set; }
    
    public int IdClient { get; set; }
    
    public int IdMedia { get; set; }
    
    public DateTime StartingDate { get; set; }
    
    public DateTime EndingDate { get; set; }
}