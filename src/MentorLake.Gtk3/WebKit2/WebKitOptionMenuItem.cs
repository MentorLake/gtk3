namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// One item of a #WebKitOptionMenu.
/// </para>
/// <para>
/// The #WebKitOptionMenu is composed of WebKitOptionMenuItem&amp;lt;!-- --&amp;gt;s.
/// A WebKitOptionMenuItem always has a label and can contain a tooltip text.
/// You can use the WebKitOptionMenuItem of a #WebKitOptionMenu to build your
/// own menus.
/// </para>
/// </summary>

public class WebKitOptionMenuItemHandle : BaseSafeHandle
{
}


public static class WebKitOptionMenuItemExtensions
{
/// <summary>
/// <para>
/// Make a copy of the #WebKitOptionMenuItem.
/// </para>
/// </summary>

/// <param name="item">
/// a #WebKitOptionMenuItem
/// </param>
/// <return>
/// A copy of passed in #WebKitOptionMenuItem
/// </return>

	public static MentorLake.WebKit2.WebKitOptionMenuItemHandle Copy(this MentorLake.WebKit2.WebKitOptionMenuItemHandle item)
	{
		if (item.IsInvalid) throw new Exception("Invalid handle (WebKitOptionMenuItem)");
		return WebKitOptionMenuItemExterns.webkit_option_menu_item_copy(item);
	}

/// <summary>
/// <para>
/// Free the #WebKitOptionMenuItem.
/// </para>
/// </summary>

/// <param name="item">
/// A #WebKitOptionMenuItem
/// </param>

	public static void Free(this MentorLake.WebKit2.WebKitOptionMenuItemHandle item)
	{
		if (item.IsInvalid) throw new Exception("Invalid handle (WebKitOptionMenuItem)");
		WebKitOptionMenuItemExterns.webkit_option_menu_item_free(item);
	}

/// <summary>
/// <para>
/// Get the label of a #WebKitOptionMenuItem.
/// </para>
/// </summary>

/// <param name="item">
/// a #WebKitOptionMenuItem
/// </param>
/// <return>
/// The label of @item.
/// </return>

	public static string GetLabel(this MentorLake.WebKit2.WebKitOptionMenuItemHandle item)
	{
		if (item.IsInvalid) throw new Exception("Invalid handle (WebKitOptionMenuItem)");
		return WebKitOptionMenuItemExterns.webkit_option_menu_item_get_label(item);
	}

/// <summary>
/// <para>
/// Get the tooltip of a #WebKitOptionMenuItem.
/// </para>
/// </summary>

/// <param name="item">
/// a #WebKitOptionMenuItem
/// </param>
/// <return>
/// The tooltip of @item, or %NULL.
/// </return>

	public static string GetTooltip(this MentorLake.WebKit2.WebKitOptionMenuItemHandle item)
	{
		if (item.IsInvalid) throw new Exception("Invalid handle (WebKitOptionMenuItem)");
		return WebKitOptionMenuItemExterns.webkit_option_menu_item_get_tooltip(item);
	}

/// <summary>
/// <para>
/// Whether a #WebKitOptionMenuItem is enabled.
/// </para>
/// </summary>

/// <param name="item">
/// a #WebKitOptionMenuItem
/// </param>
/// <return>
/// %TRUE if the @item is enabled or %FALSE otherwise.
/// </return>

	public static bool IsEnabled(this MentorLake.WebKit2.WebKitOptionMenuItemHandle item)
	{
		if (item.IsInvalid) throw new Exception("Invalid handle (WebKitOptionMenuItem)");
		return WebKitOptionMenuItemExterns.webkit_option_menu_item_is_enabled(item);
	}

/// <summary>
/// <para>
/// Whether a #WebKitOptionMenuItem is a group child.
/// </para>
/// </summary>

/// <param name="item">
/// a #WebKitOptionMenuItem
/// </param>
/// <return>
/// %TRUE if the @item is a group child or %FALSE otherwise.
/// </return>

	public static bool IsGroupChild(this MentorLake.WebKit2.WebKitOptionMenuItemHandle item)
	{
		if (item.IsInvalid) throw new Exception("Invalid handle (WebKitOptionMenuItem)");
		return WebKitOptionMenuItemExterns.webkit_option_menu_item_is_group_child(item);
	}

/// <summary>
/// <para>
/// Whether a #WebKitOptionMenuItem is a group label.
/// </para>
/// </summary>

/// <param name="item">
/// a #WebKitOptionMenuItem
/// </param>
/// <return>
/// %TRUE if the @item is a group label or %FALSE otherwise.
/// </return>

	public static bool IsGroupLabel(this MentorLake.WebKit2.WebKitOptionMenuItemHandle item)
	{
		if (item.IsInvalid) throw new Exception("Invalid handle (WebKitOptionMenuItem)");
		return WebKitOptionMenuItemExterns.webkit_option_menu_item_is_group_label(item);
	}

/// <summary>
/// <para>
/// Whether a #WebKitOptionMenuItem is the currently selected one.
/// </para>
/// </summary>

/// <param name="item">
/// a #WebKitOptionMenuItem
/// </param>
/// <return>
/// %TRUE if the @item is selected or %FALSE otherwise.
/// </return>

	public static bool IsSelected(this MentorLake.WebKit2.WebKitOptionMenuItemHandle item)
	{
		if (item.IsInvalid) throw new Exception("Invalid handle (WebKitOptionMenuItem)");
		return WebKitOptionMenuItemExterns.webkit_option_menu_item_is_selected(item);
	}


	public static WebKitOptionMenuItem Dereference(this WebKitOptionMenuItemHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitOptionMenuItem>(x.DangerousGetHandle());
}
internal class WebKitOptionMenuItemExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitOptionMenuItemHandle>))]
	internal static extern MentorLake.WebKit2.WebKitOptionMenuItemHandle webkit_option_menu_item_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitOptionMenuItemHandle>))] MentorLake.WebKit2.WebKitOptionMenuItemHandle item);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_option_menu_item_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitOptionMenuItemHandle>))] MentorLake.WebKit2.WebKitOptionMenuItemHandle item);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_option_menu_item_get_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitOptionMenuItemHandle>))] MentorLake.WebKit2.WebKitOptionMenuItemHandle item);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_option_menu_item_get_tooltip([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitOptionMenuItemHandle>))] MentorLake.WebKit2.WebKitOptionMenuItemHandle item);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_option_menu_item_is_enabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitOptionMenuItemHandle>))] MentorLake.WebKit2.WebKitOptionMenuItemHandle item);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_option_menu_item_is_group_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitOptionMenuItemHandle>))] MentorLake.WebKit2.WebKitOptionMenuItemHandle item);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_option_menu_item_is_group_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitOptionMenuItemHandle>))] MentorLake.WebKit2.WebKitOptionMenuItemHandle item);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_option_menu_item_is_selected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitOptionMenuItemHandle>))] MentorLake.WebKit2.WebKitOptionMenuItemHandle item);

}

/// <summary>
/// <para>
/// One item of a #WebKitOptionMenu.
/// </para>
/// <para>
/// The #WebKitOptionMenu is composed of WebKitOptionMenuItem&amp;lt;!-- --&amp;gt;s.
/// A WebKitOptionMenuItem always has a label and can contain a tooltip text.
/// You can use the WebKitOptionMenuItem of a #WebKitOptionMenu to build your
/// own menus.
/// </para>
/// </summary>

public struct WebKitOptionMenuItem
{
}
