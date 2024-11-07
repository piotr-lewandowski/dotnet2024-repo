namespace Data;

public record Comment(
    int Id,
    string Author, 
    string Text, 
    int Likes,
    int Dislikes,
    DateTime PostedAt
);