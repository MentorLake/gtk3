namespace MentorLake.Gio;

public class GFileIconHandle : GObjectHandle, GIconHandle, GLoadableIconHandle
{
	public static MentorLake.Gio.GFileIconHandle New(MentorLake.Gio.GFileHandle file)
	{
		return GFileIconHandleExterns.g_file_icon_new(file);
	}

}

public static class GFileIconHandleExtensions
{
	public static MentorLake.Gio.GFileHandle GetFile(this MentorLake.Gio.GFileIconHandle icon)
	{
		return GFileIconHandleExterns.g_file_icon_get_file(icon);
	}

}

internal class GFileIconHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileIconHandle g_file_icon_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileHandle g_file_icon_get_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileIconHandle>))] MentorLake.Gio.GFileIconHandle icon);

}
