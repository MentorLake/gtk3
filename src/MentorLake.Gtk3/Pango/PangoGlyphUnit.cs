namespace MentorLake.Pango;

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
