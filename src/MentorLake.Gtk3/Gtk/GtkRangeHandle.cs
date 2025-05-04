namespace MentorLake.Gtk;

public class GtkRangeHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
}
public static class GtkRangeHandleSignalExtensions
{

	public static IObservable<GtkRangeHandleSignalStructs.AdjustBoundsSignal> Signal_AdjustBounds(this GtkRangeHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkRangeHandleSignalStructs.AdjustBoundsSignal> obs) =>
		{
			GtkRangeHandleSignalDelegates.adjust_bounds handler = ( MentorLake.Gtk.GtkRangeHandle self,  double value,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkRangeHandleSignalStructs.AdjustBoundsSignal()
				{
					Self = self, Value = value, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "adjust-bounds", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkRangeHandleSignalStructs.ChangeValueSignal> Signal_ChangeValue(this GtkRangeHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkRangeHandleSignalStructs.ChangeValueSignal> obs) =>
		{
			GtkRangeHandleSignalDelegates.change_value handler = ( MentorLake.Gtk.GtkRangeHandle self,  MentorLake.Gtk.GtkScrollType scroll,  double value,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkRangeHandleSignalStructs.ChangeValueSignal()
				{
					Self = self, Scroll = scroll, Value = value, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "change-value", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkRangeHandleSignalStructs.MoveSliderSignal> Signal_MoveSlider(this GtkRangeHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkRangeHandleSignalStructs.MoveSliderSignal> obs) =>
		{
			GtkRangeHandleSignalDelegates.move_slider handler = ( MentorLake.Gtk.GtkRangeHandle self,  MentorLake.Gtk.GtkScrollType step,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkRangeHandleSignalStructs.MoveSliderSignal()
				{
					Self = self, Step = step, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "move-slider", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkRangeHandleSignalStructs.ValueChangedSignal> Signal_ValueChanged(this GtkRangeHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkRangeHandleSignalStructs.ValueChangedSignal> obs) =>
		{
			GtkRangeHandleSignalDelegates.value_changed handler = ( MentorLake.Gtk.GtkRangeHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkRangeHandleSignalStructs.ValueChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "value-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkRangeHandleSignalStructs
{

public class AdjustBoundsSignal
{
	public MentorLake.Gtk.GtkRangeHandle Self;
	public double Value;
	public IntPtr UserData;
}

public class ChangeValueSignal
{
	public MentorLake.Gtk.GtkRangeHandle Self;
	public MentorLake.Gtk.GtkScrollType Scroll;
	public double Value;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class MoveSliderSignal
{
	public MentorLake.Gtk.GtkRangeHandle Self;
	public MentorLake.Gtk.GtkScrollType Step;
	public IntPtr UserData;
}

public class ValueChangedSignal
{
	public MentorLake.Gtk.GtkRangeHandle Self;
	public IntPtr UserData;
}
}

public static class GtkRangeHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void adjust_bounds([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRangeHandle>))] MentorLake.Gtk.GtkRangeHandle self, double value, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool change_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRangeHandle>))] MentorLake.Gtk.GtkRangeHandle self, MentorLake.Gtk.GtkScrollType scroll, double value, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void move_slider([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRangeHandle>))] MentorLake.Gtk.GtkRangeHandle self, MentorLake.Gtk.GtkScrollType step, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void value_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRangeHandle>))] MentorLake.Gtk.GtkRangeHandle self, IntPtr user_data);

}


public static class GtkRangeHandleExtensions
{
	public static MentorLake.Gtk.GtkAdjustmentHandle GetAdjustment(this MentorLake.Gtk.GtkRangeHandle range)
	{
		if (range.IsInvalid || range.IsClosed) throw new Exception("Invalid or closed handle (GtkRangeHandle)");
		return GtkRangeHandleExterns.gtk_range_get_adjustment(range);
	}

	public static double GetFillLevel(this MentorLake.Gtk.GtkRangeHandle range)
	{
		if (range.IsInvalid || range.IsClosed) throw new Exception("Invalid or closed handle (GtkRangeHandle)");
		return GtkRangeHandleExterns.gtk_range_get_fill_level(range);
	}

	public static bool GetFlippable(this MentorLake.Gtk.GtkRangeHandle range)
	{
		if (range.IsInvalid || range.IsClosed) throw new Exception("Invalid or closed handle (GtkRangeHandle)");
		return GtkRangeHandleExterns.gtk_range_get_flippable(range);
	}

	public static bool GetInverted(this MentorLake.Gtk.GtkRangeHandle range)
	{
		if (range.IsInvalid || range.IsClosed) throw new Exception("Invalid or closed handle (GtkRangeHandle)");
		return GtkRangeHandleExterns.gtk_range_get_inverted(range);
	}

	public static MentorLake.Gtk.GtkSensitivityType GetLowerStepperSensitivity(this MentorLake.Gtk.GtkRangeHandle range)
	{
		if (range.IsInvalid || range.IsClosed) throw new Exception("Invalid or closed handle (GtkRangeHandle)");
		return GtkRangeHandleExterns.gtk_range_get_lower_stepper_sensitivity(range);
	}

	public static int GetMinSliderSize(this MentorLake.Gtk.GtkRangeHandle range)
	{
		if (range.IsInvalid || range.IsClosed) throw new Exception("Invalid or closed handle (GtkRangeHandle)");
		return GtkRangeHandleExterns.gtk_range_get_min_slider_size(range);
	}

	public static T GetRangeRect<T>(this T range, out MentorLake.Gdk.GdkRectangle range_rect) where T : GtkRangeHandle
	{
		if (range.IsInvalid || range.IsClosed) throw new Exception("Invalid or closed handle (GtkRangeHandle)");
		GtkRangeHandleExterns.gtk_range_get_range_rect(range, out range_rect);
		return range;
	}

	public static bool GetRestrictToFillLevel(this MentorLake.Gtk.GtkRangeHandle range)
	{
		if (range.IsInvalid || range.IsClosed) throw new Exception("Invalid or closed handle (GtkRangeHandle)");
		return GtkRangeHandleExterns.gtk_range_get_restrict_to_fill_level(range);
	}

	public static int GetRoundDigits(this MentorLake.Gtk.GtkRangeHandle range)
	{
		if (range.IsInvalid || range.IsClosed) throw new Exception("Invalid or closed handle (GtkRangeHandle)");
		return GtkRangeHandleExterns.gtk_range_get_round_digits(range);
	}

	public static bool GetShowFillLevel(this MentorLake.Gtk.GtkRangeHandle range)
	{
		if (range.IsInvalid || range.IsClosed) throw new Exception("Invalid or closed handle (GtkRangeHandle)");
		return GtkRangeHandleExterns.gtk_range_get_show_fill_level(range);
	}

	public static T GetSliderRange<T>(this T range, out int slider_start, out int slider_end) where T : GtkRangeHandle
	{
		if (range.IsInvalid || range.IsClosed) throw new Exception("Invalid or closed handle (GtkRangeHandle)");
		GtkRangeHandleExterns.gtk_range_get_slider_range(range, out slider_start, out slider_end);
		return range;
	}

	public static bool GetSliderSizeFixed(this MentorLake.Gtk.GtkRangeHandle range)
	{
		if (range.IsInvalid || range.IsClosed) throw new Exception("Invalid or closed handle (GtkRangeHandle)");
		return GtkRangeHandleExterns.gtk_range_get_slider_size_fixed(range);
	}

	public static MentorLake.Gtk.GtkSensitivityType GetUpperStepperSensitivity(this MentorLake.Gtk.GtkRangeHandle range)
	{
		if (range.IsInvalid || range.IsClosed) throw new Exception("Invalid or closed handle (GtkRangeHandle)");
		return GtkRangeHandleExterns.gtk_range_get_upper_stepper_sensitivity(range);
	}

	public static double GetValue(this MentorLake.Gtk.GtkRangeHandle range)
	{
		if (range.IsInvalid || range.IsClosed) throw new Exception("Invalid or closed handle (GtkRangeHandle)");
		return GtkRangeHandleExterns.gtk_range_get_value(range);
	}

	public static T SetAdjustment<T>(this T range, MentorLake.Gtk.GtkAdjustmentHandle adjustment) where T : GtkRangeHandle
	{
		if (range.IsInvalid || range.IsClosed) throw new Exception("Invalid or closed handle (GtkRangeHandle)");
		GtkRangeHandleExterns.gtk_range_set_adjustment(range, adjustment);
		return range;
	}

	public static T SetFillLevel<T>(this T range, double fill_level) where T : GtkRangeHandle
	{
		if (range.IsInvalid || range.IsClosed) throw new Exception("Invalid or closed handle (GtkRangeHandle)");
		GtkRangeHandleExterns.gtk_range_set_fill_level(range, fill_level);
		return range;
	}

	public static T SetFlippable<T>(this T range, bool flippable) where T : GtkRangeHandle
	{
		if (range.IsInvalid || range.IsClosed) throw new Exception("Invalid or closed handle (GtkRangeHandle)");
		GtkRangeHandleExterns.gtk_range_set_flippable(range, flippable);
		return range;
	}

	public static T SetIncrements<T>(this T range, double step, double page) where T : GtkRangeHandle
	{
		if (range.IsInvalid || range.IsClosed) throw new Exception("Invalid or closed handle (GtkRangeHandle)");
		GtkRangeHandleExterns.gtk_range_set_increments(range, step, page);
		return range;
	}

	public static T SetInverted<T>(this T range, bool setting) where T : GtkRangeHandle
	{
		if (range.IsInvalid || range.IsClosed) throw new Exception("Invalid or closed handle (GtkRangeHandle)");
		GtkRangeHandleExterns.gtk_range_set_inverted(range, setting);
		return range;
	}

	public static T SetLowerStepperSensitivity<T>(this T range, MentorLake.Gtk.GtkSensitivityType sensitivity) where T : GtkRangeHandle
	{
		if (range.IsInvalid || range.IsClosed) throw new Exception("Invalid or closed handle (GtkRangeHandle)");
		GtkRangeHandleExterns.gtk_range_set_lower_stepper_sensitivity(range, sensitivity);
		return range;
	}

	public static T SetMinSliderSize<T>(this T range, int min_size) where T : GtkRangeHandle
	{
		if (range.IsInvalid || range.IsClosed) throw new Exception("Invalid or closed handle (GtkRangeHandle)");
		GtkRangeHandleExterns.gtk_range_set_min_slider_size(range, min_size);
		return range;
	}

	public static T SetRange<T>(this T range, double min, double max) where T : GtkRangeHandle
	{
		if (range.IsInvalid || range.IsClosed) throw new Exception("Invalid or closed handle (GtkRangeHandle)");
		GtkRangeHandleExterns.gtk_range_set_range(range, min, max);
		return range;
	}

	public static T SetRestrictToFillLevel<T>(this T range, bool restrict_to_fill_level) where T : GtkRangeHandle
	{
		if (range.IsInvalid || range.IsClosed) throw new Exception("Invalid or closed handle (GtkRangeHandle)");
		GtkRangeHandleExterns.gtk_range_set_restrict_to_fill_level(range, restrict_to_fill_level);
		return range;
	}

	public static T SetRoundDigits<T>(this T range, int round_digits) where T : GtkRangeHandle
	{
		if (range.IsInvalid || range.IsClosed) throw new Exception("Invalid or closed handle (GtkRangeHandle)");
		GtkRangeHandleExterns.gtk_range_set_round_digits(range, round_digits);
		return range;
	}

	public static T SetShowFillLevel<T>(this T range, bool show_fill_level) where T : GtkRangeHandle
	{
		if (range.IsInvalid || range.IsClosed) throw new Exception("Invalid or closed handle (GtkRangeHandle)");
		GtkRangeHandleExterns.gtk_range_set_show_fill_level(range, show_fill_level);
		return range;
	}

	public static T SetSliderSizeFixed<T>(this T range, bool size_fixed) where T : GtkRangeHandle
	{
		if (range.IsInvalid || range.IsClosed) throw new Exception("Invalid or closed handle (GtkRangeHandle)");
		GtkRangeHandleExterns.gtk_range_set_slider_size_fixed(range, size_fixed);
		return range;
	}

	public static T SetUpperStepperSensitivity<T>(this T range, MentorLake.Gtk.GtkSensitivityType sensitivity) where T : GtkRangeHandle
	{
		if (range.IsInvalid || range.IsClosed) throw new Exception("Invalid or closed handle (GtkRangeHandle)");
		GtkRangeHandleExterns.gtk_range_set_upper_stepper_sensitivity(range, sensitivity);
		return range;
	}

	public static T SetValue<T>(this T range, double value) where T : GtkRangeHandle
	{
		if (range.IsInvalid || range.IsClosed) throw new Exception("Invalid or closed handle (GtkRangeHandle)");
		GtkRangeHandleExterns.gtk_range_set_value(range, value);
		return range;
	}

}

internal class GtkRangeHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkAdjustmentHandle gtk_range_get_adjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRangeHandle>))] MentorLake.Gtk.GtkRangeHandle range);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_range_get_fill_level([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRangeHandle>))] MentorLake.Gtk.GtkRangeHandle range);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_range_get_flippable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRangeHandle>))] MentorLake.Gtk.GtkRangeHandle range);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_range_get_inverted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRangeHandle>))] MentorLake.Gtk.GtkRangeHandle range);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkSensitivityType gtk_range_get_lower_stepper_sensitivity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRangeHandle>))] MentorLake.Gtk.GtkRangeHandle range);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_range_get_min_slider_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRangeHandle>))] MentorLake.Gtk.GtkRangeHandle range);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_range_get_range_rect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRangeHandle>))] MentorLake.Gtk.GtkRangeHandle range, out MentorLake.Gdk.GdkRectangle range_rect);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_range_get_restrict_to_fill_level([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRangeHandle>))] MentorLake.Gtk.GtkRangeHandle range);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_range_get_round_digits([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRangeHandle>))] MentorLake.Gtk.GtkRangeHandle range);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_range_get_show_fill_level([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRangeHandle>))] MentorLake.Gtk.GtkRangeHandle range);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_range_get_slider_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRangeHandle>))] MentorLake.Gtk.GtkRangeHandle range, out int slider_start, out int slider_end);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_range_get_slider_size_fixed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRangeHandle>))] MentorLake.Gtk.GtkRangeHandle range);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkSensitivityType gtk_range_get_upper_stepper_sensitivity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRangeHandle>))] MentorLake.Gtk.GtkRangeHandle range);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_range_get_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRangeHandle>))] MentorLake.Gtk.GtkRangeHandle range);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_range_set_adjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRangeHandle>))] MentorLake.Gtk.GtkRangeHandle range, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_range_set_fill_level([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRangeHandle>))] MentorLake.Gtk.GtkRangeHandle range, double fill_level);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_range_set_flippable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRangeHandle>))] MentorLake.Gtk.GtkRangeHandle range, bool flippable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_range_set_increments([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRangeHandle>))] MentorLake.Gtk.GtkRangeHandle range, double step, double page);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_range_set_inverted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRangeHandle>))] MentorLake.Gtk.GtkRangeHandle range, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_range_set_lower_stepper_sensitivity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRangeHandle>))] MentorLake.Gtk.GtkRangeHandle range, MentorLake.Gtk.GtkSensitivityType sensitivity);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_range_set_min_slider_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRangeHandle>))] MentorLake.Gtk.GtkRangeHandle range, int min_size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_range_set_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRangeHandle>))] MentorLake.Gtk.GtkRangeHandle range, double min, double max);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_range_set_restrict_to_fill_level([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRangeHandle>))] MentorLake.Gtk.GtkRangeHandle range, bool restrict_to_fill_level);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_range_set_round_digits([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRangeHandle>))] MentorLake.Gtk.GtkRangeHandle range, int round_digits);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_range_set_show_fill_level([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRangeHandle>))] MentorLake.Gtk.GtkRangeHandle range, bool show_fill_level);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_range_set_slider_size_fixed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRangeHandle>))] MentorLake.Gtk.GtkRangeHandle range, bool size_fixed);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_range_set_upper_stepper_sensitivity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRangeHandle>))] MentorLake.Gtk.GtkRangeHandle range, MentorLake.Gtk.GtkSensitivityType sensitivity);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_range_set_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRangeHandle>))] MentorLake.Gtk.GtkRangeHandle range, double value);

}
