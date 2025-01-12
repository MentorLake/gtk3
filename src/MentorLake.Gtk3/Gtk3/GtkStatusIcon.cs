namespace MentorLake.Gtk3.Gtk3;

public class GtkStatusIconHandle : GObjectHandle
{
	public static GtkStatusIconHandle New()
	{
		return GtkStatusIconExterns.gtk_status_icon_new();
	}

	public static GtkStatusIconHandle NewFromFile(string filename)
	{
		return GtkStatusIconExterns.gtk_status_icon_new_from_file(filename);
	}

	public static GtkStatusIconHandle NewFromGicon(GIconHandle icon)
	{
		return GtkStatusIconExterns.gtk_status_icon_new_from_gicon(icon);
	}

	public static GtkStatusIconHandle NewFromIconName(string icon_name)
	{
		return GtkStatusIconExterns.gtk_status_icon_new_from_icon_name(icon_name);
	}

	public static GtkStatusIconHandle NewFromPixbuf(GdkPixbufHandle pixbuf)
	{
		return GtkStatusIconExterns.gtk_status_icon_new_from_pixbuf(pixbuf);
	}

	public static GtkStatusIconHandle NewFromStock(string stock_id)
	{
		return GtkStatusIconExterns.gtk_status_icon_new_from_stock(stock_id);
	}

	public static void PositionMenu(GtkMenuHandle menu, out int x, out int y, out bool push_in, GtkStatusIconHandle user_data)
	{
		GtkStatusIconExterns.gtk_status_icon_position_menu(menu, out x, out y, out push_in, user_data);
	}

}

public static class GtkStatusIconSignalExtensions
{

	public static IObservable<GtkStatusIconSignalStructs.ActivateSignal> Signal_Activate(this GtkStatusIconHandle instance)
	{
		return Observable.Create((IObserver<GtkStatusIconSignalStructs.ActivateSignal> obs) =>
		{
			GtkStatusIconSignalDelegates.activate handler = (GtkStatusIconHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkStatusIconSignalStructs.ActivateSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkStatusIconSignalStructs.ButtonPressEventSignal> Signal_ButtonPressEvent(this GtkStatusIconHandle instance)
	{
		return Observable.Create((IObserver<GtkStatusIconSignalStructs.ButtonPressEventSignal> obs) =>
		{
			GtkStatusIconSignalDelegates.button_press_event handler = (GtkStatusIconHandle self, GdkEventButton @event, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkStatusIconSignalStructs.ButtonPressEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "button_press_event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkStatusIconSignalStructs.ButtonReleaseEventSignal> Signal_ButtonReleaseEvent(this GtkStatusIconHandle instance)
	{
		return Observable.Create((IObserver<GtkStatusIconSignalStructs.ButtonReleaseEventSignal> obs) =>
		{
			GtkStatusIconSignalDelegates.button_release_event handler = (GtkStatusIconHandle self, GdkEventButton @event, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkStatusIconSignalStructs.ButtonReleaseEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "button_release_event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkStatusIconSignalStructs.PopupMenuSignal> Signal_PopupMenu(this GtkStatusIconHandle instance)
	{
		return Observable.Create((IObserver<GtkStatusIconSignalStructs.PopupMenuSignal> obs) =>
		{
			GtkStatusIconSignalDelegates.popup_menu handler = (GtkStatusIconHandle self, uint button, uint activate_time, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkStatusIconSignalStructs.PopupMenuSignal()
				{
					Self = self, Button = button, ActivateTime = activate_time, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "popup_menu", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkStatusIconSignalStructs.QueryTooltipSignal> Signal_QueryTooltip(this GtkStatusIconHandle instance)
	{
		return Observable.Create((IObserver<GtkStatusIconSignalStructs.QueryTooltipSignal> obs) =>
		{
			GtkStatusIconSignalDelegates.query_tooltip handler = (GtkStatusIconHandle self, int x, int y, bool keyboard_mode, GtkTooltipHandle tooltip, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkStatusIconSignalStructs.QueryTooltipSignal()
				{
					Self = self, X = x, Y = y, KeyboardMode = keyboard_mode, Tooltip = tooltip, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "query_tooltip", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkStatusIconSignalStructs.ScrollEventSignal> Signal_ScrollEvent(this GtkStatusIconHandle instance)
	{
		return Observable.Create((IObserver<GtkStatusIconSignalStructs.ScrollEventSignal> obs) =>
		{
			GtkStatusIconSignalDelegates.scroll_event handler = (GtkStatusIconHandle self, GdkEventScroll @event, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkStatusIconSignalStructs.ScrollEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "scroll_event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkStatusIconSignalStructs.SizeChangedSignal> Signal_SizeChanged(this GtkStatusIconHandle instance)
	{
		return Observable.Create((IObserver<GtkStatusIconSignalStructs.SizeChangedSignal> obs) =>
		{
			GtkStatusIconSignalDelegates.size_changed handler = (GtkStatusIconHandle self, int size, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkStatusIconSignalStructs.SizeChangedSignal()
				{
					Self = self, Size = size, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "size_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkStatusIconSignalStructs
{

public struct ActivateSignal
{
	public GtkStatusIconHandle Self;
	public IntPtr UserData;
}

public struct ButtonPressEventSignal
{
	public GtkStatusIconHandle Self;
	public GdkEventButton Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct ButtonReleaseEventSignal
{
	public GtkStatusIconHandle Self;
	public GdkEventButton Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct PopupMenuSignal
{
	public GtkStatusIconHandle Self;
	public uint Button;
	public uint ActivateTime;
	public IntPtr UserData;
}

public struct QueryTooltipSignal
{
	public GtkStatusIconHandle Self;
	public int X;
	public int Y;
	public bool KeyboardMode;
	public GtkTooltipHandle Tooltip;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct ScrollEventSignal
{
	public GtkStatusIconHandle Self;
	public GdkEventScroll Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct SizeChangedSignal
{
	public GtkStatusIconHandle Self;
	public int Size;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GtkStatusIconSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkStatusIconHandle>))] GtkStatusIconHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool button_press_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkStatusIconHandle>))] GtkStatusIconHandle self, GdkEventButton @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool button_release_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkStatusIconHandle>))] GtkStatusIconHandle self, GdkEventButton @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void popup_menu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkStatusIconHandle>))] GtkStatusIconHandle self, uint button, uint activate_time, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool query_tooltip([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkStatusIconHandle>))] GtkStatusIconHandle self, int x, int y, bool keyboard_mode, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTooltipHandle>))] GtkTooltipHandle tooltip, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool scroll_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkStatusIconHandle>))] GtkStatusIconHandle self, GdkEventScroll @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool size_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkStatusIconHandle>))] GtkStatusIconHandle self, int size, IntPtr user_data);

}


public static class GtkStatusIconHandleExtensions
{
	public static bool GetGeometry(this GtkStatusIconHandle status_icon, out GdkScreenHandle screen, out GdkRectangle area, out GtkOrientation orientation)
	{
		return GtkStatusIconExterns.gtk_status_icon_get_geometry(status_icon, out screen, out area, out orientation);
	}

	public static GIconHandle GetGicon(this GtkStatusIconHandle status_icon)
	{
		return GtkStatusIconExterns.gtk_status_icon_get_gicon(status_icon);
	}

	public static bool GetHasTooltip(this GtkStatusIconHandle status_icon)
	{
		return GtkStatusIconExterns.gtk_status_icon_get_has_tooltip(status_icon);
	}

	public static string GetIconName(this GtkStatusIconHandle status_icon)
	{
		return GtkStatusIconExterns.gtk_status_icon_get_icon_name(status_icon);
	}

	public static GdkPixbufHandle GetPixbuf(this GtkStatusIconHandle status_icon)
	{
		return GtkStatusIconExterns.gtk_status_icon_get_pixbuf(status_icon);
	}

	public static GdkScreenHandle GetScreen(this GtkStatusIconHandle status_icon)
	{
		return GtkStatusIconExterns.gtk_status_icon_get_screen(status_icon);
	}

	public static int GetSize(this GtkStatusIconHandle status_icon)
	{
		return GtkStatusIconExterns.gtk_status_icon_get_size(status_icon);
	}

	public static string GetStock(this GtkStatusIconHandle status_icon)
	{
		return GtkStatusIconExterns.gtk_status_icon_get_stock(status_icon);
	}

	public static GtkImageType GetStorageType(this GtkStatusIconHandle status_icon)
	{
		return GtkStatusIconExterns.gtk_status_icon_get_storage_type(status_icon);
	}

	public static string GetTitle(this GtkStatusIconHandle status_icon)
	{
		return GtkStatusIconExterns.gtk_status_icon_get_title(status_icon);
	}

	public static string GetTooltipMarkup(this GtkStatusIconHandle status_icon)
	{
		return GtkStatusIconExterns.gtk_status_icon_get_tooltip_markup(status_icon);
	}

	public static string GetTooltipText(this GtkStatusIconHandle status_icon)
	{
		return GtkStatusIconExterns.gtk_status_icon_get_tooltip_text(status_icon);
	}

	public static bool GetVisible(this GtkStatusIconHandle status_icon)
	{
		return GtkStatusIconExterns.gtk_status_icon_get_visible(status_icon);
	}

	public static uint GetX11WindowId(this GtkStatusIconHandle status_icon)
	{
		return GtkStatusIconExterns.gtk_status_icon_get_x11_window_id(status_icon);
	}

	public static bool IsEmbedded(this GtkStatusIconHandle status_icon)
	{
		return GtkStatusIconExterns.gtk_status_icon_is_embedded(status_icon);
	}

	public static T SetFromFile<T>(this T status_icon, string filename) where T : GtkStatusIconHandle
	{
		GtkStatusIconExterns.gtk_status_icon_set_from_file(status_icon, filename);
		return status_icon;
	}

	public static T SetFromGicon<T>(this T status_icon, GIconHandle icon) where T : GtkStatusIconHandle
	{
		GtkStatusIconExterns.gtk_status_icon_set_from_gicon(status_icon, icon);
		return status_icon;
	}

	public static T SetFromIconName<T>(this T status_icon, string icon_name) where T : GtkStatusIconHandle
	{
		GtkStatusIconExterns.gtk_status_icon_set_from_icon_name(status_icon, icon_name);
		return status_icon;
	}

	public static T SetFromPixbuf<T>(this T status_icon, GdkPixbufHandle pixbuf) where T : GtkStatusIconHandle
	{
		GtkStatusIconExterns.gtk_status_icon_set_from_pixbuf(status_icon, pixbuf);
		return status_icon;
	}

	public static T SetFromStock<T>(this T status_icon, string stock_id) where T : GtkStatusIconHandle
	{
		GtkStatusIconExterns.gtk_status_icon_set_from_stock(status_icon, stock_id);
		return status_icon;
	}

	public static T SetHasTooltip<T>(this T status_icon, bool has_tooltip) where T : GtkStatusIconHandle
	{
		GtkStatusIconExterns.gtk_status_icon_set_has_tooltip(status_icon, has_tooltip);
		return status_icon;
	}

	public static T SetName<T>(this T status_icon, string name) where T : GtkStatusIconHandle
	{
		GtkStatusIconExterns.gtk_status_icon_set_name(status_icon, name);
		return status_icon;
	}

	public static T SetScreen<T>(this T status_icon, GdkScreenHandle screen) where T : GtkStatusIconHandle
	{
		GtkStatusIconExterns.gtk_status_icon_set_screen(status_icon, screen);
		return status_icon;
	}

	public static T SetTitle<T>(this T status_icon, string title) where T : GtkStatusIconHandle
	{
		GtkStatusIconExterns.gtk_status_icon_set_title(status_icon, title);
		return status_icon;
	}

	public static T SetTooltipMarkup<T>(this T status_icon, string markup) where T : GtkStatusIconHandle
	{
		GtkStatusIconExterns.gtk_status_icon_set_tooltip_markup(status_icon, markup);
		return status_icon;
	}

	public static T SetTooltipText<T>(this T status_icon, string text) where T : GtkStatusIconHandle
	{
		GtkStatusIconExterns.gtk_status_icon_set_tooltip_text(status_icon, text);
		return status_icon;
	}

	public static T SetVisible<T>(this T status_icon, bool visible) where T : GtkStatusIconHandle
	{
		GtkStatusIconExterns.gtk_status_icon_set_visible(status_icon, visible);
		return status_icon;
	}

}

internal class GtkStatusIconExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkStatusIconHandle gtk_status_icon_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkStatusIconHandle gtk_status_icon_new_from_file(string filename);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkStatusIconHandle gtk_status_icon_new_from_gicon(GIconHandle icon);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkStatusIconHandle gtk_status_icon_new_from_icon_name(string icon_name);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkStatusIconHandle gtk_status_icon_new_from_pixbuf(GdkPixbufHandle pixbuf);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkStatusIconHandle gtk_status_icon_new_from_stock(string stock_id);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_status_icon_get_geometry(GtkStatusIconHandle status_icon, out GdkScreenHandle screen, out GdkRectangle area, out GtkOrientation orientation);

	[DllImport(Libraries.Gtk3)]
	internal static extern GIconHandle gtk_status_icon_get_gicon(GtkStatusIconHandle status_icon);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_status_icon_get_has_tooltip(GtkStatusIconHandle status_icon);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_status_icon_get_icon_name(GtkStatusIconHandle status_icon);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkPixbufHandle gtk_status_icon_get_pixbuf(GtkStatusIconHandle status_icon);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkScreenHandle gtk_status_icon_get_screen(GtkStatusIconHandle status_icon);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_status_icon_get_size(GtkStatusIconHandle status_icon);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_status_icon_get_stock(GtkStatusIconHandle status_icon);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkImageType gtk_status_icon_get_storage_type(GtkStatusIconHandle status_icon);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_status_icon_get_title(GtkStatusIconHandle status_icon);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_status_icon_get_tooltip_markup(GtkStatusIconHandle status_icon);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_status_icon_get_tooltip_text(GtkStatusIconHandle status_icon);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_status_icon_get_visible(GtkStatusIconHandle status_icon);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_status_icon_get_x11_window_id(GtkStatusIconHandle status_icon);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_status_icon_is_embedded(GtkStatusIconHandle status_icon);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_status_icon_set_from_file(GtkStatusIconHandle status_icon, string filename);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_status_icon_set_from_gicon(GtkStatusIconHandle status_icon, GIconHandle icon);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_status_icon_set_from_icon_name(GtkStatusIconHandle status_icon, string icon_name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_status_icon_set_from_pixbuf(GtkStatusIconHandle status_icon, GdkPixbufHandle pixbuf);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_status_icon_set_from_stock(GtkStatusIconHandle status_icon, string stock_id);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_status_icon_set_has_tooltip(GtkStatusIconHandle status_icon, bool has_tooltip);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_status_icon_set_name(GtkStatusIconHandle status_icon, string name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_status_icon_set_screen(GtkStatusIconHandle status_icon, GdkScreenHandle screen);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_status_icon_set_title(GtkStatusIconHandle status_icon, string title);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_status_icon_set_tooltip_markup(GtkStatusIconHandle status_icon, string markup);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_status_icon_set_tooltip_text(GtkStatusIconHandle status_icon, string text);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_status_icon_set_visible(GtkStatusIconHandle status_icon, bool visible);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_status_icon_position_menu(GtkMenuHandle menu, out int x, out int y, out bool push_in, GtkStatusIconHandle user_data);

}
