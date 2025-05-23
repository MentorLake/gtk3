namespace MentorLake.GLib;

public class GIOChannelHandle : BaseSafeHandle
{
	public static MentorLake.GLib.GIOChannelHandle NewFile(string filename, string mode)
	{
		var externCallResult = GIOChannelExterns.g_io_channel_new_file(filename, mode, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GLib.GIOChannelHandle UnixNew(int fd)
	{
		return GIOChannelExterns.g_io_channel_unix_new(fd);
	}

}


public static class GIOChannelExtensions
{
	public static void Close(this MentorLake.GLib.GIOChannelHandle channel)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		GIOChannelExterns.g_io_channel_close(channel);
	}

	public static MentorLake.GLib.GIOStatus Flush(this MentorLake.GLib.GIOChannelHandle channel)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		var externCallResult = GIOChannelExterns.g_io_channel_flush(channel, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GLib.GIOCondition GetBufferCondition(this MentorLake.GLib.GIOChannelHandle channel)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		return GIOChannelExterns.g_io_channel_get_buffer_condition(channel);
	}

	public static UIntPtr GetBufferSize(this MentorLake.GLib.GIOChannelHandle channel)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		return GIOChannelExterns.g_io_channel_get_buffer_size(channel);
	}

	public static bool GetBuffered(this MentorLake.GLib.GIOChannelHandle channel)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		return GIOChannelExterns.g_io_channel_get_buffered(channel);
	}

	public static bool GetCloseOnUnref(this MentorLake.GLib.GIOChannelHandle channel)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		return GIOChannelExterns.g_io_channel_get_close_on_unref(channel);
	}

	public static string GetEncoding(this MentorLake.GLib.GIOChannelHandle channel)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		return GIOChannelExterns.g_io_channel_get_encoding(channel);
	}

	public static MentorLake.GLib.GIOFlags GetFlags(this MentorLake.GLib.GIOChannelHandle channel)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		return GIOChannelExterns.g_io_channel_get_flags(channel);
	}

	public static string GetLineTerm(this MentorLake.GLib.GIOChannelHandle channel, out int length)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		return GIOChannelExterns.g_io_channel_get_line_term(channel, out length);
	}

	public static void Init(this MentorLake.GLib.GIOChannelHandle channel)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		GIOChannelExterns.g_io_channel_init(channel);
	}

	public static MentorLake.GLib.GIOError Read(this MentorLake.GLib.GIOChannelHandle channel, string buf, UIntPtr count, UIntPtr bytes_read)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		return GIOChannelExterns.g_io_channel_read(channel, buf, count, bytes_read);
	}

	public static MentorLake.GLib.GIOStatus ReadChars(this MentorLake.GLib.GIOChannelHandle channel, out byte[] buf, UIntPtr count, out UIntPtr bytes_read)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		var externCallResult = GIOChannelExterns.g_io_channel_read_chars(channel, out buf, count, out bytes_read, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GLib.GIOStatus ReadLine(this MentorLake.GLib.GIOChannelHandle channel, out string str_return, out UIntPtr length, out UIntPtr terminator_pos)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		var externCallResult = GIOChannelExterns.g_io_channel_read_line(channel, out str_return, out length, out terminator_pos, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GLib.GIOStatus ReadLineString(this MentorLake.GLib.GIOChannelHandle channel, MentorLake.GLib.GStringHandle buffer, UIntPtr terminator_pos)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		var externCallResult = GIOChannelExterns.g_io_channel_read_line_string(channel, buffer, terminator_pos, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GLib.GIOStatus ReadToEnd(this MentorLake.GLib.GIOChannelHandle channel, out byte[] str_return, out UIntPtr length)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		var externCallResult = GIOChannelExterns.g_io_channel_read_to_end(channel, out str_return, out length, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GLib.GIOStatus ReadUnichar(this MentorLake.GLib.GIOChannelHandle channel, out char thechar)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		var externCallResult = GIOChannelExterns.g_io_channel_read_unichar(channel, out thechar, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GLib.GIOChannelHandle Ref(this MentorLake.GLib.GIOChannelHandle channel)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		return GIOChannelExterns.g_io_channel_ref(channel);
	}

	public static MentorLake.GLib.GIOError Seek(this MentorLake.GLib.GIOChannelHandle channel, long offset, MentorLake.GLib.GSeekType type)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		return GIOChannelExterns.g_io_channel_seek(channel, offset, type);
	}

	public static MentorLake.GLib.GIOStatus SeekPosition(this MentorLake.GLib.GIOChannelHandle channel, long offset, MentorLake.GLib.GSeekType type)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		var externCallResult = GIOChannelExterns.g_io_channel_seek_position(channel, offset, type, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static void SetBufferSize(this MentorLake.GLib.GIOChannelHandle channel, UIntPtr size)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		GIOChannelExterns.g_io_channel_set_buffer_size(channel, size);
	}

	public static void SetBuffered(this MentorLake.GLib.GIOChannelHandle channel, bool buffered)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		GIOChannelExterns.g_io_channel_set_buffered(channel, buffered);
	}

	public static void SetCloseOnUnref(this MentorLake.GLib.GIOChannelHandle channel, bool do_close)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		GIOChannelExterns.g_io_channel_set_close_on_unref(channel, do_close);
	}

	public static MentorLake.GLib.GIOStatus SetEncoding(this MentorLake.GLib.GIOChannelHandle channel, string encoding)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		var externCallResult = GIOChannelExterns.g_io_channel_set_encoding(channel, encoding, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GLib.GIOStatus SetFlags(this MentorLake.GLib.GIOChannelHandle channel, MentorLake.GLib.GIOFlags flags)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		var externCallResult = GIOChannelExterns.g_io_channel_set_flags(channel, flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static void SetLineTerm(this MentorLake.GLib.GIOChannelHandle channel, string line_term, int length)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		GIOChannelExterns.g_io_channel_set_line_term(channel, line_term, length);
	}

	public static MentorLake.GLib.GIOStatus Shutdown(this MentorLake.GLib.GIOChannelHandle channel, bool flush)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		var externCallResult = GIOChannelExterns.g_io_channel_shutdown(channel, flush, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static int UnixGetFd(this MentorLake.GLib.GIOChannelHandle channel)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		return GIOChannelExterns.g_io_channel_unix_get_fd(channel);
	}

	public static void Unref(this MentorLake.GLib.GIOChannelHandle channel)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		GIOChannelExterns.g_io_channel_unref(channel);
	}

	public static MentorLake.GLib.GIOError Write(this MentorLake.GLib.GIOChannelHandle channel, string buf, UIntPtr count, UIntPtr bytes_written)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		return GIOChannelExterns.g_io_channel_write(channel, buf, count, bytes_written);
	}

	public static MentorLake.GLib.GIOStatus WriteChars(this MentorLake.GLib.GIOChannelHandle channel, byte[] buf, UIntPtr count, out UIntPtr bytes_written)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		var externCallResult = GIOChannelExterns.g_io_channel_write_chars(channel, buf, count, out bytes_written, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GLib.GIOStatus WriteUnichar(this MentorLake.GLib.GIOChannelHandle channel, char thechar)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		var externCallResult = GIOChannelExterns.g_io_channel_write_unichar(channel, thechar, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}


	public static GIOChannel Dereference(this GIOChannelHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GIOChannel>(x.DangerousGetHandle());
}
internal class GIOChannelExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))]
	internal static extern MentorLake.GLib.GIOChannelHandle g_io_channel_new_file(string filename, string mode, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))]
	internal static extern MentorLake.GLib.GIOChannelHandle g_io_channel_unix_new(int fd);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_io_channel_close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIOStatus g_io_channel_flush([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIOCondition g_io_channel_get_buffer_condition([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_io_channel_get_buffer_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_io_channel_get_buffered([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_io_channel_get_close_on_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_io_channel_get_encoding([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIOFlags g_io_channel_get_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_io_channel_get_line_term([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, out int length);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_io_channel_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIOError g_io_channel_read([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, string buf, UIntPtr count, UIntPtr bytes_read);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIOStatus g_io_channel_read_chars([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, out byte[] buf, UIntPtr count, out UIntPtr bytes_read, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIOStatus g_io_channel_read_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, out string str_return, out UIntPtr length, out UIntPtr terminator_pos, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIOStatus g_io_channel_read_line_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle buffer, UIntPtr terminator_pos, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIOStatus g_io_channel_read_to_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, out byte[] str_return, out UIntPtr length, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIOStatus g_io_channel_read_unichar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, out char thechar, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))]
	internal static extern MentorLake.GLib.GIOChannelHandle g_io_channel_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIOError g_io_channel_seek([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, long offset, MentorLake.GLib.GSeekType type);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIOStatus g_io_channel_seek_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, long offset, MentorLake.GLib.GSeekType type, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_io_channel_set_buffer_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, UIntPtr size);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_io_channel_set_buffered([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, bool buffered);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_io_channel_set_close_on_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, bool do_close);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIOStatus g_io_channel_set_encoding([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, string encoding, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIOStatus g_io_channel_set_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, MentorLake.GLib.GIOFlags flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_io_channel_set_line_term([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, string line_term, int length);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIOStatus g_io_channel_shutdown([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, bool flush, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_io_channel_unix_get_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_io_channel_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIOError g_io_channel_write([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, string buf, UIntPtr count, UIntPtr bytes_written);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIOStatus g_io_channel_write_chars([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, byte[] buf, UIntPtr count, out UIntPtr bytes_written, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIOStatus g_io_channel_write_unichar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, char thechar, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIOChannelError g_io_channel_error_from_errno(int en);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_io_channel_error_quark();

}

public struct GIOChannel
{
	public static MentorLake.GLib.GIOChannelError ErrorFromErrno(int en)
	{
		return GIOChannelExterns.g_io_channel_error_from_errno(en);
	}

	public static MentorLake.GLib.GQuark ErrorQuark()
	{
		return GIOChannelExterns.g_io_channel_error_quark();
	}

}
