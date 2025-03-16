namespace MentorLake.Pango;

public class PangoAttrClassHandle : BaseSafeHandle
{
}


public static class PangoAttrClassExtensions
{

	public static PangoAttrClass Dereference(this PangoAttrClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoAttrClass>(x.DangerousGetHandle());
}
internal class PangoAttrClassExterns
{
}

public struct PangoAttrClass
{
	public PangoAttrType type;
	public IntPtr copy;
	public IntPtr destroy;
	public IntPtr equal;
}
