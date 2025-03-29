namespace MentorLake.Gtk;

public class GtkHeaderBarHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkHeaderBarHandle New()
	{
		return GtkHeaderBarHandleExterns.gtk_header_bar_new();
	}

}

public static class GtkHeaderBarHandleExtensions
{
	public static MentorLake.Gtk.GtkWidgetHandle GetCustomTitle(this MentorLake.Gtk.GtkHeaderBarHandle bar)
	{
		if (bar.IsInvalid || bar.IsClosed) throw new Exception("Invalid or closed handle (GtkHeaderBarHandle)");
		return GtkHeaderBarHandleExterns.gtk_header_bar_get_custom_title(bar);
	}

	public static string GetDecorationLayout(this MentorLake.Gtk.GtkHeaderBarHandle bar)
	{
		if (bar.IsInvalid || bar.IsClosed) throw new Exception("Invalid or closed handle (GtkHeaderBarHandle)");
		return GtkHeaderBarHandleExterns.gtk_header_bar_get_decoration_layout(bar);
	}

	public static bool GetHasSubtitle(this MentorLake.Gtk.GtkHeaderBarHandle bar)
	{
		if (bar.IsInvalid || bar.IsClosed) throw new Exception("Invalid or closed handle (GtkHeaderBarHandle)");
		return GtkHeaderBarHandleExterns.gtk_header_bar_get_has_subtitle(bar);
	}

	public static bool GetShowCloseButton(this MentorLake.Gtk.GtkHeaderBarHandle bar)
	{
		if (bar.IsInvalid || bar.IsClosed) throw new Exception("Invalid or closed handle (GtkHeaderBarHandle)");
		return GtkHeaderBarHandleExterns.gtk_header_bar_get_show_close_button(bar);
	}

	public static string GetSubtitle(this MentorLake.Gtk.GtkHeaderBarHandle bar)
	{
		if (bar.IsInvalid || bar.IsClosed) throw new Exception("Invalid or closed handle (GtkHeaderBarHandle)");
		return GtkHeaderBarHandleExterns.gtk_header_bar_get_subtitle(bar);
	}

	public static string GetTitle(this MentorLake.Gtk.GtkHeaderBarHandle bar)
	{
		if (bar.IsInvalid || bar.IsClosed) throw new Exception("Invalid or closed handle (GtkHeaderBarHandle)");
		return GtkHeaderBarHandleExterns.gtk_header_bar_get_title(bar);
	}

	public static T PackEnd<T>(this T bar, MentorLake.Gtk.GtkWidgetHandle child) where T : GtkHeaderBarHandle
	{
		if (bar.IsInvalid || bar.IsClosed) throw new Exception("Invalid or closed handle (GtkHeaderBarHandle)");
		GtkHeaderBarHandleExterns.gtk_header_bar_pack_end(bar, child);
		return bar;
	}

	public static T PackStart<T>(this T bar, MentorLake.Gtk.GtkWidgetHandle child) where T : GtkHeaderBarHandle
	{
		if (bar.IsInvalid || bar.IsClosed) throw new Exception("Invalid or closed handle (GtkHeaderBarHandle)");
		GtkHeaderBarHandleExterns.gtk_header_bar_pack_start(bar, child);
		return bar;
	}

	public static T SetCustomTitle<T>(this T bar, MentorLake.Gtk.GtkWidgetHandle title_widget) where T : GtkHeaderBarHandle
	{
		if (bar.IsInvalid || bar.IsClosed) throw new Exception("Invalid or closed handle (GtkHeaderBarHandle)");
		GtkHeaderBarHandleExterns.gtk_header_bar_set_custom_title(bar, title_widget);
		return bar;
	}

	public static T SetDecorationLayout<T>(this T bar, string layout) where T : GtkHeaderBarHandle
	{
		if (bar.IsInvalid || bar.IsClosed) throw new Exception("Invalid or closed handle (GtkHeaderBarHandle)");
		GtkHeaderBarHandleExterns.gtk_header_bar_set_decoration_layout(bar, layout);
		return bar;
	}

	public static T SetHasSubtitle<T>(this T bar, bool setting) where T : GtkHeaderBarHandle
	{
		if (bar.IsInvalid || bar.IsClosed) throw new Exception("Invalid or closed handle (GtkHeaderBarHandle)");
		GtkHeaderBarHandleExterns.gtk_header_bar_set_has_subtitle(bar, setting);
		return bar;
	}

	public static T SetShowCloseButton<T>(this T bar, bool setting) where T : GtkHeaderBarHandle
	{
		if (bar.IsInvalid || bar.IsClosed) throw new Exception("Invalid or closed handle (GtkHeaderBarHandle)");
		GtkHeaderBarHandleExterns.gtk_header_bar_set_show_close_button(bar, setting);
		return bar;
	}

	public static T SetSubtitle<T>(this T bar, string subtitle) where T : GtkHeaderBarHandle
	{
		if (bar.IsInvalid || bar.IsClosed) throw new Exception("Invalid or closed handle (GtkHeaderBarHandle)");
		GtkHeaderBarHandleExterns.gtk_header_bar_set_subtitle(bar, subtitle);
		return bar;
	}

	public static T SetTitle<T>(this T bar, string title) where T : GtkHeaderBarHandle
	{
		if (bar.IsInvalid || bar.IsClosed) throw new Exception("Invalid or closed handle (GtkHeaderBarHandle)");
		GtkHeaderBarHandleExterns.gtk_header_bar_set_title(bar, title);
		return bar;
	}

}

internal class GtkHeaderBarHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkHeaderBarHandle gtk_header_bar_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_header_bar_get_custom_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHeaderBarHandle>))] MentorLake.Gtk.GtkHeaderBarHandle bar);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_header_bar_get_decoration_layout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHeaderBarHandle>))] MentorLake.Gtk.GtkHeaderBarHandle bar);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_header_bar_get_has_subtitle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHeaderBarHandle>))] MentorLake.Gtk.GtkHeaderBarHandle bar);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_header_bar_get_show_close_button([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHeaderBarHandle>))] MentorLake.Gtk.GtkHeaderBarHandle bar);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_header_bar_get_subtitle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHeaderBarHandle>))] MentorLake.Gtk.GtkHeaderBarHandle bar);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_header_bar_get_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHeaderBarHandle>))] MentorLake.Gtk.GtkHeaderBarHandle bar);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_header_bar_pack_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHeaderBarHandle>))] MentorLake.Gtk.GtkHeaderBarHandle bar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_header_bar_pack_start([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHeaderBarHandle>))] MentorLake.Gtk.GtkHeaderBarHandle bar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_header_bar_set_custom_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHeaderBarHandle>))] MentorLake.Gtk.GtkHeaderBarHandle bar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle title_widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_header_bar_set_decoration_layout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHeaderBarHandle>))] MentorLake.Gtk.GtkHeaderBarHandle bar, string layout);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_header_bar_set_has_subtitle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHeaderBarHandle>))] MentorLake.Gtk.GtkHeaderBarHandle bar, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_header_bar_set_show_close_button([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHeaderBarHandle>))] MentorLake.Gtk.GtkHeaderBarHandle bar, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_header_bar_set_subtitle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHeaderBarHandle>))] MentorLake.Gtk.GtkHeaderBarHandle bar, string subtitle);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_header_bar_set_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHeaderBarHandle>))] MentorLake.Gtk.GtkHeaderBarHandle bar, string title);

}
