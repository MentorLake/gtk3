namespace MentorLake.Gtk3.Gtk3;

public class GtkScrolledWindowHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkScrolledWindowHandle New(GtkAdjustmentHandle hadjustment, GtkAdjustmentHandle vadjustment)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_new(hadjustment, vadjustment);
	}

}

public static class GtkScrolledWindowSignalExtensions
{

	public static IObservable<GtkScrolledWindowSignalStructs.EdgeOvershotSignal> Signal_EdgeOvershot(this GtkScrolledWindowHandle instance)
	{
		return Observable.Create((IObserver<GtkScrolledWindowSignalStructs.EdgeOvershotSignal> obs) =>
		{
			GtkScrolledWindowSignalDelegates.edge_overshot handler = (GtkScrolledWindowHandle self, GtkPositionType pos, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkScrolledWindowSignalStructs.EdgeOvershotSignal()
				{
					Self = self, Pos = pos, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "edge_overshot", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkScrolledWindowSignalStructs.EdgeReachedSignal> Signal_EdgeReached(this GtkScrolledWindowHandle instance)
	{
		return Observable.Create((IObserver<GtkScrolledWindowSignalStructs.EdgeReachedSignal> obs) =>
		{
			GtkScrolledWindowSignalDelegates.edge_reached handler = (GtkScrolledWindowHandle self, GtkPositionType pos, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkScrolledWindowSignalStructs.EdgeReachedSignal()
				{
					Self = self, Pos = pos, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "edge_reached", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkScrolledWindowSignalStructs.MoveFocusOutSignal> Signal_MoveFocusOut(this GtkScrolledWindowHandle instance)
	{
		return Observable.Create((IObserver<GtkScrolledWindowSignalStructs.MoveFocusOutSignal> obs) =>
		{
			GtkScrolledWindowSignalDelegates.move_focus_out handler = (GtkScrolledWindowHandle self, GtkDirectionType direction_type, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkScrolledWindowSignalStructs.MoveFocusOutSignal()
				{
					Self = self, DirectionType = direction_type, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "move_focus_out", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkScrolledWindowSignalStructs.ScrollChildSignal> Signal_ScrollChild(this GtkScrolledWindowHandle instance)
	{
		return Observable.Create((IObserver<GtkScrolledWindowSignalStructs.ScrollChildSignal> obs) =>
		{
			GtkScrolledWindowSignalDelegates.scroll_child handler = (GtkScrolledWindowHandle self, ref GtkScrollType scroll, bool horizontal, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkScrolledWindowSignalStructs.ScrollChildSignal()
				{
					Self = self, Scroll = scroll, Horizontal = horizontal, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "scroll_child", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkScrolledWindowSignalStructs
{

public struct EdgeOvershotSignal
{
	public GtkScrolledWindowHandle Self;
	public GtkPositionType Pos;
	public IntPtr UserData;
}

public struct EdgeReachedSignal
{
	public GtkScrolledWindowHandle Self;
	public GtkPositionType Pos;
	public IntPtr UserData;
}

public struct MoveFocusOutSignal
{
	public GtkScrolledWindowHandle Self;
	public GtkDirectionType DirectionType;
	public IntPtr UserData;
}

public struct ScrollChildSignal
{
	public GtkScrolledWindowHandle Self;
	public GtkScrollType Scroll;
	public bool Horizontal;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GtkScrolledWindowSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void edge_overshot([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkScrolledWindowHandle>))] GtkScrolledWindowHandle self, GtkPositionType pos, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void edge_reached([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkScrolledWindowHandle>))] GtkScrolledWindowHandle self, GtkPositionType pos, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void move_focus_out([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkScrolledWindowHandle>))] GtkScrolledWindowHandle self, GtkDirectionType direction_type, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool scroll_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkScrolledWindowHandle>))] GtkScrolledWindowHandle self, ref GtkScrollType scroll, bool horizontal, IntPtr user_data);

}


public static class GtkScrolledWindowHandleExtensions
{
	public static T AddWithViewport<T>(this T scrolled_window, GtkWidgetHandle child) where T : GtkScrolledWindowHandle
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_add_with_viewport(scrolled_window, child);
		return scrolled_window;
	}

	public static bool GetCaptureButtonPress(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_capture_button_press(scrolled_window);
	}

	public static GtkAdjustmentHandle GetHadjustment(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_hadjustment(scrolled_window);
	}

	public static GtkWidgetHandle GetHscrollbar(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_hscrollbar(scrolled_window);
	}

	public static bool GetKineticScrolling(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_kinetic_scrolling(scrolled_window);
	}

	public static int GetMaxContentHeight(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_max_content_height(scrolled_window);
	}

	public static int GetMaxContentWidth(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_max_content_width(scrolled_window);
	}

	public static int GetMinContentHeight(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_min_content_height(scrolled_window);
	}

	public static int GetMinContentWidth(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_min_content_width(scrolled_window);
	}

	public static bool GetOverlayScrolling(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_overlay_scrolling(scrolled_window);
	}

	public static GtkCornerType GetPlacement(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_placement(scrolled_window);
	}

	public static T GetPolicy<T>(this T scrolled_window, out GtkPolicyType hscrollbar_policy, out GtkPolicyType vscrollbar_policy) where T : GtkScrolledWindowHandle
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_get_policy(scrolled_window, out hscrollbar_policy, out vscrollbar_policy);
		return scrolled_window;
	}

	public static bool GetPropagateNaturalHeight(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_propagate_natural_height(scrolled_window);
	}

	public static bool GetPropagateNaturalWidth(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_propagate_natural_width(scrolled_window);
	}

	public static GtkShadowType GetShadowType(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_shadow_type(scrolled_window);
	}

	public static GtkAdjustmentHandle GetVadjustment(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_vadjustment(scrolled_window);
	}

	public static GtkWidgetHandle GetVscrollbar(this GtkScrolledWindowHandle scrolled_window)
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_get_vscrollbar(scrolled_window);
	}

	public static T SetCaptureButtonPress<T>(this T scrolled_window, bool capture_button_press) where T : GtkScrolledWindowHandle
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_capture_button_press(scrolled_window, capture_button_press);
		return scrolled_window;
	}

	public static T SetHadjustment<T>(this T scrolled_window, GtkAdjustmentHandle hadjustment) where T : GtkScrolledWindowHandle
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_hadjustment(scrolled_window, hadjustment);
		return scrolled_window;
	}

	public static T SetKineticScrolling<T>(this T scrolled_window, bool kinetic_scrolling) where T : GtkScrolledWindowHandle
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_kinetic_scrolling(scrolled_window, kinetic_scrolling);
		return scrolled_window;
	}

	public static T SetMaxContentHeight<T>(this T scrolled_window, int height) where T : GtkScrolledWindowHandle
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_max_content_height(scrolled_window, height);
		return scrolled_window;
	}

	public static T SetMaxContentWidth<T>(this T scrolled_window, int width) where T : GtkScrolledWindowHandle
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_max_content_width(scrolled_window, width);
		return scrolled_window;
	}

	public static T SetMinContentHeight<T>(this T scrolled_window, int height) where T : GtkScrolledWindowHandle
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_min_content_height(scrolled_window, height);
		return scrolled_window;
	}

	public static T SetMinContentWidth<T>(this T scrolled_window, int width) where T : GtkScrolledWindowHandle
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_min_content_width(scrolled_window, width);
		return scrolled_window;
	}

	public static T SetOverlayScrolling<T>(this T scrolled_window, bool overlay_scrolling) where T : GtkScrolledWindowHandle
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_overlay_scrolling(scrolled_window, overlay_scrolling);
		return scrolled_window;
	}

	public static T SetPlacement<T>(this T scrolled_window, GtkCornerType window_placement) where T : GtkScrolledWindowHandle
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_placement(scrolled_window, window_placement);
		return scrolled_window;
	}

	public static T SetPolicy<T>(this T scrolled_window, GtkPolicyType hscrollbar_policy, GtkPolicyType vscrollbar_policy) where T : GtkScrolledWindowHandle
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_policy(scrolled_window, hscrollbar_policy, vscrollbar_policy);
		return scrolled_window;
	}

	public static T SetPropagateNaturalHeight<T>(this T scrolled_window, bool propagate) where T : GtkScrolledWindowHandle
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_propagate_natural_height(scrolled_window, propagate);
		return scrolled_window;
	}

	public static T SetPropagateNaturalWidth<T>(this T scrolled_window, bool propagate) where T : GtkScrolledWindowHandle
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_propagate_natural_width(scrolled_window, propagate);
		return scrolled_window;
	}

	public static T SetShadowType<T>(this T scrolled_window, GtkShadowType type) where T : GtkScrolledWindowHandle
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_shadow_type(scrolled_window, type);
		return scrolled_window;
	}

	public static T SetVadjustment<T>(this T scrolled_window, GtkAdjustmentHandle vadjustment) where T : GtkScrolledWindowHandle
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_set_vadjustment(scrolled_window, vadjustment);
		return scrolled_window;
	}

	public static T UnsetPlacement<T>(this T scrolled_window) where T : GtkScrolledWindowHandle
	{
		GtkScrolledWindowExterns.gtk_scrolled_window_unset_placement(scrolled_window);
		return scrolled_window;
	}

}

internal class GtkScrolledWindowExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkScrolledWindowHandle gtk_scrolled_window_new(GtkAdjustmentHandle hadjustment, GtkAdjustmentHandle vadjustment);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_scrolled_window_add_with_viewport(GtkScrolledWindowHandle scrolled_window, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_scrolled_window_get_capture_button_press(GtkScrolledWindowHandle scrolled_window);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkAdjustmentHandle gtk_scrolled_window_get_hadjustment(GtkScrolledWindowHandle scrolled_window);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_scrolled_window_get_hscrollbar(GtkScrolledWindowHandle scrolled_window);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_scrolled_window_get_kinetic_scrolling(GtkScrolledWindowHandle scrolled_window);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_scrolled_window_get_max_content_height(GtkScrolledWindowHandle scrolled_window);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_scrolled_window_get_max_content_width(GtkScrolledWindowHandle scrolled_window);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_scrolled_window_get_min_content_height(GtkScrolledWindowHandle scrolled_window);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_scrolled_window_get_min_content_width(GtkScrolledWindowHandle scrolled_window);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_scrolled_window_get_overlay_scrolling(GtkScrolledWindowHandle scrolled_window);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkCornerType gtk_scrolled_window_get_placement(GtkScrolledWindowHandle scrolled_window);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_scrolled_window_get_policy(GtkScrolledWindowHandle scrolled_window, out GtkPolicyType hscrollbar_policy, out GtkPolicyType vscrollbar_policy);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_scrolled_window_get_propagate_natural_height(GtkScrolledWindowHandle scrolled_window);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_scrolled_window_get_propagate_natural_width(GtkScrolledWindowHandle scrolled_window);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkShadowType gtk_scrolled_window_get_shadow_type(GtkScrolledWindowHandle scrolled_window);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkAdjustmentHandle gtk_scrolled_window_get_vadjustment(GtkScrolledWindowHandle scrolled_window);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_scrolled_window_get_vscrollbar(GtkScrolledWindowHandle scrolled_window);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_scrolled_window_set_capture_button_press(GtkScrolledWindowHandle scrolled_window, bool capture_button_press);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_scrolled_window_set_hadjustment(GtkScrolledWindowHandle scrolled_window, GtkAdjustmentHandle hadjustment);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_scrolled_window_set_kinetic_scrolling(GtkScrolledWindowHandle scrolled_window, bool kinetic_scrolling);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_scrolled_window_set_max_content_height(GtkScrolledWindowHandle scrolled_window, int height);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_scrolled_window_set_max_content_width(GtkScrolledWindowHandle scrolled_window, int width);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_scrolled_window_set_min_content_height(GtkScrolledWindowHandle scrolled_window, int height);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_scrolled_window_set_min_content_width(GtkScrolledWindowHandle scrolled_window, int width);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_scrolled_window_set_overlay_scrolling(GtkScrolledWindowHandle scrolled_window, bool overlay_scrolling);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_scrolled_window_set_placement(GtkScrolledWindowHandle scrolled_window, GtkCornerType window_placement);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_scrolled_window_set_policy(GtkScrolledWindowHandle scrolled_window, GtkPolicyType hscrollbar_policy, GtkPolicyType vscrollbar_policy);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_scrolled_window_set_propagate_natural_height(GtkScrolledWindowHandle scrolled_window, bool propagate);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_scrolled_window_set_propagate_natural_width(GtkScrolledWindowHandle scrolled_window, bool propagate);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_scrolled_window_set_shadow_type(GtkScrolledWindowHandle scrolled_window, GtkShadowType type);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_scrolled_window_set_vadjustment(GtkScrolledWindowHandle scrolled_window, GtkAdjustmentHandle vadjustment);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_scrolled_window_unset_placement(GtkScrolledWindowHandle scrolled_window);

}
