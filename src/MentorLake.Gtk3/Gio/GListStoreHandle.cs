namespace MentorLake.Gio;

public class GListStoreHandle : GObjectHandle, GListModelHandle
{
	public static MentorLake.Gio.GListStoreHandle New(MentorLake.GObject.GType item_type)
	{
		return GListStoreHandleExterns.g_list_store_new(item_type);
	}

}
public static class GListStoreHandleSignalExtensions
{

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
	public uint Position;
	public uint Removed;
	public uint Added;
	public IntPtr UserData;
}
}

public static class GListStoreHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void items_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GListModelHandleImpl>))] MentorLake.Gio.GListModelHandle self, uint position, uint removed, uint added, IntPtr user_data);

}


public static class GListStoreHandleExtensions
{
	public static T Append<T>(this T store, MentorLake.GObject.GObjectHandle item) where T : GListStoreHandle
	{
		if (store.IsInvalid || store.IsClosed) throw new Exception("Invalid or closed handle (GListStoreHandle)");
		GListStoreHandleExterns.g_list_store_append(store, item);
		return store;
	}

	public static bool Find(this MentorLake.Gio.GListStoreHandle store, MentorLake.GObject.GObjectHandle item, out uint position)
	{
		if (store.IsInvalid || store.IsClosed) throw new Exception("Invalid or closed handle (GListStoreHandle)");
		return GListStoreHandleExterns.g_list_store_find(store, item, out position);
	}

	public static bool FindWithEqualFunc(this MentorLake.Gio.GListStoreHandle store, MentorLake.GObject.GObjectHandle item, MentorLake.GLib.GEqualFunc equal_func, out uint position)
	{
		if (store.IsInvalid || store.IsClosed) throw new Exception("Invalid or closed handle (GListStoreHandle)");
		return GListStoreHandleExterns.g_list_store_find_with_equal_func(store, item, equal_func, out position);
	}

	public static bool FindWithEqualFuncFull(this MentorLake.Gio.GListStoreHandle store, MentorLake.GObject.GObjectHandle item, MentorLake.GLib.GEqualFuncFull equal_func, IntPtr user_data, out uint position)
	{
		if (store.IsInvalid || store.IsClosed) throw new Exception("Invalid or closed handle (GListStoreHandle)");
		return GListStoreHandleExterns.g_list_store_find_with_equal_func_full(store, item, equal_func, user_data, out position);
	}

	public static T Insert<T>(this T store, uint position, MentorLake.GObject.GObjectHandle item) where T : GListStoreHandle
	{
		if (store.IsInvalid || store.IsClosed) throw new Exception("Invalid or closed handle (GListStoreHandle)");
		GListStoreHandleExterns.g_list_store_insert(store, position, item);
		return store;
	}

	public static uint InsertSorted(this MentorLake.Gio.GListStoreHandle store, MentorLake.GObject.GObjectHandle item, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data)
	{
		if (store.IsInvalid || store.IsClosed) throw new Exception("Invalid or closed handle (GListStoreHandle)");
		return GListStoreHandleExterns.g_list_store_insert_sorted(store, item, compare_func, user_data);
	}

	public static T Remove<T>(this T store, uint position) where T : GListStoreHandle
	{
		if (store.IsInvalid || store.IsClosed) throw new Exception("Invalid or closed handle (GListStoreHandle)");
		GListStoreHandleExterns.g_list_store_remove(store, position);
		return store;
	}

	public static T RemoveAll<T>(this T store) where T : GListStoreHandle
	{
		if (store.IsInvalid || store.IsClosed) throw new Exception("Invalid or closed handle (GListStoreHandle)");
		GListStoreHandleExterns.g_list_store_remove_all(store);
		return store;
	}

	public static T Sort<T>(this T store, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data) where T : GListStoreHandle
	{
		if (store.IsInvalid || store.IsClosed) throw new Exception("Invalid or closed handle (GListStoreHandle)");
		GListStoreHandleExterns.g_list_store_sort(store, compare_func, user_data);
		return store;
	}

	public static T Splice<T>(this T store, uint position, uint n_removals, MentorLake.GObject.GObjectHandle[] additions, uint n_additions) where T : GListStoreHandle
	{
		if (store.IsInvalid || store.IsClosed) throw new Exception("Invalid or closed handle (GListStoreHandle)");
		GListStoreHandleExterns.g_list_store_splice(store, position, n_removals, additions, n_additions);
		return store;
	}

}

internal class GListStoreHandleExterns
{
	[DllImport(GioLibrary.Name)]
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
