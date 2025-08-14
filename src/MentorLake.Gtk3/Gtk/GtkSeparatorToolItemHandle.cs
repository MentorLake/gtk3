namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A #GtkSeparatorToolItem is a #GtkToolItem that separates groups of other
/// #GtkToolItems. Depending on the theme, a #GtkSeparatorToolItem will
/// often look like a vertical line on horizontally docked toolbars.
/// </para>
/// <para>
/// If the #GtkToolbar child property “expand” is %TRUE and the property
/// #GtkSeparatorToolItem:draw is %FALSE, a #GtkSeparatorToolItem will act as
/// a “spring” that forces other items to the ends of the toolbar.
/// </para>
/// <para>
/// Use gtk_separator_tool_item_new() to create a new #GtkSeparatorToolItem.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// GtkSeparatorToolItem has a single CSS node with name separator.
/// </para>
/// </summary>

public class GtkSeparatorToolItemHandle : GtkToolItemHandle, AtkImplementorIfaceHandle, GtkActivatableHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Create a new #GtkSeparatorToolItem
/// </para>
/// </summary>

/// <return>
/// the new #GtkSeparatorToolItem
/// </return>

	public static MentorLake.Gtk.GtkSeparatorToolItemHandle New()
	{
		return GtkSeparatorToolItemHandleExterns.gtk_separator_tool_item_new();
	}

}

public static class GtkSeparatorToolItemHandleExtensions
{
/// <summary>
/// <para>
/// Returns whether @item is drawn as a line, or just blank.
/// See gtk_separator_tool_item_set_draw().
/// </para>
/// </summary>

/// <param name="item">
/// a #GtkSeparatorToolItem
/// </param>
/// <return>
/// %TRUE if @item is drawn as a line, or just blank.
/// </return>

	public static bool GetDraw(this MentorLake.Gtk.GtkSeparatorToolItemHandle item)
	{
		if (item.IsInvalid) throw new Exception("Invalid handle (GtkSeparatorToolItemHandle)");
		return GtkSeparatorToolItemHandleExterns.gtk_separator_tool_item_get_draw(item);
	}

/// <summary>
/// <para>
/// Whether @item is drawn as a vertical line, or just blank.
/// Setting this to %FALSE along with gtk_tool_item_set_expand() is useful
/// to create an item that forces following items to the end of the toolbar.
/// </para>
/// </summary>

/// <param name="item">
/// a #GtkSeparatorToolItem
/// </param>
/// <param name="draw">
/// whether @item is drawn as a vertical line
/// </param>

	public static T SetDraw<T>(this T item, bool draw) where T : GtkSeparatorToolItemHandle
	{
		if (item.IsInvalid) throw new Exception("Invalid handle (GtkSeparatorToolItemHandle)");
		GtkSeparatorToolItemHandleExterns.gtk_separator_tool_item_set_draw(item, draw);
		return item;
	}

}

internal class GtkSeparatorToolItemHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkSeparatorToolItemHandle>))]
	internal static extern MentorLake.Gtk.GtkSeparatorToolItemHandle gtk_separator_tool_item_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_separator_tool_item_get_draw([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSeparatorToolItemHandle>))] MentorLake.Gtk.GtkSeparatorToolItemHandle item);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_separator_tool_item_set_draw([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSeparatorToolItemHandle>))] MentorLake.Gtk.GtkSeparatorToolItemHandle item, bool draw);

}
