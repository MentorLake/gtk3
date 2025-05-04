namespace MentorLake.Gtk;

public class GtkEntryBufferHandle : GObjectHandle
{
	public static MentorLake.Gtk.GtkEntryBufferHandle New(string initial_chars, int n_initial_chars)
	{
		return GtkEntryBufferHandleExterns.gtk_entry_buffer_new(initial_chars, n_initial_chars);
	}

}
public static class GtkEntryBufferHandleSignalExtensions
{

	public static IObservable<GtkEntryBufferHandleSignalStructs.DeletedTextSignal> Signal_DeletedText(this GtkEntryBufferHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEntryBufferHandleSignalStructs.DeletedTextSignal> obs) =>
		{
			GtkEntryBufferHandleSignalDelegates.deleted_text handler = ( MentorLake.Gtk.GtkEntryBufferHandle self,  uint position,  uint n_chars,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryBufferHandleSignalStructs.DeletedTextSignal()
				{
					Self = self, Position = position, NChars = n_chars, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "deleted-text", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkEntryBufferHandleSignalStructs.InsertedTextSignal> Signal_InsertedText(this GtkEntryBufferHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEntryBufferHandleSignalStructs.InsertedTextSignal> obs) =>
		{
			GtkEntryBufferHandleSignalDelegates.inserted_text handler = ( MentorLake.Gtk.GtkEntryBufferHandle self,  uint position,  string chars,  uint n_chars,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryBufferHandleSignalStructs.InsertedTextSignal()
				{
					Self = self, Position = position, Chars = chars, NChars = n_chars, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "inserted-text", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkEntryBufferHandleSignalStructs
{

public class DeletedTextSignal
{
	public MentorLake.Gtk.GtkEntryBufferHandle Self;
	public uint Position;
	public uint NChars;
	public IntPtr UserData;
}

public class InsertedTextSignal
{
	public MentorLake.Gtk.GtkEntryBufferHandle Self;
	public uint Position;
	public string Chars;
	public uint NChars;
	public IntPtr UserData;
}
}

public static class GtkEntryBufferHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void deleted_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryBufferHandle>))] MentorLake.Gtk.GtkEntryBufferHandle self, uint position, uint n_chars, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void inserted_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryBufferHandle>))] MentorLake.Gtk.GtkEntryBufferHandle self, uint position, string chars, uint n_chars, IntPtr user_data);

}


public static class GtkEntryBufferHandleExtensions
{
	public static uint DeleteText(this MentorLake.Gtk.GtkEntryBufferHandle buffer, uint position, int n_chars)
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryBufferHandle)");
		return GtkEntryBufferHandleExterns.gtk_entry_buffer_delete_text(buffer, position, n_chars);
	}

	public static T EmitDeletedText<T>(this T buffer, uint position, uint n_chars) where T : GtkEntryBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryBufferHandle)");
		GtkEntryBufferHandleExterns.gtk_entry_buffer_emit_deleted_text(buffer, position, n_chars);
		return buffer;
	}

	public static T EmitInsertedText<T>(this T buffer, uint position, string chars, uint n_chars) where T : GtkEntryBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryBufferHandle)");
		GtkEntryBufferHandleExterns.gtk_entry_buffer_emit_inserted_text(buffer, position, chars, n_chars);
		return buffer;
	}

	public static UIntPtr GetBytes(this MentorLake.Gtk.GtkEntryBufferHandle buffer)
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryBufferHandle)");
		return GtkEntryBufferHandleExterns.gtk_entry_buffer_get_bytes(buffer);
	}

	public static uint GetLength(this MentorLake.Gtk.GtkEntryBufferHandle buffer)
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryBufferHandle)");
		return GtkEntryBufferHandleExterns.gtk_entry_buffer_get_length(buffer);
	}

	public static int GetMaxLength(this MentorLake.Gtk.GtkEntryBufferHandle buffer)
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryBufferHandle)");
		return GtkEntryBufferHandleExterns.gtk_entry_buffer_get_max_length(buffer);
	}

	public static string GetText(this MentorLake.Gtk.GtkEntryBufferHandle buffer)
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryBufferHandle)");
		return GtkEntryBufferHandleExterns.gtk_entry_buffer_get_text(buffer);
	}

	public static uint InsertText(this MentorLake.Gtk.GtkEntryBufferHandle buffer, uint position, string chars, int n_chars)
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryBufferHandle)");
		return GtkEntryBufferHandleExterns.gtk_entry_buffer_insert_text(buffer, position, chars, n_chars);
	}

	public static T SetMaxLength<T>(this T buffer, int max_length) where T : GtkEntryBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryBufferHandle)");
		GtkEntryBufferHandleExterns.gtk_entry_buffer_set_max_length(buffer, max_length);
		return buffer;
	}

	public static T SetText<T>(this T buffer, string chars, int n_chars) where T : GtkEntryBufferHandle
	{
		if (buffer.IsInvalid || buffer.IsClosed) throw new Exception("Invalid or closed handle (GtkEntryBufferHandle)");
		GtkEntryBufferHandleExterns.gtk_entry_buffer_set_text(buffer, chars, n_chars);
		return buffer;
	}

}

internal class GtkEntryBufferHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkEntryBufferHandle gtk_entry_buffer_new(string initial_chars, int n_initial_chars);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_entry_buffer_delete_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryBufferHandle>))] MentorLake.Gtk.GtkEntryBufferHandle buffer, uint position, int n_chars);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_buffer_emit_deleted_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryBufferHandle>))] MentorLake.Gtk.GtkEntryBufferHandle buffer, uint position, uint n_chars);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_buffer_emit_inserted_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryBufferHandle>))] MentorLake.Gtk.GtkEntryBufferHandle buffer, uint position, string chars, uint n_chars);

	[DllImport(GtkLibrary.Name)]
	internal static extern UIntPtr gtk_entry_buffer_get_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryBufferHandle>))] MentorLake.Gtk.GtkEntryBufferHandle buffer);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_entry_buffer_get_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryBufferHandle>))] MentorLake.Gtk.GtkEntryBufferHandle buffer);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_entry_buffer_get_max_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryBufferHandle>))] MentorLake.Gtk.GtkEntryBufferHandle buffer);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_entry_buffer_get_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryBufferHandle>))] MentorLake.Gtk.GtkEntryBufferHandle buffer);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_entry_buffer_insert_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryBufferHandle>))] MentorLake.Gtk.GtkEntryBufferHandle buffer, uint position, string chars, int n_chars);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_buffer_set_max_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryBufferHandle>))] MentorLake.Gtk.GtkEntryBufferHandle buffer, int max_length);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_buffer_set_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryBufferHandle>))] MentorLake.Gtk.GtkEntryBufferHandle buffer, string chars, int n_chars);

}
