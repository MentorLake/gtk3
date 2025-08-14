namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkAlignment widget controls the alignment and size of its child widget.
/// It has four settings: xscale, yscale, xalign, and yalign.
/// </para>
/// <para>
/// The scale settings are used to specify how much the child widget should
/// expand to fill the space allocated to the #GtkAlignment.
/// The values can range from 0 (meaning the child doesn’t expand at all) to
/// 1 (meaning the child expands to fill all of the available space).
/// </para>
/// <para>
/// The align settings are used to place the child widget within the available
/// area. The values range from 0 (top or left) to 1 (bottom or right).
/// Of course, if the scale settings are both set to 1, the alignment settings
/// have no effect.
/// </para>
/// <para>
/// GtkAlignment has been deprecated in 3.14 and should not be used in
/// newly-written code. The desired effect can be achieved by using the
/// #GtkWidget:halign, #GtkWidget:valign and #GtkWidget:margin properties on the
/// child widget.
/// </para>
/// </summary>

public class GtkAlignmentHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkAlignment.
/// </para>
/// </summary>

/// <param name="xalign">
/// the horizontal alignment of the child widget, from 0 (left) to 1
///  (right).
/// </param>
/// <param name="yalign">
/// the vertical alignment of the child widget, from 0 (top) to 1
///  (bottom).
/// </param>
/// <param name="xscale">
/// the amount that the child widget expands horizontally to fill up
///  unused space, from 0 to 1.
///  A value of 0 indicates that the child widget should never expand.
///  A value of 1 indicates that the child widget will expand to fill all of the
///  space allocated for the #GtkAlignment.
/// </param>
/// <param name="yscale">
/// the amount that the child widget expands vertically to fill up
///  unused space, from 0 to 1. The values are similar to @xscale.
/// </param>
/// <return>
/// the new #GtkAlignment
/// </return>

	public static MentorLake.Gtk.GtkAlignmentHandle New(float xalign, float yalign, float xscale, float yscale)
	{
		return GtkAlignmentHandleExterns.gtk_alignment_new(xalign, yalign, xscale, yscale);
	}

}

public static class GtkAlignmentHandleExtensions
{
/// <summary>
/// <para>
/// Gets the padding on the different sides of the widget.
/// See gtk_alignment_set_padding ().
/// </para>
/// </summary>

/// <param name="alignment">
/// a #GtkAlignment
/// </param>
/// <param name="padding_top">
/// location to store the padding for
///     the top of the widget, or %NULL
/// </param>
/// <param name="padding_bottom">
/// location to store the padding
///     for the bottom of the widget, or %NULL
/// </param>
/// <param name="padding_left">
/// location to store the padding
///     for the left of the widget, or %NULL
/// </param>
/// <param name="padding_right">
/// location to store the padding
///     for the right of the widget, or %NULL
/// </param>

	public static T GetPadding<T>(this T alignment, out uint padding_top, out uint padding_bottom, out uint padding_left, out uint padding_right) where T : GtkAlignmentHandle
	{
		if (alignment.IsInvalid) throw new Exception("Invalid handle (GtkAlignmentHandle)");
		GtkAlignmentHandleExterns.gtk_alignment_get_padding(alignment, out padding_top, out padding_bottom, out padding_left, out padding_right);
		return alignment;
	}

/// <summary>
/// <para>
/// Sets the #GtkAlignment values.
/// </para>
/// </summary>

/// <param name="alignment">
/// a #GtkAlignment.
/// </param>
/// <param name="xalign">
/// the horizontal alignment of the child widget, from 0 (left) to 1
///  (right).
/// </param>
/// <param name="yalign">
/// the vertical alignment of the child widget, from 0 (top) to 1
///  (bottom).
/// </param>
/// <param name="xscale">
/// the amount that the child widget expands horizontally to fill up
///  unused space, from 0 to 1.
///  A value of 0 indicates that the child widget should never expand.
///  A value of 1 indicates that the child widget will expand to fill all of the
///  space allocated for the #GtkAlignment.
/// </param>
/// <param name="yscale">
/// the amount that the child widget expands vertically to fill up
///  unused space, from 0 to 1. The values are similar to @xscale.
/// </param>

	public static T Set<T>(this T alignment, float xalign, float yalign, float xscale, float yscale) where T : GtkAlignmentHandle
	{
		if (alignment.IsInvalid) throw new Exception("Invalid handle (GtkAlignmentHandle)");
		GtkAlignmentHandleExterns.gtk_alignment_set(alignment, xalign, yalign, xscale, yscale);
		return alignment;
	}

/// <summary>
/// <para>
/// Sets the padding on the different sides of the widget.
/// The padding adds blank space to the sides of the widget. For instance,
/// this can be used to indent the child widget towards the right by adding
/// padding on the left.
/// </para>
/// </summary>

/// <param name="alignment">
/// a #GtkAlignment
/// </param>
/// <param name="padding_top">
/// the padding at the top of the widget
/// </param>
/// <param name="padding_bottom">
/// the padding at the bottom of the widget
/// </param>
/// <param name="padding_left">
/// the padding at the left of the widget
/// </param>
/// <param name="padding_right">
/// the padding at the right of the widget.
/// </param>

	public static T SetPadding<T>(this T alignment, uint padding_top, uint padding_bottom, uint padding_left, uint padding_right) where T : GtkAlignmentHandle
	{
		if (alignment.IsInvalid) throw new Exception("Invalid handle (GtkAlignmentHandle)");
		GtkAlignmentHandleExterns.gtk_alignment_set_padding(alignment, padding_top, padding_bottom, padding_left, padding_right);
		return alignment;
	}

}

internal class GtkAlignmentHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkAlignmentHandle>))]
	internal static extern MentorLake.Gtk.GtkAlignmentHandle gtk_alignment_new(float xalign, float yalign, float xscale, float yscale);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_alignment_get_padding([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAlignmentHandle>))] MentorLake.Gtk.GtkAlignmentHandle alignment, out uint padding_top, out uint padding_bottom, out uint padding_left, out uint padding_right);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_alignment_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAlignmentHandle>))] MentorLake.Gtk.GtkAlignmentHandle alignment, float xalign, float yalign, float xscale, float yscale);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_alignment_set_padding([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAlignmentHandle>))] MentorLake.Gtk.GtkAlignmentHandle alignment, uint padding_top, uint padding_bottom, uint padding_left, uint padding_right);

}
