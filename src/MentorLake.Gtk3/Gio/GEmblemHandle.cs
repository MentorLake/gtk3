namespace MentorLake.Gio;

public class GEmblemHandle : GObjectHandle, GIconHandle
{
	public static MentorLake.Gio.GEmblemHandle New(MentorLake.Gio.GIconHandle icon)
	{
		return GEmblemHandleExterns.g_emblem_new(icon);
	}

	public static MentorLake.Gio.GEmblemHandle NewWithOrigin(MentorLake.Gio.GIconHandle icon, MentorLake.Gio.GEmblemOrigin origin)
	{
		return GEmblemHandleExterns.g_emblem_new_with_origin(icon, origin);
	}

}

public static class GEmblemHandleExtensions
{
	public static MentorLake.Gio.GIconHandle GetIcon(this MentorLake.Gio.GEmblemHandle emblem)
	{
		return GEmblemHandleExterns.g_emblem_get_icon(emblem);
	}

	public static MentorLake.Gio.GEmblemOrigin GetOrigin(this MentorLake.Gio.GEmblemHandle emblem)
	{
		return GEmblemHandleExterns.g_emblem_get_origin(emblem);
	}

}

internal class GEmblemHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GEmblemHandle g_emblem_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GEmblemHandle g_emblem_new_with_origin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon, MentorLake.Gio.GEmblemOrigin origin);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GIconHandle g_emblem_get_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GEmblemHandle>))] MentorLake.Gio.GEmblemHandle emblem);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GEmblemOrigin g_emblem_get_origin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GEmblemHandle>))] MentorLake.Gio.GEmblemHandle emblem);

}
