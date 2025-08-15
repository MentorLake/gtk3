namespace MentorLake.Atk;

/// <summary>
/// <para>
/// The ATK interface provided by UI components
/// which the user can activate/interact with.
/// </para>
/// <para>
/// #AtkAction should be implemented by instances of #AtkObject classes
/// with which the user can interact directly, i.e. buttons,
/// checkboxes, scrollbars, e.g. components which are not &quot;passive&quot;
/// providers of UI information.
/// </para>
/// <para>
/// Exceptions: when the user interaction is already covered by another
/// appropriate interface such as #AtkEditableText (insert/delete text,
/// etc.) or #AtkValue (set value) then these actions should not be
/// exposed by #AtkAction as well.
/// </para>
/// <para>
/// Though most UI interactions on components should be invocable via
/// keyboard as well as mouse, there will generally be a close mapping
/// between &quot;mouse actions&quot; that are possible on a component and the
/// AtkActions.  Where mouse and keyboard actions are redundant in
/// effect, #AtkAction should expose only one action rather than
/// exposing redundant actions if possible.  By convention we have been
/// using &quot;mouse centric&quot; terminology for #AtkAction names.
/// </para>
/// </summary>

public interface AtkActionHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class AtkActionHandleImpl : BaseSafeHandle, AtkActionHandle
{
}

public static class AtkActionHandleExtensions
{
/// <summary>
/// <para>
/// Perform the specified action on the object.
/// </para>
/// </summary>

/// <param name="action">
/// a #GObject instance that implements AtkActionIface
/// </param>
/// <param name="i">
/// the action index corresponding to the action to be performed
/// </param>
/// <return>
/// %TRUE if success, %FALSE otherwise
/// </return>

	public static bool DoAction(this MentorLake.Atk.AtkActionHandle action, int i)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (AtkActionHandle)");
		return AtkActionHandleExterns.atk_action_do_action(action, i);
	}

/// <summary>
/// <para>
/// Returns a description of the specified action of the object.
/// </para>
/// </summary>

/// <param name="action">
/// a #GObject instance that implements AtkActionIface
/// </param>
/// <param name="i">
/// the action index corresponding to the action to be performed
/// </param>
/// <return>
/// a description string, or %NULL if @action does
/// not implement this interface.
/// </return>

	public static string GetDescription(this MentorLake.Atk.AtkActionHandle action, int i)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (AtkActionHandle)");
		return AtkActionHandleExterns.atk_action_get_description(action, i);
	}

/// <summary>
/// <para>
/// Gets the keybinding which can be used to activate this action, if one
/// exists. The string returned should contain localized, human-readable,
/// key sequences as they would appear when displayed on screen. It must
/// be in the format &quot;mnemonic;sequence;shortcut&quot;.
/// </para>
/// <para>
/// - The mnemonic key activates the object if it is presently enabled onscreen.
///   This typically corresponds to the underlined letter within the widget.
///   Example: &quot;n&quot; in a traditional &quot;New...&quot; menu item or the &quot;a&quot; in &quot;Apply&quot; for
///   a button.
/// - The sequence is the full list of keys which invoke the action even if the
///   relevant element is not currently shown on screen. For instance, for a menu
///   item the sequence is the keybindings used to open the parent menus before
///   invoking. The sequence string is colon-delimited. Example: &quot;Alt+F:N&quot; in a
///   traditional &quot;New...&quot; menu item.
/// - The shortcut, if it exists, will invoke the same action without showing
///   the component or its enclosing menus or dialogs. Example: &quot;Ctrl+N&quot; in a
///   traditional &quot;New...&quot; menu item.
/// </para>
/// <para>
/// Example: For a traditional &quot;New...&quot; menu item, the expected return value
/// would be: &quot;N;Alt+F:N;Ctrl+N&quot; for the English locale and &quot;N;Alt+D:N;Strg+N&quot;
/// for the German locale. If, hypothetically, this menu item lacked a mnemonic,
/// it would be represented by &quot;;;Ctrl+N&quot; and &quot;;;Strg+N&quot; respectively.
/// </para>
/// </summary>

/// <param name="action">
/// a #GObject instance that implements AtkActionIface
/// </param>
/// <param name="i">
/// the action index corresponding to the action to be performed
/// </param>
/// <return>
/// the keybinding which can be used to activate
/// this action, or %NULL if there is no keybinding for this action.
/// </return>

	public static string GetKeybinding(this MentorLake.Atk.AtkActionHandle action, int i)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (AtkActionHandle)");
		return AtkActionHandleExterns.atk_action_get_keybinding(action, i);
	}

/// <summary>
/// <para>
/// Returns the localized name of the specified action of the object.
/// </para>
/// </summary>

/// <param name="action">
/// a #GObject instance that implements AtkActionIface
/// </param>
/// <param name="i">
/// the action index corresponding to the action to be performed
/// </param>
/// <return>
/// a name string, or %NULL if @action does not
/// implement this interface.
/// </return>

	public static string GetLocalizedName(this MentorLake.Atk.AtkActionHandle action, int i)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (AtkActionHandle)");
		return AtkActionHandleExterns.atk_action_get_localized_name(action, i);
	}

/// <summary>
/// <para>
/// Gets the number of accessible actions available on the object.
/// If there are more than one, the first one is considered the
/// &quot;default&quot; action of the object.
/// </para>
/// </summary>

/// <param name="action">
/// a #GObject instance that implements AtkActionIface
/// </param>
/// <return>
/// a the number of actions, or 0 if @action does not
/// implement this interface.
/// </return>

	public static int GetNActions(this MentorLake.Atk.AtkActionHandle action)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (AtkActionHandle)");
		return AtkActionHandleExterns.atk_action_get_n_actions(action);
	}

/// <summary>
/// <para>
/// Returns a non-localized string naming the specified action of the
/// object. This name is generally not descriptive of the end result
/// of the action, but instead names the &apos;interaction type&apos; which the
/// object supports. By convention, the above strings should be used to
/// represent the actions which correspond to the common point-and-click
/// interaction techniques of the same name: i.e.
/// &quot;click&quot;, &quot;press&quot;, &quot;release&quot;, &quot;drag&quot;, &quot;drop&quot;, &quot;popup&quot;, etc.
/// The &quot;popup&quot; action should be used to pop up a context menu for the
/// object, if one exists.
/// </para>
/// <para>
/// For technical reasons, some toolkits cannot guarantee that the
/// reported action is actually &apos;bound&apos; to a nontrivial user event;
/// i.e. the result of some actions via atk_action_do_action() may be
/// NIL.
/// </para>
/// </summary>

/// <param name="action">
/// a #GObject instance that implements AtkActionIface
/// </param>
/// <param name="i">
/// the action index corresponding to the action to be performed
/// </param>
/// <return>
/// a name string, or %NULL if @action does not
/// implement this interface.
/// </return>

	public static string GetName(this MentorLake.Atk.AtkActionHandle action, int i)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (AtkActionHandle)");
		return AtkActionHandleExterns.atk_action_get_name(action, i);
	}

/// <summary>
/// <para>
/// Sets a description of the specified action of the object.
/// </para>
/// </summary>

/// <param name="action">
/// a #GObject instance that implements AtkActionIface
/// </param>
/// <param name="i">
/// the action index corresponding to the action to be performed
/// </param>
/// <param name="desc">
/// the description to be assigned to this action
/// </param>
/// <return>
/// a gboolean representing if the description was successfully set;
/// </return>

	public static bool SetDescription(this MentorLake.Atk.AtkActionHandle action, int i, string desc)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (AtkActionHandle)");
		return AtkActionHandleExterns.atk_action_set_description(action, i, desc);
	}

}

internal class AtkActionHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_action_do_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkActionHandleImpl>))] MentorLake.Atk.AtkActionHandle action, int i);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_action_get_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkActionHandleImpl>))] MentorLake.Atk.AtkActionHandle action, int i);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_action_get_keybinding([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkActionHandleImpl>))] MentorLake.Atk.AtkActionHandle action, int i);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_action_get_localized_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkActionHandleImpl>))] MentorLake.Atk.AtkActionHandle action, int i);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_action_get_n_actions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkActionHandleImpl>))] MentorLake.Atk.AtkActionHandle action);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_action_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkActionHandleImpl>))] MentorLake.Atk.AtkActionHandle action, int i);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_action_set_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkActionHandleImpl>))] MentorLake.Atk.AtkActionHandle action, int i, string desc);

}
