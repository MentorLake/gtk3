namespace MentorLake.Pango;

public class PangoAttrIntHandle : BaseSafeHandle
{
}


public static class PangoAttrIntExtensions
{

	public static PangoAttrInt Dereference(this PangoAttrIntHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoAttrInt>(x.DangerousGetHandle());
}
internal class PangoAttrIntExterns
{
}

public struct PangoAttrInt
{
	public PangoAttribute attr;
	public int value;
}
