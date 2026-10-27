namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Automation Session.
/// </para>
/// <para>
/// WebKitAutomationSession represents an automation session of a WebKitWebContext.
/// When a new session is requested, a WebKitAutomationSession is created and the signal
/// WebKitWebContext::automation-started is emitted with the WebKitAutomationSession as
/// argument. Then, the automation client can request the session to create a new
/// #WebKitWebView to interact with it. When this happens the signal #WebKitAutomationSession::create-web-view
/// is emitted.
/// </para>
/// </summary>

public class WebKitAutomationSessionHandle : GObjectHandle
{
}
public static class WebKitAutomationSessionHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted when the automation client requests a new
/// browsing context to interact with it. The callback handler should
/// return a #WebKitWebView created with #WebKitWebView:is-controlled-by-automation
/// construct property enabled and #WebKitWebView:automation-presentation-type construct
/// property set if needed.
/// </para>
/// <para>
/// If the signal is emitted with &quot;tab&quot; detail, the returned #WebKitWebView should be
/// a new web view added to a new tab of the current browsing context window.
/// If the signal is emitted with &quot;window&quot; detail, the returned #WebKitWebView should be
/// a new web view added to a new window.
/// When creating a new web view and there&apos;s an active browsing context, the new window
/// or tab shouldn&apos;t be focused.
/// </para>
/// </summary>

	public static IObservable<WebKitAutomationSessionHandleSignalStructs.CreateWebViewSignal> Signal_CreateWebView(this WebKitAutomationSessionHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitAutomationSessionHandleSignalStructs.CreateWebViewSignal> obs) =>
		{
			WebKitAutomationSessionHandleSignalDelegates.create_web_view handler = ( MentorLake.WebKit2.WebKitAutomationSessionHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitAutomationSessionHandleSignalStructs.CreateWebViewSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "create-web-view", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted when the given automation session is about to finish.
/// It allows clients to perform any cleanup tasks before the session is destroyed.
/// </para>
/// </summary>

	public static IObservable<WebKitAutomationSessionHandleSignalStructs.WillCloseSignal> Signal_WillClose(this WebKitAutomationSessionHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitAutomationSessionHandleSignalStructs.WillCloseSignal> obs) =>
		{
			WebKitAutomationSessionHandleSignalDelegates.will_close handler = ( MentorLake.WebKit2.WebKitAutomationSessionHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitAutomationSessionHandleSignalStructs.WillCloseSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "will-close", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class WebKitAutomationSessionHandleSignalStructs
{

public class CreateWebViewSignal
{

	public MentorLake.WebKit2.WebKitAutomationSessionHandle Self;

	public IntPtr UserData;
/// <summary>
/// <para>
/// a #WebKitWebView widget.
/// </para>
/// </summary>

	public MentorLake.WebKit2.WebKitWebViewHandle ReturnValue;
}

public class WillCloseSignal
{

	public MentorLake.WebKit2.WebKitAutomationSessionHandle Self;

	public IntPtr UserData;
}
}

public static class WebKitAutomationSessionHandleSignalDelegates
{

/// <summary>
/// <para>
/// This signal is emitted when the automation client requests a new
/// browsing context to interact with it. The callback handler should
/// return a #WebKitWebView created with #WebKitWebView:is-controlled-by-automation
/// construct property enabled and #WebKitWebView:automation-presentation-type construct
/// property set if needed.
/// </para>
/// <para>
/// If the signal is emitted with &quot;tab&quot; detail, the returned #WebKitWebView should be
/// a new web view added to a new tab of the current browsing context window.
/// If the signal is emitted with &quot;window&quot; detail, the returned #WebKitWebView should be
/// a new web view added to a new window.
/// When creating a new web view and there&apos;s an active browsing context, the new window
/// or tab shouldn&apos;t be focused.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// a #WebKitWebView widget.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.WebKit2.WebKitWebViewHandle create_web_view([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitAutomationSessionHandle>))] MentorLake.WebKit2.WebKitAutomationSessionHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when the given automation session is about to finish.
/// It allows clients to perform any cleanup tasks before the session is destroyed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void will_close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitAutomationSessionHandle>))] MentorLake.WebKit2.WebKitAutomationSessionHandle self, IntPtr user_data);

}


public static class WebKitAutomationSessionHandleExtensions
{
/// <summary>
/// <para>
/// Get the the previously set #WebKitAutomationSession.
/// </para>
/// <para>
/// Get the #WebKitAutomationSession previously set with webkit_automation_session_set_application_info().
/// </para>
/// </summary>

/// <param name="session">
/// a #WebKitAutomationSession
/// </param>
/// <return>
/// the #WebKitAutomationSession of @session, or %NULL if no one has been set.
/// </return>

	public static MentorLake.WebKit2.WebKitApplicationInfoHandle GetApplicationInfo(this MentorLake.WebKit2.WebKitAutomationSessionHandle session)
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (WebKitAutomationSessionHandle)");
		return WebKitAutomationSessionHandleExterns.webkit_automation_session_get_application_info(session);
	}

/// <summary>
/// <para>
/// Get the unique identifier of a #WebKitAutomationSession
/// </para>
/// </summary>

/// <param name="session">
/// a #WebKitAutomationSession
/// </param>
/// <return>
/// the unique identifier of @session
/// </return>

	public static string GetId(this MentorLake.WebKit2.WebKitAutomationSessionHandle session)
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (WebKitAutomationSessionHandle)");
		return WebKitAutomationSessionHandleExterns.webkit_automation_session_get_id(session);
	}

/// <summary>
/// <para>
/// Set the application information to @session.
/// </para>
/// <para>
/// This information will be used by the driver service
/// to match the requested capabilities with the actual application information. If this information
/// is not provided to the session when a new automation session is requested, the creation might fail
/// if the client requested a specific browser name or version. This will not have any effect when called
/// after the automation session has been fully created, so this must be called in the callback of
/// #WebKitWebContext::automation-started signal.
/// </para>
/// </summary>

/// <param name="session">
/// a #WebKitAutomationSession
/// </param>
/// <param name="info">
/// a #WebKitApplicationInfo
/// </param>

	public static T SetApplicationInfo<T>(this T session, MentorLake.WebKit2.WebKitApplicationInfoHandle info) where T : WebKitAutomationSessionHandle
	{
		if (session.IsInvalid) throw new Exception("Invalid handle (WebKitAutomationSessionHandle)");
		WebKitAutomationSessionHandleExterns.webkit_automation_session_set_application_info(session, info);
		return session;
	}

}

internal class WebKitAutomationSessionHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitApplicationInfoHandle>))]
	internal static extern MentorLake.WebKit2.WebKitApplicationInfoHandle webkit_automation_session_get_application_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitAutomationSessionHandle>))] MentorLake.WebKit2.WebKitAutomationSessionHandle session);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_automation_session_get_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitAutomationSessionHandle>))] MentorLake.WebKit2.WebKitAutomationSessionHandle session);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_automation_session_set_application_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitAutomationSessionHandle>))] MentorLake.WebKit2.WebKitAutomationSessionHandle session, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitApplicationInfoHandle>))] MentorLake.WebKit2.WebKitApplicationInfoHandle info);

}
