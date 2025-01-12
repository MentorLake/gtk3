namespace MentorLake.Gtk3.Gtk3;

public class GtkRangeHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
}

public static class GtkRangeSignalExtensions
{

	public static IObservable<GtkRangeSignalStructs.AdjustBoundsSignal> Signal_AdjustBounds(this GtkRangeHandle instance)
	{
		return Observable.Create((IObserver<GtkRangeSignalStructs.AdjustBoundsSignal> obs) =>
		{
			GtkRangeSignalDelegates.adjust_bounds handler = (GtkRangeHandle self, double value, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkRangeSignalStructs.AdjustBoundsSignal()
				{
					Self = self, Value = value, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "adjust_bounds", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkRangeSignalStructs.ChangeValueSignal> Signal_ChangeValue(this GtkRangeHandle instance)
	{
		return Observable.Create((IObserver<GtkRangeSignalStructs.ChangeValueSignal> obs) =>
		{
			GtkRangeSignalDelegates.change_value handler = (GtkRangeHandle self, ref GtkScrollType scroll, double value, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkRangeSignalStructs.ChangeValueSignal()
				{
					Self = self, Scroll = scroll, Value = value, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "change_value", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkRangeSignalStructs.MoveSliderSignal> Signal_MoveSlider(this GtkRangeHandle instance)
	{
		return Observable.Create((IObserver<GtkRangeSignalStructs.MoveSliderSignal> obs) =>
		{
			GtkRangeSignalDelegates.move_slider handler = (GtkRangeHandle self, ref GtkScrollType step, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkRangeSignalStructs.MoveSliderSignal()
				{
					Self = self, Step = step, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "move_slider", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkRangeSignalStructs.ValueChangedSignal> Signal_ValueChanged(this GtkRangeHandle instance)
	{
		return Observable.Create((IObserver<GtkRangeSignalStructs.ValueChangedSignal> obs) =>
		{
			GtkRangeSignalDelegates.value_changed handler = (GtkRangeHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkRangeSignalStructs.ValueChangedSignal()
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
}

public static class GtkRangeSignalStructs
{

public struct AdjustBoundsSignal
{
	public GtkRangeHandle Self;
	public double Value;
	public IntPtr UserData;
}

public struct ChangeValueSignal
{
	public GtkRangeHandle Self;
	public GtkScrollType Scroll;
	public double Value;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct MoveSliderSignal
{
	public GtkRangeHandle Self;
	public GtkScrollType Step;
	public IntPtr UserData;
}

public struct ValueChangedSignal
{
	public GtkRangeHandle Self;
	public IntPtr UserData;
}
}

public static class GtkRangeSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void adjust_bounds([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkRangeHandle>))] GtkRangeHandle self, double value, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool change_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkRangeHandle>))] GtkRangeHandle self, ref GtkScrollType scroll, double value, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void move_slider([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkRangeHandle>))] GtkRangeHandle self, ref GtkScrollType step, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void value_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkRangeHandle>))] GtkRangeHandle self, IntPtr user_data);

}


public static class GtkRangeHandleExtensions
{
	public static GtkAdjustmentHandle GetAdjustment(this GtkRangeHandle range)
	{
		return GtkRangeExterns.gtk_range_get_adjustment(range);
	}

	public static double GetFillLevel(this GtkRangeHandle range)
	{
		return GtkRangeExterns.gtk_range_get_fill_level(range);
	}

	public static bool GetFlippable(this GtkRangeHandle range)
	{
		return GtkRangeExterns.gtk_range_get_flippable(range);
	}

	public static bool GetInverted(this GtkRangeHandle range)
	{
		return GtkRangeExterns.gtk_range_get_inverted(range);
	}

	public static GtkSensitivityType GetLowerStepperSensitivity(this GtkRangeHandle range)
	{
		return GtkRangeExterns.gtk_range_get_lower_stepper_sensitivity(range);
	}

	public static int GetMinSliderSize(this GtkRangeHandle range)
	{
		return GtkRangeExterns.gtk_range_get_min_slider_size(range);
	}

	public static T GetRangeRect<T>(this T range, out GdkRectangle range_rect) where T : GtkRangeHandle
	{
		GtkRangeExterns.gtk_range_get_range_rect(range, out range_rect);
		return range;
	}

	public static bool GetRestrictToFillLevel(this GtkRangeHandle range)
	{
		return GtkRangeExterns.gtk_range_get_restrict_to_fill_level(range);
	}

	public static int GetRoundDigits(this GtkRangeHandle range)
	{
		return GtkRangeExterns.gtk_range_get_round_digits(range);
	}

	public static bool GetShowFillLevel(this GtkRangeHandle range)
	{
		return GtkRangeExterns.gtk_range_get_show_fill_level(range);
	}

	public static T GetSliderRange<T>(this T range, out int slider_start, out int slider_end) where T : GtkRangeHandle
	{
		GtkRangeExterns.gtk_range_get_slider_range(range, out slider_start, out slider_end);
		return range;
	}

	public static bool GetSliderSizeFixed(this GtkRangeHandle range)
	{
		return GtkRangeExterns.gtk_range_get_slider_size_fixed(range);
	}

	public static GtkSensitivityType GetUpperStepperSensitivity(this GtkRangeHandle range)
	{
		return GtkRangeExterns.gtk_range_get_upper_stepper_sensitivity(range);
	}

	public static double GetValue(this GtkRangeHandle range)
	{
		return GtkRangeExterns.gtk_range_get_value(range);
	}

	public static T SetAdjustment<T>(this T range, GtkAdjustmentHandle adjustment) where T : GtkRangeHandle
	{
		GtkRangeExterns.gtk_range_set_adjustment(range, adjustment);
		return range;
	}

	public static T SetFillLevel<T>(this T range, double fill_level) where T : GtkRangeHandle
	{
		GtkRangeExterns.gtk_range_set_fill_level(range, fill_level);
		return range;
	}

	public static T SetFlippable<T>(this T range, bool flippable) where T : GtkRangeHandle
	{
		GtkRangeExterns.gtk_range_set_flippable(range, flippable);
		return range;
	}

	public static T SetIncrements<T>(this T range, double step, double page) where T : GtkRangeHandle
	{
		GtkRangeExterns.gtk_range_set_increments(range, step, page);
		return range;
	}

	public static T SetInverted<T>(this T range, bool setting) where T : GtkRangeHandle
	{
		GtkRangeExterns.gtk_range_set_inverted(range, setting);
		return range;
	}

	public static T SetLowerStepperSensitivity<T>(this T range, GtkSensitivityType sensitivity) where T : GtkRangeHandle
	{
		GtkRangeExterns.gtk_range_set_lower_stepper_sensitivity(range, sensitivity);
		return range;
	}

	public static T SetMinSliderSize<T>(this T range, int min_size) where T : GtkRangeHandle
	{
		GtkRangeExterns.gtk_range_set_min_slider_size(range, min_size);
		return range;
	}

	public static T SetRange<T>(this T range, double min, double max) where T : GtkRangeHandle
	{
		GtkRangeExterns.gtk_range_set_range(range, min, max);
		return range;
	}

	public static T SetRestrictToFillLevel<T>(this T range, bool restrict_to_fill_level) where T : GtkRangeHandle
	{
		GtkRangeExterns.gtk_range_set_restrict_to_fill_level(range, restrict_to_fill_level);
		return range;
	}

	public static T SetRoundDigits<T>(this T range, int round_digits) where T : GtkRangeHandle
	{
		GtkRangeExterns.gtk_range_set_round_digits(range, round_digits);
		return range;
	}

	public static T SetShowFillLevel<T>(this T range, bool show_fill_level) where T : GtkRangeHandle
	{
		GtkRangeExterns.gtk_range_set_show_fill_level(range, show_fill_level);
		return range;
	}

	public static T SetSliderSizeFixed<T>(this T range, bool size_fixed) where T : GtkRangeHandle
	{
		GtkRangeExterns.gtk_range_set_slider_size_fixed(range, size_fixed);
		return range;
	}

	public static T SetUpperStepperSensitivity<T>(this T range, GtkSensitivityType sensitivity) where T : GtkRangeHandle
	{
		GtkRangeExterns.gtk_range_set_upper_stepper_sensitivity(range, sensitivity);
		return range;
	}

	public static T SetValue<T>(this T range, double value) where T : GtkRangeHandle
	{
		GtkRangeExterns.gtk_range_set_value(range, value);
		return range;
	}

}

internal class GtkRangeExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkAdjustmentHandle gtk_range_get_adjustment(GtkRangeHandle range);

	[DllImport(Libraries.Gtk3)]
	internal static extern double gtk_range_get_fill_level(GtkRangeHandle range);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_range_get_flippable(GtkRangeHandle range);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_range_get_inverted(GtkRangeHandle range);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkSensitivityType gtk_range_get_lower_stepper_sensitivity(GtkRangeHandle range);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_range_get_min_slider_size(GtkRangeHandle range);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_range_get_range_rect(GtkRangeHandle range, out GdkRectangle range_rect);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_range_get_restrict_to_fill_level(GtkRangeHandle range);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_range_get_round_digits(GtkRangeHandle range);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_range_get_show_fill_level(GtkRangeHandle range);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_range_get_slider_range(GtkRangeHandle range, out int slider_start, out int slider_end);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_range_get_slider_size_fixed(GtkRangeHandle range);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkSensitivityType gtk_range_get_upper_stepper_sensitivity(GtkRangeHandle range);

	[DllImport(Libraries.Gtk3)]
	internal static extern double gtk_range_get_value(GtkRangeHandle range);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_range_set_adjustment(GtkRangeHandle range, GtkAdjustmentHandle adjustment);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_range_set_fill_level(GtkRangeHandle range, double fill_level);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_range_set_flippable(GtkRangeHandle range, bool flippable);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_range_set_increments(GtkRangeHandle range, double step, double page);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_range_set_inverted(GtkRangeHandle range, bool setting);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_range_set_lower_stepper_sensitivity(GtkRangeHandle range, GtkSensitivityType sensitivity);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_range_set_min_slider_size(GtkRangeHandle range, int min_size);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_range_set_range(GtkRangeHandle range, double min, double max);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_range_set_restrict_to_fill_level(GtkRangeHandle range, bool restrict_to_fill_level);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_range_set_round_digits(GtkRangeHandle range, int round_digits);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_range_set_show_fill_level(GtkRangeHandle range, bool show_fill_level);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_range_set_slider_size_fixed(GtkRangeHandle range, bool size_fixed);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_range_set_upper_stepper_sensitivity(GtkRangeHandle range, GtkSensitivityType sensitivity);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_range_set_value(GtkRangeHandle range, double value);

}
