namespace MentorLake.WebKit2;


public class WebKitGeolocationManagerPrivateHandle : BaseSafeHandle
{
}


public static class WebKitGeolocationManagerPrivateExtensions
{

	public static WebKitGeolocationManagerPrivate Dereference(this WebKitGeolocationManagerPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitGeolocationManagerPrivate>(x.DangerousGetHandle());
}
internal class WebKitGeolocationManagerPrivateExterns
{
}


public struct WebKitGeolocationManagerPrivate
{
}
