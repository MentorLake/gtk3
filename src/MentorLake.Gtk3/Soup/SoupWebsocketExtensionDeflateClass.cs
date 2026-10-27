namespace MentorLake.Soup;


public class SoupWebsocketExtensionDeflateClassHandle : BaseSafeHandle
{
}


public static class SoupWebsocketExtensionDeflateClassExtensions
{

	public static SoupWebsocketExtensionDeflateClass Dereference(this SoupWebsocketExtensionDeflateClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<SoupWebsocketExtensionDeflateClass>(x.DangerousGetHandle());
}
internal class SoupWebsocketExtensionDeflateClassExterns
{
}


public struct SoupWebsocketExtensionDeflateClass
{
	
public SoupWebsocketExtensionClass parent_class;
}
