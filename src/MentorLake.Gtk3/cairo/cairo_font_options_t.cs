namespace MentorLake.cairo;

/// <summary>
/// <para>
/// An opaque structure holding all options that are used when
/// rendering fonts.
/// </para>
/// <para>
/// Individual features of a #cairo_font_options_t can be set or
/// accessed using functions named
/// <function>cairo_font_options_set_<emphasis>feature_name</emphasis>()</function> and
/// <function>cairo_font_options_get_<emphasis>feature_name</emphasis>()</function>, like
/// cairo_font_options_set_antialias() and
/// cairo_font_options_get_antialias().
/// </para>
/// <para>
/// New features may be added to a #cairo_font_options_t in the
/// future.  For this reason, cairo_font_options_copy(),
/// cairo_font_options_equal(), cairo_font_options_merge(), and
/// cairo_font_options_hash() should be used to copy, check
/// for equality, merge, or compute a hash value of
/// #cairo_font_options_t objects.
/// </para>
/// </summary>

public class cairo_font_options_tHandle : BaseSafeHandle
{
}


public static class cairo_font_options_tExtensions
{

	public static cairo_font_options_t Dereference(this cairo_font_options_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<cairo_font_options_t>(x.DangerousGetHandle());
}
internal class cairo_font_options_tExterns
{
}

/// <summary>
/// <para>
/// An opaque structure holding all options that are used when
/// rendering fonts.
/// </para>
/// <para>
/// Individual features of a #cairo_font_options_t can be set or
/// accessed using functions named
/// <function>cairo_font_options_set_<emphasis>feature_name</emphasis>()</function> and
/// <function>cairo_font_options_get_<emphasis>feature_name</emphasis>()</function>, like
/// cairo_font_options_set_antialias() and
/// cairo_font_options_get_antialias().
/// </para>
/// <para>
/// New features may be added to a #cairo_font_options_t in the
/// future.  For this reason, cairo_font_options_copy(),
/// cairo_font_options_equal(), cairo_font_options_merge(), and
/// cairo_font_options_hash() should be used to copy, check
/// for equality, merge, or compute a hash value of
/// #cairo_font_options_t objects.
/// </para>
/// </summary>

public struct cairo_font_options_t
{
}
