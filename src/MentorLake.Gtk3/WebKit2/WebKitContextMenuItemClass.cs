namespace MentorLake.WebKit2;


public class WebKitContextMenuItemClassHandle : BaseSafeHandle
{
}


public static class WebKitContextMenuItemClassExtensions
{

	public static WebKitContextMenuItemClass Dereference(this WebKitContextMenuItemClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitContextMenuItemClass>(x.DangerousGetHandle());
}
internal class WebKitContextMenuItemClassExterns
{
}


public struct WebKitContextMenuItemClass
{
	
public GInitiallyUnownedClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
