namespace MentorLake.Gtk3.Gio;

public interface GListModelHandle
{
}

internal class GListModelHandleImpl : BaseSafeHandle, GListModelHandle
{
}

public static class GListModelHandleExtensions
{
	public static IntPtr GetItem(this GListModelHandle list, uint position)
	{
		return GListModelExterns.g_list_model_get_item(list, position);
	}

	public static GType GetItemType(this GListModelHandle list)
	{
		return GListModelExterns.g_list_model_get_item_type(list);
	}

	public static uint GetNItems(this GListModelHandle list)
	{
		return GListModelExterns.g_list_model_get_n_items(list);
	}

	public static GObjectHandle GetObject(this GListModelHandle list, uint position)
	{
		return GListModelExterns.g_list_model_get_object(list, position);
	}

	public static T ItemsChanged<T>(this T list, uint position, uint removed, uint added) where T : GListModelHandle
	{
		GListModelExterns.g_list_model_items_changed(list, position, removed, added);
		return list;
	}

}

internal class GListModelExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern IntPtr g_list_model_get_item(GListModelHandle list, uint position);

	[DllImport(Libraries.Gio)]
	internal static extern GType g_list_model_get_item_type(GListModelHandle list);

	[DllImport(Libraries.Gio)]
	internal static extern uint g_list_model_get_n_items(GListModelHandle list);

	[DllImport(Libraries.Gio)]
	internal static extern GObjectHandle g_list_model_get_object(GListModelHandle list, uint position);

	[DllImport(Libraries.Gio)]
	internal static extern void g_list_model_items_changed(GListModelHandle list, uint position, uint removed, uint added);

}
