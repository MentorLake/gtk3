namespace MentorLake.GLib;

/// <summary>
/// <para>
/// A typedef for a reference-counted string. A pointer to a #GRefString can be
/// treated like a standard `char*` array by all code, but can additionally have
/// `g_ref_string_*()` methods called on it. `g_ref_string_*()` methods cannot be
/// called on `char*` arrays not allocated using g_ref_string_new().
/// </para>
/// <para>
/// If using #GRefString with autocleanups, g_autoptr() must be used rather than
/// g_autofree(), so that the reference counting metadata is also freed.
/// </para>
/// </summary>

public struct GRefString
{
	public char Value;
}

public class GRefStringHandle : BaseSafeHandle
{
}

public static class GRefStringHandleExtensions
{
	public static GRefString Dereference(this GRefStringHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GRefString>(x.DangerousGetHandle());
	public static char DereferenceValue(this GRefStringHandle x) => x.Dereference().Value;
}
