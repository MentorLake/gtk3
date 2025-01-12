namespace MentorLake.Gtk3.Pango;

public class PangoAttrListHandle : BaseSafeHandle
{
	public static PangoAttrListHandle New()
	{
		return PangoAttrListExterns.pango_attr_list_new();
	}

}


public static class PangoAttrListHandleExtensions
{
	public static T Change<T>(this T list, PangoAttributeHandle attr) where T : PangoAttrListHandle
	{
		PangoAttrListExterns.pango_attr_list_change(list, attr);
		return list;
	}

	public static PangoAttrListHandle Copy(this PangoAttrListHandle list)
	{
		return PangoAttrListExterns.pango_attr_list_copy(list);
	}

	public static bool Equal(this PangoAttrListHandle list, PangoAttrListHandle other_list)
	{
		return PangoAttrListExterns.pango_attr_list_equal(list, other_list);
	}

	public static PangoAttrListHandle Filter(this PangoAttrListHandle list, PangoAttrFilterFunc func, IntPtr data)
	{
		return PangoAttrListExterns.pango_attr_list_filter(list, func, data);
	}

	public static GSListHandle GetAttributes(this PangoAttrListHandle list)
	{
		return PangoAttrListExterns.pango_attr_list_get_attributes(list);
	}

	public static PangoAttrIteratorHandle GetIterator(this PangoAttrListHandle list)
	{
		return PangoAttrListExterns.pango_attr_list_get_iterator(list);
	}

	public static T Insert<T>(this T list, PangoAttributeHandle attr) where T : PangoAttrListHandle
	{
		PangoAttrListExterns.pango_attr_list_insert(list, attr);
		return list;
	}

	public static T InsertBefore<T>(this T list, PangoAttributeHandle attr) where T : PangoAttrListHandle
	{
		PangoAttrListExterns.pango_attr_list_insert_before(list, attr);
		return list;
	}

	public static PangoAttrListHandle Ref(this PangoAttrListHandle list)
	{
		return PangoAttrListExterns.pango_attr_list_ref(list);
	}

	public static T Splice<T>(this T list, PangoAttrListHandle other, int pos, int len) where T : PangoAttrListHandle
	{
		PangoAttrListExterns.pango_attr_list_splice(list, other, pos, len);
		return list;
	}

	public static string ToString(this PangoAttrListHandle list)
	{
		return PangoAttrListExterns.pango_attr_list_to_string(list);
	}

	public static T Unref<T>(this T list) where T : PangoAttrListHandle
	{
		PangoAttrListExterns.pango_attr_list_unref(list);
		return list;
	}

	public static T Update<T>(this T list, int pos, int remove, int add) where T : PangoAttrListHandle
	{
		PangoAttrListExterns.pango_attr_list_update(list, pos, remove, add);
		return list;
	}

	public static PangoAttrListHandle FromString(string text)
	{
		return PangoAttrListExterns.pango_attr_list_from_string(text);
	}

}
internal class PangoAttrListExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern PangoAttrListHandle pango_attr_list_new();

	[DllImport(Libraries.Pango)]
	internal static extern void pango_attr_list_change(PangoAttrListHandle list, PangoAttributeHandle attr);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttrListHandle pango_attr_list_copy(PangoAttrListHandle list);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_attr_list_equal(PangoAttrListHandle list, PangoAttrListHandle other_list);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttrListHandle pango_attr_list_filter(PangoAttrListHandle list, PangoAttrFilterFunc func, IntPtr data);

	[DllImport(Libraries.Pango)]
	internal static extern GSListHandle pango_attr_list_get_attributes(PangoAttrListHandle list);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttrIteratorHandle pango_attr_list_get_iterator(PangoAttrListHandle list);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_attr_list_insert(PangoAttrListHandle list, PangoAttributeHandle attr);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_attr_list_insert_before(PangoAttrListHandle list, PangoAttributeHandle attr);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttrListHandle pango_attr_list_ref(PangoAttrListHandle list);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_attr_list_splice(PangoAttrListHandle list, PangoAttrListHandle other, int pos, int len);

	[DllImport(Libraries.Pango)]
	internal static extern string pango_attr_list_to_string(PangoAttrListHandle list);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_attr_list_unref(PangoAttrListHandle list);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_attr_list_update(PangoAttrListHandle list, int pos, int remove, int add);

	[DllImport(Libraries.Pango)]
	internal static extern PangoAttrListHandle pango_attr_list_from_string(string text);

}

public struct PangoAttrList
{
}
