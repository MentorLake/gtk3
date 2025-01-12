namespace MentorLake.Gtk3.Gtk3;

public class GtkTextBufferHandle : GObjectHandle
{
	public static GtkTextBufferHandle New(GtkTextTagTableHandle table)
	{
		return GtkTextBufferExterns.gtk_text_buffer_new(table);
	}

}

public static class GtkTextBufferSignalExtensions
{

	public static IObservable<GtkTextBufferSignalStructs.ApplyTagSignal> Signal_ApplyTag(this GtkTextBufferHandle instance)
	{
		return Observable.Create((IObserver<GtkTextBufferSignalStructs.ApplyTagSignal> obs) =>
		{
			GtkTextBufferSignalDelegates.apply_tag handler = (GtkTextBufferHandle self, GtkTextTagHandle tag, GtkTextIterHandle start, GtkTextIterHandle end, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextBufferSignalStructs.ApplyTagSignal()
				{
					Self = self, Tag = tag, Start = start, End = end, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "apply_tag", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkTextBufferSignalStructs.BeginUserActionSignal> Signal_BeginUserAction(this GtkTextBufferHandle instance)
	{
		return Observable.Create((IObserver<GtkTextBufferSignalStructs.BeginUserActionSignal> obs) =>
		{
			GtkTextBufferSignalDelegates.begin_user_action handler = (GtkTextBufferHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextBufferSignalStructs.BeginUserActionSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "begin_user_action", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkTextBufferSignalStructs.ChangedSignal> Signal_Changed(this GtkTextBufferHandle instance)
	{
		return Observable.Create((IObserver<GtkTextBufferSignalStructs.ChangedSignal> obs) =>
		{
			GtkTextBufferSignalDelegates.changed handler = (GtkTextBufferHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextBufferSignalStructs.ChangedSignal()
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

	public static IObservable<GtkTextBufferSignalStructs.DeleteRangeSignal> Signal_DeleteRange(this GtkTextBufferHandle instance)
	{
		return Observable.Create((IObserver<GtkTextBufferSignalStructs.DeleteRangeSignal> obs) =>
		{
			GtkTextBufferSignalDelegates.delete_range handler = (GtkTextBufferHandle self, GtkTextIterHandle start, GtkTextIterHandle end, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextBufferSignalStructs.DeleteRangeSignal()
				{
					Self = self, Start = start, End = end, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "delete_range", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkTextBufferSignalStructs.EndUserActionSignal> Signal_EndUserAction(this GtkTextBufferHandle instance)
	{
		return Observable.Create((IObserver<GtkTextBufferSignalStructs.EndUserActionSignal> obs) =>
		{
			GtkTextBufferSignalDelegates.end_user_action handler = (GtkTextBufferHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextBufferSignalStructs.EndUserActionSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "end_user_action", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkTextBufferSignalStructs.InsertChildAnchorSignal> Signal_InsertChildAnchor(this GtkTextBufferHandle instance)
	{
		return Observable.Create((IObserver<GtkTextBufferSignalStructs.InsertChildAnchorSignal> obs) =>
		{
			GtkTextBufferSignalDelegates.insert_child_anchor handler = (GtkTextBufferHandle self, GtkTextIterHandle location, GtkTextChildAnchorHandle anchor, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextBufferSignalStructs.InsertChildAnchorSignal()
				{
					Self = self, Location = location, Anchor = anchor, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "insert_child_anchor", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkTextBufferSignalStructs.InsertPixbufSignal> Signal_InsertPixbuf(this GtkTextBufferHandle instance)
	{
		return Observable.Create((IObserver<GtkTextBufferSignalStructs.InsertPixbufSignal> obs) =>
		{
			GtkTextBufferSignalDelegates.insert_pixbuf handler = (GtkTextBufferHandle self, GtkTextIterHandle location, GdkPixbufHandle pixbuf, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextBufferSignalStructs.InsertPixbufSignal()
				{
					Self = self, Location = location, Pixbuf = pixbuf, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "insert_pixbuf", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkTextBufferSignalStructs.InsertTextSignal> Signal_InsertText(this GtkTextBufferHandle instance)
	{
		return Observable.Create((IObserver<GtkTextBufferSignalStructs.InsertTextSignal> obs) =>
		{
			GtkTextBufferSignalDelegates.insert_text handler = (GtkTextBufferHandle self, GtkTextIterHandle location, string text, int len, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextBufferSignalStructs.InsertTextSignal()
				{
					Self = self, Location = location, Text = text, Len = len, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "insert_text", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkTextBufferSignalStructs.MarkDeletedSignal> Signal_MarkDeleted(this GtkTextBufferHandle instance)
	{
		return Observable.Create((IObserver<GtkTextBufferSignalStructs.MarkDeletedSignal> obs) =>
		{
			GtkTextBufferSignalDelegates.mark_deleted handler = (GtkTextBufferHandle self, GtkTextMarkHandle mark, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextBufferSignalStructs.MarkDeletedSignal()
				{
					Self = self, Mark = mark, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "mark_deleted", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkTextBufferSignalStructs.MarkSetSignal> Signal_MarkSet(this GtkTextBufferHandle instance)
	{
		return Observable.Create((IObserver<GtkTextBufferSignalStructs.MarkSetSignal> obs) =>
		{
			GtkTextBufferSignalDelegates.mark_set handler = (GtkTextBufferHandle self, GtkTextIterHandle location, GtkTextMarkHandle mark, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextBufferSignalStructs.MarkSetSignal()
				{
					Self = self, Location = location, Mark = mark, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "mark_set", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkTextBufferSignalStructs.ModifiedChangedSignal> Signal_ModifiedChanged(this GtkTextBufferHandle instance)
	{
		return Observable.Create((IObserver<GtkTextBufferSignalStructs.ModifiedChangedSignal> obs) =>
		{
			GtkTextBufferSignalDelegates.modified_changed handler = (GtkTextBufferHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextBufferSignalStructs.ModifiedChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "modified_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkTextBufferSignalStructs.PasteDoneSignal> Signal_PasteDone(this GtkTextBufferHandle instance)
	{
		return Observable.Create((IObserver<GtkTextBufferSignalStructs.PasteDoneSignal> obs) =>
		{
			GtkTextBufferSignalDelegates.paste_done handler = (GtkTextBufferHandle self, GtkClipboardHandle clipboard, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextBufferSignalStructs.PasteDoneSignal()
				{
					Self = self, Clipboard = clipboard, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "paste_done", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkTextBufferSignalStructs.RemoveTagSignal> Signal_RemoveTag(this GtkTextBufferHandle instance)
	{
		return Observable.Create((IObserver<GtkTextBufferSignalStructs.RemoveTagSignal> obs) =>
		{
			GtkTextBufferSignalDelegates.remove_tag handler = (GtkTextBufferHandle self, GtkTextTagHandle tag, GtkTextIterHandle start, GtkTextIterHandle end, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextBufferSignalStructs.RemoveTagSignal()
				{
					Self = self, Tag = tag, Start = start, End = end, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "remove_tag", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkTextBufferSignalStructs
{

public struct ApplyTagSignal
{
	public GtkTextBufferHandle Self;
	public GtkTextTagHandle Tag;
	public GtkTextIterHandle Start;
	public GtkTextIterHandle End;
	public IntPtr UserData;
}

public struct BeginUserActionSignal
{
	public GtkTextBufferHandle Self;
	public IntPtr UserData;
}

public struct ChangedSignal
{
	public GtkTextBufferHandle Self;
	public IntPtr UserData;
}

public struct DeleteRangeSignal
{
	public GtkTextBufferHandle Self;
	public GtkTextIterHandle Start;
	public GtkTextIterHandle End;
	public IntPtr UserData;
}

public struct EndUserActionSignal
{
	public GtkTextBufferHandle Self;
	public IntPtr UserData;
}

public struct InsertChildAnchorSignal
{
	public GtkTextBufferHandle Self;
	public GtkTextIterHandle Location;
	public GtkTextChildAnchorHandle Anchor;
	public IntPtr UserData;
}

public struct InsertPixbufSignal
{
	public GtkTextBufferHandle Self;
	public GtkTextIterHandle Location;
	public GdkPixbufHandle Pixbuf;
	public IntPtr UserData;
}

public struct InsertTextSignal
{
	public GtkTextBufferHandle Self;
	public GtkTextIterHandle Location;
	public string Text;
	public int Len;
	public IntPtr UserData;
}

public struct MarkDeletedSignal
{
	public GtkTextBufferHandle Self;
	public GtkTextMarkHandle Mark;
	public IntPtr UserData;
}

public struct MarkSetSignal
{
	public GtkTextBufferHandle Self;
	public GtkTextIterHandle Location;
	public GtkTextMarkHandle Mark;
	public IntPtr UserData;
}

public struct ModifiedChangedSignal
{
	public GtkTextBufferHandle Self;
	public IntPtr UserData;
}

public struct PasteDoneSignal
{
	public GtkTextBufferHandle Self;
	public GtkClipboardHandle Clipboard;
	public IntPtr UserData;
}

public struct RemoveTagSignal
{
	public GtkTextBufferHandle Self;
	public GtkTextTagHandle Tag;
	public GtkTextIterHandle Start;
	public GtkTextIterHandle End;
	public IntPtr UserData;
}
}

public static class GtkTextBufferSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void apply_tag([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextBufferHandle>))] GtkTextBufferHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextTagHandle>))] GtkTextTagHandle tag, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextIterHandle>))] GtkTextIterHandle start, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextIterHandle>))] GtkTextIterHandle end, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void begin_user_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextBufferHandle>))] GtkTextBufferHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextBufferHandle>))] GtkTextBufferHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void delete_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextBufferHandle>))] GtkTextBufferHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextIterHandle>))] GtkTextIterHandle start, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextIterHandle>))] GtkTextIterHandle end, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void end_user_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextBufferHandle>))] GtkTextBufferHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void insert_child_anchor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextBufferHandle>))] GtkTextBufferHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextIterHandle>))] GtkTextIterHandle location, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextChildAnchorHandle>))] GtkTextChildAnchorHandle anchor, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void insert_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextBufferHandle>))] GtkTextBufferHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextIterHandle>))] GtkTextIterHandle location, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkPixbufHandle>))] GdkPixbufHandle pixbuf, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void insert_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextBufferHandle>))] GtkTextBufferHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextIterHandle>))] GtkTextIterHandle location, string text, int len, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void mark_deleted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextBufferHandle>))] GtkTextBufferHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextMarkHandle>))] GtkTextMarkHandle mark, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void mark_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextBufferHandle>))] GtkTextBufferHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextIterHandle>))] GtkTextIterHandle location, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextMarkHandle>))] GtkTextMarkHandle mark, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void modified_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextBufferHandle>))] GtkTextBufferHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void paste_done([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextBufferHandle>))] GtkTextBufferHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkClipboardHandle>))] GtkClipboardHandle clipboard, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void remove_tag([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextBufferHandle>))] GtkTextBufferHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextTagHandle>))] GtkTextTagHandle tag, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextIterHandle>))] GtkTextIterHandle start, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextIterHandle>))] GtkTextIterHandle end, IntPtr user_data);

}


public static class GtkTextBufferHandleExtensions
{
	public static GtkTextBufferHandle AddMark(this GtkTextBufferHandle buffer, GtkTextMarkHandle mark, GtkTextIterHandle where)
	{
		GtkTextBufferExterns.gtk_text_buffer_add_mark(buffer, mark, where);
		return buffer;
	}

	public static GtkTextBufferHandle AddSelectionClipboard(this GtkTextBufferHandle buffer, GtkClipboardHandle clipboard)
	{
		GtkTextBufferExterns.gtk_text_buffer_add_selection_clipboard(buffer, clipboard);
		return buffer;
	}

	public static GtkTextBufferHandle ApplyTag(this GtkTextBufferHandle buffer, GtkTextTagHandle tag, GtkTextIterHandle start, GtkTextIterHandle end)
	{
		GtkTextBufferExterns.gtk_text_buffer_apply_tag(buffer, tag, start, end);
		return buffer;
	}

	public static GtkTextBufferHandle ApplyTagByName(this GtkTextBufferHandle buffer, string name, GtkTextIterHandle start, GtkTextIterHandle end)
	{
		GtkTextBufferExterns.gtk_text_buffer_apply_tag_by_name(buffer, name, start, end);
		return buffer;
	}

	public static bool Backspace(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, bool interactive, bool default_editable)
	{
		return GtkTextBufferExterns.gtk_text_buffer_backspace(buffer, iter, interactive, default_editable);
	}

	public static GtkTextBufferHandle BeginUserAction(this GtkTextBufferHandle buffer)
	{
		GtkTextBufferExterns.gtk_text_buffer_begin_user_action(buffer);
		return buffer;
	}

	public static GtkTextBufferHandle CopyClipboard(this GtkTextBufferHandle buffer, GtkClipboardHandle clipboard)
	{
		GtkTextBufferExterns.gtk_text_buffer_copy_clipboard(buffer, clipboard);
		return buffer;
	}

	public static GtkTextChildAnchorHandle CreateChildAnchor(this GtkTextBufferHandle buffer, GtkTextIterHandle iter)
	{
		return GtkTextBufferExterns.gtk_text_buffer_create_child_anchor(buffer, iter);
	}

	public static GtkTextMarkHandle CreateMark(this GtkTextBufferHandle buffer, string mark_name, GtkTextIterHandle where, bool left_gravity)
	{
		return GtkTextBufferExterns.gtk_text_buffer_create_mark(buffer, mark_name, where, left_gravity);
	}

	public static GtkTextTagHandle CreateTag(this GtkTextBufferHandle buffer, string tag_name, string first_property_name, IntPtr @__arglist)
	{
		return GtkTextBufferExterns.gtk_text_buffer_create_tag(buffer, tag_name, first_property_name, @__arglist);
	}

	public static GtkTextBufferHandle CutClipboard(this GtkTextBufferHandle buffer, GtkClipboardHandle clipboard, bool default_editable)
	{
		GtkTextBufferExterns.gtk_text_buffer_cut_clipboard(buffer, clipboard, default_editable);
		return buffer;
	}

	public static GtkTextBufferHandle Delete(this GtkTextBufferHandle buffer, GtkTextIterHandle start, GtkTextIterHandle end)
	{
		GtkTextBufferExterns.gtk_text_buffer_delete(buffer, start, end);
		return buffer;
	}

	public static bool DeleteInteractive(this GtkTextBufferHandle buffer, GtkTextIterHandle start_iter, GtkTextIterHandle end_iter, bool default_editable)
	{
		return GtkTextBufferExterns.gtk_text_buffer_delete_interactive(buffer, start_iter, end_iter, default_editable);
	}

	public static GtkTextBufferHandle DeleteMark(this GtkTextBufferHandle buffer, GtkTextMarkHandle mark)
	{
		GtkTextBufferExterns.gtk_text_buffer_delete_mark(buffer, mark);
		return buffer;
	}

	public static GtkTextBufferHandle DeleteMarkByName(this GtkTextBufferHandle buffer, string name)
	{
		GtkTextBufferExterns.gtk_text_buffer_delete_mark_by_name(buffer, name);
		return buffer;
	}

	public static bool DeleteSelection(this GtkTextBufferHandle buffer, bool interactive, bool default_editable)
	{
		return GtkTextBufferExterns.gtk_text_buffer_delete_selection(buffer, interactive, default_editable);
	}

	public static bool Deserialize(this GtkTextBufferHandle register_buffer, GtkTextBufferHandle content_buffer, GdkAtom format, GtkTextIterHandle iter, byte[] data, UIntPtr length, out GErrorHandle error)
	{
		return GtkTextBufferExterns.gtk_text_buffer_deserialize(register_buffer, content_buffer, format, iter, data, length, out error);
	}

	public static bool DeserializeGetCanCreateTags(this GtkTextBufferHandle buffer, GdkAtom format)
	{
		return GtkTextBufferExterns.gtk_text_buffer_deserialize_get_can_create_tags(buffer, format);
	}

	public static GtkTextBufferHandle DeserializeSetCanCreateTags(this GtkTextBufferHandle buffer, GdkAtom format, bool can_create_tags)
	{
		GtkTextBufferExterns.gtk_text_buffer_deserialize_set_can_create_tags(buffer, format, can_create_tags);
		return buffer;
	}

	public static GtkTextBufferHandle EndUserAction(this GtkTextBufferHandle buffer)
	{
		GtkTextBufferExterns.gtk_text_buffer_end_user_action(buffer);
		return buffer;
	}

	public static GtkTextBufferHandle GetBounds(this GtkTextBufferHandle buffer, out GtkTextIter start, out GtkTextIter end)
	{
		GtkTextBufferExterns.gtk_text_buffer_get_bounds(buffer, out start, out end);
		return buffer;
	}

	public static int GetCharCount(this GtkTextBufferHandle buffer)
	{
		return GtkTextBufferExterns.gtk_text_buffer_get_char_count(buffer);
	}

	public static GtkTargetListHandle GetCopyTargetList(this GtkTextBufferHandle buffer)
	{
		return GtkTextBufferExterns.gtk_text_buffer_get_copy_target_list(buffer);
	}

	public static IntPtr GetDeserializeFormats(this GtkTextBufferHandle buffer, out int n_formats)
	{
		return GtkTextBufferExterns.gtk_text_buffer_get_deserialize_formats(buffer, out n_formats);
	}

	public static GtkTextBufferHandle GetEndIter(this GtkTextBufferHandle buffer, out GtkTextIter iter)
	{
		GtkTextBufferExterns.gtk_text_buffer_get_end_iter(buffer, out iter);
		return buffer;
	}

	public static bool GetHasSelection(this GtkTextBufferHandle buffer)
	{
		return GtkTextBufferExterns.gtk_text_buffer_get_has_selection(buffer);
	}

	public static GtkTextMarkHandle GetInsert(this GtkTextBufferHandle buffer)
	{
		return GtkTextBufferExterns.gtk_text_buffer_get_insert(buffer);
	}

	public static GtkTextBufferHandle GetIterAtChildAnchor(this GtkTextBufferHandle buffer, out GtkTextIter iter, GtkTextChildAnchorHandle anchor)
	{
		GtkTextBufferExterns.gtk_text_buffer_get_iter_at_child_anchor(buffer, out iter, anchor);
		return buffer;
	}

	public static GtkTextBufferHandle GetIterAtLine(this GtkTextBufferHandle buffer, out GtkTextIter iter, int line_number)
	{
		GtkTextBufferExterns.gtk_text_buffer_get_iter_at_line(buffer, out iter, line_number);
		return buffer;
	}

	public static GtkTextBufferHandle GetIterAtLineIndex(this GtkTextBufferHandle buffer, out GtkTextIter iter, int line_number, int byte_index)
	{
		GtkTextBufferExterns.gtk_text_buffer_get_iter_at_line_index(buffer, out iter, line_number, byte_index);
		return buffer;
	}

	public static GtkTextBufferHandle GetIterAtLineOffset(this GtkTextBufferHandle buffer, out GtkTextIter iter, int line_number, int char_offset)
	{
		GtkTextBufferExterns.gtk_text_buffer_get_iter_at_line_offset(buffer, out iter, line_number, char_offset);
		return buffer;
	}

	public static GtkTextBufferHandle GetIterAtMark(this GtkTextBufferHandle buffer, out GtkTextIter iter, GtkTextMarkHandle mark)
	{
		GtkTextBufferExterns.gtk_text_buffer_get_iter_at_mark(buffer, out iter, mark);
		return buffer;
	}

	public static GtkTextBufferHandle GetIterAtOffset(this GtkTextBufferHandle buffer, out GtkTextIter iter, int char_offset)
	{
		GtkTextBufferExterns.gtk_text_buffer_get_iter_at_offset(buffer, out iter, char_offset);
		return buffer;
	}

	public static int GetLineCount(this GtkTextBufferHandle buffer)
	{
		return GtkTextBufferExterns.gtk_text_buffer_get_line_count(buffer);
	}

	public static GtkTextMarkHandle GetMark(this GtkTextBufferHandle buffer, string name)
	{
		return GtkTextBufferExterns.gtk_text_buffer_get_mark(buffer, name);
	}

	public static bool GetModified(this GtkTextBufferHandle buffer)
	{
		return GtkTextBufferExterns.gtk_text_buffer_get_modified(buffer);
	}

	public static GtkTargetListHandle GetPasteTargetList(this GtkTextBufferHandle buffer)
	{
		return GtkTextBufferExterns.gtk_text_buffer_get_paste_target_list(buffer);
	}

	public static GtkTextMarkHandle GetSelectionBound(this GtkTextBufferHandle buffer)
	{
		return GtkTextBufferExterns.gtk_text_buffer_get_selection_bound(buffer);
	}

	public static bool GetSelectionBounds(this GtkTextBufferHandle buffer, out GtkTextIter start, out GtkTextIter end)
	{
		return GtkTextBufferExterns.gtk_text_buffer_get_selection_bounds(buffer, out start, out end);
	}

	public static IntPtr GetSerializeFormats(this GtkTextBufferHandle buffer, out int n_formats)
	{
		return GtkTextBufferExterns.gtk_text_buffer_get_serialize_formats(buffer, out n_formats);
	}

	public static string GetSlice(this GtkTextBufferHandle buffer, GtkTextIterHandle start, GtkTextIterHandle end, bool include_hidden_chars)
	{
		return GtkTextBufferExterns.gtk_text_buffer_get_slice(buffer, start, end, include_hidden_chars);
	}

	public static GtkTextBufferHandle GetStartIter(this GtkTextBufferHandle buffer, out GtkTextIter iter)
	{
		GtkTextBufferExterns.gtk_text_buffer_get_start_iter(buffer, out iter);
		return buffer;
	}

	public static GtkTextTagTableHandle GetTagTable(this GtkTextBufferHandle buffer)
	{
		return GtkTextBufferExterns.gtk_text_buffer_get_tag_table(buffer);
	}

	public static string GetText(this GtkTextBufferHandle buffer, GtkTextIterHandle start, GtkTextIterHandle end, bool include_hidden_chars)
	{
		return GtkTextBufferExterns.gtk_text_buffer_get_text(buffer, start, end, include_hidden_chars);
	}

	public static GtkTextBufferHandle Insert(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, string text, int len)
	{
		GtkTextBufferExterns.gtk_text_buffer_insert(buffer, iter, text, len);
		return buffer;
	}

	public static GtkTextBufferHandle InsertAtCursor(this GtkTextBufferHandle buffer, string text, int len)
	{
		GtkTextBufferExterns.gtk_text_buffer_insert_at_cursor(buffer, text, len);
		return buffer;
	}

	public static GtkTextBufferHandle InsertChildAnchor(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, GtkTextChildAnchorHandle anchor)
	{
		GtkTextBufferExterns.gtk_text_buffer_insert_child_anchor(buffer, iter, anchor);
		return buffer;
	}

	public static bool InsertInteractive(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, string text, int len, bool default_editable)
	{
		return GtkTextBufferExterns.gtk_text_buffer_insert_interactive(buffer, iter, text, len, default_editable);
	}

	public static bool InsertInteractiveAtCursor(this GtkTextBufferHandle buffer, string text, int len, bool default_editable)
	{
		return GtkTextBufferExterns.gtk_text_buffer_insert_interactive_at_cursor(buffer, text, len, default_editable);
	}

	public static GtkTextBufferHandle InsertMarkup(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, string markup, int len)
	{
		GtkTextBufferExterns.gtk_text_buffer_insert_markup(buffer, iter, markup, len);
		return buffer;
	}

	public static GtkTextBufferHandle InsertPixbuf(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, GdkPixbufHandle pixbuf)
	{
		GtkTextBufferExterns.gtk_text_buffer_insert_pixbuf(buffer, iter, pixbuf);
		return buffer;
	}

	public static GtkTextBufferHandle InsertRange(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, GtkTextIterHandle start, GtkTextIterHandle end)
	{
		GtkTextBufferExterns.gtk_text_buffer_insert_range(buffer, iter, start, end);
		return buffer;
	}

	public static bool InsertRangeInteractive(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, GtkTextIterHandle start, GtkTextIterHandle end, bool default_editable)
	{
		return GtkTextBufferExterns.gtk_text_buffer_insert_range_interactive(buffer, iter, start, end, default_editable);
	}

	public static GtkTextBufferHandle InsertWithTags(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, string text, int len, GtkTextTagHandle first_tag, IntPtr @__arglist)
	{
		GtkTextBufferExterns.gtk_text_buffer_insert_with_tags(buffer, iter, text, len, first_tag, @__arglist);
		return buffer;
	}

	public static GtkTextBufferHandle InsertWithTagsByName(this GtkTextBufferHandle buffer, GtkTextIterHandle iter, string text, int len, string first_tag_name, IntPtr @__arglist)
	{
		GtkTextBufferExterns.gtk_text_buffer_insert_with_tags_by_name(buffer, iter, text, len, first_tag_name, @__arglist);
		return buffer;
	}

	public static GtkTextBufferHandle MoveMark(this GtkTextBufferHandle buffer, GtkTextMarkHandle mark, GtkTextIterHandle where)
	{
		GtkTextBufferExterns.gtk_text_buffer_move_mark(buffer, mark, where);
		return buffer;
	}

	public static GtkTextBufferHandle MoveMarkByName(this GtkTextBufferHandle buffer, string name, GtkTextIterHandle where)
	{
		GtkTextBufferExterns.gtk_text_buffer_move_mark_by_name(buffer, name, where);
		return buffer;
	}

	public static GtkTextBufferHandle PasteClipboard(this GtkTextBufferHandle buffer, GtkClipboardHandle clipboard, GtkTextIterHandle override_location, bool default_editable)
	{
		GtkTextBufferExterns.gtk_text_buffer_paste_clipboard(buffer, clipboard, override_location, default_editable);
		return buffer;
	}

	public static GtkTextBufferHandle PlaceCursor(this GtkTextBufferHandle buffer, GtkTextIterHandle where)
	{
		GtkTextBufferExterns.gtk_text_buffer_place_cursor(buffer, where);
		return buffer;
	}

	public static GdkAtom RegisterDeserializeFormat(this GtkTextBufferHandle buffer, string mime_type, GtkTextBufferDeserializeFunc function, IntPtr user_data, GDestroyNotify user_data_destroy)
	{
		return GtkTextBufferExterns.gtk_text_buffer_register_deserialize_format(buffer, mime_type, function, user_data, user_data_destroy);
	}

	public static GdkAtom RegisterDeserializeTagset(this GtkTextBufferHandle buffer, string tagset_name)
	{
		return GtkTextBufferExterns.gtk_text_buffer_register_deserialize_tagset(buffer, tagset_name);
	}

	public static GdkAtom RegisterSerializeFormat(this GtkTextBufferHandle buffer, string mime_type, GtkTextBufferSerializeFunc function, IntPtr user_data, GDestroyNotify user_data_destroy)
	{
		return GtkTextBufferExterns.gtk_text_buffer_register_serialize_format(buffer, mime_type, function, user_data, user_data_destroy);
	}

	public static GdkAtom RegisterSerializeTagset(this GtkTextBufferHandle buffer, string tagset_name)
	{
		return GtkTextBufferExterns.gtk_text_buffer_register_serialize_tagset(buffer, tagset_name);
	}

	public static GtkTextBufferHandle RemoveAllTags(this GtkTextBufferHandle buffer, GtkTextIterHandle start, GtkTextIterHandle end)
	{
		GtkTextBufferExterns.gtk_text_buffer_remove_all_tags(buffer, start, end);
		return buffer;
	}

	public static GtkTextBufferHandle RemoveSelectionClipboard(this GtkTextBufferHandle buffer, GtkClipboardHandle clipboard)
	{
		GtkTextBufferExterns.gtk_text_buffer_remove_selection_clipboard(buffer, clipboard);
		return buffer;
	}

	public static GtkTextBufferHandle RemoveTag(this GtkTextBufferHandle buffer, GtkTextTagHandle tag, GtkTextIterHandle start, GtkTextIterHandle end)
	{
		GtkTextBufferExterns.gtk_text_buffer_remove_tag(buffer, tag, start, end);
		return buffer;
	}

	public static GtkTextBufferHandle RemoveTagByName(this GtkTextBufferHandle buffer, string name, GtkTextIterHandle start, GtkTextIterHandle end)
	{
		GtkTextBufferExterns.gtk_text_buffer_remove_tag_by_name(buffer, name, start, end);
		return buffer;
	}

	public static GtkTextBufferHandle SelectRange(this GtkTextBufferHandle buffer, GtkTextIterHandle ins, GtkTextIterHandle bound)
	{
		GtkTextBufferExterns.gtk_text_buffer_select_range(buffer, ins, bound);
		return buffer;
	}

	public static IntPtr Serialize(this GtkTextBufferHandle register_buffer, GtkTextBufferHandle content_buffer, GdkAtom format, GtkTextIterHandle start, GtkTextIterHandle end, out UIntPtr length)
	{
		return GtkTextBufferExterns.gtk_text_buffer_serialize(register_buffer, content_buffer, format, start, end, out length);
	}

	public static GtkTextBufferHandle SetModified(this GtkTextBufferHandle buffer, bool setting)
	{
		GtkTextBufferExterns.gtk_text_buffer_set_modified(buffer, setting);
		return buffer;
	}

	public static GtkTextBufferHandle SetText(this GtkTextBufferHandle buffer, string text, int len)
	{
		GtkTextBufferExterns.gtk_text_buffer_set_text(buffer, text, len);
		return buffer;
	}

	public static GtkTextBufferHandle UnregisterDeserializeFormat(this GtkTextBufferHandle buffer, GdkAtom format)
	{
		GtkTextBufferExterns.gtk_text_buffer_unregister_deserialize_format(buffer, format);
		return buffer;
	}

	public static GtkTextBufferHandle UnregisterSerializeFormat(this GtkTextBufferHandle buffer, GdkAtom format)
	{
		GtkTextBufferExterns.gtk_text_buffer_unregister_serialize_format(buffer, format);
		return buffer;
	}

}

internal class GtkTextBufferExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTextBufferHandle gtk_text_buffer_new(GtkTextTagTableHandle table);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_add_mark(GtkTextBufferHandle buffer, GtkTextMarkHandle mark, GtkTextIterHandle where);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_add_selection_clipboard(GtkTextBufferHandle buffer, GtkClipboardHandle clipboard);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_apply_tag(GtkTextBufferHandle buffer, GtkTextTagHandle tag, GtkTextIterHandle start, GtkTextIterHandle end);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_apply_tag_by_name(GtkTextBufferHandle buffer, string name, GtkTextIterHandle start, GtkTextIterHandle end);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_text_buffer_backspace(GtkTextBufferHandle buffer, GtkTextIterHandle iter, bool interactive, bool default_editable);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_begin_user_action(GtkTextBufferHandle buffer);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_copy_clipboard(GtkTextBufferHandle buffer, GtkClipboardHandle clipboard);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTextChildAnchorHandle gtk_text_buffer_create_child_anchor(GtkTextBufferHandle buffer, GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTextMarkHandle gtk_text_buffer_create_mark(GtkTextBufferHandle buffer, string mark_name, GtkTextIterHandle where, bool left_gravity);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTextTagHandle gtk_text_buffer_create_tag(GtkTextBufferHandle buffer, string tag_name, string first_property_name, IntPtr @__arglist);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_cut_clipboard(GtkTextBufferHandle buffer, GtkClipboardHandle clipboard, bool default_editable);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_delete(GtkTextBufferHandle buffer, GtkTextIterHandle start, GtkTextIterHandle end);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_text_buffer_delete_interactive(GtkTextBufferHandle buffer, GtkTextIterHandle start_iter, GtkTextIterHandle end_iter, bool default_editable);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_delete_mark(GtkTextBufferHandle buffer, GtkTextMarkHandle mark);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_delete_mark_by_name(GtkTextBufferHandle buffer, string name);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_text_buffer_delete_selection(GtkTextBufferHandle buffer, bool interactive, bool default_editable);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_text_buffer_deserialize(GtkTextBufferHandle register_buffer, GtkTextBufferHandle content_buffer, GdkAtom format, GtkTextIterHandle iter, byte[] data, UIntPtr length, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_text_buffer_deserialize_get_can_create_tags(GtkTextBufferHandle buffer, GdkAtom format);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_deserialize_set_can_create_tags(GtkTextBufferHandle buffer, GdkAtom format, bool can_create_tags);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_end_user_action(GtkTextBufferHandle buffer);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_get_bounds(GtkTextBufferHandle buffer, out GtkTextIter start, out GtkTextIter end);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_text_buffer_get_char_count(GtkTextBufferHandle buffer);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTargetListHandle gtk_text_buffer_get_copy_target_list(GtkTextBufferHandle buffer);

	[DllImport(Libraries.Gtk3)]
	internal static extern IntPtr gtk_text_buffer_get_deserialize_formats(GtkTextBufferHandle buffer, out int n_formats);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_get_end_iter(GtkTextBufferHandle buffer, out GtkTextIter iter);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_text_buffer_get_has_selection(GtkTextBufferHandle buffer);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTextMarkHandle gtk_text_buffer_get_insert(GtkTextBufferHandle buffer);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_get_iter_at_child_anchor(GtkTextBufferHandle buffer, out GtkTextIter iter, GtkTextChildAnchorHandle anchor);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_get_iter_at_line(GtkTextBufferHandle buffer, out GtkTextIter iter, int line_number);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_get_iter_at_line_index(GtkTextBufferHandle buffer, out GtkTextIter iter, int line_number, int byte_index);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_get_iter_at_line_offset(GtkTextBufferHandle buffer, out GtkTextIter iter, int line_number, int char_offset);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_get_iter_at_mark(GtkTextBufferHandle buffer, out GtkTextIter iter, GtkTextMarkHandle mark);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_get_iter_at_offset(GtkTextBufferHandle buffer, out GtkTextIter iter, int char_offset);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_text_buffer_get_line_count(GtkTextBufferHandle buffer);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTextMarkHandle gtk_text_buffer_get_mark(GtkTextBufferHandle buffer, string name);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_text_buffer_get_modified(GtkTextBufferHandle buffer);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTargetListHandle gtk_text_buffer_get_paste_target_list(GtkTextBufferHandle buffer);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTextMarkHandle gtk_text_buffer_get_selection_bound(GtkTextBufferHandle buffer);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_text_buffer_get_selection_bounds(GtkTextBufferHandle buffer, out GtkTextIter start, out GtkTextIter end);

	[DllImport(Libraries.Gtk3)]
	internal static extern IntPtr gtk_text_buffer_get_serialize_formats(GtkTextBufferHandle buffer, out int n_formats);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_text_buffer_get_slice(GtkTextBufferHandle buffer, GtkTextIterHandle start, GtkTextIterHandle end, bool include_hidden_chars);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_get_start_iter(GtkTextBufferHandle buffer, out GtkTextIter iter);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTextTagTableHandle gtk_text_buffer_get_tag_table(GtkTextBufferHandle buffer);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_text_buffer_get_text(GtkTextBufferHandle buffer, GtkTextIterHandle start, GtkTextIterHandle end, bool include_hidden_chars);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_insert(GtkTextBufferHandle buffer, GtkTextIterHandle iter, string text, int len);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_insert_at_cursor(GtkTextBufferHandle buffer, string text, int len);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_insert_child_anchor(GtkTextBufferHandle buffer, GtkTextIterHandle iter, GtkTextChildAnchorHandle anchor);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_text_buffer_insert_interactive(GtkTextBufferHandle buffer, GtkTextIterHandle iter, string text, int len, bool default_editable);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_text_buffer_insert_interactive_at_cursor(GtkTextBufferHandle buffer, string text, int len, bool default_editable);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_insert_markup(GtkTextBufferHandle buffer, GtkTextIterHandle iter, string markup, int len);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_insert_pixbuf(GtkTextBufferHandle buffer, GtkTextIterHandle iter, GdkPixbufHandle pixbuf);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_insert_range(GtkTextBufferHandle buffer, GtkTextIterHandle iter, GtkTextIterHandle start, GtkTextIterHandle end);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_text_buffer_insert_range_interactive(GtkTextBufferHandle buffer, GtkTextIterHandle iter, GtkTextIterHandle start, GtkTextIterHandle end, bool default_editable);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_insert_with_tags(GtkTextBufferHandle buffer, GtkTextIterHandle iter, string text, int len, GtkTextTagHandle first_tag, IntPtr @__arglist);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_insert_with_tags_by_name(GtkTextBufferHandle buffer, GtkTextIterHandle iter, string text, int len, string first_tag_name, IntPtr @__arglist);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_move_mark(GtkTextBufferHandle buffer, GtkTextMarkHandle mark, GtkTextIterHandle where);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_move_mark_by_name(GtkTextBufferHandle buffer, string name, GtkTextIterHandle where);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_paste_clipboard(GtkTextBufferHandle buffer, GtkClipboardHandle clipboard, GtkTextIterHandle override_location, bool default_editable);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_place_cursor(GtkTextBufferHandle buffer, GtkTextIterHandle where);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkAtom gtk_text_buffer_register_deserialize_format(GtkTextBufferHandle buffer, string mime_type, GtkTextBufferDeserializeFunc function, IntPtr user_data, GDestroyNotify user_data_destroy);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkAtom gtk_text_buffer_register_deserialize_tagset(GtkTextBufferHandle buffer, string tagset_name);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkAtom gtk_text_buffer_register_serialize_format(GtkTextBufferHandle buffer, string mime_type, GtkTextBufferSerializeFunc function, IntPtr user_data, GDestroyNotify user_data_destroy);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkAtom gtk_text_buffer_register_serialize_tagset(GtkTextBufferHandle buffer, string tagset_name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_remove_all_tags(GtkTextBufferHandle buffer, GtkTextIterHandle start, GtkTextIterHandle end);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_remove_selection_clipboard(GtkTextBufferHandle buffer, GtkClipboardHandle clipboard);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_remove_tag(GtkTextBufferHandle buffer, GtkTextTagHandle tag, GtkTextIterHandle start, GtkTextIterHandle end);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_remove_tag_by_name(GtkTextBufferHandle buffer, string name, GtkTextIterHandle start, GtkTextIterHandle end);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_select_range(GtkTextBufferHandle buffer, GtkTextIterHandle ins, GtkTextIterHandle bound);

	[DllImport(Libraries.Gtk3)]
	internal static extern IntPtr gtk_text_buffer_serialize(GtkTextBufferHandle register_buffer, GtkTextBufferHandle content_buffer, GdkAtom format, GtkTextIterHandle start, GtkTextIterHandle end, out UIntPtr length);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_set_modified(GtkTextBufferHandle buffer, bool setting);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_set_text(GtkTextBufferHandle buffer, string text, int len);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_unregister_deserialize_format(GtkTextBufferHandle buffer, GdkAtom format);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_buffer_unregister_serialize_format(GtkTextBufferHandle buffer, GdkAtom format);

}
