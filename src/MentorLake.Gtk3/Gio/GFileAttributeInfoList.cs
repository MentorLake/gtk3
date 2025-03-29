namespace MentorLake.Gio;

public class GFileAttributeInfoListHandle : BaseSafeHandle
{
	public static MentorLake.Gio.GFileAttributeInfoListHandle New()
	{
		return GFileAttributeInfoListExterns.g_file_attribute_info_list_new();
	}

}


public static class GFileAttributeInfoListExtensions
{
	public static void Add(this MentorLake.Gio.GFileAttributeInfoListHandle list, string name, MentorLake.Gio.GFileAttributeType type, MentorLake.Gio.GFileAttributeInfoFlags flags)
	{
		if (list.IsInvalid || list.IsClosed) throw new Exception("Invalid or closed handle (GFileAttributeInfoList)");
		GFileAttributeInfoListExterns.g_file_attribute_info_list_add(list, name, type, flags);
	}

	public static MentorLake.Gio.GFileAttributeInfoListHandle Dup(this MentorLake.Gio.GFileAttributeInfoListHandle list)
	{
		if (list.IsInvalid || list.IsClosed) throw new Exception("Invalid or closed handle (GFileAttributeInfoList)");
		return GFileAttributeInfoListExterns.g_file_attribute_info_list_dup(list);
	}

	public static MentorLake.Gio.GFileAttributeInfoHandle Lookup(this MentorLake.Gio.GFileAttributeInfoListHandle list, string name)
	{
		if (list.IsInvalid || list.IsClosed) throw new Exception("Invalid or closed handle (GFileAttributeInfoList)");
		return GFileAttributeInfoListExterns.g_file_attribute_info_list_lookup(list, name);
	}

	public static MentorLake.Gio.GFileAttributeInfoListHandle Ref(this MentorLake.Gio.GFileAttributeInfoListHandle list)
	{
		if (list.IsInvalid || list.IsClosed) throw new Exception("Invalid or closed handle (GFileAttributeInfoList)");
		return GFileAttributeInfoListExterns.g_file_attribute_info_list_ref(list);
	}

	public static void Unref(this MentorLake.Gio.GFileAttributeInfoListHandle list)
	{
		if (list.IsInvalid || list.IsClosed) throw new Exception("Invalid or closed handle (GFileAttributeInfoList)");
		GFileAttributeInfoListExterns.g_file_attribute_info_list_unref(list);
	}


	public static GFileAttributeInfoList Dereference(this GFileAttributeInfoListHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GFileAttributeInfoList>(x.DangerousGetHandle());
}
internal class GFileAttributeInfoListExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileAttributeInfoListHandle g_file_attribute_info_list_new();

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_attribute_info_list_add([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileAttributeInfoListHandle>))] MentorLake.Gio.GFileAttributeInfoListHandle list, string name, MentorLake.Gio.GFileAttributeType type, MentorLake.Gio.GFileAttributeInfoFlags flags);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileAttributeInfoListHandle g_file_attribute_info_list_dup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileAttributeInfoListHandle>))] MentorLake.Gio.GFileAttributeInfoListHandle list);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileAttributeInfoHandle g_file_attribute_info_list_lookup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileAttributeInfoListHandle>))] MentorLake.Gio.GFileAttributeInfoListHandle list, string name);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileAttributeInfoListHandle g_file_attribute_info_list_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileAttributeInfoListHandle>))] MentorLake.Gio.GFileAttributeInfoListHandle list);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_attribute_info_list_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileAttributeInfoListHandle>))] MentorLake.Gio.GFileAttributeInfoListHandle list);

}

public struct GFileAttributeInfoList
{
	public IntPtr infos;
	public int n_infos;
}
