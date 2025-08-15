namespace MentorLake.GObject;

/// <summary>
/// <para>
/// The #GTypeValueTable provides the functions required by the #GValue
/// implementation, to serve as a container for values of a type.
/// </para>
/// </summary>

public class GTypeValueTableHandle : BaseSafeHandle
{
}


public static class GTypeValueTableExtensions
{

	public static GTypeValueTable Dereference(this GTypeValueTableHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTypeValueTable>(x.DangerousGetHandle());
}
internal class GTypeValueTableExterns
{
	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeValueTableHandle>))]
	internal static extern MentorLake.GObject.GTypeValueTableHandle g_type_value_table_peek(MentorLake.GObject.GType type);

}

/// <summary>
/// <para>
/// The #GTypeValueTable provides the functions required by the #GValue
/// implementation, to serve as a container for values of a type.
/// </para>
/// </summary>

public struct GTypeValueTable
{
	/// <summary>
/// <para>
/// Function to initialize a GValue
/// </para>
/// </summary>

public GTypeValueInitFunc value_init;
	/// <summary>
/// <para>
/// Function to free a GValue
/// </para>
/// </summary>

public GTypeValueFreeFunc value_free;
	/// <summary>
/// <para>
/// Function to copy a GValue
/// </para>
/// </summary>

public GTypeValueCopyFunc value_copy;
	/// <summary>
/// <para>
/// Function to peek the contents of a GValue if they fit
///   into a pointer
/// </para>
/// </summary>

public GTypeValuePeekPointerFunc value_peek_pointer;
	/// <summary>
/// <para>
/// A string format describing how to collect the contents of
///   this value bit-by-bit. Each character in the format represents
///   an argument to be collected, and the characters themselves indicate
///   the type of the argument. Currently supported arguments are:
///    - `&apos;i&apos;`: Integers, passed as `collect_values[].v_int`
///    - `&apos;l&apos;`: Longs, passed as `collect_values[].v_long`
///    - `&apos;d&apos;`: Doubles, passed as `collect_values[].v_double`
///    - `&apos;p&apos;`: Pointers, passed as `collect_values[].v_pointer`
///   It should be noted that for variable argument list construction,
///   ANSI C promotes every type smaller than an integer to an int, and
///   floats to doubles. So for collection of short int or char, `&apos;i&apos;`
///   needs to be used, and for collection of floats `&apos;d&apos;`.
/// </para>
/// </summary>

public string collect_format;
	/// <summary>
/// <para>
/// Function to initialize a GValue from the values
///   collected from variadic arguments
/// </para>
/// </summary>

public GTypeValueCollectFunc collect_value;
	/// <summary>
/// <para>
/// Format description of the arguments to collect for @lcopy_value,
///   analogous to @collect_format. Usually, @lcopy_format string consists
///   only of `&apos;p&apos;`s to provide lcopy_value() with pointers to storage locations.
/// </para>
/// </summary>

public string lcopy_format;
	/// <summary>
/// <para>
/// Function to store the contents of a value into the
///   locations collected from variadic arguments
/// </para>
/// </summary>

public GTypeValueLCopyFunc lcopy_value;
/// <summary>
/// <para>
/// Returns the location of the #GTypeValueTable associated with @type.
/// </para>
/// <para>
/// Note that this function should only be used from source code
/// that implements or has internal knowledge of the implementation of
/// @type.
/// </para>
/// </summary>

/// <param name="type">
/// a #GType
/// </param>
/// <return>
/// location of the #GTypeValueTable associated with @type or
///     %NULL if there is no #GTypeValueTable associated with @type
/// </return>

	public static MentorLake.GObject.GTypeValueTableHandle Peek(MentorLake.GObject.GType type)
	{
		return GTypeValueTableExterns.g_type_value_table_peek(type);
	}

}
