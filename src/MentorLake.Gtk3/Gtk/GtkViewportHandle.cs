namespace MentorLake.Gtk;

public class GtkViewportHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkScrollableHandle
{
	public static MentorLake.Gtk.GtkViewportHandle New(MentorLake.Gtk.GtkAdjustmentHandle hadjustment, MentorLake.Gtk.GtkAdjustmentHandle vadjustment)
	{
		return GtkViewportHandleExterns.gtk_viewport_new(hadjustment, vadjustment);
	}

}

public static class GtkViewportHandleExtensions
{
	public static MentorLake.Gdk.GdkWindowHandle GetBinWindow(this MentorLake.Gtk.GtkViewportHandle viewport)
	{
		if (viewport.IsInvalid) throw new Exception("Invalid handle (GtkViewportHandle)");
		return GtkViewportHandleExterns.gtk_viewport_get_bin_window(viewport);
	}

	public static MentorLake.Gtk.GtkAdjustmentHandle GetHadjustment(this MentorLake.Gtk.GtkViewportHandle viewport)
	{
		if (viewport.IsInvalid) throw new Exception("Invalid handle (GtkViewportHandle)");
		return GtkViewportHandleExterns.gtk_viewport_get_hadjustment(viewport);
	}

	public static MentorLake.Gtk.GtkShadowType GetShadowType(this MentorLake.Gtk.GtkViewportHandle viewport)
	{
		if (viewport.IsInvalid) throw new Exception("Invalid handle (GtkViewportHandle)");
		return GtkViewportHandleExterns.gtk_viewport_get_shadow_type(viewport);
	}

	public static MentorLake.Gtk.GtkAdjustmentHandle GetVadjustment(this MentorLake.Gtk.GtkViewportHandle viewport)
	{
		if (viewport.IsInvalid) throw new Exception("Invalid handle (GtkViewportHandle)");
		return GtkViewportHandleExterns.gtk_viewport_get_vadjustment(viewport);
	}

	public static MentorLake.Gdk.GdkWindowHandle GetViewWindow(this MentorLake.Gtk.GtkViewportHandle viewport)
	{
		if (viewport.IsInvalid) throw new Exception("Invalid handle (GtkViewportHandle)");
		return GtkViewportHandleExterns.gtk_viewport_get_view_window(viewport);
	}

	public static T SetHadjustment<T>(this T viewport, MentorLake.Gtk.GtkAdjustmentHandle adjustment) where T : GtkViewportHandle
	{
		if (viewport.IsInvalid) throw new Exception("Invalid handle (GtkViewportHandle)");
		GtkViewportHandleExterns.gtk_viewport_set_hadjustment(viewport, adjustment);
		return viewport;
	}

	public static T SetShadowType<T>(this T viewport, MentorLake.Gtk.GtkShadowType type) where T : GtkViewportHandle
	{
		if (viewport.IsInvalid) throw new Exception("Invalid handle (GtkViewportHandle)");
		GtkViewportHandleExterns.gtk_viewport_set_shadow_type(viewport, type);
		return viewport;
	}

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
