namespace MentorLake.Gio;

public interface GSeekableHandle
{
}

internal class GSeekableHandleImpl : BaseSafeHandle, GSeekableHandle
{
}

public static class GSeekableHandleExtensions
{
	public static bool CanSeek(this MentorLake.Gio.GSeekableHandle seekable)
	{
		return GSeekableHandleExterns.g_seekable_can_seek(seekable);
	}

	public static bool CanTruncate(this MentorLake.Gio.GSeekableHandle seekable)
	{
		return GSeekableHandleExterns.g_seekable_can_truncate(seekable);
	}

	public static bool Seek(this MentorLake.Gio.GSeekableHandle seekable, int offset, MentorLake.GLib.GSeekType type, MentorLake.Gio.GCancellableHandle cancellable)
	{
		return GSeekableHandleExterns.g_seekable_seek(seekable, offset, type, cancellable);
	}

	public static int Tell(this MentorLake.Gio.GSeekableHandle seekable)
	{
		return GSeekableHandleExterns.g_seekable_tell(seekable);
	}

	public static bool Truncate(this MentorLake.Gio.GSeekableHandle seekable, int offset, MentorLake.Gio.GCancellableHandle cancellable)
	{
		return GSeekableHandleExterns.g_seekable_truncate(seekable, offset, cancellable);
	}

}

internal class GSeekableHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern bool g_seekable_can_seek([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSeekableHandleImpl>))] MentorLake.Gio.GSeekableHandle seekable);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_seekable_can_truncate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSeekableHandleImpl>))] MentorLake.Gio.GSeekableHandle seekable);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_seekable_seek([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSeekableHandleImpl>))] MentorLake.Gio.GSeekableHandle seekable, int offset, MentorLake.GLib.GSeekType type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_seekable_tell([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSeekableHandleImpl>))] MentorLake.Gio.GSeekableHandle seekable);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_seekable_truncate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSeekableHandleImpl>))] MentorLake.Gio.GSeekableHandle seekable, int offset, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

}
