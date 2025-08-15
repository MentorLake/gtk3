namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// You may wish to begin by reading the
/// [text widget conceptual overview](TextWidget.html)
/// which gives an overview of all the objects and data
/// types related to the text widget and how they work together.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <code>
/// textview.view
/// textview.view
/// ├── border.top
/// ├── border.left
/// ├── text
/// │   ╰── [selection]
/// ├── border.right
/// ├── border.bottom
/// ╰── [window.popup]
/// </code>
/// <para>
/// GtkTextView has a main css node with name textview and style class .view,
/// and subnodes for each of the border windows, and the main text area,
/// with names border and text, respectively. The border nodes each get
/// one of the style classes .left, .right, .top or .bottom.
/// </para>
/// <para>
/// A node representing the selection will appear below the text node.
/// </para>
/// <para>
/// If a context menu is opened, the window node will appear as a subnode
/// of the main node.
/// </para>
/// </summary>

public class GtkTextViewHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkScrollableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkTextView. If you don’t call gtk_text_view_set_buffer()
/// before using the text view, an empty default buffer will be created
/// for you. Get the buffer with gtk_text_view_get_buffer(). If you want
/// to specify your own buffer, consider gtk_text_view_new_with_buffer().
/// </para>
/// </summary>

/// <return>
/// a new #GtkTextView
/// </return>

	public static MentorLake.Gtk.GtkTextViewHandle New()
	{
		return GtkTextViewHandleExterns.gtk_text_view_new();
	}

/// <summary>
/// <para>
/// Creates a new #GtkTextView widget displaying the buffer
/// @buffer. One buffer can be shared among many widgets.
/// @buffer may be %NULL to create a default buffer, in which case
/// this function is equivalent to gtk_text_view_new(). The
/// text view adds its own reference count to the buffer; it does not
/// take over an existing reference.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <return>
/// a new #GtkTextView.
/// </return>

	public static MentorLake.Gtk.GtkTextViewHandle NewWithBuffer(MentorLake.Gtk.GtkTextBufferHandle buffer)
	{
		return GtkTextViewHandleExterns.gtk_text_view_new_with_buffer(buffer);
	}

}
public static class GtkTextViewHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::backspace signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user asks for it.
/// </para>
/// <para>
/// The default bindings for this signal are
/// Backspace and Shift-Backspace.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The ::copy-clipboard signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to copy the selection to the clipboard.
/// </para>
/// <para>
/// The default bindings for this signal are
/// Ctrl-c and Ctrl-Insert.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The ::cut-clipboard signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to cut the selection to the clipboard.
/// </para>
/// <para>
/// The default bindings for this signal are
/// Ctrl-x and Shift-Delete.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The ::delete-from-cursor signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user initiates a text deletion.
/// </para>
/// <para>
/// If the @type is %GTK_DELETE_CHARS, GTK+ deletes the selection
/// if there is one, otherwise it deletes the requested number
/// of characters.
/// </para>
/// <para>
/// The default bindings for this signal are
/// Delete for deleting a character, Ctrl-Delete for
/// deleting a word and Ctrl-Backspace for deleting a word
/// backwords.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The ::extend-selection signal is emitted when the selection needs to be
/// extended at @location.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The ::insert-at-cursor signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user initiates the insertion of a
/// fixed string at the cursor.
/// </para>
/// <para>
/// This signal has no default bindings.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The ::insert-emoji signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to present the Emoji chooser for the @text_view.
/// </para>
/// <para>
/// The default bindings for this signal are Ctrl-. and Ctrl-;
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The ::move-cursor signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user initiates a cursor movement.
/// If the cursor is not visible in @text_view, this signal causes
/// the viewport to be moved instead.
/// </para>
/// <para>
/// Applications should not connect to it, but may emit it with
/// g_signal_emit_by_name() if they need to control the cursor
/// programmatically.
/// </para>
/// <para>
/// The default bindings for this signal come in two variants,
/// the variant with the Shift modifier extends the selection,
/// the variant without the Shift modifer does not.
/// There are too many key combinations to list them all here.
/// - Arrow keys move by individual characters/lines
/// - Ctrl-arrow key combinations move by words/paragraphs
/// - Home/End keys move to the ends of the buffer
/// - PageUp/PageDown keys move vertically by pages
/// - Ctrl-PageUp/PageDown keys move horizontally by pages
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The ::move-viewport signal is a
/// [keybinding signal][GtkBindingSignal]
/// which can be bound to key combinations to allow the user
/// to move the viewport, i.e. change what part of the text view
/// is visible in a containing scrolled window.
/// </para>
/// <para>
/// There are no default bindings for this signal.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The ::paste-clipboard signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to paste the contents of the clipboard
/// into the text view.
/// </para>
/// <para>
/// The default bindings for this signal are
/// Ctrl-v and Shift-Insert.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The ::populate-popup signal gets emitted before showing the
/// context menu of the text view.
/// </para>
/// <para>
/// If you need to add items to the context menu, connect
/// to this signal and append your items to the @popup, which
/// will be a #GtkMenu in this case.
/// </para>
/// <para>
/// If #GtkTextView:populate-all is %TRUE, this signal will
/// also be emitted to populate touch popups. In this case,
/// @popup will be a different container, e.g. a #GtkToolbar.
/// </para>
/// <para>
/// The signal handler should not make assumptions about the
/// type of @widget, but check whether @popup is a #GtkMenu
/// or #GtkToolbar or another kind of container.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// If an input method is used, the typed text will not immediately
/// be committed to the buffer. So if you are interested in the text,
/// connect to this signal.
/// </para>
/// <para>
/// This signal is only emitted if the text at the given position
/// is actually editable.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The ::select-all signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to select or unselect the complete
/// contents of the text view.
/// </para>
/// <para>
/// The default bindings for this signal are Ctrl-a and Ctrl-/
/// for selecting and Shift-Ctrl-a and Ctrl-\ for unselecting.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The ::set-anchor signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user initiates setting the &quot;anchor&quot;
/// mark. The &quot;anchor&quot; mark gets placed at the same position as the
/// &quot;insert&quot; mark.
/// </para>
/// <para>
/// This signal has no default bindings.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The ::toggle-cursor-visible signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to toggle the #GtkTextView:cursor-visible
/// property.
/// </para>
/// <para>
/// The default binding for this signal is F7.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The ::toggle-overwrite signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to toggle the overwrite mode of the text view.
/// </para>
/// <para>
/// The default bindings for this signal is Insert.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// the granularity of the deletion, as a #GtkDeleteType
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkDeleteType Type;
/// <summary>
/// <para>
/// the number of @type units to delete
/// </para>
/// </summary>

	public int Count;

	public IntPtr UserData;
}

public class ExtendSelectionSignal
{

	public MentorLake.Gtk.GtkTextViewHandle Self;
/// <summary>
/// <para>
/// the granularity type
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTextExtendSelection Granularity;
/// <summary>
/// <para>
/// the location where to extend the selection
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTextIterHandle Location;
/// <summary>
/// <para>
/// where the selection should start
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTextIterHandle Start;
/// <summary>
/// <para>
/// where the selection should end
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTextIterHandle End;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %GDK_EVENT_STOP to stop other handlers from being invoked for the
///   event. %GDK_EVENT_PROPAGATE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class InsertAtCursorSignal
{

	public MentorLake.Gtk.GtkTextViewHandle Self;
/// <summary>
/// <para>
/// the string to insert
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// the granularity of the move, as a #GtkMovementStep
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkMovementStep Step;
/// <summary>
/// <para>
/// the number of @step units to move
/// </para>
/// </summary>

	public int Count;
/// <summary>
/// <para>
/// %TRUE if the move should extend the selection
/// </para>
/// </summary>

	public bool ExtendSelection;

	public IntPtr UserData;
}

public class MoveViewportSignal
{

	public MentorLake.Gtk.GtkTextViewHandle Self;
/// <summary>
/// <para>
/// the granularity of the movement, as a #GtkScrollStep
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkScrollStep Step;
/// <summary>
/// <para>
/// the number of @step units to move
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// the container that is being populated
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkWidgetHandle Popup;

	public IntPtr UserData;
}

public class PreeditChangedSignal
{

	public MentorLake.Gtk.GtkTextViewHandle Self;
/// <summary>
/// <para>
/// the current preedit string
/// </para>
/// </summary>

	public string Preedit;

	public IntPtr UserData;
}

public class SelectAllSignal
{

	public MentorLake.Gtk.GtkTextViewHandle Self;
/// <summary>
/// <para>
/// %TRUE to select, %FALSE to unselect
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// The ::backspace signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user asks for it.
/// </para>
/// <para>
/// The default bindings for this signal are
/// Backspace and Shift-Backspace.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void backspace([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::copy-clipboard signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to copy the selection to the clipboard.
/// </para>
/// <para>
/// The default bindings for this signal are
/// Ctrl-c and Ctrl-Insert.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void copy_clipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::cut-clipboard signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to cut the selection to the clipboard.
/// </para>
/// <para>
/// The default bindings for this signal are
/// Ctrl-x and Shift-Delete.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void cut_clipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::delete-from-cursor signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user initiates a text deletion.
/// </para>
/// <para>
/// If the @type is %GTK_DELETE_CHARS, GTK+ deletes the selection
/// if there is one, otherwise it deletes the requested number
/// of characters.
/// </para>
/// <para>
/// The default bindings for this signal are
/// Delete for deleting a character, Ctrl-Delete for
/// deleting a word and Ctrl-Backspace for deleting a word
/// backwords.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="type">
/// the granularity of the deletion, as a #GtkDeleteType
/// </param>
/// <param name="count">
/// the number of @type units to delete
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void delete_from_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle self, MentorLake.Gtk.GtkDeleteType type, int count, IntPtr user_data);


/// <summary>
/// <para>
/// The ::extend-selection signal is emitted when the selection needs to be
/// extended at @location.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="granularity">
/// the granularity type
/// </param>
/// <param name="location">
/// the location where to extend the selection
/// </param>
/// <param name="start">
/// where the selection should start
/// </param>
/// <param name="end">
/// where the selection should end
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %GDK_EVENT_STOP to stop other handlers from being invoked for the
///   event. %GDK_EVENT_PROPAGATE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool extend_selection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle self, MentorLake.Gtk.GtkTextExtendSelection granularity, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle location, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle start, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle end, IntPtr user_data);


/// <summary>
/// <para>
/// The ::insert-at-cursor signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user initiates the insertion of a
/// fixed string at the cursor.
/// </para>
/// <para>
/// This signal has no default bindings.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@string">
/// the string to insert
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void insert_at_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle self, string @string, IntPtr user_data);


/// <summary>
/// <para>
/// The ::insert-emoji signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to present the Emoji chooser for the @text_view.
/// </para>
/// <para>
/// The default bindings for this signal are Ctrl-. and Ctrl-;
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void insert_emoji([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::move-cursor signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user initiates a cursor movement.
/// If the cursor is not visible in @text_view, this signal causes
/// the viewport to be moved instead.
/// </para>
/// <para>
/// Applications should not connect to it, but may emit it with
/// g_signal_emit_by_name() if they need to control the cursor
/// programmatically.
/// </para>
/// <para>
/// The default bindings for this signal come in two variants,
/// the variant with the Shift modifier extends the selection,
/// the variant without the Shift modifer does not.
/// There are too many key combinations to list them all here.
/// - Arrow keys move by individual characters/lines
/// - Ctrl-arrow key combinations move by words/paragraphs
/// - Home/End keys move to the ends of the buffer
/// - PageUp/PageDown keys move vertically by pages
/// - Ctrl-PageUp/PageDown keys move horizontally by pages
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="step">
/// the granularity of the move, as a #GtkMovementStep
/// </param>
/// <param name="count">
/// the number of @step units to move
/// </param>
/// <param name="extend_selection">
/// %TRUE if the move should extend the selection
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void move_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle self, MentorLake.Gtk.GtkMovementStep step, int count, bool extend_selection, IntPtr user_data);


/// <summary>
/// <para>
/// The ::move-viewport signal is a
/// [keybinding signal][GtkBindingSignal]
/// which can be bound to key combinations to allow the user
/// to move the viewport, i.e. change what part of the text view
/// is visible in a containing scrolled window.
/// </para>
/// <para>
/// There are no default bindings for this signal.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="step">
/// the granularity of the movement, as a #GtkScrollStep
/// </param>
/// <param name="count">
/// the number of @step units to move
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void move_viewport([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle self, MentorLake.Gtk.GtkScrollStep step, int count, IntPtr user_data);


/// <summary>
/// <para>
/// The ::paste-clipboard signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to paste the contents of the clipboard
/// into the text view.
/// </para>
/// <para>
/// The default bindings for this signal are
/// Ctrl-v and Shift-Insert.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void paste_clipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::populate-popup signal gets emitted before showing the
/// context menu of the text view.
/// </para>
/// <para>
/// If you need to add items to the context menu, connect
/// to this signal and append your items to the @popup, which
/// will be a #GtkMenu in this case.
/// </para>
/// <para>
/// If #GtkTextView:populate-all is %TRUE, this signal will
/// also be emitted to populate touch popups. In this case,
/// @popup will be a different container, e.g. a #GtkToolbar.
/// </para>
/// <para>
/// The signal handler should not make assumptions about the
/// type of @widget, but check whether @popup is a #GtkMenu
/// or #GtkToolbar or another kind of container.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="popup">
/// the container that is being populated
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void populate_popup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle popup, IntPtr user_data);


/// <summary>
/// <para>
/// If an input method is used, the typed text will not immediately
/// be committed to the buffer. So if you are interested in the text,
/// connect to this signal.
/// </para>
/// <para>
/// This signal is only emitted if the text at the given position
/// is actually editable.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="preedit">
/// the current preedit string
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void preedit_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle self, string preedit, IntPtr user_data);


/// <summary>
/// <para>
/// The ::select-all signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to select or unselect the complete
/// contents of the text view.
/// </para>
/// <para>
/// The default bindings for this signal are Ctrl-a and Ctrl-/
/// for selecting and Shift-Ctrl-a and Ctrl-\ for unselecting.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="select">
/// %TRUE to select, %FALSE to unselect
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void select_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle self, bool select, IntPtr user_data);


/// <summary>
/// <para>
/// The ::set-anchor signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user initiates setting the &quot;anchor&quot;
/// mark. The &quot;anchor&quot; mark gets placed at the same position as the
/// &quot;insert&quot; mark.
/// </para>
/// <para>
/// This signal has no default bindings.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void set_anchor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::toggle-cursor-visible signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to toggle the #GtkTextView:cursor-visible
/// property.
/// </para>
/// <para>
/// The default binding for this signal is F7.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void toggle_cursor_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::toggle-overwrite signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to toggle the overwrite mode of the text view.
/// </para>
/// <para>
/// The default bindings for this signal is Insert.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void toggle_overwrite([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextViewHandle>))] MentorLake.Gtk.GtkTextViewHandle self, IntPtr user_data);

}


public static class GtkTextViewHandleExtensions
{
/// <summary>
/// <para>
/// Adds a child widget in the text buffer, at the given @anchor.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="child">
/// a #GtkWidget
/// </param>
/// <param name="anchor">
/// a #GtkTextChildAnchor in the #GtkTextBuffer for @text_view
/// </param>

	public static T AddChildAtAnchor<T>(this T text_view, MentorLake.Gtk.GtkWidgetHandle child, MentorLake.Gtk.GtkTextChildAnchorHandle anchor) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_add_child_at_anchor(text_view, child, anchor);
		return text_view;
	}

/// <summary>
/// <para>
/// Adds a child at fixed coordinates in one of the text widget&apos;s
/// windows.
/// </para>
/// <para>
/// The window must have nonzero size (see
/// gtk_text_view_set_border_window_size()). Note that the child
/// coordinates are given relative to scrolling. When
/// placing a child in #GTK_TEXT_WINDOW_WIDGET, scrolling is
/// irrelevant, the child floats above all scrollable areas. But when
/// placing a child in one of the scrollable windows (border windows or
/// text window) it will move with the scrolling as needed.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="child">
/// a #GtkWidget
/// </param>
/// <param name="which_window">
/// which window the child should appear in
/// </param>
/// <param name="xpos">
/// X position of child in window coordinates
/// </param>
/// <param name="ypos">
/// Y position of child in window coordinates
/// </param>

	public static T AddChildInWindow<T>(this T text_view, MentorLake.Gtk.GtkWidgetHandle child, MentorLake.Gtk.GtkTextWindowType which_window, int xpos, int ypos) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_add_child_in_window(text_view, child, which_window, xpos, ypos);
		return text_view;
	}

/// <summary>
/// <para>
/// Moves the given @iter backward by one display (wrapped) line.
/// A display line is different from a paragraph. Paragraphs are
/// separated by newlines or other paragraph separator characters.
/// Display lines are created by line-wrapping a paragraph. If
/// wrapping is turned off, display lines and paragraphs will be the
/// same. Display lines are divided differently for each view, since
/// they depend on the view’s width; paragraphs are the same in all
/// views, since they depend on the contents of the #GtkTextBuffer.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <return>
/// %TRUE if @iter was moved and is not on the end iterator
/// </return>

	public static bool BackwardDisplayLine(this MentorLake.Gtk.GtkTextViewHandle text_view, MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_backward_display_line(text_view, iter);
	}

/// <summary>
/// <para>
/// Moves the given @iter backward to the next display line start.
/// A display line is different from a paragraph. Paragraphs are
/// separated by newlines or other paragraph separator characters.
/// Display lines are created by line-wrapping a paragraph. If
/// wrapping is turned off, display lines and paragraphs will be the
/// same. Display lines are divided differently for each view, since
/// they depend on the view’s width; paragraphs are the same in all
/// views, since they depend on the contents of the #GtkTextBuffer.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <return>
/// %TRUE if @iter was moved and is not on the end iterator
/// </return>

	public static bool BackwardDisplayLineStart(this MentorLake.Gtk.GtkTextViewHandle text_view, MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_backward_display_line_start(text_view, iter);
	}

/// <summary>
/// <para>
/// Converts coordinate (@buffer_x, @buffer_y) to coordinates for the window
/// @win, and stores the result in (@window_x, @window_y).
/// </para>
/// <para>
/// Note that you can’t convert coordinates for a nonexisting window (see
/// gtk_text_view_set_border_window_size()).
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="win">
/// a #GtkTextWindowType, except %GTK_TEXT_WINDOW_PRIVATE
/// </param>
/// <param name="buffer_x">
/// buffer x coordinate
/// </param>
/// <param name="buffer_y">
/// buffer y coordinate
/// </param>
/// <param name="window_x">
/// window x coordinate return location or %NULL
/// </param>
/// <param name="window_y">
/// window y coordinate return location or %NULL
/// </param>

	public static T BufferToWindowCoords<T>(this T text_view, MentorLake.Gtk.GtkTextWindowType win, int buffer_x, int buffer_y, out int window_x, out int window_y) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_buffer_to_window_coords(text_view, win, buffer_x, buffer_y, out window_x, out window_y);
		return text_view;
	}

/// <summary>
/// <para>
/// Moves the given @iter forward by one display (wrapped) line.
/// A display line is different from a paragraph. Paragraphs are
/// separated by newlines or other paragraph separator characters.
/// Display lines are created by line-wrapping a paragraph. If
/// wrapping is turned off, display lines and paragraphs will be the
/// same. Display lines are divided differently for each view, since
/// they depend on the view’s width; paragraphs are the same in all
/// views, since they depend on the contents of the #GtkTextBuffer.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <return>
/// %TRUE if @iter was moved and is not on the end iterator
/// </return>

	public static bool ForwardDisplayLine(this MentorLake.Gtk.GtkTextViewHandle text_view, MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_forward_display_line(text_view, iter);
	}

/// <summary>
/// <para>
/// Moves the given @iter forward to the next display line end.
/// A display line is different from a paragraph. Paragraphs are
/// separated by newlines or other paragraph separator characters.
/// Display lines are created by line-wrapping a paragraph. If
/// wrapping is turned off, display lines and paragraphs will be the
/// same. Display lines are divided differently for each view, since
/// they depend on the view’s width; paragraphs are the same in all
/// views, since they depend on the contents of the #GtkTextBuffer.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <return>
/// %TRUE if @iter was moved and is not on the end iterator
/// </return>

	public static bool ForwardDisplayLineEnd(this MentorLake.Gtk.GtkTextViewHandle text_view, MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_forward_display_line_end(text_view, iter);
	}

/// <summary>
/// <para>
/// Returns whether pressing the Tab key inserts a tab characters.
/// gtk_text_view_set_accepts_tab().
/// </para>
/// </summary>

/// <param name="text_view">
/// A #GtkTextView
/// </param>
/// <return>
/// %TRUE if pressing the Tab key inserts a tab character,
///   %FALSE if pressing the Tab key moves the keyboard focus.
/// </return>

	public static bool GetAcceptsTab(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_accepts_tab(text_view);
	}

/// <summary>
/// <para>
/// Gets the width of the specified border window. See
/// gtk_text_view_set_border_window_size().
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="type">
/// window to return size from
/// </param>
/// <return>
/// width of window
/// </return>

	public static int GetBorderWindowSize(this MentorLake.Gtk.GtkTextViewHandle text_view, MentorLake.Gtk.GtkTextWindowType type)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_border_window_size(text_view, type);
	}

/// <summary>
/// <para>
/// Gets the bottom margin for text in the @text_view.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <return>
/// bottom margin in pixels
/// </return>

	public static int GetBottomMargin(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_bottom_margin(text_view);
	}

/// <summary>
/// <para>
/// Returns the #GtkTextBuffer being displayed by this text view.
/// The reference count on the buffer is not incremented; the caller
/// of this function won’t own a new reference.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <return>
/// a #GtkTextBuffer
/// </return>

	public static MentorLake.Gtk.GtkTextBufferHandle GetBuffer(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_buffer(text_view);
	}

/// <summary>
/// <para>
/// Given an @iter within a text layout, determine the positions of the
/// strong and weak cursors if the insertion point is at that
/// iterator. The position of each cursor is stored as a zero-width
/// rectangle. The strong cursor location is the location where
/// characters of the directionality equal to the base direction of the
/// paragraph are inserted.  The weak cursor location is the location
/// where characters of the directionality opposite to the base
/// direction of the paragraph are inserted.
/// </para>
/// <para>
/// If @iter is %NULL, the actual cursor position is used.
/// </para>
/// <para>
/// Note that if @iter happens to be the actual cursor position, and
/// there is currently an IM preedit sequence being entered, the
/// returned locations will be adjusted to account for the preedit
/// cursor’s offset within the preedit sequence.
/// </para>
/// <para>
/// The rectangle position is in buffer coordinates; use
/// gtk_text_view_buffer_to_window_coords() to convert these
/// coordinates to coordinates for one of the windows in the text view.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <param name="strong">
/// location to store the strong
///     cursor position (may be %NULL)
/// </param>
/// <param name="weak">
/// location to store the weak
///     cursor position (may be %NULL)
/// </param>

	public static T GetCursorLocations<T>(this T text_view, MentorLake.Gtk.GtkTextIterHandle iter, out MentorLake.Gdk.GdkRectangle strong, out MentorLake.Gdk.GdkRectangle weak) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_get_cursor_locations(text_view, iter, out strong, out weak);
		return text_view;
	}

/// <summary>
/// <para>
/// Find out whether the cursor should be displayed.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <return>
/// whether the insertion mark is visible
/// </return>

	public static bool GetCursorVisible(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_cursor_visible(text_view);
	}

/// <summary>
/// <para>
/// Obtains a copy of the default text attributes. These are the
/// attributes used for text unless a tag overrides them.
/// You’d typically pass the default attributes in to
/// gtk_text_iter_get_attributes() in order to get the
/// attributes in effect at a given text position.
/// </para>
/// <para>
/// The return value is a copy owned by the caller of this function,
/// and should be freed with gtk_text_attributes_unref().
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <return>
/// a new #GtkTextAttributes
/// </return>

	public static MentorLake.Gtk.GtkTextAttributesHandle GetDefaultAttributes(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_default_attributes(text_view);
	}

/// <summary>
/// <para>
/// Returns the default editability of the #GtkTextView. Tags in the
/// buffer may override this setting for some ranges of text.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <return>
/// whether text is editable by default
/// </return>

	public static bool GetEditable(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_editable(text_view);
	}

/// <summary>
/// <para>
/// Gets the horizontal-scrolling #GtkAdjustment.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <return>
/// pointer to the horizontal #GtkAdjustment
/// </return>

	public static MentorLake.Gtk.GtkAdjustmentHandle GetHadjustment(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_hadjustment(text_view);
	}

/// <summary>
/// <para>
/// Gets the default indentation of paragraphs in @text_view.
/// Tags in the view’s buffer may override the default.
/// The indentation may be negative.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <return>
/// number of pixels of indentation
/// </return>

	public static int GetIndent(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_indent(text_view);
	}

/// <summary>
/// <para>
/// Gets the value of the #GtkTextView:input-hints property.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>

	public static MentorLake.Gtk.GtkInputHints GetInputHints(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_input_hints(text_view);
	}

/// <summary>
/// <para>
/// Gets the value of the #GtkTextView:input-purpose property.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>

	public static MentorLake.Gtk.GtkInputPurpose GetInputPurpose(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_input_purpose(text_view);
	}

/// <summary>
/// <para>
/// Retrieves the iterator at buffer coordinates @x and @y. Buffer
/// coordinates are coordinates for the entire buffer, not just the
/// currently-displayed portion.  If you have coordinates from an
/// event, you have to convert those to buffer coordinates with
/// gtk_text_view_window_to_buffer_coords().
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <param name="x">
/// x position, in buffer coordinates
/// </param>
/// <param name="y">
/// y position, in buffer coordinates
/// </param>
/// <return>
/// %TRUE if the position is over text
/// </return>

	public static bool GetIterAtLocation(this MentorLake.Gtk.GtkTextViewHandle text_view, out MentorLake.Gtk.GtkTextIter iter, int x, int y)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_iter_at_location(text_view, out iter, x, y);
	}

/// <summary>
/// <para>
/// Retrieves the iterator pointing to the character at buffer
/// coordinates @x and @y. Buffer coordinates are coordinates for
/// the entire buffer, not just the currently-displayed portion.
/// If you have coordinates from an event, you have to convert
/// those to buffer coordinates with
/// gtk_text_view_window_to_buffer_coords().
/// </para>
/// <para>
/// Note that this is different from gtk_text_view_get_iter_at_location(),
/// which returns cursor locations, i.e. positions between
/// characters.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <param name="trailing">
/// if non-%NULL, location to store an integer indicating where
///    in the grapheme the user clicked. It will either be
///    zero, or the number of characters in the grapheme.
///    0 represents the trailing edge of the grapheme.
/// </param>
/// <param name="x">
/// x position, in buffer coordinates
/// </param>
/// <param name="y">
/// y position, in buffer coordinates
/// </param>
/// <return>
/// %TRUE if the position is over text
/// </return>

	public static bool GetIterAtPosition(this MentorLake.Gtk.GtkTextViewHandle text_view, out MentorLake.Gtk.GtkTextIter iter, out int trailing, int x, int y)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_iter_at_position(text_view, out iter, out trailing, x, y);
	}

/// <summary>
/// <para>
/// Gets a rectangle which roughly contains the character at @iter.
/// The rectangle position is in buffer coordinates; use
/// gtk_text_view_buffer_to_window_coords() to convert these
/// coordinates to coordinates for one of the windows in the text view.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <param name="location">
/// bounds of the character at @iter
/// </param>

	public static T GetIterLocation<T>(this T text_view, MentorLake.Gtk.GtkTextIterHandle iter, out MentorLake.Gdk.GdkRectangle location) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_get_iter_location(text_view, iter, out location);
		return text_view;
	}

/// <summary>
/// <para>
/// Gets the default justification of paragraphs in @text_view.
/// Tags in the buffer may override the default.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <return>
/// default justification
/// </return>

	public static MentorLake.Gtk.GtkJustification GetJustification(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_justification(text_view);
	}

/// <summary>
/// <para>
/// Gets the default left margin size of paragraphs in the @text_view.
/// Tags in the buffer may override the default.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <return>
/// left margin in pixels
/// </return>

	public static int GetLeftMargin(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_left_margin(text_view);
	}

/// <summary>
/// <para>
/// Gets the #GtkTextIter at the start of the line containing
/// the coordinate @y. @y is in buffer coordinates, convert from
/// window coordinates with gtk_text_view_window_to_buffer_coords().
/// If non-%NULL, @line_top will be filled with the coordinate of the top
/// edge of the line.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="target_iter">
/// a #GtkTextIter
/// </param>
/// <param name="y">
/// a y coordinate
/// </param>
/// <param name="line_top">
/// return location for top coordinate of the line
/// </param>

	public static T GetLineAtY<T>(this T text_view, out MentorLake.Gtk.GtkTextIter target_iter, int y, out int line_top) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_get_line_at_y(text_view, out target_iter, y, out line_top);
		return text_view;
	}

/// <summary>
/// <para>
/// Gets the y coordinate of the top of the line containing @iter,
/// and the height of the line. The coordinate is a buffer coordinate;
/// convert to window coordinates with gtk_text_view_buffer_to_window_coords().
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <param name="y">
/// return location for a y coordinate
/// </param>
/// <param name="height">
/// return location for a height
/// </param>

	public static T GetLineYrange<T>(this T text_view, MentorLake.Gtk.GtkTextIterHandle iter, out int y, out int height) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_get_line_yrange(text_view, iter, out y, out height);
		return text_view;
	}

/// <summary>
/// <para>
/// Gets the value of the #GtkTextView:monospace property.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <return>
/// %TRUE if monospace fonts are desired
/// </return>

	public static bool GetMonospace(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_monospace(text_view);
	}

/// <summary>
/// <para>
/// Returns whether the #GtkTextView is in overwrite mode or not.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <return>
/// whether @text_view is in overwrite mode or not.
/// </return>

	public static bool GetOverwrite(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_overwrite(text_view);
	}

/// <summary>
/// <para>
/// Gets the default number of pixels to put above paragraphs.
/// Adding this function with gtk_text_view_get_pixels_below_lines()
/// is equal to the line space between each paragraph.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <return>
/// default number of pixels above paragraphs
/// </return>

	public static int GetPixelsAboveLines(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_pixels_above_lines(text_view);
	}

/// <summary>
/// <para>
/// Gets the value set by gtk_text_view_set_pixels_below_lines().
/// </para>
/// <para>
/// The line space is the sum of the value returned by this function and the
/// value returned by gtk_text_view_get_pixels_above_lines().
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <return>
/// default number of blank pixels below paragraphs
/// </return>

	public static int GetPixelsBelowLines(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_pixels_below_lines(text_view);
	}

/// <summary>
/// <para>
/// Gets the value set by gtk_text_view_set_pixels_inside_wrap().
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <return>
/// default number of pixels of blank space between wrapped lines
/// </return>

	public static int GetPixelsInsideWrap(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_pixels_inside_wrap(text_view);
	}

/// <summary>
/// <para>
/// Gets the default right margin for text in @text_view. Tags
/// in the buffer may override the default.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <return>
/// right margin in pixels
/// </return>

	public static int GetRightMargin(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_right_margin(text_view);
	}

/// <summary>
/// <para>
/// Gets the default tabs for @text_view. Tags in the buffer may
/// override the defaults. The returned array will be %NULL if
/// “standard” (8-space) tabs are used. Free the return value
/// with pango_tab_array_free().
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <return>
/// copy of default tab array, or %NULL if
///    “standard&quot; tabs are used; must be freed with pango_tab_array_free().
/// </return>

	public static MentorLake.Pango.PangoTabArrayHandle GetTabs(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_tabs(text_view);
	}

/// <summary>
/// <para>
/// Gets the top margin for text in the @text_view.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <return>
/// top margin in pixels
/// </return>

	public static int GetTopMargin(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_top_margin(text_view);
	}

/// <summary>
/// <para>
/// Gets the vertical-scrolling #GtkAdjustment.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <return>
/// pointer to the vertical #GtkAdjustment
/// </return>

	public static MentorLake.Gtk.GtkAdjustmentHandle GetVadjustment(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_vadjustment(text_view);
	}

/// <summary>
/// <para>
/// Fills @visible_rect with the currently-visible
/// region of the buffer, in buffer coordinates. Convert to window coordinates
/// with gtk_text_view_buffer_to_window_coords().
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="visible_rect">
/// rectangle to fill
/// </param>

	public static T GetVisibleRect<T>(this T text_view, out MentorLake.Gdk.GdkRectangle visible_rect) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_get_visible_rect(text_view, out visible_rect);
		return text_view;
	}

/// <summary>
/// <para>
/// Retrieves the #GdkWindow corresponding to an area of the text view;
/// possible windows include the overall widget window, child windows
/// on the left, right, top, bottom, and the window that displays the
/// text buffer. Windows are %NULL and nonexistent if their width or
/// height is 0, and are nonexistent before the widget has been
/// realized.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="win">
/// window to get
/// </param>
/// <return>
/// a #GdkWindow, or %NULL
/// </return>

	public static MentorLake.Gdk.GdkWindowHandle GetWindow(this MentorLake.Gtk.GtkTextViewHandle text_view, MentorLake.Gtk.GtkTextWindowType win)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_window(text_view, win);
	}

/// <summary>
/// <para>
/// Usually used to find out which window an event corresponds to.
/// </para>
/// <para>
/// If you connect to an event signal on @text_view, this function
/// should be called on `event-&amp;gt;window` to see which window it was.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="window">
/// a window type
/// </param>
/// <return>
/// the window type.
/// </return>

	public static MentorLake.Gtk.GtkTextWindowType GetWindowType(this MentorLake.Gtk.GtkTextViewHandle text_view, MentorLake.Gdk.GdkWindowHandle window)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_window_type(text_view, window);
	}

/// <summary>
/// <para>
/// Gets the line wrapping for the view.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <return>
/// the line wrap setting
/// </return>

	public static MentorLake.Gtk.GtkWrapMode GetWrapMode(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_get_wrap_mode(text_view);
	}

/// <summary>
/// <para>
/// Allow the #GtkTextView input method to internally handle key press
/// and release events. If this function returns %TRUE, then no further
/// processing should be done for this key event. See
/// gtk_im_context_filter_keypress().
/// </para>
/// <para>
/// Note that you are expected to call this function from your handler
/// when overriding key event handling. This is needed in the case when
/// you need to insert your own key handling between the input method
/// and the default key event handling of the #GtkTextView.
/// </para>
/// <code>
/// static gboolean
/// static gboolean
/// gtk_foo_bar_key_press_event (GtkWidget   *widget,
///                              GdkEventKey *event)
/// {
///   guint keyval;
/// 
///   gdk_event_get_keyval ((GdkEvent*)event, &amp;keyval);
/// 
///   if (keyval == GDK_KEY_Return || keyval == GDK_KEY_KP_Enter)
///     {
///       if (gtk_text_view_im_context_filter_keypress (GTK_TEXT_VIEW (widget), event))
///         return TRUE;
///     }
/// 
///   // Do some stuff
/// 
///   return GTK_WIDGET_CLASS (gtk_foo_bar_parent_class)-&amp;gt;key_press_event (widget, event);
/// }
/// </code>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="@event">
/// the key event
/// </param>
/// <return>
/// %TRUE if the input method handled the key event.
/// </return>

	public static bool ImContextFilterKeypress(this MentorLake.Gtk.GtkTextViewHandle text_view, MentorLake.Gdk.GdkEventKeyHandle @event)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_im_context_filter_keypress(text_view, @event);
	}

/// <summary>
/// <para>
/// Updates the position of a child, as for gtk_text_view_add_child_in_window().
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="child">
/// child widget already added to the text view
/// </param>
/// <param name="xpos">
/// new X position in window coordinates
/// </param>
/// <param name="ypos">
/// new Y position in window coordinates
/// </param>

	public static T MoveChild<T>(this T text_view, MentorLake.Gtk.GtkWidgetHandle child, int xpos, int ypos) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_move_child(text_view, child, xpos, ypos);
		return text_view;
	}

/// <summary>
/// <para>
/// Moves a mark within the buffer so that it&apos;s
/// located within the currently-visible text area.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="mark">
/// a #GtkTextMark
/// </param>
/// <return>
/// %TRUE if the mark moved (wasn’t already onscreen)
/// </return>

	public static bool MoveMarkOnscreen(this MentorLake.Gtk.GtkTextViewHandle text_view, MentorLake.Gtk.GtkTextMarkHandle mark)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_move_mark_onscreen(text_view, mark);
	}

/// <summary>
/// <para>
/// Move the iterator a given number of characters visually, treating
/// it as the strong cursor position. If @count is positive, then the
/// new strong cursor position will be @count positions to the right of
/// the old cursor position. If @count is negative then the new strong
/// cursor position will be @count positions to the left of the old
/// cursor position.
/// </para>
/// <para>
/// In the presence of bi-directional text, the correspondence
/// between logical and visual order will depend on the direction
/// of the current run, and there may be jumps when the cursor
/// is moved off of the end of a run.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <param name="count">
/// number of characters to move (negative moves left,
///    positive moves right)
/// </param>
/// <return>
/// %TRUE if @iter moved and is not on the end iterator
/// </return>

	public static bool MoveVisually(this MentorLake.Gtk.GtkTextViewHandle text_view, MentorLake.Gtk.GtkTextIterHandle iter, int count)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_move_visually(text_view, iter, count);
	}

/// <summary>
/// <para>
/// Moves the cursor to the currently visible region of the
/// buffer, it it isn’t there already.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <return>
/// %TRUE if the cursor had to be moved.
/// </return>

	public static bool PlaceCursorOnscreen(this MentorLake.Gtk.GtkTextViewHandle text_view)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_place_cursor_onscreen(text_view);
	}

/// <summary>
/// <para>
/// Ensures that the cursor is shown (i.e. not in an &apos;off&apos; blink
/// interval) and resets the time that it will stay blinking (or
/// visible, in case blinking is disabled).
/// </para>
/// <para>
/// This function should be called in response to user input
/// (e.g. from derived classes that override the textview&apos;s
/// #GtkWidget::key-press-event handler).
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>

	public static T ResetCursorBlink<T>(this T text_view) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_reset_cursor_blink(text_view);
		return text_view;
	}

/// <summary>
/// <para>
/// Reset the input method context of the text view if needed.
/// </para>
/// <para>
/// This can be necessary in the case where modifying the buffer
/// would confuse on-going input method behavior.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>

	public static T ResetImContext<T>(this T text_view) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_reset_im_context(text_view);
		return text_view;
	}

/// <summary>
/// <para>
/// Scrolls @text_view the minimum distance such that @mark is contained
/// within the visible area of the widget.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="mark">
/// a mark in the buffer for @text_view
/// </param>

	public static T ScrollMarkOnscreen<T>(this T text_view, MentorLake.Gtk.GtkTextMarkHandle mark) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_scroll_mark_onscreen(text_view, mark);
		return text_view;
	}

/// <summary>
/// <para>
/// Scrolls @text_view so that @iter is on the screen in the position
/// indicated by @xalign and @yalign. An alignment of 0.0 indicates
/// left or top, 1.0 indicates right or bottom, 0.5 means center.
/// If @use_align is %FALSE, the text scrolls the minimal distance to
/// get the mark onscreen, possibly not scrolling at all. The effective
/// screen for purposes of this function is reduced by a margin of size
/// @within_margin.
/// </para>
/// <para>
/// Note that this function uses the currently-computed height of the
/// lines in the text buffer. Line heights are computed in an idle
/// handler; so this function may not have the desired effect if it’s
/// called before the height computations. To avoid oddness, consider
/// using gtk_text_view_scroll_to_mark() which saves a point to be
/// scrolled to after line validation.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <param name="within_margin">
/// margin as a [0.0,0.5) fraction of screen size
/// </param>
/// <param name="use_align">
/// whether to use alignment arguments (if %FALSE,
///    just get the mark onscreen)
/// </param>
/// <param name="xalign">
/// horizontal alignment of mark within visible area
/// </param>
/// <param name="yalign">
/// vertical alignment of mark within visible area
/// </param>
/// <return>
/// %TRUE if scrolling occurred
/// </return>

	public static bool ScrollToIter(this MentorLake.Gtk.GtkTextViewHandle text_view, MentorLake.Gtk.GtkTextIterHandle iter, double within_margin, bool use_align, double xalign, double yalign)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_scroll_to_iter(text_view, iter, within_margin, use_align, xalign, yalign);
	}

/// <summary>
/// <para>
/// Scrolls @text_view so that @mark is on the screen in the position
/// indicated by @xalign and @yalign. An alignment of 0.0 indicates
/// left or top, 1.0 indicates right or bottom, 0.5 means center.
/// If @use_align is %FALSE, the text scrolls the minimal distance to
/// get the mark onscreen, possibly not scrolling at all. The effective
/// screen for purposes of this function is reduced by a margin of size
/// @within_margin.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="mark">
/// a #GtkTextMark
/// </param>
/// <param name="within_margin">
/// margin as a [0.0,0.5) fraction of screen size
/// </param>
/// <param name="use_align">
/// whether to use alignment arguments (if %FALSE, just
///    get the mark onscreen)
/// </param>
/// <param name="xalign">
/// horizontal alignment of mark within visible area
/// </param>
/// <param name="yalign">
/// vertical alignment of mark within visible area
/// </param>

	public static T ScrollToMark<T>(this T text_view, MentorLake.Gtk.GtkTextMarkHandle mark, double within_margin, bool use_align, double xalign, double yalign) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_scroll_to_mark(text_view, mark, within_margin, use_align, xalign, yalign);
		return text_view;
	}

/// <summary>
/// <para>
/// Sets the behavior of the text widget when the Tab key is pressed.
/// If @accepts_tab is %TRUE, a tab character is inserted. If @accepts_tab
/// is %FALSE the keyboard focus is moved to the next widget in the focus
/// chain.
/// </para>
/// </summary>

/// <param name="text_view">
/// A #GtkTextView
/// </param>
/// <param name="accepts_tab">
/// %TRUE if pressing the Tab key should insert a tab
///    character, %FALSE, if pressing the Tab key should move the
///    keyboard focus.
/// </param>

	public static T SetAcceptsTab<T>(this T text_view, bool accepts_tab) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_set_accepts_tab(text_view, accepts_tab);
		return text_view;
	}

/// <summary>
/// <para>
/// Sets the width of %GTK_TEXT_WINDOW_LEFT or %GTK_TEXT_WINDOW_RIGHT,
/// or the height of %GTK_TEXT_WINDOW_TOP or %GTK_TEXT_WINDOW_BOTTOM.
/// Automatically destroys the corresponding window if the size is set
/// to 0, and creates the window if the size is set to non-zero.  This
/// function can only be used for the “border windows”, and it won’t
/// work with %GTK_TEXT_WINDOW_WIDGET, %GTK_TEXT_WINDOW_TEXT, or
/// %GTK_TEXT_WINDOW_PRIVATE.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="type">
/// window to affect
/// </param>
/// <param name="size">
/// width or height of the window
/// </param>

	public static T SetBorderWindowSize<T>(this T text_view, MentorLake.Gtk.GtkTextWindowType type, int size) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_set_border_window_size(text_view, type, size);
		return text_view;
	}

/// <summary>
/// <para>
/// Sets the bottom margin for text in @text_view.
/// </para>
/// <para>
/// Note that this function is confusingly named.
/// In CSS terms, the value set here is padding.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="bottom_margin">
/// bottom margin in pixels
/// </param>

	public static T SetBottomMargin<T>(this T text_view, int bottom_margin) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_set_bottom_margin(text_view, bottom_margin);
		return text_view;
	}

/// <summary>
/// <para>
/// Sets @buffer as the buffer being displayed by @text_view. The previous
/// buffer displayed by the text view is unreferenced, and a reference is
/// added to @buffer. If you owned a reference to @buffer before passing it
/// to this function, you must remove that reference yourself; #GtkTextView
/// will not “adopt” it.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>

	public static T SetBuffer<T>(this T text_view, MentorLake.Gtk.GtkTextBufferHandle buffer) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_set_buffer(text_view, buffer);
		return text_view;
	}

/// <summary>
/// <para>
/// Toggles whether the insertion point should be displayed. A buffer with
/// no editable text probably shouldn’t have a visible cursor, so you may
/// want to turn the cursor off.
/// </para>
/// <para>
/// Note that this property may be overridden by the
/// #GtkSettings:gtk-keynave-use-caret settings.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="setting">
/// whether to show the insertion cursor
/// </param>

	public static T SetCursorVisible<T>(this T text_view, bool setting) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_set_cursor_visible(text_view, setting);
		return text_view;
	}

/// <summary>
/// <para>
/// Sets the default editability of the #GtkTextView. You can override
/// this default setting with tags in the buffer, using the “editable”
/// attribute of tags.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="setting">
/// whether it’s editable
/// </param>

	public static T SetEditable<T>(this T text_view, bool setting) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_set_editable(text_view, setting);
		return text_view;
	}

/// <summary>
/// <para>
/// Sets the default indentation for paragraphs in @text_view.
/// Tags in the buffer may override the default.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="indent">
/// indentation in pixels
/// </param>

	public static T SetIndent<T>(this T text_view, int indent) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_set_indent(text_view, indent);
		return text_view;
	}

/// <summary>
/// <para>
/// Sets the #GtkTextView:input-hints property, which
/// allows input methods to fine-tune their behaviour.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="hints">
/// the hints
/// </param>

	public static T SetInputHints<T>(this T text_view, MentorLake.Gtk.GtkInputHints hints) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_set_input_hints(text_view, hints);
		return text_view;
	}

/// <summary>
/// <para>
/// Sets the #GtkTextView:input-purpose property which
/// can be used by on-screen keyboards and other input
/// methods to adjust their behaviour.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="purpose">
/// the purpose
/// </param>

	public static T SetInputPurpose<T>(this T text_view, MentorLake.Gtk.GtkInputPurpose purpose) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_set_input_purpose(text_view, purpose);
		return text_view;
	}

/// <summary>
/// <para>
/// Sets the default justification of text in @text_view.
/// Tags in the view’s buffer may override the default.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="justification">
/// justification
/// </param>

	public static T SetJustification<T>(this T text_view, MentorLake.Gtk.GtkJustification justification) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_set_justification(text_view, justification);
		return text_view;
	}

/// <summary>
/// <para>
/// Sets the default left margin for text in @text_view.
/// Tags in the buffer may override the default.
/// </para>
/// <para>
/// Note that this function is confusingly named.
/// In CSS terms, the value set here is padding.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="left_margin">
/// left margin in pixels
/// </param>

	public static T SetLeftMargin<T>(this T text_view, int left_margin) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_set_left_margin(text_view, left_margin);
		return text_view;
	}

/// <summary>
/// <para>
/// Sets the #GtkTextView:monospace property, which
/// indicates that the text view should use monospace
/// fonts.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="monospace">
/// %TRUE to request monospace styling
/// </param>

	public static T SetMonospace<T>(this T text_view, bool monospace) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_set_monospace(text_view, monospace);
		return text_view;
	}

/// <summary>
/// <para>
/// Changes the #GtkTextView overwrite mode.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="overwrite">
/// %TRUE to turn on overwrite mode, %FALSE to turn it off
/// </param>

	public static T SetOverwrite<T>(this T text_view, bool overwrite) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_set_overwrite(text_view, overwrite);
		return text_view;
	}

/// <summary>
/// <para>
/// Sets the default number of blank pixels above paragraphs in @text_view.
/// Tags in the buffer for @text_view may override the defaults.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="pixels_above_lines">
/// pixels above paragraphs
/// </param>

	public static T SetPixelsAboveLines<T>(this T text_view, int pixels_above_lines) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_set_pixels_above_lines(text_view, pixels_above_lines);
		return text_view;
	}

/// <summary>
/// <para>
/// Sets the default number of pixels of blank space
/// to put below paragraphs in @text_view. May be overridden
/// by tags applied to @text_view’s buffer.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="pixels_below_lines">
/// pixels below paragraphs
/// </param>

	public static T SetPixelsBelowLines<T>(this T text_view, int pixels_below_lines) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_set_pixels_below_lines(text_view, pixels_below_lines);
		return text_view;
	}

/// <summary>
/// <para>
/// Sets the default number of pixels of blank space to leave between
/// display/wrapped lines within a paragraph. May be overridden by
/// tags in @text_view’s buffer.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="pixels_inside_wrap">
/// default number of pixels between wrapped lines
/// </param>

	public static T SetPixelsInsideWrap<T>(this T text_view, int pixels_inside_wrap) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_set_pixels_inside_wrap(text_view, pixels_inside_wrap);
		return text_view;
	}

/// <summary>
/// <para>
/// Sets the default right margin for text in the text view.
/// Tags in the buffer may override the default.
/// </para>
/// <para>
/// Note that this function is confusingly named.
/// In CSS terms, the value set here is padding.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="right_margin">
/// right margin in pixels
/// </param>

	public static T SetRightMargin<T>(this T text_view, int right_margin) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_set_right_margin(text_view, right_margin);
		return text_view;
	}

/// <summary>
/// <para>
/// Sets the default tab stops for paragraphs in @text_view.
/// Tags in the buffer may override the default.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="tabs">
/// tabs as a #PangoTabArray
/// </param>

	public static T SetTabs<T>(this T text_view, MentorLake.Pango.PangoTabArrayHandle tabs) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_set_tabs(text_view, tabs);
		return text_view;
	}

/// <summary>
/// <para>
/// Sets the top margin for text in @text_view.
/// </para>
/// <para>
/// Note that this function is confusingly named.
/// In CSS terms, the value set here is padding.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="top_margin">
/// top margin in pixels
/// </param>

	public static T SetTopMargin<T>(this T text_view, int top_margin) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_set_top_margin(text_view, top_margin);
		return text_view;
	}

/// <summary>
/// <para>
/// Sets the line wrapping for the view.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="wrap_mode">
/// a #GtkWrapMode
/// </param>

	public static T SetWrapMode<T>(this T text_view, MentorLake.Gtk.GtkWrapMode wrap_mode) where T : GtkTextViewHandle
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		GtkTextViewHandleExterns.gtk_text_view_set_wrap_mode(text_view, wrap_mode);
		return text_view;
	}

/// <summary>
/// <para>
/// Determines whether @iter is at the start of a display line.
/// See gtk_text_view_forward_display_line() for an explanation of
/// display lines vs. paragraphs.
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <return>
/// %TRUE if @iter begins a wrapped line
/// </return>

	public static bool StartsDisplayLine(this MentorLake.Gtk.GtkTextViewHandle text_view, MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (text_view.IsInvalid) throw new Exception("Invalid handle (GtkTextViewHandle)");
		return GtkTextViewHandleExterns.gtk_text_view_starts_display_line(text_view, iter);
	}

/// <summary>
/// <para>
/// Converts coordinates on the window identified by @win to buffer
/// coordinates, storing the result in (@buffer_x,@buffer_y).
/// </para>
/// <para>
/// Note that you can’t convert coordinates for a nonexisting window (see
/// gtk_text_view_set_border_window_size()).
/// </para>
/// </summary>

/// <param name="text_view">
/// a #GtkTextView
/// </param>
/// <param name="win">
/// a #GtkTextWindowType except %GTK_TEXT_WINDOW_PRIVATE
/// </param>
/// <param name="window_x">
/// window x coordinate
/// </param>
/// <param name="window_y">
/// window y coordinate
/// </param>
/// <param name="buffer_x">
/// buffer x coordinate return location or %NULL
/// </param>
/// <param name="buffer_y">
/// buffer y coordinate return location or %NULL
/// </param>

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
