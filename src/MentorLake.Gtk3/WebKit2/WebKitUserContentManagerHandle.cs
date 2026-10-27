namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Manages user-defined content which affects web pages.
/// </para>
/// <para>
/// Using a #WebKitUserContentManager user CSS style sheets can be set to
/// be injected in the web pages loaded by a #WebKitWebView, by
/// webkit_user_content_manager_add_style_sheet().
/// </para>
/// <para>
/// To use a #WebKitUserContentManager, it must be created using
/// webkit_user_content_manager_new(), and then used to construct
/// a #WebKitWebView. User style sheets can be created with
/// webkit_user_style_sheet_new().
/// </para>
/// <para>
/// User style sheets can be added and removed at any time, but
/// they will affect the web pages loaded afterwards.
/// </para>
/// </summary>

public class WebKitUserContentManagerHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new user content manager.
/// </para>
/// </summary>

/// <return>
/// A #WebKitUserContentManager
/// </return>

	public static MentorLake.WebKit2.WebKitUserContentManagerHandle New()
	{
		return WebKitUserContentManagerHandleExterns.webkit_user_content_manager_new();
	}

}
public static class WebKitUserContentManagerHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted when JavaScript in a web view calls
/// &amp;lt;code&amp;gt;window.webkit.messageHandlers.&amp;lt;name&amp;gt;.postMessage()&amp;lt;/code&amp;gt;, after registering
/// &amp;lt;code&amp;gt;&amp;lt;name&amp;gt;&amp;lt;/code&amp;gt; using
/// webkit_user_content_manager_register_script_message_handler()
/// </para>
/// </summary>

	public static IObservable<WebKitUserContentManagerHandleSignalStructs.ScriptMessageReceivedSignal> Signal_ScriptMessageReceived(this WebKitUserContentManagerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitUserContentManagerHandleSignalStructs.ScriptMessageReceivedSignal> obs) =>
		{
			WebKitUserContentManagerHandleSignalDelegates.script_message_received handler = ( MentorLake.WebKit2.WebKitUserContentManagerHandle self,  MentorLake.WebKit2.WebKitJavascriptResultHandle value,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitUserContentManagerHandleSignalStructs.ScriptMessageReceivedSignal()
				{
					Self = self, Value = value, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "script-message-received", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
/// <summary>
/// <para>
/// This signal is emitted when JavaScript in a web view calls
/// &amp;lt;code&amp;gt;window.webkit.messageHandlers.&amp;lt;name&amp;gt;.postMessage()&amp;lt;/code&amp;gt;, after registering
/// &amp;lt;code&amp;gt;&amp;lt;name&amp;gt;&amp;lt;/code&amp;gt; using
/// webkit_user_content_manager_register_script_message_handler_with_reply()
/// </para>
/// <para>
/// The given @reply can be used to send a return value with
/// webkit_script_message_reply_return_value() or an error message with
/// webkit_script_message_reply_return_error_message(). If none of them are
/// called, an automatic reply with an undefined value will be sent.
/// </para>
/// <para>
/// It is possible to handle the reply asynchronously, by simply calling
/// g_object_ref() on the @reply and returning %TRUE.
/// </para>
/// </summary>

	public static IObservable<WebKitUserContentManagerHandleSignalStructs.ScriptMessageWithReplyReceivedSignal> Signal_ScriptMessageWithReplyReceived(this WebKitUserContentManagerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitUserContentManagerHandleSignalStructs.ScriptMessageWithReplyReceivedSignal> obs) =>
		{
			WebKitUserContentManagerHandleSignalDelegates.script_message_with_reply_received handler = ( MentorLake.WebKit2.WebKitUserContentManagerHandle self,  MentorLake.JavaScriptCore.JSCValueHandle value,  MentorLake.WebKit2.WebKitScriptMessageReplyHandle reply,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitUserContentManagerHandleSignalStructs.ScriptMessageWithReplyReceivedSignal()
				{
					Self = self, Value = value, Reply = reply, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "script-message-with-reply-received", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class WebKitUserContentManagerHandleSignalStructs
{

public class ScriptMessageReceivedSignal
{

	public MentorLake.WebKit2.WebKitUserContentManagerHandle Self;
/// <summary>
/// <para>
/// the value received from the JavaScript world.
/// </para>
/// </summary>

	public MentorLake.WebKit2.WebKitJavascriptResultHandle Value;

	public IntPtr UserData;
}

public class ScriptMessageWithReplyReceivedSignal
{

	public MentorLake.WebKit2.WebKitUserContentManagerHandle Self;
/// <summary>
/// <para>
/// the value received from the JavaScript world.
/// </para>
/// </summary>

	public MentorLake.JavaScriptCore.JSCValueHandle Value;
/// <summary>
/// <para>
/// the #WebKitScriptMessageReply to send the reply to the script message.
/// </para>
/// </summary>

	public MentorLake.WebKit2.WebKitScriptMessageReplyHandle Reply;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///    %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}
}

public static class WebKitUserContentManagerHandleSignalDelegates
{

/// <summary>
/// <para>
/// This signal is emitted when JavaScript in a web view calls
/// &amp;lt;code&amp;gt;window.webkit.messageHandlers.&amp;lt;name&amp;gt;.postMessage()&amp;lt;/code&amp;gt;, after registering
/// &amp;lt;code&amp;gt;&amp;lt;name&amp;gt;&amp;lt;/code&amp;gt; using
/// webkit_user_content_manager_register_script_message_handler()
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="value">
/// the value received from the JavaScript world.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void script_message_received([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserContentManagerHandle>))] MentorLake.WebKit2.WebKitUserContentManagerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitJavascriptResultHandle>))] MentorLake.WebKit2.WebKitJavascriptResultHandle value, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when JavaScript in a web view calls
/// &amp;lt;code&amp;gt;window.webkit.messageHandlers.&amp;lt;name&amp;gt;.postMessage()&amp;lt;/code&amp;gt;, after registering
/// &amp;lt;code&amp;gt;&amp;lt;name&amp;gt;&amp;lt;/code&amp;gt; using
/// webkit_user_content_manager_register_script_message_handler_with_reply()
/// </para>
/// <para>
/// The given @reply can be used to send a return value with
/// webkit_script_message_reply_return_value() or an error message with
/// webkit_script_message_reply_return_error_message(). If none of them are
/// called, an automatic reply with an undefined value will be sent.
/// </para>
/// <para>
/// It is possible to handle the reply asynchronously, by simply calling
/// g_object_ref() on the @reply and returning %TRUE.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="value">
/// the value received from the JavaScript world.
/// </param>
/// <param name="reply">
/// the #WebKitScriptMessageReply to send the reply to the script message.
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
///    %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool script_message_with_reply_received([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserContentManagerHandle>))] MentorLake.WebKit2.WebKitUserContentManagerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitScriptMessageReplyHandle>))] MentorLake.WebKit2.WebKitScriptMessageReplyHandle reply, IntPtr user_data);

}


public static class WebKitUserContentManagerHandleExtensions
{
/// <summary>
/// <para>
/// Adds a #WebKitUserContentFilter to the given #WebKitUserContentManager.
/// </para>
/// <para>
/// The same #WebKitUserContentFilter can be reused with multiple
/// #WebKitUserContentManager instances.
/// </para>
/// <para>
/// Filters need to be saved and loaded from #WebKitUserContentFilterStore.
/// </para>
/// </summary>

/// <param name="manager">
/// A #WebKitUserContentManager
/// </param>
/// <param name="filter">
/// A #WebKitUserContentFilter
/// </param>

	public static T AddFilter<T>(this T manager, MentorLake.WebKit2.WebKitUserContentFilterHandle filter) where T : WebKitUserContentManagerHandle
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitUserContentManagerHandle)");
		WebKitUserContentManagerHandleExterns.webkit_user_content_manager_add_filter(manager, filter);
		return manager;
	}

/// <summary>
/// <para>
/// Adds a #WebKitUserScript to the given #WebKitUserContentManager.
/// </para>
/// <para>
/// The same #WebKitUserScript can be reused with multiple
/// #WebKitUserContentManager instances.
/// </para>
/// </summary>

/// <param name="manager">
/// A #WebKitUserContentManager
/// </param>
/// <param name="script">
/// A #WebKitUserScript
/// </param>

	public static T AddScript<T>(this T manager, MentorLake.WebKit2.WebKitUserScriptHandle script) where T : WebKitUserContentManagerHandle
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitUserContentManagerHandle)");
		WebKitUserContentManagerHandleExterns.webkit_user_content_manager_add_script(manager, script);
		return manager;
	}

/// <summary>
/// <para>
/// Adds a #WebKitUserStyleSheet to the given #WebKitUserContentManager.
/// </para>
/// <para>
/// The same #WebKitUserStyleSheet can be reused with multiple
/// #WebKitUserContentManager instances.
/// </para>
/// </summary>

/// <param name="manager">
/// A #WebKitUserContentManager
/// </param>
/// <param name="stylesheet">
/// A #WebKitUserStyleSheet
/// </param>

	public static T AddStyleSheet<T>(this T manager, MentorLake.WebKit2.WebKitUserStyleSheetHandle stylesheet) where T : WebKitUserContentManagerHandle
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitUserContentManagerHandle)");
		WebKitUserContentManagerHandleExterns.webkit_user_content_manager_add_style_sheet(manager, stylesheet);
		return manager;
	}

/// <summary>
/// <para>
/// Registers a new user script message handler.
/// </para>
/// <para>
/// After it is registered,
/// scripts can use `window.webkit.messageHandlers.&amp;lt;name&amp;gt;.postMessage(value)`
/// to send messages. Those messages are received by connecting handlers
/// to the #WebKitUserContentManager::script-message-received signal. The
/// handler name is used as the detail of the signal. To avoid race
/// conditions between registering the handler name, and starting to
/// receive the signals, it is recommended to connect to the signal
/// *before* registering the handler name:
/// </para>
/// <para>
/// ```c
/// WebKitWebView *view = webkit_web_view_new ();
/// WebKitUserContentManager *manager = webkit_web_view_get_user_content_manager ();
/// g_signal_connect (manager, &quot;script-message-received::foobar&quot;,
///                   G_CALLBACK (handle_script_message), NULL);
/// webkit_user_content_manager_register_script_message_handler (manager, &quot;foobar&quot;);
/// ```
/// </para>
/// <para>
/// Registering a script message handler will fail if the requested
/// name has been already registered before.
/// </para>
/// </summary>

/// <param name="manager">
/// A #WebKitUserContentManager
/// </param>
/// <param name="name">
/// Name of the script message channel
/// </param>
/// <return>
/// %TRUE if message handler was registered successfully, or %FALSE otherwise.
/// </return>

	public static bool RegisterScriptMessageHandler(this MentorLake.WebKit2.WebKitUserContentManagerHandle manager, string name)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitUserContentManagerHandle)");
		return WebKitUserContentManagerHandleExterns.webkit_user_content_manager_register_script_message_handler(manager, name);
	}

/// <summary>
/// <para>
/// Registers a new user script message handler in script world.
/// </para>
/// <para>
/// Registers a new user script message handler in script world with name @world_name.
/// See webkit_user_content_manager_register_script_message_handler() for full description.
/// </para>
/// <para>
/// Registering a script message handler will fail if the requested
/// name has been already registered before.
/// </para>
/// </summary>

/// <param name="manager">
/// A #WebKitUserContentManager
/// </param>
/// <param name="name">
/// Name of the script message channel
/// </param>
/// <param name="world_name">
/// the name of a #WebKitScriptWorld
/// </param>
/// <return>
/// %TRUE if message handler was registered successfully, or %FALSE otherwise.
/// </return>

	public static bool RegisterScriptMessageHandlerInWorld(this MentorLake.WebKit2.WebKitUserContentManagerHandle manager, string name, string world_name)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitUserContentManagerHandle)");
		return WebKitUserContentManagerHandleExterns.webkit_user_content_manager_register_script_message_handler_in_world(manager, name, world_name);
	}

/// <summary>
/// <para>
/// Registers a new user script message handler in script world with name @world_name.
/// </para>
/// <para>
/// Different from webkit_user_content_manager_register_script_message_handler(),
/// when using this function to register the handler, the connected signal is
/// script-message-with-reply-received, and a reply provided by the user is expected.
/// Otherwise, the user will receive a default undefined value.
/// </para>
/// <para>
/// If %NULL is passed as the @world_name, the default world will be used.
/// See webkit_user_content_manager_register_script_message_handler() for full description.
/// </para>
/// <para>
/// Registering a script message handler will fail if the requested
/// name has been already registered before.
/// </para>
/// <para>
/// The registered handler can be unregistered by using
/// webkit_user_content_manager_unregister_script_message_handler().
/// </para>
/// </summary>

/// <param name="manager">
/// A #WebKitUserContentManager
/// </param>
/// <param name="name">
/// Name of the script message channel
/// </param>
/// <param name="world_name">
/// the name of a #WebKitScriptWorld
/// </param>
/// <return>
/// %TRUE if message handler was registered successfully, or %FALSE otherwise.
/// </return>

	public static bool RegisterScriptMessageHandlerWithReply(this MentorLake.WebKit2.WebKitUserContentManagerHandle manager, string name, string world_name)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitUserContentManagerHandle)");
		return WebKitUserContentManagerHandleExterns.webkit_user_content_manager_register_script_message_handler_with_reply(manager, name, world_name);
	}

/// <summary>
/// <para>
/// Removes all content filters from the given #WebKitUserContentManager.
/// </para>
/// </summary>

/// <param name="manager">
/// A #WebKitUserContentManager
/// </param>

	public static T RemoveAllFilters<T>(this T manager) where T : WebKitUserContentManagerHandle
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitUserContentManagerHandle)");
		WebKitUserContentManagerHandleExterns.webkit_user_content_manager_remove_all_filters(manager);
		return manager;
	}

/// <summary>
/// <para>
/// Removes all user scripts from the given #WebKitUserContentManager
/// </para>
/// <para>
/// See also webkit_user_content_manager_remove_script().
/// </para>
/// </summary>

/// <param name="manager">
/// A #WebKitUserContentManager
/// </param>

	public static T RemoveAllScripts<T>(this T manager) where T : WebKitUserContentManagerHandle
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitUserContentManagerHandle)");
		WebKitUserContentManagerHandleExterns.webkit_user_content_manager_remove_all_scripts(manager);
		return manager;
	}

/// <summary>
/// <para>
/// Removes all user style sheets from the given #WebKitUserContentManager.
/// </para>
/// </summary>

/// <param name="manager">
/// A #WebKitUserContentManager
/// </param>

	public static T RemoveAllStyleSheets<T>(this T manager) where T : WebKitUserContentManagerHandle
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitUserContentManagerHandle)");
		WebKitUserContentManagerHandleExterns.webkit_user_content_manager_remove_all_style_sheets(manager);
		return manager;
	}

/// <summary>
/// <para>
/// Removes a filter from the given #WebKitUserContentManager.
/// </para>
/// <para>
/// Since 2.24
/// </para>
/// </summary>

/// <param name="manager">
/// A #WebKitUserContentManager
/// </param>
/// <param name="filter">
/// A #WebKitUserContentFilter
/// </param>

	public static T RemoveFilter<T>(this T manager, MentorLake.WebKit2.WebKitUserContentFilterHandle filter) where T : WebKitUserContentManagerHandle
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitUserContentManagerHandle)");
		WebKitUserContentManagerHandleExterns.webkit_user_content_manager_remove_filter(manager, filter);
		return manager;
	}

/// <summary>
/// <para>
/// Removes a filter by the given identifier.
/// </para>
/// <para>
/// Removes a filter from the given #WebKitUserContentManager given the
/// identifier of a #WebKitUserContentFilter as returned by
/// webkit_user_content_filter_get_identifier().
/// </para>
/// </summary>

/// <param name="manager">
/// A #WebKitUserContentManager
/// </param>
/// <param name="filter_id">
/// Filter identifier
/// </param>

	public static T RemoveFilterById<T>(this T manager, string filter_id) where T : WebKitUserContentManagerHandle
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitUserContentManagerHandle)");
		WebKitUserContentManagerHandleExterns.webkit_user_content_manager_remove_filter_by_id(manager, filter_id);
		return manager;
	}

/// <summary>
/// <para>
/// Removes a #WebKitUserScript from the given #WebKitUserContentManager.
/// </para>
/// <para>
/// See also webkit_user_content_manager_remove_all_scripts().
/// </para>
/// </summary>

/// <param name="manager">
/// A #WebKitUserContentManager
/// </param>
/// <param name="script">
/// A #WebKitUserScript
/// </param>

	public static T RemoveScript<T>(this T manager, MentorLake.WebKit2.WebKitUserScriptHandle script) where T : WebKitUserContentManagerHandle
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitUserContentManagerHandle)");
		WebKitUserContentManagerHandleExterns.webkit_user_content_manager_remove_script(manager, script);
		return manager;
	}

/// <summary>
/// <para>
/// Removes a #WebKitUserStyleSheet from the given #WebKitUserContentManager.
/// </para>
/// <para>
/// See also webkit_user_content_manager_remove_all_style_sheets().
/// </para>
/// </summary>

/// <param name="manager">
/// A #WebKitUserContentManager
/// </param>
/// <param name="stylesheet">
/// A #WebKitUserStyleSheet
/// </param>

	public static T RemoveStyleSheet<T>(this T manager, MentorLake.WebKit2.WebKitUserStyleSheetHandle stylesheet) where T : WebKitUserContentManagerHandle
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitUserContentManagerHandle)");
		WebKitUserContentManagerHandleExterns.webkit_user_content_manager_remove_style_sheet(manager, stylesheet);
		return manager;
	}

/// <summary>
/// <para>
/// Unregisters a previously registered message handler.
/// </para>
/// <para>
/// Note that this does *not* disconnect handlers for the
/// #WebKitUserContentManager::script-message-received signal;
/// they will be kept connected, but the signal will not be emitted
/// unless the handler name is registered again.
/// </para>
/// <para>
/// See also webkit_user_content_manager_register_script_message_handler().
/// </para>
/// </summary>

/// <param name="manager">
/// A #WebKitUserContentManager
/// </param>
/// <param name="name">
/// Name of the script message channel
/// </param>

	public static T UnregisterScriptMessageHandler<T>(this T manager, string name) where T : WebKitUserContentManagerHandle
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitUserContentManagerHandle)");
		WebKitUserContentManagerHandleExterns.webkit_user_content_manager_unregister_script_message_handler(manager, name);
		return manager;
	}

/// <summary>
/// <para>
/// Unregisters a previously registered message handler in script world with name @world_name.
/// </para>
/// <para>
/// Note that this does *not* disconnect handlers for the
/// #WebKitUserContentManager::script-message-received signal;
/// they will be kept connected, but the signal will not be emitted
/// unless the handler name is registered again.
/// </para>
/// <para>
/// See also webkit_user_content_manager_register_script_message_handler_in_world().
/// </para>
/// </summary>

/// <param name="manager">
/// A #WebKitUserContentManager
/// </param>
/// <param name="name">
/// Name of the script message channel
/// </param>
/// <param name="world_name">
/// the name of a #WebKitScriptWorld
/// </param>

	public static T UnregisterScriptMessageHandlerInWorld<T>(this T manager, string name, string world_name) where T : WebKitUserContentManagerHandle
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (WebKitUserContentManagerHandle)");
		WebKitUserContentManagerHandleExterns.webkit_user_content_manager_unregister_script_message_handler_in_world(manager, name, world_name);
		return manager;
	}

}

internal class WebKitUserContentManagerHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserContentManagerHandle>))]
	internal static extern MentorLake.WebKit2.WebKitUserContentManagerHandle webkit_user_content_manager_new();

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_user_content_manager_add_filter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserContentManagerHandle>))] MentorLake.WebKit2.WebKitUserContentManagerHandle manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserContentFilterHandle>))] MentorLake.WebKit2.WebKitUserContentFilterHandle filter);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_user_content_manager_add_script([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserContentManagerHandle>))] MentorLake.WebKit2.WebKitUserContentManagerHandle manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserScriptHandle>))] MentorLake.WebKit2.WebKitUserScriptHandle script);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_user_content_manager_add_style_sheet([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserContentManagerHandle>))] MentorLake.WebKit2.WebKitUserContentManagerHandle manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserStyleSheetHandle>))] MentorLake.WebKit2.WebKitUserStyleSheetHandle stylesheet);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_user_content_manager_register_script_message_handler([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserContentManagerHandle>))] MentorLake.WebKit2.WebKitUserContentManagerHandle manager, string name);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_user_content_manager_register_script_message_handler_in_world([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserContentManagerHandle>))] MentorLake.WebKit2.WebKitUserContentManagerHandle manager, string name, string world_name);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_user_content_manager_register_script_message_handler_with_reply([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserContentManagerHandle>))] MentorLake.WebKit2.WebKitUserContentManagerHandle manager, string name, string world_name);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_user_content_manager_remove_all_filters([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserContentManagerHandle>))] MentorLake.WebKit2.WebKitUserContentManagerHandle manager);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_user_content_manager_remove_all_scripts([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserContentManagerHandle>))] MentorLake.WebKit2.WebKitUserContentManagerHandle manager);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_user_content_manager_remove_all_style_sheets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserContentManagerHandle>))] MentorLake.WebKit2.WebKitUserContentManagerHandle manager);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_user_content_manager_remove_filter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserContentManagerHandle>))] MentorLake.WebKit2.WebKitUserContentManagerHandle manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserContentFilterHandle>))] MentorLake.WebKit2.WebKitUserContentFilterHandle filter);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_user_content_manager_remove_filter_by_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserContentManagerHandle>))] MentorLake.WebKit2.WebKitUserContentManagerHandle manager, string filter_id);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_user_content_manager_remove_script([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserContentManagerHandle>))] MentorLake.WebKit2.WebKitUserContentManagerHandle manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserScriptHandle>))] MentorLake.WebKit2.WebKitUserScriptHandle script);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_user_content_manager_remove_style_sheet([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserContentManagerHandle>))] MentorLake.WebKit2.WebKitUserContentManagerHandle manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserStyleSheetHandle>))] MentorLake.WebKit2.WebKitUserStyleSheetHandle stylesheet);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_user_content_manager_unregister_script_message_handler([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserContentManagerHandle>))] MentorLake.WebKit2.WebKitUserContentManagerHandle manager, string name);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_user_content_manager_unregister_script_message_handler_in_world([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserContentManagerHandle>))] MentorLake.WebKit2.WebKitUserContentManagerHandle manager, string name, string world_name);

}
