namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// One item of the #WebKitBackForwardList.
/// </para>
/// <para>
/// A history item is part of the #WebKitBackForwardList and consists
/// out of a title and a URI.
/// </para>
/// </summary>

public class WebKitBackForwardListItemHandle : GInitiallyUnownedHandle
{
}

public static class WebKitBackForwardListItemHandleExtensions
{
/// <summary>
/// <para>
/// Obtain the original URI of the item.
/// </para>
/// <para>
/// See also webkit_back_forward_list_item_get_uri().
/// </para>
/// </summary>

/// <param name="list_item">
/// a #WebKitBackForwardListItem
/// </param>
/// <return>
/// the original URI of @list_item or %NULL
///    when the original URI is empty.
/// </return>

	public static string GetOriginalUri(this MentorLake.WebKit2.WebKitBackForwardListItemHandle list_item)
	{
		if (list_item.IsInvalid) throw new Exception("Invalid handle (WebKitBackForwardListItemHandle)");
		return WebKitBackForwardListItemHandleExterns.webkit_back_forward_list_item_get_original_uri(list_item);
	}

/// <summary>
/// <para>
/// Obtain the title of the item.
/// </para>
/// </summary>

/// <param name="list_item">
/// a #WebKitBackForwardListItem
/// </param>
/// <return>
/// the page title of @list_item or %NULL
///    when the title is empty.
/// </return>

	public static string GetTitle(this MentorLake.WebKit2.WebKitBackForwardListItemHandle list_item)
	{
		if (list_item.IsInvalid) throw new Exception("Invalid handle (WebKitBackForwardListItemHandle)");
		return WebKitBackForwardListItemHandleExterns.webkit_back_forward_list_item_get_title(list_item);
	}

/// <summary>
/// <para>
/// Obtain the URI of the item.
/// </para>
/// <para>
/// This URI may differ from the original URI if the page was,
/// for example, redirected to a new location.
/// See also webkit_back_forward_list_item_get_original_uri().
/// </para>
/// </summary>

/// <param name="list_item">
/// a #WebKitBackForwardListItem
/// </param>
/// <return>
/// the URI of @list_item or %NULL
///    when the URI is empty.
/// </return>

	public static string GetUri(this MentorLake.WebKit2.WebKitBackForwardListItemHandle list_item)
	{
		if (list_item.IsInvalid) throw new Exception("Invalid handle (WebKitBackForwardListItemHandle)");
		return WebKitBackForwardListItemHandleExterns.webkit_back_forward_list_item_get_uri(list_item);
	}

}

internal class WebKitBackForwardListItemHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_back_forward_list_item_get_original_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitBackForwardListItemHandle>))] MentorLake.WebKit2.WebKitBackForwardListItemHandle list_item);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_back_forward_list_item_get_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitBackForwardListItemHandle>))] MentorLake.WebKit2.WebKitBackForwardListItemHandle list_item);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_back_forward_list_item_get_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitBackForwardListItemHandle>))] MentorLake.WebKit2.WebKitBackForwardListItemHandle list_item);

}
