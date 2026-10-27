namespace MentorLake.WebKit2;


public class WebKitWebInspectorClassHandle : BaseSafeHandle
{
}


public static class WebKitWebInspectorClassExtensions
{

	public static WebKitWebInspectorClass Dereference(this WebKitWebInspectorClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitWebInspectorClass>(x.DangerousGetHandle());
}
internal class WebKitWebInspectorClassExterns
{
}


public struct WebKitWebInspectorClass
{
	
public GObjectClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
