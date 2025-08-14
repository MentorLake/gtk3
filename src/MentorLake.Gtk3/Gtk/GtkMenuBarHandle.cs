namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkMenuBar is a subclass of #GtkMenuShell which contains one or
/// more #GtkMenuItems. The result is a standard menu bar which can hold
/// many menu items.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// GtkMenuBar has a single CSS node with name menubar.
/// </para>
/// </summary>

public class GtkMenuBarHandle : GtkMenuShellHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkMenuBar
/// </para>
/// </summary>

/// <return>
/// the new menu bar, as a #GtkWidget
/// </return>

	public static MentorLake.Gtk.GtkMenuBarHandle New()
	{
		return GtkMenuBarHandleExterns.gtk_menu_bar_new();
	}

/// <summary>
/// <para>
/// Creates a new #GtkMenuBar and populates it with menu items
/// and submenus according to @model.
/// </para>
/// <para>
/// The created menu items are connected to actions found in the
/// #GtkApplicationWindow to which the menu bar belongs - typically
/// by means of being contained within the #GtkApplicationWindows
/// widget hierarchy.
/// </para>
/// </summary>

/// <param name="model">
/// a #GMenuModel
/// </param>
/// <return>
/// a new #GtkMenuBar
/// </return>

	public static MentorLake.Gtk.GtkMenuBarHandle NewFromModel(MentorLake.Gio.GMenuModelHandle model)
	{
		return GtkMenuBarHandleExterns.gtk_menu_bar_new_from_model(model);
	}

}

public static class GtkMenuBarHandleExtensions
{
/// <summary>
/// <para>
/// Retrieves the current child pack direction of the menubar.
/// See gtk_menu_bar_set_child_pack_direction().
/// </para>
/// </summary>

/// <param name="menubar">
/// a #GtkMenuBar
/// </param>
/// <return>
/// the child pack direction
/// </return>

	public static MentorLake.Gtk.GtkPackDirection GetChildPackDirection(this MentorLake.Gtk.GtkMenuBarHandle menubar)
	{
		if (menubar.IsInvalid) throw new Exception("Invalid handle (GtkMenuBarHandle)");
		return GtkMenuBarHandleExterns.gtk_menu_bar_get_child_pack_direction(menubar);
	}

/// <summary>
/// <para>
/// Retrieves the current pack direction of the menubar.
/// See gtk_menu_bar_set_pack_direction().
/// </para>
/// </summary>

/// <param name="menubar">
/// a #GtkMenuBar
/// </param>
/// <return>
/// the pack direction
/// </return>

	public static MentorLake.Gtk.GtkPackDirection GetPackDirection(this MentorLake.Gtk.GtkMenuBarHandle menubar)
	{
		if (menubar.IsInvalid) throw new Exception("Invalid handle (GtkMenuBarHandle)");
		return GtkMenuBarHandleExterns.gtk_menu_bar_get_pack_direction(menubar);
	}

/// <summary>
/// <para>
/// Sets how widgets should be packed inside the children of a menubar.
/// </para>
/// </summary>

/// <param name="menubar">
/// a #GtkMenuBar
/// </param>
/// <param name="child_pack_dir">
/// a new #GtkPackDirection
/// </param>

	public static T SetChildPackDirection<T>(this T menubar, MentorLake.Gtk.GtkPackDirection child_pack_dir) where T : GtkMenuBarHandle
	{
		if (menubar.IsInvalid) throw new Exception("Invalid handle (GtkMenuBarHandle)");
		GtkMenuBarHandleExterns.gtk_menu_bar_set_child_pack_direction(menubar, child_pack_dir);
		return menubar;
	}

/// <summary>
/// <para>
/// Sets how items should be packed inside a menubar.
/// </para>
/// </summary>

/// <param name="menubar">
/// a #GtkMenuBar
/// </param>
/// <param name="pack_dir">
/// a new #GtkPackDirection
/// </param>

	public static T SetPackDirection<T>(this T menubar, MentorLake.Gtk.GtkPackDirection pack_dir) where T : GtkMenuBarHandle
	{
		if (menubar.IsInvalid) throw new Exception("Invalid handle (GtkMenuBarHandle)");
		GtkMenuBarHandleExterns.gtk_menu_bar_set_pack_direction(menubar, pack_dir);
		return menubar;
	}

}

internal class GtkMenuBarHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkMenuBarHandle>))]
	internal static extern MentorLake.Gtk.GtkMenuBarHandle gtk_menu_bar_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkMenuBarHandle>))]
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
