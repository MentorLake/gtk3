namespace MentorLake.WebKit2;


public class WebKitContextMenuItemPrivateHandle : BaseSafeHandle
{
}


public static class WebKitContextMenuItemPrivateExtensions
{

	public static WebKitContextMenuItemPrivate Dereference(this WebKitContextMenuItemPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitContextMenuItemPrivate>(x.DangerousGetHandle());
}
internal class WebKitContextMenuItemPrivateExterns
{
}


public struct WebKitContextMenuItemPrivate
{
}
