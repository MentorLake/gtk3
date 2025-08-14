namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkHSeparator widget is a horizontal separator, used to group the
/// widgets within a window. It displays a horizontal line with a shadow to
/// make it appear sunken into the interface.
/// </para>
/// <para>
/// > The #GtkHSeparator widget is not used as a separator within menus.
/// > To create a separator in a menu create an empty #GtkSeparatorMenuItem
/// > widget using gtk_separator_menu_item_new() and add it to the menu with
/// > gtk_menu_shell_append().
/// </para>
/// <para>
/// GtkHSeparator has been deprecated, use #GtkSeparator instead.
/// </para>
/// </summary>

public class GtkHSeparatorHandle : GtkSeparatorHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkHSeparator.
/// </para>
/// </summary>

/// <return>
/// a new #GtkHSeparator.
/// </return>

	public static MentorLake.Gtk.GtkHSeparatorHandle New()
	{
		return GtkHSeparatorHandleExterns.gtk_hseparator_new();
	}

}

public static class GtkHSeparatorHandleExtensions
{
}

internal class GtkHSeparatorHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkHSeparatorHandle>))]
	internal static extern MentorLake.Gtk.GtkHSeparatorHandle gtk_hseparator_new();

}
