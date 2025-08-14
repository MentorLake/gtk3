namespace MentorLake.Pango;

/// <summary>
/// <para>
/// The `PangoGlyphUnit` type is used to store dimensions within
/// Pango.
/// </para>
/// <para>
/// Dimensions are stored in 1/PANGO_SCALE of a device unit.
/// (A device unit might be a pixel for screen display, or
/// a point on a printer.) PANGO_SCALE is currently 1024, and
/// may change in the future (unlikely though), but you should not
/// depend on its exact value.
/// </para>
/// <para>
/// The PANGO_PIXELS() macro can be used to convert from glyph units
/// into device units with correct rounding.
/// </para>
/// </summary>

public struct PangoGlyphUnit
{
	public int Value;
}

public class PangoGlyphUnitHandle : BaseSafeHandle
{
}

public static class PangoGlyphUnitHandleExtensions
{
	public static PangoGlyphUnit Dereference(this PangoGlyphUnitHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoGlyphUnit>(x.DangerousGetHandle());
	public static int DereferenceValue(this PangoGlyphUnitHandle x) => x.Dereference().Value;
}
