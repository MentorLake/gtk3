namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GAction` represents a single named action.
/// </para>
/// <para>
/// The main interface to an action is that it can be activated with
/// [method@Gio.Action.activate]. This results in the &apos;activate&apos; signal being
/// emitted. An activation has a `GVariant` parameter (which may be
/// `NULL`). The correct type for the parameter is determined by a static
/// parameter type (which is given at construction time).
/// </para>
/// <para>
/// An action may optionally have a state, in which case the state may be
/// set with [method@Gio.Action.change_state]. This call takes a [type@GLib.Variant]. The
/// correct type for the state is determined by a static state type
/// (which is given at construction time).
/// </para>
/// <para>
/// The state may have a hint associated with it, specifying its valid
/// range.
/// </para>
/// <para>
/// `GAction` is merely the interface to the concept of an action, as
/// described above.  Various implementations of actions exist, including
/// [class@Gio.SimpleAction].
/// </para>
/// <para>
/// In all cases, the implementing class is responsible for storing the
/// name of the action, the parameter type, the enabled state, the optional
/// state type and the state and emitting the appropriate signals when these
/// change. The implementor is responsible for filtering calls to
/// [method@Gio.Action.activate] and [method@Gio.Action.change_state]
/// for type safety and for the state being enabled.
/// </para>
/// <para>
/// Probably the only useful thing to do with a `GAction` is to put it
/// inside of a [class@Gio.SimpleActionGroup].
/// </para>
/// </summary>

public interface GActionHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GActionHandleImpl : BaseSafeHandle, GActionHandle
{
}

public static class GActionHandleExtensions
{
/// <summary>
/// <para>
/// Activates the action.
/// </para>
/// <para>
/// @parameter must be the correct type of parameter for the action (ie:
/// the parameter type given at construction time).  If the parameter
/// type was `NULL` then @parameter must also be `NULL`.
/// </para>
/// <para>
/// If the @parameter [type@GLib.Variant] is floating, it is consumed.
/// </para>
/// </summary>

/// <param name="action">
/// a [type@Gio.Action]
/// </param>
/// <param name="parameter">
/// the parameter to the activation
/// </param>

	public static T Activate<T>(this T action, MentorLake.GLib.GVariantHandle parameter) where T : GActionHandle
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GActionHandle)");
		GActionHandleExterns.g_action_activate(action, parameter);
		return action;
	}

/// <summary>
/// <para>
/// Request for the state of @action to be changed to @value.
/// </para>
/// <para>
/// The action must be stateful and @value must be of the correct type.
/// See [method@Gio.Action.get_state_type].
/// </para>
/// <para>
/// This call merely requests a change.  The action may refuse to change
/// its state or may change its state to something other than @value.
/// See [method@Gio.Action.get_state_hint].
/// </para>
/// <para>
/// If the @value [type@GLib.Variant] is floating, it is consumed.
/// </para>
/// </summary>

/// <param name="action">
/// a [type@Gio.Action]
/// </param>
/// <param name="value">
/// the new state
/// </param>

	public static T ChangeState<T>(this T action, MentorLake.GLib.GVariantHandle value) where T : GActionHandle
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GActionHandle)");
		GActionHandleExterns.g_action_change_state(action, value);
		return action;
	}

/// <summary>
/// <para>
/// Checks if @action is currently enabled.
/// </para>
/// <para>
/// An action must be enabled in order to be activated or in order to
/// have its state changed from outside callers.
/// </para>
/// </summary>

/// <param name="action">
/// a [type@Gio.Action]
/// </param>
/// <return>
/// whether the action is enabled
/// </return>

	public static bool GetEnabled(this MentorLake.Gio.GActionHandle action)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GActionHandle)");
		return GActionHandleExterns.g_action_get_enabled(action);
	}

/// <summary>
/// <para>
/// Queries the name of @action.
/// </para>
/// </summary>

/// <param name="action">
/// a [type@Gio.Action]
/// </param>
/// <return>
/// the name of the action
/// </return>

	public static string GetName(this MentorLake.Gio.GActionHandle action)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GActionHandle)");
		return GActionHandleExterns.g_action_get_name(action);
	}

/// <summary>
/// <para>
/// Queries the type of the parameter that must be given when activating
/// @action.
/// </para>
/// <para>
/// When activating the action using [method@Gio.Action.activate], the
/// [type@GLib.Variant] given to that function must be of the type returned by
/// this function.
/// </para>
/// <para>
/// In the case that this function returns `NULL`, you must not give any
/// [type@GLib.Variant], but `NULL` instead.
/// </para>
/// </summary>

/// <param name="action">
/// a [type@Gio.Action]
/// </param>
/// <return>
/// the parameter type
/// </return>

	public static MentorLake.GLib.GVariantTypeHandle GetParameterType(this MentorLake.Gio.GActionHandle action)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GActionHandle)");
		return GActionHandleExterns.g_action_get_parameter_type(action);
	}

/// <summary>
/// <para>
/// Queries the current state of @action.
/// </para>
/// <para>
/// If the action is not stateful then `NULL` will be returned.  If the
/// action is stateful then the type of the return value is the type
/// given by [method@Gio.Action.get_state_type].
/// </para>
/// <para>
/// The return value (if non-`NULL`) should be freed with
/// [method@GLib.Variant.unref] when it is no longer required.
/// </para>
/// </summary>

/// <param name="action">
/// a [type@Gio.Action]
/// </param>
/// <return>
/// the current state of the action
/// </return>

	public static MentorLake.GLib.GVariantHandle GetState(this MentorLake.Gio.GActionHandle action)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GActionHandle)");
		return GActionHandleExterns.g_action_get_state(action);
	}

/// <summary>
/// <para>
/// Requests a hint about the valid range of values for the state of
/// @action.
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

/// <param name="action">
/// a [type@Gio.Action]
/// </param>
/// <return>
/// the state range hint
/// </return>

	public static MentorLake.GLib.GVariantHandle GetStateHint(this MentorLake.Gio.GActionHandle action)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GActionHandle)");
		return GActionHandleExterns.g_action_get_state_hint(action);
	}

/// <summary>
/// <para>
/// Queries the type of the state of @action.
/// </para>
/// <para>
/// If the action is stateful (e.g. created with
/// [ctor@Gio.SimpleAction.new_stateful]) then this function returns the
/// [type@GLib.VariantType] of the state.  This is the type of the initial value
/// given as the state. All calls to [method@Gio.Action.change_state] must give a
/// [type@GLib.Variant] of this type and [method@Gio.Action.get_state] will return a
/// [type@GLib.Variant] of the same type.
/// </para>
/// <para>
/// If the action is not stateful (e.g. created with [ctor@Gio.SimpleAction.new])
/// then this function will return `NULL`. In that case, [method@Gio.Action.get_state]
/// will return `NULL` and you must not call [method@Gio.Action.change_state].
/// </para>
/// </summary>

/// <param name="action">
/// a [type@Gio.Action]
/// </param>
/// <return>
/// the state type, if the action is stateful
/// </return>

	public static MentorLake.GLib.GVariantTypeHandle GetStateType(this MentorLake.Gio.GActionHandle action)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GActionHandle)");
		return GActionHandleExterns.g_action_get_state_type(action);
	}

/// <summary>
/// <para>
/// Checks if @action_name is valid.
/// </para>
/// <para>
/// @action_name is valid if it consists only of alphanumeric characters,
/// plus `-` and `.`.  The empty string is not a valid action name.
/// </para>
/// <para>
/// It is an error to call this function with a non-UTF-8 @action_name.
/// @action_name must not be `NULL`.
/// </para>
/// </summary>

/// <param name="action_name">
/// a potential action name
/// </param>
/// <return>
/// `TRUE` if @action_name is valid
/// </return>

	public static bool NameIsValid(string action_name)
	{
		return GActionHandleExterns.g_action_name_is_valid(action_name);
	}

/// <summary>
/// <para>
/// Parses a detailed action name into its separate name and target
/// components.
/// </para>
/// <para>
/// Detailed action names can have three formats.
/// </para>
/// <para>
/// The first format is used to represent an action name with no target
/// value and consists of just an action name containing no whitespace
/// nor the characters `:`, `(` or `)`.  For example: `app.action`.
/// </para>
/// <para>
/// The second format is used to represent an action with a target value
/// that is a non-empty string consisting only of alphanumerics, plus `-`
/// and `.`.  In that case, the action name and target value are
/// separated by a double colon (`::`).  For example:
/// `app.action::target`.
/// </para>
/// <para>
/// The third format is used to represent an action with any type of
/// target value, including strings.  The target value follows the action
/// name, surrounded in parens.  For example: `app.action(42)`.  The
/// target value is parsed using [func@GLib.Variant.parse].  If a tuple-typed
/// value is desired, it must be specified in the same way, resulting in
/// two sets of parens, for example: `app.action((1,2,3))`.  A string
/// target can be specified this way as well: `app.action(&apos;target&apos;)`.
/// For strings, this third format must be used if target value is
/// empty or contains characters other than alphanumerics, `-` and `.`.
/// </para>
/// <para>
/// If this function returns `TRUE`, a non-`NULL` value is guaranteed to be returned
/// in @action_name (if a pointer is passed in). A `NULL` value may still be
/// returned in @target_value, as the @detailed_name may not contain a target.
/// </para>
/// <para>
/// If returned, the [type@GLib.Variant] in @target_value is guaranteed to not be floating.
/// </para>
/// </summary>

/// <param name="detailed_name">
/// a detailed action name
/// </param>
/// <param name="action_name">
/// the action name
/// </param>
/// <param name="target_value">
/// the target value,
///   or `NULL` for no target
/// </param>
/// <return>
/// `TRUE` if successful, else `FALSE` with @error set
/// </return>

	public static bool ParseDetailedName(string detailed_name, out string action_name, out MentorLake.GLib.GVariantHandle target_value)
	{
		var externCallResult = GActionHandleExterns.g_action_parse_detailed_name(detailed_name, out action_name, out target_value, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Formats a detailed action name from @action_name and @target_value.
/// </para>
/// <para>
/// It is an error to call this function with an invalid action name.
/// </para>
/// <para>
/// This function is the opposite of [func@Gio.Action.parse_detailed_name].
/// It will produce a string that can be parsed back to the @action_name
/// and @target_value by that function.
/// </para>
/// <para>
/// See that function for the types of strings that will be printed by
/// this function.
/// </para>
/// </summary>

/// <param name="action_name">
/// a valid action name
/// </param>
/// <param name="target_value">
/// a [type@GLib.Variant] target value, or `NULL`
/// </param>
/// <return>
/// a detailed format string
/// </return>

	public static string PrintDetailedName(string action_name, MentorLake.GLib.GVariantHandle target_value)
	{
		return GActionHandleExterns.g_action_print_detailed_name(action_name, target_value);
	}

}

internal class GActionHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern void g_action_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionHandleImpl>))] MentorLake.Gio.GActionHandle action, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameter);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_action_change_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionHandleImpl>))] MentorLake.Gio.GActionHandle action, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_action_get_enabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionHandleImpl>))] MentorLake.Gio.GActionHandle action);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_action_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionHandleImpl>))] MentorLake.Gio.GActionHandle action);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))]
	internal static extern MentorLake.GLib.GVariantTypeHandle g_action_get_parameter_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionHandleImpl>))] MentorLake.Gio.GActionHandle action);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_action_get_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionHandleImpl>))] MentorLake.Gio.GActionHandle action);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_action_get_state_hint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionHandleImpl>))] MentorLake.Gio.GActionHandle action);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))]
	internal static extern MentorLake.GLib.GVariantTypeHandle g_action_get_state_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionHandleImpl>))] MentorLake.Gio.GActionHandle action);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_action_name_is_valid(string action_name);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_action_parse_detailed_name(string detailed_name, out string action_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] out MentorLake.GLib.GVariantHandle target_value, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_action_print_detailed_name(string action_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle target_value);

}
