namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Structure representing a single field in a structured log entry. See
/// g_log_structured() for details.
/// </para>
/// <para>
/// Log fields may contain arbitrary values, including binary with embedded nul
/// bytes. If the field contains a string, the string must be UTF-8 encoded and
/// have a trailing nul byte. Otherwise, @length must be set to a non-negative
/// value.
/// </para>
/// </summary>

public class GLogFieldHandle : BaseSafeHandle
{
}


public static class GLogFieldExtensions
{

	public static GLogField Dereference(this GLogFieldHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GLogField>(x.DangerousGetHandle());
}
internal class GLogFieldExterns
{
}

/// <summary>
/// <para>
/// Structure representing a single field in a structured log entry. See
/// g_log_structured() for details.
/// </para>
/// <para>
/// Log fields may contain arbitrary values, including binary with embedded nul
/// bytes. If the field contains a string, the string must be UTF-8 encoded and
/// have a trailing nul byte. Otherwise, @length must be set to a non-negative
/// value.
/// </para>
/// </summary>

public struct GLogField
{
	/// <summary>
/// <para>
/// field name (UTF-8 string)
/// </para>
/// </summary>

public string key;
	/// <summary>
/// <para>
/// field value (arbitrary bytes)
/// </para>
/// </summary>

public IntPtr value;
	/// <summary>
/// <para>
/// length of @value, in bytes, or -1 if it is nul-terminated
/// </para>
/// </summary>

public UIntPtr length;
}
