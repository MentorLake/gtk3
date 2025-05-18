namespace MentorLake.Pango;

public class PangoAttrShapeHandle : BaseSafeHandle
{
}


public static class PangoAttrShapeExtensions
{

	public static PangoAttrShape Dereference(this PangoAttrShapeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoAttrShape>(x.DangerousGetHandle());
}
internal class PangoAttrShapeExterns
{
	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_shape_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoRectangleHandle>))] MentorLake.Pango.PangoRectangleHandle ink_rect, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoRectangleHandle>))] MentorLake.Pango.PangoRectangleHandle logical_rect);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_shape_new_with_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoRectangleHandle>))] MentorLake.Pango.PangoRectangleHandle ink_rect, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoRectangleHandle>))] MentorLake.Pango.PangoRectangleHandle logical_rect, IntPtr data, MentorLake.Pango.PangoAttrDataCopyFunc copy_func, MentorLake.GLib.GDestroyNotify destroy_func);

}

public struct PangoAttrShape
{
	public PangoAttribute attr;
	public PangoRectangle ink_rect;
	public PangoRectangle logical_rect;
	public IntPtr data;
	public PangoAttrDataCopyFunc copy_func;
	public GDestroyNotify destroy_func;
	public static MentorLake.Pango.PangoAttributeHandle New(MentorLake.Pango.PangoRectangleHandle ink_rect, MentorLake.Pango.PangoRectangleHandle logical_rect)
	{
		return PangoAttrShapeExterns.pango_attr_shape_new(ink_rect, logical_rect);
	}

	public static MentorLake.Pango.PangoAttributeHandle NewWithData(MentorLake.Pango.PangoRectangleHandle ink_rect, MentorLake.Pango.PangoRectangleHandle logical_rect, IntPtr data, MentorLake.Pango.PangoAttrDataCopyFunc copy_func, MentorLake.GLib.GDestroyNotify destroy_func)
	{
		return PangoAttrShapeExterns.pango_attr_shape_new_with_data(ink_rect, logical_rect, data, copy_func, destroy_func);
	}

}
