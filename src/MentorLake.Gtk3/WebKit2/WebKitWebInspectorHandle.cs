namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Access to the WebKit inspector.
/// </para>
/// <para>
/// The WebKit Inspector is a graphical tool to inspect and change the
/// content of a #WebKitWebView. It also includes an interactive
/// JavaScript debugger. Using this class one can get a #GtkWidget
/// which can be embedded into an application to show the inspector.
/// </para>
/// <para>
/// The inspector is available when the #WebKitSettings of the
/// #WebKitWebView has set the #WebKitSettings:enable-developer-extras
/// to true, otherwise no inspector is available.
/// </para>
/// <para>
/// ```c
/// // Enable the developer extras
/// WebKitSettings *settings = webkit_web_view_get_settings (WEBKIT_WEB_VIEW(my_webview));
/// g_object_set (G_OBJECT(settings), &quot;enable-developer-extras&quot;, TRUE, NULL);
/// </para>
/// <para>
/// // Load some data or reload to be able to inspect the page
/// webkit_web_view_load_uri (WEBKIT_WEB_VIEW(my_webview), &quot;http://www.gnome.org&quot;);
/// </para>
/// <para>
/// // Show the inspector
/// WebKitWebInspector *inspector = webkit_web_view_get_inspector (WEBKIT_WEB_VIEW(my_webview));
/// webkit_web_inspector_show (WEBKIT_WEB_INSPECTOR(inspector));
/// ```
/// </para>
/// </summary>

public class WebKitWebInspectorHandle : GObjectHandle
{
}
public static class WebKitWebInspectorHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when the inspector is requested to be attached to the window
/// where the inspected web view is.
/// If this signal is not handled the inspector view will be automatically
/// attached to the inspected view, so you only need to handle this signal
/// if you want to attach the inspector view yourself (for example, to add
/// the inspector view to a browser tab).
/// </para>
/// <para>
/// To prevent the inspector view from being attached you can connect to this
/// signal and simply return %TRUE.
/// </para>
/// </summary>

	public static IObservable<WebKitWebInspectorHandleSignalStructs.AttachSignal> Signal_Attach(this WebKitWebInspectorHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebInspectorHandleSignalStructs.AttachSignal> obs) =>
		{
			WebKitWebInspectorHandleSignalDelegates.attach handler = ( MentorLake.WebKit2.WebKitWebInspectorHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebInspectorHandleSignalStructs.AttachSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "attach", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when the inspector should be shown.
/// </para>
/// <para>
/// If the inspector is not attached the inspector window should be shown
/// on top of any other windows.
/// If the inspector is attached the inspector view should be made visible.
/// For example, if the inspector view is attached using a tab in a browser
/// window, the browser window should be raised and the tab containing the
/// inspector view should be the active one.
/// In both cases, if this signal is not handled, the default implementation
/// calls gtk_window_present() on the current toplevel #GtkWindow of the
/// inspector view.
/// </para>
/// </summary>

	public static IObservable<WebKitWebInspectorHandleSignalStructs.BringToFrontSignal> Signal_BringToFront(this WebKitWebInspectorHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebInspectorHandleSignalStructs.BringToFrontSignal> obs) =>
		{
			WebKitWebInspectorHandleSignalDelegates.bring_to_front handler = ( MentorLake.WebKit2.WebKitWebInspectorHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebInspectorHandleSignalStructs.BringToFrontSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "bring-to-front", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when the inspector page is closed. If you are using your own
/// inspector window, you should connect to this signal and destroy your
/// window.
/// </para>
/// </summary>

	public static IObservable<WebKitWebInspectorHandleSignalStructs.ClosedSignal> Signal_Closed(this WebKitWebInspectorHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebInspectorHandleSignalStructs.ClosedSignal> obs) =>
		{
			WebKitWebInspectorHandleSignalDelegates.closed handler = ( MentorLake.WebKit2.WebKitWebInspectorHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebInspectorHandleSignalStructs.ClosedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "closed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when the inspector is requested to be detached from the window
/// it is currently attached to. The inspector is detached when the inspector page
/// is about to be closed, and this signal is emitted right before
/// #WebKitWebInspector::closed, or when the user clicks on the detach button
/// in the inspector view to show the inspector in a separate window. In this case
/// the signal #WebKitWebInspector::open-window is emitted after this one.
/// </para>
/// <para>
/// To prevent the inspector view from being detached you can connect to this
/// signal and simply return %TRUE.
/// </para>
/// </summary>

	public static IObservable<WebKitWebInspectorHandleSignalStructs.DetachSignal> Signal_Detach(this WebKitWebInspectorHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebInspectorHandleSignalStructs.DetachSignal> obs) =>
		{
			WebKitWebInspectorHandleSignalDelegates.detach handler = ( MentorLake.WebKit2.WebKitWebInspectorHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebInspectorHandleSignalStructs.DetachSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "detach", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when the inspector is requested to open in a separate window.
/// If this signal is not handled, a #GtkWindow with the inspector will be
/// created and shown, so you only need to handle this signal if you want
/// to use your own window.
/// This signal is emitted after #WebKitWebInspector::detach to show
/// the inspector in a separate window after being detached.
/// </para>
/// <para>
/// To prevent the inspector from being shown you can connect to this
/// signal and simply return %TRUE
/// </para>
/// </summary>

	public static IObservable<WebKitWebInspectorHandleSignalStructs.OpenWindowSignal> Signal_OpenWindow(this WebKitWebInspectorHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebInspectorHandleSignalStructs.OpenWindowSignal> obs) =>
		{
			WebKitWebInspectorHandleSignalDelegates.open_window handler = ( MentorLake.WebKit2.WebKitWebInspectorHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebInspectorHandleSignalStructs.OpenWindowSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "open-window", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class WebKitWebInspectorHandleSignalStructs
{

public class AttachSignal
{

	public MentorLake.WebKit2.WebKitWebInspectorHandle Self;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///    %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class BringToFrontSignal
{

	public MentorLake.WebKit2.WebKitWebInspectorHandle Self;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///    %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class ClosedSignal
{

	public MentorLake.WebKit2.WebKitWebInspectorHandle Self;

	public IntPtr UserData;
}

public class DetachSignal
{

	public MentorLake.WebKit2.WebKitWebInspectorHandle Self;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event.
///    %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class OpenWindowSignal
{

	public MentorLake.WebKit2.WebKitWebInspectorHandle Self;

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

public static class WebKitWebInspectorHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted when the inspector is requested to be attached to the window
/// where the inspected web view is.
/// If this signal is not handled the inspector view will be automatically
/// attached to the inspected view, so you only need to handle this signal
/// if you want to attach the inspector view yourself (for example, to add
/// the inspector view to a browser tab).
/// </para>
/// <para>
/// To prevent the inspector view from being attached you can connect to this
/// signal and simply return %TRUE.
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
public delegate bool attach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebInspectorHandle>))] MentorLake.WebKit2.WebKitWebInspectorHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when the inspector should be shown.
/// </para>
/// <para>
/// If the inspector is not attached the inspector window should be shown
/// on top of any other windows.
/// If the inspector is attached the inspector view should be made visible.
/// For example, if the inspector view is attached using a tab in a browser
/// window, the browser window should be raised and the tab containing the
/// inspector view should be the active one.
/// In both cases, if this signal is not handled, the default implementation
/// calls gtk_window_present() on the current toplevel #GtkWindow of the
/// inspector view.
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
public delegate bool bring_to_front([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebInspectorHandle>))] MentorLake.WebKit2.WebKitWebInspectorHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when the inspector page is closed. If you are using your own
/// inspector window, you should connect to this signal and destroy your
/// window.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void closed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebInspectorHandle>))] MentorLake.WebKit2.WebKitWebInspectorHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when the inspector is requested to be detached from the window
/// it is currently attached to. The inspector is detached when the inspector page
/// is about to be closed, and this signal is emitted right before
/// #WebKitWebInspector::closed, or when the user clicks on the detach button
/// in the inspector view to show the inspector in a separate window. In this case
/// the signal #WebKitWebInspector::open-window is emitted after this one.
/// </para>
/// <para>
/// To prevent the inspector view from being detached you can connect to this
/// signal and simply return %TRUE.
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
public delegate bool detach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebInspectorHandle>))] MentorLake.WebKit2.WebKitWebInspectorHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when the inspector is requested to open in a separate window.
/// If this signal is not handled, a #GtkWindow with the inspector will be
/// created and shown, so you only need to handle this signal if you want
/// to use your own window.
/// This signal is emitted after #WebKitWebInspector::detach to show
/// the inspector in a separate window after being detached.
/// </para>
/// <para>
/// To prevent the inspector from being shown you can connect to this
/// signal and simply return %TRUE
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
public delegate bool open_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebInspectorHandle>))] MentorLake.WebKit2.WebKitWebInspectorHandle self, IntPtr user_data);

}


public static class WebKitWebInspectorHandleExtensions
{
/// <summary>
/// <para>
/// Request @inspector to be attached.
/// </para>
/// <para>
/// The signal #WebKitWebInspector::attach
/// will be emitted. If the inspector is already attached it does nothing.
/// </para>
/// </summary>

/// <param name="inspector">
/// a #WebKitWebInspector
/// </param>

	public static T Attach<T>(this T inspector) where T : WebKitWebInspectorHandle
	{
		if (inspector.IsInvalid) throw new Exception("Invalid handle (WebKitWebInspectorHandle)");
		WebKitWebInspectorHandleExterns.webkit_web_inspector_attach(inspector);
		return inspector;
	}

/// <summary>
/// <para>
/// Request @inspector to be closed.
/// </para>
/// </summary>

/// <param name="inspector">
/// a #WebKitWebInspector
/// </param>

	public static T Close<T>(this T inspector) where T : WebKitWebInspectorHandle
	{
		if (inspector.IsInvalid) throw new Exception("Invalid handle (WebKitWebInspectorHandle)");
		WebKitWebInspectorHandleExterns.webkit_web_inspector_close(inspector);
		return inspector;
	}

/// <summary>
/// <para>
/// Request @inspector to be detached.
/// </para>
/// <para>
/// The signal #WebKitWebInspector::detach
/// will be emitted. If the inspector is already detached it does nothing.
/// </para>
/// </summary>

/// <param name="inspector">
/// a #WebKitWebInspector
/// </param>

	public static T Detach<T>(this T inspector) where T : WebKitWebInspectorHandle
	{
		if (inspector.IsInvalid) throw new Exception("Invalid handle (WebKitWebInspectorHandle)");
		WebKitWebInspectorHandleExterns.webkit_web_inspector_detach(inspector);
		return inspector;
	}

/// <summary>
/// <para>
/// Get the height that the inspector view when attached.
/// </para>
/// <para>
/// Get the height that the inspector view should have when
/// it&apos;s attached. If the inspector view is not attached this
/// returns 0.
/// </para>
/// </summary>

/// <param name="inspector">
/// a #WebKitWebInspector
/// </param>
/// <return>
/// the height of the inspector view when attached
/// </return>

	public static uint GetAttachedHeight(this MentorLake.WebKit2.WebKitWebInspectorHandle inspector)
	{
		if (inspector.IsInvalid) throw new Exception("Invalid handle (WebKitWebInspectorHandle)");
		return WebKitWebInspectorHandleExterns.webkit_web_inspector_get_attached_height(inspector);
	}

/// <summary>
/// <para>
/// Whether the @inspector can be attached to the same window that contains
/// the inspected view.
/// </para>
/// </summary>

/// <param name="inspector">
/// a #WebKitWebInspector
/// </param>
/// <return>
/// %TRUE if there is enough room for the inspector view inside the
///     window that contains the inspected view, or %FALSE otherwise.
/// </return>

	public static bool GetCanAttach(this MentorLake.WebKit2.WebKitWebInspectorHandle inspector)
	{
		if (inspector.IsInvalid) throw new Exception("Invalid handle (WebKitWebInspectorHandle)");
		return WebKitWebInspectorHandleExterns.webkit_web_inspector_get_can_attach(inspector);
	}

/// <summary>
/// <para>
/// Get the URI that is currently being inspected.
/// </para>
/// <para>
/// This can be %NULL if
/// nothing has been loaded yet in the inspected view, if the inspector
/// has been closed or when inspected view was loaded from a HTML string
/// instead of a URI.
/// </para>
/// </summary>

/// <param name="inspector">
/// a #WebKitWebInspector
/// </param>
/// <return>
/// the URI that is currently being inspected or %NULL
/// </return>

	public static string GetInspectedUri(this MentorLake.WebKit2.WebKitWebInspectorHandle inspector)
	{
		if (inspector.IsInvalid) throw new Exception("Invalid handle (WebKitWebInspectorHandle)");
		return WebKitWebInspectorHandleExterns.webkit_web_inspector_get_inspected_uri(inspector);
	}

/// <summary>
/// <para>
/// Get the #WebKitWebViewBase used to display the inspector.
/// </para>
/// <para>
/// This might be %NULL if the inspector hasn&apos;t been loaded yet,
/// or it has been closed.
/// </para>
/// </summary>

/// <param name="inspector">
/// a #WebKitWebInspector
/// </param>
/// <return>
/// the #WebKitWebViewBase used to display the inspector or %NULL
/// </return>

	public static MentorLake.WebKit2.WebKitWebViewBaseHandle GetWebView(this MentorLake.WebKit2.WebKitWebInspectorHandle inspector)
	{
		if (inspector.IsInvalid) throw new Exception("Invalid handle (WebKitWebInspectorHandle)");
		return WebKitWebInspectorHandleExterns.webkit_web_inspector_get_web_view(inspector);
	}

/// <summary>
/// <para>
/// Whether the @inspector view is currently attached to the same window that contains
/// the inspected view.
/// </para>
/// </summary>

/// <param name="inspector">
/// a #WebKitWebInspector
/// </param>
/// <return>
/// %TRUE if @inspector is currently attached or %FALSE otherwise
/// </return>

	public static bool IsAttached(this MentorLake.WebKit2.WebKitWebInspectorHandle inspector)
	{
		if (inspector.IsInvalid) throw new Exception("Invalid handle (WebKitWebInspectorHandle)");
		return WebKitWebInspectorHandleExterns.webkit_web_inspector_is_attached(inspector);
	}

/// <summary>
/// <para>
/// Request @inspector to be shown.
/// </para>
/// </summary>

/// <param name="inspector">
/// a #WebKitWebInspector
/// </param>

	public static T Show<T>(this T inspector) where T : WebKitWebInspectorHandle
	{
		if (inspector.IsInvalid) throw new Exception("Invalid handle (WebKitWebInspectorHandle)");
		WebKitWebInspectorHandleExterns.webkit_web_inspector_show(inspector);
		return inspector;
	}

}

internal class WebKitWebInspectorHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_inspector_attach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebInspectorHandle>))] MentorLake.WebKit2.WebKitWebInspectorHandle inspector);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_inspector_close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebInspectorHandle>))] MentorLake.WebKit2.WebKitWebInspectorHandle inspector);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_inspector_detach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebInspectorHandle>))] MentorLake.WebKit2.WebKitWebInspectorHandle inspector);

	[DllImport(WebKit2Library.Name)]
	internal static extern uint webkit_web_inspector_get_attached_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebInspectorHandle>))] MentorLake.WebKit2.WebKitWebInspectorHandle inspector);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_web_inspector_get_can_attach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebInspectorHandle>))] MentorLake.WebKit2.WebKitWebInspectorHandle inspector);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_web_inspector_get_inspected_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebInspectorHandle>))] MentorLake.WebKit2.WebKitWebInspectorHandle inspector);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewBaseHandle>))]
	internal static extern MentorLake.WebKit2.WebKitWebViewBaseHandle webkit_web_inspector_get_web_view([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebInspectorHandle>))] MentorLake.WebKit2.WebKitWebInspectorHandle inspector);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_web_inspector_is_attached([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebInspectorHandle>))] MentorLake.WebKit2.WebKitWebInspectorHandle inspector);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_inspector_show([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebInspectorHandle>))] MentorLake.WebKit2.WebKitWebInspectorHandle inspector);

}
