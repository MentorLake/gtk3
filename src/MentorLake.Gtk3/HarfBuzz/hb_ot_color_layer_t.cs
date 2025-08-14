namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Pairs of glyph and color index.
/// </para>
/// <para>
/// A color index of 0xFFFF does not refer to a palette
/// color, but indicates that the foreground color should
/// be used.
/// </para>
/// </summary>

public class hb_ot_color_layer_tHandle : BaseSafeHandle
{
}


public static class hb_ot_color_layer_tExtensions
{

	public static hb_ot_color_layer_t Dereference(this hb_ot_color_layer_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_ot_color_layer_t>(x.DangerousGetHandle());
}
internal class hb_ot_color_layer_tExterns
{
}

/// <summary>
/// <para>
/// Pairs of glyph and color index.
/// </para>
/// <para>
/// A color index of 0xFFFF does not refer to a palette
/// color, but indicates that the foreground color should
/// be used.
/// </para>
/// </summary>

public struct hb_ot_color_layer_t
{
	/// <summary>
/// <para>
/// the glyph ID of the layer
/// </para>
/// </summary>

public hb_codepoint_t glyph;
	/// <summary>
/// <para>
/// the palette color index of the layer
/// </para>
/// </summary>

public uint color_index;
}
