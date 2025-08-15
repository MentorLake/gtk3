namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkEntry widget is a single line text entry
/// widget. A fairly large set of key bindings are supported
/// by default. If the entered text is longer than the allocation
/// of the widget, the widget will scroll so that the cursor
/// position is visible.
/// </para>
/// <para>
/// When using an entry for passwords and other sensitive information,
/// it can be put into “password mode” using gtk_entry_set_visibility().
/// In this mode, entered text is displayed using a “invisible” character.
/// By default, GTK+ picks the best invisible character that is available
/// in the current font, but it can be changed with
/// gtk_entry_set_invisible_char(). Since 2.16, GTK+ displays a warning
/// when Caps Lock or input methods might interfere with entering text in
/// a password entry. The warning can be turned off with the
/// #GtkEntry:caps-lock-warning property.
/// </para>
/// <para>
/// Since 2.16, GtkEntry has the ability to display progress or activity
/// information behind the text. To make an entry display such information,
/// use gtk_entry_set_progress_fraction() or gtk_entry_set_progress_pulse_step().
/// </para>
/// <para>
/// Additionally, GtkEntry can show icons at either side of the entry. These
/// icons can be activatable by clicking, can be set up as drag source and
/// can have tooltips. To add an icon, use gtk_entry_set_icon_from_gicon() or
/// one of the various other functions that set an icon from a stock id, an
/// icon name or a pixbuf. To trigger an action when the user clicks an icon,
/// connect to the #GtkEntry::icon-press signal. To allow DND operations
/// from an icon, use gtk_entry_set_icon_drag_source(). To set a tooltip on
/// an icon, use gtk_entry_set_icon_tooltip_text() or the corresponding function
/// for markup.
/// </para>
/// <para>
/// Note that functionality or information that is only available by clicking
/// on an icon in an entry may not be accessible at all to users which are not
/// able to use a mouse or other pointing device. It is therefore recommended
/// that any such functionality should also be available by other means, e.g.
/// via the context menu of the entry.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <code>
/// entry[.read-only][.flat][.warning][.error]
/// entry[.read-only][.flat][.warning][.error]
/// ├── image.left
/// ├── image.right
/// ├── undershoot.left
/// ├── undershoot.right
/// ├── [selection]
/// ├── [progress[.pulse]]
/// ╰── [window.popup]
/// </code>
/// <para>
/// GtkEntry has a main node with the name entry. Depending on the properties
/// of the entry, the style classes .read-only and .flat may appear. The style
/// classes .warning and .error may also be used with entries.
/// </para>
/// <para>
/// When the entry shows icons, it adds subnodes with the name image and the
/// style class .left or .right, depending on where the icon appears.
/// </para>
/// <para>
/// When the entry has a selection, it adds a subnode with the name selection.
/// </para>
/// <para>
/// When the entry shows progress, it adds a subnode with the name progress.
/// The node has the style class .pulse when the shown progress is pulsing.
/// </para>
/// <para>
/// The CSS node for a context menu is added as a subnode below entry as well.
/// </para>
/// <para>
/// The undershoot nodes are used to draw the underflow indication when content
/// is scrolled out of view. These nodes get the .left and .right style classes
/// added depending on where the indication is drawn.
/// </para>
/// <para>
/// When touch is used and touch selection handles are shown, they are using
/// CSS nodes with name cursor-handle. They get the .top or .bottom style class
/// depending on where they are shown in relation to the selection. If there is
/// just a single handle for the text cursor, it gets the style class
/// .insertion-cursor.
/// </para>
/// </summary>

public class GtkEntryHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkCellEditableHandle, GtkEditableHandle
{
/// <summary>
/// <para>
/// Creates a new entry.
/// </para>
/// </summary>

/// <return>
/// a new #GtkEntry.
/// </return>

	public static MentorLake.Gtk.GtkEntryHandle New()
	{
		return GtkEntryHandleExterns.gtk_entry_new();
	}

/// <summary>
/// <para>
/// Creates a new entry with the specified text buffer.
/// </para>
/// </summary>

/// <param name="buffer">
/// The buffer to use for the new #GtkEntry.
/// </param>
/// <return>
/// a new #GtkEntry
/// </return>

	public static MentorLake.Gtk.GtkEntryHandle NewWithBuffer(MentorLake.Gtk.GtkEntryBufferHandle buffer)
	{
		return GtkEntryHandleExterns.gtk_entry_new_with_buffer(buffer);
	}

}
public static class GtkEntryHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::activate signal is emitted when the user hits
/// the Enter key.
/// </para>
/// <para>
/// While this signal is used as a
/// [keybinding signal][GtkBindingSignal],
/// it is also commonly used by applications to intercept
/// activation of entries.
/// </para>
/// <para>
/// The default bindings for this signal are all forms of the Enter key.
/// </para>
/// </summary>

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
/// Delete for deleting a character and Ctrl-Delete for
/// deleting a word.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The ::icon-press signal is emitted when an activatable icon
/// is clicked.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The ::icon-release signal is emitted on the button release from a
/// mouse click over an activatable icon.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The ::insert-emoji signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to present the Emoji chooser for the @entry.
/// </para>
/// <para>
/// The default bindings for this signal are Ctrl-. and Ctrl-;
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The ::move-cursor signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user initiates a cursor movement.
/// If the cursor is not visible in @entry, this signal causes
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
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The ::populate-popup signal gets emitted before showing the
/// context menu of the entry.
/// </para>
/// <para>
/// If you need to add items to the context menu, connect
/// to this signal and append your items to the @widget, which
/// will be a #GtkMenu in this case.
/// </para>
/// <para>
/// If #GtkEntry:populate-all is %TRUE, this signal will
/// also be emitted to populate touch popups. In this case,
/// @widget will be a different container, e.g. a #GtkToolbar.
/// The signal handler should not make assumptions about the
/// type of @widget.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// If an input method is used, the typed text will not immediately
/// be committed to the buffer. So if you are interested in the text,
/// connect to this signal.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The ::toggle-overwrite signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to toggle the overwrite mode of the entry.
/// </para>
/// <para>
/// The default bindings for this signal is Insert.
/// </para>
/// </summary>

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
/// to give the cell renderer a chance to update the cell&apos;s value
/// before the widget is removed.
/// </para>
/// <para>
/// gtk_cell_editable_remove_widget() is a convenience method
/// for emitting #GtkCellEditable::remove-widget.
/// </para>
/// </summary>

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

public class IconPressSignal
{

	public MentorLake.Gtk.GtkEntryHandle Self;
/// <summary>
/// <para>
/// The position of the clicked icon
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkEntryIconPosition IconPos;
/// <summary>
/// <para>
/// the button press event
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkEventHandle Event;

	public IntPtr UserData;
}

public class IconReleaseSignal
{

	public MentorLake.Gtk.GtkEntryHandle Self;
/// <summary>
/// <para>
/// The position of the clicked icon
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkEntryIconPosition IconPos;
/// <summary>
/// <para>
/// the button release event
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkEventHandle Event;

	public IntPtr UserData;
}

public class InsertAtCursorSignal
{

	public MentorLake.Gtk.GtkEntryHandle Self;
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

	public MentorLake.Gtk.GtkEntryHandle Self;

	public IntPtr UserData;
}

public class MoveCursorSignal
{

	public MentorLake.Gtk.GtkEntryHandle Self;
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

public class PasteClipboardSignal
{

	public MentorLake.Gtk.GtkEntryHandle Self;

	public IntPtr UserData;
}

public class PopulatePopupSignal
{

	public MentorLake.Gtk.GtkEntryHandle Self;
/// <summary>
/// <para>
/// the container that is being populated
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkWidgetHandle Widget;

	public IntPtr UserData;
}

public class PreeditChangedSignal
{

	public MentorLake.Gtk.GtkEntryHandle Self;
/// <summary>
/// <para>
/// the current preedit string
/// </para>
/// </summary>

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

public static class GtkEntryHandleSignalDelegates
{

/// <summary>
/// <para>
/// The ::activate signal is emitted when the user hits
/// the Enter key.
/// </para>
/// <para>
/// While this signal is used as a
/// [keybinding signal][GtkBindingSignal],
/// it is also commonly used by applications to intercept
/// activation of entries.
/// </para>
/// <para>
/// The default bindings for this signal are all forms of the Enter key.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle self, IntPtr user_data);


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
public delegate void backspace([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle self, IntPtr user_data);


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
public delegate void copy_clipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle self, IntPtr user_data);


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
public delegate void cut_clipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle self, IntPtr user_data);


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
/// Delete for deleting a character and Ctrl-Delete for
/// deleting a word.
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
public delegate void delete_from_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle self, MentorLake.Gtk.GtkDeleteType type, int count, IntPtr user_data);


/// <summary>
/// <para>
/// The ::icon-press signal is emitted when an activatable icon
/// is clicked.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="icon_pos">
/// The position of the clicked icon
/// </param>
/// <param name="@event">
/// the button press event
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void icon_press([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle self, MentorLake.Gtk.GtkEntryIconPosition icon_pos, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, IntPtr user_data);


/// <summary>
/// <para>
/// The ::icon-release signal is emitted on the button release from a
/// mouse click over an activatable icon.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="icon_pos">
/// The position of the clicked icon
/// </param>
/// <param name="@event">
/// the button release event
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void icon_release([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle self, MentorLake.Gtk.GtkEntryIconPosition icon_pos, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, IntPtr user_data);


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
public delegate void insert_at_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle self, string @string, IntPtr user_data);


/// <summary>
/// <para>
/// The ::insert-emoji signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to present the Emoji chooser for the @entry.
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
public delegate void insert_emoji([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::move-cursor signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user initiates a cursor movement.
/// If the cursor is not visible in @entry, this signal causes
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
public delegate void move_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle self, MentorLake.Gtk.GtkMovementStep step, int count, bool extend_selection, IntPtr user_data);


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
public delegate void paste_clipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::populate-popup signal gets emitted before showing the
/// context menu of the entry.
/// </para>
/// <para>
/// If you need to add items to the context menu, connect
/// to this signal and append your items to the @widget, which
/// will be a #GtkMenu in this case.
/// </para>
/// <para>
/// If #GtkEntry:populate-all is %TRUE, this signal will
/// also be emitted to populate touch popups. In this case,
/// @widget will be a different container, e.g. a #GtkToolbar.
/// The signal handler should not make assumptions about the
/// type of @widget.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="widget">
/// the container that is being populated
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void populate_popup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, IntPtr user_data);


/// <summary>
/// <para>
/// If an input method is used, the typed text will not immediately
/// be committed to the buffer. So if you are interested in the text,
/// connect to this signal.
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
public delegate void preedit_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle self, string preedit, IntPtr user_data);


/// <summary>
/// <para>
/// The ::toggle-overwrite signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to toggle the overwrite mode of the entry.
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
public delegate void toggle_overwrite([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle self, IntPtr user_data);


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
/// to give the cell renderer a chance to update the cell&apos;s value
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


public static class GtkEntryHandleExtensions
{
/// <summary>
/// <para>
/// Retrieves the value set by gtk_entry_set_activates_default().
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <return>
/// %TRUE if the entry will activate the default widget
/// </return>

	public static bool GetActivatesDefault(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_activates_default(entry);
	}

/// <summary>
/// <para>
/// Gets the value set by gtk_entry_set_alignment().
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <return>
/// the alignment
/// </return>

	public static float GetAlignment(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_alignment(entry);
	}

/// <summary>
/// <para>
/// Gets the attribute list that was set on the entry using
/// gtk_entry_set_attributes(), if any.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <return>
/// the attribute list, or %NULL
///     if none was set.
/// </return>

	public static MentorLake.Pango.PangoAttrListHandle GetAttributes(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_attributes(entry);
	}

/// <summary>
/// <para>
/// Get the #GtkEntryBuffer object which holds the text for
/// this widget.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <return>
/// A #GtkEntryBuffer object.
/// </return>

	public static MentorLake.Gtk.GtkEntryBufferHandle GetBuffer(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_buffer(entry);
	}

/// <summary>
/// <para>
/// Returns the auxiliary completion object currently in use by @entry.
/// </para>
/// </summary>

/// <param name="entry">
/// A #GtkEntry
/// </param>
/// <return>
/// The auxiliary completion object currently
///     in use by @entry.
/// </return>

	public static MentorLake.Gtk.GtkEntryCompletionHandle GetCompletion(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_completion(entry);
	}

/// <summary>
/// <para>
/// Returns the index of the icon which is the source of the current
/// DND operation, or -1.
/// </para>
/// <para>
/// This function is meant to be used in a #GtkWidget::drag-data-get
/// callback.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <return>
/// index of the icon which is the source of the current
///          DND operation, or -1.
/// </return>

	public static int GetCurrentIconDragSource(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_current_icon_drag_source(entry);
	}

/// <summary>
/// <para>
/// Retrieves the horizontal cursor adjustment for the entry.
/// See gtk_entry_set_cursor_hadjustment().
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <return>
/// the horizontal cursor adjustment, or %NULL
///   if none has been set.
/// </return>

	public static MentorLake.Gtk.GtkAdjustmentHandle GetCursorHadjustment(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_cursor_hadjustment(entry);
	}

/// <summary>
/// <para>
/// Gets the value set by gtk_entry_set_has_frame().
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <return>
/// whether the entry has a beveled frame
/// </return>

	public static bool GetHasFrame(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_has_frame(entry);
	}

/// <summary>
/// <para>
/// Returns whether the icon is activatable.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <param name="icon_pos">
/// Icon position
/// </param>
/// <return>
/// %TRUE if the icon is activatable.
/// </return>

	public static bool GetIconActivatable(this MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos)
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_icon_activatable(entry, icon_pos);
	}

/// <summary>
/// <para>
/// Gets the area where entry’s icon at @icon_pos is drawn.
/// This function is useful when drawing something to the
/// entry in a draw callback.
/// </para>
/// <para>
/// If the entry is not realized or has no icon at the given position,
/// @icon_area is filled with zeros. Otherwise, @icon_area will be filled
/// with the icon’s allocation, relative to @entry’s allocation.
/// </para>
/// <para>
/// See also gtk_entry_get_text_area()
/// </para>
/// </summary>

/// <param name="entry">
/// A #GtkEntry
/// </param>
/// <param name="icon_pos">
/// Icon position
/// </param>
/// <param name="icon_area">
/// Return location for the icon’s area
/// </param>

	public static T GetIconArea<T>(this T entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos, out MentorLake.Gdk.GdkRectangle icon_area) where T : GtkEntryHandle
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_get_icon_area(entry, icon_pos, out icon_area);
		return entry;
	}

/// <summary>
/// <para>
/// Finds the icon at the given position and return its index. The
/// position’s coordinates are relative to the @entry’s top left corner.
/// If @x, @y doesn’t lie inside an icon, -1 is returned.
/// This function is intended for use in a #GtkWidget::query-tooltip
/// signal handler.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <param name="x">
/// the x coordinate of the position to find
/// </param>
/// <param name="y">
/// the y coordinate of the position to find
/// </param>
/// <return>
/// the index of the icon at the given position, or -1
/// </return>

	public static int GetIconAtPos(this MentorLake.Gtk.GtkEntryHandle entry, int x, int y)
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_icon_at_pos(entry, x, y);
	}

/// <summary>
/// <para>
/// Retrieves the #GIcon used for the icon, or %NULL if there is
/// no icon or if the icon was set by some other method (e.g., by
/// stock, pixbuf, or icon name).
/// </para>
/// </summary>

/// <param name="entry">
/// A #GtkEntry
/// </param>
/// <param name="icon_pos">
/// Icon position
/// </param>
/// <return>
/// A #GIcon, or %NULL if no icon is set
///     or if the icon is not a #GIcon
/// </return>

	public static MentorLake.Gio.GIconHandle GetIconGicon(this MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos)
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_icon_gicon(entry, icon_pos);
	}

/// <summary>
/// <para>
/// Retrieves the icon name used for the icon, or %NULL if there is
/// no icon or if the icon was set by some other method (e.g., by
/// pixbuf, stock or gicon).
/// </para>
/// </summary>

/// <param name="entry">
/// A #GtkEntry
/// </param>
/// <param name="icon_pos">
/// Icon position
/// </param>
/// <return>
/// An icon name, or %NULL if no icon is set or if the icon
///          wasn’t set from an icon name
/// </return>

	public static string GetIconName(this MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos)
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_icon_name(entry, icon_pos);
	}

/// <summary>
/// <para>
/// Retrieves the image used for the icon.
/// </para>
/// <para>
/// Unlike the other methods of setting and getting icon data, this
/// method will work regardless of whether the icon was set using a
/// #GdkPixbuf, a #GIcon, a stock item, or an icon name.
/// </para>
/// </summary>

/// <param name="entry">
/// A #GtkEntry
/// </param>
/// <param name="icon_pos">
/// Icon position
/// </param>
/// <return>
/// A #GdkPixbuf, or %NULL if no icon is
///     set for this position.
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle GetIconPixbuf(this MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos)
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_icon_pixbuf(entry, icon_pos);
	}

/// <summary>
/// <para>
/// Returns whether the icon appears sensitive or insensitive.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <param name="icon_pos">
/// Icon position
/// </param>
/// <return>
/// %TRUE if the icon is sensitive.
/// </return>

	public static bool GetIconSensitive(this MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos)
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_icon_sensitive(entry, icon_pos);
	}

/// <summary>
/// <para>
/// Retrieves the stock id used for the icon, or %NULL if there is
/// no icon or if the icon was set by some other method (e.g., by
/// pixbuf, icon name or gicon).
/// </para>
/// </summary>

/// <param name="entry">
/// A #GtkEntry
/// </param>
/// <param name="icon_pos">
/// Icon position
/// </param>
/// <return>
/// A stock id, or %NULL if no icon is set or if the icon
///          wasn’t set from a stock id
/// </return>

	public static string GetIconStock(this MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos)
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_icon_stock(entry, icon_pos);
	}

/// <summary>
/// <para>
/// Gets the type of representation being used by the icon
/// to store image data. If the icon has no image data,
/// the return value will be %GTK_IMAGE_EMPTY.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <param name="icon_pos">
/// Icon position
/// </param>
/// <return>
/// image representation being used
/// </return>

	public static MentorLake.Gtk.GtkImageType GetIconStorageType(this MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos)
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_icon_storage_type(entry, icon_pos);
	}

/// <summary>
/// <para>
/// Gets the contents of the tooltip on the icon at the specified
/// position in @entry.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <param name="icon_pos">
/// the icon position
/// </param>
/// <return>
/// the tooltip text, or %NULL. Free the returned
///     string with g_free() when done.
/// </return>

	public static string GetIconTooltipMarkup(this MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos)
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_icon_tooltip_markup(entry, icon_pos);
	}

/// <summary>
/// <para>
/// Gets the contents of the tooltip on the icon at the specified
/// position in @entry.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <param name="icon_pos">
/// the icon position
/// </param>
/// <return>
/// the tooltip text, or %NULL. Free the returned
///     string with g_free() when done.
/// </return>

	public static string GetIconTooltipText(this MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos)
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_icon_tooltip_text(entry, icon_pos);
	}

/// <summary>
/// <para>
/// This function returns the entry’s #GtkEntry:inner-border property. See
/// gtk_entry_set_inner_border() for more information.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <return>
/// the entry’s #GtkBorder, or
///   %NULL if none was set.
/// </return>

	public static MentorLake.Gtk.GtkBorderHandle GetInnerBorder(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_inner_border(entry);
	}

/// <summary>
/// <para>
/// Gets the value of the #GtkEntry:input-hints property.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>

	public static MentorLake.Gtk.GtkInputHints GetInputHints(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_input_hints(entry);
	}

/// <summary>
/// <para>
/// Gets the value of the #GtkEntry:input-purpose property.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>

	public static MentorLake.Gtk.GtkInputPurpose GetInputPurpose(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_input_purpose(entry);
	}

/// <summary>
/// <para>
/// Retrieves the character displayed in place of the real characters
/// for entries with visibility set to false. See gtk_entry_set_invisible_char().
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <return>
/// the current invisible char, or 0, if the entry does not
///               show invisible text at all.
/// </return>

	public static char GetInvisibleChar(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_invisible_char(entry);
	}

/// <summary>
/// <para>
/// Gets the #PangoLayout used to display the entry.
/// The layout is useful to e.g. convert text positions to
/// pixel positions, in combination with gtk_entry_get_layout_offsets().
/// The returned layout is owned by the entry and must not be
/// modified or freed by the caller.
/// </para>
/// <para>
/// Keep in mind that the layout text may contain a preedit string, so
/// gtk_entry_layout_index_to_text_index() and
/// gtk_entry_text_index_to_layout_index() are needed to convert byte
/// indices in the layout to byte indices in the entry contents.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <return>
/// the #PangoLayout for this entry
/// </return>

	public static MentorLake.Pango.PangoLayoutHandle GetLayout(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_layout(entry);
	}

/// <summary>
/// <para>
/// Obtains the position of the #PangoLayout used to render text
/// in the entry, in widget coordinates. Useful if you want to line
/// up the text in an entry with some other text, e.g. when using the
/// entry to implement editable cells in a sheet widget.
/// </para>
/// <para>
/// Also useful to convert mouse events into coordinates inside the
/// #PangoLayout, e.g. to take some action if some part of the entry text
/// is clicked.
/// </para>
/// <para>
/// Note that as the user scrolls around in the entry the offsets will
/// change; you’ll need to connect to the “notify::scroll-offset”
/// signal to track this. Remember when using the #PangoLayout
/// functions you need to convert to and from pixels using
/// PANGO_PIXELS() or #PANGO_SCALE.
/// </para>
/// <para>
/// Keep in mind that the layout text may contain a preedit string, so
/// gtk_entry_layout_index_to_text_index() and
/// gtk_entry_text_index_to_layout_index() are needed to convert byte
/// indices in the layout to byte indices in the entry contents.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <param name="x">
/// location to store X offset of layout, or %NULL
/// </param>
/// <param name="y">
/// location to store Y offset of layout, or %NULL
/// </param>

	public static T GetLayoutOffsets<T>(this T entry, out int x, out int y) where T : GtkEntryHandle
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_get_layout_offsets(entry, out x, out y);
		return entry;
	}

/// <summary>
/// <para>
/// Retrieves the maximum allowed length of the text in
/// @entry. See gtk_entry_set_max_length().
/// </para>
/// <para>
/// This is equivalent to getting @entry&apos;s #GtkEntryBuffer and
/// calling gtk_entry_buffer_get_max_length() on it.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <return>
/// the maximum allowed number of characters
///               in #GtkEntry, or 0 if there is no maximum.
/// </return>

	public static int GetMaxLength(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_max_length(entry);
	}

/// <summary>
/// <para>
/// Retrieves the desired maximum width of @entry, in characters.
/// See gtk_entry_set_max_width_chars().
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <return>
/// the maximum width of the entry, in characters
/// </return>

	public static int GetMaxWidthChars(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_max_width_chars(entry);
	}

/// <summary>
/// <para>
/// Gets the value set by gtk_entry_set_overwrite_mode().
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <return>
/// whether the text is overwritten when typing.
/// </return>

	public static bool GetOverwriteMode(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_overwrite_mode(entry);
	}

/// <summary>
/// <para>
/// Retrieves the text that will be displayed when @entry is empty and unfocused
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <return>
/// a pointer to the placeholder text as a string. This string points to internally allocated
/// storage in the widget and must not be freed, modified or stored.
/// </return>

	public static string GetPlaceholderText(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_placeholder_text(entry);
	}

/// <summary>
/// <para>
/// Returns the current fraction of the task that’s been completed.
/// See gtk_entry_set_progress_fraction().
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <return>
/// a fraction from 0.0 to 1.0
/// </return>

	public static double GetProgressFraction(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_progress_fraction(entry);
	}

/// <summary>
/// <para>
/// Retrieves the pulse step set with gtk_entry_set_progress_pulse_step().
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <return>
/// a fraction from 0.0 to 1.0
/// </return>

	public static double GetProgressPulseStep(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_progress_pulse_step(entry);
	}

/// <summary>
/// <para>
/// Gets the tabstops that were set on the entry using gtk_entry_set_tabs(), if
/// any.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <return>
/// the tabstops, or %NULL if none was set.
/// </return>

	public static MentorLake.Pango.PangoTabArrayHandle GetTabs(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_tabs(entry);
	}

/// <summary>
/// <para>
/// Retrieves the contents of the entry widget.
/// See also gtk_editable_get_chars().
/// </para>
/// <para>
/// This is equivalent to getting @entry&apos;s #GtkEntryBuffer and calling
/// gtk_entry_buffer_get_text() on it.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <return>
/// a pointer to the contents of the widget as a
///      string. This string points to internally allocated
///      storage in the widget and must not be freed, modified or
///      stored.
/// </return>

	public static string GetText(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_text(entry);
	}

/// <summary>
/// <para>
/// Gets the area where the entry’s text is drawn. This function is
/// useful when drawing something to the entry in a draw callback.
/// </para>
/// <para>
/// If the entry is not realized, @text_area is filled with zeros.
/// </para>
/// <para>
/// See also gtk_entry_get_icon_area().
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <param name="text_area">
/// Return location for the text area.
/// </param>

	public static T GetTextArea<T>(this T entry, out MentorLake.Gdk.GdkRectangle text_area) where T : GtkEntryHandle
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_get_text_area(entry, out text_area);
		return entry;
	}

/// <summary>
/// <para>
/// Retrieves the current length of the text in
/// @entry.
/// </para>
/// <para>
/// This is equivalent to getting @entry&apos;s #GtkEntryBuffer and
/// calling gtk_entry_buffer_get_length() on it.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <return>
/// the current number of characters
///               in #GtkEntry, or 0 if there are none.
/// </return>

	public static ushort GetTextLength(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_text_length(entry);
	}

/// <summary>
/// <para>
/// Retrieves whether the text in @entry is visible. See
/// gtk_entry_set_visibility().
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <return>
/// %TRUE if the text is currently visible
/// </return>

	public static bool GetVisibility(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_visibility(entry);
	}

/// <summary>
/// <para>
/// Gets the value set by gtk_entry_set_width_chars().
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <return>
/// number of chars to request space for, or negative if unset
/// </return>

	public static int GetWidthChars(this MentorLake.Gtk.GtkEntryHandle entry)
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_get_width_chars(entry);
	}

/// <summary>
/// <para>
/// Causes @entry to have keyboard focus.
/// </para>
/// <para>
/// It behaves like gtk_widget_grab_focus(),
/// except that it doesn&apos;t select the contents of the entry.
/// You only want to call this on some special entries
/// which the user usually doesn&apos;t want to replace all text in,
/// such as search-as-you-type entries.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>

	public static T GrabFocusWithoutSelecting<T>(this T entry) where T : GtkEntryHandle
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_grab_focus_without_selecting(entry);
		return entry;
	}

/// <summary>
/// <para>
/// Allow the #GtkEntry input method to internally handle key press
/// and release events. If this function returns %TRUE, then no further
/// processing should be done for this key event. See
/// gtk_im_context_filter_keypress().
/// </para>
/// <para>
/// Note that you are expected to call this function from your handler
/// when overriding key event handling. This is needed in the case when
/// you need to insert your own key handling between the input method
/// and the default key event handling of the #GtkEntry.
/// See gtk_text_view_reset_im_context() for an example of use.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <param name="@event">
/// the key event
/// </param>
/// <return>
/// %TRUE if the input method handled the key event.
/// </return>

	public static bool ImContextFilterKeypress(this MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gdk.GdkEventKeyHandle @event)
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_im_context_filter_keypress(entry, @event);
	}

/// <summary>
/// <para>
/// Converts from a position in the entry’s #PangoLayout (returned by
/// gtk_entry_get_layout()) to a position in the entry contents
/// (returned by gtk_entry_get_text()).
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <param name="layout_index">
/// byte index into the entry layout text
/// </param>
/// <return>
/// byte index into the entry contents
/// </return>

	public static int LayoutIndexToTextIndex(this MentorLake.Gtk.GtkEntryHandle entry, int layout_index)
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_layout_index_to_text_index(entry, layout_index);
	}

/// <summary>
/// <para>
/// Indicates that some progress is made, but you don’t know how much.
/// Causes the entry’s progress indicator to enter “activity mode,”
/// where a block bounces back and forth. Each call to
/// gtk_entry_progress_pulse() causes the block to move by a little bit
/// (the amount of movement per pulse is determined by
/// gtk_entry_set_progress_pulse_step()).
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>

	public static T ProgressPulse<T>(this T entry) where T : GtkEntryHandle
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_progress_pulse(entry);
		return entry;
	}

/// <summary>
/// <para>
/// Reset the input method context of the entry if needed.
/// </para>
/// <para>
/// This can be necessary in the case where modifying the buffer
/// would confuse on-going input method behavior.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>

	public static T ResetImContext<T>(this T entry) where T : GtkEntryHandle
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_reset_im_context(entry);
		return entry;
	}

/// <summary>
/// <para>
/// If @setting is %TRUE, pressing Enter in the @entry will activate the default
/// widget for the window containing the entry. This usually means that
/// the dialog box containing the entry will be closed, since the default
/// widget is usually one of the dialog buttons.
/// </para>
/// <para>
/// (For experts: if @setting is %TRUE, the entry calls
/// gtk_window_activate_default() on the window containing the entry, in
/// the default handler for the #GtkEntry::activate signal.)
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <param name="setting">
/// %TRUE to activate window’s default widget on Enter keypress
/// </param>

	public static T SetActivatesDefault<T>(this T entry, bool setting) where T : GtkEntryHandle
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_activates_default(entry, setting);
		return entry;
	}

/// <summary>
/// <para>
/// Sets the alignment for the contents of the entry. This controls
/// the horizontal positioning of the contents when the displayed
/// text is shorter than the width of the entry.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <param name="xalign">
/// The horizontal alignment, from 0 (left) to 1 (right).
///          Reversed for RTL layouts
/// </param>

	public static T SetAlignment<T>(this T entry, float xalign) where T : GtkEntryHandle
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_alignment(entry, xalign);
		return entry;
	}

/// <summary>
/// <para>
/// Sets a #PangoAttrList; the attributes in the list are applied to the
/// entry text.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <param name="attrs">
/// a #PangoAttrList
/// </param>

	public static T SetAttributes<T>(this T entry, MentorLake.Pango.PangoAttrListHandle attrs) where T : GtkEntryHandle
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_attributes(entry, attrs);
		return entry;
	}

/// <summary>
/// <para>
/// Set the #GtkEntryBuffer object which holds the text for
/// this widget.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <param name="buffer">
/// a #GtkEntryBuffer
/// </param>

	public static T SetBuffer<T>(this T entry, MentorLake.Gtk.GtkEntryBufferHandle buffer) where T : GtkEntryHandle
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_buffer(entry, buffer);
		return entry;
	}

/// <summary>
/// <para>
/// Sets @completion to be the auxiliary completion object to use with @entry.
/// All further configuration of the completion mechanism is done on
/// @completion using the #GtkEntryCompletion API. Completion is disabled if
/// @completion is set to %NULL.
/// </para>
/// </summary>

/// <param name="entry">
/// A #GtkEntry
/// </param>
/// <param name="completion">
/// The #GtkEntryCompletion or %NULL
/// </param>

	public static T SetCompletion<T>(this T entry, MentorLake.Gtk.GtkEntryCompletionHandle completion) where T : GtkEntryHandle
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_completion(entry, completion);
		return entry;
	}

/// <summary>
/// <para>
/// Hooks up an adjustment to the cursor position in an entry, so that when
/// the cursor is moved, the adjustment is scrolled to show that position.
/// See gtk_scrolled_window_get_hadjustment() for a typical way of obtaining
/// the adjustment.
/// </para>
/// <para>
/// The adjustment has to be in pixel units and in the same coordinate system
/// as the entry.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <param name="adjustment">
/// an adjustment which should be adjusted when the cursor
///              is moved, or %NULL
/// </param>

	public static T SetCursorHadjustment<T>(this T entry, MentorLake.Gtk.GtkAdjustmentHandle adjustment) where T : GtkEntryHandle
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_cursor_hadjustment(entry, adjustment);
		return entry;
	}

/// <summary>
/// <para>
/// Sets whether the entry has a beveled frame around it.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <param name="setting">
/// new value
/// </param>

	public static T SetHasFrame<T>(this T entry, bool setting) where T : GtkEntryHandle
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_has_frame(entry, setting);
		return entry;
	}

/// <summary>
/// <para>
/// Sets whether the icon is activatable.
/// </para>
/// </summary>

/// <param name="entry">
/// A #GtkEntry
/// </param>
/// <param name="icon_pos">
/// Icon position
/// </param>
/// <param name="activatable">
/// %TRUE if the icon should be activatable
/// </param>

	public static T SetIconActivatable<T>(this T entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos, bool activatable) where T : GtkEntryHandle
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_icon_activatable(entry, icon_pos, activatable);
		return entry;
	}

/// <summary>
/// <para>
/// Sets up the icon at the given position so that GTK+ will start a drag
/// operation when the user clicks and drags the icon.
/// </para>
/// <para>
/// To handle the drag operation, you need to connect to the usual
/// #GtkWidget::drag-data-get (or possibly #GtkWidget::drag-data-delete)
/// signal, and use gtk_entry_get_current_icon_drag_source() in
/// your signal handler to find out if the drag was started from
/// an icon.
/// </para>
/// <para>
/// By default, GTK+ uses the icon as the drag icon. You can use the
/// #GtkWidget::drag-begin signal to set a different icon. Note that you
/// have to use g_signal_connect_after() to ensure that your signal handler
/// gets executed after the default handler.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <param name="icon_pos">
/// icon position
/// </param>
/// <param name="target_list">
/// the targets (data formats) in which the data can be provided
/// </param>
/// <param name="actions">
/// a bitmask of the allowed drag actions
/// </param>

	public static T SetIconDragSource<T>(this T entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos, MentorLake.Gtk.GtkTargetListHandle target_list, MentorLake.Gdk.GdkDragAction actions) where T : GtkEntryHandle
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_icon_drag_source(entry, icon_pos, target_list, actions);
		return entry;
	}

/// <summary>
/// <para>
/// Sets the icon shown in the entry at the specified position
/// from the current icon theme.
/// If the icon isn’t known, a “broken image” icon will be displayed
/// instead.
/// </para>
/// <para>
/// If @icon is %NULL, no icon will be shown in the specified position.
/// </para>
/// </summary>

/// <param name="entry">
/// A #GtkEntry
/// </param>
/// <param name="icon_pos">
/// The position at which to set the icon
/// </param>
/// <param name="icon">
/// The icon to set, or %NULL
/// </param>

	public static T SetIconFromGicon<T>(this T entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos, MentorLake.Gio.GIconHandle icon) where T : GtkEntryHandle
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_icon_from_gicon(entry, icon_pos, icon);
		return entry;
	}

/// <summary>
/// <para>
/// Sets the icon shown in the entry at the specified position
/// from the current icon theme.
/// </para>
/// <para>
/// If the icon name isn’t known, a “broken image” icon will be displayed
/// instead.
/// </para>
/// <para>
/// If @icon_name is %NULL, no icon will be shown in the specified position.
/// </para>
/// </summary>

/// <param name="entry">
/// A #GtkEntry
/// </param>
/// <param name="icon_pos">
/// The position at which to set the icon
/// </param>
/// <param name="icon_name">
/// An icon name, or %NULL
/// </param>

	public static T SetIconFromIconName<T>(this T entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos, string icon_name) where T : GtkEntryHandle
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_icon_from_icon_name(entry, icon_pos, icon_name);
		return entry;
	}

/// <summary>
/// <para>
/// Sets the icon shown in the specified position using a pixbuf.
/// </para>
/// <para>
/// If @pixbuf is %NULL, no icon will be shown in the specified position.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <param name="icon_pos">
/// Icon position
/// </param>
/// <param name="pixbuf">
/// A #GdkPixbuf, or %NULL
/// </param>

	public static T SetIconFromPixbuf<T>(this T entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos, MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf) where T : GtkEntryHandle
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_icon_from_pixbuf(entry, icon_pos, pixbuf);
		return entry;
	}

/// <summary>
/// <para>
/// Sets the icon shown in the entry at the specified position from
/// a stock image.
/// </para>
/// <para>
/// If @stock_id is %NULL, no icon will be shown in the specified position.
/// </para>
/// </summary>

/// <param name="entry">
/// A #GtkEntry
/// </param>
/// <param name="icon_pos">
/// Icon position
/// </param>
/// <param name="stock_id">
/// The name of the stock item, or %NULL
/// </param>

	public static T SetIconFromStock<T>(this T entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos, string stock_id) where T : GtkEntryHandle
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_icon_from_stock(entry, icon_pos, stock_id);
		return entry;
	}

/// <summary>
/// <para>
/// Sets the sensitivity for the specified icon.
/// </para>
/// </summary>

/// <param name="entry">
/// A #GtkEntry
/// </param>
/// <param name="icon_pos">
/// Icon position
/// </param>
/// <param name="sensitive">
/// Specifies whether the icon should appear
///             sensitive or insensitive
/// </param>

	public static T SetIconSensitive<T>(this T entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos, bool sensitive) where T : GtkEntryHandle
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_icon_sensitive(entry, icon_pos, sensitive);
		return entry;
	}

/// <summary>
/// <para>
/// Sets @tooltip as the contents of the tooltip for the icon at
/// the specified position. @tooltip is assumed to be marked up with
/// the [Pango text markup language][PangoMarkupFormat].
/// </para>
/// <para>
/// Use %NULL for @tooltip to remove an existing tooltip.
/// </para>
/// <para>
/// See also gtk_widget_set_tooltip_markup() and
/// gtk_entry_set_icon_tooltip_text().
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <param name="icon_pos">
/// the icon position
/// </param>
/// <param name="tooltip">
/// the contents of the tooltip for the icon, or %NULL
/// </param>

	public static T SetIconTooltipMarkup<T>(this T entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos, string tooltip) where T : GtkEntryHandle
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_icon_tooltip_markup(entry, icon_pos, tooltip);
		return entry;
	}

/// <summary>
/// <para>
/// Sets @tooltip as the contents of the tooltip for the icon
/// at the specified position.
/// </para>
/// <para>
/// Use %NULL for @tooltip to remove an existing tooltip.
/// </para>
/// <para>
/// See also gtk_widget_set_tooltip_text() and
/// gtk_entry_set_icon_tooltip_markup().
/// </para>
/// <para>
/// If you unset the widget tooltip via gtk_widget_set_tooltip_text() or
/// gtk_widget_set_tooltip_markup(), this sets GtkWidget:has-tooltip to %FALSE,
/// which suppresses icon tooltips too. You can resolve this by then calling
/// gtk_widget_set_has_tooltip() to set GtkWidget:has-tooltip back to %TRUE, or
/// setting at least one non-empty tooltip on any icon achieves the same result.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <param name="icon_pos">
/// the icon position
/// </param>
/// <param name="tooltip">
/// the contents of the tooltip for the icon, or %NULL
/// </param>

	public static T SetIconTooltipText<T>(this T entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos, string tooltip) where T : GtkEntryHandle
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_icon_tooltip_text(entry, icon_pos, tooltip);
		return entry;
	}

/// <summary>
/// <para>
/// Sets %entry’s inner-border property to @border, or clears it if %NULL
/// is passed. The inner-border is the area around the entry’s text, but
/// inside its frame.
/// </para>
/// <para>
/// If set, this property overrides the inner-border style property.
/// Overriding the style-provided border is useful when you want to do
/// in-place editing of some text in a canvas or list widget, where
/// pixel-exact positioning of the entry is important.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <param name="border">
/// a #GtkBorder, or %NULL
/// </param>

	public static T SetInnerBorder<T>(this T entry, MentorLake.Gtk.GtkBorderHandle border) where T : GtkEntryHandle
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_inner_border(entry, border);
		return entry;
	}

/// <summary>
/// <para>
/// Sets the #GtkEntry:input-hints property, which
/// allows input methods to fine-tune their behaviour.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <param name="hints">
/// the hints
/// </param>

	public static T SetInputHints<T>(this T entry, MentorLake.Gtk.GtkInputHints hints) where T : GtkEntryHandle
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_input_hints(entry, hints);
		return entry;
	}

/// <summary>
/// <para>
/// Sets the #GtkEntry:input-purpose property which
/// can be used by on-screen keyboards and other input
/// methods to adjust their behaviour.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <param name="purpose">
/// the purpose
/// </param>

	public static T SetInputPurpose<T>(this T entry, MentorLake.Gtk.GtkInputPurpose purpose) where T : GtkEntryHandle
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_input_purpose(entry, purpose);
		return entry;
	}

/// <summary>
/// <para>
/// Sets the character to use in place of the actual text when
/// gtk_entry_set_visibility() has been called to set text visibility
/// to %FALSE. i.e. this is the character used in “password mode” to
/// show the user how many characters have been typed. By default, GTK+
/// picks the best invisible char available in the current font. If you
/// set the invisible char to 0, then the user will get no feedback
/// at all; there will be no text on the screen as they type.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <param name="ch">
/// a Unicode character
/// </param>

	public static T SetInvisibleChar<T>(this T entry, char ch) where T : GtkEntryHandle
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_invisible_char(entry, ch);
		return entry;
	}

/// <summary>
/// <para>
/// Sets the maximum allowed length of the contents of the widget. If
/// the current contents are longer than the given length, then they
/// will be truncated to fit.
/// </para>
/// <para>
/// This is equivalent to getting @entry&apos;s #GtkEntryBuffer and
/// calling gtk_entry_buffer_set_max_length() on it.
/// ]|
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <param name="max">
/// the maximum length of the entry, or 0 for no maximum.
///   (other than the maximum length of entries.) The value passed in will
///   be clamped to the range 0-65536.
/// </param>

	public static T SetMaxLength<T>(this T entry, int max) where T : GtkEntryHandle
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_max_length(entry, max);
		return entry;
	}

/// <summary>
/// <para>
/// Sets the desired maximum width in characters of @entry.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <param name="n_chars">
/// the new desired maximum width, in characters
/// </param>

	public static T SetMaxWidthChars<T>(this T entry, int n_chars) where T : GtkEntryHandle
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_max_width_chars(entry, n_chars);
		return entry;
	}

/// <summary>
/// <para>
/// Sets whether the text is overwritten when typing in the #GtkEntry.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <param name="overwrite">
/// new value
/// </param>

	public static T SetOverwriteMode<T>(this T entry, bool overwrite) where T : GtkEntryHandle
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_overwrite_mode(entry, overwrite);
		return entry;
	}

/// <summary>
/// <para>
/// Sets text to be displayed in @entry when it is empty and unfocused.
/// This can be used to give a visual hint of the expected contents of
/// the #GtkEntry.
/// </para>
/// <para>
/// Note that since the placeholder text gets removed when the entry
/// received focus, using this feature is a bit problematic if the entry
/// is given the initial focus in a window. Sometimes this can be
/// worked around by delaying the initial focus setting until the
/// first key event arrives.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <param name="text">
/// a string to be displayed when @entry is empty and unfocused, or %NULL
/// </param>

	public static T SetPlaceholderText<T>(this T entry, string text) where T : GtkEntryHandle
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_placeholder_text(entry, text);
		return entry;
	}

/// <summary>
/// <para>
/// Causes the entry’s progress indicator to “fill in” the given
/// fraction of the bar. The fraction should be between 0.0 and 1.0,
/// inclusive.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <param name="fraction">
/// fraction of the task that’s been completed
/// </param>

	public static T SetProgressFraction<T>(this T entry, double fraction) where T : GtkEntryHandle
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_progress_fraction(entry, fraction);
		return entry;
	}

/// <summary>
/// <para>
/// Sets the fraction of total entry width to move the progress
/// bouncing block for each call to gtk_entry_progress_pulse().
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <param name="fraction">
/// fraction between 0.0 and 1.0
/// </param>

	public static T SetProgressPulseStep<T>(this T entry, double fraction) where T : GtkEntryHandle
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_progress_pulse_step(entry, fraction);
		return entry;
	}

/// <summary>
/// <para>
/// Sets a #PangoTabArray; the tabstops in the array are applied to the entry
/// text.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <param name="tabs">
/// a #PangoTabArray
/// </param>

	public static T SetTabs<T>(this T entry, MentorLake.Pango.PangoTabArrayHandle tabs) where T : GtkEntryHandle
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_tabs(entry, tabs);
		return entry;
	}

/// <summary>
/// <para>
/// Sets the text in the widget to the given
/// value, replacing the current contents.
/// </para>
/// <para>
/// See gtk_entry_buffer_set_text().
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <param name="text">
/// the new text
/// </param>

	public static T SetText<T>(this T entry, string text) where T : GtkEntryHandle
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_text(entry, text);
		return entry;
	}

/// <summary>
/// <para>
/// Sets whether the contents of the entry are visible or not.
/// When visibility is set to %FALSE, characters are displayed
/// as the invisible char, and will also appear that way when
/// the text in the entry widget is copied elsewhere.
/// </para>
/// <para>
/// By default, GTK+ picks the best invisible character available
/// in the current font, but it can be changed with
/// gtk_entry_set_invisible_char().
/// </para>
/// <para>
/// Note that you probably want to set #GtkEntry:input-purpose
/// to %GTK_INPUT_PURPOSE_PASSWORD or %GTK_INPUT_PURPOSE_PIN to
/// inform input methods about the purpose of this entry,
/// in addition to setting visibility to %FALSE.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <param name="visible">
/// %TRUE if the contents of the entry are displayed
///           as plaintext
/// </param>

	public static T SetVisibility<T>(this T entry, bool visible) where T : GtkEntryHandle
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_visibility(entry, visible);
		return entry;
	}

/// <summary>
/// <para>
/// Changes the size request of the entry to be about the right size
/// for @n_chars characters. Note that it changes the size
/// request, the size can still be affected by
/// how you pack the widget into containers. If @n_chars is -1, the
/// size reverts to the default entry size.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <param name="n_chars">
/// width in chars
/// </param>

	public static T SetWidthChars<T>(this T entry, int n_chars) where T : GtkEntryHandle
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_set_width_chars(entry, n_chars);
		return entry;
	}

/// <summary>
/// <para>
/// Converts from a position in the entry contents (returned
/// by gtk_entry_get_text()) to a position in the
/// entry’s #PangoLayout (returned by gtk_entry_get_layout(),
/// with text retrieved via pango_layout_get_text()).
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>
/// <param name="text_index">
/// byte index into the entry contents
/// </param>
/// <return>
/// byte index into the entry layout text
/// </return>

	public static int TextIndexToLayoutIndex(this MentorLake.Gtk.GtkEntryHandle entry, int text_index)
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		return GtkEntryHandleExterns.gtk_entry_text_index_to_layout_index(entry, text_index);
	}

/// <summary>
/// <para>
/// Unsets the invisible char previously set with
/// gtk_entry_set_invisible_char(). So that the
/// default invisible char is used again.
/// </para>
/// </summary>

/// <param name="entry">
/// a #GtkEntry
/// </param>

	public static T UnsetInvisibleChar<T>(this T entry) where T : GtkEntryHandle
	{
		if (entry.IsInvalid) throw new Exception("Invalid handle (GtkEntryHandle)");
		GtkEntryHandleExterns.gtk_entry_unset_invisible_char(entry);
		return entry;
	}

}

internal class GtkEntryHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))]
	internal static extern MentorLake.Gtk.GtkEntryHandle gtk_entry_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))]
	internal static extern MentorLake.Gtk.GtkEntryHandle gtk_entry_new_with_buffer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryBufferHandle>))] MentorLake.Gtk.GtkEntryBufferHandle buffer);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_entry_get_activates_default([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry);

	[DllImport(GtkLibrary.Name)]
	internal static extern float gtk_entry_get_alignment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))]
	internal static extern MentorLake.Pango.PangoAttrListHandle gtk_entry_get_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryBufferHandle>))]
	internal static extern MentorLake.Gtk.GtkEntryBufferHandle gtk_entry_get_buffer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryCompletionHandle>))]
	internal static extern MentorLake.Gtk.GtkEntryCompletionHandle gtk_entry_get_completion([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_entry_get_current_icon_drag_source([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))]
	internal static extern MentorLake.Gio.GIconHandle gtk_entry_get_icon_gicon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_entry_get_icon_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry, MentorLake.Gtk.GtkEntryIconPosition icon_pos);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBorderHandle>))]
	internal static extern MentorLake.Gtk.GtkBorderHandle gtk_entry_get_inner_border([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkInputHints gtk_entry_get_input_hints([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkInputPurpose gtk_entry_get_input_purpose([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry);

	[DllImport(GtkLibrary.Name)]
	internal static extern char gtk_entry_get_invisible_char([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryHandle>))] MentorLake.Gtk.GtkEntryHandle entry);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoTabArrayHandle>))]
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
