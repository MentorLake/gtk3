namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A #GtkTearoffMenuItem is a special #GtkMenuItem which is used to
/// tear off and reattach its menu.
/// </para>
/// <para>
/// When its menu is shown normally, the #GtkTearoffMenuItem is drawn as a
/// dotted line indicating that the menu can be torn off.  Activating it
/// causes its menu to be torn off and displayed in its own window
/// as a tearoff menu.
/// </para>
/// <para>
/// When its menu is shown as a tearoff menu, the #GtkTearoffMenuItem is drawn
/// as a dotted line which has a left pointing arrow graphic indicating that
/// the tearoff menu can be reattached.  Activating it will erase the tearoff
/// menu window.
/// </para>
/// <para>
/// &amp;gt; #GtkTearoffMenuItem is deprecated and should not be used in newly
/// &amp;gt; written code. Menus are not meant to be torn around.
/// </para>
/// </summary>

public class GtkTearoffMenuItemHandle : GtkMenuItemHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkTearoffMenuItem.
/// </para>
/// </summary>

/// <return>
/// a new #GtkTearoffMenuItem.
/// </return>

	public static MentorLake.Gtk.GtkTearoffMenuItemHandle New()
	{
		return GtkTearoffMenuItemHandleExterns.gtk_tearoff_menu_item_new();
	}

}

public static class GtkTearoffMenuItemHandleExtensions
{
}

internal class GtkTearoffMenuItemHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkTearoffMenuItemHandle>))]
	internal static extern MentorLake.Gtk.GtkTearoffMenuItemHandle gtk_tearoff_menu_item_new();

}
