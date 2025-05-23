namespace MentorLake.GioUnix;

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
