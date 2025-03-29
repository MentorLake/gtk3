namespace MentorLake.Gtk;

public class GtkScrolledWindowHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkScrolledWindowHandle New(MentorLake.Gtk.GtkAdjustmentHandle hadjustment, MentorLake.Gtk.GtkAdjustmentHandle vadjustment)
	{
		return GtkScrolledWindowHandleExterns.gtk_scrolled_window_new(hadjustment, vadjustment);
	}

}
public static class GtkScrolledWindowHandleSignalExtensions
{

	public static IObservable<GtkScrolledWindowHandleSignalStructs.EdgeOvershotSignal> Signal_EdgeOvershot(this GtkScrolledWindowHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkScrolledWindowHandleSignalStructs.EdgeOvershotSignal> obs) =>
		{
			GtkScrolledWindowHandleSignalDelegates.edge_overshot handler = ( MentorLake.Gtk.GtkScrolledWindowHandle self,  MentorLake.Gtk.GtkPositionType pos,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkScrolledWindowHandleSignalStructs.EdgeOvershotSignal()
				{
					Self = self, Pos = pos, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "edge-overshot", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkScrolledWindowHandleSignalStructs.EdgeReachedSignal> Signal_EdgeReached(this GtkScrolledWindowHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkScrolledWindowHandleSignalStructs.EdgeReachedSignal> obs) =>
		{
			GtkScrolledWindowHandleSignalDelegates.edge_reached handler = ( MentorLake.Gtk.GtkScrolledWindowHandle self,  MentorLake.Gtk.GtkPositionType pos,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkScrolledWindowHandleSignalStructs.EdgeReachedSignal()
				{
					Self = self, Pos = pos, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "edge-reached", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkScrolledWindowHandleSignalStructs.MoveFocusOutSignal> Signal_MoveFocusOut(this GtkScrolledWindowHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkScrolledWindowHandleSignalStructs.MoveFocusOutSignal> obs) =>
		{
			GtkScrolledWindowHandleSignalDelegates.move_focus_out handler = ( MentorLake.Gtk.GtkScrolledWindowHandle self,  MentorLake.Gtk.GtkDirectionType direction_type,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkScrolledWindowHandleSignalStructs.MoveFocusOutSignal()
				{
					Self = self, DirectionType = direction_type, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "move-focus-out", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkScrolledWindowHandleSignalStructs.ScrollChildSignal> Signal_ScrollChild(this GtkScrolledWindowHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkScrolledWindowHandleSignalStructs.ScrollChildSignal> obs) =>
		{
			GtkScrolledWindowHandleSignalDelegates.scroll_child handler = ( MentorLake.Gtk.GtkScrolledWindowHandle self,  MentorLake.Gtk.GtkScrollType scroll,  bool horizontal,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkScrolledWindowHandleSignalStructs.ScrollChildSignal()
				{
					Self = self, Scroll = scroll, Horizontal = horizontal, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "scroll-child", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkScrolledWindowHandleSignalStructs
{

public struct EdgeOvershotSignal
{
	public MentorLake.Gtk.GtkScrolledWindowHandle Self;
	public MentorLake.Gtk.GtkPositionType Pos;
	public IntPtr UserData;
}

public struct EdgeReachedSignal
{
	public MentorLake.Gtk.GtkScrolledWindowHandle Self;
	public MentorLake.Gtk.GtkPositionType Pos;
	public IntPtr UserData;
}

public struct MoveFocusOutSignal
{
	public MentorLake.Gtk.GtkScrolledWindowHandle Self;
	public MentorLake.Gtk.GtkDirectionType DirectionType;
	public IntPtr UserData;
}

public struct ScrollChildSignal
{
	public MentorLake.Gtk.GtkScrolledWindowHandle Self;
	public MentorLake.Gtk.GtkScrollType Scroll;
	public bool Horizontal;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GtkScrolledWindowHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void edge_overshot([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle self, MentorLake.Gtk.GtkPositionType pos, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void edge_reached([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle self, MentorLake.Gtk.GtkPositionType pos, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void move_focus_out([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle self, MentorLake.Gtk.GtkDirectionType direction_type, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool scroll_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle self, MentorLake.Gtk.GtkScrollType scroll, bool horizontal, IntPtr user_data);

}


public static class GtkScrolledWindowHandleExtensions
{
	public static T AddWithViewport<T>(this T scrolled_window, MentorLake.Gtk.GtkWidgetHandle child) where T : GtkScrolledWindowHandle
	{
		if (scrolled_window.IsInvalid || scrolled_window.IsClosed) throw new Exception("Invalid or closed handle (GtkScrolledWindowHandle)");
		GtkScrolledWindowHandleExterns.gtk_scrolled_window_add_with_viewport(scrolled_window, child);
		return scrolled_window;
	}

	public static bool GetCaptureButtonPress(this MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window)
	{
		if (scrolled_window.IsInvalid || scrolled_window.IsClosed) throw new Exception("Invalid or closed handle (GtkScrolledWindowHandle)");
		return GtkScrolledWindowHandleExterns.gtk_scrolled_window_get_capture_button_press(scrolled_window);
	}

	public static MentorLake.Gtk.GtkAdjustmentHandle GetHadjustment(this MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window)
	{
		if (scrolled_window.IsInvalid || scrolled_window.IsClosed) throw new Exception("Invalid or closed handle (GtkScrolledWindowHandle)");
		return GtkScrolledWindowHandleExterns.gtk_scrolled_window_get_hadjustment(scrolled_window);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetHscrollbar(this MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window)
	{
		if (scrolled_window.IsInvalid || scrolled_window.IsClosed) throw new Exception("Invalid or closed handle (GtkScrolledWindowHandle)");
		return GtkScrolledWindowHandleExterns.gtk_scrolled_window_get_hscrollbar(scrolled_window);
	}

	public static bool GetKineticScrolling(this MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window)
	{
		if (scrolled_window.IsInvalid || scrolled_window.IsClosed) throw new Exception("Invalid or closed handle (GtkScrolledWindowHandle)");
		return GtkScrolledWindowHandleExterns.gtk_scrolled_window_get_kinetic_scrolling(scrolled_window);
	}

	public static int GetMaxContentHeight(this MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window)
	{
		if (scrolled_window.IsInvalid || scrolled_window.IsClosed) throw new Exception("Invalid or closed handle (GtkScrolledWindowHandle)");
		return GtkScrolledWindowHandleExterns.gtk_scrolled_window_get_max_content_height(scrolled_window);
	}

	public static int GetMaxContentWidth(this MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window)
	{
		if (scrolled_window.IsInvalid || scrolled_window.IsClosed) throw new Exception("Invalid or closed handle (GtkScrolledWindowHandle)");
		return GtkScrolledWindowHandleExterns.gtk_scrolled_window_get_max_content_width(scrolled_window);
	}

	public static int GetMinContentHeight(this MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window)
	{
		if (scrolled_window.IsInvalid || scrolled_window.IsClosed) throw new Exception("Invalid or closed handle (GtkScrolledWindowHandle)");
		return GtkScrolledWindowHandleExterns.gtk_scrolled_window_get_min_content_height(scrolled_window);
	}

	public static int GetMinContentWidth(this MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window)
	{
		if (scrolled_window.IsInvalid || scrolled_window.IsClosed) throw new Exception("Invalid or closed handle (GtkScrolledWindowHandle)");
		return GtkScrolledWindowHandleExterns.gtk_scrolled_window_get_min_content_width(scrolled_window);
	}

	public static bool GetOverlayScrolling(this MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window)
	{
		if (scrolled_window.IsInvalid || scrolled_window.IsClosed) throw new Exception("Invalid or closed handle (GtkScrolledWindowHandle)");
		return GtkScrolledWindowHandleExterns.gtk_scrolled_window_get_overlay_scrolling(scrolled_window);
	}

	public static MentorLake.Gtk.GtkCornerType GetPlacement(this MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window)
	{
		if (scrolled_window.IsInvalid || scrolled_window.IsClosed) throw new Exception("Invalid or closed handle (GtkScrolledWindowHandle)");
		return GtkScrolledWindowHandleExterns.gtk_scrolled_window_get_placement(scrolled_window);
	}

	public static T GetPolicy<T>(this T scrolled_window, out MentorLake.Gtk.GtkPolicyType hscrollbar_policy, out MentorLake.Gtk.GtkPolicyType vscrollbar_policy) where T : GtkScrolledWindowHandle
	{
		if (scrolled_window.IsInvalid || scrolled_window.IsClosed) throw new Exception("Invalid or closed handle (GtkScrolledWindowHandle)");
		GtkScrolledWindowHandleExterns.gtk_scrolled_window_get_policy(scrolled_window, out hscrollbar_policy, out vscrollbar_policy);
		return scrolled_window;
	}

	public static bool GetPropagateNaturalHeight(this MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window)
	{
		if (scrolled_window.IsInvalid || scrolled_window.IsClosed) throw new Exception("Invalid or closed handle (GtkScrolledWindowHandle)");
		return GtkScrolledWindowHandleExterns.gtk_scrolled_window_get_propagate_natural_height(scrolled_window);
	}

	public static bool GetPropagateNaturalWidth(this MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window)
	{
		if (scrolled_window.IsInvalid || scrolled_window.IsClosed) throw new Exception("Invalid or closed handle (GtkScrolledWindowHandle)");
		return GtkScrolledWindowHandleExterns.gtk_scrolled_window_get_propagate_natural_width(scrolled_window);
	}

	public static MentorLake.Gtk.GtkShadowType GetShadowType(this MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window)
	{
		if (scrolled_window.IsInvalid || scrolled_window.IsClosed) throw new Exception("Invalid or closed handle (GtkScrolledWindowHandle)");
		return GtkScrolledWindowHandleExterns.gtk_scrolled_window_get_shadow_type(scrolled_window);
	}

	public static MentorLake.Gtk.GtkAdjustmentHandle GetVadjustment(this MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window)
	{
		if (scrolled_window.IsInvalid || scrolled_window.IsClosed) throw new Exception("Invalid or closed handle (GtkScrolledWindowHandle)");
		return GtkScrolledWindowHandleExterns.gtk_scrolled_window_get_vadjustment(scrolled_window);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetVscrollbar(this MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window)
	{
		if (scrolled_window.IsInvalid || scrolled_window.IsClosed) throw new Exception("Invalid or closed handle (GtkScrolledWindowHandle)");
		return GtkScrolledWindowHandleExterns.gtk_scrolled_window_get_vscrollbar(scrolled_window);
	}

	public static T SetCaptureButtonPress<T>(this T scrolled_window, bool capture_button_press) where T : GtkScrolledWindowHandle
	{
		if (scrolled_window.IsInvalid || scrolled_window.IsClosed) throw new Exception("Invalid or closed handle (GtkScrolledWindowHandle)");
		GtkScrolledWindowHandleExterns.gtk_scrolled_window_set_capture_button_press(scrolled_window, capture_button_press);
		return scrolled_window;
	}

	public static T SetHadjustment<T>(this T scrolled_window, MentorLake.Gtk.GtkAdjustmentHandle hadjustment) where T : GtkScrolledWindowHandle
	{
		if (scrolled_window.IsInvalid || scrolled_window.IsClosed) throw new Exception("Invalid or closed handle (GtkScrolledWindowHandle)");
		GtkScrolledWindowHandleExterns.gtk_scrolled_window_set_hadjustment(scrolled_window, hadjustment);
		return scrolled_window;
	}

	public static T SetKineticScrolling<T>(this T scrolled_window, bool kinetic_scrolling) where T : GtkScrolledWindowHandle
	{
		if (scrolled_window.IsInvalid || scrolled_window.IsClosed) throw new Exception("Invalid or closed handle (GtkScrolledWindowHandle)");
		GtkScrolledWindowHandleExterns.gtk_scrolled_window_set_kinetic_scrolling(scrolled_window, kinetic_scrolling);
		return scrolled_window;
	}

	public static T SetMaxContentHeight<T>(this T scrolled_window, int height) where T : GtkScrolledWindowHandle
	{
		if (scrolled_window.IsInvalid || scrolled_window.IsClosed) throw new Exception("Invalid or closed handle (GtkScrolledWindowHandle)");
		GtkScrolledWindowHandleExterns.gtk_scrolled_window_set_max_content_height(scrolled_window, height);
		return scrolled_window;
	}

	public static T SetMaxContentWidth<T>(this T scrolled_window, int width) where T : GtkScrolledWindowHandle
	{
		if (scrolled_window.IsInvalid || scrolled_window.IsClosed) throw new Exception("Invalid or closed handle (GtkScrolledWindowHandle)");
		GtkScrolledWindowHandleExterns.gtk_scrolled_window_set_max_content_width(scrolled_window, width);
		return scrolled_window;
	}

	public static T SetMinContentHeight<T>(this T scrolled_window, int height) where T : GtkScrolledWindowHandle
	{
		if (scrolled_window.IsInvalid || scrolled_window.IsClosed) throw new Exception("Invalid or closed handle (GtkScrolledWindowHandle)");
		GtkScrolledWindowHandleExterns.gtk_scrolled_window_set_min_content_height(scrolled_window, height);
		return scrolled_window;
	}

	public static T SetMinContentWidth<T>(this T scrolled_window, int width) where T : GtkScrolledWindowHandle
	{
		if (scrolled_window.IsInvalid || scrolled_window.IsClosed) throw new Exception("Invalid or closed handle (GtkScrolledWindowHandle)");
		GtkScrolledWindowHandleExterns.gtk_scrolled_window_set_min_content_width(scrolled_window, width);
		return scrolled_window;
	}

	public static T SetOverlayScrolling<T>(this T scrolled_window, bool overlay_scrolling) where T : GtkScrolledWindowHandle
	{
		if (scrolled_window.IsInvalid || scrolled_window.IsClosed) throw new Exception("Invalid or closed handle (GtkScrolledWindowHandle)");
		GtkScrolledWindowHandleExterns.gtk_scrolled_window_set_overlay_scrolling(scrolled_window, overlay_scrolling);
		return scrolled_window;
	}

	public static T SetPlacement<T>(this T scrolled_window, MentorLake.Gtk.GtkCornerType window_placement) where T : GtkScrolledWindowHandle
	{
		if (scrolled_window.IsInvalid || scrolled_window.IsClosed) throw new Exception("Invalid or closed handle (GtkScrolledWindowHandle)");
		GtkScrolledWindowHandleExterns.gtk_scrolled_window_set_placement(scrolled_window, window_placement);
		return scrolled_window;
	}

	public static T SetPolicy<T>(this T scrolled_window, MentorLake.Gtk.GtkPolicyType hscrollbar_policy, MentorLake.Gtk.GtkPolicyType vscrollbar_policy) where T : GtkScrolledWindowHandle
	{
		if (scrolled_window.IsInvalid || scrolled_window.IsClosed) throw new Exception("Invalid or closed handle (GtkScrolledWindowHandle)");
		GtkScrolledWindowHandleExterns.gtk_scrolled_window_set_policy(scrolled_window, hscrollbar_policy, vscrollbar_policy);
		return scrolled_window;
	}

	public static T SetPropagateNaturalHeight<T>(this T scrolled_window, bool propagate) where T : GtkScrolledWindowHandle
	{
		if (scrolled_window.IsInvalid || scrolled_window.IsClosed) throw new Exception("Invalid or closed handle (GtkScrolledWindowHandle)");
		GtkScrolledWindowHandleExterns.gtk_scrolled_window_set_propagate_natural_height(scrolled_window, propagate);
		return scrolled_window;
	}

	public static T SetPropagateNaturalWidth<T>(this T scrolled_window, bool propagate) where T : GtkScrolledWindowHandle
	{
		if (scrolled_window.IsInvalid || scrolled_window.IsClosed) throw new Exception("Invalid or closed handle (GtkScrolledWindowHandle)");
		GtkScrolledWindowHandleExterns.gtk_scrolled_window_set_propagate_natural_width(scrolled_window, propagate);
		return scrolled_window;
	}

	public static T SetShadowType<T>(this T scrolled_window, MentorLake.Gtk.GtkShadowType type) where T : GtkScrolledWindowHandle
	{
		if (scrolled_window.IsInvalid || scrolled_window.IsClosed) throw new Exception("Invalid or closed handle (GtkScrolledWindowHandle)");
		GtkScrolledWindowHandleExterns.gtk_scrolled_window_set_shadow_type(scrolled_window, type);
		return scrolled_window;
	}

	public static T SetVadjustment<T>(this T scrolled_window, MentorLake.Gtk.GtkAdjustmentHandle vadjustment) where T : GtkScrolledWindowHandle
	{
		if (scrolled_window.IsInvalid || scrolled_window.IsClosed) throw new Exception("Invalid or closed handle (GtkScrolledWindowHandle)");
		GtkScrolledWindowHandleExterns.gtk_scrolled_window_set_vadjustment(scrolled_window, vadjustment);
		return scrolled_window;
	}

	public static T UnsetPlacement<T>(this T scrolled_window) where T : GtkScrolledWindowHandle
	{
		if (scrolled_window.IsInvalid || scrolled_window.IsClosed) throw new Exception("Invalid or closed handle (GtkScrolledWindowHandle)");
		GtkScrolledWindowHandleExterns.gtk_scrolled_window_unset_placement(scrolled_window);
		return scrolled_window;
	}

}

internal class GtkScrolledWindowHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkScrolledWindowHandle gtk_scrolled_window_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle hadjustment, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle vadjustment);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrolled_window_add_with_viewport([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_scrolled_window_get_capture_button_press([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkAdjustmentHandle gtk_scrolled_window_get_hadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_scrolled_window_get_hscrollbar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_scrolled_window_get_kinetic_scrolling([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_scrolled_window_get_max_content_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_scrolled_window_get_max_content_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_scrolled_window_get_min_content_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_scrolled_window_get_min_content_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_scrolled_window_get_overlay_scrolling([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkCornerType gtk_scrolled_window_get_placement([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrolled_window_get_policy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window, out MentorLake.Gtk.GtkPolicyType hscrollbar_policy, out MentorLake.Gtk.GtkPolicyType vscrollbar_policy);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_scrolled_window_get_propagate_natural_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_scrolled_window_get_propagate_natural_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkShadowType gtk_scrolled_window_get_shadow_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkAdjustmentHandle gtk_scrolled_window_get_vadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_scrolled_window_get_vscrollbar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrolled_window_set_capture_button_press([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window, bool capture_button_press);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrolled_window_set_hadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle hadjustment);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrolled_window_set_kinetic_scrolling([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window, bool kinetic_scrolling);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrolled_window_set_max_content_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window, int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrolled_window_set_max_content_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window, int width);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrolled_window_set_min_content_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window, int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrolled_window_set_min_content_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window, int width);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrolled_window_set_overlay_scrolling([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window, bool overlay_scrolling);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrolled_window_set_placement([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window, MentorLake.Gtk.GtkCornerType window_placement);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrolled_window_set_policy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window, MentorLake.Gtk.GtkPolicyType hscrollbar_policy, MentorLake.Gtk.GtkPolicyType vscrollbar_policy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrolled_window_set_propagate_natural_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window, bool propagate);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrolled_window_set_propagate_natural_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window, bool propagate);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrolled_window_set_shadow_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window, MentorLake.Gtk.GtkShadowType type);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrolled_window_set_vadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle vadjustment);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrolled_window_unset_placement([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window);

}
