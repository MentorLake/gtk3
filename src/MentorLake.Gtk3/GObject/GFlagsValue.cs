namespace MentorLake.GObject;

/// <summary>
/// <para>
/// A structure which contains a single flags value, its name, and its
/// nickname.
/// </para>
/// </summary>

public class GFlagsValueHandle : BaseSafeHandle
{
}


public static class GFlagsValueExtensions
{

	public static GFlagsValue Dereference(this GFlagsValueHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GFlagsValue>(x.DangerousGetHandle());
}
internal class GFlagsValueExterns
{
}

/// <summary>
/// <para>
/// A structure which contains a single flags value, its name, and its
/// nickname.
/// </para>
/// </summary>

public struct GFlagsValue
{
	/// <summary>
/// <para>
/// the flags value
/// </para>
/// </summary>

public uint value;
	/// <summary>
/// <para>
/// the name of the value
/// </para>
/// </summary>

public string value_name;
	/// <summary>
/// <para>
/// the nickname of the value
/// </para>
/// </summary>

public string value_nick;
}
