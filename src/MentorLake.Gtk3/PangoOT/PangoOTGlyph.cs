namespace MentorLake.PangoOT;

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

public struct PangoOTGlyph
{
	public uint glyph;
	public uint properties;
	public uint cluster;
	public ushort component;
	public ushort ligID;
	public uint @internal;
}
