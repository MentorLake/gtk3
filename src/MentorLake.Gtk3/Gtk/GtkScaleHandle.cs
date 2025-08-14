namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A GtkScale is a slider control used to select a numeric value.
/// To use it, you’ll probably want to investigate the methods on
/// its base class, #GtkRange, in addition to the methods for GtkScale itself.
/// To set the value of a scale, you would normally use gtk_range_set_value().
/// To detect changes to the value, you would normally use the
/// #GtkRange::value-changed signal.
/// </para>
/// <para>
/// Note that using the same upper and lower bounds for the #GtkScale (through
/// the #GtkRange methods) will hide the slider itself. This is useful for
/// applications that want to show an undeterminate value on the scale, without
/// changing the layout of the application (such as movie or music players).
/// </para>
/// <para>
/// # GtkScale as GtkBuildable
/// </para>
/// <para>
/// GtkScale supports a custom `<marks>` element, which can contain multiple
/// `<mark>` elements. The “value” and “position” attributes have the same
/// meaning as gtk_scale_add_mark() parameters of the same name. If the
/// element is not empty, its content is taken as the markup to show at
/// the mark. It can be translated with the usual ”translatable” and
/// “context” attributes.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// |[<!-- language="plain" -->
/// scale[.fine-tune][.marks-before][.marks-after]
/// ├── marks.top
/// │   ├── mark
/// │   ┊    ├── [label]
/// │   ┊    ╰── indicator
/// ┊   ┊
/// │   ╰── mark
/// ├── [value]
/// ├── contents
/// │   ╰── trough
/// │       ├── slider
/// │       ├── [highlight]
/// │       ╰── [fill]
/// ╰── marks.bottom
///     ├── mark
///     ┊    ├── indicator
///     ┊    ╰── [label]
///     ╰── mark
/// ]|
/// </para>
/// <para>
/// GtkScale has a main CSS node with name scale and a subnode for its contents,
/// with subnodes named trough and slider.
/// </para>
/// <para>
/// The main node gets the style class .fine-tune added when the scale is in
/// 'fine-tuning' mode.
/// </para>
/// <para>
/// If the scale has an origin (see gtk_scale_set_has_origin()), there is a
/// subnode with name highlight below the trough node that is used for rendering
/// the highlighted part of the trough.
/// </para>
/// <para>
/// If the scale is showing a fill level (see gtk_range_set_show_fill_level()),
/// there is a subnode with name fill below the trough node that is used for
/// rendering the filled in part of the trough.
/// </para>
/// <para>
/// If marks are present, there is a marks subnode before or after the contents
/// node, below which each mark gets a node with name mark. The marks nodes get
/// either the .top or .bottom style class.
/// </para>
/// <para>
/// The mark node has a subnode named indicator. If the mark has text, it also
/// has a subnode named label. When the mark is either above or left of the
/// scale, the label subnode is the first when present. Otherwise, the indicator
/// subnode is the first.
/// </para>
/// <para>
/// The main CSS node gets the 'marks-before' and/or 'marks-after' style classes
/// added depending on what marks are present.
/// </para>
/// <para>
/// If the scale is displaying the value (see #GtkScale:draw-value), there is
/// subnode with name value.
/// </para>
/// </summary>

public class GtkScaleHandle : GtkRangeHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkScale.
/// </para>
/// </summary>

/// <param name="orientation">
/// the scale’s orientation.
/// </param>
/// <param name="adjustment">
/// the #GtkAdjustment which sets the range
///              of the scale, or %NULL to create a new adjustment.
/// </param>
/// <return>
/// a new #GtkScale
/// </return>

	public static MentorLake.Gtk.GtkScaleHandle New(MentorLake.Gtk.GtkOrientation orientation, MentorLake.Gtk.GtkAdjustmentHandle adjustment)
	{
		return GtkScaleHandleExterns.gtk_scale_new(orientation, adjustment);
	}

/// <summary>
/// <para>
/// Creates a new scale widget with the given orientation that lets the
/// user input a number between @min and @max (including @min and @max)
/// with the increment @step.  @step must be nonzero; it’s the distance
/// the slider moves when using the arrow keys to adjust the scale
/// value.
/// </para>
/// <para>
/// Note that the way in which the precision is derived works best if @step
/// is a power of ten. If the resulting precision is not suitable for your
/// needs, use gtk_scale_set_digits() to correct it.
/// </para>
/// </summary>

/// <param name="orientation">
/// the scale’s orientation.
/// </param>
/// <param name="min">
/// minimum value
/// </param>
/// <param name="max">
/// maximum value
/// </param>
/// <param name="step">
/// step increment (tick size) used with keyboard shortcuts
/// </param>
/// <return>
/// a new #GtkScale
/// </return>

	public static MentorLake.Gtk.GtkScaleHandle NewWithRange(MentorLake.Gtk.GtkOrientation orientation, double min, double max, double step)
	{
		return GtkScaleHandleExterns.gtk_scale_new_with_range(orientation, min, max, step);
	}

}
public static class GtkScaleHandleSignalExtensions
{
/// <summary>
/// <para>
/// Signal which allows you to change how the scale value is displayed.
/// Connect a signal handler which returns an allocated string representing
/// @value. That string will then be used to display the scale's value.
/// </para>
/// <para>
/// If no user-provided handlers are installed, the value will be displayed on
/// its own, rounded according to the value of the #GtkScale:digits property.
/// </para>
/// <para>
/// Here's an example signal handler which displays a value 1.0 as
/// with "-->1.0<--".
/// |[<!-- language="C" -->
/// static gchar*
/// format_value_callback (GtkScale *scale,
///                        gdouble   value)
/// {
///   return g_strdup_printf ("-->\%0.*g<--",
///                           gtk_scale_get_digits (scale), value);
///  }
/// ]|
/// </para>
/// </summary>

	public static IObservable<GtkScaleHandleSignalStructs.FormatValueSignal> Signal_FormatValue(this GtkScaleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkScaleHandleSignalStructs.FormatValueSignal> obs) =>
		{
			GtkScaleHandleSignalDelegates.format_value handler = ( MentorLake.Gtk.GtkScaleHandle self,  double value,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkScaleHandleSignalStructs.FormatValueSignal()
				{
					Self = self, Value = value, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "format-value", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkScaleHandleSignalStructs
{

public class FormatValueSignal
{

	public MentorLake.Gtk.GtkScaleHandle Self;
/// <summary>
/// <para>
/// the value to format
/// </para>
/// </summary>

	public double Value;

	public IntPtr UserData;
/// <summary>
/// <para>
/// allocated string representing @value
/// </para>
/// </summary>

	public string ReturnValue;
}
}

public static class GtkScaleHandleSignalDelegates
{

/// <summary>
/// <para>
/// Signal which allows you to change how the scale value is displayed.
/// Connect a signal handler which returns an allocated string representing
/// @value. That string will then be used to display the scale's value.
/// </para>
/// <para>
/// If no user-provided handlers are installed, the value will be displayed on
/// its own, rounded according to the value of the #GtkScale:digits property.
/// </para>
/// <para>
/// Here's an example signal handler which displays a value 1.0 as
/// with "-->1.0<--".
/// |[<!-- language="C" -->
/// static gchar*
/// format_value_callback (GtkScale *scale,
///                        gdouble   value)
/// {
///   return g_strdup_printf ("-->\%0.*g<--",
///                           gtk_scale_get_digits (scale), value);
///  }
/// ]|
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="value">
/// the value to format
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// allocated string representing @value
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate string format_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleHandle>))] MentorLake.Gtk.GtkScaleHandle self, double value, IntPtr user_data);

}


public static class GtkScaleHandleExtensions
{
/// <summary>
/// <para>
/// Adds a mark at @value.
/// </para>
/// <para>
/// A mark is indicated visually by drawing a tick mark next to the scale,
/// and GTK+ makes it easy for the user to position the scale exactly at the
/// marks value.
/// </para>
/// <para>
/// If @markup is not %NULL, text is shown next to the tick mark.
/// </para>
/// <para>
/// To remove marks from a scale, use gtk_scale_clear_marks().
/// </para>
/// </summary>

/// <param name="scale">
/// a #GtkScale
/// </param>
/// <param name="value">
/// the value at which the mark is placed, must be between
///   the lower and upper limits of the scales’ adjustment
/// </param>
/// <param name="position">
/// where to draw the mark. For a horizontal scale, #GTK_POS_TOP
///   and %GTK_POS_LEFT are drawn above the scale, anything else below.
///   For a vertical scale, #GTK_POS_LEFT and %GTK_POS_TOP are drawn to
///   the left of the scale, anything else to the right.
/// </param>
/// <param name="markup">
/// Text to be shown at the mark, using [Pango markup][PangoMarkupFormat], or %NULL
/// </param>

	public static T AddMark<T>(this T scale, double value, MentorLake.Gtk.GtkPositionType position, string markup) where T : GtkScaleHandle
	{
		if (scale.IsInvalid) throw new Exception("Invalid handle (GtkScaleHandle)");
		GtkScaleHandleExterns.gtk_scale_add_mark(scale, value, position, markup);
		return scale;
	}

/// <summary>
/// <para>
/// Removes any marks that have been added with gtk_scale_add_mark().
/// </para>
/// </summary>

/// <param name="scale">
/// a #GtkScale
/// </param>

	public static T ClearMarks<T>(this T scale) where T : GtkScaleHandle
	{
		if (scale.IsInvalid) throw new Exception("Invalid handle (GtkScaleHandle)");
		GtkScaleHandleExterns.gtk_scale_clear_marks(scale);
		return scale;
	}

/// <summary>
/// <para>
/// Gets the number of decimal places that are displayed in the value.
/// </para>
/// </summary>

/// <param name="scale">
/// a #GtkScale
/// </param>
/// <return>
/// the number of decimal places that are displayed
/// </return>

	public static int GetDigits(this MentorLake.Gtk.GtkScaleHandle scale)
	{
		if (scale.IsInvalid) throw new Exception("Invalid handle (GtkScaleHandle)");
		return GtkScaleHandleExterns.gtk_scale_get_digits(scale);
	}

/// <summary>
/// <para>
/// Returns whether the current value is displayed as a string
/// next to the slider.
/// </para>
/// </summary>

/// <param name="scale">
/// a #GtkScale
/// </param>
/// <return>
/// whether the current value is displayed as a string
/// </return>

	public static bool GetDrawValue(this MentorLake.Gtk.GtkScaleHandle scale)
	{
		if (scale.IsInvalid) throw new Exception("Invalid handle (GtkScaleHandle)");
		return GtkScaleHandleExterns.gtk_scale_get_draw_value(scale);
	}

/// <summary>
/// <para>
/// Returns whether the scale has an origin.
/// </para>
/// </summary>

/// <param name="scale">
/// a #GtkScale
/// </param>
/// <return>
/// %TRUE if the scale has an origin.
/// </return>

	public static bool GetHasOrigin(this MentorLake.Gtk.GtkScaleHandle scale)
	{
		if (scale.IsInvalid) throw new Exception("Invalid handle (GtkScaleHandle)");
		return GtkScaleHandleExterns.gtk_scale_get_has_origin(scale);
	}

/// <summary>
/// <para>
/// Gets the #PangoLayout used to display the scale. The returned
/// object is owned by the scale so does not need to be freed by
/// the caller.
/// </para>
/// </summary>

/// <param name="scale">
/// A #GtkScale
/// </param>
/// <return>
/// the #PangoLayout for this scale,
///     or %NULL if the #GtkScale:draw-value property is %FALSE.
/// </return>

	public static MentorLake.Pango.PangoLayoutHandle GetLayout(this MentorLake.Gtk.GtkScaleHandle scale)
	{
		if (scale.IsInvalid) throw new Exception("Invalid handle (GtkScaleHandle)");
		return GtkScaleHandleExterns.gtk_scale_get_layout(scale);
	}

/// <summary>
/// <para>
/// Obtains the coordinates where the scale will draw the
/// #PangoLayout representing the text in the scale. Remember
/// when using the #PangoLayout function you need to convert to
/// and from pixels using PANGO_PIXELS() or #PANGO_SCALE.
/// </para>
/// <para>
/// If the #GtkScale:draw-value property is %FALSE, the return
/// values are undefined.
/// </para>
/// </summary>

/// <param name="scale">
/// a #GtkScale
/// </param>
/// <param name="x">
/// location to store X offset of layout, or %NULL
/// </param>
/// <param name="y">
/// location to store Y offset of layout, or %NULL
/// </param>

	public static T GetLayoutOffsets<T>(this T scale, out int x, out int y) where T : GtkScaleHandle
	{
		if (scale.IsInvalid) throw new Exception("Invalid handle (GtkScaleHandle)");
		GtkScaleHandleExterns.gtk_scale_get_layout_offsets(scale, out x, out y);
		return scale;
	}

/// <summary>
/// <para>
/// Gets the position in which the current value is displayed.
/// </para>
/// </summary>

/// <param name="scale">
/// a #GtkScale
/// </param>
/// <return>
/// the position in which the current value is displayed
/// </return>

	public static MentorLake.Gtk.GtkPositionType GetValuePos(this MentorLake.Gtk.GtkScaleHandle scale)
	{
		if (scale.IsInvalid) throw new Exception("Invalid handle (GtkScaleHandle)");
		return GtkScaleHandleExterns.gtk_scale_get_value_pos(scale);
	}

/// <summary>
/// <para>
/// Sets the number of decimal places that are displayed in the value. Also
/// causes the value of the adjustment to be rounded to this number of digits,
/// so the retrieved value matches the displayed one, if #GtkScale:draw-value is
/// %TRUE when the value changes. If you want to enforce rounding the value when
/// #GtkScale:draw-value is %FALSE, you can set #GtkRange:round-digits instead.
/// </para>
/// <para>
/// Note that rounding to a small number of digits can interfere with
/// the smooth autoscrolling that is built into #GtkScale. As an alternative,
/// you can use the #GtkScale::format-value signal to format the displayed
/// value yourself.
/// </para>
/// </summary>

/// <param name="scale">
/// a #GtkScale
/// </param>
/// <param name="digits">
/// the number of decimal places to display,
///     e.g. use 1 to display 1.0, 2 to display 1.00, etc
/// </param>

	public static T SetDigits<T>(this T scale, int digits) where T : GtkScaleHandle
	{
		if (scale.IsInvalid) throw new Exception("Invalid handle (GtkScaleHandle)");
		GtkScaleHandleExterns.gtk_scale_set_digits(scale, digits);
		return scale;
	}

/// <summary>
/// <para>
/// Specifies whether the current value is displayed as a string next
/// to the slider.
/// </para>
/// </summary>

/// <param name="scale">
/// a #GtkScale
/// </param>
/// <param name="draw_value">
/// %TRUE to draw the value
/// </param>

	public static T SetDrawValue<T>(this T scale, bool draw_value) where T : GtkScaleHandle
	{
		if (scale.IsInvalid) throw new Exception("Invalid handle (GtkScaleHandle)");
		GtkScaleHandleExterns.gtk_scale_set_draw_value(scale, draw_value);
		return scale;
	}

/// <summary>
/// <para>
/// If #GtkScale:has-origin is set to %TRUE (the default), the scale will
/// highlight the part of the trough between the origin (bottom or left side)
/// and the current value.
/// </para>
/// </summary>

/// <param name="scale">
/// a #GtkScale
/// </param>
/// <param name="has_origin">
/// %TRUE if the scale has an origin
/// </param>

	public static T SetHasOrigin<T>(this T scale, bool has_origin) where T : GtkScaleHandle
	{
		if (scale.IsInvalid) throw new Exception("Invalid handle (GtkScaleHandle)");
		GtkScaleHandleExterns.gtk_scale_set_has_origin(scale, has_origin);
		return scale;
	}

/// <summary>
/// <para>
/// Sets the position in which the current value is displayed.
/// </para>
/// </summary>

/// <param name="scale">
/// a #GtkScale
/// </param>
/// <param name="pos">
/// the position in which the current value is displayed
/// </param>

	public static T SetValuePos<T>(this T scale, MentorLake.Gtk.GtkPositionType pos) where T : GtkScaleHandle
	{
		if (scale.IsInvalid) throw new Exception("Invalid handle (GtkScaleHandle)");
		GtkScaleHandleExterns.gtk_scale_set_value_pos(scale, pos);
		return scale;
	}

}

internal class GtkScaleHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkScaleHandle>))]
	internal static extern MentorLake.Gtk.GtkScaleHandle gtk_scale_new(MentorLake.Gtk.GtkOrientation orientation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkScaleHandle>))]
	internal static extern MentorLake.Gtk.GtkScaleHandle gtk_scale_new_with_range(MentorLake.Gtk.GtkOrientation orientation, double min, double max, double step);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scale_add_mark([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleHandle>))] MentorLake.Gtk.GtkScaleHandle scale, double value, MentorLake.Gtk.GtkPositionType position, string markup);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scale_clear_marks([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleHandle>))] MentorLake.Gtk.GtkScaleHandle scale);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_scale_get_digits([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleHandle>))] MentorLake.Gtk.GtkScaleHandle scale);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_scale_get_draw_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleHandle>))] MentorLake.Gtk.GtkScaleHandle scale);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_scale_get_has_origin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleHandle>))] MentorLake.Gtk.GtkScaleHandle scale);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))]
	internal static extern MentorLake.Pango.PangoLayoutHandle gtk_scale_get_layout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleHandle>))] MentorLake.Gtk.GtkScaleHandle scale);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scale_get_layout_offsets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleHandle>))] MentorLake.Gtk.GtkScaleHandle scale, out int x, out int y);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPositionType gtk_scale_get_value_pos([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleHandle>))] MentorLake.Gtk.GtkScaleHandle scale);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scale_set_digits([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleHandle>))] MentorLake.Gtk.GtkScaleHandle scale, int digits);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scale_set_draw_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleHandle>))] MentorLake.Gtk.GtkScaleHandle scale, bool draw_value);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scale_set_has_origin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleHandle>))] MentorLake.Gtk.GtkScaleHandle scale, bool has_origin);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scale_set_value_pos([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScaleHandle>))] MentorLake.Gtk.GtkScaleHandle scale, MentorLake.Gtk.GtkPositionType pos);

}
