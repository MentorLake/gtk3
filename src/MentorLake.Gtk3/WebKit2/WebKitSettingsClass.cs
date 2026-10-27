namespace MentorLake.WebKit2;


public class WebKitSettingsClassHandle : BaseSafeHandle
{
}


public static class WebKitSettingsClassExtensions
{

	public static WebKitSettingsClass Dereference(this WebKitSettingsClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitSettingsClass>(x.DangerousGetHandle());
}
internal class WebKitSettingsClassExterns
{
}


public struct WebKitSettingsClass
{
	
public GObjectClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
