namespace MentorLake.Gio;

public interface GIconHandle
{
}

internal class GIconHandleImpl : BaseSafeHandle, GIconHandle
{
}

public static class GIconHandleExtensions
{
	public static bool Equal(this MentorLake.Gio.GIconHandle icon1, MentorLake.Gio.GIconHandle icon2)
	{
		return GIconHandleExterns.g_icon_equal(icon1, icon2);
	}

	public static uint Hash(this MentorLake.Gio.GIconHandle icon)
	{
		return GIconHandleExterns.g_icon_hash(icon);
	}

	public static MentorLake.GLib.GVariantHandle Serialize(this MentorLake.Gio.GIconHandle icon)
	{
		return GIconHandleExterns.g_icon_serialize(icon);
	}

	public static string ToString(this MentorLake.Gio.GIconHandle icon)
	{
		return GIconHandleExterns.g_icon_to_string(icon);
	}

	public static MentorLake.Gio.GIconHandle Deserialize(MentorLake.GLib.GVariantHandle value)
	{
		return GIconHandleExterns.g_icon_deserialize(value);
	}

	public static MentorLake.Gio.GIconHandle NewForString(string str)
	{
		var externCallResult = GIconHandleExterns.g_icon_new_for_string(str, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class GIconHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern bool g_icon_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon2);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_icon_hash([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_icon_serialize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_icon_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GIconHandle g_icon_deserialize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GIconHandle g_icon_new_for_string(string str, out MentorLake.GLib.GErrorHandle error);

}
