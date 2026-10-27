namespace MentorLake.WebKit2;


public class WebKitDownloadPrivateHandle : BaseSafeHandle
{
}


public static class WebKitDownloadPrivateExtensions
{

	public static WebKitDownloadPrivate Dereference(this WebKitDownloadPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitDownloadPrivate>(x.DangerousGetHandle());
}
internal class WebKitDownloadPrivateExterns
{
}


public struct WebKitDownloadPrivate
{
}
