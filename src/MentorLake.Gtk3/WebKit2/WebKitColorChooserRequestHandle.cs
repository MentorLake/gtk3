namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// A request to open a color chooser.
/// </para>
/// <para>
/// Whenever the user interacts with an &amp;lt;input type=&apos;color&apos; /&amp;gt;
/// HTML element, WebKit will need to show a dialog to choose a color. For that
/// to happen in a general way, instead of just opening a #GtkColorChooser
/// (which might be not desirable in some cases, which could prefer to use their
/// own color chooser dialog), WebKit will fire the
/// #WebKitWebView::run-color-chooser signal with a #WebKitColorChooserRequest
/// object, which will allow the client application to specify the color to be
/// selected, to inspect the details of the request (e.g. to get initial color)
/// and to cancel the request, in case nothing was selected.
/// </para>
/// <para>
/// In case the client application does not wish to handle this signal,
/// WebKit will provide a default handler which will asynchronously run
/// a regular #GtkColorChooserDialog for the user to interact with.
/// </para>
/// </summary>

public class WebKitColorChooserRequestHandle : GObjectHandle
{
}
public static class WebKitColorChooserRequestHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when the @request finishes. This signal can be emitted because the
/// user completed the @request calling webkit_color_chooser_request_finish(),
/// or cancelled it with webkit_color_chooser_request_cancel() or because the
/// color input element is removed from the DOM.
/// </para>
/// </summary>

	public static IObservable<WebKitColorChooserRequestHandleSignalStructs.FinishedSignal> Signal_Finished(this WebKitColorChooserRequestHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitColorChooserRequestHandleSignalStructs.FinishedSignal> obs) =>
		{
			WebKitColorChooserRequestHandleSignalDelegates.finished handler = ( MentorLake.WebKit2.WebKitColorChooserRequestHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitColorChooserRequestHandleSignalStructs.FinishedSignal()
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
}

public static class WebKitColorChooserRequestHandleSignalStructs
{

public class FinishedSignal
{

	public MentorLake.WebKit2.WebKitColorChooserRequestHandle Self;

	public IntPtr UserData;
}
}

public static class WebKitColorChooserRequestHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted when the @request finishes. This signal can be emitted because the
/// user completed the @request calling webkit_color_chooser_request_finish(),
/// or cancelled it with webkit_color_chooser_request_cancel() or because the
/// color input element is removed from the DOM.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void finished([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitColorChooserRequestHandle>))] MentorLake.WebKit2.WebKitColorChooserRequestHandle self, IntPtr user_data);

}


public static class WebKitColorChooserRequestHandleExtensions
{
/// <summary>
/// <para>
/// Cancels @request and the input element changes to use the initial color.
/// </para>
/// <para>
/// Cancels @request and the input element changes to use the initial color
/// it has before the request started.
/// The signal #WebKitColorChooserRequest::finished
/// is emitted to notify that the request has finished.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitColorChooserRequest
/// </param>

	public static T Cancel<T>(this T request) where T : WebKitColorChooserRequestHandle
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitColorChooserRequestHandle)");
		WebKitColorChooserRequestHandleExterns.webkit_color_chooser_request_cancel(request);
		return request;
	}

/// <summary>
/// <para>
/// Finishes @request and the input element keeps the current value of
/// #WebKitColorChooserRequest:rgba.
/// </para>
/// <para>
/// Finishes @request and the input element keeps the current value of
/// #WebKitColorChooserRequest:rgba.
/// The signal #WebKitColorChooserRequest::finished
/// is emitted to notify that the request has finished.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitColorChooserRequest
/// </param>

	public static T Finish<T>(this T request) where T : WebKitColorChooserRequestHandle
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitColorChooserRequestHandle)");
		WebKitColorChooserRequestHandleExterns.webkit_color_chooser_request_finish(request);
		return request;
	}

/// <summary>
/// <para>
/// Gets the bounding box of the color input element.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitColorChooserRequest
/// </param>
/// <param name="rect">
/// a #GdkRectangle to fill in with the element area
/// </param>

	public static T GetElementRectangle<T>(this T request, out MentorLake.Gdk.GdkRectangle rect) where T : WebKitColorChooserRequestHandle
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitColorChooserRequestHandle)");
		WebKitColorChooserRequestHandleExterns.webkit_color_chooser_request_get_element_rectangle(request, out rect);
		return request;
	}

/// <summary>
/// <para>
/// Gets the current #GdkRGBA color of @request
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitColorChooserRequest
/// </param>
/// <param name="rgba">
/// a #GdkRGBA to fill in with the current color.
/// </param>

	public static T GetRgba<T>(this T request, out MentorLake.Gdk.GdkRGBA rgba) where T : WebKitColorChooserRequestHandle
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitColorChooserRequestHandle)");
		WebKitColorChooserRequestHandleExterns.webkit_color_chooser_request_get_rgba(request, out rgba);
		return request;
	}

/// <summary>
/// <para>
/// Sets the current #GdkRGBA color of @request
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitFileChooserRequest
/// </param>
/// <param name="rgba">
/// a pointer #GdkRGBA
/// </param>

	public static T SetRgba<T>(this T request, MentorLake.Gdk.GdkRGBAHandle rgba) where T : WebKitColorChooserRequestHandle
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitColorChooserRequestHandle)");
		WebKitColorChooserRequestHandleExterns.webkit_color_chooser_request_set_rgba(request, rgba);
		return request;
	}

}

internal class WebKitColorChooserRequestHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_color_chooser_request_cancel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitColorChooserRequestHandle>))] MentorLake.WebKit2.WebKitColorChooserRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_color_chooser_request_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitColorChooserRequestHandle>))] MentorLake.WebKit2.WebKitColorChooserRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_color_chooser_request_get_element_rectangle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitColorChooserRequestHandle>))] MentorLake.WebKit2.WebKitColorChooserRequestHandle request, out MentorLake.Gdk.GdkRectangle rect);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_color_chooser_request_get_rgba([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitColorChooserRequestHandle>))] MentorLake.WebKit2.WebKitColorChooserRequestHandle request, out MentorLake.Gdk.GdkRGBA rgba);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_color_chooser_request_set_rgba([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitColorChooserRequestHandle>))] MentorLake.WebKit2.WebKitColorChooserRequestHandle request, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle rgba);

}
