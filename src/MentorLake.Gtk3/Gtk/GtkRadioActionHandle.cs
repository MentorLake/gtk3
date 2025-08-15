namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A #GtkRadioAction is similar to #GtkRadioMenuItem. A number of radio
/// actions can be linked together so that only one may be active at any
/// one time.
/// </para>
/// </summary>

public class GtkRadioActionHandle : GtkToggleActionHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkRadioAction object. To add the action to
/// a #GtkActionGroup and set the accelerator for the action,
/// call gtk_action_group_add_action_with_accel().
/// </para>
/// </summary>

/// <param name="name">
/// A unique name for the action
/// </param>
/// <param name="label">
/// The label displayed in menu items and on buttons,
///   or %NULL
/// </param>
/// <param name="tooltip">
/// A tooltip for this action, or %NULL
/// </param>
/// <param name="stock_id">
/// The stock icon to display in widgets representing
///   this action, or %NULL
/// </param>
/// <param name="value">
/// The value which gtk_radio_action_get_current_value() should
///   return if this action is selected.
/// </param>
/// <return>
/// a new #GtkRadioAction
/// </return>

	public static MentorLake.Gtk.GtkRadioActionHandle New(string name, string label, string tooltip, string stock_id, int value)
	{
		return GtkRadioActionHandleExterns.gtk_radio_action_new(name, label, tooltip, stock_id, value);
	}

}
public static class GtkRadioActionHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::changed signal is emitted on every member of a radio group when the
/// active member is changed. The signal gets emitted after the ::activate signals
/// for the previous and current active members.
/// </para>
/// </summary>

	public static IObservable<GtkRadioActionHandleSignalStructs.ChangedSignal> Signal_Changed(this GtkRadioActionHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkRadioActionHandleSignalStructs.ChangedSignal> obs) =>
		{
			GtkRadioActionHandleSignalDelegates.changed handler = ( MentorLake.Gtk.GtkRadioActionHandle self,  MentorLake.Gtk.GtkRadioActionHandle current,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkRadioActionHandleSignalStructs.ChangedSignal()
				{
					Self = self, Current = current, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkRadioActionHandleSignalStructs
{

public class ChangedSignal
{

	public MentorLake.Gtk.GtkRadioActionHandle Self;
/// <summary>
/// <para>
/// the member of @action&apos;s group which has just been activated
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkRadioActionHandle Current;

	public IntPtr UserData;
}
}

public static class GtkRadioActionHandleSignalDelegates
{

/// <summary>
/// <para>
/// The ::changed signal is emitted on every member of a radio group when the
/// active member is changed. The signal gets emitted after the ::activate signals
/// for the previous and current active members.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="current">
/// the member of @action&apos;s group which has just been activated
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioActionHandle>))] MentorLake.Gtk.GtkRadioActionHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioActionHandle>))] MentorLake.Gtk.GtkRadioActionHandle current, IntPtr user_data);

}


public static class GtkRadioActionHandleExtensions
{
/// <summary>
/// <para>
/// Obtains the value property of the currently active member of
/// the group to which @action belongs.
/// </para>
/// </summary>

/// <param name="action">
/// a #GtkRadioAction
/// </param>
/// <return>
/// The value of the currently active group member
/// </return>

	public static int GetCurrentValue(this MentorLake.Gtk.GtkRadioActionHandle action)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkRadioActionHandle)");
		return GtkRadioActionHandleExterns.gtk_radio_action_get_current_value(action);
	}

/// <summary>
/// <para>
/// Returns the list representing the radio group for this object.
/// Note that the returned list is only valid until the next change
/// to the group.
/// </para>
/// <para>
/// A common way to set up a group of radio group is the following:
/// <code>
///   GSList *group = NULL;
///   GSList *group = NULL;
///   GtkRadioAction *action;
/// 
///   while ( ...more actions to add... /)
///     {
///        action = gtk_radio_action_new (...);
/// 
///        gtk_radio_action_set_group (action, group);
///        group = gtk_radio_action_get_group (action);
///     }
/// </code>
/// </para>
/// </summary>

/// <param name="action">
/// the action object
/// </param>
/// <return>
/// the list representing the radio group for this object
/// </return>

	public static MentorLake.GLib.GSListHandle GetGroup(this MentorLake.Gtk.GtkRadioActionHandle action)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkRadioActionHandle)");
		return GtkRadioActionHandleExterns.gtk_radio_action_get_group(action);
	}

/// <summary>
/// <para>
/// Joins a radio action object to the group of another radio action object.
/// </para>
/// <para>
/// Use this in language bindings instead of the gtk_radio_action_get_group()
/// and gtk_radio_action_set_group() methods
/// </para>
/// <para>
/// A common way to set up a group of radio actions is the following:
/// <code>
///   GtkRadioAction *action;
///   GtkRadioAction *action;
///   GtkRadioAction *last_action;
/// 
///   while ( ...more actions to add... /)
///     {
///        action = gtk_radio_action_new (...);
/// 
///        gtk_radio_action_join_group (action, last_action);
///        last_action = action;
///     }
/// </code>
/// </para>
/// </summary>

/// <param name="action">
/// the action object
/// </param>
/// <param name="group_source">
/// a radio action object whos group we are
///   joining, or %NULL to remove the radio action from its group
/// </param>

	public static T JoinGroup<T>(this T action, MentorLake.Gtk.GtkRadioActionHandle group_source) where T : GtkRadioActionHandle
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkRadioActionHandle)");
		GtkRadioActionHandleExterns.gtk_radio_action_join_group(action, group_source);
		return action;
	}

/// <summary>
/// <para>
/// Sets the currently active group member to the member with value
/// property @current_value.
/// </para>
/// </summary>

/// <param name="action">
/// a #GtkRadioAction
/// </param>
/// <param name="current_value">
/// the new value
/// </param>

	public static T SetCurrentValue<T>(this T action, int current_value) where T : GtkRadioActionHandle
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkRadioActionHandle)");
		GtkRadioActionHandleExterns.gtk_radio_action_set_current_value(action, current_value);
		return action;
	}

/// <summary>
/// <para>
/// Sets the radio group for the radio action object.
/// </para>
/// </summary>

/// <param name="action">
/// the action object
/// </param>
/// <param name="group">
/// a list representing a radio group, or %NULL
/// </param>

	public static T SetGroup<T>(this T action, MentorLake.GLib.GSListHandle group) where T : GtkRadioActionHandle
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkRadioActionHandle)");
		GtkRadioActionHandleExterns.gtk_radio_action_set_group(action, group);
		return action;
	}

}

internal class GtkRadioActionHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkRadioActionHandle>))]
	internal static extern MentorLake.Gtk.GtkRadioActionHandle gtk_radio_action_new(string name, string label, string tooltip, string stock_id, int value);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_radio_action_get_current_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioActionHandle>))] MentorLake.Gtk.GtkRadioActionHandle action);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle gtk_radio_action_get_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioActionHandle>))] MentorLake.Gtk.GtkRadioActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_radio_action_join_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioActionHandle>))] MentorLake.Gtk.GtkRadioActionHandle action, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioActionHandle>))] MentorLake.Gtk.GtkRadioActionHandle group_source);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_radio_action_set_current_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioActionHandle>))] MentorLake.Gtk.GtkRadioActionHandle action, int current_value);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_radio_action_set_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioActionHandle>))] MentorLake.Gtk.GtkRadioActionHandle action, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle group);

}
