namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GActionGroup` represents a group of actions.
/// </para>
/// <para>
/// Actions can be used to expose functionality in a structured way, either
/// from one part of a program to another, or to the outside world. Action
/// groups are often used together with a [type@Gio.MenuModel] that provides additional
/// representation data for displaying the actions to the user, e.g. in a menu.
/// </para>
/// <para>
/// The main way to interact with the actions in a `GActionGroup` is to
/// activate them with [method@Gio.ActionGroup.activate_action]. Activating an
/// action may require a [type@GLib.Variant] parameter. The required type of the
/// parameter can be inquired with [method@Gio.ActionGroup.get_action_parameter_type].
/// Actions may be disabled, see [method@Gio.ActionGroup.get_action_enabled].
/// Activating a disabled action has no effect.
/// </para>
/// <para>
/// Actions may optionally have a state in the form of a [type@GLib.Variant]. The current
/// state of an action can be inquired with [method@Gio.ActionGroup.get_action_state].
/// Activating a stateful action may change its state, but it is also possible to
/// set the state by calling [method@Gio.ActionGroup.change_action_state].
/// </para>
/// <para>
/// As typical example, consider a text editing application which has an
/// option to change the current font to ‘bold’. A good way to represent
/// this would be a stateful action, with a boolean state. Activating the
/// action would toggle the state.
/// </para>
/// <para>
/// Each action in the group has a unique name (which is a string).  All
/// method calls, except [method@Gio.ActionGroup.list_actions] take the name of
/// an action as an argument.
/// </para>
/// <para>
/// The `GActionGroup` API is meant to be the ‘public’ API to the action
/// group. The calls here are exactly the interaction that ‘external
/// forces’ (eg: UI, incoming D-Bus messages, etc.) are supposed to have
/// with actions. ‘Internal’ APIs (ie: ones meant only to be accessed by
/// the action group implementation) are found on subclasses. This is
/// why you will find – for example – [method@Gio.ActionGroup.get_action_enabled]
/// but not an equivalent `set_action_enabled()` method.
/// </para>
/// <para>
/// Signals are emitted on the action group in response to state changes
/// on individual actions.
/// </para>
/// <para>
/// Implementations of `GActionGroup` should provide implementations for
/// the virtual functions [method@Gio.ActionGroup.list_actions] and
/// [method@Gio.ActionGroup.query_action]. The other virtual functions should
/// not be implemented — their ‘wrappers’ are actually implemented with
/// calls to [method@Gio.ActionGroup.query_action].
/// </para>
/// </summary>

public interface GActionGroupHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GActionGroupHandleImpl : BaseSafeHandle, GActionGroupHandle
{
}

public static class GActionGroupHandleExtensions
{
/// <summary>
/// <para>
/// Emits the [signal@Gio.ActionGroup::action-added] signal on @action_group.
/// </para>
/// <para>
/// This function should only be called by [type@Gio.ActionGroup] implementations.
/// </para>
/// </summary>

/// <param name="action_group">
/// a [type@Gio.ActionGroup]
/// </param>
/// <param name="action_name">
/// the name of an action in the group
/// </param>

	public static T ActionAdded<T>(this T action_group, string action_name) where T : GActionGroupHandle
	{
		if (action_group.IsInvalid) throw new Exception("Invalid handle (GActionGroupHandle)");
		GActionGroupHandleExterns.g_action_group_action_added(action_group, action_name);
		return action_group;
	}

/// <summary>
/// <para>
/// Emits the [signal@Gio.ActionGroup::action-enabled-changed] signal on @action_group.
/// </para>
/// <para>
/// This function should only be called by [type@Gio.ActionGroup] implementations.
/// </para>
/// </summary>

/// <param name="action_group">
/// a [type@Gio.ActionGroup]
/// </param>
/// <param name="action_name">
/// the name of an action in the group
/// </param>
/// <param name="enabled">
/// whether the action is now enabled
/// </param>

	public static T ActionEnabledChanged<T>(this T action_group, string action_name, bool enabled) where T : GActionGroupHandle
	{
		if (action_group.IsInvalid) throw new Exception("Invalid handle (GActionGroupHandle)");
		GActionGroupHandleExterns.g_action_group_action_enabled_changed(action_group, action_name, enabled);
		return action_group;
	}

/// <summary>
/// <para>
/// Emits the [signal@Gio.ActionGroup::action-removed] signal on @action_group.
/// </para>
/// <para>
/// This function should only be called by [type@Gio.ActionGroup] implementations.
/// </para>
/// </summary>

/// <param name="action_group">
/// a [type@Gio.ActionGroup]
/// </param>
/// <param name="action_name">
/// the name of an action in the group
/// </param>

	public static T ActionRemoved<T>(this T action_group, string action_name) where T : GActionGroupHandle
	{
		if (action_group.IsInvalid) throw new Exception("Invalid handle (GActionGroupHandle)");
		GActionGroupHandleExterns.g_action_group_action_removed(action_group, action_name);
		return action_group;
	}

/// <summary>
/// <para>
/// Emits the [signal@Gio.ActionGroup::action-state-changed] signal on @action_group.
/// </para>
/// <para>
/// This function should only be called by [type@Gio.ActionGroup] implementations.
/// </para>
/// </summary>

/// <param name="action_group">
/// a [type@Gio.ActionGroup]
/// </param>
/// <param name="action_name">
/// the name of an action in the group
/// </param>
/// <param name="state">
/// the new state of the named action
/// </param>

	public static T ActionStateChanged<T>(this T action_group, string action_name, MentorLake.GLib.GVariantHandle state) where T : GActionGroupHandle
	{
		if (action_group.IsInvalid) throw new Exception("Invalid handle (GActionGroupHandle)");
		GActionGroupHandleExterns.g_action_group_action_state_changed(action_group, action_name, state);
		return action_group;
	}

/// <summary>
/// <para>
/// Activate the named action within @action_group.
/// </para>
/// <para>
/// If the action is expecting a parameter, then the correct type of
/// parameter must be given as @parameter.  If the action is expecting no
/// parameters then @parameter must be `NULL`.  See
/// [method@Gio.ActionGroup.get_action_parameter_type].
/// </para>
/// <para>
/// If the [type@Gio.ActionGroup] implementation supports asynchronous remote
/// activation over D-Bus, this call may return before the relevant
/// D-Bus traffic has been sent, or any replies have been received. In
/// order to block on such asynchronous activation calls,
/// [method@Gio.DBusConnection.flush] should be called prior to the code, which
/// depends on the result of the action activation. Without flushing
/// the D-Bus connection, there is no guarantee that the action would
/// have been activated.
/// </para>
/// <para>
/// The following code which runs in a remote app instance, shows an
/// example of a ‘quit’ action being activated on the primary app
/// instance over D-Bus. Here [method@Gio.DBusConnection.flush] is called
/// before `exit()`. Without `g_dbus_connection_flush()`, the ‘quit’ action
/// may fail to be activated on the primary instance.
/// </para>
/// <para>
/// ```c
/// // call ‘quit’ action on primary instance
/// g_action_group_activate_action (G_ACTION_GROUP (app), &quot;quit&quot;, NULL);
/// </para>
/// <para>
/// // make sure the action is activated now
/// g_dbus_connection_flush (…);
/// </para>
/// <para>
/// g_debug (&quot;Application has been terminated. Exiting.&quot;);
/// </para>
/// <para>
/// exit (0);
/// ```
/// </para>
/// </summary>

/// <param name="action_group">
/// a [type@Gio.ActionGroup]
/// </param>
/// <param name="action_name">
/// the name of the action to activate
/// </param>
/// <param name="parameter">
/// parameters to the activation
/// </param>

	public static T ActivateAction<T>(this T action_group, string action_name, MentorLake.GLib.GVariantHandle parameter) where T : GActionGroupHandle
	{
		if (action_group.IsInvalid) throw new Exception("Invalid handle (GActionGroupHandle)");
		GActionGroupHandleExterns.g_action_group_activate_action(action_group, action_name, parameter);
		return action_group;
	}

/// <summary>
/// <para>
/// Request for the state of the named action within @action_group to be
/// changed to @value.
/// </para>
/// <para>
/// The action must be stateful and @value must be of the correct type.
/// See [method@Gio.ActionGroup.get_action_state_type].
/// </para>
/// <para>
/// This call merely requests a change.  The action may refuse to change
/// its state or may change its state to something other than @value.
/// See [method@Gio.ActionGroup.get_action_state_hint].
/// </para>
/// <para>
/// If the @value GVariant is floating, it is consumed.
/// </para>
/// </summary>

/// <param name="action_group">
/// a [type@Gio.ActionGroup]
/// </param>
/// <param name="action_name">
/// the name of the action to request the change on
/// </param>
/// <param name="value">
/// the new state
/// </param>

	public static T ChangeActionState<T>(this T action_group, string action_name, MentorLake.GLib.GVariantHandle value) where T : GActionGroupHandle
	{
		if (action_group.IsInvalid) throw new Exception("Invalid handle (GActionGroupHandle)");
		GActionGroupHandleExterns.g_action_group_change_action_state(action_group, action_name, value);
		return action_group;
	}

/// <summary>
/// <para>
/// Checks if the named action within @action_group is currently enabled.
/// </para>
/// <para>
/// An action must be enabled in order to be activated or in order to
/// have its state changed from outside callers.
/// </para>
/// </summary>

/// <param name="action_group">
/// a [type@Gio.ActionGroup]
/// </param>
/// <param name="action_name">
/// the name of the action to query
/// </param>
/// <return>
/// whether the action is currently enabled
/// </return>

	public static bool GetActionEnabled(this MentorLake.Gio.GActionGroupHandle action_group, string action_name)
	{
		if (action_group.IsInvalid) throw new Exception("Invalid handle (GActionGroupHandle)");
		return GActionGroupHandleExterns.g_action_group_get_action_enabled(action_group, action_name);
	}

/// <summary>
/// <para>
/// Queries the type of the parameter that must be given when activating
/// the named action within @action_group.
/// </para>
/// <para>
/// When activating the action using [method@Gio.ActionGroup.activate_action],
/// the [type@GLib.Variant] given to that function must be of the type returned
/// by this function.
/// </para>
/// <para>
/// In the case that this function returns `NULL`, you must not give any
/// [type@GLib.Variant], but `NULL` instead.
/// </para>
/// <para>
/// The parameter type of a particular action will never change but it is
/// possible for an action to be removed and for a new action to be added
/// with the same name but a different parameter type.
/// </para>
/// </summary>

/// <param name="action_group">
/// a [type@Gio.ActionGroup]
/// </param>
/// <param name="action_name">
/// the name of the action to query
/// </param>
/// <return>
/// the parameter type
/// </return>

	public static MentorLake.GLib.GVariantTypeHandle GetActionParameterType(this MentorLake.Gio.GActionGroupHandle action_group, string action_name)
	{
		if (action_group.IsInvalid) throw new Exception("Invalid handle (GActionGroupHandle)");
		return GActionGroupHandleExterns.g_action_group_get_action_parameter_type(action_group, action_name);
	}

/// <summary>
/// <para>
/// Queries the current state of the named action within @action_group.
/// </para>
/// <para>
/// If the action is not stateful then `NULL` will be returned.  If the
/// action is stateful then the type of the return value is the type
/// given by [method@Gio.ActionGroup.get_action_state_type].
/// </para>
/// <para>
/// The return value (if non-`NULL`) should be freed with
/// [method@GLib.Variant.unref] when it is no longer required.
/// </para>
/// </summary>

/// <param name="action_group">
/// a [type@Gio.ActionGroup]
/// </param>
/// <param name="action_name">
/// the name of the action to query
/// </param>
/// <return>
/// the current state of the action
/// </return>

	public static MentorLake.GLib.GVariantHandle GetActionState(this MentorLake.Gio.GActionGroupHandle action_group, string action_name)
	{
		if (action_group.IsInvalid) throw new Exception("Invalid handle (GActionGroupHandle)");
		return GActionGroupHandleExterns.g_action_group_get_action_state(action_group, action_name);
	}

/// <summary>
/// <para>
/// Requests a hint about the valid range of values for the state of the
/// named action within @action_group.
/// </para>
/// <para>
/// If `NULL` is returned it either means that the action is not stateful
/// or that there is no hint about the valid range of values for the
/// state of the action.
/// </para>
/// <para>
/// If a [type@GLib.Variant] array is returned then each item in the array is a
/// possible value for the state.  If a [type@GLib.Variant] pair (ie: two-tuple) is
/// returned then the tuple specifies the inclusive lower and upper bound
/// of valid values for the state.
/// </para>
/// <para>
/// In any case, the information is merely a hint.  It may be possible to
/// have a state value outside of the hinted range and setting a value
/// within the range may fail.
/// </para>
/// <para>
/// The return value (if non-`NULL`) should be freed with
/// [method@GLib.Variant.unref] when it is no longer required.
/// </para>
/// </summary>

/// <param name="action_group">
/// a [type@Gio.ActionGroup]
/// </param>
/// <param name="action_name">
/// the name of the action to query
/// </param>
/// <return>
/// the state range hint
/// </return>

	public static MentorLake.GLib.GVariantHandle GetActionStateHint(this MentorLake.Gio.GActionGroupHandle action_group, string action_name)
	{
		if (action_group.IsInvalid) throw new Exception("Invalid handle (GActionGroupHandle)");
		return GActionGroupHandleExterns.g_action_group_get_action_state_hint(action_group, action_name);
	}

/// <summary>
/// <para>
/// Queries the type of the state of the named action within
/// @action_group.
/// </para>
/// <para>
/// If the action is stateful then this function returns the
/// [type@GLib.VariantType] of the state.  All calls to
/// [method@Gio.ActionGroup.change_action_state] must give a [type@GLib.Variant] of this
/// type and [method@Gio.ActionGroup.get_action_state] will return a [type@GLib.Variant]
/// of the same type.
/// </para>
/// <para>
/// If the action is not stateful then this function will return `NULL`.
/// In that case, [method@Gio.ActionGroup.get_action_state] will return `NULL`
/// and you must not call [method@Gio.ActionGroup.change_action_state].
/// </para>
/// <para>
/// The state type of a particular action will never change but it is
/// possible for an action to be removed and for a new action to be added
/// with the same name but a different state type.
/// </para>
/// </summary>

/// <param name="action_group">
/// a [type@Gio.ActionGroup]
/// </param>
/// <param name="action_name">
/// the name of the action to query
/// </param>
/// <return>
/// the state type, if the action is stateful
/// </return>

	public static MentorLake.GLib.GVariantTypeHandle GetActionStateType(this MentorLake.Gio.GActionGroupHandle action_group, string action_name)
	{
		if (action_group.IsInvalid) throw new Exception("Invalid handle (GActionGroupHandle)");
		return GActionGroupHandleExterns.g_action_group_get_action_state_type(action_group, action_name);
	}

/// <summary>
/// <para>
/// Checks if the named action exists within @action_group.
/// </para>
/// </summary>

/// <param name="action_group">
/// a [type@Gio.ActionGroup]
/// </param>
/// <param name="action_name">
/// the name of the action to check for
/// </param>
/// <return>
/// whether the named action exists
/// </return>

	public static bool HasAction(this MentorLake.Gio.GActionGroupHandle action_group, string action_name)
	{
		if (action_group.IsInvalid) throw new Exception("Invalid handle (GActionGroupHandle)");
		return GActionGroupHandleExterns.g_action_group_has_action(action_group, action_name);
	}

/// <summary>
/// <para>
/// Lists the actions contained within @action_group.
/// </para>
/// <para>
/// The caller is responsible for freeing the list with [func@GLib.strfreev] when
/// it is no longer required.
/// </para>
/// </summary>

/// <param name="action_group">
/// a [type@Gio.ActionGroup]
/// </param>
/// <return>
/// a `NULL`-terminated array
///   of the names of the actions in the group
/// </return>

	public static string[] ListActions(this MentorLake.Gio.GActionGroupHandle action_group)
	{
		if (action_group.IsInvalid) throw new Exception("Invalid handle (GActionGroupHandle)");
		return GActionGroupHandleExterns.g_action_group_list_actions(action_group);
	}

/// <summary>
/// <para>
/// Queries all aspects of the named action within an @action_group.
/// </para>
/// <para>
/// This function acquires the information available from
/// [method@Gio.ActionGroup.has_action], [method@Gio.ActionGroup.get_action_enabled],
/// [method@Gio.ActionGroup.get_action_parameter_type],
/// [method@Gio.ActionGroup.get_action_state_type],
/// [method@Gio.ActionGroup.get_action_state_hint] and
/// [method@Gio.ActionGroup.get_action_state] with a single function call.
/// </para>
/// <para>
/// This provides two main benefits.
/// </para>
/// <para>
/// The first is the improvement in efficiency that comes with not having
/// to perform repeated lookups of the action in order to discover
/// different things about it.  The second is that implementing
/// [type@Gio.ActionGroup] can now be done by only overriding this one virtual
/// function.
/// </para>
/// <para>
/// The interface provides a default implementation of this function that
/// calls the individual functions, as required, to fetch the
/// information.  The interface also provides default implementations of
/// those functions that call this function.  All implementations,
/// therefore, must override either this function or all of the others.
/// </para>
/// <para>
/// If the action exists, `TRUE` is returned and any of the requested
/// fields (as indicated by having a non-`NULL` reference passed in) are
/// filled.  If the action doesn’t exist, `FALSE` is returned and the
/// fields may or may not have been modified.
/// </para>
/// </summary>

/// <param name="action_group">
/// a [type@Gio.ActionGroup]
/// </param>
/// <param name="action_name">
/// the name of an action in the group
/// </param>
/// <param name="enabled">
/// if the action is presently enabled
/// </param>
/// <param name="parameter_type">
/// the parameter type, or `NULL` if none needed
/// </param>
/// <param name="state_type">
/// the state type, or `NULL` if stateless
/// </param>
/// <param name="state_hint">
/// the state hint, or `NULL` if none
/// </param>
/// <param name="state">
/// the current state, or `NULL` if stateless
/// </param>
/// <return>
/// `TRUE` if the action exists, else `FALSE`
/// </return>

	public static bool QueryAction(this MentorLake.Gio.GActionGroupHandle action_group, string action_name, out bool enabled, out MentorLake.GLib.GVariantTypeHandle parameter_type, out MentorLake.GLib.GVariantTypeHandle state_type, out MentorLake.GLib.GVariantHandle state_hint, out MentorLake.GLib.GVariantHandle state)
	{
		if (action_group.IsInvalid) throw new Exception("Invalid handle (GActionGroupHandle)");
		return GActionGroupHandleExterns.g_action_group_query_action(action_group, action_name, out enabled, out parameter_type, out state_type, out state_hint, out state);
	}

}

internal class GActionGroupHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern void g_action_group_action_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle action_group, string action_name);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_action_group_action_enabled_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle action_group, string action_name, bool enabled);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_action_group_action_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle action_group, string action_name);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_action_group_action_state_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle action_group, string action_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle state);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_action_group_activate_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle action_group, string action_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameter);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_action_group_change_action_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle action_group, string action_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_action_group_get_action_enabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle action_group, string action_name);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))]
	internal static extern MentorLake.GLib.GVariantTypeHandle g_action_group_get_action_parameter_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle action_group, string action_name);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_action_group_get_action_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle action_group, string action_name);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_action_group_get_action_state_hint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle action_group, string action_name);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))]
	internal static extern MentorLake.GLib.GVariantTypeHandle g_action_group_get_action_state_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle action_group, string action_name);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_action_group_has_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle action_group, string action_name);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_action_group_list_actions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle action_group);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_action_group_query_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle action_group, string action_name, out bool enabled, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] out MentorLake.GLib.GVariantTypeHandle parameter_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] out MentorLake.GLib.GVariantTypeHandle state_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] out MentorLake.GLib.GVariantHandle state_hint, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] out MentorLake.GLib.GVariantHandle state);

}
