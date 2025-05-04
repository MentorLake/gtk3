namespace MentorLake.Gtk;

public class GtkSearchEntryHandle : GtkEntryHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkCellEditableHandle, GtkEditableHandle
{
	public static MentorLake.Gtk.GtkSearchEntryHandle New()
	{
		return GtkSearchEntryHandleExterns.gtk_search_entry_new();
	}

}
public static class GtkSearchEntryHandleSignalExtensions
{

	public static IObservable<GtkSearchEntryHandleSignalStructs.NextMatchSignal> Signal_NextMatch(this GtkSearchEntryHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkSearchEntryHandleSignalStructs.NextMatchSignal> obs) =>
		{
			GtkSearchEntryHandleSignalDelegates.next_match handler = ( MentorLake.Gtk.GtkSearchEntryHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSearchEntryHandleSignalStructs.NextMatchSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "next-match", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkSearchEntryHandleSignalStructs.PreviousMatchSignal> Signal_PreviousMatch(this GtkSearchEntryHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkSearchEntryHandleSignalStructs.PreviousMatchSignal> obs) =>
		{
			GtkSearchEntryHandleSignalDelegates.previous_match handler = ( MentorLake.Gtk.GtkSearchEntryHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSearchEntryHandleSignalStructs.PreviousMatchSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "previous-match", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkSearchEntryHandleSignalStructs.SearchChangedSignal> Signal_SearchChanged(this GtkSearchEntryHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkSearchEntryHandleSignalStructs.SearchChangedSignal> obs) =>
		{
			GtkSearchEntryHandleSignalDelegates.search_changed handler = ( MentorLake.Gtk.GtkSearchEntryHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSearchEntryHandleSignalStructs.SearchChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "search-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkSearchEntryHandleSignalStructs.StopSearchSignal> Signal_StopSearch(this GtkSearchEntryHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkSearchEntryHandleSignalStructs.StopSearchSignal> obs) =>
		{
			GtkSearchEntryHandleSignalDelegates.stop_search handler = ( MentorLake.Gtk.GtkSearchEntryHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSearchEntryHandleSignalStructs.StopSearchSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "stop-search", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkSearchEntryHandleSignalStructs.EditingDoneSignal> Signal_EditingDone(this GtkSearchEntryHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkSearchEntryHandleSignalStructs.EditingDoneSignal> obs) =>
		{
			GtkSearchEntryHandleSignalDelegates.editing_done handler = ( MentorLake.Gtk.GtkCellEditableHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSearchEntryHandleSignalStructs.EditingDoneSignal()
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

	public static IObservable<GtkSearchEntryHandleSignalStructs.RemoveWidgetSignal> Signal_RemoveWidget(this GtkSearchEntryHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkSearchEntryHandleSignalStructs.RemoveWidgetSignal> obs) =>
		{
			GtkSearchEntryHandleSignalDelegates.remove_widget handler = ( MentorLake.Gtk.GtkCellEditableHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSearchEntryHandleSignalStructs.RemoveWidgetSignal()
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

	public static IObservable<GtkSearchEntryHandleSignalStructs.ChangedSignal> Signal_Changed(this GtkSearchEntryHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkSearchEntryHandleSignalStructs.ChangedSignal> obs) =>
		{
			GtkSearchEntryHandleSignalDelegates.changed handler = ( MentorLake.Gtk.GtkEditableHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSearchEntryHandleSignalStructs.ChangedSignal()
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

	public static IObservable<GtkSearchEntryHandleSignalStructs.DeleteTextSignal> Signal_DeleteText(this GtkSearchEntryHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkSearchEntryHandleSignalStructs.DeleteTextSignal> obs) =>
		{
			GtkSearchEntryHandleSignalDelegates.delete_text handler = ( MentorLake.Gtk.GtkEditableHandle self,  int start_pos,  int end_pos,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSearchEntryHandleSignalStructs.DeleteTextSignal()
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

	public static IObservable<GtkSearchEntryHandleSignalStructs.InsertTextSignal> Signal_InsertText(this GtkSearchEntryHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkSearchEntryHandleSignalStructs.InsertTextSignal> obs) =>
		{
			GtkSearchEntryHandleSignalDelegates.insert_text handler = ( MentorLake.Gtk.GtkEditableHandle self,  string new_text,  int new_text_length, ref int position,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSearchEntryHandleSignalStructs.InsertTextSignal()
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

public static class GtkSearchEntryHandleSignalStructs
{

public class NextMatchSignal
{
	public MentorLake.Gtk.GtkSearchEntryHandle Self;
	public IntPtr UserData;
}

public class PreviousMatchSignal
{
	public MentorLake.Gtk.GtkSearchEntryHandle Self;
	public IntPtr UserData;
}

public class SearchChangedSignal
{
	public MentorLake.Gtk.GtkSearchEntryHandle Self;
	public IntPtr UserData;
}

public class StopSearchSignal
{
	public MentorLake.Gtk.GtkSearchEntryHandle Self;
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

public static class GtkSearchEntryHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void next_match([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSearchEntryHandle>))] MentorLake.Gtk.GtkSearchEntryHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void previous_match([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSearchEntryHandle>))] MentorLake.Gtk.GtkSearchEntryHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void search_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSearchEntryHandle>))] MentorLake.Gtk.GtkSearchEntryHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void stop_search([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSearchEntryHandle>))] MentorLake.Gtk.GtkSearchEntryHandle self, IntPtr user_data);


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


public static class GtkSearchEntryHandleExtensions
{
	public static bool HandleEvent(this MentorLake.Gtk.GtkSearchEntryHandle entry, MentorLake.Gdk.GdkEventHandle @event)
	{
		if (entry.IsInvalid || entry.IsClosed) throw new Exception("Invalid or closed handle (GtkSearchEntryHandle)");
		return GtkSearchEntryHandleExterns.gtk_search_entry_handle_event(entry, @event);
	}

}

internal class GtkSearchEntryHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkSearchEntryHandle gtk_search_entry_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_search_entry_handle_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSearchEntryHandle>))] MentorLake.Gtk.GtkSearchEntryHandle entry, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

}
