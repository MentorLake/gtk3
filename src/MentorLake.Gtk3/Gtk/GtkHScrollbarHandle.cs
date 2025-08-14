namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkHScrollbar widget is a widget arranged horizontally creating a
/// scrollbar. See #GtkScrollbar for details on
/// scrollbars. #GtkAdjustment pointers may be added to handle the
/// adjustment of the scrollbar or it may be left %NULL in which case one
/// will be created for you. See #GtkScrollbar for a description of what the
/// fields in an adjustment represent for a scrollbar.
/// </para>
/// <para>
/// GtkHScrollbar has been deprecated, use #GtkScrollbar instead.
/// </para>
/// </summary>

public class GtkHScrollbarHandle : GtkScrollbarHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
/// <summary>
/// <para>
/// Creates a new horizontal scrollbar.
/// </para>
/// </summary>

/// <param name="adjustment">
/// the #GtkAdjustment to use, or %NULL to create a new adjustment
/// </param>
/// <return>
/// the new #GtkHScrollbar
/// </return>

	public static MentorLake.Gtk.GtkHScrollbarHandle New(MentorLake.Gtk.GtkAdjustmentHandle adjustment)
	{
		return GtkHScrollbarHandleExterns.gtk_hscrollbar_new(adjustment);
	}

}

public static class GtkHScrollbarHandleExtensions
{
}

internal class GtkHScrollbarHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkHScrollbarHandle>))]
	internal static extern MentorLake.Gtk.GtkHScrollbarHandle gtk_hscrollbar_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

}
