namespace MentorLake.Gtk3.Gtk3;

public class GtkMenuHandle : GtkMenuShellHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkMenuHandle New()
	{
		return GtkMenuExterns.gtk_menu_new();
	}

	public static GtkMenuHandle NewFromModel(GMenuModelHandle model)
	{
		return GtkMenuExterns.gtk_menu_new_from_model(model);
	}

	public static GListHandle GetForAttachWidget(GtkWidgetHandle widget)
	{
		return GtkMenuExterns.gtk_menu_get_for_attach_widget(widget);
	}

}

public static class GtkMenuSignalExtensions
{

	public static IObservable<GtkMenuSignalStructs.MoveScrollSignal> Signal_MoveScroll(this GtkMenuHandle instance)
	{
		return Observable.Create((IObserver<GtkMenuSignalStructs.MoveScrollSignal> obs) =>
		{
			GtkMenuSignalDelegates.move_scroll handler = (GtkMenuHandle self, ref GtkScrollType scroll_type, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuSignalStructs.MoveScrollSignal()
				{
					Self = self, ScrollType = scroll_type, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "move_scroll", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkMenuSignalStructs.PoppedUpSignal> Signal_PoppedUp(this GtkMenuHandle instance)
	{
		return Observable.Create((IObserver<GtkMenuSignalStructs.PoppedUpSignal> obs) =>
		{
			GtkMenuSignalDelegates.popped_up handler = (GtkMenuHandle self, IntPtr flipped_rect, IntPtr final_rect, bool flipped_x, bool flipped_y, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuSignalStructs.PoppedUpSignal()
				{
					Self = self, FlippedRect = flipped_rect, FinalRect = final_rect, FlippedX = flipped_x, FlippedY = flipped_y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "popped_up", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkMenuSignalStructs
{

public struct MoveScrollSignal
{
	public GtkMenuHandle Self;
	public GtkScrollType ScrollType;
	public IntPtr UserData;
}

public struct PoppedUpSignal
{
	public GtkMenuHandle Self;
	public IntPtr FlippedRect;
	public IntPtr FinalRect;
	public bool FlippedX;
	public bool FlippedY;
	public IntPtr UserData;
}
}

public static class GtkMenuSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void move_scroll([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkMenuHandle>))] GtkMenuHandle self, ref GtkScrollType scroll_type, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void popped_up([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkMenuHandle>))] GtkMenuHandle self, IntPtr flipped_rect, IntPtr final_rect, bool flipped_x, bool flipped_y, IntPtr user_data);

}


public static class GtkMenuHandleExtensions
{
	public static T Attach<T>(this T menu, GtkWidgetHandle child, uint left_attach, uint right_attach, uint top_attach, uint bottom_attach) where T : GtkMenuHandle
	{
		GtkMenuExterns.gtk_menu_attach(menu, child, left_attach, right_attach, top_attach, bottom_attach);
		return menu;
	}

	public static T AttachToWidget<T>(this T menu, GtkWidgetHandle attach_widget, GtkMenuDetachFunc detacher) where T : GtkMenuHandle
	{
		GtkMenuExterns.gtk_menu_attach_to_widget(menu, attach_widget, detacher);
		return menu;
	}

	public static T Detach<T>(this T menu) where T : GtkMenuHandle
	{
		GtkMenuExterns.gtk_menu_detach(menu);
		return menu;
	}

	public static GtkAccelGroupHandle GetAccelGroup(this GtkMenuHandle menu)
	{
		return GtkMenuExterns.gtk_menu_get_accel_group(menu);
	}

	public static string GetAccelPath(this GtkMenuHandle menu)
	{
		return GtkMenuExterns.gtk_menu_get_accel_path(menu);
	}

	public static GtkWidgetHandle GetActive(this GtkMenuHandle menu)
	{
		return GtkMenuExterns.gtk_menu_get_active(menu);
	}

	public static GtkWidgetHandle GetAttachWidget(this GtkMenuHandle menu)
	{
		return GtkMenuExterns.gtk_menu_get_attach_widget(menu);
	}

	public static int GetMonitor(this GtkMenuHandle menu)
	{
		return GtkMenuExterns.gtk_menu_get_monitor(menu);
	}

	public static bool GetReserveToggleSize(this GtkMenuHandle menu)
	{
		return GtkMenuExterns.gtk_menu_get_reserve_toggle_size(menu);
	}

	public static bool GetTearoffState(this GtkMenuHandle menu)
	{
		return GtkMenuExterns.gtk_menu_get_tearoff_state(menu);
	}

	public static string GetTitle(this GtkMenuHandle menu)
	{
		return GtkMenuExterns.gtk_menu_get_title(menu);
	}

	public static T PlaceOnMonitor<T>(this T menu, GdkMonitorHandle monitor) where T : GtkMenuHandle
	{
		GtkMenuExterns.gtk_menu_place_on_monitor(menu, monitor);
		return menu;
	}

	public static T Popdown<T>(this T menu) where T : GtkMenuHandle
	{
		GtkMenuExterns.gtk_menu_popdown(menu);
		return menu;
	}

	public static T Popup<T>(this T menu, GtkWidgetHandle parent_menu_shell, GtkWidgetHandle parent_menu_item, GtkMenuPositionFunc func, IntPtr data, uint button, uint activate_time) where T : GtkMenuHandle
	{
		GtkMenuExterns.gtk_menu_popup(menu, parent_menu_shell, parent_menu_item, func, data, button, activate_time);
		return menu;
	}

	public static T PopupAtPointer<T>(this T menu, GdkEventHandle trigger_event) where T : GtkMenuHandle
	{
		GtkMenuExterns.gtk_menu_popup_at_pointer(menu, trigger_event);
		return menu;
	}

	public static T PopupAtRect<T>(this T menu, GdkWindowHandle rect_window, GdkRectangleHandle rect, GdkGravity rect_anchor, GdkGravity menu_anchor, GdkEventHandle trigger_event) where T : GtkMenuHandle
	{
		GtkMenuExterns.gtk_menu_popup_at_rect(menu, rect_window, rect, rect_anchor, menu_anchor, trigger_event);
		return menu;
	}

	public static T PopupAtWidget<T>(this T menu, GtkWidgetHandle widget, GdkGravity widget_anchor, GdkGravity menu_anchor, GdkEventHandle trigger_event) where T : GtkMenuHandle
	{
		GtkMenuExterns.gtk_menu_popup_at_widget(menu, widget, widget_anchor, menu_anchor, trigger_event);
		return menu;
	}

	public static T PopupForDevice<T>(this T menu, GdkDeviceHandle device, GtkWidgetHandle parent_menu_shell, GtkWidgetHandle parent_menu_item, GtkMenuPositionFunc func, IntPtr data, GDestroyNotify destroy, uint button, uint activate_time) where T : GtkMenuHandle
	{
		GtkMenuExterns.gtk_menu_popup_for_device(menu, device, parent_menu_shell, parent_menu_item, func, data, destroy, button, activate_time);
		return menu;
	}

	public static T ReorderChild<T>(this T menu, GtkWidgetHandle child, int position) where T : GtkMenuHandle
	{
		GtkMenuExterns.gtk_menu_reorder_child(menu, child, position);
		return menu;
	}

	public static T Reposition<T>(this T menu) where T : GtkMenuHandle
	{
		GtkMenuExterns.gtk_menu_reposition(menu);
		return menu;
	}

	public static T SetAccelGroup<T>(this T menu, GtkAccelGroupHandle accel_group) where T : GtkMenuHandle
	{
		GtkMenuExterns.gtk_menu_set_accel_group(menu, accel_group);
		return menu;
	}

	public static T SetAccelPath<T>(this T menu, string accel_path) where T : GtkMenuHandle
	{
		GtkMenuExterns.gtk_menu_set_accel_path(menu, accel_path);
		return menu;
	}

	public static T SetActive<T>(this T menu, uint index) where T : GtkMenuHandle
	{
		GtkMenuExterns.gtk_menu_set_active(menu, index);
		return menu;
	}

	public static T SetMonitor<T>(this T menu, int monitor_num) where T : GtkMenuHandle
	{
		GtkMenuExterns.gtk_menu_set_monitor(menu, monitor_num);
		return menu;
	}

	public static T SetReserveToggleSize<T>(this T menu, bool reserve_toggle_size) where T : GtkMenuHandle
	{
		GtkMenuExterns.gtk_menu_set_reserve_toggle_size(menu, reserve_toggle_size);
		return menu;
	}

	public static T SetScreen<T>(this T menu, GdkScreenHandle screen) where T : GtkMenuHandle
	{
		GtkMenuExterns.gtk_menu_set_screen(menu, screen);
		return menu;
	}

	public static T SetTearoffState<T>(this T menu, bool torn_off) where T : GtkMenuHandle
	{
		GtkMenuExterns.gtk_menu_set_tearoff_state(menu, torn_off);
		return menu;
	}

	public static T SetTitle<T>(this T menu, string title) where T : GtkMenuHandle
	{
		GtkMenuExterns.gtk_menu_set_title(menu, title);
		return menu;
	}

}

internal class GtkMenuExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkMenuHandle gtk_menu_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkMenuHandle gtk_menu_new_from_model(GMenuModelHandle model);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_attach(GtkMenuHandle menu, GtkWidgetHandle child, uint left_attach, uint right_attach, uint top_attach, uint bottom_attach);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_attach_to_widget(GtkMenuHandle menu, GtkWidgetHandle attach_widget, GtkMenuDetachFunc detacher);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_detach(GtkMenuHandle menu);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkAccelGroupHandle gtk_menu_get_accel_group(GtkMenuHandle menu);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_menu_get_accel_path(GtkMenuHandle menu);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_menu_get_active(GtkMenuHandle menu);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_menu_get_attach_widget(GtkMenuHandle menu);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_menu_get_monitor(GtkMenuHandle menu);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_menu_get_reserve_toggle_size(GtkMenuHandle menu);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_menu_get_tearoff_state(GtkMenuHandle menu);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_menu_get_title(GtkMenuHandle menu);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_place_on_monitor(GtkMenuHandle menu, GdkMonitorHandle monitor);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_popdown(GtkMenuHandle menu);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_popup(GtkMenuHandle menu, GtkWidgetHandle parent_menu_shell, GtkWidgetHandle parent_menu_item, GtkMenuPositionFunc func, IntPtr data, uint button, uint activate_time);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_popup_at_pointer(GtkMenuHandle menu, GdkEventHandle trigger_event);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_popup_at_rect(GtkMenuHandle menu, GdkWindowHandle rect_window, GdkRectangleHandle rect, GdkGravity rect_anchor, GdkGravity menu_anchor, GdkEventHandle trigger_event);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_popup_at_widget(GtkMenuHandle menu, GtkWidgetHandle widget, GdkGravity widget_anchor, GdkGravity menu_anchor, GdkEventHandle trigger_event);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_popup_for_device(GtkMenuHandle menu, GdkDeviceHandle device, GtkWidgetHandle parent_menu_shell, GtkWidgetHandle parent_menu_item, GtkMenuPositionFunc func, IntPtr data, GDestroyNotify destroy, uint button, uint activate_time);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_reorder_child(GtkMenuHandle menu, GtkWidgetHandle child, int position);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_reposition(GtkMenuHandle menu);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_set_accel_group(GtkMenuHandle menu, GtkAccelGroupHandle accel_group);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_set_accel_path(GtkMenuHandle menu, string accel_path);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_set_active(GtkMenuHandle menu, uint index);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_set_monitor(GtkMenuHandle menu, int monitor_num);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_set_reserve_toggle_size(GtkMenuHandle menu, bool reserve_toggle_size);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_set_screen(GtkMenuHandle menu, GdkScreenHandle screen);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_set_tearoff_state(GtkMenuHandle menu, bool torn_off);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_set_title(GtkMenuHandle menu, string title);

	[DllImport(Libraries.Gtk3)]
	internal static extern GListHandle gtk_menu_get_for_attach_widget(GtkWidgetHandle widget);

}
