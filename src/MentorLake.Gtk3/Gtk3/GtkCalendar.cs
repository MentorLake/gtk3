namespace MentorLake.Gtk3.Gtk3;

public class GtkCalendarHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkCalendarHandle New()
	{
		return GtkCalendarExterns.gtk_calendar_new();
	}

}

public static class GtkCalendarSignalExtensions
{

	public static IObservable<GtkCalendarSignalStructs.DaySelectedSignal> Signal_DaySelected(this GtkCalendarHandle instance)
	{
		return Observable.Create((IObserver<GtkCalendarSignalStructs.DaySelectedSignal> obs) =>
		{
			GtkCalendarSignalDelegates.day_selected handler = (GtkCalendarHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCalendarSignalStructs.DaySelectedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "day_selected", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkCalendarSignalStructs.DaySelectedDoubleClickSignal> Signal_DaySelectedDoubleClick(this GtkCalendarHandle instance)
	{
		return Observable.Create((IObserver<GtkCalendarSignalStructs.DaySelectedDoubleClickSignal> obs) =>
		{
			GtkCalendarSignalDelegates.day_selected_double_click handler = (GtkCalendarHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCalendarSignalStructs.DaySelectedDoubleClickSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "day_selected_double_click", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkCalendarSignalStructs.MonthChangedSignal> Signal_MonthChanged(this GtkCalendarHandle instance)
	{
		return Observable.Create((IObserver<GtkCalendarSignalStructs.MonthChangedSignal> obs) =>
		{
			GtkCalendarSignalDelegates.month_changed handler = (GtkCalendarHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCalendarSignalStructs.MonthChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "month_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkCalendarSignalStructs.NextMonthSignal> Signal_NextMonth(this GtkCalendarHandle instance)
	{
		return Observable.Create((IObserver<GtkCalendarSignalStructs.NextMonthSignal> obs) =>
		{
			GtkCalendarSignalDelegates.next_month handler = (GtkCalendarHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCalendarSignalStructs.NextMonthSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "next_month", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkCalendarSignalStructs.NextYearSignal> Signal_NextYear(this GtkCalendarHandle instance)
	{
		return Observable.Create((IObserver<GtkCalendarSignalStructs.NextYearSignal> obs) =>
		{
			GtkCalendarSignalDelegates.next_year handler = (GtkCalendarHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCalendarSignalStructs.NextYearSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "next_year", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkCalendarSignalStructs.PrevMonthSignal> Signal_PrevMonth(this GtkCalendarHandle instance)
	{
		return Observable.Create((IObserver<GtkCalendarSignalStructs.PrevMonthSignal> obs) =>
		{
			GtkCalendarSignalDelegates.prev_month handler = (GtkCalendarHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCalendarSignalStructs.PrevMonthSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "prev_month", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkCalendarSignalStructs.PrevYearSignal> Signal_PrevYear(this GtkCalendarHandle instance)
	{
		return Observable.Create((IObserver<GtkCalendarSignalStructs.PrevYearSignal> obs) =>
		{
			GtkCalendarSignalDelegates.prev_year handler = (GtkCalendarHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCalendarSignalStructs.PrevYearSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "prev_year", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkCalendarSignalStructs
{

public struct DaySelectedSignal
{
	public GtkCalendarHandle Self;
	public IntPtr UserData;
}

public struct DaySelectedDoubleClickSignal
{
	public GtkCalendarHandle Self;
	public IntPtr UserData;
}

public struct MonthChangedSignal
{
	public GtkCalendarHandle Self;
	public IntPtr UserData;
}

public struct NextMonthSignal
{
	public GtkCalendarHandle Self;
	public IntPtr UserData;
}

public struct NextYearSignal
{
	public GtkCalendarHandle Self;
	public IntPtr UserData;
}

public struct PrevMonthSignal
{
	public GtkCalendarHandle Self;
	public IntPtr UserData;
}

public struct PrevYearSignal
{
	public GtkCalendarHandle Self;
	public IntPtr UserData;
}
}

public static class GtkCalendarSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void day_selected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCalendarHandle>))] GtkCalendarHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void day_selected_double_click([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCalendarHandle>))] GtkCalendarHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void month_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCalendarHandle>))] GtkCalendarHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void next_month([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCalendarHandle>))] GtkCalendarHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void next_year([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCalendarHandle>))] GtkCalendarHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void prev_month([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCalendarHandle>))] GtkCalendarHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void prev_year([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCalendarHandle>))] GtkCalendarHandle self, IntPtr user_data);

}


public static class GtkCalendarHandleExtensions
{
	public static GtkCalendarHandle ClearMarks(this GtkCalendarHandle calendar)
	{
		GtkCalendarExterns.gtk_calendar_clear_marks(calendar);
		return calendar;
	}

	public static GtkCalendarHandle GetDate(this GtkCalendarHandle calendar, out uint year, out uint month, out uint day)
	{
		GtkCalendarExterns.gtk_calendar_get_date(calendar, out year, out month, out day);
		return calendar;
	}

	public static bool GetDayIsMarked(this GtkCalendarHandle calendar, uint day)
	{
		return GtkCalendarExterns.gtk_calendar_get_day_is_marked(calendar, day);
	}

	public static int GetDetailHeightRows(this GtkCalendarHandle calendar)
	{
		return GtkCalendarExterns.gtk_calendar_get_detail_height_rows(calendar);
	}

	public static int GetDetailWidthChars(this GtkCalendarHandle calendar)
	{
		return GtkCalendarExterns.gtk_calendar_get_detail_width_chars(calendar);
	}

	public static GtkCalendarDisplayOptions GetDisplayOptions(this GtkCalendarHandle calendar)
	{
		return GtkCalendarExterns.gtk_calendar_get_display_options(calendar);
	}

	public static GtkCalendarHandle MarkDay(this GtkCalendarHandle calendar, uint day)
	{
		GtkCalendarExterns.gtk_calendar_mark_day(calendar, day);
		return calendar;
	}

	public static GtkCalendarHandle SelectDay(this GtkCalendarHandle calendar, uint day)
	{
		GtkCalendarExterns.gtk_calendar_select_day(calendar, day);
		return calendar;
	}

	public static GtkCalendarHandle SelectMonth(this GtkCalendarHandle calendar, uint month, uint year)
	{
		GtkCalendarExterns.gtk_calendar_select_month(calendar, month, year);
		return calendar;
	}

	public static GtkCalendarHandle SetDetailFunc(this GtkCalendarHandle calendar, GtkCalendarDetailFunc func, IntPtr data, GDestroyNotify destroy)
	{
		GtkCalendarExterns.gtk_calendar_set_detail_func(calendar, func, data, destroy);
		return calendar;
	}

	public static GtkCalendarHandle SetDetailHeightRows(this GtkCalendarHandle calendar, int rows)
	{
		GtkCalendarExterns.gtk_calendar_set_detail_height_rows(calendar, rows);
		return calendar;
	}

	public static GtkCalendarHandle SetDetailWidthChars(this GtkCalendarHandle calendar, int chars)
	{
		GtkCalendarExterns.gtk_calendar_set_detail_width_chars(calendar, chars);
		return calendar;
	}

	public static GtkCalendarHandle SetDisplayOptions(this GtkCalendarHandle calendar, GtkCalendarDisplayOptions flags)
	{
		GtkCalendarExterns.gtk_calendar_set_display_options(calendar, flags);
		return calendar;
	}

	public static GtkCalendarHandle UnmarkDay(this GtkCalendarHandle calendar, uint day)
	{
		GtkCalendarExterns.gtk_calendar_unmark_day(calendar, day);
		return calendar;
	}

}

internal class GtkCalendarExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkCalendarHandle gtk_calendar_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_calendar_clear_marks(GtkCalendarHandle calendar);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_calendar_get_date(GtkCalendarHandle calendar, out uint year, out uint month, out uint day);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_calendar_get_day_is_marked(GtkCalendarHandle calendar, uint day);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_calendar_get_detail_height_rows(GtkCalendarHandle calendar);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_calendar_get_detail_width_chars(GtkCalendarHandle calendar);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkCalendarDisplayOptions gtk_calendar_get_display_options(GtkCalendarHandle calendar);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_calendar_mark_day(GtkCalendarHandle calendar, uint day);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_calendar_select_day(GtkCalendarHandle calendar, uint day);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_calendar_select_month(GtkCalendarHandle calendar, uint month, uint year);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_calendar_set_detail_func(GtkCalendarHandle calendar, GtkCalendarDetailFunc func, IntPtr data, GDestroyNotify destroy);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_calendar_set_detail_height_rows(GtkCalendarHandle calendar, int rows);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_calendar_set_detail_width_chars(GtkCalendarHandle calendar, int chars);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_calendar_set_display_options(GtkCalendarHandle calendar, GtkCalendarDisplayOptions flags);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_calendar_unmark_day(GtkCalendarHandle calendar, uint day);

}
