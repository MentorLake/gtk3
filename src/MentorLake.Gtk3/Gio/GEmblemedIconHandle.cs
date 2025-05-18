namespace MentorLake.Gio;

public class GEmblemedIconHandle : GObjectHandle, GIconHandle
{
	public static MentorLake.Gio.GEmblemedIconHandle New(MentorLake.Gio.GIconHandle icon, MentorLake.Gio.GEmblemHandle emblem)
	{
		return GEmblemedIconHandleExterns.g_emblemed_icon_new(icon, emblem);
	}

}

public static class GEmblemedIconHandleExtensions
{
	public static T AddEmblem<T>(this T emblemed, MentorLake.Gio.GEmblemHandle emblem) where T : GEmblemedIconHandle
	{
		if (emblemed.IsInvalid) throw new Exception("Invalid handle (GEmblemedIconHandle)");
		GEmblemedIconHandleExterns.g_emblemed_icon_add_emblem(emblemed, emblem);
		return emblemed;
	}

	public static T ClearEmblems<T>(this T emblemed) where T : GEmblemedIconHandle
	{
		if (emblemed.IsInvalid) throw new Exception("Invalid handle (GEmblemedIconHandle)");
		GEmblemedIconHandleExterns.g_emblemed_icon_clear_emblems(emblemed);
		return emblemed;
	}

	public static MentorLake.GLib.GListHandle GetEmblems(this MentorLake.Gio.GEmblemedIconHandle emblemed)
	{
		if (emblemed.IsInvalid) throw new Exception("Invalid handle (GEmblemedIconHandle)");
		return GEmblemedIconHandleExterns.g_emblemed_icon_get_emblems(emblemed);
	}

	public static MentorLake.Gio.GIconHandle GetIcon(this MentorLake.Gio.GEmblemedIconHandle emblemed)
	{
		if (emblemed.IsInvalid) throw new Exception("Invalid handle (GEmblemedIconHandle)");
		return GEmblemedIconHandleExterns.g_emblemed_icon_get_icon(emblemed);
	}

}

internal class GEmblemedIconHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GEmblemedIconHandle>))]
	internal static extern MentorLake.Gio.GEmblemedIconHandle g_emblemed_icon_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GEmblemHandle>))] MentorLake.Gio.GEmblemHandle emblem);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_emblemed_icon_add_emblem([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GEmblemedIconHandle>))] MentorLake.Gio.GEmblemedIconHandle emblemed, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GEmblemHandle>))] MentorLake.Gio.GEmblemHandle emblem);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_emblemed_icon_clear_emblems([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GEmblemedIconHandle>))] MentorLake.Gio.GEmblemedIconHandle emblemed);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_emblemed_icon_get_emblems([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GEmblemedIconHandle>))] MentorLake.Gio.GEmblemedIconHandle emblemed);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))]
	internal static extern MentorLake.Gio.GIconHandle g_emblemed_icon_get_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GEmblemedIconHandle>))] MentorLake.Gio.GEmblemedIconHandle emblemed);

}
