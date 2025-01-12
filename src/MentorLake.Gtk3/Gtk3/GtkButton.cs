namespace MentorLake.Gtk3.Gtk3;

public class GtkButtonHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
	public static GtkButtonHandle New()
	{
		return GtkButtonExterns.gtk_button_new();
	}

	public static GtkButtonHandle NewFromIconName(string icon_name, GtkIconSize size)
	{
		return GtkButtonExterns.gtk_button_new_from_icon_name(icon_name, size);
	}

	public static GtkButtonHandle NewFromStock(string stock_id)
	{
		return GtkButtonExterns.gtk_button_new_from_stock(stock_id);
	}

	public static GtkButtonHandle NewWithLabel(string label)
	{
		return GtkButtonExterns.gtk_button_new_with_label(label);
	}

	public static GtkButtonHandle NewWithMnemonic(string label)
	{
		return GtkButtonExterns.gtk_button_new_with_mnemonic(label);
	}

}

public static class GtkButtonSignalExtensions
{

	public static IObservable<GtkButtonSignalStructs.ActivateSignal> Signal_Activate(this GtkButtonHandle instance)
	{
		return Observable.Create((IObserver<GtkButtonSignalStructs.ActivateSignal> obs) =>
		{
			GtkButtonSignalDelegates.activate handler = (GtkButtonHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkButtonSignalStructs.ActivateSignal()
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

	public static IObservable<GtkButtonSignalStructs.ClickedSignal> Signal_Clicked(this GtkButtonHandle instance)
	{
		return Observable.Create((IObserver<GtkButtonSignalStructs.ClickedSignal> obs) =>
		{
			GtkButtonSignalDelegates.clicked handler = (GtkButtonHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkButtonSignalStructs.ClickedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "clicked", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkButtonSignalStructs.EnterSignal> Signal_Enter(this GtkButtonHandle instance)
	{
		return Observable.Create((IObserver<GtkButtonSignalStructs.EnterSignal> obs) =>
		{
			GtkButtonSignalDelegates.enter handler = (GtkButtonHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkButtonSignalStructs.EnterSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "enter", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkButtonSignalStructs.LeaveSignal> Signal_Leave(this GtkButtonHandle instance)
	{
		return Observable.Create((IObserver<GtkButtonSignalStructs.LeaveSignal> obs) =>
		{
			GtkButtonSignalDelegates.leave handler = (GtkButtonHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkButtonSignalStructs.LeaveSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "leave", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkButtonSignalStructs.PressedSignal> Signal_Pressed(this GtkButtonHandle instance)
	{
		return Observable.Create((IObserver<GtkButtonSignalStructs.PressedSignal> obs) =>
		{
			GtkButtonSignalDelegates.pressed handler = (GtkButtonHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkButtonSignalStructs.PressedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "pressed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkButtonSignalStructs.ReleasedSignal> Signal_Released(this GtkButtonHandle instance)
	{
		return Observable.Create((IObserver<GtkButtonSignalStructs.ReleasedSignal> obs) =>
		{
			GtkButtonSignalDelegates.released handler = (GtkButtonHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkButtonSignalStructs.ReleasedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "released", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkButtonSignalStructs
{

public struct ActivateSignal
{
	public GtkButtonHandle Self;
	public IntPtr UserData;
}

public struct ClickedSignal
{
	public GtkButtonHandle Self;
	public IntPtr UserData;
}

public struct EnterSignal
{
	public GtkButtonHandle Self;
	public IntPtr UserData;
}

public struct LeaveSignal
{
	public GtkButtonHandle Self;
	public IntPtr UserData;
}

public struct PressedSignal
{
	public GtkButtonHandle Self;
	public IntPtr UserData;
}

public struct ReleasedSignal
{
	public GtkButtonHandle Self;
	public IntPtr UserData;
}
}

public static class GtkButtonSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkButtonHandle>))] GtkButtonHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void clicked([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkButtonHandle>))] GtkButtonHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void enter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkButtonHandle>))] GtkButtonHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void leave([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkButtonHandle>))] GtkButtonHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void pressed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkButtonHandle>))] GtkButtonHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void released([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkButtonHandle>))] GtkButtonHandle self, IntPtr user_data);

}


public static class GtkButtonHandleExtensions
{
	public static GtkButtonHandle Clicked(this GtkButtonHandle button)
	{
		GtkButtonExterns.gtk_button_clicked(button);
		return button;
	}

	public static GtkButtonHandle Enter(this GtkButtonHandle button)
	{
		GtkButtonExterns.gtk_button_enter(button);
		return button;
	}

	public static GtkButtonHandle GetAlignment(this GtkButtonHandle button, out float xalign, out float yalign)
	{
		GtkButtonExterns.gtk_button_get_alignment(button, out xalign, out yalign);
		return button;
	}

	public static bool GetAlwaysShowImage(this GtkButtonHandle button)
	{
		return GtkButtonExterns.gtk_button_get_always_show_image(button);
	}

	public static GdkWindowHandle GetEventWindow(this GtkButtonHandle button)
	{
		return GtkButtonExterns.gtk_button_get_event_window(button);
	}

	public static bool GetFocusOnClick(this GtkButtonHandle button)
	{
		return GtkButtonExterns.gtk_button_get_focus_on_click(button);
	}

	public static GtkWidgetHandle GetImage(this GtkButtonHandle button)
	{
		return GtkButtonExterns.gtk_button_get_image(button);
	}

	public static GtkPositionType GetImagePosition(this GtkButtonHandle button)
	{
		return GtkButtonExterns.gtk_button_get_image_position(button);
	}

	public static string GetLabel(this GtkButtonHandle button)
	{
		return GtkButtonExterns.gtk_button_get_label(button);
	}

	public static GtkReliefStyle GetRelief(this GtkButtonHandle button)
	{
		return GtkButtonExterns.gtk_button_get_relief(button);
	}

	public static bool GetUseStock(this GtkButtonHandle button)
	{
		return GtkButtonExterns.gtk_button_get_use_stock(button);
	}

	public static bool GetUseUnderline(this GtkButtonHandle button)
	{
		return GtkButtonExterns.gtk_button_get_use_underline(button);
	}

	public static GtkButtonHandle Leave(this GtkButtonHandle button)
	{
		GtkButtonExterns.gtk_button_leave(button);
		return button;
	}

	public static GtkButtonHandle Pressed(this GtkButtonHandle button)
	{
		GtkButtonExterns.gtk_button_pressed(button);
		return button;
	}

	public static GtkButtonHandle Released(this GtkButtonHandle button)
	{
		GtkButtonExterns.gtk_button_released(button);
		return button;
	}

	public static GtkButtonHandle SetAlignment(this GtkButtonHandle button, float xalign, float yalign)
	{
		GtkButtonExterns.gtk_button_set_alignment(button, xalign, yalign);
		return button;
	}

	public static GtkButtonHandle SetAlwaysShowImage(this GtkButtonHandle button, bool always_show)
	{
		GtkButtonExterns.gtk_button_set_always_show_image(button, always_show);
		return button;
	}

	public static GtkButtonHandle SetFocusOnClick(this GtkButtonHandle button, bool focus_on_click)
	{
		GtkButtonExterns.gtk_button_set_focus_on_click(button, focus_on_click);
		return button;
	}

	public static GtkButtonHandle SetImage(this GtkButtonHandle button, GtkWidgetHandle image)
	{
		GtkButtonExterns.gtk_button_set_image(button, image);
		return button;
	}

	public static GtkButtonHandle SetImagePosition(this GtkButtonHandle button, GtkPositionType position)
	{
		GtkButtonExterns.gtk_button_set_image_position(button, position);
		return button;
	}

	public static GtkButtonHandle SetLabel(this GtkButtonHandle button, string label)
	{
		GtkButtonExterns.gtk_button_set_label(button, label);
		return button;
	}

	public static GtkButtonHandle SetRelief(this GtkButtonHandle button, GtkReliefStyle relief)
	{
		GtkButtonExterns.gtk_button_set_relief(button, relief);
		return button;
	}

	public static GtkButtonHandle SetUseStock(this GtkButtonHandle button, bool use_stock)
	{
		GtkButtonExterns.gtk_button_set_use_stock(button, use_stock);
		return button;
	}

	public static GtkButtonHandle SetUseUnderline(this GtkButtonHandle button, bool use_underline)
	{
		GtkButtonExterns.gtk_button_set_use_underline(button, use_underline);
		return button;
	}

}

internal class GtkButtonExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkButtonHandle gtk_button_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkButtonHandle gtk_button_new_from_icon_name(string icon_name, GtkIconSize size);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkButtonHandle gtk_button_new_from_stock(string stock_id);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkButtonHandle gtk_button_new_with_label(string label);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkButtonHandle gtk_button_new_with_mnemonic(string label);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_button_clicked(GtkButtonHandle button);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_button_enter(GtkButtonHandle button);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_button_get_alignment(GtkButtonHandle button, out float xalign, out float yalign);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_button_get_always_show_image(GtkButtonHandle button);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkWindowHandle gtk_button_get_event_window(GtkButtonHandle button);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_button_get_focus_on_click(GtkButtonHandle button);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_button_get_image(GtkButtonHandle button);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPositionType gtk_button_get_image_position(GtkButtonHandle button);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_button_get_label(GtkButtonHandle button);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkReliefStyle gtk_button_get_relief(GtkButtonHandle button);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_button_get_use_stock(GtkButtonHandle button);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_button_get_use_underline(GtkButtonHandle button);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_button_leave(GtkButtonHandle button);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_button_pressed(GtkButtonHandle button);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_button_released(GtkButtonHandle button);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_button_set_alignment(GtkButtonHandle button, float xalign, float yalign);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_button_set_always_show_image(GtkButtonHandle button, bool always_show);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_button_set_focus_on_click(GtkButtonHandle button, bool focus_on_click);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_button_set_image(GtkButtonHandle button, GtkWidgetHandle image);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_button_set_image_position(GtkButtonHandle button, GtkPositionType position);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_button_set_label(GtkButtonHandle button, string label);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_button_set_relief(GtkButtonHandle button, GtkReliefStyle relief);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_button_set_use_stock(GtkButtonHandle button, bool use_stock);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_button_set_use_underline(GtkButtonHandle button, bool use_underline);

}
