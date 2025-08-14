namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GDBusActionGroup` is an implementation of the [iface@Gio.ActionGroup]
/// interface.
/// </para>
/// <para>
/// `GDBusActionGroup` can be used as a proxy for an action group
/// that is exported over D-Bus with [method@Gio.DBusConnection.export_action_group].
/// </para>
/// </summary>

public class GDBusActionGroupHandle : GObjectHandle, GActionGroupHandle, GRemoteActionGroupHandle
{
/// <summary>
/// <para>
/// Obtains a #GDBusActionGroup for the action group which is exported at
/// the given @bus_name and @object_path.
/// </para>
/// <para>
/// The thread default main context is taken at the time of this call.
/// All signals on the menu model (and any linked models) are reported
/// with respect to this context.  All calls on the returned menu model
/// (and linked models) must also originate from this same context, with
/// the thread default main context unchanged.
/// </para>
/// <para>
/// This call is non-blocking.  The returned action group may or may not
/// already be filled in.  The correct thing to do is connect the signals
/// for the action group to monitor for changes and then to call
/// g_action_group_list_actions() to get the initial list.
/// </para>
/// </summary>

/// <param name="connection">
/// A #GDBusConnection
/// </param>
/// <param name="bus_name">
/// the bus name which exports the action
///     group or %NULL if @connection is not a message bus connection
/// </param>
/// <param name="object_path">
/// the object path at which the action group is exported
/// </param>
/// <return>
/// a #GDBusActionGroup
/// </return>

	public static MentorLake.Gio.GDBusActionGroupHandle Get(MentorLake.Gio.GDBusConnectionHandle connection, string bus_name, string object_path)
	{
		return GDBusActionGroupHandleExterns.g_dbus_action_group_get(connection, bus_name, object_path);
	}

}
public static class GDBusActionGroupHandleSignalExtensions
{
/// <summary>
/// <para>
/// Signals that a new action was just added to the group.
/// </para>
/// <para>
/// This signal is emitted after the action has been added
/// and is now visible.
/// </para>
/// </summary>

	public static IObservable<GDBusActionGroupHandleSignalStructs.ActionAddedSignal> Signal_ActionAdded(this GDBusActionGroupHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GDBusActionGroupHandleSignalStructs.ActionAddedSignal> obs) =>
		{
			GDBusActionGroupHandleSignalDelegates.action_added handler = ( MentorLake.Gio.GActionGroupHandle self,  string action_name,  IntPtr user_data) =>
			{
				

				var signalStruct = new GDBusActionGroupHandleSignalStructs.ActionAddedSignal()
				{
					Self = self, ActionName = action_name, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "action-added", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
/// <summary>
/// <para>
/// Signals that the enabled status of the named action has changed.
/// </para>
/// </summary>

	public static IObservable<GDBusActionGroupHandleSignalStructs.ActionEnabledChangedSignal> Signal_ActionEnabledChanged(this GDBusActionGroupHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GDBusActionGroupHandleSignalStructs.ActionEnabledChangedSignal> obs) =>
		{
			GDBusActionGroupHandleSignalDelegates.action_enabled_changed handler = ( MentorLake.Gio.GActionGroupHandle self,  string action_name,  bool enabled,  IntPtr user_data) =>
			{
				

				var signalStruct = new GDBusActionGroupHandleSignalStructs.ActionEnabledChangedSignal()
				{
					Self = self, ActionName = action_name, Enabled = enabled, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "action-enabled-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
/// <summary>
/// <para>
/// Signals that an action is just about to be removed from the group.
/// </para>
/// <para>
/// This signal is emitted before the action is removed, so the action
/// is still visible and can be queried from the signal handler.
/// </para>
/// </summary>

	public static IObservable<GDBusActionGroupHandleSignalStructs.ActionRemovedSignal> Signal_ActionRemoved(this GDBusActionGroupHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GDBusActionGroupHandleSignalStructs.ActionRemovedSignal> obs) =>
		{
			GDBusActionGroupHandleSignalDelegates.action_removed handler = ( MentorLake.Gio.GActionGroupHandle self,  string action_name,  IntPtr user_data) =>
			{
				

				var signalStruct = new GDBusActionGroupHandleSignalStructs.ActionRemovedSignal()
				{
					Self = self, ActionName = action_name, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "action-removed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
/// <summary>
/// <para>
/// Signals that the state of the named action has changed.
/// </para>
/// </summary>

	public static IObservable<GDBusActionGroupHandleSignalStructs.ActionStateChangedSignal> Signal_ActionStateChanged(this GDBusActionGroupHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GDBusActionGroupHandleSignalStructs.ActionStateChangedSignal> obs) =>
		{
			GDBusActionGroupHandleSignalDelegates.action_state_changed handler = ( MentorLake.Gio.GActionGroupHandle self,  string action_name,  MentorLake.GLib.GVariantHandle value,  IntPtr user_data) =>
			{
				

				var signalStruct = new GDBusActionGroupHandleSignalStructs.ActionStateChangedSignal()
				{
					Self = self, ActionName = action_name, Value = value, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "action-state-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GDBusActionGroupHandleSignalStructs
{

public class ActionAddedSignal
{

	public MentorLake.Gio.GActionGroupHandle Self;
/// <summary>
/// <para>
/// the name of the action in @action_group
/// </para>
/// </summary>

	public string ActionName;

	public IntPtr UserData;
}

public class ActionEnabledChangedSignal
{

	public MentorLake.Gio.GActionGroupHandle Self;
/// <summary>
/// <para>
/// the name of the action in @action_group
/// </para>
/// </summary>

	public string ActionName;
/// <summary>
/// <para>
/// whether the action is enabled
/// </para>
/// </summary>

	public bool Enabled;

	public IntPtr UserData;
}

public class ActionRemovedSignal
{

	public MentorLake.Gio.GActionGroupHandle Self;
/// <summary>
/// <para>
/// the name of the action in @action_group
/// </para>
/// </summary>

	public string ActionName;

	public IntPtr UserData;
}

public class ActionStateChangedSignal
{

	public MentorLake.Gio.GActionGroupHandle Self;
/// <summary>
/// <para>
/// the name of the action in @action_group
/// </para>
/// </summary>

	public string ActionName;
/// <summary>
/// <para>
/// the new value of the state
/// </para>
/// </summary>

	public MentorLake.GLib.GVariantHandle Value;

	public IntPtr UserData;
}
}

public static class GDBusActionGroupHandleSignalDelegates
{

/// <summary>
/// <para>
/// Signals that a new action was just added to the group.
/// </para>
/// <para>
/// This signal is emitted after the action has been added
/// and is now visible.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="action_name">
/// the name of the action in @action_group
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void action_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle self, string action_name, IntPtr user_data);


/// <summary>
/// <para>
/// Signals that the enabled status of the named action has changed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="action_name">
/// the name of the action in @action_group
/// </param>
/// <param name="enabled">
/// whether the action is enabled
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void action_enabled_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle self, string action_name, bool enabled, IntPtr user_data);


/// <summary>
/// <para>
/// Signals that an action is just about to be removed from the group.
/// </para>
/// <para>
/// This signal is emitted before the action is removed, so the action
/// is still visible and can be queried from the signal handler.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="action_name">
/// the name of the action in @action_group
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void action_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle self, string action_name, IntPtr user_data);


/// <summary>
/// <para>
/// Signals that the state of the named action has changed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="action_name">
/// the name of the action in @action_group
/// </param>
/// <param name="value">
/// the new value of the state
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void action_state_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle self, string action_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, IntPtr user_data);

}


public static class GDBusActionGroupHandleExtensions
{
}

internal class GDBusActionGroupHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GDBusActionGroupHandle>))]
	internal static extern MentorLake.Gio.GDBusActionGroupHandle g_dbus_action_group_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string bus_name, string object_path);

}
