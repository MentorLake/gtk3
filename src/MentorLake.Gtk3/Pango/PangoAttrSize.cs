namespace MentorLake.Gtk3.Pango;

public class PangoAttrSizeHandle : BaseSafeHandle
{
}


public static class PangoAttrSizeHandleExtensions
{
	public static PangoAttributeHandle New(int size)
	{
		return PangoAttrSizeExterns.pango_attr_size_new(size);
	}

	public static PangoAttributeHandle NewAbsolute(int size)
	{
		return PangoAttrSizeExterns.pango_attr_size_new_absolute(size);
	}

}
internal class PangoAttrSizeExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern PangoAttributeHandle pango_attr_size_new(int size);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttributeHandle pango_attr_size_new_absolute(int size);

}

public struct PangoAttrSize
{
	public PangoAttribute attr;
	public int size;
	public uint absolute;
}
