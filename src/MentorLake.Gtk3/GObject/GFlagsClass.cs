namespace MentorLake.GObject;

/// <summary>
/// <para>
/// The class of a flags type holds information about its
/// possible values.
/// </para>
/// </summary>

public class GFlagsClassHandle : BaseSafeHandle
{
}


public static class GFlagsClassExtensions
{

	public static GFlagsClass Dereference(this GFlagsClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GFlagsClass>(x.DangerousGetHandle());
}
internal class GFlagsClassExterns
{
}

/// <summary>
/// <para>
/// The class of a flags type holds information about its
/// possible values.
/// </para>
/// </summary>

public struct GFlagsClass
{
	/// <summary>
/// <para>
/// the parent class
/// </para>
/// </summary>

public GTypeClass g_type_class;
	/// <summary>
/// <para>
/// a mask covering all possible values.
/// </para>
/// </summary>

public uint mask;
	/// <summary>
/// <para>
/// the number of possible values.
/// </para>
/// </summary>

public uint n_values;
	/// <summary>
/// <para>
/// an array of #GFlagsValue structs describing the
///  individual values.
/// </para>
/// </summary>

public IntPtr values;
}
