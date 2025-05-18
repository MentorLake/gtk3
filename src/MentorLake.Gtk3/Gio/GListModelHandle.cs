namespace MentorLake.Gio;

public interface GListModelHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GListModelHandleImpl : BaseSafeHandle, GListModelHandle
{
}

public static class GListModelHandleExtensions
{
	public static IntPtr GetItem(this MentorLake.Gio.GListModelHandle list, uint position)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (GListModelHandle)");
		return GListModelHandleExterns.g_list_model_get_item(list, position);
	}

	public static MentorLake.GObject.GType GetItemType(this MentorLake.Gio.GListModelHandle list)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (GListModelHandle)");
		return GListModelHandleExterns.g_list_model_get_item_type(list);
	}

	public static uint GetNItems(this MentorLake.Gio.GListModelHandle list)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (GListModelHandle)");
		return GListModelHandleExterns.g_list_model_get_n_items(list);
	}

	public static MentorLake.GObject.GObjectHandle GetObject(this MentorLake.Gio.GListModelHandle list, uint position)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (GListModelHandle)");
		return GListModelHandleExterns.g_list_model_get_object(list, position);
	}

	public static T ItemsChanged<T>(this T list, uint position, uint removed, uint added) where T : GListModelHandle
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (GListModelHandle)");
		GListModelHandleExterns.g_list_model_items_changed(list, position, removed, added);
		return list;
	}

}

internal class GListModelHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern IntPtr g_list_model_get_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GListModelHandleImpl>))] MentorLake.Gio.GListModelHandle list, uint position);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GObject.GType g_list_model_get_item_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GListModelHandleImpl>))] MentorLake.Gio.GListModelHandle list);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_list_model_get_n_items([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GListModelHandleImpl>))] MentorLake.Gio.GListModelHandle list);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle g_list_model_get_object([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GListModelHandleImpl>))] MentorLake.Gio.GListModelHandle list, uint position);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_list_model_items_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GListModelHandleImpl>))] MentorLake.Gio.GListModelHandle list, uint position, uint removed, uint added);

}
