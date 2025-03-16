namespace MentorLake.Gdk;

public class GdkDragContextHandle : GObjectHandle
{
}
public static class GdkDragContextHandleSignalExtensions
{

	public static IObservable<GdkDragContextHandleSignalStructs.ActionChangedSignal> Signal_ActionChanged(this GdkDragContextHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkDragContextHandleSignalStructs.ActionChangedSignal> obs) =>
		{
			GdkDragContextHandleSignalDelegates.action_changed handler = ( MentorLake.Gdk.GdkDragContextHandle self,  MentorLake.Gdk.GdkDragAction action,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkDragContextHandleSignalStructs.ActionChangedSignal()
				{
					Self = self, Action = action, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "action-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GdkDragContextHandleSignalStructs.CancelSignal> Signal_Cancel(this GdkDragContextHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkDragContextHandleSignalStructs.CancelSignal> obs) =>
		{
			GdkDragContextHandleSignalDelegates.cancel handler = ( MentorLake.Gdk.GdkDragContextHandle self,  MentorLake.Gdk.GdkDragCancelReason reason,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkDragContextHandleSignalStructs.CancelSignal()
				{
					Self = self, Reason = reason, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "cancel", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GdkDragContextHandleSignalStructs.DndFinishedSignal> Signal_DndFinished(this GdkDragContextHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkDragContextHandleSignalStructs.DndFinishedSignal> obs) =>
		{
			GdkDragContextHandleSignalDelegates.dnd_finished handler = ( MentorLake.Gdk.GdkDragContextHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkDragContextHandleSignalStructs.DndFinishedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "dnd-finished", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GdkDragContextHandleSignalStructs.DropPerformedSignal> Signal_DropPerformed(this GdkDragContextHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkDragContextHandleSignalStructs.DropPerformedSignal> obs) =>
		{
			GdkDragContextHandleSignalDelegates.drop_performed handler = ( MentorLake.Gdk.GdkDragContextHandle self,  int time,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkDragContextHandleSignalStructs.DropPerformedSignal()
				{
					Self = self, Time = time, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "drop-performed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GdkDragContextHandleSignalStructs
{

public struct ActionChangedSignal
{
	public MentorLake.Gdk.GdkDragContextHandle Self;
	public MentorLake.Gdk.GdkDragAction Action;
	public IntPtr UserData;
}

public struct CancelSignal
{
	public MentorLake.Gdk.GdkDragContextHandle Self;
	public MentorLake.Gdk.GdkDragCancelReason Reason;
	public IntPtr UserData;
}

public struct DndFinishedSignal
{
	public MentorLake.Gdk.GdkDragContextHandle Self;
	public IntPtr UserData;
}

public struct DropPerformedSignal
{
	public MentorLake.Gdk.GdkDragContextHandle Self;
	public int Time;
	public IntPtr UserData;
}
}

public static class GdkDragContextHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void action_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle self, MentorLake.Gdk.GdkDragAction action, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void cancel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle self, MentorLake.Gdk.GdkDragCancelReason reason, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void dnd_finished([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void drop_performed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle self, int time, IntPtr user_data);

}


public static class GdkDragContextHandleExtensions
{
	public static MentorLake.Gdk.GdkDragAction GetActions(this MentorLake.Gdk.GdkDragContextHandle context)
	{
		return GdkDragContextHandleExterns.gdk_drag_context_get_actions(context);
	}

	public static MentorLake.Gdk.GdkWindowHandle GetDestWindow(this MentorLake.Gdk.GdkDragContextHandle context)
	{
		return GdkDragContextHandleExterns.gdk_drag_context_get_dest_window(context);
	}

	public static MentorLake.Gdk.GdkDeviceHandle GetDevice(this MentorLake.Gdk.GdkDragContextHandle context)
	{
		return GdkDragContextHandleExterns.gdk_drag_context_get_device(context);
	}

	public static MentorLake.Gdk.GdkWindowHandle GetDragWindow(this MentorLake.Gdk.GdkDragContextHandle context)
	{
		return GdkDragContextHandleExterns.gdk_drag_context_get_drag_window(context);
	}

	public static MentorLake.Gdk.GdkDragProtocol GetProtocol(this MentorLake.Gdk.GdkDragContextHandle context)
	{
		return GdkDragContextHandleExterns.gdk_drag_context_get_protocol(context);
	}

	public static MentorLake.Gdk.GdkDragAction GetSelectedAction(this MentorLake.Gdk.GdkDragContextHandle context)
	{
		return GdkDragContextHandleExterns.gdk_drag_context_get_selected_action(context);
	}

	public static MentorLake.Gdk.GdkWindowHandle GetSourceWindow(this MentorLake.Gdk.GdkDragContextHandle context)
	{
		return GdkDragContextHandleExterns.gdk_drag_context_get_source_window(context);
	}

	public static MentorLake.Gdk.GdkDragAction GetSuggestedAction(this MentorLake.Gdk.GdkDragContextHandle context)
	{
		return GdkDragContextHandleExterns.gdk_drag_context_get_suggested_action(context);
	}

	public static MentorLake.GLib.GListHandle ListTargets(this MentorLake.Gdk.GdkDragContextHandle context)
	{
		return GdkDragContextHandleExterns.gdk_drag_context_list_targets(context);
	}

	public static bool ManageDnd(this MentorLake.Gdk.GdkDragContextHandle context, MentorLake.Gdk.GdkWindowHandle ipc_window, MentorLake.Gdk.GdkDragAction actions)
	{
		return GdkDragContextHandleExterns.gdk_drag_context_manage_dnd(context, ipc_window, actions);
	}

	public static T SetDevice<T>(this T context, MentorLake.Gdk.GdkDeviceHandle device) where T : GdkDragContextHandle
	{
		GdkDragContextHandleExterns.gdk_drag_context_set_device(context, device);
		return context;
	}

	public static T SetHotspot<T>(this T context, int hot_x, int hot_y) where T : GdkDragContextHandle
	{
		GdkDragContextHandleExterns.gdk_drag_context_set_hotspot(context, hot_x, hot_y);
		return context;
	}

}

internal class GdkDragContextHandleExterns
{
	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkDragAction gdk_drag_context_get_actions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkWindowHandle gdk_drag_context_get_dest_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkDeviceHandle gdk_drag_context_get_device([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkWindowHandle gdk_drag_context_get_drag_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkDragProtocol gdk_drag_context_get_protocol([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkDragAction gdk_drag_context_get_selected_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkWindowHandle gdk_drag_context_get_source_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkDragAction gdk_drag_context_get_suggested_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle gdk_drag_context_list_targets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_drag_context_manage_dnd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle ipc_window, MentorLake.Gdk.GdkDragAction actions);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_drag_context_set_device([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_drag_context_set_hotspot([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, int hot_x, int hot_y);

}
