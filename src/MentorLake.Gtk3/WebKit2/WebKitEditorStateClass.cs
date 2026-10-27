namespace MentorLake.WebKit2;


public class WebKitEditorStateClassHandle : BaseSafeHandle
{
}


public static class WebKitEditorStateClassExtensions
{

	public static WebKitEditorStateClass Dereference(this WebKitEditorStateClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitEditorStateClass>(x.DangerousGetHandle());
}
internal class WebKitEditorStateClassExterns
{
}


public struct WebKitEditorStateClass
{
	
public GObjectClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
