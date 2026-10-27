namespace MentorLake.WebKit2;


public class WebKitPluginClassHandle : BaseSafeHandle
{
}


public static class WebKitPluginClassExtensions
{

	public static WebKitPluginClass Dereference(this WebKitPluginClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitPluginClass>(x.DangerousGetHandle());
}
internal class WebKitPluginClassExterns
{
}


public struct WebKitPluginClass
{
	
public GObjectClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
