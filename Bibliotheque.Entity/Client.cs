using System.ComponentModel.DataAnnotations;

namespace Bibliotheque.Entity;

public class Client : IEntity
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string Name { get; set; }

    [EmailAddress]
    public string Mail { get; set; }

    [Phone]
    public string Phone { get; set; }

    [DataType(DataType.Password)]
    public string Password { get; set; }    
}