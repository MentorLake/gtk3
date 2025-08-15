namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// GtkPopoverMenu is a subclass of #GtkPopover that treats its
/// children like menus and allows switching between them. It is
/// meant to be used primarily together with #GtkModelButton, but
/// any widget can be used, such as #GtkSpinButton or #GtkScale.
/// In this respect, GtkPopoverMenu is more flexible than popovers
/// that are created from a #GMenuModel with gtk_popover_new_from_model().
/// </para>
/// <para>
/// To add a child as a submenu, set the #GtkPopoverMenu:submenu
/// child property to the name of the submenu. To let the user open
/// this submenu, add a #GtkModelButton whose #GtkModelButton:menu-name
/// property is set to the name you&apos;ve given to the submenu.
/// </para>
/// <para>
/// By convention, the first child of a submenu should be a #GtkModelButton
/// to switch back to the parent menu. Such a button should use the
/// #GtkModelButton:inverted and #GtkModelButton:centered properties
/// to achieve a title-like appearance and place the submenu indicator
/// at the opposite side. To switch back to the main menu, use &quot;main&quot;
/// as the menu name.
/// </para>
/// <para>
/// # Example
/// </para>
/// <code>
/// &amp;lt;object class=&quot;GtkPopoverMenu&quot;&amp;gt;
/// &amp;lt;object class=&quot;GtkPopoverMenu&quot;&amp;gt;
///   &amp;lt;child&amp;gt;
///     &amp;lt;object class=&quot;GtkBox&quot;&amp;gt;
///       &amp;lt;property name=&quot;visible&quot;&amp;gt;True&amp;lt;/property&amp;gt;
///       &amp;lt;property name=&quot;margin&quot;&amp;gt;10&amp;lt;/property&amp;gt;
///       &amp;lt;child&amp;gt;
///         &amp;lt;object class=&quot;GtkModelButton&quot;&amp;gt;
///           &amp;lt;property name=&quot;visible&quot;&amp;gt;True&amp;lt;/property&amp;gt;
///           &amp;lt;property name=&quot;action-name&quot;&amp;gt;win.frob&amp;lt;/property&amp;gt;
///           &amp;lt;property name=&quot;text&quot; translatable=&quot;yes&quot;&amp;gt;Frob&amp;lt;/property&amp;gt;
///         &amp;lt;/object&amp;gt;
///       &amp;lt;/child&amp;gt;
///       &amp;lt;child&amp;gt;
///         &amp;lt;object class=&quot;GtkModelButton&quot;&amp;gt;
///           &amp;lt;property name=&quot;visible&quot;&amp;gt;True&amp;lt;/property&amp;gt;
///           &amp;lt;property name=&quot;menu-name&quot;&amp;gt;more&amp;lt;/property&amp;gt;
///           &amp;lt;property name=&quot;text&quot; translatable=&quot;yes&quot;&amp;gt;More&amp;lt;/property&amp;gt;
///         &amp;lt;/object&amp;gt;
///       &amp;lt;/child&amp;gt;
///     &amp;lt;/object&amp;gt;
///   &amp;lt;/child&amp;gt;
///   &amp;lt;child&amp;gt;
///     &amp;lt;object class=&quot;GtkBox&quot;&amp;gt;
///       &amp;lt;property name=&quot;visible&quot;&amp;gt;True&amp;lt;/property&amp;gt;
///       &amp;lt;property name=&quot;margin&quot;&amp;gt;10&amp;lt;/property&amp;gt;
///       &amp;lt;child&amp;gt;
///         &amp;lt;object class=&quot;GtkModelButton&quot;&amp;gt;
///           &amp;lt;property name=&quot;visible&quot;&amp;gt;True&amp;lt;/property&amp;gt;
///           &amp;lt;property name=&quot;action-name&quot;&amp;gt;win.foo&amp;lt;/property&amp;gt;
///           &amp;lt;property name=&quot;text&quot; translatable=&quot;yes&quot;&amp;gt;Foo&amp;lt;/property&amp;gt;
///         &amp;lt;/object&amp;gt;
///       &amp;lt;/child&amp;gt;
///       &amp;lt;child&amp;gt;
///         &amp;lt;object class=&quot;GtkModelButton&quot;&amp;gt;
///           &amp;lt;property name=&quot;visible&quot;&amp;gt;True&amp;lt;/property&amp;gt;
///           &amp;lt;property name=&quot;action-name&quot;&amp;gt;win.bar&amp;lt;/property&amp;gt;
///           &amp;lt;property name=&quot;text&quot; translatable=&quot;yes&quot;&amp;gt;Bar&amp;lt;/property&amp;gt;
///         &amp;lt;/object&amp;gt;
///       &amp;lt;/child&amp;gt;
///     &amp;lt;/object&amp;gt;
///     &amp;lt;packing&amp;gt;
///       &amp;lt;property name=&quot;submenu&quot;&amp;gt;more&amp;lt;/property&amp;gt;
///     &amp;lt;/packing&amp;gt;
///   &amp;lt;/child&amp;gt;
/// &amp;lt;/object&amp;gt;
/// </code>
/// <para>
/// Just like normal popovers created using gtk_popover_new_from_model,
/// #GtkPopoverMenu instances have a single css node called &quot;popover&quot;
/// and get the .menu style class.
/// </para>
/// </summary>

public class GtkPopoverMenuHandle : GtkPopoverHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new popover menu.
/// </para>
/// </summary>

/// <return>
/// a new #GtkPopoverMenu
/// </return>

	public static MentorLake.Gtk.GtkPopoverMenuHandle New()
	{
		return GtkPopoverMenuHandleExterns.gtk_popover_menu_new();
	}

}

public static class GtkPopoverMenuHandleExtensions
{
/// <summary>
/// <para>
/// Opens a submenu of the @popover. The @name
/// must be one of the names given to the submenus
/// of @popover with #GtkPopoverMenu:submenu, or
/// &quot;main&quot; to switch back to the main menu.
/// </para>
/// <para>
/// #GtkModelButton will open submenus automatically
/// when the #GtkModelButton:menu-name property is set,
/// so this function is only needed when you are using
/// other kinds of widgets to initiate menu changes.
/// </para>
/// </summary>

/// <param name="popover">
/// a #GtkPopoverMenu
/// </param>
/// <param name="name">
/// the name of the menu to switch to
/// </param>

	public static T OpenSubmenu<T>(this T popover, string name) where T : GtkPopoverMenuHandle
	{
		if (popover.IsInvalid) throw new Exception("Invalid handle (GtkPopoverMenuHandle)");
		GtkPopoverMenuHandleExterns.gtk_popover_menu_open_submenu(popover, name);
		return popover;
	}

}

internal class GtkPopoverMenuHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverMenuHandle>))]
	internal static extern MentorLake.Gtk.GtkPopoverMenuHandle gtk_popover_menu_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_popover_menu_open_submenu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverMenuHandle>))] MentorLake.Gtk.GtkPopoverMenuHandle popover, string name);

}
