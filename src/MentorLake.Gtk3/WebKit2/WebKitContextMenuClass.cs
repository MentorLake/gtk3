namespace MentorLake.WebKit2;


public class WebKitContextMenuClassHandle : BaseSafeHandle
{
}


public static class WebKitContextMenuClassExtensions
{

	public static WebKitContextMenuClass Dereference(this WebKitContextMenuClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitContextMenuClass>(x.DangerousGetHandle());
}
internal class WebKitContextMenuClassExterns
{
}


public struct WebKitContextMenuClass
{
	
public GObjectClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
