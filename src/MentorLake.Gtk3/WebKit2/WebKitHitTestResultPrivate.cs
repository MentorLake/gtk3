namespace MentorLake.WebKit2;


public class WebKitHitTestResultPrivateHandle : BaseSafeHandle
{
}


public static class WebKitHitTestResultPrivateExtensions
{

	public static WebKitHitTestResultPrivate Dereference(this WebKitHitTestResultPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitHitTestResultPrivate>(x.DangerousGetHandle());
}
internal class WebKitHitTestResultPrivateExterns
{
}


public struct WebKitHitTestResultPrivate
{
}
