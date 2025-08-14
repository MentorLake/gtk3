namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkScaleButton provides a button which pops up a scale widget.
/// This kind of widget is commonly used for volume controls in multimedia
/// applications, and GTK+ provides a #GtkVolumeButton subclass that
/// is tailored for this use case.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// GtkScaleButton has a single CSS node with name button. To differentiate
/// it from a plain #GtkButton, it gets the .scale style class.
/// </para>
/// <para>
/// The popup widget that contains the scale has a .scale-popup style class.
/// </para>
/// </summary>

public class GtkScaleButtonHandle : GtkButtonHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle, GtkOrientableHandle
{
/// <summary>
/// <para>
/// Creates a #GtkScaleButton, with a range between @min and @max, with
/// a stepping of @step.
/// </para>
/// </summary>

/// <param name="size">
/// a stock icon size (#GtkIconSize)
/// </param>
/// <param name="min">
/// the minimum value of the scale (usually 0)
/// </param>
/// <param name="max">
/// the maximum value of the scale (usually 100)
/// </param>
/// <param name="step">
/// the stepping of value when a scroll-wheel event,
///        or up/down arrow event occurs (usually 2)
/// </param>
/// <param name="icons">
/// a %NULL-terminated
///         array of icon names, or %NULL if you want to set the list
///         later with gtk_scale_button_set_icons()
/// </param>
/// <return>
/// a new #GtkScaleButton
/// </return>

	public static MentorLake.Gtk.GtkScaleButtonHandle New(MentorLake.Gtk.GtkIconSize size, double min, double max, double step, string[] icons)
	{
		return GtkScaleButtonHandleExterns.gtk_scale_button_new(size, min, max, step, icons);
	}

}
public static class GtkScaleButtonHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::popdown signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to popdown the scale widget.
/// </para>
/// <para>
/// The default binding for this signal is Escape.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The ::popup signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to popup the scale widget.
/// </para>
/// <para>
/// The default bindings for this signal are Space, Enter and Return.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The ::value-changed signal is emitted when the value field has
/// changed.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// the new value
/// </para>
/// </summary>

	public double Value;

	public IntPtr UserData;
}
}

public static class GtkScaleButtonHandleSignalDelegates
{

/// <summary>
/// <para>
/// The ::popdown signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to popdown the scale widget.
/// </para>
/// <para>
/// The default binding for this signal is Escape.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void popdown([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleButtonHandle>))] MentorLake.Gtk.GtkScaleButtonHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::popup signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to popup the scale widget.
/// </para>
/// <para>
/// The default bindings for this signal are Space, Enter and Return.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void popup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleButtonHandle>))] MentorLake.Gtk.GtkScaleButtonHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::value-changed signal is emitted when the value field has
/// changed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="value">
/// the new value
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void value_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleButtonHandle>))] MentorLake.Gtk.GtkScaleButtonHandle self, double value, IntPtr user_data);

}


public static class GtkScaleButtonHandleExtensions
{
/// <summary>
/// <para>
/// Gets the #GtkAdjustment associated with the #GtkScaleButton’s scale.
/// See gtk_range_get_adjustment() for details.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkScaleButton
/// </param>
/// <return>
/// the adjustment associated with the scale
/// </return>

	public static MentorLake.Gtk.GtkAdjustmentHandle GetAdjustment(this MentorLake.Gtk.GtkScaleButtonHandle button)
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkScaleButtonHandle)");
		return GtkScaleButtonHandleExterns.gtk_scale_button_get_adjustment(button);
	}

/// <summary>
/// <para>
/// Retrieves the minus button of the #GtkScaleButton.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkScaleButton
/// </param>
/// <return>
/// the minus button of the #GtkScaleButton as a #GtkButton
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetMinusButton(this MentorLake.Gtk.GtkScaleButtonHandle button)
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkScaleButtonHandle)");
		return GtkScaleButtonHandleExterns.gtk_scale_button_get_minus_button(button);
	}

/// <summary>
/// <para>
/// Retrieves the plus button of the #GtkScaleButton.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkScaleButton
/// </param>
/// <return>
/// the plus button of the #GtkScaleButton as a #GtkButton
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetPlusButton(this MentorLake.Gtk.GtkScaleButtonHandle button)
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkScaleButtonHandle)");
		return GtkScaleButtonHandleExterns.gtk_scale_button_get_plus_button(button);
	}

/// <summary>
/// <para>
/// Retrieves the popup of the #GtkScaleButton.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkScaleButton
/// </param>
/// <return>
/// the popup of the #GtkScaleButton
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetPopup(this MentorLake.Gtk.GtkScaleButtonHandle button)
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkScaleButtonHandle)");
		return GtkScaleButtonHandleExterns.gtk_scale_button_get_popup(button);
	}

/// <summary>
/// <para>
/// Gets the current value of the scale button.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkScaleButton
/// </param>
/// <return>
/// current value of the scale button
/// </return>

	public static double GetValue(this MentorLake.Gtk.GtkScaleButtonHandle button)
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkScaleButtonHandle)");
		return GtkScaleButtonHandleExterns.gtk_scale_button_get_value(button);
	}

/// <summary>
/// <para>
/// Sets the #GtkAdjustment to be used as a model
/// for the #GtkScaleButton’s scale.
/// See gtk_range_set_adjustment() for details.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkScaleButton
/// </param>
/// <param name="adjustment">
/// a #GtkAdjustment
/// </param>

	public static T SetAdjustment<T>(this T button, MentorLake.Gtk.GtkAdjustmentHandle adjustment) where T : GtkScaleButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkScaleButtonHandle)");
		GtkScaleButtonHandleExterns.gtk_scale_button_set_adjustment(button, adjustment);
		return button;
	}

/// <summary>
/// <para>
/// Sets the icons to be used by the scale button.
/// For details, see the #GtkScaleButton:icons property.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkScaleButton
/// </param>
/// <param name="icons">
/// a %NULL-terminated array of icon names
/// </param>

	public static T SetIcons<T>(this T button, string[] icons) where T : GtkScaleButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkScaleButtonHandle)");
		GtkScaleButtonHandleExterns.gtk_scale_button_set_icons(button, icons);
		return button;
	}

/// <summary>
/// <para>
/// Sets the current value of the scale; if the value is outside
/// the minimum or maximum range values, it will be clamped to fit
/// inside them. The scale button emits the #GtkScaleButton::value-changed
/// signal if the value changes.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkScaleButton
/// </param>
/// <param name="value">
/// new value of the scale button
/// </param>

	public static T SetValue<T>(this T button, double value) where T : GtkScaleButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkScaleButtonHandle)");
		GtkScaleButtonHandleExterns.gtk_scale_button_set_value(button, value);
		return button;
	}

}

internal class GtkScaleButtonHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkScaleButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkScaleButtonHandle gtk_scale_button_new(MentorLake.Gtk.GtkIconSize size, double min, double max, double step, string[] icons);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))]
	internal static extern MentorLake.Gtk.GtkAdjustmentHandle gtk_scale_button_get_adjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleButtonHandle>))] MentorLake.Gtk.GtkScaleButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_scale_button_get_minus_button([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleButtonHandle>))] MentorLake.Gtk.GtkScaleButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_scale_button_get_plus_button([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleButtonHandle>))] MentorLake.Gtk.GtkScaleButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
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
