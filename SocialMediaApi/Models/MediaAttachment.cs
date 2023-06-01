namespace SocialMediaApp.Api.Models;

public class MediaAttachment
{
	public int MediaAttachmentId { get; set; }
	public string FileName { get; set; }
	public string ContentType { get; set; }
	public string FilePath { get; set; }

	public int PostId { get; set; }
	public Post Post { get; set; }
}
