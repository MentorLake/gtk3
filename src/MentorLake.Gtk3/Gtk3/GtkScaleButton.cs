namespace MentorLake.Gtk3.Gtk3;

public class GtkScaleButtonHandle : GtkButtonHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static GtkScaleButtonHandle New(GtkIconSize size, double min, double max, double step, string[] icons)
	{
		return GtkScaleButtonExterns.gtk_scale_button_new(size, min, max, step, icons);
	}

}

public static class GtkScaleButtonSignalExtensions
{

	public static IObservable<GtkScaleButtonSignalStructs.PopdownSignal> Signal_Popdown(this GtkScaleButtonHandle instance)
	{
		return Observable.Create((IObserver<GtkScaleButtonSignalStructs.PopdownSignal> obs) =>
		{
			GtkScaleButtonSignalDelegates.popdown handler = (GtkScaleButtonHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkScaleButtonSignalStructs.PopdownSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "popdown", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkScaleButtonSignalStructs.PopupSignal> Signal_Popup(this GtkScaleButtonHandle instance)
	{
		return Observable.Create((IObserver<GtkScaleButtonSignalStructs.PopupSignal> obs) =>
		{
			GtkScaleButtonSignalDelegates.popup handler = (GtkScaleButtonHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkScaleButtonSignalStructs.PopupSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "popup", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkScaleButtonSignalStructs.ValueChangedSignal> Signal_ValueChanged(this GtkScaleButtonHandle instance)
	{
		return Observable.Create((IObserver<GtkScaleButtonSignalStructs.ValueChangedSignal> obs) =>
		{
			GtkScaleButtonSignalDelegates.value_changed handler = (GtkScaleButtonHandle self, double value, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkScaleButtonSignalStructs.ValueChangedSignal()
				{
					Self = self, Value = value, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "value_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkScaleButtonSignalStructs
{

public struct PopdownSignal
{
	public GtkScaleButtonHandle Self;
	public IntPtr UserData;
}

public struct PopupSignal
{
	public GtkScaleButtonHandle Self;
	public IntPtr UserData;
}

public struct ValueChangedSignal
{
	public GtkScaleButtonHandle Self;
	public double Value;
	public IntPtr UserData;
}
}

public static class GtkScaleButtonSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void popdown([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkScaleButtonHandle>))] GtkScaleButtonHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void popup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkScaleButtonHandle>))] GtkScaleButtonHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void value_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkScaleButtonHandle>))] GtkScaleButtonHandle self, double value, IntPtr user_data);

}


public static class GtkScaleButtonHandleExtensions
{
	public static GtkAdjustmentHandle GetAdjustment(this GtkScaleButtonHandle button)
	{
		return GtkScaleButtonExterns.gtk_scale_button_get_adjustment(button);
	}

	public static GtkWidgetHandle GetMinusButton(this GtkScaleButtonHandle button)
	{
		return GtkScaleButtonExterns.gtk_scale_button_get_minus_button(button);
	}

	public static GtkWidgetHandle GetPlusButton(this GtkScaleButtonHandle button)
	{
		return GtkScaleButtonExterns.gtk_scale_button_get_plus_button(button);
	}

	public static GtkWidgetHandle GetPopup(this GtkScaleButtonHandle button)
	{
		return GtkScaleButtonExterns.gtk_scale_button_get_popup(button);
	}

	public static double GetValue(this GtkScaleButtonHandle button)
	{
		return GtkScaleButtonExterns.gtk_scale_button_get_value(button);
	}

	public static T SetAdjustment<T>(this T button, GtkAdjustmentHandle adjustment) where T : GtkScaleButtonHandle
	{
		GtkScaleButtonExterns.gtk_scale_button_set_adjustment(button, adjustment);
		return button;
	}

	public static T SetIcons<T>(this T button, string[] icons) where T : GtkScaleButtonHandle
	{
		GtkScaleButtonExterns.gtk_scale_button_set_icons(button, icons);
		return button;
	}

	public static T SetValue<T>(this T button, double value) where T : GtkScaleButtonHandle
	{
		GtkScaleButtonExterns.gtk_scale_button_set_value(button, value);
		return button;
	}

}

internal class GtkScaleButtonExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkScaleButtonHandle gtk_scale_button_new(GtkIconSize size, double min, double max, double step, string[] icons);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkAdjustmentHandle gtk_scale_button_get_adjustment(GtkScaleButtonHandle button);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_scale_button_get_minus_button(GtkScaleButtonHandle button);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_scale_button_get_plus_button(GtkScaleButtonHandle button);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_scale_button_get_popup(GtkScaleButtonHandle button);

	[DllImport(Libraries.Gtk3)]
	internal static extern double gtk_scale_button_get_value(GtkScaleButtonHandle button);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_scale_button_set_adjustment(GtkScaleButtonHandle button, GtkAdjustmentHandle adjustment);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_scale_button_set_icons(GtkScaleButtonHandle button, string[] icons);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_scale_button_set_value(GtkScaleButtonHandle button, double value);

}
