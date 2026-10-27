namespace MentorLake.WebKit2;


public class WebKitPrintOperationClassHandle : BaseSafeHandle
{
}


public static class WebKitPrintOperationClassExtensions
{

	public static WebKitPrintOperationClass Dereference(this WebKitPrintOperationClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitPrintOperationClass>(x.DangerousGetHandle());
}
internal class WebKitPrintOperationClassExterns
{
}


public struct WebKitPrintOperationClass
{
	
public GObjectClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
