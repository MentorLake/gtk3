namespace MentorLake.WebKit2;


public class WebKitPrintCustomWidgetClassHandle : BaseSafeHandle
{
}


public static class WebKitPrintCustomWidgetClassExtensions
{

	public static WebKitPrintCustomWidgetClass Dereference(this WebKitPrintCustomWidgetClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitPrintCustomWidgetClass>(x.DangerousGetHandle());
}
internal class WebKitPrintCustomWidgetClassExterns
{
}


public struct WebKitPrintCustomWidgetClass
{
	
public GObjectClass parent_class;
	
public IntPtr apply;
	
public IntPtr update;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
