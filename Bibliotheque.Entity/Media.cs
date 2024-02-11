using Bibliotheque.Entity;

namespace Database;

public class Media : IEntity
{
    public int Id { get; set; }
    
    public string Label { get; set; }
    
    public string Type { get; set; }
    
    public bool Available { get; set; }
}