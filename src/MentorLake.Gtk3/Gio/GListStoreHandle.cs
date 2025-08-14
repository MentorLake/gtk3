namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GListStore` is a simple implementation of [iface@Gio.ListModel] that stores
/// all items in memory.
/// </para>
/// <para>
/// It provides insertions, deletions, and lookups in logarithmic time
/// with a fast path for the common case of iterating the list linearly.
/// </para>
/// </summary>

public class GListStoreHandle : GObjectHandle, GListModelHandle
{
/// <summary>
/// <para>
/// Creates a new #GListStore with items of type @item_type. @item_type
/// must be a subclass of #GObject.
/// </para>
/// </summary>

/// <param name="item_type">
/// the #GType of items in the list
/// </param>
/// <return>
/// a new #GListStore
/// </return>

	public static MentorLake.Gio.GListStoreHandle New(MentorLake.GObject.GType item_type)
	{
		return GListStoreHandleExterns.g_list_store_new(item_type);
	}

}
public static class GListStoreHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted whenever items were added to or removed
/// from @list. At @position, @removed items were removed and @added
/// items were added in their place.
/// </para>
/// <para>
/// Note: If `removed != added`, the positions of all later items
/// in the model change.
/// </para>
/// </summary>

	public static IObservable<GListStoreHandleSignalStructs.ItemsChangedSignal> Signal_ItemsChanged(this GListStoreHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GListStoreHandleSignalStructs.ItemsChangedSignal> obs) =>
		{
			GListStoreHandleSignalDelegates.items_changed handler = ( MentorLake.Gio.GListModelHandle self,  uint position,  uint removed,  uint added,  IntPtr user_data) =>
			{
				

				var signalStruct = new GListStoreHandleSignalStructs.ItemsChangedSignal()
				{
					Self = self, Position = position, Removed = removed, Added = added, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "items-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GListStoreHandleSignalStructs
{

public class ItemsChangedSignal
{

	public MentorLake.Gio.GListModelHandle Self;
/// <summary>
/// <para>
/// the position at which @list changed
/// </para>
/// </summary>

	public uint Position;
/// <summary>
/// <para>
/// the number of items removed
/// </para>
/// </summary>

	public uint Removed;
/// <summary>
/// <para>
/// the number of items added
/// </para>
/// </summary>

	public uint Added;

	public IntPtr UserData;
}
}

public static class GListStoreHandleSignalDelegates
{

/// <summary>
/// <para>
/// This signal is emitted whenever items were added to or removed
/// from @list. At @position, @removed items were removed and @added
/// items were added in their place.
/// </para>
/// <para>
/// Note: If `removed != added`, the positions of all later items
/// in the model change.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="position">
/// the position at which @list changed
/// </param>
/// <param name="removed">
/// the number of items removed
/// </param>
/// <param name="added">
/// the number of items added
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void items_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GListModelHandleImpl>))] MentorLake.Gio.GListModelHandle self, uint position, uint removed, uint added, IntPtr user_data);

}


public static class GListStoreHandleExtensions
{
/// <summary>
/// <para>
/// Appends @item to @store. @item must be of type #GListStore:item-type.
/// </para>
/// <para>
/// This function takes a ref on @item.
/// </para>
/// <para>
/// Use g_list_store_splice() to append multiple items at the same time
/// efficiently.
/// </para>
/// </summary>

/// <param name="store">
/// a #GListStore
/// </param>
/// <param name="item">
/// the new item
/// </param>

	public static T Append<T>(this T store, MentorLake.GObject.GObjectHandle item) where T : GListStoreHandle
	{
		if (store.IsInvalid) throw new Exception("Invalid handle (GListStoreHandle)");
		GListStoreHandleExterns.g_list_store_append(store, item);
		return store;
	}

/// <summary>
/// <para>
/// Looks up the given @item in the list store by looping over the items until
/// the first occurrence of @item. If @item was not found, then @position will
/// not be set, and this method will return %FALSE.
/// </para>
/// <para>
/// If you need to compare the two items with a custom comparison function, use
/// g_list_store_find_with_equal_func() with a custom #GEqualFunc instead.
/// </para>
/// </summary>

/// <param name="store">
/// a #GListStore
/// </param>
/// <param name="item">
/// an item
/// </param>
/// <param name="position">
/// the first position of @item, if it was found.
/// </param>
/// <return>
/// Whether @store contains @item. If it was found, @position will be
/// set to the position where @item occurred for the first time.
/// </return>

	public static bool Find(this MentorLake.Gio.GListStoreHandle store, MentorLake.GObject.GObjectHandle item, out uint position)
	{
		if (store.IsInvalid) throw new Exception("Invalid handle (GListStoreHandle)");
		return GListStoreHandleExterns.g_list_store_find(store, item, out position);
	}

/// <summary>
/// <para>
/// Looks up the given @item in the list store by looping over the items and
/// comparing them with @equal_func until the first occurrence of @item which
/// matches. If @item was not found, then @position will not be set, and this
/// method will return %FALSE.
/// </para>
/// <para>
/// @item is always passed as second parameter to @equal_func.
/// </para>
/// <para>
/// Since GLib 2.76 it is possible to pass `NULL` for @item.
/// </para>
/// </summary>

/// <param name="store">
/// a #GListStore
/// </param>
/// <param name="item">
/// an item
/// </param>
/// <param name="equal_func">
/// A custom equality check function
/// </param>
/// <param name="position">
/// the first position of @item, if it was found.
/// </param>
/// <return>
/// Whether @store contains @item. If it was found, @position will be
/// set to the position where @item occurred for the first time.
/// </return>

	public static bool FindWithEqualFunc(this MentorLake.Gio.GListStoreHandle store, MentorLake.GObject.GObjectHandle item, MentorLake.GLib.GEqualFunc equal_func, out uint position)
	{
		if (store.IsInvalid) throw new Exception("Invalid handle (GListStoreHandle)");
		return GListStoreHandleExterns.g_list_store_find_with_equal_func(store, item, equal_func, out position);
	}

/// <summary>
/// <para>
/// Like g_list_store_find_with_equal_func() but with an additional @user_data
/// that is passed to @equal_func.
/// </para>
/// <para>
/// @item is always passed as second parameter to @equal_func.
/// </para>
/// <para>
/// Since GLib 2.76 it is possible to pass `NULL` for @item.
/// </para>
/// </summary>

/// <param name="store">
/// a #GListStore
/// </param>
/// <param name="item">
/// an item
/// </param>
/// <param name="equal_func">
/// A custom equality check function
/// </param>
/// <param name="user_data">
/// user data for @equal_func
/// </param>
/// <param name="position">
/// the first position of @item, if it was found.
/// </param>
/// <return>
/// Whether @store contains @item. If it was found, @position will be
/// set to the position where @item occurred for the first time.
/// </return>

	public static bool FindWithEqualFuncFull(this MentorLake.Gio.GListStoreHandle store, MentorLake.GObject.GObjectHandle item, MentorLake.GLib.GEqualFuncFull equal_func, IntPtr user_data, out uint position)
	{
		if (store.IsInvalid) throw new Exception("Invalid handle (GListStoreHandle)");
		return GListStoreHandleExterns.g_list_store_find_with_equal_func_full(store, item, equal_func, user_data, out position);
	}

/// <summary>
/// <para>
/// Inserts @item into @store at @position. @item must be of type
/// #GListStore:item-type or derived from it. @position must be smaller
/// than the length of the list, or equal to it to append.
/// </para>
/// <para>
/// This function takes a ref on @item.
/// </para>
/// <para>
/// Use g_list_store_splice() to insert multiple items at the same time
/// efficiently.
/// </para>
/// </summary>

/// <param name="store">
/// a #GListStore
/// </param>
/// <param name="position">
/// the position at which to insert the new item
/// </param>
/// <param name="item">
/// the new item
/// </param>

	public static T Insert<T>(this T store, uint position, MentorLake.GObject.GObjectHandle item) where T : GListStoreHandle
	{
		if (store.IsInvalid) throw new Exception("Invalid handle (GListStoreHandle)");
		GListStoreHandleExterns.g_list_store_insert(store, position, item);
		return store;
	}

/// <summary>
/// <para>
/// Inserts @item into @store at a position to be determined by the
/// @compare_func.
/// </para>
/// <para>
/// The list must already be sorted before calling this function or the
/// result is undefined.  Usually you would approach this by only ever
/// inserting items by way of this function.
/// </para>
/// <para>
/// This function takes a ref on @item.
/// </para>
/// </summary>

/// <param name="store">
/// a #GListStore
/// </param>
/// <param name="item">
/// the new item
/// </param>
/// <param name="compare_func">
/// pairwise comparison function for sorting
/// </param>
/// <param name="user_data">
/// user data for @compare_func
/// </param>
/// <return>
/// the position at which @item was inserted
/// </return>

	public static uint InsertSorted(this MentorLake.Gio.GListStoreHandle store, MentorLake.GObject.GObjectHandle item, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data)
	{
		if (store.IsInvalid) throw new Exception("Invalid handle (GListStoreHandle)");
		return GListStoreHandleExterns.g_list_store_insert_sorted(store, item, compare_func, user_data);
	}

/// <summary>
/// <para>
/// Removes the item from @store that is at @position. @position must be
/// smaller than the current length of the list.
/// </para>
/// <para>
/// Use g_list_store_splice() to remove multiple items at the same time
/// efficiently.
/// </para>
/// </summary>

/// <param name="store">
/// a #GListStore
/// </param>
/// <param name="position">
/// the position of the item that is to be removed
/// </param>

	public static T Remove<T>(this T store, uint position) where T : GListStoreHandle
	{
		if (store.IsInvalid) throw new Exception("Invalid handle (GListStoreHandle)");
		GListStoreHandleExterns.g_list_store_remove(store, position);
		return store;
	}

/// <summary>
/// <para>
/// Removes all items from @store.
/// </para>
/// </summary>

/// <param name="store">
/// a #GListStore
/// </param>

	public static T RemoveAll<T>(this T store) where T : GListStoreHandle
	{
		if (store.IsInvalid) throw new Exception("Invalid handle (GListStoreHandle)");
		GListStoreHandleExterns.g_list_store_remove_all(store);
		return store;
	}

/// <summary>
/// <para>
/// Sort the items in @store according to @compare_func.
/// </para>
/// </summary>

/// <param name="store">
/// a #GListStore
/// </param>
/// <param name="compare_func">
/// pairwise comparison function for sorting
/// </param>
/// <param name="user_data">
/// user data for @compare_func
/// </param>

	public static T Sort<T>(this T store, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data) where T : GListStoreHandle
	{
		if (store.IsInvalid) throw new Exception("Invalid handle (GListStoreHandle)");
		GListStoreHandleExterns.g_list_store_sort(store, compare_func, user_data);
		return store;
	}

/// <summary>
/// <para>
/// Changes @store by removing @n_removals items and adding @n_additions
/// items to it. @additions must contain @n_additions items of type
/// #GListStore:item-type.  %NULL is not permitted.
/// </para>
/// <para>
/// This function is more efficient than g_list_store_insert() and
/// g_list_store_remove(), because it only emits
/// #GListModel::items-changed once for the change.
/// </para>
/// <para>
/// This function takes a ref on each item in @additions.
/// </para>
/// <para>
/// The parameters @position and @n_removals must be correct (ie:
/// @position + @n_removals must be less than or equal to the length of
/// the list at the time this function is called).
/// </para>
/// </summary>

/// <param name="store">
/// a #GListStore
/// </param>
/// <param name="position">
/// the position at which to make the change
/// </param>
/// <param name="n_removals">
/// the number of items to remove
/// </param>
/// <param name="additions">
/// the items to add
/// </param>
/// <param name="n_additions">
/// the number of items to add
/// </param>

	public static T Splice<T>(this T store, uint position, uint n_removals, MentorLake.GObject.GObjectHandle[] additions, uint n_additions) where T : GListStoreHandle
	{
		if (store.IsInvalid) throw new Exception("Invalid handle (GListStoreHandle)");
		GListStoreHandleExterns.g_list_store_splice(store, position, n_removals, additions, n_additions);
		return store;
	}

}

internal class GListStoreHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GListStoreHandle>))]
	internal static extern MentorLake.Gio.GListStoreHandle g_list_store_new(MentorLake.GObject.GType item_type);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_list_store_append([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GListStoreHandle>))] MentorLake.Gio.GListStoreHandle store, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle item);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_list_store_find([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GListStoreHandle>))] MentorLake.Gio.GListStoreHandle store, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle item, out uint position);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_list_store_find_with_equal_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GListStoreHandle>))] MentorLake.Gio.GListStoreHandle store, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle item, MentorLake.GLib.GEqualFunc equal_func, out uint position);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_list_store_find_with_equal_func_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GListStoreHandle>))] MentorLake.Gio.GListStoreHandle store, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle item, MentorLake.GLib.GEqualFuncFull equal_func, IntPtr user_data, out uint position);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_list_store_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GListStoreHandle>))] MentorLake.Gio.GListStoreHandle store, uint position, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle item);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_list_store_insert_sorted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GListStoreHandle>))] MentorLake.Gio.GListStoreHandle store, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle item, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_list_store_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GListStoreHandle>))] MentorLake.Gio.GListStoreHandle store, uint position);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_list_store_remove_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GListStoreHandle>))] MentorLake.Gio.GListStoreHandle store);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_list_store_sort([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GListStoreHandle>))] MentorLake.Gio.GListStoreHandle store, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_list_store_splice([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GListStoreHandle>))] MentorLake.Gio.GListStoreHandle store, uint position, uint n_removals, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 4, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle[] additions, uint n_additions);

}
