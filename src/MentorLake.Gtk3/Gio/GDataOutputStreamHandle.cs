namespace MentorLake.Gio;

public class GDataOutputStreamHandle : GFilterOutputStreamHandle, GSeekableHandle
{
	public static MentorLake.Gio.GDataOutputStreamHandle New(MentorLake.Gio.GOutputStreamHandle base_stream)
	{
		return GDataOutputStreamHandleExterns.g_data_output_stream_new(base_stream);
	}

}

public static class GDataOutputStreamHandleExtensions
{
	public static MentorLake.Gio.GDataStreamByteOrder GetByteOrder(this MentorLake.Gio.GDataOutputStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GDataOutputStreamHandle)");
		return GDataOutputStreamHandleExterns.g_data_output_stream_get_byte_order(stream);
	}

	public static bool PutByte(this MentorLake.Gio.GDataOutputStreamHandle stream, char data, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GDataOutputStreamHandle)");
		var externCallResult = GDataOutputStreamHandleExterns.g_data_output_stream_put_byte(stream, data, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool PutInt16(this MentorLake.Gio.GDataOutputStreamHandle stream, short data, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GDataOutputStreamHandle)");
		var externCallResult = GDataOutputStreamHandleExterns.g_data_output_stream_put_int16(stream, data, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool PutInt32(this MentorLake.Gio.GDataOutputStreamHandle stream, int data, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GDataOutputStreamHandle)");
		var externCallResult = GDataOutputStreamHandleExterns.g_data_output_stream_put_int32(stream, data, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool PutInt64(this MentorLake.Gio.GDataOutputStreamHandle stream, long data, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GDataOutputStreamHandle)");
		var externCallResult = GDataOutputStreamHandleExterns.g_data_output_stream_put_int64(stream, data, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool PutString(this MentorLake.Gio.GDataOutputStreamHandle stream, string str, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GDataOutputStreamHandle)");
		var externCallResult = GDataOutputStreamHandleExterns.g_data_output_stream_put_string(stream, str, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool PutUint16(this MentorLake.Gio.GDataOutputStreamHandle stream, ushort data, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GDataOutputStreamHandle)");
		var externCallResult = GDataOutputStreamHandleExterns.g_data_output_stream_put_uint16(stream, data, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool PutUint32(this MentorLake.Gio.GDataOutputStreamHandle stream, uint data, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GDataOutputStreamHandle)");
		var externCallResult = GDataOutputStreamHandleExterns.g_data_output_stream_put_uint32(stream, data, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool PutUint64(this MentorLake.Gio.GDataOutputStreamHandle stream, ulong data, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GDataOutputStreamHandle)");
		var externCallResult = GDataOutputStreamHandleExterns.g_data_output_stream_put_uint64(stream, data, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T SetByteOrder<T>(this T stream, MentorLake.Gio.GDataStreamByteOrder order) where T : GDataOutputStreamHandle
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GDataOutputStreamHandle)");
		GDataOutputStreamHandleExterns.g_data_output_stream_set_byte_order(stream, order);
		return stream;
	}

}

internal class GDataOutputStreamHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GDataOutputStreamHandle>))]
	internal static extern MentorLake.Gio.GDataOutputStreamHandle g_data_output_stream_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))] MentorLake.Gio.GOutputStreamHandle base_stream);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDataStreamByteOrder g_data_output_stream_get_byte_order([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataOutputStreamHandle>))] MentorLake.Gio.GDataOutputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_data_output_stream_put_byte([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataOutputStreamHandle>))] MentorLake.Gio.GDataOutputStreamHandle stream, char data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_data_output_stream_put_int16([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataOutputStreamHandle>))] MentorLake.Gio.GDataOutputStreamHandle stream, short data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_data_output_stream_put_int32([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataOutputStreamHandle>))] MentorLake.Gio.GDataOutputStreamHandle stream, int data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_data_output_stream_put_int64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataOutputStreamHandle>))] MentorLake.Gio.GDataOutputStreamHandle stream, long data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_data_output_stream_put_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataOutputStreamHandle>))] MentorLake.Gio.GDataOutputStreamHandle stream, string str, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_data_output_stream_put_uint16([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataOutputStreamHandle>))] MentorLake.Gio.GDataOutputStreamHandle stream, ushort data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_data_output_stream_put_uint32([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataOutputStreamHandle>))] MentorLake.Gio.GDataOutputStreamHandle stream, uint data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_data_output_stream_put_uint64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataOutputStreamHandle>))] MentorLake.Gio.GDataOutputStreamHandle stream, ulong data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_data_output_stream_set_byte_order([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataOutputStreamHandle>))] MentorLake.Gio.GDataOutputStreamHandle stream, MentorLake.Gio.GDataStreamByteOrder order);

}
