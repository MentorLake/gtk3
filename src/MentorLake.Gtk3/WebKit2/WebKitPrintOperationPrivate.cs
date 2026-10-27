namespace MentorLake.WebKit2;


public class WebKitPrintOperationPrivateHandle : BaseSafeHandle
{
}


public static class WebKitPrintOperationPrivateExtensions
{

	public static WebKitPrintOperationPrivate Dereference(this WebKitPrintOperationPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitPrintOperationPrivate>(x.DangerousGetHandle());
}
internal class WebKitPrintOperationPrivateExterns
{
}


public struct WebKitPrintOperationPrivate
{
}
