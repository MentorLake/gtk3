namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkSearchEntry is a subclass of #GtkEntry that has been
/// tailored for use as a search entry.
/// </para>
/// <para>
/// It will show an inactive symbolic “find” icon when the search
/// entry is empty, and a symbolic “clear” icon when there is text.
/// Clicking on the “clear” icon will empty the search entry.
/// </para>
/// <para>
/// Note that the search/clear icon is shown using a secondary
/// icon, and thus does not work if you are using the secondary
/// icon position for some other purpose.
/// </para>
/// <para>
/// To make filtering appear more reactive, it is a good idea to
/// not react to every change in the entry text immediately, but
/// only after a short delay. To support this, #GtkSearchEntry
/// emits the #GtkSearchEntry::search-changed signal which can
/// be used instead of the #GtkEditable::changed signal.
/// </para>
/// <para>
/// The #GtkSearchEntry::previous-match, #GtkSearchEntry::next-match
/// and #GtkSearchEntry::stop-search signals can be used to implement
/// moving between search results and ending the search.
/// </para>
/// <para>
/// Often, GtkSearchEntry will be fed events by means of being
/// placed inside a #GtkSearchBar. If that is not the case,
/// you can use gtk_search_entry_handle_event() to pass events.
/// </para>
/// </summary>

public class GtkSearchEntryHandle : GtkEntryHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkCellEditableHandle, GtkEditableHandle
{
/// <summary>
/// <para>
/// Creates a #GtkSearchEntry, with a find icon when the search field is
/// empty, and a clear icon when it isn't.
/// </para>
/// </summary>

/// <return>
/// a new #GtkSearchEntry
/// </return>

	public static MentorLake.Gtk.GtkSearchEntryHandle New()
	{
		return GtkSearchEntryHandleExterns.gtk_search_entry_new();
	}

}
public static class GtkSearchEntryHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::next-match signal is a [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user initiates a move to the next match
/// for the current search string.
/// </para>
/// <para>
/// Applications should connect to it, to implement moving between
/// matches.
/// </para>
/// <para>
/// The default bindings for this signal is Ctrl-g.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The ::previous-match signal is a [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user initiates a move to the previous match
/// for the current search string.
/// </para>
/// <para>
/// Applications should connect to it, to implement moving between
/// matches.
/// </para>
/// <para>
/// The default bindings for this signal is Ctrl-Shift-g.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The #GtkSearchEntry::search-changed signal is emitted with a short
/// delay of 150 milliseconds after the last change to the entry text.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The ::stop-search signal is a [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user stops a search via keyboard input.
/// </para>
/// <para>
/// Applications should connect to it, to implement hiding the search
/// entry in this case.
/// </para>
/// <para>
/// The default bindings for this signal is Escape.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// This signal is a sign for the cell renderer to update its
/// value from the @cell_editable.
/// </para>
/// <para>
/// Implementations of #GtkCellEditable are responsible for
/// emitting this signal when they are done editing, e.g.
/// #GtkEntry emits this signal when the user presses Enter. Typical things to
/// do in a handler for ::editing-done are to capture the edited value,
/// disconnect the @cell_editable from signals on the #GtkCellRenderer, etc.
/// </para>
/// <para>
/// gtk_cell_editable_editing_done() is a convenience method
/// for emitting #GtkCellEditable::editing-done.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// This signal is meant to indicate that the cell is finished
/// editing, and the @cell_editable widget is being removed and may
/// subsequently be destroyed.
/// </para>
/// <para>
/// Implementations of #GtkCellEditable are responsible for
/// emitting this signal when they are done editing. It must
/// be emitted after the #GtkCellEditable::editing-done signal,
/// to give the cell renderer a chance to update the cell's value
/// before the widget is removed.
/// </para>
/// <para>
/// gtk_cell_editable_remove_widget() is a convenience method
/// for emitting #GtkCellEditable::remove-widget.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The ::changed signal is emitted at the end of a single
/// user-visible operation on the contents of the #GtkEditable.
/// </para>
/// <para>
/// E.g., a paste operation that replaces the contents of the
/// selection will cause only one signal emission (even though it
/// is implemented by first deleting the selection, then inserting
/// the new content, and may cause multiple ::notify::text signals
/// to be emitted).
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// This signal is emitted when text is deleted from
/// the widget by the user. The default handler for
/// this signal will normally be responsible for deleting
/// the text, so by connecting to this signal and then
/// stopping the signal with g_signal_stop_emission(), it
/// is possible to modify the range of deleted text, or
/// prevent it from being deleted entirely. The @start_pos
/// and @end_pos parameters are interpreted as for
/// gtk_editable_delete_text().
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// This signal is emitted when text is inserted into
/// the widget by the user. The default handler for
/// this signal will normally be responsible for inserting
/// the text, so by connecting to this signal and then
/// stopping the signal with g_signal_stop_emission(), it
/// is possible to modify the inserted text, or prevent
/// it from being inserted entirely.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// the starting position
/// </para>
/// </summary>

	public int StartPos;
/// <summary>
/// <para>
/// the end position
/// </para>
/// </summary>

	public int EndPos;

	public IntPtr UserData;
}

public class InsertTextSignal
{

	public MentorLake.Gtk.GtkEditableHandle Self;
/// <summary>
/// <para>
/// the new text to insert
/// </para>
/// </summary>

	public string NewText;
/// <summary>
/// <para>
/// the length of the new text, in bytes,
///     or -1 if new_text is nul-terminated
/// </para>
/// </summary>

	public int NewTextLength;
/// <summary>
/// <para>
/// the position, in characters,
///     at which to insert the new text. this is an in-out
///     parameter.  After the signal emission is finished, it
///     should point after the newly inserted text.
/// </para>
/// </summary>

	public int Position;

	public IntPtr UserData;
}
}

public static class GtkSearchEntryHandleSignalDelegates
{

/// <summary>
/// <para>
/// The ::next-match signal is a [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user initiates a move to the next match
/// for the current search string.
/// </para>
/// <para>
/// Applications should connect to it, to implement moving between
/// matches.
/// </para>
/// <para>
/// The default bindings for this signal is Ctrl-g.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void next_match([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSearchEntryHandle>))] MentorLake.Gtk.GtkSearchEntryHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::previous-match signal is a [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user initiates a move to the previous match
/// for the current search string.
/// </para>
/// <para>
/// Applications should connect to it, to implement moving between
/// matches.
/// </para>
/// <para>
/// The default bindings for this signal is Ctrl-Shift-g.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void previous_match([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSearchEntryHandle>))] MentorLake.Gtk.GtkSearchEntryHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The #GtkSearchEntry::search-changed signal is emitted with a short
/// delay of 150 milliseconds after the last change to the entry text.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void search_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSearchEntryHandle>))] MentorLake.Gtk.GtkSearchEntryHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::stop-search signal is a [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user stops a search via keyboard input.
/// </para>
/// <para>
/// Applications should connect to it, to implement hiding the search
/// entry in this case.
/// </para>
/// <para>
/// The default bindings for this signal is Escape.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void stop_search([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSearchEntryHandle>))] MentorLake.Gtk.GtkSearchEntryHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is a sign for the cell renderer to update its
/// value from the @cell_editable.
/// </para>
/// <para>
/// Implementations of #GtkCellEditable are responsible for
/// emitting this signal when they are done editing, e.g.
/// #GtkEntry emits this signal when the user presses Enter. Typical things to
/// do in a handler for ::editing-done are to capture the edited value,
/// disconnect the @cell_editable from signals on the #GtkCellRenderer, etc.
/// </para>
/// <para>
/// gtk_cell_editable_editing_done() is a convenience method
/// for emitting #GtkCellEditable::editing-done.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void editing_done([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellEditableHandleImpl>))] MentorLake.Gtk.GtkCellEditableHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is meant to indicate that the cell is finished
/// editing, and the @cell_editable widget is being removed and may
/// subsequently be destroyed.
/// </para>
/// <para>
/// Implementations of #GtkCellEditable are responsible for
/// emitting this signal when they are done editing. It must
/// be emitted after the #GtkCellEditable::editing-done signal,
/// to give the cell renderer a chance to update the cell's value
/// before the widget is removed.
/// </para>
/// <para>
/// gtk_cell_editable_remove_widget() is a convenience method
/// for emitting #GtkCellEditable::remove-widget.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void remove_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellEditableHandleImpl>))] MentorLake.Gtk.GtkCellEditableHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::changed signal is emitted at the end of a single
/// user-visible operation on the contents of the #GtkEditable.
/// </para>
/// <para>
/// E.g., a paste operation that replaces the contents of the
/// selection will cause only one signal emission (even though it
/// is implemented by first deleting the selection, then inserting
/// the new content, and may cause multiple ::notify::text signals
/// to be emitted).
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEditableHandleImpl>))] MentorLake.Gtk.GtkEditableHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when text is deleted from
/// the widget by the user. The default handler for
/// this signal will normally be responsible for deleting
/// the text, so by connecting to this signal and then
/// stopping the signal with g_signal_stop_emission(), it
/// is possible to modify the range of deleted text, or
/// prevent it from being deleted entirely. The @start_pos
/// and @end_pos parameters are interpreted as for
/// gtk_editable_delete_text().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="start_pos">
/// the starting position
/// </param>
/// <param name="end_pos">
/// the end position
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void delete_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEditableHandleImpl>))] MentorLake.Gtk.GtkEditableHandle self, int start_pos, int end_pos, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when text is inserted into
/// the widget by the user. The default handler for
/// this signal will normally be responsible for inserting
/// the text, so by connecting to this signal and then
/// stopping the signal with g_signal_stop_emission(), it
/// is possible to modify the inserted text, or prevent
/// it from being inserted entirely.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="new_text">
/// the new text to insert
/// </param>
/// <param name="new_text_length">
/// the length of the new text, in bytes,
///     or -1 if new_text is nul-terminated
/// </param>
/// <param name="position">
/// the position, in characters,
///     at which to insert the new text. this is an in-out
///     parameter.  After the signal emission is finished, it
///     should point after the newly inserted text.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void insert_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEditableHandleImpl>))] MentorLake.Gtk.GtkEditableHandle self, string new_text, int new_text_length, ref int position, IntPtr user_data);

}


public static class GtkSearchEntryHandleExtensions
{
/// <summary>
/// <para>
/// This function should be called when the top-level window
/// which contains the search entry received a key event. If
/// the entry is part of a #GtkSearchBar, it is preferable
/// to call gtk_search_bar_handle_event() instead, which will
/// reveal the entry in addition to passing the event to this
/// function.
/// </para>
/// <para>
/// If the key event is handled by the search entry and starts
/// or continues a search, %GDK_EVENT_STOP will be returned.
/// The caller should ensure that the entry is shown in this
/// case, and not propagate the event further.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkSearchEntry
/// </param>
/// <param name="@event">
/// a key event
/// </param>
/// <return>
/// %GDK_EVENT_STOP if the key press event resulted
///     in a search beginning or continuing, %GDK_EVENT_PROPAGATE
///     otherwise.
/// </return>

	public static bool HandleEvent(this MentorLake.Gtk.GtkSearchEntryHandle entry, MentorLake.Gdk.GdkEventHandle @event)
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkSearchEntryHandle)");
		return GtkSearchEntryHandleExterns.gtk_search_entry_handle_event(entry, @event);
	}

}

internal class GtkSearchEntryHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkSearchEntryHandle>))]
	internal static extern MentorLake.Gtk.GtkSearchEntryHandle gtk_search_entry_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_search_entry_handle_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSearchEntryHandle>))] MentorLake.Gtk.GtkSearchEntryHandle entry, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

}
