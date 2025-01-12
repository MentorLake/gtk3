namespace MentorLake.Gtk3.Gtk3;

public class GtkStockItemHandle : BaseSafeHandle
{
}


public static class GtkStockItemHandleExtensions
{
	public static GtkStockItemHandle Copy(this GtkStockItemHandle item)
	{
		return GtkStockItemExterns.gtk_stock_item_copy(item);
	}

	public static GtkStockItemHandle Free(this GtkStockItemHandle item)
	{
		GtkStockItemExterns.gtk_stock_item_free(item);
		return item;
	}

}
internal class GtkStockItemExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkStockItemHandle gtk_stock_item_copy(GtkStockItemHandle item);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_stock_item_free(GtkStockItemHandle item);

}

public struct GtkStockItem
{
	public string stock_id;
	public string label;
	public GdkModifierType modifier;
	public uint keyval;
	public string translation_domain;
}
