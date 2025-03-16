namespace MentorLake.Pango;

public class PangoAttrStringHandle : BaseSafeHandle
{
}


public static class PangoAttrStringExtensions
{

	public static PangoAttrString Dereference(this PangoAttrStringHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoAttrString>(x.DangerousGetHandle());
}
internal class PangoAttrStringExterns
{
}

public struct PangoAttrString
{
	public PangoAttribute attr;
	public string value;
}
