namespace MentorLake.Gtk;

public class GtkLayoutHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkScrollableHandle
{
	public static MentorLake.Gtk.GtkLayoutHandle New(MentorLake.Gtk.GtkAdjustmentHandle hadjustment, MentorLake.Gtk.GtkAdjustmentHandle vadjustment)
	{
		return GtkLayoutHandleExterns.gtk_layout_new(hadjustment, vadjustment);
	}

}

public static class GtkLayoutHandleExtensions
{
	public static MentorLake.Gdk.GdkWindowHandle GetBinWindow(this MentorLake.Gtk.GtkLayoutHandle layout)
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (GtkLayoutHandle)");
		return GtkLayoutHandleExterns.gtk_layout_get_bin_window(layout);
	}

	public static MentorLake.Gtk.GtkAdjustmentHandle GetHadjustment(this MentorLake.Gtk.GtkLayoutHandle layout)
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (GtkLayoutHandle)");
		return GtkLayoutHandleExterns.gtk_layout_get_hadjustment(layout);
	}

	public static T GetSize<T>(this T layout, out uint width, out uint height) where T : GtkLayoutHandle
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (GtkLayoutHandle)");
		GtkLayoutHandleExterns.gtk_layout_get_size(layout, out width, out height);
		return layout;
	}

	public static MentorLake.Gtk.GtkAdjustmentHandle GetVadjustment(this MentorLake.Gtk.GtkLayoutHandle layout)
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (GtkLayoutHandle)");
		return GtkLayoutHandleExterns.gtk_layout_get_vadjustment(layout);
	}

	public static T Move<T>(this T layout, MentorLake.Gtk.GtkWidgetHandle child_widget, int x, int y) where T : GtkLayoutHandle
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (GtkLayoutHandle)");
		GtkLayoutHandleExterns.gtk_layout_move(layout, child_widget, x, y);
		return layout;
	}

	public static T Put<T>(this T layout, MentorLake.Gtk.GtkWidgetHandle child_widget, int x, int y) where T : GtkLayoutHandle
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (GtkLayoutHandle)");
		GtkLayoutHandleExterns.gtk_layout_put(layout, child_widget, x, y);
		return layout;
	}

	public static T SetHadjustment<T>(this T layout, MentorLake.Gtk.GtkAdjustmentHandle adjustment) where T : GtkLayoutHandle
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (GtkLayoutHandle)");
		GtkLayoutHandleExterns.gtk_layout_set_hadjustment(layout, adjustment);
		return layout;
	}

	public static T SetSize<T>(this T layout, uint width, uint height) where T : GtkLayoutHandle
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (GtkLayoutHandle)");
		GtkLayoutHandleExterns.gtk_layout_set_size(layout, width, height);
		return layout;
	}

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
