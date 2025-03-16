namespace MentorLake.Gio;

public interface GFileDescriptorBasedHandle
{
}

internal class GFileDescriptorBasedHandleImpl : BaseSafeHandle, GFileDescriptorBasedHandle
{
}

public static class GFileDescriptorBasedHandleExtensions
{
	public static int GetFd(this MentorLake.Gio.GFileDescriptorBasedHandle fd_based)
	{
		return GFileDescriptorBasedHandleExterns.g_file_descriptor_based_get_fd(fd_based);
	}

}

internal class GFileDescriptorBasedHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern int g_file_descriptor_based_get_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileDescriptorBasedHandleImpl>))] MentorLake.Gio.GFileDescriptorBasedHandle fd_based);

}
