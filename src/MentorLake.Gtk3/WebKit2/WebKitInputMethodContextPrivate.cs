namespace MentorLake.WebKit2;


public class WebKitInputMethodContextPrivateHandle : BaseSafeHandle
{
}


public static class WebKitInputMethodContextPrivateExtensions
{

	public static WebKitInputMethodContextPrivate Dereference(this WebKitInputMethodContextPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitInputMethodContextPrivate>(x.DangerousGetHandle());
}
internal class WebKitInputMethodContextPrivateExterns
{
}


public struct WebKitInputMethodContextPrivate
{
}
