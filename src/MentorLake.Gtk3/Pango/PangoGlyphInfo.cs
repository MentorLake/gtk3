namespace MentorLake.Pango;

public class PangoGlyphInfoHandle : BaseSafeHandle
{
}


public static class PangoGlyphInfoExtensions
{

	public static PangoGlyphInfo Dereference(this PangoGlyphInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoGlyphInfo>(x.DangerousGetHandle());
}
internal class PangoGlyphInfoExterns
{
}

public struct PangoGlyphInfo
{
	public PangoGlyph glyph;
	public PangoGlyphGeometry geometry;
	public PangoGlyphVisAttr attr;
}
