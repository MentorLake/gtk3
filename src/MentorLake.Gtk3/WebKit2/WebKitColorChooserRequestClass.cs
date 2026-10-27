namespace MentorLake.WebKit2;


public class WebKitColorChooserRequestClassHandle : BaseSafeHandle
{
}


public static class WebKitColorChooserRequestClassExtensions
{

	public static WebKitColorChooserRequestClass Dereference(this WebKitColorChooserRequestClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitColorChooserRequestClass>(x.DangerousGetHandle());
}
internal class WebKitColorChooserRequestClassExterns
{
}


public struct WebKitColorChooserRequestClass
{
	
public GObjectClass parent_class;
}
