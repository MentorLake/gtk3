namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkCalendar is a widget that displays a Gregorian calendar, one month
/// at a time. It can be created with gtk_calendar_new().
/// </para>
/// <para>
/// The month and year currently displayed can be altered with
/// gtk_calendar_select_month(). The exact day can be selected from the
/// displayed month using gtk_calendar_select_day().
/// </para>
/// <para>
/// To place a visual marker on a particular day, use gtk_calendar_mark_day()
/// and to remove the marker, gtk_calendar_unmark_day(). Alternative, all
/// marks can be cleared with gtk_calendar_clear_marks().
/// </para>
/// <para>
/// The way in which the calendar itself is displayed can be altered using
/// gtk_calendar_set_display_options().
/// </para>
/// <para>
/// The selected date can be retrieved from a #GtkCalendar using
/// gtk_calendar_get_date().
/// </para>
/// <para>
/// Users should be aware that, although the Gregorian calendar is the
/// legal calendar in most countries, it was adopted progressively
/// between 1582 and 1929. Display before these dates is likely to be
/// historically incorrect.
/// </para>
/// </summary>

public class GtkCalendarHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new calendar, with the current date being selected.
/// </para>
/// </summary>

/// <return>
/// a newly #GtkCalendar widget
/// </return>

	public static MentorLake.Gtk.GtkCalendarHandle New()
	{
		return GtkCalendarHandleExterns.gtk_calendar_new();
	}

}
public static class GtkCalendarHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when the user selects a day.
/// </para>
/// </summary>

	public static IObservable<GtkCalendarHandleSignalStructs.DaySelectedSignal> Signal_DaySelected(this GtkCalendarHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkCalendarHandleSignalStructs.DaySelectedSignal> obs) =>
		{
			GtkCalendarHandleSignalDelegates.day_selected handler = ( MentorLake.Gtk.GtkCalendarHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCalendarHandleSignalStructs.DaySelectedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "day-selected", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when the user double-clicks a day.
/// </para>
/// </summary>

	public static IObservable<GtkCalendarHandleSignalStructs.DaySelectedDoubleClickSignal> Signal_DaySelectedDoubleClick(this GtkCalendarHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkCalendarHandleSignalStructs.DaySelectedDoubleClickSignal> obs) =>
		{
			GtkCalendarHandleSignalDelegates.day_selected_double_click handler = ( MentorLake.Gtk.GtkCalendarHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCalendarHandleSignalStructs.DaySelectedDoubleClickSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "day-selected-double-click", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when the user clicks a button to change the selected month on a
/// calendar.
/// </para>
/// </summary>

	public static IObservable<GtkCalendarHandleSignalStructs.MonthChangedSignal> Signal_MonthChanged(this GtkCalendarHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkCalendarHandleSignalStructs.MonthChangedSignal> obs) =>
		{
			GtkCalendarHandleSignalDelegates.month_changed handler = ( MentorLake.Gtk.GtkCalendarHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCalendarHandleSignalStructs.MonthChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "month-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when the user switched to the next month.
/// </para>
/// </summary>

	public static IObservable<GtkCalendarHandleSignalStructs.NextMonthSignal> Signal_NextMonth(this GtkCalendarHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkCalendarHandleSignalStructs.NextMonthSignal> obs) =>
		{
			GtkCalendarHandleSignalDelegates.next_month handler = ( MentorLake.Gtk.GtkCalendarHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCalendarHandleSignalStructs.NextMonthSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "next-month", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when user switched to the next year.
/// </para>
/// </summary>

	public static IObservable<GtkCalendarHandleSignalStructs.NextYearSignal> Signal_NextYear(this GtkCalendarHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkCalendarHandleSignalStructs.NextYearSignal> obs) =>
		{
			GtkCalendarHandleSignalDelegates.next_year handler = ( MentorLake.Gtk.GtkCalendarHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCalendarHandleSignalStructs.NextYearSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "next-year", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when the user switched to the previous month.
/// </para>
/// </summary>

	public static IObservable<GtkCalendarHandleSignalStructs.PrevMonthSignal> Signal_PrevMonth(this GtkCalendarHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkCalendarHandleSignalStructs.PrevMonthSignal> obs) =>
		{
			GtkCalendarHandleSignalDelegates.prev_month handler = ( MentorLake.Gtk.GtkCalendarHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCalendarHandleSignalStructs.PrevMonthSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "prev-month", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when user switched to the previous year.
/// </para>
/// </summary>

	public static IObservable<GtkCalendarHandleSignalStructs.PrevYearSignal> Signal_PrevYear(this GtkCalendarHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkCalendarHandleSignalStructs.PrevYearSignal> obs) =>
		{
			GtkCalendarHandleSignalDelegates.prev_year handler = ( MentorLake.Gtk.GtkCalendarHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCalendarHandleSignalStructs.PrevYearSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "prev-year", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkCalendarHandleSignalStructs
{

public class DaySelectedSignal
{

	public MentorLake.Gtk.GtkCalendarHandle Self;

	public IntPtr UserData;
}

public class DaySelectedDoubleClickSignal
{

	public MentorLake.Gtk.GtkCalendarHandle Self;

	public IntPtr UserData;
}

public class MonthChangedSignal
{

	public MentorLake.Gtk.GtkCalendarHandle Self;

	public IntPtr UserData;
}

public class NextMonthSignal
{

	public MentorLake.Gtk.GtkCalendarHandle Self;

	public IntPtr UserData;
}

public class NextYearSignal
{

	public MentorLake.Gtk.GtkCalendarHandle Self;

	public IntPtr UserData;
}

public class PrevMonthSignal
{

	public MentorLake.Gtk.GtkCalendarHandle Self;

	public IntPtr UserData;
}

public class PrevYearSignal
{

	public MentorLake.Gtk.GtkCalendarHandle Self;

	public IntPtr UserData;
}
}

public static class GtkCalendarHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted when the user selects a day.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void day_selected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCalendarHandle>))] MentorLake.Gtk.GtkCalendarHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when the user double-clicks a day.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void day_selected_double_click([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCalendarHandle>))] MentorLake.Gtk.GtkCalendarHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when the user clicks a button to change the selected month on a
/// calendar.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void month_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCalendarHandle>))] MentorLake.Gtk.GtkCalendarHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when the user switched to the next month.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void next_month([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCalendarHandle>))] MentorLake.Gtk.GtkCalendarHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when user switched to the next year.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void next_year([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCalendarHandle>))] MentorLake.Gtk.GtkCalendarHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when the user switched to the previous month.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void prev_month([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCalendarHandle>))] MentorLake.Gtk.GtkCalendarHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when user switched to the previous year.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void prev_year([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCalendarHandle>))] MentorLake.Gtk.GtkCalendarHandle self, IntPtr user_data);

}


public static class GtkCalendarHandleExtensions
{
/// <summary>
/// <para>
/// Remove all visual markers.
/// </para>
/// </summary>

/// <param name="calendar">
/// a #GtkCalendar
/// </param>

	public static T ClearMarks<T>(this T calendar) where T : GtkCalendarHandle
	{
		if (calendar.IsInvalid) throw new Exception("Invalid handle (GtkCalendarHandle)");
		GtkCalendarHandleExterns.gtk_calendar_clear_marks(calendar);
		return calendar;
	}

/// <summary>
/// <para>
/// Obtains the selected date from a #GtkCalendar.
/// </para>
/// </summary>

/// <param name="calendar">
/// a #GtkCalendar
/// </param>
/// <param name="year">
/// location to store the year as a decimal
///     number (e.g. 2011), or %NULL
/// </param>
/// <param name="month">
/// location to store the month number
///     (between 0 and 11), or %NULL
/// </param>
/// <param name="day">
/// location to store the day number (between
///     1 and 31), or %NULL
/// </param>

	public static T GetDate<T>(this T calendar, out uint year, out uint month, out uint day) where T : GtkCalendarHandle
	{
		if (calendar.IsInvalid) throw new Exception("Invalid handle (GtkCalendarHandle)");
		GtkCalendarHandleExterns.gtk_calendar_get_date(calendar, out year, out month, out day);
		return calendar;
	}

/// <summary>
/// <para>
/// Returns if the @day of the @calendar is already marked.
/// </para>
/// </summary>

/// <param name="calendar">
/// a #GtkCalendar
/// </param>
/// <param name="day">
/// the day number between 1 and 31.
/// </param>
/// <return>
/// whether the day is marked.
/// </return>

	public static bool GetDayIsMarked(this MentorLake.Gtk.GtkCalendarHandle calendar, uint day)
	{
		if (calendar.IsInvalid) throw new Exception("Invalid handle (GtkCalendarHandle)");
		return GtkCalendarHandleExterns.gtk_calendar_get_day_is_marked(calendar, day);
	}

/// <summary>
/// <para>
/// Queries the height of detail cells, in rows.
/// See #GtkCalendar:detail-width-chars.
/// </para>
/// </summary>

/// <param name="calendar">
/// a #GtkCalendar.
/// </param>
/// <return>
/// The height of detail cells, in rows.
/// </return>

	public static int GetDetailHeightRows(this MentorLake.Gtk.GtkCalendarHandle calendar)
	{
		if (calendar.IsInvalid) throw new Exception("Invalid handle (GtkCalendarHandle)");
		return GtkCalendarHandleExterns.gtk_calendar_get_detail_height_rows(calendar);
	}

/// <summary>
/// <para>
/// Queries the width of detail cells, in characters.
/// See #GtkCalendar:detail-width-chars.
/// </para>
/// </summary>

/// <param name="calendar">
/// a #GtkCalendar.
/// </param>
/// <return>
/// The width of detail cells, in characters.
/// </return>

	public static int GetDetailWidthChars(this MentorLake.Gtk.GtkCalendarHandle calendar)
	{
		if (calendar.IsInvalid) throw new Exception("Invalid handle (GtkCalendarHandle)");
		return GtkCalendarHandleExterns.gtk_calendar_get_detail_width_chars(calendar);
	}

/// <summary>
/// <para>
/// Returns the current display options of @calendar.
/// </para>
/// </summary>

/// <param name="calendar">
/// a #GtkCalendar
/// </param>
/// <return>
/// the display options.
/// </return>

	public static MentorLake.Gtk.GtkCalendarDisplayOptions GetDisplayOptions(this MentorLake.Gtk.GtkCalendarHandle calendar)
	{
		if (calendar.IsInvalid) throw new Exception("Invalid handle (GtkCalendarHandle)");
		return GtkCalendarHandleExterns.gtk_calendar_get_display_options(calendar);
	}

/// <summary>
/// <para>
/// Places a visual marker on a particular day.
/// </para>
/// </summary>

/// <param name="calendar">
/// a #GtkCalendar
/// </param>
/// <param name="day">
/// the day number to mark between 1 and 31.
/// </param>

	public static T MarkDay<T>(this T calendar, uint day) where T : GtkCalendarHandle
	{
		if (calendar.IsInvalid) throw new Exception("Invalid handle (GtkCalendarHandle)");
		GtkCalendarHandleExterns.gtk_calendar_mark_day(calendar, day);
		return calendar;
	}

/// <summary>
/// <para>
/// Selects a day from the current month.
/// </para>
/// </summary>

/// <param name="calendar">
/// a #GtkCalendar.
/// </param>
/// <param name="day">
/// the day number between 1 and 31, or 0 to unselect
///   the currently selected day.
/// </param>

	public static T SelectDay<T>(this T calendar, uint day) where T : GtkCalendarHandle
	{
		if (calendar.IsInvalid) throw new Exception("Invalid handle (GtkCalendarHandle)");
		GtkCalendarHandleExterns.gtk_calendar_select_day(calendar, day);
		return calendar;
	}

/// <summary>
/// <para>
/// Shifts the calendar to a different month.
/// </para>
/// </summary>

/// <param name="calendar">
/// a #GtkCalendar
/// </param>
/// <param name="month">
/// a month number between 0 and 11.
/// </param>
/// <param name="year">
/// the year the month is in.
/// </param>

	public static T SelectMonth<T>(this T calendar, uint month, uint year) where T : GtkCalendarHandle
	{
		if (calendar.IsInvalid) throw new Exception("Invalid handle (GtkCalendarHandle)");
		GtkCalendarHandleExterns.gtk_calendar_select_month(calendar, month, year);
		return calendar;
	}

/// <summary>
/// <para>
/// Installs a function which provides Pango markup with detail information
/// for each day. Examples for such details are holidays or appointments. That
/// information is shown below each day when #GtkCalendar:show-details is set.
/// A tooltip containing with full detail information is provided, if the entire
/// text should not fit into the details area, or if #GtkCalendar:show-details
/// is not set.
/// </para>
/// <para>
/// The size of the details area can be restricted by setting the
/// #GtkCalendar:detail-width-chars and #GtkCalendar:detail-height-rows
/// properties.
/// </para>
/// </summary>

/// <param name="calendar">
/// a #GtkCalendar.
/// </param>
/// <param name="func">
/// a function providing details for each day.
/// </param>
/// <param name="data">
/// data to pass to @func invokations.
/// </param>
/// <param name="destroy">
/// a function for releasing @data.
/// </param>

	public static T SetDetailFunc<T>(this T calendar, MentorLake.Gtk.GtkCalendarDetailFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkCalendarHandle
	{
		if (calendar.IsInvalid) throw new Exception("Invalid handle (GtkCalendarHandle)");
		GtkCalendarHandleExterns.gtk_calendar_set_detail_func(calendar, func, data, destroy);
		return calendar;
	}

/// <summary>
/// <para>
/// Updates the height of detail cells.
/// See #GtkCalendar:detail-height-rows.
/// </para>
/// </summary>

/// <param name="calendar">
/// a #GtkCalendar.
/// </param>
/// <param name="rows">
/// detail height in rows.
/// </param>

	public static T SetDetailHeightRows<T>(this T calendar, int rows) where T : GtkCalendarHandle
	{
		if (calendar.IsInvalid) throw new Exception("Invalid handle (GtkCalendarHandle)");
		GtkCalendarHandleExterns.gtk_calendar_set_detail_height_rows(calendar, rows);
		return calendar;
	}

/// <summary>
/// <para>
/// Updates the width of detail cells.
/// See #GtkCalendar:detail-width-chars.
/// </para>
/// </summary>

/// <param name="calendar">
/// a #GtkCalendar.
/// </param>
/// <param name="chars">
/// detail width in characters.
/// </param>

	public static T SetDetailWidthChars<T>(this T calendar, int chars) where T : GtkCalendarHandle
	{
		if (calendar.IsInvalid) throw new Exception("Invalid handle (GtkCalendarHandle)");
		GtkCalendarHandleExterns.gtk_calendar_set_detail_width_chars(calendar, chars);
		return calendar;
	}

/// <summary>
/// <para>
/// Sets display options (whether to display the heading and the month
/// headings).
/// </para>
/// </summary>

/// <param name="calendar">
/// a #GtkCalendar
/// </param>
/// <param name="flags">
/// the display options to set
/// </param>

	public static T SetDisplayOptions<T>(this T calendar, MentorLake.Gtk.GtkCalendarDisplayOptions flags) where T : GtkCalendarHandle
	{
		if (calendar.IsInvalid) throw new Exception("Invalid handle (GtkCalendarHandle)");
		GtkCalendarHandleExterns.gtk_calendar_set_display_options(calendar, flags);
		return calendar;
	}

/// <summary>
/// <para>
/// Removes the visual marker from a particular day.
/// </para>
/// </summary>

/// <param name="calendar">
/// a #GtkCalendar.
/// </param>
/// <param name="day">
/// the day number to unmark between 1 and 31.
/// </param>

	public static T UnmarkDay<T>(this T calendar, uint day) where T : GtkCalendarHandle
	{
		if (calendar.IsInvalid) throw new Exception("Invalid handle (GtkCalendarHandle)");
		GtkCalendarHandleExterns.gtk_calendar_unmark_day(calendar, day);
		return calendar;
	}

}

internal class GtkCalendarHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkCalendarHandle>))]
	internal static extern MentorLake.Gtk.GtkCalendarHandle gtk_calendar_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_calendar_clear_marks([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCalendarHandle>))] MentorLake.Gtk.GtkCalendarHandle calendar);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_calendar_get_date([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCalendarHandle>))] MentorLake.Gtk.GtkCalendarHandle calendar, out uint year, out uint month, out uint day);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_calendar_get_day_is_marked([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCalendarHandle>))] MentorLake.Gtk.GtkCalendarHandle calendar, uint day);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_calendar_get_detail_height_rows([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCalendarHandle>))] MentorLake.Gtk.GtkCalendarHandle calendar);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_calendar_get_detail_width_chars([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCalendarHandle>))] MentorLake.Gtk.GtkCalendarHandle calendar);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkCalendarDisplayOptions gtk_calendar_get_display_options([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCalendarHandle>))] MentorLake.Gtk.GtkCalendarHandle calendar);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_calendar_mark_day([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCalendarHandle>))] MentorLake.Gtk.GtkCalendarHandle calendar, uint day);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_calendar_select_day([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCalendarHandle>))] MentorLake.Gtk.GtkCalendarHandle calendar, uint day);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_calendar_select_month([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCalendarHandle>))] MentorLake.Gtk.GtkCalendarHandle calendar, uint month, uint year);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_calendar_set_detail_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCalendarHandle>))] MentorLake.Gtk.GtkCalendarHandle calendar, MentorLake.Gtk.GtkCalendarDetailFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_calendar_set_detail_height_rows([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCalendarHandle>))] MentorLake.Gtk.GtkCalendarHandle calendar, int rows);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_calendar_set_detail_width_chars([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCalendarHandle>))] MentorLake.Gtk.GtkCalendarHandle calendar, int chars);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_calendar_set_display_options([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCalendarHandle>))] MentorLake.Gtk.GtkCalendarHandle calendar, MentorLake.Gtk.GtkCalendarDisplayOptions flags);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_calendar_unmark_day([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCalendarHandle>))] MentorLake.Gtk.GtkCalendarHandle calendar, uint day);

}
