namespace MentorLake.Gtk;

public class GtkSearchBarHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkSearchBarHandle New()
	{
		return GtkSearchBarHandleExterns.gtk_search_bar_new();
	}

}

public static class GtkSearchBarHandleExtensions
{
	public static T ConnectEntry<T>(this T bar, MentorLake.Gtk.GtkEntryHandle entry) where T : GtkSearchBarHandle
	{
		if (bar.IsInvalid) throw new Exception("Invalid handle (GtkSearchBarHandle)");
		GtkSearchBarHandleExterns.gtk_search_bar_connect_entry(bar, entry);
		return bar;
	}

	public static bool GetSearchMode(this MentorLake.Gtk.GtkSearchBarHandle bar)
	{
		if (bar.IsInvalid) throw new Exception("Invalid handle (GtkSearchBarHandle)");
		return GtkSearchBarHandleExterns.gtk_search_bar_get_search_mode(bar);
	}

	public static bool GetShowCloseButton(this MentorLake.Gtk.GtkSearchBarHandle bar)
	{
		if (bar.IsInvalid) throw new Exception("Invalid handle (GtkSearchBarHandle)");
		return GtkSearchBarHandleExterns.gtk_search_bar_get_show_close_button(bar);
	}

	public static bool HandleEvent(this MentorLake.Gtk.GtkSearchBarHandle bar, MentorLake.Gdk.GdkEventHandle @event)
	{
		if (bar.IsInvalid) throw new Exception("Invalid handle (GtkSearchBarHandle)");
		return GtkSearchBarHandleExterns.gtk_search_bar_handle_event(bar, @event);
	}

	public static T SetSearchMode<T>(this T bar, bool search_mode) where T : GtkSearchBarHandle
	{
		if (bar.IsInvalid) throw new Exception("Invalid handle (GtkSearchBarHandle)");
		GtkSearchBarHandleExterns.gtk_search_bar_set_search_mode(bar, search_mode);
		return bar;
	}

	public static T SetShowCloseButton<T>(this T bar, bool visible) where T : GtkSearchBarHandle
	{
		if (bar.IsInvalid) throw new Exception("Invalid handle (GtkSearchBarHandle)");
		GtkSearchBarHandleExterns.gtk_search_bar_set_show_close_button(bar, visible);
		return bar;
	}

}

internal class GtkSearchBarHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkSearchBarHandle>))]
	internal static extern MentorLake.Gtk.GtkSearchBarHandle gtk_search_bar_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_search_bar_connect_entry([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSearchBarHandle>))] MentorLake.Gtk.GtkSearchBarHandle bar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_search_bar_get_search_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSearchBarHandle>))] MentorLake.Gtk.GtkSearchBarHandle bar);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_search_bar_get_show_close_button([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSearchBarHandle>))] MentorLake.Gtk.GtkSearchBarHandle bar);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_search_bar_handle_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSearchBarHandle>))] MentorLake.Gtk.GtkSearchBarHandle bar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_search_bar_set_search_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSearchBarHandle>))] MentorLake.Gtk.GtkSearchBarHandle bar, bool search_mode);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_search_bar_set_show_close_button([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSearchBarHandle>))] MentorLake.Gtk.GtkSearchBarHandle bar, bool visible);

}
