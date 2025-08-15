namespace MentorLake.GLib;

/// <summary>
/// <para>
/// A #GOnce struct controls a one-time initialization function. Any
/// one-time initialization function must have its own unique #GOnce
/// struct.
/// </para>
/// </summary>

public class GOnceHandle : BaseSafeHandle
{
}


public static class GOnceExtensions
{

/// <param name="once">
/// </param>
/// <param name="func">
/// </param>
/// <param name="arg">
/// </param>

	public static IntPtr Impl(this MentorLake.GLib.GOnceHandle once, MentorLake.GLib.GThreadFunc func, IntPtr arg)
	{
		if (once.IsInvalid) throw new Exception("Invalid handle (GOnce)");
		return GOnceExterns.g_once_impl(once, func, arg);
	}


	public static GOnce Dereference(this GOnceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GOnce>(x.DangerousGetHandle());
}
internal class GOnceExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_once_impl([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOnceHandle>))] MentorLake.GLib.GOnceHandle once, MentorLake.GLib.GThreadFunc func, IntPtr arg);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_once_init_enter(ref IntPtr location);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_once_init_enter_impl(UIntPtr location);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_once_init_enter_pointer(IntPtr location);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_once_init_leave(ref IntPtr location, UIntPtr result);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_once_init_leave_pointer(IntPtr location, IntPtr result);

}

/// <summary>
/// <para>
/// A #GOnce struct controls a one-time initialization function. Any
/// one-time initialization function must have its own unique #GOnce
/// struct.
/// </para>
/// </summary>

public struct GOnce
{
	/// <summary>
/// <para>
/// the status of the #GOnce
/// </para>
/// </summary>

public GOnceStatus status;
	/// <summary>
/// <para>
/// the value returned by the call to the function, if @status
///          is %G_ONCE_STATUS_READY
/// </para>
/// </summary>

public IntPtr retval;
/// <summary>
/// <para>
/// Function to be called when starting a critical initialization
/// section. The argument @location must point to a static
/// 0-initialized variable that will be set to a value other than 0 at
/// the end of the initialization section. In combination with
/// g_once_init_leave() and the unique address @value_location, it can
/// be ensured that an initialization section will be executed only once
/// during a program&apos;s life time, and that concurrent threads are
/// blocked until initialization completed. To be used in constructs
/// like this:
/// </para>
/// <code>
///   static gsize initialization_value = 0;
///   static gsize initialization_value = 0;
/// 
///   if (g_once_init_enter (&amp;initialization_value))
///     {
///       gsize setup_value = 42; // initialization code here
/// 
///       g_once_init_leave (&amp;initialization_value, setup_value);
///     }
/// 
///   // use initialization_value here
/// </code>
/// <para>
/// While @location has a `volatile` qualifier, this is a historical artifact and
/// the pointer passed to it should not be `volatile`.
/// </para>
/// </summary>

/// <param name="location">
/// location of a static initializable variable
///    containing 0
/// </param>
/// <return>
/// %TRUE if the initialization section should be entered,
///     %FALSE and blocks otherwise
/// </return>

	public static bool InitEnter(ref IntPtr location)
	{
		return GOnceExterns.g_once_init_enter(ref location);
	}


/// <param name="location">
/// </param>

	public static bool InitEnterImpl(UIntPtr location)
	{
		return GOnceExterns.g_once_init_enter_impl(location);
	}

/// <summary>
/// <para>
/// This functions behaves in the same way as g_once_init_enter(), but can
/// can be used to initialize pointers (or #guintptr) instead of #gsize.
/// </para>
/// <code>
///   static MyStruct *interesting_struct = NULL;
///   static MyStruct *interesting_struct = NULL;
/// 
///   if (g_once_init_enter_pointer (&amp;interesting_struct))
///     {
///       MyStruct *setup_value = allocate_my_struct (); // initialization code here
/// 
///       g_once_init_leave_pointer (&amp;interesting_struct, g_steal_pointer (&amp;setup_value));
///     }
/// 
///   // use interesting_struct here
/// </code>
/// </summary>

/// <param name="location">
/// location of a static initializable variable
///    containing `NULL`
/// </param>
/// <return>
/// %TRUE if the initialization section should be entered,
///     %FALSE and blocks otherwise
/// </return>

	public static bool InitEnterPointer(IntPtr location)
	{
		return GOnceExterns.g_once_init_enter_pointer(location);
	}

/// <summary>
/// <para>
/// Counterpart to g_once_init_enter(). Expects a location of a static
/// 0-initialized initialization variable, and an initialization value
/// other than 0. Sets the variable to the initialization value, and
/// releases concurrent threads blocking in g_once_init_enter() on this
/// initialization variable.
/// </para>
/// <para>
/// While @location has a `volatile` qualifier, this is a historical artifact and
/// the pointer passed to it should not be `volatile`.
/// </para>
/// </summary>

/// <param name="location">
/// location of a static initializable variable
///    containing 0
/// </param>
/// <param name="result">
/// new non-0 value for `*value_location`
/// </param>

	public static void InitLeave(ref IntPtr location, UIntPtr result)
	{
		GOnceExterns.g_once_init_leave(ref location, result);
	}

/// <summary>
/// <para>
/// Counterpart to g_once_init_enter_pointer(). Expects a location of a static
/// `NULL`-initialized initialization variable, and an initialization value
/// other than `NULL`. Sets the variable to the initialization value, and
/// releases concurrent threads blocking in g_once_init_enter_pointer() on this
/// initialization variable.
/// </para>
/// <para>
/// This functions behaves in the same way as g_once_init_leave(), but
/// can be used to initialize pointers (or #guintptr) instead of #gsize.
/// </para>
/// </summary>

/// <param name="location">
/// location of a static initializable variable
///    containing `NULL`
/// </param>
/// <param name="result">
/// new non-`NULL` value for `*location`
/// </param>

	public static void InitLeavePointer(IntPtr location, IntPtr result)
	{
		GOnceExterns.g_once_init_leave_pointer(location, result);
	}

}
