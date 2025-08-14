namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The `GSourceCallbackFuncs` struct contains
/// functions for managing callback objects.
/// </para>
/// </summary>

public class GSourceCallbackFuncsHandle : BaseSafeHandle
{
}


public static class GSourceCallbackFuncsExtensions
{

	public static GSourceCallbackFuncs Dereference(this GSourceCallbackFuncsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSourceCallbackFuncs>(x.DangerousGetHandle());
}
internal class GSourceCallbackFuncsExterns
{
}

/// <summary>
/// <para>
/// The `GSourceCallbackFuncs` struct contains
/// functions for managing callback objects.
/// </para>
/// </summary>

public struct GSourceCallbackFuncs
{
	/// <summary>
/// <para>
/// Called when a reference is added to the callback object
/// </para>
/// </summary>

public IntPtr @ref;
	/// <summary>
/// <para>
/// Called when a reference to the callback object is dropped
/// </para>
/// </summary>

public IntPtr unref;
	/// <summary>
/// <para>
/// Called to extract the callback function and data from the
///     callback object.
/// </para>
/// </summary>

public IntPtr get;
}
