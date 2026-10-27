namespace MentorLake.Soup;

/// <summary>
/// <para>
/// The abstract base class for [class@WebsocketConnection].
/// </para>
/// </summary>

public class SoupWebsocketConnectionClassHandle : BaseSafeHandle
{
}


public static class SoupWebsocketConnectionClassExtensions
{

	public static SoupWebsocketConnectionClass Dereference(this SoupWebsocketConnectionClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<SoupWebsocketConnectionClass>(x.DangerousGetHandle());
}
internal class SoupWebsocketConnectionClassExterns
{
}

/// <summary>
/// <para>
/// The abstract base class for [class@WebsocketConnection].
/// </para>
/// </summary>

public struct SoupWebsocketConnectionClass
{
	
public GObjectClass parent_class;
}
