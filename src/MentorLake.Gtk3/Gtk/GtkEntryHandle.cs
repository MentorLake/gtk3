namespace MentorLake.Gtk;

public class GtkEntryHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkCellEditableHandle, GtkEditableHandle
{
	public static MentorLake.Gtk.GtkEntryHandle New()
	{
		return GtkEntryHandleExterns.gtk_entry_new();
	}

	public static MentorLake.Gtk.GtkEntryHandle NewWithBuffer(MentorLake.Gtk.GtkEntryBufferHandle buffer)
	{
		return GtkEntryHandleExterns.gtk_entry_new_with_buffer(buffer);
	}

}
public static class GtkEntryHandleSignalExtensions
{

	public static IObservable<GtkEntryHandleSignalStructs.ActivateSignal> Signal_Activate(this GtkEntryHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEntryHandleSignalStructs.ActivateSignal> obs) =>
		{
			GtkEntryHandleSignalDelegates.activate handler = ( MentorLake.Gtk.GtkEntryHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryHandleSignalStructs.ActivateSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkEntryHandleSignalStructs.BackspaceSignal> Signal_Backspace(this GtkEntryHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEntryHandleSignalStructs.BackspaceSignal> obs) =>
		{
			GtkEntryHandleSignalDelegates.backspace handler = ( MentorLake.Gtk.GtkEntryHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryHandleSignalStructs.BackspaceSignal()
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

	public static IObservable<GtkEntryHandleSignalStructs.CopyClipboardSignal> Signal_CopyClipboard(this GtkEntryHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEntryHandleSignalStructs.CopyClipboardSignal> obs) =>
		{
			GtkEntryHandleSignalDelegates.copy_clipboard handler = ( MentorLake.Gtk.GtkEntryHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryHandleSignalStructs.CopyClipboardSignal()
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

	public static IObservable<GtkEntryHandleSignalStructs.CutClipboardSignal> Signal_CutClipboard(this GtkEntryHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEntryHandleSignalStructs.CutClipboardSignal> obs) =>
		{
			GtkEntryHandleSignalDelegates.cut_clipboard handler = ( MentorLake.Gtk.GtkEntryHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryHandleSignalStructs.CutClipboardSignal()
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

	public static IObservable<GtkEntryHandleSignalStructs.DeleteFromCursorSignal> Signal_DeleteFromCursor(this GtkEntryHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEntryHandleSignalStructs.DeleteFromCursorSignal> obs) =>
		{
			GtkEntryHandleSignalDelegates.delete_from_cursor handler = ( MentorLake.Gtk.GtkEntryHandle self,  MentorLake.Gtk.GtkDeleteType type,  int count,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryHandleSignalStructs.DeleteFromCursorSignal()
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

	public static IObservable<GtkEntryHandleSignalStructs.IconPressSignal> Signal_IconPress(this GtkEntryHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEntryHandleSignalStructs.IconPressSignal> obs) =>
		{
			GtkEntryHandleSignalDelegates.icon_press handler = ( MentorLake.Gtk.GtkEntryHandle self,  MentorLake.Gtk.GtkEntryIconPosition icon_pos,  MentorLake.Gdk.GdkEventHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryHandleSignalStructs.IconPressSignal()
				{
					Self = self, IconPos = icon_pos, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "icon-press", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkEntryHandleSignalStructs.IconReleaseSignal> Signal_IconRelease(this GtkEntryHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEntryHandleSignalStructs.IconReleaseSignal> obs) =>
		{
			GtkEntryHandleSignalDelegates.icon_release handler = ( MentorLake.Gtk.GtkEntryHandle self,  MentorLake.Gtk.GtkEntryIconPosition icon_pos,  MentorLake.Gdk.GdkEventHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryHandleSignalStructs.IconReleaseSignal()
				{
					Self = self, IconPos = icon_pos, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "icon-release", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkEntryHandleSignalStructs.InsertAtCursorSignal> Signal_InsertAtCursor(this GtkEntryHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEntryHandleSignalStructs.InsertAtCursorSignal> obs) =>
		{
			GtkEntryHandleSignalDelegates.insert_at_cursor handler = ( MentorLake.Gtk.GtkEntryHandle self,  string @string,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryHandleSignalStructs.InsertAtCursorSignal()
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

	public static IObservable<GtkEntryHandleSignalStructs.InsertEmojiSignal> Signal_InsertEmoji(this GtkEntryHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEntryHandleSignalStructs.InsertEmojiSignal> obs) =>
		{
			GtkEntryHandleSignalDelegates.insert_emoji handler = ( MentorLake.Gtk.GtkEntryHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryHandleSignalStructs.InsertEmojiSignal()
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

	public static IObservable<GtkEntryHandleSignalStructs.MoveCursorSignal> Signal_MoveCursor(this GtkEntryHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEntryHandleSignalStructs.MoveCursorSignal> obs) =>
		{
			GtkEntryHandleSignalDelegates.move_cursor handler = ( MentorLake.Gtk.GtkEntryHandle self,  MentorLake.Gtk.GtkMovementStep step,  int count,  bool extend_selection,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryHandleSignalStructs.MoveCursorSignal()
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

	public static IObservable<GtkEntryHandleSignalStructs.PasteClipboardSignal> Signal_PasteClipboard(this GtkEntryHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEntryHandleSignalStructs.PasteClipboardSignal> obs) =>
		{
			GtkEntryHandleSignalDelegates.paste_clipboard handler = ( MentorLake.Gtk.GtkEntryHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryHandleSignalStructs.PasteClipboardSignal()
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

	public static IObservable<GtkEntryHandleSignalStructs.PopulatePopupSignal> Signal_PopulatePopup(this GtkEntryHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEntryHandleSignalStructs.PopulatePopupSignal> obs) =>
		{
			GtkEntryHandleSignalDelegates.populate_popup handler = ( MentorLake.Gtk.GtkEntryHandle self,  MentorLake.Gtk.GtkWidgetHandle widget,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryHandleSignalStructs.PopulatePopupSignal()
				{
					Self = self, Widget = widget, UserData = user_data
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

	public static IObservable<GtkEntryHandleSignalStructs.PreeditChangedSignal> Signal_PreeditChanged(this GtkEntryHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEntryHandleSignalStructs.PreeditChangedSignal> obs) =>
		{
			GtkEntryHandleSignalDelegates.preedit_changed handler = ( MentorLake.Gtk.GtkEntryHandle self,  string preedit,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryHandleSignalStructs.PreeditChangedSignal()
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

	public static IObservable<GtkEntryHandleSignalStructs.ToggleOverwriteSignal> Signal_ToggleOverwrite(this GtkEntryHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEntryHandleSignalStructs.ToggleOverwriteSignal> obs) =>
		{
			GtkEntryHandleSignalDelegates.toggle_overwrite handler = ( MentorLake.Gtk.GtkEntryHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryHandleSignalStructs.ToggleOverwriteSignal()
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

	public static IObservable<GtkEntryHandleSignalStructs.EditingDoneSignal> Signal_EditingDone(this GtkEntryHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEntryHandleSignalStructs.EditingDoneSignal> obs) =>
		{
			GtkEntryHandleSignalDelegates.editing_done handler = ( MentorLake.Gtk.GtkCellEditableHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryHandleSignalStructs.EditingDoneSignal()
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

	public static IObservable<GtkEntryHandleSignalStructs.RemoveWidgetSignal> Signal_RemoveWidget(this GtkEntryHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEntryHandleSignalStructs.RemoveWidgetSignal> obs) =>
		{
			GtkEntryHandleSignalDelegates.remove_widget handler = ( MentorLake.Gtk.GtkCellEditableHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryHandleSignalStructs.RemoveWidgetSignal()
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

	public static IObservable<GtkEntryHandleSignalStructs.ChangedSignal> Signal_Changed(this GtkEntryHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEntryHandleSignalStructs.ChangedSignal> obs) =>
		{
			GtkEntryHandleSignalDelegates.changed handler = ( MentorLake.Gtk.GtkEditableHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryHandleSignalStructs.ChangedSignal()
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

	public static IObservable<GtkEntryHandleSignalStructs.DeleteTextSignal> Signal_DeleteText(this GtkEntryHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEntryHandleSignalStructs.DeleteTextSignal> obs) =>
		{
			GtkEntryHandleSignalDelegates.delete_text handler = ( MentorLake.Gtk.GtkEditableHandle self,  int start_pos,  int end_pos,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryHandleSignalStructs.DeleteTextSignal()
				{
					Self = self, StartPos = start_pos, EndPos = end_pos, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "delete-text", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkEntryHandleSignalStructs.InsertTextSignal> Signal_InsertText(this GtkEntryHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEntryHandleSignalStructs.InsertTextSignal> obs) =>
		{
			GtkEntryHandleSignalDelegates.insert_text handler = ( MentorLake.Gtk.GtkEditableHandle self,  string new_text,  int new_text_length, ref int position,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryHandleSignalStructs.InsertTextSignal()
				{
					Self = self, NewText = new_text, NewTextLength = new_text_length, Position = position, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "insert-text", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkEntryHandleSignalStructs
{

public class ActivateSignal
{
	public MentorLake.Gtk.GtkEntryHandle Self;
	public IntPtr UserData;
}

public class BackspaceSignal
{
	public MentorLake.Gtk.GtkEntryHandle Self;
	public IntPtr UserData;
}

public class CopyClipboardSignal
{
	public MentorLake.Gtk.GtkEntryHandle Self;
	public IntPtr UserData;
}

public class CutClipboardSignal
{
	public MentorLake.Gtk.GtkEntryHandle Self;
	public IntPtr UserData;
}

public class DeleteFromCursorSignal
{
	public MentorLake.Gtk.GtkEntryHandle Self;
	public MentorLake.Gtk.GtkDeleteType Type;
	public int Count;
	public IntPtr UserData;
}

public class IconPressSignal
{
	public MentorLake.Gtk.GtkEntryHandle Self;
	public MentorLake.Gtk.GtkEntryIconPosition IconPos;
	public MentorLake.Gdk.GdkEventHandle Event;
	public IntPtr UserData;
}

public class IconReleaseSignal
{
	public MentorLake.Gtk.GtkEntryHandle Self;
	public MentorLake.Gtk.GtkEntryIconPosition IconPos;
	public MentorLake.Gdk.GdkEventHandle Event;
	public IntPtr UserData;
}

public class InsertAtCursorSignal
{
	public MentorLake.Gtk.GtkEntryHandle Self;
	public string String;
	public IntPtr UserData;
}

public class InsertEmojiSignal
{
	public MentorLake.Gtk.GtkEntryHandle Self;
	public IntPtr UserData;
}

public class MoveCursorSignal
{
	public MentorLake.Gtk.GtkEntryHandle Self;
	public MentorLake.Gtk.GtkMovementStep Step;
	public int Count;
	public bool ExtendSelection;
	public IntPtr UserData;
}

public class PasteClipboardSignal
{
	public MentorLake.Gtk.GtkEntryHandle Self;
	public IntPtr UserData;
}

public class PopulatePopupSignal
{
	public MentorLake.Gtk.GtkEntryHandle Self;
	public MentorLake.Gtk.GtkWidgetHandle Widget;
	public IntPtr UserData;
}

public class PreeditChangedSignal
{
	public MentorLake.Gtk.GtkEntryHandle Self;
	public string Preedit;
	public IntPtr UserData;
}

public class ToggleOverwriteSignal
{
	public MentorLake.Gtk.GtkEntryHandle Self;
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

public class ChangedSignal
{
	public MentorLake.Gtk.GtkEditableHandle Self;
	public IntPtr UserData;
}

public class DeleteTextSignal
{
	public MentorLake.Gtk.GtkEditableHandle Self;
	public int StartPos;
	public int EndPos;
	public IntPtr UserData;
}

public class InsertTextSignal
{
	public MentorLake.Gtk.GtkEditableHandle Self;
	public string NewText;
	public int NewTextLength;
	public int Position;
	public IntPtr UserData;
}
}

public static class GtkEntryHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void backspace([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void copy_clipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void cut_clipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void delete_from_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle self, MentorLake.Gtk.GtkDeleteType type, int count, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void icon_press([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle self, MentorLake.Gtk.GtkEntryIconPosition icon_pos, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void icon_release([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle self, MentorLake.Gtk.GtkEntryIconPosition icon_pos, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void insert_at_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle self, string @string, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void insert_emoji([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void move_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle self, MentorLake.Gtk.GtkMovementStep step, int count, bool extend_selection, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void paste_clipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void populate_popup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void preedit_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle self, string preedit, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void toggle_overwrite([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void editing_done([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellEditableHandleImpl>))] MentorLake.Gtk.GtkCellEditableHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void remove_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellEditableHandleImpl>))] MentorLake.Gtk.GtkCellEditableHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEditableHandleImpl>))] MentorLake.Gtk.GtkEditableHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void delete_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEditableHandleImpl>))] MentorLake.Gtk.GtkEditableHandle self, int start_pos, int end_pos, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void insert_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEditableHandleImpl>))] MentorLake.Gtk.GtkEditableHandle self, string new_text, int new_text_length, ref int position, IntPtr user_data);

}


public static class GtkEntryHandleExtensions
{
	public static bool GetActivatesDefault(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_activates_default(entry);
	}

	public static float GetAlignment(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_alignment(entry);
	}

	public static MentorLake.Pango.PangoAttrListHandle GetAttributes(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_attributes(entry);
	}

	public static MentorLake.Gtk.GtkEntryBufferHandle GetBuffer(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_buffer(entry);
	}

	public static MentorLake.Gtk.GtkEntryCompletionHandle GetCompletion(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_completion(entry);
	}

	public static int GetCurrentIconDragSource(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_current_icon_drag_source(entry);
	}

	public static MentorLake.Gtk.GtkAdjustmentHandle GetCursorHadjustment(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_cursor_hadjustment(entry);
	}

	public static bool GetHasFrame(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_has_frame(entry);
	}

	public static bool GetIconActivatable(this MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos)
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_icon_activatable(entry, icon_pos);
	}

	public static T GetIconArea<T>(this T entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos, out MentorLake.Gdk.GdkRectangle icon_area) where T : GtkEntryHandle
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_get_icon_area(entry, icon_pos, out icon_area);
		return entry;
	}

	public static int GetIconAtPos(this MentorLake.Gtk.GtkEntryHandle entry, int x, int y)
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_icon_at_pos(entry, x, y);
	}

	public static MentorLake.Gio.GIconHandle GetIconGicon(this MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos)
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_icon_gicon(entry, icon_pos);
	}

	public static string GetIconName(this MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos)
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_icon_name(entry, icon_pos);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle GetIconPixbuf(this MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos)
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_icon_pixbuf(entry, icon_pos);
	}

	public static bool GetIconSensitive(this MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos)
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_icon_sensitive(entry, icon_pos);
	}

	public static string GetIconStock(this MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos)
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_icon_stock(entry, icon_pos);
	}

	public static MentorLake.Gtk.GtkImageType GetIconStorageType(this MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos)
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_icon_storage_type(entry, icon_pos);
	}

	public static string GetIconTooltipMarkup(this MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos)
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_icon_tooltip_markup(entry, icon_pos);
	}

	public static string GetIconTooltipText(this MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos)
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_icon_tooltip_text(entry, icon_pos);
	}

	public static MentorLake.Gtk.GtkBorderHandle GetInnerBorder(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_inner_border(entry);
	}

	public static MentorLake.Gtk.GtkInputHints GetInputHints(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_input_hints(entry);
	}

	public static MentorLake.Gtk.GtkInputPurpose GetInputPurpose(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_input_purpose(entry);
	}

	public static char GetInvisibleChar(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_invisible_char(entry);
	}

	public static MentorLake.Pango.PangoLayoutHandle GetLayout(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_layout(entry);
	}

	public static T GetLayoutOffsets<T>(this T entry, out int x, out int y) where T : GtkEntryHandle
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_get_layout_offsets(entry, out x, out y);
		return entry;
	}

	public static int GetMaxLength(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_max_length(entry);
	}

	public static int GetMaxWidthChars(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_max_width_chars(entry);
	}

	public static bool GetOverwriteMode(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_overwrite_mode(entry);
	}

	public static string GetPlaceholderText(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_placeholder_text(entry);
	}

	public static double GetProgressFraction(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_progress_fraction(entry);
	}

	public static double GetProgressPulseStep(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_progress_pulse_step(entry);
	}

	public static MentorLake.Pango.PangoTabArrayHandle GetTabs(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_tabs(entry);
	}

	public static string GetText(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_text(entry);
	}

	public static T GetTextArea<T>(this T entry, out MentorLake.Gdk.GdkRectangle text_area) where T : GtkEntryHandle
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_get_text_area(entry, out text_area);
		return entry;
	}

	public static ushort GetTextLength(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_text_length(entry);
	}

	public static bool GetVisibility(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_visibility(entry);
	}

	public static int GetWidthChars(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_width_chars(entry);
	}

	public static T GrabFocusWithoutSelecting<T>(this T entry) where T : GtkEntryHandle
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_grab_focus_without_selecting(entry);
		return entry;
	}

	public static bool ImContextFilterKeypress(this MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gdk.GdkEventKeyHandle @event)
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_im_context_filter_keypress(entry, @event);
	}

	public static int LayoutIndexToTextIndex(this MentorLake.Gtk.GtkEntryHandle entry, int layout_index)
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_layout_index_to_text_index(entry, layout_index);
	}

	public static T ProgressPulse<T>(this T entry) where T : GtkEntryHandle
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_progress_pulse(entry);
		return entry;
	}

	public static T ResetImContext<T>(this T entry) where T : GtkEntryHandle
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_reset_im_context(entry);
		return entry;
	}

	public static T SetActivatesDefault<T>(this T entry, bool setting) where T : GtkEntryHandle
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_activates_default(entry, setting);
		return entry;
	}

	public static T SetAlignment<T>(this T entry, float xalign) where T : GtkEntryHandle
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_alignment(entry, xalign);
		return entry;
	}

	public static T SetAttributes<T>(this T entry, MentorLake.Pango.PangoAttrListHandle attrs) where T : GtkEntryHandle
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_attributes(entry, attrs);
		return entry;
	}

	public static T SetBuffer<T>(this T entry, MentorLake.Gtk.GtkEntryBufferHandle buffer) where T : GtkEntryHandle
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_buffer(entry, buffer);
		return entry;
	}

	public static T SetCompletion<T>(this T entry, MentorLake.Gtk.GtkEntryCompletionHandle completion) where T : GtkEntryHandle
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_completion(entry, completion);
		return entry;
	}

	public static T SetCursorHadjustment<T>(this T entry, MentorLake.Gtk.GtkAdjustmentHandle adjustment) where T : GtkEntryHandle
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_cursor_hadjustment(entry, adjustment);
		return entry;
	}

	public static T SetHasFrame<T>(this T entry, bool setting) where T : GtkEntryHandle
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_has_frame(entry, setting);
		return entry;
	}

	public static T SetIconActivatable<T>(this T entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos, bool activatable) where T : GtkEntryHandle
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_icon_activatable(entry, icon_pos, activatable);
		return entry;
	}

	public static T SetIconDragSource<T>(this T entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos, MentorLake.Gtk.GtkTargetListHandle target_list, MentorLake.Gdk.GdkDragAction actions) where T : GtkEntryHandle
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_icon_drag_source(entry, icon_pos, target_list, actions);
		return entry;
	}

	public static T SetIconFromGicon<T>(this T entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos, MentorLake.Gio.GIconHandle icon) where T : GtkEntryHandle
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_icon_from_gicon(entry, icon_pos, icon);
		return entry;
	}

	public static T SetIconFromIconName<T>(this T entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos, string icon_name) where T : GtkEntryHandle
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_icon_from_icon_name(entry, icon_pos, icon_name);
		return entry;
	}

	public static T SetIconFromPixbuf<T>(this T entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos, MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf) where T : GtkEntryHandle
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_icon_from_pixbuf(entry, icon_pos, pixbuf);
		return entry;
	}

	public static T SetIconFromStock<T>(this T entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos, string stock_id) where T : GtkEntryHandle
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_icon_from_stock(entry, icon_pos, stock_id);
		return entry;
	}

	public static T SetIconSensitive<T>(this T entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos, bool sensitive) where T : GtkEntryHandle
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_icon_sensitive(entry, icon_pos, sensitive);
		return entry;
	}

	public static T SetIconTooltipMarkup<T>(this T entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos, string tooltip) where T : GtkEntryHandle
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_icon_tooltip_markup(entry, icon_pos, tooltip);
		return entry;
	}

	public static T SetIconTooltipText<T>(this T entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos, string tooltip) where T : GtkEntryHandle
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_icon_tooltip_text(entry, icon_pos, tooltip);
		return entry;
	}

	public static T SetInnerBorder<T>(this T entry, MentorLake.Gtk.GtkBorderHandle border) where T : GtkEntryHandle
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_inner_border(entry, border);
		return entry;
	}

	public static T SetInputHints<T>(this T entry, MentorLake.Gtk.GtkInputHints hints) where T : GtkEntryHandle
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_input_hints(entry, hints);
		return entry;
	}

	public static T SetInputPurpose<T>(this T entry, MentorLake.Gtk.GtkInputPurpose purpose) where T : GtkEntryHandle
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_input_purpose(entry, purpose);
		return entry;
	}

	public static T SetInvisibleChar<T>(this T entry, char ch) where T : GtkEntryHandle
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_invisible_char(entry, ch);
		return entry;
	}

	public static T SetMaxLength<T>(this T entry, int max) where T : GtkEntryHandle
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_max_length(entry, max);
		return entry;
	}

	public static T SetMaxWidthChars<T>(this T entry, int n_chars) where T : GtkEntryHandle
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_max_width_chars(entry, n_chars);
		return entry;
	}

	public static T SetOverwriteMode<T>(this T entry, bool overwrite) where T : GtkEntryHandle
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_overwrite_mode(entry, overwrite);
		return entry;
	}

	public static T SetPlaceholderText<T>(this T entry, string text) where T : GtkEntryHandle
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_placeholder_text(entry, text);
		return entry;
	}

	public static T SetProgressFraction<T>(this T entry, double fraction) where T : GtkEntryHandle
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_progress_fraction(entry, fraction);
		return entry;
	}

	public static T SetProgressPulseStep<T>(this T entry, double fraction) where T : GtkEntryHandle
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_progress_pulse_step(entry, fraction);
		return entry;
	}

	public static T SetTabs<T>(this T entry, MentorLake.Pango.PangoTabArrayHandle tabs) where T : GtkEntryHandle
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_tabs(entry, tabs);
		return entry;
	}

	public static T SetText<T>(this T entry, string text) where T : GtkEntryHandle
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_text(entry, text);
		return entry;
	}

	public static T SetVisibility<T>(this T entry, bool visible) where T : GtkEntryHandle
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_visibility(entry, visible);
		return entry;
	}

	public static T SetWidthChars<T>(this T entry, int n_chars) where T : GtkEntryHandle
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_width_chars(entry, n_chars);
		return entry;
	}

	public static int TextIndexToLayoutIndex(this MentorLake.Gtk.GtkEntryHandle entry, int text_index)
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_text_index_to_layout_index(entry, text_index);
	}

	public static T UnsetInvisibleChar<T>(this T entry) where T : GtkEntryHandle
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_unset_invisible_char(entry);
		return entry;
	}

}

internal class GtkEntryHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkEntryHandle gtk_entry_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkEntryHandle gtk_entry_new_with_buffer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryBufferHandle>))] MentorLake.Gtk.GtkEntryBufferHandle buffer);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_entry_get_activates_default([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry);

	[DllImport(GtkLibrary.Name)]
	internal static extern float gtk_entry_get_alignment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttrListHandle gtk_entry_get_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkEntryBufferHandle gtk_entry_get_buffer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkEntryCompletionHandle gtk_entry_get_completion([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_entry_get_current_icon_drag_source([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkAdjustmentHandle gtk_entry_get_cursor_hadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_entry_get_has_frame([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_entry_get_icon_activatable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_get_icon_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos, out MentorLake.Gdk.GdkRectangle icon_area);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_entry_get_icon_at_pos([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, int x, int y);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gio.GIconHandle gtk_entry_get_icon_gicon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_entry_get_icon_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_entry_get_icon_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_entry_get_icon_sensitive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_entry_get_icon_stock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkImageType gtk_entry_get_icon_storage_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_entry_get_icon_tooltip_markup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_entry_get_icon_tooltip_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkBorderHandle gtk_entry_get_inner_border([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkInputHints gtk_entry_get_input_hints([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkInputPurpose gtk_entry_get_input_purpose([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry);

	[DllImport(GtkLibrary.Name)]
	internal static extern char gtk_entry_get_invisible_char([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Pango.PangoLayoutHandle gtk_entry_get_layout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_get_layout_offsets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, out int x, out int y);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_entry_get_max_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_entry_get_max_width_chars([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_entry_get_overwrite_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_entry_get_placeholder_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_entry_get_progress_fraction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_entry_get_progress_pulse_step([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Pango.PangoTabArrayHandle gtk_entry_get_tabs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_entry_get_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_get_text_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, out MentorLake.Gdk.GdkRectangle text_area);

	[DllImport(GtkLibrary.Name)]
	internal static extern ushort gtk_entry_get_text_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_entry_get_visibility([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_entry_get_width_chars([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_grab_focus_without_selecting([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_entry_im_context_filter_keypress([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventKeyHandle>))] MentorLake.Gdk.GdkEventKeyHandle @event);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_entry_layout_index_to_text_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, int layout_index);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_progress_pulse([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_reset_im_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_set_activates_default([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_set_alignment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, float xalign);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_set_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle attrs);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_set_buffer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryBufferHandle>))] MentorLake.Gtk.GtkEntryBufferHandle buffer);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_set_completion([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryCompletionHandle>))] MentorLake.Gtk.GtkEntryCompletionHandle completion);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_set_cursor_hadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_set_has_frame([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_set_icon_activatable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos, bool activatable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_set_icon_drag_source([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTargetListHandle>))] MentorLake.Gtk.GtkTargetListHandle target_list, MentorLake.Gdk.GdkDragAction actions);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_set_icon_from_gicon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_set_icon_from_icon_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos, string icon_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_set_icon_from_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_set_icon_from_stock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos, string stock_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_set_icon_sensitive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos, bool sensitive);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_set_icon_tooltip_markup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos, string tooltip);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_set_icon_tooltip_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos, string tooltip);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_set_inner_border([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBorderHandle>))] MentorLake.Gtk.GtkBorderHandle border);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_set_input_hints([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gtk.GtkInputHints hints);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_set_input_purpose([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gtk.GtkInputPurpose purpose);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_set_invisible_char([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, char ch);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_set_max_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, int max);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_set_max_width_chars([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, int n_chars);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_set_overwrite_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, bool overwrite);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_set_placeholder_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, string text);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_set_progress_fraction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, double fraction);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_set_progress_pulse_step([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, double fraction);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_set_tabs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoTabArrayHandle>))] MentorLake.Pango.PangoTabArrayHandle tabs);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_set_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, string text);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_set_visibility([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, bool visible);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_set_width_chars([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, int n_chars);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_entry_text_index_to_layout_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, int text_index);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_unset_invisible_char([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry);

}
