namespace MentorLake.Pango;

/// <summary>
/// <para>
/// A `PangoLayoutRun` represents a single run within a `PangoLayoutLine`.
/// </para>
/// <para>
/// It is simply an alternate name for [struct@Pango.GlyphItem].
/// See the [struct@Pango.GlyphItem] docs for details on the fields.
/// </para>
/// </summary>

public struct PangoLayoutRun
{
	public MentorLake.Pango.PangoGlyphItem Value;
}

/// <summary>
/// <para>
/// A `PangoLayoutRun` represents a single run within a `PangoLayoutLine`.
/// </para>
/// <para>
/// It is simply an alternate name for [struct@Pango.GlyphItem].
/// See the [struct@Pango.GlyphItem] docs for details on the fields.
/// </para>
/// </summary>

public class PangoLayoutRunHandle : BaseSafeHandle
{
}

public static class PangoLayoutRunHandleExtensions
{
	public static PangoLayoutRun Dereference(this PangoLayoutRunHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoLayoutRun>(x.DangerousGetHandle());
	public static MentorLake.Pango.PangoGlyphItem DereferenceValue(this PangoLayoutRunHandle x) => x.Dereference().Value;
}
