namespace MentorLake.Gtk;

public class GtkMenuHandle : GtkMenuShellHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkMenuHandle New()
	{
		return GtkMenuHandleExterns.gtk_menu_new();
	}

	public static MentorLake.Gtk.GtkMenuHandle NewFromModel(MentorLake.Gio.GMenuModelHandle model)
	{
		return GtkMenuHandleExterns.gtk_menu_new_from_model(model);
	}

	public static MentorLake.GLib.GListHandle GetForAttachWidget(MentorLake.Gtk.GtkWidgetHandle widget)
	{
		return GtkMenuHandleExterns.gtk_menu_get_for_attach_widget(widget);
	}

}
public static class GtkMenuHandleSignalExtensions
{

	public static IObservable<GtkMenuHandleSignalStructs.MoveScrollSignal> Signal_MoveScroll(this GtkMenuHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkMenuHandleSignalStructs.MoveScrollSignal> obs) =>
		{
			GtkMenuHandleSignalDelegates.move_scroll handler = ( MentorLake.Gtk.GtkMenuHandle self,  MentorLake.Gtk.GtkScrollType scroll_type,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuHandleSignalStructs.MoveScrollSignal()
				{
					Self = self, ScrollType = scroll_type, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "move-scroll", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkMenuHandleSignalStructs.PoppedUpSignal> Signal_PoppedUp(this GtkMenuHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkMenuHandleSignalStructs.PoppedUpSignal> obs) =>
		{
			GtkMenuHandleSignalDelegates.popped_up handler = ( MentorLake.Gtk.GtkMenuHandle self,  IntPtr flipped_rect,  IntPtr final_rect,  bool flipped_x,  bool flipped_y,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuHandleSignalStructs.PoppedUpSignal()
				{
					Self = self, FlippedRect = flipped_rect, FinalRect = final_rect, FlippedX = flipped_x, FlippedY = flipped_y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "popped-up", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkMenuHandleSignalStructs
{

public class MoveScrollSignal
{
	public MentorLake.Gtk.GtkMenuHandle Self;
	public MentorLake.Gtk.GtkScrollType ScrollType;
	public IntPtr UserData;
}

public class PoppedUpSignal
{
	public MentorLake.Gtk.GtkMenuHandle Self;
	public IntPtr FlippedRect;
	public IntPtr FinalRect;
	public bool FlippedX;
	public bool FlippedY;
	public IntPtr UserData;
}
}

public static class GtkMenuHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void move_scroll([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle self, MentorLake.Gtk.GtkScrollType scroll_type, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void popped_up([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle self, IntPtr flipped_rect, IntPtr final_rect, bool flipped_x, bool flipped_y, IntPtr user_data);

}


public static class GtkMenuHandleExtensions
{
	public static T Attach<T>(this T menu, MentorLake.Gtk.GtkWidgetHandle child, uint left_attach, uint right_attach, uint top_attach, uint bottom_attach) where T : GtkMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		GtkMenuHandleExterns.gtk_menu_attach(menu, child, left_attach, right_attach, top_attach, bottom_attach);
		return menu;
	}

	public static T AttachToWidget<T>(this T menu, MentorLake.Gtk.GtkWidgetHandle attach_widget, MentorLake.Gtk.GtkMenuDetachFunc detacher) where T : GtkMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		GtkMenuHandleExterns.gtk_menu_attach_to_widget(menu, attach_widget, detacher);
		return menu;
	}

	public static T Detach<T>(this T menu) where T : GtkMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		GtkMenuHandleExterns.gtk_menu_detach(menu);
		return menu;
	}

	public static MentorLake.Gtk.GtkAccelGroupHandle GetAccelGroup(this MentorLake.Gtk.GtkMenuHandle menu)
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		return GtkMenuHandleExterns.gtk_menu_get_accel_group(menu);
	}

	public static string GetAccelPath(this MentorLake.Gtk.GtkMenuHandle menu)
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		return GtkMenuHandleExterns.gtk_menu_get_accel_path(menu);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetActive(this MentorLake.Gtk.GtkMenuHandle menu)
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		return GtkMenuHandleExterns.gtk_menu_get_active(menu);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetAttachWidget(this MentorLake.Gtk.GtkMenuHandle menu)
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		return GtkMenuHandleExterns.gtk_menu_get_attach_widget(menu);
	}

	public static int GetMonitor(this MentorLake.Gtk.GtkMenuHandle menu)
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		return GtkMenuHandleExterns.gtk_menu_get_monitor(menu);
	}

	public static bool GetReserveToggleSize(this MentorLake.Gtk.GtkMenuHandle menu)
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		return GtkMenuHandleExterns.gtk_menu_get_reserve_toggle_size(menu);
	}

	public static bool GetTearoffState(this MentorLake.Gtk.GtkMenuHandle menu)
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		return GtkMenuHandleExterns.gtk_menu_get_tearoff_state(menu);
	}

	public static string GetTitle(this MentorLake.Gtk.GtkMenuHandle menu)
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		return GtkMenuHandleExterns.gtk_menu_get_title(menu);
	}

	public static T PlaceOnMonitor<T>(this T menu, MentorLake.Gdk.GdkMonitorHandle monitor) where T : GtkMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		GtkMenuHandleExterns.gtk_menu_place_on_monitor(menu, monitor);
		return menu;
	}

	public static T Popdown<T>(this T menu) where T : GtkMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		GtkMenuHandleExterns.gtk_menu_popdown(menu);
		return menu;
	}

	public static T Popup<T>(this T menu, MentorLake.Gtk.GtkWidgetHandle parent_menu_shell, MentorLake.Gtk.GtkWidgetHandle parent_menu_item, MentorLake.Gtk.GtkMenuPositionFunc func, IntPtr data, uint button, uint activate_time) where T : GtkMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		GtkMenuHandleExterns.gtk_menu_popup(menu, parent_menu_shell, parent_menu_item, func, data, button, activate_time);
		return menu;
	}

	public static T PopupAtPointer<T>(this T menu, MentorLake.Gdk.GdkEventHandle trigger_event) where T : GtkMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		GtkMenuHandleExterns.gtk_menu_popup_at_pointer(menu, trigger_event);
		return menu;
	}

	public static T PopupAtRect<T>(this T menu, MentorLake.Gdk.GdkWindowHandle rect_window, MentorLake.Gdk.GdkRectangleHandle rect, MentorLake.Gdk.GdkGravity rect_anchor, MentorLake.Gdk.GdkGravity menu_anchor, MentorLake.Gdk.GdkEventHandle trigger_event) where T : GtkMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		GtkMenuHandleExterns.gtk_menu_popup_at_rect(menu, rect_window, rect, rect_anchor, menu_anchor, trigger_event);
		return menu;
	}

	public static T PopupAtWidget<T>(this T menu, MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkGravity widget_anchor, MentorLake.Gdk.GdkGravity menu_anchor, MentorLake.Gdk.GdkEventHandle trigger_event) where T : GtkMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		GtkMenuHandleExterns.gtk_menu_popup_at_widget(menu, widget, widget_anchor, menu_anchor, trigger_event);
		return menu;
	}

	public static T PopupForDevice<T>(this T menu, MentorLake.Gdk.GdkDeviceHandle device, MentorLake.Gtk.GtkWidgetHandle parent_menu_shell, MentorLake.Gtk.GtkWidgetHandle parent_menu_item, MentorLake.Gtk.GtkMenuPositionFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy, uint button, uint activate_time) where T : GtkMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		GtkMenuHandleExterns.gtk_menu_popup_for_device(menu, device, parent_menu_shell, parent_menu_item, func, data, destroy, button, activate_time);
		return menu;
	}

	public static T ReorderChild<T>(this T menu, MentorLake.Gtk.GtkWidgetHandle child, int position) where T : GtkMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		GtkMenuHandleExterns.gtk_menu_reorder_child(menu, child, position);
		return menu;
	}

	public static T Reposition<T>(this T menu) where T : GtkMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		GtkMenuHandleExterns.gtk_menu_reposition(menu);
		return menu;
	}

	public static T SetAccelGroup<T>(this T menu, MentorLake.Gtk.GtkAccelGroupHandle accel_group) where T : GtkMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		GtkMenuHandleExterns.gtk_menu_set_accel_group(menu, accel_group);
		return menu;
	}

	public static T SetAccelPath<T>(this T menu, string accel_path) where T : GtkMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		GtkMenuHandleExterns.gtk_menu_set_accel_path(menu, accel_path);
		return menu;
	}

	public static T SetActive<T>(this T menu, uint index) where T : GtkMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		GtkMenuHandleExterns.gtk_menu_set_active(menu, index);
		return menu;
	}

	public static T SetMonitor<T>(this T menu, int monitor_num) where T : GtkMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		GtkMenuHandleExterns.gtk_menu_set_monitor(menu, monitor_num);
		return menu;
	}

	public static T SetReserveToggleSize<T>(this T menu, bool reserve_toggle_size) where T : GtkMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		GtkMenuHandleExterns.gtk_menu_set_reserve_toggle_size(menu, reserve_toggle_size);
		return menu;
	}

	public static T SetScreen<T>(this T menu, MentorLake.Gdk.GdkScreenHandle screen) where T : GtkMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		GtkMenuHandleExterns.gtk_menu_set_screen(menu, screen);
		return menu;
	}

	public static T SetTearoffState<T>(this T menu, bool torn_off) where T : GtkMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		GtkMenuHandleExterns.gtk_menu_set_tearoff_state(menu, torn_off);
		return menu;
	}

	public static T SetTitle<T>(this T menu, string title) where T : GtkMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkMenuHandle)");
		GtkMenuHandleExterns.gtk_menu_set_title(menu, title);
		return menu;
	}

}

internal class GtkMenuHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))]
	internal static extern MentorLake.Gtk.GtkMenuHandle gtk_menu_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))]
	internal static extern MentorLake.Gtk.GtkMenuHandle gtk_menu_new_from_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle model);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_attach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, uint left_attach, uint right_attach, uint top_attach, uint bottom_attach);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_attach_to_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle attach_widget, MentorLake.Gtk.GtkMenuDetachFunc detacher);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_detach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))]
	internal static extern MentorLake.Gtk.GtkAccelGroupHandle gtk_menu_get_accel_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_menu_get_accel_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_menu_get_active([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_menu_get_attach_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_menu_get_monitor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_menu_get_reserve_toggle_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_menu_get_tearoff_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_menu_get_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_place_on_monitor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkMonitorHandle>))] MentorLake.Gdk.GdkMonitorHandle monitor);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_popdown([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_popup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle parent_menu_shell, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle parent_menu_item, MentorLake.Gtk.GtkMenuPositionFunc func, IntPtr data, uint button, uint activate_time);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_popup_at_pointer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle trigger_event);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_popup_at_rect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle rect_window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle rect, MentorLake.Gdk.GdkGravity rect_anchor, MentorLake.Gdk.GdkGravity menu_anchor, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle trigger_event);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_popup_at_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkGravity widget_anchor, MentorLake.Gdk.GdkGravity menu_anchor, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle trigger_event);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_popup_for_device([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle parent_menu_shell, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle parent_menu_item, MentorLake.Gtk.GtkMenuPositionFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy, uint button, uint activate_time);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_reorder_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, int position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_reposition([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_set_accel_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle accel_group);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_set_accel_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu, string accel_path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_set_active([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu, uint index);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_set_monitor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu, int monitor_num);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_set_reserve_toggle_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu, bool reserve_toggle_size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_set_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_set_tearoff_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu, bool torn_off);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_set_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu, string title);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gtk_menu_get_for_attach_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

}
