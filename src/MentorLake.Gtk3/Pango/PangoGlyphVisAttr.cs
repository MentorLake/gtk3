namespace MentorLake.Pango;

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

public struct PangoGlyphVisAttr
{
	public uint is_cluster_start;
}
