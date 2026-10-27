namespace MentorLake.WebKit2;


public class WebKitHitTestResultClassHandle : BaseSafeHandle
{
}


public static class WebKitHitTestResultClassExtensions
{

	public static WebKitHitTestResultClass Dereference(this WebKitHitTestResultClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitHitTestResultClass>(x.DangerousGetHandle());
}
internal class WebKitHitTestResultClassExterns
{
}


public struct WebKitHitTestResultClass
{
	
public GObjectClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
