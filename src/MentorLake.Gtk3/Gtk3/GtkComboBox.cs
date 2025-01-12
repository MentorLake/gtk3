namespace MentorLake.Gtk3.Gtk3;

public class GtkComboBoxHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkCellEditableHandle, GtkCellLayoutHandle
{
	public static GtkComboBoxHandle New()
	{
		return GtkComboBoxExterns.gtk_combo_box_new();
	}

	public static GtkComboBoxHandle NewWithArea(GtkCellAreaHandle area)
	{
		return GtkComboBoxExterns.gtk_combo_box_new_with_area(area);
	}

	public static GtkComboBoxHandle NewWithAreaAndEntry(GtkCellAreaHandle area)
	{
		return GtkComboBoxExterns.gtk_combo_box_new_with_area_and_entry(area);
	}

	public static GtkComboBoxHandle NewWithEntry()
	{
		return GtkComboBoxExterns.gtk_combo_box_new_with_entry();
	}

	public static GtkComboBoxHandle NewWithModel(GtkTreeModelHandle model)
	{
		return GtkComboBoxExterns.gtk_combo_box_new_with_model(model);
	}

	public static GtkComboBoxHandle NewWithModelAndEntry(GtkTreeModelHandle model)
	{
		return GtkComboBoxExterns.gtk_combo_box_new_with_model_and_entry(model);
	}

}

public static class GtkComboBoxSignalExtensions
{

	public static IObservable<GtkComboBoxSignalStructs.ChangedSignal> Signal_Changed(this GtkComboBoxHandle instance)
	{
		return Observable.Create((IObserver<GtkComboBoxSignalStructs.ChangedSignal> obs) =>
		{
			GtkComboBoxSignalDelegates.changed handler = (GtkComboBoxHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkComboBoxSignalStructs.ChangedSignal()
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

	public static IObservable<GtkComboBoxSignalStructs.FormatEntryTextSignal> Signal_FormatEntryText(this GtkComboBoxHandle instance)
	{
		return Observable.Create((IObserver<GtkComboBoxSignalStructs.FormatEntryTextSignal> obs) =>
		{
			GtkComboBoxSignalDelegates.format_entry_text handler = (GtkComboBoxHandle self, string path, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkComboBoxSignalStructs.FormatEntryTextSignal()
				{
					Self = self, Path = path, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "format_entry_text", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkComboBoxSignalStructs.MoveActiveSignal> Signal_MoveActive(this GtkComboBoxHandle instance)
	{
		return Observable.Create((IObserver<GtkComboBoxSignalStructs.MoveActiveSignal> obs) =>
		{
			GtkComboBoxSignalDelegates.move_active handler = (GtkComboBoxHandle self, ref GtkScrollType scroll_type, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkComboBoxSignalStructs.MoveActiveSignal()
				{
					Self = self, ScrollType = scroll_type, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "move_active", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkComboBoxSignalStructs.PopdownSignal> Signal_Popdown(this GtkComboBoxHandle instance)
	{
		return Observable.Create((IObserver<GtkComboBoxSignalStructs.PopdownSignal> obs) =>
		{
			GtkComboBoxSignalDelegates.popdown handler = (GtkComboBoxHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkComboBoxSignalStructs.PopdownSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "popdown", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkComboBoxSignalStructs.PopupSignal> Signal_Popup(this GtkComboBoxHandle instance)
	{
		return Observable.Create((IObserver<GtkComboBoxSignalStructs.PopupSignal> obs) =>
		{
			GtkComboBoxSignalDelegates.popup handler = (GtkComboBoxHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkComboBoxSignalStructs.PopupSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "popup", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkComboBoxSignalStructs
{

public struct ChangedSignal
{
	public GtkComboBoxHandle Self;
	public IntPtr UserData;
}

public struct FormatEntryTextSignal
{
	public GtkComboBoxHandle Self;
	public string Path;
	public IntPtr UserData;
	public string ReturnValue;
}

public struct MoveActiveSignal
{
	public GtkComboBoxHandle Self;
	public GtkScrollType ScrollType;
	public IntPtr UserData;
}

public struct PopdownSignal
{
	public GtkComboBoxHandle Self;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct PopupSignal
{
	public GtkComboBoxHandle Self;
	public IntPtr UserData;
}
}

public static class GtkComboBoxSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkComboBoxHandle>))] GtkComboBoxHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate string format_entry_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkComboBoxHandle>))] GtkComboBoxHandle self, string path, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void move_active([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkComboBoxHandle>))] GtkComboBoxHandle self, ref GtkScrollType scroll_type, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool popdown([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkComboBoxHandle>))] GtkComboBoxHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void popup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkComboBoxHandle>))] GtkComboBoxHandle self, IntPtr user_data);

}


public static class GtkComboBoxHandleExtensions
{
	public static int GetActive(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_active(combo_box);
	}

	public static string GetActiveId(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_active_id(combo_box);
	}

	public static bool GetActiveIter(this GtkComboBoxHandle combo_box, out GtkTreeIter iter)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_active_iter(combo_box, out iter);
	}

	public static bool GetAddTearoffs(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_add_tearoffs(combo_box);
	}

	public static GtkSensitivityType GetButtonSensitivity(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_button_sensitivity(combo_box);
	}

	public static int GetColumnSpanColumn(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_column_span_column(combo_box);
	}

	public static int GetEntryTextColumn(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_entry_text_column(combo_box);
	}

	public static bool GetFocusOnClick(this GtkComboBoxHandle combo)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_focus_on_click(combo);
	}

	public static bool GetHasEntry(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_has_entry(combo_box);
	}

	public static int GetIdColumn(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_id_column(combo_box);
	}

	public static GtkTreeModelHandle GetModel(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_model(combo_box);
	}

	public static AtkObjectHandle GetPopupAccessible(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_popup_accessible(combo_box);
	}

	public static bool GetPopupFixedWidth(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_popup_fixed_width(combo_box);
	}

	public static GtkTreeViewRowSeparatorFunc GetRowSeparatorFunc(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_row_separator_func(combo_box);
	}

	public static int GetRowSpanColumn(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_row_span_column(combo_box);
	}

	public static string GetTitle(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_title(combo_box);
	}

	public static int GetWrapWidth(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_wrap_width(combo_box);
	}

	public static T Popdown<T>(this T combo_box) where T : GtkComboBoxHandle
	{
		GtkComboBoxExterns.gtk_combo_box_popdown(combo_box);
		return combo_box;
	}

	public static T Popup<T>(this T combo_box) where T : GtkComboBoxHandle
	{
		GtkComboBoxExterns.gtk_combo_box_popup(combo_box);
		return combo_box;
	}

	public static T PopupForDevice<T>(this T combo_box, GdkDeviceHandle device) where T : GtkComboBoxHandle
	{
		GtkComboBoxExterns.gtk_combo_box_popup_for_device(combo_box, device);
		return combo_box;
	}

	public static T SetActive<T>(this T combo_box, int index_) where T : GtkComboBoxHandle
	{
		GtkComboBoxExterns.gtk_combo_box_set_active(combo_box, index_);
		return combo_box;
	}

	public static bool SetActiveId(this GtkComboBoxHandle combo_box, string active_id)
	{
		return GtkComboBoxExterns.gtk_combo_box_set_active_id(combo_box, active_id);
	}

	public static T SetActiveIter<T>(this T combo_box, GtkTreeIterHandle iter) where T : GtkComboBoxHandle
	{
		GtkComboBoxExterns.gtk_combo_box_set_active_iter(combo_box, iter);
		return combo_box;
	}

	public static T SetAddTearoffs<T>(this T combo_box, bool add_tearoffs) where T : GtkComboBoxHandle
	{
		GtkComboBoxExterns.gtk_combo_box_set_add_tearoffs(combo_box, add_tearoffs);
		return combo_box;
	}

	public static T SetButtonSensitivity<T>(this T combo_box, GtkSensitivityType sensitivity) where T : GtkComboBoxHandle
	{
		GtkComboBoxExterns.gtk_combo_box_set_button_sensitivity(combo_box, sensitivity);
		return combo_box;
	}

	public static T SetColumnSpanColumn<T>(this T combo_box, int column_span) where T : GtkComboBoxHandle
	{
		GtkComboBoxExterns.gtk_combo_box_set_column_span_column(combo_box, column_span);
		return combo_box;
	}

	public static T SetEntryTextColumn<T>(this T combo_box, int text_column) where T : GtkComboBoxHandle
	{
		GtkComboBoxExterns.gtk_combo_box_set_entry_text_column(combo_box, text_column);
		return combo_box;
	}

	public static T SetFocusOnClick<T>(this T combo, bool focus_on_click) where T : GtkComboBoxHandle
	{
		GtkComboBoxExterns.gtk_combo_box_set_focus_on_click(combo, focus_on_click);
		return combo;
	}

	public static T SetIdColumn<T>(this T combo_box, int id_column) where T : GtkComboBoxHandle
	{
		GtkComboBoxExterns.gtk_combo_box_set_id_column(combo_box, id_column);
		return combo_box;
	}

	public static T SetModel<T>(this T combo_box, GtkTreeModelHandle model) where T : GtkComboBoxHandle
	{
		GtkComboBoxExterns.gtk_combo_box_set_model(combo_box, model);
		return combo_box;
	}

	public static T SetPopupFixedWidth<T>(this T combo_box, bool @fixed) where T : GtkComboBoxHandle
	{
		GtkComboBoxExterns.gtk_combo_box_set_popup_fixed_width(combo_box, @fixed);
		return combo_box;
	}

	public static T SetRowSeparatorFunc<T>(this T combo_box, GtkTreeViewRowSeparatorFunc func, IntPtr data, GDestroyNotify destroy) where T : GtkComboBoxHandle
	{
		GtkComboBoxExterns.gtk_combo_box_set_row_separator_func(combo_box, func, data, destroy);
		return combo_box;
	}

	public static T SetRowSpanColumn<T>(this T combo_box, int row_span) where T : GtkComboBoxHandle
	{
		GtkComboBoxExterns.gtk_combo_box_set_row_span_column(combo_box, row_span);
		return combo_box;
	}

	public static T SetTitle<T>(this T combo_box, string title) where T : GtkComboBoxHandle
	{
		GtkComboBoxExterns.gtk_combo_box_set_title(combo_box, title);
		return combo_box;
	}

	public static T SetWrapWidth<T>(this T combo_box, int width) where T : GtkComboBoxHandle
	{
		GtkComboBoxExterns.gtk_combo_box_set_wrap_width(combo_box, width);
		return combo_box;
	}

}

internal class GtkComboBoxExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkComboBoxHandle gtk_combo_box_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkComboBoxHandle gtk_combo_box_new_with_area(GtkCellAreaHandle area);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkComboBoxHandle gtk_combo_box_new_with_area_and_entry(GtkCellAreaHandle area);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkComboBoxHandle gtk_combo_box_new_with_entry();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkComboBoxHandle gtk_combo_box_new_with_model(GtkTreeModelHandle model);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkComboBoxHandle gtk_combo_box_new_with_model_and_entry(GtkTreeModelHandle model);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_combo_box_get_active(GtkComboBoxHandle combo_box);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_combo_box_get_active_id(GtkComboBoxHandle combo_box);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_combo_box_get_active_iter(GtkComboBoxHandle combo_box, out GtkTreeIter iter);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_combo_box_get_add_tearoffs(GtkComboBoxHandle combo_box);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkSensitivityType gtk_combo_box_get_button_sensitivity(GtkComboBoxHandle combo_box);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_combo_box_get_column_span_column(GtkComboBoxHandle combo_box);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_combo_box_get_entry_text_column(GtkComboBoxHandle combo_box);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_combo_box_get_focus_on_click(GtkComboBoxHandle combo);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_combo_box_get_has_entry(GtkComboBoxHandle combo_box);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_combo_box_get_id_column(GtkComboBoxHandle combo_box);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTreeModelHandle gtk_combo_box_get_model(GtkComboBoxHandle combo_box);

	[DllImport(Libraries.Gtk3)]
	internal static extern AtkObjectHandle gtk_combo_box_get_popup_accessible(GtkComboBoxHandle combo_box);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_combo_box_get_popup_fixed_width(GtkComboBoxHandle combo_box);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTreeViewRowSeparatorFunc gtk_combo_box_get_row_separator_func(GtkComboBoxHandle combo_box);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_combo_box_get_row_span_column(GtkComboBoxHandle combo_box);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_combo_box_get_title(GtkComboBoxHandle combo_box);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_combo_box_get_wrap_width(GtkComboBoxHandle combo_box);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_combo_box_popdown(GtkComboBoxHandle combo_box);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_combo_box_popup(GtkComboBoxHandle combo_box);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_combo_box_popup_for_device(GtkComboBoxHandle combo_box, GdkDeviceHandle device);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_combo_box_set_active(GtkComboBoxHandle combo_box, int index_);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_combo_box_set_active_id(GtkComboBoxHandle combo_box, string active_id);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_combo_box_set_active_iter(GtkComboBoxHandle combo_box, GtkTreeIterHandle iter);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_combo_box_set_add_tearoffs(GtkComboBoxHandle combo_box, bool add_tearoffs);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_combo_box_set_button_sensitivity(GtkComboBoxHandle combo_box, GtkSensitivityType sensitivity);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_combo_box_set_column_span_column(GtkComboBoxHandle combo_box, int column_span);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_combo_box_set_entry_text_column(GtkComboBoxHandle combo_box, int text_column);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_combo_box_set_focus_on_click(GtkComboBoxHandle combo, bool focus_on_click);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_combo_box_set_id_column(GtkComboBoxHandle combo_box, int id_column);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_combo_box_set_model(GtkComboBoxHandle combo_box, GtkTreeModelHandle model);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_combo_box_set_popup_fixed_width(GtkComboBoxHandle combo_box, bool @fixed);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_combo_box_set_row_separator_func(GtkComboBoxHandle combo_box, GtkTreeViewRowSeparatorFunc func, IntPtr data, GDestroyNotify destroy);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_combo_box_set_row_span_column(GtkComboBoxHandle combo_box, int row_span);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_combo_box_set_title(GtkComboBoxHandle combo_box, string title);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_combo_box_set_wrap_width(GtkComboBoxHandle combo_box, int width);

}
