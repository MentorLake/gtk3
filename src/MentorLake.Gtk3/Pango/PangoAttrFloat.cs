namespace MentorLake.Pango;

public class PangoAttrFloatHandle : BaseSafeHandle
{
}


public static class PangoAttrFloatExtensions
{

	public static PangoAttrFloat Dereference(this PangoAttrFloatHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoAttrFloat>(x.DangerousGetHandle());
}
internal class PangoAttrFloatExterns
{
}

public struct PangoAttrFloat
{
	public PangoAttribute attr;
	public double value;
}
