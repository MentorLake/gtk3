namespace MentorLake.Gio;

public class GDataInputStreamHandle : GBufferedInputStreamHandle, GSeekableHandle
{
	public static MentorLake.Gio.GDataInputStreamHandle New(MentorLake.Gio.GInputStreamHandle base_stream)
	{
		return GDataInputStreamHandleExterns.g_data_input_stream_new(base_stream);
	}

}

public static class GDataInputStreamHandleExtensions
{
	public static MentorLake.Gio.GDataStreamByteOrder GetByteOrder(this MentorLake.Gio.GDataInputStreamHandle stream)
	{
		return GDataInputStreamHandleExterns.g_data_input_stream_get_byte_order(stream);
	}

	public static MentorLake.Gio.GDataStreamNewlineType GetNewlineType(this MentorLake.Gio.GDataInputStreamHandle stream)
	{
		return GDataInputStreamHandleExterns.g_data_input_stream_get_newline_type(stream);
	}

	public static char ReadByte(this MentorLake.Gio.GDataInputStreamHandle stream, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GDataInputStreamHandleExterns.g_data_input_stream_read_byte(stream, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static short ReadInt16(this MentorLake.Gio.GDataInputStreamHandle stream, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GDataInputStreamHandleExterns.g_data_input_stream_read_int16(stream, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static int ReadInt32(this MentorLake.Gio.GDataInputStreamHandle stream, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GDataInputStreamHandleExterns.g_data_input_stream_read_int32(stream, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static long ReadInt64(this MentorLake.Gio.GDataInputStreamHandle stream, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GDataInputStreamHandleExterns.g_data_input_stream_read_int64(stream, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static byte[] ReadLine(this MentorLake.Gio.GDataInputStreamHandle stream, out UIntPtr length, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GDataInputStreamHandleExterns.g_data_input_stream_read_line(stream, out length, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T ReadLineAsync<T>(this T stream, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GDataInputStreamHandle
	{
		GDataInputStreamHandleExterns.g_data_input_stream_read_line_async(stream, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static byte[] ReadLineFinish(this MentorLake.Gio.GDataInputStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result, out UIntPtr length)
	{
		var externCallResult = GDataInputStreamHandleExterns.g_data_input_stream_read_line_finish(stream, result, out length, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static string ReadLineFinishUtf8(this MentorLake.Gio.GDataInputStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result, out UIntPtr length)
	{
		var externCallResult = GDataInputStreamHandleExterns.g_data_input_stream_read_line_finish_utf8(stream, result, out length, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static string ReadLineUtf8(this MentorLake.Gio.GDataInputStreamHandle stream, out UIntPtr length, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GDataInputStreamHandleExterns.g_data_input_stream_read_line_utf8(stream, out length, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static ushort ReadUint16(this MentorLake.Gio.GDataInputStreamHandle stream, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GDataInputStreamHandleExterns.g_data_input_stream_read_uint16(stream, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static uint ReadUint32(this MentorLake.Gio.GDataInputStreamHandle stream, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GDataInputStreamHandleExterns.g_data_input_stream_read_uint32(stream, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static ulong ReadUint64(this MentorLake.Gio.GDataInputStreamHandle stream, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GDataInputStreamHandleExterns.g_data_input_stream_read_uint64(stream, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static string ReadUntil(this MentorLake.Gio.GDataInputStreamHandle stream, string stop_chars, out UIntPtr length, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GDataInputStreamHandleExterns.g_data_input_stream_read_until(stream, stop_chars, out length, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T ReadUntilAsync<T>(this T stream, string stop_chars, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GDataInputStreamHandle
	{
		GDataInputStreamHandleExterns.g_data_input_stream_read_until_async(stream, stop_chars, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static string ReadUntilFinish(this MentorLake.Gio.GDataInputStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result, out UIntPtr length)
	{
		var externCallResult = GDataInputStreamHandleExterns.g_data_input_stream_read_until_finish(stream, result, out length, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static string ReadUpto(this MentorLake.Gio.GDataInputStreamHandle stream, string stop_chars, UIntPtr stop_chars_len, out UIntPtr length, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GDataInputStreamHandleExterns.g_data_input_stream_read_upto(stream, stop_chars, stop_chars_len, out length, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T ReadUptoAsync<T>(this T stream, string stop_chars, UIntPtr stop_chars_len, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GDataInputStreamHandle
	{
		GDataInputStreamHandleExterns.g_data_input_stream_read_upto_async(stream, stop_chars, stop_chars_len, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static string ReadUptoFinish(this MentorLake.Gio.GDataInputStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result, out UIntPtr length)
	{
		var externCallResult = GDataInputStreamHandleExterns.g_data_input_stream_read_upto_finish(stream, result, out length, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T SetByteOrder<T>(this T stream, MentorLake.Gio.GDataStreamByteOrder order) where T : GDataInputStreamHandle
	{
		GDataInputStreamHandleExterns.g_data_input_stream_set_byte_order(stream, order);
		return stream;
	}

	public static T SetNewlineType<T>(this T stream, MentorLake.Gio.GDataStreamNewlineType type) where T : GDataInputStreamHandle
	{
		GDataInputStreamHandleExterns.g_data_input_stream_set_newline_type(stream, type);
		return stream;
	}

}

internal class GDataInputStreamHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDataInputStreamHandle g_data_input_stream_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle base_stream);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDataStreamByteOrder g_data_input_stream_get_byte_order([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDataStreamNewlineType g_data_input_stream_get_newline_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern char g_data_input_stream_read_byte([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern short g_data_input_stream_read_int16([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_data_input_stream_read_int32([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern long g_data_input_stream_read_int64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern byte[] g_data_input_stream_read_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream, out UIntPtr length, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_data_input_stream_read_line_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern byte[] g_data_input_stream_read_line_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out UIntPtr length, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_data_input_stream_read_line_finish_utf8([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out UIntPtr length, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_data_input_stream_read_line_utf8([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream, out UIntPtr length, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern ushort g_data_input_stream_read_uint16([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_data_input_stream_read_uint32([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern ulong g_data_input_stream_read_uint64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_data_input_stream_read_until([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream, string stop_chars, out UIntPtr length, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_data_input_stream_read_until_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream, string stop_chars, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_data_input_stream_read_until_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out UIntPtr length, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_data_input_stream_read_upto([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream, string stop_chars, UIntPtr stop_chars_len, out UIntPtr length, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_data_input_stream_read_upto_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream, string stop_chars, UIntPtr stop_chars_len, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_data_input_stream_read_upto_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out UIntPtr length, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_data_input_stream_set_byte_order([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream, MentorLake.Gio.GDataStreamByteOrder order);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_data_input_stream_set_newline_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream, MentorLake.Gio.GDataStreamNewlineType type);

}
