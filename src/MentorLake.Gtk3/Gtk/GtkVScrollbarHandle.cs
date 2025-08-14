namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkVScrollbar widget is a widget arranged vertically creating a
/// scrollbar. See #GtkScrollbar for details on
/// scrollbars. #GtkAdjustment pointers may be added to handle the
/// adjustment of the scrollbar or it may be left %NULL in which case one
/// will be created for you. See #GtkScrollbar for a description of what the
/// fields in an adjustment represent for a scrollbar.
/// </para>
/// <para>
/// GtkVScrollbar has been deprecated, use #GtkScrollbar instead.
/// </para>
/// </summary>

public class GtkVScrollbarHandle : GtkScrollbarHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
/// <summary>
/// <para>
/// Creates a new vertical scrollbar.
/// </para>
/// </summary>

/// <param name="adjustment">
/// the #GtkAdjustment to use, or %NULL to create a new adjustment
/// </param>
/// <return>
/// the new #GtkVScrollbar
/// </return>

	public static MentorLake.Gtk.GtkVScrollbarHandle New(MentorLake.Gtk.GtkAdjustmentHandle adjustment)
	{
		return GtkVScrollbarHandleExterns.gtk_vscrollbar_new(adjustment);
	}

}

public static class GtkVScrollbarHandleExtensions
{
}

internal class GtkVScrollbarHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkVScrollbarHandle>))]
	internal static extern MentorLake.Gtk.GtkVScrollbarHandle gtk_vscrollbar_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

}
