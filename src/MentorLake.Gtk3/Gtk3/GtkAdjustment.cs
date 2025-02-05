namespace MentorLake.Gtk3.Gtk3;

public class GtkAdjustmentHandle : GInitiallyUnownedHandle
{
	public static GtkAdjustmentHandle New(double value, double lower, double upper, double step_increment, double page_increment, double page_size)
	{
		return GtkAdjustmentExterns.gtk_adjustment_new(value, lower, upper, step_increment, page_increment, page_size);
	}

}

public static class GtkAdjustmentSignalExtensions
{

	public static IObservable<GtkAdjustmentSignalStructs.ChangedSignal> Signal_Changed(this GtkAdjustmentHandle instance)
	{
		return Observable.Create((IObserver<GtkAdjustmentSignalStructs.ChangedSignal> obs) =>
		{
			GtkAdjustmentSignalDelegates.changed handler = (GtkAdjustmentHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAdjustmentSignalStructs.ChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkAdjustmentSignalStructs.ValueChangedSignal> Signal_ValueChanged(this GtkAdjustmentHandle instance)
	{
		return Observable.Create((IObserver<GtkAdjustmentSignalStructs.ValueChangedSignal> obs) =>
		{
			GtkAdjustmentSignalDelegates.value_changed handler = (GtkAdjustmentHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAdjustmentSignalStructs.ValueChangedSignal()
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

public static class GtkAdjustmentSignalStructs
{

public struct ChangedSignal
{
	public GtkAdjustmentHandle Self;
	public IntPtr UserData;
}

public struct ValueChangedSignal
{
	public GtkAdjustmentHandle Self;
	public IntPtr UserData;
}
}

public static class GtkAdjustmentSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkAdjustmentHandle>))] GtkAdjustmentHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void value_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkAdjustmentHandle>))] GtkAdjustmentHandle self, IntPtr user_data);

}


public static class GtkAdjustmentHandleExtensions
{
	public static T Changed<T>(this T adjustment) where T : GtkAdjustmentHandle
	{
		GtkAdjustmentExterns.gtk_adjustment_changed(adjustment);
		return adjustment;
	}

	public static T ClampPage<T>(this T adjustment, double lower, double upper) where T : GtkAdjustmentHandle
	{
		GtkAdjustmentExterns.gtk_adjustment_clamp_page(adjustment, lower, upper);
		return adjustment;
	}

	public static T Configure<T>(this T adjustment, double value, double lower, double upper, double step_increment, double page_increment, double page_size) where T : GtkAdjustmentHandle
	{
		GtkAdjustmentExterns.gtk_adjustment_configure(adjustment, value, lower, upper, step_increment, page_increment, page_size);
		return adjustment;
	}

	public static double GetLower(this GtkAdjustmentHandle adjustment)
	{
		return GtkAdjustmentExterns.gtk_adjustment_get_lower(adjustment);
	}

	public static double GetMinimumIncrement(this GtkAdjustmentHandle adjustment)
	{
		return GtkAdjustmentExterns.gtk_adjustment_get_minimum_increment(adjustment);
	}

	public static double GetPageIncrement(this GtkAdjustmentHandle adjustment)
	{
		return GtkAdjustmentExterns.gtk_adjustment_get_page_increment(adjustment);
	}

	public static double GetPageSize(this GtkAdjustmentHandle adjustment)
	{
		return GtkAdjustmentExterns.gtk_adjustment_get_page_size(adjustment);
	}

	public static double GetStepIncrement(this GtkAdjustmentHandle adjustment)
	{
		return GtkAdjustmentExterns.gtk_adjustment_get_step_increment(adjustment);
	}

	public static double GetUpper(this GtkAdjustmentHandle adjustment)
	{
		return GtkAdjustmentExterns.gtk_adjustment_get_upper(adjustment);
	}

	public static double GetValue(this GtkAdjustmentHandle adjustment)
	{
		return GtkAdjustmentExterns.gtk_adjustment_get_value(adjustment);
	}

	public static T SetLower<T>(this T adjustment, double lower) where T : GtkAdjustmentHandle
	{
		GtkAdjustmentExterns.gtk_adjustment_set_lower(adjustment, lower);
		return adjustment;
	}

	public static T SetPageIncrement<T>(this T adjustment, double page_increment) where T : GtkAdjustmentHandle
	{
		GtkAdjustmentExterns.gtk_adjustment_set_page_increment(adjustment, page_increment);
		return adjustment;
	}

	public static T SetPageSize<T>(this T adjustment, double page_size) where T : GtkAdjustmentHandle
	{
		GtkAdjustmentExterns.gtk_adjustment_set_page_size(adjustment, page_size);
		return adjustment;
	}

	public static T SetStepIncrement<T>(this T adjustment, double step_increment) where T : GtkAdjustmentHandle
	{
		GtkAdjustmentExterns.gtk_adjustment_set_step_increment(adjustment, step_increment);
		return adjustment;
	}

	public static T SetUpper<T>(this T adjustment, double upper) where T : GtkAdjustmentHandle
	{
		GtkAdjustmentExterns.gtk_adjustment_set_upper(adjustment, upper);
		return adjustment;
	}

	public static T SetValue<T>(this T adjustment, double value) where T : GtkAdjustmentHandle
	{
		GtkAdjustmentExterns.gtk_adjustment_set_value(adjustment, value);
		return adjustment;
	}

	public static T ValueChanged<T>(this T adjustment) where T : GtkAdjustmentHandle
	{
		GtkAdjustmentExterns.gtk_adjustment_value_changed(adjustment);
		return adjustment;
	}

}

internal class GtkAdjustmentExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkAdjustmentHandle gtk_adjustment_new(double value, double lower, double upper, double step_increment, double page_increment, double page_size);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_adjustment_changed(GtkAdjustmentHandle adjustment);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_adjustment_clamp_page(GtkAdjustmentHandle adjustment, double lower, double upper);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_adjustment_configure(GtkAdjustmentHandle adjustment, double value, double lower, double upper, double step_increment, double page_increment, double page_size);

	[DllImport(Libraries.Gtk3)]
	internal static extern double gtk_adjustment_get_lower(GtkAdjustmentHandle adjustment);

	[DllImport(Libraries.Gtk3)]
	internal static extern double gtk_adjustment_get_minimum_increment(GtkAdjustmentHandle adjustment);

	[DllImport(Libraries.Gtk3)]
	internal static extern double gtk_adjustment_get_page_increment(GtkAdjustmentHandle adjustment);

	[DllImport(Libraries.Gtk3)]
	internal static extern double gtk_adjustment_get_page_size(GtkAdjustmentHandle adjustment);

	[DllImport(Libraries.Gtk3)]
	internal static extern double gtk_adjustment_get_step_increment(GtkAdjustmentHandle adjustment);

	[DllImport(Libraries.Gtk3)]
	internal static extern double gtk_adjustment_get_upper(GtkAdjustmentHandle adjustment);

	[DllImport(Libraries.Gtk3)]
	internal static extern double gtk_adjustment_get_value(GtkAdjustmentHandle adjustment);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_adjustment_set_lower(GtkAdjustmentHandle adjustment, double lower);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_adjustment_set_page_increment(GtkAdjustmentHandle adjustment, double page_increment);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_adjustment_set_page_size(GtkAdjustmentHandle adjustment, double page_size);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_adjustment_set_step_increment(GtkAdjustmentHandle adjustment, double step_increment);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_adjustment_set_upper(GtkAdjustmentHandle adjustment, double upper);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_adjustment_set_value(GtkAdjustmentHandle adjustment, double value);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_adjustment_value_changed(GtkAdjustmentHandle adjustment);

}
