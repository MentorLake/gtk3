namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkViewport widget acts as an adaptor class, implementing
/// scrollability for child widgets that lack their own scrolling
/// capabilities. Use GtkViewport to scroll child widgets such as
/// #GtkGrid, #GtkBox, and so on.
/// </para>
/// <para>
/// If a widget has native scrolling abilities, such as #GtkTextView,
/// #GtkTreeView or #GtkIconView, it can be added to a #GtkScrolledWindow
/// with gtk_container_add(). If a widget does not, you must first add the
/// widget to a #GtkViewport, then add the viewport to the scrolled window.
/// gtk_container_add() does this automatically if a child that does not
/// implement #GtkScrollable is added to a #GtkScrolledWindow, so you can
/// ignore the presence of the viewport.
/// </para>
/// <para>
/// The GtkViewport will start scrolling content only if allocated less
/// than the child widget’s minimum size in a given orientation.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// GtkViewport has a single CSS node with name viewport.
/// </para>
/// </summary>

public class GtkViewportHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkScrollableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkViewport with the given adjustments, or with default
/// adjustments if none are given.
/// </para>
/// </summary>

/// <param name="hadjustment">
/// horizontal adjustment
/// </param>
/// <param name="vadjustment">
/// vertical adjustment
/// </param>
/// <return>
/// a new #GtkViewport
/// </return>

	public static MentorLake.Gtk.GtkViewportHandle New(MentorLake.Gtk.GtkAdjustmentHandle hadjustment, MentorLake.Gtk.GtkAdjustmentHandle vadjustment)
	{
		return GtkViewportHandleExterns.gtk_viewport_new(hadjustment, vadjustment);
	}

}

public static class GtkViewportHandleExtensions
{
/// <summary>
/// <para>
/// Gets the bin window of the #GtkViewport.
/// </para>
/// </summary>

/// <param name="viewport">
/// a #GtkViewport
/// </param>
/// <return>
/// a #GdkWindow
/// </return>

	public static MentorLake.Gdk.GdkWindowHandle GetBinWindow(this MentorLake.Gtk.GtkViewportHandle viewport)
	{
		if (viewport.IsInvalid) throw new Exception("Invalid handle (GtkViewportHandle)");
		return GtkViewportHandleExterns.gtk_viewport_get_bin_window(viewport);
	}

/// <summary>
/// <para>
/// Returns the horizontal adjustment of the viewport.
/// </para>
/// </summary>

/// <param name="viewport">
/// a #GtkViewport.
/// </param>
/// <return>
/// the horizontal adjustment of @viewport.
/// </return>

	public static MentorLake.Gtk.GtkAdjustmentHandle GetHadjustment(this MentorLake.Gtk.GtkViewportHandle viewport)
	{
		if (viewport.IsInvalid) throw new Exception("Invalid handle (GtkViewportHandle)");
		return GtkViewportHandleExterns.gtk_viewport_get_hadjustment(viewport);
	}

/// <summary>
/// <para>
/// Gets the shadow type of the #GtkViewport. See
/// gtk_viewport_set_shadow_type().
/// </para>
/// </summary>

/// <param name="viewport">
/// a #GtkViewport
/// </param>
/// <return>
/// the shadow type
/// </return>

	public static MentorLake.Gtk.GtkShadowType GetShadowType(this MentorLake.Gtk.GtkViewportHandle viewport)
	{
		if (viewport.IsInvalid) throw new Exception("Invalid handle (GtkViewportHandle)");
		return GtkViewportHandleExterns.gtk_viewport_get_shadow_type(viewport);
	}

/// <summary>
/// <para>
/// Returns the vertical adjustment of the viewport.
/// </para>
/// </summary>

/// <param name="viewport">
/// a #GtkViewport.
/// </param>
/// <return>
/// the vertical adjustment of @viewport.
/// </return>

	public static MentorLake.Gtk.GtkAdjustmentHandle GetVadjustment(this MentorLake.Gtk.GtkViewportHandle viewport)
	{
		if (viewport.IsInvalid) throw new Exception("Invalid handle (GtkViewportHandle)");
		return GtkViewportHandleExterns.gtk_viewport_get_vadjustment(viewport);
	}

/// <summary>
/// <para>
/// Gets the view window of the #GtkViewport.
/// </para>
/// </summary>

/// <param name="viewport">
/// a #GtkViewport
/// </param>
/// <return>
/// a #GdkWindow
/// </return>

	public static MentorLake.Gdk.GdkWindowHandle GetViewWindow(this MentorLake.Gtk.GtkViewportHandle viewport)
	{
		if (viewport.IsInvalid) throw new Exception("Invalid handle (GtkViewportHandle)");
		return GtkViewportHandleExterns.gtk_viewport_get_view_window(viewport);
	}

/// <summary>
/// <para>
/// Sets the horizontal adjustment of the viewport.
/// </para>
/// </summary>

/// <param name="viewport">
/// a #GtkViewport.
/// </param>
/// <param name="adjustment">
/// a #GtkAdjustment.
/// </param>

	public static T SetHadjustment<T>(this T viewport, MentorLake.Gtk.GtkAdjustmentHandle adjustment) where T : GtkViewportHandle
	{
		if (viewport.IsInvalid) throw new Exception("Invalid handle (GtkViewportHandle)");
		GtkViewportHandleExterns.gtk_viewport_set_hadjustment(viewport, adjustment);
		return viewport;
	}

/// <summary>
/// <para>
/// Sets the shadow type of the viewport.
/// </para>
/// </summary>

/// <param name="viewport">
/// a #GtkViewport.
/// </param>
/// <param name="type">
/// the new shadow type.
/// </param>

	public static T SetShadowType<T>(this T viewport, MentorLake.Gtk.GtkShadowType type) where T : GtkViewportHandle
	{
		if (viewport.IsInvalid) throw new Exception("Invalid handle (GtkViewportHandle)");
		GtkViewportHandleExterns.gtk_viewport_set_shadow_type(viewport, type);
		return viewport;
	}

/// <summary>
/// <para>
/// Sets the vertical adjustment of the viewport.
/// </para>
/// </summary>

/// <param name="viewport">
/// a #GtkViewport.
/// </param>
/// <param name="adjustment">
/// a #GtkAdjustment.
/// </param>

	public static T SetVadjustment<T>(this T viewport, MentorLake.Gtk.GtkAdjustmentHandle adjustment) where T : GtkViewportHandle
	{
		if (viewport.IsInvalid) throw new Exception("Invalid handle (GtkViewportHandle)");
		GtkViewportHandleExterns.gtk_viewport_set_vadjustment(viewport, adjustment);
		return viewport;
	}

}

internal class GtkViewportHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkViewportHandle>))]
	internal static extern MentorLake.Gtk.GtkViewportHandle gtk_viewport_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle hadjustment, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle vadjustment);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gtk_viewport_get_bin_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkViewportHandle>))] MentorLake.Gtk.GtkViewportHandle viewport);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))]
	internal static extern MentorLake.Gtk.GtkAdjustmentHandle gtk_viewport_get_hadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkViewportHandle>))] MentorLake.Gtk.GtkViewportHandle viewport);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkShadowType gtk_viewport_get_shadow_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkViewportHandle>))] MentorLake.Gtk.GtkViewportHandle viewport);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))]
	internal static extern MentorLake.Gtk.GtkAdjustmentHandle gtk_viewport_get_vadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkViewportHandle>))] MentorLake.Gtk.GtkViewportHandle viewport);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gtk_viewport_get_view_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkViewportHandle>))] MentorLake.Gtk.GtkViewportHandle viewport);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_viewport_set_hadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkViewportHandle>))] MentorLake.Gtk.GtkViewportHandle viewport, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_viewport_set_shadow_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkViewportHandle>))] MentorLake.Gtk.GtkViewportHandle viewport, MentorLake.Gtk.GtkShadowType type);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_viewport_set_vadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkViewportHandle>))] MentorLake.Gtk.GtkViewportHandle viewport, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

}
