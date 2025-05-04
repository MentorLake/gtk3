namespace MentorLake.Gio;

public class GSimpleActionGroupHandle : GObjectHandle, GActionGroupHandle, GActionMapHandle
{
	public static MentorLake.Gio.GSimpleActionGroupHandle New()
	{
		return GSimpleActionGroupHandleExterns.g_simple_action_group_new();
	}

}
public static class GSimpleActionGroupHandleSignalExtensions
{

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

public static class GSimpleActionGroupHandleSignalDelegates
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


public static class GSimpleActionGroupHandleExtensions
{
	public static T AddEntries<T>(this T simple, MentorLake.Gio.GActionEntry[] entries, int n_entries, IntPtr user_data) where T : GSimpleActionGroupHandle
	{
		if (simple.IsInvalid || simple.IsClosed) throw new Exception("Invalid or closed handle (GSimpleActionGroupHandle)");
		GSimpleActionGroupHandleExterns.g_simple_action_group_add_entries(simple, entries, n_entries, user_data);
		return simple;
	}

	public static T Insert<T>(this T simple, MentorLake.Gio.GActionHandle action) where T : GSimpleActionGroupHandle
	{
		if (simple.IsInvalid || simple.IsClosed) throw new Exception("Invalid or closed handle (GSimpleActionGroupHandle)");
		GSimpleActionGroupHandleExterns.g_simple_action_group_insert(simple, action);
		return simple;
	}

	public static MentorLake.Gio.GActionHandle Lookup(this MentorLake.Gio.GSimpleActionGroupHandle simple, string action_name)
	{
		if (simple.IsInvalid || simple.IsClosed) throw new Exception("Invalid or closed handle (GSimpleActionGroupHandle)");
		return GSimpleActionGroupHandleExterns.g_simple_action_group_lookup(simple, action_name);
	}

	public static T Remove<T>(this T simple, string action_name) where T : GSimpleActionGroupHandle
	{
		if (simple.IsInvalid || simple.IsClosed) throw new Exception("Invalid or closed handle (GSimpleActionGroupHandle)");
		GSimpleActionGroupHandleExterns.g_simple_action_group_remove(simple, action_name);
		return simple;
	}

}

internal class GSimpleActionGroupHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSimpleActionGroupHandle g_simple_action_group_new();

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_action_group_add_entries([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleActionGroupHandle>))] MentorLake.Gio.GSimpleActionGroupHandle simple, MentorLake.Gio.GActionEntry[] entries, int n_entries, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_action_group_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleActionGroupHandle>))] MentorLake.Gio.GSimpleActionGroupHandle simple, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionHandleImpl>))] MentorLake.Gio.GActionHandle action);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GActionHandle g_simple_action_group_lookup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleActionGroupHandle>))] MentorLake.Gio.GSimpleActionGroupHandle simple, string action_name);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_action_group_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleActionGroupHandle>))] MentorLake.Gio.GSimpleActionGroupHandle simple, string action_name);

}
