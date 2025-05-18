namespace MentorLake.Gdk;

public class GdkWindowHandle : GObjectHandle
{
	public static MentorLake.Gdk.GdkWindowHandle New(MentorLake.Gdk.GdkWindowHandle parent, MentorLake.Gdk.GdkWindowAttrHandle attributes, int attributes_mask)
	{
		return GdkWindowHandleExterns.gdk_window_new(parent, attributes, attributes_mask);
	}

	public static MentorLake.Gdk.GdkWindowHandle AtPointer(out int win_x, out int win_y)
	{
		return GdkWindowHandleExterns.gdk_window_at_pointer(out win_x, out win_y);
	}

	public static void ConstrainSize(MentorLake.Gdk.GdkGeometryHandle geometry, MentorLake.Gdk.GdkWindowHints flags, int width, int height, out int new_width, out int new_height)
	{
		GdkWindowHandleExterns.gdk_window_constrain_size(geometry, flags, width, height, out new_width, out new_height);
	}

	public static void ProcessAllUpdates()
	{
		GdkWindowHandleExterns.gdk_window_process_all_updates();
	}

	public static void SetDebugUpdates(bool setting)
	{
		GdkWindowHandleExterns.gdk_window_set_debug_updates(setting);
	}

}
public static class GdkWindowHandleSignalExtensions
{

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
	public int Width;
	public int Height;
	public IntPtr UserData;
	public MentorLake.cairo.cairo_surface_tHandle ReturnValue;
}

public class FromEmbedderSignal
{
	public MentorLake.Gdk.GdkWindowHandle Self;
	public double EmbedderX;
	public double EmbedderY;
	public double OffscreenX;
	public double OffscreenY;
	public IntPtr UserData;
}

public class MovedToRectSignal
{
	public MentorLake.Gdk.GdkWindowHandle Self;
	public IntPtr FlippedRect;
	public IntPtr FinalRect;
	public bool FlippedX;
	public bool FlippedY;
	public IntPtr UserData;
}

public class PickEmbeddedChildSignal
{
	public MentorLake.Gdk.GdkWindowHandle Self;
	public double X;
	public double Y;
	public IntPtr UserData;
	public MentorLake.Gdk.GdkWindowHandle ReturnValue;
}

public class ToEmbedderSignal
{
	public MentorLake.Gdk.GdkWindowHandle Self;
	public double OffscreenX;
	public double OffscreenY;
	public double EmbedderX;
	public double EmbedderY;
	public IntPtr UserData;
}
}

public static class GdkWindowHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.cairo.cairo_surface_tHandle create_surface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle self, int width, int height, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void from_embedder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle self, double embedder_x, double embedder_y, out double offscreen_x, out double offscreen_y, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void moved_to_rect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle self, IntPtr flipped_rect, IntPtr final_rect, bool flipped_x, bool flipped_y, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.Gdk.GdkWindowHandle pick_embedded_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle self, double x, double y, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void to_embedder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle self, double offscreen_x, double offscreen_y, out double embedder_x, out double embedder_y, IntPtr user_data);

}


public static class GdkWindowHandleExtensions
{
	public static T AddFilter<T>(this T window, MentorLake.Gdk.GdkFilterFunc function, IntPtr data) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_add_filter(window, function, data);
		return window;
	}

	public static T Beep<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_beep(window);
		return window;
	}

	public static MentorLake.Gdk.GdkDrawingContextHandle BeginDrawFrame(this MentorLake.Gdk.GdkWindowHandle window, MentorLake.cairo.cairo_region_tHandle region)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_begin_draw_frame(window, region);
	}

	public static T BeginMoveDrag<T>(this T window, int button, int root_x, int root_y, uint timestamp) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_begin_move_drag(window, button, root_x, root_y, timestamp);
		return window;
	}

	public static T BeginMoveDragForDevice<T>(this T window, MentorLake.Gdk.GdkDeviceHandle device, int button, int root_x, int root_y, uint timestamp) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_begin_move_drag_for_device(window, device, button, root_x, root_y, timestamp);
		return window;
	}

	public static T BeginPaintRect<T>(this T window, MentorLake.Gdk.GdkRectangleHandle rectangle) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_begin_paint_rect(window, rectangle);
		return window;
	}

	public static T BeginPaintRegion<T>(this T window, MentorLake.cairo.cairo_region_tHandle region) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_begin_paint_region(window, region);
		return window;
	}

	public static T BeginResizeDrag<T>(this T window, MentorLake.Gdk.GdkWindowEdge edge, int button, int root_x, int root_y, uint timestamp) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_begin_resize_drag(window, edge, button, root_x, root_y, timestamp);
		return window;
	}

	public static T BeginResizeDragForDevice<T>(this T window, MentorLake.Gdk.GdkWindowEdge edge, MentorLake.Gdk.GdkDeviceHandle device, int button, int root_x, int root_y, uint timestamp) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_begin_resize_drag_for_device(window, edge, device, button, root_x, root_y, timestamp);
		return window;
	}

	public static T ConfigureFinished<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_configure_finished(window);
		return window;
	}

	public static T CoordsFromParent<T>(this T window, double parent_x, double parent_y, out double x, out double y) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_coords_from_parent(window, parent_x, parent_y, out x, out y);
		return window;
	}

	public static T CoordsToParent<T>(this T window, double x, double y, out double parent_x, out double parent_y) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_coords_to_parent(window, x, y, out parent_x, out parent_y);
		return window;
	}

	public static MentorLake.Gdk.GdkGLContextHandle CreateGlContext(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		var externCallResult = GdkWindowHandleExterns.gdk_window_create_gl_context(window, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.cairo.cairo_surface_tHandle CreateSimilarImageSurface(this MentorLake.Gdk.GdkWindowHandle window, MentorLake.cairo.cairo_format_t format, int width, int height, int scale)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_create_similar_image_surface(window, format, width, height, scale);
	}

	public static MentorLake.cairo.cairo_surface_tHandle CreateSimilarSurface(this MentorLake.Gdk.GdkWindowHandle window, MentorLake.cairo.cairo_content_t content, int width, int height)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_create_similar_surface(window, content, width, height);
	}

	public static T Deiconify<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_deiconify(window);
		return window;
	}

	public static T Destroy<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_destroy(window);
		return window;
	}

	public static T DestroyNotify<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_destroy_notify(window);
		return window;
	}

	public static T EnableSynchronizedConfigure<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_enable_synchronized_configure(window);
		return window;
	}

	public static T EndDrawFrame<T>(this T window, MentorLake.Gdk.GdkDrawingContextHandle context) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_end_draw_frame(window, context);
		return window;
	}

	public static T EndPaint<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_end_paint(window);
		return window;
	}

	public static bool EnsureNative(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_ensure_native(window);
	}

	public static T Flush<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_flush(window);
		return window;
	}

	public static T Focus<T>(this T window, uint timestamp) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_focus(window, timestamp);
		return window;
	}

	public static T FreezeToplevelUpdatesLibgtkOnly<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_freeze_toplevel_updates_libgtk_only(window);
		return window;
	}

	public static T FreezeUpdates<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_freeze_updates(window);
		return window;
	}

	public static T Fullscreen<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_fullscreen(window);
		return window;
	}

	public static T FullscreenOnMonitor<T>(this T window, int monitor) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_fullscreen_on_monitor(window, monitor);
		return window;
	}

	public static T GeometryChanged<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_geometry_changed(window);
		return window;
	}

	public static bool GetAcceptFocus(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_accept_focus(window);
	}

	public static MentorLake.cairo.cairo_pattern_tHandle GetBackgroundPattern(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_background_pattern(window);
	}

	public static MentorLake.GLib.GListHandle GetChildren(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_children(window);
	}

	public static MentorLake.GLib.GListHandle GetChildrenWithUserData(this MentorLake.Gdk.GdkWindowHandle window, IntPtr user_data)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_children_with_user_data(window, user_data);
	}

	public static MentorLake.cairo.cairo_region_tHandle GetClipRegion(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_clip_region(window);
	}

	public static bool GetComposited(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_composited(window);
	}

	public static MentorLake.Gdk.GdkCursorHandle GetCursor(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_cursor(window);
	}

	public static bool GetDecorations(this MentorLake.Gdk.GdkWindowHandle window, out MentorLake.Gdk.GdkWMDecoration decorations)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_decorations(window, out decorations);
	}

	public static MentorLake.Gdk.GdkCursorHandle GetDeviceCursor(this MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_device_cursor(window, device);
	}

	public static MentorLake.Gdk.GdkEventMask GetDeviceEvents(this MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_device_events(window, device);
	}

	public static MentorLake.Gdk.GdkWindowHandle GetDevicePosition(this MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkDeviceHandle device, out int x, out int y, out MentorLake.Gdk.GdkModifierType mask)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_device_position(window, device, out x, out y, out mask);
	}

	public static MentorLake.Gdk.GdkWindowHandle GetDevicePositionDouble(this MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkDeviceHandle device, out double x, out double y, out MentorLake.Gdk.GdkModifierType mask)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_device_position_double(window, device, out x, out y, out mask);
	}

	public static MentorLake.Gdk.GdkDisplayHandle GetDisplay(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_display(window);
	}

	public static MentorLake.Gdk.GdkDragProtocol GetDragProtocol(this MentorLake.Gdk.GdkWindowHandle window, out MentorLake.Gdk.GdkWindowHandle target)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_drag_protocol(window, out target);
	}

	public static MentorLake.Gdk.GdkWindowHandle GetEffectiveParent(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_effective_parent(window);
	}

	public static MentorLake.Gdk.GdkWindowHandle GetEffectiveToplevel(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_effective_toplevel(window);
	}

	public static bool GetEventCompression(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_event_compression(window);
	}

	public static MentorLake.Gdk.GdkEventMask GetEvents(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_events(window);
	}

	public static bool GetFocusOnMap(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_focus_on_map(window);
	}

	public static MentorLake.Gdk.GdkFrameClockHandle GetFrameClock(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_frame_clock(window);
	}

	public static T GetFrameExtents<T>(this T window, out MentorLake.Gdk.GdkRectangle rect) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_get_frame_extents(window, out rect);
		return window;
	}

	public static MentorLake.Gdk.GdkFullscreenMode GetFullscreenMode(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_fullscreen_mode(window);
	}

	public static T GetGeometry<T>(this T window, out int x, out int y, out int width, out int height) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_get_geometry(window, out x, out y, out width, out height);
		return window;
	}

	public static MentorLake.Gdk.GdkWindowHandle GetGroup(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_group(window);
	}

	public static int GetHeight(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_height(window);
	}

	public static bool GetModalHint(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_modal_hint(window);
	}

	public static int GetOrigin(this MentorLake.Gdk.GdkWindowHandle window, out int x, out int y)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_origin(window, out x, out y);
	}

	public static MentorLake.Gdk.GdkWindowHandle GetParent(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_parent(window);
	}

	public static bool GetPassThrough(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_pass_through(window);
	}

	public static MentorLake.Gdk.GdkWindowHandle GetPointer(this MentorLake.Gdk.GdkWindowHandle window, out int x, out int y, out MentorLake.Gdk.GdkModifierType mask)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_pointer(window, out x, out y, out mask);
	}

	public static T GetPosition<T>(this T window, out int x, out int y) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_get_position(window, out x, out y);
		return window;
	}

	public static T GetRootCoords<T>(this T window, int x, int y, out int root_x, out int root_y) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_get_root_coords(window, x, y, out root_x, out root_y);
		return window;
	}

	public static T GetRootOrigin<T>(this T window, out int x, out int y) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_get_root_origin(window, out x, out y);
		return window;
	}

	public static int GetScaleFactor(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_scale_factor(window);
	}

	public static MentorLake.Gdk.GdkScreenHandle GetScreen(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_screen(window);
	}

	public static MentorLake.Gdk.GdkEventMask GetSourceEvents(this MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkInputSource source)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_source_events(window, source);
	}

	public static MentorLake.Gdk.GdkWindowState GetState(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_state(window);
	}

	public static bool GetSupportMultidevice(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_support_multidevice(window);
	}

	public static MentorLake.Gdk.GdkWindowHandle GetToplevel(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_toplevel(window);
	}

	public static MentorLake.Gdk.GdkWindowTypeHint GetTypeHint(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_type_hint(window);
	}

	public static MentorLake.cairo.cairo_region_tHandle GetUpdateArea(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_update_area(window);
	}

	public static T GetUserData<T>(this T window, out IntPtr data) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_get_user_data(window, out data);
		return window;
	}

	public static MentorLake.cairo.cairo_region_tHandle GetVisibleRegion(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_visible_region(window);
	}

	public static MentorLake.Gdk.GdkVisualHandle GetVisual(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_visual(window);
	}

	public static int GetWidth(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_width(window);
	}

	public static MentorLake.Gdk.GdkWindowType GetWindowType(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_get_window_type(window);
	}

	public static bool HasNative(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_has_native(window);
	}

	public static T Hide<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_hide(window);
		return window;
	}

	public static T Iconify<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_iconify(window);
		return window;
	}

	public static T InputShapeCombineRegion<T>(this T window, MentorLake.cairo.cairo_region_tHandle shape_region, int offset_x, int offset_y) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_input_shape_combine_region(window, shape_region, offset_x, offset_y);
		return window;
	}

	public static T InvalidateMaybeRecurse<T>(this T window, MentorLake.cairo.cairo_region_tHandle region, MentorLake.Gdk.GdkWindowChildFunc child_func, IntPtr user_data) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_invalidate_maybe_recurse(window, region, child_func, user_data);
		return window;
	}

	public static T InvalidateRect<T>(this T window, MentorLake.Gdk.GdkRectangleHandle rect, bool invalidate_children) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_invalidate_rect(window, rect, invalidate_children);
		return window;
	}

	public static T InvalidateRegion<T>(this T window, MentorLake.cairo.cairo_region_tHandle region, bool invalidate_children) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_invalidate_region(window, region, invalidate_children);
		return window;
	}

	public static bool IsDestroyed(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_is_destroyed(window);
	}

	public static bool IsInputOnly(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_is_input_only(window);
	}

	public static bool IsShaped(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_is_shaped(window);
	}

	public static bool IsViewable(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_is_viewable(window);
	}

	public static bool IsVisible(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_is_visible(window);
	}

	public static T Lower<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_lower(window);
		return window;
	}

	public static T MarkPaintFromClip<T>(this T window, MentorLake.cairo.cairo_tHandle cr) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_mark_paint_from_clip(window, cr);
		return window;
	}

	public static T Maximize<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_maximize(window);
		return window;
	}

	public static T MergeChildInputShapes<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_merge_child_input_shapes(window);
		return window;
	}

	public static T MergeChildShapes<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_merge_child_shapes(window);
		return window;
	}

	public static T Move<T>(this T window, int x, int y) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_move(window, x, y);
		return window;
	}

	public static T MoveRegion<T>(this T window, MentorLake.cairo.cairo_region_tHandle region, int dx, int dy) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_move_region(window, region, dx, dy);
		return window;
	}

	public static T MoveResize<T>(this T window, int x, int y, int width, int height) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_move_resize(window, x, y, width, height);
		return window;
	}

	public static T MoveToRect<T>(this T window, MentorLake.Gdk.GdkRectangleHandle rect, MentorLake.Gdk.GdkGravity rect_anchor, MentorLake.Gdk.GdkGravity window_anchor, MentorLake.Gdk.GdkAnchorHints anchor_hints, int rect_anchor_dx, int rect_anchor_dy) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_move_to_rect(window, rect, rect_anchor, window_anchor, anchor_hints, rect_anchor_dx, rect_anchor_dy);
		return window;
	}

	public static MentorLake.GLib.GListHandle PeekChildren(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_peek_children(window);
	}

	public static T ProcessUpdates<T>(this T window, bool update_children) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_process_updates(window, update_children);
		return window;
	}

	public static T Raise<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_raise(window);
		return window;
	}

	public static T RegisterDnd<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_register_dnd(window);
		return window;
	}

	public static T RemoveFilter<T>(this T window, MentorLake.Gdk.GdkFilterFunc function, IntPtr data) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_remove_filter(window, function, data);
		return window;
	}

	public static T Reparent<T>(this T window, MentorLake.Gdk.GdkWindowHandle new_parent, int x, int y) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_reparent(window, new_parent, x, y);
		return window;
	}

	public static T Resize<T>(this T window, int width, int height) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_resize(window, width, height);
		return window;
	}

	public static T Restack<T>(this T window, MentorLake.Gdk.GdkWindowHandle sibling, bool above) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_restack(window, sibling, above);
		return window;
	}

	public static T Scroll<T>(this T window, int dx, int dy) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_scroll(window, dx, dy);
		return window;
	}

	public static T SetAcceptFocus<T>(this T window, bool accept_focus) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_accept_focus(window, accept_focus);
		return window;
	}

	public static T SetBackground<T>(this T window, MentorLake.Gdk.GdkColorHandle color) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_background(window, color);
		return window;
	}

	public static T SetBackgroundPattern<T>(this T window, MentorLake.cairo.cairo_pattern_tHandle pattern) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_background_pattern(window, pattern);
		return window;
	}

	public static T SetBackgroundRgba<T>(this T window, MentorLake.Gdk.GdkRGBAHandle rgba) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_background_rgba(window, rgba);
		return window;
	}

	public static T SetChildInputShapes<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_child_input_shapes(window);
		return window;
	}

	public static T SetChildShapes<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_child_shapes(window);
		return window;
	}

	public static T SetComposited<T>(this T window, bool composited) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_composited(window, composited);
		return window;
	}

	public static T SetCursor<T>(this T window, MentorLake.Gdk.GdkCursorHandle cursor) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_cursor(window, cursor);
		return window;
	}

	public static T SetDecorations<T>(this T window, MentorLake.Gdk.GdkWMDecoration decorations) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_decorations(window, decorations);
		return window;
	}

	public static T SetDeviceCursor<T>(this T window, MentorLake.Gdk.GdkDeviceHandle device, MentorLake.Gdk.GdkCursorHandle cursor) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_device_cursor(window, device, cursor);
		return window;
	}

	public static T SetDeviceEvents<T>(this T window, MentorLake.Gdk.GdkDeviceHandle device, MentorLake.Gdk.GdkEventMask event_mask) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_device_events(window, device, event_mask);
		return window;
	}

	public static T SetEventCompression<T>(this T window, bool event_compression) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_event_compression(window, event_compression);
		return window;
	}

	public static T SetEvents<T>(this T window, MentorLake.Gdk.GdkEventMask event_mask) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_events(window, event_mask);
		return window;
	}

	public static T SetFocusOnMap<T>(this T window, bool focus_on_map) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_focus_on_map(window, focus_on_map);
		return window;
	}

	public static T SetFullscreenMode<T>(this T window, MentorLake.Gdk.GdkFullscreenMode mode) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_fullscreen_mode(window, mode);
		return window;
	}

	public static T SetFunctions<T>(this T window, MentorLake.Gdk.GdkWMFunction functions) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_functions(window, functions);
		return window;
	}

	public static T SetGeometryHints<T>(this T window, MentorLake.Gdk.GdkGeometryHandle geometry, MentorLake.Gdk.GdkWindowHints geom_mask) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_geometry_hints(window, geometry, geom_mask);
		return window;
	}

	public static T SetGroup<T>(this T window, MentorLake.Gdk.GdkWindowHandle leader) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_group(window, leader);
		return window;
	}

	public static T SetIconList<T>(this T window, MentorLake.GLib.GListHandle pixbufs) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_icon_list(window, pixbufs);
		return window;
	}

	public static T SetIconName<T>(this T window, string name) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_icon_name(window, name);
		return window;
	}

	public static T SetInvalidateHandler<T>(this T window, MentorLake.Gdk.GdkWindowInvalidateHandlerFunc handler) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_invalidate_handler(window, handler);
		return window;
	}

	public static T SetKeepAbove<T>(this T window, bool setting) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_keep_above(window, setting);
		return window;
	}

	public static T SetKeepBelow<T>(this T window, bool setting) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_keep_below(window, setting);
		return window;
	}

	public static T SetModalHint<T>(this T window, bool modal) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_modal_hint(window, modal);
		return window;
	}

	public static T SetOpacity<T>(this T window, double opacity) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_opacity(window, opacity);
		return window;
	}

	public static T SetOpaqueRegion<T>(this T window, MentorLake.cairo.cairo_region_tHandle region) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_opaque_region(window, region);
		return window;
	}

	public static T SetOverrideRedirect<T>(this T window, bool override_redirect) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_override_redirect(window, override_redirect);
		return window;
	}

	public static T SetPassThrough<T>(this T window, bool pass_through) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_pass_through(window, pass_through);
		return window;
	}

	public static T SetRole<T>(this T window, string role) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_role(window, role);
		return window;
	}

	public static T SetShadowWidth<T>(this T window, int left, int right, int top, int bottom) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_shadow_width(window, left, right, top, bottom);
		return window;
	}

	public static T SetSkipPagerHint<T>(this T window, bool skips_pager) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_skip_pager_hint(window, skips_pager);
		return window;
	}

	public static T SetSkipTaskbarHint<T>(this T window, bool skips_taskbar) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_skip_taskbar_hint(window, skips_taskbar);
		return window;
	}

	public static T SetSourceEvents<T>(this T window, MentorLake.Gdk.GdkInputSource source, MentorLake.Gdk.GdkEventMask event_mask) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_source_events(window, source, event_mask);
		return window;
	}

	public static T SetStartupId<T>(this T window, string startup_id) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_startup_id(window, startup_id);
		return window;
	}

	public static bool SetStaticGravities(this MentorLake.Gdk.GdkWindowHandle window, bool use_static)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_set_static_gravities(window, use_static);
	}

	public static T SetSupportMultidevice<T>(this T window, bool support_multidevice) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_support_multidevice(window, support_multidevice);
		return window;
	}

	public static T SetTitle<T>(this T window, string title) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_title(window, title);
		return window;
	}

	public static T SetTransientFor<T>(this T window, MentorLake.Gdk.GdkWindowHandle parent) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_transient_for(window, parent);
		return window;
	}

	public static T SetTypeHint<T>(this T window, MentorLake.Gdk.GdkWindowTypeHint hint) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_type_hint(window, hint);
		return window;
	}

	public static T SetUrgencyHint<T>(this T window, bool urgent) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_urgency_hint(window, urgent);
		return window;
	}

	public static T SetUserData<T>(this T window, MentorLake.GObject.GObjectHandle user_data) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_set_user_data(window, user_data);
		return window;
	}

	public static T ShapeCombineRegion<T>(this T window, MentorLake.cairo.cairo_region_tHandle shape_region, int offset_x, int offset_y) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_shape_combine_region(window, shape_region, offset_x, offset_y);
		return window;
	}

	public static T Show<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_show(window);
		return window;
	}

	public static T ShowUnraised<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_show_unraised(window);
		return window;
	}

	public static bool ShowWindowMenu(this MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkEventHandle @event)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		return GdkWindowHandleExterns.gdk_window_show_window_menu(window, @event);
	}

	public static T Stick<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_stick(window);
		return window;
	}

	public static T ThawToplevelUpdatesLibgtkOnly<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_thaw_toplevel_updates_libgtk_only(window);
		return window;
	}

	public static T ThawUpdates<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_thaw_updates(window);
		return window;
	}

	public static T Unfullscreen<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_unfullscreen(window);
		return window;
	}

	public static T Unmaximize<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_unmaximize(window);
		return window;
	}

	public static T Unstick<T>(this T window) where T : GdkWindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkWindowHandle)");
		GdkWindowHandleExterns.gdk_window_unstick(window);
		return window;
	}

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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkGLContextHandle>))]
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
