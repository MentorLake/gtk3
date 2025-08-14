namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Information about a specific attribute.
/// </para>
/// </summary>

public class GFileAttributeInfoHandle : BaseSafeHandle
{
}


public static class GFileAttributeInfoExtensions
{

	public static GFileAttributeInfo Dereference(this GFileAttributeInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GFileAttributeInfo>(x.DangerousGetHandle());
}
internal class GFileAttributeInfoExterns
{
}

/// <summary>
/// <para>
/// Information about a specific attribute.
/// </para>
/// </summary>

public struct GFileAttributeInfo
{
	/// <summary>
/// <para>
/// the name of the attribute.
/// </para>
/// </summary>

public string name;
	/// <summary>
/// <para>
/// the #GFileAttributeType type of the attribute.
/// </para>
/// </summary>

public GFileAttributeType type;
	/// <summary>
/// <para>
/// a set of #GFileAttributeInfoFlags.
/// </para>
/// </summary>

public GFileAttributeInfoFlags flags;
}
