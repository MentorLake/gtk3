namespace MentorLake.Gtk;

public class GtkMenuBarHandle : GtkMenuShellHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkMenuBarHandle New()
	{
		return GtkMenuBarHandleExterns.gtk_menu_bar_new();
	}

	public static MentorLake.Gtk.GtkMenuBarHandle NewFromModel(MentorLake.Gio.GMenuModelHandle model)
	{
		return GtkMenuBarHandleExterns.gtk_menu_bar_new_from_model(model);
	}

}

public static class GtkMenuBarHandleExtensions
{
	public static MentorLake.Gtk.GtkPackDirection GetChildPackDirection(this MentorLake.Gtk.GtkMenuBarHandle menubar)
	{
		return GtkMenuBarHandleExterns.gtk_menu_bar_get_child_pack_direction(menubar);
	}

	public static MentorLake.Gtk.GtkPackDirection GetPackDirection(this MentorLake.Gtk.GtkMenuBarHandle menubar)
	{
		return GtkMenuBarHandleExterns.gtk_menu_bar_get_pack_direction(menubar);
	}

	public static T SetChildPackDirection<T>(this T menubar, MentorLake.Gtk.GtkPackDirection child_pack_dir) where T : GtkMenuBarHandle
	{
		GtkMenuBarHandleExterns.gtk_menu_bar_set_child_pack_direction(menubar, child_pack_dir);
		return menubar;
	}

	public static T SetPackDirection<T>(this T menubar, MentorLake.Gtk.GtkPackDirection pack_dir) where T : GtkMenuBarHandle
	{
		GtkMenuBarHandleExterns.gtk_menu_bar_set_pack_direction(menubar, pack_dir);
		return menubar;
	}

}

internal class GtkMenuBarHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkMenuBarHandle gtk_menu_bar_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkMenuBarHandle gtk_menu_bar_new_from_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle model);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPackDirection gtk_menu_bar_get_child_pack_direction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuBarHandle>))] MentorLake.Gtk.GtkMenuBarHandle menubar);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPackDirection gtk_menu_bar_get_pack_direction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuBarHandle>))] MentorLake.Gtk.GtkMenuBarHandle menubar);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_bar_set_child_pack_direction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuBarHandle>))] MentorLake.Gtk.GtkMenuBarHandle menubar, MentorLake.Gtk.GtkPackDirection child_pack_dir);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_bar_set_pack_direction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuBarHandle>))] MentorLake.Gtk.GtkMenuBarHandle menubar, MentorLake.Gtk.GtkPackDirection pack_dir);

}
