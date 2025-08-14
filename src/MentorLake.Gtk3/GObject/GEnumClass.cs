namespace MentorLake.GObject;

/// <summary>
/// <para>
/// The class of an enumeration type holds information about its
/// possible values.
/// </para>
/// </summary>

public class GEnumClassHandle : BaseSafeHandle
{
}


public static class GEnumClassExtensions
{

	public static GEnumClass Dereference(this GEnumClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GEnumClass>(x.DangerousGetHandle());
}
internal class GEnumClassExterns
{
}

/// <summary>
/// <para>
/// The class of an enumeration type holds information about its
/// possible values.
/// </para>
/// </summary>

public struct GEnumClass
{
	/// <summary>
/// <para>
/// the parent class
/// </para>
/// </summary>

public GTypeClass g_type_class;
	/// <summary>
/// <para>
/// the smallest possible value.
/// </para>
/// </summary>

public int minimum;
	/// <summary>
/// <para>
/// the largest possible value.
/// </para>
/// </summary>

public int maximum;
	/// <summary>
/// <para>
/// the number of possible values.
/// </para>
/// </summary>

public uint n_values;
	/// <summary>
/// <para>
/// an array of #GEnumValue structs describing the
///  individual values.
/// </para>
/// </summary>

public IntPtr values;
}
