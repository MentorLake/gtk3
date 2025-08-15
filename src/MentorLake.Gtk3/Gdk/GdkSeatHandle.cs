namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// The #GdkSeat object represents a collection of input devices
/// that belong to a user.
/// </para>
/// </summary>

public class GdkSeatHandle : GObjectHandle
{
}
public static class GdkSeatHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::device-added signal is emitted when a new input
/// device is related to this seat.
/// </para>
/// </summary>

	public static IObservable<GdkSeatHandleSignalStructs.DeviceAddedSignal> Signal_DeviceAdded(this GdkSeatHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkSeatHandleSignalStructs.DeviceAddedSignal> obs) =>
		{
			GdkSeatHandleSignalDelegates.device_added handler = ( MentorLake.Gdk.GdkSeatHandle self,  MentorLake.Gdk.GdkDeviceHandle device,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkSeatHandleSignalStructs.DeviceAddedSignal()
				{
					Self = self, Device = device, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "device-added", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::device-removed signal is emitted when an
/// input device is removed (e.g. unplugged).
/// </para>
/// </summary>

	public static IObservable<GdkSeatHandleSignalStructs.DeviceRemovedSignal> Signal_DeviceRemoved(this GdkSeatHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkSeatHandleSignalStructs.DeviceRemovedSignal> obs) =>
		{
			GdkSeatHandleSignalDelegates.device_removed handler = ( MentorLake.Gdk.GdkSeatHandle self,  MentorLake.Gdk.GdkDeviceHandle device,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkSeatHandleSignalStructs.DeviceRemovedSignal()
				{
					Self = self, Device = device, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "device-removed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::tool-added signal is emitted whenever a new tool
/// is made known to the seat. The tool may later be assigned
/// to a device (i.e. on proximity with a tablet). The device
/// will emit the #GdkDevice::tool-changed signal accordingly.
/// </para>
/// <para>
/// A same tool may be used by several devices.
/// </para>
/// </summary>

	public static IObservable<GdkSeatHandleSignalStructs.ToolAddedSignal> Signal_ToolAdded(this GdkSeatHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkSeatHandleSignalStructs.ToolAddedSignal> obs) =>
		{
			GdkSeatHandleSignalDelegates.tool_added handler = ( MentorLake.Gdk.GdkSeatHandle self,  MentorLake.Gdk.GdkDeviceToolHandle tool,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkSeatHandleSignalStructs.ToolAddedSignal()
				{
					Self = self, Tool = tool, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "tool-added", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted whenever a tool is no longer known
/// to this @seat.
/// </para>
/// </summary>

	public static IObservable<GdkSeatHandleSignalStructs.ToolRemovedSignal> Signal_ToolRemoved(this GdkSeatHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkSeatHandleSignalStructs.ToolRemovedSignal> obs) =>
		{
			GdkSeatHandleSignalDelegates.tool_removed handler = ( MentorLake.Gdk.GdkSeatHandle self,  MentorLake.Gdk.GdkDeviceToolHandle tool,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkSeatHandleSignalStructs.ToolRemovedSignal()
				{
					Self = self, Tool = tool, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "tool-removed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GdkSeatHandleSignalStructs
{

public class DeviceAddedSignal
{

	public MentorLake.Gdk.GdkSeatHandle Self;
/// <summary>
/// <para>
/// the newly added #GdkDevice.
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkDeviceHandle Device;

	public IntPtr UserData;
}

public class DeviceRemovedSignal
{

	public MentorLake.Gdk.GdkSeatHandle Self;
/// <summary>
/// <para>
/// the just removed #GdkDevice.
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkDeviceHandle Device;

	public IntPtr UserData;
}

public class ToolAddedSignal
{

	public MentorLake.Gdk.GdkSeatHandle Self;
/// <summary>
/// <para>
/// the new #GdkDeviceTool known to the seat
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkDeviceToolHandle Tool;

	public IntPtr UserData;
}

public class ToolRemovedSignal
{

	public MentorLake.Gdk.GdkSeatHandle Self;
/// <summary>
/// <para>
/// the just removed #GdkDeviceTool
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkDeviceToolHandle Tool;

	public IntPtr UserData;
}
}

public static class GdkSeatHandleSignalDelegates
{

/// <summary>
/// <para>
/// The ::device-added signal is emitted when a new input
/// device is related to this seat.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="device">
/// the newly added #GdkDevice.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void device_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkSeatHandle>))] MentorLake.Gdk.GdkSeatHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, IntPtr user_data);


/// <summary>
/// <para>
/// The ::device-removed signal is emitted when an
/// input device is removed (e.g. unplugged).
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="device">
/// the just removed #GdkDevice.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void device_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkSeatHandle>))] MentorLake.Gdk.GdkSeatHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, IntPtr user_data);


/// <summary>
/// <para>
/// The ::tool-added signal is emitted whenever a new tool
/// is made known to the seat. The tool may later be assigned
/// to a device (i.e. on proximity with a tablet). The device
/// will emit the #GdkDevice::tool-changed signal accordingly.
/// </para>
/// <para>
/// A same tool may be used by several devices.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="tool">
/// the new #GdkDeviceTool known to the seat
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void tool_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkSeatHandle>))] MentorLake.Gdk.GdkSeatHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceToolHandle>))] MentorLake.Gdk.GdkDeviceToolHandle tool, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted whenever a tool is no longer known
/// to this @seat.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="tool">
/// the just removed #GdkDeviceTool
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void tool_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkSeatHandle>))] MentorLake.Gdk.GdkSeatHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceToolHandle>))] MentorLake.Gdk.GdkDeviceToolHandle tool, IntPtr user_data);

}


public static class GdkSeatHandleExtensions
{
/// <summary>
/// <para>
/// Returns the capabilities this #GdkSeat currently has.
/// </para>
/// </summary>

/// <param name="seat">
/// a #GdkSeat
/// </param>
/// <return>
/// the seat capabilities
/// </return>

	public static MentorLake.Gdk.GdkSeatCapabilities GetCapabilities(this MentorLake.Gdk.GdkSeatHandle seat)
	{
		if (seat.IsInvalid) throw new Exception("Invalid handle (GdkSeatHandle)");
		return GdkSeatHandleExterns.gdk_seat_get_capabilities(seat);
	}

/// <summary>
/// <para>
/// Returns the #GdkDisplay this seat belongs to.
/// </para>
/// </summary>

/// <param name="seat">
/// a #GdkSeat
/// </param>
/// <return>
/// a #GdkDisplay. This object is owned by GTK+
///          and must not be freed.
/// </return>

	public static MentorLake.Gdk.GdkDisplayHandle GetDisplay(this MentorLake.Gdk.GdkSeatHandle seat)
	{
		if (seat.IsInvalid) throw new Exception("Invalid handle (GdkSeatHandle)");
		return GdkSeatHandleExterns.gdk_seat_get_display(seat);
	}

/// <summary>
/// <para>
/// Returns the master device that routes keyboard events.
/// </para>
/// </summary>

/// <param name="seat">
/// a #GdkSeat
/// </param>
/// <return>
/// a master #GdkDevice with keyboard
///          capabilities. This object is owned by GTK+ and must not be freed.
/// </return>

	public static MentorLake.Gdk.GdkDeviceHandle GetKeyboard(this MentorLake.Gdk.GdkSeatHandle seat)
	{
		if (seat.IsInvalid) throw new Exception("Invalid handle (GdkSeatHandle)");
		return GdkSeatHandleExterns.gdk_seat_get_keyboard(seat);
	}

/// <summary>
/// <para>
/// Returns the master device that routes pointer events.
/// </para>
/// </summary>

/// <param name="seat">
/// a #GdkSeat
/// </param>
/// <return>
/// a master #GdkDevice with pointer
///          capabilities. This object is owned by GTK+ and must not be freed.
/// </return>

	public static MentorLake.Gdk.GdkDeviceHandle GetPointer(this MentorLake.Gdk.GdkSeatHandle seat)
	{
		if (seat.IsInvalid) throw new Exception("Invalid handle (GdkSeatHandle)");
		return GdkSeatHandleExterns.gdk_seat_get_pointer(seat);
	}

/// <summary>
/// <para>
/// Returns the slave devices that match the given capabilities.
/// </para>
/// </summary>

/// <param name="seat">
/// a #GdkSeat
/// </param>
/// <param name="capabilities">
/// capabilities to get devices for
/// </param>
/// <return>
/// A list of #GdkDevices.
///          The list must be freed with g_list_free(), the elements are owned
///          by GDK and must not be freed.
/// </return>

	public static MentorLake.GLib.GListHandle GetSlaves(this MentorLake.Gdk.GdkSeatHandle seat, MentorLake.Gdk.GdkSeatCapabilities capabilities)
	{
		if (seat.IsInvalid) throw new Exception("Invalid handle (GdkSeatHandle)");
		return GdkSeatHandleExterns.gdk_seat_get_slaves(seat, capabilities);
	}

/// <summary>
/// <para>
/// Grabs the seat so that all events corresponding to the given @capabilities
/// are passed to this application until the seat is ungrabbed with gdk_seat_ungrab(),
/// or the window becomes hidden. This overrides any previous grab on the
/// seat by this client.
/// </para>
/// <para>
/// As a rule of thumb, if a grab is desired over %GDK_SEAT_CAPABILITY_POINTER,
/// all other &quot;pointing&quot; capabilities (eg. %GDK_SEAT_CAPABILITY_TOUCH) should
/// be grabbed too, so the user is able to interact with all of those while
/// the grab holds, you should thus use %GDK_SEAT_CAPABILITY_ALL_POINTING most
/// commonly.
/// </para>
/// <para>
/// Grabs are used for operations which need complete control over the
/// events corresponding to the given capabilities. For example in GTK+ this
/// is used for Drag and Drop operations, popup menus and such.
/// </para>
/// <para>
/// Note that if the event mask of a #GdkWindow has selected both button press
/// and button release events, or touch begin and touch end, then a press event
/// will cause an automatic grab until the button is released, equivalent to a
/// grab on the window with @owner_events set to %TRUE. This is done because most
/// applications expect to receive paired press and release events.
/// </para>
/// <para>
/// If you set up anything at the time you take the grab that needs to be
/// cleaned up when the grab ends, you should handle the #GdkEventGrabBroken
/// events that are emitted when the grab ends unvoluntarily.
/// </para>
/// </summary>

/// <param name="seat">
/// a #GdkSeat
/// </param>
/// <param name="window">
/// the #GdkWindow which will own the grab
/// </param>
/// <param name="capabilities">
/// capabilities that will be grabbed
/// </param>
/// <param name="owner_events">
/// if %FALSE then all device events are reported with respect to
///                @window and are only reported if selected by @event_mask. If
///                %TRUE then pointer events for this application are reported
///                as normal, but pointer events outside this application are
///                reported with respect to @window and only if selected by
///                @event_mask. In either mode, unreported events are discarded.
/// </param>
/// <param name="cursor">
/// the cursor to display while the grab is active. If
///          this is %NULL then the normal cursors are used for
///          @window and its descendants, and the cursor for @window is used
///          elsewhere.
/// </param>
/// <param name="@event">
/// the event that is triggering the grab, or %NULL if none
///         is available.
/// </param>
/// <param name="prepare_func">
/// function to
///                prepare the window to be grabbed, it can be %NULL if @window is
///                visible before this call.
/// </param>
/// <param name="prepare_func_data">
/// user data to pass to @prepare_func
/// </param>
/// <return>
/// %GDK_GRAB_SUCCESS if the grab was successful.
/// </return>

	public static MentorLake.Gdk.GdkGrabStatus Grab(this MentorLake.Gdk.GdkSeatHandle seat, MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkSeatCapabilities capabilities, bool owner_events, MentorLake.Gdk.GdkCursorHandle cursor, MentorLake.Gdk.GdkEventHandle @event, MentorLake.Gdk.GdkSeatGrabPrepareFunc prepare_func, IntPtr prepare_func_data)
	{
		if (seat.IsInvalid) throw new Exception("Invalid handle (GdkSeatHandle)");
		return GdkSeatHandleExterns.gdk_seat_grab(seat, window, capabilities, owner_events, cursor, @event, prepare_func, prepare_func_data);
	}

/// <summary>
/// <para>
/// Releases a grab added through gdk_seat_grab().
/// </para>
/// </summary>

/// <param name="seat">
/// a #GdkSeat
/// </param>

	public static T Ungrab<T>(this T seat) where T : GdkSeatHandle
	{
		if (seat.IsInvalid) throw new Exception("Invalid handle (GdkSeatHandle)");
		GdkSeatHandleExterns.gdk_seat_ungrab(seat);
		return seat;
	}

}

internal class GdkSeatHandleExterns
{
	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkSeatCapabilities gdk_seat_get_capabilities([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkSeatHandle>))] MentorLake.Gdk.GdkSeatHandle seat);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))]
	internal static extern MentorLake.Gdk.GdkDisplayHandle gdk_seat_get_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkSeatHandle>))] MentorLake.Gdk.GdkSeatHandle seat);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))]
	internal static extern MentorLake.Gdk.GdkDeviceHandle gdk_seat_get_keyboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkSeatHandle>))] MentorLake.Gdk.GdkSeatHandle seat);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))]
	internal static extern MentorLake.Gdk.GdkDeviceHandle gdk_seat_get_pointer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkSeatHandle>))] MentorLake.Gdk.GdkSeatHandle seat);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gdk_seat_get_slaves([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkSeatHandle>))] MentorLake.Gdk.GdkSeatHandle seat, MentorLake.Gdk.GdkSeatCapabilities capabilities);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkGrabStatus gdk_seat_grab([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkSeatHandle>))] MentorLake.Gdk.GdkSeatHandle seat, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkSeatCapabilities capabilities, bool owner_events, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkCursorHandle>))] MentorLake.Gdk.GdkCursorHandle cursor, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, MentorLake.Gdk.GdkSeatGrabPrepareFunc prepare_func, IntPtr prepare_func_data);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_seat_ungrab([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkSeatHandle>))] MentorLake.Gdk.GdkSeatHandle seat);

}
