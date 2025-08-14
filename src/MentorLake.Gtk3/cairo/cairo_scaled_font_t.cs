namespace MentorLake.cairo;

/// <summary>
/// <para>
/// A #cairo_scaled_font_t is a font scaled to a particular size and device
/// resolution. A #cairo_scaled_font_t is most useful for low-level font
/// usage where a library or application wants to cache a reference
/// to a scaled font to speed up the computation of metrics.
/// </para>
/// <para>
/// There are various types of scaled fonts, depending on the
/// <firstterm>font backend</firstterm> they use. The type of a
/// scaled font can be queried using cairo_scaled_font_get_type().
/// </para>
/// <para>
/// Memory management of #cairo_scaled_font_t is done with
/// cairo_scaled_font_reference() and cairo_scaled_font_destroy().
/// </para>
/// </summary>

public class cairo_scaled_font_tHandle : BaseSafeHandle
{
}


public static class cairo_scaled_font_tExtensions
{

	public static cairo_scaled_font_t Dereference(this cairo_scaled_font_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<cairo_scaled_font_t>(x.DangerousGetHandle());
}
internal class cairo_scaled_font_tExterns
{
}

/// <summary>
/// <para>
/// A #cairo_scaled_font_t is a font scaled to a particular size and device
/// resolution. A #cairo_scaled_font_t is most useful for low-level font
/// usage where a library or application wants to cache a reference
/// to a scaled font to speed up the computation of metrics.
/// </para>
/// <para>
/// There are various types of scaled fonts, depending on the
/// <firstterm>font backend</firstterm> they use. The type of a
/// scaled font can be queried using cairo_scaled_font_get_type().
/// </para>
/// <para>
/// Memory management of #cairo_scaled_font_t is done with
/// cairo_scaled_font_reference() and cairo_scaled_font_destroy().
/// </para>
/// </summary>

public struct cairo_scaled_font_t
{
}
