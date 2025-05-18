namespace MentorLake.Gtk;

public class GtkTextViewHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkScrollableHandle
{
	public static MentorLake.Gtk.GtkTextViewHandle New()
	{
		return GtkTextViewHandleExterns.gtk_text_view_new();
	}

	public static MentorLake.Gtk.GtkTextViewHandle NewWithBuffer(MentorLake.Gtk.GtkTextBufferHandle buffer)
	{
		return GtkTextViewHandleExterns.gtk_text_view_new_with_buffer(buffer);
	}

}
public static class GtkTextViewHandleSignalExtensions
{

	public static IObservable<GtkTextViewHandleSignalStructs.BackspaceSignal> Signal_Backspace(this GtkTextViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextViewHandleSignalStructs.BackspaceSignal> obs) =>
		{
			GtkTextViewHandleSignalDelegates.backspace handler = ( MentorLake.Gtk.GtkTextViewHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextViewHandleSignalStructs.BackspaceSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "backspace", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkTextViewHandleSignalStructs.CopyClipboardSignal> Signal_CopyClipboard(this GtkTextViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextViewHandleSignalStructs.CopyClipboardSignal> obs) =>
		{
			GtkTextViewHandleSignalDelegates.copy_clipboard handler = ( MentorLake.Gtk.GtkTextViewHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextViewHandleSignalStructs.CopyClipboardSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "copy-clipboard", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkTextViewHandleSignalStructs.CutClipboardSignal> Signal_CutClipboard(this GtkTextViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextViewHandleSignalStructs.CutClipboardSignal> obs) =>
		{
			GtkTextViewHandleSignalDelegates.cut_clipboard handler = ( MentorLake.Gtk.GtkTextViewHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextViewHandleSignalStructs.CutClipboardSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "cut-clipboard", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkTextViewHandleSignalStructs.DeleteFromCursorSignal> Signal_DeleteFromCursor(this GtkTextViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextViewHandleSignalStructs.DeleteFromCursorSignal> obs) =>
		{
			GtkTextViewHandleSignalDelegates.delete_from_cursor handler = ( MentorLake.Gtk.GtkTextViewHandle self,  MentorLake.Gtk.GtkDeleteType type,  int count,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextViewHandleSignalStructs.DeleteFromCursorSignal()
				{
					Self = self, Type = type, Count = count, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "delete-from-cursor", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkTextViewHandleSignalStructs.ExtendSelectionSignal> Signal_ExtendSelection(this GtkTextViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextViewHandleSignalStructs.ExtendSelectionSignal> obs) =>
		{
			GtkTextViewHandleSignalDelegates.extend_selection handler = ( MentorLake.Gtk.GtkTextViewHandle self,  MentorLake.Gtk.GtkTextExtendSelection granularity,  MentorLake.Gtk.GtkTextIterHandle location,  MentorLake.Gtk.GtkTextIterHandle start,  MentorLake.Gtk.GtkTextIterHandle end,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextViewHandleSignalStructs.ExtendSelectionSignal()
				{
					Self = self, Granularity = granularity, Location = location, Start = start, End = end, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "extend-selection", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkTextViewHandleSignalStructs.InsertAtCursorSignal> Signal_InsertAtCursor(this GtkTextViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextViewHandleSignalStructs.InsertAtCursorSignal> obs) =>
		{
			GtkTextViewHandleSignalDelegates.insert_at_cursor handler = ( MentorLake.Gtk.GtkTextViewHandle self,  string @string,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextViewHandleSignalStructs.InsertAtCursorSignal()
				{
					Self = self, String = @string, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "insert-at-cursor", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkTextViewHandleSignalStructs.InsertEmojiSignal> Signal_InsertEmoji(this GtkTextViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextViewHandleSignalStructs.InsertEmojiSignal> obs) =>
		{
			GtkTextViewHandleSignalDelegates.insert_emoji handler = ( MentorLake.Gtk.GtkTextViewHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextViewHandleSignalStructs.InsertEmojiSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "insert-emoji", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkTextViewHandleSignalStructs.MoveCursorSignal> Signal_MoveCursor(this GtkTextViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextViewHandleSignalStructs.MoveCursorSignal> obs) =>
		{
			GtkTextViewHandleSignalDelegates.move_cursor handler = ( MentorLake.Gtk.GtkTextViewHandle self,  MentorLake.Gtk.GtkMovementStep step,  int count,  bool extend_selection,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextViewHandleSignalStructs.MoveCursorSignal()
				{
					Self = self, Step = step, Count = count, ExtendSelection = extend_selection, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "move-cursor", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkTextViewHandleSignalStructs.MoveViewportSignal> Signal_MoveViewport(this GtkTextViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextViewHandleSignalStructs.MoveViewportSignal> obs) =>
		{
			GtkTextViewHandleSignalDelegates.move_viewport handler = ( MentorLake.Gtk.GtkTextViewHandle self,  MentorLake.Gtk.GtkScrollStep step,  int count,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextViewHandleSignalStructs.MoveViewportSignal()
				{
					Self = self, Step = step, Count = count, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "move-viewport", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkTextViewHandleSignalStructs.PasteClipboardSignal> Signal_PasteClipboard(this GtkTextViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextViewHandleSignalStructs.PasteClipboardSignal> obs) =>
		{
			GtkTextViewHandleSignalDelegates.paste_clipboard handler = ( MentorLake.Gtk.GtkTextViewHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextViewHandleSignalStructs.PasteClipboardSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "paste-clipboard", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkTextViewHandleSignalStructs.PopulatePopupSignal> Signal_PopulatePopup(this GtkTextViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextViewHandleSignalStructs.PopulatePopupSignal> obs) =>
		{
			GtkTextViewHandleSignalDelegates.populate_popup handler = ( MentorLake.Gtk.GtkTextViewHandle self,  MentorLake.Gtk.GtkWidgetHandle popup,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextViewHandleSignalStructs.PopulatePopupSignal()
				{
					Self = self, Popup = popup, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "populate-popup", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkTextViewHandleSignalStructs.PreeditChangedSignal> Signal_PreeditChanged(this GtkTextViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextViewHandleSignalStructs.PreeditChangedSignal> obs) =>
		{
			GtkTextViewHandleSignalDelegates.preedit_changed handler = ( MentorLake.Gtk.GtkTextViewHandle self,  string preedit,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextViewHandleSignalStructs.PreeditChangedSignal()
				{
					Self = self, Preedit = preedit, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "preedit-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkTextViewHandleSignalStructs.SelectAllSignal> Signal_SelectAll(this GtkTextViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextViewHandleSignalStructs.SelectAllSignal> obs) =>
		{
			GtkTextViewHandleSignalDelegates.select_all handler = ( MentorLake.Gtk.GtkTextViewHandle self,  bool select,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextViewHandleSignalStructs.SelectAllSignal()
				{
					Self = self, Select = select, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "select-all", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkTextViewHandleSignalStructs.SetAnchorSignal> Signal_SetAnchor(this GtkTextViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextViewHandleSignalStructs.SetAnchorSignal> obs) =>
		{
			GtkTextViewHandleSignalDelegates.set_anchor handler = ( MentorLake.Gtk.GtkTextViewHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextViewHandleSignalStructs.SetAnchorSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "set-anchor", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkTextViewHandleSignalStructs.ToggleCursorVisibleSignal> Signal_ToggleCursorVisible(this GtkTextViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextViewHandleSignalStructs.ToggleCursorVisibleSignal> obs) =>
		{
			GtkTextViewHandleSignalDelegates.toggle_cursor_visible handler = ( MentorLake.Gtk.GtkTextViewHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextViewHandleSignalStructs.ToggleCursorVisibleSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "toggle-cursor-visible", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkTextViewHandleSignalStructs.ToggleOverwriteSignal> Signal_ToggleOverwrite(this GtkTextViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextViewHandleSignalStructs.ToggleOverwriteSignal> obs) =>
		{
			GtkTextViewHandleSignalDelegates.toggle_overwrite handler = ( MentorLake.Gtk.GtkTextViewHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextViewHandleSignalStructs.ToggleOverwriteSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "toggle-overwrite", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkTextViewHandleSignalStructs
{

public class BackspaceSignal
{
	public MentorLake.Gtk.GtkTextViewHandle Self;
	public IntPtr UserData;
}

public class CopyClipboardSignal
{
	public MentorLake.Gtk.GtkTextViewHandle Self;
	public IntPtr UserData;
}

public class CutClipboardSignal
{
	public MentorLake.Gtk.GtkTextViewHandle Self;
	public IntPtr UserData;
}

public class DeleteFromCursorSignal
{
	public MentorLake.Gtk.GtkTextViewHandle Self;
	public MentorLake.Gtk.GtkDeleteType Type;
	public int Count;
	public IntPtr UserData;
}

public class ExtendSelectionSignal
{
	public MentorLake.Gtk.GtkTextViewHandle Self;
	public MentorLake.Gtk.GtkTextExtendSelection Granularity;
	public MentorLake.Gtk.GtkTextIterHandle Location;
	public MentorLake.Gtk.GtkTextIterHandle Start;
	public MentorLake.Gtk.GtkTextIterHandle End;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class InsertAtCursorSignal
{
	public MentorLake.Gtk.GtkTextViewHandle Self;
	public string String;
	public IntPtr UserData;
}

public class InsertEmojiSignal
{
	public MentorLake.Gtk.GtkTextViewHandle Self;
	public IntPtr UserData;
}

public class MoveCursorSignal
{
	public MentorLake.Gtk.GtkTextViewHandle Self;
	public MentorLake.Gtk.GtkMovementStep Step;
	public int Count;
	public bool ExtendSelection;
	public IntPtr UserData;
}

public class MoveViewportSignal
{
	public MentorLake.Gtk.GtkTextViewHandle Self;
	public MentorLake.Gtk.GtkScrollStep Step;
	public int Count;
	public IntPtr UserData;
}

public class PasteClipboardSignal
{
	public MentorLake.Gtk.GtkTextViewHandle Self;
	public IntPtr UserData;
}

public class PopulatePopupSignal
{
	public MentorLake.Gtk.GtkTextViewHandle Self;
	public MentorLake.Gtk.GtkWidgetHandle Popup;
	public IntPtr UserData;
}

public class PreeditChangedSignal
{
	public MentorLake.Gtk.GtkTextViewHandle Self;
	public string Preedit;
	public IntPtr UserData;
}

public class SelectAllSignal
{
	public MentorLake.Gtk.GtkTextViewHandle Self;
	public bool Select;
	public IntPtr UserData;
}

public class SetAnchorSignal
{
	public MentorLake.Gtk.GtkTextViewHandle Self;
	public IntPtr UserData;
}

public class ToggleCursorVisibleSignal
{
	public MentorLake.Gtk.GtkTextViewHandle Self;
	public IntPtr UserData;
}

public class ToggleOverwriteSignal
{
	public MentorLake.Gtk.GtkTextViewHandle Self;
	public IntPtr UserData;
}
}

public static class GtkTextViewHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void backspace([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void copy_clipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void cut_clipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void delete_from_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle self, MentorLake.Gtk.GtkDeleteType type, int count, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool extend_selection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle self, MentorLake.Gtk.GtkTextExtendSelection granularity, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle location, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle start, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle end, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void insert_at_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle self, string @string, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void insert_emoji([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void move_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle self, MentorLake.Gtk.GtkMovementStep step, int count, bool extend_selection, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void move_viewport([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle self, MentorLake.Gtk.GtkScrollStep step, int count, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void paste_clipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void populate_popup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle popup, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void preedit_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle self, string preedit, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void select_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle self, bool select, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void set_anchor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void toggle_cursor_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void toggle_overwrite([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle self, IntPtr user_data);

}


public static class GtkTextViewHandleExtensions
{
	public static T AddChildAtAnchor<T>(this T text_view, MentorLake.Gtk.GtkWidgetHandle child, MentorLake.Gtk.GtkTextChildAnchorHandle anchor) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_add_child_at_anchor(text_view, child, anchor);
		return text_view;
	}

	public static T AddChildInWindow<T>(this T text_view, MentorLake.Gtk.GtkWidgetHandle child, MentorLake.Gtk.GtkTextWindowType which_window, int xpos, int ypos) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_add_child_in_window(text_view, child, which_window, xpos, ypos);
		return text_view;
	}

	public static bool BackwardDisplayLine(this MentorLake.Gtk.GtkTextViewHandle text_view, MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_backward_display_line(text_view, iter);
	}

	public static bool BackwardDisplayLineStart(this MentorLake.Gtk.GtkTextViewHandle text_view, MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_backward_display_line_start(text_view, iter);
	}

	public static T BufferToWindowCoords<T>(this T text_view, MentorLake.Gtk.GtkTextWindowType win, int buffer_x, int buffer_y, out int window_x, out int window_y) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_buffer_to_window_coords(text_view, win, buffer_x, buffer_y, out window_x, out window_y);
		return text_view;
	}

	public static bool ForwardDisplayLine(this MentorLake.Gtk.GtkTextViewHandle text_view, MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_forward_display_line(text_view, iter);
	}

	public static bool ForwardDisplayLineEnd(this MentorLake.Gtk.GtkTextViewHandle text_view, MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_forward_display_line_end(text_view, iter);
	}

	public static bool GetAcceptsTab(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_accepts_tab(text_view);
	}

	public static int GetBorderWindowSize(this MentorLake.Gtk.GtkTextViewHandle text_view, MentorLake.Gtk.GtkTextWindowType type)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_border_window_size(text_view, type);
	}

	public static int GetBottomMargin(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_bottom_margin(text_view);
	}

	public static MentorLake.Gtk.GtkTextBufferHandle GetBuffer(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_buffer(text_view);
	}

	public static T GetCursorLocations<T>(this T text_view, MentorLake.Gtk.GtkTextIterHandle iter, out MentorLake.Gdk.GdkRectangle strong, out MentorLake.Gdk.GdkRectangle weak) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_get_cursor_locations(text_view, iter, out strong, out weak);
		return text_view;
	}

	public static bool GetCursorVisible(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_cursor_visible(text_view);
	}

	public static MentorLake.Gtk.GtkTextAttributesHandle GetDefaultAttributes(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_default_attributes(text_view);
	}

	public static bool GetEditable(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_editable(text_view);
	}

	public static MentorLake.Gtk.GtkAdjustmentHandle GetHadjustment(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_hadjustment(text_view);
	}

	public static int GetIndent(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_indent(text_view);
	}

	public static MentorLake.Gtk.GtkInputHints GetInputHints(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_input_hints(text_view);
	}

	public static MentorLake.Gtk.GtkInputPurpose GetInputPurpose(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_input_purpose(text_view);
	}

	public static bool GetIterAtLocation(this MentorLake.Gtk.GtkTextViewHandle text_view, out MentorLake.Gtk.GtkTextIter iter, int x, int y)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_iter_at_location(text_view, out iter, x, y);
	}

	public static bool GetIterAtPosition(this MentorLake.Gtk.GtkTextViewHandle text_view, out MentorLake.Gtk.GtkTextIter iter, out int trailing, int x, int y)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_iter_at_position(text_view, out iter, out trailing, x, y);
	}

	public static T GetIterLocation<T>(this T text_view, MentorLake.Gtk.GtkTextIterHandle iter, out MentorLake.Gdk.GdkRectangle location) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_get_iter_location(text_view, iter, out location);
		return text_view;
	}

	public static MentorLake.Gtk.GtkJustification GetJustification(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_justification(text_view);
	}

	public static int GetLeftMargin(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_left_margin(text_view);
	}

	public static T GetLineAtY<T>(this T text_view, out MentorLake.Gtk.GtkTextIter target_iter, int y, out int line_top) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_get_line_at_y(text_view, out target_iter, y, out line_top);
		return text_view;
	}

	public static T GetLineYrange<T>(this T text_view, MentorLake.Gtk.GtkTextIterHandle iter, out int y, out int height) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_get_line_yrange(text_view, iter, out y, out height);
		return text_view;
	}

	public static bool GetMonospace(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_monospace(text_view);
	}

	public static bool GetOverwrite(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_overwrite(text_view);
	}

	public static int GetPixelsAboveLines(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_pixels_above_lines(text_view);
	}

	public static int GetPixelsBelowLines(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_pixels_below_lines(text_view);
	}

	public static int GetPixelsInsideWrap(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_pixels_inside_wrap(text_view);
	}

	public static int GetRightMargin(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_right_margin(text_view);
	}

	public static MentorLake.Pango.PangoTabArrayHandle GetTabs(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_tabs(text_view);
	}

	public static int GetTopMargin(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_top_margin(text_view);
	}

	public static MentorLake.Gtk.GtkAdjustmentHandle GetVadjustment(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_vadjustment(text_view);
	}

	public static T GetVisibleRect<T>(this T text_view, out MentorLake.Gdk.GdkRectangle visible_rect) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_get_visible_rect(text_view, out visible_rect);
		return text_view;
	}

	public static MentorLake.Gdk.GdkWindowHandle GetWindow(this MentorLake.Gtk.GtkTextViewHandle text_view, MentorLake.Gtk.GtkTextWindowType win)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_window(text_view, win);
	}

	public static MentorLake.Gtk.GtkTextWindowType GetWindowType(this MentorLake.Gtk.GtkTextViewHandle text_view, MentorLake.Gdk.GdkWindowHandle window)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_window_type(text_view, window);
	}

	public static MentorLake.Gtk.GtkWrapMode GetWrapMode(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_wrap_mode(text_view);
	}

	public static bool ImContextFilterKeypress(this MentorLake.Gtk.GtkTextViewHandle text_view, MentorLake.Gdk.GdkEventKeyHandle @event)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_im_context_filter_keypress(text_view, @event);
	}

	public static T MoveChild<T>(this T text_view, MentorLake.Gtk.GtkWidgetHandle child, int xpos, int ypos) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_move_child(text_view, child, xpos, ypos);
		return text_view;
	}

	public static bool MoveMarkOnscreen(this MentorLake.Gtk.GtkTextViewHandle text_view, MentorLake.Gtk.GtkTextMarkHandle mark)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_move_mark_onscreen(text_view, mark);
	}

	public static bool MoveVisually(this MentorLake.Gtk.GtkTextViewHandle text_view, MentorLake.Gtk.GtkTextIterHandle iter, int count)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_move_visually(text_view, iter, count);
	}

	public static bool PlaceCursorOnscreen(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_place_cursor_onscreen(text_view);
	}

	public static T ResetCursorBlink<T>(this T text_view) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_reset_cursor_blink(text_view);
		return text_view;
	}

	public static T ResetImContext<T>(this T text_view) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_reset_im_context(text_view);
		return text_view;
	}

	public static T ScrollMarkOnscreen<T>(this T text_view, MentorLake.Gtk.GtkTextMarkHandle mark) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_scroll_mark_onscreen(text_view, mark);
		return text_view;
	}

	public static bool ScrollToIter(this MentorLake.Gtk.GtkTextViewHandle text_view, MentorLake.Gtk.GtkTextIterHandle iter, double within_margin, bool use_align, double xalign, double yalign)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_scroll_to_iter(text_view, iter, within_margin, use_align, xalign, yalign);
	}

	public static T ScrollToMark<T>(this T text_view, MentorLake.Gtk.GtkTextMarkHandle mark, double within_margin, bool use_align, double xalign, double yalign) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_scroll_to_mark(text_view, mark, within_margin, use_align, xalign, yalign);
		return text_view;
	}

	public static T SetAcceptsTab<T>(this T text_view, bool accepts_tab) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_set_accepts_tab(text_view, accepts_tab);
		return text_view;
	}

	public static T SetBorderWindowSize<T>(this T text_view, MentorLake.Gtk.GtkTextWindowType type, int size) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_set_border_window_size(text_view, type, size);
		return text_view;
	}

	public static T SetBottomMargin<T>(this T text_view, int bottom_margin) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_set_bottom_margin(text_view, bottom_margin);
		return text_view;
	}

	public static T SetBuffer<T>(this T text_view, MentorLake.Gtk.GtkTextBufferHandle buffer) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_set_buffer(text_view, buffer);
		return text_view;
	}

	public static T SetCursorVisible<T>(this T text_view, bool setting) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_set_cursor_visible(text_view, setting);
		return text_view;
	}

	public static T SetEditable<T>(this T text_view, bool setting) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_set_editable(text_view, setting);
		return text_view;
	}

	public static T SetIndent<T>(this T text_view, int indent) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_set_indent(text_view, indent);
		return text_view;
	}

	public static T SetInputHints<T>(this T text_view, MentorLake.Gtk.GtkInputHints hints) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_set_input_hints(text_view, hints);
		return text_view;
	}

	public static T SetInputPurpose<T>(this T text_view, MentorLake.Gtk.GtkInputPurpose purpose) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_set_input_purpose(text_view, purpose);
		return text_view;
	}

	public static T SetJustification<T>(this T text_view, MentorLake.Gtk.GtkJustification justification) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_set_justification(text_view, justification);
		return text_view;
	}

	public static T SetLeftMargin<T>(this T text_view, int left_margin) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_set_left_margin(text_view, left_margin);
		return text_view;
	}

	public static T SetMonospace<T>(this T text_view, bool monospace) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_set_monospace(text_view, monospace);
		return text_view;
	}

	public static T SetOverwrite<T>(this T text_view, bool overwrite) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_set_overwrite(text_view, overwrite);
		return text_view;
	}

	public static T SetPixelsAboveLines<T>(this T text_view, int pixels_above_lines) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_set_pixels_above_lines(text_view, pixels_above_lines);
		return text_view;
	}

	public static T SetPixelsBelowLines<T>(this T text_view, int pixels_below_lines) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_set_pixels_below_lines(text_view, pixels_below_lines);
		return text_view;
	}

	public static T SetPixelsInsideWrap<T>(this T text_view, int pixels_inside_wrap) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_set_pixels_inside_wrap(text_view, pixels_inside_wrap);
		return text_view;
	}

	public static T SetRightMargin<T>(this T text_view, int right_margin) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_set_right_margin(text_view, right_margin);
		return text_view;
	}

	public static T SetTabs<T>(this T text_view, MentorLake.Pango.PangoTabArrayHandle tabs) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_set_tabs(text_view, tabs);
		return text_view;
	}

	public static T SetTopMargin<T>(this T text_view, int top_margin) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_set_top_margin(text_view, top_margin);
		return text_view;
	}

	public static T SetWrapMode<T>(this T text_view, MentorLake.Gtk.GtkWrapMode wrap_mode) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_set_wrap_mode(text_view, wrap_mode);
		return text_view;
	}

	public static bool StartsDisplayLine(this MentorLake.Gtk.GtkTextViewHandle text_view, MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_starts_display_line(text_view, iter);
	}

	public static T WindowToBufferCoords<T>(this T text_view, MentorLake.Gtk.GtkTextWindowType win, int window_x, int window_y, out int buffer_x, out int buffer_y) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_window_to_buffer_coords(text_view, win, window_x, window_y, out buffer_x, out buffer_y);
		return text_view;
	}

}

internal class GtkTextViewHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))]
	internal static extern MentorLake.Gtk.GtkTextViewHandle gtk_text_view_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))]
	internal static extern MentorLake.Gtk.GtkTextViewHandle gtk_text_view_new_with_buffer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_view_add_child_at_anchor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextChildAnchorHandle>))] MentorLake.Gtk.GtkTextChildAnchorHandle anchor);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_view_add_child_in_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, MentorLake.Gtk.GtkTextWindowType which_window, int xpos, int ypos);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_view_backward_display_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_view_backward_display_line_start([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_view_buffer_to_window_coords([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, MentorLake.Gtk.GtkTextWindowType win, int buffer_x, int buffer_y, out int window_x, out int window_y);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_view_forward_display_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_view_forward_display_line_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_view_get_accepts_tab([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_text_view_get_border_window_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, MentorLake.Gtk.GtkTextWindowType type);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_text_view_get_bottom_margin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))]
	internal static extern MentorLake.Gtk.GtkTextBufferHandle gtk_text_view_get_buffer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_view_get_cursor_locations([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, out MentorLake.Gdk.GdkRectangle strong, out MentorLake.Gdk.GdkRectangle weak);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_view_get_cursor_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextAttributesHandle>))]
	internal static extern MentorLake.Gtk.GtkTextAttributesHandle gtk_text_view_get_default_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_view_get_editable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))]
	internal static extern MentorLake.Gtk.GtkAdjustmentHandle gtk_text_view_get_hadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_text_view_get_indent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkInputHints gtk_text_view_get_input_hints([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkInputPurpose gtk_text_view_get_input_purpose([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_view_get_iter_at_location([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, out MentorLake.Gtk.GtkTextIter iter, int x, int y);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_view_get_iter_at_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, out MentorLake.Gtk.GtkTextIter iter, out int trailing, int x, int y);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_view_get_iter_location([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, out MentorLake.Gdk.GdkRectangle location);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkJustification gtk_text_view_get_justification([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_text_view_get_left_margin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_view_get_line_at_y([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, out MentorLake.Gtk.GtkTextIter target_iter, int y, out int line_top);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_view_get_line_yrange([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, out int y, out int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_view_get_monospace([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_view_get_overwrite([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_text_view_get_pixels_above_lines([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_text_view_get_pixels_below_lines([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_text_view_get_pixels_inside_wrap([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_text_view_get_right_margin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoTabArrayHandle>))]
	internal static extern MentorLake.Pango.PangoTabArrayHandle gtk_text_view_get_tabs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_text_view_get_top_margin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))]
	internal static extern MentorLake.Gtk.GtkAdjustmentHandle gtk_text_view_get_vadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_view_get_visible_rect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, out MentorLake.Gdk.GdkRectangle visible_rect);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gtk_text_view_get_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, MentorLake.Gtk.GtkTextWindowType win);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTextWindowType gtk_text_view_get_window_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWrapMode gtk_text_view_get_wrap_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_view_im_context_filter_keypress([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventKeyHandle>))] MentorLake.Gdk.GdkEventKeyHandle @event);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_view_move_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, int xpos, int ypos);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_view_move_mark_onscreen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextMarkHandle>))] MentorLake.Gtk.GtkTextMarkHandle mark);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_view_move_visually([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, int count);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_view_place_cursor_onscreen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_view_reset_cursor_blink([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_view_reset_im_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_view_scroll_mark_onscreen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextMarkHandle>))] MentorLake.Gtk.GtkTextMarkHandle mark);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_view_scroll_to_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, double within_margin, bool use_align, double xalign, double yalign);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_view_scroll_to_mark([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextMarkHandle>))] MentorLake.Gtk.GtkTextMarkHandle mark, double within_margin, bool use_align, double xalign, double yalign);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_view_set_accepts_tab([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, bool accepts_tab);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_view_set_border_window_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, MentorLake.Gtk.GtkTextWindowType type, int size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_view_set_bottom_margin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, int bottom_margin);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_view_set_buffer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_view_set_cursor_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_view_set_editable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_view_set_indent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, int indent);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_view_set_input_hints([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, MentorLake.Gtk.GtkInputHints hints);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_view_set_input_purpose([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, MentorLake.Gtk.GtkInputPurpose purpose);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_view_set_justification([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, MentorLake.Gtk.GtkJustification justification);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_view_set_left_margin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, int left_margin);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_view_set_monospace([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, bool monospace);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_view_set_overwrite([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, bool overwrite);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_view_set_pixels_above_lines([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, int pixels_above_lines);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_view_set_pixels_below_lines([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, int pixels_below_lines);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_view_set_pixels_inside_wrap([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, int pixels_inside_wrap);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_view_set_right_margin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, int right_margin);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_view_set_tabs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoTabArrayHandle>))] MentorLake.Pango.PangoTabArrayHandle tabs);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_view_set_top_margin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, int top_margin);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_view_set_wrap_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, MentorLake.Gtk.GtkWrapMode wrap_mode);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_view_starts_display_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_view_window_to_buffer_coords([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle text_view, MentorLake.Gtk.GtkTextWindowType win, int window_x, int window_y, out int buffer_x, out int buffer_y);

}
