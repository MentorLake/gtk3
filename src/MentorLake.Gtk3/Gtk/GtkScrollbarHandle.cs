namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkScrollbar widget is a horizontal or vertical scrollbar,
/// depending on the value of the #GtkOrientable:orientation property.
/// </para>
/// <para>
/// Its position and movement are controlled by the adjustment that is passed to
/// or created by gtk_scrollbar_new(). See #GtkAdjustment for more details. The
/// #GtkAdjustment:value field sets the position of the thumb and must be between
/// #GtkAdjustment:lower and #GtkAdjustment:upper - #GtkAdjustment:page-size. The
/// #GtkAdjustment:page-size represents the size of the visible scrollable area.
/// The fields #GtkAdjustment:step-increment and #GtkAdjustment:page-increment
/// fields are added to or subtracted from the #GtkAdjustment:value when the user
/// asks to move by a step (using e.g. the cursor arrow keys or, if present, the
/// stepper buttons) or by a page (using e.g. the Page Down/Up keys).
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <code>
/// scrollbar[.fine-tune]
/// scrollbar[.fine-tune]
/// ╰── contents
///     ├── [button.up]
///     ├── [button.down]
///     ├── trough
///     │   ╰── slider
///     ├── [button.up]
///     ╰── [button.down]
/// </code>
/// <para>
/// GtkScrollbar has a main CSS node with name scrollbar and a subnode for its
/// contents, with subnodes named trough and slider.
/// </para>
/// <para>
/// The main node gets the style class .fine-tune added when the scrollbar is
/// in &apos;fine-tuning&apos; mode.
/// </para>
/// <para>
/// If steppers are enabled, they are represented by up to four additional
/// subnodes with name button. These get the style classes .up and .down to
/// indicate in which direction they are moving.
/// </para>
/// <para>
/// Other style classes that may be added to scrollbars inside #GtkScrolledWindow
/// include the positional classes (.left, .right, .top, .bottom) and style
/// classes related to overlay scrolling (.overlay-indicator, .dragging, .hovering).
/// </para>
/// </summary>

public class GtkScrollbarHandle : GtkRangeHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
/// <summary>
/// <para>
/// Creates a new scrollbar with the given orientation.
/// </para>
/// </summary>

/// <param name="orientation">
/// the scrollbar’s orientation.
/// </param>
/// <param name="adjustment">
/// the #GtkAdjustment to use, or %NULL to create a new adjustment.
/// </param>
/// <return>
/// the new #GtkScrollbar.
/// </return>

	public static MentorLake.Gtk.GtkScrollbarHandle New(MentorLake.Gtk.GtkOrientation orientation, MentorLake.Gtk.GtkAdjustmentHandle adjustment)
	{
		return GtkScrollbarHandleExterns.gtk_scrollbar_new(orientation, adjustment);
	}

}

public static class GtkScrollbarHandleExtensions
{
}

internal class GtkScrollbarHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkScrollbarHandle>))]
	internal static extern MentorLake.Gtk.GtkScrollbarHandle gtk_scrollbar_new(MentorLake.Gtk.GtkOrientation orientation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

}
