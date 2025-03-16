namespace MentorLake.Pango;

public class PangoAttrColorHandle : BaseSafeHandle
{
}


public static class PangoAttrColorExtensions
{

	public static PangoAttrColor Dereference(this PangoAttrColorHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoAttrColor>(x.DangerousGetHandle());
}
internal class PangoAttrColorExterns
{
}

public struct PangoAttrColor
{
	public PangoAttribute attr;
	public PangoColor color;
}
