namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkEntryBuffer class contains the actual text displayed in a
/// #GtkEntry widget.
/// </para>
/// <para>
/// A single #GtkEntryBuffer object can be shared by multiple #GtkEntry
/// widgets which will then share the same text content, but not the cursor
/// position, visibility attributes, icon etc.
/// </para>
/// <para>
/// #GtkEntryBuffer may be derived from. Such a derived class might allow
/// text to be stored in an alternate location, such as non-pageable memory,
/// useful in the case of important passwords. Or a derived class could
/// integrate with an application’s concept of undo/redo.
/// </para>
/// </summary>

public class GtkEntryBufferHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Create a new GtkEntryBuffer object.
/// </para>
/// <para>
/// Optionally, specify initial text to set in the buffer.
/// </para>
/// </summary>

/// <param name="initial_chars">
/// initial buffer text, or %NULL
/// </param>
/// <param name="n_initial_chars">
/// number of characters in @initial_chars, or -1
/// </param>
/// <return>
/// A new GtkEntryBuffer object.
/// </return>

	public static MentorLake.Gtk.GtkEntryBufferHandle New(string initial_chars, int n_initial_chars)
	{
		return GtkEntryBufferHandleExterns.gtk_entry_buffer_new(initial_chars, n_initial_chars);
	}

}
public static class GtkEntryBufferHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted after text is deleted from the buffer.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// This signal is emitted after text is inserted into the buffer.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// the position the text was deleted at.
/// </para>
/// </summary>

	public uint Position;
/// <summary>
/// <para>
/// The number of characters that were deleted.
/// </para>
/// </summary>

	public uint NChars;

	public IntPtr UserData;
}

public class InsertedTextSignal
{

	public MentorLake.Gtk.GtkEntryBufferHandle Self;
/// <summary>
/// <para>
/// the position the text was inserted at.
/// </para>
/// </summary>

	public uint Position;
/// <summary>
/// <para>
/// The text that was inserted.
/// </para>
/// </summary>

	public string Chars;
/// <summary>
/// <para>
/// The number of characters that were inserted.
/// </para>
/// </summary>

	public uint NChars;

	public IntPtr UserData;
}
}

public static class GtkEntryBufferHandleSignalDelegates
{

/// <summary>
/// <para>
/// This signal is emitted after text is deleted from the buffer.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="position">
/// the position the text was deleted at.
/// </param>
/// <param name="n_chars">
/// The number of characters that were deleted.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void deleted_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryBufferHandle>))] MentorLake.Gtk.GtkEntryBufferHandle self, uint position, uint n_chars, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted after text is inserted into the buffer.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="position">
/// the position the text was inserted at.
/// </param>
/// <param name="chars">
/// The text that was inserted.
/// </param>
/// <param name="n_chars">
/// The number of characters that were inserted.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void inserted_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryBufferHandle>))] MentorLake.Gtk.GtkEntryBufferHandle self, uint position, string chars, uint n_chars, IntPtr user_data);

}


public static class GtkEntryBufferHandleExtensions
{
/// <summary>
/// <para>
/// Deletes a sequence of characters from the buffer. @n_chars characters are
/// deleted starting at @position. If @n_chars is negative, then all characters
/// until the end of the text are deleted.
/// </para>
/// <para>
/// If @position or @n_chars are out of bounds, then they are coerced to sane
/// values.
/// </para>
/// <para>
/// Note that the positions are specified in characters, not bytes.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkEntryBuffer
/// </param>
/// <param name="position">
/// position at which to delete text
/// </param>
/// <param name="n_chars">
/// number of characters to delete
/// </param>
/// <return>
/// The number of characters deleted.
/// </return>

	public static uint DeleteText(this MentorLake.Gtk.GtkEntryBufferHandle buffer, uint position, int n_chars)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkEntryBufferHandle)");
		return GtkEntryBufferHandleExterns.gtk_entry_buffer_delete_text(buffer, position, n_chars);
	}

/// <summary>
/// <para>
/// Used when subclassing #GtkEntryBuffer
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkEntryBuffer
/// </param>
/// <param name="position">
/// position at which text was deleted
/// </param>
/// <param name="n_chars">
/// number of characters deleted
/// </param>

	public static T EmitDeletedText<T>(this T buffer, uint position, uint n_chars) where T : GtkEntryBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkEntryBufferHandle)");
		GtkEntryBufferHandleExterns.gtk_entry_buffer_emit_deleted_text(buffer, position, n_chars);
		return buffer;
	}

/// <summary>
/// <para>
/// Used when subclassing #GtkEntryBuffer
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkEntryBuffer
/// </param>
/// <param name="position">
/// position at which text was inserted
/// </param>
/// <param name="chars">
/// text that was inserted
/// </param>
/// <param name="n_chars">
/// number of characters inserted
/// </param>

	public static T EmitInsertedText<T>(this T buffer, uint position, string chars, uint n_chars) where T : GtkEntryBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkEntryBufferHandle)");
		GtkEntryBufferHandleExterns.gtk_entry_buffer_emit_inserted_text(buffer, position, chars, n_chars);
		return buffer;
	}

/// <summary>
/// <para>
/// Retrieves the length in bytes of the buffer.
/// See gtk_entry_buffer_get_length().
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkEntryBuffer
/// </param>
/// <return>
/// The byte length of the buffer.
/// </return>

	public static UIntPtr GetBytes(this MentorLake.Gtk.GtkEntryBufferHandle buffer)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkEntryBufferHandle)");
		return GtkEntryBufferHandleExterns.gtk_entry_buffer_get_bytes(buffer);
	}

/// <summary>
/// <para>
/// Retrieves the length in characters of the buffer.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkEntryBuffer
/// </param>
/// <return>
/// The number of characters in the buffer.
/// </return>

	public static uint GetLength(this MentorLake.Gtk.GtkEntryBufferHandle buffer)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkEntryBufferHandle)");
		return GtkEntryBufferHandleExterns.gtk_entry_buffer_get_length(buffer);
	}

/// <summary>
/// <para>
/// Retrieves the maximum allowed length of the text in
/// @buffer. See gtk_entry_buffer_set_max_length().
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkEntryBuffer
/// </param>
/// <return>
/// the maximum allowed number of characters
///               in #GtkEntryBuffer, or 0 if there is no maximum.
/// </return>

	public static int GetMaxLength(this MentorLake.Gtk.GtkEntryBufferHandle buffer)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkEntryBufferHandle)");
		return GtkEntryBufferHandleExterns.gtk_entry_buffer_get_max_length(buffer);
	}

/// <summary>
/// <para>
/// Retrieves the contents of the buffer.
/// </para>
/// <para>
/// The memory pointer returned by this call will not change
/// unless this object emits a signal, or is finalized.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkEntryBuffer
/// </param>
/// <return>
/// a pointer to the contents of the widget as a
///      string. This string points to internally allocated
///      storage in the buffer and must not be freed, modified or
///      stored.
/// </return>

	public static string GetText(this MentorLake.Gtk.GtkEntryBufferHandle buffer)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkEntryBufferHandle)");
		return GtkEntryBufferHandleExterns.gtk_entry_buffer_get_text(buffer);
	}

/// <summary>
/// <para>
/// Inserts @n_chars characters of @chars into the contents of the
/// buffer, at position @position.
/// </para>
/// <para>
/// If @n_chars is negative, then characters from chars will be inserted
/// until a null-terminator is found. If @position or @n_chars are out of
/// bounds, or the maximum buffer text length is exceeded, then they are
/// coerced to sane values.
/// </para>
/// <para>
/// Note that the position and length are in characters, not in bytes.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkEntryBuffer
/// </param>
/// <param name="position">
/// the position at which to insert text.
/// </param>
/// <param name="chars">
/// the text to insert into the buffer.
/// </param>
/// <param name="n_chars">
/// the length of the text in characters, or -1
/// </param>
/// <return>
/// The number of characters actually inserted.
/// </return>

	public static uint InsertText(this MentorLake.Gtk.GtkEntryBufferHandle buffer, uint position, string chars, int n_chars)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkEntryBufferHandle)");
		return GtkEntryBufferHandleExterns.gtk_entry_buffer_insert_text(buffer, position, chars, n_chars);
	}

/// <summary>
/// <para>
/// Sets the maximum allowed length of the contents of the buffer. If
/// the current contents are longer than the given length, then they
/// will be truncated to fit.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkEntryBuffer
/// </param>
/// <param name="max_length">
/// the maximum length of the entry buffer, or 0 for no maximum.
///   (other than the maximum length of entries.) The value passed in will
///   be clamped to the range 0-65536.
/// </param>

	public static T SetMaxLength<T>(this T buffer, int max_length) where T : GtkEntryBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkEntryBufferHandle)");
		GtkEntryBufferHandleExterns.gtk_entry_buffer_set_max_length(buffer, max_length);
		return buffer;
	}

/// <summary>
/// <para>
/// Sets the text in the buffer.
/// </para>
/// <para>
/// This is roughly equivalent to calling gtk_entry_buffer_delete_text()
/// and gtk_entry_buffer_insert_text().
/// </para>
/// <para>
/// Note that @n_chars is in characters, not in bytes.
/// </para>
/// </summary>

/// <param name="buffer">
/// a #GtkEntryBuffer
/// </param>
/// <param name="chars">
/// the new text
/// </param>
/// <param name="n_chars">
/// the number of characters in @text, or -1
/// </param>

	public static T SetText<T>(this T buffer, string chars, int n_chars) where T : GtkEntryBufferHandle
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (GtkEntryBufferHandle)");
		GtkEntryBufferHandleExterns.gtk_entry_buffer_set_text(buffer, chars, n_chars);
		return buffer;
	}

}

internal class GtkEntryBufferHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkEntryBufferHandle>))]
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
