namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Associates a string with a bit flag.
/// Used in g_parse_debug_string().
/// </para>
/// </summary>

public class GDebugKeyHandle : BaseSafeHandle
{
}


public static class GDebugKeyExtensions
{

	public static GDebugKey Dereference(this GDebugKeyHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDebugKey>(x.DangerousGetHandle());
}
internal class GDebugKeyExterns
{
}

/// <summary>
/// <para>
/// Associates a string with a bit flag.
/// Used in g_parse_debug_string().
/// </para>
/// </summary>

public struct GDebugKey
{
	/// <summary>
/// <para>
/// the string
/// </para>
/// </summary>

public string key;
	/// <summary>
/// <para>
/// the flag
/// </para>
/// </summary>

public uint value;
}
