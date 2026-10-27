namespace MentorLake.WebKit2;


public class WebKitAuthenticationRequestPrivateHandle : BaseSafeHandle
{
}


public static class WebKitAuthenticationRequestPrivateExtensions
{

	public static WebKitAuthenticationRequestPrivate Dereference(this WebKitAuthenticationRequestPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitAuthenticationRequestPrivate>(x.DangerousGetHandle());
}
internal class WebKitAuthenticationRequestPrivateExterns
{
}


public struct WebKitAuthenticationRequestPrivate
{
}
