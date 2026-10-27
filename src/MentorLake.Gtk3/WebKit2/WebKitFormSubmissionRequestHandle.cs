namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Represents a form submission request.
/// </para>
/// <para>
/// When a form is about to be submitted in a #WebKitWebView, the
/// #WebKitWebView::submit-form signal is emitted. Its request argument
/// contains information about the text fields of the form, that are
/// typically used to store login information, returned as lists by
/// webkit_form_submission_request_list_text_fields(). You can submit the
/// form with webkit_form_submission_request_submit().
/// </para>
/// </summary>

public class WebKitFormSubmissionRequestHandle : GObjectHandle
{
}

public static class WebKitFormSubmissionRequestHandleExtensions
{
/// <summary>
/// <para>
/// Get the values of the text fields contained in the form associated to @request.
/// </para>
/// <para>
/// Get a #GHashTable with the values of the text fields contained in the form
/// associated to @request. Note that fields will be missing if the form
/// contains multiple text input elements with the same name, so this
/// function does not reliably return all text fields.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitFormSubmissionRequest
/// </param>
/// <return>
/// a #GHashTable with the form
///    text fields, or %NULL if the form doesn&apos;t contain text fields.
/// </return>

	public static MentorLake.GLib.GHashTableHandle GetTextFields(this MentorLake.WebKit2.WebKitFormSubmissionRequestHandle request)
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitFormSubmissionRequestHandle)");
		return WebKitFormSubmissionRequestHandleExterns.webkit_form_submission_request_get_text_fields(request);
	}

/// <summary>
/// <para>
/// Get lists of the text fields contained in the form associated to @request.
/// </para>
/// <para>
/// Get lists with the names and values of the text fields contained in
/// the form associated to @request. Note that names and values may be
/// %NULL.
/// </para>
/// <para>
/// If this function returns %FALSE, then both @field_names and
/// @field_values will be empty.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitFormSubmissionRequest
/// </param>
/// <param name="field_names">
/// 
///    names of the text fields in the form
/// </param>
/// <param name="field_values">
/// 
///    values of the text fields in the form
/// </param>
/// <return>
/// %TRUE if the form contains text fields, or %FALSE otherwise
/// </return>

	public static bool ListTextFields(this MentorLake.WebKit2.WebKitFormSubmissionRequestHandle request, out MentorLake.GLib.GPtrArrayHandle field_names, out MentorLake.GLib.GPtrArrayHandle field_values)
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitFormSubmissionRequestHandle)");
		return WebKitFormSubmissionRequestHandleExterns.webkit_form_submission_request_list_text_fields(request, out field_names, out field_values);
	}

/// <summary>
/// <para>
/// Continue the form submission.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitFormSubmissionRequest
/// </param>

	public static T Submit<T>(this T request) where T : WebKitFormSubmissionRequestHandle
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitFormSubmissionRequestHandle)");
		WebKitFormSubmissionRequestHandleExterns.webkit_form_submission_request_submit(request);
		return request;
	}

}

internal class WebKitFormSubmissionRequestHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))]
	internal static extern MentorLake.GLib.GHashTableHandle webkit_form_submission_request_get_text_fields([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFormSubmissionRequestHandle>))] MentorLake.WebKit2.WebKitFormSubmissionRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_form_submission_request_list_text_fields([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFormSubmissionRequestHandle>))] MentorLake.WebKit2.WebKitFormSubmissionRequestHandle request, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] out MentorLake.GLib.GPtrArrayHandle field_names, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] out MentorLake.GLib.GPtrArrayHandle field_values);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_form_submission_request_submit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFormSubmissionRequestHandle>))] MentorLake.WebKit2.WebKitFormSubmissionRequestHandle request);

}
