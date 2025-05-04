namespace MentorLake.Gtk;

public class GtkStatusIconHandle : GObjectHandle
{
	public static MentorLake.Gtk.GtkStatusIconHandle New()
	{
		return GtkStatusIconHandleExterns.gtk_status_icon_new();
	}

	public static MentorLake.Gtk.GtkStatusIconHandle NewFromFile(string filename)
	{
		return GtkStatusIconHandleExterns.gtk_status_icon_new_from_file(filename);
	}

	public static MentorLake.Gtk.GtkStatusIconHandle NewFromGicon(MentorLake.Gio.GIconHandle icon)
	{
		return GtkStatusIconHandleExterns.gtk_status_icon_new_from_gicon(icon);
	}

	public static MentorLake.Gtk.GtkStatusIconHandle NewFromIconName(string icon_name)
	{
		return GtkStatusIconHandleExterns.gtk_status_icon_new_from_icon_name(icon_name);
	}

	public static MentorLake.Gtk.GtkStatusIconHandle NewFromPixbuf(MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		return GtkStatusIconHandleExterns.gtk_status_icon_new_from_pixbuf(pixbuf);
	}

	public static MentorLake.Gtk.GtkStatusIconHandle NewFromStock(string stock_id)
	{
		return GtkStatusIconHandleExterns.gtk_status_icon_new_from_stock(stock_id);
	}

	public static void PositionMenu(MentorLake.Gtk.GtkMenuHandle menu, ref int x, ref int y, out bool push_in, MentorLake.Gtk.GtkStatusIconHandle user_data)
	{
		GtkStatusIconHandleExterns.gtk_status_icon_position_menu(menu, ref x, ref y, out push_in, user_data);
	}

}
public static class GtkStatusIconHandleSignalExtensions
{

	public static IObservable<GtkStatusIconHandleSignalStructs.ActivateSignal> Signal_Activate(this GtkStatusIconHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkStatusIconHandleSignalStructs.ActivateSignal> obs) =>
		{
			GtkStatusIconHandleSignalDelegates.activate handler = ( MentorLake.Gtk.GtkStatusIconHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkStatusIconHandleSignalStructs.ActivateSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkStatusIconHandleSignalStructs.ButtonPressEventSignal> Signal_ButtonPressEvent(this GtkStatusIconHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkStatusIconHandleSignalStructs.ButtonPressEventSignal> obs) =>
		{
			GtkStatusIconHandleSignalDelegates.button_press_event handler = ( MentorLake.Gtk.GtkStatusIconHandle self,  MentorLake.Gdk.GdkEventButtonHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkStatusIconHandleSignalStructs.ButtonPressEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "button-press-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkStatusIconHandleSignalStructs.ButtonReleaseEventSignal> Signal_ButtonReleaseEvent(this GtkStatusIconHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkStatusIconHandleSignalStructs.ButtonReleaseEventSignal> obs) =>
		{
			GtkStatusIconHandleSignalDelegates.button_release_event handler = ( MentorLake.Gtk.GtkStatusIconHandle self,  MentorLake.Gdk.GdkEventButtonHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkStatusIconHandleSignalStructs.ButtonReleaseEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "button-release-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkStatusIconHandleSignalStructs.PopupMenuSignal> Signal_PopupMenu(this GtkStatusIconHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkStatusIconHandleSignalStructs.PopupMenuSignal> obs) =>
		{
			GtkStatusIconHandleSignalDelegates.popup_menu handler = ( MentorLake.Gtk.GtkStatusIconHandle self,  uint button,  uint activate_time,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkStatusIconHandleSignalStructs.PopupMenuSignal()
				{
					Self = self, Button = button, ActivateTime = activate_time, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "popup-menu", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkStatusIconHandleSignalStructs.QueryTooltipSignal> Signal_QueryTooltip(this GtkStatusIconHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkStatusIconHandleSignalStructs.QueryTooltipSignal> obs) =>
		{
			GtkStatusIconHandleSignalDelegates.query_tooltip handler = ( MentorLake.Gtk.GtkStatusIconHandle self,  int x,  int y,  bool keyboard_mode,  MentorLake.Gtk.GtkTooltipHandle tooltip,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkStatusIconHandleSignalStructs.QueryTooltipSignal()
				{
					Self = self, X = x, Y = y, KeyboardMode = keyboard_mode, Tooltip = tooltip, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "query-tooltip", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkStatusIconHandleSignalStructs.ScrollEventSignal> Signal_ScrollEvent(this GtkStatusIconHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkStatusIconHandleSignalStructs.ScrollEventSignal> obs) =>
		{
			GtkStatusIconHandleSignalDelegates.scroll_event handler = ( MentorLake.Gtk.GtkStatusIconHandle self,  MentorLake.Gdk.GdkEventScrollHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkStatusIconHandleSignalStructs.ScrollEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "scroll-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkStatusIconHandleSignalStructs.SizeChangedSignal> Signal_SizeChanged(this GtkStatusIconHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkStatusIconHandleSignalStructs.SizeChangedSignal> obs) =>
		{
			GtkStatusIconHandleSignalDelegates.size_changed handler = ( MentorLake.Gtk.GtkStatusIconHandle self,  int size,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkStatusIconHandleSignalStructs.SizeChangedSignal()
				{
					Self = self, Size = size, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "size-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkStatusIconHandleSignalStructs
{

public class ActivateSignal
{
	public MentorLake.Gtk.GtkStatusIconHandle Self;
	public IntPtr UserData;
}

public class ButtonPressEventSignal
{
	public MentorLake.Gtk.GtkStatusIconHandle Self;
	public MentorLake.Gdk.GdkEventButtonHandle Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class ButtonReleaseEventSignal
{
	public MentorLake.Gtk.GtkStatusIconHandle Self;
	public MentorLake.Gdk.GdkEventButtonHandle Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class PopupMenuSignal
{
	public MentorLake.Gtk.GtkStatusIconHandle Self;
	public uint Button;
	public uint ActivateTime;
	public IntPtr UserData;
}

public class QueryTooltipSignal
{
	public MentorLake.Gtk.GtkStatusIconHandle Self;
	public int X;
	public int Y;
	public bool KeyboardMode;
	public MentorLake.Gtk.GtkTooltipHandle Tooltip;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class ScrollEventSignal
{
	public MentorLake.Gtk.GtkStatusIconHandle Self;
	public MentorLake.Gdk.GdkEventScrollHandle Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class SizeChangedSignal
{
	public MentorLake.Gtk.GtkStatusIconHandle Self;
	public int Size;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GtkStatusIconHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool button_press_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventButtonHandle>))] MentorLake.Gdk.GdkEventButtonHandle @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool button_release_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventButtonHandle>))] MentorLake.Gdk.GdkEventButtonHandle @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void popup_menu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle self, uint button, uint activate_time, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool query_tooltip([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle self, int x, int y, bool keyboard_mode, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTooltipHandle>))] MentorLake.Gtk.GtkTooltipHandle tooltip, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool scroll_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventScrollHandle>))] MentorLake.Gdk.GdkEventScrollHandle @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool size_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle self, int size, IntPtr user_data);

}


public static class GtkStatusIconHandleExtensions
{
	public static bool GetGeometry(this MentorLake.Gtk.GtkStatusIconHandle status_icon, out MentorLake.Gdk.GdkScreenHandle screen, out MentorLake.Gdk.GdkRectangle area, out MentorLake.Gtk.GtkOrientation orientation)
	{
		if (status_icon.IsInvalid || status_icon.IsClosed) throw new Exception("Invalid or closed handle (GtkStatusIconHandle)");
		return GtkStatusIconHandleExterns.gtk_status_icon_get_geometry(status_icon, out screen, out area, out orientation);
	}

	public static MentorLake.Gio.GIconHandle GetGicon(this MentorLake.Gtk.GtkStatusIconHandle status_icon)
	{
		if (status_icon.IsInvalid || status_icon.IsClosed) throw new Exception("Invalid or closed handle (GtkStatusIconHandle)");
		return GtkStatusIconHandleExterns.gtk_status_icon_get_gicon(status_icon);
	}

	public static bool GetHasTooltip(this MentorLake.Gtk.GtkStatusIconHandle status_icon)
	{
		if (status_icon.IsInvalid || status_icon.IsClosed) throw new Exception("Invalid or closed handle (GtkStatusIconHandle)");
		return GtkStatusIconHandleExterns.gtk_status_icon_get_has_tooltip(status_icon);
	}

	public static string GetIconName(this MentorLake.Gtk.GtkStatusIconHandle status_icon)
	{
		if (status_icon.IsInvalid || status_icon.IsClosed) throw new Exception("Invalid or closed handle (GtkStatusIconHandle)");
		return GtkStatusIconHandleExterns.gtk_status_icon_get_icon_name(status_icon);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle GetPixbuf(this MentorLake.Gtk.GtkStatusIconHandle status_icon)
	{
		if (status_icon.IsInvalid || status_icon.IsClosed) throw new Exception("Invalid or closed handle (GtkStatusIconHandle)");
		return GtkStatusIconHandleExterns.gtk_status_icon_get_pixbuf(status_icon);
	}

	public static MentorLake.Gdk.GdkScreenHandle GetScreen(this MentorLake.Gtk.GtkStatusIconHandle status_icon)
	{
		if (status_icon.IsInvalid || status_icon.IsClosed) throw new Exception("Invalid or closed handle (GtkStatusIconHandle)");
		return GtkStatusIconHandleExterns.gtk_status_icon_get_screen(status_icon);
	}

	public static int GetSize(this MentorLake.Gtk.GtkStatusIconHandle status_icon)
	{
		if (status_icon.IsInvalid || status_icon.IsClosed) throw new Exception("Invalid or closed handle (GtkStatusIconHandle)");
		return GtkStatusIconHandleExterns.gtk_status_icon_get_size(status_icon);
	}

	public static string GetStock(this MentorLake.Gtk.GtkStatusIconHandle status_icon)
	{
		if (status_icon.IsInvalid || status_icon.IsClosed) throw new Exception("Invalid or closed handle (GtkStatusIconHandle)");
		return GtkStatusIconHandleExterns.gtk_status_icon_get_stock(status_icon);
	}

	public static MentorLake.Gtk.GtkImageType GetStorageType(this MentorLake.Gtk.GtkStatusIconHandle status_icon)
	{
		if (status_icon.IsInvalid || status_icon.IsClosed) throw new Exception("Invalid or closed handle (GtkStatusIconHandle)");
		return GtkStatusIconHandleExterns.gtk_status_icon_get_storage_type(status_icon);
	}

	public static string GetTitle(this MentorLake.Gtk.GtkStatusIconHandle status_icon)
	{
		if (status_icon.IsInvalid || status_icon.IsClosed) throw new Exception("Invalid or closed handle (GtkStatusIconHandle)");
		return GtkStatusIconHandleExterns.gtk_status_icon_get_title(status_icon);
	}

	public static string GetTooltipMarkup(this MentorLake.Gtk.GtkStatusIconHandle status_icon)
	{
		if (status_icon.IsInvalid || status_icon.IsClosed) throw new Exception("Invalid or closed handle (GtkStatusIconHandle)");
		return GtkStatusIconHandleExterns.gtk_status_icon_get_tooltip_markup(status_icon);
	}

	public static string GetTooltipText(this MentorLake.Gtk.GtkStatusIconHandle status_icon)
	{
		if (status_icon.IsInvalid || status_icon.IsClosed) throw new Exception("Invalid or closed handle (GtkStatusIconHandle)");
		return GtkStatusIconHandleExterns.gtk_status_icon_get_tooltip_text(status_icon);
	}

	public static bool GetVisible(this MentorLake.Gtk.GtkStatusIconHandle status_icon)
	{
		if (status_icon.IsInvalid || status_icon.IsClosed) throw new Exception("Invalid or closed handle (GtkStatusIconHandle)");
		return GtkStatusIconHandleExterns.gtk_status_icon_get_visible(status_icon);
	}

	public static uint GetX11WindowId(this MentorLake.Gtk.GtkStatusIconHandle status_icon)
	{
		if (status_icon.IsInvalid || status_icon.IsClosed) throw new Exception("Invalid or closed handle (GtkStatusIconHandle)");
		return GtkStatusIconHandleExterns.gtk_status_icon_get_x11_window_id(status_icon);
	}

	public static bool IsEmbedded(this MentorLake.Gtk.GtkStatusIconHandle status_icon)
	{
		if (status_icon.IsInvalid || status_icon.IsClosed) throw new Exception("Invalid or closed handle (GtkStatusIconHandle)");
		return GtkStatusIconHandleExterns.gtk_status_icon_is_embedded(status_icon);
	}

	public static T SetFromFile<T>(this T status_icon, string filename) where T : GtkStatusIconHandle
	{
		if (status_icon.IsInvalid || status_icon.IsClosed) throw new Exception("Invalid or closed handle (GtkStatusIconHandle)");
		GtkStatusIconHandleExterns.gtk_status_icon_set_from_file(status_icon, filename);
		return status_icon;
	}

	public static T SetFromGicon<T>(this T status_icon, MentorLake.Gio.GIconHandle icon) where T : GtkStatusIconHandle
	{
		if (status_icon.IsInvalid || status_icon.IsClosed) throw new Exception("Invalid or closed handle (GtkStatusIconHandle)");
		GtkStatusIconHandleExterns.gtk_status_icon_set_from_gicon(status_icon, icon);
		return status_icon;
	}

	public static T SetFromIconName<T>(this T status_icon, string icon_name) where T : GtkStatusIconHandle
	{
		if (status_icon.IsInvalid || status_icon.IsClosed) throw new Exception("Invalid or closed handle (GtkStatusIconHandle)");
		GtkStatusIconHandleExterns.gtk_status_icon_set_from_icon_name(status_icon, icon_name);
		return status_icon;
	}

	public static T SetFromPixbuf<T>(this T status_icon, MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf) where T : GtkStatusIconHandle
	{
		if (status_icon.IsInvalid || status_icon.IsClosed) throw new Exception("Invalid or closed handle (GtkStatusIconHandle)");
		GtkStatusIconHandleExterns.gtk_status_icon_set_from_pixbuf(status_icon, pixbuf);
		return status_icon;
	}

	public static T SetFromStock<T>(this T status_icon, string stock_id) where T : GtkStatusIconHandle
	{
		if (status_icon.IsInvalid || status_icon.IsClosed) throw new Exception("Invalid or closed handle (GtkStatusIconHandle)");
		GtkStatusIconHandleExterns.gtk_status_icon_set_from_stock(status_icon, stock_id);
		return status_icon;
	}

	public static T SetHasTooltip<T>(this T status_icon, bool has_tooltip) where T : GtkStatusIconHandle
	{
		if (status_icon.IsInvalid || status_icon.IsClosed) throw new Exception("Invalid or closed handle (GtkStatusIconHandle)");
		GtkStatusIconHandleExterns.gtk_status_icon_set_has_tooltip(status_icon, has_tooltip);
		return status_icon;
	}

	public static T SetName<T>(this T status_icon, string name) where T : GtkStatusIconHandle
	{
		if (status_icon.IsInvalid || status_icon.IsClosed) throw new Exception("Invalid or closed handle (GtkStatusIconHandle)");
		GtkStatusIconHandleExterns.gtk_status_icon_set_name(status_icon, name);
		return status_icon;
	}

	public static T SetScreen<T>(this T status_icon, MentorLake.Gdk.GdkScreenHandle screen) where T : GtkStatusIconHandle
	{
		if (status_icon.IsInvalid || status_icon.IsClosed) throw new Exception("Invalid or closed handle (GtkStatusIconHandle)");
		GtkStatusIconHandleExterns.gtk_status_icon_set_screen(status_icon, screen);
		return status_icon;
	}

	public static T SetTitle<T>(this T status_icon, string title) where T : GtkStatusIconHandle
	{
		if (status_icon.IsInvalid || status_icon.IsClosed) throw new Exception("Invalid or closed handle (GtkStatusIconHandle)");
		GtkStatusIconHandleExterns.gtk_status_icon_set_title(status_icon, title);
		return status_icon;
	}

	public static T SetTooltipMarkup<T>(this T status_icon, string markup) where T : GtkStatusIconHandle
	{
		if (status_icon.IsInvalid || status_icon.IsClosed) throw new Exception("Invalid or closed handle (GtkStatusIconHandle)");
		GtkStatusIconHandleExterns.gtk_status_icon_set_tooltip_markup(status_icon, markup);
		return status_icon;
	}

	public static T SetTooltipText<T>(this T status_icon, string text) where T : GtkStatusIconHandle
	{
		if (status_icon.IsInvalid || status_icon.IsClosed) throw new Exception("Invalid or closed handle (GtkStatusIconHandle)");
		GtkStatusIconHandleExterns.gtk_status_icon_set_tooltip_text(status_icon, text);
		return status_icon;
	}

	public static T SetVisible<T>(this T status_icon, bool visible) where T : GtkStatusIconHandle
	{
		if (status_icon.IsInvalid || status_icon.IsClosed) throw new Exception("Invalid or closed handle (GtkStatusIconHandle)");
		GtkStatusIconHandleExterns.gtk_status_icon_set_visible(status_icon, visible);
		return status_icon;
	}

}

internal class GtkStatusIconHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkStatusIconHandle gtk_status_icon_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkStatusIconHandle gtk_status_icon_new_from_file(string filename);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkStatusIconHandle gtk_status_icon_new_from_gicon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkStatusIconHandle gtk_status_icon_new_from_icon_name(string icon_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkStatusIconHandle gtk_status_icon_new_from_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkStatusIconHandle gtk_status_icon_new_from_stock(string stock_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_status_icon_get_geometry([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] out MentorLake.Gdk.GdkScreenHandle screen, out MentorLake.Gdk.GdkRectangle area, out MentorLake.Gtk.GtkOrientation orientation);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gio.GIconHandle gtk_status_icon_get_gicon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_status_icon_get_has_tooltip([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_status_icon_get_icon_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_status_icon_get_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkScreenHandle gtk_status_icon_get_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_status_icon_get_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_status_icon_get_stock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkImageType gtk_status_icon_get_storage_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_status_icon_get_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_status_icon_get_tooltip_markup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_status_icon_get_tooltip_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_status_icon_get_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_status_icon_get_x11_window_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_status_icon_is_embedded([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_status_icon_set_from_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon, string filename);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_status_icon_set_from_gicon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_status_icon_set_from_icon_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon, string icon_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_status_icon_set_from_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_status_icon_set_from_stock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon, string stock_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_status_icon_set_has_tooltip([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon, bool has_tooltip);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_status_icon_set_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon, string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_status_icon_set_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_status_icon_set_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon, string title);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_status_icon_set_tooltip_markup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon, string markup);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_status_icon_set_tooltip_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon, string text);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_status_icon_set_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle status_icon, bool visible);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_status_icon_position_menu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu, ref int x, ref int y, out bool push_in, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStatusIconHandle>))] MentorLake.Gtk.GtkStatusIconHandle user_data);

}
