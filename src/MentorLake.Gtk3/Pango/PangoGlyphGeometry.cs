namespace MentorLake.Pango;

public class PangoGlyphGeometryHandle : BaseSafeHandle
{
}


public static class PangoGlyphGeometryExtensions
{

	public static PangoGlyphGeometry Dereference(this PangoGlyphGeometryHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoGlyphGeometry>(x.DangerousGetHandle());
}
internal class PangoGlyphGeometryExterns
{
}

public struct PangoGlyphGeometry
{
	public PangoGlyphUnit width;
	public PangoGlyphUnit x_offset;
	public PangoGlyphUnit y_offset;
}
