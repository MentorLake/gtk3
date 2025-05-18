namespace MentorLake.Pango;

public class PangoAttrListHandle : BaseSafeHandle
{
	public static MentorLake.Pango.PangoAttrListHandle New()
	{
		return PangoAttrListExterns.pango_attr_list_new();
	}

}


public static class PangoAttrListExtensions
{
	public static void Change(this MentorLake.Pango.PangoAttrListHandle list, MentorLake.Pango.PangoAttributeHandle attr)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (PangoAttrList)");
		PangoAttrListExterns.pango_attr_list_change(list, attr);
	}

	public static MentorLake.Pango.PangoAttrListHandle Copy(this MentorLake.Pango.PangoAttrListHandle list)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (PangoAttrList)");
		return PangoAttrListExterns.pango_attr_list_copy(list);
	}

	public static bool Equal(this MentorLake.Pango.PangoAttrListHandle list, MentorLake.Pango.PangoAttrListHandle other_list)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (PangoAttrList)");
		return PangoAttrListExterns.pango_attr_list_equal(list, other_list);
	}

	public static MentorLake.Pango.PangoAttrListHandle Filter(this MentorLake.Pango.PangoAttrListHandle list, MentorLake.Pango.PangoAttrFilterFunc func, IntPtr data)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (PangoAttrList)");
		return PangoAttrListExterns.pango_attr_list_filter(list, func, data);
	}

	public static MentorLake.GLib.GSListHandle GetAttributes(this MentorLake.Pango.PangoAttrListHandle list)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (PangoAttrList)");
		return PangoAttrListExterns.pango_attr_list_get_attributes(list);
	}

	public static MentorLake.Pango.PangoAttrIteratorHandle GetIterator(this MentorLake.Pango.PangoAttrListHandle list)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (PangoAttrList)");
		return PangoAttrListExterns.pango_attr_list_get_iterator(list);
	}

	public static void Insert(this MentorLake.Pango.PangoAttrListHandle list, MentorLake.Pango.PangoAttributeHandle attr)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (PangoAttrList)");
		PangoAttrListExterns.pango_attr_list_insert(list, attr);
	}

	public static void InsertBefore(this MentorLake.Pango.PangoAttrListHandle list, MentorLake.Pango.PangoAttributeHandle attr)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (PangoAttrList)");
		PangoAttrListExterns.pango_attr_list_insert_before(list, attr);
	}

	public static MentorLake.Pango.PangoAttrListHandle Ref(this MentorLake.Pango.PangoAttrListHandle list)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (PangoAttrList)");
		return PangoAttrListExterns.pango_attr_list_ref(list);
	}

	public static void Splice(this MentorLake.Pango.PangoAttrListHandle list, MentorLake.Pango.PangoAttrListHandle other, int pos, int len)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (PangoAttrList)");
		PangoAttrListExterns.pango_attr_list_splice(list, other, pos, len);
	}

	public static string ToString(this MentorLake.Pango.PangoAttrListHandle list)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (PangoAttrList)");
		return PangoAttrListExterns.pango_attr_list_to_string(list);
	}

	public static void Unref(this MentorLake.Pango.PangoAttrListHandle list)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (PangoAttrList)");
		PangoAttrListExterns.pango_attr_list_unref(list);
	}

	public static void Update(this MentorLake.Pango.PangoAttrListHandle list, int pos, int remove, int add)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (PangoAttrList)");
		PangoAttrListExterns.pango_attr_list_update(list, pos, remove, add);
	}


	public static PangoAttrList Dereference(this PangoAttrListHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoAttrList>(x.DangerousGetHandle());
}
internal class PangoAttrListExterns
{
	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))]
	internal static extern MentorLake.Pango.PangoAttrListHandle pango_attr_list_new();

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_attr_list_change([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))] MentorLake.Pango.PangoAttributeHandle attr);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))]
	internal static extern MentorLake.Pango.PangoAttrListHandle pango_attr_list_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle list);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_attr_list_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle other_list);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))]
	internal static extern MentorLake.Pango.PangoAttrListHandle pango_attr_list_filter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle list, MentorLake.Pango.PangoAttrFilterFunc func, IntPtr data);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle pango_attr_list_get_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle list);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrIteratorHandle>))]
	internal static extern MentorLake.Pango.PangoAttrIteratorHandle pango_attr_list_get_iterator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle list);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_attr_list_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))] MentorLake.Pango.PangoAttributeHandle attr);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_attr_list_insert_before([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))] MentorLake.Pango.PangoAttributeHandle attr);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))]
	internal static extern MentorLake.Pango.PangoAttrListHandle pango_attr_list_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle list);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_attr_list_splice([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle other, int pos, int len);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string pango_attr_list_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle list);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_attr_list_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle list);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_attr_list_update([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle list, int pos, int remove, int add);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))]
	internal static extern MentorLake.Pango.PangoAttrListHandle pango_attr_list_from_string(string text);

}

public struct PangoAttrList
{
	public static MentorLake.Pango.PangoAttrListHandle FromString(string text)
	{
		return PangoAttrListExterns.pango_attr_list_from_string(text);
	}

}
