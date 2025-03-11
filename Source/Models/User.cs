namespace AISmartCodeWithCSharp14.Models;

public record User
{
    public Guid Id { get; init; }
    public string FirstName { get; init; } = string.Empty;
    public string LastName { get; init; } = string.Empty;
    public string EmailAddress { get; init; } = string.Empty;
    public DateTime DateOfBirth { get; init; }
    public string TelephoneNumber { get; init; }=string.Empty;
    public DateTime CreatedAt { get; init; }

    public string FullName => $"{FirstName} {LastName}";
    public string FullDetials => $"{FullName} ({DateOfBirth}) ({EmailAddress}) ({TelephoneNumber})";
}