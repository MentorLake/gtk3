namespace MentorLake.WebKit2;


public class WebKitPrintCustomWidgetPrivateHandle : BaseSafeHandle
{
}


public static class WebKitPrintCustomWidgetPrivateExtensions
{

	public static WebKitPrintCustomWidgetPrivate Dereference(this WebKitPrintCustomWidgetPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitPrintCustomWidgetPrivate>(x.DangerousGetHandle());
}
internal class WebKitPrintCustomWidgetPrivateExterns
{
}


public struct WebKitPrintCustomWidgetPrivate
{
}
