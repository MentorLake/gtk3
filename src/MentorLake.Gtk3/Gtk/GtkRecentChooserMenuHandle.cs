namespace MentorLake.Gtk;

public class GtkRecentChooserMenuHandle : GtkMenuHandle, AtkImplementorIfaceHandle, GtkActivatableHandle, GtkBuildableHandle, GtkRecentChooserHandle
{
	public static MentorLake.Gtk.GtkRecentChooserMenuHandle New()
	{
		return GtkRecentChooserMenuHandleExterns.gtk_recent_chooser_menu_new();
	}

	public static MentorLake.Gtk.GtkRecentChooserMenuHandle NewForManager(MentorLake.Gtk.GtkRecentManagerHandle manager)
	{
		return GtkRecentChooserMenuHandleExterns.gtk_recent_chooser_menu_new_for_manager(manager);
	}

}

public static class GtkRecentChooserMenuHandleExtensions
{
	public static bool GetShowNumbers(this MentorLake.Gtk.GtkRecentChooserMenuHandle menu)
	{
		if (menu.IsInvalid || menu.IsClosed) throw new Exception("Invalid or closed handle (GtkRecentChooserMenuHandle)");
		return GtkRecentChooserMenuHandleExterns.gtk_recent_chooser_menu_get_show_numbers(menu);
	}

	public static T SetShowNumbers<T>(this T menu, bool show_numbers) where T : GtkRecentChooserMenuHandle
	{
		if (menu.IsInvalid || menu.IsClosed) throw new Exception("Invalid or closed handle (GtkRecentChooserMenuHandle)");
		GtkRecentChooserMenuHandleExterns.gtk_recent_chooser_menu_set_show_numbers(menu, show_numbers);
		return menu;
	}

}

internal class GtkRecentChooserMenuHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRecentChooserMenuHandle gtk_recent_chooser_menu_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRecentChooserMenuHandle gtk_recent_chooser_menu_new_for_manager([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentManagerHandle>))] MentorLake.Gtk.GtkRecentManagerHandle manager);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_recent_chooser_menu_get_show_numbers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserMenuHandle>))] MentorLake.Gtk.GtkRecentChooserMenuHandle menu);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_recent_chooser_menu_set_show_numbers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserMenuHandle>))] MentorLake.Gtk.GtkRecentChooserMenuHandle menu, bool show_numbers);

}
