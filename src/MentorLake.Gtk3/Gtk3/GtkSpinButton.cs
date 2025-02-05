namespace MentorLake.Gtk3.Gtk3;

public class GtkSpinButtonHandle : GtkEntryHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkCellEditableHandle, GtkEditableHandle, GtkOrientableHandle
{
	public static GtkSpinButtonHandle New(GtkAdjustmentHandle adjustment, double climb_rate, uint digits)
	{
		return GtkSpinButtonExterns.gtk_spin_button_new(adjustment, climb_rate, digits);
	}

	public static GtkSpinButtonHandle NewWithRange(double min, double max, double step)
	{
		return GtkSpinButtonExterns.gtk_spin_button_new_with_range(min, max, step);
	}

}

public static class GtkSpinButtonSignalExtensions
{

	public static IObservable<GtkSpinButtonSignalStructs.ChangeValueSignal> Signal_ChangeValue(this GtkSpinButtonHandle instance)
	{
		return Observable.Create((IObserver<GtkSpinButtonSignalStructs.ChangeValueSignal> obs) =>
		{
			GtkSpinButtonSignalDelegates.change_value handler = (GtkSpinButtonHandle self, ref GtkScrollType scroll, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSpinButtonSignalStructs.ChangeValueSignal()
				{
					Self = self, Scroll = scroll, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "change_value", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkSpinButtonSignalStructs.InputSignal> Signal_Input(this GtkSpinButtonHandle instance)
	{
		return Observable.Create((IObserver<GtkSpinButtonSignalStructs.InputSignal> obs) =>
		{
			GtkSpinButtonSignalDelegates.input handler = (GtkSpinButtonHandle self, out double new_value, IntPtr user_data) =>
			{
				new_value = default;

				var signalStruct = new GtkSpinButtonSignalStructs.InputSignal()
				{
					Self = self, NewValue = new_value, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "input", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkSpinButtonSignalStructs.OutputSignal> Signal_Output(this GtkSpinButtonHandle instance)
	{
		return Observable.Create((IObserver<GtkSpinButtonSignalStructs.OutputSignal> obs) =>
		{
			GtkSpinButtonSignalDelegates.output handler = (GtkSpinButtonHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSpinButtonSignalStructs.OutputSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "output", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkSpinButtonSignalStructs.ValueChangedSignal> Signal_ValueChanged(this GtkSpinButtonHandle instance)
	{
		return Observable.Create((IObserver<GtkSpinButtonSignalStructs.ValueChangedSignal> obs) =>
		{
			GtkSpinButtonSignalDelegates.value_changed handler = (GtkSpinButtonHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSpinButtonSignalStructs.ValueChangedSignal()
				{
					Self = self, UserData = user_data
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

	public static IObservable<GtkSpinButtonSignalStructs.WrappedSignal> Signal_Wrapped(this GtkSpinButtonHandle instance)
	{
		return Observable.Create((IObserver<GtkSpinButtonSignalStructs.WrappedSignal> obs) =>
		{
			GtkSpinButtonSignalDelegates.wrapped handler = (GtkSpinButtonHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSpinButtonSignalStructs.WrappedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "wrapped", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkSpinButtonSignalStructs
{

public struct ChangeValueSignal
{
	public GtkSpinButtonHandle Self;
	public GtkScrollType Scroll;
	public IntPtr UserData;
}

public struct InputSignal
{
	public GtkSpinButtonHandle Self;
	public double NewValue;
	public IntPtr UserData;
	public int ReturnValue;
}

public struct OutputSignal
{
	public GtkSpinButtonHandle Self;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct ValueChangedSignal
{
	public GtkSpinButtonHandle Self;
	public IntPtr UserData;
}

public struct WrappedSignal
{
	public GtkSpinButtonHandle Self;
	public IntPtr UserData;
}
}

public static class GtkSpinButtonSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void change_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkSpinButtonHandle>))] GtkSpinButtonHandle self, ref GtkScrollType scroll, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int input([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkSpinButtonHandle>))] GtkSpinButtonHandle self, out double new_value, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool output([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkSpinButtonHandle>))] GtkSpinButtonHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void value_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkSpinButtonHandle>))] GtkSpinButtonHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void wrapped([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkSpinButtonHandle>))] GtkSpinButtonHandle self, IntPtr user_data);

}


public static class GtkSpinButtonHandleExtensions
{
	public static T Configure<T>(this T spin_button, GtkAdjustmentHandle adjustment, double climb_rate, uint digits) where T : GtkSpinButtonHandle
	{
		GtkSpinButtonExterns.gtk_spin_button_configure(spin_button, adjustment, climb_rate, digits);
		return spin_button;
	}

	public static GtkAdjustmentHandle GetAdjustment(this GtkSpinButtonHandle spin_button)
	{
		return GtkSpinButtonExterns.gtk_spin_button_get_adjustment(spin_button);
	}

	public static uint GetDigits(this GtkSpinButtonHandle spin_button)
	{
		return GtkSpinButtonExterns.gtk_spin_button_get_digits(spin_button);
	}

	public static T GetIncrements<T>(this T spin_button, out double step, out double page) where T : GtkSpinButtonHandle
	{
		GtkSpinButtonExterns.gtk_spin_button_get_increments(spin_button, out step, out page);
		return spin_button;
	}

	public static bool GetNumeric(this GtkSpinButtonHandle spin_button)
	{
		return GtkSpinButtonExterns.gtk_spin_button_get_numeric(spin_button);
	}

	public static T GetRange<T>(this T spin_button, out double min, out double max) where T : GtkSpinButtonHandle
	{
		GtkSpinButtonExterns.gtk_spin_button_get_range(spin_button, out min, out max);
		return spin_button;
	}

	public static bool GetSnapToTicks(this GtkSpinButtonHandle spin_button)
	{
		return GtkSpinButtonExterns.gtk_spin_button_get_snap_to_ticks(spin_button);
	}

	public static GtkSpinButtonUpdatePolicy GetUpdatePolicy(this GtkSpinButtonHandle spin_button)
	{
		return GtkSpinButtonExterns.gtk_spin_button_get_update_policy(spin_button);
	}

	public static double GetValue(this GtkSpinButtonHandle spin_button)
	{
		return GtkSpinButtonExterns.gtk_spin_button_get_value(spin_button);
	}

	public static int GetValueAsInt(this GtkSpinButtonHandle spin_button)
	{
		return GtkSpinButtonExterns.gtk_spin_button_get_value_as_int(spin_button);
	}

	public static bool GetWrap(this GtkSpinButtonHandle spin_button)
	{
		return GtkSpinButtonExterns.gtk_spin_button_get_wrap(spin_button);
	}

	public static T SetAdjustment<T>(this T spin_button, GtkAdjustmentHandle adjustment) where T : GtkSpinButtonHandle
	{
		GtkSpinButtonExterns.gtk_spin_button_set_adjustment(spin_button, adjustment);
		return spin_button;
	}

	public static T SetDigits<T>(this T spin_button, uint digits) where T : GtkSpinButtonHandle
	{
		GtkSpinButtonExterns.gtk_spin_button_set_digits(spin_button, digits);
		return spin_button;
	}

	public static T SetIncrements<T>(this T spin_button, double step, double page) where T : GtkSpinButtonHandle
	{
		GtkSpinButtonExterns.gtk_spin_button_set_increments(spin_button, step, page);
		return spin_button;
	}

	public static T SetNumeric<T>(this T spin_button, bool numeric) where T : GtkSpinButtonHandle
	{
		GtkSpinButtonExterns.gtk_spin_button_set_numeric(spin_button, numeric);
		return spin_button;
	}

	public static T SetRange<T>(this T spin_button, double min, double max) where T : GtkSpinButtonHandle
	{
		GtkSpinButtonExterns.gtk_spin_button_set_range(spin_button, min, max);
		return spin_button;
	}

	public static T SetSnapToTicks<T>(this T spin_button, bool snap_to_ticks) where T : GtkSpinButtonHandle
	{
		GtkSpinButtonExterns.gtk_spin_button_set_snap_to_ticks(spin_button, snap_to_ticks);
		return spin_button;
	}

	public static T SetUpdatePolicy<T>(this T spin_button, GtkSpinButtonUpdatePolicy policy) where T : GtkSpinButtonHandle
	{
		GtkSpinButtonExterns.gtk_spin_button_set_update_policy(spin_button, policy);
		return spin_button;
	}

	public static T SetValue<T>(this T spin_button, double value) where T : GtkSpinButtonHandle
	{
		GtkSpinButtonExterns.gtk_spin_button_set_value(spin_button, value);
		return spin_button;
	}

	public static T SetWrap<T>(this T spin_button, bool wrap) where T : GtkSpinButtonHandle
	{
		GtkSpinButtonExterns.gtk_spin_button_set_wrap(spin_button, wrap);
		return spin_button;
	}

	public static T Spin<T>(this T spin_button, GtkSpinType direction, double increment) where T : GtkSpinButtonHandle
	{
		GtkSpinButtonExterns.gtk_spin_button_spin(spin_button, direction, increment);
		return spin_button;
	}

	public static T Update<T>(this T spin_button) where T : GtkSpinButtonHandle
	{
		GtkSpinButtonExterns.gtk_spin_button_update(spin_button);
		return spin_button;
	}

	public static bool GtkTestSpinButtonClick(this GtkSpinButtonHandle spinner, uint button, bool upwards)
	{
		return GtkSpinButtonExterns.gtk_test_spin_button_click(spinner, button, upwards);
	}

}

internal class GtkSpinButtonExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkSpinButtonHandle gtk_spin_button_new(GtkAdjustmentHandle adjustment, double climb_rate, uint digits);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkSpinButtonHandle gtk_spin_button_new_with_range(double min, double max, double step);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_spin_button_configure(GtkSpinButtonHandle spin_button, GtkAdjustmentHandle adjustment, double climb_rate, uint digits);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkAdjustmentHandle gtk_spin_button_get_adjustment(GtkSpinButtonHandle spin_button);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_spin_button_get_digits(GtkSpinButtonHandle spin_button);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_spin_button_get_increments(GtkSpinButtonHandle spin_button, out double step, out double page);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_spin_button_get_numeric(GtkSpinButtonHandle spin_button);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_spin_button_get_range(GtkSpinButtonHandle spin_button, out double min, out double max);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_spin_button_get_snap_to_ticks(GtkSpinButtonHandle spin_button);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkSpinButtonUpdatePolicy gtk_spin_button_get_update_policy(GtkSpinButtonHandle spin_button);

	[DllImport(Libraries.Gtk3)]
	internal static extern double gtk_spin_button_get_value(GtkSpinButtonHandle spin_button);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_spin_button_get_value_as_int(GtkSpinButtonHandle spin_button);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_spin_button_get_wrap(GtkSpinButtonHandle spin_button);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_spin_button_set_adjustment(GtkSpinButtonHandle spin_button, GtkAdjustmentHandle adjustment);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_spin_button_set_digits(GtkSpinButtonHandle spin_button, uint digits);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_spin_button_set_increments(GtkSpinButtonHandle spin_button, double step, double page);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_spin_button_set_numeric(GtkSpinButtonHandle spin_button, bool numeric);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_spin_button_set_range(GtkSpinButtonHandle spin_button, double min, double max);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_spin_button_set_snap_to_ticks(GtkSpinButtonHandle spin_button, bool snap_to_ticks);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_spin_button_set_update_policy(GtkSpinButtonHandle spin_button, GtkSpinButtonUpdatePolicy policy);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_spin_button_set_value(GtkSpinButtonHandle spin_button, double value);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_spin_button_set_wrap(GtkSpinButtonHandle spin_button, bool wrap);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_spin_button_spin(GtkSpinButtonHandle spin_button, GtkSpinType direction, double increment);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_spin_button_update(GtkSpinButtonHandle spin_button);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_test_spin_button_click(GtkSpinButtonHandle spinner, uint button, bool upwards);

}
