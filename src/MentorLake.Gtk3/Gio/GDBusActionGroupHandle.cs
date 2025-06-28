namespace MentorLake.Gio;

public class GDBusActionGroupHandle : GObjectHandle, GActionGroupHandle, GRemoteActionGroupHandle
{
	public static MentorLake.Gio.GDBusActionGroupHandle Get(MentorLake.Gio.GDBusConnectionHandle connection, string bus_name, string object_path)
	{
		return GDBusActionGroupHandleExterns.g_dbus_action_group_get(connection, bus_name, object_path);
	}

}
public static class GDBusActionGroupHandleSignalExtensions
{

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
	public string ActionName;
	public IntPtr UserData;
}

public class ActionEnabledChangedSignal
{
	public MentorLake.Gio.GActionGroupHandle Self;
	public string ActionName;
	public bool Enabled;
	public IntPtr UserData;
}

public class ActionRemovedSignal
{
	public MentorLake.Gio.GActionGroupHandle Self;
	public string ActionName;
	public IntPtr UserData;
}

public class ActionStateChangedSignal
{
	public MentorLake.Gio.GActionGroupHandle Self;
	public string ActionName;
	public MentorLake.GLib.GVariantHandle Value;
	public IntPtr UserData;
}
}

public static class GDBusActionGroupHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void action_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle self, string action_name, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void action_enabled_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle self, string action_name, bool enabled, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void action_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle self, string action_name, IntPtr user_data);


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
