namespace MentorLake.Gio;

/// <summary>
/// <para>
/// A `GPropertyAction` is a way to get a [iface@Gio.Action] with a state value
/// reflecting and controlling the value of a [class@GObject.Object] property.
/// </para>
/// <para>
/// The state of the action will correspond to the value of the property.
/// Changing it will change the property (assuming the requested value
/// matches the requirements as specified in the [type@GObject.ParamSpec]).
/// </para>
/// <para>
/// Only the most common types are presently supported.  Booleans are
/// mapped to booleans, strings to strings, signed/unsigned integers to
/// int32/uint32 and floats and doubles to doubles.
/// </para>
/// <para>
/// If the property is an enum then the state will be string-typed and
/// conversion will automatically be performed between the enum value and
/// ‘nick’ string as per the [type@GObject.EnumValue] table.
/// </para>
/// <para>
/// Flags types are not currently supported.
/// </para>
/// <para>
/// Properties of object types, boxed types and pointer types are not
/// supported and probably never will be.
/// </para>
/// <para>
/// Properties of [type@GLib.Variant] types are not currently supported.
/// </para>
/// <para>
/// If the property is boolean-valued then the action will have a `NULL`
/// parameter type, and activating the action (with no parameter) will
/// toggle the value of the property.
/// </para>
/// <para>
/// In all other cases, the parameter type will correspond to the type of
/// the property.
/// </para>
/// <para>
/// The general idea here is to reduce the number of locations where a
/// particular piece of state is kept (and therefore has to be synchronised
/// between). `GPropertyAction` does not have a separate state that is kept
/// in sync with the property value — its state is the property value.
/// </para>
/// <para>
/// For example, it might be useful to create a [iface@Gio.Action] corresponding
/// to the `visible-child-name` property of a &amp;lt;see href=&quot;https://docs.gtk.org/gtk4/class.Stack.html&quot;&amp;gt;GtkStack&amp;lt;/see&amp;gt;
/// so that the current page can be switched from a menu.  The active radio
/// indication in the menu is then directly determined from the active page of
/// the `GtkStack`.
/// </para>
/// <para>
/// An anti-example would be binding the `active-id` property on a
/// &amp;lt;see href=&quot;https://docs.gtk.org/gtk4/class.ComboBox.html&quot;&amp;gt;GtkComboBox&amp;lt;/see&amp;gt;. This is
/// because the state of the combo box itself is probably uninteresting and is
/// actually being used to control something else.
/// </para>
/// <para>
/// Another anti-example would be to bind to the `visible-child-name`
/// property of a &amp;lt;see href=&quot;https://docs.gtk.org/gtk4/class.Stack.html&quot;&amp;gt;GtkStack&amp;lt;/see&amp;gt; if
/// this value is actually stored in [class@Gio.Settings].  In that case, the
/// real source of the value is* [class@Gio.Settings].  If you want
/// a [iface@Gio.Action] to control a setting stored in [class@Gio.Settings],
/// see [method@Gio.Settings.create_action] instead, and possibly combine its
/// use with [method@Gio.Settings.bind].
/// </para>
/// </summary>

public class GPropertyActionHandle : GObjectHandle, GActionHandle
{
/// <summary>
/// <para>
/// Creates a #GAction corresponding to the value of property
/// @property_name on @object.
/// </para>
/// <para>
/// The property must be existent and readable and writable (and not
/// construct-only).
/// </para>
/// <para>
/// This function takes a reference on @object and doesn&apos;t release it
/// until the action is destroyed.
/// </para>
/// </summary>

/// <param name="name">
/// the name of the action to create
/// </param>
/// <param name="@object">
/// the object that has the property
///   to wrap
/// </param>
/// <param name="property_name">
/// the name of the property
/// </param>
/// <return>
/// a new #GPropertyAction
/// </return>

	public static MentorLake.Gio.GPropertyActionHandle New(string name, MentorLake.GObject.GObjectHandle @object, string property_name)
	{
		return GPropertyActionHandleExterns.g_property_action_new(name, @object, property_name);
	}

}

public static class GPropertyActionHandleExtensions
{
}

internal class GPropertyActionHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GPropertyActionHandle>))]
	internal static extern MentorLake.Gio.GPropertyActionHandle g_property_action_new(string name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string property_name);

}
