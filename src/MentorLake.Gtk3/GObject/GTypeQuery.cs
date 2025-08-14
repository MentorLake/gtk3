namespace MentorLake.GObject;

/// <summary>
/// <para>
/// A structure holding information for a specific type.
/// </para>
/// <para>
/// See also: g_type_query()
/// </para>
/// </summary>

public class GTypeQueryHandle : BaseSafeHandle
{
}


public static class GTypeQueryExtensions
{

	public static GTypeQuery Dereference(this GTypeQueryHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTypeQuery>(x.DangerousGetHandle());
}
internal class GTypeQueryExterns
{
}

/// <summary>
/// <para>
/// A structure holding information for a specific type.
/// </para>
/// <para>
/// See also: g_type_query()
/// </para>
/// </summary>

public struct GTypeQuery
{
	/// <summary>
/// <para>
/// the #GType value of the type
/// </para>
/// </summary>

public GType type;
	/// <summary>
/// <para>
/// the name of the type
/// </para>
/// </summary>

public string type_name;
	/// <summary>
/// <para>
/// the size of the class structure
/// </para>
/// </summary>

public uint class_size;
	/// <summary>
/// <para>
/// the size of the instance structure
/// </para>
/// </summary>

public uint instance_size;
}
