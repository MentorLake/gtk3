namespace MentorLake.Pango;

public class PangoAttrSizeHandle : BaseSafeHandle
{
}


public static class PangoAttrSizeExtensions
{

	public static PangoAttrSize Dereference(this PangoAttrSizeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoAttrSize>(x.DangerousGetHandle());
}
internal class PangoAttrSizeExterns
{
	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_size_new(int size);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_size_new_absolute(int size);

}

public struct PangoAttrSize
{
	public PangoAttribute attr;
	public int size;
	public uint absolute;
	public static MentorLake.Pango.PangoAttributeHandle New(int size)
	{
		return PangoAttrSizeExterns.pango_attr_size_new(size);
	}

	public static MentorLake.Pango.PangoAttributeHandle NewAbsolute(int size)
	{
		return PangoAttrSizeExterns.pango_attr_size_new_absolute(size);
	}

}
