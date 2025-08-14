namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// This interface provides a convenient way of associating widgets with
/// actions on a #GtkApplicationWindow or #GtkApplication.
/// </para>
/// <para>
/// It primarily consists of two properties: #GtkActionable:action-name
/// and #GtkActionable:action-target. There are also some convenience APIs
/// for setting these properties.
/// </para>
/// <para>
/// The action will be looked up in action groups that are found among
/// the widgets ancestors. Most commonly, these will be the actions with
/// the “win.” or “app.” prefix that are associated with the #GtkApplicationWindow
/// or #GtkApplication, but other action groups that are added with
/// gtk_widget_insert_action_group() will be consulted as well.
/// </para>
/// </summary>

public interface GtkActionableHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GtkActionableHandleImpl : BaseSafeHandle, GtkActionableHandle
{
}

public static class GtkActionableHandleExtensions
{
/// <summary>
/// <para>
/// Gets the action name for @actionable.
/// </para>
/// <para>
/// See gtk_actionable_set_action_name() for more information.
/// </para>
/// </summary>

/// <param name="actionable">
/// a #GtkActionable widget
/// </param>
/// <return>
/// the action name, or %NULL if none is set
/// </return>

	public static string GetActionName(this MentorLake.Gtk.GtkActionableHandle actionable)
	{
		if (actionable.IsInvalid) throw new Exception("Invalid handle (GtkActionableHandle)");
		return GtkActionableHandleExterns.gtk_actionable_get_action_name(actionable);
	}

/// <summary>
/// <para>
/// Gets the current target value of @actionable.
/// </para>
/// <para>
/// See gtk_actionable_set_action_target_value() for more information.
/// </para>
/// </summary>

/// <param name="actionable">
/// a #GtkActionable widget
/// </param>
/// <return>
/// the current target value
/// </return>

	public static MentorLake.GLib.GVariantHandle GetActionTargetValue(this MentorLake.Gtk.GtkActionableHandle actionable)
	{
		if (actionable.IsInvalid) throw new Exception("Invalid handle (GtkActionableHandle)");
		return GtkActionableHandleExterns.gtk_actionable_get_action_target_value(actionable);
	}

/// <summary>
/// <para>
/// Specifies the name of the action with which this widget should be
/// associated.  If @action_name is %NULL then the widget will be
/// unassociated from any previous action.
/// </para>
/// <para>
/// Usually this function is used when the widget is located (or will be
/// located) within the hierarchy of a #GtkApplicationWindow.
/// </para>
/// <para>
/// Names are of the form “win.save” or “app.quit” for actions on the
/// containing #GtkApplicationWindow or its associated #GtkApplication,
/// respectively.  This is the same form used for actions in the #GMenu
/// associated with the window.
/// </para>
/// </summary>

/// <param name="actionable">
/// a #GtkActionable widget
/// </param>
/// <param name="action_name">
/// an action name, or %NULL
/// </param>

	public static T SetActionName<T>(this T actionable, string action_name) where T : GtkActionableHandle
	{
		if (actionable.IsInvalid) throw new Exception("Invalid handle (GtkActionableHandle)");
		GtkActionableHandleExterns.gtk_actionable_set_action_name(actionable, action_name);
		return actionable;
	}

/// <summary>
/// <para>
/// Sets the target of an actionable widget.
/// </para>
/// <para>
/// This is a convenience function that calls g_variant_new() for
/// @format_string and uses the result to call
/// gtk_actionable_set_action_target_value().
/// </para>
/// <para>
/// If you are setting a string-valued target and want to set the action
/// name at the same time, you can use
/// gtk_actionable_set_detailed_action_name ().
/// </para>
/// </summary>

/// <param name="actionable">
/// a #GtkActionable widget
/// </param>
/// <param name="format_string">
/// a GVariant format string
/// </param>
/// <param name="@__arglist">
/// arguments appropriate for @format_string
/// </param>

	public static T SetActionTarget<T>(this T actionable, string format_string, IntPtr @__arglist) where T : GtkActionableHandle
	{
		if (actionable.IsInvalid) throw new Exception("Invalid handle (GtkActionableHandle)");
		GtkActionableHandleExterns.gtk_actionable_set_action_target(actionable, format_string, @__arglist);
		return actionable;
	}

/// <summary>
/// <para>
/// Sets the target value of an actionable widget.
/// </para>
/// <para>
/// If @target_value is %NULL then the target value is unset.
/// </para>
/// <para>
/// The target value has two purposes.  First, it is used as the
/// parameter to activation of the action associated with the
/// #GtkActionable widget. Second, it is used to determine if the widget
/// should be rendered as “active” — the widget is active if the state
/// is equal to the given target.
/// </para>
/// <para>
/// Consider the example of associating a set of buttons with a #GAction
/// with string state in a typical “radio button” situation.  Each button
/// will be associated with the same action, but with a different target
/// value for that action.  Clicking on a particular button will activate
/// the action with the target of that button, which will typically cause
/// the action’s state to change to that value.  Since the action’s state
/// is now equal to the target value of the button, the button will now
/// be rendered as active (and the other buttons, with different targets,
/// rendered inactive).
/// </para>
/// </summary>

/// <param name="actionable">
/// a #GtkActionable widget
/// </param>
/// <param name="target_value">
/// a #GVariant to set as the target value, or %NULL
/// </param>

	public static T SetActionTargetValue<T>(this T actionable, MentorLake.GLib.GVariantHandle target_value) where T : GtkActionableHandle
	{
		if (actionable.IsInvalid) throw new Exception("Invalid handle (GtkActionableHandle)");
		GtkActionableHandleExterns.gtk_actionable_set_action_target_value(actionable, target_value);
		return actionable;
	}

/// <summary>
/// <para>
/// Sets the action-name and associated string target value of an
/// actionable widget.
/// </para>
/// <para>
/// @detailed_action_name is a string in the format accepted by
/// g_action_parse_detailed_name().
/// </para>
/// <para>
/// (Note that prior to version 3.22.25,
/// this function is only usable for actions with a simple "s" target, and
/// @detailed_action_name must be of the form `"action::target"` where
/// `action` is the action name and `target` is the string to use
/// as the target.)
/// </para>
/// </summary>

/// <param name="actionable">
/// a #GtkActionable widget
/// </param>
/// <param name="detailed_action_name">
/// the detailed action name
/// </param>

	public static T SetDetailedActionName<T>(this T actionable, string detailed_action_name) where T : GtkActionableHandle
	{
		if (actionable.IsInvalid) throw new Exception("Invalid handle (GtkActionableHandle)");
		GtkActionableHandleExterns.gtk_actionable_set_detailed_action_name(actionable, detailed_action_name);
		return actionable;
	}

}

internal class GtkActionableHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_actionable_get_action_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionableHandleImpl>))] MentorLake.Gtk.GtkActionableHandle actionable);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle gtk_actionable_get_action_target_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionableHandleImpl>))] MentorLake.Gtk.GtkActionableHandle actionable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_actionable_set_action_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionableHandleImpl>))] MentorLake.Gtk.GtkActionableHandle actionable, string action_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_actionable_set_action_target([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionableHandleImpl>))] MentorLake.Gtk.GtkActionableHandle actionable, string format_string, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_actionable_set_action_target_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionableHandleImpl>))] MentorLake.Gtk.GtkActionableHandle actionable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle target_value);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_actionable_set_detailed_action_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionableHandleImpl>))] MentorLake.Gtk.GtkActionableHandle actionable, string detailed_action_name);

}
