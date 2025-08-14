namespace MentorLake.GLib;

/// <summary>
/// <para>
/// A set of functions used to perform memory allocation. The same #GMemVTable must
/// be used for all allocations in the same program; a call to g_mem_set_vtable(),
/// if it exists, should be prior to any use of GLib.
/// </para>
/// <para>
/// This functions related to this has been deprecated in 2.46, and no longer work.
/// </para>
/// </summary>

public class GMemVTableHandle : BaseSafeHandle
{
}


public static class GMemVTableExtensions
{

	public static GMemVTable Dereference(this GMemVTableHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GMemVTable>(x.DangerousGetHandle());
}
internal class GMemVTableExterns
{
}

/// <summary>
/// <para>
/// A set of functions used to perform memory allocation. The same #GMemVTable must
/// be used for all allocations in the same program; a call to g_mem_set_vtable(),
/// if it exists, should be prior to any use of GLib.
/// </para>
/// <para>
/// This functions related to this has been deprecated in 2.46, and no longer work.
/// </para>
/// </summary>

public struct GMemVTable
{
	/// <summary>
/// <para>
/// function to use for allocating memory.
/// </para>
/// </summary>

public IntPtr malloc;
	/// <summary>
/// <para>
/// function to use for reallocating memory.
/// </para>
/// </summary>

public IntPtr realloc;
	/// <summary>
/// <para>
/// function to use to free memory.
/// </para>
/// </summary>

public IntPtr free;
	/// <summary>
/// <para>
/// function to use for allocating zero-filled memory.
/// </para>
/// </summary>

public IntPtr calloc;
	/// <summary>
/// <para>
/// function to use for allocating memory without a default error handler.
/// </para>
/// </summary>

public IntPtr try_malloc;
	/// <summary>
/// <para>
/// function to use for reallocating memory without a default error handler.
/// </para>
/// </summary>

public IntPtr try_realloc;
}
