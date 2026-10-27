namespace MentorLake.Soup;


public class SoupWebsocketExtensionManagerClassHandle : BaseSafeHandle
{
}


public static class SoupWebsocketExtensionManagerClassExtensions
{

	public static SoupWebsocketExtensionManagerClass Dereference(this SoupWebsocketExtensionManagerClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<SoupWebsocketExtensionManagerClass>(x.DangerousGetHandle());
}
internal class SoupWebsocketExtensionManagerClassExterns
{
}


public struct SoupWebsocketExtensionManagerClass
{
	
public GObjectClass parent_class;
}
