namespace MentorLake.WebKit2;


public class WebKitContextMenuPrivateHandle : BaseSafeHandle
{
}


public static class WebKitContextMenuPrivateExtensions
{

	public static WebKitContextMenuPrivate Dereference(this WebKitContextMenuPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitContextMenuPrivate>(x.DangerousGetHandle());
}
internal class WebKitContextMenuPrivateExterns
{
}


public struct WebKitContextMenuPrivate
{
}
