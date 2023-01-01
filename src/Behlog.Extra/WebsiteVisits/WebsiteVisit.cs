namespace Behlog.Extra;

/// <summary>
/// Keep tracks of Website's Visitor Statistics.
/// </summary>
public class WebsiteVisit : BehlogEntity<long>
{
    private WebsiteVisit() { }
    
    #region props
    
    public Guid WebsiteId { get; protected set; }
    public string Url { get; protected set; }
    public string IpAddress { get; protected set; }
    public string? Referer { get; protected set; }
    public string? UserAgent { get; protected set; }
    public string? ExtraInfo { get; protected set; }
    
    #endregion
}