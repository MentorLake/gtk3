namespace MentorLake.WebKit2;


public class WebKitClipboardPermissionRequestClassHandle : BaseSafeHandle
{
}


public static class WebKitClipboardPermissionRequestClassExtensions
{

	public static WebKitClipboardPermissionRequestClass Dereference(this WebKitClipboardPermissionRequestClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitClipboardPermissionRequestClass>(x.DangerousGetHandle());
}
internal class WebKitClipboardPermissionRequestClassExterns
{
}


public struct WebKitClipboardPermissionRequestClass
{
	
public GObjectClass parent_class;
}
