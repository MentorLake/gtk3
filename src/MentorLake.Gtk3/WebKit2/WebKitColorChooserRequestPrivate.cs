namespace MentorLake.WebKit2;


public class WebKitColorChooserRequestPrivateHandle : BaseSafeHandle
{
}


public static class WebKitColorChooserRequestPrivateExtensions
{

	public static WebKitColorChooserRequestPrivate Dereference(this WebKitColorChooserRequestPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitColorChooserRequestPrivate>(x.DangerousGetHandle());
}
internal class WebKitColorChooserRequestPrivateExterns
{
}


public struct WebKitColorChooserRequestPrivate
{
}
