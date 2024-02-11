namespace Bibliotheque.Entity;

public class Auteur : IEntity
{
    public int Id { get; set; }
    
    public string FirstName { get; set; }
    
    public string Name { get; set; }
}