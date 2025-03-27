namespace MentorLake.Pango;

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
