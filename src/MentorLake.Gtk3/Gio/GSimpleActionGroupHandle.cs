namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GSimpleActionGroup` is a hash table filled with [iface@Gio.Action] objects,
/// implementing the [iface@Gio.ActionGroup] and [iface@Gio.ActionMap]
/// interfaces.
/// </para>
/// </summary>

public class GSimpleActionGroupHandle : GObjectHandle, GActionGroupHandle, GActionMapHandle
{
/// <summary>
/// <para>
/// Creates a new, empty, #GSimpleActionGroup.
/// </para>
/// </summary>

/// <return>
/// a new #GSimpleActionGroup
/// </return>

	public static MentorLake.Gio.GSimpleActionGroupHandle New()
	{
		return GSimpleActionGroupHandleExterns.g_simple_action_group_new();
	}

}
public static class GSimpleActionGroupHandleSignalExtensions
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

	public static IObservable<GSimpleActionGroupHandleSignalStructs.ActionAddedSignal> Signal_ActionAdded(this GSimpleActionGroupHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GSimpleActionGroupHandleSignalStructs.ActionAddedSignal> obs) =>
		{
			GSimpleActionGroupHandleSignalDelegates.action_added handler = ( MentorLake.Gio.GActionGroupHandle self,  string action_name,  IntPtr user_data) =>
			{
				

				var signalStruct = new GSimpleActionGroupHandleSignalStructs.ActionAddedSignal()
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

	public static IObservable<GSimpleActionGroupHandleSignalStructs.ActionEnabledChangedSignal> Signal_ActionEnabledChanged(this GSimpleActionGroupHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GSimpleActionGroupHandleSignalStructs.ActionEnabledChangedSignal> obs) =>
		{
			GSimpleActionGroupHandleSignalDelegates.action_enabled_changed handler = ( MentorLake.Gio.GActionGroupHandle self,  string action_name,  bool enabled,  IntPtr user_data) =>
			{
				

				var signalStruct = new GSimpleActionGroupHandleSignalStructs.ActionEnabledChangedSignal()
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

	public static IObservable<GSimpleActionGroupHandleSignalStructs.ActionRemovedSignal> Signal_ActionRemoved(this GSimpleActionGroupHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GSimpleActionGroupHandleSignalStructs.ActionRemovedSignal> obs) =>
		{
			GSimpleActionGroupHandleSignalDelegates.action_removed handler = ( MentorLake.Gio.GActionGroupHandle self,  string action_name,  IntPtr user_data) =>
			{
				

				var signalStruct = new GSimpleActionGroupHandleSignalStructs.ActionRemovedSignal()
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

	public static IObservable<GSimpleActionGroupHandleSignalStructs.ActionStateChangedSignal> Signal_ActionStateChanged(this GSimpleActionGroupHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GSimpleActionGroupHandleSignalStructs.ActionStateChangedSignal> obs) =>
		{
			GSimpleActionGroupHandleSignalDelegates.action_state_changed handler = ( MentorLake.Gio.GActionGroupHandle self,  string action_name,  MentorLake.GLib.GVariantHandle value,  IntPtr user_data) =>
			{
				

				var signalStruct = new GSimpleActionGroupHandleSignalStructs.ActionStateChangedSignal()
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

public static class GSimpleActionGroupHandleSignalStructs
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

public static class GSimpleActionGroupHandleSignalDelegates
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


public static class GSimpleActionGroupHandleExtensions
{
/// <summary>
/// <para>
/// A convenience function for creating multiple #GSimpleAction instances
/// and adding them to the action group.
/// </para>
/// </summary>

/// <param name="simple">
/// a #GSimpleActionGroup
/// </param>
/// <param name="entries">
/// a pointer to the first item in
///           an array of #GActionEntry structs
/// </param>
/// <param name="n_entries">
/// the length of @entries, or -1
/// </param>
/// <param name="user_data">
/// the user data for signal connections
/// </param>

	public static T AddEntries<T>(this T simple, MentorLake.Gio.GActionEntry[] entries, int n_entries, IntPtr user_data) where T : GSimpleActionGroupHandle
	{
		if (simple.IsInvalid) throw new Exception("Invalid handle (GSimpleActionGroupHandle)");
		GSimpleActionGroupHandleExterns.g_simple_action_group_add_entries(simple, entries, n_entries, user_data);
		return simple;
	}

/// <summary>
/// <para>
/// Adds an action to the action group.
/// </para>
/// <para>
/// If the action group already contains an action with the same name as
/// @action then the old action is dropped from the group.
/// </para>
/// <para>
/// The action group takes its own reference on @action.
/// </para>
/// </summary>

/// <param name="simple">
/// a #GSimpleActionGroup
/// </param>
/// <param name="action">
/// a #GAction
/// </param>

	public static T Insert<T>(this T simple, MentorLake.Gio.GActionHandle action) where T : GSimpleActionGroupHandle
	{
		if (simple.IsInvalid) throw new Exception("Invalid handle (GSimpleActionGroupHandle)");
		GSimpleActionGroupHandleExterns.g_simple_action_group_insert(simple, action);
		return simple;
	}

/// <summary>
/// <para>
/// Looks up the action with the name @action_name in the group.
/// </para>
/// <para>
/// If no such action exists, returns %NULL.
/// </para>
/// </summary>

/// <param name="simple">
/// a #GSimpleActionGroup
/// </param>
/// <param name="action_name">
/// the name of an action
/// </param>
/// <return>
/// a #GAction, or %NULL
/// </return>

	public static MentorLake.Gio.GActionHandle Lookup(this MentorLake.Gio.GSimpleActionGroupHandle simple, string action_name)
	{
		if (simple.IsInvalid) throw new Exception("Invalid handle (GSimpleActionGroupHandle)");
		return GSimpleActionGroupHandleExterns.g_simple_action_group_lookup(simple, action_name);
	}

/// <summary>
/// <para>
/// Removes the named action from the action group.
/// </para>
/// <para>
/// If no action of this name is in the group then nothing happens.
/// </para>
/// </summary>

/// <param name="simple">
/// a #GSimpleActionGroup
/// </param>
/// <param name="action_name">
/// the name of the action
/// </param>

	public static T Remove<T>(this T simple, string action_name) where T : GSimpleActionGroupHandle
	{
		if (simple.IsInvalid) throw new Exception("Invalid handle (GSimpleActionGroupHandle)");
		GSimpleActionGroupHandleExterns.g_simple_action_group_remove(simple, action_name);
		return simple;
	}

}

internal class GSimpleActionGroupHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSimpleActionGroupHandle>))]
	internal static extern MentorLake.Gio.GSimpleActionGroupHandle g_simple_action_group_new();

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_action_group_add_entries([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleActionGroupHandle>))] MentorLake.Gio.GSimpleActionGroupHandle simple, MentorLake.Gio.GActionEntry[] entries, int n_entries, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_action_group_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleActionGroupHandle>))] MentorLake.Gio.GSimpleActionGroupHandle simple, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionHandleImpl>))] MentorLake.Gio.GActionHandle action);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionHandleImpl>))]
	internal static extern MentorLake.Gio.GActionHandle g_simple_action_group_lookup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleActionGroupHandle>))] MentorLake.Gio.GSimpleActionGroupHandle simple, string action_name);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_action_group_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleActionGroupHandle>))] MentorLake.Gio.GSimpleActionGroupHandle simple, string action_name);

}
