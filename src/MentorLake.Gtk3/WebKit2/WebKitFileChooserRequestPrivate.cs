namespace MentorLake.WebKit2;


public class WebKitFileChooserRequestPrivateHandle : BaseSafeHandle
{
}


public static class WebKitFileChooserRequestPrivateExtensions
{

	public static WebKitFileChooserRequestPrivate Dereference(this WebKitFileChooserRequestPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitFileChooserRequestPrivate>(x.DangerousGetHandle());
}
internal class WebKitFileChooserRequestPrivateExterns
{
}


public struct WebKitFileChooserRequestPrivate
{
}
