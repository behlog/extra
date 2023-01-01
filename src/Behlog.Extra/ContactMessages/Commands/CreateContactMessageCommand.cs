namespace Behlog.Extra.Commands;

public class CreateContactMessageCommand : IBehlogCommand<CommandResult<ContactMessageResult>>
{
    public Guid WebsiteId { get; set; }
    public string AuthorName { get; set; }
    public string? Subject { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
    public string? Website { get; set; }
    public string Message { get; set; }
}