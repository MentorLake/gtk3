namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// The central class of the WPE WebKit and WebKitGTK APIs.
/// </para>
/// <para>
/// #WebKitWebView is the central class of the WPE WebKit and WebKitGTK
/// APIs. It is responsible for managing the drawing of the content and
/// forwarding of events. You can load any URI into the #WebKitWebView or
/// a data string. With #WebKitSettings you can control various aspects
/// of the rendering and loading of the content.
/// </para>
/// <para>
/// Note that in WebKitGTK, #WebKitWebView is scrollable by itself, so
/// you don&apos;t need to embed it in a #GtkScrolledWindow.
/// </para>
/// </summary>

public class WebKitWebViewHandle : WebKitWebViewBaseHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #WebKitWebView with the default #WebKitWebContext.
/// </para>
/// <para>
/// Creates a new #WebKitWebView with the default #WebKitWebContext and
/// no #WebKitUserContentManager associated with it.
/// See also webkit_web_view_new_with_context(),
/// webkit_web_view_new_with_user_content_manager(), and
/// webkit_web_view_new_with_settings().
/// </para>
/// </summary>

/// <return>
/// The newly created #WebKitWebView widget
/// </return>

	public static MentorLake.WebKit2.WebKitWebViewHandle New()
	{
		return WebKitWebViewHandleExterns.webkit_web_view_new();
	}

/// <summary>
/// <para>
/// Creates a new #WebKitWebView with the given #WebKitWebContext.
/// </para>
/// <para>
/// Creates a new #WebKitWebView with the given #WebKitWebContext and
/// no #WebKitUserContentManager associated with it.
/// See also webkit_web_view_new_with_user_content_manager() and
/// webkit_web_view_new_with_settings().
/// </para>
/// </summary>

/// <param name="context">
/// the #WebKitWebContext to be used by the #WebKitWebView
/// </param>
/// <return>
/// The newly created #WebKitWebView widget
/// </return>

	public static MentorLake.WebKit2.WebKitWebViewHandle NewWithContext(MentorLake.WebKit2.WebKitWebContextHandle context)
	{
		return WebKitWebViewHandleExterns.webkit_web_view_new_with_context(context);
	}

/// <summary>
/// <para>
/// Creates a new #WebKitWebView sharing the same web process with @web_view.
/// </para>
/// <para>
/// This method doesn&apos;t have any effect when %WEBKIT_PROCESS_MODEL_SHARED_SECONDARY_PROCESS
/// process model is used, because a single web process is shared for all the web views in the
/// same #WebKitWebContext. When using %WEBKIT_PROCESS_MODEL_MULTIPLE_SECONDARY_PROCESSES process model,
/// this method should always be used when creating the #WebKitWebView in the #WebKitWebView::create signal.
/// You can also use this method to implement other process models based on %WEBKIT_PROCESS_MODEL_MULTIPLE_SECONDARY_PROCESSES,
/// like for example, sharing the same web process for all the views in the same security domain.
/// </para>
/// <para>
/// The newly created #WebKitWebView will also have the same #WebKitUserContentManager,
/// #WebKitSettings, and #WebKitWebsitePolicies as @web_view.
/// </para>
/// </summary>

/// <param name="web_view">
/// the related #WebKitWebView
/// </param>
/// <return>
/// The newly created #WebKitWebView widget
/// </return>

	public static MentorLake.WebKit2.WebKitWebViewHandle NewWithRelatedView(MentorLake.WebKit2.WebKitWebViewHandle web_view)
	{
		return WebKitWebViewHandleExterns.webkit_web_view_new_with_related_view(web_view);
	}

/// <summary>
/// <para>
/// Creates a new #WebKitWebView with the given #WebKitSettings.
/// </para>
/// <para>
/// See also webkit_web_view_new_with_context(), and
/// webkit_web_view_new_with_user_content_manager().
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitSettings
/// </param>
/// <return>
/// The newly created #WebKitWebView widget
/// </return>

	public static MentorLake.WebKit2.WebKitWebViewHandle NewWithSettings(MentorLake.WebKit2.WebKitSettingsHandle settings)
	{
		return WebKitWebViewHandleExterns.webkit_web_view_new_with_settings(settings);
	}

/// <summary>
/// <para>
/// Creates a new #WebKitWebView with the given #WebKitUserContentManager.
/// </para>
/// <para>
/// The content loaded in the view may be affected by the content injected
/// in the view by the user content manager.
/// </para>
/// </summary>

/// <param name="user_content_manager">
/// a #WebKitUserContentManager.
/// </param>
/// <return>
/// The newly created #WebKitWebView widget
/// </return>

	public static MentorLake.WebKit2.WebKitWebViewHandle NewWithUserContentManager(MentorLake.WebKit2.WebKitUserContentManagerHandle user_content_manager)
	{
		return WebKitWebViewHandleExterns.webkit_web_view_new_with_user_content_manager(user_content_manager);
	}

}
public static class WebKitWebViewHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted when the user is challenged with HTTP
/// authentication. To let the  application access or supply
/// the credentials as well as to allow the client application
/// to either cancel the request or perform the authentication,
/// the signal will pass an instance of the
/// #WebKitAuthenticationRequest in the @request argument.
/// To handle this signal asynchronously you should keep a ref
/// of the request and return %TRUE. To disable HTTP authentication
/// entirely, connect to this signal and simply return %TRUE.
/// </para>
/// <para>
/// The default signal handler will run a default authentication
/// dialog asynchronously for the user to interact with.
/// </para>
/// </summary>

	public static IObservable<WebKitWebViewHandleSignalStructs.AuthenticateSignal> Signal_Authenticate(this WebKitWebViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebViewHandleSignalStructs.AuthenticateSignal> obs) =>
		{
			WebKitWebViewHandleSignalDelegates.authenticate handler = ( MentorLake.WebKit2.WebKitWebViewHandle self,  MentorLake.WebKit2.WebKitAuthenticationRequestHandle request,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebViewHandleSignalStructs.AuthenticateSignal()
				{
					Self = self, Request = request, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "authenticate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when closing a #WebKitWebView is requested. This occurs when a
/// call is made from JavaScript&apos;s &amp;lt;function&amp;gt;window.close&amp;lt;/function&amp;gt; function or
/// after trying to close the @web_view with webkit_web_view_try_close().
/// It is the owner&apos;s responsibility to handle this signal to hide or
/// destroy the #WebKitWebView, if necessary.
/// </para>
/// </summary>

	public static IObservable<WebKitWebViewHandleSignalStructs.CloseSignal> Signal_Close(this WebKitWebViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebViewHandleSignalStructs.CloseSignal> obs) =>
		{
			WebKitWebViewHandleSignalDelegates.close handler = ( MentorLake.WebKit2.WebKitWebViewHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebViewHandleSignalStructs.CloseSignal()
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
/// <summary>
/// <para>
/// Emitted when a context menu is about to be displayed to give the application
/// a chance to customize the proposed menu, prevent the menu from being displayed,
/// or build its own context menu.
/// &amp;lt;itemizedlist&amp;gt;
/// &amp;lt;listitem&amp;gt;&amp;lt;para&amp;gt;
///  To customize the proposed menu you can use webkit_context_menu_prepend(),
///  webkit_context_menu_append() or webkit_context_menu_insert() to add new
///  #WebKitContextMenuItem&amp;lt;!-- --&amp;gt;s to @context_menu, webkit_context_menu_move_item()
///  to reorder existing items, or webkit_context_menu_remove() to remove an
///  existing item. The signal handler should return %FALSE, and the menu represented
///  by @context_menu will be shown.
/// &amp;lt;/para&amp;gt;&amp;lt;/listitem&amp;gt;
/// &amp;lt;listitem&amp;gt;&amp;lt;para&amp;gt;
///  To prevent the menu from being displayed you can just connect to this signal
///  and return %TRUE so that the proposed menu will not be shown.
/// &amp;lt;/para&amp;gt;&amp;lt;/listitem&amp;gt;
/// &amp;lt;listitem&amp;gt;&amp;lt;para&amp;gt;
///  To build your own menu, you can remove all items from the proposed menu with
///  webkit_context_menu_remove_all(), add your own items and return %FALSE so
///  that the menu will be shown. You can also ignore the proposed #WebKitContextMenu,
///  build your own #GtkMenu and return %TRUE to prevent the proposed menu from being shown.
/// &amp;lt;/para&amp;gt;&amp;lt;/listitem&amp;gt;
/// &amp;lt;listitem&amp;gt;&amp;lt;para&amp;gt;
///  If you just want the default menu to be shown always, simply don&apos;t connect to this
///  signal because showing the proposed context menu is the default behaviour.
/// &amp;lt;/para&amp;gt;&amp;lt;/listitem&amp;gt;
/// &amp;lt;/itemizedlist&amp;gt;
/// </para>
/// <para>
/// The @event parameter is now deprecated. Use webkit_context_menu_get_event() to get the
/// #GdkEvent that triggered the context menu.
/// </para>
/// <para>
/// If the signal handler returns %FALSE the context menu represented by @context_menu
/// will be shown, if it return %TRUE the context menu will not be shown.
/// </para>
/// <para>
/// The proposed #WebKitContextMenu passed in @context_menu argument is only valid
/// during the signal emission.
/// </para>
/// </summary>

	public static IObservable<WebKitWebViewHandleSignalStructs.ContextMenuSignal> Signal_ContextMenu(this WebKitWebViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebViewHandleSignalStructs.ContextMenuSignal> obs) =>
		{
			WebKitWebViewHandleSignalDelegates.context_menu handler = ( MentorLake.WebKit2.WebKitWebViewHandle self,  MentorLake.WebKit2.WebKitContextMenuHandle context_menu,  MentorLake.Gdk.GdkEventHandle @event,  MentorLake.WebKit2.WebKitHitTestResultHandle hit_test_result,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebViewHandleSignalStructs.ContextMenuSignal()
				{
					Self = self, ContextMenu = context_menu, Event = @event, HitTestResult = hit_test_result, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "context-menu", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted after #WebKitWebView::context-menu signal, if the context menu is shown,
/// to notify that the context menu is dismissed.
/// </para>
/// </summary>

	public static IObservable<WebKitWebViewHandleSignalStructs.ContextMenuDismissedSignal> Signal_ContextMenuDismissed(this WebKitWebViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebViewHandleSignalStructs.ContextMenuDismissedSignal> obs) =>
		{
			WebKitWebViewHandleSignalDelegates.context_menu_dismissed handler = ( MentorLake.WebKit2.WebKitWebViewHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebViewHandleSignalStructs.ContextMenuDismissedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "context-menu-dismissed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when the creation of a new #WebKitWebView is requested.
/// If this signal is handled the signal handler should return the
/// newly created #WebKitWebView.
/// </para>
/// <para>
/// The #WebKitNavigationAction parameter contains information about the
/// navigation action that triggered this signal.
/// </para>
/// <para>
/// The new #WebKitWebView must be related to @web_view, see
/// #WebKitWebView:related-view for more details.
/// </para>
/// <para>
/// The new #WebKitWebView should not be displayed to the user
/// until the #WebKitWebView::ready-to-show signal is emitted.
/// </para>
/// <para>
/// For creating views as response to automation tools requests, see the
/// #WebKitAutomationSession::create-web-view signal.
/// </para>
/// </summary>

	public static IObservable<WebKitWebViewHandleSignalStructs.CreateSignal> Signal_Create(this WebKitWebViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebViewHandleSignalStructs.CreateSignal> obs) =>
		{
			WebKitWebViewHandleSignalDelegates.create handler = ( MentorLake.WebKit2.WebKitWebViewHandle self,  MentorLake.WebKit2.WebKitNavigationActionHandle navigation_action,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebViewHandleSignalStructs.CreateSignal()
				{
					Self = self, NavigationAction = navigation_action, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "create", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted when WebKit is requesting the client to decide a policy
/// decision, such as whether to navigate to a page, open a new window or whether or
/// not to download a resource. The #WebKitNavigationPolicyDecision passed in the
/// @decision argument is a generic type, but should be casted to a more
/// specific type when making the decision. For example:
/// </para>
/// <para>
/// ```c
/// static gboolean
/// decide_policy_cb (WebKitWebView *web_view,
///                   WebKitPolicyDecision *decision,
///                   WebKitPolicyDecisionType type)
/// {
///     switch (type) {
///     case WEBKIT_POLICY_DECISION_TYPE_NAVIGATION_ACTION: {
///         WebKitNavigationPolicyDecision *navigation_decision = WEBKIT_NAVIGATION_POLICY_DECISION (decision);
///         // Make a policy decision here
///         break;
///     }
///     case WEBKIT_POLICY_DECISION_TYPE_NEW_WINDOW_ACTION: {
///         WebKitNavigationPolicyDecision *navigation_decision = WEBKIT_NAVIGATION_POLICY_DECISION (decision);
///         // Make a policy decision here
///         break;
///     }
///     case WEBKIT_POLICY_DECISION_TYPE_RESPONSE:
///         WebKitResponsePolicyDecision *response = WEBKIT_RESPONSE_POLICY_DECISION (decision);
///         // Make a policy decision here
///         break;
///     default:
///         // Making no decision results in webkit_policy_decision_use()
///         return FALSE;
///     }
///     return TRUE;
/// }
/// ```
/// </para>
/// <para>
/// It is possible to make policy decision asynchronously, by simply calling g_object_ref()
/// on the @decision argument and returning %TRUE to block the default signal handler.
/// If the last reference is removed on a #WebKitPolicyDecision and no decision has been
/// made explicitly, webkit_policy_decision_use() will be the default policy decision. The
/// default signal handler will simply call webkit_policy_decision_use(). Only the first
/// policy decision chosen for a given #WebKitPolicyDecision will have any affect.
/// </para>
/// </summary>

	public static IObservable<WebKitWebViewHandleSignalStructs.DecidePolicySignal> Signal_DecidePolicy(this WebKitWebViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebViewHandleSignalStructs.DecidePolicySignal> obs) =>
		{
			WebKitWebViewHandleSignalDelegates.decide_policy handler = ( MentorLake.WebKit2.WebKitWebViewHandle self,  MentorLake.WebKit2.WebKitPolicyDecisionHandle decision,  MentorLake.WebKit2.WebKitPolicyDecisionType decision_type,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebViewHandleSignalStructs.DecidePolicySignal()
				{
					Self = self, Decision = decision, DecisionType = decision_type, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "decide-policy", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when JavaScript code calls
/// &amp;lt;function&amp;gt;element.webkitRequestFullScreen&amp;lt;/function&amp;gt;. If the
/// signal is not handled the #WebKitWebView will proceed to full screen
/// its top level window. This signal can be used by client code to
/// request permission to the user prior doing the full screen
/// transition and eventually prepare the top-level window
/// (e.g. hide some widgets that would otherwise be part of the
/// full screen window).
/// </para>
/// </summary>

	public static IObservable<WebKitWebViewHandleSignalStructs.EnterFullscreenSignal> Signal_EnterFullscreen(this WebKitWebViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebViewHandleSignalStructs.EnterFullscreenSignal> obs) =>
		{
			WebKitWebViewHandleSignalDelegates.enter_fullscreen handler = ( MentorLake.WebKit2.WebKitWebViewHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebViewHandleSignalStructs.EnterFullscreenSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "enter-fullscreen", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Prior to 2.46, this signal was emitted when insecure content was
/// loaded in a secure content. Since 2.46, this signal is generally
/// no longer emitted.
/// </para>
/// </summary>

	public static IObservable<WebKitWebViewHandleSignalStructs.InsecureContentDetectedSignal> Signal_InsecureContentDetected(this WebKitWebViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebViewHandleSignalStructs.InsecureContentDetectedSignal> obs) =>
		{
			WebKitWebViewHandleSignalDelegates.insecure_content_detected handler = ( MentorLake.WebKit2.WebKitWebViewHandle self,  MentorLake.WebKit2.WebKitInsecureContentEvent @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebViewHandleSignalStructs.InsecureContentDetectedSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "insecure-content-detected", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when the #WebKitWebView is about to restore its top level
/// window out of its full screen state. This signal can be used by
/// client code to restore widgets hidden during the
/// #WebKitWebView::enter-fullscreen stage for instance.
/// </para>
/// </summary>

	public static IObservable<WebKitWebViewHandleSignalStructs.LeaveFullscreenSignal> Signal_LeaveFullscreen(this WebKitWebViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebViewHandleSignalStructs.LeaveFullscreenSignal> obs) =>
		{
			WebKitWebViewHandleSignalDelegates.leave_fullscreen handler = ( MentorLake.WebKit2.WebKitWebViewHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebViewHandleSignalStructs.LeaveFullscreenSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "leave-fullscreen", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when a load operation in @web_view changes.
/// The signal is always emitted with %WEBKIT_LOAD_STARTED when a
/// new load request is made and %WEBKIT_LOAD_FINISHED when the load
/// finishes successfully or due to an error. When the ongoing load
/// operation fails #WebKitWebView::load-failed signal is emitted
/// before #WebKitWebView::load-changed is emitted with
/// %WEBKIT_LOAD_FINISHED.
/// If a redirection is received from the server, this signal is emitted
/// with %WEBKIT_LOAD_REDIRECTED after the initial emission with
/// %WEBKIT_LOAD_STARTED and before %WEBKIT_LOAD_COMMITTED.
/// When the page content starts arriving the signal is emitted with
/// %WEBKIT_LOAD_COMMITTED event.
/// </para>
/// <para>
/// You can handle this signal and use a switch to track any ongoing
/// load operation.
/// </para>
/// <para>
/// ```c
/// static void web_view_load_changed (WebKitWebView  *web_view,
///                                    WebKitLoadEvent load_event,
///                                    gpointer        user_data)
/// {
///     switch (load_event) {
///     case WEBKIT_LOAD_STARTED:
///         // New load, we have now a provisional URI
///         provisional_uri = webkit_web_view_get_uri (web_view);
///         // Here we could start a spinner or update the
///         // location bar with the provisional URI
///         break;
///     case WEBKIT_LOAD_REDIRECTED:
///         redirected_uri = webkit_web_view_get_uri (web_view);
///         break;
///     case WEBKIT_LOAD_COMMITTED:
///         // The load is being performed. Current URI is
///         // the final one and it won&apos;t change unless a new
///         // load is requested or a navigation within the
///         // same page is performed
///         uri = webkit_web_view_get_uri (web_view);
///         break;
///     case WEBKIT_LOAD_FINISHED:
///         // Load finished, we can now stop the spinner
///         break;
///     }
/// }
/// ```
/// </para>
/// </summary>

	public static IObservable<WebKitWebViewHandleSignalStructs.LoadChangedSignal> Signal_LoadChanged(this WebKitWebViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebViewHandleSignalStructs.LoadChangedSignal> obs) =>
		{
			WebKitWebViewHandleSignalDelegates.load_changed handler = ( MentorLake.WebKit2.WebKitWebViewHandle self,  MentorLake.WebKit2.WebKitLoadEvent load_event,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebViewHandleSignalStructs.LoadChangedSignal()
				{
					Self = self, LoadEvent = load_event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "load-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when an error occurs during a load operation.
/// If the error happened when starting to load data for a page
/// @load_event will be %WEBKIT_LOAD_STARTED. If it happened while
/// loading a committed data source @load_event will be %WEBKIT_LOAD_COMMITTED.
/// Since a load error causes the load operation to finish, the signal
/// WebKitWebView::load-changed will always be emitted with
/// %WEBKIT_LOAD_FINISHED event right after this one.
/// </para>
/// <para>
/// By default, if the signal is not handled, a stock error page will be displayed.
/// You need to handle the signal if you want to provide your own error page.
/// </para>
/// </summary>

	public static IObservable<WebKitWebViewHandleSignalStructs.LoadFailedSignal> Signal_LoadFailed(this WebKitWebViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebViewHandleSignalStructs.LoadFailedSignal> obs) =>
		{
			WebKitWebViewHandleSignalDelegates.load_failed handler = ( MentorLake.WebKit2.WebKitWebViewHandle self,  MentorLake.WebKit2.WebKitLoadEvent load_event,  string failing_uri,  MentorLake.GLib.GErrorHandle error,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebViewHandleSignalStructs.LoadFailedSignal()
				{
					Self = self, LoadEvent = load_event, FailingUri = failing_uri, Error = error, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "load-failed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when a TLS error occurs during a load operation.
/// To allow an exception for this @certificate
/// and the host of @failing_uri use webkit_web_context_allow_tls_certificate_for_host().
/// </para>
/// <para>
/// To handle this signal asynchronously you should call g_object_ref() on @certificate
/// and return %TRUE.
/// </para>
/// <para>
/// If %FALSE is returned, #WebKitWebView::load-failed will be emitted. The load
/// will finish regardless of the returned value.
/// </para>
/// </summary>

	public static IObservable<WebKitWebViewHandleSignalStructs.LoadFailedWithTlsErrorsSignal> Signal_LoadFailedWithTlsErrors(this WebKitWebViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebViewHandleSignalStructs.LoadFailedWithTlsErrorsSignal> obs) =>
		{
			WebKitWebViewHandleSignalDelegates.load_failed_with_tls_errors handler = ( MentorLake.WebKit2.WebKitWebViewHandle self,  string failing_uri,  MentorLake.Gio.GTlsCertificateHandle certificate,  MentorLake.Gio.GTlsCertificateFlags errors,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebViewHandleSignalStructs.LoadFailedWithTlsErrorsSignal()
				{
					Self = self, FailingUri = failing_uri, Certificate = certificate, Errors = errors, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "load-failed-with-tls-errors", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted when the mouse cursor moves over an
/// element such as a link, image or a media element. To determine
/// what type of element the mouse cursor is over, a Hit Test is performed
/// on the current mouse coordinates and the result is passed in the
/// @hit_test_result argument. The @modifiers argument is a bitmask of
/// #GdkModifierType flags indicating the state of modifier keys.
/// The signal is emitted again when the mouse is moved out of the
/// current element with a new @hit_test_result.
/// </para>
/// </summary>

	public static IObservable<WebKitWebViewHandleSignalStructs.MouseTargetChangedSignal> Signal_MouseTargetChanged(this WebKitWebViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebViewHandleSignalStructs.MouseTargetChangedSignal> obs) =>
		{
			WebKitWebViewHandleSignalDelegates.mouse_target_changed handler = ( MentorLake.WebKit2.WebKitWebViewHandle self,  MentorLake.WebKit2.WebKitHitTestResultHandle hit_test_result,  uint modifiers,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebViewHandleSignalStructs.MouseTargetChangedSignal()
				{
					Self = self, HitTestResult = hit_test_result, Modifiers = modifiers, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "mouse-target-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted when WebKit is requesting the client to
/// decide about a permission request, such as allowing the browser
/// to switch to fullscreen mode, sharing its location or similar
/// operations.
/// </para>
/// <para>
/// A possible way to use this signal could be through a dialog
/// allowing the user decide what to do with the request:
/// </para>
/// <para>
/// ```c
/// static gboolean permission_request_cb (WebKitWebView *web_view,
///                                        WebKitPermissionRequest *request,
///                                        GtkWindow *parent_window)
/// {
///     GtkWidget *dialog = gtk_message_dialog_new (parent_window,
///                                                 GTK_DIALOG_MODAL,
///                                                 GTK_MESSAGE_QUESTION,
///                                                 GTK_BUTTONS_YES_NO,
///                                                 &quot;Allow Permission Request?&quot;);
///     gtk_widget_show (dialog);
///     gint result = gtk_dialog_run (GTK_DIALOG (dialog));
/// </para>
/// <para>
///     switch (result) {
///     case GTK_RESPONSE_YES:
///         webkit_permission_request_allow (request);
///         break;
///     default:
///         webkit_permission_request_deny (request);
///         break;
///     }
///     gtk_widget_destroy (dialog);
/// </para>
/// <para>
///     return TRUE;
/// }
/// ```
/// </para>
/// <para>
/// It is possible to handle permission requests asynchronously, by
/// simply calling g_object_ref() on the @request argument and
/// returning %TRUE to block the default signal handler.  If the
/// last reference is removed on a #WebKitPermissionRequest and the
/// request has not been handled, webkit_permission_request_deny()
/// will be the default action.
/// </para>
/// <para>
/// If the signal is not handled, the @request will be completed automatically
/// by the specific #WebKitPermissionRequest that could allow or deny it. Check the
/// documentation of classes implementing #WebKitPermissionRequest interface to know
/// their default action.
/// </para>
/// </summary>

	public static IObservable<WebKitWebViewHandleSignalStructs.PermissionRequestSignal> Signal_PermissionRequest(this WebKitWebViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebViewHandleSignalStructs.PermissionRequestSignal> obs) =>
		{
			WebKitWebViewHandleSignalDelegates.permission_request handler = ( MentorLake.WebKit2.WebKitWebViewHandle self,  MentorLake.WebKit2.WebKitPermissionRequestHandle request,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebViewHandleSignalStructs.PermissionRequestSignal()
				{
					Self = self, Request = request, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "permission-request", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when printing is requested on @web_view, usually by a JavaScript call,
/// before the print dialog is shown. This signal can be used to set the initial
/// print settings and page setup of @print_operation to be used as default values in
/// the print dialog. You can call webkit_print_operation_set_print_settings() and
/// webkit_print_operation_set_page_setup() and then return %FALSE to propagate the
/// event so that the print dialog is shown.
/// </para>
/// <para>
/// You can connect to this signal and return %TRUE to cancel the print operation
/// or implement your own print dialog.
/// </para>
/// </summary>

	public static IObservable<WebKitWebViewHandleSignalStructs.PrintSignal> Signal_Print(this WebKitWebViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebViewHandleSignalStructs.PrintSignal> obs) =>
		{
			WebKitWebViewHandleSignalDelegates.print handler = ( MentorLake.WebKit2.WebKitWebViewHandle self,  MentorLake.WebKit2.WebKitPrintOperationHandle print_operation,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebViewHandleSignalStructs.PrintSignal()
				{
					Self = self, PrintOperation = print_operation, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "print", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal allows the User-Agent to respond to permission requests for powerful features, as
/// specified by the [Permissions W3C Specification](https://w3c.github.io/permissions/).
/// You can reply to the query using webkit_permission_state_query_finish().
/// </para>
/// <para>
/// You can handle the query asynchronously by calling webkit_permission_state_query_ref() on
/// @query and returning %TRUE. If the last reference of @query is removed and the query has not
/// been handled, the query result will be set to %WEBKIT_QUERY_PERMISSION_PROMPT.
/// </para>
/// </summary>

	public static IObservable<WebKitWebViewHandleSignalStructs.QueryPermissionStateSignal> Signal_QueryPermissionState(this WebKitWebViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebViewHandleSignalStructs.QueryPermissionStateSignal> obs) =>
		{
			WebKitWebViewHandleSignalDelegates.query_permission_state handler = ( MentorLake.WebKit2.WebKitWebViewHandle self,  MentorLake.WebKit2.WebKitPermissionStateQueryHandle query,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebViewHandleSignalStructs.QueryPermissionStateSignal()
				{
					Self = self, Query = query, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "query-permission-state", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted after #WebKitWebView::create on the newly created #WebKitWebView
/// when it should be displayed to the user. When this signal is emitted
/// all the information about how the window should look, including
/// size, position, whether the location, status and scrollbars
/// should be displayed, is already set on the #WebKitWindowProperties
/// of @web_view. See also webkit_web_view_get_window_properties().
/// </para>
/// </summary>

	public static IObservable<WebKitWebViewHandleSignalStructs.ReadyToShowSignal> Signal_ReadyToShow(this WebKitWebViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebViewHandleSignalStructs.ReadyToShowSignal> obs) =>
		{
			WebKitWebViewHandleSignalDelegates.ready_to_show handler = ( MentorLake.WebKit2.WebKitWebViewHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebViewHandleSignalStructs.ReadyToShowSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "ready-to-show", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when a new resource is going to be loaded. The @request parameter
/// contains the #WebKitURIRequest that will be sent to the server.
/// You can monitor the load operation by connecting to the different signals
/// of @resource.
/// </para>
/// </summary>

	public static IObservable<WebKitWebViewHandleSignalStructs.ResourceLoadStartedSignal> Signal_ResourceLoadStarted(this WebKitWebViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebViewHandleSignalStructs.ResourceLoadStartedSignal> obs) =>
		{
			WebKitWebViewHandleSignalDelegates.resource_load_started handler = ( MentorLake.WebKit2.WebKitWebViewHandle self,  MentorLake.WebKit2.WebKitWebResourceHandle resource,  MentorLake.WebKit2.WebKitURIRequestHandle request,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebViewHandleSignalStructs.ResourceLoadStartedSignal()
				{
					Self = self, Resource = resource, Request = request, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "resource-load-started", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted after #WebKitWebView::ready-to-show on the newly
/// created #WebKitWebView when JavaScript code calls
/// &amp;lt;function&amp;gt;window.showModalDialog&amp;lt;/function&amp;gt;. The purpose of
/// this signal is to allow the client application to prepare the
/// new view to behave as modal. Once the signal is emitted a new
/// main loop will be run to block user interaction in the parent
/// #WebKitWebView until the new dialog is closed.
/// </para>
/// </summary>

	public static IObservable<WebKitWebViewHandleSignalStructs.RunAsModalSignal> Signal_RunAsModal(this WebKitWebViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebViewHandleSignalStructs.RunAsModalSignal> obs) =>
		{
			WebKitWebViewHandleSignalDelegates.run_as_modal handler = ( MentorLake.WebKit2.WebKitWebViewHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebViewHandleSignalStructs.RunAsModalSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "run-as-modal", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted when the user interacts with a &amp;lt;input
/// type=&apos;color&apos; /&amp;gt; HTML element, requesting from WebKit to show
/// a dialog to select a color. To let the application know the details of
/// the color chooser, as well as to allow the client application to either
/// cancel the request or perform an actual color selection, the signal will
/// pass an instance of the #WebKitColorChooserRequest in the @request
/// argument.
/// </para>
/// <para>
/// It is possible to handle this request asynchronously by increasing the
/// reference count of the request.
/// </para>
/// <para>
/// The default signal handler will asynchronously run a regular
/// #GtkColorChooser for the user to interact with.
/// </para>
/// </summary>

	public static IObservable<WebKitWebViewHandleSignalStructs.RunColorChooserSignal> Signal_RunColorChooser(this WebKitWebViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebViewHandleSignalStructs.RunColorChooserSignal> obs) =>
		{
			WebKitWebViewHandleSignalDelegates.run_color_chooser handler = ( MentorLake.WebKit2.WebKitWebViewHandle self,  MentorLake.WebKit2.WebKitColorChooserRequestHandle request,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebViewHandleSignalStructs.RunColorChooserSignal()
				{
					Self = self, Request = request, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "run-color-chooser", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted when the user interacts with a &amp;lt;input
/// type=&apos;file&apos; /&amp;gt; HTML element, requesting from WebKit to show
/// a dialog to select one or more files to be uploaded. To let the
/// application know the details of the file chooser, as well as to
/// allow the client application to either cancel the request or
/// perform an actual selection of files, the signal will pass an
/// instance of the #WebKitFileChooserRequest in the @request
/// argument.
/// </para>
/// <para>
/// The default signal handler will asynchronously run a regular
/// #GtkFileChooserDialog for the user to interact with.
/// </para>
/// </summary>

	public static IObservable<WebKitWebViewHandleSignalStructs.RunFileChooserSignal> Signal_RunFileChooser(this WebKitWebViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebViewHandleSignalStructs.RunFileChooserSignal> obs) =>
		{
			WebKitWebViewHandleSignalDelegates.run_file_chooser handler = ( MentorLake.WebKit2.WebKitWebViewHandle self,  MentorLake.WebKit2.WebKitFileChooserRequestHandle request,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebViewHandleSignalStructs.RunFileChooserSignal()
				{
					Self = self, Request = request, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "run-file-chooser", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when JavaScript code calls &amp;lt;function&amp;gt;window.alert&amp;lt;/function&amp;gt;,
/// &amp;lt;function&amp;gt;window.confirm&amp;lt;/function&amp;gt; or &amp;lt;function&amp;gt;window.prompt&amp;lt;/function&amp;gt;,
/// or when &amp;lt;function&amp;gt;onbeforeunload&amp;lt;/function&amp;gt; event is fired.
/// The @dialog parameter should be used to build the dialog.
/// If the signal is not handled a different dialog will be built and shown depending
/// on the dialog type:
/// &amp;lt;itemizedlist&amp;gt;
/// &amp;lt;listitem&amp;gt;&amp;lt;para&amp;gt;
///  %WEBKIT_SCRIPT_DIALOG_ALERT: message dialog with a single Close button.
/// &amp;lt;/para&amp;gt;&amp;lt;/listitem&amp;gt;
/// &amp;lt;listitem&amp;gt;&amp;lt;para&amp;gt;
///  %WEBKIT_SCRIPT_DIALOG_CONFIRM: message dialog with OK and Cancel buttons.
/// &amp;lt;/para&amp;gt;&amp;lt;/listitem&amp;gt;
/// &amp;lt;listitem&amp;gt;&amp;lt;para&amp;gt;
///  %WEBKIT_SCRIPT_DIALOG_PROMPT: message dialog with OK and Cancel buttons and
///  a text entry with the default text.
/// &amp;lt;/para&amp;gt;&amp;lt;/listitem&amp;gt;
/// &amp;lt;listitem&amp;gt;&amp;lt;para&amp;gt;
///  %WEBKIT_SCRIPT_DIALOG_BEFORE_UNLOAD_CONFIRM: message dialog with Stay and Leave buttons.
/// &amp;lt;/para&amp;gt;&amp;lt;/listitem&amp;gt;
/// &amp;lt;/itemizedlist&amp;gt;
/// </para>
/// <para>
/// It is possible to handle the script dialog request asynchronously, by simply
/// caling webkit_script_dialog_ref() on the @dialog argument and calling
/// webkit_script_dialog_close() when done.
/// If the last reference is removed on a #WebKitScriptDialog and the dialog has not been
/// closed, webkit_script_dialog_close() will be called.
/// </para>
/// </summary>

	public static IObservable<WebKitWebViewHandleSignalStructs.ScriptDialogSignal> Signal_ScriptDialog(this WebKitWebViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebViewHandleSignalStructs.ScriptDialogSignal> obs) =>
		{
			WebKitWebViewHandleSignalDelegates.script_dialog handler = ( MentorLake.WebKit2.WebKitWebViewHandle self,  MentorLake.WebKit2.WebKitScriptDialogHandle dialog,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebViewHandleSignalStructs.ScriptDialogSignal()
				{
					Self = self, Dialog = dialog, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "script-dialog", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted when a notification should be presented to the
/// user. The @notification is kept alive until either: 1) the web page cancels it
/// or 2) a navigation happens.
/// </para>
/// <para>
/// The default handler will emit a notification using libnotify, if built with
/// support for it.
/// </para>
/// </summary>

	public static IObservable<WebKitWebViewHandleSignalStructs.ShowNotificationSignal> Signal_ShowNotification(this WebKitWebViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebViewHandleSignalStructs.ShowNotificationSignal> obs) =>
		{
			WebKitWebViewHandleSignalDelegates.show_notification handler = ( MentorLake.WebKit2.WebKitWebViewHandle self,  MentorLake.WebKit2.WebKitNotificationHandle notification,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebViewHandleSignalStructs.ShowNotificationSignal()
				{
					Self = self, Notification = notification, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "show-notification", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted when a select element in @web_view needs to display a
/// dropdown menu. This signal can be used to show a custom menu, using @menu to get
/// the details of all items that should be displayed. The area of the element in the
/// #WebKitWebView is given as @rectangle parameter, it can be used to position the
/// menu. If this was triggered by a user interaction, like a mouse click,
/// @event parameter provides the #GdkEvent.
/// To handle this signal asynchronously you should keep a ref of the @menu.
/// </para>
/// <para>
/// The @event parameter is now deprecated. Use webkit_option_menu_get_event() to get the
/// #GdkEvent that triggered the dropdown menu.
/// </para>
/// <para>
/// The default signal handler will pop up a #GtkMenu.
/// </para>
/// </summary>

	public static IObservable<WebKitWebViewHandleSignalStructs.ShowOptionMenuSignal> Signal_ShowOptionMenu(this WebKitWebViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebViewHandleSignalStructs.ShowOptionMenuSignal> obs) =>
		{
			WebKitWebViewHandleSignalDelegates.show_option_menu handler = ( MentorLake.WebKit2.WebKitWebViewHandle self,  MentorLake.WebKit2.WebKitOptionMenuHandle menu,  MentorLake.Gdk.GdkEventHandle @event,  MentorLake.Gdk.GdkRectangleHandle rectangle,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebViewHandleSignalStructs.ShowOptionMenuSignal()
				{
					Self = self, Menu = menu, Event = @event, Rectangle = rectangle, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "show-option-menu", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted when a form is about to be submitted. The @request
/// argument passed contains information about the text fields of the form. This
/// is typically used to store login information that can be used later to
/// pre-fill the form.
/// The form will not be submitted until webkit_form_submission_request_submit() is called.
/// </para>
/// <para>
/// It is possible to handle the form submission request asynchronously, by
/// simply calling g_object_ref() on the @request argument and calling
/// webkit_form_submission_request_submit() when done to continue with the form submission.
/// If the last reference is removed on a #WebKitFormSubmissionRequest and the
/// form has not been submitted, webkit_form_submission_request_submit() will be called.
/// </para>
/// </summary>

	public static IObservable<WebKitWebViewHandleSignalStructs.SubmitFormSignal> Signal_SubmitForm(this WebKitWebViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebViewHandleSignalStructs.SubmitFormSignal> obs) =>
		{
			WebKitWebViewHandleSignalDelegates.submit_form handler = ( MentorLake.WebKit2.WebKitWebViewHandle self,  MentorLake.WebKit2.WebKitFormSubmissionRequestHandle request,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebViewHandleSignalStructs.SubmitFormSignal()
				{
					Self = self, Request = request, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "submit-form", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted when a #WebKitUserMessage is received from the
/// #WebKitWebPage corresponding to @web_view. You can reply to the message
/// using webkit_user_message_send_reply().
/// </para>
/// <para>
/// You can handle the user message asynchronously by calling g_object_ref() on
/// @message and returning %TRUE. If the last reference of @message is removed
/// and the message has not been replied to, the operation in the #WebKitWebPage will
/// finish with error %WEBKIT_USER_MESSAGE_UNHANDLED_MESSAGE.
/// </para>
/// </summary>

	public static IObservable<WebKitWebViewHandleSignalStructs.UserMessageReceivedSignal> Signal_UserMessageReceived(this WebKitWebViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebViewHandleSignalStructs.UserMessageReceivedSignal> obs) =>
		{
			WebKitWebViewHandleSignalDelegates.user_message_received handler = ( MentorLake.WebKit2.WebKitWebViewHandle self,  MentorLake.WebKit2.WebKitUserMessageHandle message,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebViewHandleSignalStructs.UserMessageReceivedSignal()
				{
					Self = self, Message = message, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "user-message-received", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted when the web process crashes.
/// </para>
/// </summary>

	public static IObservable<WebKitWebViewHandleSignalStructs.WebProcessCrashedSignal> Signal_WebProcessCrashed(this WebKitWebViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebViewHandleSignalStructs.WebProcessCrashedSignal> obs) =>
		{
			WebKitWebViewHandleSignalDelegates.web_process_crashed handler = ( MentorLake.WebKit2.WebKitWebViewHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebViewHandleSignalStructs.WebProcessCrashedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "web-process-crashed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted when the web process terminates abnormally due
/// to @reason.
/// </para>
/// </summary>

	public static IObservable<WebKitWebViewHandleSignalStructs.WebProcessTerminatedSignal> Signal_WebProcessTerminated(this WebKitWebViewHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebViewHandleSignalStructs.WebProcessTerminatedSignal> obs) =>
		{
			WebKitWebViewHandleSignalDelegates.web_process_terminated handler = ( MentorLake.WebKit2.WebKitWebViewHandle self,  MentorLake.WebKit2.WebKitWebProcessTerminationReason reason,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebViewHandleSignalStructs.WebProcessTerminatedSignal()
				{
					Self = self, Reason = reason, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "web-process-terminated", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class WebKitWebViewHandleSignalStructs
{

public class AuthenticateSignal
{

	public MentorLake.WebKit2.WebKitWebViewHandle Self;
/// <summary>
/// <para>
/// a #WebKitAuthenticationRequest
/// </para>
/// </summary>

	public MentorLake.WebKit2.WebKitAuthenticationRequestHandle Request;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class CloseSignal
{

	public MentorLake.WebKit2.WebKitWebViewHandle Self;

	public IntPtr UserData;
}

public class ContextMenuSignal
{

	public MentorLake.WebKit2.WebKitWebViewHandle Self;
/// <summary>
/// <para>
/// the proposed #WebKitContextMenu
/// </para>
/// </summary>

	public MentorLake.WebKit2.WebKitContextMenuHandle ContextMenu;
/// <summary>
/// <para>
/// the #GdkEvent that triggered the context menu. Deprecated 2.40.
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkEventHandle Event;
/// <summary>
/// <para>
/// a #WebKitHitTestResult
/// </para>
/// </summary>

	public MentorLake.WebKit2.WebKitHitTestResultHandle HitTestResult;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///    %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class ContextMenuDismissedSignal
{

	public MentorLake.WebKit2.WebKitWebViewHandle Self;

	public IntPtr UserData;
}

public class CreateSignal
{

	public MentorLake.WebKit2.WebKitWebViewHandle Self;
/// <summary>
/// <para>
/// a #WebKitNavigationAction
/// </para>
/// </summary>

	public MentorLake.WebKit2.WebKitNavigationActionHandle NavigationAction;

	public IntPtr UserData;
/// <summary>
/// <para>
/// a newly allocated #WebKitWebView widget
///    or %NULL to propagate the event further.
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkWidgetHandle ReturnValue;
}

public class DecidePolicySignal
{

	public MentorLake.WebKit2.WebKitWebViewHandle Self;
/// <summary>
/// <para>
/// the #WebKitPolicyDecision
/// </para>
/// </summary>

	public MentorLake.WebKit2.WebKitPolicyDecisionHandle Decision;
/// <summary>
/// <para>
/// a #WebKitPolicyDecisionType denoting the type of @decision
/// </para>
/// </summary>

	public MentorLake.WebKit2.WebKitPolicyDecisionType DecisionType;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class EnterFullscreenSignal
{

	public MentorLake.WebKit2.WebKitWebViewHandle Self;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///    %FALSE to continue emission of the event.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class InsecureContentDetectedSignal
{

	public MentorLake.WebKit2.WebKitWebViewHandle Self;
/// <summary>
/// <para>
/// the #WebKitInsecureContentEvent
/// </para>
/// </summary>

	public MentorLake.WebKit2.WebKitInsecureContentEvent Event;

	public IntPtr UserData;
}

public class LeaveFullscreenSignal
{

	public MentorLake.WebKit2.WebKitWebViewHandle Self;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///    %FALSE to continue emission of the event.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class LoadChangedSignal
{

	public MentorLake.WebKit2.WebKitWebViewHandle Self;
/// <summary>
/// <para>
/// the #WebKitLoadEvent
/// </para>
/// </summary>

	public MentorLake.WebKit2.WebKitLoadEvent LoadEvent;

	public IntPtr UserData;
}

public class LoadFailedSignal
{

	public MentorLake.WebKit2.WebKitWebViewHandle Self;
/// <summary>
/// <para>
/// the #WebKitLoadEvent of the load operation
/// </para>
/// </summary>

	public MentorLake.WebKit2.WebKitLoadEvent LoadEvent;
/// <summary>
/// <para>
/// the URI that failed to load
/// </para>
/// </summary>

	public string FailingUri;
/// <summary>
/// <para>
/// the #GError that was triggered
/// </para>
/// </summary>

	public MentorLake.GLib.GErrorHandle Error;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///    %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class LoadFailedWithTlsErrorsSignal
{

	public MentorLake.WebKit2.WebKitWebViewHandle Self;
/// <summary>
/// <para>
/// the URI that failed to load
/// </para>
/// </summary>

	public string FailingUri;
/// <summary>
/// <para>
/// a #GTlsCertificate
/// </para>
/// </summary>

	public MentorLake.Gio.GTlsCertificateHandle Certificate;
/// <summary>
/// <para>
/// a #GTlsCertificateFlags with the verification status of @certificate
/// </para>
/// </summary>

	public MentorLake.Gio.GTlsCertificateFlags Errors;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class MouseTargetChangedSignal
{

	public MentorLake.WebKit2.WebKitWebViewHandle Self;
/// <summary>
/// <para>
/// a #WebKitHitTestResult
/// </para>
/// </summary>

	public MentorLake.WebKit2.WebKitHitTestResultHandle HitTestResult;
/// <summary>
/// <para>
/// a bitmask of #GdkModifierType
/// </para>
/// </summary>

	public uint Modifiers;

	public IntPtr UserData;
}

public class PermissionRequestSignal
{

	public MentorLake.WebKit2.WebKitWebViewHandle Self;
/// <summary>
/// <para>
/// the #WebKitPermissionRequest
/// </para>
/// </summary>

	public MentorLake.WebKit2.WebKitPermissionRequestHandle Request;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class PrintSignal
{

	public MentorLake.WebKit2.WebKitWebViewHandle Self;
/// <summary>
/// <para>
/// the #WebKitPrintOperation that will handle the print request
/// </para>
/// </summary>

	public MentorLake.WebKit2.WebKitPrintOperationHandle PrintOperation;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///    %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class QueryPermissionStateSignal
{

	public MentorLake.WebKit2.WebKitWebViewHandle Self;
/// <summary>
/// <para>
/// the #WebKitPermissionStateQuery
/// </para>
/// </summary>

	public MentorLake.WebKit2.WebKitPermissionStateQueryHandle Query;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE if the message was handled, or %FALSE otherwise.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class ReadyToShowSignal
{

	public MentorLake.WebKit2.WebKitWebViewHandle Self;

	public IntPtr UserData;
}

public class ResourceLoadStartedSignal
{

	public MentorLake.WebKit2.WebKitWebViewHandle Self;
/// <summary>
/// <para>
/// a #WebKitWebResource
/// </para>
/// </summary>

	public MentorLake.WebKit2.WebKitWebResourceHandle Resource;
/// <summary>
/// <para>
/// a #WebKitURIRequest
/// </para>
/// </summary>

	public MentorLake.WebKit2.WebKitURIRequestHandle Request;

	public IntPtr UserData;
}

public class RunAsModalSignal
{

	public MentorLake.WebKit2.WebKitWebViewHandle Self;

	public IntPtr UserData;
}

public class RunColorChooserSignal
{

	public MentorLake.WebKit2.WebKitWebViewHandle Self;
/// <summary>
/// <para>
/// a #WebKitColorChooserRequest
/// </para>
/// </summary>

	public MentorLake.WebKit2.WebKitColorChooserRequestHandle Request;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class RunFileChooserSignal
{

	public MentorLake.WebKit2.WebKitWebViewHandle Self;
/// <summary>
/// <para>
/// a #WebKitFileChooserRequest
/// </para>
/// </summary>

	public MentorLake.WebKit2.WebKitFileChooserRequestHandle Request;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class ScriptDialogSignal
{

	public MentorLake.WebKit2.WebKitWebViewHandle Self;
/// <summary>
/// <para>
/// the #WebKitScriptDialog to show
/// </para>
/// </summary>

	public MentorLake.WebKit2.WebKitScriptDialogHandle Dialog;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///    %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class ShowNotificationSignal
{

	public MentorLake.WebKit2.WebKitWebViewHandle Self;
/// <summary>
/// <para>
/// a #WebKitNotification
/// </para>
/// </summary>

	public MentorLake.WebKit2.WebKitNotificationHandle Notification;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked. %FALSE otherwise.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class ShowOptionMenuSignal
{

	public MentorLake.WebKit2.WebKitWebViewHandle Self;
/// <summary>
/// <para>
/// the #WebKitOptionMenu
/// </para>
/// </summary>

	public MentorLake.WebKit2.WebKitOptionMenuHandle Menu;
/// <summary>
/// <para>
/// the #GdkEvent that triggered the menu, or %NULL. Deprecated 2.40
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkEventHandle Event;
/// <summary>
/// <para>
/// the option element area
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkRectangleHandle Rectangle;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class SubmitFormSignal
{

	public MentorLake.WebKit2.WebKitWebViewHandle Self;
/// <summary>
/// <para>
/// a #WebKitFormSubmissionRequest
/// </para>
/// </summary>

	public MentorLake.WebKit2.WebKitFormSubmissionRequestHandle Request;

	public IntPtr UserData;
}

public class UserMessageReceivedSignal
{

	public MentorLake.WebKit2.WebKitWebViewHandle Self;
/// <summary>
/// <para>
/// the #WebKitUserMessage received
/// </para>
/// </summary>

	public MentorLake.WebKit2.WebKitUserMessageHandle Message;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE if the message was handled, or %FALSE otherwise.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class WebProcessCrashedSignal
{

	public MentorLake.WebKit2.WebKitWebViewHandle Self;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///    %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class WebProcessTerminatedSignal
{

	public MentorLake.WebKit2.WebKitWebViewHandle Self;
/// <summary>
/// <para>
/// the a #WebKitWebProcessTerminationReason
/// </para>
/// </summary>

	public MentorLake.WebKit2.WebKitWebProcessTerminationReason Reason;

	public IntPtr UserData;
}
}

public static class WebKitWebViewHandleSignalDelegates
{

/// <summary>
/// <para>
/// This signal is emitted when the user is challenged with HTTP
/// authentication. To let the  application access or supply
/// the credentials as well as to allow the client application
/// to either cancel the request or perform the authentication,
/// the signal will pass an instance of the
/// #WebKitAuthenticationRequest in the @request argument.
/// To handle this signal asynchronously you should keep a ref
/// of the request and return %TRUE. To disable HTTP authentication
/// entirely, connect to this signal and simply return %TRUE.
/// </para>
/// <para>
/// The default signal handler will run a default authentication
/// dialog asynchronously for the user to interact with.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="request">
/// a #WebKitAuthenticationRequest
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool authenticate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitAuthenticationRequestHandle>))] MentorLake.WebKit2.WebKitAuthenticationRequestHandle request, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when closing a #WebKitWebView is requested. This occurs when a
/// call is made from JavaScript&apos;s &amp;lt;function&amp;gt;window.close&amp;lt;/function&amp;gt; function or
/// after trying to close the @web_view with webkit_web_view_try_close().
/// It is the owner&apos;s responsibility to handle this signal to hide or
/// destroy the #WebKitWebView, if necessary.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when a context menu is about to be displayed to give the application
/// a chance to customize the proposed menu, prevent the menu from being displayed,
/// or build its own context menu.
/// &amp;lt;itemizedlist&amp;gt;
/// &amp;lt;listitem&amp;gt;&amp;lt;para&amp;gt;
///  To customize the proposed menu you can use webkit_context_menu_prepend(),
///  webkit_context_menu_append() or webkit_context_menu_insert() to add new
///  #WebKitContextMenuItem&amp;lt;!-- --&amp;gt;s to @context_menu, webkit_context_menu_move_item()
///  to reorder existing items, or webkit_context_menu_remove() to remove an
///  existing item. The signal handler should return %FALSE, and the menu represented
///  by @context_menu will be shown.
/// &amp;lt;/para&amp;gt;&amp;lt;/listitem&amp;gt;
/// &amp;lt;listitem&amp;gt;&amp;lt;para&amp;gt;
///  To prevent the menu from being displayed you can just connect to this signal
///  and return %TRUE so that the proposed menu will not be shown.
/// &amp;lt;/para&amp;gt;&amp;lt;/listitem&amp;gt;
/// &amp;lt;listitem&amp;gt;&amp;lt;para&amp;gt;
///  To build your own menu, you can remove all items from the proposed menu with
///  webkit_context_menu_remove_all(), add your own items and return %FALSE so
///  that the menu will be shown. You can also ignore the proposed #WebKitContextMenu,
///  build your own #GtkMenu and return %TRUE to prevent the proposed menu from being shown.
/// &amp;lt;/para&amp;gt;&amp;lt;/listitem&amp;gt;
/// &amp;lt;listitem&amp;gt;&amp;lt;para&amp;gt;
///  If you just want the default menu to be shown always, simply don&apos;t connect to this
///  signal because showing the proposed context menu is the default behaviour.
/// &amp;lt;/para&amp;gt;&amp;lt;/listitem&amp;gt;
/// &amp;lt;/itemizedlist&amp;gt;
/// </para>
/// <para>
/// The @event parameter is now deprecated. Use webkit_context_menu_get_event() to get the
/// #GdkEvent that triggered the context menu.
/// </para>
/// <para>
/// If the signal handler returns %FALSE the context menu represented by @context_menu
/// will be shown, if it return %TRUE the context menu will not be shown.
/// </para>
/// <para>
/// The proposed #WebKitContextMenu passed in @context_menu argument is only valid
/// during the signal emission.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="context_menu">
/// the proposed #WebKitContextMenu
/// </param>
/// <param name="@event">
/// the #GdkEvent that triggered the context menu. Deprecated 2.40.
/// </param>
/// <param name="hit_test_result">
/// a #WebKitHitTestResult
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
///    %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool context_menu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitContextMenuHandle>))] MentorLake.WebKit2.WebKitContextMenuHandle context_menu, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitHitTestResultHandle>))] MentorLake.WebKit2.WebKitHitTestResultHandle hit_test_result, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted after #WebKitWebView::context-menu signal, if the context menu is shown,
/// to notify that the context menu is dismissed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void context_menu_dismissed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when the creation of a new #WebKitWebView is requested.
/// If this signal is handled the signal handler should return the
/// newly created #WebKitWebView.
/// </para>
/// <para>
/// The #WebKitNavigationAction parameter contains information about the
/// navigation action that triggered this signal.
/// </para>
/// <para>
/// The new #WebKitWebView must be related to @web_view, see
/// #WebKitWebView:related-view for more details.
/// </para>
/// <para>
/// The new #WebKitWebView should not be displayed to the user
/// until the #WebKitWebView::ready-to-show signal is emitted.
/// </para>
/// <para>
/// For creating views as response to automation tools requests, see the
/// #WebKitAutomationSession::create-web-view signal.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="navigation_action">
/// a #WebKitNavigationAction
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// a newly allocated #WebKitWebView widget
///    or %NULL to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.Gtk.GtkWidgetHandle create([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitNavigationActionHandle>))] MentorLake.WebKit2.WebKitNavigationActionHandle navigation_action, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when WebKit is requesting the client to decide a policy
/// decision, such as whether to navigate to a page, open a new window or whether or
/// not to download a resource. The #WebKitNavigationPolicyDecision passed in the
/// @decision argument is a generic type, but should be casted to a more
/// specific type when making the decision. For example:
/// </para>
/// <para>
/// ```c
/// static gboolean
/// decide_policy_cb (WebKitWebView *web_view,
///                   WebKitPolicyDecision *decision,
///                   WebKitPolicyDecisionType type)
/// {
///     switch (type) {
///     case WEBKIT_POLICY_DECISION_TYPE_NAVIGATION_ACTION: {
///         WebKitNavigationPolicyDecision *navigation_decision = WEBKIT_NAVIGATION_POLICY_DECISION (decision);
///         // Make a policy decision here
///         break;
///     }
///     case WEBKIT_POLICY_DECISION_TYPE_NEW_WINDOW_ACTION: {
///         WebKitNavigationPolicyDecision *navigation_decision = WEBKIT_NAVIGATION_POLICY_DECISION (decision);
///         // Make a policy decision here
///         break;
///     }
///     case WEBKIT_POLICY_DECISION_TYPE_RESPONSE:
///         WebKitResponsePolicyDecision *response = WEBKIT_RESPONSE_POLICY_DECISION (decision);
///         // Make a policy decision here
///         break;
///     default:
///         // Making no decision results in webkit_policy_decision_use()
///         return FALSE;
///     }
///     return TRUE;
/// }
/// ```
/// </para>
/// <para>
/// It is possible to make policy decision asynchronously, by simply calling g_object_ref()
/// on the @decision argument and returning %TRUE to block the default signal handler.
/// If the last reference is removed on a #WebKitPolicyDecision and no decision has been
/// made explicitly, webkit_policy_decision_use() will be the default policy decision. The
/// default signal handler will simply call webkit_policy_decision_use(). Only the first
/// policy decision chosen for a given #WebKitPolicyDecision will have any affect.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="decision">
/// the #WebKitPolicyDecision
/// </param>
/// <param name="decision_type">
/// a #WebKitPolicyDecisionType denoting the type of @decision
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool decide_policy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitPolicyDecisionHandle>))] MentorLake.WebKit2.WebKitPolicyDecisionHandle decision, MentorLake.WebKit2.WebKitPolicyDecisionType decision_type, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when JavaScript code calls
/// &amp;lt;function&amp;gt;element.webkitRequestFullScreen&amp;lt;/function&amp;gt;. If the
/// signal is not handled the #WebKitWebView will proceed to full screen
/// its top level window. This signal can be used by client code to
/// request permission to the user prior doing the full screen
/// transition and eventually prepare the top-level window
/// (e.g. hide some widgets that would otherwise be part of the
/// full screen window).
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
///    %FALSE to continue emission of the event.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool enter_fullscreen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Prior to 2.46, this signal was emitted when insecure content was
/// loaded in a secure content. Since 2.46, this signal is generally
/// no longer emitted.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@event">
/// the #WebKitInsecureContentEvent
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void insecure_content_detected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle self, MentorLake.WebKit2.WebKitInsecureContentEvent @event, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when the #WebKitWebView is about to restore its top level
/// window out of its full screen state. This signal can be used by
/// client code to restore widgets hidden during the
/// #WebKitWebView::enter-fullscreen stage for instance.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
///    %FALSE to continue emission of the event.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool leave_fullscreen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when a load operation in @web_view changes.
/// The signal is always emitted with %WEBKIT_LOAD_STARTED when a
/// new load request is made and %WEBKIT_LOAD_FINISHED when the load
/// finishes successfully or due to an error. When the ongoing load
/// operation fails #WebKitWebView::load-failed signal is emitted
/// before #WebKitWebView::load-changed is emitted with
/// %WEBKIT_LOAD_FINISHED.
/// If a redirection is received from the server, this signal is emitted
/// with %WEBKIT_LOAD_REDIRECTED after the initial emission with
/// %WEBKIT_LOAD_STARTED and before %WEBKIT_LOAD_COMMITTED.
/// When the page content starts arriving the signal is emitted with
/// %WEBKIT_LOAD_COMMITTED event.
/// </para>
/// <para>
/// You can handle this signal and use a switch to track any ongoing
/// load operation.
/// </para>
/// <para>
/// ```c
/// static void web_view_load_changed (WebKitWebView  *web_view,
///                                    WebKitLoadEvent load_event,
///                                    gpointer        user_data)
/// {
///     switch (load_event) {
///     case WEBKIT_LOAD_STARTED:
///         // New load, we have now a provisional URI
///         provisional_uri = webkit_web_view_get_uri (web_view);
///         // Here we could start a spinner or update the
///         // location bar with the provisional URI
///         break;
///     case WEBKIT_LOAD_REDIRECTED:
///         redirected_uri = webkit_web_view_get_uri (web_view);
///         break;
///     case WEBKIT_LOAD_COMMITTED:
///         // The load is being performed. Current URI is
///         // the final one and it won&apos;t change unless a new
///         // load is requested or a navigation within the
///         // same page is performed
///         uri = webkit_web_view_get_uri (web_view);
///         break;
///     case WEBKIT_LOAD_FINISHED:
///         // Load finished, we can now stop the spinner
///         break;
///     }
/// }
/// ```
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="load_event">
/// the #WebKitLoadEvent
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void load_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle self, MentorLake.WebKit2.WebKitLoadEvent load_event, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when an error occurs during a load operation.
/// If the error happened when starting to load data for a page
/// @load_event will be %WEBKIT_LOAD_STARTED. If it happened while
/// loading a committed data source @load_event will be %WEBKIT_LOAD_COMMITTED.
/// Since a load error causes the load operation to finish, the signal
/// WebKitWebView::load-changed will always be emitted with
/// %WEBKIT_LOAD_FINISHED event right after this one.
/// </para>
/// <para>
/// By default, if the signal is not handled, a stock error page will be displayed.
/// You need to handle the signal if you want to provide your own error page.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="load_event">
/// the #WebKitLoadEvent of the load operation
/// </param>
/// <param name="failing_uri">
/// the URI that failed to load
/// </param>
/// <param name="error">
/// the #GError that was triggered
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
///    %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool load_failed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle self, MentorLake.WebKit2.WebKitLoadEvent load_event, string failing_uri, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when a TLS error occurs during a load operation.
/// To allow an exception for this @certificate
/// and the host of @failing_uri use webkit_web_context_allow_tls_certificate_for_host().
/// </para>
/// <para>
/// To handle this signal asynchronously you should call g_object_ref() on @certificate
/// and return %TRUE.
/// </para>
/// <para>
/// If %FALSE is returned, #WebKitWebView::load-failed will be emitted. The load
/// will finish regardless of the returned value.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="failing_uri">
/// the URI that failed to load
/// </param>
/// <param name="certificate">
/// a #GTlsCertificate
/// </param>
/// <param name="errors">
/// a #GTlsCertificateFlags with the verification status of @certificate
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool load_failed_with_tls_errors([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle self, string failing_uri, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle certificate, MentorLake.Gio.GTlsCertificateFlags errors, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when the mouse cursor moves over an
/// element such as a link, image or a media element. To determine
/// what type of element the mouse cursor is over, a Hit Test is performed
/// on the current mouse coordinates and the result is passed in the
/// @hit_test_result argument. The @modifiers argument is a bitmask of
/// #GdkModifierType flags indicating the state of modifier keys.
/// The signal is emitted again when the mouse is moved out of the
/// current element with a new @hit_test_result.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="hit_test_result">
/// a #WebKitHitTestResult
/// </param>
/// <param name="modifiers">
/// a bitmask of #GdkModifierType
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void mouse_target_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitHitTestResultHandle>))] MentorLake.WebKit2.WebKitHitTestResultHandle hit_test_result, uint modifiers, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when WebKit is requesting the client to
/// decide about a permission request, such as allowing the browser
/// to switch to fullscreen mode, sharing its location or similar
/// operations.
/// </para>
/// <para>
/// A possible way to use this signal could be through a dialog
/// allowing the user decide what to do with the request:
/// </para>
/// <para>
/// ```c
/// static gboolean permission_request_cb (WebKitWebView *web_view,
///                                        WebKitPermissionRequest *request,
///                                        GtkWindow *parent_window)
/// {
///     GtkWidget *dialog = gtk_message_dialog_new (parent_window,
///                                                 GTK_DIALOG_MODAL,
///                                                 GTK_MESSAGE_QUESTION,
///                                                 GTK_BUTTONS_YES_NO,
///                                                 &quot;Allow Permission Request?&quot;);
///     gtk_widget_show (dialog);
///     gint result = gtk_dialog_run (GTK_DIALOG (dialog));
/// </para>
/// <para>
///     switch (result) {
///     case GTK_RESPONSE_YES:
///         webkit_permission_request_allow (request);
///         break;
///     default:
///         webkit_permission_request_deny (request);
///         break;
///     }
///     gtk_widget_destroy (dialog);
/// </para>
/// <para>
///     return TRUE;
/// }
/// ```
/// </para>
/// <para>
/// It is possible to handle permission requests asynchronously, by
/// simply calling g_object_ref() on the @request argument and
/// returning %TRUE to block the default signal handler.  If the
/// last reference is removed on a #WebKitPermissionRequest and the
/// request has not been handled, webkit_permission_request_deny()
/// will be the default action.
/// </para>
/// <para>
/// If the signal is not handled, the @request will be completed automatically
/// by the specific #WebKitPermissionRequest that could allow or deny it. Check the
/// documentation of classes implementing #WebKitPermissionRequest interface to know
/// their default action.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="request">
/// the #WebKitPermissionRequest
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool permission_request([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitPermissionRequestHandleImpl>))] MentorLake.WebKit2.WebKitPermissionRequestHandle request, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when printing is requested on @web_view, usually by a JavaScript call,
/// before the print dialog is shown. This signal can be used to set the initial
/// print settings and page setup of @print_operation to be used as default values in
/// the print dialog. You can call webkit_print_operation_set_print_settings() and
/// webkit_print_operation_set_page_setup() and then return %FALSE to propagate the
/// event so that the print dialog is shown.
/// </para>
/// <para>
/// You can connect to this signal and return %TRUE to cancel the print operation
/// or implement your own print dialog.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="print_operation">
/// the #WebKitPrintOperation that will handle the print request
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
///    %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool print([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitPrintOperationHandle>))] MentorLake.WebKit2.WebKitPrintOperationHandle print_operation, IntPtr user_data);


/// <summary>
/// <para>
/// This signal allows the User-Agent to respond to permission requests for powerful features, as
/// specified by the [Permissions W3C Specification](https://w3c.github.io/permissions/).
/// You can reply to the query using webkit_permission_state_query_finish().
/// </para>
/// <para>
/// You can handle the query asynchronously by calling webkit_permission_state_query_ref() on
/// @query and returning %TRUE. If the last reference of @query is removed and the query has not
/// been handled, the query result will be set to %WEBKIT_QUERY_PERMISSION_PROMPT.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="query">
/// the #WebKitPermissionStateQuery
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE if the message was handled, or %FALSE otherwise.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool query_permission_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitPermissionStateQueryHandle>))] MentorLake.WebKit2.WebKitPermissionStateQueryHandle query, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted after #WebKitWebView::create on the newly created #WebKitWebView
/// when it should be displayed to the user. When this signal is emitted
/// all the information about how the window should look, including
/// size, position, whether the location, status and scrollbars
/// should be displayed, is already set on the #WebKitWindowProperties
/// of @web_view. See also webkit_web_view_get_window_properties().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void ready_to_show([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when a new resource is going to be loaded. The @request parameter
/// contains the #WebKitURIRequest that will be sent to the server.
/// You can monitor the load operation by connecting to the different signals
/// of @resource.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="resource">
/// a #WebKitWebResource
/// </param>
/// <param name="request">
/// a #WebKitURIRequest
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void resource_load_started([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebResourceHandle>))] MentorLake.WebKit2.WebKitWebResourceHandle resource, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitURIRequestHandle>))] MentorLake.WebKit2.WebKitURIRequestHandle request, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted after #WebKitWebView::ready-to-show on the newly
/// created #WebKitWebView when JavaScript code calls
/// &amp;lt;function&amp;gt;window.showModalDialog&amp;lt;/function&amp;gt;. The purpose of
/// this signal is to allow the client application to prepare the
/// new view to behave as modal. Once the signal is emitted a new
/// main loop will be run to block user interaction in the parent
/// #WebKitWebView until the new dialog is closed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void run_as_modal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when the user interacts with a &amp;lt;input
/// type=&apos;color&apos; /&amp;gt; HTML element, requesting from WebKit to show
/// a dialog to select a color. To let the application know the details of
/// the color chooser, as well as to allow the client application to either
/// cancel the request or perform an actual color selection, the signal will
/// pass an instance of the #WebKitColorChooserRequest in the @request
/// argument.
/// </para>
/// <para>
/// It is possible to handle this request asynchronously by increasing the
/// reference count of the request.
/// </para>
/// <para>
/// The default signal handler will asynchronously run a regular
/// #GtkColorChooser for the user to interact with.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="request">
/// a #WebKitColorChooserRequest
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool run_color_chooser([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitColorChooserRequestHandle>))] MentorLake.WebKit2.WebKitColorChooserRequestHandle request, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when the user interacts with a &amp;lt;input
/// type=&apos;file&apos; /&amp;gt; HTML element, requesting from WebKit to show
/// a dialog to select one or more files to be uploaded. To let the
/// application know the details of the file chooser, as well as to
/// allow the client application to either cancel the request or
/// perform an actual selection of files, the signal will pass an
/// instance of the #WebKitFileChooserRequest in the @request
/// argument.
/// </para>
/// <para>
/// The default signal handler will asynchronously run a regular
/// #GtkFileChooserDialog for the user to interact with.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="request">
/// a #WebKitFileChooserRequest
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool run_file_chooser([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFileChooserRequestHandle>))] MentorLake.WebKit2.WebKitFileChooserRequestHandle request, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when JavaScript code calls &amp;lt;function&amp;gt;window.alert&amp;lt;/function&amp;gt;,
/// &amp;lt;function&amp;gt;window.confirm&amp;lt;/function&amp;gt; or &amp;lt;function&amp;gt;window.prompt&amp;lt;/function&amp;gt;,
/// or when &amp;lt;function&amp;gt;onbeforeunload&amp;lt;/function&amp;gt; event is fired.
/// The @dialog parameter should be used to build the dialog.
/// If the signal is not handled a different dialog will be built and shown depending
/// on the dialog type:
/// &amp;lt;itemizedlist&amp;gt;
/// &amp;lt;listitem&amp;gt;&amp;lt;para&amp;gt;
///  %WEBKIT_SCRIPT_DIALOG_ALERT: message dialog with a single Close button.
/// &amp;lt;/para&amp;gt;&amp;lt;/listitem&amp;gt;
/// &amp;lt;listitem&amp;gt;&amp;lt;para&amp;gt;
///  %WEBKIT_SCRIPT_DIALOG_CONFIRM: message dialog with OK and Cancel buttons.
/// &amp;lt;/para&amp;gt;&amp;lt;/listitem&amp;gt;
/// &amp;lt;listitem&amp;gt;&amp;lt;para&amp;gt;
///  %WEBKIT_SCRIPT_DIALOG_PROMPT: message dialog with OK and Cancel buttons and
///  a text entry with the default text.
/// &amp;lt;/para&amp;gt;&amp;lt;/listitem&amp;gt;
/// &amp;lt;listitem&amp;gt;&amp;lt;para&amp;gt;
///  %WEBKIT_SCRIPT_DIALOG_BEFORE_UNLOAD_CONFIRM: message dialog with Stay and Leave buttons.
/// &amp;lt;/para&amp;gt;&amp;lt;/listitem&amp;gt;
/// &amp;lt;/itemizedlist&amp;gt;
/// </para>
/// <para>
/// It is possible to handle the script dialog request asynchronously, by simply
/// caling webkit_script_dialog_ref() on the @dialog argument and calling
/// webkit_script_dialog_close() when done.
/// If the last reference is removed on a #WebKitScriptDialog and the dialog has not been
/// closed, webkit_script_dialog_close() will be called.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="dialog">
/// the #WebKitScriptDialog to show
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
///    %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool script_dialog([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitScriptDialogHandle>))] MentorLake.WebKit2.WebKitScriptDialogHandle dialog, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when a notification should be presented to the
/// user. The @notification is kept alive until either: 1) the web page cancels it
/// or 2) a navigation happens.
/// </para>
/// <para>
/// The default handler will emit a notification using libnotify, if built with
/// support for it.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="notification">
/// a #WebKitNotification
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked. %FALSE otherwise.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool show_notification([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitNotificationHandle>))] MentorLake.WebKit2.WebKitNotificationHandle notification, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when a select element in @web_view needs to display a
/// dropdown menu. This signal can be used to show a custom menu, using @menu to get
/// the details of all items that should be displayed. The area of the element in the
/// #WebKitWebView is given as @rectangle parameter, it can be used to position the
/// menu. If this was triggered by a user interaction, like a mouse click,
/// @event parameter provides the #GdkEvent.
/// To handle this signal asynchronously you should keep a ref of the @menu.
/// </para>
/// <para>
/// The @event parameter is now deprecated. Use webkit_option_menu_get_event() to get the
/// #GdkEvent that triggered the dropdown menu.
/// </para>
/// <para>
/// The default signal handler will pop up a #GtkMenu.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="menu">
/// the #WebKitOptionMenu
/// </param>
/// <param name="@event">
/// the #GdkEvent that triggered the menu, or %NULL. Deprecated 2.40
/// </param>
/// <param name="rectangle">
/// the option element area
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
///   %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool show_option_menu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitOptionMenuHandle>))] MentorLake.WebKit2.WebKitOptionMenuHandle menu, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle rectangle, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when a form is about to be submitted. The @request
/// argument passed contains information about the text fields of the form. This
/// is typically used to store login information that can be used later to
/// pre-fill the form.
/// The form will not be submitted until webkit_form_submission_request_submit() is called.
/// </para>
/// <para>
/// It is possible to handle the form submission request asynchronously, by
/// simply calling g_object_ref() on the @request argument and calling
/// webkit_form_submission_request_submit() when done to continue with the form submission.
/// If the last reference is removed on a #WebKitFormSubmissionRequest and the
/// form has not been submitted, webkit_form_submission_request_submit() will be called.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="request">
/// a #WebKitFormSubmissionRequest
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void submit_form([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFormSubmissionRequestHandle>))] MentorLake.WebKit2.WebKitFormSubmissionRequestHandle request, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when a #WebKitUserMessage is received from the
/// #WebKitWebPage corresponding to @web_view. You can reply to the message
/// using webkit_user_message_send_reply().
/// </para>
/// <para>
/// You can handle the user message asynchronously by calling g_object_ref() on
/// @message and returning %TRUE. If the last reference of @message is removed
/// and the message has not been replied to, the operation in the #WebKitWebPage will
/// finish with error %WEBKIT_USER_MESSAGE_UNHANDLED_MESSAGE.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="message">
/// the #WebKitUserMessage received
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE if the message was handled, or %FALSE otherwise.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool user_message_received([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserMessageHandle>))] MentorLake.WebKit2.WebKitUserMessageHandle message, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when the web process crashes.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event.
///    %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool web_process_crashed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when the web process terminates abnormally due
/// to @reason.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="reason">
/// the a #WebKitWebProcessTerminationReason
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void web_process_terminated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle self, MentorLake.WebKit2.WebKitWebProcessTerminationReason reason, IntPtr user_data);

}


public static class WebKitWebViewHandleExtensions
{
/// <summary>
/// <para>
/// Asynchronously call @body with @arguments in the script world with name @world_name of the main frame current context in @web_view.
/// The @arguments values must be one of the following types, or contain only the following GVariant types: number, string and dictionary.
/// The result of the operation can be a Promise that will be properly passed to the callback.
/// If @world_name is %NULL, the default world is used. Any value that is not %NULL is a distin ct world.
/// The @source_uri will be shown in exceptions and doesn&apos;t affect the behavior of the script.
/// When not provided, the document URL is used.
/// </para>
/// <para>
/// Note that if #WebKitSettings:enable-javascript is %FALSE, this method will do nothing.
/// If you want to use this method but still prevent web content from executing its own
/// JavaScript, then use #WebKitSettings:enable-javascript-markup.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called. You can then call
/// webkit_web_view_call_async_javascript_function_finish() to get the result of the operation.
/// </para>
/// <para>
/// This is an example that shows how to pass arguments to a JS function that returns a Promise
/// that resolves with the passed argument:
/// </para>
/// <para>
/// ```c
/// static void
/// web_view_javascript_finished (GObject      *object,
///                               GAsyncResult *result,
///                               gpointer      user_data)
/// {
///     JSCValue               *value;
///     GError                 *error = NULL;
/// </para>
/// <para>
///     value = webkit_web_view_call_async_javascript_function_finish (WEBKIT_WEB_VIEW (object), result, &amp;error);
///     if (!value) {
///         g_warning (&quot;Error running javascript: %s&quot;, error-&amp;gt;message);
///         g_error_free (error);
///         return;
///     }
/// </para>
/// <para>
///     if (jsc_value_is_number (value)) {
///         gint32        int_value = jsc_value_to_string (value);
///         JSCException *exception = jsc_context_get_exception (jsc_value_get_context (value));
///         if (exception)
///             g_warning (&quot;Error running javascript: %s&quot;, jsc_exception_get_message (exception));
///         else
///             g_print (&quot;Script result: %d\n&quot;, int_value);
///         g_free (str_value);
///     } else {
///         g_warning (&quot;Error running javascript: unexpected return value&quot;);
///     }
///     g_object_unref (value);
/// }
/// </para>
/// <para>
/// static void
/// web_view_evaluate_promise (WebKitWebView *web_view)
/// {
///     GVariantDict dict;
///     g_variant_dict_init (&amp;dict, NULL);
///     g_variant_dict_insert (&amp;dict, &quot;count&quot;, &quot;u&quot;, 42);
///     GVariant *args = g_variant_dict_end (&amp;dict);
///     const gchar *body = &quot;return new Promise((resolve) =&amp;gt; { resolve(count); });&quot;;
///     webkit_web_view_call_async_javascript_function (web_view, body, -1, arguments, NULL, NULL, NULL, web_view_javascript_finished, NULL);
/// }
/// ```
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="body">
/// the function body
/// </param>
/// <param name="length">
/// length of @body, or -1 if @body is a nul-terminated string
/// </param>
/// <param name="arguments">
/// a #GVariant with format `a{sv}` storing the function arguments, or %NULL
/// </param>
/// <param name="world_name">
/// the name of a #WebKitScriptWorld or %NULL to use the default
/// </param>
/// <param name="source_uri">
/// the source URI
/// </param>
/// <param name="cancellable">
/// a #GCancellable or %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the script finished
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T CallAsyncJavascriptFunction<T>(this T web_view, string body, UIntPtr length, MentorLake.GLib.GVariantHandle arguments, string world_name, string source_uri, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : WebKitWebViewHandle
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		WebKitWebViewHandleExterns.webkit_web_view_call_async_javascript_function(web_view, body, length, arguments, world_name, source_uri, cancellable, callback, user_data);
		return web_view;
	}

/// <summary>
/// <para>
/// Finish an asynchronous operation started with webkit_web_view_call_async_javascript_function().
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// a #JSCValue with the return value of the async function
///    or %NULL in case of error
/// </return>

	public static MentorLake.JavaScriptCore.JSCValueHandle CallAsyncJavascriptFunctionFinish(this MentorLake.WebKit2.WebKitWebViewHandle web_view, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		var externCallResult = WebKitWebViewHandleExterns.webkit_web_view_call_async_javascript_function_finish(web_view, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously check if it is possible to execute the given editing command.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called. You can then call
/// webkit_web_view_can_execute_editing_command_finish() to get the result of the operation.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="command">
/// the command to check
/// </param>
/// <param name="cancellable">
/// a #GCancellable or %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T CanExecuteEditingCommand<T>(this T web_view, string command, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : WebKitWebViewHandle
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		WebKitWebViewHandleExterns.webkit_web_view_can_execute_editing_command(web_view, command, cancellable, callback, user_data);
		return web_view;
	}

/// <summary>
/// <para>
/// Finish an asynchronous operation started with webkit_web_view_can_execute_editing_command().
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// %TRUE if the editing command can be executed or %FALSE otherwise
/// </return>

	public static bool CanExecuteEditingCommandFinish(this MentorLake.WebKit2.WebKitWebViewHandle web_view, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		var externCallResult = WebKitWebViewHandleExterns.webkit_web_view_can_execute_editing_command_finish(web_view, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Determines whether @web_view has a previous history item.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <return>
/// %TRUE if able to move back or %FALSE otherwise.
/// </return>

	public static bool CanGoBack(this MentorLake.WebKit2.WebKitWebViewHandle web_view)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		return WebKitWebViewHandleExterns.webkit_web_view_can_go_back(web_view);
	}

/// <summary>
/// <para>
/// Determines whether @web_view has a next history item.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <return>
/// %TRUE if able to move forward or %FALSE otherwise.
/// </return>

	public static bool CanGoForward(this MentorLake.WebKit2.WebKitWebViewHandle web_view)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		return WebKitWebViewHandleExterns.webkit_web_view_can_go_forward(web_view);
	}

/// <summary>
/// <para>
/// Whether or not a MIME type can be displayed in @web_view.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="mime_type">
/// a MIME type
/// </param>
/// <return>
/// %TRUE if the MIME type @mime_type can be displayed or %FALSE otherwise
/// </return>

	public static bool CanShowMimeType(this MentorLake.WebKit2.WebKitWebViewHandle web_view, string mime_type)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		return WebKitWebViewHandleExterns.webkit_web_view_can_show_mime_type(web_view, mime_type);
	}

/// <summary>
/// <para>
/// Requests downloading of the specified URI string for @web_view.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="uri">
/// the URI to download
/// </param>
/// <return>
/// a new #WebKitDownload representing
///    the download operation.
/// </return>

	public static MentorLake.WebKit2.WebKitDownloadHandle DownloadUri(this MentorLake.WebKit2.WebKitWebViewHandle web_view, string uri)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		return WebKitWebViewHandleExterns.webkit_web_view_download_uri(web_view, uri);
	}

/// <summary>
/// <para>
/// Asynchronously evaluate @script in the script world with name @world_name of the main frame current context in @web_view.
/// If @world_name is %NULL, the default world is used. Any value that is not %NULL is a distinct world.
/// The @source_uri will be shown in exceptions and doesn&apos;t affect the behavior of the script.
/// When not provided, the document URL is used.
/// </para>
/// <para>
/// Note that if #WebKitSettings:enable-javascript is %FALSE, this method will do nothing.
/// If you want to use this method but still prevent web content from executing its own
/// JavaScript, then use #WebKitSettings:enable-javascript-markup.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called. You can then call
/// webkit_web_view_evaluate_javascript_finish() to get the result of the operation.
/// </para>
/// <para>
/// This is an example of using webkit_web_view_evaluate_javascript() with a script returning
/// a string:
/// </para>
/// <para>
/// ```c
/// static void
/// web_view_javascript_finished (GObject      *object,
///                               GAsyncResult *result,
///                               gpointer      user_data)
/// {
///     JSCValue               *value;
///     GError                 *error = NULL;
/// </para>
/// <para>
///     value = webkit_web_view_evaluate_javascript_finish (WEBKIT_WEB_VIEW (object), result, &amp;error);
///     if (!value) {
///         g_warning (&quot;Error running javascript: %s&quot;, error-&amp;gt;message);
///         g_error_free (error);
///         return;
///     }
/// </para>
/// <para>
///     if (jsc_value_is_string (value)) {
///         gchar        *str_value = jsc_value_to_string (value);
///         JSCException *exception = jsc_context_get_exception (jsc_value_get_context (value));
///         if (exception)
///             g_warning (&quot;Error running javascript: %s&quot;, jsc_exception_get_message (exception));
///         else
///             g_print (&quot;Script result: %s\n&quot;, str_value);
///         g_free (str_value);
///     } else {
///         g_warning (&quot;Error running javascript: unexpected return value&quot;);
///     }
///     g_object_unref (value);
/// }
/// </para>
/// <para>
/// static void
/// web_view_get_link_url (WebKitWebView *web_view,
///                        const gchar   *link_id)
/// {
///     gchar *script = g_strdup_printf (&quot;window.document.getElementById(&apos;%s&apos;).href;&quot;, link_id);
///     webkit_web_view_evaluate_javascript (web_view, script, -1, NULL, NULL, NULL, web_view_javascript_finished, NULL);
///     g_free (script);
/// }
/// ```
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="script">
/// the script to evaluate
/// </param>
/// <param name="length">
/// length of @script, or -1 if @script is a nul-terminated string
/// </param>
/// <param name="world_name">
/// the name of a #WebKitScriptWorld or %NULL to use the default
/// </param>
/// <param name="source_uri">
/// the source URI
/// </param>
/// <param name="cancellable">
/// a #GCancellable or %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the script finished
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T EvaluateJavascript<T>(this T web_view, string script, UIntPtr length, string world_name, string source_uri, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : WebKitWebViewHandle
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		WebKitWebViewHandleExterns.webkit_web_view_evaluate_javascript(web_view, script, length, world_name, source_uri, cancellable, callback, user_data);
		return web_view;
	}

/// <summary>
/// <para>
/// Finish an asynchronous operation started with webkit_web_view_evaluate_javascript().
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// a #JSCValue with the result of the last executed statement in script
///    or %NULL in case of error
/// </return>

	public static MentorLake.JavaScriptCore.JSCValueHandle EvaluateJavascriptFinish(this MentorLake.WebKit2.WebKitWebViewHandle web_view, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		var externCallResult = WebKitWebViewHandleExterns.webkit_web_view_evaluate_javascript_finish(web_view, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Request to execute the given @command for @web_view.
/// </para>
/// <para>
/// You can use webkit_web_view_can_execute_editing_command() to check whether
/// it&apos;s possible to execute the command.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="command">
/// the command to execute
/// </param>

	public static T ExecuteEditingCommand<T>(this T web_view, string command) where T : WebKitWebViewHandle
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		WebKitWebViewHandleExterns.webkit_web_view_execute_editing_command(web_view, command);
		return web_view;
	}

/// <summary>
/// <para>
/// Request to execute the given @command with @argument for @web_view.
/// </para>
/// <para>
/// You can use
/// webkit_web_view_can_execute_editing_command() to check whether
/// it&apos;s possible to execute the command.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="command">
/// the command to execute
/// </param>
/// <param name="argument">
/// the command argument
/// </param>

	public static T ExecuteEditingCommandWithArgument<T>(this T web_view, string command, string argument) where T : WebKitWebViewHandle
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		WebKitWebViewHandleExterns.webkit_web_view_execute_editing_command_with_argument(web_view, command, argument);
		return web_view;
	}

/// <summary>
/// <para>
/// Get the presentation type of #WebKitWebView when created for automation.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <return>
/// a #WebKitAutomationBrowsingContextPresentation.
/// </return>

	public static MentorLake.WebKit2.WebKitAutomationBrowsingContextPresentation GetAutomationPresentationType(this MentorLake.WebKit2.WebKitWebViewHandle web_view)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		return WebKitWebViewHandleExterns.webkit_web_view_get_automation_presentation_type(web_view);
	}

/// <summary>
/// <para>
/// Obtains the #WebKitBackForwardList associated with the given #WebKitWebView.
/// </para>
/// <para>
/// The #WebKitBackForwardList is owned by the #WebKitWebView.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <return>
/// the #WebKitBackForwardList
/// </return>

	public static MentorLake.WebKit2.WebKitBackForwardListHandle GetBackForwardList(this MentorLake.WebKit2.WebKitWebViewHandle web_view)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		return WebKitWebViewHandleExterns.webkit_web_view_get_back_forward_list(web_view);
	}

/// <summary>
/// <para>
/// Gets the color that is used to draw the @web_view background.
/// </para>
/// <para>
/// Gets the color that is used to draw the @web_view background before
/// the actual contents are rendered.
/// For more information see also webkit_web_view_set_background_color()
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="rgba">
/// a #GdkRGBA to fill in with the background color
/// </param>

	public static T GetBackgroundColor<T>(this T web_view, out MentorLake.Gdk.GdkRGBA rgba) where T : WebKitWebViewHandle
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		WebKitWebViewHandleExterns.webkit_web_view_get_background_color(web_view, out rgba);
		return web_view;
	}

/// <summary>
/// <para>
/// Get the camera capture state of a #WebKitWebView.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <return>
/// The #WebKitMediaCaptureState of the camera device. If #WebKitSettings:enable-mediastream
/// is %FALSE, this method will return %WEBKIT_MEDIA_CAPTURE_STATE_NONE.
/// </return>

	public static MentorLake.WebKit2.WebKitMediaCaptureState GetCameraCaptureState(this MentorLake.WebKit2.WebKitWebViewHandle web_view)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		return WebKitWebViewHandleExterns.webkit_web_view_get_camera_capture_state(web_view);
	}

/// <summary>
/// <para>
/// Gets the web context of @web_view.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <return>
/// the #WebKitWebContext of the view
/// </return>

	public static MentorLake.WebKit2.WebKitWebContextHandle GetContext(this MentorLake.WebKit2.WebKitWebViewHandle web_view)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		return WebKitWebViewHandleExterns.webkit_web_view_get_context(web_view);
	}

/// <summary>
/// <para>
/// Returns the current custom character encoding name of @web_view.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <return>
/// the current custom character encoding name or %NULL if no
///    custom character encoding has been set.
/// </return>

	public static string GetCustomCharset(this MentorLake.WebKit2.WebKitWebViewHandle web_view)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		return WebKitWebViewHandleExterns.webkit_web_view_get_custom_charset(web_view);
	}

/// <summary>
/// <para>
/// Gets the configured default Content-Security-Policy.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <return>
/// The default policy or %NULL
/// </return>

	public static string GetDefaultContentSecurityPolicy(this MentorLake.WebKit2.WebKitWebViewHandle web_view)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		return WebKitWebViewHandleExterns.webkit_web_view_get_default_content_security_policy(web_view);
	}

/// <summary>
/// <para>
/// Get the display capture state of a #WebKitWebView.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <return>
/// The #WebKitMediaCaptureState of the display device. If #WebKitSettings:enable-mediastream
/// is %FALSE, this method will return %WEBKIT_MEDIA_CAPTURE_STATE_NONE.
/// </return>

	public static MentorLake.WebKit2.WebKitMediaCaptureState GetDisplayCaptureState(this MentorLake.WebKit2.WebKitWebViewHandle web_view)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		return WebKitWebViewHandleExterns.webkit_web_view_get_display_capture_state(web_view);
	}

/// <summary>
/// <para>
/// Gets the web editor state of @web_view.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <return>
/// the #WebKitEditorState of the view
/// </return>

	public static MentorLake.WebKit2.WebKitEditorStateHandle GetEditorState(this MentorLake.WebKit2.WebKitWebViewHandle web_view)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		return WebKitWebViewHandleExterns.webkit_web_view_get_editor_state(web_view);
	}

/// <summary>
/// <para>
/// Gets the value of the #WebKitWebView:estimated-load-progress property.
/// </para>
/// <para>
/// You can monitor the estimated progress of a load operation by
/// connecting to the notify::estimated-load-progress signal of @web_view.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <return>
/// an estimate of the of the percent complete for a document
///     load as a range from 0.0 to 1.0.
/// </return>

	public static double GetEstimatedLoadProgress(this MentorLake.WebKit2.WebKitWebViewHandle web_view)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		return WebKitWebViewHandleExterns.webkit_web_view_get_estimated_load_progress(web_view);
	}

/// <summary>
/// <para>
/// Returns favicon currently associated to @web_view.
/// </para>
/// <para>
/// Returns favicon currently associated to @web_view, if any. You can
/// connect to notify::favicon signal of @web_view to be notified when
/// the favicon is available.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <return>
/// the favicon image or %NULL if there&apos;s no
///    icon associated with @web_view.
/// </return>

	public static MentorLake.cairo.cairo_surface_tHandle GetFavicon(this MentorLake.WebKit2.WebKitWebViewHandle web_view)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		return WebKitWebViewHandleExterns.webkit_web_view_get_favicon(web_view);
	}

/// <summary>
/// <para>
/// Gets the #WebKitFindController.
/// </para>
/// <para>
/// Gets the #WebKitFindController that will allow the caller to query
/// the #WebKitWebView for the text to look for.
/// </para>
/// </summary>

/// <param name="web_view">
/// the #WebKitWebView
/// </param>
/// <return>
/// the #WebKitFindController associated to
/// this particular #WebKitWebView.
/// </return>

	public static MentorLake.WebKit2.WebKitFindControllerHandle GetFindController(this MentorLake.WebKit2.WebKitWebViewHandle web_view)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		return WebKitWebViewHandleExterns.webkit_web_view_get_find_controller(web_view);
	}

/// <summary>
/// <para>
/// Get the #WebKitInputMethodContext currently in use by @web_view.
/// </para>
/// <para>
/// Get the #WebKitInputMethodContext currently in use by @web_view, or %NULL if no input method is being used.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <return>
/// a #WebKitInputMethodContext, or %NULL
/// </return>

	public static MentorLake.WebKit2.WebKitInputMethodContextHandle GetInputMethodContext(this MentorLake.WebKit2.WebKitWebViewHandle web_view)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		return WebKitWebViewHandleExterns.webkit_web_view_get_input_method_context(web_view);
	}

/// <summary>
/// <para>
/// Get the #WebKitWebInspector associated to @web_view
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <return>
/// the #WebKitWebInspector of @web_view
/// </return>

	public static MentorLake.WebKit2.WebKitWebInspectorHandle GetInspector(this MentorLake.WebKit2.WebKitWebViewHandle web_view)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		return WebKitWebViewHandleExterns.webkit_web_view_get_inspector(web_view);
	}

/// <summary>
/// <para>
/// Gets the mute state of @web_view.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <return>
/// %TRUE if @web_view audio is muted or %FALSE is audio is not muted.
/// </return>

	public static bool GetIsMuted(this MentorLake.WebKit2.WebKitWebViewHandle web_view)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		return WebKitWebViewHandleExterns.webkit_web_view_get_is_muted(web_view);
	}

/// <summary>
/// <para>
/// Get whether the current web process of a #WebKitWebView is responsive.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <return>
/// %TRUE if the web process attached to @web_view is responsive, or %FALSE otherwise.
/// </return>

	public static bool GetIsWebProcessResponsive(this MentorLake.WebKit2.WebKitWebViewHandle web_view)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		return WebKitWebViewHandleExterns.webkit_web_view_get_is_web_process_responsive(web_view);
	}

/// <summary>
/// <para>
/// Get the global JavaScript context.
/// </para>
/// <para>
/// Get the global JavaScript context used by @web_view to deserialize the
/// result values of scripts executed with webkit_web_view_run_javascript().
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <return>
/// the JSGlobalContextRef used by @web_view to deserialize
///    the result values of scripts.
/// </return>

	public static MentorLake.WebKit2.JSGlobalContextRef GetJavascriptGlobalContext(this MentorLake.WebKit2.WebKitWebViewHandle web_view)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		return WebKitWebViewHandleExterns.webkit_web_view_get_javascript_global_context(web_view);
	}

/// <summary>
/// <para>
/// Return the main resource of @web_view.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <return>
/// the main #WebKitWebResource of the view
///    or %NULL if nothing has been loaded.
/// </return>

	public static MentorLake.WebKit2.WebKitWebResourceHandle GetMainResource(this MentorLake.WebKit2.WebKitWebViewHandle web_view)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		return WebKitWebViewHandleExterns.webkit_web_view_get_main_resource(web_view);
	}

/// <summary>
/// <para>
/// Get the microphone capture state of a #WebKitWebView.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <return>
/// The #WebKitMediaCaptureState of the microphone device. If #WebKitSettings:enable-mediastream
/// is %FALSE, this method will return %WEBKIT_MEDIA_CAPTURE_STATE_NONE.
/// </return>

	public static MentorLake.WebKit2.WebKitMediaCaptureState GetMicrophoneCaptureState(this MentorLake.WebKit2.WebKitWebViewHandle web_view)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		return WebKitWebViewHandleExterns.webkit_web_view_get_microphone_capture_state(web_view);
	}

/// <summary>
/// <para>
/// Get the identifier of the #WebKitWebPage corresponding to
/// the #WebKitWebView
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <return>
/// the page ID of @web_view.
/// </return>

	public static ulong GetPageId(this MentorLake.WebKit2.WebKitWebViewHandle web_view)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		return WebKitWebViewHandleExterns.webkit_web_view_get_page_id(web_view);
	}

/// <summary>
/// <para>
/// Gets the current session state of @web_view
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <return>
/// a #WebKitWebViewSessionState
/// </return>

	public static MentorLake.WebKit2.WebKitWebViewSessionStateHandle GetSessionState(this MentorLake.WebKit2.WebKitWebViewHandle web_view)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		return WebKitWebViewHandleExterns.webkit_web_view_get_session_state(web_view);
	}

/// <summary>
/// <para>
/// Gets the #WebKitSettings currently applied to @web_view.
/// </para>
/// <para>
/// If no other #WebKitSettings have been explicitly applied to
/// @web_view with webkit_web_view_set_settings(), the default
/// #WebKitSettings will be returned. This method always returns
/// a valid #WebKitSettings object.
/// To modify any of the @web_view settings, you can either create
/// a new #WebKitSettings object with webkit_settings_new(), setting
/// the desired preferences, and then replace the existing @web_view
/// settings with webkit_web_view_set_settings() or get the existing
/// @web_view settings and update it directly. #WebKitSettings objects
/// can be shared by multiple #WebKitWebView&amp;lt;!-- --&amp;gt;s, so modifying
/// the settings of a #WebKitWebView would affect other
/// #WebKitWebView&amp;lt;!-- --&amp;gt;s using the same #WebKitSettings.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <return>
/// the #WebKitSettings attached to @web_view
/// </return>

	public static MentorLake.WebKit2.WebKitSettingsHandle GetSettings(this MentorLake.WebKit2.WebKitWebViewHandle web_view)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		return WebKitWebViewHandleExterns.webkit_web_view_get_settings(web_view);
	}

/// <summary>
/// <para>
/// Asynchronously retrieves a snapshot of @web_view for @region.
/// </para>
/// <para>
/// @options specifies how the snapshot should be rendered.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called. You must
/// call webkit_web_view_get_snapshot_finish() to get the result of the
/// operation.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="region">
/// the #WebKitSnapshotRegion for this snapshot
/// </param>
/// <param name="options">
/// #WebKitSnapshotOptions for the snapshot
/// </param>
/// <param name="cancellable">
/// a #GCancellable
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback
/// </param>
/// <param name="user_data">
/// user data
/// </param>

	public static T GetSnapshot<T>(this T web_view, MentorLake.WebKit2.WebKitSnapshotRegion region, MentorLake.WebKit2.WebKitSnapshotOptions options, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : WebKitWebViewHandle
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		WebKitWebViewHandleExterns.webkit_web_view_get_snapshot(web_view, region, options, cancellable, callback, user_data);
		return web_view;
	}

/// <summary>
/// <para>
/// Finishes an asynchronous operation started with webkit_web_view_get_snapshot(), producing
/// an image of the snapshot using the BGRA8888 pixel format.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// an image with the retrieved snapshot, or %NULL in case of error.
/// </return>

	public static MentorLake.cairo.cairo_surface_tHandle GetSnapshotFinish(this MentorLake.WebKit2.WebKitWebViewHandle web_view, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		var externCallResult = WebKitWebViewHandleExterns.webkit_web_view_get_snapshot_finish(web_view, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets the theme color that is specified by the content in the @web_view.
/// If the @web_view doesn&apos;t have a theme color it will fill the @rgba
/// with transparent black content.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="rgba">
/// a #GdkRGBA to fill in with the theme color
/// </param>
/// <return>
/// Whether the currently loaded page defines a theme color.
/// </return>

	public static bool GetThemeColor(this MentorLake.WebKit2.WebKitWebViewHandle web_view, out MentorLake.Gdk.GdkRGBA rgba)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		return WebKitWebViewHandleExterns.webkit_web_view_get_theme_color(web_view, out rgba);
	}

/// <summary>
/// <para>
/// Gets the value of the #WebKitWebView:title property.
/// </para>
/// <para>
/// You can connect to notify::title signal of @web_view to
/// be notified when the title has been received.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <return>
/// The main frame document title of @web_view.
/// </return>

	public static string GetTitle(this MentorLake.WebKit2.WebKitWebViewHandle web_view)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		return WebKitWebViewHandleExterns.webkit_web_view_get_title(web_view);
	}

/// <summary>
/// <para>
/// Retrieves the #GTlsCertificate associated with the main resource of @web_view.
/// </para>
/// <para>
/// Retrieves the #GTlsCertificate associated with the main resource of @web_view,
/// and the #GTlsCertificateFlags showing what problems, if any, have been found
/// with that certificate.
/// If the connection is not HTTPS, this function returns %FALSE.
/// This function should be called after a response has been received from the
/// server, so you can connect to #WebKitWebView::load-changed and call this function
/// when it&apos;s emitted with %WEBKIT_LOAD_COMMITTED event.
/// </para>
/// <para>
/// Note that this function provides no information about the security of the web
/// page if the current #WebKitTLSErrorsPolicy is %WEBKIT_TLS_ERRORS_POLICY_IGNORE,
/// as subresources of the page may be controlled by an attacker. This function
/// may safely be used to determine the security status of the current page only
/// if the current #WebKitTLSErrorsPolicy is %WEBKIT_TLS_ERRORS_POLICY_FAIL, in
/// which case subresources that fail certificate verification will be blocked.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="certificate">
/// return location for a #GTlsCertificate
/// </param>
/// <param name="errors">
/// return location for a #GTlsCertificateFlags the verification status of @certificate
/// </param>
/// <return>
/// %TRUE if the @web_view connection uses HTTPS and a response has been received
///    from the server, or %FALSE otherwise.
/// </return>

	public static bool GetTlsInfo(this MentorLake.WebKit2.WebKitWebViewHandle web_view, out MentorLake.Gio.GTlsCertificateHandle certificate, out MentorLake.Gio.GTlsCertificateFlags errors)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		return WebKitWebViewHandleExterns.webkit_web_view_get_tls_info(web_view, out certificate, out errors);
	}

/// <summary>
/// <para>
/// Returns the current active URI of @web_view.
/// </para>
/// <para>
/// The active URI might change during
/// a load operation:
/// </para>
/// <para>
/// &amp;lt;orderedlist&amp;gt;
/// &amp;lt;listitem&amp;gt;&amp;lt;para&amp;gt;
///   When nothing has been loaded yet on @web_view the active URI is %NULL.
/// &amp;lt;/para&amp;gt;&amp;lt;/listitem&amp;gt;
/// &amp;lt;listitem&amp;gt;&amp;lt;para&amp;gt;
///   When a new load operation starts the active URI is the requested URI:
///   &amp;lt;itemizedlist&amp;gt;
///   &amp;lt;listitem&amp;gt;&amp;lt;para&amp;gt;
///     If the load operation was started by webkit_web_view_load_uri(),
///     the requested URI is the given one.
///   &amp;lt;/para&amp;gt;&amp;lt;/listitem&amp;gt;
///   &amp;lt;listitem&amp;gt;&amp;lt;para&amp;gt;
///     If the load operation was started by webkit_web_view_load_html(),
///     the requested URI is &quot;about:blank&quot;.
///   &amp;lt;/para&amp;gt;&amp;lt;/listitem&amp;gt;
///   &amp;lt;listitem&amp;gt;&amp;lt;para&amp;gt;
///     If the load operation was started by webkit_web_view_load_alternate_html(),
///     the requested URI is content URI provided.
///   &amp;lt;/para&amp;gt;&amp;lt;/listitem&amp;gt;
///   &amp;lt;listitem&amp;gt;&amp;lt;para&amp;gt;
///     If the load operation was started by webkit_web_view_go_back() or
///     webkit_web_view_go_forward(), the requested URI is the original URI
///     of the previous/next item in the #WebKitBackForwardList of @web_view.
///   &amp;lt;/para&amp;gt;&amp;lt;/listitem&amp;gt;
///   &amp;lt;listitem&amp;gt;&amp;lt;para&amp;gt;
///     If the load operation was started by
///     webkit_web_view_go_to_back_forward_list_item(), the requested URI
///     is the opriginal URI of the given #WebKitBackForwardListItem.
///   &amp;lt;/para&amp;gt;&amp;lt;/listitem&amp;gt;
///   &amp;lt;/itemizedlist&amp;gt;
/// &amp;lt;/para&amp;gt;&amp;lt;/listitem&amp;gt;
/// &amp;lt;listitem&amp;gt;&amp;lt;para&amp;gt;
///   If there is a server redirection during the load operation,
///   the active URI is the redirected URI. When the signal
///   #WebKitWebView::load-changed is emitted with %WEBKIT_LOAD_REDIRECTED
///   event, the active URI is already updated to the redirected URI.
/// &amp;lt;/para&amp;gt;&amp;lt;/listitem&amp;gt;
/// &amp;lt;listitem&amp;gt;&amp;lt;para&amp;gt;
///   When the signal #WebKitWebView::load-changed is emitted
///   with %WEBKIT_LOAD_COMMITTED event, the active URI is the final
///   one and it will not change unless a new load operation is started
///   or a navigation action within the same page is performed.
/// &amp;lt;/para&amp;gt;&amp;lt;/listitem&amp;gt;
/// &amp;lt;/orderedlist&amp;gt;
/// </para>
/// <para>
/// You can monitor the active URI by connecting to the notify::uri
/// signal of @web_view.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <return>
/// the current active URI of @web_view or %NULL
///    if nothing has been loaded yet.
/// </return>

	public static string GetUri(this MentorLake.WebKit2.WebKitWebViewHandle web_view)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		return WebKitWebViewHandleExterns.webkit_web_view_get_uri(web_view);
	}

/// <summary>
/// <para>
/// Gets the user content manager associated to @web_view.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <return>
/// the #WebKitUserContentManager associated with the view
/// </return>

	public static MentorLake.WebKit2.WebKitUserContentManagerHandle GetUserContentManager(this MentorLake.WebKit2.WebKitWebViewHandle web_view)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		return WebKitWebViewHandleExterns.webkit_web_view_get_user_content_manager(web_view);
	}

/// <summary>
/// <para>
/// Get the view&apos;s #WebKitWebExtensionMode.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <return>
/// the #WebKitWebExtensionMode
/// </return>

	public static MentorLake.WebKit2.WebKitWebExtensionMode GetWebExtensionMode(this MentorLake.WebKit2.WebKitWebViewHandle web_view)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		return WebKitWebViewHandleExterns.webkit_web_view_get_web_extension_mode(web_view);
	}

/// <summary>
/// <para>
/// Get the #WebKitWebsiteDataManager associated to @web_view.
/// </para>
/// <para>
/// If @web_view is not ephemeral,
/// the returned #WebKitWebsiteDataManager will be the same as the #WebKitWebsiteDataManager
/// of @web_view&apos;s #WebKitWebContext.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <return>
/// a #WebKitWebsiteDataManager
/// </return>

	public static MentorLake.WebKit2.WebKitWebsiteDataManagerHandle GetWebsiteDataManager(this MentorLake.WebKit2.WebKitWebViewHandle web_view)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		return WebKitWebViewHandleExterns.webkit_web_view_get_website_data_manager(web_view);
	}

/// <summary>
/// <para>
/// Gets the default website policies.
/// </para>
/// <para>
/// Gets the default website policies set on construction in the
/// @web_view. These can be overridden on a per-origin basis via the
/// #WebKitWebView::decide-policy signal handler.
/// </para>
/// <para>
/// See also webkit_policy_decision_use_with_policies().
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <return>
/// the default #WebKitWebsitePolicies
///     associated with the view.
/// </return>

	public static MentorLake.WebKit2.WebKitWebsitePoliciesHandle GetWebsitePolicies(this MentorLake.WebKit2.WebKitWebViewHandle web_view)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		return WebKitWebViewHandleExterns.webkit_web_view_get_website_policies(web_view);
	}

/// <summary>
/// <para>
/// Get the #WebKitWindowProperties object.
/// </para>
/// <para>
/// Get the #WebKitWindowProperties object containing the properties
/// that the window containing @web_view should have.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <return>
/// the #WebKitWindowProperties of @web_view
/// </return>

	public static MentorLake.WebKit2.WebKitWindowPropertiesHandle GetWindowProperties(this MentorLake.WebKit2.WebKitWebViewHandle web_view)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		return WebKitWebViewHandleExterns.webkit_web_view_get_window_properties(web_view);
	}

/// <summary>
/// <para>
/// Set the zoom level of @web_view.
/// </para>
/// <para>
/// Get the zoom level of @web_view, i.e. the factor by which the
/// view contents are scaled with respect to their original size.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <return>
/// the current zoom level of @web_view
/// </return>

	public static double GetZoomLevel(this MentorLake.WebKit2.WebKitWebViewHandle web_view)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		return WebKitWebViewHandleExterns.webkit_web_view_get_zoom_level(web_view);
	}

/// <summary>
/// <para>
/// Loads the previous history item.
/// </para>
/// <para>
/// You can monitor the load operation by connecting to
/// #WebKitWebView::load-changed signal.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>

	public static T GoBack<T>(this T web_view) where T : WebKitWebViewHandle
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		WebKitWebViewHandleExterns.webkit_web_view_go_back(web_view);
		return web_view;
	}

/// <summary>
/// <para>
/// Loads the next history item.
/// </para>
/// <para>
/// You can monitor the load operation by connecting to
/// #WebKitWebView::load-changed signal.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>

	public static T GoForward<T>(this T web_view) where T : WebKitWebViewHandle
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		WebKitWebViewHandleExterns.webkit_web_view_go_forward(web_view);
		return web_view;
	}

/// <summary>
/// <para>
/// Loads the specific history item @list_item.
/// </para>
/// <para>
/// You can monitor the load operation by connecting to
/// #WebKitWebView::load-changed signal.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="list_item">
/// a #WebKitBackForwardListItem
/// </param>

	public static T GoToBackForwardListItem<T>(this T web_view, MentorLake.WebKit2.WebKitBackForwardListItemHandle list_item) where T : WebKitWebViewHandle
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		WebKitWebViewHandleExterns.webkit_web_view_go_to_back_forward_list_item(web_view, list_item);
		return web_view;
	}

/// <summary>
/// <para>
/// Get whether a #WebKitWebView was created with #WebKitWebView:is-controlled-by-automation
/// property enabled.
/// </para>
/// <para>
/// Only #WebKitWebView&amp;lt;!-- --&amp;gt;s controlled by automation can be used in an
/// automation session.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <return>
/// %TRUE if @web_view is controlled by automation, or %FALSE otherwise.
/// </return>

	public static bool IsControlledByAutomation(this MentorLake.WebKit2.WebKitWebViewHandle web_view)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		return WebKitWebViewHandleExterns.webkit_web_view_is_controlled_by_automation(web_view);
	}

/// <summary>
/// <para>
/// Gets whether the user is allowed to edit the HTML document.
/// </para>
/// <para>
/// When @web_view is not editable an element in the HTML document can only be edited if the
/// CONTENTEDITABLE attribute has been set on the element or one of its parent
/// elements. By default a #WebKitWebView is not editable.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <return>
/// %TRUE if the user is allowed to edit the HTML document, or %FALSE otherwise.
/// </return>

	public static bool IsEditable(this MentorLake.WebKit2.WebKitWebViewHandle web_view)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		return WebKitWebViewHandleExterns.webkit_web_view_is_editable(web_view);
	}

/// <summary>
/// <para>
/// Get whether a #WebKitWebView is ephemeral.
/// </para>
/// <para>
/// To create an ephemeral #WebKitWebView you need to
/// use g_object_new() and pass is-ephemeral property with %TRUE value. See
/// #WebKitWebView:is-ephemeral for more details.
/// If @web_view was created with a ephemeral #WebKitWebView:related-view or an
/// ephemeral #WebKitWebView:web-context it will also be ephemeral.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <return>
/// %TRUE if @web_view is ephemeral or %FALSE otherwise.
/// </return>

	public static bool IsEphemeral(this MentorLake.WebKit2.WebKitWebViewHandle web_view)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		return WebKitWebViewHandleExterns.webkit_web_view_is_ephemeral(web_view);
	}

/// <summary>
/// <para>
/// Gets whether @web_view is in immersive mode.
/// </para>
/// <para>
/// An immersive session is a mode in which the user is presented with a fully immersive XR experience
/// (such as VR or AR), typically rendered via a headset.
/// </para>
/// <para>
/// Note that if WebXR is disabled or OPENXR is not used, this API always returns %FALSE.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <return>
/// %TRUE if the @web_view is in immersive mode, or %FALSE otherwise.
/// </return>

	public static bool IsImmersiveModeEnabled(this MentorLake.WebKit2.WebKitWebViewHandle web_view)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		return WebKitWebViewHandleExterns.webkit_web_view_is_immersive_mode_enabled(web_view);
	}

/// <summary>
/// <para>
/// Gets the value of the #WebKitWebView:is-loading property.
/// </para>
/// <para>
/// You can monitor when a #WebKitWebView is loading a page by connecting to
/// notify::is-loading signal of @web_view. This is useful when you are
/// interesting in knowing when the view is loading something but not in the
/// details about the status of the load operation, for example to start a spinner
/// when the view is loading a page and stop it when it finishes.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <return>
/// %TRUE if @web_view is loading a page or %FALSE otherwise.
/// </return>

	public static bool IsLoading(this MentorLake.WebKit2.WebKitWebViewHandle web_view)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		return WebKitWebViewHandleExterns.webkit_web_view_is_loading(web_view);
	}

/// <summary>
/// <para>
/// Gets the value of the #WebKitWebView:is-playing-audio property.
/// </para>
/// <para>
/// You can monitor when a page in a #WebKitWebView is playing audio by
/// connecting to the notify::is-playing-audio signal of @web_view. This
/// is useful when the application wants to provide visual feedback when a
/// page is producing sound.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <return>
/// %TRUE if a page in @web_view is playing audio or %FALSE otherwise.
/// </return>

	public static bool IsPlayingAudio(this MentorLake.WebKit2.WebKitWebViewHandle web_view)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		return WebKitWebViewHandleExterns.webkit_web_view_is_playing_audio(web_view);
	}

/// <summary>
/// <para>
/// Requests to leave the immersive mode this #WebKitWebView is in.
/// </para>
/// <para>
/// Users interact with web content to start XR sessions, and can typically
/// end the sessions themselves, but applications might need to end a session on their
/// own based on application or platform logic.
/// </para>
/// <para>
/// Note that if WebXR is disabled, or if it is enabled but the @web_view is not in
/// immersive mode, this API does nothing. See also webkit_web_view_is_immersive_mode_enabled().
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>

	public static T LeaveImmersiveMode<T>(this T web_view) where T : WebKitWebViewHandle
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		WebKitWebViewHandleExterns.webkit_web_view_leave_immersive_mode(web_view);
		return web_view;
	}

/// <summary>
/// <para>
/// Load the given @content string for the URI @content_uri.
/// </para>
/// <para>
/// This allows clients to display page-loading errors in the #WebKitWebView itself.
/// When this method is called from #WebKitWebView::load-failed signal to show an
/// error page, then the back-forward list is maintained appropriately.
/// For everything else this method works the same way as webkit_web_view_load_html().
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="content">
/// the new content to display as the main page of the @web_view
/// </param>
/// <param name="content_uri">
/// the URI for the alternate page content
/// </param>
/// <param name="base_uri">
/// the base URI for relative locations or %NULL
/// </param>

	public static T LoadAlternateHtml<T>(this T web_view, string content, string content_uri, string base_uri) where T : WebKitWebViewHandle
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		WebKitWebViewHandleExterns.webkit_web_view_load_alternate_html(web_view, content, content_uri, base_uri);
		return web_view;
	}

/// <summary>
/// <para>
/// Load the specified @bytes into @web_view using the given @mime_type and @encoding.
/// </para>
/// <para>
/// When @mime_type is %NULL, it defaults to &quot;text/html&quot;.
/// When @encoding is %NULL, it defaults to &quot;UTF-8&quot;.
/// When @base_uri is %NULL, it defaults to &quot;about:blank&quot;.
/// You can monitor the load operation by connecting to #WebKitWebView::load-changed signal.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="bytes">
/// input data to load
/// </param>
/// <param name="mime_type">
/// the MIME type of @bytes, or %NULL
/// </param>
/// <param name="encoding">
/// the character encoding of @bytes, or %NULL
/// </param>
/// <param name="base_uri">
/// the base URI for relative locations or %NULL
/// </param>

	public static T LoadBytes<T>(this T web_view, MentorLake.GLib.GBytesHandle bytes, string mime_type, string encoding, string base_uri) where T : WebKitWebViewHandle
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		WebKitWebViewHandleExterns.webkit_web_view_load_bytes(web_view, bytes, mime_type, encoding, base_uri);
		return web_view;
	}

/// <summary>
/// <para>
/// Load the given @content string with the specified @base_uri.
/// </para>
/// <para>
/// If @base_uri is not %NULL, relative URLs in the @content will be
/// resolved against @base_uri and absolute local paths must be children of the @base_uri.
/// For security reasons absolute local paths that are not children of @base_uri
/// will cause the web process to terminate.
/// If you need to include URLs in @content that are local paths in a different
/// directory than @base_uri you can build a data URI for them. When @base_uri is %NULL,
/// it defaults to &quot;about:blank&quot;. The mime type of the document will be &quot;text/html&quot;.
/// You can monitor the load operation by connecting to #WebKitWebView::load-changed signal.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="content">
/// The HTML string to load
/// </param>
/// <param name="base_uri">
/// The base URI for relative locations or %NULL
/// </param>

	public static T LoadHtml<T>(this T web_view, string content, string base_uri) where T : WebKitWebViewHandle
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		WebKitWebViewHandleExterns.webkit_web_view_load_html(web_view, content, base_uri);
		return web_view;
	}

/// <summary>
/// <para>
/// Load the specified @plain_text string into @web_view.
/// </para>
/// <para>
/// The mime type of document will be &quot;text/plain&quot;. You can monitor the load
/// operation by connecting to #WebKitWebView::load-changed signal.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="plain_text">
/// The plain text to load
/// </param>

	public static T LoadPlainText<T>(this T web_view, string plain_text) where T : WebKitWebViewHandle
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		WebKitWebViewHandleExterns.webkit_web_view_load_plain_text(web_view, plain_text);
		return web_view;
	}

/// <summary>
/// <para>
/// Requests loading of the specified #WebKitURIRequest.
/// </para>
/// <para>
/// You can monitor the load operation by connecting to
/// #WebKitWebView::load-changed signal.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="request">
/// a #WebKitURIRequest to load
/// </param>

	public static T LoadRequest<T>(this T web_view, MentorLake.WebKit2.WebKitURIRequestHandle request) where T : WebKitWebViewHandle
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		WebKitWebViewHandleExterns.webkit_web_view_load_request(web_view, request);
		return web_view;
	}

/// <summary>
/// <para>
/// Requests loading of the specified URI string.
/// </para>
/// <para>
/// You can monitor the load operation by connecting to
/// #WebKitWebView::load-changed signal.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="uri">
/// an URI string
/// </param>

	public static T LoadUri<T>(this T web_view, string uri) where T : WebKitWebViewHandle
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		WebKitWebViewHandleExterns.webkit_web_view_load_uri(web_view, uri);
		return web_view;
	}

/// <summary>
/// <para>
/// Reloads the current contents of @web_view.
/// </para>
/// <para>
/// See also webkit_web_view_reload_bypass_cache().
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>

	public static T Reload<T>(this T web_view) where T : WebKitWebViewHandle
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		WebKitWebViewHandleExterns.webkit_web_view_reload(web_view);
		return web_view;
	}

/// <summary>
/// <para>
/// Reloads the current contents of @web_view without
/// using any cached data.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>

	public static T ReloadBypassCache<T>(this T web_view) where T : WebKitWebViewHandle
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		WebKitWebViewHandleExterns.webkit_web_view_reload_bypass_cache(web_view);
		return web_view;
	}

/// <summary>
/// <para>
/// Restore the @web_view session state from @state
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="state">
/// a #WebKitWebViewSessionState
/// </param>

	public static T RestoreSessionState<T>(this T web_view, MentorLake.WebKit2.WebKitWebViewSessionStateHandle state) where T : WebKitWebViewHandle
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		WebKitWebViewHandleExterns.webkit_web_view_restore_session_state(web_view, state);
		return web_view;
	}

/// <summary>
/// <para>
/// Asynchronously run @body in the script world with name @world_name of the current page context in
/// @web_view. If WebKitSettings:enable-javascript is FALSE, this method will do nothing. This API
/// differs from webkit_web_view_run_javascript_in_world() in that the JavaScript function can return a
/// Promise and its result will be properly passed to the callback.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called. You can then call
/// webkit_web_view_run_javascript_in_world_finish() to get the result of the operation.
/// </para>
/// <para>
/// For instance here is a dummy example that shows how to pass arguments to a JS function that
/// returns a Promise that resolves with the passed argument:
/// </para>
/// <para>
/// ```c
/// static void
/// web_view_javascript_finished (GObject      *object,
///                               GAsyncResult *result,
///                               gpointer      user_data)
/// {
///     WebKitJavascriptResult *js_result;
///     JSCValue               *value;
///     GError                 *error = NULL;
/// </para>
/// <para>
///     js_result = webkit_web_view_run_javascript_finish (WEBKIT_WEB_VIEW (object), result, &amp;error);
///     if (!js_result) {
///         g_warning (&quot;Error running javascript: %s&quot;, error-&amp;gt;message);
///         g_error_free (error);
///         return;
///     }
/// </para>
/// <para>
///     value = webkit_javascript_result_get_js_value (js_result);
///     if (jsc_value_is_number (value)) {
///         gint32        int_value = jsc_value_to_string (value);
///         JSCException *exception = jsc_context_get_exception (jsc_value_get_context (value));
///         if (exception)
///             g_warning (&quot;Error running javascript: %s&quot;, jsc_exception_get_message (exception));
///         else
///             g_print (&quot;Script result: %d\n&quot;, int_value);
///         g_free (str_value);
///     } else {
///         g_warning (&quot;Error running javascript: unexpected return value&quot;);
///     }
///     webkit_javascript_result_unref (js_result);
/// }
/// </para>
/// <para>
/// static void
/// web_view_evaluate_promise (WebKitWebView *web_view)
/// {
///     GVariantDict dict;
///     g_variant_dict_init (&amp;dict, NULL);
///     g_variant_dict_insert (&amp;dict, &quot;count&quot;, &quot;u&quot;, 42);
///     GVariant *args = g_variant_dict_end (&amp;dict);
///     const gchar *body = &quot;return new Promise((resolve) =&amp;gt; { resolve(count); });&quot;;
///     webkit_web_view_run_async_javascript_function_in_world (web_view, body, arguments, NULL, NULL, web_view_javascript_finished, NULL);
/// }
/// ```
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="body">
/// the JavaScript function body
/// </param>
/// <param name="arguments">
/// a #GVariant with format `{&amp;sv}` storing the function arguments. Function argument values must be one of the following types, or contain only the following GVariant types: number, string, array, and dictionary.
/// </param>
/// <param name="world_name">
/// the name of a #WebKitScriptWorld, if no name (i.e. %NULL) is provided, the default world is used. Any value that is not %NULL is a distinct world.
/// </param>
/// <param name="cancellable">
/// a #GCancellable or %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the script finished
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T RunAsyncJavascriptFunctionInWorld<T>(this T web_view, string body, MentorLake.GLib.GVariantHandle arguments, string world_name, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : WebKitWebViewHandle
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		WebKitWebViewHandleExterns.webkit_web_view_run_async_javascript_function_in_world(web_view, body, arguments, world_name, cancellable, callback, user_data);
		return web_view;
	}

/// <summary>
/// <para>
/// Asynchronously run @script in the context of the current page in @web_view.
/// </para>
/// <para>
/// If WebKitSettings:enable-javascript is FALSE, this method will do nothing.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called. You can then call
/// webkit_web_view_run_javascript_finish() to get the result of the operation.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="script">
/// the script to run
/// </param>
/// <param name="cancellable">
/// a #GCancellable or %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the script finished
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T RunJavascript<T>(this T web_view, string script, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : WebKitWebViewHandle
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		WebKitWebViewHandleExterns.webkit_web_view_run_javascript(web_view, script, cancellable, callback, user_data);
		return web_view;
	}

/// <summary>
/// <para>
/// Finish an asynchronous operation started with webkit_web_view_run_javascript().
/// </para>
/// <para>
/// This is an example of using webkit_web_view_run_javascript() with a script returning
/// a string:
/// </para>
/// <para>
/// ```c
/// static void
/// web_view_javascript_finished (GObject      *object,
///                               GAsyncResult *result,
///                               gpointer      user_data)
/// {
///     WebKitJavascriptResult *js_result;
///     JSCValue               *value;
///     GError                 *error = NULL;
/// </para>
/// <para>
///     js_result = webkit_web_view_run_javascript_finish (WEBKIT_WEB_VIEW (object), result, &amp;error);
///     if (!js_result) {
///         g_warning (&quot;Error running javascript: %s&quot;, error-&amp;gt;message);
///         g_error_free (error);
///         return;
///     }
/// </para>
/// <para>
///     value = webkit_javascript_result_get_js_value (js_result);
///     if (jsc_value_is_string (value)) {
///         gchar        *str_value = jsc_value_to_string (value);
///         JSCException *exception = jsc_context_get_exception (jsc_value_get_context (value));
///         if (exception)
///             g_warning (&quot;Error running javascript: %s&quot;, jsc_exception_get_message (exception));
///         else
///             g_print (&quot;Script result: %s\n&quot;, str_value);
///         g_free (str_value);
///     } else {
///         g_warning (&quot;Error running javascript: unexpected return value&quot;);
///     }
///     webkit_javascript_result_unref (js_result);
/// }
/// </para>
/// <para>
/// static void
/// web_view_get_link_url (WebKitWebView *web_view,
///                        const gchar   *link_id)
/// {
///     gchar *script = g_strdup_printf (&quot;window.document.getElementById(&apos;%s&apos;).href;&quot;, link_id);
///     webkit_web_view_run_javascript (web_view, script, NULL, web_view_javascript_finished, NULL);
///     g_free (script);
/// }
/// ```
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// a #WebKitJavascriptResult with the result of the last executed statement in @script
///    or %NULL in case of error
/// </return>

	public static MentorLake.WebKit2.WebKitJavascriptResultHandle RunJavascriptFinish(this MentorLake.WebKit2.WebKitWebViewHandle web_view, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		var externCallResult = WebKitWebViewHandleExterns.webkit_web_view_run_javascript_finish(web_view, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously run the script from @resource.
/// </para>
/// <para>
/// Asynchronously run the script from @resource in the context of the
/// current page in @web_view.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called. You can
/// then call webkit_web_view_run_javascript_from_gresource_finish() to get the result
/// of the operation.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="resource">
/// the location of the resource to load
/// </param>
/// <param name="cancellable">
/// a #GCancellable or %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the script finished
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T RunJavascriptFromGresource<T>(this T web_view, string resource, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : WebKitWebViewHandle
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		WebKitWebViewHandleExterns.webkit_web_view_run_javascript_from_gresource(web_view, resource, cancellable, callback, user_data);
		return web_view;
	}

/// <summary>
/// <para>
/// Finish an asynchronous operation started with webkit_web_view_run_javascript_from_gresource().
/// </para>
/// <para>
/// Check webkit_web_view_run_javascript_finish() for a usage example.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// a #WebKitJavascriptResult with the result of the last executed statement in @script
///    or %NULL in case of error
/// </return>

	public static MentorLake.WebKit2.WebKitJavascriptResultHandle RunJavascriptFromGresourceFinish(this MentorLake.WebKit2.WebKitWebViewHandle web_view, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		var externCallResult = WebKitWebViewHandleExterns.webkit_web_view_run_javascript_from_gresource_finish(web_view, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously run @script in the script world.
/// </para>
/// <para>
/// Asynchronously run @script in the script world with name @world_name of the current page context in @web_view.
/// If WebKitSettings:enable-javascript is FALSE, this method will do nothing.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called. You can then call
/// webkit_web_view_run_javascript_in_world_finish() to get the result of the operation.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="script">
/// the script to run
/// </param>
/// <param name="world_name">
/// the name of a #WebKitScriptWorld
/// </param>
/// <param name="cancellable">
/// a #GCancellable or %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the script finished
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T RunJavascriptInWorld<T>(this T web_view, string script, string world_name, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : WebKitWebViewHandle
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		WebKitWebViewHandleExterns.webkit_web_view_run_javascript_in_world(web_view, script, world_name, cancellable, callback, user_data);
		return web_view;
	}

/// <summary>
/// <para>
/// Finish an asynchronous operation started with webkit_web_view_run_javascript_in_world().
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// a #WebKitJavascriptResult with the result of the last executed statement in @script
///    or %NULL in case of error
/// </return>

	public static MentorLake.WebKit2.WebKitJavascriptResultHandle RunJavascriptInWorldFinish(this MentorLake.WebKit2.WebKitWebViewHandle web_view, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		var externCallResult = WebKitWebViewHandleExterns.webkit_web_view_run_javascript_in_world_finish(web_view, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously save the current web page.
/// </para>
/// <para>
/// Asynchronously save the current web page associated to the
/// #WebKitWebView into a self-contained format using the mode
/// specified in @save_mode.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called. You can
/// then call webkit_web_view_save_finish() to get the result of the
/// operation.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="save_mode">
/// the #WebKitSaveMode specifying how the web page should be saved.
/// </param>
/// <param name="cancellable">
/// a #GCancellable or %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T Save<T>(this T web_view, MentorLake.WebKit2.WebKitSaveMode save_mode, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : WebKitWebViewHandle
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		WebKitWebViewHandleExterns.webkit_web_view_save(web_view, save_mode, cancellable, callback, user_data);
		return web_view;
	}

/// <summary>
/// <para>
/// Finish an asynchronous operation started with webkit_web_view_save().
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// a #GInputStream with the result of saving
///    the current web page or %NULL in case of error.
/// </return>

	public static MentorLake.Gio.GInputStreamHandle SaveFinish(this MentorLake.WebKit2.WebKitWebViewHandle web_view, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		var externCallResult = WebKitWebViewHandleExterns.webkit_web_view_save_finish(web_view, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously save the current web page.
/// </para>
/// <para>
/// Asynchronously save the current web page associated to the
/// #WebKitWebView into a self-contained format using the mode
/// specified in @save_mode and writing it to @file.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called. You can
/// then call webkit_web_view_save_to_file_finish() to get the result of the
/// operation.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="file">
/// the #GFile where the current web page should be saved to.
/// </param>
/// <param name="save_mode">
/// the #WebKitSaveMode specifying how the web page should be saved.
/// </param>
/// <param name="cancellable">
/// a #GCancellable or %NULL to ignore
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T SaveToFile<T>(this T web_view, MentorLake.Gio.GFileHandle file, MentorLake.WebKit2.WebKitSaveMode save_mode, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : WebKitWebViewHandle
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		WebKitWebViewHandleExterns.webkit_web_view_save_to_file(web_view, file, save_mode, cancellable, callback, user_data);
		return web_view;
	}

/// <summary>
/// <para>
/// Finish an asynchronous operation started with webkit_web_view_save_to_file().
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// %TRUE if the web page was successfully saved to a file or %FALSE otherwise.
/// </return>

	public static bool SaveToFileFinish(this MentorLake.WebKit2.WebKitWebViewHandle web_view, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		var externCallResult = WebKitWebViewHandleExterns.webkit_web_view_save_to_file_finish(web_view, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Send @message to the #WebKitWebPage corresponding to @web_view.
/// </para>
/// <para>
/// If @message is floating, it&apos;s consumed.
/// If you don&apos;t expect any reply, or you simply want to ignore it, you can pass %NULL as @callback.
/// When the operation is finished, @callback will be called. You can then call
/// webkit_web_view_send_message_to_page_finish() to get the message reply.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="message">
/// a #WebKitUserMessage
/// </param>
/// <param name="cancellable">
/// a #GCancellable or %NULL to ignore
/// </param>
/// <param name="callback">
/// (nullable): A #GAsyncReadyCallback to call when the request is satisfied or %NULL
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T SendMessageToPage<T>(this T web_view, MentorLake.WebKit2.WebKitUserMessageHandle message, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : WebKitWebViewHandle
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		WebKitWebViewHandleExterns.webkit_web_view_send_message_to_page(web_view, message, cancellable, callback, user_data);
		return web_view;
	}

/// <summary>
/// <para>
/// Finish an asynchronous operation started with webkit_web_view_send_message_to_page().
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// a #WebKitUserMessage with the reply or %NULL in case of error.
/// </return>

	public static MentorLake.WebKit2.WebKitUserMessageHandle SendMessageToPageFinish(this MentorLake.WebKit2.WebKitWebViewHandle web_view, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		var externCallResult = WebKitWebViewHandleExterns.webkit_web_view_send_message_to_page_finish(web_view, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Sets the color that will be used to draw the @web_view background.
/// </para>
/// <para>
/// Sets the color that will be used to draw the @web_view background before
/// the actual contents are rendered. Note that if the web page loaded in @web_view
/// specifies a background color, it will take precedence over the @rgba color.
/// By default the @web_view background color is opaque white.
/// Note that the parent window must have a RGBA visual and
/// #GtkWidget:app-paintable property set to %TRUE for backgrounds colors to work.
/// </para>
/// <para>
/// ```c
/// static void browser_window_set_background_color (BrowserWindow *window,
///                                                  const GdkRGBA *rgba)
/// {
///     WebKitWebView *web_view;
///     GdkScreen *screen = gtk_window_get_screen (GTK_WINDOW (window));
///     GdkVisual *rgba_visual = gdk_screen_get_rgba_visual (screen);
/// </para>
/// <para>
///     if (!rgba_visual)
///          return;
/// </para>
/// <para>
///     gtk_widget_set_visual (GTK_WIDGET (window), rgba_visual);
///     gtk_widget_set_app_paintable (GTK_WIDGET (window), TRUE);
/// </para>
/// <para>
///     web_view = browser_window_get_web_view (window);
///     webkit_web_view_set_background_color (web_view, rgba);
/// }
/// ```
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="rgba">
/// a #GdkRGBA
/// </param>

	public static T SetBackgroundColor<T>(this T web_view, MentorLake.Gdk.GdkRGBAHandle rgba) where T : WebKitWebViewHandle
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		WebKitWebViewHandleExterns.webkit_web_view_set_background_color(web_view, rgba);
		return web_view;
	}

/// <summary>
/// <para>
/// Set the camera capture state of a #WebKitWebView.
/// </para>
/// <para>
/// If #WebKitSettings:enable-mediastream is %FALSE, this method will have no visible effect. Once the
/// state of the device has been set to %WEBKIT_MEDIA_CAPTURE_STATE_NONE it cannot be changed
/// anymore. The page can however request capture again using the mediaDevices API.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="state">
/// a #WebKitMediaCaptureState
/// </param>

	public static T SetCameraCaptureState<T>(this T web_view, MentorLake.WebKit2.WebKitMediaCaptureState state) where T : WebKitWebViewHandle
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		WebKitWebViewHandleExterns.webkit_web_view_set_camera_capture_state(web_view, state);
		return web_view;
	}

/// <summary>
/// <para>
/// Sets the @allowlist for CORS.
/// </para>
/// <para>
/// Sets the @allowlist for which
/// [Cross-Origin Resource Sharing](https://developer.mozilla.org/en-US/docs/Web/HTTP/CORS)
/// checks are disabled in @web_view. URI patterns must be of the form
/// `[protocol]://[host]/[path]`, each component may contain the wildcard
/// character (`*`) to represent zero or more other characters. All three
/// components are required and must not be omitted from the URI
/// patterns.
/// </para>
/// <para>
/// Disabling CORS checks permits resources from other origins to load
/// allowlisted resources. It does not permit the allowlisted resources
/// to load resources from other origins.
/// </para>
/// <para>
/// If this function is called multiple times, only the allowlist set by
/// the most recent call will be effective.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="allowlist">
/// an allowlist of URI patterns, or %NULL
/// </param>

	public static T SetCorsAllowlist<T>(this T web_view, string[] allowlist) where T : WebKitWebViewHandle
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		WebKitWebViewHandleExterns.webkit_web_view_set_cors_allowlist(web_view, allowlist);
		return web_view;
	}

/// <summary>
/// <para>
/// Sets the current custom character encoding override of @web_view.
/// </para>
/// <para>
/// The custom character encoding will override any text encoding detected via HTTP headers or
/// META tags. Calling this method will stop any current load operation and reload the
/// current page. Setting the custom character encoding to %NULL removes the character
/// encoding override.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="charset">
/// a character encoding name or %NULL
/// </param>

	public static T SetCustomCharset<T>(this T web_view, string charset) where T : WebKitWebViewHandle
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		WebKitWebViewHandleExterns.webkit_web_view_set_custom_charset(web_view, charset);
		return web_view;
	}

/// <summary>
/// <para>
/// Set the display capture state of a #WebKitWebView.
/// </para>
/// <para>
/// If #WebKitSettings:enable-mediastream is %FALSE, this method will have no visible effect. Once the
/// state of the device has been set to %WEBKIT_MEDIA_CAPTURE_STATE_NONE it cannot be changed
/// anymore. The page can however request capture again using the mediaDevices API.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="state">
/// a #WebKitMediaCaptureState
/// </param>

	public static T SetDisplayCaptureState<T>(this T web_view, MentorLake.WebKit2.WebKitMediaCaptureState state) where T : WebKitWebViewHandle
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		WebKitWebViewHandleExterns.webkit_web_view_set_display_capture_state(web_view, state);
		return web_view;
	}

/// <summary>
/// <para>
/// Sets whether the user is allowed to edit the HTML document.
/// </para>
/// <para>
/// If @editable is %TRUE, @web_view allows the user to edit the HTML document. If
/// @editable is %FALSE, an element in @web_view&apos;s document can only be edited if the
/// CONTENTEDITABLE attribute has been set on the element or one of its parent
/// elements. By default a #WebKitWebView is not editable.
/// </para>
/// <para>
/// Normally, a HTML document is not editable unless the elements within the
/// document are editable. This function provides a way to make the contents
/// of a #WebKitWebView editable without altering the document or DOM structure.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="editable">
/// a #gboolean indicating the editable state
/// </param>

	public static T SetEditable<T>(this T web_view, bool editable) where T : WebKitWebViewHandle
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		WebKitWebViewHandleExterns.webkit_web_view_set_editable(web_view, editable);
		return web_view;
	}

/// <summary>
/// <para>
/// Set the #WebKitInputMethodContext to be used by @web_view.
/// </para>
/// <para>
/// Set the #WebKitInputMethodContext to be used by @web_view, or %NULL to not use any input method.
/// Note that the same #WebKitInputMethodContext can&apos;t be set on more than one #WebKitWebView at the same time.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="context">
/// the #WebKitInputMethodContext to set, or %NULL
/// </param>

	public static T SetInputMethodContext<T>(this T web_view, MentorLake.WebKit2.WebKitInputMethodContextHandle context) where T : WebKitWebViewHandle
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		WebKitWebViewHandleExterns.webkit_web_view_set_input_method_context(web_view, context);
		return web_view;
	}

/// <summary>
/// <para>
/// Sets the mute state of @web_view.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="muted">
/// mute flag
/// </param>

	public static T SetIsMuted<T>(this T web_view, bool muted) where T : WebKitWebViewHandle
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		WebKitWebViewHandleExterns.webkit_web_view_set_is_muted(web_view, muted);
		return web_view;
	}

/// <summary>
/// <para>
/// Set the microphone capture state of a #WebKitWebView.
/// </para>
/// <para>
/// If #WebKitSettings:enable-mediastream is %FALSE, this method will have no visible effect. Once the
/// state of the device has been set to %WEBKIT_MEDIA_CAPTURE_STATE_NONE it cannot be changed
/// anymore. The page can however request capture again using the mediaDevices API.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="state">
/// a #WebKitMediaCaptureState
/// </param>

	public static T SetMicrophoneCaptureState<T>(this T web_view, MentorLake.WebKit2.WebKitMediaCaptureState state) where T : WebKitWebViewHandle
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		WebKitWebViewHandleExterns.webkit_web_view_set_microphone_capture_state(web_view, state);
		return web_view;
	}

/// <summary>
/// <para>
/// Sets the #WebKitSettings to be applied to @web_view.
/// </para>
/// <para>
/// The
/// existing #WebKitSettings of @web_view will be replaced by
/// @settings. New settings are applied immediately on @web_view.
/// The same #WebKitSettings object can be shared
/// by multiple #WebKitWebView&amp;lt;!-- --&amp;gt;s.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="settings">
/// a #WebKitSettings
/// </param>

	public static T SetSettings<T>(this T web_view, MentorLake.WebKit2.WebKitSettingsHandle settings) where T : WebKitWebViewHandle
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		WebKitWebViewHandleExterns.webkit_web_view_set_settings(web_view, settings);
		return web_view;
	}

/// <summary>
/// <para>
/// Set the zoom level of @web_view.
/// </para>
/// <para>
/// Set the zoom level of @web_view, i.e. the factor by which the
/// view contents are scaled with respect to their original size.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <param name="zoom_level">
/// the zoom level
/// </param>

	public static T SetZoomLevel<T>(this T web_view, double zoom_level) where T : WebKitWebViewHandle
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		WebKitWebViewHandleExterns.webkit_web_view_set_zoom_level(web_view, zoom_level);
		return web_view;
	}

/// <summary>
/// <para>
/// Stops any ongoing loading operation in @web_view.
/// </para>
/// <para>
/// This method does nothing if no content is being loaded.
/// If there is a loading operation in progress, it will be cancelled and
/// #WebKitWebView::load-failed signal will be emitted with
/// %WEBKIT_NETWORK_ERROR_CANCELLED error.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>

	public static T StopLoading<T>(this T web_view) where T : WebKitWebViewHandle
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		WebKitWebViewHandleExterns.webkit_web_view_stop_loading(web_view);
		return web_view;
	}

/// <summary>
/// <para>
/// Terminates the web process associated to @web_view.
/// </para>
/// <para>
/// When the web process gets terminated
/// using this method, the #WebKitWebView::web-process-terminated signal is emitted with
/// %WEBKIT_WEB_PROCESS_TERMINATED_BY_API as the reason for termination.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>

	public static T TerminateWebProcess<T>(this T web_view) where T : WebKitWebViewHandle
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		WebKitWebViewHandleExterns.webkit_web_view_terminate_web_process(web_view);
		return web_view;
	}

/// <summary>
/// <para>
/// Tries to close the @web_view.
/// </para>
/// <para>
/// This will fire the onbeforeunload event
/// to ask the user for confirmation to close the page. If there isn&apos;t an
/// onbeforeunload event handler or the user confirms to close the page,
/// the #WebKitWebView::close signal is emitted, otherwise nothing happens.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>

	public static T TryClose<T>(this T web_view) where T : WebKitWebViewHandle
	{
		if (web_view.IsInvalid) throw new Exception("Invalid handle (WebKitWebViewHandle)");
		WebKitWebViewHandleExterns.webkit_web_view_try_close(web_view);
		return web_view;
	}

}

internal class WebKitWebViewHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))]
	internal static extern MentorLake.WebKit2.WebKitWebViewHandle webkit_web_view_new();

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))]
	internal static extern MentorLake.WebKit2.WebKitWebViewHandle webkit_web_view_new_with_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))] MentorLake.WebKit2.WebKitWebContextHandle context);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))]
	internal static extern MentorLake.WebKit2.WebKitWebViewHandle webkit_web_view_new_with_related_view([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))]
	internal static extern MentorLake.WebKit2.WebKitWebViewHandle webkit_web_view_new_with_settings([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))]
	internal static extern MentorLake.WebKit2.WebKitWebViewHandle webkit_web_view_new_with_user_content_manager([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserContentManagerHandle>))] MentorLake.WebKit2.WebKitUserContentManagerHandle user_content_manager);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_call_async_javascript_function([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, string body, UIntPtr length, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle arguments, string world_name, string source_uri, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCValueHandle webkit_web_view_call_async_javascript_function_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_can_execute_editing_command([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, string command, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_web_view_can_execute_editing_command_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_web_view_can_go_back([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_web_view_can_go_forward([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_web_view_can_show_mime_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, string mime_type);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.WebKit2.WebKitDownloadHandle>))]
	internal static extern MentorLake.WebKit2.WebKitDownloadHandle webkit_web_view_download_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, string uri);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_evaluate_javascript([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, string script, UIntPtr length, string world_name, string source_uri, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCValueHandle webkit_web_view_evaluate_javascript_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_execute_editing_command([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, string command);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_execute_editing_command_with_argument([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, string command, string argument);

	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.WebKit2.WebKitAutomationBrowsingContextPresentation webkit_web_view_get_automation_presentation_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitBackForwardListHandle>))]
	internal static extern MentorLake.WebKit2.WebKitBackForwardListHandle webkit_web_view_get_back_forward_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_get_background_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, out MentorLake.Gdk.GdkRGBA rgba);

	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.WebKit2.WebKitMediaCaptureState webkit_web_view_get_camera_capture_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebContextHandle>))]
	internal static extern MentorLake.WebKit2.WebKitWebContextHandle webkit_web_view_get_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_web_view_get_custom_charset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_web_view_get_default_content_security_policy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.WebKit2.WebKitMediaCaptureState webkit_web_view_get_display_capture_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitEditorStateHandle>))]
	internal static extern MentorLake.WebKit2.WebKitEditorStateHandle webkit_web_view_get_editor_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	internal static extern double webkit_web_view_get_estimated_load_progress([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))]
	internal static extern MentorLake.cairo.cairo_surface_tHandle webkit_web_view_get_favicon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFindControllerHandle>))]
	internal static extern MentorLake.WebKit2.WebKitFindControllerHandle webkit_web_view_get_find_controller([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitInputMethodContextHandle>))]
	internal static extern MentorLake.WebKit2.WebKitInputMethodContextHandle webkit_web_view_get_input_method_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebInspectorHandle>))]
	internal static extern MentorLake.WebKit2.WebKitWebInspectorHandle webkit_web_view_get_inspector([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_web_view_get_is_muted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_web_view_get_is_web_process_responsive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.WebKit2.JSGlobalContextRef webkit_web_view_get_javascript_global_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebResourceHandle>))]
	internal static extern MentorLake.WebKit2.WebKitWebResourceHandle webkit_web_view_get_main_resource([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.WebKit2.WebKitMediaCaptureState webkit_web_view_get_microphone_capture_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	internal static extern ulong webkit_web_view_get_page_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewSessionStateHandle>))]
	internal static extern MentorLake.WebKit2.WebKitWebViewSessionStateHandle webkit_web_view_get_session_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))]
	internal static extern MentorLake.WebKit2.WebKitSettingsHandle webkit_web_view_get_settings([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_get_snapshot([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, MentorLake.WebKit2.WebKitSnapshotRegion region, MentorLake.WebKit2.WebKitSnapshotOptions options, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))]
	internal static extern MentorLake.cairo.cairo_surface_tHandle webkit_web_view_get_snapshot_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_web_view_get_theme_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, out MentorLake.Gdk.GdkRGBA rgba);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_web_view_get_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_web_view_get_tls_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] out MentorLake.Gio.GTlsCertificateHandle certificate, out MentorLake.Gio.GTlsCertificateFlags errors);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_web_view_get_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserContentManagerHandle>))]
	internal static extern MentorLake.WebKit2.WebKitUserContentManagerHandle webkit_web_view_get_user_content_manager([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.WebKit2.WebKitWebExtensionMode webkit_web_view_get_web_extension_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsiteDataManagerHandle>))]
	internal static extern MentorLake.WebKit2.WebKitWebsiteDataManagerHandle webkit_web_view_get_website_data_manager([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsitePoliciesHandle>))]
	internal static extern MentorLake.WebKit2.WebKitWebsitePoliciesHandle webkit_web_view_get_website_policies([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWindowPropertiesHandle>))]
	internal static extern MentorLake.WebKit2.WebKitWindowPropertiesHandle webkit_web_view_get_window_properties([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	internal static extern double webkit_web_view_get_zoom_level([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_go_back([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_go_forward([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_go_to_back_forward_list_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitBackForwardListItemHandle>))] MentorLake.WebKit2.WebKitBackForwardListItemHandle list_item);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_web_view_is_controlled_by_automation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_web_view_is_editable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_web_view_is_ephemeral([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_web_view_is_immersive_mode_enabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_web_view_is_loading([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_web_view_is_playing_audio([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_leave_immersive_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_load_alternate_html([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, string content, string content_uri, string base_uri);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_load_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes, string mime_type, string encoding, string base_uri);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_load_html([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, string content, string base_uri);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_load_plain_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, string plain_text);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_load_request([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitURIRequestHandle>))] MentorLake.WebKit2.WebKitURIRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_load_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, string uri);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_reload([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_reload_bypass_cache([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_restore_session_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewSessionStateHandle>))] MentorLake.WebKit2.WebKitWebViewSessionStateHandle state);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_run_async_javascript_function_in_world([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, string body, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle arguments, string world_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_run_javascript([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, string script, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitJavascriptResultHandle>))]
	internal static extern MentorLake.WebKit2.WebKitJavascriptResultHandle webkit_web_view_run_javascript_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_run_javascript_from_gresource([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, string resource, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitJavascriptResultHandle>))]
	internal static extern MentorLake.WebKit2.WebKitJavascriptResultHandle webkit_web_view_run_javascript_from_gresource_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_run_javascript_in_world([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, string script, string world_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitJavascriptResultHandle>))]
	internal static extern MentorLake.WebKit2.WebKitJavascriptResultHandle webkit_web_view_run_javascript_in_world_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_save([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, MentorLake.WebKit2.WebKitSaveMode save_mode, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))]
	internal static extern MentorLake.Gio.GInputStreamHandle webkit_web_view_save_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_save_to_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, MentorLake.WebKit2.WebKitSaveMode save_mode, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_web_view_save_to_file_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_send_message_to_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserMessageHandle>))] MentorLake.WebKit2.WebKitUserMessageHandle message, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserMessageHandle>))]
	internal static extern MentorLake.WebKit2.WebKitUserMessageHandle webkit_web_view_send_message_to_page_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_set_background_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle rgba);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_set_camera_capture_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, MentorLake.WebKit2.WebKitMediaCaptureState state);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_set_cors_allowlist([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, string[] allowlist);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_set_custom_charset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, string charset);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_set_display_capture_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, MentorLake.WebKit2.WebKitMediaCaptureState state);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_set_editable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, bool editable);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_set_input_method_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitInputMethodContextHandle>))] MentorLake.WebKit2.WebKitInputMethodContextHandle context);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_set_is_muted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, bool muted);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_set_microphone_capture_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, MentorLake.WebKit2.WebKitMediaCaptureState state);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_set_settings([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSettingsHandle>))] MentorLake.WebKit2.WebKitSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_set_zoom_level([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view, double zoom_level);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_stop_loading([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_terminate_web_process([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_view_try_close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

}
