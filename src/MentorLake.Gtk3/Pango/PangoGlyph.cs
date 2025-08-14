namespace MentorLake.Pango;

/// <summary>
/// <para>
/// A `PangoGlyph` represents a single glyph in the output form of a string.
/// </para>
/// </summary>

public struct PangoGlyph
{
	public uint Value;
}

public class PangoGlyphHandle : BaseSafeHandle
{
}

public static class PangoGlyphHandleExtensions
{
	public static PangoGlyph Dereference(this PangoGlyphHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoGlyph>(x.DangerousGetHandle());
	public static uint DereferenceValue(this PangoGlyphHandle x) => x.Dereference().Value;
}
