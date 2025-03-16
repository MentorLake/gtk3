namespace MentorLake.Gtk;

public class GtkPopoverMenuHandle : GtkPopoverHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkPopoverMenuHandle New()
	{
		return GtkPopoverMenuHandleExterns.gtk_popover_menu_new();
	}

}

public static class GtkPopoverMenuHandleExtensions
{
	public static T OpenSubmenu<T>(this T popover, string name) where T : GtkPopoverMenuHandle
	{
		GtkPopoverMenuHandleExterns.gtk_popover_menu_open_submenu(popover, name);
		return popover;
	}

}

internal class GtkPopoverMenuHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPopoverMenuHandle gtk_popover_menu_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_popover_menu_open_submenu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverMenuHandle>))] MentorLake.Gtk.GtkPopoverMenuHandle popover, string name);

}
