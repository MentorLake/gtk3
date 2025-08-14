namespace MentorLake.Gtk;


public class GtkStockItemHandle : BaseSafeHandle
{
}


public static class GtkStockItemExtensions
{
/// <summary>
/// <para>
/// Copies a stock item, mostly useful for language bindings and not in applications.
/// </para>
/// </summary>

/// <param name="item">
/// a #GtkStockItem
/// </param>
/// <return>
/// a new #GtkStockItem
/// </return>

	public static MentorLake.Gtk.GtkStockItemHandle Copy(this MentorLake.Gtk.GtkStockItemHandle item)
	{
		if (item.IsInvalid) throw new Exception("Invalid handle (GtkStockItem)");
		return GtkStockItemExterns.gtk_stock_item_copy(item);
	}

/// <summary>
/// <para>
/// Frees a stock item allocated on the heap, such as one returned by
/// gtk_stock_item_copy(). Also frees the fields inside the stock item,
/// if they are not %NULL.
/// </para>
/// </summary>

/// <param name="item">
/// a #GtkStockItem
/// </param>

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
	/// <summary>
/// <para>
/// Identifier.
/// </para>
/// </summary>

public string stock_id;
	/// <summary>
/// <para>
/// User visible label.
/// </para>
/// </summary>

public string label;
	/// <summary>
/// <para>
/// Modifier type for keyboard accelerator
/// </para>
/// </summary>

public GdkModifierType modifier;
	/// <summary>
/// <para>
/// Keyboard accelerator
/// </para>
/// </summary>

public uint keyval;
	/// <summary>
/// <para>
/// Translation domain of the menu or toolbar item
/// </para>
/// </summary>

public string translation_domain;
}
