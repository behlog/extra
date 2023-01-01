namespace Behlog.Extra.Commands;

public class ReplyToContactMessageCommand : IBehlogCommand<CommandResult>
{
    public ReplyToContactMessageCommand(Guid contactMessageId, string replyMessage)
    {
        contactMessageId.ThrowIfGuidIsEmpty(
            new BehlogInvalidEntityIdException(nameof(ContactMessage)));

        if (replyMessage.IsNullOrEmptySpace())
            throw new ArgumentNullException(nameof(replyMessage));
        
        Id = contactMessageId;
        ReplyMessage = replyMessage;
    }
    
    public Guid Id { get; }
    public string ReplyMessage { get; }
}