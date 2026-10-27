namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// List of visited pages.
/// </para>
/// <para>
/// WebKitBackForwardList maintains a list of visited pages used to
/// navigate to recent pages. Items are inserted in the list in the
/// order they are visited.
/// </para>
/// <para>
/// WebKitBackForwardList also maintains the notion of the current item
/// (which is always at index 0), the preceding item (which is at index -1),
/// and the following item (which is at index 1).
/// Methods webkit_web_view_go_back() and webkit_web_view_go_forward() move
/// the current item backward or forward by one. Method
/// webkit_web_view_go_to_back_forward_list_item() sets the current item to the
/// specified item. All other methods returning #WebKitBackForwardListItem&amp;lt;!-- --&amp;gt;s
/// do not change the value of the current item, they just return the requested
/// item or items.
/// </para>
/// </summary>

public class WebKitBackForwardListHandle : GObjectHandle
{
}
public static class WebKitBackForwardListHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted when @back_forward_list changes. This happens
/// when the current item is updated, a new item is added or one or more
/// items are removed. Note that both @item_added and @items_removed can
/// %NULL when only the current item is updated. Items are only removed
/// when the list is cleared or the maximum items limit is reached.
/// </para>
/// </summary>

	public static IObservable<WebKitBackForwardListHandleSignalStructs.ChangedSignal> Signal_Changed(this WebKitBackForwardListHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitBackForwardListHandleSignalStructs.ChangedSignal> obs) =>
		{
			WebKitBackForwardListHandleSignalDelegates.changed handler = ( MentorLake.WebKit2.WebKitBackForwardListHandle self,  MentorLake.WebKit2.WebKitBackForwardListItemHandle item_added,  IntPtr items_removed,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitBackForwardListHandleSignalStructs.ChangedSignal()
				{
					Self = self, ItemAdded = item_added, ItemsRemoved = items_removed, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class WebKitBackForwardListHandleSignalStructs
{

public class ChangedSignal
{

	public MentorLake.WebKit2.WebKitBackForwardListHandle Self;
/// <summary>
/// <para>
/// the #WebKitBackForwardListItem added or %NULL
/// </para>
/// </summary>

	public MentorLake.WebKit2.WebKitBackForwardListItemHandle ItemAdded;
/// <summary>
/// <para>
/// a #GList of #WebKitBackForwardListItem&amp;lt;!-- --&amp;gt;s
/// </para>
/// </summary>

	public IntPtr ItemsRemoved;

	public IntPtr UserData;
}
}

public static class WebKitBackForwardListHandleSignalDelegates
{

/// <summary>
/// <para>
/// This signal is emitted when @back_forward_list changes. This happens
/// when the current item is updated, a new item is added or one or more
/// items are removed. Note that both @item_added and @items_removed can
/// %NULL when only the current item is updated. Items are only removed
/// when the list is cleared or the maximum items limit is reached.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="item_added">
/// the #WebKitBackForwardListItem added or %NULL
/// </param>
/// <param name="items_removed">
/// a #GList of #WebKitBackForwardListItem&amp;lt;!-- --&amp;gt;s
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitBackForwardListHandle>))] MentorLake.WebKit2.WebKitBackForwardListHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitBackForwardListItemHandle>))] MentorLake.WebKit2.WebKitBackForwardListItemHandle item_added, IntPtr items_removed, IntPtr user_data);

}


public static class WebKitBackForwardListHandleExtensions
{
/// <summary>
/// <para>
/// Returns the item that precedes the current item.
/// </para>
/// </summary>

/// <param name="back_forward_list">
/// a #WebKitBackForwardList
/// </param>
/// <return>
/// the #WebKitBackForwardListItem
///    preceding the current item or %NULL.
/// </return>

	public static MentorLake.WebKit2.WebKitBackForwardListItemHandle GetBackItem(this MentorLake.WebKit2.WebKitBackForwardListHandle back_forward_list)
	{
		if (back_forward_list.IsInvalid) throw new Exception("Invalid handle (WebKitBackForwardListHandle)");
		return WebKitBackForwardListHandleExterns.webkit_back_forward_list_get_back_item(back_forward_list);
	}

/// <summary>
/// <para>
/// Obtain the list of items preceding the current one.
/// </para>
/// </summary>

/// <param name="back_forward_list">
/// a #WebKitBackForwardList
/// </param>
/// <return>
/// a #GList of
///    items preceding the current item.
/// </return>

	public static MentorLake.GLib.GListHandle GetBackList(this MentorLake.WebKit2.WebKitBackForwardListHandle back_forward_list)
	{
		if (back_forward_list.IsInvalid) throw new Exception("Invalid handle (WebKitBackForwardListHandle)");
		return WebKitBackForwardListHandleExterns.webkit_back_forward_list_get_back_list(back_forward_list);
	}

/// <summary>
/// <para>
/// Obtain a list up to some number of items preceding the current one.
/// </para>
/// </summary>

/// <param name="back_forward_list">
/// a #WebKitBackForwardList
/// </param>
/// <param name="limit">
/// the number of items to retrieve
/// </param>
/// <return>
/// a #GList of
///    items preceding the current item limited by @limit.
/// </return>

	public static MentorLake.GLib.GListHandle GetBackListWithLimit(this MentorLake.WebKit2.WebKitBackForwardListHandle back_forward_list, uint limit)
	{
		if (back_forward_list.IsInvalid) throw new Exception("Invalid handle (WebKitBackForwardListHandle)");
		return WebKitBackForwardListHandleExterns.webkit_back_forward_list_get_back_list_with_limit(back_forward_list, limit);
	}

/// <summary>
/// <para>
/// Returns the current item in @back_forward_list.
/// </para>
/// </summary>

/// <param name="back_forward_list">
/// a #WebKitBackForwardList
/// </param>
/// <return>
/// a #WebKitBackForwardListItem
///    or %NULL if @back_forward_list is empty.
/// </return>

	public static MentorLake.WebKit2.WebKitBackForwardListItemHandle GetCurrentItem(this MentorLake.WebKit2.WebKitBackForwardListHandle back_forward_list)
	{
		if (back_forward_list.IsInvalid) throw new Exception("Invalid handle (WebKitBackForwardListHandle)");
		return WebKitBackForwardListHandleExterns.webkit_back_forward_list_get_current_item(back_forward_list);
	}

/// <summary>
/// <para>
/// Returns the item that follows the current item.
/// </para>
/// </summary>

/// <param name="back_forward_list">
/// a #WebKitBackForwardList
/// </param>
/// <return>
/// the #WebKitBackForwardListItem
///    following the current item or %NULL.
/// </return>

	public static MentorLake.WebKit2.WebKitBackForwardListItemHandle GetForwardItem(this MentorLake.WebKit2.WebKitBackForwardListHandle back_forward_list)
	{
		if (back_forward_list.IsInvalid) throw new Exception("Invalid handle (WebKitBackForwardListHandle)");
		return WebKitBackForwardListHandleExterns.webkit_back_forward_list_get_forward_item(back_forward_list);
	}

/// <summary>
/// <para>
/// Obtain the list of items following the current one.
/// </para>
/// </summary>

/// <param name="back_forward_list">
/// a #WebKitBackForwardList
/// </param>
/// <return>
/// a #GList of
///    items following the current item.
/// </return>

	public static MentorLake.GLib.GListHandle GetForwardList(this MentorLake.WebKit2.WebKitBackForwardListHandle back_forward_list)
	{
		if (back_forward_list.IsInvalid) throw new Exception("Invalid handle (WebKitBackForwardListHandle)");
		return WebKitBackForwardListHandleExterns.webkit_back_forward_list_get_forward_list(back_forward_list);
	}

/// <summary>
/// <para>
/// Obtain a list up to some number of items following the current one.
/// </para>
/// </summary>

/// <param name="back_forward_list">
/// a #WebKitBackForwardList
/// </param>
/// <param name="limit">
/// the number of items to retrieve
/// </param>
/// <return>
/// a #GList of
///    items following the current item limited by @limit.
/// </return>

	public static MentorLake.GLib.GListHandle GetForwardListWithLimit(this MentorLake.WebKit2.WebKitBackForwardListHandle back_forward_list, uint limit)
	{
		if (back_forward_list.IsInvalid) throw new Exception("Invalid handle (WebKitBackForwardListHandle)");
		return WebKitBackForwardListHandleExterns.webkit_back_forward_list_get_forward_list_with_limit(back_forward_list, limit);
	}

/// <summary>
/// <para>
/// Obtain the amount of items in the list.
/// </para>
/// </summary>

/// <param name="back_forward_list">
/// a #WebKitBackForwardList
/// </param>
/// <return>
/// the length of @back_forward_list.
/// </return>

	public static uint GetLength(this MentorLake.WebKit2.WebKitBackForwardListHandle back_forward_list)
	{
		if (back_forward_list.IsInvalid) throw new Exception("Invalid handle (WebKitBackForwardListHandle)");
		return WebKitBackForwardListHandleExterns.webkit_back_forward_list_get_length(back_forward_list);
	}

/// <summary>
/// <para>
/// Returns the item at a given index relative to the current item.
/// </para>
/// </summary>

/// <param name="back_forward_list">
/// a #WebKitBackForwardList
/// </param>
/// <param name="index">
/// the index of the item
/// </param>
/// <return>
/// the #WebKitBackForwardListItem
///    located at the specified index relative to the current item or %NULL.
/// </return>

	public static MentorLake.WebKit2.WebKitBackForwardListItemHandle GetNthItem(this MentorLake.WebKit2.WebKitBackForwardListHandle back_forward_list, int index)
	{
		if (back_forward_list.IsInvalid) throw new Exception("Invalid handle (WebKitBackForwardListHandle)");
		return WebKitBackForwardListHandleExterns.webkit_back_forward_list_get_nth_item(back_forward_list, index);
	}

}

internal class WebKitBackForwardListHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitBackForwardListItemHandle>))]
	internal static extern MentorLake.WebKit2.WebKitBackForwardListItemHandle webkit_back_forward_list_get_back_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitBackForwardListHandle>))] MentorLake.WebKit2.WebKitBackForwardListHandle back_forward_list);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle webkit_back_forward_list_get_back_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitBackForwardListHandle>))] MentorLake.WebKit2.WebKitBackForwardListHandle back_forward_list);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle webkit_back_forward_list_get_back_list_with_limit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitBackForwardListHandle>))] MentorLake.WebKit2.WebKitBackForwardListHandle back_forward_list, uint limit);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitBackForwardListItemHandle>))]
	internal static extern MentorLake.WebKit2.WebKitBackForwardListItemHandle webkit_back_forward_list_get_current_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitBackForwardListHandle>))] MentorLake.WebKit2.WebKitBackForwardListHandle back_forward_list);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitBackForwardListItemHandle>))]
	internal static extern MentorLake.WebKit2.WebKitBackForwardListItemHandle webkit_back_forward_list_get_forward_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitBackForwardListHandle>))] MentorLake.WebKit2.WebKitBackForwardListHandle back_forward_list);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle webkit_back_forward_list_get_forward_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitBackForwardListHandle>))] MentorLake.WebKit2.WebKitBackForwardListHandle back_forward_list);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle webkit_back_forward_list_get_forward_list_with_limit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitBackForwardListHandle>))] MentorLake.WebKit2.WebKitBackForwardListHandle back_forward_list, uint limit);

	[DllImport(WebKit2Library.Name)]
	internal static extern uint webkit_back_forward_list_get_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitBackForwardListHandle>))] MentorLake.WebKit2.WebKitBackForwardListHandle back_forward_list);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitBackForwardListItemHandle>))]
	internal static extern MentorLake.WebKit2.WebKitBackForwardListItemHandle webkit_back_forward_list_get_nth_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitBackForwardListHandle>))] MentorLake.WebKit2.WebKitBackForwardListHandle back_forward_list, int index);

}
