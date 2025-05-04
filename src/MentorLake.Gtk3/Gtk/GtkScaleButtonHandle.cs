namespace MentorLake.Gtk;

public class GtkScaleButtonHandle : GtkButtonHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static MentorLake.Gtk.GtkScaleButtonHandle New(MentorLake.Gtk.GtkIconSize size, double min, double max, double step, string[] icons)
	{
		return GtkScaleButtonHandleExterns.gtk_scale_button_new(size, min, max, step, icons);
	}

}
public static class GtkScaleButtonHandleSignalExtensions
{

	public static IObservable<GtkScaleButtonHandleSignalStructs.PopdownSignal> Signal_Popdown(this GtkScaleButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkScaleButtonHandleSignalStructs.PopdownSignal> obs) =>
		{
			GtkScaleButtonHandleSignalDelegates.popdown handler = ( MentorLake.Gtk.GtkScaleButtonHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkScaleButtonHandleSignalStructs.PopdownSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "popdown", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkScaleButtonHandleSignalStructs.PopupSignal> Signal_Popup(this GtkScaleButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkScaleButtonHandleSignalStructs.PopupSignal> obs) =>
		{
			GtkScaleButtonHandleSignalDelegates.popup handler = ( MentorLake.Gtk.GtkScaleButtonHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkScaleButtonHandleSignalStructs.PopupSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "popup", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkScaleButtonHandleSignalStructs.ValueChangedSignal> Signal_ValueChanged(this GtkScaleButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkScaleButtonHandleSignalStructs.ValueChangedSignal> obs) =>
		{
			GtkScaleButtonHandleSignalDelegates.value_changed handler = ( MentorLake.Gtk.GtkScaleButtonHandle self,  double value,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkScaleButtonHandleSignalStructs.ValueChangedSignal()
				{
					Self = self, Value = value, UserData = user_data
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

public static class GtkScaleButtonHandleSignalStructs
{

public class PopdownSignal
{
	public MentorLake.Gtk.GtkScaleButtonHandle Self;
	public IntPtr UserData;
}

public class PopupSignal
{
	public MentorLake.Gtk.GtkScaleButtonHandle Self;
	public IntPtr UserData;
}

public class ValueChangedSignal
{
	public MentorLake.Gtk.GtkScaleButtonHandle Self;
	public double Value;
	public IntPtr UserData;
}
}

public static class GtkScaleButtonHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void popdown([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleButtonHandle>))] MentorLake.Gtk.GtkScaleButtonHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void popup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleButtonHandle>))] MentorLake.Gtk.GtkScaleButtonHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void value_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleButtonHandle>))] MentorLake.Gtk.GtkScaleButtonHandle self, double value, IntPtr user_data);

}


public static class GtkScaleButtonHandleExtensions
{
	public static MentorLake.Gtk.GtkAdjustmentHandle GetAdjustment(this MentorLake.Gtk.GtkScaleButtonHandle button)
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkScaleButtonHandle)");
		return GtkScaleButtonHandleExterns.gtk_scale_button_get_adjustment(button);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetMinusButton(this MentorLake.Gtk.GtkScaleButtonHandle button)
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkScaleButtonHandle)");
		return GtkScaleButtonHandleExterns.gtk_scale_button_get_minus_button(button);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetPlusButton(this MentorLake.Gtk.GtkScaleButtonHandle button)
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkScaleButtonHandle)");
		return GtkScaleButtonHandleExterns.gtk_scale_button_get_plus_button(button);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetPopup(this MentorLake.Gtk.GtkScaleButtonHandle button)
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkScaleButtonHandle)");
		return GtkScaleButtonHandleExterns.gtk_scale_button_get_popup(button);
	}

	public static double GetValue(this MentorLake.Gtk.GtkScaleButtonHandle button)
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkScaleButtonHandle)");
		return GtkScaleButtonHandleExterns.gtk_scale_button_get_value(button);
	}

	public static T SetAdjustment<T>(this T button, MentorLake.Gtk.GtkAdjustmentHandle adjustment) where T : GtkScaleButtonHandle
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkScaleButtonHandle)");
		GtkScaleButtonHandleExterns.gtk_scale_button_set_adjustment(button, adjustment);
		return button;
	}

	public static T SetIcons<T>(this T button, string[] icons) where T : GtkScaleButtonHandle
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkScaleButtonHandle)");
		GtkScaleButtonHandleExterns.gtk_scale_button_set_icons(button, icons);
		return button;
	}

	public static T SetValue<T>(this T button, double value) where T : GtkScaleButtonHandle
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkScaleButtonHandle)");
		GtkScaleButtonHandleExterns.gtk_scale_button_set_value(button, value);
		return button;
	}

}

internal class GtkScaleButtonHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkScaleButtonHandle gtk_scale_button_new(MentorLake.Gtk.GtkIconSize size, double min, double max, double step, string[] icons);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkAdjustmentHandle gtk_scale_button_get_adjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleButtonHandle>))] MentorLake.Gtk.GtkScaleButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_scale_button_get_minus_button([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleButtonHandle>))] MentorLake.Gtk.GtkScaleButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_scale_button_get_plus_button([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleButtonHandle>))] MentorLake.Gtk.GtkScaleButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_scale_button_get_popup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleButtonHandle>))] MentorLake.Gtk.GtkScaleButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_scale_button_get_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleButtonHandle>))] MentorLake.Gtk.GtkScaleButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scale_button_set_adjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleButtonHandle>))] MentorLake.Gtk.GtkScaleButtonHandle button, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scale_button_set_icons([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleButtonHandle>))] MentorLake.Gtk.GtkScaleButtonHandle button, string[] icons);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scale_button_set_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleButtonHandle>))] MentorLake.Gtk.GtkScaleButtonHandle button, double value);

}
