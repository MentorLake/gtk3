namespace MentorLake.Gio;

public class GBytesIconHandle : GObjectHandle, GIconHandle, GLoadableIconHandle
{
	public static MentorLake.Gio.GBytesIconHandle New(MentorLake.GLib.GBytesHandle bytes)
	{
		return GBytesIconHandleExterns.g_bytes_icon_new(bytes);
	}

}

public static class GBytesIconHandleExtensions
{
	public static MentorLake.GLib.GBytesHandle GetBytes(this MentorLake.Gio.GBytesIconHandle icon)
	{
		return GBytesIconHandleExterns.g_bytes_icon_get_bytes(icon);
	}

}

internal class GBytesIconHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GBytesIconHandle g_bytes_icon_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GBytesHandle g_bytes_icon_get_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GBytesIconHandle>))] MentorLake.Gio.GBytesIconHandle icon);

}
