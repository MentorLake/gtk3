namespace MentorLake.Gtk3.Pango;

public class PangoAttrShapeHandle : BaseSafeHandle
{
}


public static class PangoAttrShapeHandleExtensions
{
	public static PangoAttributeHandle New(PangoRectangleHandle ink_rect, PangoRectangleHandle logical_rect)
	{
		return PangoAttrShapeExterns.pango_attr_shape_new(ink_rect, logical_rect);
	}

	public static PangoAttributeHandle NewWithData(PangoRectangleHandle ink_rect, PangoRectangleHandle logical_rect, IntPtr data, PangoAttrDataCopyFunc copy_func, GDestroyNotify destroy_func)
	{
		return PangoAttrShapeExterns.pango_attr_shape_new_with_data(ink_rect, logical_rect, data, copy_func, destroy_func);
	}

}
internal class PangoAttrShapeExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern PangoAttributeHandle pango_attr_shape_new(PangoRectangleHandle ink_rect, PangoRectangleHandle logical_rect);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttributeHandle pango_attr_shape_new_with_data(PangoRectangleHandle ink_rect, PangoRectangleHandle logical_rect, IntPtr data, PangoAttrDataCopyFunc copy_func, GDestroyNotify destroy_func);

}

public struct PangoAttrShape
{
	public PangoAttribute attr;
	public PangoRectangle ink_rect;
	public PangoRectangle logical_rect;
	public IntPtr data;
	public PangoAttrDataCopyFunc copy_func;
	public GDestroyNotify destroy_func;
}
