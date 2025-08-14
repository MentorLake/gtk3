namespace MentorLake.Pango;

/// <summary>
/// <para>
/// A `PangoGlyphVisAttr` structure communicates information between
/// the shaping and rendering phases.
/// </para>
/// <para>
/// Currently, it contains cluster start and color information.
/// More attributes may be added in the future.
/// </para>
/// <para>
/// Clusters are stored in visual order, within the cluster, glyphs
/// are always ordered in logical order, since visual order is meaningless;
/// that is, in Arabic text, accent glyphs follow the glyphs for the
/// base character.
/// </para>
/// </summary>

public class PangoGlyphVisAttrHandle : BaseSafeHandle
{
}


public static class PangoGlyphVisAttrExtensions
{

	public static PangoGlyphVisAttr Dereference(this PangoGlyphVisAttrHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoGlyphVisAttr>(x.DangerousGetHandle());
}
internal class PangoGlyphVisAttrExterns
{
}

/// <summary>
/// <para>
/// A `PangoGlyphVisAttr` structure communicates information between
/// the shaping and rendering phases.
/// </para>
/// <para>
/// Currently, it contains cluster start and color information.
/// More attributes may be added in the future.
/// </para>
/// <para>
/// Clusters are stored in visual order, within the cluster, glyphs
/// are always ordered in logical order, since visual order is meaningless;
/// that is, in Arabic text, accent glyphs follow the glyphs for the
/// base character.
/// </para>
/// </summary>

public struct PangoGlyphVisAttr
{
	/// <summary>
/// <para>
/// set for the first logical glyph in each cluster.
/// </para>
/// </summary>

public uint is_cluster_start;
}
