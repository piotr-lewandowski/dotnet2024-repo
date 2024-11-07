using System.ComponentModel.DataAnnotations;

namespace Data;


public record User 
{
    [Key]
    public int Id { get; init; }
    public string Username { get; init; }
    public IEnumerable<Comment> Comments { get; init; }
}