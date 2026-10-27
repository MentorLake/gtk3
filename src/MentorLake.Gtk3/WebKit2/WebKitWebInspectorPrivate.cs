namespace MentorLake.WebKit2;


public class WebKitWebInspectorPrivateHandle : BaseSafeHandle
{
}


public static class WebKitWebInspectorPrivateExtensions
{

	public static WebKitWebInspectorPrivate Dereference(this WebKitWebInspectorPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitWebInspectorPrivate>(x.DangerousGetHandle());
}
internal class WebKitWebInspectorPrivateExterns
{
}


public struct WebKitWebInspectorPrivate
{
}
