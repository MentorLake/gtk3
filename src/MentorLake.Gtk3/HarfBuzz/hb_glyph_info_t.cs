namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// The #hb_glyph_info_t is the structure that holds information about the
/// glyphs and their relation to input text.
/// </para>
/// </summary>

public class hb_glyph_info_tHandle : BaseSafeHandle
{
}


public static class hb_glyph_info_tExtensions
{

	public static hb_glyph_info_t Dereference(this hb_glyph_info_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_glyph_info_t>(x.DangerousGetHandle());
}
internal class hb_glyph_info_tExterns
{
}

/// <summary>
/// <para>
/// The #hb_glyph_info_t is the structure that holds information about the
/// glyphs and their relation to input text.
/// </para>
/// </summary>

public struct hb_glyph_info_t
{
	/// <summary>
/// <para>
/// either a Unicode code point (before shaping) or a glyph index
///             (after shaping).
/// </para>
/// </summary>

public hb_codepoint_t codepoint;
	/// <summary>
/// <para>
/// the index of the character in the original text that corresponds
///           to this #hb_glyph_info_t, or whatever the client passes to
///           hb_buffer_add(). More than one #hb_glyph_info_t can have the same
///           @cluster value, if they resulted from the same character (e.g. one
///           to many glyph substitution), and when more than one character gets
///           merged in the same glyph (e.g. many to one glyph substitution) the
///           #hb_glyph_info_t will have the smallest cluster value of them.
///           By default some characters are merged into the same cluster
///           (e.g. combining marks have the same cluster as their bases)
///           even if they are separate glyphs, hb_buffer_set_cluster_level()
///           allow selecting more fine-grained cluster handling.
/// </para>
/// </summary>

public uint cluster;
}
