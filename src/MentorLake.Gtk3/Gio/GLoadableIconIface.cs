namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Interface for icons that can be loaded as a stream.
/// </para>
/// </summary>

public class GLoadableIconIfaceHandle : BaseSafeHandle
{
}


public static class GLoadableIconIfaceExtensions
{

	public static GLoadableIconIface Dereference(this GLoadableIconIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GLoadableIconIface>(x.DangerousGetHandle());
}
internal class GLoadableIconIfaceExterns
{
}

/// <summary>
/// <para>
/// Interface for icons that can be loaded as a stream.
/// </para>
/// </summary>

public struct GLoadableIconIface
{
	/// <summary>
/// <para>
/// The parent interface.
/// </para>
/// </summary>

public GTypeInterface g_iface;
	/// <summary>
/// <para>
/// Loads an icon.
/// </para>
/// </summary>

public IntPtr load;
	/// <summary>
/// <para>
/// Loads an icon asynchronously.
/// </para>
/// </summary>

public IntPtr load_async;
	/// <summary>
/// <para>
/// Finishes an asynchronous icon load.
/// </para>
/// </summary>

public IntPtr load_finish;
}
