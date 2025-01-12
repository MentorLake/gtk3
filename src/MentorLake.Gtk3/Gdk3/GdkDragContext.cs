namespace MentorLake.Gtk3.Gdk3;

public class GdkDragContextHandle : GObjectHandle
{
}

public static class GdkDragContextSignalExtensions
{

	public static IObservable<GdkDragContextSignalStructs.ActionChangedSignal> Signal_ActionChanged(this GdkDragContextHandle instance)
	{
		return Observable.Create((IObserver<GdkDragContextSignalStructs.ActionChangedSignal> obs) =>
		{
			GdkDragContextSignalDelegates.action_changed handler = (GdkDragContextHandle self, GdkDragAction action, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkDragContextSignalStructs.ActionChangedSignal()
				{
					Self = self, Action = action, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "action_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GdkDragContextSignalStructs.CancelSignal> Signal_Cancel(this GdkDragContextHandle instance)
	{
		return Observable.Create((IObserver<GdkDragContextSignalStructs.CancelSignal> obs) =>
		{
			GdkDragContextSignalDelegates.cancel handler = (GdkDragContextHandle self, ref GdkDragCancelReason reason, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkDragContextSignalStructs.CancelSignal()
				{
					Self = self, Reason = reason, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "cancel", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GdkDragContextSignalStructs.DndFinishedSignal> Signal_DndFinished(this GdkDragContextHandle instance)
	{
		return Observable.Create((IObserver<GdkDragContextSignalStructs.DndFinishedSignal> obs) =>
		{
			GdkDragContextSignalDelegates.dnd_finished handler = (GdkDragContextHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkDragContextSignalStructs.DndFinishedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "dnd_finished", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GdkDragContextSignalStructs.DropPerformedSignal> Signal_DropPerformed(this GdkDragContextHandle instance)
	{
		return Observable.Create((IObserver<GdkDragContextSignalStructs.DropPerformedSignal> obs) =>
		{
			GdkDragContextSignalDelegates.drop_performed handler = (GdkDragContextHandle self, int time, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkDragContextSignalStructs.DropPerformedSignal()
				{
					Self = self, Time = time, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "drop_performed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GdkDragContextSignalStructs
{

public struct ActionChangedSignal
{
	public GdkDragContextHandle Self;
	public GdkDragAction Action;
	public IntPtr UserData;
}

public struct CancelSignal
{
	public GdkDragContextHandle Self;
	public GdkDragCancelReason Reason;
	public IntPtr UserData;
}

public struct DndFinishedSignal
{
	public GdkDragContextHandle Self;
	public IntPtr UserData;
}

public struct DropPerformedSignal
{
	public GdkDragContextHandle Self;
	public int Time;
	public IntPtr UserData;
}
}

public static class GdkDragContextSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void action_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDragContextHandle>))] GdkDragContextHandle self, GdkDragAction action, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void cancel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDragContextHandle>))] GdkDragContextHandle self, ref GdkDragCancelReason reason, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void dnd_finished([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDragContextHandle>))] GdkDragContextHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void drop_performed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDragContextHandle>))] GdkDragContextHandle self, int time, IntPtr user_data);

}


public static class GdkDragContextHandleExtensions
{
	public static GdkDragAction GetActions(this GdkDragContextHandle context)
	{
		return GdkDragContextExterns.gdk_drag_context_get_actions(context);
	}

	public static GdkWindowHandle GetDestWindow(this GdkDragContextHandle context)
	{
		return GdkDragContextExterns.gdk_drag_context_get_dest_window(context);
	}

	public static GdkDeviceHandle GetDevice(this GdkDragContextHandle context)
	{
		return GdkDragContextExterns.gdk_drag_context_get_device(context);
	}

	public static GdkWindowHandle GetDragWindow(this GdkDragContextHandle context)
	{
		return GdkDragContextExterns.gdk_drag_context_get_drag_window(context);
	}

	public static GdkDragProtocol GetProtocol(this GdkDragContextHandle context)
	{
		return GdkDragContextExterns.gdk_drag_context_get_protocol(context);
	}

	public static GdkDragAction GetSelectedAction(this GdkDragContextHandle context)
	{
		return GdkDragContextExterns.gdk_drag_context_get_selected_action(context);
	}

	public static GdkWindowHandle GetSourceWindow(this GdkDragContextHandle context)
	{
		return GdkDragContextExterns.gdk_drag_context_get_source_window(context);
	}

	public static GdkDragAction GetSuggestedAction(this GdkDragContextHandle context)
	{
		return GdkDragContextExterns.gdk_drag_context_get_suggested_action(context);
	}

	public static GListHandle ListTargets(this GdkDragContextHandle context)
	{
		return GdkDragContextExterns.gdk_drag_context_list_targets(context);
	}

	public static bool ManageDnd(this GdkDragContextHandle context, GdkWindowHandle ipc_window, GdkDragAction actions)
	{
		return GdkDragContextExterns.gdk_drag_context_manage_dnd(context, ipc_window, actions);
	}

	public static GdkDragContextHandle SetDevice(this GdkDragContextHandle context, GdkDeviceHandle device)
	{
		GdkDragContextExterns.gdk_drag_context_set_device(context, device);
		return context;
	}

	public static GdkDragContextHandle SetHotspot(this GdkDragContextHandle context, int hot_x, int hot_y)
	{
		GdkDragContextExterns.gdk_drag_context_set_hotspot(context, hot_x, hot_y);
		return context;
	}

	public static bool GdkDragDropSucceeded(this GdkDragContextHandle context)
	{
		return GdkDragContextExterns.gdk_drag_drop_succeeded(context);
	}

	public static GdkDragContextHandle GdkDragStatus(this GdkDragContextHandle context, GdkDragAction action, uint time_)
	{
		GdkDragContextExterns.gdk_drag_status(context, action, time_);
		return context;
	}

	public static GdkDragContextHandle GdkDragDropDone(this GdkDragContextHandle context, bool success)
	{
		GdkDragContextExterns.gdk_drag_drop_done(context, success);
		return context;
	}

	public static bool GdkDragMotion(this GdkDragContextHandle context, GdkWindowHandle dest_window, GdkDragProtocol protocol, int x_root, int y_root, GdkDragAction suggested_action, GdkDragAction possible_actions, uint time_)
	{
		return GdkDragContextExterns.gdk_drag_motion(context, dest_window, protocol, x_root, y_root, suggested_action, possible_actions, time_);
	}

	public static GdkDragContextHandle GdkDragFindWindowForScreen(this GdkDragContextHandle context, GdkWindowHandle drag_window, GdkScreenHandle screen, int x_root, int y_root, out GdkWindowHandle dest_window, out GdkDragProtocol protocol)
	{
		GdkDragContextExterns.gdk_drag_find_window_for_screen(context, drag_window, screen, x_root, y_root, out dest_window, out protocol);
		return context;
	}

	public static GdkDragContextHandle GdkDropFinish(this GdkDragContextHandle context, bool success, uint time_)
	{
		GdkDragContextExterns.gdk_drop_finish(context, success, time_);
		return context;
	}

	public static GdkDragContextHandle GdkDragDrop(this GdkDragContextHandle context, uint time_)
	{
		GdkDragContextExterns.gdk_drag_drop(context, time_);
		return context;
	}

	public static GdkAtom GdkDragGetSelection(this GdkDragContextHandle context)
	{
		return GdkDragContextExterns.gdk_drag_get_selection(context);
	}

	public static GdkDragContextHandle GdkDropReply(this GdkDragContextHandle context, bool accepted, uint time_)
	{
		GdkDragContextExterns.gdk_drop_reply(context, accepted, time_);
		return context;
	}

	public static GdkDragContextHandle GdkDragAbort(this GdkDragContextHandle context, uint time_)
	{
		GdkDragContextExterns.gdk_drag_abort(context, time_);
		return context;
	}

}

internal class GdkDragContextExterns
{
	[DllImport(Libraries.Gdk3)]
	internal static extern GdkDragAction gdk_drag_context_get_actions(GdkDragContextHandle context);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkWindowHandle gdk_drag_context_get_dest_window(GdkDragContextHandle context);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkDeviceHandle gdk_drag_context_get_device(GdkDragContextHandle context);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkWindowHandle gdk_drag_context_get_drag_window(GdkDragContextHandle context);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkDragProtocol gdk_drag_context_get_protocol(GdkDragContextHandle context);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkDragAction gdk_drag_context_get_selected_action(GdkDragContextHandle context);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkWindowHandle gdk_drag_context_get_source_window(GdkDragContextHandle context);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkDragAction gdk_drag_context_get_suggested_action(GdkDragContextHandle context);

	[DllImport(Libraries.Gdk3)]
	internal static extern GListHandle gdk_drag_context_list_targets(GdkDragContextHandle context);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_drag_context_manage_dnd(GdkDragContextHandle context, GdkWindowHandle ipc_window, GdkDragAction actions);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_drag_context_set_device(GdkDragContextHandle context, GdkDeviceHandle device);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_drag_context_set_hotspot(GdkDragContextHandle context, int hot_x, int hot_y);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_drag_drop_succeeded(GdkDragContextHandle context);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_drag_status(GdkDragContextHandle context, GdkDragAction action, uint time_);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_drag_drop_done(GdkDragContextHandle context, bool success);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_drag_motion(GdkDragContextHandle context, GdkWindowHandle dest_window, GdkDragProtocol protocol, int x_root, int y_root, GdkDragAction suggested_action, GdkDragAction possible_actions, uint time_);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_drag_find_window_for_screen(GdkDragContextHandle context, GdkWindowHandle drag_window, GdkScreenHandle screen, int x_root, int y_root, out GdkWindowHandle dest_window, out GdkDragProtocol protocol);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_drop_finish(GdkDragContextHandle context, bool success, uint time_);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_drag_drop(GdkDragContextHandle context, uint time_);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkAtom gdk_drag_get_selection(GdkDragContextHandle context);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_drop_reply(GdkDragContextHandle context, bool accepted, uint time_);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_drag_abort(GdkDragContextHandle context, uint time_);

}
