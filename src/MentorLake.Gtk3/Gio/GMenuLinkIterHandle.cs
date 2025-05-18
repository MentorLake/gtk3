namespace MentorLake.Gio;

public class GMenuLinkIterHandle : GObjectHandle
{
}

public static class GMenuLinkIterHandleExtensions
{
	public static string GetName(this MentorLake.Gio.GMenuLinkIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GMenuLinkIterHandle)");
		return GMenuLinkIterHandleExterns.g_menu_link_iter_get_name(iter);
	}

	public static bool GetNext(this MentorLake.Gio.GMenuLinkIterHandle iter, out string out_link, out MentorLake.Gio.GMenuModelHandle value)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GMenuLinkIterHandle)");
		return GMenuLinkIterHandleExterns.g_menu_link_iter_get_next(iter, out out_link, out value);
	}

	public static MentorLake.Gio.GMenuModelHandle GetValue(this MentorLake.Gio.GMenuLinkIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GMenuLinkIterHandle)");
		return GMenuLinkIterHandleExterns.g_menu_link_iter_get_value(iter);
	}

	public static bool Next(this MentorLake.Gio.GMenuLinkIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GMenuLinkIterHandle)");
		return GMenuLinkIterHandleExterns.g_menu_link_iter_next(iter);
	}

}

internal class GMenuLinkIterHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_menu_link_iter_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuLinkIterHandle>))] MentorLake.Gio.GMenuLinkIterHandle iter);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_menu_link_iter_get_next([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuLinkIterHandle>))] MentorLake.Gio.GMenuLinkIterHandle iter, out string out_link, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] out MentorLake.Gio.GMenuModelHandle value);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))]
	internal static extern MentorLake.Gio.GMenuModelHandle g_menu_link_iter_get_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuLinkIterHandle>))] MentorLake.Gio.GMenuLinkIterHandle iter);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_menu_link_iter_next([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuLinkIterHandle>))] MentorLake.Gio.GMenuLinkIterHandle iter);

}
