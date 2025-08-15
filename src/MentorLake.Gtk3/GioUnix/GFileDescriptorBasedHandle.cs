namespace MentorLake.GioUnix;

/// <summary>
/// <para>
/// `GFileDescriptorBased` is an interface for file descriptor based IO.
/// </para>
/// <para>
/// It is implemented by streams (implementations of [class@Gio.InputStream] or
/// [class@Gio.OutputStream]) that are based on file descriptors.
/// </para>
/// <para>
/// Note that `&amp;lt;gio/gfiledescriptorbased.h&amp;gt;` belongs to the UNIX-specific
/// GIO interfaces, thus you have to use the `gio-unix-2.0.pc` pkg-config
/// file or the `GioUnix-2.0` GIR namespace when using it.
/// </para>
/// </summary>

public interface GFileDescriptorBasedHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GFileDescriptorBasedHandleImpl : BaseSafeHandle, GFileDescriptorBasedHandle
{
}

public static class GFileDescriptorBasedHandleExtensions
{
/// <summary>
/// <para>
/// Gets the underlying file descriptor.
/// </para>
/// </summary>

/// <param name="fd_based">
/// a #GFileDescriptorBased.
/// </param>
/// <return>
/// The file descriptor
/// </return>

	public static int GetFd(MentorLake.Gio.GFileDescriptorBasedHandle fd_based)
	{
		return GFileDescriptorBasedHandleExterns.g_file_descriptor_based_get_fd(fd_based);
	}

}

internal class GFileDescriptorBasedHandleExterns
{
	[DllImport(GioUnixLibrary.Name)]
	internal static extern int g_file_descriptor_based_get_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileDescriptorBasedHandleImpl>))] MentorLake.Gio.GFileDescriptorBasedHandle fd_based);

}
