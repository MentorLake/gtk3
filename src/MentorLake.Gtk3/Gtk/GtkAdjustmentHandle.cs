namespace MentorLake.Gtk;

public class GtkAdjustmentHandle : GInitiallyUnownedHandle
{
	public static MentorLake.Gtk.GtkAdjustmentHandle New(double value, double lower, double upper, double step_increment, double page_increment, double page_size)
	{
		return GtkAdjustmentHandleExterns.gtk_adjustment_new(value, lower, upper, step_increment, page_increment, page_size);
	}

}
public static class GtkAdjustmentHandleSignalExtensions
{

	public static IObservable<GtkAdjustmentHandleSignalStructs.ChangedSignal> Signal_Changed(this GtkAdjustmentHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkAdjustmentHandleSignalStructs.ChangedSignal> obs) =>
		{
			GtkAdjustmentHandleSignalDelegates.changed handler = ( MentorLake.Gtk.GtkAdjustmentHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAdjustmentHandleSignalStructs.ChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkAdjustmentHandleSignalStructs.ValueChangedSignal> Signal_ValueChanged(this GtkAdjustmentHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkAdjustmentHandleSignalStructs.ValueChangedSignal> obs) =>
		{
			GtkAdjustmentHandleSignalDelegates.value_changed handler = ( MentorLake.Gtk.GtkAdjustmentHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAdjustmentHandleSignalStructs.ValueChangedSignal()
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

public static class GtkAdjustmentHandleSignalStructs
{

public class ChangedSignal
{
	public MentorLake.Gtk.GtkAdjustmentHandle Self;
	public IntPtr UserData;
}

public class ValueChangedSignal
{
	public MentorLake.Gtk.GtkAdjustmentHandle Self;
	public IntPtr UserData;
}
}

public static class GtkAdjustmentHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void value_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle self, IntPtr user_data);

}


public static class GtkAdjustmentHandleExtensions
{
	public static T Changed<T>(this T adjustment) where T : GtkAdjustmentHandle
	{
		if (adjustment.IsInvalid || adjustment.IsClosed) throw new Exception("Invalid or closed handle (GtkAdjustmentHandle)");
		GtkAdjustmentHandleExterns.gtk_adjustment_changed(adjustment);
		return adjustment;
	}

	public static T ClampPage<T>(this T adjustment, double lower, double upper) where T : GtkAdjustmentHandle
	{
		if (adjustment.IsInvalid || adjustment.IsClosed) throw new Exception("Invalid or closed handle (GtkAdjustmentHandle)");
		GtkAdjustmentHandleExterns.gtk_adjustment_clamp_page(adjustment, lower, upper);
		return adjustment;
	}

	public static T Configure<T>(this T adjustment, double value, double lower, double upper, double step_increment, double page_increment, double page_size) where T : GtkAdjustmentHandle
	{
		if (adjustment.IsInvalid || adjustment.IsClosed) throw new Exception("Invalid or closed handle (GtkAdjustmentHandle)");
		GtkAdjustmentHandleExterns.gtk_adjustment_configure(adjustment, value, lower, upper, step_increment, page_increment, page_size);
		return adjustment;
	}

	public static double GetLower(this MentorLake.Gtk.GtkAdjustmentHandle adjustment)
	{
		if (adjustment.IsInvalid || adjustment.IsClosed) throw new Exception("Invalid or closed handle (GtkAdjustmentHandle)");
		return GtkAdjustmentHandleExterns.gtk_adjustment_get_lower(adjustment);
	}

	public static double GetMinimumIncrement(this MentorLake.Gtk.GtkAdjustmentHandle adjustment)
	{
		if (adjustment.IsInvalid || adjustment.IsClosed) throw new Exception("Invalid or closed handle (GtkAdjustmentHandle)");
		return GtkAdjustmentHandleExterns.gtk_adjustment_get_minimum_increment(adjustment);
	}

	public static double GetPageIncrement(this MentorLake.Gtk.GtkAdjustmentHandle adjustment)
	{
		if (adjustment.IsInvalid || adjustment.IsClosed) throw new Exception("Invalid or closed handle (GtkAdjustmentHandle)");
		return GtkAdjustmentHandleExterns.gtk_adjustment_get_page_increment(adjustment);
	}

	public static double GetPageSize(this MentorLake.Gtk.GtkAdjustmentHandle adjustment)
	{
		if (adjustment.IsInvalid || adjustment.IsClosed) throw new Exception("Invalid or closed handle (GtkAdjustmentHandle)");
		return GtkAdjustmentHandleExterns.gtk_adjustment_get_page_size(adjustment);
	}

	public static double GetStepIncrement(this MentorLake.Gtk.GtkAdjustmentHandle adjustment)
	{
		if (adjustment.IsInvalid || adjustment.IsClosed) throw new Exception("Invalid or closed handle (GtkAdjustmentHandle)");
		return GtkAdjustmentHandleExterns.gtk_adjustment_get_step_increment(adjustment);
	}

	public static double GetUpper(this MentorLake.Gtk.GtkAdjustmentHandle adjustment)
	{
		if (adjustment.IsInvalid || adjustment.IsClosed) throw new Exception("Invalid or closed handle (GtkAdjustmentHandle)");
		return GtkAdjustmentHandleExterns.gtk_adjustment_get_upper(adjustment);
	}

	public static double GetValue(this MentorLake.Gtk.GtkAdjustmentHandle adjustment)
	{
		if (adjustment.IsInvalid || adjustment.IsClosed) throw new Exception("Invalid or closed handle (GtkAdjustmentHandle)");
		return GtkAdjustmentHandleExterns.gtk_adjustment_get_value(adjustment);
	}

	public static T SetLower<T>(this T adjustment, double lower) where T : GtkAdjustmentHandle
	{
		if (adjustment.IsInvalid || adjustment.IsClosed) throw new Exception("Invalid or closed handle (GtkAdjustmentHandle)");
		GtkAdjustmentHandleExterns.gtk_adjustment_set_lower(adjustment, lower);
		return adjustment;
	}

	public static T SetPageIncrement<T>(this T adjustment, double page_increment) where T : GtkAdjustmentHandle
	{
		if (adjustment.IsInvalid || adjustment.IsClosed) throw new Exception("Invalid or closed handle (GtkAdjustmentHandle)");
		GtkAdjustmentHandleExterns.gtk_adjustment_set_page_increment(adjustment, page_increment);
		return adjustment;
	}

	public static T SetPageSize<T>(this T adjustment, double page_size) where T : GtkAdjustmentHandle
	{
		if (adjustment.IsInvalid || adjustment.IsClosed) throw new Exception("Invalid or closed handle (GtkAdjustmentHandle)");
		GtkAdjustmentHandleExterns.gtk_adjustment_set_page_size(adjustment, page_size);
		return adjustment;
	}

	public static T SetStepIncrement<T>(this T adjustment, double step_increment) where T : GtkAdjustmentHandle
	{
		if (adjustment.IsInvalid || adjustment.IsClosed) throw new Exception("Invalid or closed handle (GtkAdjustmentHandle)");
		GtkAdjustmentHandleExterns.gtk_adjustment_set_step_increment(adjustment, step_increment);
		return adjustment;
	}

	public static T SetUpper<T>(this T adjustment, double upper) where T : GtkAdjustmentHandle
	{
		if (adjustment.IsInvalid || adjustment.IsClosed) throw new Exception("Invalid or closed handle (GtkAdjustmentHandle)");
		GtkAdjustmentHandleExterns.gtk_adjustment_set_upper(adjustment, upper);
		return adjustment;
	}

	public static T SetValue<T>(this T adjustment, double value) where T : GtkAdjustmentHandle
	{
		if (adjustment.IsInvalid || adjustment.IsClosed) throw new Exception("Invalid or closed handle (GtkAdjustmentHandle)");
		GtkAdjustmentHandleExterns.gtk_adjustment_set_value(adjustment, value);
		return adjustment;
	}

	public static T ValueChanged<T>(this T adjustment) where T : GtkAdjustmentHandle
	{
		if (adjustment.IsInvalid || adjustment.IsClosed) throw new Exception("Invalid or closed handle (GtkAdjustmentHandle)");
		GtkAdjustmentHandleExterns.gtk_adjustment_value_changed(adjustment);
		return adjustment;
	}

}

internal class GtkAdjustmentHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkAdjustmentHandle gtk_adjustment_new(double value, double lower, double upper, double step_increment, double page_increment, double page_size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_adjustment_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_adjustment_clamp_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment, double lower, double upper);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_adjustment_configure([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment, double value, double lower, double upper, double step_increment, double page_increment, double page_size);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_adjustment_get_lower([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_adjustment_get_minimum_increment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_adjustment_get_page_increment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_adjustment_get_page_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_adjustment_get_step_increment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_adjustment_get_upper([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_adjustment_get_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_adjustment_set_lower([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment, double lower);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_adjustment_set_page_increment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment, double page_increment);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_adjustment_set_page_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment, double page_size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_adjustment_set_step_increment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment, double step_increment);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_adjustment_set_upper([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment, double upper);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_adjustment_set_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment, double value);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_adjustment_value_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

}
