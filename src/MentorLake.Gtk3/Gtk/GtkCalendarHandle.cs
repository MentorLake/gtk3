namespace MentorLake.Gtk;

public class GtkCalendarHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkCalendarHandle New()
	{
		return GtkCalendarHandleExterns.gtk_calendar_new();
	}

}
public static class GtkCalendarHandleSignalExtensions
{

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

public struct DaySelectedSignal
{
	public MentorLake.Gtk.GtkCalendarHandle Self;
	public IntPtr UserData;
}

public struct DaySelectedDoubleClickSignal
{
	public MentorLake.Gtk.GtkCalendarHandle Self;
	public IntPtr UserData;
}

public struct MonthChangedSignal
{
	public MentorLake.Gtk.GtkCalendarHandle Self;
	public IntPtr UserData;
}

public struct NextMonthSignal
{
	public MentorLake.Gtk.GtkCalendarHandle Self;
	public IntPtr UserData;
}

public struct NextYearSignal
{
	public MentorLake.Gtk.GtkCalendarHandle Self;
	public IntPtr UserData;
}

public struct PrevMonthSignal
{
	public MentorLake.Gtk.GtkCalendarHandle Self;
	public IntPtr UserData;
}

public struct PrevYearSignal
{
	public MentorLake.Gtk.GtkCalendarHandle Self;
	public IntPtr UserData;
}
}

public static class GtkCalendarHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void day_selected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCalendarHandle>))] MentorLake.Gtk.GtkCalendarHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void day_selected_double_click([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCalendarHandle>))] MentorLake.Gtk.GtkCalendarHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void month_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCalendarHandle>))] MentorLake.Gtk.GtkCalendarHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void next_month([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCalendarHandle>))] MentorLake.Gtk.GtkCalendarHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void next_year([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCalendarHandle>))] MentorLake.Gtk.GtkCalendarHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void prev_month([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCalendarHandle>))] MentorLake.Gtk.GtkCalendarHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void prev_year([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCalendarHandle>))] MentorLake.Gtk.GtkCalendarHandle self, IntPtr user_data);

}


public static class GtkCalendarHandleExtensions
{
	public static T ClearMarks<T>(this T calendar) where T : GtkCalendarHandle
	{
		if (calendar.IsInvalid || calendar.IsClosed) throw new Exception("Invalid or closed handle (GtkCalendarHandle)");
		GtkCalendarHandleExterns.gtk_calendar_clear_marks(calendar);
		return calendar;
	}

	public static T GetDate<T>(this T calendar, out uint year, out uint month, out uint day) where T : GtkCalendarHandle
	{
		if (calendar.IsInvalid || calendar.IsClosed) throw new Exception("Invalid or closed handle (GtkCalendarHandle)");
		GtkCalendarHandleExterns.gtk_calendar_get_date(calendar, out year, out month, out day);
		return calendar;
	}

	public static bool GetDayIsMarked(this MentorLake.Gtk.GtkCalendarHandle calendar, uint day)
	{
		if (calendar.IsInvalid || calendar.IsClosed) throw new Exception("Invalid or closed handle (GtkCalendarHandle)");
		return GtkCalendarHandleExterns.gtk_calendar_get_day_is_marked(calendar, day);
	}

	public static int GetDetailHeightRows(this MentorLake.Gtk.GtkCalendarHandle calendar)
	{
		if (calendar.IsInvalid || calendar.IsClosed) throw new Exception("Invalid or closed handle (GtkCalendarHandle)");
		return GtkCalendarHandleExterns.gtk_calendar_get_detail_height_rows(calendar);
	}

	public static int GetDetailWidthChars(this MentorLake.Gtk.GtkCalendarHandle calendar)
	{
		if (calendar.IsInvalid || calendar.IsClosed) throw new Exception("Invalid or closed handle (GtkCalendarHandle)");
		return GtkCalendarHandleExterns.gtk_calendar_get_detail_width_chars(calendar);
	}

	public static MentorLake.Gtk.GtkCalendarDisplayOptions GetDisplayOptions(this MentorLake.Gtk.GtkCalendarHandle calendar)
	{
		if (calendar.IsInvalid || calendar.IsClosed) throw new Exception("Invalid or closed handle (GtkCalendarHandle)");
		return GtkCalendarHandleExterns.gtk_calendar_get_display_options(calendar);
	}

	public static T MarkDay<T>(this T calendar, uint day) where T : GtkCalendarHandle
	{
		if (calendar.IsInvalid || calendar.IsClosed) throw new Exception("Invalid or closed handle (GtkCalendarHandle)");
		GtkCalendarHandleExterns.gtk_calendar_mark_day(calendar, day);
		return calendar;
	}

	public static T SelectDay<T>(this T calendar, uint day) where T : GtkCalendarHandle
	{
		if (calendar.IsInvalid || calendar.IsClosed) throw new Exception("Invalid or closed handle (GtkCalendarHandle)");
		GtkCalendarHandleExterns.gtk_calendar_select_day(calendar, day);
		return calendar;
	}

	public static T SelectMonth<T>(this T calendar, uint month, uint year) where T : GtkCalendarHandle
	{
		if (calendar.IsInvalid || calendar.IsClosed) throw new Exception("Invalid or closed handle (GtkCalendarHandle)");
		GtkCalendarHandleExterns.gtk_calendar_select_month(calendar, month, year);
		return calendar;
	}

	public static T SetDetailFunc<T>(this T calendar, MentorLake.Gtk.GtkCalendarDetailFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkCalendarHandle
	{
		if (calendar.IsInvalid || calendar.IsClosed) throw new Exception("Invalid or closed handle (GtkCalendarHandle)");
		GtkCalendarHandleExterns.gtk_calendar_set_detail_func(calendar, func, data, destroy);
		return calendar;
	}

	public static T SetDetailHeightRows<T>(this T calendar, int rows) where T : GtkCalendarHandle
	{
		if (calendar.IsInvalid || calendar.IsClosed) throw new Exception("Invalid or closed handle (GtkCalendarHandle)");
		GtkCalendarHandleExterns.gtk_calendar_set_detail_height_rows(calendar, rows);
		return calendar;
	}

	public static T SetDetailWidthChars<T>(this T calendar, int chars) where T : GtkCalendarHandle
	{
		if (calendar.IsInvalid || calendar.IsClosed) throw new Exception("Invalid or closed handle (GtkCalendarHandle)");
		GtkCalendarHandleExterns.gtk_calendar_set_detail_width_chars(calendar, chars);
		return calendar;
	}

	public static T SetDisplayOptions<T>(this T calendar, MentorLake.Gtk.GtkCalendarDisplayOptions flags) where T : GtkCalendarHandle
	{
		if (calendar.IsInvalid || calendar.IsClosed) throw new Exception("Invalid or closed handle (GtkCalendarHandle)");
		GtkCalendarHandleExterns.gtk_calendar_set_display_options(calendar, flags);
		return calendar;
	}

	public static T UnmarkDay<T>(this T calendar, uint day) where T : GtkCalendarHandle
	{
		if (calendar.IsInvalid || calendar.IsClosed) throw new Exception("Invalid or closed handle (GtkCalendarHandle)");
		GtkCalendarHandleExterns.gtk_calendar_unmark_day(calendar, day);
		return calendar;
	}

}

internal class GtkCalendarHandleExterns
{
	[DllImport(GtkLibrary.Name)]
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
