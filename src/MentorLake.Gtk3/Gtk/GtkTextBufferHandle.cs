namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// You may wish to begin by reading the
/// [text widget conceptual overview](TextWidget.html)
/// which gives an overview of all the objects and data
/// types related to the text widget and how they work together.
/// </para>
/// </summary>

public class GtkTextBufferHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new text buffer.
/// </para>
/// </summary>

/// <param name="table">
/// a tag table, or %NULL to create a new one
/// </param>
/// <return>
/// a new text buffer
/// </return>

	public static MentorLake.Gtk.GtkTextBufferHandle New(MentorLake.Gtk.GtkTextTagTableHandle table)
	{
		return GtkTextBufferHandleExterns.gtk_text_buffer_new(table);
	}

}
public static class GtkTextBufferHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::apply-tag signal is emitted to apply a tag to a
/// range of text in a #GtkTextBuffer.
/// Applying actually occurs in the default handler.
/// </para>
/// <para>
/// Note that if your handler runs before the default handler it must not
/// invalidate the @start and @end iters (or has to revalidate them).
/// </para>
/// <para>
/// See also:
/// gtk_text_buffer_apply_tag(),
/// gtk_text_buffer_insert_with_tags(),
/// gtk_text_buffer_insert_range().
/// </para>
/// </summary>

	public static IObservable<GtkTextBufferHandleSignalStructs.ApplyTagSignal> Signal_ApplyTag(this GtkTextBufferHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextBufferHandleSignalStructs.ApplyTagSignal> obs) =>
		{
			GtkTextBufferHandleSignalDelegates.apply_tag handler = ( MentorLake.Gtk.GtkTextBufferHandle self,  MentorLake.Gtk.GtkTextTagHandle tag,  MentorLake.Gtk.GtkTextIterHandle start,  MentorLake.Gtk.GtkTextIterHandle end,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextBufferHandleSignalStructs.ApplyTagSignal()
				{
					Self = self, Tag = tag, Start = start, End = end, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "apply-tag", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::begin-user-action signal is emitted at the beginning of a single
/// user-visible operation on a #GtkTextBuffer.
/// </para>
/// <para>
/// See also:
/// gtk_text_buffer_begin_user_action(),
/// gtk_text_buffer_insert_interactive(),
/// gtk_text_buffer_insert_range_interactive(),
/// gtk_text_buffer_delete_interactive(),
/// gtk_text_buffer_backspace(),
/// gtk_text_buffer_delete_selection().
/// </para>
/// </summary>

	public static IObservable<GtkTextBufferHandleSignalStructs.BeginUserActionSignal> Signal_BeginUserAction(this GtkTextBufferHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextBufferHandleSignalStructs.BeginUserActionSignal> obs) =>
		{
			GtkTextBufferHandleSignalDelegates.begin_user_action handler = ( MentorLake.Gtk.GtkTextBufferHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextBufferHandleSignalStructs.BeginUserActionSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "begin-user-action", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::changed signal is emitted when the content of a #GtkTextBuffer
/// has changed.
/// </para>
/// </summary>

	public static IObservable<GtkTextBufferHandleSignalStructs.ChangedSignal> Signal_Changed(this GtkTextBufferHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextBufferHandleSignalStructs.ChangedSignal> obs) =>
		{
			GtkTextBufferHandleSignalDelegates.changed handler = ( MentorLake.Gtk.GtkTextBufferHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextBufferHandleSignalStructs.ChangedSignal()
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
/// The ::delete-range signal is emitted to delete a range
/// from a #GtkTextBuffer.
/// </para>
/// <para>
/// Note that if your handler runs before the default handler it must not
/// invalidate the @start and @end iters (or has to revalidate them).
/// The default signal handler revalidates the @start and @end iters to
/// both point to the location where text was deleted. Handlers
/// which run after the default handler (see g_signal_connect_after())
/// do not have access to the deleted text.
/// </para>
/// <para>
/// See also: gtk_text_buffer_delete().
/// </para>
/// </summary>

	public static IObservable<GtkTextBufferHandleSignalStructs.DeleteRangeSignal> Signal_DeleteRange(this GtkTextBufferHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextBufferHandleSignalStructs.DeleteRangeSignal> obs) =>
		{
			GtkTextBufferHandleSignalDelegates.delete_range handler = ( MentorLake.Gtk.GtkTextBufferHandle self,  MentorLake.Gtk.GtkTextIterHandle start,  MentorLake.Gtk.GtkTextIterHandle end,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextBufferHandleSignalStructs.DeleteRangeSignal()
				{
					Self = self, Start = start, End = end, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "delete-range", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::end-user-action signal is emitted at the end of a single
/// user-visible operation on the #GtkTextBuffer.
/// </para>
/// <para>
/// See also:
/// gtk_text_buffer_end_user_action(),
/// gtk_text_buffer_insert_interactive(),
/// gtk_text_buffer_insert_range_interactive(),
/// gtk_text_buffer_delete_interactive(),
/// gtk_text_buffer_backspace(),
/// gtk_text_buffer_delete_selection(),
/// gtk_text_buffer_backspace().
/// </para>
/// </summary>

	public static IObservable<GtkTextBufferHandleSignalStructs.EndUserActionSignal> Signal_EndUserAction(this GtkTextBufferHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextBufferHandleSignalStructs.EndUserActionSignal> obs) =>
		{
			GtkTextBufferHandleSignalDelegates.end_user_action handler = ( MentorLake.Gtk.GtkTextBufferHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextBufferHandleSignalStructs.EndUserActionSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "end-user-action", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::insert-child-anchor signal is emitted to insert a
/// #GtkTextChildAnchor in a #GtkTextBuffer.
/// Insertion actually occurs in the default handler.
/// </para>
/// <para>
/// Note that if your handler runs before the default handler it must
/// not invalidate the @location iter (or has to revalidate it).
/// The default signal handler revalidates it to be placed after the
/// inserted @anchor.
/// </para>
/// <para>
/// See also: gtk_text_buffer_insert_child_anchor().
/// </para>
/// </summary>

	public static IObservable<GtkTextBufferHandleSignalStructs.InsertChildAnchorSignal> Signal_InsertChildAnchor(this GtkTextBufferHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextBufferHandleSignalStructs.InsertChildAnchorSignal> obs) =>
		{
			GtkTextBufferHandleSignalDelegates.insert_child_anchor handler = ( MentorLake.Gtk.GtkTextBufferHandle self,  MentorLake.Gtk.GtkTextIterHandle location,  MentorLake.Gtk.GtkTextChildAnchorHandle anchor,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextBufferHandleSignalStructs.InsertChildAnchorSignal()
				{
					Self = self, Location = location, Anchor = anchor, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "insert-child-anchor", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::insert-pixbuf signal is emitted to insert a #GdkPixbuf
/// in a #GtkTextBuffer. Insertion actually occurs in the default handler.
/// </para>
/// <para>
/// Note that if your handler runs before the default handler it must not
/// invalidate the @location iter (or has to revalidate it).
/// The default signal handler revalidates it to be placed after the
/// inserted @pixbuf.
/// </para>
/// <para>
/// See also: gtk_text_buffer_insert_pixbuf().
/// </para>
/// </summary>

	public static IObservable<GtkTextBufferHandleSignalStructs.InsertPixbufSignal> Signal_InsertPixbuf(this GtkTextBufferHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextBufferHandleSignalStructs.InsertPixbufSignal> obs) =>
		{
			GtkTextBufferHandleSignalDelegates.insert_pixbuf handler = ( MentorLake.Gtk.GtkTextBufferHandle self,  MentorLake.Gtk.GtkTextIterHandle location,  MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextBufferHandleSignalStructs.InsertPixbufSignal()
				{
					Self = self, Location = location, Pixbuf = pixbuf, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "insert-pixbuf", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::insert-text signal is emitted to insert text in a #GtkTextBuffer.
/// Insertion actually occurs in the default handler.
/// </para>
/// <para>
/// Note that if your handler runs before the default handler it must not
/// invalidate the @location iter (or has to revalidate it).
/// The default signal handler revalidates it to point to the end of the
/// inserted text.
/// </para>
/// <para>
/// See also:
/// gtk_text_buffer_insert(),
/// gtk_text_buffer_insert_range().
/// </para>
/// </summary>

	public static IObservable<GtkTextBufferHandleSignalStructs.InsertTextSignal> Signal_InsertText(this GtkTextBufferHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextBufferHandleSignalStructs.InsertTextSignal> obs) =>
		{
			GtkTextBufferHandleSignalDelegates.insert_text handler = ( MentorLake.Gtk.GtkTextBufferHandle self,  MentorLake.Gtk.GtkTextIterHandle location,  string text,  int len,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextBufferHandleSignalStructs.InsertTextSignal()
				{
					Self = self, Location = location, Text = text, Len = len, UserData = user_data
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
/// <summary>
/// <para>
/// The ::mark-deleted signal is emitted as notification
/// after a #GtkTextMark is deleted.
/// </para>
/// <para>
/// See also:
/// gtk_text_buffer_delete_mark().
/// </para>
/// </summary>

	public static IObservable<GtkTextBufferHandleSignalStructs.MarkDeletedSignal> Signal_MarkDeleted(this GtkTextBufferHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextBufferHandleSignalStructs.MarkDeletedSignal> obs) =>
		{
			GtkTextBufferHandleSignalDelegates.mark_deleted handler = ( MentorLake.Gtk.GtkTextBufferHandle self,  MentorLake.Gtk.GtkTextMarkHandle mark,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextBufferHandleSignalStructs.MarkDeletedSignal()
				{
					Self = self, Mark = mark, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "mark-deleted", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::mark-set signal is emitted as notification
/// after a #GtkTextMark is set.
/// </para>
/// <para>
/// See also:
/// gtk_text_buffer_create_mark(),
/// gtk_text_buffer_move_mark().
/// </para>
/// </summary>

	public static IObservable<GtkTextBufferHandleSignalStructs.MarkSetSignal> Signal_MarkSet(this GtkTextBufferHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextBufferHandleSignalStructs.MarkSetSignal> obs) =>
		{
			GtkTextBufferHandleSignalDelegates.mark_set handler = ( MentorLake.Gtk.GtkTextBufferHandle self,  MentorLake.Gtk.GtkTextIterHandle location,  MentorLake.Gtk.GtkTextMarkHandle mark,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextBufferHandleSignalStructs.MarkSetSignal()
				{
					Self = self, Location = location, Mark = mark, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "mark-set", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::modified-changed signal is emitted when the modified bit of a
/// #GtkTextBuffer flips.
/// </para>
/// <para>
/// See also:
/// gtk_text_buffer_set_modified().
/// </para>
/// </summary>

	public static IObservable<GtkTextBufferHandleSignalStructs.ModifiedChangedSignal> Signal_ModifiedChanged(this GtkTextBufferHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextBufferHandleSignalStructs.ModifiedChangedSignal> obs) =>
		{
			GtkTextBufferHandleSignalDelegates.modified_changed handler = ( MentorLake.Gtk.GtkTextBufferHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextBufferHandleSignalStructs.ModifiedChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "modified-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The paste-done signal is emitted after paste operation has been completed.
/// This is useful to properly scroll the view to the end of the pasted text.
/// See gtk_text_buffer_paste_clipboard() for more details.
/// </para>
/// </summary>

	public static IObservable<GtkTextBufferHandleSignalStructs.PasteDoneSignal> Signal_PasteDone(this GtkTextBufferHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextBufferHandleSignalStructs.PasteDoneSignal> obs) =>
		{
			GtkTextBufferHandleSignalDelegates.paste_done handler = ( MentorLake.Gtk.GtkTextBufferHandle self,  MentorLake.Gtk.GtkClipboardHandle clipboard,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextBufferHandleSignalStructs.PasteDoneSignal()
				{
					Self = self, Clipboard = clipboard, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "paste-done", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::remove-tag signal is emitted to remove all occurrences of @tag from
/// a range of text in a #GtkTextBuffer.
/// Removal actually occurs in the default handler.
/// </para>
/// <para>
/// Note that if your handler runs before the default handler it must not
/// invalidate the @start and @end iters (or has to revalidate them).
/// </para>
/// <para>
/// See also:
/// gtk_text_buffer_remove_tag().
/// </para>
/// </summary>

	public static IObservable<GtkTextBufferHandleSignalStructs.RemoveTagSignal> Signal_RemoveTag(this GtkTextBufferHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextBufferHandleSignalStructs.RemoveTagSignal> obs) =>
		{
			GtkTextBufferHandleSignalDelegates.remove_tag handler = ( MentorLake.Gtk.GtkTextBufferHandle self,  MentorLake.Gtk.GtkTextTagHandle tag,  MentorLake.Gtk.GtkTextIterHandle start,  MentorLake.Gtk.GtkTextIterHandle end,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextBufferHandleSignalStructs.RemoveTagSignal()
				{
					Self = self, Tag = tag, Start = start, End = end, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "remove-tag", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkTextBufferHandleSignalStructs
{

public class ApplyTagSignal
{

	public MentorLake.Gtk.GtkTextBufferHandle Self;
/// <summary>
/// <para>
/// the applied tag
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTextTagHandle Tag;
/// <summary>
/// <para>
/// the start of the range the tag is applied to
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTextIterHandle Start;
/// <summary>
/// <para>
/// the end of the range the tag is applied to
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTextIterHandle End;

	public IntPtr UserData;
}

public class BeginUserActionSignal
{

	public MentorLake.Gtk.GtkTextBufferHandle Self;

	public IntPtr UserData;
}

public class ChangedSignal
{

	public MentorLake.Gtk.GtkTextBufferHandle Self;

	public IntPtr UserData;
}

public class DeleteRangeSignal
{

	public MentorLake.Gtk.GtkTextBufferHandle Self;
/// <summary>
/// <para>
/// the start of the range to be deleted
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTextIterHandle Start;
/// <summary>
/// <para>
/// the end of the range to be deleted
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTextIterHandle End;

	public IntPtr UserData;
}

public class EndUserActionSignal
{

	public MentorLake.Gtk.GtkTextBufferHandle Self;

	public IntPtr UserData;
}

public class InsertChildAnchorSignal
{

	public MentorLake.Gtk.GtkTextBufferHandle Self;
/// <summary>
/// <para>
/// position to insert @anchor in @textbuffer
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTextIterHandle Location;
/// <summary>
/// <para>
/// the #GtkTextChildAnchor to be inserted
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTextChildAnchorHandle Anchor;

	public IntPtr UserData;
}

public class InsertPixbufSignal
{

	public MentorLake.Gtk.GtkTextBufferHandle Self;
/// <summary>
/// <para>
/// position to insert @pixbuf in @textbuffer
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTextIterHandle Location;
/// <summary>
/// <para>
/// the #GdkPixbuf to be inserted
/// </para>
/// </summary>

	public MentorLake.GdkPixbuf.GdkPixbufHandle Pixbuf;

	public IntPtr UserData;
}

public class InsertTextSignal
{

	public MentorLake.Gtk.GtkTextBufferHandle Self;
/// <summary>
/// <para>
/// position to insert @text in @textbuffer
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTextIterHandle Location;
/// <summary>
/// <para>
/// the UTF-8 text to be inserted
/// </para>
/// </summary>

	public string Text;
/// <summary>
/// <para>
/// length of the inserted text in bytes
/// </para>
/// </summary>

	public int Len;

	public IntPtr UserData;
}

public class MarkDeletedSignal
{

	public MentorLake.Gtk.GtkTextBufferHandle Self;
/// <summary>
/// <para>
/// The mark that was deleted
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTextMarkHandle Mark;

	public IntPtr UserData;
}

public class MarkSetSignal
{

	public MentorLake.Gtk.GtkTextBufferHandle Self;
/// <summary>
/// <para>
/// The location of @mark in @textbuffer
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTextIterHandle Location;
/// <summary>
/// <para>
/// The mark that is set
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTextMarkHandle Mark;

	public IntPtr UserData;
}

public class ModifiedChangedSignal
{

	public MentorLake.Gtk.GtkTextBufferHandle Self;

	public IntPtr UserData;
}

public class PasteDoneSignal
{

	public MentorLake.Gtk.GtkTextBufferHandle Self;
/// <summary>
/// <para>
/// the #GtkClipboard pasted from
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkClipboardHandle Clipboard;

	public IntPtr UserData;
}

public class RemoveTagSignal
{

	public MentorLake.Gtk.GtkTextBufferHandle Self;
/// <summary>
/// <para>
/// the tag to be removed
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTextTagHandle Tag;
/// <summary>
/// <para>
/// the start of the range the tag is removed from
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTextIterHandle Start;
/// <summary>
/// <para>
/// the end of the range the tag is removed from
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTextIterHandle End;

	public IntPtr UserData;
}
}

public static class GtkTextBufferHandleSignalDelegates
{

/// <summary>
/// <para>
/// The ::apply-tag signal is emitted to apply a tag to a
/// range of text in a #GtkTextBuffer.
/// Applying actually occurs in the default handler.
/// </para>
/// <para>
/// Note that if your handler runs before the default handler it must not
/// invalidate the @start and @end iters (or has to revalidate them).
/// </para>
/// <para>
/// See also:
/// gtk_text_buffer_apply_tag(),
/// gtk_text_buffer_insert_with_tags(),
/// gtk_text_buffer_insert_range().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="tag">
/// the applied tag
/// </param>
/// <param name="start">
/// the start of the range the tag is applied to
/// </param>
/// <param name="end">
/// the end of the range the tag is applied to
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void apply_tag([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagHandle>))] MentorLake.Gtk.GtkTextTagHandle tag, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle start, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle end, IntPtr user_data);


/// <summary>
/// <para>
/// The ::begin-user-action signal is emitted at the beginning of a single
/// user-visible operation on a #GtkTextBuffer.
/// </para>
/// <para>
/// See also:
/// gtk_text_buffer_begin_user_action(),
/// gtk_text_buffer_insert_interactive(),
/// gtk_text_buffer_insert_range_interactive(),
/// gtk_text_buffer_delete_interactive(),
/// gtk_text_buffer_backspace(),
/// gtk_text_buffer_delete_selection().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void begin_user_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::changed signal is emitted when the content of a #GtkTextBuffer
/// has changed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::delete-range signal is emitted to delete a range
/// from a #GtkTextBuffer.
/// </para>
/// <para>
/// Note that if your handler runs before the default handler it must not
/// invalidate the @start and @end iters (or has to revalidate them).
/// The default signal handler revalidates the @start and @end iters to
/// both point to the location where text was deleted. Handlers
/// which run after the default handler (see g_signal_connect_after())
/// do not have access to the deleted text.
/// </para>
/// <para>
/// See also: gtk_text_buffer_delete().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="start">
/// the start of the range to be deleted
/// </param>
/// <param name="end">
/// the end of the range to be deleted
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void delete_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle start, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle end, IntPtr user_data);


/// <summary>
/// <para>
/// The ::end-user-action signal is emitted at the end of a single
/// user-visible operation on the #GtkTextBuffer.
/// </para>
/// <para>
/// See also:
/// gtk_text_buffer_end_user_action(),
/// gtk_text_buffer_insert_interactive(),
/// gtk_text_buffer_insert_range_interactive(),
/// gtk_text_buffer_delete_interactive(),
/// gtk_text_buffer_backspace(),
/// gtk_text_buffer_delete_selection(),
/// gtk_text_buffer_backspace().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void end_user_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::insert-child-anchor signal is emitted to insert a
/// #GtkTextChildAnchor in a #GtkTextBuffer.
/// Insertion actually occurs in the default handler.
/// </para>
/// <para>
/// Note that if your handler runs before the default handler it must
/// not invalidate the @location iter (or has to revalidate it).
/// The default signal handler revalidates it to be placed after the
/// inserted @anchor.
/// </para>
/// <para>
/// See also: gtk_text_buffer_insert_child_anchor().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="location">
/// position to insert @anchor in @textbuffer
/// </param>
/// <param name="anchor">
/// the #GtkTextChildAnchor to be inserted
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void insert_child_anchor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle location, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextChildAnchorHandle>))] MentorLake.Gtk.GtkTextChildAnchorHandle anchor, IntPtr user_data);


/// <summary>
/// <para>
/// The ::insert-pixbuf signal is emitted to insert a #GdkPixbuf
/// in a #GtkTextBuffer. Insertion actually occurs in the default handler.
/// </para>
/// <para>
/// Note that if your handler runs before the default handler it must not
/// invalidate the @location iter (or has to revalidate it).
/// The default signal handler revalidates it to be placed after the
/// inserted @pixbuf.
/// </para>
/// <para>
/// See also: gtk_text_buffer_insert_pixbuf().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="location">
/// position to insert @pixbuf in @textbuffer
/// </param>
/// <param name="pixbuf">
/// the #GdkPixbuf to be inserted
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void insert_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle location, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, IntPtr user_data);


/// <summary>
/// <para>
/// The ::insert-text signal is emitted to insert text in a #GtkTextBuffer.
/// Insertion actually occurs in the default handler.
/// </para>
/// <para>
/// Note that if your handler runs before the default handler it must not
/// invalidate the @location iter (or has to revalidate it).
/// The default signal handler revalidates it to point to the end of the
/// inserted text.
/// </para>
/// <para>
/// See also:
/// gtk_text_buffer_insert(),
/// gtk_text_buffer_insert_range().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="location">
/// position to insert @text in @textbuffer
/// </param>
/// <param name="text">
/// the UTF-8 text to be inserted
/// </param>
/// <param name="len">
/// length of the inserted text in bytes
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void insert_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle location, string text, int len, IntPtr user_data);


/// <summary>
/// <para>
/// The ::mark-deleted signal is emitted as notification
/// after a #GtkTextMark is deleted.
/// </para>
/// <para>
/// See also:
/// gtk_text_buffer_delete_mark().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="mark">
/// The mark that was deleted
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void mark_deleted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextMarkHandle>))] MentorLake.Gtk.GtkTextMarkHandle mark, IntPtr user_data);


/// <summary>
/// <para>
/// The ::mark-set signal is emitted as notification
/// after a #GtkTextMark is set.
/// </para>
/// <para>
/// See also:
/// gtk_text_buffer_create_mark(),
/// gtk_text_buffer_move_mark().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="location">
/// The location of @mark in @textbuffer
/// </param>
/// <param name="mark">
/// The mark that is set
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void mark_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle location, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextMarkHandle>))] MentorLake.Gtk.GtkTextMarkHandle mark, IntPtr user_data);


/// <summary>
/// <para>
/// The ::modified-changed signal is emitted when the modified bit of a
/// #GtkTextBuffer flips.
/// </para>
/// <para>
/// See also:
/// gtk_text_buffer_set_modified().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void modified_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The paste-done signal is emitted after paste operation has been completed.
/// This is useful to properly scroll the view to the end of the pasted text.
/// See gtk_text_buffer_paste_clipboard() for more details.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="clipboard">
/// the #GtkClipboard pasted from
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void paste_done([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard, IntPtr user_data);


/// <summary>
/// <para>
/// The ::remove-tag signal is emitted to remove all occurrences of @tag from
/// a range of text in a #GtkTextBuffer.
/// Removal actually occurs in the default handler.
/// </para>
/// <para>
/// Note that if your handler runs before the default handler it must not
/// invalidate the @start and @end iters (or has to revalidate them).
/// </para>
/// <para>
/// See also:
/// gtk_text_buffer_remove_tag().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="tag">
/// the tag to be removed
/// </param>
/// <param name="start">
/// the start of the range the tag is removed from
/// </param>
/// <param name="end">
/// the end of the range the tag is removed from
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void remove_tag([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagHandle>))] MentorLake.Gtk.GtkTextTagHandle tag, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle start, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle end, IntPtr user_data);

}


public static class GtkTextBufferHandleExtensions
{
/// <summary>
/// <para>
/// Adds the mark at position @where. The mark must not be added to
/// another buffer, and if its name is not %NULL then there must not
/// be another mark in the buffer with the same name.
/// </para>
/// <para>
/// Emits the #GtkTextBuffer::mark-set signal as notification of the mark&apos;s
/// initial placement.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="mark">
/// the mark to add
/// </param>
/// <param name="where">
/// location to place mark
/// </param>

	public static T AddMark<T>(this T buffer, MentorLake.Gtk.GtkTextMarkHandle mark, MentorLake.Gtk.GtkTextIterHandle where) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_add_mark(buffer, mark, where);
		return buffer;
	}

/// <summary>
/// <para>
/// Adds @clipboard to the list of clipboards in which the selection
/// contents of @buffer are available. In most cases, @clipboard will be
/// the #GtkClipboard of type %GDK_SELECTION_PRIMARY for a view of @buffer.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="clipboard">
/// a #GtkClipboard
/// </param>

	public static T AddSelectionClipboard<T>(this T buffer, MentorLake.Gtk.GtkClipboardHandle clipboard) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_add_selection_clipboard(buffer, clipboard);
		return buffer;
	}

/// <summary>
/// <para>
/// Emits the “apply-tag” signal on @buffer. The default
/// handler for the signal applies @tag to the given range.
/// @start and @end do not have to be in order.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="tag">
/// a #GtkTextTag
/// </param>
/// <param name="start">
/// one bound of range to be tagged
/// </param>
/// <param name="end">
/// other bound of range to be tagged
/// </param>

	public static T ApplyTag<T>(this T buffer, MentorLake.Gtk.GtkTextTagHandle tag, MentorLake.Gtk.GtkTextIterHandle start, MentorLake.Gtk.GtkTextIterHandle end) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_apply_tag(buffer, tag, start, end);
		return buffer;
	}

/// <summary>
/// <para>
/// Calls gtk_text_tag_table_lookup() on the buffer’s tag table to
/// get a #GtkTextTag, then calls gtk_text_buffer_apply_tag().
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="name">
/// name of a named #GtkTextTag
/// </param>
/// <param name="start">
/// one bound of range to be tagged
/// </param>
/// <param name="end">
/// other bound of range to be tagged
/// </param>

	public static T ApplyTagByName<T>(this T buffer, string name, MentorLake.Gtk.GtkTextIterHandle start, MentorLake.Gtk.GtkTextIterHandle end) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_apply_tag_by_name(buffer, name, start, end);
		return buffer;
	}

/// <summary>
/// <para>
/// Performs the appropriate action as if the user hit the delete
/// key with the cursor at the position specified by @iter. In the
/// normal case a single character will be deleted, but when
/// combining accents are involved, more than one character can
/// be deleted, and when precomposed character and accent combinations
/// are involved, less than one character will be deleted.
/// </para>
/// <para>
/// Because the buffer is modified, all outstanding iterators become
/// invalid after calling this function; however, the @iter will be
/// re-initialized to point to the location where text was deleted.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="iter">
/// a position in @buffer
/// </param>
/// <param name="interactive">
/// whether the deletion is caused by user interaction
/// </param>
/// <param name="default_editable">
/// whether the buffer is editable by default
/// </param>
/// <return>
/// %TRUE if the buffer was modified
/// </return>

	public static bool Backspace(this MentorLake.Gtk.GtkTextBufferHandle buffer, MentorLake.Gtk.GtkTextIterHandle iter, bool interactive, bool default_editable)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_backspace(buffer, iter, interactive, default_editable);
	}

/// <summary>
/// <para>
/// Called to indicate that the buffer operations between here and a
/// call to gtk_text_buffer_end_user_action() are part of a single
/// user-visible operation. The operations between
/// gtk_text_buffer_begin_user_action() and
/// gtk_text_buffer_end_user_action() can then be grouped when creating
/// an undo stack. #GtkTextBuffer maintains a count of calls to
/// gtk_text_buffer_begin_user_action() that have not been closed with
/// a call to gtk_text_buffer_end_user_action(), and emits the
/// “begin-user-action” and “end-user-action” signals only for the
/// outermost pair of calls. This allows you to build user actions
/// from other user actions.
/// </para>
/// <para>
/// The “interactive” buffer mutation functions, such as
/// gtk_text_buffer_insert_interactive(), automatically call begin/end
/// user action around the buffer operations they perform, so there&apos;s
/// no need to add extra calls if you user action consists solely of a
/// single call to one of those functions.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>

	public static T BeginUserAction<T>(this T buffer) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_begin_user_action(buffer);
		return buffer;
	}

/// <summary>
/// <para>
/// Copies the currently-selected text to a clipboard.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="clipboard">
/// the #GtkClipboard object to copy to
/// </param>

	public static T CopyClipboard<T>(this T buffer, MentorLake.Gtk.GtkClipboardHandle clipboard) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_copy_clipboard(buffer, clipboard);
		return buffer;
	}

/// <summary>
/// <para>
/// This is a convenience function which simply creates a child anchor
/// with gtk_text_child_anchor_new() and inserts it into the buffer
/// with gtk_text_buffer_insert_child_anchor(). The new anchor is
/// owned by the buffer; no reference count is returned to
/// the caller of gtk_text_buffer_create_child_anchor().
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="iter">
/// location in the buffer
/// </param>
/// <return>
/// the created child anchor
/// </return>

	public static MentorLake.Gtk.GtkTextChildAnchorHandle CreateChildAnchor(this MentorLake.Gtk.GtkTextBufferHandle buffer, MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_create_child_anchor(buffer, iter);
	}

/// <summary>
/// <para>
/// Creates a mark at position @where. If @mark_name is %NULL, the mark
/// is anonymous; otherwise, the mark can be retrieved by name using
/// gtk_text_buffer_get_mark(). If a mark has left gravity, and text is
/// inserted at the mark’s current location, the mark will be moved to
/// the left of the newly-inserted text. If the mark has right gravity
/// (@left_gravity = %FALSE), the mark will end up on the right of
/// newly-inserted text. The standard left-to-right cursor is a mark
/// with right gravity (when you type, the cursor stays on the right
/// side of the text you’re typing).
/// </para>
/// <para>
/// The caller of this function does not own a
/// reference to the returned #GtkTextMark, so you can ignore the
/// return value if you like. Marks are owned by the buffer and go
/// away when the buffer does.
/// </para>
/// <para>
/// Emits the #GtkTextBuffer::mark-set signal as notification of the mark&apos;s
/// initial placement.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="mark_name">
/// name for mark, or %NULL
/// </param>
/// <param name="where">
/// location to place mark
/// </param>
/// <param name="left_gravity">
/// whether the mark has left gravity
/// </param>
/// <return>
/// the new #GtkTextMark object
/// </return>

	public static MentorLake.Gtk.GtkTextMarkHandle CreateMark(this MentorLake.Gtk.GtkTextBufferHandle buffer, string mark_name, MentorLake.Gtk.GtkTextIterHandle where, bool left_gravity)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_create_mark(buffer, mark_name, where, left_gravity);
	}

/// <summary>
/// <para>
/// Creates a tag and adds it to the tag table for @buffer.
/// Equivalent to calling gtk_text_tag_new() and then adding the
/// tag to the buffer’s tag table. The returned tag is owned by
/// the buffer’s tag table, so the ref count will be equal to one.
/// </para>
/// <para>
/// If @tag_name is %NULL, the tag is anonymous.
/// </para>
/// <para>
/// If @tag_name is non-%NULL, a tag called @tag_name must not already
/// exist in the tag table for this buffer.
/// </para>
/// <para>
/// The @first_property_name argument and subsequent arguments are a list
/// of properties to set on the tag, as with g_object_set().
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="tag_name">
/// name of the new tag, or %NULL
/// </param>
/// <param name="first_property_name">
/// name of first property to set, or %NULL
/// </param>
/// <param name="@__arglist">
/// %NULL-terminated list of property names and values
/// </param>
/// <return>
/// a new tag
/// </return>

	public static MentorLake.Gtk.GtkTextTagHandle CreateTag(this MentorLake.Gtk.GtkTextBufferHandle buffer, string tag_name, string first_property_name, IntPtr @__arglist)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_create_tag(buffer, tag_name, first_property_name, @__arglist);
	}

/// <summary>
/// <para>
/// Copies the currently-selected text to a clipboard, then deletes
/// said text if it’s editable.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="clipboard">
/// the #GtkClipboard object to cut to
/// </param>
/// <param name="default_editable">
/// default editability of the buffer
/// </param>

	public static T CutClipboard<T>(this T buffer, MentorLake.Gtk.GtkClipboardHandle clipboard, bool default_editable) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_cut_clipboard(buffer, clipboard, default_editable);
		return buffer;
	}

/// <summary>
/// <para>
/// Deletes text between @start and @end. The order of @start and @end
/// is not actually relevant; gtk_text_buffer_delete() will reorder
/// them. This function actually emits the “delete-range” signal, and
/// the default handler of that signal deletes the text. Because the
/// buffer is modified, all outstanding iterators become invalid after
/// calling this function; however, the @start and @end will be
/// re-initialized to point to the location where text was deleted.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="start">
/// a position in @buffer
/// </param>
/// <param name="end">
/// another position in @buffer
/// </param>

	public static T Delete<T>(this T buffer, MentorLake.Gtk.GtkTextIterHandle start, MentorLake.Gtk.GtkTextIterHandle end) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_delete(buffer, start, end);
		return buffer;
	}

/// <summary>
/// <para>
/// Deletes all editable text in the given range.
/// Calls gtk_text_buffer_delete() for each editable sub-range of
/// [@start,@end). @start and @end are revalidated to point to
/// the location of the last deleted range, or left untouched if
/// no text was deleted.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="start_iter">
/// start of range to delete
/// </param>
/// <param name="end_iter">
/// end of range
/// </param>
/// <param name="default_editable">
/// whether the buffer is editable by default
/// </param>
/// <return>
/// whether some text was actually deleted
/// </return>

	public static bool DeleteInteractive(this MentorLake.Gtk.GtkTextBufferHandle buffer, MentorLake.Gtk.GtkTextIterHandle start_iter, MentorLake.Gtk.GtkTextIterHandle end_iter, bool default_editable)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_delete_interactive(buffer, start_iter, end_iter, default_editable);
	}

/// <summary>
/// <para>
/// Deletes @mark, so that it’s no longer located anywhere in the
/// buffer. Removes the reference the buffer holds to the mark, so if
/// you haven’t called g_object_ref() on the mark, it will be freed. Even
/// if the mark isn’t freed, most operations on @mark become
/// invalid, until it gets added to a buffer again with
/// gtk_text_buffer_add_mark(). Use gtk_text_mark_get_deleted() to
/// find out if a mark has been removed from its buffer.
/// The #GtkTextBuffer::mark-deleted signal will be emitted as notification after
/// the mark is deleted.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="mark">
/// a #GtkTextMark in @buffer
/// </param>

	public static T DeleteMark<T>(this T buffer, MentorLake.Gtk.GtkTextMarkHandle mark) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_delete_mark(buffer, mark);
		return buffer;
	}

/// <summary>
/// <para>
/// Deletes the mark named @name; the mark must exist. See
/// gtk_text_buffer_delete_mark() for details.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="name">
/// name of a mark in @buffer
/// </param>

	public static T DeleteMarkByName<T>(this T buffer, string name) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_delete_mark_by_name(buffer, name);
		return buffer;
	}

/// <summary>
/// <para>
/// Deletes the range between the “insert” and “selection_bound” marks,
/// that is, the currently-selected text. If @interactive is %TRUE,
/// the editability of the selection will be considered (users can’t delete
/// uneditable text).
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="interactive">
/// whether the deletion is caused by user interaction
/// </param>
/// <param name="default_editable">
/// whether the buffer is editable by default
/// </param>
/// <return>
/// whether there was a non-empty selection to delete
/// </return>

	public static bool DeleteSelection(this MentorLake.Gtk.GtkTextBufferHandle buffer, bool interactive, bool default_editable)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_delete_selection(buffer, interactive, default_editable);
	}

/// <summary>
/// <para>
/// This function deserializes rich text in format @format and inserts
/// it at @iter.
/// </para>
/// <para>
/// @formats to be used must be registered using
/// gtk_text_buffer_register_deserialize_format() or
/// gtk_text_buffer_register_deserialize_tagset() beforehand.
/// </para>
/// </summary>

/// <param name="register_buffer">
/// the #GtkTextBuffer @format is registered with
/// </param>
/// <param name="content_buffer">
/// the #GtkTextBuffer to deserialize into
/// </param>
/// <param name="format">
/// the rich text format to use for deserializing
/// </param>
/// <param name="iter">
/// insertion point for the deserialized text
/// </param>
/// <param name="data">
/// data to deserialize
/// </param>
/// <param name="length">
/// length of @data
/// </param>
/// <return>
/// %TRUE on success, %FALSE otherwise.
/// </return>

	public static bool Deserialize(this MentorLake.Gtk.GtkTextBufferHandle register_buffer, MentorLake.Gtk.GtkTextBufferHandle content_buffer, MentorLake.Gdk.GdkAtom format, MentorLake.Gtk.GtkTextIterHandle iter, byte[] data, UIntPtr length)
	{
		if (register_buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		var externCallResult = GtkTextBufferHandleExterns.gtk_text_buffer_deserialize(register_buffer, content_buffer, format, iter, data, length, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// This functions returns the value set with
/// gtk_text_buffer_deserialize_set_can_create_tags()
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="format">
/// a #GdkAtom representing a registered rich text format
/// </param>
/// <return>
/// whether deserializing this format may create tags
/// </return>

	public static bool DeserializeGetCanCreateTags(this MentorLake.Gtk.GtkTextBufferHandle buffer, MentorLake.Gdk.GdkAtom format)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_deserialize_get_can_create_tags(buffer, format);
	}

/// <summary>
/// <para>
/// Use this function to allow a rich text deserialization function to
/// create new tags in the receiving buffer. Note that using this
/// function is almost always a bad idea, because the rich text
/// functions you register should know how to map the rich text format
/// they handler to your text buffers set of tags.
/// </para>
/// <para>
/// The ability of creating new (arbitrary!) tags in the receiving buffer
/// is meant for special rich text formats like the internal one that
/// is registered using gtk_text_buffer_register_deserialize_tagset(),
/// because that format is essentially a dump of the internal structure
/// of the source buffer, including its tag names.
/// </para>
/// <para>
/// You should allow creation of tags only if you know what you are
/// doing, e.g. if you defined a tagset name for your application
/// suite’s text buffers and you know that it’s fine to receive new
/// tags from these buffers, because you know that your application can
/// handle the newly created tags.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="format">
/// a #GdkAtom representing a registered rich text format
/// </param>
/// <param name="can_create_tags">
/// whether deserializing this format may create tags
/// </param>

	public static T DeserializeSetCanCreateTags<T>(this T buffer, MentorLake.Gdk.GdkAtom format, bool can_create_tags) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_deserialize_set_can_create_tags(buffer, format, can_create_tags);
		return buffer;
	}

/// <summary>
/// <para>
/// Should be paired with a call to gtk_text_buffer_begin_user_action().
/// See that function for a full explanation.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>

	public static T EndUserAction<T>(this T buffer) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_end_user_action(buffer);
		return buffer;
	}

/// <summary>
/// <para>
/// Retrieves the first and last iterators in the buffer, i.e. the
/// entire buffer lies within the range [@start,@end).
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="start">
/// iterator to initialize with first position in the buffer
/// </param>
/// <param name="end">
/// iterator to initialize with the end iterator
/// </param>

	public static T GetBounds<T>(this T buffer, out MentorLake.Gtk.GtkTextIter start, out MentorLake.Gtk.GtkTextIter end) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_get_bounds(buffer, out start, out end);
		return buffer;
	}

/// <summary>
/// <para>
/// Gets the number of characters in the buffer; note that characters
/// and bytes are not the same, you can’t e.g. expect the contents of
/// the buffer in string form to be this many bytes long. The character
/// count is cached, so this function is very fast.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <return>
/// number of characters in the buffer
/// </return>

	public static int GetCharCount(this MentorLake.Gtk.GtkTextBufferHandle buffer)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_get_char_count(buffer);
	}

/// <summary>
/// <para>
/// This function returns the list of targets this text buffer can
/// provide for copying and as DND source. The targets in the list are
/// added with @info values from the #GtkTextBufferTargetInfo enum,
/// using gtk_target_list_add_rich_text_targets() and
/// gtk_target_list_add_text_targets().
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <return>
/// the #GtkTargetList
/// </return>

	public static MentorLake.Gtk.GtkTargetListHandle GetCopyTargetList(this MentorLake.Gtk.GtkTextBufferHandle buffer)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_get_copy_target_list(buffer);
	}

/// <summary>
/// <para>
/// This function returns the rich text deserialize formats registered
/// with @buffer using gtk_text_buffer_register_deserialize_format() or
/// gtk_text_buffer_register_deserialize_tagset()
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="n_formats">
/// return location for the number of formats
/// </param>
/// <return>
/// an array of
///               #GdkAtoms representing the registered formats.
/// </return>

	public static MentorLake.Gdk.GdkAtom[] GetDeserializeFormats(this MentorLake.Gtk.GtkTextBufferHandle buffer, out int n_formats)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_get_deserialize_formats(buffer, out n_formats);
	}

/// <summary>
/// <para>
/// Initializes @iter with the “end iterator,” one past the last valid
/// character in the text buffer. If dereferenced with
/// gtk_text_iter_get_char(), the end iterator has a character value of 0.
/// The entire buffer lies in the range from the first position in
/// the buffer (call gtk_text_buffer_get_start_iter() to get
/// character position 0) to the end iterator.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="iter">
/// iterator to initialize
/// </param>

	public static T GetEndIter<T>(this T buffer, out MentorLake.Gtk.GtkTextIter iter) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_get_end_iter(buffer, out iter);
		return buffer;
	}

/// <summary>
/// <para>
/// Indicates whether the buffer has some text currently selected.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <return>
/// %TRUE if the there is text selected
/// </return>

	public static bool GetHasSelection(this MentorLake.Gtk.GtkTextBufferHandle buffer)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_get_has_selection(buffer);
	}

/// <summary>
/// <para>
/// Returns the mark that represents the cursor (insertion point).
/// Equivalent to calling gtk_text_buffer_get_mark() to get the mark
/// named “insert”, but very slightly more efficient, and involves less
/// typing.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <return>
/// insertion point mark
/// </return>

	public static MentorLake.Gtk.GtkTextMarkHandle GetInsert(this MentorLake.Gtk.GtkTextBufferHandle buffer)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_get_insert(buffer);
	}

/// <summary>
/// <para>
/// Obtains the location of @anchor within @buffer.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="iter">
/// an iterator to be initialized
/// </param>
/// <param name="anchor">
/// a child anchor that appears in @buffer
/// </param>

	public static T GetIterAtChildAnchor<T>(this T buffer, out MentorLake.Gtk.GtkTextIter iter, MentorLake.Gtk.GtkTextChildAnchorHandle anchor) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_get_iter_at_child_anchor(buffer, out iter, anchor);
		return buffer;
	}

/// <summary>
/// <para>
/// Initializes @iter to the start of the given line. If @line_number is greater
/// than the number of lines in the @buffer, the end iterator is returned.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="iter">
/// iterator to initialize
/// </param>
/// <param name="line_number">
/// line number counting from 0
/// </param>

	public static T GetIterAtLine<T>(this T buffer, out MentorLake.Gtk.GtkTextIter iter, int line_number) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_get_iter_at_line(buffer, out iter, line_number);
		return buffer;
	}

/// <summary>
/// <para>
/// Obtains an iterator pointing to @byte_index within the given line.
/// @byte_index must be the start of a UTF-8 character. Note bytes, not
/// characters; UTF-8 may encode one character as multiple bytes.
/// </para>
/// <para>
/// Before the 3.20 version, it was not allowed to pass an invalid location.
/// </para>
/// <para>
/// Since the 3.20 version, if @line_number is greater than the number of lines
/// in the @buffer, the end iterator is returned. And if @byte_index is off the
/// end of the line, the iterator at the end of the line is returned.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="iter">
/// iterator to initialize
/// </param>
/// <param name="line_number">
/// line number counting from 0
/// </param>
/// <param name="byte_index">
/// byte index from start of line
/// </param>

	public static T GetIterAtLineIndex<T>(this T buffer, out MentorLake.Gtk.GtkTextIter iter, int line_number, int byte_index) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_get_iter_at_line_index(buffer, out iter, line_number, byte_index);
		return buffer;
	}

/// <summary>
/// <para>
/// Obtains an iterator pointing to @char_offset within the given line. Note
/// characters, not bytes; UTF-8 may encode one character as multiple bytes.
/// </para>
/// <para>
/// Before the 3.20 version, it was not allowed to pass an invalid location.
/// </para>
/// <para>
/// Since the 3.20 version, if @line_number is greater than the number of lines
/// in the @buffer, the end iterator is returned. And if @char_offset is off the
/// end of the line, the iterator at the end of the line is returned.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="iter">
/// iterator to initialize
/// </param>
/// <param name="line_number">
/// line number counting from 0
/// </param>
/// <param name="char_offset">
/// char offset from start of line
/// </param>

	public static T GetIterAtLineOffset<T>(this T buffer, out MentorLake.Gtk.GtkTextIter iter, int line_number, int char_offset) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_get_iter_at_line_offset(buffer, out iter, line_number, char_offset);
		return buffer;
	}

/// <summary>
/// <para>
/// Initializes @iter with the current position of @mark.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="iter">
/// iterator to initialize
/// </param>
/// <param name="mark">
/// a #GtkTextMark in @buffer
/// </param>

	public static T GetIterAtMark<T>(this T buffer, out MentorLake.Gtk.GtkTextIter iter, MentorLake.Gtk.GtkTextMarkHandle mark) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_get_iter_at_mark(buffer, out iter, mark);
		return buffer;
	}

/// <summary>
/// <para>
/// Initializes @iter to a position @char_offset chars from the start
/// of the entire buffer. If @char_offset is -1 or greater than the number
/// of characters in the buffer, @iter is initialized to the end iterator,
/// the iterator one past the last valid character in the buffer.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="iter">
/// iterator to initialize
/// </param>
/// <param name="char_offset">
/// char offset from start of buffer, counting from 0, or -1
/// </param>

	public static T GetIterAtOffset<T>(this T buffer, out MentorLake.Gtk.GtkTextIter iter, int char_offset) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_get_iter_at_offset(buffer, out iter, char_offset);
		return buffer;
	}

/// <summary>
/// <para>
/// Obtains the number of lines in the buffer. This value is cached, so
/// the function is very fast.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <return>
/// number of lines in the buffer
/// </return>

	public static int GetLineCount(this MentorLake.Gtk.GtkTextBufferHandle buffer)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_get_line_count(buffer);
	}

/// <summary>
/// <para>
/// Returns the mark named @name in buffer @buffer, or %NULL if no such
/// mark exists in the buffer.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="name">
/// a mark name
/// </param>
/// <return>
/// a #GtkTextMark, or %NULL
/// </return>

	public static MentorLake.Gtk.GtkTextMarkHandle GetMark(this MentorLake.Gtk.GtkTextBufferHandle buffer, string name)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_get_mark(buffer, name);
	}

/// <summary>
/// <para>
/// Indicates whether the buffer has been modified since the last call
/// to gtk_text_buffer_set_modified() set the modification flag to
/// %FALSE. Used for example to enable a “save” function in a text
/// editor.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <return>
/// %TRUE if the buffer has been modified
/// </return>

	public static bool GetModified(this MentorLake.Gtk.GtkTextBufferHandle buffer)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_get_modified(buffer);
	}

/// <summary>
/// <para>
/// This function returns the list of targets this text buffer supports
/// for pasting and as DND destination. The targets in the list are
/// added with @info values from the #GtkTextBufferTargetInfo enum,
/// using gtk_target_list_add_rich_text_targets() and
/// gtk_target_list_add_text_targets().
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <return>
/// the #GtkTargetList
/// </return>

	public static MentorLake.Gtk.GtkTargetListHandle GetPasteTargetList(this MentorLake.Gtk.GtkTextBufferHandle buffer)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_get_paste_target_list(buffer);
	}

/// <summary>
/// <para>
/// Returns the mark that represents the selection bound.  Equivalent
/// to calling gtk_text_buffer_get_mark() to get the mark named
/// “selection_bound”, but very slightly more efficient, and involves
/// less typing.
/// </para>
/// <para>
/// The currently-selected text in @buffer is the region between the
/// “selection_bound” and “insert” marks. If “selection_bound” and
/// “insert” are in the same place, then there is no current selection.
/// gtk_text_buffer_get_selection_bounds() is another convenient function
/// for handling the selection, if you just want to know whether there’s a
/// selection and what its bounds are.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <return>
/// selection bound mark
/// </return>

	public static MentorLake.Gtk.GtkTextMarkHandle GetSelectionBound(this MentorLake.Gtk.GtkTextBufferHandle buffer)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_get_selection_bound(buffer);
	}

/// <summary>
/// <para>
/// Returns %TRUE if some text is selected; places the bounds
/// of the selection in @start and @end (if the selection has length 0,
/// then @start and @end are filled in with the same value).
/// @start and @end will be in ascending order. If @start and @end are
/// NULL, then they are not filled in, but the return value still indicates
/// whether text is selected.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer a #GtkTextBuffer
/// </param>
/// <param name="start">
/// iterator to initialize with selection start
/// </param>
/// <param name="end">
/// iterator to initialize with selection end
/// </param>
/// <return>
/// whether the selection has nonzero length
/// </return>

	public static bool GetSelectionBounds(this MentorLake.Gtk.GtkTextBufferHandle buffer, out MentorLake.Gtk.GtkTextIter start, out MentorLake.Gtk.GtkTextIter end)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_get_selection_bounds(buffer, out start, out end);
	}

/// <summary>
/// <para>
/// This function returns the rich text serialize formats registered
/// with @buffer using gtk_text_buffer_register_serialize_format() or
/// gtk_text_buffer_register_serialize_tagset()
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="n_formats">
/// return location for the number of formats
/// </param>
/// <return>
/// an array of
///               #GdkAtoms representing the registered formats.
/// </return>

	public static MentorLake.Gdk.GdkAtom[] GetSerializeFormats(this MentorLake.Gtk.GtkTextBufferHandle buffer, out int n_formats)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_get_serialize_formats(buffer, out n_formats);
	}

/// <summary>
/// <para>
/// Returns the text in the range [@start,@end). Excludes undisplayed
/// text (text marked with tags that set the invisibility attribute) if
/// @include_hidden_chars is %FALSE. The returned string includes a
/// 0xFFFC character whenever the buffer contains
/// embedded images, so byte and character indexes into
/// the returned string do correspond to byte
/// and character indexes into the buffer. Contrast with
/// gtk_text_buffer_get_text(). Note that 0xFFFC can occur in normal
/// text as well, so it is not a reliable indicator that a pixbuf or
/// widget is in the buffer.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="start">
/// start of a range
/// </param>
/// <param name="end">
/// end of a range
/// </param>
/// <param name="include_hidden_chars">
/// whether to include invisible text
/// </param>
/// <return>
/// an allocated UTF-8 string
/// </return>

	public static string GetSlice(this MentorLake.Gtk.GtkTextBufferHandle buffer, MentorLake.Gtk.GtkTextIterHandle start, MentorLake.Gtk.GtkTextIterHandle end, bool include_hidden_chars)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_get_slice(buffer, start, end, include_hidden_chars);
	}

/// <summary>
/// <para>
/// Initialized @iter with the first position in the text buffer. This
/// is the same as using gtk_text_buffer_get_iter_at_offset() to get
/// the iter at character offset 0.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="iter">
/// iterator to initialize
/// </param>

	public static T GetStartIter<T>(this T buffer, out MentorLake.Gtk.GtkTextIter iter) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_get_start_iter(buffer, out iter);
		return buffer;
	}

/// <summary>
/// <para>
/// Get the #GtkTextTagTable associated with this buffer.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <return>
/// the buffer’s tag table
/// </return>

	public static MentorLake.Gtk.GtkTextTagTableHandle GetTagTable(this MentorLake.Gtk.GtkTextBufferHandle buffer)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_get_tag_table(buffer);
	}

/// <summary>
/// <para>
/// Returns the text in the range [@start,@end). Excludes undisplayed
/// text (text marked with tags that set the invisibility attribute) if
/// @include_hidden_chars is %FALSE. Does not include characters
/// representing embedded images, so byte and character indexes into
/// the returned string do not correspond to byte
/// and character indexes into the buffer. Contrast with
/// gtk_text_buffer_get_slice().
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="start">
/// start of a range
/// </param>
/// <param name="end">
/// end of a range
/// </param>
/// <param name="include_hidden_chars">
/// whether to include invisible text
/// </param>
/// <return>
/// an allocated UTF-8 string
/// </return>

	public static string GetText(this MentorLake.Gtk.GtkTextBufferHandle buffer, MentorLake.Gtk.GtkTextIterHandle start, MentorLake.Gtk.GtkTextIterHandle end, bool include_hidden_chars)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_get_text(buffer, start, end, include_hidden_chars);
	}

/// <summary>
/// <para>
/// Inserts @len bytes of @text at position @iter.  If @len is -1,
/// @text must be nul-terminated and will be inserted in its
/// entirety. Emits the “insert-text” signal; insertion actually occurs
/// in the default handler for the signal. @iter is invalidated when
/// insertion occurs (because the buffer contents change), but the
/// default signal handler revalidates it to point to the end of the
/// inserted text.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="iter">
/// a position in the buffer
/// </param>
/// <param name="text">
/// text in UTF-8 format
/// </param>
/// <param name="len">
/// length of text in bytes, or -1
/// </param>

	public static T Insert<T>(this T buffer, MentorLake.Gtk.GtkTextIterHandle iter, string text, int len) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_insert(buffer, iter, text, len);
		return buffer;
	}

/// <summary>
/// <para>
/// Simply calls gtk_text_buffer_insert(), using the current
/// cursor position as the insertion point.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="text">
/// text in UTF-8 format
/// </param>
/// <param name="len">
/// length of text, in bytes
/// </param>

	public static T InsertAtCursor<T>(this T buffer, string text, int len) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_insert_at_cursor(buffer, text, len);
		return buffer;
	}

/// <summary>
/// <para>
/// Inserts a child widget anchor into the text buffer at @iter. The
/// anchor will be counted as one character in character counts, and
/// when obtaining the buffer contents as a string, will be represented
/// by the Unicode “object replacement character” 0xFFFC. Note that the
/// “slice” variants for obtaining portions of the buffer as a string
/// include this character for child anchors, but the “text” variants do
/// not. E.g. see gtk_text_buffer_get_slice() and
/// gtk_text_buffer_get_text(). Consider
/// gtk_text_buffer_create_child_anchor() as a more convenient
/// alternative to this function. The buffer will add a reference to
/// the anchor, so you can unref it after insertion.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="iter">
/// location to insert the anchor
/// </param>
/// <param name="anchor">
/// a #GtkTextChildAnchor
/// </param>

	public static T InsertChildAnchor<T>(this T buffer, MentorLake.Gtk.GtkTextIterHandle iter, MentorLake.Gtk.GtkTextChildAnchorHandle anchor) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_insert_child_anchor(buffer, iter, anchor);
		return buffer;
	}

/// <summary>
/// <para>
/// Like gtk_text_buffer_insert(), but the insertion will not occur if
/// @iter is at a non-editable location in the buffer. Usually you
/// want to prevent insertions at ineditable locations if the insertion
/// results from a user action (is interactive).
/// </para>
/// <para>
/// @default_editable indicates the editability of text that doesn&apos;t
/// have a tag affecting editability applied to it. Typically the
/// result of gtk_text_view_get_editable() is appropriate here.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="iter">
/// a position in @buffer
/// </param>
/// <param name="text">
/// some UTF-8 text
/// </param>
/// <param name="len">
/// length of text in bytes, or -1
/// </param>
/// <param name="default_editable">
/// default editability of buffer
/// </param>
/// <return>
/// whether text was actually inserted
/// </return>

	public static bool InsertInteractive(this MentorLake.Gtk.GtkTextBufferHandle buffer, MentorLake.Gtk.GtkTextIterHandle iter, string text, int len, bool default_editable)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_insert_interactive(buffer, iter, text, len, default_editable);
	}

/// <summary>
/// <para>
/// Calls gtk_text_buffer_insert_interactive() at the cursor
/// position.
/// </para>
/// <para>
/// @default_editable indicates the editability of text that doesn&apos;t
/// have a tag affecting editability applied to it. Typically the
/// result of gtk_text_view_get_editable() is appropriate here.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="text">
/// text in UTF-8 format
/// </param>
/// <param name="len">
/// length of text in bytes, or -1
/// </param>
/// <param name="default_editable">
/// default editability of buffer
/// </param>
/// <return>
/// whether text was actually inserted
/// </return>

	public static bool InsertInteractiveAtCursor(this MentorLake.Gtk.GtkTextBufferHandle buffer, string text, int len, bool default_editable)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_insert_interactive_at_cursor(buffer, text, len, default_editable);
	}

/// <summary>
/// <para>
/// Inserts the text in @markup at position @iter. @markup will be inserted
/// in its entirety and must be nul-terminated and valid UTF-8. Emits the
/// #GtkTextBuffer::insert-text signal, possibly multiple times; insertion
/// actually occurs in the default handler for the signal. @iter will point
/// to the end of the inserted text on return.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="iter">
/// location to insert the markup
/// </param>
/// <param name="markup">
/// a nul-terminated UTF-8 string containing [Pango markup][PangoMarkupFormat]
/// </param>
/// <param name="len">
/// length of @markup in bytes, or -1
/// </param>

	public static T InsertMarkup<T>(this T buffer, MentorLake.Gtk.GtkTextIterHandle iter, string markup, int len) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_insert_markup(buffer, iter, markup, len);
		return buffer;
	}

/// <summary>
/// <para>
/// Inserts an image into the text buffer at @iter. The image will be
/// counted as one character in character counts, and when obtaining
/// the buffer contents as a string, will be represented by the Unicode
/// “object replacement character” 0xFFFC. Note that the “slice”
/// variants for obtaining portions of the buffer as a string include
/// this character for pixbufs, but the “text” variants do
/// not. e.g. see gtk_text_buffer_get_slice() and
/// gtk_text_buffer_get_text().
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="iter">
/// location to insert the pixbuf
/// </param>
/// <param name="pixbuf">
/// a #GdkPixbuf
/// </param>

	public static T InsertPixbuf<T>(this T buffer, MentorLake.Gtk.GtkTextIterHandle iter, MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_insert_pixbuf(buffer, iter, pixbuf);
		return buffer;
	}

/// <summary>
/// <para>
/// Copies text, tags, and pixbufs between @start and @end (the order
/// of @start and @end doesn’t matter) and inserts the copy at @iter.
/// Used instead of simply getting/inserting text because it preserves
/// images and tags. If @start and @end are in a different buffer from
/// @buffer, the two buffers must share the same tag table.
/// </para>
/// <para>
/// Implemented via emissions of the insert_text and apply_tag signals,
/// so expect those.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="iter">
/// a position in @buffer
/// </param>
/// <param name="start">
/// a position in a #GtkTextBuffer
/// </param>
/// <param name="end">
/// another position in the same buffer as @start
/// </param>

	public static T InsertRange<T>(this T buffer, MentorLake.Gtk.GtkTextIterHandle iter, MentorLake.Gtk.GtkTextIterHandle start, MentorLake.Gtk.GtkTextIterHandle end) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_insert_range(buffer, iter, start, end);
		return buffer;
	}

/// <summary>
/// <para>
/// Same as gtk_text_buffer_insert_range(), but does nothing if the
/// insertion point isn’t editable. The @default_editable parameter
/// indicates whether the text is editable at @iter if no tags
/// enclosing @iter affect editability. Typically the result of
/// gtk_text_view_get_editable() is appropriate here.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="iter">
/// a position in @buffer
/// </param>
/// <param name="start">
/// a position in a #GtkTextBuffer
/// </param>
/// <param name="end">
/// another position in the same buffer as @start
/// </param>
/// <param name="default_editable">
/// default editability of the buffer
/// </param>
/// <return>
/// whether an insertion was possible at @iter
/// </return>

	public static bool InsertRangeInteractive(this MentorLake.Gtk.GtkTextBufferHandle buffer, MentorLake.Gtk.GtkTextIterHandle iter, MentorLake.Gtk.GtkTextIterHandle start, MentorLake.Gtk.GtkTextIterHandle end, bool default_editable)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_insert_range_interactive(buffer, iter, start, end, default_editable);
	}

/// <summary>
/// <para>
/// Inserts @text into @buffer at @iter, applying the list of tags to
/// the newly-inserted text. The last tag specified must be %NULL to
/// terminate the list. Equivalent to calling gtk_text_buffer_insert(),
/// then gtk_text_buffer_apply_tag() on the inserted text;
/// gtk_text_buffer_insert_with_tags() is just a convenience function.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="iter">
/// an iterator in @buffer
/// </param>
/// <param name="text">
/// UTF-8 text
/// </param>
/// <param name="len">
/// length of @text, or -1
/// </param>
/// <param name="first_tag">
/// first tag to apply to @text
/// </param>
/// <param name="@__arglist">
/// %NULL-terminated list of tags to apply
/// </param>

	public static T InsertWithTags<T>(this T buffer, MentorLake.Gtk.GtkTextIterHandle iter, string text, int len, MentorLake.Gtk.GtkTextTagHandle first_tag, IntPtr @__arglist) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_insert_with_tags(buffer, iter, text, len, first_tag, @__arglist);
		return buffer;
	}

/// <summary>
/// <para>
/// Same as gtk_text_buffer_insert_with_tags(), but allows you
/// to pass in tag names instead of tag objects.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="iter">
/// position in @buffer
/// </param>
/// <param name="text">
/// UTF-8 text
/// </param>
/// <param name="len">
/// length of @text, or -1
/// </param>
/// <param name="first_tag_name">
/// name of a tag to apply to @text
/// </param>
/// <param name="@__arglist">
/// more tag names
/// </param>

	public static T InsertWithTagsByName<T>(this T buffer, MentorLake.Gtk.GtkTextIterHandle iter, string text, int len, string first_tag_name, IntPtr @__arglist) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_insert_with_tags_by_name(buffer, iter, text, len, first_tag_name, @__arglist);
		return buffer;
	}

/// <summary>
/// <para>
/// Moves @mark to the new location @where. Emits the #GtkTextBuffer::mark-set
/// signal as notification of the move.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="mark">
/// a #GtkTextMark
/// </param>
/// <param name="where">
/// new location for @mark in @buffer
/// </param>

	public static T MoveMark<T>(this T buffer, MentorLake.Gtk.GtkTextMarkHandle mark, MentorLake.Gtk.GtkTextIterHandle where) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_move_mark(buffer, mark, where);
		return buffer;
	}

/// <summary>
/// <para>
/// Moves the mark named @name (which must exist) to location @where.
/// See gtk_text_buffer_move_mark() for details.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="name">
/// name of a mark
/// </param>
/// <param name="where">
/// new location for mark
/// </param>

	public static T MoveMarkByName<T>(this T buffer, string name, MentorLake.Gtk.GtkTextIterHandle where) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_move_mark_by_name(buffer, name, where);
		return buffer;
	}

/// <summary>
/// <para>
/// Pastes the contents of a clipboard. If @override_location is %NULL, the
/// pasted text will be inserted at the cursor position, or the buffer selection
/// will be replaced if the selection is non-empty.
/// </para>
/// <para>
/// Note: pasting is asynchronous, that is, we’ll ask for the paste data and
/// return, and at some point later after the main loop runs, the paste data will
/// be inserted.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="clipboard">
/// the #GtkClipboard to paste from
/// </param>
/// <param name="override_location">
/// location to insert pasted text, or %NULL
/// </param>
/// <param name="default_editable">
/// whether the buffer is editable by default
/// </param>

	public static T PasteClipboard<T>(this T buffer, MentorLake.Gtk.GtkClipboardHandle clipboard, MentorLake.Gtk.GtkTextIterHandle override_location, bool default_editable) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_paste_clipboard(buffer, clipboard, override_location, default_editable);
		return buffer;
	}

/// <summary>
/// <para>
/// This function moves the “insert” and “selection_bound” marks
/// simultaneously.  If you move them to the same place in two steps
/// with gtk_text_buffer_move_mark(), you will temporarily select a
/// region in between their old and new locations, which can be pretty
/// inefficient since the temporarily-selected region will force stuff
/// to be recalculated. This function moves them as a unit, which can
/// be optimized.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="where">
/// where to put the cursor
/// </param>

	public static T PlaceCursor<T>(this T buffer, MentorLake.Gtk.GtkTextIterHandle where) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_place_cursor(buffer, where);
		return buffer;
	}

/// <summary>
/// <para>
/// This function registers a rich text deserialization @function along with
/// its @mime_type with the passed @buffer.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="mime_type">
/// the format’s mime-type
/// </param>
/// <param name="function">
/// the deserialize function to register
/// </param>
/// <param name="user_data">
/// @function’s user_data
/// </param>
/// <param name="user_data_destroy">
/// a function to call when @user_data is no longer needed
/// </param>
/// <return>
/// the #GdkAtom that corresponds to the
///               newly registered format’s mime-type.
/// </return>

	public static MentorLake.Gdk.GdkAtom RegisterDeserializeFormat(this MentorLake.Gtk.GtkTextBufferHandle buffer, string mime_type, MentorLake.Gtk.GtkTextBufferDeserializeFunc function, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_destroy)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_register_deserialize_format(buffer, mime_type, function, user_data, user_data_destroy);
	}

/// <summary>
/// <para>
/// This function registers GTK+’s internal rich text serialization
/// format with the passed @buffer. See
/// gtk_text_buffer_register_serialize_tagset() for details.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="tagset_name">
/// an optional tagset name, on %NULL
/// </param>
/// <return>
/// the #GdkAtom that corresponds to the
///               newly registered format’s mime-type.
/// </return>

	public static MentorLake.Gdk.GdkAtom RegisterDeserializeTagset(this MentorLake.Gtk.GtkTextBufferHandle buffer, string tagset_name)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_register_deserialize_tagset(buffer, tagset_name);
	}

/// <summary>
/// <para>
/// This function registers a rich text serialization @function along with
/// its @mime_type with the passed @buffer.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="mime_type">
/// the format’s mime-type
/// </param>
/// <param name="function">
/// the serialize function to register
/// </param>
/// <param name="user_data">
/// @function’s user_data
/// </param>
/// <param name="user_data_destroy">
/// a function to call when @user_data is no longer needed
/// </param>
/// <return>
/// the #GdkAtom that corresponds to the
///               newly registered format’s mime-type.
/// </return>

	public static MentorLake.Gdk.GdkAtom RegisterSerializeFormat(this MentorLake.Gtk.GtkTextBufferHandle buffer, string mime_type, MentorLake.Gtk.GtkTextBufferSerializeFunc function, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_destroy)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_register_serialize_format(buffer, mime_type, function, user_data, user_data_destroy);
	}

/// <summary>
/// <para>
/// This function registers GTK+’s internal rich text serialization
/// format with the passed @buffer. The internal format does not comply
/// to any standard rich text format and only works between #GtkTextBuffer
/// instances. It is capable of serializing all of a text buffer’s tags
/// and embedded pixbufs.
/// </para>
/// <para>
/// This function is just a wrapper around
/// gtk_text_buffer_register_serialize_format(). The mime type used
/// for registering is “application/x-gtk-text-buffer-rich-text”, or
/// “application/x-gtk-text-buffer-rich-text;format=@tagset_name” if a
/// @tagset_name was passed.
/// </para>
/// <para>
/// The @tagset_name can be used to restrict the transfer of rich text
/// to buffers with compatible sets of tags, in order to avoid unknown
/// tags from being pasted. It is probably the common case to pass an
/// identifier != %NULL here, since the %NULL tagset requires the
/// receiving buffer to deal with with pasting of arbitrary tags.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="tagset_name">
/// an optional tagset name, on %NULL
/// </param>
/// <return>
/// the #GdkAtom that corresponds to the
///               newly registered format’s mime-type.
/// </return>

	public static MentorLake.Gdk.GdkAtom RegisterSerializeTagset(this MentorLake.Gtk.GtkTextBufferHandle buffer, string tagset_name)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_register_serialize_tagset(buffer, tagset_name);
	}

/// <summary>
/// <para>
/// Removes all tags in the range between @start and @end.  Be careful
/// with this function; it could remove tags added in code unrelated to
/// the code you’re currently writing. That is, using this function is
/// probably a bad idea if you have two or more unrelated code sections
/// that add tags.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="start">
/// one bound of range to be untagged
/// </param>
/// <param name="end">
/// other bound of range to be untagged
/// </param>

	public static T RemoveAllTags<T>(this T buffer, MentorLake.Gtk.GtkTextIterHandle start, MentorLake.Gtk.GtkTextIterHandle end) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_remove_all_tags(buffer, start, end);
		return buffer;
	}

/// <summary>
/// <para>
/// Removes a #GtkClipboard added with
/// gtk_text_buffer_add_selection_clipboard().
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="clipboard">
/// a #GtkClipboard added to @buffer by
///             gtk_text_buffer_add_selection_clipboard()
/// </param>

	public static T RemoveSelectionClipboard<T>(this T buffer, MentorLake.Gtk.GtkClipboardHandle clipboard) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_remove_selection_clipboard(buffer, clipboard);
		return buffer;
	}

/// <summary>
/// <para>
/// Emits the “remove-tag” signal. The default handler for the signal
/// removes all occurrences of @tag from the given range. @start and
/// @end don’t have to be in order.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="tag">
/// a #GtkTextTag
/// </param>
/// <param name="start">
/// one bound of range to be untagged
/// </param>
/// <param name="end">
/// other bound of range to be untagged
/// </param>

	public static T RemoveTag<T>(this T buffer, MentorLake.Gtk.GtkTextTagHandle tag, MentorLake.Gtk.GtkTextIterHandle start, MentorLake.Gtk.GtkTextIterHandle end) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_remove_tag(buffer, tag, start, end);
		return buffer;
	}

/// <summary>
/// <para>
/// Calls gtk_text_tag_table_lookup() on the buffer’s tag table to
/// get a #GtkTextTag, then calls gtk_text_buffer_remove_tag().
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="name">
/// name of a #GtkTextTag
/// </param>
/// <param name="start">
/// one bound of range to be untagged
/// </param>
/// <param name="end">
/// other bound of range to be untagged
/// </param>

	public static T RemoveTagByName<T>(this T buffer, string name, MentorLake.Gtk.GtkTextIterHandle start, MentorLake.Gtk.GtkTextIterHandle end) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_remove_tag_by_name(buffer, name, start, end);
		return buffer;
	}

/// <summary>
/// <para>
/// This function moves the “insert” and “selection_bound” marks
/// simultaneously.  If you move them in two steps
/// with gtk_text_buffer_move_mark(), you will temporarily select a
/// region in between their old and new locations, which can be pretty
/// inefficient since the temporarily-selected region will force stuff
/// to be recalculated. This function moves them as a unit, which can
/// be optimized.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="ins">
/// where to put the “insert” mark
/// </param>
/// <param name="bound">
/// where to put the “selection_bound” mark
/// </param>

	public static T SelectRange<T>(this T buffer, MentorLake.Gtk.GtkTextIterHandle ins, MentorLake.Gtk.GtkTextIterHandle bound) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_select_range(buffer, ins, bound);
		return buffer;
	}

/// <summary>
/// <para>
/// This function serializes the portion of text between @start
/// and @end in the rich text format represented by @format.
/// </para>
/// <para>
/// @formats to be used must be registered using
/// gtk_text_buffer_register_serialize_format() or
/// gtk_text_buffer_register_serialize_tagset() beforehand.
/// </para>
/// </summary>

/// <param name="register_buffer">
/// the #GtkTextBuffer @format is registered with
/// </param>
/// <param name="content_buffer">
/// the #GtkTextBuffer to serialize
/// </param>
/// <param name="format">
/// the rich text format to use for serializing
/// </param>
/// <param name="start">
/// start of block of text to serialize
/// </param>
/// <param name="end">
/// end of block of test to serialize
/// </param>
/// <param name="length">
/// return location for the length of the serialized data
/// </param>
/// <return>
/// the serialized
///               data, encoded as @format
/// </return>

	public static byte[] Serialize(this MentorLake.Gtk.GtkTextBufferHandle register_buffer, MentorLake.Gtk.GtkTextBufferHandle content_buffer, MentorLake.Gdk.GdkAtom format, MentorLake.Gtk.GtkTextIterHandle start, MentorLake.Gtk.GtkTextIterHandle end, out UIntPtr length)
	{
		if (register_buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_serialize(register_buffer, content_buffer, format, start, end, out length);
	}

/// <summary>
/// <para>
/// Used to keep track of whether the buffer has been modified since the
/// last time it was saved. Whenever the buffer is saved to disk, call
/// gtk_text_buffer_set_modified (@buffer, FALSE). When the buffer is modified,
/// it will automatically toggled on the modified bit again. When the modified
/// bit flips, the buffer emits the #GtkTextBuffer::modified-changed signal.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="setting">
/// modification flag setting
/// </param>

	public static T SetModified<T>(this T buffer, bool setting) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_set_modified(buffer, setting);
		return buffer;
	}

/// <summary>
/// <para>
/// Deletes current contents of @buffer, and inserts @text instead. If
/// @len is -1, @text must be nul-terminated. @text must be valid UTF-8.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="text">
/// UTF-8 text to insert
/// </param>
/// <param name="len">
/// length of @text in bytes
/// </param>

	public static T SetText<T>(this T buffer, string text, int len) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_set_text(buffer, text, len);
		return buffer;
	}

/// <summary>
/// <para>
/// This function unregisters a rich text format that was previously
/// registered using gtk_text_buffer_register_deserialize_format() or
/// gtk_text_buffer_register_deserialize_tagset().
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="format">
/// a #GdkAtom representing a registered rich text format.
/// </param>

	public static T UnregisterDeserializeFormat<T>(this T buffer, MentorLake.Gdk.GdkAtom format) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_unregister_deserialize_format(buffer, format);
		return buffer;
	}

/// <summary>
/// <para>
/// This function unregisters a rich text format that was previously
/// registered using gtk_text_buffer_register_serialize_format() or
/// gtk_text_buffer_register_serialize_tagset()
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <param name="format">
/// a #GdkAtom representing a registered rich text format.
/// </param>

	public static T UnregisterSerializeFormat<T>(this T buffer, MentorLake.Gdk.GdkAtom format) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_unregister_serialize_format(buffer, format);
		return buffer;
	}

}

internal class GtkTextBufferHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))]
	internal static extern MentorLake.Gtk.GtkTextBufferHandle gtk_text_buffer_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagTableHandle>))] MentorLake.Gtk.GtkTextTagTableHandle table);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_add_mark([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextMarkHandle>))] MentorLake.Gtk.GtkTextMarkHandle mark, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle where);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_add_selection_clipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_apply_tag([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagHandle>))] MentorLake.Gtk.GtkTextTagHandle tag, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle start, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle end);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_apply_tag_by_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, string name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle start, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle end);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_buffer_backspace([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, bool interactive, bool default_editable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_begin_user_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_copy_clipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextChildAnchorHandle>))]
	internal static extern MentorLake.Gtk.GtkTextChildAnchorHandle gtk_text_buffer_create_child_anchor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextMarkHandle>))]
	internal static extern MentorLake.Gtk.GtkTextMarkHandle gtk_text_buffer_create_mark([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, string mark_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle where, bool left_gravity);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagHandle>))]
	internal static extern MentorLake.Gtk.GtkTextTagHandle gtk_text_buffer_create_tag([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, string tag_name, string first_property_name, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_cut_clipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard, bool default_editable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_delete([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle start, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle end);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_buffer_delete_interactive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle start_iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle end_iter, bool default_editable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_delete_mark([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextMarkHandle>))] MentorLake.Gtk.GtkTextMarkHandle mark);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_delete_mark_by_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_buffer_delete_selection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, bool interactive, bool default_editable);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_buffer_deserialize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle register_buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle content_buffer, MentorLake.Gdk.GdkAtom format, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, byte[] data, UIntPtr length, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_buffer_deserialize_get_can_create_tags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, MentorLake.Gdk.GdkAtom format);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_deserialize_set_can_create_tags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, MentorLake.Gdk.GdkAtom format, bool can_create_tags);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_end_user_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_get_bounds([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, out MentorLake.Gtk.GtkTextIter start, out MentorLake.Gtk.GtkTextIter end);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_text_buffer_get_char_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTargetListHandle>))]
	internal static extern MentorLake.Gtk.GtkTargetListHandle gtk_text_buffer_get_copy_target_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkAtom[] gtk_text_buffer_get_deserialize_formats([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, out int n_formats);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_get_end_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, out MentorLake.Gtk.GtkTextIter iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_buffer_get_has_selection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextMarkHandle>))]
	internal static extern MentorLake.Gtk.GtkTextMarkHandle gtk_text_buffer_get_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_get_iter_at_child_anchor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, out MentorLake.Gtk.GtkTextIter iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextChildAnchorHandle>))] MentorLake.Gtk.GtkTextChildAnchorHandle anchor);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_get_iter_at_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, out MentorLake.Gtk.GtkTextIter iter, int line_number);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_get_iter_at_line_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, out MentorLake.Gtk.GtkTextIter iter, int line_number, int byte_index);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_get_iter_at_line_offset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, out MentorLake.Gtk.GtkTextIter iter, int line_number, int char_offset);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_get_iter_at_mark([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, out MentorLake.Gtk.GtkTextIter iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextMarkHandle>))] MentorLake.Gtk.GtkTextMarkHandle mark);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_get_iter_at_offset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, out MentorLake.Gtk.GtkTextIter iter, int char_offset);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_text_buffer_get_line_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextMarkHandle>))]
	internal static extern MentorLake.Gtk.GtkTextMarkHandle gtk_text_buffer_get_mark([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_buffer_get_modified([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTargetListHandle>))]
	internal static extern MentorLake.Gtk.GtkTargetListHandle gtk_text_buffer_get_paste_target_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextMarkHandle>))]
	internal static extern MentorLake.Gtk.GtkTextMarkHandle gtk_text_buffer_get_selection_bound([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_buffer_get_selection_bounds([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, out MentorLake.Gtk.GtkTextIter start, out MentorLake.Gtk.GtkTextIter end);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkAtom[] gtk_text_buffer_get_serialize_formats([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, out int n_formats);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_text_buffer_get_slice([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle start, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle end, bool include_hidden_chars);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_get_start_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, out MentorLake.Gtk.GtkTextIter iter);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagTableHandle>))]
	internal static extern MentorLake.Gtk.GtkTextTagTableHandle gtk_text_buffer_get_tag_table([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_text_buffer_get_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle start, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle end, bool include_hidden_chars);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, string text, int len);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_insert_at_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, string text, int len);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_insert_child_anchor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextChildAnchorHandle>))] MentorLake.Gtk.GtkTextChildAnchorHandle anchor);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_buffer_insert_interactive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, string text, int len, bool default_editable);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_buffer_insert_interactive_at_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, string text, int len, bool default_editable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_insert_markup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, string markup, int len);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_insert_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_insert_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle start, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle end);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_buffer_insert_range_interactive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle start, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle end, bool default_editable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_insert_with_tags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, string text, int len, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagHandle>))] MentorLake.Gtk.GtkTextTagHandle first_tag, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_insert_with_tags_by_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, string text, int len, string first_tag_name, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_move_mark([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextMarkHandle>))] MentorLake.Gtk.GtkTextMarkHandle mark, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle where);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_move_mark_by_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, string name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle where);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_paste_clipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle override_location, bool default_editable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_place_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle where);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkAtom gtk_text_buffer_register_deserialize_format([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, string mime_type, MentorLake.Gtk.GtkTextBufferDeserializeFunc function, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_destroy);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkAtom gtk_text_buffer_register_deserialize_tagset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, string tagset_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkAtom gtk_text_buffer_register_serialize_format([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, string mime_type, MentorLake.Gtk.GtkTextBufferSerializeFunc function, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_destroy);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkAtom gtk_text_buffer_register_serialize_tagset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, string tagset_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_remove_all_tags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle start, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle end);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_remove_selection_clipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_remove_tag([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagHandle>))] MentorLake.Gtk.GtkTextTagHandle tag, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle start, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle end);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_remove_tag_by_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, string name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle start, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle end);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_select_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle ins, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle bound);

	[DllImport(GtkLibrary.Name)]
	internal static extern byte[] gtk_text_buffer_serialize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle register_buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle content_buffer, MentorLake.Gdk.GdkAtom format, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle start, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle end, out UIntPtr length);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_set_modified([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_set_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, string text, int len);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_unregister_deserialize_format([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, MentorLake.Gdk.GdkAtom format);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_unregister_serialize_format([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, MentorLake.Gdk.GdkAtom format);

}
