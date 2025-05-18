namespace MentorLake.Gio;

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
	public static int GetFd(this MentorLake.Gio.GFileDescriptorBasedHandle fd_based)
	{
		if (fd_based.IsInvalid) throw new Exception("Invalid handle (GFileDescriptorBasedHandle)");
		return GFileDescriptorBasedHandleExterns.g_file_descriptor_based_get_fd(fd_based);
	}

}

internal class GFileDescriptorBasedHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern int g_file_descriptor_based_get_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileDescriptorBasedHandleImpl>))] MentorLake.Gio.GFileDescriptorBasedHandle fd_based);

}
