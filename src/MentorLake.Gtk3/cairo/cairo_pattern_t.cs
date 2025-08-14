namespace MentorLake.cairo;

/// <summary>
/// <para>
/// A #cairo_pattern_t represents a source when drawing onto a
/// surface. There are different subtypes of #cairo_pattern_t,
/// for different types of sources; for example,
/// cairo_pattern_create_rgb() creates a pattern for a solid
/// opaque color.
/// </para>
/// <para>
/// Other than various
/// <function>cairo_pattern_create_<emphasis>type</emphasis>()</function>
/// functions, some of the pattern types can be implicitly created using various
/// <function>cairo_set_source_<emphasis>type</emphasis>()</function> functions;
/// for example cairo_set_source_rgb().
/// </para>
/// <para>
/// The type of a pattern can be queried with cairo_pattern_get_type().
/// </para>
/// <para>
/// Memory management of #cairo_pattern_t is done with
/// cairo_pattern_reference() and cairo_pattern_destroy().
/// </para>
/// </summary>

public class cairo_pattern_tHandle : BaseSafeHandle
{
}


public static class cairo_pattern_tExtensions
{

	public static cairo_pattern_t Dereference(this cairo_pattern_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<cairo_pattern_t>(x.DangerousGetHandle());
}
internal class cairo_pattern_tExterns
{
}

/// <summary>
/// <para>
/// A #cairo_pattern_t represents a source when drawing onto a
/// surface. There are different subtypes of #cairo_pattern_t,
/// for different types of sources; for example,
/// cairo_pattern_create_rgb() creates a pattern for a solid
/// opaque color.
/// </para>
/// <para>
/// Other than various
/// <function>cairo_pattern_create_<emphasis>type</emphasis>()</function>
/// functions, some of the pattern types can be implicitly created using various
/// <function>cairo_set_source_<emphasis>type</emphasis>()</function> functions;
/// for example cairo_set_source_rgb().
/// </para>
/// <para>
/// The type of a pattern can be queried with cairo_pattern_get_type().
/// </para>
/// <para>
/// Memory management of #cairo_pattern_t is done with
/// cairo_pattern_reference() and cairo_pattern_destroy().
/// </para>
/// </summary>

public struct cairo_pattern_t
{
}
