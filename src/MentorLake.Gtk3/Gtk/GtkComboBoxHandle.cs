namespace MentorLake.Gtk;

public class GtkComboBoxHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkCellEditableHandle, GtkCellLayoutHandle
{
	public static MentorLake.Gtk.GtkComboBoxHandle New()
	{
		return GtkComboBoxHandleExterns.gtk_combo_box_new();
	}

	public static MentorLake.Gtk.GtkComboBoxHandle NewWithArea(MentorLake.Gtk.GtkCellAreaHandle area)
	{
		return GtkComboBoxHandleExterns.gtk_combo_box_new_with_area(area);
	}

	public static MentorLake.Gtk.GtkComboBoxHandle NewWithAreaAndEntry(MentorLake.Gtk.GtkCellAreaHandle area)
	{
		return GtkComboBoxHandleExterns.gtk_combo_box_new_with_area_and_entry(area);
	}

	public static MentorLake.Gtk.GtkComboBoxHandle NewWithEntry()
	{
		return GtkComboBoxHandleExterns.gtk_combo_box_new_with_entry();
	}

	public static MentorLake.Gtk.GtkComboBoxHandle NewWithModel(MentorLake.Gtk.GtkTreeModelHandle model)
	{
		return GtkComboBoxHandleExterns.gtk_combo_box_new_with_model(model);
	}

	public static MentorLake.Gtk.GtkComboBoxHandle NewWithModelAndEntry(MentorLake.Gtk.GtkTreeModelHandle model)
	{
		return GtkComboBoxHandleExterns.gtk_combo_box_new_with_model_and_entry(model);
	}

}
public static class GtkComboBoxHandleSignalExtensions
{

	public static IObservable<GtkComboBoxHandleSignalStructs.ChangedSignal> Signal_Changed(this GtkComboBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkComboBoxHandleSignalStructs.ChangedSignal> obs) =>
		{
			GtkComboBoxHandleSignalDelegates.changed handler = ( MentorLake.Gtk.GtkComboBoxHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkComboBoxHandleSignalStructs.ChangedSignal()
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

	public static IObservable<GtkComboBoxHandleSignalStructs.FormatEntryTextSignal> Signal_FormatEntryText(this GtkComboBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkComboBoxHandleSignalStructs.FormatEntryTextSignal> obs) =>
		{
			GtkComboBoxHandleSignalDelegates.format_entry_text handler = ( MentorLake.Gtk.GtkComboBoxHandle self,  string path,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkComboBoxHandleSignalStructs.FormatEntryTextSignal()
				{
					Self = self, Path = path, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "format-entry-text", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkComboBoxHandleSignalStructs.MoveActiveSignal> Signal_MoveActive(this GtkComboBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkComboBoxHandleSignalStructs.MoveActiveSignal> obs) =>
		{
			GtkComboBoxHandleSignalDelegates.move_active handler = ( MentorLake.Gtk.GtkComboBoxHandle self,  MentorLake.Gtk.GtkScrollType scroll_type,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkComboBoxHandleSignalStructs.MoveActiveSignal()
				{
					Self = self, ScrollType = scroll_type, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "move-active", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkComboBoxHandleSignalStructs.PopdownSignal> Signal_Popdown(this GtkComboBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkComboBoxHandleSignalStructs.PopdownSignal> obs) =>
		{
			GtkComboBoxHandleSignalDelegates.popdown handler = ( MentorLake.Gtk.GtkComboBoxHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkComboBoxHandleSignalStructs.PopdownSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
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

	public static IObservable<GtkComboBoxHandleSignalStructs.PopupSignal> Signal_Popup(this GtkComboBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkComboBoxHandleSignalStructs.PopupSignal> obs) =>
		{
			GtkComboBoxHandleSignalDelegates.popup handler = ( MentorLake.Gtk.GtkComboBoxHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkComboBoxHandleSignalStructs.PopupSignal()
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

	public static IObservable<GtkComboBoxHandleSignalStructs.EditingDoneSignal> Signal_EditingDone(this GtkComboBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkComboBoxHandleSignalStructs.EditingDoneSignal> obs) =>
		{
			GtkComboBoxHandleSignalDelegates.editing_done handler = ( MentorLake.Gtk.GtkCellEditableHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkComboBoxHandleSignalStructs.EditingDoneSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "editing-done", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkComboBoxHandleSignalStructs.RemoveWidgetSignal> Signal_RemoveWidget(this GtkComboBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkComboBoxHandleSignalStructs.RemoveWidgetSignal> obs) =>
		{
			GtkComboBoxHandleSignalDelegates.remove_widget handler = ( MentorLake.Gtk.GtkCellEditableHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkComboBoxHandleSignalStructs.RemoveWidgetSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "remove-widget", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkComboBoxHandleSignalStructs
{

public class ChangedSignal
{
	public MentorLake.Gtk.GtkComboBoxHandle Self;
	public IntPtr UserData;
}

public class FormatEntryTextSignal
{
	public MentorLake.Gtk.GtkComboBoxHandle Self;
	public string Path;
	public IntPtr UserData;
	public string ReturnValue;
}

public class MoveActiveSignal
{
	public MentorLake.Gtk.GtkComboBoxHandle Self;
	public MentorLake.Gtk.GtkScrollType ScrollType;
	public IntPtr UserData;
}

public class PopdownSignal
{
	public MentorLake.Gtk.GtkComboBoxHandle Self;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class PopupSignal
{
	public MentorLake.Gtk.GtkComboBoxHandle Self;
	public IntPtr UserData;
}

public class EditingDoneSignal
{
	public MentorLake.Gtk.GtkCellEditableHandle Self;
	public IntPtr UserData;
}

public class RemoveWidgetSignal
{
	public MentorLake.Gtk.GtkCellEditableHandle Self;
	public IntPtr UserData;
}
}

public static class GtkComboBoxHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate string format_entry_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle self, string path, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void move_active([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle self, MentorLake.Gtk.GtkScrollType scroll_type, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool popdown([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void popup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void editing_done([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellEditableHandleImpl>))] MentorLake.Gtk.GtkCellEditableHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void remove_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellEditableHandleImpl>))] MentorLake.Gtk.GtkCellEditableHandle self, IntPtr user_data);

}


public static class GtkComboBoxHandleExtensions
{
	public static int GetActive(this MentorLake.Gtk.GtkComboBoxHandle combo_box)
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxHandle)");
		return GtkComboBoxHandleExterns.gtk_combo_box_get_active(combo_box);
	}

	public static string GetActiveId(this MentorLake.Gtk.GtkComboBoxHandle combo_box)
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxHandle)");
		return GtkComboBoxHandleExterns.gtk_combo_box_get_active_id(combo_box);
	}

	public static bool GetActiveIter(this MentorLake.Gtk.GtkComboBoxHandle combo_box, out MentorLake.Gtk.GtkTreeIter iter)
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxHandle)");
		return GtkComboBoxHandleExterns.gtk_combo_box_get_active_iter(combo_box, out iter);
	}

	public static bool GetAddTearoffs(this MentorLake.Gtk.GtkComboBoxHandle combo_box)
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxHandle)");
		return GtkComboBoxHandleExterns.gtk_combo_box_get_add_tearoffs(combo_box);
	}

	public static MentorLake.Gtk.GtkSensitivityType GetButtonSensitivity(this MentorLake.Gtk.GtkComboBoxHandle combo_box)
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxHandle)");
		return GtkComboBoxHandleExterns.gtk_combo_box_get_button_sensitivity(combo_box);
	}

	public static int GetColumnSpanColumn(this MentorLake.Gtk.GtkComboBoxHandle combo_box)
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxHandle)");
		return GtkComboBoxHandleExterns.gtk_combo_box_get_column_span_column(combo_box);
	}

	public static int GetEntryTextColumn(this MentorLake.Gtk.GtkComboBoxHandle combo_box)
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxHandle)");
		return GtkComboBoxHandleExterns.gtk_combo_box_get_entry_text_column(combo_box);
	}

	public static bool GetFocusOnClick(this MentorLake.Gtk.GtkComboBoxHandle combo)
	{
		if (combo.IsInvalid || combo.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxHandle)");
		return GtkComboBoxHandleExterns.gtk_combo_box_get_focus_on_click(combo);
	}

	public static bool GetHasEntry(this MentorLake.Gtk.GtkComboBoxHandle combo_box)
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxHandle)");
		return GtkComboBoxHandleExterns.gtk_combo_box_get_has_entry(combo_box);
	}

	public static int GetIdColumn(this MentorLake.Gtk.GtkComboBoxHandle combo_box)
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxHandle)");
		return GtkComboBoxHandleExterns.gtk_combo_box_get_id_column(combo_box);
	}

	public static MentorLake.Gtk.GtkTreeModelHandle GetModel(this MentorLake.Gtk.GtkComboBoxHandle combo_box)
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxHandle)");
		return GtkComboBoxHandleExterns.gtk_combo_box_get_model(combo_box);
	}

	public static MentorLake.Atk.AtkObjectHandle GetPopupAccessible(this MentorLake.Gtk.GtkComboBoxHandle combo_box)
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxHandle)");
		return GtkComboBoxHandleExterns.gtk_combo_box_get_popup_accessible(combo_box);
	}

	public static bool GetPopupFixedWidth(this MentorLake.Gtk.GtkComboBoxHandle combo_box)
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxHandle)");
		return GtkComboBoxHandleExterns.gtk_combo_box_get_popup_fixed_width(combo_box);
	}

	public static MentorLake.Gtk.GtkTreeViewRowSeparatorFunc GetRowSeparatorFunc(this MentorLake.Gtk.GtkComboBoxHandle combo_box)
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxHandle)");
		return GtkComboBoxHandleExterns.gtk_combo_box_get_row_separator_func(combo_box);
	}

	public static int GetRowSpanColumn(this MentorLake.Gtk.GtkComboBoxHandle combo_box)
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxHandle)");
		return GtkComboBoxHandleExterns.gtk_combo_box_get_row_span_column(combo_box);
	}

	public static string GetTitle(this MentorLake.Gtk.GtkComboBoxHandle combo_box)
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxHandle)");
		return GtkComboBoxHandleExterns.gtk_combo_box_get_title(combo_box);
	}

	public static int GetWrapWidth(this MentorLake.Gtk.GtkComboBoxHandle combo_box)
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxHandle)");
		return GtkComboBoxHandleExterns.gtk_combo_box_get_wrap_width(combo_box);
	}

	public static T Popdown<T>(this T combo_box) where T : GtkComboBoxHandle
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxHandle)");
		GtkComboBoxHandleExterns.gtk_combo_box_popdown(combo_box);
		return combo_box;
	}

	public static T Popup<T>(this T combo_box) where T : GtkComboBoxHandle
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxHandle)");
		GtkComboBoxHandleExterns.gtk_combo_box_popup(combo_box);
		return combo_box;
	}

	public static T PopupForDevice<T>(this T combo_box, MentorLake.Gdk.GdkDeviceHandle device) where T : GtkComboBoxHandle
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxHandle)");
		GtkComboBoxHandleExterns.gtk_combo_box_popup_for_device(combo_box, device);
		return combo_box;
	}

	public static T SetActive<T>(this T combo_box, int index_) where T : GtkComboBoxHandle
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxHandle)");
		GtkComboBoxHandleExterns.gtk_combo_box_set_active(combo_box, index_);
		return combo_box;
	}

	public static bool SetActiveId(this MentorLake.Gtk.GtkComboBoxHandle combo_box, string active_id)
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxHandle)");
		return GtkComboBoxHandleExterns.gtk_combo_box_set_active_id(combo_box, active_id);
	}

	public static T SetActiveIter<T>(this T combo_box, MentorLake.Gtk.GtkTreeIterHandle iter) where T : GtkComboBoxHandle
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxHandle)");
		GtkComboBoxHandleExterns.gtk_combo_box_set_active_iter(combo_box, iter);
		return combo_box;
	}

	public static T SetAddTearoffs<T>(this T combo_box, bool add_tearoffs) where T : GtkComboBoxHandle
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxHandle)");
		GtkComboBoxHandleExterns.gtk_combo_box_set_add_tearoffs(combo_box, add_tearoffs);
		return combo_box;
	}

	public static T SetButtonSensitivity<T>(this T combo_box, MentorLake.Gtk.GtkSensitivityType sensitivity) where T : GtkComboBoxHandle
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxHandle)");
		GtkComboBoxHandleExterns.gtk_combo_box_set_button_sensitivity(combo_box, sensitivity);
		return combo_box;
	}

	public static T SetColumnSpanColumn<T>(this T combo_box, int column_span) where T : GtkComboBoxHandle
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxHandle)");
		GtkComboBoxHandleExterns.gtk_combo_box_set_column_span_column(combo_box, column_span);
		return combo_box;
	}

	public static T SetEntryTextColumn<T>(this T combo_box, int text_column) where T : GtkComboBoxHandle
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxHandle)");
		GtkComboBoxHandleExterns.gtk_combo_box_set_entry_text_column(combo_box, text_column);
		return combo_box;
	}

	public static T SetFocusOnClick<T>(this T combo, bool focus_on_click) where T : GtkComboBoxHandle
	{
		if (combo.IsInvalid || combo.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxHandle)");
		GtkComboBoxHandleExterns.gtk_combo_box_set_focus_on_click(combo, focus_on_click);
		return combo;
	}

	public static T SetIdColumn<T>(this T combo_box, int id_column) where T : GtkComboBoxHandle
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxHandle)");
		GtkComboBoxHandleExterns.gtk_combo_box_set_id_column(combo_box, id_column);
		return combo_box;
	}

	public static T SetModel<T>(this T combo_box, MentorLake.Gtk.GtkTreeModelHandle model) where T : GtkComboBoxHandle
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxHandle)");
		GtkComboBoxHandleExterns.gtk_combo_box_set_model(combo_box, model);
		return combo_box;
	}

	public static T SetPopupFixedWidth<T>(this T combo_box, bool @fixed) where T : GtkComboBoxHandle
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxHandle)");
		GtkComboBoxHandleExterns.gtk_combo_box_set_popup_fixed_width(combo_box, @fixed);
		return combo_box;
	}

	public static T SetRowSeparatorFunc<T>(this T combo_box, MentorLake.Gtk.GtkTreeViewRowSeparatorFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkComboBoxHandle
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxHandle)");
		GtkComboBoxHandleExterns.gtk_combo_box_set_row_separator_func(combo_box, func, data, destroy);
		return combo_box;
	}

	public static T SetRowSpanColumn<T>(this T combo_box, int row_span) where T : GtkComboBoxHandle
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxHandle)");
		GtkComboBoxHandleExterns.gtk_combo_box_set_row_span_column(combo_box, row_span);
		return combo_box;
	}

	public static T SetTitle<T>(this T combo_box, string title) where T : GtkComboBoxHandle
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxHandle)");
		GtkComboBoxHandleExterns.gtk_combo_box_set_title(combo_box, title);
		return combo_box;
	}

	public static T SetWrapWidth<T>(this T combo_box, int width) where T : GtkComboBoxHandle
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxHandle)");
		GtkComboBoxHandleExterns.gtk_combo_box_set_wrap_width(combo_box, width);
		return combo_box;
	}

}

internal class GtkComboBoxHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkComboBoxHandle gtk_combo_box_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkComboBoxHandle gtk_combo_box_new_with_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkComboBoxHandle gtk_combo_box_new_with_area_and_entry([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkComboBoxHandle gtk_combo_box_new_with_entry();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkComboBoxHandle gtk_combo_box_new_with_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle model);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkComboBoxHandle gtk_combo_box_new_with_model_and_entry([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle model);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_combo_box_get_active([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_combo_box_get_active_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_combo_box_get_active_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box, out MentorLake.Gtk.GtkTreeIter iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_combo_box_get_add_tearoffs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkSensitivityType gtk_combo_box_get_button_sensitivity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_combo_box_get_column_span_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_combo_box_get_entry_text_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_combo_box_get_focus_on_click([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_combo_box_get_has_entry([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_combo_box_get_id_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTreeModelHandle gtk_combo_box_get_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Atk.AtkObjectHandle gtk_combo_box_get_popup_accessible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_combo_box_get_popup_fixed_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTreeViewRowSeparatorFunc gtk_combo_box_get_row_separator_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_combo_box_get_row_span_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_combo_box_get_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_combo_box_get_wrap_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_popdown([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_popup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_popup_for_device([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_set_active([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box, int index_);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_combo_box_set_active_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box, string active_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_set_active_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_set_add_tearoffs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box, bool add_tearoffs);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_set_button_sensitivity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box, MentorLake.Gtk.GtkSensitivityType sensitivity);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_set_column_span_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box, int column_span);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_set_entry_text_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box, int text_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_set_focus_on_click([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo, bool focus_on_click);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_set_id_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box, int id_column);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_set_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle model);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_set_popup_fixed_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box, bool @fixed);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_set_row_separator_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box, MentorLake.Gtk.GtkTreeViewRowSeparatorFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_set_row_span_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box, int row_span);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_set_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box, string title);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_set_wrap_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxHandle>))] MentorLake.Gtk.GtkComboBoxHandle combo_box, int width);

}
