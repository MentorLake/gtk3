namespace MentorLake.Gdk;


public class GdkWindowHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new #GdkWindow using the attributes from
/// @attributes. See #GdkWindowAttr and #GdkWindowAttributesType for
/// more details.  Note: to use this on displays other than the default
/// display, @parent must be specified.
/// </para>
/// </summary>

/// <param name="parent">
/// a #GdkWindow, or %NULL to create the window as a child of
///   the default root window for the default display.
/// </param>
/// <param name="attributes">
/// attributes of the new window
/// </param>
/// <param name="attributes_mask">
/// mask indicating which
///   fields in @attributes are valid
/// </param>
/// <return>
/// the new #GdkWindow
/// </return>

	public static MentorLake.Gdk.GdkWindowHandle New(MentorLake.Gdk.GdkWindowHandle parent, MentorLake.Gdk.GdkWindowAttrHandle attributes, int attributes_mask)
	{
		return GdkWindowHandleExterns.gdk_window_new(parent, attributes, attributes_mask);
	}

/// <summary>
/// <para>
/// Obtains the window underneath the mouse pointer, returning the
/// location of that window in @win_x, @win_y. Returns %NULL if the
/// window under the mouse pointer is not known to GDK (if the window
/// belongs to another application and a #GdkWindow hasn’t been created
/// for it with gdk_window_foreign_new())
/// </para>
/// <para>
/// NOTE: For multihead-aware widgets or applications use
/// gdk_display_get_window_at_pointer() instead.
/// </para>
/// </summary>

/// <param name="win_x">
/// return location for origin of the window under the pointer
/// </param>
/// <param name="win_y">
/// return location for origin of the window under the pointer
/// </param>
/// <return>
/// window under the mouse pointer
/// </return>

	public static MentorLake.Gdk.GdkWindowHandle AtPointer(out int win_x, out int win_y)
	{
		return GdkWindowHandleExterns.gdk_window_at_pointer(out win_x, out win_y);
	}

/// <summary>
/// <para>
/// Constrains a desired width and height according to a
/// set of geometry hints (such as minimum and maximum size).
/// </para>
/// </summary>

/// <param name="geometry">
/// a #GdkGeometry structure
/// </param>
/// <param name="flags">
/// a mask indicating what portions of @geometry are set
/// </param>
/// <param name="width">
/// desired width of window
/// </param>
/// <param name="height">
/// desired height of the window
/// </param>
/// <param name="new_width">
/// location to store resulting width
/// </param>
/// <param name="new_height">
/// location to store resulting height
/// </param>

	public static void ConstrainSize(MentorLake.Gdk.GdkGeometryHandle geometry, MentorLake.Gdk.GdkWindowHints flags, int width, int height, out int new_width, out int new_height)
	{
		GdkWindowHandleExterns.gdk_window_constrain_size(geometry, flags, width, height, out new_width, out new_height);
	}

/// <summary>
/// <para>
/// Calls gdk_window_process_updates() for all windows (see #GdkWindow)
/// in the application.
/// </para>
/// </summary>


	public static void ProcessAllUpdates()
	{
		GdkWindowHandleExterns.gdk_window_process_all_updates();
	}

/// <summary>
/// <para>
/// With update debugging enabled, calls to
/// gdk_window_invalidate_region() clear the invalidated region of the
/// screen to a noticeable color, and GDK pauses for a short time
/// before sending exposes to windows during
/// gdk_window_process_updates().  The net effect is that you can see
/// the invalid region for each window and watch redraws as they
/// occur. This allows you to diagnose inefficiencies in your application.
/// </para>
/// <para>
/// In essence, because the GDK rendering model prevents all flicker,
/// if you are redrawing the same region 400 times you may never
/// notice, aside from noticing a speed problem. Enabling update
/// debugging causes GTK to flicker slowly and noticeably, so you can
/// see exactly what’s being redrawn when, in what order.
/// </para>
/// <para>
/// The --gtk-debug=updates command line option passed to GTK+ programs
/// enables this debug option at application startup time. That's
/// usually more useful than calling gdk_window_set_debug_updates()
/// yourself, though you might want to use this function to enable
/// updates sometime after application startup time.
/// </para>
/// </summary>

/// <param name="setting">
/// %TRUE to turn on update debugging
/// </param>

	public static void SetDebugUpdates(bool setting)
	{
		GdkWindowHandleExterns.gdk_window_set_debug_updates(setting);
	}

}
public static class GdkWindowHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::create-surface signal is emitted when an offscreen window
/// needs its surface (re)created, which happens either when the
/// window is first drawn to, or when the window is being
/// resized. The first signal handler that returns a non-%NULL
/// surface will stop any further signal emission, and its surface
/// will be used.
/// </para>
/// <para>
/// Note that it is not possible to access the window's previous
/// surface from within any callback of this signal. Calling
/// gdk_offscreen_window_get_surface() will lead to a crash.
/// </para>
/// </summary>

	public static IObservable<GdkWindowHandleSignalStructs.CreateSurfaceSignal> Signal_CreateSurface(this GdkWindowHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkWindowHandleSignalStructs.CreateSurfaceSignal> obs) =>
		{
			GdkWindowHandleSignalDelegates.create_surface handler = ( MentorLake.Gdk.GdkWindowHandle self,  int width,  int height,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkWindowHandleSignalStructs.CreateSurfaceSignal()
				{
					Self = self, Width = width, Height = height, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "create-surface", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::from-embedder signal is emitted to translate coordinates
/// in the embedder of an offscreen window to the offscreen window.
/// </para>
/// <para>
/// See also #GdkWindow::to-embedder.
/// </para>
/// </summary>

	public static IObservable<GdkWindowHandleSignalStructs.FromEmbedderSignal> Signal_FromEmbedder(this GdkWindowHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkWindowHandleSignalStructs.FromEmbedderSignal> obs) =>
		{
			GdkWindowHandleSignalDelegates.from_embedder handler = ( MentorLake.Gdk.GdkWindowHandle self,  double embedder_x,  double embedder_y, out double offscreen_x, out double offscreen_y,  IntPtr user_data) =>
			{
				offscreen_x = default;
			offscreen_y = default;

				var signalStruct = new GdkWindowHandleSignalStructs.FromEmbedderSignal()
				{
					Self = self, EmbedderX = embedder_x, EmbedderY = embedder_y, OffscreenX = offscreen_x, OffscreenY = offscreen_y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "from-embedder", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when the position of @window is finalized after being moved to a
/// destination rectangle.
/// </para>
/// <para>
/// @window might be flipped over the destination rectangle in order to keep
/// it on-screen, in which case @flipped_x and @flipped_y will be set to %TRUE
/// accordingly.
/// </para>
/// <para>
/// @flipped_rect is the ideal position of @window after any possible
/// flipping, but before any possible sliding. @final_rect is @flipped_rect,
/// but possibly translated in the case that flipping is still ineffective in
/// keeping @window on-screen.
/// </para>
/// </summary>

	public static IObservable<GdkWindowHandleSignalStructs.MovedToRectSignal> Signal_MovedToRect(this GdkWindowHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkWindowHandleSignalStructs.MovedToRectSignal> obs) =>
		{
			GdkWindowHandleSignalDelegates.moved_to_rect handler = ( MentorLake.Gdk.GdkWindowHandle self,  IntPtr flipped_rect,  IntPtr final_rect,  bool flipped_x,  bool flipped_y,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkWindowHandleSignalStructs.MovedToRectSignal()
				{
					Self = self, FlippedRect = flipped_rect, FinalRect = final_rect, FlippedX = flipped_x, FlippedY = flipped_y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "moved-to-rect", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::pick-embedded-child signal is emitted to find an embedded
/// child at the given position.
/// </para>
/// </summary>

	public static IObservable<GdkWindowHandleSignalStructs.PickEmbeddedChildSignal> Signal_PickEmbeddedChild(this GdkWindowHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkWindowHandleSignalStructs.PickEmbeddedChildSignal> obs) =>
		{
			GdkWindowHandleSignalDelegates.pick_embedded_child handler = ( MentorLake.Gdk.GdkWindowHandle self,  double x,  double y,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkWindowHandleSignalStructs.PickEmbeddedChildSignal()
				{
					Self = self, X = x, Y = y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "pick-embedded-child", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::to-embedder signal is emitted to translate coordinates
/// in an offscreen window to its embedder.
/// </para>
/// <para>
/// See also #GdkWindow::from-embedder.
/// </para>
/// </summary>

	public static IObservable<GdkWindowHandleSignalStructs.ToEmbedderSignal> Signal_ToEmbedder(this GdkWindowHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkWindowHandleSignalStructs.ToEmbedderSignal> obs) =>
		{
			GdkWindowHandleSignalDelegates.to_embedder handler = ( MentorLake.Gdk.GdkWindowHandle self,  double offscreen_x,  double offscreen_y, out double embedder_x, out double embedder_y,  IntPtr user_data) =>
			{
				embedder_x = default;
			embedder_y = default;

				var signalStruct = new GdkWindowHandleSignalStructs.ToEmbedderSignal()
				{
					Self = self, OffscreenX = offscreen_x, OffscreenY = offscreen_y, EmbedderX = embedder_x, EmbedderY = embedder_y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "to-embedder", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GdkWindowHandleSignalStructs
{

public class CreateSurfaceSignal
{

	public MentorLake.Gdk.GdkWindowHandle Self;
/// <summary>
/// <para>
/// the width of the offscreen surface to create
/// </para>
/// </summary>

	public int Width;
/// <summary>
/// <para>
/// the height of the offscreen surface to create
/// </para>
/// </summary>

	public int Height;

	public IntPtr UserData;
/// <summary>
/// <para>
/// the newly created #cairo_surface_t for the offscreen window
/// </para>
/// </summary>

	public MentorLake.cairo.cairo_surface_tHandle ReturnValue;
}

public class FromEmbedderSignal
{

	public MentorLake.Gdk.GdkWindowHandle Self;
/// <summary>
/// <para>
/// x coordinate in the embedder window
/// </para>
/// </summary>

	public double EmbedderX;
/// <summary>
/// <para>
/// y coordinate in the embedder window
/// </para>
/// </summary>

	public double EmbedderY;
/// <summary>
/// <para>
/// return location for the x
///     coordinate in the offscreen window
/// </para>
/// </summary>

	public double OffscreenX;
/// <summary>
/// <para>
/// return location for the y
///     coordinate in the offscreen window
/// </para>
/// </summary>

	public double OffscreenY;

	public IntPtr UserData;
}

public class MovedToRectSignal
{

	public MentorLake.Gdk.GdkWindowHandle Self;
/// <summary>
/// <para>
/// the position of @window after any possible
///                flipping or %NULL if the backend can't obtain it
/// </para>
/// </summary>

	public IntPtr FlippedRect;
/// <summary>
/// <para>
/// the final position of @window or %NULL if the
///              backend can't obtain it
/// </para>
/// </summary>

	public IntPtr FinalRect;
/// <summary>
/// <para>
/// %TRUE if the anchors were flipped horizontally
/// </para>
/// </summary>

	public bool FlippedX;
/// <summary>
/// <para>
/// %TRUE if the anchors were flipped vertically
/// </para>
/// </summary>

	public bool FlippedY;

	public IntPtr UserData;
}

public class PickEmbeddedChildSignal
{

	public MentorLake.Gdk.GdkWindowHandle Self;
/// <summary>
/// <para>
/// x coordinate in the window
/// </para>
/// </summary>

	public double X;
/// <summary>
/// <para>
/// y coordinate in the window
/// </para>
/// </summary>

	public double Y;

	public IntPtr UserData;
/// <summary>
/// <para>
/// the #GdkWindow of the
///     embedded child at @x, @y, or %NULL
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkWindowHandle ReturnValue;
}

public class ToEmbedderSignal
{

	public MentorLake.Gdk.GdkWindowHandle Self;
/// <summary>
/// <para>
/// x coordinate in the offscreen window
/// </para>
/// </summary>

	public double OffscreenX;
/// <summary>
/// <para>
/// y coordinate in the offscreen window
/// </para>
/// </summary>

	public double OffscreenY;
/// <summary>
/// <para>
/// return location for the x
///     coordinate in the embedder window
/// </para>
/// </summary>

	public double EmbedderX;
/// <summary>
/// <para>
/// return location for the y
///     coordinate in the embedder window
/// </para>
/// </summary>

	public double EmbedderY;

	public IntPtr UserData;
}
}

public static class GdkWindowHandleSignalDelegates
{

/// <summary>
/// <para>
/// The ::create-surface signal is emitted when an offscreen window
/// needs its surface (re)created, which happens either when the
/// window is first drawn to, or when the window is being
/// resized. The first signal handler that returns a non-%NULL
/// surface will stop any further signal emission, and its surface
/// will be used.
/// </para>
/// <para>
/// Note that it is not possible to access the window's previous
/// surface from within any callback of this signal. Calling
/// gdk_offscreen_window_get_surface() will lead to a crash.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="width">
/// the width of the offscreen surface to create
/// </param>
/// <param name="height">
/// the height of the offscreen surface to create
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// the newly created #cairo_surface_t for the offscreen window
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.cairo.cairo_surface_tHandle create_surface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle self, int width, int height, IntPtr user_data);


/// <summary>
/// <para>
/// The ::from-embedder signal is emitted to translate coordinates
/// in the embedder of an offscreen window to the offscreen window.
/// </para>
/// <para>
/// See also #GdkWindow::to-embedder.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="embedder_x">
/// x coordinate in the embedder window
/// </param>
/// <param name="embedder_y">
/// y coordinate in the embedder window
/// </param>
/// <param name="offscreen_x">
/// return location for the x
///     coordinate in the offscreen window
/// </param>
/// <param name="offscreen_y">
/// return location for the y
///     coordinate in the offscreen window
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void from_embedder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle self, double embedder_x, double embedder_y, out double offscreen_x, out double offscreen_y, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when the position of @window is finalized after being moved to a
/// destination rectangle.
/// </para>
/// <para>
/// @window might be flipped over the destination rectangle in order to keep
/// it on-screen, in which case @flipped_x and @flipped_y will be set to %TRUE
/// accordingly.
/// </para>
/// <para>
/// @flipped_rect is the ideal position of @window after any possible
/// flipping, but before any possible sliding. @final_rect is @flipped_rect,
/// but possibly translated in the case that flipping is still ineffective in
/// keeping @window on-screen.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="flipped_rect">
/// the position of @window after any possible
///                flipping or %NULL if the backend can't obtain it
/// </param>
/// <param name="final_rect">
/// the final position of @window or %NULL if the
///              backend can't obtain it
/// </param>
/// <param name="flipped_x">
/// %TRUE if the anchors were flipped horizontally
/// </param>
/// <param name="flipped_y">
/// %TRUE if the anchors were flipped vertically
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void moved_to_rect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle self, IntPtr flipped_rect, IntPtr final_rect, bool flipped_x, bool flipped_y, IntPtr user_data);


/// <summary>
/// <para>
/// The ::pick-embedded-child signal is emitted to find an embedded
/// child at the given position.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="x">
/// x coordinate in the window
/// </param>
/// <param name="y">
/// y coordinate in the window
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// the #GdkWindow of the
///     embedded child at @x, @y, or %NULL
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.Gdk.GdkWindowHandle pick_embedded_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle self, double x, double y, IntPtr user_data);


/// <summary>
/// <para>
/// The ::to-embedder signal is emitted to translate coordinates
/// in an offscreen window to its embedder.
/// </para>
/// <para>
/// See also #GdkWindow::from-embedder.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="offscreen_x">
/// x coordinate in the offscreen window
/// </param>
/// <param name="offscreen_y">
/// y coordinate in the offscreen window
/// </param>
/// <param name="embedder_x">
/// return location for the x
///     coordinate in the embedder window
/// </param>
/// <param name="embedder_y">
/// return location for the y
///     coordinate in the embedder window
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void to_embedder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle self, double offscreen_x, double offscreen_y, out double embedder_x, out double embedder_y, IntPtr user_data);

}


public static class GdkWindowHandleExtensions
{
/// <summary>
/// <para>
/// Adds an event filter to @window, allowing you to intercept events
/// before they reach GDK. This is a low-level operation and makes it
/// easy to break GDK and/or GTK+, so you have to know what you're
/// doing. Pass %NULL for @window to get all events for all windows,
/// instead of events for a specific window.
/// </para>
/// <para>
/// If you are interested in X GenericEvents, bear in mind that
/// XGetEventData() has been already called on the event, and
/// XFreeEventData() must not be called within @function.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="function">
/// filter callback
/// </param>
/// <param name="data">
/// data to pass to filter callback
/// </param>

	public static T AddFilter<T>(this T window, MentorLake.Gdk.GdkFilterFunc function, IntPtr data) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_add_filter(window, function, data);
		return window;
	}

/// <summary>
/// <para>
/// Emits a short beep associated to @window in the appropriate
/// display, if supported. Otherwise, emits a short beep on
/// the display just as gdk_display_beep().
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow
/// </param>

	public static T Beep<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_beep(window);
		return window;
	}

/// <summary>
/// <para>
/// Indicates that you are beginning the process of redrawing @region
/// on @window, and provides you with a #GdkDrawingContext.
/// </para>
/// <para>
/// If @window is a top level #GdkWindow, backed by a native window
/// implementation, a backing store (offscreen buffer) large enough to
/// contain @region will be created. The backing store will be initialized
/// with the background color or background surface for @window. Then, all
/// drawing operations performed on @window will be diverted to the
/// backing store. When you call gdk_window_end_frame(), the contents of
/// the backing store will be copied to @window, making it visible
/// on screen. Only the part of @window contained in @region will be
/// modified; that is, drawing operations are clipped to @region.
/// </para>
/// <para>
/// The net result of all this is to remove flicker, because the user
/// sees the finished product appear all at once when you call
/// gdk_window_end_draw_frame(). If you draw to @window directly without
/// calling gdk_window_begin_draw_frame(), the user may see flicker
/// as individual drawing operations are performed in sequence.
/// </para>
/// <para>
/// When using GTK+, the widget system automatically places calls to
/// gdk_window_begin_draw_frame() and gdk_window_end_draw_frame() around
/// emissions of the `GtkWidget::draw` signal. That is, if you’re
/// drawing the contents of the widget yourself, you can assume that the
/// widget has a cleared background, is already set as the clip region,
/// and already has a backing store. Therefore in most cases, application
/// code in GTK does not need to call gdk_window_begin_draw_frame()
/// explicitly.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="region">
/// a Cairo region
/// </param>
/// <return>
/// a #GdkDrawingContext context that should be
///   used to draw the contents of the window; the returned context is owned
///   by GDK.
/// </return>

	public static MentorLake.Gdk.GdkDrawingContextHandle BeginDrawFrame(this MentorLake.Gdk.GdkWindowHandle window, MentorLake.cairo.cairo_region_tHandle region)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_begin_draw_frame(window, region);
	}

/// <summary>
/// <para>
/// Begins a window move operation (for a toplevel window).
/// </para>
/// <para>
/// This function assumes that the drag is controlled by the
/// client pointer device, use gdk_window_begin_move_drag_for_device()
/// to begin a drag with a different device.
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow
/// </param>
/// <param name="button">
/// the button being used to drag, or 0 for a keyboard-initiated drag
/// </param>
/// <param name="root_x">
/// root window X coordinate of mouse click that began the drag
/// </param>
/// <param name="root_y">
/// root window Y coordinate of mouse click that began the drag
/// </param>
/// <param name="timestamp">
/// timestamp of mouse click that began the drag
/// </param>

	public static T BeginMoveDrag<T>(this T window, int button, int root_x, int root_y, uint timestamp) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_begin_move_drag(window, button, root_x, root_y, timestamp);
		return window;
	}

/// <summary>
/// <para>
/// Begins a window move operation (for a toplevel window).
/// You might use this function to implement a “window move grip,” for
/// example. The function works best with window managers that support the
/// [Extended Window Manager Hints](http://www.freedesktop.org/Standards/wm-spec)
/// but has a fallback implementation for other window managers.
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow
/// </param>
/// <param name="device">
/// the device used for the operation
/// </param>
/// <param name="button">
/// the button being used to drag, or 0 for a keyboard-initiated drag
/// </param>
/// <param name="root_x">
/// root window X coordinate of mouse click that began the drag
/// </param>
/// <param name="root_y">
/// root window Y coordinate of mouse click that began the drag
/// </param>
/// <param name="timestamp">
/// timestamp of mouse click that began the drag
/// </param>

	public static T BeginMoveDragForDevice<T>(this T window, MentorLake.Gdk.GdkDeviceHandle device, int button, int root_x, int root_y, uint timestamp) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_begin_move_drag_for_device(window, device, button, root_x, root_y, timestamp);
		return window;
	}

/// <summary>
/// <para>
/// A convenience wrapper around gdk_window_begin_paint_region() which
/// creates a rectangular region for you. See
/// gdk_window_begin_paint_region() for details.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="rectangle">
/// rectangle you intend to draw to
/// </param>

	public static T BeginPaintRect<T>(this T window, MentorLake.Gdk.GdkRectangleHandle rectangle) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_begin_paint_rect(window, rectangle);
		return window;
	}

/// <summary>
/// <para>
/// Indicates that you are beginning the process of redrawing @region.
/// A backing store (offscreen buffer) large enough to contain @region
/// will be created. The backing store will be initialized with the
/// background color or background surface for @window. Then, all
/// drawing operations performed on @window will be diverted to the
/// backing store.  When you call gdk_window_end_paint(), the backing
/// store will be copied to @window, making it visible onscreen. Only
/// the part of @window contained in @region will be modified; that is,
/// drawing operations are clipped to @region.
/// </para>
/// <para>
/// The net result of all this is to remove flicker, because the user
/// sees the finished product appear all at once when you call
/// gdk_window_end_paint(). If you draw to @window directly without
/// calling gdk_window_begin_paint_region(), the user may see flicker
/// as individual drawing operations are performed in sequence.  The
/// clipping and background-initializing features of
/// gdk_window_begin_paint_region() are conveniences for the
/// programmer, so you can avoid doing that work yourself.
/// </para>
/// <para>
/// When using GTK+, the widget system automatically places calls to
/// gdk_window_begin_paint_region() and gdk_window_end_paint() around
/// emissions of the expose_event signal. That is, if you’re writing an
/// expose event handler, you can assume that the exposed area in
/// #GdkEventExpose has already been cleared to the window background,
/// is already set as the clip region, and already has a backing store.
/// Therefore in most cases, application code need not call
/// gdk_window_begin_paint_region(). (You can disable the automatic
/// calls around expose events on a widget-by-widget basis by calling
/// gtk_widget_set_double_buffered().)
/// </para>
/// <para>
/// If you call this function multiple times before calling the
/// matching gdk_window_end_paint(), the backing stores are pushed onto
/// a stack. gdk_window_end_paint() copies the topmost backing store
/// onscreen, subtracts the topmost region from all other regions in
/// the stack, and pops the stack. All drawing operations affect only
/// the topmost backing store in the stack. One matching call to
/// gdk_window_end_paint() is required for each call to
/// gdk_window_begin_paint_region().
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="region">
/// region you intend to draw to
/// </param>

	public static T BeginPaintRegion<T>(this T window, MentorLake.cairo.cairo_region_tHandle region) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_begin_paint_region(window, region);
		return window;
	}

/// <summary>
/// <para>
/// Begins a window resize operation (for a toplevel window).
/// </para>
/// <para>
/// This function assumes that the drag is controlled by the
/// client pointer device, use gdk_window_begin_resize_drag_for_device()
/// to begin a drag with a different device.
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow
/// </param>
/// <param name="edge">
/// the edge or corner from which the drag is started
/// </param>
/// <param name="button">
/// the button being used to drag, or 0 for a keyboard-initiated drag
/// </param>
/// <param name="root_x">
/// root window X coordinate of mouse click that began the drag
/// </param>
/// <param name="root_y">
/// root window Y coordinate of mouse click that began the drag
/// </param>
/// <param name="timestamp">
/// timestamp of mouse click that began the drag (use gdk_event_get_time())
/// </param>

	public static T BeginResizeDrag<T>(this T window, MentorLake.Gdk.GdkWindowEdge edge, int button, int root_x, int root_y, uint timestamp) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_begin_resize_drag(window, edge, button, root_x, root_y, timestamp);
		return window;
	}

/// <summary>
/// <para>
/// Begins a window resize operation (for a toplevel window).
/// You might use this function to implement a “window resize grip,” for
/// example; in fact #GtkStatusbar uses it. The function works best
/// with window managers that support the
/// [Extended Window Manager Hints](http://www.freedesktop.org/Standards/wm-spec)
/// but has a fallback implementation for other window managers.
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow
/// </param>
/// <param name="edge">
/// the edge or corner from which the drag is started
/// </param>
/// <param name="device">
/// the device used for the operation
/// </param>
/// <param name="button">
/// the button being used to drag, or 0 for a keyboard-initiated drag
/// </param>
/// <param name="root_x">
/// root window X coordinate of mouse click that began the drag
/// </param>
/// <param name="root_y">
/// root window Y coordinate of mouse click that began the drag
/// </param>
/// <param name="timestamp">
/// timestamp of mouse click that began the drag (use gdk_event_get_time())
/// </param>

	public static T BeginResizeDragForDevice<T>(this T window, MentorLake.Gdk.GdkWindowEdge edge, MentorLake.Gdk.GdkDeviceHandle device, int button, int root_x, int root_y, uint timestamp) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_begin_resize_drag_for_device(window, edge, device, button, root_x, root_y, timestamp);
		return window;
	}

/// <summary>
/// <para>
/// Does nothing, present only for compatiblity.
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow
/// </param>

	public static T ConfigureFinished<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_configure_finished(window);
		return window;
	}

/// <summary>
/// <para>
/// Transforms window coordinates from a parent window to a child
/// window, where the parent window is the normal parent as returned by
/// gdk_window_get_parent() for normal windows, and the window's
/// embedder as returned by gdk_offscreen_window_get_embedder() for
/// offscreen windows.
/// </para>
/// <para>
/// For normal windows, calling this function is equivalent to subtracting
/// the return values of gdk_window_get_position() from the parent coordinates.
/// For offscreen windows however (which can be arbitrarily transformed),
/// this function calls the GdkWindow::from-embedder: signal to translate
/// the coordinates.
/// </para>
/// <para>
/// You should always use this function when writing generic code that
/// walks down a window hierarchy.
/// </para>
/// <para>
/// See also: gdk_window_coords_to_parent()
/// </para>
/// </summary>

/// <param name="window">
/// a child window
/// </param>
/// <param name="parent_x">
/// X coordinate in parent’s coordinate system
/// </param>
/// <param name="parent_y">
/// Y coordinate in parent’s coordinate system
/// </param>
/// <param name="x">
/// return location for X coordinate in child’s coordinate system
/// </param>
/// <param name="y">
/// return location for Y coordinate in child’s coordinate system
/// </param>

	public static T CoordsFromParent<T>(this T window, double parent_x, double parent_y, out double x, out double y) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_coords_from_parent(window, parent_x, parent_y, out x, out y);
		return window;
	}

/// <summary>
/// <para>
/// Transforms window coordinates from a child window to its parent
/// window, where the parent window is the normal parent as returned by
/// gdk_window_get_parent() for normal windows, and the window's
/// embedder as returned by gdk_offscreen_window_get_embedder() for
/// offscreen windows.
/// </para>
/// <para>
/// For normal windows, calling this function is equivalent to adding
/// the return values of gdk_window_get_position() to the child coordinates.
/// For offscreen windows however (which can be arbitrarily transformed),
/// this function calls the GdkWindow::to-embedder: signal to translate
/// the coordinates.
/// </para>
/// <para>
/// You should always use this function when writing generic code that
/// walks up a window hierarchy.
/// </para>
/// <para>
/// See also: gdk_window_coords_from_parent()
/// </para>
/// </summary>

/// <param name="window">
/// a child window
/// </param>
/// <param name="x">
/// X coordinate in child’s coordinate system
/// </param>
/// <param name="y">
/// Y coordinate in child’s coordinate system
/// </param>
/// <param name="parent_x">
/// return location for X coordinate
/// in parent’s coordinate system, or %NULL
/// </param>
/// <param name="parent_y">
/// return location for Y coordinate
/// in parent’s coordinate system, or %NULL
/// </param>

	public static T CoordsToParent<T>(this T window, double x, double y, out double parent_x, out double parent_y) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_coords_to_parent(window, x, y, out parent_x, out parent_y);
		return window;
	}

/// <summary>
/// <para>
/// Creates a new #GdkGLContext matching the
/// framebuffer format to the visual of the #GdkWindow. The context
/// is disconnected from any particular window or surface.
/// </para>
/// <para>
/// If the creation of the #GdkGLContext failed, @error will be set.
/// </para>
/// <para>
/// Before using the returned #GdkGLContext, you will need to
/// call gdk_gl_context_make_current() or gdk_gl_context_realize().
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <return>
/// the newly created #GdkGLContext, or
/// %NULL on error
/// </return>

	public static MentorLake.Gdk.GdkGLContextHandle CreateGlContext(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		var externCallResult = GdkWindowHandleExterns.gdk_window_create_gl_context(window, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Create a new image surface that is efficient to draw on the
/// given @window.
/// </para>
/// <para>
/// Initially the surface contents are all 0 (transparent if contents
/// have transparency, black otherwise.)
/// </para>
/// <para>
/// The @width and @height of the new surface are not affected by
/// the scaling factor of the @window, or by the @scale argument; they
/// are the size of the surface in device pixels. If you wish to create
/// an image surface capable of holding the contents of @window you can
/// use:
/// </para>
/// <para>
/// |[<!-- language="C" -->
///   int scale = gdk_window_get_scale_factor (window);
///   int width = gdk_window_get_width (window) * scale;
///   int height = gdk_window_get_height (window) * scale;
/// </para>
/// <para>
///   // format is set elsewhere
///   cairo_surface_t *surface =
///     gdk_window_create_similar_image_surface (window,
///                                              format,
///                                              width, height,
///                                              scale);
/// ]|
/// </para>
/// <para>
/// Note that unlike cairo_surface_create_similar_image(), the new
/// surface's device scale is set to @scale, or to the scale factor of
/// @window if @scale is 0.
/// </para>
/// </summary>

/// <param name="window">
/// window to make new surface similar to, or
///   %NULL if none
/// </param>
/// <param name="format">
/// the format for the new surface
/// </param>
/// <param name="width">
/// width of the new surface
/// </param>
/// <param name="height">
/// height of the new surface
/// </param>
/// <param name="scale">
/// the scale of the new surface, or 0 to use same as @window
/// </param>
/// <return>
/// a pointer to the newly allocated surface. The caller
/// owns the surface and should call cairo_surface_destroy() when done
/// with it.
/// 
/// This function always returns a valid pointer, but it will return a
/// pointer to a “nil” surface if @other is already in an error state
/// or any other error occurs.
/// </return>

	public static MentorLake.cairo.cairo_surface_tHandle CreateSimilarImageSurface(this MentorLake.Gdk.GdkWindowHandle window, MentorLake.cairo.cairo_format_t format, int width, int height, int scale)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_create_similar_image_surface(window, format, width, height, scale);
	}

/// <summary>
/// <para>
/// Create a new surface that is as compatible as possible with the
/// given @window. For example the new surface will have the same
/// fallback resolution and font options as @window. Generally, the new
/// surface will also use the same backend as @window, unless that is
/// not possible for some reason. The type of the returned surface may
/// be examined with cairo_surface_get_type().
/// </para>
/// <para>
/// Initially the surface contents are all 0 (transparent if contents
/// have transparency, black otherwise.)
/// </para>
/// </summary>

/// <param name="window">
/// window to make new surface similar to
/// </param>
/// <param name="content">
/// the content for the new surface
/// </param>
/// <param name="width">
/// width of the new surface
/// </param>
/// <param name="height">
/// height of the new surface
/// </param>
/// <return>
/// a pointer to the newly allocated surface. The caller
/// owns the surface and should call cairo_surface_destroy() when done
/// with it.
/// 
/// This function always returns a valid pointer, but it will return a
/// pointer to a “nil” surface if @other is already in an error state
/// or any other error occurs.
/// </return>

	public static MentorLake.cairo.cairo_surface_tHandle CreateSimilarSurface(this MentorLake.Gdk.GdkWindowHandle window, MentorLake.cairo.cairo_content_t content, int width, int height)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_create_similar_surface(window, content, width, height);
	}

/// <summary>
/// <para>
/// Attempt to deiconify (unminimize) @window. On X11 the window manager may
/// choose to ignore the request to deiconify. When using GTK+,
/// use gtk_window_deiconify() instead of the #GdkWindow variant. Or better yet,
/// you probably want to use gtk_window_present_with_time(), which raises the window, focuses it,
/// unminimizes it, and puts it on the current desktop.
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow
/// </param>

	public static T Deiconify<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_deiconify(window);
		return window;
	}

/// <summary>
/// <para>
/// Destroys the window system resources associated with @window and decrements @window's
/// reference count. The window system resources for all children of @window are also
/// destroyed, but the children’s reference counts are not decremented.
/// </para>
/// <para>
/// Note that a window will not be destroyed automatically when its reference count
/// reaches zero. You must call this function yourself before that happens.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>

	public static T Destroy<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_destroy(window);
		return window;
	}


/// <param name="window">
/// </param>

	public static T DestroyNotify<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_destroy_notify(window);
		return window;
	}

/// <summary>
/// <para>
/// Does nothing, present only for compatiblity.
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow
/// </param>

	public static T EnableSynchronizedConfigure<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_enable_synchronized_configure(window);
		return window;
	}

/// <summary>
/// <para>
/// Indicates that the drawing of the contents of @window started with
/// gdk_window_begin_frame() has been completed.
/// </para>
/// <para>
/// This function will take care of destroying the #GdkDrawingContext.
/// </para>
/// <para>
/// It is an error to call this function without a matching
/// gdk_window_begin_frame() first.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="context">
/// the #GdkDrawingContext created by gdk_window_begin_draw_frame()
/// </param>

	public static T EndDrawFrame<T>(this T window, MentorLake.Gdk.GdkDrawingContextHandle context) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_end_draw_frame(window, context);
		return window;
	}

/// <summary>
/// <para>
/// Indicates that the backing store created by the most recent call
/// to gdk_window_begin_paint_region() should be copied onscreen and
/// deleted, leaving the next-most-recent backing store or no backing
/// store at all as the active paint region. See
/// gdk_window_begin_paint_region() for full details.
/// </para>
/// <para>
/// It is an error to call this function without a matching
/// gdk_window_begin_paint_region() first.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>

	public static T EndPaint<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_end_paint(window);
		return window;
	}

/// <summary>
/// <para>
/// Tries to ensure that there is a window-system native window for this
/// GdkWindow. This may fail in some situations, returning %FALSE.
/// </para>
/// <para>
/// Offscreen window and children of them can never have native windows.
/// </para>
/// <para>
/// Some backends may not support native child windows.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <return>
/// %TRUE if the window has a native window, %FALSE otherwise
/// </return>

	public static bool EnsureNative(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_ensure_native(window);
	}

/// <summary>
/// <para>
/// This function does nothing.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>

	public static T Flush<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_flush(window);
		return window;
	}

/// <summary>
/// <para>
/// Sets keyboard focus to @window. In most cases, gtk_window_present_with_time()
/// should be used on a #GtkWindow, rather than calling this function.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="timestamp">
/// timestamp of the event triggering the window focus
/// </param>

	public static T Focus<T>(this T window, uint timestamp) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_focus(window, timestamp);
		return window;
	}

/// <summary>
/// <para>
/// Temporarily freezes a window and all its descendants such that it won't
/// receive expose events.  The window will begin receiving expose events
/// again when gdk_window_thaw_toplevel_updates_libgtk_only() is called. If
/// gdk_window_freeze_toplevel_updates_libgtk_only()
/// has been called more than once,
/// gdk_window_thaw_toplevel_updates_libgtk_only() must be called
/// an equal number of times to begin processing exposes.
/// </para>
/// <para>
/// This function is not part of the GDK public API and is only
/// for use by GTK+.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>

	public static T FreezeToplevelUpdatesLibgtkOnly<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_freeze_toplevel_updates_libgtk_only(window);
		return window;
	}

/// <summary>
/// <para>
/// Temporarily freezes a window such that it won’t receive expose
/// events.  The window will begin receiving expose events again when
/// gdk_window_thaw_updates() is called. If gdk_window_freeze_updates()
/// has been called more than once, gdk_window_thaw_updates() must be called
/// an equal number of times to begin processing exposes.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>

	public static T FreezeUpdates<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_freeze_updates(window);
		return window;
	}

/// <summary>
/// <para>
/// Moves the window into fullscreen mode. This means the
/// window covers the entire screen and is above any panels
/// or task bars.
/// </para>
/// <para>
/// If the window was already fullscreen, then this function does nothing.
/// </para>
/// <para>
/// On X11, asks the window manager to put @window in a fullscreen
/// state, if the window manager supports this operation. Not all
/// window managers support this, and some deliberately ignore it or
/// don’t have a concept of “fullscreen”; so you can’t rely on the
/// fullscreenification actually happening. But it will happen with
/// most standard window managers, and GDK makes a best effort to get
/// it to happen.
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow
/// </param>

	public static T Fullscreen<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_fullscreen(window);
		return window;
	}

/// <summary>
/// <para>
/// Moves the window into fullscreen mode on the given monitor. This means
/// the window covers the entire screen and is above any panels or task bars.
/// </para>
/// <para>
/// If the window was already fullscreen, then this function does nothing.
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow
/// </param>
/// <param name="monitor">
/// Which monitor to display fullscreen on.
/// </param>

	public static T FullscreenOnMonitor<T>(this T window, int monitor) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_fullscreen_on_monitor(window, monitor);
		return window;
	}

/// <summary>
/// <para>
/// This function informs GDK that the geometry of an embedded
/// offscreen window has changed. This is necessary for GDK to keep
/// track of which offscreen window the pointer is in.
/// </para>
/// </summary>

/// <param name="window">
/// an embedded offscreen #GdkWindow
/// </param>

	public static T GeometryChanged<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_geometry_changed(window);
		return window;
	}

/// <summary>
/// <para>
/// Determines whether or not the desktop environment shuld be hinted that
/// the window does not want to receive input focus.
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow.
/// </param>
/// <return>
/// whether or not the window should receive input focus.
/// </return>

	public static bool GetAcceptFocus(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_accept_focus(window);
	}

/// <summary>
/// <para>
/// Gets the pattern used to clear the background on @window.
/// </para>
/// </summary>

/// <param name="window">
/// a window
/// </param>
/// <return>
/// The pattern to use for the
/// background or %NULL if there is no background.
/// </return>

	public static MentorLake.cairo.cairo_pattern_tHandle GetBackgroundPattern(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_background_pattern(window);
	}

/// <summary>
/// <para>
/// Gets the list of children of @window known to GDK.
/// This function only returns children created via GDK,
/// so for example it’s useless when used with the root window;
/// it only returns windows an application created itself.
/// </para>
/// <para>
/// The returned list must be freed, but the elements in the
/// list need not be.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <return>
/// 
///     list of child windows inside @window
/// </return>

	public static MentorLake.GLib.GListHandle GetChildren(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_children(window);
	}

/// <summary>
/// <para>
/// Gets the list of children of @window known to GDK with a
/// particular @user_data set on it.
/// </para>
/// <para>
/// The returned list must be freed, but the elements in the
/// list need not be.
/// </para>
/// <para>
/// The list is returned in (relative) stacking order, i.e. the
/// lowest window is first.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="user_data">
/// user data to look for
/// </param>
/// <return>
/// 
///     list of child windows inside @window
/// </return>

	public static MentorLake.GLib.GListHandle GetChildrenWithUserData(this MentorLake.Gdk.GdkWindowHandle window, IntPtr user_data)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_children_with_user_data(window, user_data);
	}

/// <summary>
/// <para>
/// Computes the region of a window that potentially can be written
/// to by drawing primitives. This region may not take into account
/// other factors such as if the window is obscured by other windows,
/// but no area outside of this region will be affected by drawing
/// primitives.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <return>
/// a #cairo_region_t. This must be freed with cairo_region_destroy()
///          when you are done.
/// </return>

	public static MentorLake.cairo.cairo_region_tHandle GetClipRegion(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_clip_region(window);
	}

/// <summary>
/// <para>
/// Determines whether @window is composited.
/// </para>
/// <para>
/// See gdk_window_set_composited().
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <return>
/// %TRUE if the window is composited.
/// </return>

	public static bool GetComposited(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_composited(window);
	}

/// <summary>
/// <para>
/// Retrieves a #GdkCursor pointer for the cursor currently set on the
/// specified #GdkWindow, or %NULL.  If the return value is %NULL then
/// there is no custom cursor set on the specified window, and it is
/// using the cursor for its parent window.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <return>
/// a #GdkCursor, or %NULL. The
///   returned object is owned by the #GdkWindow and should not be
///   unreferenced directly. Use gdk_window_set_cursor() to unset the
///   cursor of the window
/// </return>

	public static MentorLake.Gdk.GdkCursorHandle GetCursor(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_cursor(window);
	}

/// <summary>
/// <para>
/// Returns the decorations set on the GdkWindow with
/// gdk_window_set_decorations().
/// </para>
/// </summary>

/// <param name="window">
/// The toplevel #GdkWindow to get the decorations from
/// </param>
/// <param name="decorations">
/// The window decorations will be written here
/// </param>
/// <return>
/// %TRUE if the window has decorations set, %FALSE otherwise.
/// </return>

	public static bool GetDecorations(this MentorLake.Gdk.GdkWindowHandle window, out MentorLake.Gdk.GdkWMDecoration decorations)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_decorations(window, out decorations);
	}

/// <summary>
/// <para>
/// Retrieves a #GdkCursor pointer for the @device currently set on the
/// specified #GdkWindow, or %NULL.  If the return value is %NULL then
/// there is no custom cursor set on the specified window, and it is
/// using the cursor for its parent window.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow.
/// </param>
/// <param name="device">
/// a master, pointer #GdkDevice.
/// </param>
/// <return>
/// a #GdkCursor, or %NULL. The
///   returned object is owned by the #GdkWindow and should not be
///   unreferenced directly. Use gdk_window_set_cursor() to unset the
///   cursor of the window
/// </return>

	public static MentorLake.Gdk.GdkCursorHandle GetDeviceCursor(this MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_device_cursor(window, device);
	}

/// <summary>
/// <para>
/// Returns the event mask for @window corresponding to an specific device.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow.
/// </param>
/// <param name="device">
/// a #GdkDevice.
/// </param>
/// <return>
/// device event mask for @window
/// </return>

	public static MentorLake.Gdk.GdkEventMask GetDeviceEvents(this MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_device_events(window, device);
	}

/// <summary>
/// <para>
/// Obtains the current device position and modifier state.
/// The position is given in coordinates relative to the upper left
/// corner of @window.
/// </para>
/// <para>
/// Use gdk_window_get_device_position_double() if you need subpixel precision.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow.
/// </param>
/// <param name="device">
/// pointer #GdkDevice to query to.
/// </param>
/// <param name="x">
/// return location for the X coordinate of @device, or %NULL.
/// </param>
/// <param name="y">
/// return location for the Y coordinate of @device, or %NULL.
/// </param>
/// <param name="mask">
/// return location for the modifier mask, or %NULL.
/// </param>
/// <return>
/// The window underneath @device
/// (as with gdk_device_get_window_at_position()), or %NULL if the
/// window is not known to GDK.
/// </return>

	public static MentorLake.Gdk.GdkWindowHandle GetDevicePosition(this MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkDeviceHandle device, out int x, out int y, out MentorLake.Gdk.GdkModifierType mask)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_device_position(window, device, out x, out y, out mask);
	}

/// <summary>
/// <para>
/// Obtains the current device position in doubles and modifier state.
/// The position is given in coordinates relative to the upper left
/// corner of @window.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow.
/// </param>
/// <param name="device">
/// pointer #GdkDevice to query to.
/// </param>
/// <param name="x">
/// return location for the X coordinate of @device, or %NULL.
/// </param>
/// <param name="y">
/// return location for the Y coordinate of @device, or %NULL.
/// </param>
/// <param name="mask">
/// return location for the modifier mask, or %NULL.
/// </param>
/// <return>
/// The window underneath @device
/// (as with gdk_device_get_window_at_position()), or %NULL if the
/// window is not known to GDK.
/// </return>

	public static MentorLake.Gdk.GdkWindowHandle GetDevicePositionDouble(this MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkDeviceHandle device, out double x, out double y, out MentorLake.Gdk.GdkModifierType mask)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_device_position_double(window, device, out x, out y, out mask);
	}

/// <summary>
/// <para>
/// Gets the #GdkDisplay associated with a #GdkWindow.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <return>
/// the #GdkDisplay associated with @window
/// </return>

	public static MentorLake.Gdk.GdkDisplayHandle GetDisplay(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_display(window);
	}

/// <summary>
/// <para>
/// Finds out the DND protocol supported by a window.
/// </para>
/// </summary>

/// <param name="window">
/// the destination window
/// </param>
/// <param name="target">
/// location of the window
///    where the drop should happen. This may be @window or a proxy window,
///    or %NULL if @window does not support Drag and Drop.
/// </param>
/// <return>
/// the supported DND protocol.
/// </return>

	public static MentorLake.Gdk.GdkDragProtocol GetDragProtocol(this MentorLake.Gdk.GdkWindowHandle window, out MentorLake.Gdk.GdkWindowHandle target)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_drag_protocol(window, out target);
	}

/// <summary>
/// <para>
/// Obtains the parent of @window, as known to GDK. Works like
/// gdk_window_get_parent() for normal windows, but returns the
/// window’s embedder for offscreen windows.
/// </para>
/// <para>
/// See also: gdk_offscreen_window_get_embedder()
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <return>
/// effective parent of @window
/// </return>

	public static MentorLake.Gdk.GdkWindowHandle GetEffectiveParent(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_effective_parent(window);
	}

/// <summary>
/// <para>
/// Gets the toplevel window that’s an ancestor of @window.
/// </para>
/// <para>
/// Works like gdk_window_get_toplevel(), but treats an offscreen window's
/// embedder as its parent, using gdk_window_get_effective_parent().
/// </para>
/// <para>
/// See also: gdk_offscreen_window_get_embedder()
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <return>
/// the effective toplevel window containing @window
/// </return>

	public static MentorLake.Gdk.GdkWindowHandle GetEffectiveToplevel(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_effective_toplevel(window);
	}

/// <summary>
/// <para>
/// Get the current event compression setting for this window.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <return>
/// %TRUE if motion events will be compressed
/// </return>

	public static bool GetEventCompression(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_event_compression(window);
	}

/// <summary>
/// <para>
/// Gets the event mask for @window for all master input devices. See
/// gdk_window_set_events().
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <return>
/// event mask for @window
/// </return>

	public static MentorLake.Gdk.GdkEventMask GetEvents(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_events(window);
	}

/// <summary>
/// <para>
/// Determines whether or not the desktop environment should be hinted that the
/// window does not want to receive input focus when it is mapped.
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow.
/// </param>
/// <return>
/// whether or not the window wants to receive input focus when
/// it is mapped.
/// </return>

	public static bool GetFocusOnMap(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_focus_on_map(window);
	}

/// <summary>
/// <para>
/// Gets the frame clock for the window. The frame clock for a window
/// never changes unless the window is reparented to a new toplevel
/// window.
/// </para>
/// </summary>

/// <param name="window">
/// window to get frame clock for
/// </param>
/// <return>
/// the frame clock
/// </return>

	public static MentorLake.Gdk.GdkFrameClockHandle GetFrameClock(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_frame_clock(window);
	}

/// <summary>
/// <para>
/// Obtains the bounding box of the window, including window manager
/// titlebar/borders if any. The frame position is given in root window
/// coordinates. To get the position of the window itself (rather than
/// the frame) in root window coordinates, use gdk_window_get_origin().
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow
/// </param>
/// <param name="rect">
/// rectangle to fill with bounding box of the window frame
/// </param>

	public static T GetFrameExtents<T>(this T window, out MentorLake.Gdk.GdkRectangle rect) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_get_frame_extents(window, out rect);
		return window;
	}

/// <summary>
/// <para>
/// Obtains the #GdkFullscreenMode of the @window.
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow
/// </param>
/// <return>
/// The #GdkFullscreenMode applied to the window when fullscreen.
/// </return>

	public static MentorLake.Gdk.GdkFullscreenMode GetFullscreenMode(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_fullscreen_mode(window);
	}

/// <summary>
/// <para>
/// Any of the return location arguments to this function may be %NULL,
/// if you aren’t interested in getting the value of that field.
/// </para>
/// <para>
/// The X and Y coordinates returned are relative to the parent window
/// of @window, which for toplevels usually means relative to the
/// window decorations (titlebar, etc.) rather than relative to the
/// root window (screen-size background window).
/// </para>
/// <para>
/// On the X11 platform, the geometry is obtained from the X server,
/// so reflects the latest position of @window; this may be out-of-sync
/// with the position of @window delivered in the most-recently-processed
/// #GdkEventConfigure. gdk_window_get_position() in contrast gets the
/// position from the most recent configure event.
/// </para>
/// <para>
/// Note: If @window is not a toplevel, it is much better
/// to call gdk_window_get_position(), gdk_window_get_width() and
/// gdk_window_get_height() instead, because it avoids the roundtrip to
/// the X server and because these functions support the full 32-bit
/// coordinate space, whereas gdk_window_get_geometry() is restricted to
/// the 16-bit coordinates of X11.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="x">
/// return location for X coordinate of window (relative to its parent)
/// </param>
/// <param name="y">
/// return location for Y coordinate of window (relative to its parent)
/// </param>
/// <param name="width">
/// return location for width of window
/// </param>
/// <param name="height">
/// return location for height of window
/// </param>

	public static T GetGeometry<T>(this T window, out int x, out int y, out int width, out int height) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_get_geometry(window, out x, out y, out width, out height);
		return window;
	}

/// <summary>
/// <para>
/// Returns the group leader window for @window. See gdk_window_set_group().
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow
/// </param>
/// <return>
/// the group leader window for @window
/// </return>

	public static MentorLake.Gdk.GdkWindowHandle GetGroup(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_group(window);
	}

/// <summary>
/// <para>
/// Returns the height of the given @window.
/// </para>
/// <para>
/// On the X11 platform the returned size is the size reported in the
/// most-recently-processed configure event, rather than the current
/// size on the X server.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <return>
/// The height of @window
/// </return>

	public static int GetHeight(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_height(window);
	}

/// <summary>
/// <para>
/// Determines whether or not the window manager is hinted that @window
/// has modal behaviour.
/// </para>
/// </summary>

/// <param name="window">
/// A toplevel #GdkWindow.
/// </param>
/// <return>
/// whether or not the window has the modal hint set.
/// </return>

	public static bool GetModalHint(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_modal_hint(window);
	}

/// <summary>
/// <para>
/// Obtains the position of a window in root window coordinates.
/// (Compare with gdk_window_get_position() and
/// gdk_window_get_geometry() which return the position of a window
/// relative to its parent window.)
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="x">
/// return location for X coordinate
/// </param>
/// <param name="y">
/// return location for Y coordinate
/// </param>
/// <return>
/// not meaningful, ignore
/// </return>

	public static int GetOrigin(this MentorLake.Gdk.GdkWindowHandle window, out int x, out int y)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_origin(window, out x, out y);
	}

/// <summary>
/// <para>
/// Obtains the parent of @window, as known to GDK. Does not query the
/// X server; thus this returns the parent as passed to gdk_window_new(),
/// not the actual parent. This should never matter unless you’re using
/// Xlib calls mixed with GDK calls on the X11 platform. It may also
/// matter for toplevel windows, because the window manager may choose
/// to reparent them.
/// </para>
/// <para>
/// Note that you should use gdk_window_get_effective_parent() when
/// writing generic code that walks up a window hierarchy, because
/// gdk_window_get_parent() will most likely not do what you expect if
/// there are offscreen windows in the hierarchy.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <return>
/// parent of @window
/// </return>

	public static MentorLake.Gdk.GdkWindowHandle GetParent(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_parent(window);
	}

/// <summary>
/// <para>
/// Returns whether input to the window is passed through to the window
/// below.
/// </para>
/// <para>
/// See gdk_window_set_pass_through() for details
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>

	public static bool GetPassThrough(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_pass_through(window);
	}

/// <summary>
/// <para>
/// Obtains the current pointer position and modifier state.
/// The position is given in coordinates relative to the upper left
/// corner of @window.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="x">
/// return location for X coordinate of pointer or %NULL to not
///      return the X coordinate
/// </param>
/// <param name="y">
/// return location for Y coordinate of pointer or %NULL to not
///      return the Y coordinate
/// </param>
/// <param name="mask">
/// return location for modifier mask or %NULL to not return the
///      modifier mask
/// </param>
/// <return>
/// the window containing the
/// pointer (as with gdk_window_at_pointer()), or %NULL if the window
/// containing the pointer isn’t known to GDK
/// </return>

	public static MentorLake.Gdk.GdkWindowHandle GetPointer(this MentorLake.Gdk.GdkWindowHandle window, out int x, out int y, out MentorLake.Gdk.GdkModifierType mask)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_pointer(window, out x, out y, out mask);
	}

/// <summary>
/// <para>
/// Obtains the position of the window as reported in the
/// most-recently-processed #GdkEventConfigure. Contrast with
/// gdk_window_get_geometry() which queries the X server for the
/// current window position, regardless of which events have been
/// received or processed.
/// </para>
/// <para>
/// The position coordinates are relative to the window’s parent window.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="x">
/// X coordinate of window
/// </param>
/// <param name="y">
/// Y coordinate of window
/// </param>

	public static T GetPosition<T>(this T window, out int x, out int y) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_get_position(window, out x, out y);
		return window;
	}

/// <summary>
/// <para>
/// Obtains the position of a window position in root
/// window coordinates. This is similar to
/// gdk_window_get_origin() but allows you to pass
/// in any position in the window, not just the origin.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="x">
/// X coordinate in window
/// </param>
/// <param name="y">
/// Y coordinate in window
/// </param>
/// <param name="root_x">
/// return location for X coordinate
/// </param>
/// <param name="root_y">
/// return location for Y coordinate
/// </param>

	public static T GetRootCoords<T>(this T window, int x, int y, out int root_x, out int root_y) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_get_root_coords(window, x, y, out root_x, out root_y);
		return window;
	}

/// <summary>
/// <para>
/// Obtains the top-left corner of the window manager frame in root
/// window coordinates.
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow
/// </param>
/// <param name="x">
/// return location for X position of window frame
/// </param>
/// <param name="y">
/// return location for Y position of window frame
/// </param>

	public static T GetRootOrigin<T>(this T window, out int x, out int y) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_get_root_origin(window, out x, out y);
		return window;
	}

/// <summary>
/// <para>
/// Returns the internal scale factor that maps from window coordiantes
/// to the actual device pixels. On traditional systems this is 1, but
/// on very high density outputs this can be a higher value (often 2).
/// </para>
/// <para>
/// A higher value means that drawing is automatically scaled up to
/// a higher resolution, so any code doing drawing will automatically look
/// nicer. However, if you are supplying pixel-based data the scale
/// value can be used to determine whether to use a pixel resource
/// with higher resolution data.
/// </para>
/// <para>
/// The scale of a window may change during runtime, if this happens
/// a configure event will be sent to the toplevel window.
/// </para>
/// </summary>

/// <param name="window">
/// window to get scale factor for
/// </param>
/// <return>
/// the scale factor
/// </return>

	public static int GetScaleFactor(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_scale_factor(window);
	}

/// <summary>
/// <para>
/// Gets the #GdkScreen associated with a #GdkWindow.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <return>
/// the #GdkScreen associated with @window
/// </return>

	public static MentorLake.Gdk.GdkScreenHandle GetScreen(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_screen(window);
	}

/// <summary>
/// <para>
/// Returns the event mask for @window corresponding to the device class specified
/// by @source.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="source">
/// a #GdkInputSource to define the source class.
/// </param>
/// <return>
/// source event mask for @window
/// </return>

	public static MentorLake.Gdk.GdkEventMask GetSourceEvents(this MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkInputSource source)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_source_events(window, source);
	}

/// <summary>
/// <para>
/// Gets the bitwise OR of the currently active window state flags,
/// from the #GdkWindowState enumeration.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <return>
/// window state bitfield
/// </return>

	public static MentorLake.Gdk.GdkWindowState GetState(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_state(window);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the window is aware of the existence of multiple
/// devices.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow.
/// </param>
/// <return>
/// %TRUE if the window handles multidevice features.
/// </return>

	public static bool GetSupportMultidevice(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_support_multidevice(window);
	}

/// <summary>
/// <para>
/// Gets the toplevel window that’s an ancestor of @window.
/// </para>
/// <para>
/// Any window type but %GDK_WINDOW_CHILD is considered a
/// toplevel window, as is a %GDK_WINDOW_CHILD window that
/// has a root window as parent.
/// </para>
/// <para>
/// Note that you should use gdk_window_get_effective_toplevel() when
/// you want to get to a window’s toplevel as seen on screen, because
/// gdk_window_get_toplevel() will most likely not do what you expect
/// if there are offscreen windows in the hierarchy.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <return>
/// the toplevel window containing @window
/// </return>

	public static MentorLake.Gdk.GdkWindowHandle GetToplevel(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_toplevel(window);
	}

/// <summary>
/// <para>
/// This function returns the type hint set for a window.
/// </para>
/// </summary>

/// <param name="window">
/// A toplevel #GdkWindow
/// </param>
/// <return>
/// The type hint set for @window
/// </return>

	public static MentorLake.Gdk.GdkWindowTypeHint GetTypeHint(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_type_hint(window);
	}

/// <summary>
/// <para>
/// Transfers ownership of the update area from @window to the caller
/// of the function. That is, after calling this function, @window will
/// no longer have an invalid/dirty region; the update area is removed
/// from @window and handed to you. If a window has no update area,
/// gdk_window_get_update_area() returns %NULL. You are responsible for
/// calling cairo_region_destroy() on the returned region if it’s non-%NULL.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <return>
/// the update area for @window
/// </return>

	public static MentorLake.cairo.cairo_region_tHandle GetUpdateArea(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_update_area(window);
	}

/// <summary>
/// <para>
/// Retrieves the user data for @window, which is normally the widget
/// that @window belongs to. See gdk_window_set_user_data().
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="data">
/// return location for user data
/// </param>

	public static T GetUserData<T>(this T window, out IntPtr data) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_get_user_data(window, out data);
		return window;
	}

/// <summary>
/// <para>
/// Computes the region of the @window that is potentially visible.
/// This does not necessarily take into account if the window is
/// obscured by other windows, but no area outside of this region
/// is visible.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <return>
/// a #cairo_region_t. This must be freed with cairo_region_destroy()
///          when you are done.
/// </return>

	public static MentorLake.cairo.cairo_region_tHandle GetVisibleRegion(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_visible_region(window);
	}

/// <summary>
/// <para>
/// Gets the #GdkVisual describing the pixel format of @window.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <return>
/// a #GdkVisual
/// </return>

	public static MentorLake.Gdk.GdkVisualHandle GetVisual(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_visual(window);
	}

/// <summary>
/// <para>
/// Returns the width of the given @window.
/// </para>
/// <para>
/// On the X11 platform the returned size is the size reported in the
/// most-recently-processed configure event, rather than the current
/// size on the X server.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <return>
/// The width of @window
/// </return>

	public static int GetWidth(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_width(window);
	}

/// <summary>
/// <para>
/// Gets the type of the window. See #GdkWindowType.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <return>
/// type of window
/// </return>

	public static MentorLake.Gdk.GdkWindowType GetWindowType(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_window_type(window);
	}

/// <summary>
/// <para>
/// Checks whether the window has a native window or not. Note that
/// you can use gdk_window_ensure_native() if a native window is needed.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <return>
/// %TRUE if the @window has a native window, %FALSE otherwise.
/// </return>

	public static bool HasNative(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_has_native(window);
	}

/// <summary>
/// <para>
/// For toplevel windows, withdraws them, so they will no longer be
/// known to the window manager; for all windows, unmaps them, so
/// they won’t be displayed. Normally done automatically as
/// part of gtk_widget_hide().
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>

	public static T Hide<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_hide(window);
		return window;
	}

/// <summary>
/// <para>
/// Asks to iconify (minimize) @window. The window manager may choose
/// to ignore the request, but normally will honor it. Using
/// gtk_window_iconify() is preferred, if you have a #GtkWindow widget.
/// </para>
/// <para>
/// This function only makes sense when @window is a toplevel window.
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow
/// </param>

	public static T Iconify<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_iconify(window);
		return window;
	}

/// <summary>
/// <para>
/// Like gdk_window_shape_combine_region(), but the shape applies
/// only to event handling. Mouse events which happen while
/// the pointer position corresponds to an unset bit in the
/// mask will be passed on the window below @window.
/// </para>
/// <para>
/// An input shape is typically used with RGBA windows.
/// The alpha channel of the window defines which pixels are
/// invisible and allows for nicely antialiased borders,
/// and the input shape controls where the window is
/// “clickable”.
/// </para>
/// <para>
/// On the X11 platform, this requires version 1.1 of the
/// shape extension.
/// </para>
/// <para>
/// On the Win32 platform, this functionality is not present and the
/// function does nothing.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="shape_region">
/// region of window to be non-transparent
/// </param>
/// <param name="offset_x">
/// X position of @shape_region in @window coordinates
/// </param>
/// <param name="offset_y">
/// Y position of @shape_region in @window coordinates
/// </param>

	public static T InputShapeCombineRegion<T>(this T window, MentorLake.cairo.cairo_region_tHandle shape_region, int offset_x, int offset_y) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_input_shape_combine_region(window, shape_region, offset_x, offset_y);
		return window;
	}

/// <summary>
/// <para>
/// Adds @region to the update area for @window. The update area is the
/// region that needs to be redrawn, or “dirty region.” The call
/// gdk_window_process_updates() sends one or more expose events to the
/// window, which together cover the entire update area. An
/// application would normally redraw the contents of @window in
/// response to those expose events.
/// </para>
/// <para>
/// GDK will call gdk_window_process_all_updates() on your behalf
/// whenever your program returns to the main loop and becomes idle, so
/// normally there’s no need to do that manually, you just need to
/// invalidate regions that you know should be redrawn.
/// </para>
/// <para>
/// The @child_func parameter controls whether the region of
/// each child window that intersects @region will also be invalidated.
/// Only children for which @child_func returns #TRUE will have the area
/// invalidated.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="region">
/// a #cairo_region_t
/// </param>
/// <param name="child_func">
/// function to use to decide if to
///     recurse to a child, %NULL means never recurse.
/// </param>
/// <param name="user_data">
/// data passed to @child_func
/// </param>

	public static T InvalidateMaybeRecurse<T>(this T window, MentorLake.cairo.cairo_region_tHandle region, MentorLake.Gdk.GdkWindowChildFunc child_func, IntPtr user_data) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_invalidate_maybe_recurse(window, region, child_func, user_data);
		return window;
	}

/// <summary>
/// <para>
/// A convenience wrapper around gdk_window_invalidate_region() which
/// invalidates a rectangular region. See
/// gdk_window_invalidate_region() for details.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="rect">
/// rectangle to invalidate or %NULL to invalidate the whole
///      window
/// </param>
/// <param name="invalidate_children">
/// whether to also invalidate child windows
/// </param>

	public static T InvalidateRect<T>(this T window, MentorLake.Gdk.GdkRectangleHandle rect, bool invalidate_children) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_invalidate_rect(window, rect, invalidate_children);
		return window;
	}

/// <summary>
/// <para>
/// Adds @region to the update area for @window. The update area is the
/// region that needs to be redrawn, or “dirty region.” The call
/// gdk_window_process_updates() sends one or more expose events to the
/// window, which together cover the entire update area. An
/// application would normally redraw the contents of @window in
/// response to those expose events.
/// </para>
/// <para>
/// GDK will call gdk_window_process_all_updates() on your behalf
/// whenever your program returns to the main loop and becomes idle, so
/// normally there’s no need to do that manually, you just need to
/// invalidate regions that you know should be redrawn.
/// </para>
/// <para>
/// The @invalidate_children parameter controls whether the region of
/// each child window that intersects @region will also be invalidated.
/// If %FALSE, then the update area for child windows will remain
/// unaffected. See gdk_window_invalidate_maybe_recurse if you need
/// fine grained control over which children are invalidated.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="region">
/// a #cairo_region_t
/// </param>
/// <param name="invalidate_children">
/// %TRUE to also invalidate child windows
/// </param>

	public static T InvalidateRegion<T>(this T window, MentorLake.cairo.cairo_region_tHandle region, bool invalidate_children) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_invalidate_region(window, region, invalidate_children);
		return window;
	}

/// <summary>
/// <para>
/// Check to see if a window is destroyed..
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <return>
/// %TRUE if the window is destroyed
/// </return>

	public static bool IsDestroyed(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_is_destroyed(window);
	}

/// <summary>
/// <para>
/// Determines whether or not the window is an input only window.
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow
/// </param>
/// <return>
/// %TRUE if @window is input only
/// </return>

	public static bool IsInputOnly(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_is_input_only(window);
	}

/// <summary>
/// <para>
/// Determines whether or not the window is shaped.
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow
/// </param>
/// <return>
/// %TRUE if @window is shaped
/// </return>

	public static bool IsShaped(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_is_shaped(window);
	}

/// <summary>
/// <para>
/// Check if the window and all ancestors of the window are
/// mapped. (This is not necessarily "viewable" in the X sense, since
/// we only check as far as we have GDK window parents, not to the root
/// window.)
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <return>
/// %TRUE if the window is viewable
/// </return>

	public static bool IsViewable(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_is_viewable(window);
	}

/// <summary>
/// <para>
/// Checks whether the window has been mapped (with gdk_window_show() or
/// gdk_window_show_unraised()).
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <return>
/// %TRUE if the window is mapped
/// </return>

	public static bool IsVisible(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_is_visible(window);
	}

/// <summary>
/// <para>
/// Lowers @window to the bottom of the Z-order (stacking order), so that
/// other windows with the same parent window appear above @window.
/// This is true whether or not the other windows are visible.
/// </para>
/// <para>
/// If @window is a toplevel, the window manager may choose to deny the
/// request to move the window in the Z-order, gdk_window_lower() only
/// requests the restack, does not guarantee it.
/// </para>
/// <para>
/// Note that gdk_window_show() raises the window again, so don’t call this
/// function before gdk_window_show(). (Try gdk_window_show_unraised().)
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>

	public static T Lower<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_lower(window);
		return window;
	}

/// <summary>
/// <para>
/// If you call this during a paint (e.g. between gdk_window_begin_paint_region()
/// and gdk_window_end_paint() then GDK will mark the current clip region of the
/// window as being drawn. This is required when mixing GL rendering via
/// gdk_cairo_draw_from_gl() and cairo rendering, as otherwise GDK has no way
/// of knowing when something paints over the GL-drawn regions.
/// </para>
/// <para>
/// This is typically called automatically by GTK+ and you don't need
/// to care about this.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="cr">
/// a #cairo_t
/// </param>

	public static T MarkPaintFromClip<T>(this T window, MentorLake.cairo.cairo_tHandle cr) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_mark_paint_from_clip(window, cr);
		return window;
	}

/// <summary>
/// <para>
/// Maximizes the window. If the window was already maximized, then
/// this function does nothing.
/// </para>
/// <para>
/// On X11, asks the window manager to maximize @window, if the window
/// manager supports this operation. Not all window managers support
/// this, and some deliberately ignore it or don’t have a concept of
/// “maximized”; so you can’t rely on the maximization actually
/// happening. But it will happen with most standard window managers,
/// and GDK makes a best effort to get it to happen.
/// </para>
/// <para>
/// On Windows, reliably maximizes the window.
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow
/// </param>

	public static T Maximize<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_maximize(window);
		return window;
	}

/// <summary>
/// <para>
/// Merges the input shape masks for any child windows into the
/// input shape mask for @window. i.e. the union of all input masks
/// for @window and its children will become the new input mask
/// for @window. See gdk_window_input_shape_combine_region().
/// </para>
/// <para>
/// This function is distinct from gdk_window_set_child_input_shapes()
/// because it includes @window’s input shape mask in the set of
/// shapes to be merged.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>

	public static T MergeChildInputShapes<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_merge_child_input_shapes(window);
		return window;
	}

/// <summary>
/// <para>
/// Merges the shape masks for any child windows into the
/// shape mask for @window. i.e. the union of all masks
/// for @window and its children will become the new mask
/// for @window. See gdk_window_shape_combine_region().
/// </para>
/// <para>
/// This function is distinct from gdk_window_set_child_shapes()
/// because it includes @window’s shape mask in the set of shapes to
/// be merged.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>

	public static T MergeChildShapes<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_merge_child_shapes(window);
		return window;
	}

/// <summary>
/// <para>
/// Repositions a window relative to its parent window.
/// For toplevel windows, window managers may ignore or modify the move;
/// you should probably use gtk_window_move() on a #GtkWindow widget
/// anyway, instead of using GDK functions. For child windows,
/// the move will reliably succeed.
/// </para>
/// <para>
/// If you’re also planning to resize the window, use gdk_window_move_resize()
/// to both move and resize simultaneously, for a nicer visual effect.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="x">
/// X coordinate relative to window’s parent
/// </param>
/// <param name="y">
/// Y coordinate relative to window’s parent
/// </param>

	public static T Move<T>(this T window, int x, int y) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_move(window, x, y);
		return window;
	}

/// <summary>
/// <para>
/// Move the part of @window indicated by @region by @dy pixels in the Y
/// direction and @dx pixels in the X direction. The portions of @region
/// that not covered by the new position of @region are invalidated.
/// </para>
/// <para>
/// Child windows are not moved.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="region">
/// The #cairo_region_t to move
/// </param>
/// <param name="dx">
/// Amount to move in the X direction
/// </param>
/// <param name="dy">
/// Amount to move in the Y direction
/// </param>

	public static T MoveRegion<T>(this T window, MentorLake.cairo.cairo_region_tHandle region, int dx, int dy) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_move_region(window, region, dx, dy);
		return window;
	}

/// <summary>
/// <para>
/// Equivalent to calling gdk_window_move() and gdk_window_resize(),
/// except that both operations are performed at once, avoiding strange
/// visual effects. (i.e. the user may be able to see the window first
/// move, then resize, if you don’t use gdk_window_move_resize().)
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="x">
/// new X position relative to window’s parent
/// </param>
/// <param name="y">
/// new Y position relative to window’s parent
/// </param>
/// <param name="width">
/// new width
/// </param>
/// <param name="height">
/// new height
/// </param>

	public static T MoveResize<T>(this T window, int x, int y, int width, int height) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_move_resize(window, x, y, width, height);
		return window;
	}

/// <summary>
/// <para>
/// Moves @window to @rect, aligning their anchor points.
/// </para>
/// <para>
/// @rect is relative to the top-left corner of the window that @window is
/// transient for. @rect_anchor and @window_anchor determine anchor points on
/// @rect and @window to pin together. @rect's anchor point can optionally be
/// offset by @rect_anchor_dx and @rect_anchor_dy, which is equivalent to
/// offsetting the position of @window.
/// </para>
/// <para>
/// @anchor_hints determines how @window will be moved if the anchor points cause
/// it to move off-screen. For example, %GDK_ANCHOR_FLIP_X will replace
/// %GDK_GRAVITY_NORTH_WEST with %GDK_GRAVITY_NORTH_EAST and vice versa if
/// @window extends beyond the left or right edges of the monitor.
/// </para>
/// <para>
/// Connect to the #GdkWindow::moved-to-rect signal to find out how it was
/// actually positioned.
/// </para>
/// </summary>

/// <param name="window">
/// the #GdkWindow to move
/// </param>
/// <param name="rect">
/// the destination #GdkRectangle to align @window with
/// </param>
/// <param name="rect_anchor">
/// the point on @rect to align with @window's anchor point
/// </param>
/// <param name="window_anchor">
/// the point on @window to align with @rect's anchor point
/// </param>
/// <param name="anchor_hints">
/// positioning hints to use when limited on space
/// </param>
/// <param name="rect_anchor_dx">
/// horizontal offset to shift @window, i.e. @rect's anchor
///                  point
/// </param>
/// <param name="rect_anchor_dy">
/// vertical offset to shift @window, i.e. @rect's anchor point
/// </param>

	public static T MoveToRect<T>(this T window, MentorLake.Gdk.GdkRectangleHandle rect, MentorLake.Gdk.GdkGravity rect_anchor, MentorLake.Gdk.GdkGravity window_anchor, MentorLake.Gdk.GdkAnchorHints anchor_hints, int rect_anchor_dx, int rect_anchor_dy) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_move_to_rect(window, rect, rect_anchor, window_anchor, anchor_hints, rect_anchor_dx, rect_anchor_dy);
		return window;
	}

/// <summary>
/// <para>
/// Like gdk_window_get_children(), but does not copy the list of
/// children, so the list does not need to be freed.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <return>
/// 
///     a reference to the list of child windows in @window
/// </return>

	public static MentorLake.GLib.GListHandle PeekChildren(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_peek_children(window);
	}

/// <summary>
/// <para>
/// Sends one or more expose events to @window. The areas in each
/// expose event will cover the entire update area for the window (see
/// gdk_window_invalidate_region() for details). Normally GDK calls
/// gdk_window_process_all_updates() on your behalf, so there’s no
/// need to call this function unless you want to force expose events
/// to be delivered immediately and synchronously (vs. the usual
/// case, where GDK delivers them in an idle handler). Occasionally
/// this is useful to produce nicer scrolling behavior, for example.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="update_children">
/// whether to also process updates for child windows
/// </param>

	public static T ProcessUpdates<T>(this T window, bool update_children) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_process_updates(window, update_children);
		return window;
	}

/// <summary>
/// <para>
/// Raises @window to the top of the Z-order (stacking order), so that
/// other windows with the same parent window appear below @window.
/// This is true whether or not the windows are visible.
/// </para>
/// <para>
/// If @window is a toplevel, the window manager may choose to deny the
/// request to move the window in the Z-order, gdk_window_raise() only
/// requests the restack, does not guarantee it.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>

	public static T Raise<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_raise(window);
		return window;
	}

/// <summary>
/// <para>
/// Registers a window as a potential drop destination.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow.
/// </param>

	public static T RegisterDnd<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_register_dnd(window);
		return window;
	}

/// <summary>
/// <para>
/// Remove a filter previously added with gdk_window_add_filter().
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="function">
/// previously-added filter function
/// </param>
/// <param name="data">
/// user data for previously-added filter function
/// </param>

	public static T RemoveFilter<T>(this T window, MentorLake.Gdk.GdkFilterFunc function, IntPtr data) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_remove_filter(window, function, data);
		return window;
	}

/// <summary>
/// <para>
/// Reparents @window into the given @new_parent. The window being
/// reparented will be unmapped as a side effect.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="new_parent">
/// new parent to move @window into
/// </param>
/// <param name="x">
/// X location inside the new parent
/// </param>
/// <param name="y">
/// Y location inside the new parent
/// </param>

	public static T Reparent<T>(this T window, MentorLake.Gdk.GdkWindowHandle new_parent, int x, int y) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_reparent(window, new_parent, x, y);
		return window;
	}

/// <summary>
/// <para>
/// Resizes @window; for toplevel windows, asks the window manager to resize
/// the window. The window manager may not allow the resize. When using GTK+,
/// use gtk_window_resize() instead of this low-level GDK function.
/// </para>
/// <para>
/// Windows may not be resized below 1x1.
/// </para>
/// <para>
/// If you’re also planning to move the window, use gdk_window_move_resize()
/// to both move and resize simultaneously, for a nicer visual effect.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="width">
/// new width of the window
/// </param>
/// <param name="height">
/// new height of the window
/// </param>

	public static T Resize<T>(this T window, int width, int height) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_resize(window, width, height);
		return window;
	}

/// <summary>
/// <para>
/// Changes the position of  @window in the Z-order (stacking order), so that
/// it is above @sibling (if @above is %TRUE) or below @sibling (if @above is
/// %FALSE).
/// </para>
/// <para>
/// If @sibling is %NULL, then this either raises (if @above is %TRUE) or
/// lowers the window.
/// </para>
/// <para>
/// If @window is a toplevel, the window manager may choose to deny the
/// request to move the window in the Z-order, gdk_window_restack() only
/// requests the restack, does not guarantee it.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="sibling">
/// a #GdkWindow that is a sibling of @window, or %NULL
/// </param>
/// <param name="above">
/// a boolean
/// </param>

	public static T Restack<T>(this T window, MentorLake.Gdk.GdkWindowHandle sibling, bool above) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_restack(window, sibling, above);
		return window;
	}

/// <summary>
/// <para>
/// Scroll the contents of @window, both pixels and children, by the
/// given amount. @window itself does not move. Portions of the window
/// that the scroll operation brings in from offscreen areas are
/// invalidated. The invalidated region may be bigger than what would
/// strictly be necessary.
/// </para>
/// <para>
/// For X11, a minimum area will be invalidated if the window has no
/// subwindows, or if the edges of the window’s parent do not extend
/// beyond the edges of the window. In other cases, a multi-step process
/// is used to scroll the window which may produce temporary visual
/// artifacts and unnecessary invalidations.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="dx">
/// Amount to scroll in the X direction
/// </param>
/// <param name="dy">
/// Amount to scroll in the Y direction
/// </param>

	public static T Scroll<T>(this T window, int dx, int dy) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_scroll(window, dx, dy);
		return window;
	}

/// <summary>
/// <para>
/// Setting @accept_focus to %FALSE hints the desktop environment that the
/// window doesn’t want to receive input focus.
/// </para>
/// <para>
/// On X, it is the responsibility of the window manager to interpret this
/// hint. ICCCM-compliant window manager usually respect it.
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow
/// </param>
/// <param name="accept_focus">
/// %TRUE if the window should receive input focus
/// </param>

	public static T SetAcceptFocus<T>(this T window, bool accept_focus) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_accept_focus(window, accept_focus);
		return window;
	}

/// <summary>
/// <para>
/// Sets the background color of @window.
/// </para>
/// <para>
/// However, when using GTK+, influence the background of a widget
/// using a style class or CSS — if you’re an application — or with
/// gtk_style_context_set_background() — if you're implementing a
/// custom widget.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="color">
/// a #GdkColor
/// </param>

	public static T SetBackground<T>(this T window, MentorLake.Gdk.GdkColorHandle color) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_background(window, color);
		return window;
	}

/// <summary>
/// <para>
/// Sets the background of @window.
/// </para>
/// <para>
/// A background of %NULL means that the window won't have any background. On the
/// X11 backend it's also possible to inherit the background from the parent
/// window using gdk_x11_get_parent_relative_pattern().
/// </para>
/// <para>
/// The windowing system will normally fill a window with its background
/// when the window is obscured then exposed.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="pattern">
/// a pattern to use, or %NULL
/// </param>

	public static T SetBackgroundPattern<T>(this T window, MentorLake.cairo.cairo_pattern_tHandle pattern) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_background_pattern(window, pattern);
		return window;
	}

/// <summary>
/// <para>
/// Sets the background color of @window.
/// </para>
/// <para>
/// See also gdk_window_set_background_pattern().
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="rgba">
/// a #GdkRGBA color
/// </param>

	public static T SetBackgroundRgba<T>(this T window, MentorLake.Gdk.GdkRGBAHandle rgba) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_background_rgba(window, rgba);
		return window;
	}

/// <summary>
/// <para>
/// Sets the input shape mask of @window to the union of input shape masks
/// for all children of @window, ignoring the input shape mask of @window
/// itself. Contrast with gdk_window_merge_child_input_shapes() which includes
/// the input shape mask of @window in the masks to be merged.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>

	public static T SetChildInputShapes<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_child_input_shapes(window);
		return window;
	}

/// <summary>
/// <para>
/// Sets the shape mask of @window to the union of shape masks
/// for all children of @window, ignoring the shape mask of @window
/// itself. Contrast with gdk_window_merge_child_shapes() which includes
/// the shape mask of @window in the masks to be merged.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>

	public static T SetChildShapes<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_child_shapes(window);
		return window;
	}

/// <summary>
/// <para>
/// Sets a #GdkWindow as composited, or unsets it. Composited
/// windows do not automatically have their contents drawn to
/// the screen. Drawing is redirected to an offscreen buffer
/// and an expose event is emitted on the parent of the composited
/// window. It is the responsibility of the parent’s expose handler
/// to manually merge the off-screen content onto the screen in
/// whatever way it sees fit.
/// </para>
/// <para>
/// It only makes sense for child windows to be composited; see
/// gdk_window_set_opacity() if you need translucent toplevel
/// windows.
/// </para>
/// <para>
/// An additional effect of this call is that the area of this
/// window is no longer clipped from regions marked for
/// invalidation on its parent. Draws done on the parent
/// window are also no longer clipped by the child.
/// </para>
/// <para>
/// This call is only supported on some systems (currently,
/// only X11 with new enough Xcomposite and Xdamage extensions).
/// You must call gdk_display_supports_composite() to check if
/// setting a window as composited is supported before
/// attempting to do so.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="composited">
/// %TRUE to set the window as composited
/// </param>

	public static T SetComposited<T>(this T window, bool composited) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_composited(window, composited);
		return window;
	}

/// <summary>
/// <para>
/// Sets the default mouse pointer for a #GdkWindow.
/// </para>
/// <para>
/// Note that @cursor must be for the same display as @window.
/// </para>
/// <para>
/// Use gdk_cursor_new_for_display() or gdk_cursor_new_from_pixbuf() to
/// create the cursor. To make the cursor invisible, use %GDK_BLANK_CURSOR.
/// Passing %NULL for the @cursor argument to gdk_window_set_cursor() means
/// that @window will use the cursor of its parent window. Most windows
/// should use this default.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="cursor">
/// a cursor
/// </param>

	public static T SetCursor<T>(this T window, MentorLake.Gdk.GdkCursorHandle cursor) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_cursor(window, cursor);
		return window;
	}

/// <summary>
/// <para>
/// “Decorations” are the features the window manager adds to a toplevel #GdkWindow.
/// This function sets the traditional Motif window manager hints that tell the
/// window manager which decorations you would like your window to have.
/// Usually you should use gtk_window_set_decorated() on a #GtkWindow instead of
/// using the GDK function directly.
/// </para>
/// <para>
/// The @decorations argument is the logical OR of the fields in
/// the #GdkWMDecoration enumeration. If #GDK_DECOR_ALL is included in the
/// mask, the other bits indicate which decorations should be turned off.
/// If #GDK_DECOR_ALL is not included, then the other bits indicate
/// which decorations should be turned on.
/// </para>
/// <para>
/// Most window managers honor a decorations hint of 0 to disable all decorations,
/// but very few honor all possible combinations of bits.
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow
/// </param>
/// <param name="decorations">
/// decoration hint mask
/// </param>

	public static T SetDecorations<T>(this T window, MentorLake.Gdk.GdkWMDecoration decorations) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_decorations(window, decorations);
		return window;
	}

/// <summary>
/// <para>
/// Sets a specific #GdkCursor for a given device when it gets inside @window.
/// Use gdk_cursor_new_for_display() or gdk_cursor_new_from_pixbuf() to create
/// the cursor. To make the cursor invisible, use %GDK_BLANK_CURSOR. Passing
/// %NULL for the @cursor argument to gdk_window_set_cursor() means that
/// @window will use the cursor of its parent window. Most windows should
/// use this default.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="device">
/// a master, pointer #GdkDevice
/// </param>
/// <param name="cursor">
/// a #GdkCursor
/// </param>

	public static T SetDeviceCursor<T>(this T window, MentorLake.Gdk.GdkDeviceHandle device, MentorLake.Gdk.GdkCursorHandle cursor) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_device_cursor(window, device, cursor);
		return window;
	}

/// <summary>
/// <para>
/// Sets the event mask for a given device (Normally a floating device, not
/// attached to any visible pointer) to @window. For example, an event mask
/// including #GDK_BUTTON_PRESS_MASK means the window should report button
/// press events. The event mask is the bitwise OR of values from the
/// #GdkEventMask enumeration.
/// </para>
/// <para>
/// See the [input handling overview][event-masks] for details.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="device">
/// #GdkDevice to enable events for.
/// </param>
/// <param name="event_mask">
/// event mask for @window
/// </param>

	public static T SetDeviceEvents<T>(this T window, MentorLake.Gdk.GdkDeviceHandle device, MentorLake.Gdk.GdkEventMask event_mask) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_device_events(window, device, event_mask);
		return window;
	}

/// <summary>
/// <para>
/// Determines whether or not extra unprocessed motion events in
/// the event queue can be discarded. If %TRUE only the most recent
/// event will be delivered.
/// </para>
/// <para>
/// Some types of applications, e.g. paint programs, need to see all
/// motion events and will benefit from turning off event compression.
/// </para>
/// <para>
/// By default, event compression is enabled.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="event_compression">
/// %TRUE if motion events should be compressed
/// </param>

	public static T SetEventCompression<T>(this T window, bool event_compression) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_event_compression(window, event_compression);
		return window;
	}

/// <summary>
/// <para>
/// The event mask for a window determines which events will be reported
/// for that window from all master input devices. For example, an event mask
/// including #GDK_BUTTON_PRESS_MASK means the window should report button
/// press events. The event mask is the bitwise OR of values from the
/// #GdkEventMask enumeration.
/// </para>
/// <para>
/// See the [input handling overview][event-masks] for details.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="event_mask">
/// event mask for @window
/// </param>

	public static T SetEvents<T>(this T window, MentorLake.Gdk.GdkEventMask event_mask) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_events(window, event_mask);
		return window;
	}

/// <summary>
/// <para>
/// Setting @focus_on_map to %FALSE hints the desktop environment that the
/// window doesn’t want to receive input focus when it is mapped.
/// focus_on_map should be turned off for windows that aren’t triggered
/// interactively (such as popups from network activity).
/// </para>
/// <para>
/// On X, it is the responsibility of the window manager to interpret
/// this hint. Window managers following the freedesktop.org window
/// manager extension specification should respect it.
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow
/// </param>
/// <param name="focus_on_map">
/// %TRUE if the window should receive input focus when mapped
/// </param>

	public static T SetFocusOnMap<T>(this T window, bool focus_on_map) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_focus_on_map(window, focus_on_map);
		return window;
	}

/// <summary>
/// <para>
/// Specifies whether the @window should span over all monitors (in a multi-head
/// setup) or only the current monitor when in fullscreen mode.
/// </para>
/// <para>
/// The @mode argument is from the #GdkFullscreenMode enumeration.
/// If #GDK_FULLSCREEN_ON_ALL_MONITORS is specified, the fullscreen @window will
/// span over all monitors from the #GdkScreen.
/// </para>
/// <para>
/// On X11, searches through the list of monitors from the #GdkScreen the ones
/// which delimit the 4 edges of the entire #GdkScreen and will ask the window
/// manager to span the @window over these monitors.
/// </para>
/// <para>
/// If the XINERAMA extension is not available or not usable, this function
/// has no effect.
/// </para>
/// <para>
/// Not all window managers support this, so you can’t rely on the fullscreen
/// window to span over the multiple monitors when #GDK_FULLSCREEN_ON_ALL_MONITORS
/// is specified.
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow
/// </param>
/// <param name="mode">
/// fullscreen mode
/// </param>

	public static T SetFullscreenMode<T>(this T window, MentorLake.Gdk.GdkFullscreenMode mode) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_fullscreen_mode(window, mode);
		return window;
	}

/// <summary>
/// <para>
/// Sets hints about the window management functions to make available
/// via buttons on the window frame.
/// </para>
/// <para>
/// On the X backend, this function sets the traditional Motif window
/// manager hint for this purpose. However, few window managers do
/// anything reliable or interesting with this hint. Many ignore it
/// entirely.
/// </para>
/// <para>
/// The @functions argument is the logical OR of values from the
/// #GdkWMFunction enumeration. If the bitmask includes #GDK_FUNC_ALL,
/// then the other bits indicate which functions to disable; if
/// it doesn’t include #GDK_FUNC_ALL, it indicates which functions to
/// enable.
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow
/// </param>
/// <param name="functions">
/// bitmask of operations to allow on @window
/// </param>

	public static T SetFunctions<T>(this T window, MentorLake.Gdk.GdkWMFunction functions) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_functions(window, functions);
		return window;
	}

/// <summary>
/// <para>
/// Sets the geometry hints for @window. Hints flagged in @geom_mask
/// are set, hints not flagged in @geom_mask are unset.
/// To unset all hints, use a @geom_mask of 0 and a @geometry of %NULL.
/// </para>
/// <para>
/// This function provides hints to the windowing system about
/// acceptable sizes for a toplevel window. The purpose of
/// this is to constrain user resizing, but the windowing system
/// will typically  (but is not required to) also constrain the
/// current size of the window to the provided values and
/// constrain programatic resizing via gdk_window_resize() or
/// gdk_window_move_resize().
/// </para>
/// <para>
/// Note that on X11, this effect has no effect on windows
/// of type %GDK_WINDOW_TEMP or windows where override redirect
/// has been turned on via gdk_window_set_override_redirect()
/// since these windows are not resizable by the user.
/// </para>
/// <para>
/// Since you can’t count on the windowing system doing the
/// constraints for programmatic resizes, you should generally
/// call gdk_window_constrain_size() yourself to determine
/// appropriate sizes.
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow
/// </param>
/// <param name="geometry">
/// geometry hints
/// </param>
/// <param name="geom_mask">
/// bitmask indicating fields of @geometry to pay attention to
/// </param>

	public static T SetGeometryHints<T>(this T window, MentorLake.Gdk.GdkGeometryHandle geometry, MentorLake.Gdk.GdkWindowHints geom_mask) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_geometry_hints(window, geometry, geom_mask);
		return window;
	}

/// <summary>
/// <para>
/// Sets the group leader window for @window. By default,
/// GDK sets the group leader for all toplevel windows
/// to a global window implicitly created by GDK. With this function
/// you can override this default.
/// </para>
/// <para>
/// The group leader window allows the window manager to distinguish
/// all windows that belong to a single application. It may for example
/// allow users to minimize/unminimize all windows belonging to an
/// application at once. You should only set a non-default group window
/// if your application pretends to be multiple applications.
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow
/// </param>
/// <param name="leader">
/// group leader window, or %NULL to restore the default group leader window
/// </param>

	public static T SetGroup<T>(this T window, MentorLake.Gdk.GdkWindowHandle leader) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_group(window, leader);
		return window;
	}

/// <summary>
/// <para>
/// Sets a list of icons for the window. One of these will be used
/// to represent the window when it has been iconified. The icon is
/// usually shown in an icon box or some sort of task bar. Which icon
/// size is shown depends on the window manager. The window manager
/// can scale the icon  but setting several size icons can give better
/// image quality since the window manager may only need to scale the
/// icon by a small amount or not at all.
/// </para>
/// <para>
/// Note that some platforms don't support window icons.
/// </para>
/// </summary>

/// <param name="window">
/// The #GdkWindow toplevel window to set the icon of.
/// </param>
/// <param name="pixbufs">
/// 
///     A list of pixbufs, of different sizes.
/// </param>

	public static T SetIconList<T>(this T window, MentorLake.GLib.GListHandle pixbufs) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_icon_list(window, pixbufs);
		return window;
	}

/// <summary>
/// <para>
/// Windows may have a name used while minimized, distinct from the
/// name they display in their titlebar. Most of the time this is a bad
/// idea from a user interface standpoint. But you can set such a name
/// with this function, if you like.
/// </para>
/// <para>
/// After calling this with a non-%NULL @name, calls to gdk_window_set_title()
/// will not update the icon title.
/// </para>
/// <para>
/// Using %NULL for @name unsets the icon title; further calls to
/// gdk_window_set_title() will again update the icon title as well.
/// </para>
/// <para>
/// Note that some platforms don't support window icons.
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow
/// </param>
/// <param name="name">
/// name of window while iconified (minimized)
/// </param>

	public static T SetIconName<T>(this T window, string name) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_icon_name(window, name);
		return window;
	}

/// <summary>
/// <para>
/// Registers an invalidate handler for a specific window. This
/// will get called whenever a region in the window or its children
/// is invalidated.
/// </para>
/// <para>
/// This can be used to record the invalidated region, which is
/// useful if you are keeping an offscreen copy of some region
/// and want to keep it up to date. You can also modify the
/// invalidated region in case you’re doing some effect where
/// e.g. a child widget appears in multiple places.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="handler">
/// a #GdkWindowInvalidateHandlerFunc callback function
/// </param>

	public static T SetInvalidateHandler<T>(this T window, MentorLake.Gdk.GdkWindowInvalidateHandlerFunc handler) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_invalidate_handler(window, handler);
		return window;
	}

/// <summary>
/// <para>
/// Set if @window must be kept above other windows. If the
/// window was already above, then this function does nothing.
/// </para>
/// <para>
/// On X11, asks the window manager to keep @window above, if the window
/// manager supports this operation. Not all window managers support
/// this, and some deliberately ignore it or don’t have a concept of
/// “keep above”; so you can’t rely on the window being kept above.
/// But it will happen with most standard window managers,
/// and GDK makes a best effort to get it to happen.
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow
/// </param>
/// <param name="setting">
/// whether to keep @window above other windows
/// </param>

	public static T SetKeepAbove<T>(this T window, bool setting) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_keep_above(window, setting);
		return window;
	}

/// <summary>
/// <para>
/// Set if @window must be kept below other windows. If the
/// window was already below, then this function does nothing.
/// </para>
/// <para>
/// On X11, asks the window manager to keep @window below, if the window
/// manager supports this operation. Not all window managers support
/// this, and some deliberately ignore it or don’t have a concept of
/// “keep below”; so you can’t rely on the window being kept below.
/// But it will happen with most standard window managers,
/// and GDK makes a best effort to get it to happen.
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow
/// </param>
/// <param name="setting">
/// whether to keep @window below other windows
/// </param>

	public static T SetKeepBelow<T>(this T window, bool setting) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_keep_below(window, setting);
		return window;
	}

/// <summary>
/// <para>
/// The application can use this hint to tell the window manager
/// that a certain window has modal behaviour. The window manager
/// can use this information to handle modal windows in a special
/// way.
/// </para>
/// <para>
/// You should only use this on windows for which you have
/// previously called gdk_window_set_transient_for()
/// </para>
/// </summary>

/// <param name="window">
/// A toplevel #GdkWindow
/// </param>
/// <param name="modal">
/// %TRUE if the window is modal, %FALSE otherwise.
/// </param>

	public static T SetModalHint<T>(this T window, bool modal) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_modal_hint(window, modal);
		return window;
	}

/// <summary>
/// <para>
/// Set @window to render as partially transparent,
/// with opacity 0 being fully transparent and 1 fully opaque. (Values
/// of the opacity parameter are clamped to the [0,1] range.)
/// </para>
/// <para>
/// For toplevel windows this depends on support from the windowing system
/// that may not always be there. For instance, On X11, this works only on
/// X screens with a compositing manager running. On Wayland, there is no
/// per-window opacity value that the compositor would apply. Instead, use
/// `gdk_window_set_opaque_region (window, NULL)` to tell the compositor
/// that the entire window is (potentially) non-opaque, and draw your content
/// with alpha, or use gtk_widget_set_opacity() to set an overall opacity
/// for your widgets.
/// </para>
/// <para>
/// For child windows this function only works for non-native windows.
/// </para>
/// <para>
/// For setting up per-pixel alpha topelevels, see gdk_screen_get_rgba_visual(),
/// and for non-toplevels, see gdk_window_set_composited().
/// </para>
/// <para>
/// Support for non-toplevel windows was added in 3.8.
/// </para>
/// </summary>

/// <param name="window">
/// a top-level or non-native #GdkWindow
/// </param>
/// <param name="opacity">
/// opacity
/// </param>

	public static T SetOpacity<T>(this T window, double opacity) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_opacity(window, opacity);
		return window;
	}

/// <summary>
/// <para>
/// For optimisation purposes, compositing window managers may
/// like to not draw obscured regions of windows, or turn off blending
/// during for these regions. With RGB windows with no transparency,
/// this is just the shape of the window, but with ARGB32 windows, the
/// compositor does not know what regions of the window are transparent
/// or not.
/// </para>
/// <para>
/// This function only works for toplevel windows.
/// </para>
/// <para>
/// GTK+ will update this property automatically if
/// the @window background is opaque, as we know where the opaque regions
/// are. If your window background is not opaque, please update this
/// property in your #GtkWidget::style-updated handler.
/// </para>
/// </summary>

/// <param name="window">
/// a top-level or non-native #GdkWindow
/// </param>
/// <param name="region">
/// a region, or %NULL
/// </param>

	public static T SetOpaqueRegion<T>(this T window, MentorLake.cairo.cairo_region_tHandle region) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_opaque_region(window, region);
		return window;
	}

/// <summary>
/// <para>
/// An override redirect window is not under the control of the window manager.
/// This means it won’t have a titlebar, won’t be minimizable, etc. - it will
/// be entirely under the control of the application. The window manager
/// can’t see the override redirect window at all.
/// </para>
/// <para>
/// Override redirect should only be used for short-lived temporary
/// windows, such as popup menus. #GtkMenu uses an override redirect
/// window in its implementation, for example.
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow
/// </param>
/// <param name="override_redirect">
/// %TRUE if window should be override redirect
/// </param>

	public static T SetOverrideRedirect<T>(this T window, bool override_redirect) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_override_redirect(window, override_redirect);
		return window;
	}

/// <summary>
/// <para>
/// Sets whether input to the window is passed through to the window
/// below.
/// </para>
/// <para>
/// The default value of this is %FALSE, which means that pointer
/// events that happen inside the window are send first to the window,
/// but if the event is not selected by the event mask then the event
/// is sent to the parent window, and so on up the hierarchy.
/// </para>
/// <para>
/// If @pass_through is %TRUE then such pointer events happen as if the
/// window wasn't there at all, and thus will be sent first to any
/// windows below @window. This is useful if the window is used in a
/// transparent fashion. In the terminology of the web this would be called
/// "pointer-events: none".
/// </para>
/// <para>
/// Note that a window with @pass_through %TRUE can still have a subwindow
/// without pass through, so you can get events on a subset of a window. And in
/// that cases you would get the in-between related events such as the pointer
/// enter/leave events on its way to the destination window.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="pass_through">
/// a boolean
/// </param>

	public static T SetPassThrough<T>(this T window, bool pass_through) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_pass_through(window, pass_through);
		return window;
	}

/// <summary>
/// <para>
/// When using GTK+, typically you should use gtk_window_set_role() instead
/// of this low-level function.
/// </para>
/// <para>
/// The window manager and session manager use a window’s role to
/// distinguish it from other kinds of window in the same application.
/// When an application is restarted after being saved in a previous
/// session, all windows with the same title and role are treated as
/// interchangeable.  So if you have two windows with the same title
/// that should be distinguished for session management purposes, you
/// should set the role on those windows. It doesn’t matter what string
/// you use for the role, as long as you have a different role for each
/// non-interchangeable kind of window.
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow
/// </param>
/// <param name="role">
/// a string indicating its role
/// </param>

	public static T SetRole<T>(this T window, string role) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_role(window, role);
		return window;
	}

/// <summary>
/// <para>
/// Newer GTK+ windows using client-side decorations use extra geometry
/// around their frames for effects like shadows and invisible borders.
/// Window managers that want to maximize windows or snap to edges need
/// to know where the extents of the actual frame lie, so that users
/// don’t feel like windows are snapping against random invisible edges.
/// </para>
/// <para>
/// Note that this property is automatically updated by GTK+, so this
/// function should only be used by applications which do not use GTK+
/// to create toplevel windows.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="left">
/// The left extent
/// </param>
/// <param name="right">
/// The right extent
/// </param>
/// <param name="top">
/// The top extent
/// </param>
/// <param name="bottom">
/// The bottom extent
/// </param>

	public static T SetShadowWidth<T>(this T window, int left, int right, int top, int bottom) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_shadow_width(window, left, right, top, bottom);
		return window;
	}

/// <summary>
/// <para>
/// Toggles whether a window should appear in a pager (workspace
/// switcher, or other desktop utility program that displays a small
/// thumbnail representation of the windows on the desktop). If a
/// window’s semantic type as specified with gdk_window_set_type_hint()
/// already fully describes the window, this function should
/// not be called in addition, instead you should
/// allow the window to be treated according to standard policy for
/// its semantic type.
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow
/// </param>
/// <param name="skips_pager">
/// %TRUE to skip the pager
/// </param>

	public static T SetSkipPagerHint<T>(this T window, bool skips_pager) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_skip_pager_hint(window, skips_pager);
		return window;
	}

/// <summary>
/// <para>
/// Toggles whether a window should appear in a task list or window
/// list. If a window’s semantic type as specified with
/// gdk_window_set_type_hint() already fully describes the window, this
/// function should not be called in addition,
/// instead you should allow the window to be treated according to
/// standard policy for its semantic type.
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow
/// </param>
/// <param name="skips_taskbar">
/// %TRUE to skip the taskbar
/// </param>

	public static T SetSkipTaskbarHint<T>(this T window, bool skips_taskbar) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_skip_taskbar_hint(window, skips_taskbar);
		return window;
	}

/// <summary>
/// <para>
/// Sets the event mask for any floating device (i.e. not attached to any
/// visible pointer) that has the source defined as @source. This event
/// mask will be applied both to currently existing, newly added devices
/// after this call, and devices being attached/detached.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="source">
/// a #GdkInputSource to define the source class.
/// </param>
/// <param name="event_mask">
/// event mask for @window
/// </param>

	public static T SetSourceEvents<T>(this T window, MentorLake.Gdk.GdkInputSource source, MentorLake.Gdk.GdkEventMask event_mask) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_source_events(window, source, event_mask);
		return window;
	}

/// <summary>
/// <para>
/// When using GTK+, typically you should use gtk_window_set_startup_id()
/// instead of this low-level function.
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow
/// </param>
/// <param name="startup_id">
/// a string with startup-notification identifier
/// </param>

	public static T SetStartupId<T>(this T window, string startup_id) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_startup_id(window, startup_id);
		return window;
	}

/// <summary>
/// <para>
/// Used to set the bit gravity of the given window to static, and flag
/// it so all children get static subwindow gravity. This is used if you
/// are implementing scary features that involve deep knowledge of the
/// windowing system. Don’t worry about it.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="use_static">
/// %TRUE to turn on static gravity
/// </param>
/// <return>
/// %FALSE
/// </return>

	public static bool SetStaticGravities(this MentorLake.Gdk.GdkWindowHandle window, bool use_static)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_set_static_gravities(window, use_static);
	}

/// <summary>
/// <para>
/// This function will enable multidevice features in @window.
/// </para>
/// <para>
/// Multidevice aware windows will need to handle properly multiple,
/// per device enter/leave events, device grabs and grab ownerships.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow.
/// </param>
/// <param name="support_multidevice">
/// %TRUE to enable multidevice support in @window.
/// </param>

	public static T SetSupportMultidevice<T>(this T window, bool support_multidevice) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_support_multidevice(window, support_multidevice);
		return window;
	}

/// <summary>
/// <para>
/// Sets the title of a toplevel window, to be displayed in the titlebar.
/// If you haven’t explicitly set the icon name for the window
/// (using gdk_window_set_icon_name()), the icon name will be set to
/// @title as well. @title must be in UTF-8 encoding (as with all
/// user-readable strings in GDK/GTK+). @title may not be %NULL.
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow
/// </param>
/// <param name="title">
/// title of @window
/// </param>

	public static T SetTitle<T>(this T window, string title) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_title(window, title);
		return window;
	}

/// <summary>
/// <para>
/// Indicates to the window manager that @window is a transient dialog
/// associated with the application window @parent. This allows the
/// window manager to do things like center @window on @parent and
/// keep @window above @parent.
/// </para>
/// <para>
/// See gtk_window_set_transient_for() if you’re using #GtkWindow or
/// #GtkDialog.
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow
/// </param>
/// <param name="parent">
/// another toplevel #GdkWindow
/// </param>

	public static T SetTransientFor<T>(this T window, MentorLake.Gdk.GdkWindowHandle parent) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_transient_for(window, parent);
		return window;
	}

/// <summary>
/// <para>
/// The application can use this call to provide a hint to the window
/// manager about the functionality of a window. The window manager
/// can use this information when determining the decoration and behaviour
/// of the window.
/// </para>
/// <para>
/// The hint must be set before the window is mapped.
/// </para>
/// </summary>

/// <param name="window">
/// A toplevel #GdkWindow
/// </param>
/// <param name="hint">
/// A hint of the function this window will have
/// </param>

	public static T SetTypeHint<T>(this T window, MentorLake.Gdk.GdkWindowTypeHint hint) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_type_hint(window, hint);
		return window;
	}

/// <summary>
/// <para>
/// Toggles whether a window needs the user's
/// urgent attention.
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow
/// </param>
/// <param name="urgent">
/// %TRUE if the window is urgent
/// </param>

	public static T SetUrgencyHint<T>(this T window, bool urgent) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_urgency_hint(window, urgent);
		return window;
	}

/// <summary>
/// <para>
/// For most purposes this function is deprecated in favor of
/// g_object_set_data(). However, for historical reasons GTK+ stores
/// the #GtkWidget that owns a #GdkWindow as user data on the
/// #GdkWindow. So, custom widget implementations should use
/// this function for that. If GTK+ receives an event for a #GdkWindow,
/// and the user data for the window is non-%NULL, GTK+ will assume the
/// user data is a #GtkWidget, and forward the event to that widget.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="user_data">
/// user data
/// </param>

	public static T SetUserData<T>(this T window, MentorLake.GObject.GObjectHandle user_data) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_user_data(window, user_data);
		return window;
	}

/// <summary>
/// <para>
/// Makes pixels in @window outside @shape_region be transparent,
/// so that the window may be nonrectangular.
/// </para>
/// <para>
/// If @shape_region is %NULL, the shape will be unset, so the whole
/// window will be opaque again. @offset_x and @offset_y are ignored
/// if @shape_region is %NULL.
/// </para>
/// <para>
/// On the X11 platform, this uses an X server extension which is
/// widely available on most common platforms, but not available on
/// very old X servers, and occasionally the implementation will be
/// buggy. On servers without the shape extension, this function
/// will do nothing.
/// </para>
/// <para>
/// This function works on both toplevel and child windows.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="shape_region">
/// region of window to be non-transparent
/// </param>
/// <param name="offset_x">
/// X position of @shape_region in @window coordinates
/// </param>
/// <param name="offset_y">
/// Y position of @shape_region in @window coordinates
/// </param>

	public static T ShapeCombineRegion<T>(this T window, MentorLake.cairo.cairo_region_tHandle shape_region, int offset_x, int offset_y) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_shape_combine_region(window, shape_region, offset_x, offset_y);
		return window;
	}

/// <summary>
/// <para>
/// Like gdk_window_show_unraised(), but also raises the window to the
/// top of the window stack (moves the window to the front of the
/// Z-order).
/// </para>
/// <para>
/// This function maps a window so it’s visible onscreen. Its opposite
/// is gdk_window_hide().
/// </para>
/// <para>
/// When implementing a #GtkWidget, you should call this function on the widget's
/// #GdkWindow as part of the “map” method.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>

	public static T Show<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_show(window);
		return window;
	}

/// <summary>
/// <para>
/// Shows a #GdkWindow onscreen, but does not modify its stacking
/// order. In contrast, gdk_window_show() will raise the window
/// to the top of the window stack.
/// </para>
/// <para>
/// On the X11 platform, in Xlib terms, this function calls
/// XMapWindow() (it also updates some internal GDK state, which means
/// that you can’t really use XMapWindow() directly on a GDK window).
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>

	public static T ShowUnraised<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_show_unraised(window);
		return window;
	}

/// <summary>
/// <para>
/// Asks the windowing system to show the window menu. The window menu
/// is the menu shown when right-clicking the titlebar on traditional
/// windows managed by the window manager. This is useful for windows
/// using client-side decorations, activating it with a right-click
/// on the window decorations.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="@event">
/// a #GdkEvent to show the menu for
/// </param>
/// <return>
/// %TRUE if the window menu was shown and %FALSE otherwise.
/// </return>

	public static bool ShowWindowMenu(this MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkEventHandle @event)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_show_window_menu(window, @event);
	}

/// <summary>
/// <para>
/// “Pins” a window such that it’s on all workspaces and does not scroll
/// with viewports, for window managers that have scrollable viewports.
/// (When using #GtkWindow, gtk_window_stick() may be more useful.)
/// </para>
/// <para>
/// On the X11 platform, this function depends on window manager
/// support, so may have no effect with many window managers. However,
/// GDK will do the best it can to convince the window manager to stick
/// the window. For window managers that don’t support this operation,
/// there’s nothing you can do to force it to happen.
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow
/// </param>

	public static T Stick<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_stick(window);
		return window;
	}

/// <summary>
/// <para>
/// Thaws a window frozen with
/// gdk_window_freeze_toplevel_updates_libgtk_only().
/// </para>
/// <para>
/// This function is not part of the GDK public API and is only
/// for use by GTK+.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>

	public static T ThawToplevelUpdatesLibgtkOnly<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_thaw_toplevel_updates_libgtk_only(window);
		return window;
	}

/// <summary>
/// <para>
/// Thaws a window frozen with gdk_window_freeze_updates().
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>

	public static T ThawUpdates<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_thaw_updates(window);
		return window;
	}

/// <summary>
/// <para>
/// Moves the window out of fullscreen mode. If the window was not
/// fullscreen, does nothing.
/// </para>
/// <para>
/// On X11, asks the window manager to move @window out of the fullscreen
/// state, if the window manager supports this operation. Not all
/// window managers support this, and some deliberately ignore it or
/// don’t have a concept of “fullscreen”; so you can’t rely on the
/// unfullscreenification actually happening. But it will happen with
/// most standard window managers, and GDK makes a best effort to get
/// it to happen.
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow
/// </param>

	public static T Unfullscreen<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_unfullscreen(window);
		return window;
	}

/// <summary>
/// <para>
/// Unmaximizes the window. If the window wasn’t maximized, then this
/// function does nothing.
/// </para>
/// <para>
/// On X11, asks the window manager to unmaximize @window, if the
/// window manager supports this operation. Not all window managers
/// support this, and some deliberately ignore it or don’t have a
/// concept of “maximized”; so you can’t rely on the unmaximization
/// actually happening. But it will happen with most standard window
/// managers, and GDK makes a best effort to get it to happen.
/// </para>
/// <para>
/// On Windows, reliably unmaximizes the window.
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow
/// </param>

	public static T Unmaximize<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_unmaximize(window);
		return window;
	}

/// <summary>
/// <para>
/// Reverse operation for gdk_window_stick(); see gdk_window_stick(),
/// and gtk_window_unstick().
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow
/// </param>

	public static T Unstick<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_unstick(window);
		return window;
	}

/// <summary>
/// <para>
/// Withdraws a window (unmaps it and asks the window manager to forget about it).
/// This function is not really useful as gdk_window_hide() automatically
/// withdraws toplevel windows before hiding them.
/// </para>
/// </summary>

/// <param name="window">
/// a toplevel #GdkWindow
/// </param>

	public static T Withdraw<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_withdraw(window);
		return window;
	}

}

internal class GdkWindowHandleExterns
{
	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gdk_window_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle parent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowAttrHandle>))] MentorLake.Gdk.GdkWindowAttrHandle attributes, int attributes_mask);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_add_filter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkFilterFunc function, IntPtr data);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_beep([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDrawingContextHandle>))]
	internal static extern MentorLake.Gdk.GdkDrawingContextHandle gdk_window_begin_draw_frame([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle region);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_begin_move_drag([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, int button, int root_x, int root_y, uint timestamp);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_begin_move_drag_for_device([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, int button, int root_x, int root_y, uint timestamp);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_begin_paint_rect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle rectangle);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_begin_paint_region([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle region);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_begin_resize_drag([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkWindowEdge edge, int button, int root_x, int root_y, uint timestamp);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_begin_resize_drag_for_device([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkWindowEdge edge, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, int button, int root_x, int root_y, uint timestamp);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_configure_finished([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_coords_from_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, double parent_x, double parent_y, out double x, out double y);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_coords_to_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, double x, double y, out double parent_x, out double parent_y);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gdk.GdkGLContextHandle>))]
	internal static extern MentorLake.Gdk.GdkGLContextHandle gdk_window_create_gl_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))]
	internal static extern MentorLake.cairo.cairo_surface_tHandle gdk_window_create_similar_image_surface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, MentorLake.cairo.cairo_format_t format, int width, int height, int scale);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))]
	internal static extern MentorLake.cairo.cairo_surface_tHandle gdk_window_create_similar_surface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, MentorLake.cairo.cairo_content_t content, int width, int height);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_deiconify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_destroy_notify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_enable_synchronized_configure([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_end_draw_frame([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDrawingContextHandle>))] MentorLake.Gdk.GdkDrawingContextHandle context);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_end_paint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_window_ensure_native([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_flush([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, uint timestamp);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_freeze_toplevel_updates_libgtk_only([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_freeze_updates([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_fullscreen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_fullscreen_on_monitor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, int monitor);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_geometry_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_window_get_accept_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))]
	internal static extern MentorLake.cairo.cairo_pattern_tHandle gdk_window_get_background_pattern([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gdk_window_get_children([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gdk_window_get_children_with_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, IntPtr user_data);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))]
	internal static extern MentorLake.cairo.cairo_region_tHandle gdk_window_get_clip_region([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_window_get_composited([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkCursorHandle>))]
	internal static extern MentorLake.Gdk.GdkCursorHandle gdk_window_get_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_window_get_decorations([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, out MentorLake.Gdk.GdkWMDecoration decorations);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkCursorHandle>))]
	internal static extern MentorLake.Gdk.GdkCursorHandle gdk_window_get_device_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkEventMask gdk_window_get_device_events([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gdk_window_get_device_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, out int x, out int y, out MentorLake.Gdk.GdkModifierType mask);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gdk_window_get_device_position_double([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, out double x, out double y, out MentorLake.Gdk.GdkModifierType mask);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))]
	internal static extern MentorLake.Gdk.GdkDisplayHandle gdk_window_get_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkDragProtocol gdk_window_get_drag_protocol([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] out MentorLake.Gdk.GdkWindowHandle target);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gdk_window_get_effective_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gdk_window_get_effective_toplevel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_window_get_event_compression([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkEventMask gdk_window_get_events([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_window_get_focus_on_map([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkFrameClockHandle>))]
	internal static extern MentorLake.Gdk.GdkFrameClockHandle gdk_window_get_frame_clock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_get_frame_extents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, out MentorLake.Gdk.GdkRectangle rect);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkFullscreenMode gdk_window_get_fullscreen_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_get_geometry([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, out int x, out int y, out int width, out int height);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gdk_window_get_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_window_get_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_window_get_modal_hint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_window_get_origin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, out int x, out int y);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gdk_window_get_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_window_get_pass_through([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gdk_window_get_pointer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, out int x, out int y, out MentorLake.Gdk.GdkModifierType mask);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_get_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, out int x, out int y);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_get_root_coords([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, int x, int y, out int root_x, out int root_y);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_get_root_origin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, out int x, out int y);

	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_window_get_scale_factor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))]
	internal static extern MentorLake.Gdk.GdkScreenHandle gdk_window_get_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkEventMask gdk_window_get_source_events([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkInputSource source);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkWindowState gdk_window_get_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_window_get_support_multidevice([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gdk_window_get_toplevel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkWindowTypeHint gdk_window_get_type_hint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))]
	internal static extern MentorLake.cairo.cairo_region_tHandle gdk_window_get_update_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_get_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, out IntPtr data);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))]
	internal static extern MentorLake.cairo.cairo_region_tHandle gdk_window_get_visible_region([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkVisualHandle>))]
	internal static extern MentorLake.Gdk.GdkVisualHandle gdk_window_get_visual([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_window_get_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkWindowType gdk_window_get_window_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_window_has_native([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_hide([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_iconify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_input_shape_combine_region([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle shape_region, int offset_x, int offset_y);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_invalidate_maybe_recurse([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle region, MentorLake.Gdk.GdkWindowChildFunc child_func, IntPtr user_data);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_invalidate_rect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle rect, bool invalidate_children);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_invalidate_region([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle region, bool invalidate_children);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_window_is_destroyed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_window_is_input_only([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_window_is_shaped([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_window_is_viewable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_window_is_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_lower([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_mark_paint_from_clip([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_maximize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_merge_child_input_shapes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_merge_child_shapes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_move([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, int x, int y);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_move_region([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle region, int dx, int dy);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_move_resize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, int x, int y, int width, int height);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_move_to_rect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle rect, MentorLake.Gdk.GdkGravity rect_anchor, MentorLake.Gdk.GdkGravity window_anchor, MentorLake.Gdk.GdkAnchorHints anchor_hints, int rect_anchor_dx, int rect_anchor_dy);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gdk_window_peek_children([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_process_updates([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, bool update_children);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_raise([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_register_dnd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_remove_filter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkFilterFunc function, IntPtr data);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_reparent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle new_parent, int x, int y);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_resize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, int width, int height);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_restack([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle sibling, bool above);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_scroll([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, int dx, int dy);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_set_accept_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, bool accept_focus);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_set_background([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkColorHandle>))] MentorLake.Gdk.GdkColorHandle color);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_set_background_pattern([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] MentorLake.cairo.cairo_pattern_tHandle pattern);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_set_background_rgba([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle rgba);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_set_child_input_shapes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_set_child_shapes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_set_composited([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, bool composited);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_set_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkCursorHandle>))] MentorLake.Gdk.GdkCursorHandle cursor);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_set_decorations([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkWMDecoration decorations);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_set_device_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkCursorHandle>))] MentorLake.Gdk.GdkCursorHandle cursor);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_set_device_events([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, MentorLake.Gdk.GdkEventMask event_mask);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_set_event_compression([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, bool event_compression);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_set_events([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkEventMask event_mask);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_set_focus_on_map([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, bool focus_on_map);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_set_fullscreen_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkFullscreenMode mode);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_set_functions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkWMFunction functions);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_set_geometry_hints([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkGeometryHandle>))] MentorLake.Gdk.GdkGeometryHandle geometry, MentorLake.Gdk.GdkWindowHints geom_mask);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_set_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle leader);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_set_icon_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle pixbufs);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_set_icon_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, string name);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_set_invalidate_handler([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkWindowInvalidateHandlerFunc handler);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_set_keep_above([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, bool setting);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_set_keep_below([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, bool setting);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_set_modal_hint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, bool modal);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_set_opacity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, double opacity);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_set_opaque_region([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle region);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_set_override_redirect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, bool override_redirect);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_set_pass_through([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, bool pass_through);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_set_role([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, string role);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_set_shadow_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, int left, int right, int top, int bottom);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_set_skip_pager_hint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, bool skips_pager);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_set_skip_taskbar_hint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, bool skips_taskbar);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_set_source_events([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkInputSource source, MentorLake.Gdk.GdkEventMask event_mask);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_set_startup_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, string startup_id);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_window_set_static_gravities([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, bool use_static);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_set_support_multidevice([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, bool support_multidevice);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_set_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, string title);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_set_transient_for([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle parent);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_set_type_hint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkWindowTypeHint hint);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_set_urgency_hint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, bool urgent);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_set_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle user_data);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_shape_combine_region([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle shape_region, int offset_x, int offset_y);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_show([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_show_unraised([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_window_show_window_menu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_stick([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_thaw_toplevel_updates_libgtk_only([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_thaw_updates([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_unfullscreen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_unmaximize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_unstick([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_withdraw([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gdk_window_at_pointer(out int win_x, out int win_y);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_constrain_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkGeometryHandle>))] MentorLake.Gdk.GdkGeometryHandle geometry, MentorLake.Gdk.GdkWindowHints flags, int width, int height, out int new_width, out int new_height);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_process_all_updates();

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_window_set_debug_updates(bool setting);

}
