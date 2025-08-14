namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Class structure for #GProxyAddress.
/// </para>
/// </summary>

public class GProxyAddressClassHandle : BaseSafeHandle
{
}


public static class GProxyAddressClassExtensions
{

	public static GProxyAddressClass Dereference(this GProxyAddressClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GProxyAddressClass>(x.DangerousGetHandle());
}
internal class GProxyAddressClassExterns
{
}

/// <summary>
/// <para>
/// Class structure for #GProxyAddress.
/// </para>
/// </summary>

public struct GProxyAddressClass
{
	
public GInetSocketAddressClass parent_class;
}
