namespace MentorLake.Gdk;


public class GdkDragContextHandle : GObjectHandle
{
}
public static class GdkDragContextHandleSignalExtensions
{
/// <summary>
/// <para>
/// A new action is being chosen for the drag and drop operation.
/// </para>
/// <para>
/// This signal will only be emitted if the #GdkDragContext manages
/// the drag and drop operation. See gdk_drag_context_manage_dnd()
/// for more information.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The drag and drop operation was cancelled.
/// </para>
/// <para>
/// This signal will only be emitted if the #GdkDragContext manages
/// the drag and drop operation. See gdk_drag_context_manage_dnd()
/// for more information.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The drag and drop operation was finished, the drag destination
/// finished reading all data. The drag source can now free all
/// miscellaneous data.
/// </para>
/// <para>
/// This signal will only be emitted if the #GdkDragContext manages
/// the drag and drop operation. See gdk_drag_context_manage_dnd()
/// for more information.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The drag and drop operation was performed on an accepting client.
/// </para>
/// <para>
/// This signal will only be emitted if the #GdkDragContext manages
/// the drag and drop operation. See gdk_drag_context_manage_dnd()
/// for more information.
/// </para>
/// </summary>

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

public class ActionChangedSignal
{

	public MentorLake.Gdk.GdkDragContextHandle Self;
/// <summary>
/// <para>
/// The action currently chosen
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkDragAction Action;

	public IntPtr UserData;
}

public class CancelSignal
{

	public MentorLake.Gdk.GdkDragContextHandle Self;
/// <summary>
/// <para>
/// The reason the context was cancelled
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkDragCancelReason Reason;

	public IntPtr UserData;
}

public class DndFinishedSignal
{

	public MentorLake.Gdk.GdkDragContextHandle Self;

	public IntPtr UserData;
}

public class DropPerformedSignal
{

	public MentorLake.Gdk.GdkDragContextHandle Self;
/// <summary>
/// <para>
/// the time at which the drop happened.
/// </para>
/// </summary>

	public int Time;

	public IntPtr UserData;
}
}

public static class GdkDragContextHandleSignalDelegates
{

/// <summary>
/// <para>
/// A new action is being chosen for the drag and drop operation.
/// </para>
/// <para>
/// This signal will only be emitted if the #GdkDragContext manages
/// the drag and drop operation. See gdk_drag_context_manage_dnd()
/// for more information.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="action">
/// The action currently chosen
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void action_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle self, MentorLake.Gdk.GdkDragAction action, IntPtr user_data);


/// <summary>
/// <para>
/// The drag and drop operation was cancelled.
/// </para>
/// <para>
/// This signal will only be emitted if the #GdkDragContext manages
/// the drag and drop operation. See gdk_drag_context_manage_dnd()
/// for more information.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="reason">
/// The reason the context was cancelled
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void cancel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle self, MentorLake.Gdk.GdkDragCancelReason reason, IntPtr user_data);


/// <summary>
/// <para>
/// The drag and drop operation was finished, the drag destination
/// finished reading all data. The drag source can now free all
/// miscellaneous data.
/// </para>
/// <para>
/// This signal will only be emitted if the #GdkDragContext manages
/// the drag and drop operation. See gdk_drag_context_manage_dnd()
/// for more information.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void dnd_finished([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The drag and drop operation was performed on an accepting client.
/// </para>
/// <para>
/// This signal will only be emitted if the #GdkDragContext manages
/// the drag and drop operation. See gdk_drag_context_manage_dnd()
/// for more information.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="time">
/// the time at which the drop happened.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void drop_performed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle self, int time, IntPtr user_data);

}


public static class GdkDragContextHandleExtensions
{
/// <summary>
/// <para>
/// Determines the bitmask of actions proposed by the source if
/// gdk_drag_context_get_suggested_action() returns %GDK_ACTION_ASK.
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkDragContext
/// </param>
/// <return>
/// the #GdkDragAction flags
/// </return>

	public static MentorLake.Gdk.GdkDragAction GetActions(this MentorLake.Gdk.GdkDragContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkDragContextHandle)");
		return GdkDragContextHandleExterns.gdk_drag_context_get_actions(context);
	}

/// <summary>
/// <para>
/// Returns the destination window for the DND operation.
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkDragContext
/// </param>
/// <return>
/// a #GdkWindow
/// </return>

	public static MentorLake.Gdk.GdkWindowHandle GetDestWindow(this MentorLake.Gdk.GdkDragContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkDragContextHandle)");
		return GdkDragContextHandleExterns.gdk_drag_context_get_dest_window(context);
	}

/// <summary>
/// <para>
/// Returns the #GdkDevice associated to the drag context.
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkDragContext
/// </param>
/// <return>
/// The #GdkDevice associated to @context.
/// </return>

	public static MentorLake.Gdk.GdkDeviceHandle GetDevice(this MentorLake.Gdk.GdkDragContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkDragContextHandle)");
		return GdkDragContextHandleExterns.gdk_drag_context_get_device(context);
	}

/// <summary>
/// <para>
/// Returns the window on which the drag icon should be rendered
/// during the drag operation. Note that the window may not be
/// available until the drag operation has begun. GDK will move
/// the window in accordance with the ongoing drag operation.
/// The window is owned by @context and will be destroyed when
/// the drag operation is over.
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkDragContext
/// </param>
/// <return>
/// the drag window, or %NULL
/// </return>

	public static MentorLake.Gdk.GdkWindowHandle GetDragWindow(this MentorLake.Gdk.GdkDragContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkDragContextHandle)");
		return GdkDragContextHandleExterns.gdk_drag_context_get_drag_window(context);
	}

/// <summary>
/// <para>
/// Returns the drag protocol that is used by this context.
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkDragContext
/// </param>
/// <return>
/// the drag protocol
/// </return>

	public static MentorLake.Gdk.GdkDragProtocol GetProtocol(this MentorLake.Gdk.GdkDragContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkDragContextHandle)");
		return GdkDragContextHandleExterns.gdk_drag_context_get_protocol(context);
	}

/// <summary>
/// <para>
/// Determines the action chosen by the drag destination.
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkDragContext
/// </param>
/// <return>
/// a #GdkDragAction value
/// </return>

	public static MentorLake.Gdk.GdkDragAction GetSelectedAction(this MentorLake.Gdk.GdkDragContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkDragContextHandle)");
		return GdkDragContextHandleExterns.gdk_drag_context_get_selected_action(context);
	}

/// <summary>
/// <para>
/// Returns the #GdkWindow where the DND operation started.
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkDragContext
/// </param>
/// <return>
/// a #GdkWindow
/// </return>

	public static MentorLake.Gdk.GdkWindowHandle GetSourceWindow(this MentorLake.Gdk.GdkDragContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkDragContextHandle)");
		return GdkDragContextHandleExterns.gdk_drag_context_get_source_window(context);
	}

/// <summary>
/// <para>
/// Determines the suggested drag action of the context.
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkDragContext
/// </param>
/// <return>
/// a #GdkDragAction value
/// </return>

	public static MentorLake.Gdk.GdkDragAction GetSuggestedAction(this MentorLake.Gdk.GdkDragContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkDragContextHandle)");
		return GdkDragContextHandleExterns.gdk_drag_context_get_suggested_action(context);
	}

/// <summary>
/// <para>
/// Retrieves the list of targets of the context.
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkDragContext
/// </param>
/// <return>
/// a #GList of targets
/// </return>

	public static MentorLake.GLib.GListHandle ListTargets(this MentorLake.Gdk.GdkDragContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkDragContextHandle)");
		return GdkDragContextHandleExterns.gdk_drag_context_list_targets(context);
	}

/// <summary>
/// <para>
/// Requests the drag and drop operation to be managed by @context.
/// When a drag and drop operation becomes managed, the #GdkDragContext
/// will internally handle all input and source-side #GdkEventDND events
/// as required by the windowing system.
/// </para>
/// <para>
/// Once the drag and drop operation is managed, the drag context will
/// emit the following signals:
/// - The #GdkDragContext::action-changed signal whenever the final action
///   to be performed by the drag and drop operation changes.
/// - The #GdkDragContext::drop-performed signal after the user performs
///   the drag and drop gesture (typically by releasing the mouse button).
/// - The #GdkDragContext::dnd-finished signal after the drag and drop
///   operation concludes (after all #GdkSelection transfers happen).
/// - The #GdkDragContext::cancel signal if the drag and drop operation is
///   finished but doesn&apos;t happen over an accepting destination, or is
///   cancelled through other means.
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkDragContext
/// </param>
/// <param name="ipc_window">
/// Window to use for IPC messaging/events
/// </param>
/// <param name="actions">
/// the actions supported by the drag source
/// </param>
/// <return>
/// #TRUE if the drag and drop operation is managed.
/// </return>

	public static bool ManageDnd(this MentorLake.Gdk.GdkDragContextHandle context, MentorLake.Gdk.GdkWindowHandle ipc_window, MentorLake.Gdk.GdkDragAction actions)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkDragContextHandle)");
		return GdkDragContextHandleExterns.gdk_drag_context_manage_dnd(context, ipc_window, actions);
	}

/// <summary>
/// <para>
/// Associates a #GdkDevice to @context, so all Drag and Drop events
/// for @context are emitted as if they came from this device.
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkDragContext
/// </param>
/// <param name="device">
/// a #GdkDevice
/// </param>

	public static T SetDevice<T>(this T context, MentorLake.Gdk.GdkDeviceHandle device) where T : GdkDragContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkDragContextHandle)");
		GdkDragContextHandleExterns.gdk_drag_context_set_device(context, device);
		return context;
	}

/// <summary>
/// <para>
/// Sets the position of the drag window that will be kept
/// under the cursor hotspot. Initially, the hotspot is at the
/// top left corner of the drag window.
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkDragContext
/// </param>
/// <param name="hot_x">
/// x coordinate of the drag window hotspot
/// </param>
/// <param name="hot_y">
/// y coordinate of the drag window hotspot
/// </param>

	public static T SetHotspot<T>(this T context, int hot_x, int hot_y) where T : GdkDragContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkDragContextHandle)");
		GdkDragContextHandleExterns.gdk_drag_context_set_hotspot(context, hot_x, hot_y);
		return context;
	}

}

internal class GdkDragContextHandleExterns
{
	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkDragAction gdk_drag_context_get_actions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gdk_drag_context_get_dest_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))]
	internal static extern MentorLake.Gdk.GdkDeviceHandle gdk_drag_context_get_device([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gdk_drag_context_get_drag_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkDragProtocol gdk_drag_context_get_protocol([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkDragAction gdk_drag_context_get_selected_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gdk_drag_context_get_source_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkDragAction gdk_drag_context_get_suggested_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gdk_drag_context_list_targets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_drag_context_manage_dnd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle ipc_window, MentorLake.Gdk.GdkDragAction actions);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_drag_context_set_device([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_drag_context_set_hotspot([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, int hot_x, int hot_y);

}
