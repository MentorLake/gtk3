namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkLayout is similar to #GtkDrawingArea in that it’s a “blank slate” and
/// doesn’t do anything except paint a blank background by default. It’s
/// different in that it supports scrolling natively due to implementing
/// #GtkScrollable, and can contain child widgets since it’s a #GtkContainer.
/// </para>
/// <para>
/// If you just want to draw, a #GtkDrawingArea is a better choice since it has
/// lower overhead. If you just need to position child widgets at specific
/// points, then #GtkFixed provides that functionality on its own.
/// </para>
/// <para>
/// When handling expose events on a #GtkLayout, you must draw to the #GdkWindow
/// returned by gtk_layout_get_bin_window(), rather than to the one returned by
/// gtk_widget_get_window() as you would for a #GtkDrawingArea.
/// </para>
/// </summary>

public class GtkLayoutHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkScrollableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkLayout. Unless you have a specific adjustment
/// you’d like the layout to use for scrolling, pass %NULL for
/// @hadjustment and @vadjustment.
/// </para>
/// </summary>

/// <param name="hadjustment">
/// horizontal scroll adjustment, or %NULL
/// </param>
/// <param name="vadjustment">
/// vertical scroll adjustment, or %NULL
/// </param>
/// <return>
/// a new #GtkLayout
/// </return>

	public static MentorLake.Gtk.GtkLayoutHandle New(MentorLake.Gtk.GtkAdjustmentHandle hadjustment, MentorLake.Gtk.GtkAdjustmentHandle vadjustment)
	{
		return GtkLayoutHandleExterns.gtk_layout_new(hadjustment, vadjustment);
	}

}

public static class GtkLayoutHandleExtensions
{
/// <summary>
/// <para>
/// Retrieve the bin window of the layout used for drawing operations.
/// </para>
/// </summary>

/// <param name="layout">
/// a #GtkLayout
/// </param>
/// <return>
/// a #GdkWindow
/// </return>

	public static MentorLake.Gdk.GdkWindowHandle GetBinWindow(this MentorLake.Gtk.GtkLayoutHandle layout)
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (GtkLayoutHandle)");
		return GtkLayoutHandleExterns.gtk_layout_get_bin_window(layout);
	}

/// <summary>
/// <para>
/// This function should only be called after the layout has been
/// placed in a #GtkScrolledWindow or otherwise configured for
/// scrolling. It returns the #GtkAdjustment used for communication
/// between the horizontal scrollbar and @layout.
/// </para>
/// <para>
/// See #GtkScrolledWindow, #GtkScrollbar, #GtkAdjustment for details.
/// </para>
/// </summary>

/// <param name="layout">
/// a #GtkLayout
/// </param>
/// <return>
/// horizontal scroll adjustment
/// </return>

	public static MentorLake.Gtk.GtkAdjustmentHandle GetHadjustment(this MentorLake.Gtk.GtkLayoutHandle layout)
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (GtkLayoutHandle)");
		return GtkLayoutHandleExterns.gtk_layout_get_hadjustment(layout);
	}

/// <summary>
/// <para>
/// Gets the size that has been set on the layout, and that determines
/// the total extents of the layout’s scrollbar area. See
/// gtk_layout_set_size ().
/// </para>
/// </summary>

/// <param name="layout">
/// a #GtkLayout
/// </param>
/// <param name="width">
/// location to store the width set on
///     @layout, or %NULL
/// </param>
/// <param name="height">
/// location to store the height set on
///     @layout, or %NULL
/// </param>

	public static T GetSize<T>(this T layout, out uint width, out uint height) where T : GtkLayoutHandle
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (GtkLayoutHandle)");
		GtkLayoutHandleExterns.gtk_layout_get_size(layout, out width, out height);
		return layout;
	}

/// <summary>
/// <para>
/// This function should only be called after the layout has been
/// placed in a #GtkScrolledWindow or otherwise configured for
/// scrolling. It returns the #GtkAdjustment used for communication
/// between the vertical scrollbar and @layout.
/// </para>
/// <para>
/// See #GtkScrolledWindow, #GtkScrollbar, #GtkAdjustment for details.
/// </para>
/// </summary>

/// <param name="layout">
/// a #GtkLayout
/// </param>
/// <return>
/// vertical scroll adjustment
/// </return>

	public static MentorLake.Gtk.GtkAdjustmentHandle GetVadjustment(this MentorLake.Gtk.GtkLayoutHandle layout)
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (GtkLayoutHandle)");
		return GtkLayoutHandleExterns.gtk_layout_get_vadjustment(layout);
	}

/// <summary>
/// <para>
/// Moves a current child of @layout to a new position.
/// </para>
/// </summary>

/// <param name="layout">
/// a #GtkLayout
/// </param>
/// <param name="child_widget">
/// a current child of @layout
/// </param>
/// <param name="x">
/// X position to move to
/// </param>
/// <param name="y">
/// Y position to move to
/// </param>

	public static T Move<T>(this T layout, MentorLake.Gtk.GtkWidgetHandle child_widget, int x, int y) where T : GtkLayoutHandle
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (GtkLayoutHandle)");
		GtkLayoutHandleExterns.gtk_layout_move(layout, child_widget, x, y);
		return layout;
	}

/// <summary>
/// <para>
/// Adds @child_widget to @layout, at position (@x,@y).
/// @layout becomes the new parent container of @child_widget.
/// </para>
/// </summary>

/// <param name="layout">
/// a #GtkLayout
/// </param>
/// <param name="child_widget">
/// child widget
/// </param>
/// <param name="x">
/// X position of child widget
/// </param>
/// <param name="y">
/// Y position of child widget
/// </param>

	public static T Put<T>(this T layout, MentorLake.Gtk.GtkWidgetHandle child_widget, int x, int y) where T : GtkLayoutHandle
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (GtkLayoutHandle)");
		GtkLayoutHandleExterns.gtk_layout_put(layout, child_widget, x, y);
		return layout;
	}

/// <summary>
/// <para>
/// Sets the horizontal scroll adjustment for the layout.
/// </para>
/// <para>
/// See #GtkScrolledWindow, #GtkScrollbar, #GtkAdjustment for details.
/// </para>
/// </summary>

/// <param name="layout">
/// a #GtkLayout
/// </param>
/// <param name="adjustment">
/// new scroll adjustment
/// </param>

	public static T SetHadjustment<T>(this T layout, MentorLake.Gtk.GtkAdjustmentHandle adjustment) where T : GtkLayoutHandle
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (GtkLayoutHandle)");
		GtkLayoutHandleExterns.gtk_layout_set_hadjustment(layout, adjustment);
		return layout;
	}

/// <summary>
/// <para>
/// Sets the size of the scrollable area of the layout.
/// </para>
/// </summary>

/// <param name="layout">
/// a #GtkLayout
/// </param>
/// <param name="width">
/// width of entire scrollable area
/// </param>
/// <param name="height">
/// height of entire scrollable area
/// </param>

	public static T SetSize<T>(this T layout, uint width, uint height) where T : GtkLayoutHandle
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (GtkLayoutHandle)");
		GtkLayoutHandleExterns.gtk_layout_set_size(layout, width, height);
		return layout;
	}

/// <summary>
/// <para>
/// Sets the vertical scroll adjustment for the layout.
/// </para>
/// <para>
/// See #GtkScrolledWindow, #GtkScrollbar, #GtkAdjustment for details.
/// </para>
/// </summary>

/// <param name="layout">
/// a #GtkLayout
/// </param>
/// <param name="adjustment">
/// new scroll adjustment
/// </param>

	public static T SetVadjustment<T>(this T layout, MentorLake.Gtk.GtkAdjustmentHandle adjustment) where T : GtkLayoutHandle
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (GtkLayoutHandle)");
		GtkLayoutHandleExterns.gtk_layout_set_vadjustment(layout, adjustment);
		return layout;
	}

}

internal class GtkLayoutHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkLayoutHandle>))]
	internal static extern MentorLake.Gtk.GtkLayoutHandle gtk_layout_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle hadjustment, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle vadjustment);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gtk_layout_get_bin_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLayoutHandle>))] MentorLake.Gtk.GtkLayoutHandle layout);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))]
	internal static extern MentorLake.Gtk.GtkAdjustmentHandle gtk_layout_get_hadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLayoutHandle>))] MentorLake.Gtk.GtkLayoutHandle layout);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_layout_get_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLayoutHandle>))] MentorLake.Gtk.GtkLayoutHandle layout, out uint width, out uint height);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))]
	internal static extern MentorLake.Gtk.GtkAdjustmentHandle gtk_layout_get_vadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLayoutHandle>))] MentorLake.Gtk.GtkLayoutHandle layout);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_layout_move([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLayoutHandle>))] MentorLake.Gtk.GtkLayoutHandle layout, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child_widget, int x, int y);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_layout_put([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLayoutHandle>))] MentorLake.Gtk.GtkLayoutHandle layout, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child_widget, int x, int y);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_layout_set_hadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLayoutHandle>))] MentorLake.Gtk.GtkLayoutHandle layout, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_layout_set_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLayoutHandle>))] MentorLake.Gtk.GtkLayoutHandle layout, uint width, uint height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_layout_set_vadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLayoutHandle>))] MentorLake.Gtk.GtkLayoutHandle layout, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

}
