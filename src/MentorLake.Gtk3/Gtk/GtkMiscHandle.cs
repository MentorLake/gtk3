namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkMisc widget is an abstract widget which is not useful itself, but
/// is used to derive subclasses which have alignment and padding attributes.
/// </para>
/// <para>
/// The horizontal and vertical padding attributes allows extra space to be
/// added around the widget.
/// </para>
/// <para>
/// The horizontal and vertical alignment attributes enable the widget to be
/// positioned within its allocated area. Note that if the widget is added to
/// a container in such a way that it expands automatically to fill its
/// allocated area, the alignment settings will not alter the widget&apos;s position.
/// </para>
/// <para>
/// Note that the desired effect can in most cases be achieved by using the
/// #GtkWidget:halign, #GtkWidget:valign and #GtkWidget:margin properties
/// on the child widget, so GtkMisc should not be used in new code. To reflect
/// this fact, all #GtkMisc API has been deprecated.
/// </para>
/// </summary>

public class GtkMiscHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
}

public static class GtkMiscHandleExtensions
{
/// <summary>
/// <para>
/// Gets the X and Y alignment of the widget within its allocation.
/// See gtk_misc_set_alignment().
/// </para>
/// </summary>

/// <param name="misc">
/// a #GtkMisc
/// </param>
/// <param name="xalign">
/// location to store X alignment of @misc, or %NULL
/// </param>
/// <param name="yalign">
/// location to store Y alignment of @misc, or %NULL
/// </param>

	public static T GetAlignment<T>(this T misc, out float xalign, out float yalign) where T : GtkMiscHandle
	{
		if (misc.IsInvalid) throw new Exception("Invalid handle (GtkMiscHandle)");
		GtkMiscHandleExterns.gtk_misc_get_alignment(misc, out xalign, out yalign);
		return misc;
	}

/// <summary>
/// <para>
/// Gets the padding in the X and Y directions of the widget.
/// See gtk_misc_set_padding().
/// </para>
/// </summary>

/// <param name="misc">
/// a #GtkMisc
/// </param>
/// <param name="xpad">
/// location to store padding in the X
///        direction, or %NULL
/// </param>
/// <param name="ypad">
/// location to store padding in the Y
///        direction, or %NULL
/// </param>

	public static T GetPadding<T>(this T misc, out int xpad, out int ypad) where T : GtkMiscHandle
	{
		if (misc.IsInvalid) throw new Exception("Invalid handle (GtkMiscHandle)");
		GtkMiscHandleExterns.gtk_misc_get_padding(misc, out xpad, out ypad);
		return misc;
	}

/// <summary>
/// <para>
/// Sets the alignment of the widget.
/// </para>
/// </summary>

/// <param name="misc">
/// a #GtkMisc.
/// </param>
/// <param name="xalign">
/// the horizontal alignment, from 0 (left) to 1 (right).
/// </param>
/// <param name="yalign">
/// the vertical alignment, from 0 (top) to 1 (bottom).
/// </param>

	public static T SetAlignment<T>(this T misc, float xalign, float yalign) where T : GtkMiscHandle
	{
		if (misc.IsInvalid) throw new Exception("Invalid handle (GtkMiscHandle)");
		GtkMiscHandleExterns.gtk_misc_set_alignment(misc, xalign, yalign);
		return misc;
	}

/// <summary>
/// <para>
/// Sets the amount of space to add around the widget.
/// </para>
/// </summary>

/// <param name="misc">
/// a #GtkMisc.
/// </param>
/// <param name="xpad">
/// the amount of space to add on the left and right of the widget,
///   in pixels.
/// </param>
/// <param name="ypad">
/// the amount of space to add on the top and bottom of the widget,
///   in pixels.
/// </param>

	public static T SetPadding<T>(this T misc, int xpad, int ypad) where T : GtkMiscHandle
	{
		if (misc.IsInvalid) throw new Exception("Invalid handle (GtkMiscHandle)");
		GtkMiscHandleExterns.gtk_misc_set_padding(misc, xpad, ypad);
		return misc;
	}

}

internal class GtkMiscHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_misc_get_alignment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMiscHandle>))] MentorLake.Gtk.GtkMiscHandle misc, out float xalign, out float yalign);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_misc_get_padding([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMiscHandle>))] MentorLake.Gtk.GtkMiscHandle misc, out int xpad, out int ypad);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_misc_set_alignment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMiscHandle>))] MentorLake.Gtk.GtkMiscHandle misc, float xalign, float yalign);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_misc_set_padding([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMiscHandle>))] MentorLake.Gtk.GtkMiscHandle misc, int xpad, int ypad);

}
