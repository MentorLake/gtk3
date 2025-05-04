namespace MentorLake.Gtk;

public class GtkTextBufferHandle : GObjectHandle
{
	public static MentorLake.Gtk.GtkTextBufferHandle New(MentorLake.Gtk.GtkTextTagTableHandle table)
	{
		return GtkTextBufferHandleExterns.gtk_text_buffer_new(table);
	}

}
public static class GtkTextBufferHandleSignalExtensions
{

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
	public MentorLake.Gtk.GtkTextTagHandle Tag;
	public MentorLake.Gtk.GtkTextIterHandle Start;
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
	public MentorLake.Gtk.GtkTextIterHandle Start;
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
	public MentorLake.Gtk.GtkTextIterHandle Location;
	public MentorLake.Gtk.GtkTextChildAnchorHandle Anchor;
	public IntPtr UserData;
}

public class InsertPixbufSignal
{
	public MentorLake.Gtk.GtkTextBufferHandle Self;
	public MentorLake.Gtk.GtkTextIterHandle Location;
	public MentorLake.GdkPixbuf.GdkPixbufHandle Pixbuf;
	public IntPtr UserData;
}

public class InsertTextSignal
{
	public MentorLake.Gtk.GtkTextBufferHandle Self;
	public MentorLake.Gtk.GtkTextIterHandle Location;
	public string Text;
	public int Len;
	public IntPtr UserData;
}

public class MarkDeletedSignal
{
	public MentorLake.Gtk.GtkTextBufferHandle Self;
	public MentorLake.Gtk.GtkTextMarkHandle Mark;
	public IntPtr UserData;
}

public class MarkSetSignal
{
	public MentorLake.Gtk.GtkTextBufferHandle Self;
	public MentorLake.Gtk.GtkTextIterHandle Location;
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
	public MentorLake.Gtk.GtkClipboardHandle Clipboard;
	public IntPtr UserData;
}

public class RemoveTagSignal
{
	public MentorLake.Gtk.GtkTextBufferHandle Self;
	public MentorLake.Gtk.GtkTextTagHandle Tag;
	public MentorLake.Gtk.GtkTextIterHandle Start;
	public MentorLake.Gtk.GtkTextIterHandle End;
	public IntPtr UserData;
}
}

public static class GtkTextBufferHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void apply_tag([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagHandle>))] MentorLake.Gtk.GtkTextTagHandle tag, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle start, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle end, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void begin_user_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void delete_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle start, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle end, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void end_user_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void insert_child_anchor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle location, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextChildAnchorHandle>))] MentorLake.Gtk.GtkTextChildAnchorHandle anchor, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void insert_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle location, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void insert_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle location, string text, int len, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void mark_deleted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextMarkHandle>))] MentorLake.Gtk.GtkTextMarkHandle mark, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void mark_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle location, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextMarkHandle>))] MentorLake.Gtk.GtkTextMarkHandle mark, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void modified_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void paste_done([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void remove_tag([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagHandle>))] MentorLake.Gtk.GtkTextTagHandle tag, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle start, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle end, IntPtr user_data);

}


public static class GtkTextBufferHandleExtensions
{
	public static T AddMark<T>(this T buffer, MentorLake.Gtk.GtkTextMarkHandle mark, MentorLake.Gtk.GtkTextIterHandle where) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_add_mark(buffer, mark, where);
		return buffer;
	}

	public static T AddSelectionClipboard<T>(this T buffer, MentorLake.Gtk.GtkClipboardHandle clipboard) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_add_selection_clipboard(buffer, clipboard);
		return buffer;
	}

	public static T ApplyTag<T>(this T buffer, MentorLake.Gtk.GtkTextTagHandle tag, MentorLake.Gtk.GtkTextIterHandle start, MentorLake.Gtk.GtkTextIterHandle end) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_apply_tag(buffer, tag, start, end);
		return buffer;
	}

	public static T ApplyTagByName<T>(this T buffer, string name, MentorLake.Gtk.GtkTextIterHandle start, MentorLake.Gtk.GtkTextIterHandle end) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_apply_tag_by_name(buffer, name, start, end);
		return buffer;
	}

	public static bool Backspace(this MentorLake.Gtk.GtkTextBufferHandle buffer, MentorLake.Gtk.GtkTextIterHandle iter, bool interactive, bool default_editable)
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_backspace(buffer, iter, interactive, default_editable);
	}

	public static T BeginUserAction<T>(this T buffer) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_begin_user_action(buffer);
		return buffer;
	}

	public static T CopyClipboard<T>(this T buffer, MentorLake.Gtk.GtkClipboardHandle clipboard) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_copy_clipboard(buffer, clipboard);
		return buffer;
	}

	public static MentorLake.Gtk.GtkTextChildAnchorHandle CreateChildAnchor(this MentorLake.Gtk.GtkTextBufferHandle buffer, MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_create_child_anchor(buffer, iter);
	}

	public static MentorLake.Gtk.GtkTextMarkHandle CreateMark(this MentorLake.Gtk.GtkTextBufferHandle buffer, string mark_name, MentorLake.Gtk.GtkTextIterHandle where, bool left_gravity)
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_create_mark(buffer, mark_name, where, left_gravity);
	}

	public static MentorLake.Gtk.GtkTextTagHandle CreateTag(this MentorLake.Gtk.GtkTextBufferHandle buffer, string tag_name, string first_property_name, IntPtr @__arglist)
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_create_tag(buffer, tag_name, first_property_name, @__arglist);
	}

	public static T CutClipboard<T>(this T buffer, MentorLake.Gtk.GtkClipboardHandle clipboard, bool default_editable) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_cut_clipboard(buffer, clipboard, default_editable);
		return buffer;
	}

	public static T Delete<T>(this T buffer, MentorLake.Gtk.GtkTextIterHandle start, MentorLake.Gtk.GtkTextIterHandle end) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_delete(buffer, start, end);
		return buffer;
	}

	public static bool DeleteInteractive(this MentorLake.Gtk.GtkTextBufferHandle buffer, MentorLake.Gtk.GtkTextIterHandle start_iter, MentorLake.Gtk.GtkTextIterHandle end_iter, bool default_editable)
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_delete_interactive(buffer, start_iter, end_iter, default_editable);
	}

	public static T DeleteMark<T>(this T buffer, MentorLake.Gtk.GtkTextMarkHandle mark) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_delete_mark(buffer, mark);
		return buffer;
	}

	public static T DeleteMarkByName<T>(this T buffer, string name) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_delete_mark_by_name(buffer, name);
		return buffer;
	}

	public static bool DeleteSelection(this MentorLake.Gtk.GtkTextBufferHandle buffer, bool interactive, bool default_editable)
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_delete_selection(buffer, interactive, default_editable);
	}

	public static bool Deserialize(this MentorLake.Gtk.GtkTextBufferHandle register_buffer, MentorLake.Gtk.GtkTextBufferHandle content_buffer, MentorLake.Gdk.GdkAtom format, MentorLake.Gtk.GtkTextIterHandle iter, byte[] data, UIntPtr length)
	{
		if (register_buffer.IsInvalid || register_buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		var externCallResult = GtkTextBufferHandleExterns.gtk_text_buffer_deserialize(register_buffer, content_buffer, format, iter, data, length, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool DeserializeGetCanCreateTags(this MentorLake.Gtk.GtkTextBufferHandle buffer, MentorLake.Gdk.GdkAtom format)
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_deserialize_get_can_create_tags(buffer, format);
	}

	public static T DeserializeSetCanCreateTags<T>(this T buffer, MentorLake.Gdk.GdkAtom format, bool can_create_tags) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_deserialize_set_can_create_tags(buffer, format, can_create_tags);
		return buffer;
	}

	public static T EndUserAction<T>(this T buffer) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_end_user_action(buffer);
		return buffer;
	}

	public static T GetBounds<T>(this T buffer, out MentorLake.Gtk.GtkTextIter start, out MentorLake.Gtk.GtkTextIter end) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_get_bounds(buffer, out start, out end);
		return buffer;
	}

	public static int GetCharCount(this MentorLake.Gtk.GtkTextBufferHandle buffer)
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_get_char_count(buffer);
	}

	public static MentorLake.Gtk.GtkTargetListHandle GetCopyTargetList(this MentorLake.Gtk.GtkTextBufferHandle buffer)
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_get_copy_target_list(buffer);
	}

	public static MentorLake.Gdk.GdkAtom[] GetDeserializeFormats(this MentorLake.Gtk.GtkTextBufferHandle buffer, out int n_formats)
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_get_deserialize_formats(buffer, out n_formats);
	}

	public static T GetEndIter<T>(this T buffer, out MentorLake.Gtk.GtkTextIter iter) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_get_end_iter(buffer, out iter);
		return buffer;
	}

	public static bool GetHasSelection(this MentorLake.Gtk.GtkTextBufferHandle buffer)
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_get_has_selection(buffer);
	}

	public static MentorLake.Gtk.GtkTextMarkHandle GetInsert(this MentorLake.Gtk.GtkTextBufferHandle buffer)
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_get_insert(buffer);
	}

	public static T GetIterAtChildAnchor<T>(this T buffer, out MentorLake.Gtk.GtkTextIter iter, MentorLake.Gtk.GtkTextChildAnchorHandle anchor) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_get_iter_at_child_anchor(buffer, out iter, anchor);
		return buffer;
	}

	public static T GetIterAtLine<T>(this T buffer, out MentorLake.Gtk.GtkTextIter iter, int line_number) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_get_iter_at_line(buffer, out iter, line_number);
		return buffer;
	}

	public static T GetIterAtLineIndex<T>(this T buffer, out MentorLake.Gtk.GtkTextIter iter, int line_number, int byte_index) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_get_iter_at_line_index(buffer, out iter, line_number, byte_index);
		return buffer;
	}

	public static T GetIterAtLineOffset<T>(this T buffer, out MentorLake.Gtk.GtkTextIter iter, int line_number, int char_offset) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_get_iter_at_line_offset(buffer, out iter, line_number, char_offset);
		return buffer;
	}

	public static T GetIterAtMark<T>(this T buffer, out MentorLake.Gtk.GtkTextIter iter, MentorLake.Gtk.GtkTextMarkHandle mark) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_get_iter_at_mark(buffer, out iter, mark);
		return buffer;
	}

	public static T GetIterAtOffset<T>(this T buffer, out MentorLake.Gtk.GtkTextIter iter, int char_offset) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_get_iter_at_offset(buffer, out iter, char_offset);
		return buffer;
	}

	public static int GetLineCount(this MentorLake.Gtk.GtkTextBufferHandle buffer)
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_get_line_count(buffer);
	}

	public static MentorLake.Gtk.GtkTextMarkHandle GetMark(this MentorLake.Gtk.GtkTextBufferHandle buffer, string name)
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_get_mark(buffer, name);
	}

	public static bool GetModified(this MentorLake.Gtk.GtkTextBufferHandle buffer)
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_get_modified(buffer);
	}

	public static MentorLake.Gtk.GtkTargetListHandle GetPasteTargetList(this MentorLake.Gtk.GtkTextBufferHandle buffer)
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_get_paste_target_list(buffer);
	}

	public static MentorLake.Gtk.GtkTextMarkHandle GetSelectionBound(this MentorLake.Gtk.GtkTextBufferHandle buffer)
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_get_selection_bound(buffer);
	}

	public static bool GetSelectionBounds(this MentorLake.Gtk.GtkTextBufferHandle buffer, out MentorLake.Gtk.GtkTextIter start, out MentorLake.Gtk.GtkTextIter end)
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_get_selection_bounds(buffer, out start, out end);
	}

	public static MentorLake.Gdk.GdkAtom[] GetSerializeFormats(this MentorLake.Gtk.GtkTextBufferHandle buffer, out int n_formats)
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_get_serialize_formats(buffer, out n_formats);
	}

	public static string GetSlice(this MentorLake.Gtk.GtkTextBufferHandle buffer, MentorLake.Gtk.GtkTextIterHandle start, MentorLake.Gtk.GtkTextIterHandle end, bool include_hidden_chars)
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_get_slice(buffer, start, end, include_hidden_chars);
	}

	public static T GetStartIter<T>(this T buffer, out MentorLake.Gtk.GtkTextIter iter) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_get_start_iter(buffer, out iter);
		return buffer;
	}

	public static MentorLake.Gtk.GtkTextTagTableHandle GetTagTable(this MentorLake.Gtk.GtkTextBufferHandle buffer)
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_get_tag_table(buffer);
	}

	public static string GetText(this MentorLake.Gtk.GtkTextBufferHandle buffer, MentorLake.Gtk.GtkTextIterHandle start, MentorLake.Gtk.GtkTextIterHandle end, bool include_hidden_chars)
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_get_text(buffer, start, end, include_hidden_chars);
	}

	public static T Insert<T>(this T buffer, MentorLake.Gtk.GtkTextIterHandle iter, string text, int len) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_insert(buffer, iter, text, len);
		return buffer;
	}

	public static T InsertAtCursor<T>(this T buffer, string text, int len) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_insert_at_cursor(buffer, text, len);
		return buffer;
	}

	public static T InsertChildAnchor<T>(this T buffer, MentorLake.Gtk.GtkTextIterHandle iter, MentorLake.Gtk.GtkTextChildAnchorHandle anchor) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_insert_child_anchor(buffer, iter, anchor);
		return buffer;
	}

	public static bool InsertInteractive(this MentorLake.Gtk.GtkTextBufferHandle buffer, MentorLake.Gtk.GtkTextIterHandle iter, string text, int len, bool default_editable)
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_insert_interactive(buffer, iter, text, len, default_editable);
	}

	public static bool InsertInteractiveAtCursor(this MentorLake.Gtk.GtkTextBufferHandle buffer, string text, int len, bool default_editable)
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_insert_interactive_at_cursor(buffer, text, len, default_editable);
	}

	public static T InsertMarkup<T>(this T buffer, MentorLake.Gtk.GtkTextIterHandle iter, string markup, int len) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_insert_markup(buffer, iter, markup, len);
		return buffer;
	}

	public static T InsertPixbuf<T>(this T buffer, MentorLake.Gtk.GtkTextIterHandle iter, MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_insert_pixbuf(buffer, iter, pixbuf);
		return buffer;
	}

	public static T InsertRange<T>(this T buffer, MentorLake.Gtk.GtkTextIterHandle iter, MentorLake.Gtk.GtkTextIterHandle start, MentorLake.Gtk.GtkTextIterHandle end) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_insert_range(buffer, iter, start, end);
		return buffer;
	}

	public static bool InsertRangeInteractive(this MentorLake.Gtk.GtkTextBufferHandle buffer, MentorLake.Gtk.GtkTextIterHandle iter, MentorLake.Gtk.GtkTextIterHandle start, MentorLake.Gtk.GtkTextIterHandle end, bool default_editable)
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_insert_range_interactive(buffer, iter, start, end, default_editable);
	}

	public static T InsertWithTags<T>(this T buffer, MentorLake.Gtk.GtkTextIterHandle iter, string text, int len, MentorLake.Gtk.GtkTextTagHandle first_tag, IntPtr @__arglist) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_insert_with_tags(buffer, iter, text, len, first_tag, @__arglist);
		return buffer;
	}

	public static T InsertWithTagsByName<T>(this T buffer, MentorLake.Gtk.GtkTextIterHandle iter, string text, int len, string first_tag_name, IntPtr @__arglist) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_insert_with_tags_by_name(buffer, iter, text, len, first_tag_name, @__arglist);
		return buffer;
	}

	public static T MoveMark<T>(this T buffer, MentorLake.Gtk.GtkTextMarkHandle mark, MentorLake.Gtk.GtkTextIterHandle where) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_move_mark(buffer, mark, where);
		return buffer;
	}

	public static T MoveMarkByName<T>(this T buffer, string name, MentorLake.Gtk.GtkTextIterHandle where) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_move_mark_by_name(buffer, name, where);
		return buffer;
	}

	public static T PasteClipboard<T>(this T buffer, MentorLake.Gtk.GtkClipboardHandle clipboard, MentorLake.Gtk.GtkTextIterHandle override_location, bool default_editable) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_paste_clipboard(buffer, clipboard, override_location, default_editable);
		return buffer;
	}

	public static T PlaceCursor<T>(this T buffer, MentorLake.Gtk.GtkTextIterHandle where) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_place_cursor(buffer, where);
		return buffer;
	}

	public static MentorLake.Gdk.GdkAtom RegisterDeserializeFormat(this MentorLake.Gtk.GtkTextBufferHandle buffer, string mime_type, MentorLake.Gtk.GtkTextBufferDeserializeFunc function, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_destroy)
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_register_deserialize_format(buffer, mime_type, function, user_data, user_data_destroy);
	}

	public static MentorLake.Gdk.GdkAtom RegisterDeserializeTagset(this MentorLake.Gtk.GtkTextBufferHandle buffer, string tagset_name)
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_register_deserialize_tagset(buffer, tagset_name);
	}

	public static MentorLake.Gdk.GdkAtom RegisterSerializeFormat(this MentorLake.Gtk.GtkTextBufferHandle buffer, string mime_type, MentorLake.Gtk.GtkTextBufferSerializeFunc function, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_destroy)
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_register_serialize_format(buffer, mime_type, function, user_data, user_data_destroy);
	}

	public static MentorLake.Gdk.GdkAtom RegisterSerializeTagset(this MentorLake.Gtk.GtkTextBufferHandle buffer, string tagset_name)
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_register_serialize_tagset(buffer, tagset_name);
	}

	public static T RemoveAllTags<T>(this T buffer, MentorLake.Gtk.GtkTextIterHandle start, MentorLake.Gtk.GtkTextIterHandle end) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_remove_all_tags(buffer, start, end);
		return buffer;
	}

	public static T RemoveSelectionClipboard<T>(this T buffer, MentorLake.Gtk.GtkClipboardHandle clipboard) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_remove_selection_clipboard(buffer, clipboard);
		return buffer;
	}

	public static T RemoveTag<T>(this T buffer, MentorLake.Gtk.GtkTextTagHandle tag, MentorLake.Gtk.GtkTextIterHandle start, MentorLake.Gtk.GtkTextIterHandle end) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_remove_tag(buffer, tag, start, end);
		return buffer;
	}

	public static T RemoveTagByName<T>(this T buffer, string name, MentorLake.Gtk.GtkTextIterHandle start, MentorLake.Gtk.GtkTextIterHandle end) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_remove_tag_by_name(buffer, name, start, end);
		return buffer;
	}

	public static T SelectRange<T>(this T buffer, MentorLake.Gtk.GtkTextIterHandle ins, MentorLake.Gtk.GtkTextIterHandle bound) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_select_range(buffer, ins, bound);
		return buffer;
	}

	public static byte[] Serialize(this MentorLake.Gtk.GtkTextBufferHandle register_buffer, MentorLake.Gtk.GtkTextBufferHandle content_buffer, MentorLake.Gdk.GdkAtom format, MentorLake.Gtk.GtkTextIterHandle start, MentorLake.Gtk.GtkTextIterHandle end, out UIntPtr length)
	{
		if (register_buffer.IsInvalid || register_buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		return GtkTextBufferHandleExterns.gtk_text_buffer_serialize(register_buffer, content_buffer, format, start, end, out length);
	}

	public static T SetModified<T>(this T buffer, bool setting) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_set_modified(buffer, setting);
		return buffer;
	}

	public static T SetText<T>(this T buffer, string text, int len) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_set_text(buffer, text, len);
		return buffer;
	}

	public static T UnregisterDeserializeFormat<T>(this T buffer, MentorLake.Gdk.GdkAtom format) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_unregister_deserialize_format(buffer, format);
		return buffer;
	}

	public static T UnregisterSerializeFormat<T>(this T buffer, MentorLake.Gdk.GdkAtom format) where T : GtkTextBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkTextBufferHandle)");
		GtkTextBufferHandleExterns.gtk_text_buffer_unregister_serialize_format(buffer, format);
		return buffer;
	}

}

internal class GtkTextBufferHandleExterns
{
	[DllImport(GtkLibrary.Name)]
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
	internal static extern MentorLake.Gtk.GtkTextChildAnchorHandle gtk_text_buffer_create_child_anchor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTextMarkHandle gtk_text_buffer_create_mark([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, string mark_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle where, bool left_gravity);

	[DllImport(GtkLibrary.Name)]
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
	internal static extern MentorLake.Gtk.GtkTargetListHandle gtk_text_buffer_get_copy_target_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkAtom[] gtk_text_buffer_get_deserialize_formats([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, out int n_formats);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_buffer_get_end_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, out MentorLake.Gtk.GtkTextIter iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_buffer_get_has_selection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer);

	[DllImport(GtkLibrary.Name)]
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
	internal static extern MentorLake.Gtk.GtkTextMarkHandle gtk_text_buffer_get_mark([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer, string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_buffer_get_modified([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTargetListHandle gtk_text_buffer_get_paste_target_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer);

	[DllImport(GtkLibrary.Name)]
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
