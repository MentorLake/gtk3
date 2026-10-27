namespace MentorLake.WebKit2;


public class WebKitPluginPrivateHandle : BaseSafeHandle
{
}


public static class WebKitPluginPrivateExtensions
{

	public static WebKitPluginPrivate Dereference(this WebKitPluginPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitPluginPrivate>(x.DangerousGetHandle());
}
internal class WebKitPluginPrivateExterns
{
}


public struct WebKitPluginPrivate
{
}
