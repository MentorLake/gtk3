namespace MentorLake.Gtk3.Gtk3;

public class GtkEntryHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkCellEditableHandle, GtkEditableHandle
{
	public static GtkEntryHandle New()
	{
		return GtkEntryExterns.gtk_entry_new();
	}

	public static GtkEntryHandle NewWithBuffer(GtkEntryBufferHandle buffer)
	{
		return GtkEntryExterns.gtk_entry_new_with_buffer(buffer);
	}

}

public static class GtkEntrySignalExtensions
{

	public static IObservable<GtkEntrySignalStructs.ActivateSignal> Signal_Activate(this GtkEntryHandle instance)
	{
		return Observable.Create((IObserver<GtkEntrySignalStructs.ActivateSignal> obs) =>
		{
			GtkEntrySignalDelegates.activate handler = (GtkEntryHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntrySignalStructs.ActivateSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkEntrySignalStructs.BackspaceSignal> Signal_Backspace(this GtkEntryHandle instance)
	{
		return Observable.Create((IObserver<GtkEntrySignalStructs.BackspaceSignal> obs) =>
		{
			GtkEntrySignalDelegates.backspace handler = (GtkEntryHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntrySignalStructs.BackspaceSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "backspace", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkEntrySignalStructs.CopyClipboardSignal> Signal_CopyClipboard(this GtkEntryHandle instance)
	{
		return Observable.Create((IObserver<GtkEntrySignalStructs.CopyClipboardSignal> obs) =>
		{
			GtkEntrySignalDelegates.copy_clipboard handler = (GtkEntryHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntrySignalStructs.CopyClipboardSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "copy_clipboard", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkEntrySignalStructs.CutClipboardSignal> Signal_CutClipboard(this GtkEntryHandle instance)
	{
		return Observable.Create((IObserver<GtkEntrySignalStructs.CutClipboardSignal> obs) =>
		{
			GtkEntrySignalDelegates.cut_clipboard handler = (GtkEntryHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntrySignalStructs.CutClipboardSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "cut_clipboard", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkEntrySignalStructs.DeleteFromCursorSignal> Signal_DeleteFromCursor(this GtkEntryHandle instance)
	{
		return Observable.Create((IObserver<GtkEntrySignalStructs.DeleteFromCursorSignal> obs) =>
		{
			GtkEntrySignalDelegates.delete_from_cursor handler = (GtkEntryHandle self, GtkDeleteType type, int count, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntrySignalStructs.DeleteFromCursorSignal()
				{
					Self = self, Type = type, Count = count, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "delete_from_cursor", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkEntrySignalStructs.IconPressSignal> Signal_IconPress(this GtkEntryHandle instance)
	{
		return Observable.Create((IObserver<GtkEntrySignalStructs.IconPressSignal> obs) =>
		{
			GtkEntrySignalDelegates.icon_press handler = (GtkEntryHandle self, GtkEntryIconPosition icon_pos, GdkEventHandle @event, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntrySignalStructs.IconPressSignal()
				{
					Self = self, IconPos = icon_pos, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "icon_press", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkEntrySignalStructs.IconReleaseSignal> Signal_IconRelease(this GtkEntryHandle instance)
	{
		return Observable.Create((IObserver<GtkEntrySignalStructs.IconReleaseSignal> obs) =>
		{
			GtkEntrySignalDelegates.icon_release handler = (GtkEntryHandle self, GtkEntryIconPosition icon_pos, GdkEventHandle @event, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntrySignalStructs.IconReleaseSignal()
				{
					Self = self, IconPos = icon_pos, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "icon_release", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkEntrySignalStructs.InsertAtCursorSignal> Signal_InsertAtCursor(this GtkEntryHandle instance)
	{
		return Observable.Create((IObserver<GtkEntrySignalStructs.InsertAtCursorSignal> obs) =>
		{
			GtkEntrySignalDelegates.insert_at_cursor handler = (GtkEntryHandle self, string @string, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntrySignalStructs.InsertAtCursorSignal()
				{
					Self = self, String = @string, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "insert_at_cursor", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkEntrySignalStructs.InsertEmojiSignal> Signal_InsertEmoji(this GtkEntryHandle instance)
	{
		return Observable.Create((IObserver<GtkEntrySignalStructs.InsertEmojiSignal> obs) =>
		{
			GtkEntrySignalDelegates.insert_emoji handler = (GtkEntryHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntrySignalStructs.InsertEmojiSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "insert_emoji", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkEntrySignalStructs.MoveCursorSignal> Signal_MoveCursor(this GtkEntryHandle instance)
	{
		return Observable.Create((IObserver<GtkEntrySignalStructs.MoveCursorSignal> obs) =>
		{
			GtkEntrySignalDelegates.move_cursor handler = (GtkEntryHandle self, GtkMovementStep step, int count, bool extend_selection, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntrySignalStructs.MoveCursorSignal()
				{
					Self = self, Step = step, Count = count, ExtendSelection = extend_selection, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "move_cursor", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkEntrySignalStructs.PasteClipboardSignal> Signal_PasteClipboard(this GtkEntryHandle instance)
	{
		return Observable.Create((IObserver<GtkEntrySignalStructs.PasteClipboardSignal> obs) =>
		{
			GtkEntrySignalDelegates.paste_clipboard handler = (GtkEntryHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntrySignalStructs.PasteClipboardSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "paste_clipboard", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkEntrySignalStructs.PopulatePopupSignal> Signal_PopulatePopup(this GtkEntryHandle instance)
	{
		return Observable.Create((IObserver<GtkEntrySignalStructs.PopulatePopupSignal> obs) =>
		{
			GtkEntrySignalDelegates.populate_popup handler = (GtkEntryHandle self, GtkWidgetHandle widget, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntrySignalStructs.PopulatePopupSignal()
				{
					Self = self, Widget = widget, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "populate_popup", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkEntrySignalStructs.PreeditChangedSignal> Signal_PreeditChanged(this GtkEntryHandle instance)
	{
		return Observable.Create((IObserver<GtkEntrySignalStructs.PreeditChangedSignal> obs) =>
		{
			GtkEntrySignalDelegates.preedit_changed handler = (GtkEntryHandle self, string preedit, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntrySignalStructs.PreeditChangedSignal()
				{
					Self = self, Preedit = preedit, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "preedit_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkEntrySignalStructs.ToggleOverwriteSignal> Signal_ToggleOverwrite(this GtkEntryHandle instance)
	{
		return Observable.Create((IObserver<GtkEntrySignalStructs.ToggleOverwriteSignal> obs) =>
		{
			GtkEntrySignalDelegates.toggle_overwrite handler = (GtkEntryHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntrySignalStructs.ToggleOverwriteSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "toggle_overwrite", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkEntrySignalStructs
{

public struct ActivateSignal
{
	public GtkEntryHandle Self;
	public IntPtr UserData;
}

public struct BackspaceSignal
{
	public GtkEntryHandle Self;
	public IntPtr UserData;
}

public struct CopyClipboardSignal
{
	public GtkEntryHandle Self;
	public IntPtr UserData;
}

public struct CutClipboardSignal
{
	public GtkEntryHandle Self;
	public IntPtr UserData;
}

public struct DeleteFromCursorSignal
{
	public GtkEntryHandle Self;
	public GtkDeleteType Type;
	public int Count;
	public IntPtr UserData;
}

public struct IconPressSignal
{
	public GtkEntryHandle Self;
	public GtkEntryIconPosition IconPos;
	public GdkEventHandle Event;
	public IntPtr UserData;
}

public struct IconReleaseSignal
{
	public GtkEntryHandle Self;
	public GtkEntryIconPosition IconPos;
	public GdkEventHandle Event;
	public IntPtr UserData;
}

public struct InsertAtCursorSignal
{
	public GtkEntryHandle Self;
	public string String;
	public IntPtr UserData;
}

public struct InsertEmojiSignal
{
	public GtkEntryHandle Self;
	public IntPtr UserData;
}

public struct MoveCursorSignal
{
	public GtkEntryHandle Self;
	public GtkMovementStep Step;
	public int Count;
	public bool ExtendSelection;
	public IntPtr UserData;
}

public struct PasteClipboardSignal
{
	public GtkEntryHandle Self;
	public IntPtr UserData;
}

public struct PopulatePopupSignal
{
	public GtkEntryHandle Self;
	public GtkWidgetHandle Widget;
	public IntPtr UserData;
}

public struct PreeditChangedSignal
{
	public GtkEntryHandle Self;
	public string Preedit;
	public IntPtr UserData;
}

public struct ToggleOverwriteSignal
{
	public GtkEntryHandle Self;
	public IntPtr UserData;
}
}

public static class GtkEntrySignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEntryHandle>))] GtkEntryHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void backspace([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEntryHandle>))] GtkEntryHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void copy_clipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEntryHandle>))] GtkEntryHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void cut_clipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEntryHandle>))] GtkEntryHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void delete_from_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEntryHandle>))] GtkEntryHandle self, GtkDeleteType type, int count, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void icon_press([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEntryHandle>))] GtkEntryHandle self, GtkEntryIconPosition icon_pos, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkEventHandle>))] GdkEventHandle @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void icon_release([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEntryHandle>))] GtkEntryHandle self, GtkEntryIconPosition icon_pos, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkEventHandle>))] GdkEventHandle @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void insert_at_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEntryHandle>))] GtkEntryHandle self, string @string, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void insert_emoji([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEntryHandle>))] GtkEntryHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void move_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEntryHandle>))] GtkEntryHandle self, GtkMovementStep step, int count, bool extend_selection, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void paste_clipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEntryHandle>))] GtkEntryHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void populate_popup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEntryHandle>))] GtkEntryHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle widget, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void preedit_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEntryHandle>))] GtkEntryHandle self, string preedit, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void toggle_overwrite([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEntryHandle>))] GtkEntryHandle self, IntPtr user_data);

}


public static class GtkEntryHandleExtensions
{
	public static bool GetActivatesDefault(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_activates_default(entry);
	}

	public static float GetAlignment(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_alignment(entry);
	}

	public static PangoAttrListHandle GetAttributes(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_attributes(entry);
	}

	public static GtkEntryBufferHandle GetBuffer(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_buffer(entry);
	}

	public static GtkEntryCompletionHandle GetCompletion(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_completion(entry);
	}

	public static int GetCurrentIconDragSource(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_current_icon_drag_source(entry);
	}

	public static GtkAdjustmentHandle GetCursorHadjustment(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_cursor_hadjustment(entry);
	}

	public static bool GetHasFrame(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_has_frame(entry);
	}

	public static bool GetIconActivatable(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos)
	{
		return GtkEntryExterns.gtk_entry_get_icon_activatable(entry, icon_pos);
	}

	public static GtkEntryHandle GetIconArea(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos, out GdkRectangle icon_area)
	{
		GtkEntryExterns.gtk_entry_get_icon_area(entry, icon_pos, out icon_area);
		return entry;
	}

	public static int GetIconAtPos(this GtkEntryHandle entry, int x, int y)
	{
		return GtkEntryExterns.gtk_entry_get_icon_at_pos(entry, x, y);
	}

	public static GIconHandle GetIconGicon(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos)
	{
		return GtkEntryExterns.gtk_entry_get_icon_gicon(entry, icon_pos);
	}

	public static string GetIconName(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos)
	{
		return GtkEntryExterns.gtk_entry_get_icon_name(entry, icon_pos);
	}

	public static GdkPixbufHandle GetIconPixbuf(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos)
	{
		return GtkEntryExterns.gtk_entry_get_icon_pixbuf(entry, icon_pos);
	}

	public static bool GetIconSensitive(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos)
	{
		return GtkEntryExterns.gtk_entry_get_icon_sensitive(entry, icon_pos);
	}

	public static string GetIconStock(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos)
	{
		return GtkEntryExterns.gtk_entry_get_icon_stock(entry, icon_pos);
	}

	public static GtkImageType GetIconStorageType(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos)
	{
		return GtkEntryExterns.gtk_entry_get_icon_storage_type(entry, icon_pos);
	}

	public static string GetIconTooltipMarkup(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos)
	{
		return GtkEntryExterns.gtk_entry_get_icon_tooltip_markup(entry, icon_pos);
	}

	public static string GetIconTooltipText(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos)
	{
		return GtkEntryExterns.gtk_entry_get_icon_tooltip_text(entry, icon_pos);
	}

	public static GtkBorderHandle GetInnerBorder(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_inner_border(entry);
	}

	public static GtkInputHints GetInputHints(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_input_hints(entry);
	}

	public static GtkInputPurpose GetInputPurpose(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_input_purpose(entry);
	}

	public static char GetInvisibleChar(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_invisible_char(entry);
	}

	public static PangoLayoutHandle GetLayout(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_layout(entry);
	}

	public static GtkEntryHandle GetLayoutOffsets(this GtkEntryHandle entry, out int x, out int y)
	{
		GtkEntryExterns.gtk_entry_get_layout_offsets(entry, out x, out y);
		return entry;
	}

	public static int GetMaxLength(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_max_length(entry);
	}

	public static int GetMaxWidthChars(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_max_width_chars(entry);
	}

	public static bool GetOverwriteMode(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_overwrite_mode(entry);
	}

	public static string GetPlaceholderText(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_placeholder_text(entry);
	}

	public static double GetProgressFraction(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_progress_fraction(entry);
	}

	public static double GetProgressPulseStep(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_progress_pulse_step(entry);
	}

	public static PangoTabArrayHandle GetTabs(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_tabs(entry);
	}

	public static string GetText(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_text(entry);
	}

	public static GtkEntryHandle GetTextArea(this GtkEntryHandle entry, out GdkRectangle text_area)
	{
		GtkEntryExterns.gtk_entry_get_text_area(entry, out text_area);
		return entry;
	}

	public static ushort GetTextLength(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_text_length(entry);
	}

	public static bool GetVisibility(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_visibility(entry);
	}

	public static int GetWidthChars(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_width_chars(entry);
	}

	public static GtkEntryHandle GrabFocusWithoutSelecting(this GtkEntryHandle entry)
	{
		GtkEntryExterns.gtk_entry_grab_focus_without_selecting(entry);
		return entry;
	}

	public static bool ImContextFilterKeypress(this GtkEntryHandle entry, GdkEventKeyHandle @event)
	{
		return GtkEntryExterns.gtk_entry_im_context_filter_keypress(entry, @event);
	}

	public static int LayoutIndexToTextIndex(this GtkEntryHandle entry, int layout_index)
	{
		return GtkEntryExterns.gtk_entry_layout_index_to_text_index(entry, layout_index);
	}

	public static GtkEntryHandle ProgressPulse(this GtkEntryHandle entry)
	{
		GtkEntryExterns.gtk_entry_progress_pulse(entry);
		return entry;
	}

	public static GtkEntryHandle ResetImContext(this GtkEntryHandle entry)
	{
		GtkEntryExterns.gtk_entry_reset_im_context(entry);
		return entry;
	}

	public static GtkEntryHandle SetActivatesDefault(this GtkEntryHandle entry, bool setting)
	{
		GtkEntryExterns.gtk_entry_set_activates_default(entry, setting);
		return entry;
	}

	public static GtkEntryHandle SetAlignment(this GtkEntryHandle entry, float xalign)
	{
		GtkEntryExterns.gtk_entry_set_alignment(entry, xalign);
		return entry;
	}

	public static GtkEntryHandle SetAttributes(this GtkEntryHandle entry, PangoAttrListHandle attrs)
	{
		GtkEntryExterns.gtk_entry_set_attributes(entry, attrs);
		return entry;
	}

	public static GtkEntryHandle SetBuffer(this GtkEntryHandle entry, GtkEntryBufferHandle buffer)
	{
		GtkEntryExterns.gtk_entry_set_buffer(entry, buffer);
		return entry;
	}

	public static GtkEntryHandle SetCompletion(this GtkEntryHandle entry, GtkEntryCompletionHandle completion)
	{
		GtkEntryExterns.gtk_entry_set_completion(entry, completion);
		return entry;
	}

	public static GtkEntryHandle SetCursorHadjustment(this GtkEntryHandle entry, GtkAdjustmentHandle adjustment)
	{
		GtkEntryExterns.gtk_entry_set_cursor_hadjustment(entry, adjustment);
		return entry;
	}

	public static GtkEntryHandle SetHasFrame(this GtkEntryHandle entry, bool setting)
	{
		GtkEntryExterns.gtk_entry_set_has_frame(entry, setting);
		return entry;
	}

	public static GtkEntryHandle SetIconActivatable(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos, bool activatable)
	{
		GtkEntryExterns.gtk_entry_set_icon_activatable(entry, icon_pos, activatable);
		return entry;
	}

	public static GtkEntryHandle SetIconDragSource(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos, GtkTargetListHandle target_list, GdkDragAction actions)
	{
		GtkEntryExterns.gtk_entry_set_icon_drag_source(entry, icon_pos, target_list, actions);
		return entry;
	}

	public static GtkEntryHandle SetIconFromGicon(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos, GIconHandle icon)
	{
		GtkEntryExterns.gtk_entry_set_icon_from_gicon(entry, icon_pos, icon);
		return entry;
	}

	public static GtkEntryHandle SetIconFromIconName(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos, string icon_name)
	{
		GtkEntryExterns.gtk_entry_set_icon_from_icon_name(entry, icon_pos, icon_name);
		return entry;
	}

	public static GtkEntryHandle SetIconFromPixbuf(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos, GdkPixbufHandle pixbuf)
	{
		GtkEntryExterns.gtk_entry_set_icon_from_pixbuf(entry, icon_pos, pixbuf);
		return entry;
	}

	public static GtkEntryHandle SetIconFromStock(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos, string stock_id)
	{
		GtkEntryExterns.gtk_entry_set_icon_from_stock(entry, icon_pos, stock_id);
		return entry;
	}

	public static GtkEntryHandle SetIconSensitive(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos, bool sensitive)
	{
		GtkEntryExterns.gtk_entry_set_icon_sensitive(entry, icon_pos, sensitive);
		return entry;
	}

	public static GtkEntryHandle SetIconTooltipMarkup(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos, string tooltip)
	{
		GtkEntryExterns.gtk_entry_set_icon_tooltip_markup(entry, icon_pos, tooltip);
		return entry;
	}

	public static GtkEntryHandle SetIconTooltipText(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos, string tooltip)
	{
		GtkEntryExterns.gtk_entry_set_icon_tooltip_text(entry, icon_pos, tooltip);
		return entry;
	}

	public static GtkEntryHandle SetInnerBorder(this GtkEntryHandle entry, GtkBorderHandle border)
	{
		GtkEntryExterns.gtk_entry_set_inner_border(entry, border);
		return entry;
	}

	public static GtkEntryHandle SetInputHints(this GtkEntryHandle entry, GtkInputHints hints)
	{
		GtkEntryExterns.gtk_entry_set_input_hints(entry, hints);
		return entry;
	}

	public static GtkEntryHandle SetInputPurpose(this GtkEntryHandle entry, GtkInputPurpose purpose)
	{
		GtkEntryExterns.gtk_entry_set_input_purpose(entry, purpose);
		return entry;
	}

	public static GtkEntryHandle SetInvisibleChar(this GtkEntryHandle entry, char ch)
	{
		GtkEntryExterns.gtk_entry_set_invisible_char(entry, ch);
		return entry;
	}

	public static GtkEntryHandle SetMaxLength(this GtkEntryHandle entry, int max)
	{
		GtkEntryExterns.gtk_entry_set_max_length(entry, max);
		return entry;
	}

	public static GtkEntryHandle SetMaxWidthChars(this GtkEntryHandle entry, int n_chars)
	{
		GtkEntryExterns.gtk_entry_set_max_width_chars(entry, n_chars);
		return entry;
	}

	public static GtkEntryHandle SetOverwriteMode(this GtkEntryHandle entry, bool overwrite)
	{
		GtkEntryExterns.gtk_entry_set_overwrite_mode(entry, overwrite);
		return entry;
	}

	public static GtkEntryHandle SetPlaceholderText(this GtkEntryHandle entry, string text)
	{
		GtkEntryExterns.gtk_entry_set_placeholder_text(entry, text);
		return entry;
	}

	public static GtkEntryHandle SetProgressFraction(this GtkEntryHandle entry, double fraction)
	{
		GtkEntryExterns.gtk_entry_set_progress_fraction(entry, fraction);
		return entry;
	}

	public static GtkEntryHandle SetProgressPulseStep(this GtkEntryHandle entry, double fraction)
	{
		GtkEntryExterns.gtk_entry_set_progress_pulse_step(entry, fraction);
		return entry;
	}

	public static GtkEntryHandle SetTabs(this GtkEntryHandle entry, PangoTabArrayHandle tabs)
	{
		GtkEntryExterns.gtk_entry_set_tabs(entry, tabs);
		return entry;
	}

	public static GtkEntryHandle SetText(this GtkEntryHandle entry, string text)
	{
		GtkEntryExterns.gtk_entry_set_text(entry, text);
		return entry;
	}

	public static GtkEntryHandle SetVisibility(this GtkEntryHandle entry, bool visible)
	{
		GtkEntryExterns.gtk_entry_set_visibility(entry, visible);
		return entry;
	}

	public static GtkEntryHandle SetWidthChars(this GtkEntryHandle entry, int n_chars)
	{
		GtkEntryExterns.gtk_entry_set_width_chars(entry, n_chars);
		return entry;
	}

	public static int TextIndexToLayoutIndex(this GtkEntryHandle entry, int text_index)
	{
		return GtkEntryExterns.gtk_entry_text_index_to_layout_index(entry, text_index);
	}

	public static GtkEntryHandle UnsetInvisibleChar(this GtkEntryHandle entry)
	{
		GtkEntryExterns.gtk_entry_unset_invisible_char(entry);
		return entry;
	}

}

internal class GtkEntryExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkEntryHandle gtk_entry_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkEntryHandle gtk_entry_new_with_buffer(GtkEntryBufferHandle buffer);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_entry_get_activates_default(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk3)]
	internal static extern float gtk_entry_get_alignment(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk3)]
	internal static extern PangoAttrListHandle gtk_entry_get_attributes(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkEntryBufferHandle gtk_entry_get_buffer(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkEntryCompletionHandle gtk_entry_get_completion(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_entry_get_current_icon_drag_source(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkAdjustmentHandle gtk_entry_get_cursor_hadjustment(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_entry_get_has_frame(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_entry_get_icon_activatable(GtkEntryHandle entry, GtkEntryIconPosition icon_pos);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_get_icon_area(GtkEntryHandle entry, GtkEntryIconPosition icon_pos, out GdkRectangle icon_area);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_entry_get_icon_at_pos(GtkEntryHandle entry, int x, int y);

	[DllImport(Libraries.Gtk3)]
	internal static extern GIconHandle gtk_entry_get_icon_gicon(GtkEntryHandle entry, GtkEntryIconPosition icon_pos);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_entry_get_icon_name(GtkEntryHandle entry, GtkEntryIconPosition icon_pos);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkPixbufHandle gtk_entry_get_icon_pixbuf(GtkEntryHandle entry, GtkEntryIconPosition icon_pos);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_entry_get_icon_sensitive(GtkEntryHandle entry, GtkEntryIconPosition icon_pos);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_entry_get_icon_stock(GtkEntryHandle entry, GtkEntryIconPosition icon_pos);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkImageType gtk_entry_get_icon_storage_type(GtkEntryHandle entry, GtkEntryIconPosition icon_pos);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_entry_get_icon_tooltip_markup(GtkEntryHandle entry, GtkEntryIconPosition icon_pos);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_entry_get_icon_tooltip_text(GtkEntryHandle entry, GtkEntryIconPosition icon_pos);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkBorderHandle gtk_entry_get_inner_border(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkInputHints gtk_entry_get_input_hints(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkInputPurpose gtk_entry_get_input_purpose(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk3)]
	internal static extern char gtk_entry_get_invisible_char(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk3)]
	internal static extern PangoLayoutHandle gtk_entry_get_layout(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_get_layout_offsets(GtkEntryHandle entry, out int x, out int y);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_entry_get_max_length(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_entry_get_max_width_chars(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_entry_get_overwrite_mode(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_entry_get_placeholder_text(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk3)]
	internal static extern double gtk_entry_get_progress_fraction(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk3)]
	internal static extern double gtk_entry_get_progress_pulse_step(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk3)]
	internal static extern PangoTabArrayHandle gtk_entry_get_tabs(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_entry_get_text(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_get_text_area(GtkEntryHandle entry, out GdkRectangle text_area);

	[DllImport(Libraries.Gtk3)]
	internal static extern ushort gtk_entry_get_text_length(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_entry_get_visibility(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_entry_get_width_chars(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_grab_focus_without_selecting(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_entry_im_context_filter_keypress(GtkEntryHandle entry, GdkEventKeyHandle @event);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_entry_layout_index_to_text_index(GtkEntryHandle entry, int layout_index);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_progress_pulse(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_reset_im_context(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_set_activates_default(GtkEntryHandle entry, bool setting);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_set_alignment(GtkEntryHandle entry, float xalign);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_set_attributes(GtkEntryHandle entry, PangoAttrListHandle attrs);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_set_buffer(GtkEntryHandle entry, GtkEntryBufferHandle buffer);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_set_completion(GtkEntryHandle entry, GtkEntryCompletionHandle completion);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_set_cursor_hadjustment(GtkEntryHandle entry, GtkAdjustmentHandle adjustment);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_set_has_frame(GtkEntryHandle entry, bool setting);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_set_icon_activatable(GtkEntryHandle entry, GtkEntryIconPosition icon_pos, bool activatable);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_set_icon_drag_source(GtkEntryHandle entry, GtkEntryIconPosition icon_pos, GtkTargetListHandle target_list, GdkDragAction actions);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_set_icon_from_gicon(GtkEntryHandle entry, GtkEntryIconPosition icon_pos, GIconHandle icon);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_set_icon_from_icon_name(GtkEntryHandle entry, GtkEntryIconPosition icon_pos, string icon_name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_set_icon_from_pixbuf(GtkEntryHandle entry, GtkEntryIconPosition icon_pos, GdkPixbufHandle pixbuf);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_set_icon_from_stock(GtkEntryHandle entry, GtkEntryIconPosition icon_pos, string stock_id);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_set_icon_sensitive(GtkEntryHandle entry, GtkEntryIconPosition icon_pos, bool sensitive);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_set_icon_tooltip_markup(GtkEntryHandle entry, GtkEntryIconPosition icon_pos, string tooltip);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_set_icon_tooltip_text(GtkEntryHandle entry, GtkEntryIconPosition icon_pos, string tooltip);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_set_inner_border(GtkEntryHandle entry, GtkBorderHandle border);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_set_input_hints(GtkEntryHandle entry, GtkInputHints hints);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_set_input_purpose(GtkEntryHandle entry, GtkInputPurpose purpose);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_set_invisible_char(GtkEntryHandle entry, char ch);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_set_max_length(GtkEntryHandle entry, int max);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_set_max_width_chars(GtkEntryHandle entry, int n_chars);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_set_overwrite_mode(GtkEntryHandle entry, bool overwrite);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_set_placeholder_text(GtkEntryHandle entry, string text);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_set_progress_fraction(GtkEntryHandle entry, double fraction);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_set_progress_pulse_step(GtkEntryHandle entry, double fraction);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_set_tabs(GtkEntryHandle entry, PangoTabArrayHandle tabs);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_set_text(GtkEntryHandle entry, string text);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_set_visibility(GtkEntryHandle entry, bool visible);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_set_width_chars(GtkEntryHandle entry, int n_chars);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_entry_text_index_to_layout_index(GtkEntryHandle entry, int text_index);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_unset_invisible_char(GtkEntryHandle entry);

}
