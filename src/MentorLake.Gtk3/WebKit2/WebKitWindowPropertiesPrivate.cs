namespace MentorLake.WebKit2;


public class WebKitWindowPropertiesPrivateHandle : BaseSafeHandle
{
}


public static class WebKitWindowPropertiesPrivateExtensions
{

	public static WebKitWindowPropertiesPrivate Dereference(this WebKitWindowPropertiesPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitWindowPropertiesPrivate>(x.DangerousGetHandle());
}
internal class WebKitWindowPropertiesPrivateExterns
{
}


public struct WebKitWindowPropertiesPrivate
{
}
