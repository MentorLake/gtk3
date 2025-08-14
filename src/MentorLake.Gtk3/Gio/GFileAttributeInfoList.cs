namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Acts as a lightweight registry for possible valid file attributes.
/// The registry stores Key-Value pair formats as #GFileAttributeInfos.
/// </para>
/// </summary>

public class GFileAttributeInfoListHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a new file attribute info list.
/// </para>
/// </summary>

/// <return>
/// a #GFileAttributeInfoList.
/// </return>

	public static MentorLake.Gio.GFileAttributeInfoListHandle New()
	{
		return GFileAttributeInfoListExterns.g_file_attribute_info_list_new();
	}

}


public static class GFileAttributeInfoListExtensions
{
/// <summary>
/// <para>
/// Adds a new attribute with @name to the @list, setting
/// its @type and @flags.
/// </para>
/// </summary>

/// <param name="list">
/// a #GFileAttributeInfoList.
/// </param>
/// <param name="name">
/// the name of the attribute to add.
/// </param>
/// <param name="type">
/// the #GFileAttributeType for the attribute.
/// </param>
/// <param name="flags">
/// #GFileAttributeInfoFlags for the attribute.
/// </param>

	public static void Add(this MentorLake.Gio.GFileAttributeInfoListHandle list, string name, MentorLake.Gio.GFileAttributeType type, MentorLake.Gio.GFileAttributeInfoFlags flags)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (GFileAttributeInfoList)");
		GFileAttributeInfoListExterns.g_file_attribute_info_list_add(list, name, type, flags);
	}

/// <summary>
/// <para>
/// Makes a duplicate of a file attribute info list.
/// </para>
/// </summary>

/// <param name="list">
/// a #GFileAttributeInfoList to duplicate.
/// </param>
/// <return>
/// a copy of the given @list.
/// </return>

	public static MentorLake.Gio.GFileAttributeInfoListHandle Dup(this MentorLake.Gio.GFileAttributeInfoListHandle list)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (GFileAttributeInfoList)");
		return GFileAttributeInfoListExterns.g_file_attribute_info_list_dup(list);
	}

/// <summary>
/// <para>
/// Gets the file attribute with the name @name from @list.
/// </para>
/// </summary>

/// <param name="list">
/// a #GFileAttributeInfoList.
/// </param>
/// <param name="name">
/// the name of the attribute to look up.
/// </param>
/// <return>
/// a #GFileAttributeInfo for the @name, or %NULL if an
/// attribute isn't found.
/// </return>

	public static MentorLake.Gio.GFileAttributeInfoHandle Lookup(this MentorLake.Gio.GFileAttributeInfoListHandle list, string name)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (GFileAttributeInfoList)");
		return GFileAttributeInfoListExterns.g_file_attribute_info_list_lookup(list, name);
	}

/// <summary>
/// <para>
/// References a file attribute info list.
/// </para>
/// </summary>

/// <param name="list">
/// a #GFileAttributeInfoList to reference.
/// </param>
/// <return>
/// #GFileAttributeInfoList or %NULL on error.
/// </return>

	public static MentorLake.Gio.GFileAttributeInfoListHandle Ref(this MentorLake.Gio.GFileAttributeInfoListHandle list)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (GFileAttributeInfoList)");
		return GFileAttributeInfoListExterns.g_file_attribute_info_list_ref(list);
	}

/// <summary>
/// <para>
/// Removes a reference from the given @list. If the reference count
/// falls to zero, the @list is deleted.
/// </para>
/// </summary>

/// <param name="list">
/// The #GFileAttributeInfoList to unreference.
/// </param>

	public static void Unref(this MentorLake.Gio.GFileAttributeInfoListHandle list)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (GFileAttributeInfoList)");
		GFileAttributeInfoListExterns.g_file_attribute_info_list_unref(list);
	}


	public static GFileAttributeInfoList Dereference(this GFileAttributeInfoListHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GFileAttributeInfoList>(x.DangerousGetHandle());
}
internal class GFileAttributeInfoListExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileAttributeInfoListHandle>))]
	internal static extern MentorLake.Gio.GFileAttributeInfoListHandle g_file_attribute_info_list_new();

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_attribute_info_list_add([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileAttributeInfoListHandle>))] MentorLake.Gio.GFileAttributeInfoListHandle list, string name, MentorLake.Gio.GFileAttributeType type, MentorLake.Gio.GFileAttributeInfoFlags flags);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileAttributeInfoListHandle>))]
	internal static extern MentorLake.Gio.GFileAttributeInfoListHandle g_file_attribute_info_list_dup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileAttributeInfoListHandle>))] MentorLake.Gio.GFileAttributeInfoListHandle list);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileAttributeInfoHandle>))]
	internal static extern MentorLake.Gio.GFileAttributeInfoHandle g_file_attribute_info_list_lookup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileAttributeInfoListHandle>))] MentorLake.Gio.GFileAttributeInfoListHandle list, string name);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileAttributeInfoListHandle>))]
	internal static extern MentorLake.Gio.GFileAttributeInfoListHandle g_file_attribute_info_list_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileAttributeInfoListHandle>))] MentorLake.Gio.GFileAttributeInfoListHandle list);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_attribute_info_list_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileAttributeInfoListHandle>))] MentorLake.Gio.GFileAttributeInfoListHandle list);

}

/// <summary>
/// <para>
/// Acts as a lightweight registry for possible valid file attributes.
/// The registry stores Key-Value pair formats as #GFileAttributeInfos.
/// </para>
/// </summary>

public struct GFileAttributeInfoList
{
	/// <summary>
/// <para>
/// an array of #GFileAttributeInfos.
/// </para>
/// </summary>

public IntPtr infos;
	/// <summary>
/// <para>
/// the number of values in the array.
/// </para>
/// </summary>

public int n_infos;
}
