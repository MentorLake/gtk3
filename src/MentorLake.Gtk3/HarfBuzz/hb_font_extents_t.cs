namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Font-wide extent values, measured in font units.
/// </para>
/// <para>
/// Note that typically @ascender is positive and @descender
/// negative, in coordinate systems that grow up.
/// </para>
/// </summary>

public class hb_font_extents_tHandle : BaseSafeHandle
{
}


public static class hb_font_extents_tExtensions
{

	public static hb_font_extents_t Dereference(this hb_font_extents_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_font_extents_t>(x.DangerousGetHandle());
}
internal class hb_font_extents_tExterns
{
}

/// <summary>
/// <para>
/// Font-wide extent values, measured in font units.
/// </para>
/// <para>
/// Note that typically @ascender is positive and @descender
/// negative, in coordinate systems that grow up.
/// </para>
/// </summary>

public struct hb_font_extents_t
{
	/// <summary>
/// <para>
/// The height of typographic ascenders.
/// </para>
/// </summary>

public hb_position_t ascender;
	/// <summary>
/// <para>
/// The depth of typographic descenders.
/// </para>
/// </summary>

public hb_position_t descender;
	/// <summary>
/// <para>
/// The suggested line-spacing gap.
/// </para>
/// </summary>

public hb_position_t line_gap;
}
