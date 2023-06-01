namespace SocialMediaApp.Api.Models;

public class Media
{
	public int MediaId { get; set; }
	public int PostId { get; set; }
	public string FileName { get; set; }
	public string FilePath { get; set; }
	public string MediaType { get; set; }
	public DateTime Timestamp { get; set; }
}
