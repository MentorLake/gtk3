namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkSeparatorMenuItem is a separator used to group
/// items within a menu. It displays a horizontal line with a shadow to
/// make it appear sunken into the interface.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// GtkSeparatorMenuItem has a single CSS node with name separator.
/// </para>
/// </summary>

public class GtkSeparatorMenuItemHandle : GtkMenuItemHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkSeparatorMenuItem.
/// </para>
/// </summary>

/// <return>
/// a new #GtkSeparatorMenuItem.
/// </return>

	public static MentorLake.Gtk.GtkSeparatorMenuItemHandle New()
	{
		return GtkSeparatorMenuItemHandleExterns.gtk_separator_menu_item_new();
	}

}

public static class GtkSeparatorMenuItemHandleExtensions
{
}

internal class GtkSeparatorMenuItemHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkSeparatorMenuItemHandle>))]
	internal static extern MentorLake.Gtk.GtkSeparatorMenuItemHandle gtk_separator_menu_item_new();

}
