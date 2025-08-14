namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Interface definition for [iface@Gio.AsyncResult].
/// </para>
/// </summary>

public class GAsyncResultIfaceHandle : BaseSafeHandle
{
}


public static class GAsyncResultIfaceExtensions
{

	public static GAsyncResultIface Dereference(this GAsyncResultIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GAsyncResultIface>(x.DangerousGetHandle());
}
internal class GAsyncResultIfaceExterns
{
}

/// <summary>
/// <para>
/// Interface definition for [iface@Gio.AsyncResult].
/// </para>
/// </summary>

public struct GAsyncResultIface
{
	/// <summary>
/// <para>
/// The parent interface.
/// </para>
/// </summary>

public GTypeInterface g_iface;
	/// <summary>
/// <para>
/// Gets the user data passed to the callback.
/// </para>
/// </summary>

public IntPtr get_user_data;
	/// <summary>
/// <para>
/// Gets the source object that issued the asynchronous operation.
/// </para>
/// </summary>

public IntPtr get_source_object;
	/// <summary>
/// <para>
/// Checks if a result is tagged with a particular source.
/// </para>
/// </summary>

public IntPtr is_tagged;
}
