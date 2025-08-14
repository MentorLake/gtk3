namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Provides an interface for asynchronous initializing object such that
/// initialization may fail.
/// </para>
/// </summary>

public class GAsyncInitableIfaceHandle : BaseSafeHandle
{
}


public static class GAsyncInitableIfaceExtensions
{

	public static GAsyncInitableIface Dereference(this GAsyncInitableIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GAsyncInitableIface>(x.DangerousGetHandle());
}
internal class GAsyncInitableIfaceExterns
{
}

/// <summary>
/// <para>
/// Provides an interface for asynchronous initializing object such that
/// initialization may fail.
/// </para>
/// </summary>

public struct GAsyncInitableIface
{
	/// <summary>
/// <para>
/// The parent interface.
/// </para>
/// </summary>

public GTypeInterface g_iface;
	/// <summary>
/// <para>
/// Starts initialization of the object.
/// </para>
/// </summary>

public IntPtr init_async;
	/// <summary>
/// <para>
/// Finishes initialization of the object.
/// </para>
/// </summary>

public IntPtr init_finish;
}
