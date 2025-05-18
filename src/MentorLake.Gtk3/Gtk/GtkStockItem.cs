namespace MentorLake.Gtk;

public class GtkStockItemHandle : BaseSafeHandle
{
}


public static class GtkStockItemExtensions
{
	public static MentorLake.Gtk.GtkStockItemHandle Copy(this MentorLake.Gtk.GtkStockItemHandle item)
	{
		if (item.IsInvalid) throw new Exception("Invalid handle (GtkStockItem)");
		return GtkStockItemExterns.gtk_stock_item_copy(item);
	}

	public static void Free(this MentorLake.Gtk.GtkStockItemHandle item)
	{
		if (item.IsInvalid) throw new Exception("Invalid handle (GtkStockItem)");
		GtkStockItemExterns.gtk_stock_item_free(item);
	}


	public static GtkStockItem Dereference(this GtkStockItemHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkStockItem>(x.DangerousGetHandle());
}
internal class GtkStockItemExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStockItemHandle>))]
	internal static extern MentorLake.Gtk.GtkStockItemHandle gtk_stock_item_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStockItemHandle>))] MentorLake.Gtk.GtkStockItemHandle item);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_stock_item_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStockItemHandle>))] MentorLake.Gtk.GtkStockItemHandle item);

}

public struct GtkStockItem
{
	public string stock_id;
	public string label;
	public GdkModifierType modifier;
	public uint keyval;
	public string translation_domain;
}
