namespace MentorLake.Gtk;

public class GtkListStoreHandle : GObjectHandle, GtkBuildableHandle, GtkTreeDragDestHandle, GtkTreeDragSourceHandle, GtkTreeModelHandle, GtkTreeSortableHandle
{
	public static MentorLake.Gtk.GtkListStoreHandle New(int n_columns, IntPtr @__arglist)
	{
		return GtkListStoreHandleExterns.gtk_list_store_new(n_columns, @__arglist);
	}

	public static MentorLake.Gtk.GtkListStoreHandle Newv(int n_columns, MentorLake.GObject.GType[] types)
	{
		return GtkListStoreHandleExterns.gtk_list_store_newv(n_columns, types);
	}

}

public static class GtkListStoreHandleExtensions
{
	public static T Append<T>(this T list_store, out MentorLake.Gtk.GtkTreeIter iter) where T : GtkListStoreHandle
	{
		GtkListStoreHandleExterns.gtk_list_store_append(list_store, out iter);
		return list_store;
	}

	public static T Clear<T>(this T list_store) where T : GtkListStoreHandle
	{
		GtkListStoreHandleExterns.gtk_list_store_clear(list_store);
		return list_store;
	}

	public static T Insert<T>(this T list_store, out MentorLake.Gtk.GtkTreeIter iter, int position) where T : GtkListStoreHandle
	{
		GtkListStoreHandleExterns.gtk_list_store_insert(list_store, out iter, position);
		return list_store;
	}

	public static T InsertAfter<T>(this T list_store, out MentorLake.Gtk.GtkTreeIter iter, MentorLake.Gtk.GtkTreeIterHandle sibling) where T : GtkListStoreHandle
	{
		GtkListStoreHandleExterns.gtk_list_store_insert_after(list_store, out iter, sibling);
		return list_store;
	}

	public static T InsertBefore<T>(this T list_store, out MentorLake.Gtk.GtkTreeIter iter, MentorLake.Gtk.GtkTreeIterHandle sibling) where T : GtkListStoreHandle
	{
		GtkListStoreHandleExterns.gtk_list_store_insert_before(list_store, out iter, sibling);
		return list_store;
	}

	public static T InsertWithValues<T>(this T list_store, out MentorLake.Gtk.GtkTreeIter iter, int position, IntPtr @__arglist) where T : GtkListStoreHandle
	{
		GtkListStoreHandleExterns.gtk_list_store_insert_with_values(list_store, out iter, position, @__arglist);
		return list_store;
	}

	public static T InsertWithValuesv<T>(this T list_store, out MentorLake.Gtk.GtkTreeIter iter, int position, int[] columns, MentorLake.GObject.GValue[] values, int n_values) where T : GtkListStoreHandle
	{
		GtkListStoreHandleExterns.gtk_list_store_insert_with_valuesv(list_store, out iter, position, columns, values, n_values);
		return list_store;
	}

	public static bool IterIsValid(this MentorLake.Gtk.GtkListStoreHandle list_store, MentorLake.Gtk.GtkTreeIterHandle iter)
	{
		return GtkListStoreHandleExterns.gtk_list_store_iter_is_valid(list_store, iter);
	}

	public static T MoveAfter<T>(this T store, MentorLake.Gtk.GtkTreeIterHandle iter, MentorLake.Gtk.GtkTreeIterHandle position) where T : GtkListStoreHandle
	{
		GtkListStoreHandleExterns.gtk_list_store_move_after(store, iter, position);
		return store;
	}

	public static T MoveBefore<T>(this T store, MentorLake.Gtk.GtkTreeIterHandle iter, MentorLake.Gtk.GtkTreeIterHandle position) where T : GtkListStoreHandle
	{
		GtkListStoreHandleExterns.gtk_list_store_move_before(store, iter, position);
		return store;
	}

	public static T Prepend<T>(this T list_store, out MentorLake.Gtk.GtkTreeIter iter) where T : GtkListStoreHandle
	{
		GtkListStoreHandleExterns.gtk_list_store_prepend(list_store, out iter);
		return list_store;
	}

	public static bool Remove(this MentorLake.Gtk.GtkListStoreHandle list_store, MentorLake.Gtk.GtkTreeIterHandle iter)
	{
		return GtkListStoreHandleExterns.gtk_list_store_remove(list_store, iter);
	}

	public static T Reorder<T>(this T store, int[] new_order) where T : GtkListStoreHandle
	{
		GtkListStoreHandleExterns.gtk_list_store_reorder(store, new_order);
		return store;
	}

	public static T Set<T>(this T list_store, MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr @__arglist) where T : GtkListStoreHandle
	{
		GtkListStoreHandleExterns.gtk_list_store_set(list_store, iter, @__arglist);
		return list_store;
	}

	public static T SetColumnTypes<T>(this T list_store, int n_columns, MentorLake.GObject.GType[] types) where T : GtkListStoreHandle
	{
		GtkListStoreHandleExterns.gtk_list_store_set_column_types(list_store, n_columns, types);
		return list_store;
	}

	public static T SetValist<T>(this T list_store, MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr var_args) where T : GtkListStoreHandle
	{
		GtkListStoreHandleExterns.gtk_list_store_set_valist(list_store, iter, var_args);
		return list_store;
	}

	public static T SetValue<T>(this T list_store, MentorLake.Gtk.GtkTreeIterHandle iter, int column, MentorLake.GObject.GValueHandle value) where T : GtkListStoreHandle
	{
		GtkListStoreHandleExterns.gtk_list_store_set_value(list_store, iter, column, value);
		return list_store;
	}

	public static T SetValuesv<T>(this T list_store, MentorLake.Gtk.GtkTreeIterHandle iter, int[] columns, MentorLake.GObject.GValue[] values, int n_values) where T : GtkListStoreHandle
	{
		GtkListStoreHandleExterns.gtk_list_store_set_valuesv(list_store, iter, columns, values, n_values);
		return list_store;
	}

	public static T Swap<T>(this T store, MentorLake.Gtk.GtkTreeIterHandle a, MentorLake.Gtk.GtkTreeIterHandle b) where T : GtkListStoreHandle
	{
		GtkListStoreHandleExterns.gtk_list_store_swap(store, a, b);
		return store;
	}

}

internal class GtkListStoreHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkListStoreHandle gtk_list_store_new(int n_columns, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkListStoreHandle gtk_list_store_newv(int n_columns, MentorLake.GObject.GType[] types);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_store_append([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListStoreHandle>))] MentorLake.Gtk.GtkListStoreHandle list_store, out MentorLake.Gtk.GtkTreeIter iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_store_clear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListStoreHandle>))] MentorLake.Gtk.GtkListStoreHandle list_store);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_store_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListStoreHandle>))] MentorLake.Gtk.GtkListStoreHandle list_store, out MentorLake.Gtk.GtkTreeIter iter, int position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_store_insert_after([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListStoreHandle>))] MentorLake.Gtk.GtkListStoreHandle list_store, out MentorLake.Gtk.GtkTreeIter iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle sibling);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_store_insert_before([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListStoreHandle>))] MentorLake.Gtk.GtkListStoreHandle list_store, out MentorLake.Gtk.GtkTreeIter iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle sibling);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_store_insert_with_values([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListStoreHandle>))] MentorLake.Gtk.GtkListStoreHandle list_store, out MentorLake.Gtk.GtkTreeIter iter, int position, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_store_insert_with_valuesv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListStoreHandle>))] MentorLake.Gtk.GtkListStoreHandle list_store, out MentorLake.Gtk.GtkTreeIter iter, int position, int[] columns, MentorLake.GObject.GValue[] values, int n_values);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_list_store_iter_is_valid([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListStoreHandle>))] MentorLake.Gtk.GtkListStoreHandle list_store, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_store_move_after([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListStoreHandle>))] MentorLake.Gtk.GtkListStoreHandle store, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_store_move_before([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListStoreHandle>))] MentorLake.Gtk.GtkListStoreHandle store, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_store_prepend([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListStoreHandle>))] MentorLake.Gtk.GtkListStoreHandle list_store, out MentorLake.Gtk.GtkTreeIter iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_list_store_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListStoreHandle>))] MentorLake.Gtk.GtkListStoreHandle list_store, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_store_reorder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListStoreHandle>))] MentorLake.Gtk.GtkListStoreHandle store, int[] new_order);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_store_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListStoreHandle>))] MentorLake.Gtk.GtkListStoreHandle list_store, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_store_set_column_types([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListStoreHandle>))] MentorLake.Gtk.GtkListStoreHandle list_store, int n_columns, MentorLake.GObject.GType[] types);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_store_set_valist([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListStoreHandle>))] MentorLake.Gtk.GtkListStoreHandle list_store, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr var_args);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_store_set_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListStoreHandle>))] MentorLake.Gtk.GtkListStoreHandle list_store, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, int column, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_store_set_valuesv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListStoreHandle>))] MentorLake.Gtk.GtkListStoreHandle list_store, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, int[] columns, MentorLake.GObject.GValue[] values, int n_values);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_list_store_swap([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListStoreHandle>))] MentorLake.Gtk.GtkListStoreHandle store, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle b);

}
