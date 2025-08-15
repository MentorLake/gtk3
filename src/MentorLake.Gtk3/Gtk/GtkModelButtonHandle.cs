namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// GtkModelButton is a button class that can use a #GAction as its model.
/// In contrast to #GtkToggleButton or #GtkRadioButton, which can also
/// be backed by a #GAction via the #GtkActionable:action-name property,
/// GtkModelButton will adapt its appearance according to the kind of
/// action it is backed by, and appear either as a plain, check or
/// radio button.
/// </para>
/// <para>
/// Model buttons are used when popovers from a menu model with
/// gtk_popover_new_from_model(); they can also be used manually in
/// a #GtkPopoverMenu.
/// </para>
/// <para>
/// When the action is specified via the #GtkActionable:action-name
/// and #GtkActionable:action-target properties, the role of the button
/// (i.e. whether it is a plain, check or radio button) is determined by
/// the type of the action and doesn&apos;t have to be explicitly specified
/// with the #GtkModelButton:role property.
/// </para>
/// <para>
/// The content of the button is specified by the #GtkModelButton:text
/// and #GtkModelButton:icon properties.
/// </para>
/// <para>
/// The appearance of model buttons can be influenced with the
/// #GtkModelButton:centered and #GtkModelButton:iconic properties.
/// </para>
/// <para>
/// Model buttons have built-in support for submenus in #GtkPopoverMenu.
/// To make a GtkModelButton that opens a submenu when activated, set
/// the #GtkModelButton:menu-name property. To make a button that goes
/// back to the parent menu, you should set the #GtkModelButton:inverted
/// property to place the submenu indicator at the opposite side.
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
///           &amp;lt;property name=&quot;action-name&quot;&amp;gt;view.cut&amp;lt;/property&amp;gt;
///           &amp;lt;property name=&quot;text&quot; translatable=&quot;yes&quot;&amp;gt;Cut&amp;lt;/property&amp;gt;
///         &amp;lt;/object&amp;gt;
///       &amp;lt;/child&amp;gt;
///       &amp;lt;child&amp;gt;
///         &amp;lt;object class=&quot;GtkModelButton&quot;&amp;gt;
///           &amp;lt;property name=&quot;visible&quot;&amp;gt;True&amp;lt;/property&amp;gt;
///           &amp;lt;property name=&quot;action-name&quot;&amp;gt;view.copy&amp;lt;/property&amp;gt;
///           &amp;lt;property name=&quot;text&quot; translatable=&quot;yes&quot;&amp;gt;Copy&amp;lt;/property&amp;gt;
///         &amp;lt;/object&amp;gt;
///       &amp;lt;/child&amp;gt;
///       &amp;lt;child&amp;gt;
///         &amp;lt;object class=&quot;GtkModelButton&quot;&amp;gt;
///           &amp;lt;property name=&quot;visible&quot;&amp;gt;True&amp;lt;/property&amp;gt;
///           &amp;lt;property name=&quot;action-name&quot;&amp;gt;view.paste&amp;lt;/property&amp;gt;
///           &amp;lt;property name=&quot;text&quot; translatable=&quot;yes&quot;&amp;gt;Paste&amp;lt;/property&amp;gt;
///         &amp;lt;/object&amp;gt;
///       &amp;lt;/child&amp;gt;
///     &amp;lt;/object&amp;gt;
///   &amp;lt;/child&amp;gt;
/// &amp;lt;/object&amp;gt;
/// </code>
/// <para>
/// # CSS nodes
/// </para>
/// <code>
/// modelbutton
/// modelbutton
/// ├── &amp;lt;child&amp;gt;
/// ╰── check
/// </code>
/// <code>
/// modelbutton
/// modelbutton
/// ├── &amp;lt;child&amp;gt;
/// ╰── radio
/// </code>
/// <code>
/// modelbutton
/// modelbutton
/// ├── &amp;lt;child&amp;gt;
/// ╰── arrow
/// </code>
/// <para>
/// GtkModelButton has a main CSS node with name modelbutton, and a subnode,
/// which will have the name check, radio or arrow, depending on the role
/// of the button and whether it has a menu name set.
/// </para>
/// <para>
/// The subnode is positioned before or after the content nodes and gets the
/// .left or .right style class, depending on where it is located.
/// </para>
/// <code>
/// button.model
/// button.model
/// ├── &amp;lt;child&amp;gt;
/// ╰── check
/// </code>
/// <para>
/// Iconic model buttons (see #GtkModelButton:iconic) change the name of
/// their main node to button and add a .model style class to it. The indicator
/// subnode is invisible in this case.
/// </para>
/// </summary>

public class GtkModelButtonHandle : GtkButtonHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new GtkModelButton.
/// </para>
/// </summary>

/// <return>
/// the newly created #GtkModelButton widget
/// </return>

	public static MentorLake.Gtk.GtkModelButtonHandle New()
	{
		return GtkModelButtonHandleExterns.gtk_model_button_new();
	}

}

public static class GtkModelButtonHandleExtensions
{
}

internal class GtkModelButtonHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkModelButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkModelButtonHandle gtk_model_button_new();

}
