namespace MentorLake.Gio;

public class GMenuAttributeIterHandle : GObjectHandle
{
}

public static class GMenuAttributeIterHandleExtensions
{
	public static string GetName(this MentorLake.Gio.GMenuAttributeIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GMenuAttributeIterHandle)");
		return GMenuAttributeIterHandleExterns.g_menu_attribute_iter_get_name(iter);
	}

	public static bool GetNext(this MentorLake.Gio.GMenuAttributeIterHandle iter, out string out_name, out MentorLake.GLib.GVariantHandle value)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GMenuAttributeIterHandle)");
		return GMenuAttributeIterHandleExterns.g_menu_attribute_iter_get_next(iter, out out_name, out value);
	}

	public static MentorLake.GLib.GVariantHandle GetValue(this MentorLake.Gio.GMenuAttributeIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GMenuAttributeIterHandle)");
		return GMenuAttributeIterHandleExterns.g_menu_attribute_iter_get_value(iter);
	}

	public static bool Next(this MentorLake.Gio.GMenuAttributeIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GMenuAttributeIterHandle)");
		return GMenuAttributeIterHandleExterns.g_menu_attribute_iter_next(iter);
	}

}

internal class GMenuAttributeIterHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_menu_attribute_iter_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuAttributeIterHandle>))] MentorLake.Gio.GMenuAttributeIterHandle iter);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_menu_attribute_iter_get_next([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuAttributeIterHandle>))] MentorLake.Gio.GMenuAttributeIterHandle iter, out string out_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] out MentorLake.GLib.GVariantHandle value);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_menu_attribute_iter_get_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuAttributeIterHandle>))] MentorLake.Gio.GMenuAttributeIterHandle iter);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_menu_attribute_iter_next([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuAttributeIterHandle>))] MentorLake.Gio.GMenuAttributeIterHandle iter);

}
