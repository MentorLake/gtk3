namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// The #GdkDevice object represents a single input device, such
/// as a keyboard, a mouse, a touchpad, etc.
/// </para>
/// <para>
/// See the #GdkDeviceManager documentation for more information
/// about the various kinds of master and slave devices, and their
/// relationships.
/// </para>
/// </summary>

public class GdkDeviceHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Frees an array of #GdkTimeCoord that was returned by gdk_device_get_history().
/// </para>
/// </summary>

/// <param name="events">
/// an array of #GdkTimeCoord.
/// </param>
/// <param name="n_events">
/// the length of the array.
/// </param>

	public static void FreeHistory(MentorLake.Gdk.GdkTimeCoordHandle[] events, int n_events)
	{
		GdkDeviceHandleExterns.gdk_device_free_history(events, n_events);
	}

/// <summary>
/// <para>
/// Determines information about the current keyboard grab.
/// This is not public API and must not be used by applications.
/// </para>
/// </summary>

/// <param name="display">
/// the display for which to get the grab information
/// </param>
/// <param name="device">
/// device to get the grab information from
/// </param>
/// <param name="grab_window">
/// location to store current grab window
/// </param>
/// <param name="owner_events">
/// location to store boolean indicating whether
///   the @owner_events flag to gdk_keyboard_grab() or
///   gdk_pointer_grab() was %TRUE.
/// </param>
/// <return>
/// %TRUE if this application currently has the
///  keyboard grabbed.
/// </return>

	public static bool GrabInfoLibgtkOnly(MentorLake.Gdk.GdkDisplayHandle display, MentorLake.Gdk.GdkDeviceHandle device, out MentorLake.Gdk.GdkWindowHandle grab_window, out bool owner_events)
	{
		return GdkDeviceHandleExterns.gdk_device_grab_info_libgtk_only(display, device, out grab_window, out owner_events);
	}

}
public static class GdkDeviceHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::changed signal is emitted either when the #GdkDevice
/// has changed the number of either axes or keys. For example
/// In X this will normally happen when the slave device routing
/// events through the master device changes (for example, user
/// switches from the USB mouse to a tablet), in that case the
/// master device will change to reflect the new slave device
/// axes and keys.
/// </para>
/// </summary>

	public static IObservable<GdkDeviceHandleSignalStructs.ChangedSignal> Signal_Changed(this GdkDeviceHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkDeviceHandleSignalStructs.ChangedSignal> obs) =>
		{
			GdkDeviceHandleSignalDelegates.changed handler = ( MentorLake.Gdk.GdkDeviceHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkDeviceHandleSignalStructs.ChangedSignal()
				{
					Self = self, UserData = user_data
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
/// <summary>
/// <para>
/// The ::tool-changed signal is emitted on pen/eraser
/// #GdkDevices whenever tools enter or leave proximity.
/// </para>
/// </summary>

	public static IObservable<GdkDeviceHandleSignalStructs.ToolChangedSignal> Signal_ToolChanged(this GdkDeviceHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkDeviceHandleSignalStructs.ToolChangedSignal> obs) =>
		{
			GdkDeviceHandleSignalDelegates.tool_changed handler = ( MentorLake.Gdk.GdkDeviceHandle self,  MentorLake.Gdk.GdkDeviceToolHandle tool,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkDeviceHandleSignalStructs.ToolChangedSignal()
				{
					Self = self, Tool = tool, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "tool-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GdkDeviceHandleSignalStructs
{

public class ChangedSignal
{

	public MentorLake.Gdk.GdkDeviceHandle Self;

	public IntPtr UserData;
}

public class ToolChangedSignal
{

	public MentorLake.Gdk.GdkDeviceHandle Self;
/// <summary>
/// <para>
/// The new current tool
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkDeviceToolHandle Tool;

	public IntPtr UserData;
}
}

public static class GdkDeviceHandleSignalDelegates
{

/// <summary>
/// <para>
/// The ::changed signal is emitted either when the #GdkDevice
/// has changed the number of either axes or keys. For example
/// In X this will normally happen when the slave device routing
/// events through the master device changes (for example, user
/// switches from the USB mouse to a tablet), in that case the
/// master device will change to reflect the new slave device
/// axes and keys.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::tool-changed signal is emitted on pen/eraser
/// #GdkDevices whenever tools enter or leave proximity.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="tool">
/// The new current tool
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void tool_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceToolHandle>))] MentorLake.Gdk.GdkDeviceToolHandle tool, IntPtr user_data);

}


public static class GdkDeviceHandleExtensions
{
/// <summary>
/// <para>
/// Returns the associated device to @device, if @device is of type
/// %GDK_DEVICE_TYPE_MASTER, it will return the paired pointer or
/// keyboard.
/// </para>
/// <para>
/// If @device is of type %GDK_DEVICE_TYPE_SLAVE, it will return
/// the master device to which @device is attached to.
/// </para>
/// <para>
/// If @device is of type %GDK_DEVICE_TYPE_FLOATING, %NULL will be
/// returned, as there is no associated device.
/// </para>
/// </summary>

/// <param name="device">
/// a #GdkDevice
/// </param>
/// <return>
/// The associated device, or
///   %NULL
/// </return>

	public static MentorLake.Gdk.GdkDeviceHandle GetAssociatedDevice(this MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_associated_device(device);
	}

/// <summary>
/// <para>
/// Returns the axes currently available on the device.
/// </para>
/// </summary>

/// <param name="device">
/// a #GdkDevice
/// </param>

	public static MentorLake.Gdk.GdkAxisFlags GetAxes(this MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_axes(device);
	}

/// <summary>
/// <para>
/// Interprets an array of double as axis values for a given device,
/// and locates the value in the array for a given axis use.
/// </para>
/// </summary>

/// <param name="device">
/// a #GdkDevice
/// </param>
/// <param name="axes">
/// pointer to an array of axes
/// </param>
/// <param name="use">
/// the use to look for
/// </param>
/// <param name="value">
/// location to store the found value.
/// </param>
/// <return>
/// %TRUE if the given axis use was found, otherwise %FALSE
/// </return>

	public static bool GetAxis(this MentorLake.Gdk.GdkDeviceHandle device, double[] axes, MentorLake.Gdk.GdkAxisUse use, out double value)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_axis(device, axes, use, out value);
	}

/// <summary>
/// <para>
/// Returns the axis use for @index_.
/// </para>
/// </summary>

/// <param name="device">
/// a pointer #GdkDevice.
/// </param>
/// <param name="index_">
/// the index of the axis.
/// </param>
/// <return>
/// a #GdkAxisUse specifying how the axis is used.
/// </return>

	public static MentorLake.Gdk.GdkAxisUse GetAxisUse(this MentorLake.Gdk.GdkDeviceHandle device, uint index_)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_axis_use(device, index_);
	}

/// <summary>
/// <para>
/// Interprets an array of double as axis values for a given device,
/// and locates the value in the array for a given axis label, as returned
/// by gdk_device_list_axes()
/// </para>
/// </summary>

/// <param name="device">
/// a pointer #GdkDevice.
/// </param>
/// <param name="axes">
/// pointer to an array of axes
/// </param>
/// <param name="axis_label">
/// #GdkAtom with the axis label.
/// </param>
/// <param name="value">
/// location to store the found value.
/// </param>
/// <return>
/// %TRUE if the given axis use was found, otherwise %FALSE.
/// </return>

	public static bool GetAxisValue(this MentorLake.Gdk.GdkDeviceHandle device, double[] axes, MentorLake.Gdk.GdkAtom axis_label, out double value)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_axis_value(device, axes, axis_label, out value);
	}

/// <summary>
/// <para>
/// Returns the device type for @device.
/// </para>
/// </summary>

/// <param name="device">
/// a #GdkDevice
/// </param>
/// <return>
/// the #GdkDeviceType for @device.
/// </return>

	public static MentorLake.Gdk.GdkDeviceType GetDeviceType(this MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_device_type(device);
	}

/// <summary>
/// <para>
/// Returns the #GdkDisplay to which @device pertains.
/// </para>
/// </summary>

/// <param name="device">
/// a #GdkDevice
/// </param>
/// <return>
/// a #GdkDisplay. This memory is owned
///          by GTK+, and must not be freed or unreffed.
/// </return>

	public static MentorLake.Gdk.GdkDisplayHandle GetDisplay(this MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_display(device);
	}

/// <summary>
/// <para>
/// Determines whether the pointer follows device motion.
/// This is not meaningful for keyboard devices, which don&apos;t have a pointer.
/// </para>
/// </summary>

/// <param name="device">
/// a #GdkDevice
/// </param>
/// <return>
/// %TRUE if the pointer follows device motion
/// </return>

	public static bool GetHasCursor(this MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_has_cursor(device);
	}

/// <summary>
/// <para>
/// Obtains the motion history for a pointer device; given a starting and
/// ending timestamp, return all events in the motion history for
/// the device in the given range of time. Some windowing systems
/// do not support motion history, in which case, %FALSE will
/// be returned. (This is not distinguishable from the case where
/// motion history is supported and no events were found.)
/// </para>
/// <para>
/// Note that there is also gdk_window_set_event_compression() to get
/// more motion events delivered directly, independent of the windowing
/// system.
/// </para>
/// </summary>

/// <param name="device">
/// a #GdkDevice
/// </param>
/// <param name="window">
/// the window with respect to which which the event coordinates will be reported
/// </param>
/// <param name="start">
/// starting timestamp for range of events to return
/// </param>
/// <param name="stop">
/// ending timestamp for the range of events to return
/// </param>
/// <param name="events">
/// 
///   location to store a newly-allocated array of #GdkTimeCoord, or
///   %NULL
/// </param>
/// <param name="n_events">
/// location to store the length of
///   @events, or %NULL
/// </param>
/// <return>
/// %TRUE if the windowing system supports motion history and
///  at least one event was found.
/// </return>

	public static bool GetHistory(this MentorLake.Gdk.GdkDeviceHandle device, MentorLake.Gdk.GdkWindowHandle window, uint start, uint stop, out MentorLake.Gdk.GdkTimeCoordHandle[] events, out int n_events)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_history(device, window, start, stop, out events, out n_events);
	}

/// <summary>
/// <para>
/// If @index_ has a valid keyval, this function will return %TRUE
/// and fill in @keyval and @modifiers with the keyval settings.
/// </para>
/// </summary>

/// <param name="device">
/// a #GdkDevice.
/// </param>
/// <param name="index_">
/// the index of the macro button to get.
/// </param>
/// <param name="keyval">
/// return value for the keyval.
/// </param>
/// <param name="modifiers">
/// return value for modifiers.
/// </param>
/// <return>
/// %TRUE if keyval is set for @index.
/// </return>

	public static bool GetKey(this MentorLake.Gdk.GdkDeviceHandle device, uint index_, out uint keyval, out MentorLake.Gdk.GdkModifierType modifiers)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_key(device, index_, out keyval, out modifiers);
	}

/// <summary>
/// <para>
/// Gets information about which window the given pointer device is in, based on events
/// that have been received so far from the display server. If another application
/// has a pointer grab, or this application has a grab with owner_events = %FALSE,
/// %NULL may be returned even if the pointer is physically over one of this
/// application&apos;s windows.
/// </para>
/// </summary>

/// <param name="device">
/// a #GdkDevice, with a source other than %GDK_SOURCE_KEYBOARD
/// </param>
/// <return>
/// the last window the device
/// </return>

	public static MentorLake.Gdk.GdkWindowHandle GetLastEventWindow(this MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_last_event_window(device);
	}

/// <summary>
/// <para>
/// Determines the mode of the device.
/// </para>
/// </summary>

/// <param name="device">
/// a #GdkDevice
/// </param>
/// <return>
/// a #GdkInputSource
/// </return>

	public static MentorLake.Gdk.GdkInputMode GetMode(this MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_mode(device);
	}

/// <summary>
/// <para>
/// Returns the number of axes the device currently has.
/// </para>
/// </summary>

/// <param name="device">
/// a pointer #GdkDevice
/// </param>
/// <return>
/// the number of axes.
/// </return>

	public static int GetNAxes(this MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_n_axes(device);
	}

/// <summary>
/// <para>
/// Returns the number of keys the device currently has.
/// </para>
/// </summary>

/// <param name="device">
/// a #GdkDevice
/// </param>
/// <return>
/// the number of keys.
/// </return>

	public static int GetNKeys(this MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_n_keys(device);
	}

/// <summary>
/// <para>
/// Determines the name of the device.
/// </para>
/// </summary>

/// <param name="device">
/// a #GdkDevice
/// </param>
/// <return>
/// a name
/// </return>

	public static string GetName(this MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_name(device);
	}

/// <summary>
/// <para>
/// Gets the current location of @device. As a slave device
/// coordinates are those of its master pointer, This function
/// may not be called on devices of type %GDK_DEVICE_TYPE_SLAVE,
/// unless there is an ongoing grab on them, see gdk_device_grab().
/// </para>
/// </summary>

/// <param name="device">
/// pointer device to query status about.
/// </param>
/// <param name="screen">
/// location to store the #GdkScreen
///          the @device is on, or %NULL.
/// </param>
/// <param name="x">
/// location to store root window X coordinate of @device, or %NULL.
/// </param>
/// <param name="y">
/// location to store root window Y coordinate of @device, or %NULL.
/// </param>

	public static T GetPosition<T>(this T device, out MentorLake.Gdk.GdkScreenHandle screen, out int x, out int y) where T : GdkDeviceHandle
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		GdkDeviceHandleExterns.gdk_device_get_position(device, out screen, out x, out y);
		return device;
	}

/// <summary>
/// <para>
/// Gets the current location of @device in double precision. As a slave device&apos;s
/// coordinates are those of its master pointer, this function
/// may not be called on devices of type %GDK_DEVICE_TYPE_SLAVE,
/// unless there is an ongoing grab on them. See gdk_device_grab().
/// </para>
/// </summary>

/// <param name="device">
/// pointer device to query status about.
/// </param>
/// <param name="screen">
/// location to store the #GdkScreen
///          the @device is on, or %NULL.
/// </param>
/// <param name="x">
/// location to store root window X coordinate of @device, or %NULL.
/// </param>
/// <param name="y">
/// location to store root window Y coordinate of @device, or %NULL.
/// </param>

	public static T GetPositionDouble<T>(this T device, out MentorLake.Gdk.GdkScreenHandle screen, out double x, out double y) where T : GdkDeviceHandle
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		GdkDeviceHandleExterns.gdk_device_get_position_double(device, out screen, out x, out y);
		return device;
	}

/// <summary>
/// <para>
/// Returns the product ID of this device, or %NULL if this information couldn&apos;t
/// be obtained. This ID is retrieved from the device, and is thus constant for
/// it. See gdk_device_get_vendor_id() for more information.
/// </para>
/// </summary>

/// <param name="device">
/// a slave #GdkDevice
/// </param>
/// <return>
/// the product ID, or %NULL
/// </return>

	public static string GetProductId(this MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_product_id(device);
	}

/// <summary>
/// <para>
/// Returns the #GdkSeat the device belongs to.
/// </para>
/// </summary>

/// <param name="device">
/// A #GdkDevice
/// </param>
/// <return>
/// A #GdkSeat. This memory is owned by GTK+ and
///          must not be freed.
/// </return>

	public static MentorLake.Gdk.GdkSeatHandle GetSeat(this MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_seat(device);
	}

/// <summary>
/// <para>
/// Determines the type of the device.
/// </para>
/// </summary>

/// <param name="device">
/// a #GdkDevice
/// </param>
/// <return>
/// a #GdkInputSource
/// </return>

	public static MentorLake.Gdk.GdkInputSource GetSource(this MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_source(device);
	}

/// <summary>
/// <para>
/// Gets the current state of a pointer device relative to @window. As a slave
/// device’s coordinates are those of its master pointer, this
/// function may not be called on devices of type %GDK_DEVICE_TYPE_SLAVE,
/// unless there is an ongoing grab on them. See gdk_device_grab().
/// </para>
/// </summary>

/// <param name="device">
/// a #GdkDevice.
/// </param>
/// <param name="window">
/// a #GdkWindow.
/// </param>
/// <param name="axes">
/// an array of doubles to store the values of
/// the axes of @device in, or %NULL.
/// </param>
/// <param name="mask">
/// location to store the modifiers, or %NULL.
/// </param>

	public static T GetState<T>(this T device, MentorLake.Gdk.GdkWindowHandle window, double[] axes, out MentorLake.Gdk.GdkModifierType mask) where T : GdkDeviceHandle
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		GdkDeviceHandleExterns.gdk_device_get_state(device, window, axes, out mask);
		return device;
	}

/// <summary>
/// <para>
/// Returns the vendor ID of this device, or %NULL if this information couldn&apos;t
/// be obtained. This ID is retrieved from the device, and is thus constant for
/// it.
/// </para>
/// <para>
/// This function, together with gdk_device_get_product_id(), can be used to eg.
/// compose #GSettings paths to store settings for this device.
/// </para>
/// <code>
///  static GSettings *
///  static GSettings *
///  get_device_settings (GdkDevice *device)
///  {
///    const gchar *vendor, *product;
///    GSettings *settings;
///    GdkDevice *device;
///    gchar *path;
/// 
///    vendor = gdk_device_get_vendor_id (device);
///    product = gdk_device_get_product_id (device);
/// 
///    path = g_strdup_printf (&quot;/org/example/app/devices/%s:%s/&quot;, vendor, product);
///    settings = g_settings_new_with_path (DEVICE_SCHEMA, path);
///    g_free (path);
/// 
///    return settings;
///  }
/// </code>
/// </summary>

/// <param name="device">
/// a slave #GdkDevice
/// </param>
/// <return>
/// the vendor ID, or %NULL
/// </return>

	public static string GetVendorId(this MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_vendor_id(device);
	}

/// <summary>
/// <para>
/// Obtains the window underneath @device, returning the location of the device in @win_x and @win_y. Returns
/// %NULL if the window tree under @device is not known to GDK (for example, belongs to another application).
/// </para>
/// <para>
/// As a slave device coordinates are those of its master pointer, This
/// function may not be called on devices of type %GDK_DEVICE_TYPE_SLAVE,
/// unless there is an ongoing grab on them, see gdk_device_grab().
/// </para>
/// </summary>

/// <param name="device">
/// pointer #GdkDevice to query info to.
/// </param>
/// <param name="win_x">
/// return location for the X coordinate of the device location,
///         relative to the window origin, or %NULL.
/// </param>
/// <param name="win_y">
/// return location for the Y coordinate of the device location,
///         relative to the window origin, or %NULL.
/// </param>
/// <return>
/// the #GdkWindow under the
/// device position, or %NULL.
/// </return>

	public static MentorLake.Gdk.GdkWindowHandle GetWindowAtPosition(this MentorLake.Gdk.GdkDeviceHandle device, out int win_x, out int win_y)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_window_at_position(device, out win_x, out win_y);
	}

/// <summary>
/// <para>
/// Obtains the window underneath @device, returning the location of the device in @win_x and @win_y in
/// double precision. Returns %NULL if the window tree under @device is not known to GDK (for example,
/// belongs to another application).
/// </para>
/// <para>
/// As a slave device coordinates are those of its master pointer, This
/// function may not be called on devices of type %GDK_DEVICE_TYPE_SLAVE,
/// unless there is an ongoing grab on them, see gdk_device_grab().
/// </para>
/// </summary>

/// <param name="device">
/// pointer #GdkDevice to query info to.
/// </param>
/// <param name="win_x">
/// return location for the X coordinate of the device location,
///         relative to the window origin, or %NULL.
/// </param>
/// <param name="win_y">
/// return location for the Y coordinate of the device location,
///         relative to the window origin, or %NULL.
/// </param>
/// <return>
/// the #GdkWindow under the
///   device position, or %NULL.
/// </return>

	public static MentorLake.Gdk.GdkWindowHandle GetWindowAtPositionDouble(this MentorLake.Gdk.GdkDeviceHandle device, out double win_x, out double win_y)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_get_window_at_position_double(device, out win_x, out win_y);
	}

/// <summary>
/// <para>
/// Grabs the device so that all events coming from this device are passed to
/// this application until the device is ungrabbed with gdk_device_ungrab(),
/// or the window becomes unviewable. This overrides any previous grab on the device
/// by this client.
/// </para>
/// <para>
/// Note that @device and @window need to be on the same display.
/// </para>
/// <para>
/// Device grabs are used for operations which need complete control over the
/// given device events (either pointer or keyboard). For example in GTK+ this
/// is used for Drag and Drop operations, popup menus and such.
/// </para>
/// <para>
/// Note that if the event mask of an X window has selected both button press
/// and button release events, then a button press event will cause an automatic
/// pointer grab until the button is released. X does this automatically since
/// most applications expect to receive button press and release events in pairs.
/// It is equivalent to a pointer grab on the window with @owner_events set to
/// %TRUE.
/// </para>
/// <para>
/// If you set up anything at the time you take the grab that needs to be
/// cleaned up when the grab ends, you should handle the #GdkEventGrabBroken
/// events that are emitted when the grab ends unvoluntarily.
/// </para>
/// </summary>

/// <param name="device">
/// a #GdkDevice. To get the device you can use gtk_get_current_event_device()
///   or gdk_event_get_device() if the grab is in reaction to an event. Also, you can use
///   gdk_device_manager_get_client_pointer() but only in code that isn’t triggered by a
///   #GdkEvent and there aren’t other means to get a meaningful #GdkDevice to operate on.
/// </param>
/// <param name="window">
/// the #GdkWindow which will own the grab (the grab window)
/// </param>
/// <param name="grab_ownership">
/// specifies the grab ownership.
/// </param>
/// <param name="owner_events">
/// if %FALSE then all device events are reported with respect to
///                @window and are only reported if selected by @event_mask. If
///                %TRUE then pointer events for this application are reported
///                as normal, but pointer events outside this application are
///                reported with respect to @window and only if selected by
///                @event_mask. In either mode, unreported events are discarded.
/// </param>
/// <param name="event_mask">
/// specifies the event mask, which is used in accordance with
///              @owner_events.
/// </param>
/// <param name="cursor">
/// the cursor to display while the grab is active if the device is
///          a pointer. If this is %NULL then the normal cursors are used for
///          @window and its descendants, and the cursor for @window is used
///          elsewhere.
/// </param>
/// <param name="time_">
/// the timestamp of the event which led to this pointer grab. This
///         usually comes from the #GdkEvent struct, though %GDK_CURRENT_TIME
///         can be used if the time isn’t known.
/// </param>
/// <return>
/// %GDK_GRAB_SUCCESS if the grab was successful.
/// </return>

	public static MentorLake.Gdk.GdkGrabStatus Grab(this MentorLake.Gdk.GdkDeviceHandle device, MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkGrabOwnership grab_ownership, bool owner_events, MentorLake.Gdk.GdkEventMask event_mask, MentorLake.Gdk.GdkCursorHandle cursor, uint time_)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_grab(device, window, grab_ownership, owner_events, event_mask, cursor, time_);
	}

/// <summary>
/// <para>
/// Returns a #GList of #GdkAtoms, containing the labels for
/// the axes that @device currently has.
/// </para>
/// </summary>

/// <param name="device">
/// a pointer #GdkDevice
/// </param>
/// <return>
/// 
///     A #GList of #GdkAtoms, free with g_list_free().
/// </return>

	public static MentorLake.GLib.GListHandle ListAxes(this MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_list_axes(device);
	}

/// <summary>
/// <para>
/// If the device if of type %GDK_DEVICE_TYPE_MASTER, it will return
/// the list of slave devices attached to it, otherwise it will return
/// %NULL
/// </para>
/// </summary>

/// <param name="device">
/// a #GdkDevice
/// </param>
/// <return>
/// 
///          the list of slave devices, or %NULL. The list must be
///          freed with g_list_free(), the contents of the list are
///          owned by GTK+ and should not be freed.
/// </return>

	public static MentorLake.GLib.GListHandle ListSlaveDevices(this MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_list_slave_devices(device);
	}

/// <summary>
/// <para>
/// Specifies how an axis of a device is used.
/// </para>
/// </summary>

/// <param name="device">
/// a pointer #GdkDevice
/// </param>
/// <param name="index_">
/// the index of the axis
/// </param>
/// <param name="use">
/// specifies how the axis is used
/// </param>

	public static T SetAxisUse<T>(this T device, uint index_, MentorLake.Gdk.GdkAxisUse use) where T : GdkDeviceHandle
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		GdkDeviceHandleExterns.gdk_device_set_axis_use(device, index_, use);
		return device;
	}

/// <summary>
/// <para>
/// Specifies the X key event to generate when a macro button of a device
/// is pressed.
/// </para>
/// </summary>

/// <param name="device">
/// a #GdkDevice
/// </param>
/// <param name="index_">
/// the index of the macro button to set
/// </param>
/// <param name="keyval">
/// the keyval to generate
/// </param>
/// <param name="modifiers">
/// the modifiers to set
/// </param>

	public static T SetKey<T>(this T device, uint index_, uint keyval, MentorLake.Gdk.GdkModifierType modifiers) where T : GdkDeviceHandle
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		GdkDeviceHandleExterns.gdk_device_set_key(device, index_, keyval, modifiers);
		return device;
	}

/// <summary>
/// <para>
/// Sets a the mode of an input device. The mode controls if the
/// device is active and whether the device’s range is mapped to the
/// entire screen or to a single window.
/// </para>
/// <para>
/// Note: This is only meaningful for floating devices, master devices (and
/// slaves connected to these) drive the pointer cursor, which is not limited
/// by the input mode.
/// </para>
/// </summary>

/// <param name="device">
/// a #GdkDevice.
/// </param>
/// <param name="mode">
/// the input mode.
/// </param>
/// <return>
/// %TRUE if the mode was successfully changed.
/// </return>

	public static bool SetMode(this MentorLake.Gdk.GdkDeviceHandle device, MentorLake.Gdk.GdkInputMode mode)
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		return GdkDeviceHandleExterns.gdk_device_set_mode(device, mode);
	}

/// <summary>
/// <para>
/// Release any grab on @device.
/// </para>
/// </summary>

/// <param name="device">
/// a #GdkDevice
/// </param>
/// <param name="time_">
/// a timestap (e.g. %GDK_CURRENT_TIME).
/// </param>

	public static T Ungrab<T>(this T device, uint time_) where T : GdkDeviceHandle
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		GdkDeviceHandleExterns.gdk_device_ungrab(device, time_);
		return device;
	}

/// <summary>
/// <para>
/// Warps @device in @display to the point @x,@y on
/// the screen @screen, unless the device is confined
/// to a window by a grab, in which case it will be moved
/// as far as allowed by the grab. Warping the pointer
/// creates events as if the user had moved the mouse
/// instantaneously to the destination.
/// </para>
/// <para>
/// Note that the pointer should normally be under the
/// control of the user. This function was added to cover
/// some rare use cases like keyboard navigation support
/// for the color picker in the #GtkColorSelectionDialog.
/// </para>
/// </summary>

/// <param name="device">
/// the device to warp.
/// </param>
/// <param name="screen">
/// the screen to warp @device to.
/// </param>
/// <param name="x">
/// the X coordinate of the destination.
/// </param>
/// <param name="y">
/// the Y coordinate of the destination.
/// </param>

	public static T Warp<T>(this T device, MentorLake.Gdk.GdkScreenHandle screen, int x, int y) where T : GdkDeviceHandle
	{
		if (device.IsInvalid) throw new Exception("Invalid handle (GdkDeviceHandle)");
		GdkDeviceHandleExterns.gdk_device_warp(device, screen, x, y);
		return device;
	}

}

internal class GdkDeviceHandleExterns
{
	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))]
	internal static extern MentorLake.Gdk.GdkDeviceHandle gdk_device_get_associated_device([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkAxisFlags gdk_device_get_axes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_device_get_axis([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, double[] axes, MentorLake.Gdk.GdkAxisUse use, out double value);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkAxisUse gdk_device_get_axis_use([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, uint index_);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_device_get_axis_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, double[] axes, MentorLake.Gdk.GdkAtom axis_label, out double value);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkDeviceType gdk_device_get_device_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))]
	internal static extern MentorLake.Gdk.GdkDisplayHandle gdk_device_get_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_device_get_has_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_device_get_history([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, uint start, uint stop, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 5, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkTimeCoordHandle>))] out MentorLake.Gdk.GdkTimeCoordHandle[] events, out int n_events);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_device_get_key([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, uint index_, out uint keyval, out MentorLake.Gdk.GdkModifierType modifiers);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gdk_device_get_last_event_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkInputMode gdk_device_get_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_device_get_n_axes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_device_get_n_keys([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_device_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_device_get_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] out MentorLake.Gdk.GdkScreenHandle screen, out int x, out int y);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_device_get_position_double([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] out MentorLake.Gdk.GdkScreenHandle screen, out double x, out double y);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_device_get_product_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkSeatHandle>))]
	internal static extern MentorLake.Gdk.GdkSeatHandle gdk_device_get_seat([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkInputSource gdk_device_get_source([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_device_get_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, double[] axes, out MentorLake.Gdk.GdkModifierType mask);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_device_get_vendor_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gdk_device_get_window_at_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, out int win_x, out int win_y);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gdk_device_get_window_at_position_double([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, out double win_x, out double win_y);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkGrabStatus gdk_device_grab([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkGrabOwnership grab_ownership, bool owner_events, MentorLake.Gdk.GdkEventMask event_mask, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkCursorHandle>))] MentorLake.Gdk.GdkCursorHandle cursor, uint time_);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gdk_device_list_axes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gdk_device_list_slave_devices([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_device_set_axis_use([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, uint index_, MentorLake.Gdk.GdkAxisUse use);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_device_set_key([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, uint index_, uint keyval, MentorLake.Gdk.GdkModifierType modifiers);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_device_set_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, MentorLake.Gdk.GdkInputMode mode);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_device_ungrab([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, uint time_);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_device_warp([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen, int x, int y);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_device_free_history([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 1, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkTimeCoordHandle>))] MentorLake.Gdk.GdkTimeCoordHandle[] events, int n_events);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_device_grab_info_libgtk_only([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] out MentorLake.Gdk.GdkWindowHandle grab_window, out bool owner_events);

}
