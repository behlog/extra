using Behlog.Core.Contracts;

namespace Behlog.Extra.Links;

/// <summary>
/// Represents a Link to another Url in the internet with it's metadata.
/// </summary>
public class Link : AggregateRoot<Guid>, IHasMetadata
{
    private Link() { }

    #region props

    public string Url { get; protected set; }
    public string Title { get; protected set; }
    public string? ImagePath { get; protected set; }
    public string? Target { get; protected set; }
    public string? Description { get; protected set; }
    
    
    #endregion

    public DateTime CreatedDate { get; }
    public DateTime? LastUpdated { get; }
    public string CreatedByUserId { get; }
    public string LastUpdatedByUserId { get; }
    public string CreatedByIp { get; }
    public string LastUpdatedByIp { get; }
}