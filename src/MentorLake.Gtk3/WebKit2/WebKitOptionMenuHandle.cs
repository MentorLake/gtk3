namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Represents the dropdown menu of a `select` element in a #WebKitWebView.
/// </para>
/// <para>
/// When a select element in a #WebKitWebView needs to display a dropdown menu, the signal
/// #WebKitWebView::show-option-menu is emitted, providing a WebKitOptionMenu with the
/// #WebKitOptionMenuItem&amp;lt;!-- --&amp;gt;s that should be displayed.
/// </para>
/// </summary>

public class WebKitOptionMenuHandle : GObjectHandle
{
}
public static class WebKitOptionMenuHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when closing a #WebKitOptionMenu is requested. This can happen
/// when the user explicitly calls webkit_option_menu_close() or when the
/// element is detached from the current page.
/// </para>
/// </summary>

	public static IObservable<WebKitOptionMenuHandleSignalStructs.CloseSignal> Signal_Close(this WebKitOptionMenuHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitOptionMenuHandleSignalStructs.CloseSignal> obs) =>
		{
			WebKitOptionMenuHandleSignalDelegates.close handler = ( MentorLake.WebKit2.WebKitOptionMenuHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitOptionMenuHandleSignalStructs.CloseSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "close", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class WebKitOptionMenuHandleSignalStructs
{

public class CloseSignal
{

	public MentorLake.WebKit2.WebKitOptionMenuHandle Self;

	public IntPtr UserData;
}
}

public static class WebKitOptionMenuHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted when closing a #WebKitOptionMenu is requested. This can happen
/// when the user explicitly calls webkit_option_menu_close() or when the
/// element is detached from the current page.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitOptionMenuHandle>))] MentorLake.WebKit2.WebKitOptionMenuHandle self, IntPtr user_data);

}


public static class WebKitOptionMenuHandleExtensions
{
/// <summary>
/// <para>
/// Activates the #WebKitOptionMenuItem at @index in @menu.
/// </para>
/// <para>
/// Activating an item changes the value
/// of the element making the item the active one. You are expected to close the menu with
/// webkit_option_menu_close() after activating an item, calling this function again will have no
/// effect.
/// </para>
/// </summary>

/// <param name="menu">
/// a #WebKitOptionMenu
/// </param>
/// <param name="index">
/// the index of the item
/// </param>

	public static T ActivateItem<T>(this T menu, uint index) where T : WebKitOptionMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (WebKitOptionMenuHandle)");
		WebKitOptionMenuHandleExterns.webkit_option_menu_activate_item(menu, index);
		return menu;
	}

/// <summary>
/// <para>
/// Request to close a #WebKitOptionMenu.
/// </para>
/// <para>
/// This emits WebKitOptionMenu::close signal.
/// This function should always be called to notify WebKit that the associated
/// menu has been closed. If the menu is closed and neither webkit_option_menu_select_item()
/// nor webkit_option_menu_activate_item() have been called, the element value remains
/// unchanged.
/// </para>
/// </summary>

/// <param name="menu">
/// a #WebKitOptionMenu
/// </param>

	public static T Close<T>(this T menu) where T : WebKitOptionMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (WebKitOptionMenuHandle)");
		WebKitOptionMenuHandleExterns.webkit_option_menu_close(menu);
		return menu;
	}

/// <summary>
/// <para>
/// Gets the #GdkEvent that triggered the dropdown menu.
/// If @menu was not triggered by a user interaction, like a mouse click,
/// %NULL is returned.
/// </para>
/// </summary>

/// <param name="menu">
/// a #WebKitOptionMenu
/// </param>
/// <return>
/// the menu event or %NULL.
/// </return>

	public static MentorLake.Gdk.GdkEventHandle GetEvent(this MentorLake.WebKit2.WebKitOptionMenuHandle menu)
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (WebKitOptionMenuHandle)");
		return WebKitOptionMenuHandleExterns.webkit_option_menu_get_event(menu);
	}

/// <summary>
/// <para>
/// Returns the #WebKitOptionMenuItem at @index in @menu.
/// </para>
/// </summary>

/// <param name="menu">
/// a #WebKitOptionMenu
/// </param>
/// <param name="index">
/// the index of the item
/// </param>
/// <return>
/// a #WebKitOptionMenuItem of @menu.
/// </return>

	public static MentorLake.WebKit2.WebKitOptionMenuItemHandle GetItem(this MentorLake.WebKit2.WebKitOptionMenuHandle menu, uint index)
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (WebKitOptionMenuHandle)");
		return WebKitOptionMenuHandleExterns.webkit_option_menu_get_item(menu, index);
	}

/// <summary>
/// <para>
/// Gets the length of the @menu.
/// </para>
/// </summary>

/// <param name="menu">
/// a #WebKitOptionMenu
/// </param>
/// <return>
/// the number of #WebKitOptionMenuItem&amp;lt;!-- --&amp;gt;s in @menu
/// </return>

	public static uint GetNItems(this MentorLake.WebKit2.WebKitOptionMenuHandle menu)
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (WebKitOptionMenuHandle)");
		return WebKitOptionMenuHandleExterns.webkit_option_menu_get_n_items(menu);
	}

/// <summary>
/// <para>
/// Selects the #WebKitOptionMenuItem at @index in @menu.
/// </para>
/// <para>
/// Selecting an item changes the
/// text shown by the combo button, but it doesn&apos;t change the value of the element. You need to
/// explicitly activate the item with webkit_option_menu_select_item() or close the menu with
/// webkit_option_menu_close() in which case the currently selected item will be activated.
/// </para>
/// </summary>

/// <param name="menu">
/// a #WebKitOptionMenu
/// </param>
/// <param name="index">
/// the index of the item
/// </param>

	public static T SelectItem<T>(this T menu, uint index) where T : WebKitOptionMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (WebKitOptionMenuHandle)");
		WebKitOptionMenuHandleExterns.webkit_option_menu_select_item(menu, index);
		return menu;
	}

}

internal class WebKitOptionMenuHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_option_menu_activate_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitOptionMenuHandle>))] MentorLake.WebKit2.WebKitOptionMenuHandle menu, uint index);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_option_menu_close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitOptionMenuHandle>))] MentorLake.WebKit2.WebKitOptionMenuHandle menu);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))]
	internal static extern MentorLake.Gdk.GdkEventHandle webkit_option_menu_get_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitOptionMenuHandle>))] MentorLake.WebKit2.WebKitOptionMenuHandle menu);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitOptionMenuItemHandle>))]
	internal static extern MentorLake.WebKit2.WebKitOptionMenuItemHandle webkit_option_menu_get_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitOptionMenuHandle>))] MentorLake.WebKit2.WebKitOptionMenuHandle menu, uint index);

	[DllImport(WebKit2Library.Name)]
	internal static extern uint webkit_option_menu_get_n_items([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitOptionMenuHandle>))] MentorLake.WebKit2.WebKitOptionMenuHandle menu);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_option_menu_select_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitOptionMenuHandle>))] MentorLake.WebKit2.WebKitOptionMenuHandle menu, uint index);

}
