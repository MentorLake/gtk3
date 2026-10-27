namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// A request to open a file chooser.
/// </para>
/// <para>
/// Whenever the user interacts with an HTML input element with
/// file type, WebKit will need to show a dialog to choose one or
/// more files to be uploaded to the server along with the rest of the
/// form data. For that to happen in a general way, instead of just
/// opening a #GtkFileChooserDialog (which might be not desirable in
/// some cases, which could prefer to use their own file chooser
/// dialog), WebKit will fire the #WebKitWebView::run-file-chooser
/// signal with a #WebKitFileChooserRequest object, which will allow
/// the client application to specify the files to be selected, to
/// inspect the details of the request (e.g. if multiple selection
/// should be allowed) and to cancel the request, in case nothing was
/// selected.
/// </para>
/// <para>
/// In case the client application does not wish to handle this signal,
/// WebKit will provide a default handler which will asynchronously run
/// a regular #GtkFileChooserDialog for the user to interact with.
/// </para>
/// </summary>

public class WebKitFileChooserRequestHandle : GObjectHandle
{
}

public static class WebKitFileChooserRequestHandleExtensions
{
/// <summary>
/// <para>
/// Ask WebKit to cancel the request.
/// </para>
/// <para>
/// It&apos;s important to do this in case
/// no selection has been made in the client, otherwise the request
/// won&apos;t be properly completed and the browser will keep the request
/// pending forever, which might cause the browser to hang.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitFileChooserRequest
/// </param>

	public static T Cancel<T>(this T request) where T : WebKitFileChooserRequestHandle
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitFileChooserRequestHandle)");
		WebKitFileChooserRequestHandleExterns.webkit_file_chooser_request_cancel(request);
		return request;
	}

/// <summary>
/// <para>
/// Get the list of MIME types the file chooser dialog should handle.
/// </para>
/// <para>
/// Get the list of MIME types the file chooser dialog should handle,
/// in the format specified in RFC 2046 for &quot;media types&quot;. Its contents
/// depend on the value of the &apos;accept&apos; attribute for HTML input
/// elements. This function should normally be called before presenting
/// the file chooser dialog to the user, to decide whether to allow the
/// user to select multiple files at once or only one.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitFileChooserRequest
/// </param>
/// <return>
/// a
/// %NULL-terminated array of strings if a list of accepted MIME types
/// is defined or %NULL otherwise, meaning that any MIME type should be
/// accepted. This array and its contents are owned by WebKit and
/// should not be modified or freed.
/// </return>

	public static string[] GetMimeTypes(this MentorLake.WebKit2.WebKitFileChooserRequestHandle request)
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitFileChooserRequestHandle)");
		return WebKitFileChooserRequestHandleExterns.webkit_file_chooser_request_get_mime_types(request);
	}

/// <summary>
/// <para>
/// Get the filter currently associated with the request.
/// </para>
/// <para>
/// Get the filter currently associated with the request, ready to be
/// used by #GtkFileChooser. This function should normally be called
/// before presenting the file chooser dialog to the user, to decide
/// whether to apply a filter so the user would not be allowed to
/// select files with other MIME types.
/// </para>
/// <para>
/// See webkit_file_chooser_request_get_mime_types() if you are
/// interested in getting the list of accepted MIME types.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitFileChooserRequest
/// </param>
/// <return>
/// a #GtkFileFilter if a list of accepted
/// MIME types is defined or %NULL otherwise. The returned object is
/// owned by WebKit should not be modified or freed.
/// </return>

	public static MentorLake.Gtk.GtkFileFilterHandle GetMimeTypesFilter(this MentorLake.WebKit2.WebKitFileChooserRequestHandle request)
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitFileChooserRequestHandle)");
		return WebKitFileChooserRequestHandleExterns.webkit_file_chooser_request_get_mime_types_filter(request);
	}

/// <summary>
/// <para>
/// Whether the file chooser should allow selecting multiple files.
/// </para>
/// <para>
/// Determine whether the file chooser associated to this
/// #WebKitFileChooserRequest should allow selecting multiple files,
/// which depends on the HTML input element having a &apos;multiple&apos;
/// attribute defined.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitFileChooserRequest
/// </param>
/// <return>
/// %TRUE if the file chooser should allow selecting multiple files or %FALSE otherwise.
/// </return>

	public static bool GetSelectMultiple(this MentorLake.WebKit2.WebKitFileChooserRequestHandle request)
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitFileChooserRequestHandle)");
		return WebKitFileChooserRequestHandleExterns.webkit_file_chooser_request_get_select_multiple(request);
	}

/// <summary>
/// <para>
/// Get the list of selected files associated to the request.
/// </para>
/// <para>
/// Get the list of selected files currently associated to the
/// request. Initially, the return value of this method contains any
/// files selected in previous file chooser requests for this HTML
/// input element. Once webkit_file_chooser_request_select_files, the
/// value will reflect whatever files are given.
/// </para>
/// <para>
/// This function should normally be called only before presenting the
/// file chooser dialog to the user, to decide whether to perform some
/// extra action, like pre-selecting the files from a previous request.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitFileChooserRequest
/// </param>
/// <return>
/// a
/// %NULL-terminated array of strings if there are selected files
/// associated with the request or %NULL otherwise. This array and its
/// contents are owned by WebKit and should not be modified or
/// freed.
/// </return>

	public static string[] GetSelectedFiles(this MentorLake.WebKit2.WebKitFileChooserRequestHandle request)
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitFileChooserRequestHandle)");
		return WebKitFileChooserRequestHandleExterns.webkit_file_chooser_request_get_selected_files(request);
	}

/// <summary>
/// <para>
/// Ask WebKit to select local files for upload and complete the
/// request.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitFileChooserRequest
/// </param>
/// <param name="files">
/// a
/// %NULL-terminated array of strings, containing paths to local files.
/// </param>

	public static T SelectFiles<T>(this T request, string[] files) where T : WebKitFileChooserRequestHandle
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitFileChooserRequestHandle)");
		WebKitFileChooserRequestHandleExterns.webkit_file_chooser_request_select_files(request, files);
		return request;
	}

}

internal class WebKitFileChooserRequestHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_file_chooser_request_cancel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFileChooserRequestHandle>))] MentorLake.WebKit2.WebKitFileChooserRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] webkit_file_chooser_request_get_mime_types([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFileChooserRequestHandle>))] MentorLake.WebKit2.WebKitFileChooserRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileFilterHandle>))]
	internal static extern MentorLake.Gtk.GtkFileFilterHandle webkit_file_chooser_request_get_mime_types_filter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFileChooserRequestHandle>))] MentorLake.WebKit2.WebKitFileChooserRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_file_chooser_request_get_select_multiple([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFileChooserRequestHandle>))] MentorLake.WebKit2.WebKitFileChooserRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] webkit_file_chooser_request_get_selected_files([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFileChooserRequestHandle>))] MentorLake.WebKit2.WebKitFileChooserRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_file_chooser_request_select_files([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFileChooserRequestHandle>))] MentorLake.WebKit2.WebKitFileChooserRequestHandle request, string[] files);

}
