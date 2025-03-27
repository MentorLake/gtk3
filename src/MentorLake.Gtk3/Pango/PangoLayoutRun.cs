namespace MentorLake.Pango;

public struct PangoLayoutRun
{
	public MentorLake.Pango.PangoGlyphItem Value;
}

public class PangoLayoutRunHandle : BaseSafeHandle
{
}

public static class PangoLayoutRunHandleExtensions
{
	public static PangoLayoutRun Dereference(this PangoLayoutRunHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoLayoutRun>(x.DangerousGetHandle());
	public static MentorLake.Pango.PangoGlyphItem DereferenceValue(this PangoLayoutRunHandle x) => x.Dereference().Value;
}
