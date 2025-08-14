namespace MentorLake.Pango;

/// <summary>
/// <para>
/// The `PangoAttrShape` structure is used to represent attributes which
/// impose shape restrictions.
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// The `PangoAttrShape` structure is used to represent attributes which
/// impose shape restrictions.
/// </para>
/// </summary>

public struct PangoAttrShape
{
	/// <summary>
/// <para>
/// the common portion of the attribute
/// </para>
/// </summary>

public PangoAttribute attr;
	/// <summary>
/// <para>
/// the ink rectangle to restrict to
/// </para>
/// </summary>

public PangoRectangle ink_rect;
	/// <summary>
/// <para>
/// the logical rectangle to restrict to
/// </para>
/// </summary>

public PangoRectangle logical_rect;
	/// <summary>
/// <para>
/// user data set (see [func@Pango.AttrShape.new_with_data])
/// </para>
/// </summary>

public IntPtr data;
	/// <summary>
/// <para>
/// copy function for the user data
/// </para>
/// </summary>

public PangoAttrDataCopyFunc copy_func;
	/// <summary>
/// <para>
/// destroy function for the user data
/// </para>
/// </summary>

public GDestroyNotify destroy_func;
/// <summary>
/// <para>
/// Create a new shape attribute.
/// </para>
/// <para>
/// A shape is used to impose a particular ink and logical
/// rectangle on the result of shaping a particular glyph.
/// This might be used, for instance, for embedding a picture
/// or a widget inside a `PangoLayout`.
/// </para>
/// </summary>

/// <param name="ink_rect">
/// ink rectangle to assign to each character
/// </param>
/// <param name="logical_rect">
/// logical rectangle to assign to each character
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle New(MentorLake.Pango.PangoRectangleHandle ink_rect, MentorLake.Pango.PangoRectangleHandle logical_rect)
	{
		return PangoAttrShapeExterns.pango_attr_shape_new(ink_rect, logical_rect);
	}

/// <summary>
/// <para>
/// Creates a new shape attribute.
/// </para>
/// <para>
/// Like [func@Pango.AttrShape.new], but a user data pointer
/// is also provided; this pointer can be accessed when later
/// rendering the glyph.
/// </para>
/// </summary>

/// <param name="ink_rect">
/// ink rectangle to assign to each character
/// </param>
/// <param name="logical_rect">
/// logical rectangle to assign to each character
/// </param>
/// <param name="data">
/// user data pointer
/// </param>
/// <param name="copy_func">
/// function to copy @data when the
///   attribute is copied. If %NULL, @data is simply copied
///   as a pointer
/// </param>
/// <param name="destroy_func">
/// function to free @data when the
///   attribute is freed
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle NewWithData(MentorLake.Pango.PangoRectangleHandle ink_rect, MentorLake.Pango.PangoRectangleHandle logical_rect, IntPtr data, MentorLake.Pango.PangoAttrDataCopyFunc copy_func, MentorLake.GLib.GDestroyNotify destroy_func)
	{
		return PangoAttrShapeExterns.pango_attr_shape_new_with_data(ink_rect, logical_rect, data, copy_func, destroy_func);
	}

}
