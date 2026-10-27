namespace MentorLake.WebKit2;


public class WebKitFileChooserRequestClassHandle : BaseSafeHandle
{
}


public static class WebKitFileChooserRequestClassExtensions
{

	public static WebKitFileChooserRequestClass Dereference(this WebKitFileChooserRequestClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitFileChooserRequestClass>(x.DangerousGetHandle());
}
internal class WebKitFileChooserRequestClassExterns
{
}


public struct WebKitFileChooserRequestClass
{
	
public GObjectClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
