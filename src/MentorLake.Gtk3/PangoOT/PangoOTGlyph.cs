namespace MentorLake.PangoOT;

/// <summary>
/// <para>
/// The `PangoOTGlyph` structure represents a single glyph together with
/// information used for OpenType layout processing of the glyph.
/// It contains the following fields.
/// </para>
/// </summary>

public class PangoOTGlyphHandle : BaseSafeHandle
{
}


public static class PangoOTGlyphExtensions
{

	public static PangoOTGlyph Dereference(this PangoOTGlyphHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoOTGlyph>(x.DangerousGetHandle());
}
internal class PangoOTGlyphExterns
{
}

/// <summary>
/// <para>
/// The `PangoOTGlyph` structure represents a single glyph together with
/// information used for OpenType layout processing of the glyph.
/// It contains the following fields.
/// </para>
/// </summary>

public struct PangoOTGlyph
{
	/// <summary>
/// <para>
/// the glyph itself.
/// </para>
/// </summary>

public uint glyph;
	/// <summary>
/// <para>
/// the properties value, identifying which features should be
/// applied on this glyph.  See pango_ot_ruleset_add_feature().
/// </para>
/// </summary>

public uint properties;
	/// <summary>
/// <para>
/// the cluster that this glyph belongs to.
/// </para>
/// </summary>

public uint cluster;
	/// <summary>
/// <para>
/// a component value, set by the OpenType layout engine.
/// </para>
/// </summary>

public ushort component;
	/// <summary>
/// <para>
/// a ligature index value, set by the OpenType layout engine.
/// </para>
/// </summary>

public ushort ligID;
	/// <summary>
/// <para>
/// for Pango internal use
/// </para>
/// </summary>

public uint @internal;
}
