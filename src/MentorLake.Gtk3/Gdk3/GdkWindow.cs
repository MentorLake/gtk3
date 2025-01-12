namespace MentorLake.Gtk3.Gdk3;

public class GdkWindowHandle : GObjectHandle
{
	public static GdkWindowHandle New(GdkWindowHandle parent, GdkWindowAttrHandle attributes, int attributes_mask)
	{
		return GdkWindowExterns.gdk_window_new(parent, attributes, attributes_mask);
	}

	public static GdkWindowHandle AtPointer(out int win_x, out int win_y)
	{
		return GdkWindowExterns.gdk_window_at_pointer(out win_x, out win_y);
	}

	public static void ConstrainSize(GdkGeometryHandle geometry, GdkWindowHints flags, int width, int height, out int new_width, out int new_height)
	{
		GdkWindowExterns.gdk_window_constrain_size(geometry, flags, width, height, out new_width, out new_height);
	}

	public static void ProcessAllUpdates()
	{
		GdkWindowExterns.gdk_window_process_all_updates();
	}

	public static void SetDebugUpdates(bool setting)
	{
		GdkWindowExterns.gdk_window_set_debug_updates(setting);
	}

}

public static class GdkWindowSignalExtensions
{

	public static IObservable<GdkWindowSignalStructs.CreateSurfaceSignal> Signal_CreateSurface(this GdkWindowHandle instance)
	{
		return Observable.Create((IObserver<GdkWindowSignalStructs.CreateSurfaceSignal> obs) =>
		{
			GdkWindowSignalDelegates.create_surface handler = (GdkWindowHandle self, int width, int height, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkWindowSignalStructs.CreateSurfaceSignal()
				{
					Self = self, Width = width, Height = height, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "create_surface", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GdkWindowSignalStructs.FromEmbedderSignal> Signal_FromEmbedder(this GdkWindowHandle instance)
	{
		return Observable.Create((IObserver<GdkWindowSignalStructs.FromEmbedderSignal> obs) =>
		{
			GdkWindowSignalDelegates.from_embedder handler = (GdkWindowHandle self, double embedder_x, double embedder_y, out double offscreen_x, out double offscreen_y, IntPtr user_data) =>
			{
				offscreen_x = default;
			offscreen_y = default;

				var signalStruct = new GdkWindowSignalStructs.FromEmbedderSignal()
				{
					Self = self, EmbedderX = embedder_x, EmbedderY = embedder_y, OffscreenX = offscreen_x, OffscreenY = offscreen_y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "from_embedder", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GdkWindowSignalStructs.MovedToRectSignal> Signal_MovedToRect(this GdkWindowHandle instance)
	{
		return Observable.Create((IObserver<GdkWindowSignalStructs.MovedToRectSignal> obs) =>
		{
			GdkWindowSignalDelegates.moved_to_rect handler = (GdkWindowHandle self, IntPtr flipped_rect, IntPtr final_rect, bool flipped_x, bool flipped_y, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkWindowSignalStructs.MovedToRectSignal()
				{
					Self = self, FlippedRect = flipped_rect, FinalRect = final_rect, FlippedX = flipped_x, FlippedY = flipped_y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "moved_to_rect", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GdkWindowSignalStructs.PickEmbeddedChildSignal> Signal_PickEmbeddedChild(this GdkWindowHandle instance)
	{
		return Observable.Create((IObserver<GdkWindowSignalStructs.PickEmbeddedChildSignal> obs) =>
		{
			GdkWindowSignalDelegates.pick_embedded_child handler = (GdkWindowHandle self, double x, double y, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkWindowSignalStructs.PickEmbeddedChildSignal()
				{
					Self = self, X = x, Y = y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "pick_embedded_child", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GdkWindowSignalStructs.ToEmbedderSignal> Signal_ToEmbedder(this GdkWindowHandle instance)
	{
		return Observable.Create((IObserver<GdkWindowSignalStructs.ToEmbedderSignal> obs) =>
		{
			GdkWindowSignalDelegates.to_embedder handler = (GdkWindowHandle self, double offscreen_x, double offscreen_y, out double embedder_x, out double embedder_y, IntPtr user_data) =>
			{
				embedder_x = default;
			embedder_y = default;

				var signalStruct = new GdkWindowSignalStructs.ToEmbedderSignal()
				{
					Self = self, OffscreenX = offscreen_x, OffscreenY = offscreen_y, EmbedderX = embedder_x, EmbedderY = embedder_y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "to_embedder", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GdkWindowSignalStructs
{

public struct CreateSurfaceSignal
{
	public GdkWindowHandle Self;
	public int Width;
	public int Height;
	public IntPtr UserData;
	public cairo_surface_tHandle ReturnValue;
}

public struct FromEmbedderSignal
{
	public GdkWindowHandle Self;
	public double EmbedderX;
	public double EmbedderY;
	public double OffscreenX;
	public double OffscreenY;
	public IntPtr UserData;
}

public struct MovedToRectSignal
{
	public GdkWindowHandle Self;
	public IntPtr FlippedRect;
	public IntPtr FinalRect;
	public bool FlippedX;
	public bool FlippedY;
	public IntPtr UserData;
}

public struct PickEmbeddedChildSignal
{
	public GdkWindowHandle Self;
	public double X;
	public double Y;
	public IntPtr UserData;
	public GdkWindowHandle ReturnValue;
}

public struct ToEmbedderSignal
{
	public GdkWindowHandle Self;
	public double OffscreenX;
	public double OffscreenY;
	public double EmbedderX;
	public double EmbedderY;
	public IntPtr UserData;
}
}

public static class GdkWindowSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate cairo_surface_tHandle create_surface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkWindowHandle>))] GdkWindowHandle self, int width, int height, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void from_embedder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkWindowHandle>))] GdkWindowHandle self, double embedder_x, double embedder_y, out double offscreen_x, out double offscreen_y, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void moved_to_rect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkWindowHandle>))] GdkWindowHandle self, IntPtr flipped_rect, IntPtr final_rect, bool flipped_x, bool flipped_y, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate GdkWindowHandle pick_embedded_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkWindowHandle>))] GdkWindowHandle self, double x, double y, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void to_embedder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkWindowHandle>))] GdkWindowHandle self, double offscreen_x, double offscreen_y, out double embedder_x, out double embedder_y, IntPtr user_data);

}


public static class GdkWindowHandleExtensions
{
	public static T AddFilter<T>(this T window, GdkFilterFunc function, IntPtr data) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_add_filter(window, function, data);
		return window;
	}

	public static T Beep<T>(this T window) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_beep(window);
		return window;
	}

	public static GdkDrawingContextHandle BeginDrawFrame(this GdkWindowHandle window, cairo_region_tHandle region)
	{
		return GdkWindowExterns.gdk_window_begin_draw_frame(window, region);
	}

	public static T BeginMoveDrag<T>(this T window, int button, int root_x, int root_y, uint timestamp) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_begin_move_drag(window, button, root_x, root_y, timestamp);
		return window;
	}

	public static T BeginMoveDragForDevice<T>(this T window, GdkDeviceHandle device, int button, int root_x, int root_y, uint timestamp) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_begin_move_drag_for_device(window, device, button, root_x, root_y, timestamp);
		return window;
	}

	public static T BeginPaintRect<T>(this T window, GdkRectangleHandle rectangle) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_begin_paint_rect(window, rectangle);
		return window;
	}

	public static T BeginPaintRegion<T>(this T window, cairo_region_tHandle region) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_begin_paint_region(window, region);
		return window;
	}

	public static T BeginResizeDrag<T>(this T window, GdkWindowEdge edge, int button, int root_x, int root_y, uint timestamp) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_begin_resize_drag(window, edge, button, root_x, root_y, timestamp);
		return window;
	}

	public static T BeginResizeDragForDevice<T>(this T window, GdkWindowEdge edge, GdkDeviceHandle device, int button, int root_x, int root_y, uint timestamp) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_begin_resize_drag_for_device(window, edge, device, button, root_x, root_y, timestamp);
		return window;
	}

	public static T ConfigureFinished<T>(this T window) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_configure_finished(window);
		return window;
	}

	public static T CoordsFromParent<T>(this T window, double parent_x, double parent_y, out double x, out double y) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_coords_from_parent(window, parent_x, parent_y, out x, out y);
		return window;
	}

	public static T CoordsToParent<T>(this T window, double x, double y, out double parent_x, out double parent_y) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_coords_to_parent(window, x, y, out parent_x, out parent_y);
		return window;
	}

	public static GdkGLContextHandle CreateGlContext(this GdkWindowHandle window, out GErrorHandle error)
	{
		return GdkWindowExterns.gdk_window_create_gl_context(window, out error);
	}

	public static cairo_surface_tHandle CreateSimilarImageSurface(this GdkWindowHandle window, cairo_format_t format, int width, int height, int scale)
	{
		return GdkWindowExterns.gdk_window_create_similar_image_surface(window, format, width, height, scale);
	}

	public static cairo_surface_tHandle CreateSimilarSurface(this GdkWindowHandle window, cairo_content_t content, int width, int height)
	{
		return GdkWindowExterns.gdk_window_create_similar_surface(window, content, width, height);
	}

	public static T Deiconify<T>(this T window) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_deiconify(window);
		return window;
	}

	public static T Destroy<T>(this T window) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_destroy(window);
		return window;
	}

	public static T DestroyNotify<T>(this T window) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_destroy_notify(window);
		return window;
	}

	public static T EnableSynchronizedConfigure<T>(this T window) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_enable_synchronized_configure(window);
		return window;
	}

	public static T EndDrawFrame<T>(this T window, GdkDrawingContextHandle context) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_end_draw_frame(window, context);
		return window;
	}

	public static T EndPaint<T>(this T window) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_end_paint(window);
		return window;
	}

	public static bool EnsureNative(this GdkWindowHandle window)
	{
		return GdkWindowExterns.gdk_window_ensure_native(window);
	}

	public static T Flush<T>(this T window) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_flush(window);
		return window;
	}

	public static T Focus<T>(this T window, uint timestamp) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_focus(window, timestamp);
		return window;
	}

	public static T FreezeToplevelUpdatesLibgtkOnly<T>(this T window) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_freeze_toplevel_updates_libgtk_only(window);
		return window;
	}

	public static T FreezeUpdates<T>(this T window) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_freeze_updates(window);
		return window;
	}

	public static T Fullscreen<T>(this T window) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_fullscreen(window);
		return window;
	}

	public static T FullscreenOnMonitor<T>(this T window, int monitor) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_fullscreen_on_monitor(window, monitor);
		return window;
	}

	public static T GeometryChanged<T>(this T window) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_geometry_changed(window);
		return window;
	}

	public static bool GetAcceptFocus(this GdkWindowHandle window)
	{
		return GdkWindowExterns.gdk_window_get_accept_focus(window);
	}

	public static cairo_pattern_tHandle GetBackgroundPattern(this GdkWindowHandle window)
	{
		return GdkWindowExterns.gdk_window_get_background_pattern(window);
	}

	public static GListHandle GetChildren(this GdkWindowHandle window)
	{
		return GdkWindowExterns.gdk_window_get_children(window);
	}

	public static GListHandle GetChildrenWithUserData(this GdkWindowHandle window, IntPtr user_data)
	{
		return GdkWindowExterns.gdk_window_get_children_with_user_data(window, user_data);
	}

	public static cairo_region_tHandle GetClipRegion(this GdkWindowHandle window)
	{
		return GdkWindowExterns.gdk_window_get_clip_region(window);
	}

	public static bool GetComposited(this GdkWindowHandle window)
	{
		return GdkWindowExterns.gdk_window_get_composited(window);
	}

	public static GdkCursorHandle GetCursor(this GdkWindowHandle window)
	{
		return GdkWindowExterns.gdk_window_get_cursor(window);
	}

	public static bool GetDecorations(this GdkWindowHandle window, out GdkWMDecoration decorations)
	{
		return GdkWindowExterns.gdk_window_get_decorations(window, out decorations);
	}

	public static GdkCursorHandle GetDeviceCursor(this GdkWindowHandle window, GdkDeviceHandle device)
	{
		return GdkWindowExterns.gdk_window_get_device_cursor(window, device);
	}

	public static GdkEventMask GetDeviceEvents(this GdkWindowHandle window, GdkDeviceHandle device)
	{
		return GdkWindowExterns.gdk_window_get_device_events(window, device);
	}

	public static GdkWindowHandle GetDevicePosition(this GdkWindowHandle window, GdkDeviceHandle device, out int x, out int y, out GdkModifierType mask)
	{
		return GdkWindowExterns.gdk_window_get_device_position(window, device, out x, out y, out mask);
	}

	public static GdkWindowHandle GetDevicePositionDouble(this GdkWindowHandle window, GdkDeviceHandle device, out double x, out double y, out GdkModifierType mask)
	{
		return GdkWindowExterns.gdk_window_get_device_position_double(window, device, out x, out y, out mask);
	}

	public static GdkDisplayHandle GetDisplay(this GdkWindowHandle window)
	{
		return GdkWindowExterns.gdk_window_get_display(window);
	}

	public static GdkDragProtocol GetDragProtocol(this GdkWindowHandle window, out GdkWindowHandle target)
	{
		return GdkWindowExterns.gdk_window_get_drag_protocol(window, out target);
	}

	public static GdkWindowHandle GetEffectiveParent(this GdkWindowHandle window)
	{
		return GdkWindowExterns.gdk_window_get_effective_parent(window);
	}

	public static GdkWindowHandle GetEffectiveToplevel(this GdkWindowHandle window)
	{
		return GdkWindowExterns.gdk_window_get_effective_toplevel(window);
	}

	public static bool GetEventCompression(this GdkWindowHandle window)
	{
		return GdkWindowExterns.gdk_window_get_event_compression(window);
	}

	public static GdkEventMask GetEvents(this GdkWindowHandle window)
	{
		return GdkWindowExterns.gdk_window_get_events(window);
	}

	public static bool GetFocusOnMap(this GdkWindowHandle window)
	{
		return GdkWindowExterns.gdk_window_get_focus_on_map(window);
	}

	public static GdkFrameClockHandle GetFrameClock(this GdkWindowHandle window)
	{
		return GdkWindowExterns.gdk_window_get_frame_clock(window);
	}

	public static T GetFrameExtents<T>(this T window, out GdkRectangle rect) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_get_frame_extents(window, out rect);
		return window;
	}

	public static GdkFullscreenMode GetFullscreenMode(this GdkWindowHandle window)
	{
		return GdkWindowExterns.gdk_window_get_fullscreen_mode(window);
	}

	public static T GetGeometry<T>(this T window, out int x, out int y, out int width, out int height) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_get_geometry(window, out x, out y, out width, out height);
		return window;
	}

	public static GdkWindowHandle GetGroup(this GdkWindowHandle window)
	{
		return GdkWindowExterns.gdk_window_get_group(window);
	}

	public static int GetHeight(this GdkWindowHandle window)
	{
		return GdkWindowExterns.gdk_window_get_height(window);
	}

	public static bool GetModalHint(this GdkWindowHandle window)
	{
		return GdkWindowExterns.gdk_window_get_modal_hint(window);
	}

	public static int GetOrigin(this GdkWindowHandle window, out int x, out int y)
	{
		return GdkWindowExterns.gdk_window_get_origin(window, out x, out y);
	}

	public static GdkWindowHandle GetParent(this GdkWindowHandle window)
	{
		return GdkWindowExterns.gdk_window_get_parent(window);
	}

	public static bool GetPassThrough(this GdkWindowHandle window)
	{
		return GdkWindowExterns.gdk_window_get_pass_through(window);
	}

	public static GdkWindowHandle GetPointer(this GdkWindowHandle window, out int x, out int y, out GdkModifierType mask)
	{
		return GdkWindowExterns.gdk_window_get_pointer(window, out x, out y, out mask);
	}

	public static T GetPosition<T>(this T window, out int x, out int y) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_get_position(window, out x, out y);
		return window;
	}

	public static T GetRootCoords<T>(this T window, int x, int y, out int root_x, out int root_y) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_get_root_coords(window, x, y, out root_x, out root_y);
		return window;
	}

	public static T GetRootOrigin<T>(this T window, out int x, out int y) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_get_root_origin(window, out x, out y);
		return window;
	}

	public static int GetScaleFactor(this GdkWindowHandle window)
	{
		return GdkWindowExterns.gdk_window_get_scale_factor(window);
	}

	public static GdkScreenHandle GetScreen(this GdkWindowHandle window)
	{
		return GdkWindowExterns.gdk_window_get_screen(window);
	}

	public static GdkEventMask GetSourceEvents(this GdkWindowHandle window, GdkInputSource source)
	{
		return GdkWindowExterns.gdk_window_get_source_events(window, source);
	}

	public static GdkWindowState GetState(this GdkWindowHandle window)
	{
		return GdkWindowExterns.gdk_window_get_state(window);
	}

	public static bool GetSupportMultidevice(this GdkWindowHandle window)
	{
		return GdkWindowExterns.gdk_window_get_support_multidevice(window);
	}

	public static GdkWindowHandle GetToplevel(this GdkWindowHandle window)
	{
		return GdkWindowExterns.gdk_window_get_toplevel(window);
	}

	public static GdkWindowTypeHint GetTypeHint(this GdkWindowHandle window)
	{
		return GdkWindowExterns.gdk_window_get_type_hint(window);
	}

	public static cairo_region_tHandle GetUpdateArea(this GdkWindowHandle window)
	{
		return GdkWindowExterns.gdk_window_get_update_area(window);
	}

	public static T GetUserData<T>(this T window, out IntPtr data) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_get_user_data(window, out data);
		return window;
	}

	public static cairo_region_tHandle GetVisibleRegion(this GdkWindowHandle window)
	{
		return GdkWindowExterns.gdk_window_get_visible_region(window);
	}

	public static GdkVisualHandle GetVisual(this GdkWindowHandle window)
	{
		return GdkWindowExterns.gdk_window_get_visual(window);
	}

	public static int GetWidth(this GdkWindowHandle window)
	{
		return GdkWindowExterns.gdk_window_get_width(window);
	}

	public static GdkWindowType GetWindowType(this GdkWindowHandle window)
	{
		return GdkWindowExterns.gdk_window_get_window_type(window);
	}

	public static bool HasNative(this GdkWindowHandle window)
	{
		return GdkWindowExterns.gdk_window_has_native(window);
	}

	public static T Hide<T>(this T window) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_hide(window);
		return window;
	}

	public static T Iconify<T>(this T window) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_iconify(window);
		return window;
	}

	public static T InputShapeCombineRegion<T>(this T window, cairo_region_tHandle shape_region, int offset_x, int offset_y) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_input_shape_combine_region(window, shape_region, offset_x, offset_y);
		return window;
	}

	public static T InvalidateMaybeRecurse<T>(this T window, cairo_region_tHandle region, GdkWindowChildFunc child_func, IntPtr user_data) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_invalidate_maybe_recurse(window, region, child_func, user_data);
		return window;
	}

	public static T InvalidateRect<T>(this T window, GdkRectangleHandle rect, bool invalidate_children) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_invalidate_rect(window, rect, invalidate_children);
		return window;
	}

	public static T InvalidateRegion<T>(this T window, cairo_region_tHandle region, bool invalidate_children) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_invalidate_region(window, region, invalidate_children);
		return window;
	}

	public static bool IsDestroyed(this GdkWindowHandle window)
	{
		return GdkWindowExterns.gdk_window_is_destroyed(window);
	}

	public static bool IsInputOnly(this GdkWindowHandle window)
	{
		return GdkWindowExterns.gdk_window_is_input_only(window);
	}

	public static bool IsShaped(this GdkWindowHandle window)
	{
		return GdkWindowExterns.gdk_window_is_shaped(window);
	}

	public static bool IsViewable(this GdkWindowHandle window)
	{
		return GdkWindowExterns.gdk_window_is_viewable(window);
	}

	public static bool IsVisible(this GdkWindowHandle window)
	{
		return GdkWindowExterns.gdk_window_is_visible(window);
	}

	public static T Lower<T>(this T window) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_lower(window);
		return window;
	}

	public static T MarkPaintFromClip<T>(this T window, cairo_tHandle cr) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_mark_paint_from_clip(window, cr);
		return window;
	}

	public static T Maximize<T>(this T window) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_maximize(window);
		return window;
	}

	public static T MergeChildInputShapes<T>(this T window) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_merge_child_input_shapes(window);
		return window;
	}

	public static T MergeChildShapes<T>(this T window) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_merge_child_shapes(window);
		return window;
	}

	public static T Move<T>(this T window, int x, int y) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_move(window, x, y);
		return window;
	}

	public static T MoveRegion<T>(this T window, cairo_region_tHandle region, int dx, int dy) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_move_region(window, region, dx, dy);
		return window;
	}

	public static T MoveResize<T>(this T window, int x, int y, int width, int height) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_move_resize(window, x, y, width, height);
		return window;
	}

	public static T MoveToRect<T>(this T window, GdkRectangleHandle rect, GdkGravity rect_anchor, GdkGravity window_anchor, GdkAnchorHints anchor_hints, int rect_anchor_dx, int rect_anchor_dy) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_move_to_rect(window, rect, rect_anchor, window_anchor, anchor_hints, rect_anchor_dx, rect_anchor_dy);
		return window;
	}

	public static GListHandle PeekChildren(this GdkWindowHandle window)
	{
		return GdkWindowExterns.gdk_window_peek_children(window);
	}

	public static T ProcessUpdates<T>(this T window, bool update_children) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_process_updates(window, update_children);
		return window;
	}

	public static T Raise<T>(this T window) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_raise(window);
		return window;
	}

	public static T RegisterDnd<T>(this T window) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_register_dnd(window);
		return window;
	}

	public static T RemoveFilter<T>(this T window, GdkFilterFunc function, IntPtr data) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_remove_filter(window, function, data);
		return window;
	}

	public static T Reparent<T>(this T window, GdkWindowHandle new_parent, int x, int y) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_reparent(window, new_parent, x, y);
		return window;
	}

	public static T Resize<T>(this T window, int width, int height) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_resize(window, width, height);
		return window;
	}

	public static T Restack<T>(this T window, GdkWindowHandle sibling, bool above) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_restack(window, sibling, above);
		return window;
	}

	public static T Scroll<T>(this T window, int dx, int dy) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_scroll(window, dx, dy);
		return window;
	}

	public static T SetAcceptFocus<T>(this T window, bool accept_focus) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_set_accept_focus(window, accept_focus);
		return window;
	}

	public static T SetBackground<T>(this T window, GdkColorHandle color) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_set_background(window, color);
		return window;
	}

	public static T SetBackgroundPattern<T>(this T window, cairo_pattern_tHandle pattern) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_set_background_pattern(window, pattern);
		return window;
	}

	public static T SetBackgroundRgba<T>(this T window, GdkRGBAHandle rgba) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_set_background_rgba(window, rgba);
		return window;
	}

	public static T SetChildInputShapes<T>(this T window) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_set_child_input_shapes(window);
		return window;
	}

	public static T SetChildShapes<T>(this T window) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_set_child_shapes(window);
		return window;
	}

	public static T SetComposited<T>(this T window, bool composited) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_set_composited(window, composited);
		return window;
	}

	public static T SetCursor<T>(this T window, GdkCursorHandle cursor) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_set_cursor(window, cursor);
		return window;
	}

	public static T SetDecorations<T>(this T window, GdkWMDecoration decorations) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_set_decorations(window, decorations);
		return window;
	}

	public static T SetDeviceCursor<T>(this T window, GdkDeviceHandle device, GdkCursorHandle cursor) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_set_device_cursor(window, device, cursor);
		return window;
	}

	public static T SetDeviceEvents<T>(this T window, GdkDeviceHandle device, GdkEventMask event_mask) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_set_device_events(window, device, event_mask);
		return window;
	}

	public static T SetEventCompression<T>(this T window, bool event_compression) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_set_event_compression(window, event_compression);
		return window;
	}

	public static T SetEvents<T>(this T window, GdkEventMask event_mask) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_set_events(window, event_mask);
		return window;
	}

	public static T SetFocusOnMap<T>(this T window, bool focus_on_map) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_set_focus_on_map(window, focus_on_map);
		return window;
	}

	public static T SetFullscreenMode<T>(this T window, GdkFullscreenMode mode) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_set_fullscreen_mode(window, mode);
		return window;
	}

	public static T SetFunctions<T>(this T window, GdkWMFunction functions) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_set_functions(window, functions);
		return window;
	}

	public static T SetGeometryHints<T>(this T window, GdkGeometryHandle geometry, GdkWindowHints geom_mask) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_set_geometry_hints(window, geometry, geom_mask);
		return window;
	}

	public static T SetGroup<T>(this T window, GdkWindowHandle leader) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_set_group(window, leader);
		return window;
	}

	public static T SetIconList<T>(this T window, GListHandle pixbufs) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_set_icon_list(window, pixbufs);
		return window;
	}

	public static T SetIconName<T>(this T window, string name) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_set_icon_name(window, name);
		return window;
	}

	public static T SetInvalidateHandler<T>(this T window, GdkWindowInvalidateHandlerFunc handler) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_set_invalidate_handler(window, handler);
		return window;
	}

	public static T SetKeepAbove<T>(this T window, bool setting) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_set_keep_above(window, setting);
		return window;
	}

	public static T SetKeepBelow<T>(this T window, bool setting) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_set_keep_below(window, setting);
		return window;
	}

	public static T SetModalHint<T>(this T window, bool modal) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_set_modal_hint(window, modal);
		return window;
	}

	public static T SetOpacity<T>(this T window, double opacity) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_set_opacity(window, opacity);
		return window;
	}

	public static T SetOpaqueRegion<T>(this T window, cairo_region_tHandle region) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_set_opaque_region(window, region);
		return window;
	}

	public static T SetOverrideRedirect<T>(this T window, bool override_redirect) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_set_override_redirect(window, override_redirect);
		return window;
	}

	public static T SetPassThrough<T>(this T window, bool pass_through) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_set_pass_through(window, pass_through);
		return window;
	}

	public static T SetRole<T>(this T window, string role) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_set_role(window, role);
		return window;
	}

	public static T SetShadowWidth<T>(this T window, int left, int right, int top, int bottom) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_set_shadow_width(window, left, right, top, bottom);
		return window;
	}

	public static T SetSkipPagerHint<T>(this T window, bool skips_pager) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_set_skip_pager_hint(window, skips_pager);
		return window;
	}

	public static T SetSkipTaskbarHint<T>(this T window, bool skips_taskbar) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_set_skip_taskbar_hint(window, skips_taskbar);
		return window;
	}

	public static T SetSourceEvents<T>(this T window, GdkInputSource source, GdkEventMask event_mask) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_set_source_events(window, source, event_mask);
		return window;
	}

	public static T SetStartupId<T>(this T window, string startup_id) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_set_startup_id(window, startup_id);
		return window;
	}

	public static bool SetStaticGravities(this GdkWindowHandle window, bool use_static)
	{
		return GdkWindowExterns.gdk_window_set_static_gravities(window, use_static);
	}

	public static T SetSupportMultidevice<T>(this T window, bool support_multidevice) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_set_support_multidevice(window, support_multidevice);
		return window;
	}

	public static T SetTitle<T>(this T window, string title) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_set_title(window, title);
		return window;
	}

	public static T SetTransientFor<T>(this T window, GdkWindowHandle parent) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_set_transient_for(window, parent);
		return window;
	}

	public static T SetTypeHint<T>(this T window, GdkWindowTypeHint hint) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_set_type_hint(window, hint);
		return window;
	}

	public static T SetUrgencyHint<T>(this T window, bool urgent) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_set_urgency_hint(window, urgent);
		return window;
	}

	public static T SetUserData<T>(this T window, GObjectHandle user_data) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_set_user_data(window, user_data);
		return window;
	}

	public static T ShapeCombineRegion<T>(this T window, cairo_region_tHandle shape_region, int offset_x, int offset_y) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_shape_combine_region(window, shape_region, offset_x, offset_y);
		return window;
	}

	public static T Show<T>(this T window) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_show(window);
		return window;
	}

	public static T ShowUnraised<T>(this T window) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_show_unraised(window);
		return window;
	}

	public static bool ShowWindowMenu(this GdkWindowHandle window, GdkEventHandle @event)
	{
		return GdkWindowExterns.gdk_window_show_window_menu(window, @event);
	}

	public static T Stick<T>(this T window) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_stick(window);
		return window;
	}

	public static T ThawToplevelUpdatesLibgtkOnly<T>(this T window) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_thaw_toplevel_updates_libgtk_only(window);
		return window;
	}

	public static T ThawUpdates<T>(this T window) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_thaw_updates(window);
		return window;
	}

	public static T Unfullscreen<T>(this T window) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_unfullscreen(window);
		return window;
	}

	public static T Unmaximize<T>(this T window) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_unmaximize(window);
		return window;
	}

	public static T Unstick<T>(this T window) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_unstick(window);
		return window;
	}

	public static T Withdraw<T>(this T window) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_window_withdraw(window);
		return window;
	}

	public static T GdkOffscreenWindowSetEmbedder<T>(this T window, GdkWindowHandle embedder) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_offscreen_window_set_embedder(window, embedder);
		return window;
	}

	public static GdkGrabStatus GdkKeyboardGrab(this GdkWindowHandle window, bool owner_events, uint time_)
	{
		return GdkWindowExterns.gdk_keyboard_grab(window, owner_events, time_);
	}

	public static T GdkSelectionSendNotify<T>(this T requestor, GdkAtom selection, GdkAtom target, GdkAtom property, uint time_) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_selection_send_notify(requestor, selection, target, property, time_);
		return requestor;
	}

	public static GdkDragContextHandle GdkDragBegin(this GdkWindowHandle window, GListHandle targets)
	{
		return GdkWindowExterns.gdk_drag_begin(window, targets);
	}

	public static GdkDragContextHandle GdkDragBeginFromPoint(this GdkWindowHandle window, GdkDeviceHandle device, GListHandle targets, int x_root, int y_root)
	{
		return GdkWindowExterns.gdk_drag_begin_from_point(window, device, targets, x_root, y_root);
	}

	public static bool GdkTestSimulateKey(this GdkWindowHandle window, int x, int y, uint keyval, GdkModifierType modifiers, GdkEventType key_pressrelease)
	{
		return GdkWindowExterns.gdk_test_simulate_key(window, x, y, keyval, modifiers, key_pressrelease);
	}

	public static GdkWindowHandle GdkOffscreenWindowGetEmbedder(this GdkWindowHandle window)
	{
		return GdkWindowExterns.gdk_offscreen_window_get_embedder(window);
	}

	public static bool GdkPropertyGet(this GdkWindowHandle window, GdkAtom property, GdkAtom type, ulong offset, ulong length, int pdelete, out GdkAtom actual_property_type, out int actual_format, out int actual_length, out string data)
	{
		return GdkWindowExterns.gdk_property_get(window, property, type, offset, length, pdelete, out actual_property_type, out actual_format, out actual_length, out data);
	}

	public static T GdkSelectionConvert<T>(this T requestor, GdkAtom selection, GdkAtom target, uint time_) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_selection_convert(requestor, selection, target, time_);
		return requestor;
	}

	public static T GdkPropertyChange<T>(this T window, GdkAtom property, GdkAtom type, int format, GdkPropMode mode, string data, int nelements) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_property_change(window, property, type, format, mode, data, nelements);
		return window;
	}

	public static GdkPixbufHandle GdkPixbufGetFromWindow(this GdkWindowHandle window, int src_x, int src_y, int width, int height)
	{
		return GdkWindowExterns.gdk_pixbuf_get_from_window(window, src_x, src_y, width, height);
	}

	public static bool GdkTestSimulateButton(this GdkWindowHandle window, int x, int y, uint button, GdkModifierType modifiers, GdkEventType button_pressrelease)
	{
		return GdkWindowExterns.gdk_test_simulate_button(window, x, y, button, modifiers, button_pressrelease);
	}

	public static cairo_surface_tHandle GdkOffscreenWindowGetSurface(this GdkWindowHandle window)
	{
		return GdkWindowExterns.gdk_offscreen_window_get_surface(window);
	}

	public static T GdkSynthesizeWindowState<T>(this T window, GdkWindowState unset_flags, GdkWindowState set_flags) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_synthesize_window_state(window, unset_flags, set_flags);
		return window;
	}

	public static int GdkSelectionPropertyGet(this GdkWindowHandle requestor, ref string data, GdkAtomHandle prop_type, ref int prop_format)
	{
		return GdkWindowExterns.gdk_selection_property_get(requestor, ref data, prop_type, ref prop_format);
	}

	public static T GdkPropertyDelete<T>(this T window, GdkAtom property) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_property_delete(window, property);
		return window;
	}

	public static T GdkTestRenderSync<T>(this T window) where T : GdkWindowHandle
	{
		GdkWindowExterns.gdk_test_render_sync(window);
		return window;
	}

	public static GdkGrabStatus GdkPointerGrab(this GdkWindowHandle window, bool owner_events, GdkEventMask event_mask, GdkWindowHandle confine_to, GdkCursorHandle cursor, uint time_)
	{
		return GdkWindowExterns.gdk_pointer_grab(window, owner_events, event_mask, confine_to, cursor, time_);
	}

	public static bool GdkSelectionOwnerSet(this GdkWindowHandle owner, GdkAtom selection, uint time_, bool send_event)
	{
		return GdkWindowExterns.gdk_selection_owner_set(owner, selection, time_, send_event);
	}

	public static GdkDragContextHandle GdkDragBeginForDevice(this GdkWindowHandle window, GdkDeviceHandle device, GListHandle targets)
	{
		return GdkWindowExterns.gdk_drag_begin_for_device(window, device, targets);
	}

	public static cairo_tHandle GdkCairoCreate(this GdkWindowHandle window)
	{
		return GdkWindowExterns.gdk_cairo_create(window);
	}

}

internal class GdkWindowExterns
{
	[DllImport(Libraries.Gdk3)]
	internal static extern GdkWindowHandle gdk_window_new(GdkWindowHandle parent, GdkWindowAttrHandle attributes, int attributes_mask);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_add_filter(GdkWindowHandle window, GdkFilterFunc function, IntPtr data);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_beep(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkDrawingContextHandle gdk_window_begin_draw_frame(GdkWindowHandle window, cairo_region_tHandle region);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_begin_move_drag(GdkWindowHandle window, int button, int root_x, int root_y, uint timestamp);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_begin_move_drag_for_device(GdkWindowHandle window, GdkDeviceHandle device, int button, int root_x, int root_y, uint timestamp);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_begin_paint_rect(GdkWindowHandle window, GdkRectangleHandle rectangle);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_begin_paint_region(GdkWindowHandle window, cairo_region_tHandle region);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_begin_resize_drag(GdkWindowHandle window, GdkWindowEdge edge, int button, int root_x, int root_y, uint timestamp);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_begin_resize_drag_for_device(GdkWindowHandle window, GdkWindowEdge edge, GdkDeviceHandle device, int button, int root_x, int root_y, uint timestamp);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_configure_finished(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_coords_from_parent(GdkWindowHandle window, double parent_x, double parent_y, out double x, out double y);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_coords_to_parent(GdkWindowHandle window, double x, double y, out double parent_x, out double parent_y);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkGLContextHandle gdk_window_create_gl_context(GdkWindowHandle window, out GErrorHandle error);

	[DllImport(Libraries.Gdk3)]
	internal static extern cairo_surface_tHandle gdk_window_create_similar_image_surface(GdkWindowHandle window, cairo_format_t format, int width, int height, int scale);

	[DllImport(Libraries.Gdk3)]
	internal static extern cairo_surface_tHandle gdk_window_create_similar_surface(GdkWindowHandle window, cairo_content_t content, int width, int height);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_deiconify(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_destroy(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_destroy_notify(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_enable_synchronized_configure(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_end_draw_frame(GdkWindowHandle window, GdkDrawingContextHandle context);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_end_paint(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_window_ensure_native(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_flush(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_focus(GdkWindowHandle window, uint timestamp);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_freeze_toplevel_updates_libgtk_only(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_freeze_updates(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_fullscreen(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_fullscreen_on_monitor(GdkWindowHandle window, int monitor);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_geometry_changed(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_window_get_accept_focus(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern cairo_pattern_tHandle gdk_window_get_background_pattern(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern GListHandle gdk_window_get_children(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern GListHandle gdk_window_get_children_with_user_data(GdkWindowHandle window, IntPtr user_data);

	[DllImport(Libraries.Gdk3)]
	internal static extern cairo_region_tHandle gdk_window_get_clip_region(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_window_get_composited(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkCursorHandle gdk_window_get_cursor(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_window_get_decorations(GdkWindowHandle window, out GdkWMDecoration decorations);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkCursorHandle gdk_window_get_device_cursor(GdkWindowHandle window, GdkDeviceHandle device);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkEventMask gdk_window_get_device_events(GdkWindowHandle window, GdkDeviceHandle device);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkWindowHandle gdk_window_get_device_position(GdkWindowHandle window, GdkDeviceHandle device, out int x, out int y, out GdkModifierType mask);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkWindowHandle gdk_window_get_device_position_double(GdkWindowHandle window, GdkDeviceHandle device, out double x, out double y, out GdkModifierType mask);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkDisplayHandle gdk_window_get_display(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkDragProtocol gdk_window_get_drag_protocol(GdkWindowHandle window, out GdkWindowHandle target);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkWindowHandle gdk_window_get_effective_parent(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkWindowHandle gdk_window_get_effective_toplevel(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_window_get_event_compression(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkEventMask gdk_window_get_events(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_window_get_focus_on_map(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkFrameClockHandle gdk_window_get_frame_clock(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_get_frame_extents(GdkWindowHandle window, out GdkRectangle rect);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkFullscreenMode gdk_window_get_fullscreen_mode(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_get_geometry(GdkWindowHandle window, out int x, out int y, out int width, out int height);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkWindowHandle gdk_window_get_group(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern int gdk_window_get_height(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_window_get_modal_hint(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern int gdk_window_get_origin(GdkWindowHandle window, out int x, out int y);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkWindowHandle gdk_window_get_parent(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_window_get_pass_through(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkWindowHandle gdk_window_get_pointer(GdkWindowHandle window, out int x, out int y, out GdkModifierType mask);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_get_position(GdkWindowHandle window, out int x, out int y);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_get_root_coords(GdkWindowHandle window, int x, int y, out int root_x, out int root_y);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_get_root_origin(GdkWindowHandle window, out int x, out int y);

	[DllImport(Libraries.Gdk3)]
	internal static extern int gdk_window_get_scale_factor(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkScreenHandle gdk_window_get_screen(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkEventMask gdk_window_get_source_events(GdkWindowHandle window, GdkInputSource source);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkWindowState gdk_window_get_state(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_window_get_support_multidevice(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkWindowHandle gdk_window_get_toplevel(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkWindowTypeHint gdk_window_get_type_hint(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern cairo_region_tHandle gdk_window_get_update_area(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_get_user_data(GdkWindowHandle window, out IntPtr data);

	[DllImport(Libraries.Gdk3)]
	internal static extern cairo_region_tHandle gdk_window_get_visible_region(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkVisualHandle gdk_window_get_visual(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern int gdk_window_get_width(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkWindowType gdk_window_get_window_type(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_window_has_native(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_hide(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_iconify(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_input_shape_combine_region(GdkWindowHandle window, cairo_region_tHandle shape_region, int offset_x, int offset_y);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_invalidate_maybe_recurse(GdkWindowHandle window, cairo_region_tHandle region, GdkWindowChildFunc child_func, IntPtr user_data);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_invalidate_rect(GdkWindowHandle window, GdkRectangleHandle rect, bool invalidate_children);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_invalidate_region(GdkWindowHandle window, cairo_region_tHandle region, bool invalidate_children);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_window_is_destroyed(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_window_is_input_only(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_window_is_shaped(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_window_is_viewable(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_window_is_visible(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_lower(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_mark_paint_from_clip(GdkWindowHandle window, cairo_tHandle cr);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_maximize(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_merge_child_input_shapes(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_merge_child_shapes(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_move(GdkWindowHandle window, int x, int y);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_move_region(GdkWindowHandle window, cairo_region_tHandle region, int dx, int dy);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_move_resize(GdkWindowHandle window, int x, int y, int width, int height);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_move_to_rect(GdkWindowHandle window, GdkRectangleHandle rect, GdkGravity rect_anchor, GdkGravity window_anchor, GdkAnchorHints anchor_hints, int rect_anchor_dx, int rect_anchor_dy);

	[DllImport(Libraries.Gdk3)]
	internal static extern GListHandle gdk_window_peek_children(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_process_updates(GdkWindowHandle window, bool update_children);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_raise(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_register_dnd(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_remove_filter(GdkWindowHandle window, GdkFilterFunc function, IntPtr data);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_reparent(GdkWindowHandle window, GdkWindowHandle new_parent, int x, int y);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_resize(GdkWindowHandle window, int width, int height);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_restack(GdkWindowHandle window, GdkWindowHandle sibling, bool above);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_scroll(GdkWindowHandle window, int dx, int dy);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_set_accept_focus(GdkWindowHandle window, bool accept_focus);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_set_background(GdkWindowHandle window, GdkColorHandle color);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_set_background_pattern(GdkWindowHandle window, cairo_pattern_tHandle pattern);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_set_background_rgba(GdkWindowHandle window, GdkRGBAHandle rgba);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_set_child_input_shapes(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_set_child_shapes(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_set_composited(GdkWindowHandle window, bool composited);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_set_cursor(GdkWindowHandle window, GdkCursorHandle cursor);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_set_decorations(GdkWindowHandle window, GdkWMDecoration decorations);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_set_device_cursor(GdkWindowHandle window, GdkDeviceHandle device, GdkCursorHandle cursor);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_set_device_events(GdkWindowHandle window, GdkDeviceHandle device, GdkEventMask event_mask);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_set_event_compression(GdkWindowHandle window, bool event_compression);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_set_events(GdkWindowHandle window, GdkEventMask event_mask);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_set_focus_on_map(GdkWindowHandle window, bool focus_on_map);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_set_fullscreen_mode(GdkWindowHandle window, GdkFullscreenMode mode);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_set_functions(GdkWindowHandle window, GdkWMFunction functions);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_set_geometry_hints(GdkWindowHandle window, GdkGeometryHandle geometry, GdkWindowHints geom_mask);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_set_group(GdkWindowHandle window, GdkWindowHandle leader);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_set_icon_list(GdkWindowHandle window, GListHandle pixbufs);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_set_icon_name(GdkWindowHandle window, string name);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_set_invalidate_handler(GdkWindowHandle window, GdkWindowInvalidateHandlerFunc handler);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_set_keep_above(GdkWindowHandle window, bool setting);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_set_keep_below(GdkWindowHandle window, bool setting);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_set_modal_hint(GdkWindowHandle window, bool modal);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_set_opacity(GdkWindowHandle window, double opacity);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_set_opaque_region(GdkWindowHandle window, cairo_region_tHandle region);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_set_override_redirect(GdkWindowHandle window, bool override_redirect);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_set_pass_through(GdkWindowHandle window, bool pass_through);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_set_role(GdkWindowHandle window, string role);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_set_shadow_width(GdkWindowHandle window, int left, int right, int top, int bottom);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_set_skip_pager_hint(GdkWindowHandle window, bool skips_pager);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_set_skip_taskbar_hint(GdkWindowHandle window, bool skips_taskbar);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_set_source_events(GdkWindowHandle window, GdkInputSource source, GdkEventMask event_mask);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_set_startup_id(GdkWindowHandle window, string startup_id);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_window_set_static_gravities(GdkWindowHandle window, bool use_static);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_set_support_multidevice(GdkWindowHandle window, bool support_multidevice);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_set_title(GdkWindowHandle window, string title);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_set_transient_for(GdkWindowHandle window, GdkWindowHandle parent);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_set_type_hint(GdkWindowHandle window, GdkWindowTypeHint hint);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_set_urgency_hint(GdkWindowHandle window, bool urgent);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_set_user_data(GdkWindowHandle window, GObjectHandle user_data);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_shape_combine_region(GdkWindowHandle window, cairo_region_tHandle shape_region, int offset_x, int offset_y);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_show(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_show_unraised(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_window_show_window_menu(GdkWindowHandle window, GdkEventHandle @event);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_stick(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_thaw_toplevel_updates_libgtk_only(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_thaw_updates(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_unfullscreen(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_unmaximize(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_unstick(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_withdraw(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_offscreen_window_set_embedder(GdkWindowHandle window, GdkWindowHandle embedder);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkGrabStatus gdk_keyboard_grab(GdkWindowHandle window, bool owner_events, uint time_);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_selection_send_notify(GdkWindowHandle requestor, GdkAtom selection, GdkAtom target, GdkAtom property, uint time_);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkDragContextHandle gdk_drag_begin(GdkWindowHandle window, GListHandle targets);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkDragContextHandle gdk_drag_begin_from_point(GdkWindowHandle window, GdkDeviceHandle device, GListHandle targets, int x_root, int y_root);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_test_simulate_key(GdkWindowHandle window, int x, int y, uint keyval, GdkModifierType modifiers, GdkEventType key_pressrelease);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkWindowHandle gdk_offscreen_window_get_embedder(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_property_get(GdkWindowHandle window, GdkAtom property, GdkAtom type, ulong offset, ulong length, int pdelete, out GdkAtom actual_property_type, out int actual_format, out int actual_length, out string data);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_selection_convert(GdkWindowHandle requestor, GdkAtom selection, GdkAtom target, uint time_);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_property_change(GdkWindowHandle window, GdkAtom property, GdkAtom type, int format, GdkPropMode mode, string data, int nelements);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkPixbufHandle gdk_pixbuf_get_from_window(GdkWindowHandle window, int src_x, int src_y, int width, int height);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_test_simulate_button(GdkWindowHandle window, int x, int y, uint button, GdkModifierType modifiers, GdkEventType button_pressrelease);

	[DllImport(Libraries.Gdk3)]
	internal static extern cairo_surface_tHandle gdk_offscreen_window_get_surface(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_synthesize_window_state(GdkWindowHandle window, GdkWindowState unset_flags, GdkWindowState set_flags);

	[DllImport(Libraries.Gdk3)]
	internal static extern int gdk_selection_property_get(GdkWindowHandle requestor, ref string data, GdkAtomHandle prop_type, ref int prop_format);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_property_delete(GdkWindowHandle window, GdkAtom property);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_test_render_sync(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkGrabStatus gdk_pointer_grab(GdkWindowHandle window, bool owner_events, GdkEventMask event_mask, GdkWindowHandle confine_to, GdkCursorHandle cursor, uint time_);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_selection_owner_set(GdkWindowHandle owner, GdkAtom selection, uint time_, bool send_event);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkDragContextHandle gdk_drag_begin_for_device(GdkWindowHandle window, GdkDeviceHandle device, GListHandle targets);

	[DllImport(Libraries.Gdk3)]
	internal static extern cairo_tHandle gdk_cairo_create(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkWindowHandle gdk_window_at_pointer(out int win_x, out int win_y);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_constrain_size(GdkGeometryHandle geometry, GdkWindowHints flags, int width, int height, out int new_width, out int new_height);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_process_all_updates();

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_window_set_debug_updates(bool setting);

}
