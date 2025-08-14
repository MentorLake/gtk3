namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Provides an interface for initializing object such that initialization
/// may fail.
/// </para>
/// </summary>

public class GInitableIfaceHandle : BaseSafeHandle
{
}


public static class GInitableIfaceExtensions
{

	public static GInitableIface Dereference(this GInitableIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GInitableIface>(x.DangerousGetHandle());
}
internal class GInitableIfaceExterns
{
}

/// <summary>
/// <para>
/// Provides an interface for initializing object such that initialization
/// may fail.
/// </para>
/// </summary>

public struct GInitableIface
{
	/// <summary>
/// <para>
/// The parent interface.
/// </para>
/// </summary>

public GTypeInterface g_iface;
	/// <summary>
/// <para>
/// Initializes the object.
/// </para>
/// </summary>

public IntPtr init;
}
