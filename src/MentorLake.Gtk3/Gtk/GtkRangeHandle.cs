namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkRange is the common base class for widgets which visualize an
/// adjustment, e.g #GtkScale or #GtkScrollbar.
/// </para>
/// <para>
/// Apart from signals for monitoring the parameters of the adjustment,
/// #GtkRange provides properties and methods for influencing the sensitivity
/// of the “steppers”. It also provides properties and methods for setting a
/// “fill level” on range widgets. See gtk_range_set_fill_level().
/// </para>
/// </summary>

public class GtkRangeHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
}
public static class GtkRangeHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted before clamping a value, to give the application a
/// chance to adjust the bounds.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The #GtkRange::change-value signal is emitted when a scroll action is
/// performed on a range.  It allows an application to determine the
/// type of scroll event that occurred and the resultant new value.
/// The application can handle the event itself and return %TRUE to
/// prevent further processing.  Or, by returning %FALSE, it can pass
/// the event to other handlers until the default GTK+ handler is
/// reached.
/// </para>
/// <para>
/// The value parameter is unrounded.  An application that overrides
/// the GtkRange::change-value signal is responsible for clamping the
/// value to the desired number of decimal digits; the default GTK+
/// handler clamps the value based on #GtkRange:round-digits.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Virtual function that moves the slider. Used for keybindings.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Emitted when the range value changes.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// the value before we clamp
/// </para>
/// </summary>

	public double Value;

	public IntPtr UserData;
}

public class ChangeValueSignal
{

	public MentorLake.Gtk.GtkRangeHandle Self;
/// <summary>
/// <para>
/// the type of scroll action that was performed
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkScrollType Scroll;
/// <summary>
/// <para>
/// the new value resulting from the scroll action
/// </para>
/// </summary>

	public double Value;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to prevent other handlers from being invoked for
///     the signal, %FALSE to propagate the signal further
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class MoveSliderSignal
{

	public MentorLake.Gtk.GtkRangeHandle Self;
/// <summary>
/// <para>
/// how to move the slider
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// Emitted before clamping a value, to give the application a
/// chance to adjust the bounds.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="value">
/// the value before we clamp
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void adjust_bounds([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRangeHandle>))] MentorLake.Gtk.GtkRangeHandle self, double value, IntPtr user_data);


/// <summary>
/// <para>
/// The #GtkRange::change-value signal is emitted when a scroll action is
/// performed on a range.  It allows an application to determine the
/// type of scroll event that occurred and the resultant new value.
/// The application can handle the event itself and return %TRUE to
/// prevent further processing.  Or, by returning %FALSE, it can pass
/// the event to other handlers until the default GTK+ handler is
/// reached.
/// </para>
/// <para>
/// The value parameter is unrounded.  An application that overrides
/// the GtkRange::change-value signal is responsible for clamping the
/// value to the desired number of decimal digits; the default GTK+
/// handler clamps the value based on #GtkRange:round-digits.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="scroll">
/// the type of scroll action that was performed
/// </param>
/// <param name="value">
/// the new value resulting from the scroll action
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to prevent other handlers from being invoked for
///     the signal, %FALSE to propagate the signal further
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool change_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRangeHandle>))] MentorLake.Gtk.GtkRangeHandle self, MentorLake.Gtk.GtkScrollType scroll, double value, IntPtr user_data);


/// <summary>
/// <para>
/// Virtual function that moves the slider. Used for keybindings.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="step">
/// how to move the slider
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void move_slider([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRangeHandle>))] MentorLake.Gtk.GtkRangeHandle self, MentorLake.Gtk.GtkScrollType step, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when the range value changes.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void value_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRangeHandle>))] MentorLake.Gtk.GtkRangeHandle self, IntPtr user_data);

}


public static class GtkRangeHandleExtensions
{
/// <summary>
/// <para>
/// Get the #GtkAdjustment which is the “model” object for #GtkRange.
/// See gtk_range_set_adjustment() for details.
/// The return value does not have a reference added, so should not
/// be unreferenced.
/// </para>
/// </summary>

/// <param name="range">
/// a #GtkRange
/// </param>
/// <return>
/// a #GtkAdjustment
/// </return>

	public static MentorLake.Gtk.GtkAdjustmentHandle GetAdjustment(this MentorLake.Gtk.GtkRangeHandle range)
	{
		if (range.IsInvalid) throw new Exception("Invalid handle (GtkRangeHandle)");
		return GtkRangeHandleExterns.gtk_range_get_adjustment(range);
	}

/// <summary>
/// <para>
/// Gets the current position of the fill level indicator.
/// </para>
/// </summary>

/// <param name="range">
/// A #GtkRange
/// </param>
/// <return>
/// The current fill level
/// </return>

	public static double GetFillLevel(this MentorLake.Gtk.GtkRangeHandle range)
	{
		if (range.IsInvalid) throw new Exception("Invalid handle (GtkRangeHandle)");
		return GtkRangeHandleExterns.gtk_range_get_fill_level(range);
	}

/// <summary>
/// <para>
/// Gets the value set by gtk_range_set_flippable().
/// </para>
/// </summary>

/// <param name="range">
/// a #GtkRange
/// </param>
/// <return>
/// %TRUE if the range is flippable
/// </return>

	public static bool GetFlippable(this MentorLake.Gtk.GtkRangeHandle range)
	{
		if (range.IsInvalid) throw new Exception("Invalid handle (GtkRangeHandle)");
		return GtkRangeHandleExterns.gtk_range_get_flippable(range);
	}

/// <summary>
/// <para>
/// Gets the value set by gtk_range_set_inverted().
/// </para>
/// </summary>

/// <param name="range">
/// a #GtkRange
/// </param>
/// <return>
/// %TRUE if the range is inverted
/// </return>

	public static bool GetInverted(this MentorLake.Gtk.GtkRangeHandle range)
	{
		if (range.IsInvalid) throw new Exception("Invalid handle (GtkRangeHandle)");
		return GtkRangeHandleExterns.gtk_range_get_inverted(range);
	}

/// <summary>
/// <para>
/// Gets the sensitivity policy for the stepper that points to the
/// 'lower' end of the GtkRange’s adjustment.
/// </para>
/// </summary>

/// <param name="range">
/// a #GtkRange
/// </param>
/// <return>
/// The lower stepper’s sensitivity policy.
/// </return>

	public static MentorLake.Gtk.GtkSensitivityType GetLowerStepperSensitivity(this MentorLake.Gtk.GtkRangeHandle range)
	{
		if (range.IsInvalid) throw new Exception("Invalid handle (GtkRangeHandle)");
		return GtkRangeHandleExterns.gtk_range_get_lower_stepper_sensitivity(range);
	}

/// <summary>
/// <para>
/// This function is useful mainly for #GtkRange subclasses.
/// </para>
/// <para>
/// See gtk_range_set_min_slider_size().
/// </para>
/// </summary>

/// <param name="range">
/// a #GtkRange
/// </param>
/// <return>
/// The minimum size of the range’s slider.
/// </return>

	public static int GetMinSliderSize(this MentorLake.Gtk.GtkRangeHandle range)
	{
		if (range.IsInvalid) throw new Exception("Invalid handle (GtkRangeHandle)");
		return GtkRangeHandleExterns.gtk_range_get_min_slider_size(range);
	}

/// <summary>
/// <para>
/// This function returns the area that contains the range’s trough
/// and its steppers, in widget->window coordinates.
/// </para>
/// <para>
/// This function is useful mainly for #GtkRange subclasses.
/// </para>
/// </summary>

/// <param name="range">
/// a #GtkRange
/// </param>
/// <param name="range_rect">
/// return location for the range rectangle
/// </param>

	public static T GetRangeRect<T>(this T range, out MentorLake.Gdk.GdkRectangle range_rect) where T : GtkRangeHandle
	{
		if (range.IsInvalid) throw new Exception("Invalid handle (GtkRangeHandle)");
		GtkRangeHandleExterns.gtk_range_get_range_rect(range, out range_rect);
		return range;
	}

/// <summary>
/// <para>
/// Gets whether the range is restricted to the fill level.
/// </para>
/// </summary>

/// <param name="range">
/// A #GtkRange
/// </param>
/// <return>
/// %TRUE if @range is restricted to the fill level.
/// </return>

	public static bool GetRestrictToFillLevel(this MentorLake.Gtk.GtkRangeHandle range)
	{
		if (range.IsInvalid) throw new Exception("Invalid handle (GtkRangeHandle)");
		return GtkRangeHandleExterns.gtk_range_get_restrict_to_fill_level(range);
	}

/// <summary>
/// <para>
/// Gets the number of digits to round the value to when
/// it changes. See #GtkRange::change-value.
/// </para>
/// </summary>

/// <param name="range">
/// a #GtkRange
/// </param>
/// <return>
/// the number of digits to round to
/// </return>

	public static int GetRoundDigits(this MentorLake.Gtk.GtkRangeHandle range)
	{
		if (range.IsInvalid) throw new Exception("Invalid handle (GtkRangeHandle)");
		return GtkRangeHandleExterns.gtk_range_get_round_digits(range);
	}

/// <summary>
/// <para>
/// Gets whether the range displays the fill level graphically.
/// </para>
/// </summary>

/// <param name="range">
/// A #GtkRange
/// </param>
/// <return>
/// %TRUE if @range shows the fill level.
/// </return>

	public static bool GetShowFillLevel(this MentorLake.Gtk.GtkRangeHandle range)
	{
		if (range.IsInvalid) throw new Exception("Invalid handle (GtkRangeHandle)");
		return GtkRangeHandleExterns.gtk_range_get_show_fill_level(range);
	}

/// <summary>
/// <para>
/// This function returns sliders range along the long dimension,
/// in widget->window coordinates.
/// </para>
/// <para>
/// This function is useful mainly for #GtkRange subclasses.
/// </para>
/// </summary>

/// <param name="range">
/// a #GtkRange
/// </param>
/// <param name="slider_start">
/// return location for the slider's
///     start, or %NULL
/// </param>
/// <param name="slider_end">
/// return location for the slider's
///     end, or %NULL
/// </param>

	public static T GetSliderRange<T>(this T range, out int slider_start, out int slider_end) where T : GtkRangeHandle
	{
		if (range.IsInvalid) throw new Exception("Invalid handle (GtkRangeHandle)");
		GtkRangeHandleExterns.gtk_range_get_slider_range(range, out slider_start, out slider_end);
		return range;
	}

/// <summary>
/// <para>
/// This function is useful mainly for #GtkRange subclasses.
/// </para>
/// <para>
/// See gtk_range_set_slider_size_fixed().
/// </para>
/// </summary>

/// <param name="range">
/// a #GtkRange
/// </param>
/// <return>
/// whether the range’s slider has a fixed size.
/// </return>

	public static bool GetSliderSizeFixed(this MentorLake.Gtk.GtkRangeHandle range)
	{
		if (range.IsInvalid) throw new Exception("Invalid handle (GtkRangeHandle)");
		return GtkRangeHandleExterns.gtk_range_get_slider_size_fixed(range);
	}

/// <summary>
/// <para>
/// Gets the sensitivity policy for the stepper that points to the
/// 'upper' end of the GtkRange’s adjustment.
/// </para>
/// </summary>

/// <param name="range">
/// a #GtkRange
/// </param>
/// <return>
/// The upper stepper’s sensitivity policy.
/// </return>

	public static MentorLake.Gtk.GtkSensitivityType GetUpperStepperSensitivity(this MentorLake.Gtk.GtkRangeHandle range)
	{
		if (range.IsInvalid) throw new Exception("Invalid handle (GtkRangeHandle)");
		return GtkRangeHandleExterns.gtk_range_get_upper_stepper_sensitivity(range);
	}

/// <summary>
/// <para>
/// Gets the current value of the range.
/// </para>
/// </summary>

/// <param name="range">
/// a #GtkRange
/// </param>
/// <return>
/// current value of the range.
/// </return>

	public static double GetValue(this MentorLake.Gtk.GtkRangeHandle range)
	{
		if (range.IsInvalid) throw new Exception("Invalid handle (GtkRangeHandle)");
		return GtkRangeHandleExterns.gtk_range_get_value(range);
	}

/// <summary>
/// <para>
/// Sets the adjustment to be used as the “model” object for this range
/// widget. The adjustment indicates the current range value, the
/// minimum and maximum range values, the step/page increments used
/// for keybindings and scrolling, and the page size. The page size
/// is normally 0 for #GtkScale and nonzero for #GtkScrollbar, and
/// indicates the size of the visible area of the widget being scrolled.
/// The page size affects the size of the scrollbar slider.
/// </para>
/// </summary>

/// <param name="range">
/// a #GtkRange
/// </param>
/// <param name="adjustment">
/// a #GtkAdjustment
/// </param>

	public static T SetAdjustment<T>(this T range, MentorLake.Gtk.GtkAdjustmentHandle adjustment) where T : GtkRangeHandle
	{
		if (range.IsInvalid) throw new Exception("Invalid handle (GtkRangeHandle)");
		GtkRangeHandleExterns.gtk_range_set_adjustment(range, adjustment);
		return range;
	}

/// <summary>
/// <para>
/// Set the new position of the fill level indicator.
/// </para>
/// <para>
/// The “fill level” is probably best described by its most prominent
/// use case, which is an indicator for the amount of pre-buffering in
/// a streaming media player. In that use case, the value of the range
/// would indicate the current play position, and the fill level would
/// be the position up to which the file/stream has been downloaded.
/// </para>
/// <para>
/// This amount of prebuffering can be displayed on the range’s trough
/// and is themeable separately from the trough. To enable fill level
/// display, use gtk_range_set_show_fill_level(). The range defaults
/// to not showing the fill level.
/// </para>
/// <para>
/// Additionally, it’s possible to restrict the range’s slider position
/// to values which are smaller than the fill level. This is controller
/// by gtk_range_set_restrict_to_fill_level() and is by default
/// enabled.
/// </para>
/// </summary>

/// <param name="range">
/// a #GtkRange
/// </param>
/// <param name="fill_level">
/// the new position of the fill level indicator
/// </param>

	public static T SetFillLevel<T>(this T range, double fill_level) where T : GtkRangeHandle
	{
		if (range.IsInvalid) throw new Exception("Invalid handle (GtkRangeHandle)");
		GtkRangeHandleExterns.gtk_range_set_fill_level(range, fill_level);
		return range;
	}

/// <summary>
/// <para>
/// If a range is flippable, it will switch its direction if it is
/// horizontal and its direction is %GTK_TEXT_DIR_RTL.
/// </para>
/// <para>
/// See gtk_widget_get_direction().
/// </para>
/// </summary>

/// <param name="range">
/// a #GtkRange
/// </param>
/// <param name="flippable">
/// %TRUE to make the range flippable
/// </param>

	public static T SetFlippable<T>(this T range, bool flippable) where T : GtkRangeHandle
	{
		if (range.IsInvalid) throw new Exception("Invalid handle (GtkRangeHandle)");
		GtkRangeHandleExterns.gtk_range_set_flippable(range, flippable);
		return range;
	}

/// <summary>
/// <para>
/// Sets the step and page sizes for the range.
/// The step size is used when the user clicks the #GtkScrollbar
/// arrows or moves #GtkScale via arrow keys. The page size
/// is used for example when moving via Page Up or Page Down keys.
/// </para>
/// </summary>

/// <param name="range">
/// a #GtkRange
/// </param>
/// <param name="step">
/// step size
/// </param>
/// <param name="page">
/// page size
/// </param>

	public static T SetIncrements<T>(this T range, double step, double page) where T : GtkRangeHandle
	{
		if (range.IsInvalid) throw new Exception("Invalid handle (GtkRangeHandle)");
		GtkRangeHandleExterns.gtk_range_set_increments(range, step, page);
		return range;
	}

/// <summary>
/// <para>
/// Ranges normally move from lower to higher values as the
/// slider moves from top to bottom or left to right. Inverted
/// ranges have higher values at the top or on the right rather than
/// on the bottom or left.
/// </para>
/// </summary>

/// <param name="range">
/// a #GtkRange
/// </param>
/// <param name="setting">
/// %TRUE to invert the range
/// </param>

	public static T SetInverted<T>(this T range, bool setting) where T : GtkRangeHandle
	{
		if (range.IsInvalid) throw new Exception("Invalid handle (GtkRangeHandle)");
		GtkRangeHandleExterns.gtk_range_set_inverted(range, setting);
		return range;
	}

/// <summary>
/// <para>
/// Sets the sensitivity policy for the stepper that points to the
/// 'lower' end of the GtkRange’s adjustment.
/// </para>
/// </summary>

/// <param name="range">
/// a #GtkRange
/// </param>
/// <param name="sensitivity">
/// the lower stepper’s sensitivity policy.
/// </param>

	public static T SetLowerStepperSensitivity<T>(this T range, MentorLake.Gtk.GtkSensitivityType sensitivity) where T : GtkRangeHandle
	{
		if (range.IsInvalid) throw new Exception("Invalid handle (GtkRangeHandle)");
		GtkRangeHandleExterns.gtk_range_set_lower_stepper_sensitivity(range, sensitivity);
		return range;
	}

/// <summary>
/// <para>
/// Sets the minimum size of the range’s slider.
/// </para>
/// <para>
/// This function is useful mainly for #GtkRange subclasses.
/// </para>
/// </summary>

/// <param name="range">
/// a #GtkRange
/// </param>
/// <param name="min_size">
/// The slider’s minimum size
/// </param>

	public static T SetMinSliderSize<T>(this T range, int min_size) where T : GtkRangeHandle
	{
		if (range.IsInvalid) throw new Exception("Invalid handle (GtkRangeHandle)");
		GtkRangeHandleExterns.gtk_range_set_min_slider_size(range, min_size);
		return range;
	}

/// <summary>
/// <para>
/// Sets the allowable values in the #GtkRange, and clamps the range
/// value to be between @min and @max. (If the range has a non-zero
/// page size, it is clamped between @min and @max - page-size.)
/// </para>
/// </summary>

/// <param name="range">
/// a #GtkRange
/// </param>
/// <param name="min">
/// minimum range value
/// </param>
/// <param name="max">
/// maximum range value
/// </param>

	public static T SetRange<T>(this T range, double min, double max) where T : GtkRangeHandle
	{
		if (range.IsInvalid) throw new Exception("Invalid handle (GtkRangeHandle)");
		GtkRangeHandleExterns.gtk_range_set_range(range, min, max);
		return range;
	}

/// <summary>
/// <para>
/// Sets whether the slider is restricted to the fill level. See
/// gtk_range_set_fill_level() for a general description of the fill
/// level concept.
/// </para>
/// </summary>

/// <param name="range">
/// A #GtkRange
/// </param>
/// <param name="restrict_to_fill_level">
/// Whether the fill level restricts slider movement.
/// </param>

	public static T SetRestrictToFillLevel<T>(this T range, bool restrict_to_fill_level) where T : GtkRangeHandle
	{
		if (range.IsInvalid) throw new Exception("Invalid handle (GtkRangeHandle)");
		GtkRangeHandleExterns.gtk_range_set_restrict_to_fill_level(range, restrict_to_fill_level);
		return range;
	}

/// <summary>
/// <para>
/// Sets the number of digits to round the value to when
/// it changes. See #GtkRange::change-value.
/// </para>
/// </summary>

/// <param name="range">
/// a #GtkRange
/// </param>
/// <param name="round_digits">
/// the precision in digits, or -1
/// </param>

	public static T SetRoundDigits<T>(this T range, int round_digits) where T : GtkRangeHandle
	{
		if (range.IsInvalid) throw new Exception("Invalid handle (GtkRangeHandle)");
		GtkRangeHandleExterns.gtk_range_set_round_digits(range, round_digits);
		return range;
	}

/// <summary>
/// <para>
/// Sets whether a graphical fill level is show on the trough. See
/// gtk_range_set_fill_level() for a general description of the fill
/// level concept.
/// </para>
/// </summary>

/// <param name="range">
/// A #GtkRange
/// </param>
/// <param name="show_fill_level">
/// Whether a fill level indicator graphics is shown.
/// </param>

	public static T SetShowFillLevel<T>(this T range, bool show_fill_level) where T : GtkRangeHandle
	{
		if (range.IsInvalid) throw new Exception("Invalid handle (GtkRangeHandle)");
		GtkRangeHandleExterns.gtk_range_set_show_fill_level(range, show_fill_level);
		return range;
	}

/// <summary>
/// <para>
/// Sets whether the range’s slider has a fixed size, or a size that
/// depends on its adjustment’s page size.
/// </para>
/// <para>
/// This function is useful mainly for #GtkRange subclasses.
/// </para>
/// </summary>

/// <param name="range">
/// a #GtkRange
/// </param>
/// <param name="size_fixed">
/// %TRUE to make the slider size constant
/// </param>

	public static T SetSliderSizeFixed<T>(this T range, bool size_fixed) where T : GtkRangeHandle
	{
		if (range.IsInvalid) throw new Exception("Invalid handle (GtkRangeHandle)");
		GtkRangeHandleExterns.gtk_range_set_slider_size_fixed(range, size_fixed);
		return range;
	}

/// <summary>
/// <para>
/// Sets the sensitivity policy for the stepper that points to the
/// 'upper' end of the GtkRange’s adjustment.
/// </para>
/// </summary>

/// <param name="range">
/// a #GtkRange
/// </param>
/// <param name="sensitivity">
/// the upper stepper’s sensitivity policy.
/// </param>

	public static T SetUpperStepperSensitivity<T>(this T range, MentorLake.Gtk.GtkSensitivityType sensitivity) where T : GtkRangeHandle
	{
		if (range.IsInvalid) throw new Exception("Invalid handle (GtkRangeHandle)");
		GtkRangeHandleExterns.gtk_range_set_upper_stepper_sensitivity(range, sensitivity);
		return range;
	}

/// <summary>
/// <para>
/// Sets the current value of the range; if the value is outside the
/// minimum or maximum range values, it will be clamped to fit inside
/// them. The range emits the #GtkRange::value-changed signal if the
/// value changes.
/// </para>
/// </summary>

/// <param name="range">
/// a #GtkRange
/// </param>
/// <param name="value">
/// new value of the range
/// </param>

	public static T SetValue<T>(this T range, double value) where T : GtkRangeHandle
	{
		if (range.IsInvalid) throw new Exception("Invalid handle (GtkRangeHandle)");
		GtkRangeHandleExterns.gtk_range_set_value(range, value);
		return range;
	}

}

internal class GtkRangeHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))]
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
