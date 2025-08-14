namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkAdjustment object represents a value which has an associated lower
/// and upper bound, together with step and page increments, and a page size.
/// It is used within several GTK+ widgets, including #GtkSpinButton, #GtkViewport,
/// and #GtkRange (which is a base class for #GtkScrollbar and #GtkScale).
/// </para>
/// <para>
/// The #GtkAdjustment object does not update the value itself. Instead
/// it is left up to the owner of the #GtkAdjustment to control the value.
/// </para>
/// </summary>

public class GtkAdjustmentHandle : GInitiallyUnownedHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkAdjustment.
/// </para>
/// </summary>

/// <param name="value">
/// the initial value
/// </param>
/// <param name="lower">
/// the minimum value
/// </param>
/// <param name="upper">
/// the maximum value
/// </param>
/// <param name="step_increment">
/// the step increment
/// </param>
/// <param name="page_increment">
/// the page increment
/// </param>
/// <param name="page_size">
/// the page size
/// </param>
/// <return>
/// a new #GtkAdjustment
/// </return>

	public static MentorLake.Gtk.GtkAdjustmentHandle New(double value, double lower, double upper, double step_increment, double page_increment, double page_size)
	{
		return GtkAdjustmentHandleExterns.gtk_adjustment_new(value, lower, upper, step_increment, page_increment, page_size);
	}

}
public static class GtkAdjustmentHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when one or more of the #GtkAdjustment properties have been
/// changed, other than the #GtkAdjustment:value property.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Emitted when the #GtkAdjustment:value property has been changed.
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// Emitted when one or more of the #GtkAdjustment properties have been
/// changed, other than the #GtkAdjustment:value property.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when the #GtkAdjustment:value property has been changed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void value_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle self, IntPtr user_data);

}


public static class GtkAdjustmentHandleExtensions
{
/// <summary>
/// <para>
/// Emits a #GtkAdjustment::changed signal from the #GtkAdjustment.
/// This is typically called by the owner of the #GtkAdjustment after it has
/// changed any of the #GtkAdjustment properties other than the value.
/// </para>
/// </summary>

/// <param name="adjustment">
/// a #GtkAdjustment
/// </param>

	public static T Changed<T>(this T adjustment) where T : GtkAdjustmentHandle
	{
		if (adjustment.IsInvalid) throw new Exception("Invalid handle (GtkAdjustmentHandle)");
		GtkAdjustmentHandleExterns.gtk_adjustment_changed(adjustment);
		return adjustment;
	}

/// <summary>
/// <para>
/// Updates the #GtkAdjustment:value property to ensure that the range
/// between @lower and @upper is in the current page (i.e. between
/// #GtkAdjustment:value and #GtkAdjustment:value + #GtkAdjustment:page-size).
/// If the range is larger than the page size, then only the start of it will
/// be in the current page.
/// </para>
/// <para>
/// A #GtkAdjustment::value-changed signal will be emitted if the value is changed.
/// </para>
/// </summary>

/// <param name="adjustment">
/// a #GtkAdjustment
/// </param>
/// <param name="lower">
/// the lower value
/// </param>
/// <param name="upper">
/// the upper value
/// </param>

	public static T ClampPage<T>(this T adjustment, double lower, double upper) where T : GtkAdjustmentHandle
	{
		if (adjustment.IsInvalid) throw new Exception("Invalid handle (GtkAdjustmentHandle)");
		GtkAdjustmentHandleExterns.gtk_adjustment_clamp_page(adjustment, lower, upper);
		return adjustment;
	}

/// <summary>
/// <para>
/// Sets all properties of the adjustment at once.
/// </para>
/// <para>
/// Use this function to avoid multiple emissions of the
/// #GtkAdjustment::changed signal. See gtk_adjustment_set_lower()
/// for an alternative way of compressing multiple emissions of
/// #GtkAdjustment::changed into one.
/// </para>
/// </summary>

/// <param name="adjustment">
/// a #GtkAdjustment
/// </param>
/// <param name="value">
/// the new value
/// </param>
/// <param name="lower">
/// the new minimum value
/// </param>
/// <param name="upper">
/// the new maximum value
/// </param>
/// <param name="step_increment">
/// the new step increment
/// </param>
/// <param name="page_increment">
/// the new page increment
/// </param>
/// <param name="page_size">
/// the new page size
/// </param>

	public static T Configure<T>(this T adjustment, double value, double lower, double upper, double step_increment, double page_increment, double page_size) where T : GtkAdjustmentHandle
	{
		if (adjustment.IsInvalid) throw new Exception("Invalid handle (GtkAdjustmentHandle)");
		GtkAdjustmentHandleExterns.gtk_adjustment_configure(adjustment, value, lower, upper, step_increment, page_increment, page_size);
		return adjustment;
	}

/// <summary>
/// <para>
/// Retrieves the minimum value of the adjustment.
/// </para>
/// </summary>

/// <param name="adjustment">
/// a #GtkAdjustment
/// </param>
/// <return>
/// The current minimum value of the adjustment
/// </return>

	public static double GetLower(this MentorLake.Gtk.GtkAdjustmentHandle adjustment)
	{
		if (adjustment.IsInvalid) throw new Exception("Invalid handle (GtkAdjustmentHandle)");
		return GtkAdjustmentHandleExterns.gtk_adjustment_get_lower(adjustment);
	}

/// <summary>
/// <para>
/// Gets the smaller of step increment and page increment.
/// </para>
/// </summary>

/// <param name="adjustment">
/// a #GtkAdjustment
/// </param>
/// <return>
/// the minimum increment of @adjustment
/// </return>

	public static double GetMinimumIncrement(this MentorLake.Gtk.GtkAdjustmentHandle adjustment)
	{
		if (adjustment.IsInvalid) throw new Exception("Invalid handle (GtkAdjustmentHandle)");
		return GtkAdjustmentHandleExterns.gtk_adjustment_get_minimum_increment(adjustment);
	}

/// <summary>
/// <para>
/// Retrieves the page increment of the adjustment.
/// </para>
/// </summary>

/// <param name="adjustment">
/// a #GtkAdjustment
/// </param>
/// <return>
/// The current page increment of the adjustment
/// </return>

	public static double GetPageIncrement(this MentorLake.Gtk.GtkAdjustmentHandle adjustment)
	{
		if (adjustment.IsInvalid) throw new Exception("Invalid handle (GtkAdjustmentHandle)");
		return GtkAdjustmentHandleExterns.gtk_adjustment_get_page_increment(adjustment);
	}

/// <summary>
/// <para>
/// Retrieves the page size of the adjustment.
/// </para>
/// </summary>

/// <param name="adjustment">
/// a #GtkAdjustment
/// </param>
/// <return>
/// The current page size of the adjustment
/// </return>

	public static double GetPageSize(this MentorLake.Gtk.GtkAdjustmentHandle adjustment)
	{
		if (adjustment.IsInvalid) throw new Exception("Invalid handle (GtkAdjustmentHandle)");
		return GtkAdjustmentHandleExterns.gtk_adjustment_get_page_size(adjustment);
	}

/// <summary>
/// <para>
/// Retrieves the step increment of the adjustment.
/// </para>
/// </summary>

/// <param name="adjustment">
/// a #GtkAdjustment
/// </param>
/// <return>
/// The current step increment of the adjustment.
/// </return>

	public static double GetStepIncrement(this MentorLake.Gtk.GtkAdjustmentHandle adjustment)
	{
		if (adjustment.IsInvalid) throw new Exception("Invalid handle (GtkAdjustmentHandle)");
		return GtkAdjustmentHandleExterns.gtk_adjustment_get_step_increment(adjustment);
	}

/// <summary>
/// <para>
/// Retrieves the maximum value of the adjustment.
/// </para>
/// </summary>

/// <param name="adjustment">
/// a #GtkAdjustment
/// </param>
/// <return>
/// The current maximum value of the adjustment
/// </return>

	public static double GetUpper(this MentorLake.Gtk.GtkAdjustmentHandle adjustment)
	{
		if (adjustment.IsInvalid) throw new Exception("Invalid handle (GtkAdjustmentHandle)");
		return GtkAdjustmentHandleExterns.gtk_adjustment_get_upper(adjustment);
	}

/// <summary>
/// <para>
/// Gets the current value of the adjustment.
/// See gtk_adjustment_set_value().
/// </para>
/// </summary>

/// <param name="adjustment">
/// a #GtkAdjustment
/// </param>
/// <return>
/// The current value of the adjustment
/// </return>

	public static double GetValue(this MentorLake.Gtk.GtkAdjustmentHandle adjustment)
	{
		if (adjustment.IsInvalid) throw new Exception("Invalid handle (GtkAdjustmentHandle)");
		return GtkAdjustmentHandleExterns.gtk_adjustment_get_value(adjustment);
	}

/// <summary>
/// <para>
/// Sets the minimum value of the adjustment.
/// </para>
/// <para>
/// When setting multiple adjustment properties via their individual
/// setters, multiple #GtkAdjustment::changed signals will be emitted.
/// However, since the emission of the #GtkAdjustment::changed signal
/// is tied to the emission of the #GObject::notify signals of the changed
/// properties, it’s possible to compress the #GtkAdjustment::changed
/// signals into one by calling g_object_freeze_notify() and
/// g_object_thaw_notify() around the calls to the individual setters.
/// </para>
/// <para>
/// Alternatively, using a single g_object_set() for all the properties
/// to change, or using gtk_adjustment_configure() has the same effect
/// of compressing #GtkAdjustment::changed emissions.
/// </para>
/// </summary>

/// <param name="adjustment">
/// a #GtkAdjustment
/// </param>
/// <param name="lower">
/// the new minimum value
/// </param>

	public static T SetLower<T>(this T adjustment, double lower) where T : GtkAdjustmentHandle
	{
		if (adjustment.IsInvalid) throw new Exception("Invalid handle (GtkAdjustmentHandle)");
		GtkAdjustmentHandleExterns.gtk_adjustment_set_lower(adjustment, lower);
		return adjustment;
	}

/// <summary>
/// <para>
/// Sets the page increment of the adjustment.
/// </para>
/// <para>
/// See gtk_adjustment_set_lower() about how to compress multiple
/// emissions of the #GtkAdjustment::changed signal when setting
/// multiple adjustment properties.
/// </para>
/// </summary>

/// <param name="adjustment">
/// a #GtkAdjustment
/// </param>
/// <param name="page_increment">
/// the new page increment
/// </param>

	public static T SetPageIncrement<T>(this T adjustment, double page_increment) where T : GtkAdjustmentHandle
	{
		if (adjustment.IsInvalid) throw new Exception("Invalid handle (GtkAdjustmentHandle)");
		GtkAdjustmentHandleExterns.gtk_adjustment_set_page_increment(adjustment, page_increment);
		return adjustment;
	}

/// <summary>
/// <para>
/// Sets the page size of the adjustment.
/// </para>
/// <para>
/// See gtk_adjustment_set_lower() about how to compress multiple
/// emissions of the GtkAdjustment::changed signal when setting
/// multiple adjustment properties.
/// </para>
/// </summary>

/// <param name="adjustment">
/// a #GtkAdjustment
/// </param>
/// <param name="page_size">
/// the new page size
/// </param>

	public static T SetPageSize<T>(this T adjustment, double page_size) where T : GtkAdjustmentHandle
	{
		if (adjustment.IsInvalid) throw new Exception("Invalid handle (GtkAdjustmentHandle)");
		GtkAdjustmentHandleExterns.gtk_adjustment_set_page_size(adjustment, page_size);
		return adjustment;
	}

/// <summary>
/// <para>
/// Sets the step increment of the adjustment.
/// </para>
/// <para>
/// See gtk_adjustment_set_lower() about how to compress multiple
/// emissions of the #GtkAdjustment::changed signal when setting
/// multiple adjustment properties.
/// </para>
/// </summary>

/// <param name="adjustment">
/// a #GtkAdjustment
/// </param>
/// <param name="step_increment">
/// the new step increment
/// </param>

	public static T SetStepIncrement<T>(this T adjustment, double step_increment) where T : GtkAdjustmentHandle
	{
		if (adjustment.IsInvalid) throw new Exception("Invalid handle (GtkAdjustmentHandle)");
		GtkAdjustmentHandleExterns.gtk_adjustment_set_step_increment(adjustment, step_increment);
		return adjustment;
	}

/// <summary>
/// <para>
/// Sets the maximum value of the adjustment.
/// </para>
/// <para>
/// Note that values will be restricted by `upper - page-size`
/// if the page-size property is nonzero.
/// </para>
/// <para>
/// See gtk_adjustment_set_lower() about how to compress multiple
/// emissions of the #GtkAdjustment::changed signal when setting
/// multiple adjustment properties.
/// </para>
/// </summary>

/// <param name="adjustment">
/// a #GtkAdjustment
/// </param>
/// <param name="upper">
/// the new maximum value
/// </param>

	public static T SetUpper<T>(this T adjustment, double upper) where T : GtkAdjustmentHandle
	{
		if (adjustment.IsInvalid) throw new Exception("Invalid handle (GtkAdjustmentHandle)");
		GtkAdjustmentHandleExterns.gtk_adjustment_set_upper(adjustment, upper);
		return adjustment;
	}

/// <summary>
/// <para>
/// Sets the #GtkAdjustment value. The value is clamped to lie between
/// #GtkAdjustment:lower and #GtkAdjustment:upper.
/// </para>
/// <para>
/// Note that for adjustments which are used in a #GtkScrollbar, the
/// effective range of allowed values goes from #GtkAdjustment:lower to
/// #GtkAdjustment:upper - #GtkAdjustment:page-size.
/// </para>
/// </summary>

/// <param name="adjustment">
/// a #GtkAdjustment
/// </param>
/// <param name="value">
/// the new value
/// </param>

	public static T SetValue<T>(this T adjustment, double value) where T : GtkAdjustmentHandle
	{
		if (adjustment.IsInvalid) throw new Exception("Invalid handle (GtkAdjustmentHandle)");
		GtkAdjustmentHandleExterns.gtk_adjustment_set_value(adjustment, value);
		return adjustment;
	}

/// <summary>
/// <para>
/// Emits a #GtkAdjustment::value-changed signal from the #GtkAdjustment.
/// This is typically called by the owner of the #GtkAdjustment after it has
/// changed the #GtkAdjustment:value property.
/// </para>
/// </summary>

/// <param name="adjustment">
/// a #GtkAdjustment
/// </param>

	public static T ValueChanged<T>(this T adjustment) where T : GtkAdjustmentHandle
	{
		if (adjustment.IsInvalid) throw new Exception("Invalid handle (GtkAdjustmentHandle)");
		GtkAdjustmentHandleExterns.gtk_adjustment_value_changed(adjustment);
		return adjustment;
	}

}

internal class GtkAdjustmentHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))]
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
