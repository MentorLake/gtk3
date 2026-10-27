namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Represents a resource at the end of a URI.
/// </para>
/// <para>
/// A #WebKitWebResource encapsulates content for each resource at the
/// end of a particular URI. For example, one #WebKitWebResource will
/// be created for each separate image and stylesheet when a page is
/// loaded.
/// </para>
/// <para>
/// You can access the response and the URI for a given
/// #WebKitWebResource, using webkit_web_resource_get_uri() and
/// webkit_web_resource_get_response(), as well as the raw data, using
/// webkit_web_resource_get_data().
/// </para>
/// </summary>

public class WebKitWebResourceHandle : GObjectHandle
{
}
public static class WebKitWebResourceHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted when an error occurs during the resource
/// load operation.
/// </para>
/// </summary>

	public static IObservable<WebKitWebResourceHandleSignalStructs.FailedSignal> Signal_Failed(this WebKitWebResourceHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebResourceHandleSignalStructs.FailedSignal> obs) =>
		{
			WebKitWebResourceHandleSignalDelegates.failed handler = ( MentorLake.WebKit2.WebKitWebResourceHandle self,  MentorLake.GLib.GErrorHandle error,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebResourceHandleSignalStructs.FailedSignal()
				{
					Self = self, Error = error, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "failed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted when a TLS error occurs during the resource load operation.
/// </para>
/// </summary>

	public static IObservable<WebKitWebResourceHandleSignalStructs.FailedWithTlsErrorsSignal> Signal_FailedWithTlsErrors(this WebKitWebResourceHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebResourceHandleSignalStructs.FailedWithTlsErrorsSignal> obs) =>
		{
			WebKitWebResourceHandleSignalDelegates.failed_with_tls_errors handler = ( MentorLake.WebKit2.WebKitWebResourceHandle self,  MentorLake.Gio.GTlsCertificateHandle certificate,  MentorLake.Gio.GTlsCertificateFlags errors,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebResourceHandleSignalStructs.FailedWithTlsErrorsSignal()
				{
					Self = self, Certificate = certificate, Errors = errors, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "failed-with-tls-errors", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted when the resource load finishes successfully
/// or due to an error. In case of errors #WebKitWebResource::failed signal
/// is emitted before this one.
/// </para>
/// </summary>

	public static IObservable<WebKitWebResourceHandleSignalStructs.FinishedSignal> Signal_Finished(this WebKitWebResourceHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebResourceHandleSignalStructs.FinishedSignal> obs) =>
		{
			WebKitWebResourceHandleSignalDelegates.finished handler = ( MentorLake.WebKit2.WebKitWebResourceHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebResourceHandleSignalStructs.FinishedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "finished", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted after response is received,
/// every time new data has been received. It&apos;s
/// useful to know the progress of the resource load operation.
/// </para>
/// <para>
/// This is signal is deprecated since version 2.40 and it&apos;s never emitted.
/// </para>
/// </summary>

	public static IObservable<WebKitWebResourceHandleSignalStructs.ReceivedDataSignal> Signal_ReceivedData(this WebKitWebResourceHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebResourceHandleSignalStructs.ReceivedDataSignal> obs) =>
		{
			WebKitWebResourceHandleSignalDelegates.received_data handler = ( MentorLake.WebKit2.WebKitWebResourceHandle self,  ulong data_length,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebResourceHandleSignalStructs.ReceivedDataSignal()
				{
					Self = self, DataLength = data_length, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "received-data", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted when @request has been sent to the
/// server. In case of a server redirection this signal is
/// emitted again with the @request argument containing the new
/// request sent to the server due to the redirection and the
/// @redirected_response parameter containing the response
/// received by the server for the initial request.
/// </para>
/// </summary>

	public static IObservable<WebKitWebResourceHandleSignalStructs.SentRequestSignal> Signal_SentRequest(this WebKitWebResourceHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitWebResourceHandleSignalStructs.SentRequestSignal> obs) =>
		{
			WebKitWebResourceHandleSignalDelegates.sent_request handler = ( MentorLake.WebKit2.WebKitWebResourceHandle self,  MentorLake.WebKit2.WebKitURIRequestHandle request,  MentorLake.WebKit2.WebKitURIResponseHandle redirected_response,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitWebResourceHandleSignalStructs.SentRequestSignal()
				{
					Self = self, Request = request, RedirectedResponse = redirected_response, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "sent-request", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class WebKitWebResourceHandleSignalStructs
{

public class FailedSignal
{

	public MentorLake.WebKit2.WebKitWebResourceHandle Self;
/// <summary>
/// <para>
/// the #GError that was triggered
/// </para>
/// </summary>

	public MentorLake.GLib.GErrorHandle Error;

	public IntPtr UserData;
}

public class FailedWithTlsErrorsSignal
{

	public MentorLake.WebKit2.WebKitWebResourceHandle Self;
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
}

public class FinishedSignal
{

	public MentorLake.WebKit2.WebKitWebResourceHandle Self;

	public IntPtr UserData;
}

public class ReceivedDataSignal
{

	public MentorLake.WebKit2.WebKitWebResourceHandle Self;
/// <summary>
/// <para>
/// the length of data received in bytes
/// </para>
/// </summary>

	public ulong DataLength;

	public IntPtr UserData;
}

public class SentRequestSignal
{

	public MentorLake.WebKit2.WebKitWebResourceHandle Self;
/// <summary>
/// <para>
/// a #WebKitURIRequest
/// </para>
/// </summary>

	public MentorLake.WebKit2.WebKitURIRequestHandle Request;
/// <summary>
/// <para>
/// a #WebKitURIResponse, or %NULL
/// </para>
/// </summary>

	public MentorLake.WebKit2.WebKitURIResponseHandle RedirectedResponse;

	public IntPtr UserData;
}
}

public static class WebKitWebResourceHandleSignalDelegates
{

/// <summary>
/// <para>
/// This signal is emitted when an error occurs during the resource
/// load operation.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="error">
/// the #GError that was triggered
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void failed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebResourceHandle>))] MentorLake.WebKit2.WebKitWebResourceHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when a TLS error occurs during the resource load operation.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="certificate">
/// a #GTlsCertificate
/// </param>
/// <param name="errors">
/// a #GTlsCertificateFlags with the verification status of @certificate
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void failed_with_tls_errors([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebResourceHandle>))] MentorLake.WebKit2.WebKitWebResourceHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle certificate, MentorLake.Gio.GTlsCertificateFlags errors, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when the resource load finishes successfully
/// or due to an error. In case of errors #WebKitWebResource::failed signal
/// is emitted before this one.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void finished([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebResourceHandle>))] MentorLake.WebKit2.WebKitWebResourceHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted after response is received,
/// every time new data has been received. It&apos;s
/// useful to know the progress of the resource load operation.
/// </para>
/// <para>
/// This is signal is deprecated since version 2.40 and it&apos;s never emitted.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="data_length">
/// the length of data received in bytes
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void received_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebResourceHandle>))] MentorLake.WebKit2.WebKitWebResourceHandle self, ulong data_length, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when @request has been sent to the
/// server. In case of a server redirection this signal is
/// emitted again with the @request argument containing the new
/// request sent to the server due to the redirection and the
/// @redirected_response parameter containing the response
/// received by the server for the initial request.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="request">
/// a #WebKitURIRequest
/// </param>
/// <param name="redirected_response">
/// a #WebKitURIResponse, or %NULL
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void sent_request([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebResourceHandle>))] MentorLake.WebKit2.WebKitWebResourceHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitURIRequestHandle>))] MentorLake.WebKit2.WebKitURIRequestHandle request, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitURIResponseHandle>))] MentorLake.WebKit2.WebKitURIResponseHandle redirected_response, IntPtr user_data);

}


public static class WebKitWebResourceHandleExtensions
{
/// <summary>
/// <para>
/// Asynchronously get the raw data for @resource.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called. You can then call
/// webkit_web_resource_get_data_finish() to get the result of the operation.
/// </para>
/// </summary>

/// <param name="resource">
/// a #WebKitWebResource
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

	public static T GetData<T>(this T resource, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : WebKitWebResourceHandle
	{
		if (resource.IsInvalid) throw new Exception("Invalid handle (WebKitWebResourceHandle)");
		WebKitWebResourceHandleExterns.webkit_web_resource_get_data(resource, cancellable, callback, user_data);
		return resource;
	}

/// <summary>
/// <para>
/// Finish an asynchronous operation started with webkit_web_resource_get_data().
/// </para>
/// </summary>

/// <param name="resource">
/// a #WebKitWebResource
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <param name="length">
/// return location for the length of the resource data
/// </param>
/// <return>
/// a
///    string with the data of @resource, or %NULL in case of error. if @length
///    is not %NULL, the size of the data will be assigned to it.
/// </return>

	public static byte[] GetDataFinish(this MentorLake.WebKit2.WebKitWebResourceHandle resource, MentorLake.Gio.GAsyncResultHandle result, out UIntPtr length)
	{
		if (resource.IsInvalid) throw new Exception("Invalid handle (WebKitWebResourceHandle)");
		var externCallResult = WebKitWebResourceHandleExterns.webkit_web_resource_get_data_finish(resource, result, out length, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Retrieves the #WebKitURIResponse of the resource load operation.
/// </para>
/// <para>
/// This method returns %NULL if called before the response
/// is received from the server. You can connect to notify::response
/// signal to be notified when the response is received.
/// </para>
/// </summary>

/// <param name="resource">
/// a #WebKitWebResource
/// </param>
/// <return>
/// the #WebKitURIResponse, or %NULL if
///     the response hasn&apos;t been received yet.
/// </return>

	public static MentorLake.WebKit2.WebKitURIResponseHandle GetResponse(this MentorLake.WebKit2.WebKitWebResourceHandle resource)
	{
		if (resource.IsInvalid) throw new Exception("Invalid handle (WebKitWebResourceHandle)");
		return WebKitWebResourceHandleExterns.webkit_web_resource_get_response(resource);
	}

/// <summary>
/// <para>
/// Returns the current active URI of @resource.
/// </para>
/// <para>
/// The active URI might change during
/// a load operation:
/// </para>
/// <para>
/// &amp;lt;orderedlist&amp;gt;
/// &amp;lt;listitem&amp;gt;&amp;lt;para&amp;gt;
///   When the resource load starts, the active URI is the requested URI
/// &amp;lt;/para&amp;gt;&amp;lt;/listitem&amp;gt;
/// &amp;lt;listitem&amp;gt;&amp;lt;para&amp;gt;
///   When the initial request is sent to the server, #WebKitWebResource::sent-request
///   signal is emitted without a redirected response, the active URI is the URI of
///   the request sent to the server.
/// &amp;lt;/para&amp;gt;&amp;lt;/listitem&amp;gt;
/// &amp;lt;listitem&amp;gt;&amp;lt;para&amp;gt;
///   In case of a server redirection, #WebKitWebResource::sent-request signal
///   is emitted again with a redirected response, the active URI is the URI the request
///   was redirected to.
/// &amp;lt;/para&amp;gt;&amp;lt;/listitem&amp;gt;
/// &amp;lt;listitem&amp;gt;&amp;lt;para&amp;gt;
///   When the response is received from the server, the active URI is the final
///   one and it will not change again.
/// &amp;lt;/para&amp;gt;&amp;lt;/listitem&amp;gt;
/// &amp;lt;/orderedlist&amp;gt;
/// </para>
/// <para>
/// You can monitor the active URI by connecting to the notify::uri
/// signal of @resource.
/// </para>
/// </summary>

/// <param name="resource">
/// a #WebKitWebResource
/// </param>
/// <return>
/// the current active URI of @resource
/// </return>

	public static string GetUri(this MentorLake.WebKit2.WebKitWebResourceHandle resource)
	{
		if (resource.IsInvalid) throw new Exception("Invalid handle (WebKitWebResourceHandle)");
		return WebKitWebResourceHandleExterns.webkit_web_resource_get_uri(resource);
	}

}

internal class WebKitWebResourceHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_web_resource_get_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebResourceHandle>))] MentorLake.WebKit2.WebKitWebResourceHandle resource, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(WebKit2Library.Name)]
	internal static extern byte[] webkit_web_resource_get_data_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebResourceHandle>))] MentorLake.WebKit2.WebKitWebResourceHandle resource, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out UIntPtr length, out MentorLake.GLib.GErrorHandle error);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitURIResponseHandle>))]
	internal static extern MentorLake.WebKit2.WebKitURIResponseHandle webkit_web_resource_get_response([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebResourceHandle>))] MentorLake.WebKit2.WebKitWebResourceHandle resource);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_web_resource_get_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebResourceHandle>))] MentorLake.WebKit2.WebKitWebResourceHandle resource);

}
