namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Object used to communicate with the application when downloading.
/// </para>
/// <para>
/// #WebKitDownload carries information about a download request and
/// response, including a #WebKitURIRequest and a #WebKitURIResponse
/// objects. The application may use this object to control the
/// download process, or to simply figure out what is to be downloaded,
/// and handle the download process itself.
/// </para>
/// </summary>

public class WebKitDownloadHandle : GObjectHandle
{
}
public static class WebKitDownloadHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted after #WebKitDownload::decide-destination and before
/// #WebKitDownload::received-data to notify that destination file has been
/// created successfully at @destination.
/// </para>
/// </summary>

	public static IObservable<WebKitDownloadHandleSignalStructs.CreatedDestinationSignal> Signal_CreatedDestination(this WebKitDownloadHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitDownloadHandleSignalStructs.CreatedDestinationSignal> obs) =>
		{
			WebKitDownloadHandleSignalDelegates.created_destination handler = ( MentorLake.WebKit2.WebKitDownloadHandle self,  string destination,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitDownloadHandleSignalStructs.CreatedDestinationSignal()
				{
					Self = self, Destination = destination, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "created-destination", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted after response is received to
/// decide a destination for the download using
/// webkit_download_set_destination(). If this signal is not
/// handled, the file will be downloaded to %G_USER_DIRECTORY_DOWNLOAD
/// directory using @suggested_filename.
/// </para>
/// <para>
/// Since 2.40, you may handle this signal asynchronously by
/// returning %TRUE without calling webkit_download_set_destination().
/// This indicates intent to eventually call webkit_download_set_destination().
/// In this case, the download will not proceed until the destination is set
/// or cancelled with webkit_download_cancel().
/// </para>
/// </summary>

	public static IObservable<WebKitDownloadHandleSignalStructs.DecideDestinationSignal> Signal_DecideDestination(this WebKitDownloadHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitDownloadHandleSignalStructs.DecideDestinationSignal> obs) =>
		{
			WebKitDownloadHandleSignalDelegates.decide_destination handler = ( MentorLake.WebKit2.WebKitDownloadHandle self,  string suggested_filename,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitDownloadHandleSignalStructs.DecideDestinationSignal()
				{
					Self = self, SuggestedFilename = suggested_filename, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "decide-destination", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted when an error occurs during the download
/// operation. The given @error, of the domain %WEBKIT_DOWNLOAD_ERROR,
/// contains further details of the failure. If the download is cancelled
/// with webkit_download_cancel(), this signal is emitted with error
/// %WEBKIT_DOWNLOAD_ERROR_CANCELLED_BY_USER. The download operation finishes
/// after an error and #WebKitDownload::finished signal is emitted after this one.
/// </para>
/// </summary>

	public static IObservable<WebKitDownloadHandleSignalStructs.FailedSignal> Signal_Failed(this WebKitDownloadHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitDownloadHandleSignalStructs.FailedSignal> obs) =>
		{
			WebKitDownloadHandleSignalDelegates.failed handler = ( MentorLake.WebKit2.WebKitDownloadHandle self,  MentorLake.GLib.GErrorHandle error,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitDownloadHandleSignalStructs.FailedSignal()
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
/// This signal is emitted when download finishes successfully or due to an error.
/// In case of errors #WebKitDownload::failed signal is emitted before this one.
/// </para>
/// </summary>

	public static IObservable<WebKitDownloadHandleSignalStructs.FinishedSignal> Signal_Finished(this WebKitDownloadHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitDownloadHandleSignalStructs.FinishedSignal> obs) =>
		{
			WebKitDownloadHandleSignalDelegates.finished handler = ( MentorLake.WebKit2.WebKitDownloadHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitDownloadHandleSignalStructs.FinishedSignal()
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
/// every time new data has been written to the destination. It&apos;s
/// useful to know the progress of the download operation.
/// </para>
/// </summary>

	public static IObservable<WebKitDownloadHandleSignalStructs.ReceivedDataSignal> Signal_ReceivedData(this WebKitDownloadHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitDownloadHandleSignalStructs.ReceivedDataSignal> obs) =>
		{
			WebKitDownloadHandleSignalDelegates.received_data handler = ( MentorLake.WebKit2.WebKitDownloadHandle self,  ulong data_length,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitDownloadHandleSignalStructs.ReceivedDataSignal()
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
}

public static class WebKitDownloadHandleSignalStructs
{

public class CreatedDestinationSignal
{

	public MentorLake.WebKit2.WebKitDownloadHandle Self;
/// <summary>
/// <para>
/// the destination
/// </para>
/// </summary>

	public string Destination;

	public IntPtr UserData;
}

public class DecideDestinationSignal
{

	public MentorLake.WebKit2.WebKitDownloadHandle Self;
/// <summary>
/// <para>
/// the filename suggested for the download
/// </para>
/// </summary>

	public string SuggestedFilename;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the event,
///   or %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class FailedSignal
{

	public MentorLake.WebKit2.WebKitDownloadHandle Self;
/// <summary>
/// <para>
/// the #GError that was triggered
/// </para>
/// </summary>

	public MentorLake.GLib.GErrorHandle Error;

	public IntPtr UserData;
}

public class FinishedSignal
{

	public MentorLake.WebKit2.WebKitDownloadHandle Self;

	public IntPtr UserData;
}

public class ReceivedDataSignal
{

	public MentorLake.WebKit2.WebKitDownloadHandle Self;
/// <summary>
/// <para>
/// the length of data received in bytes
/// </para>
/// </summary>

	public ulong DataLength;

	public IntPtr UserData;
}
}

public static class WebKitDownloadHandleSignalDelegates
{

/// <summary>
/// <para>
/// This signal is emitted after #WebKitDownload::decide-destination and before
/// #WebKitDownload::received-data to notify that destination file has been
/// created successfully at @destination.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="destination">
/// the destination
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void created_destination([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitDownloadHandle>))] MentorLake.WebKit2.WebKitDownloadHandle self, string destination, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted after response is received to
/// decide a destination for the download using
/// webkit_download_set_destination(). If this signal is not
/// handled, the file will be downloaded to %G_USER_DIRECTORY_DOWNLOAD
/// directory using @suggested_filename.
/// </para>
/// <para>
/// Since 2.40, you may handle this signal asynchronously by
/// returning %TRUE without calling webkit_download_set_destination().
/// This indicates intent to eventually call webkit_download_set_destination().
/// In this case, the download will not proceed until the destination is set
/// or cancelled with webkit_download_cancel().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="suggested_filename">
/// the filename suggested for the download
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the event,
///   or %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool decide_destination([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitDownloadHandle>))] MentorLake.WebKit2.WebKitDownloadHandle self, string suggested_filename, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when an error occurs during the download
/// operation. The given @error, of the domain %WEBKIT_DOWNLOAD_ERROR,
/// contains further details of the failure. If the download is cancelled
/// with webkit_download_cancel(), this signal is emitted with error
/// %WEBKIT_DOWNLOAD_ERROR_CANCELLED_BY_USER. The download operation finishes
/// after an error and #WebKitDownload::finished signal is emitted after this one.
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
public delegate void failed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitDownloadHandle>))] MentorLake.WebKit2.WebKitDownloadHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when download finishes successfully or due to an error.
/// In case of errors #WebKitDownload::failed signal is emitted before this one.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void finished([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitDownloadHandle>))] MentorLake.WebKit2.WebKitDownloadHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted after response is received,
/// every time new data has been written to the destination. It&apos;s
/// useful to know the progress of the download operation.
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
public delegate void received_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitDownloadHandle>))] MentorLake.WebKit2.WebKitDownloadHandle self, ulong data_length, IntPtr user_data);

}


public static class WebKitDownloadHandleExtensions
{
/// <summary>
/// <para>
/// Cancels the download.
/// </para>
/// <para>
/// When the ongoing download
/// operation is effectively cancelled the signal
/// #WebKitDownload::failed is emitted with
/// %WEBKIT_DOWNLOAD_ERROR_CANCELLED_BY_USER error.
/// </para>
/// </summary>

/// <param name="download">
/// a #WebKitDownload
/// </param>

	public static T Cancel<T>(this T download) where T : WebKitDownloadHandle
	{
		if (download.IsInvalid) throw new Exception("Invalid handle (WebKitDownloadHandle)");
		WebKitDownloadHandleExterns.webkit_download_cancel(download);
		return download;
	}

/// <summary>
/// <para>
/// Returns the current value of the #WebKitDownload:allow-overwrite property.
/// </para>
/// <para>
/// Returns the current value of the #WebKitDownload:allow-overwrite property,
/// which determines whether the download will overwrite an existing file on
/// disk, or if it will fail if the destination already exists.
/// </para>
/// </summary>

/// <param name="download">
/// a #WebKitDownload
/// </param>
/// <return>
/// the current value of the #WebKitDownload:allow-overwrite property
/// </return>

	public static bool GetAllowOverwrite(this MentorLake.WebKit2.WebKitDownloadHandle download)
	{
		if (download.IsInvalid) throw new Exception("Invalid handle (WebKitDownloadHandle)");
		return WebKitDownloadHandleExterns.webkit_download_get_allow_overwrite(download);
	}

/// <summary>
/// <para>
/// Obtains the destination to which the downloaded file will be written.
/// </para>
/// <para>
/// You can connect to #WebKitDownload::created-destination to make
/// sure this method returns a valid destination.
/// </para>
/// </summary>

/// <param name="download">
/// a #WebKitDownload
/// </param>
/// <return>
/// the destination or %NULL
/// </return>

	public static string GetDestination(this MentorLake.WebKit2.WebKitDownloadHandle download)
	{
		if (download.IsInvalid) throw new Exception("Invalid handle (WebKitDownloadHandle)");
		return WebKitDownloadHandleExterns.webkit_download_get_destination(download);
	}

/// <summary>
/// <para>
/// Gets the elapsed time in seconds, including any fractional part.
/// </para>
/// <para>
/// If the download finished, had an error or was cancelled this is
/// the time between its start and the event.
/// </para>
/// </summary>

/// <param name="download">
/// a #WebKitDownload
/// </param>
/// <return>
/// seconds since the download was started
/// </return>

	public static double GetElapsedTime(this MentorLake.WebKit2.WebKitDownloadHandle download)
	{
		if (download.IsInvalid) throw new Exception("Invalid handle (WebKitDownloadHandle)");
		return WebKitDownloadHandleExterns.webkit_download_get_elapsed_time(download);
	}

/// <summary>
/// <para>
/// Gets the value of the #WebKitDownload:estimated-progress property.
/// Gets the value of the #WebKitDownload:estimated-progress property.
/// You can monitor the estimated progress of the download operation by
/// connecting to the notify::estimated-progress signal of @download.
/// </para>
/// </summary>

/// <param name="download">
/// a #WebKitDownload
/// </param>
/// <return>
/// an estimate of the of the percent complete for a download
///     as a range from 0.0 to 1.0.
/// </return>

	public static double GetEstimatedProgress(this MentorLake.WebKit2.WebKitDownloadHandle download)
	{
		if (download.IsInvalid) throw new Exception("Invalid handle (WebKitDownloadHandle)");
		return WebKitDownloadHandleExterns.webkit_download_get_estimated_progress(download);
	}

/// <summary>
/// <para>
/// Gets the length of the data already downloaded for @download.
/// </para>
/// <para>
/// Gets the length of the data already downloaded for @download
/// in bytes.
/// </para>
/// </summary>

/// <param name="download">
/// a #WebKitDownload
/// </param>
/// <return>
/// the amount of bytes already downloaded.
/// </return>

	public static ulong GetReceivedDataLength(this MentorLake.WebKit2.WebKitDownloadHandle download)
	{
		if (download.IsInvalid) throw new Exception("Invalid handle (WebKitDownloadHandle)");
		return WebKitDownloadHandleExterns.webkit_download_get_received_data_length(download);
	}

/// <summary>
/// <para>
/// Retrieves the #WebKitURIRequest object that backs the download
/// process.
/// </para>
/// </summary>

/// <param name="download">
/// a #WebKitDownload
/// </param>
/// <return>
/// the #WebKitURIRequest of @download
/// </return>

	public static MentorLake.WebKit2.WebKitURIRequestHandle GetRequest(this MentorLake.WebKit2.WebKitDownloadHandle download)
	{
		if (download.IsInvalid) throw new Exception("Invalid handle (WebKitDownloadHandle)");
		return WebKitDownloadHandleExterns.webkit_download_get_request(download);
	}

/// <summary>
/// <para>
/// Retrieves the #WebKitURIResponse object that backs the download process.
/// </para>
/// <para>
/// Retrieves the #WebKitURIResponse object that backs the download
/// process. This method returns %NULL if called before the response
/// is received from the server. You can connect to notify::response
/// signal to be notified when the response is received.
/// </para>
/// </summary>

/// <param name="download">
/// a #WebKitDownload
/// </param>
/// <return>
/// the #WebKitURIResponse, or %NULL if
///     the response hasn&apos;t been received yet.
/// </return>

	public static MentorLake.WebKit2.WebKitURIResponseHandle GetResponse(this MentorLake.WebKit2.WebKitDownloadHandle download)
	{
		if (download.IsInvalid) throw new Exception("Invalid handle (WebKitDownloadHandle)");
		return WebKitDownloadHandleExterns.webkit_download_get_response(download);
	}

/// <summary>
/// <para>
/// Get the #WebKitWebView that initiated the download.
/// </para>
/// </summary>

/// <param name="download">
/// a #WebKitDownload
/// </param>
/// <return>
/// the #WebKitWebView that initiated @download,
///    or %NULL if @download was not initiated by a #WebKitWebView.
/// </return>

	public static MentorLake.WebKit2.WebKitWebViewHandle GetWebView(this MentorLake.WebKit2.WebKitDownloadHandle download)
	{
		if (download.IsInvalid) throw new Exception("Invalid handle (WebKitDownloadHandle)");
		return WebKitDownloadHandleExterns.webkit_download_get_web_view(download);
	}

/// <summary>
/// <para>
/// Sets the #WebKitDownload:allow-overwrite property.
/// </para>
/// <para>
/// Sets the #WebKitDownload:allow-overwrite property, which determines whether
/// the download may overwrite an existing file on disk, or if it will fail if
/// the destination already exists.
/// </para>
/// </summary>

/// <param name="download">
/// a #WebKitDownload
/// </param>
/// <param name="allowed">
/// the new value for the #WebKitDownload:allow-overwrite property
/// </param>

	public static T SetAllowOverwrite<T>(this T download, bool allowed) where T : WebKitDownloadHandle
	{
		if (download.IsInvalid) throw new Exception("Invalid handle (WebKitDownloadHandle)");
		WebKitDownloadHandleExterns.webkit_download_set_allow_overwrite(download, allowed);
		return download;
	}

/// <summary>
/// <para>
/// Sets the destination to which the downloaded file will be written.
/// </para>
/// <para>
/// This method should be called before the download transfer
/// starts or it will not have any effect on the ongoing download
/// operation. To set the destination using the filename suggested
/// by the server connect to #WebKitDownload::decide-destination
/// signal and call webkit_download_set_destination(). If you want to
/// set a fixed destination that doesn&apos;t depend on the suggested
/// filename you can connect to notify::response signal and call
/// webkit_download_set_destination().
/// </para>
/// <para>
/// If #WebKitDownload::decide-destination signal is not handled
/// and destination is not set when the download transfer starts,
/// the file will be saved with the filename suggested by the server in
/// %G_USER_DIRECTORY_DOWNLOAD directory.
/// </para>
/// </summary>

/// <param name="download">
/// a #WebKitDownload
/// </param>
/// <param name="destination">
/// the destination
/// </param>

	public static T SetDestination<T>(this T download, string destination) where T : WebKitDownloadHandle
	{
		if (download.IsInvalid) throw new Exception("Invalid handle (WebKitDownloadHandle)");
		WebKitDownloadHandleExterns.webkit_download_set_destination(download, destination);
		return download;
	}

}

internal class WebKitDownloadHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_download_cancel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitDownloadHandle>))] MentorLake.WebKit2.WebKitDownloadHandle download);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_download_get_allow_overwrite([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitDownloadHandle>))] MentorLake.WebKit2.WebKitDownloadHandle download);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_download_get_destination([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitDownloadHandle>))] MentorLake.WebKit2.WebKitDownloadHandle download);

	[DllImport(WebKit2Library.Name)]
	internal static extern double webkit_download_get_elapsed_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitDownloadHandle>))] MentorLake.WebKit2.WebKitDownloadHandle download);

	[DllImport(WebKit2Library.Name)]
	internal static extern double webkit_download_get_estimated_progress([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitDownloadHandle>))] MentorLake.WebKit2.WebKitDownloadHandle download);

	[DllImport(WebKit2Library.Name)]
	internal static extern ulong webkit_download_get_received_data_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitDownloadHandle>))] MentorLake.WebKit2.WebKitDownloadHandle download);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitURIRequestHandle>))]
	internal static extern MentorLake.WebKit2.WebKitURIRequestHandle webkit_download_get_request([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitDownloadHandle>))] MentorLake.WebKit2.WebKitDownloadHandle download);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitURIResponseHandle>))]
	internal static extern MentorLake.WebKit2.WebKitURIResponseHandle webkit_download_get_response([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitDownloadHandle>))] MentorLake.WebKit2.WebKitDownloadHandle download);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))]
	internal static extern MentorLake.WebKit2.WebKitWebViewHandle webkit_download_get_web_view([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitDownloadHandle>))] MentorLake.WebKit2.WebKitDownloadHandle download);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_download_set_allow_overwrite([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitDownloadHandle>))] MentorLake.WebKit2.WebKitDownloadHandle download, bool allowed);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_download_set_destination([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitDownloadHandle>))] MentorLake.WebKit2.WebKitDownloadHandle download, string destination);

}
