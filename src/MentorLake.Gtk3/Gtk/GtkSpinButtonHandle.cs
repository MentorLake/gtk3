namespace MentorLake.Gtk;

public class GtkSpinButtonHandle : GtkEntryHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkCellEditableHandle, GtkEditableHandle, GtkOrientableHandle
{
	public static MentorLake.Gtk.GtkSpinButtonHandle New(MentorLake.Gtk.GtkAdjustmentHandle adjustment, double climb_rate, uint digits)
	{
		return GtkSpinButtonHandleExterns.gtk_spin_button_new(adjustment, climb_rate, digits);
	}

	public static MentorLake.Gtk.GtkSpinButtonHandle NewWithRange(double min, double max, double step)
	{
		return GtkSpinButtonHandleExterns.gtk_spin_button_new_with_range(min, max, step);
	}

}
public static class GtkSpinButtonHandleSignalExtensions
{

	public static IObservable<GtkSpinButtonHandleSignalStructs.ChangeValueSignal> Signal_ChangeValue(this GtkSpinButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkSpinButtonHandleSignalStructs.ChangeValueSignal> obs) =>
		{
			GtkSpinButtonHandleSignalDelegates.change_value handler = ( MentorLake.Gtk.GtkSpinButtonHandle self,  MentorLake.Gtk.GtkScrollType scroll,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSpinButtonHandleSignalStructs.ChangeValueSignal()
				{
					Self = self, Scroll = scroll, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
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

	public static IObservable<GtkSpinButtonHandleSignalStructs.InputSignal> Signal_Input(this GtkSpinButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkSpinButtonHandleSignalStructs.InputSignal> obs) =>
		{
			GtkSpinButtonHandleSignalDelegates.input handler = ( MentorLake.Gtk.GtkSpinButtonHandle self, out double new_value,  IntPtr user_data) =>
			{
				new_value = default;

				var signalStruct = new GtkSpinButtonHandleSignalStructs.InputSignal()
				{
					Self = self, NewValue = new_value, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "input", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkSpinButtonHandleSignalStructs.OutputSignal> Signal_Output(this GtkSpinButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkSpinButtonHandleSignalStructs.OutputSignal> obs) =>
		{
			GtkSpinButtonHandleSignalDelegates.output handler = ( MentorLake.Gtk.GtkSpinButtonHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSpinButtonHandleSignalStructs.OutputSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "output", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkSpinButtonHandleSignalStructs.ValueChangedSignal> Signal_ValueChanged(this GtkSpinButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkSpinButtonHandleSignalStructs.ValueChangedSignal> obs) =>
		{
			GtkSpinButtonHandleSignalDelegates.value_changed handler = ( MentorLake.Gtk.GtkSpinButtonHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSpinButtonHandleSignalStructs.ValueChangedSignal()
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

	public static IObservable<GtkSpinButtonHandleSignalStructs.WrappedSignal> Signal_Wrapped(this GtkSpinButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkSpinButtonHandleSignalStructs.WrappedSignal> obs) =>
		{
			GtkSpinButtonHandleSignalDelegates.wrapped handler = ( MentorLake.Gtk.GtkSpinButtonHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSpinButtonHandleSignalStructs.WrappedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "wrapped", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkSpinButtonHandleSignalStructs
{

public class ChangeValueSignal
{
	public MentorLake.Gtk.GtkSpinButtonHandle Self;
	public MentorLake.Gtk.GtkScrollType Scroll;
	public IntPtr UserData;
}

public class InputSignal
{
	public MentorLake.Gtk.GtkSpinButtonHandle Self;
	public double NewValue;
	public IntPtr UserData;
	public int ReturnValue;
}

public class OutputSignal
{
	public MentorLake.Gtk.GtkSpinButtonHandle Self;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class ValueChangedSignal
{
	public MentorLake.Gtk.GtkSpinButtonHandle Self;
	public IntPtr UserData;
}

public class WrappedSignal
{
	public MentorLake.Gtk.GtkSpinButtonHandle Self;
	public IntPtr UserData;
}
}

public static class GtkSpinButtonHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void change_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle self, MentorLake.Gtk.GtkScrollType scroll, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int input([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle self, out double new_value, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool output([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void value_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void wrapped([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle self, IntPtr user_data);

}


public static class GtkSpinButtonHandleExtensions
{
	public static T Configure<T>(this T spin_button, MentorLake.Gtk.GtkAdjustmentHandle adjustment, double climb_rate, uint digits) where T : GtkSpinButtonHandle
	{
		if (spin_button.IsInvalid || spin_button.IsClosed) throw new Exception("Invalid or closed handle (GtkSpinButtonHandle)");
		GtkSpinButtonHandleExterns.gtk_spin_button_configure(spin_button, adjustment, climb_rate, digits);
		return spin_button;
	}

	public static MentorLake.Gtk.GtkAdjustmentHandle GetAdjustment(this MentorLake.Gtk.GtkSpinButtonHandle spin_button)
	{
		if (spin_button.IsInvalid || spin_button.IsClosed) throw new Exception("Invalid or closed handle (GtkSpinButtonHandle)");
		return GtkSpinButtonHandleExterns.gtk_spin_button_get_adjustment(spin_button);
	}

	public static uint GetDigits(this MentorLake.Gtk.GtkSpinButtonHandle spin_button)
	{
		if (spin_button.IsInvalid || spin_button.IsClosed) throw new Exception("Invalid or closed handle (GtkSpinButtonHandle)");
		return GtkSpinButtonHandleExterns.gtk_spin_button_get_digits(spin_button);
	}

	public static T GetIncrements<T>(this T spin_button, out double step, out double page) where T : GtkSpinButtonHandle
	{
		if (spin_button.IsInvalid || spin_button.IsClosed) throw new Exception("Invalid or closed handle (GtkSpinButtonHandle)");
		GtkSpinButtonHandleExterns.gtk_spin_button_get_increments(spin_button, out step, out page);
		return spin_button;
	}

	public static bool GetNumeric(this MentorLake.Gtk.GtkSpinButtonHandle spin_button)
	{
		if (spin_button.IsInvalid || spin_button.IsClosed) throw new Exception("Invalid or closed handle (GtkSpinButtonHandle)");
		return GtkSpinButtonHandleExterns.gtk_spin_button_get_numeric(spin_button);
	}

	public static T GetRange<T>(this T spin_button, out double min, out double max) where T : GtkSpinButtonHandle
	{
		if (spin_button.IsInvalid || spin_button.IsClosed) throw new Exception("Invalid or closed handle (GtkSpinButtonHandle)");
		GtkSpinButtonHandleExterns.gtk_spin_button_get_range(spin_button, out min, out max);
		return spin_button;
	}

	public static bool GetSnapToTicks(this MentorLake.Gtk.GtkSpinButtonHandle spin_button)
	{
		if (spin_button.IsInvalid || spin_button.IsClosed) throw new Exception("Invalid or closed handle (GtkSpinButtonHandle)");
		return GtkSpinButtonHandleExterns.gtk_spin_button_get_snap_to_ticks(spin_button);
	}

	public static MentorLake.Gtk.GtkSpinButtonUpdatePolicy GetUpdatePolicy(this MentorLake.Gtk.GtkSpinButtonHandle spin_button)
	{
		if (spin_button.IsInvalid || spin_button.IsClosed) throw new Exception("Invalid or closed handle (GtkSpinButtonHandle)");
		return GtkSpinButtonHandleExterns.gtk_spin_button_get_update_policy(spin_button);
	}

	public static double GetValue(this MentorLake.Gtk.GtkSpinButtonHandle spin_button)
	{
		if (spin_button.IsInvalid || spin_button.IsClosed) throw new Exception("Invalid or closed handle (GtkSpinButtonHandle)");
		return GtkSpinButtonHandleExterns.gtk_spin_button_get_value(spin_button);
	}

	public static int GetValueAsInt(this MentorLake.Gtk.GtkSpinButtonHandle spin_button)
	{
		if (spin_button.IsInvalid || spin_button.IsClosed) throw new Exception("Invalid or closed handle (GtkSpinButtonHandle)");
		return GtkSpinButtonHandleExterns.gtk_spin_button_get_value_as_int(spin_button);
	}

	public static bool GetWrap(this MentorLake.Gtk.GtkSpinButtonHandle spin_button)
	{
		if (spin_button.IsInvalid || spin_button.IsClosed) throw new Exception("Invalid or closed handle (GtkSpinButtonHandle)");
		return GtkSpinButtonHandleExterns.gtk_spin_button_get_wrap(spin_button);
	}

	public static T SetAdjustment<T>(this T spin_button, MentorLake.Gtk.GtkAdjustmentHandle adjustment) where T : GtkSpinButtonHandle
	{
		if (spin_button.IsInvalid || spin_button.IsClosed) throw new Exception("Invalid or closed handle (GtkSpinButtonHandle)");
		GtkSpinButtonHandleExterns.gtk_spin_button_set_adjustment(spin_button, adjustment);
		return spin_button;
	}

	public static T SetDigits<T>(this T spin_button, uint digits) where T : GtkSpinButtonHandle
	{
		if (spin_button.IsInvalid || spin_button.IsClosed) throw new Exception("Invalid or closed handle (GtkSpinButtonHandle)");
		GtkSpinButtonHandleExterns.gtk_spin_button_set_digits(spin_button, digits);
		return spin_button;
	}

	public static T SetIncrements<T>(this T spin_button, double step, double page) where T : GtkSpinButtonHandle
	{
		if (spin_button.IsInvalid || spin_button.IsClosed) throw new Exception("Invalid or closed handle (GtkSpinButtonHandle)");
		GtkSpinButtonHandleExterns.gtk_spin_button_set_increments(spin_button, step, page);
		return spin_button;
	}

	public static T SetNumeric<T>(this T spin_button, bool numeric) where T : GtkSpinButtonHandle
	{
		if (spin_button.IsInvalid || spin_button.IsClosed) throw new Exception("Invalid or closed handle (GtkSpinButtonHandle)");
		GtkSpinButtonHandleExterns.gtk_spin_button_set_numeric(spin_button, numeric);
		return spin_button;
	}

	public static T SetRange<T>(this T spin_button, double min, double max) where T : GtkSpinButtonHandle
	{
		if (spin_button.IsInvalid || spin_button.IsClosed) throw new Exception("Invalid or closed handle (GtkSpinButtonHandle)");
		GtkSpinButtonHandleExterns.gtk_spin_button_set_range(spin_button, min, max);
		return spin_button;
	}

	public static T SetSnapToTicks<T>(this T spin_button, bool snap_to_ticks) where T : GtkSpinButtonHandle
	{
		if (spin_button.IsInvalid || spin_button.IsClosed) throw new Exception("Invalid or closed handle (GtkSpinButtonHandle)");
		GtkSpinButtonHandleExterns.gtk_spin_button_set_snap_to_ticks(spin_button, snap_to_ticks);
		return spin_button;
	}

	public static T SetUpdatePolicy<T>(this T spin_button, MentorLake.Gtk.GtkSpinButtonUpdatePolicy policy) where T : GtkSpinButtonHandle
	{
		if (spin_button.IsInvalid || spin_button.IsClosed) throw new Exception("Invalid or closed handle (GtkSpinButtonHandle)");
		GtkSpinButtonHandleExterns.gtk_spin_button_set_update_policy(spin_button, policy);
		return spin_button;
	}

	public static T SetValue<T>(this T spin_button, double value) where T : GtkSpinButtonHandle
	{
		if (spin_button.IsInvalid || spin_button.IsClosed) throw new Exception("Invalid or closed handle (GtkSpinButtonHandle)");
		GtkSpinButtonHandleExterns.gtk_spin_button_set_value(spin_button, value);
		return spin_button;
	}

	public static T SetWrap<T>(this T spin_button, bool wrap) where T : GtkSpinButtonHandle
	{
		if (spin_button.IsInvalid || spin_button.IsClosed) throw new Exception("Invalid or closed handle (GtkSpinButtonHandle)");
		GtkSpinButtonHandleExterns.gtk_spin_button_set_wrap(spin_button, wrap);
		return spin_button;
	}

	public static T Spin<T>(this T spin_button, MentorLake.Gtk.GtkSpinType direction, double increment) where T : GtkSpinButtonHandle
	{
		if (spin_button.IsInvalid || spin_button.IsClosed) throw new Exception("Invalid or closed handle (GtkSpinButtonHandle)");
		GtkSpinButtonHandleExterns.gtk_spin_button_spin(spin_button, direction, increment);
		return spin_button;
	}

	public static T Update<T>(this T spin_button) where T : GtkSpinButtonHandle
	{
		if (spin_button.IsInvalid || spin_button.IsClosed) throw new Exception("Invalid or closed handle (GtkSpinButtonHandle)");
		GtkSpinButtonHandleExterns.gtk_spin_button_update(spin_button);
		return spin_button;
	}

}

internal class GtkSpinButtonHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkSpinButtonHandle gtk_spin_button_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment, double climb_rate, uint digits);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkSpinButtonHandle gtk_spin_button_new_with_range(double min, double max, double step);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_spin_button_configure([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment, double climb_rate, uint digits);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkAdjustmentHandle gtk_spin_button_get_adjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_spin_button_get_digits([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_spin_button_get_increments([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button, out double step, out double page);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_spin_button_get_numeric([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_spin_button_get_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button, out double min, out double max);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_spin_button_get_snap_to_ticks([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkSpinButtonUpdatePolicy gtk_spin_button_get_update_policy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_spin_button_get_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_spin_button_get_value_as_int([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_spin_button_get_wrap([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_spin_button_set_adjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_spin_button_set_digits([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button, uint digits);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_spin_button_set_increments([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button, double step, double page);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_spin_button_set_numeric([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button, bool numeric);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_spin_button_set_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button, double min, double max);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_spin_button_set_snap_to_ticks([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button, bool snap_to_ticks);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_spin_button_set_update_policy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button, MentorLake.Gtk.GtkSpinButtonUpdatePolicy policy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_spin_button_set_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button, double value);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_spin_button_set_wrap([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button, bool wrap);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_spin_button_spin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button, MentorLake.Gtk.GtkSpinType direction, double increment);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_spin_button_update([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button);

}
