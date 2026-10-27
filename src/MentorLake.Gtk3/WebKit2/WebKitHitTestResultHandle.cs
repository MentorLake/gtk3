namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Result of a Hit Test.
/// </para>
/// <para>
/// A Hit Test is an operation to get context information about a given
/// point in a #WebKitWebView. #WebKitHitTestResult represents the
/// result of a Hit Test. It provides context information about what is
/// at the coordinates of the Hit Test, such as if there&apos;s a link,
/// an image or a media.
/// </para>
/// <para>
/// You can get the context of the HitTestResult with
/// webkit_hit_test_result_get_context() that returns a bitmask of
/// #WebKitHitTestResultContext flags. You can also use
/// webkit_hit_test_result_context_is_link(), webkit_hit_test_result_context_is_image() and
/// webkit_hit_test_result_context_is_media() to determine whether there&apos;s
/// a link, image or a media element at the coordinates of the Hit Test.
/// Note that it&apos;s possible that several #WebKitHitTestResultContext flags
/// are active at the same time, for example if there&apos;s a link containing an image.
/// </para>
/// <para>
/// When the mouse is moved over a #WebKitWebView a Hit Test is performed
/// for the mouse coordinates and #WebKitWebView::mouse-target-changed
/// signal is emitted with a #WebKitHitTestResult.
/// </para>
/// </summary>

public class WebKitHitTestResultHandle : GObjectHandle
{
}

public static class WebKitHitTestResultHandleExtensions
{
/// <summary>
/// <para>
/// Gets whether %WEBKIT_HIT_TEST_RESULT_CONTEXT_EDITABLE flag is present in
/// #WebKitHitTestResult:context.
/// </para>
/// </summary>

/// <param name="hit_test_result">
/// a #WebKitHitTestResult
/// </param>
/// <return>
/// %TRUE if there&apos;s an editable element at the coordinates of the @hit_test_result,
///    or %FALSE otherwise
/// </return>

	public static bool ContextIsEditable(this MentorLake.WebKit2.WebKitHitTestResultHandle hit_test_result)
	{
		if (hit_test_result.IsInvalid) throw new Exception("Invalid handle (WebKitHitTestResultHandle)");
		return WebKitHitTestResultHandleExterns.webkit_hit_test_result_context_is_editable(hit_test_result);
	}

/// <summary>
/// <para>
/// Gets whether %WEBKIT_HIT_TEST_RESULT_CONTEXT_IMAGE flag is present in
/// #WebKitHitTestResult:context.
/// </para>
/// </summary>

/// <param name="hit_test_result">
/// a #WebKitHitTestResult
/// </param>
/// <return>
/// %TRUE if there&apos;s an image element in the coordinates of the Hit Test,
///    or %FALSE otherwise
/// </return>

	public static bool ContextIsImage(this MentorLake.WebKit2.WebKitHitTestResultHandle hit_test_result)
	{
		if (hit_test_result.IsInvalid) throw new Exception("Invalid handle (WebKitHitTestResultHandle)");
		return WebKitHitTestResultHandleExterns.webkit_hit_test_result_context_is_image(hit_test_result);
	}

/// <summary>
/// <para>
/// Gets whether %WEBKIT_HIT_TEST_RESULT_CONTEXT_LINK flag is present in
/// #WebKitHitTestResult:context.
/// </para>
/// </summary>

/// <param name="hit_test_result">
/// a #WebKitHitTestResult
/// </param>
/// <return>
/// %TRUE if there&apos;s a link element in the coordinates of the Hit Test,
///    or %FALSE otherwise
/// </return>

	public static bool ContextIsLink(this MentorLake.WebKit2.WebKitHitTestResultHandle hit_test_result)
	{
		if (hit_test_result.IsInvalid) throw new Exception("Invalid handle (WebKitHitTestResultHandle)");
		return WebKitHitTestResultHandleExterns.webkit_hit_test_result_context_is_link(hit_test_result);
	}

/// <summary>
/// <para>
/// Gets whether %WEBKIT_HIT_TEST_RESULT_CONTEXT_MEDIA flag is present in
/// #WebKitHitTestResult:context.
/// </para>
/// </summary>

/// <param name="hit_test_result">
/// a #WebKitHitTestResult
/// </param>
/// <return>
/// %TRUE if there&apos;s a media element in the coordinates of the Hit Test,
///    or %FALSE otherwise
/// </return>

	public static bool ContextIsMedia(this MentorLake.WebKit2.WebKitHitTestResultHandle hit_test_result)
	{
		if (hit_test_result.IsInvalid) throw new Exception("Invalid handle (WebKitHitTestResultHandle)");
		return WebKitHitTestResultHandleExterns.webkit_hit_test_result_context_is_media(hit_test_result);
	}

/// <summary>
/// <para>
/// Gets whether %WEBKIT_HIT_TEST_RESULT_CONTEXT_SCROLLBAR flag is present in
/// #WebKitHitTestResult:context.
/// </para>
/// </summary>

/// <param name="hit_test_result">
/// a #WebKitHitTestResult
/// </param>
/// <return>
/// %TRUE if there&apos;s a scrollbar element at the coordinates of the @hit_test_result,
///    or %FALSE otherwise
/// </return>

	public static bool ContextIsScrollbar(this MentorLake.WebKit2.WebKitHitTestResultHandle hit_test_result)
	{
		if (hit_test_result.IsInvalid) throw new Exception("Invalid handle (WebKitHitTestResultHandle)");
		return WebKitHitTestResultHandleExterns.webkit_hit_test_result_context_is_scrollbar(hit_test_result);
	}

/// <summary>
/// <para>
/// Gets whether %WEBKIT_HIT_TEST_RESULT_CONTEXT_SELECTION flag is present in
/// #WebKitHitTestResult:context.
/// </para>
/// </summary>

/// <param name="hit_test_result">
/// a #WebKitHitTestResult
/// </param>
/// <return>
/// %TRUE if there&apos;s a selected element at the coordinates of the @hit_test_result,
///    or %FALSE otherwise
/// </return>

	public static bool ContextIsSelection(this MentorLake.WebKit2.WebKitHitTestResultHandle hit_test_result)
	{
		if (hit_test_result.IsInvalid) throw new Exception("Invalid handle (WebKitHitTestResultHandle)");
		return WebKitHitTestResultHandleExterns.webkit_hit_test_result_context_is_selection(hit_test_result);
	}

/// <summary>
/// <para>
/// Gets the value of the #WebKitHitTestResult:context property.
/// </para>
/// </summary>

/// <param name="hit_test_result">
/// a #WebKitHitTestResult
/// </param>
/// <return>
/// a bitmask of #WebKitHitTestResultContext flags
/// </return>

	public static uint GetContext(this MentorLake.WebKit2.WebKitHitTestResultHandle hit_test_result)
	{
		if (hit_test_result.IsInvalid) throw new Exception("Invalid handle (WebKitHitTestResultHandle)");
		return WebKitHitTestResultHandleExterns.webkit_hit_test_result_get_context(hit_test_result);
	}

/// <summary>
/// <para>
/// Gets the value of the #WebKitHitTestResult:image-uri property.
/// </para>
/// </summary>

/// <param name="hit_test_result">
/// a #WebKitHitTestResult
/// </param>
/// <return>
/// the URI of the image element in the coordinates of the Hit Test,
///    or %NULL if there isn&apos;t an image element in @hit_test_result context
/// </return>

	public static string GetImageUri(this MentorLake.WebKit2.WebKitHitTestResultHandle hit_test_result)
	{
		if (hit_test_result.IsInvalid) throw new Exception("Invalid handle (WebKitHitTestResultHandle)");
		return WebKitHitTestResultHandleExterns.webkit_hit_test_result_get_image_uri(hit_test_result);
	}

/// <summary>
/// <para>
/// Gets the value of the #WebKitHitTestResult:link-label property.
/// </para>
/// </summary>

/// <param name="hit_test_result">
/// a #WebKitHitTestResult
/// </param>
/// <return>
/// the label of the link element in the coordinates of the Hit Test,
///    or %NULL if there isn&apos;t a link element in @hit_test_result context or the
///    link element doesn&apos;t have a label
/// </return>

	public static string GetLinkLabel(this MentorLake.WebKit2.WebKitHitTestResultHandle hit_test_result)
	{
		if (hit_test_result.IsInvalid) throw new Exception("Invalid handle (WebKitHitTestResultHandle)");
		return WebKitHitTestResultHandleExterns.webkit_hit_test_result_get_link_label(hit_test_result);
	}

/// <summary>
/// <para>
/// Gets the value of the #WebKitHitTestResult:link-title property.
/// </para>
/// </summary>

/// <param name="hit_test_result">
/// a #WebKitHitTestResult
/// </param>
/// <return>
/// the title of the link element in the coordinates of the Hit Test,
///    or %NULL if there isn&apos;t a link element in @hit_test_result context or the
///    link element doesn&apos;t have a title
/// </return>

	public static string GetLinkTitle(this MentorLake.WebKit2.WebKitHitTestResultHandle hit_test_result)
	{
		if (hit_test_result.IsInvalid) throw new Exception("Invalid handle (WebKitHitTestResultHandle)");
		return WebKitHitTestResultHandleExterns.webkit_hit_test_result_get_link_title(hit_test_result);
	}

/// <summary>
/// <para>
/// Gets the value of the #WebKitHitTestResult:link-uri property.
/// </para>
/// </summary>

/// <param name="hit_test_result">
/// a #WebKitHitTestResult
/// </param>
/// <return>
/// the URI of the link element in the coordinates of the Hit Test,
///    or %NULL if there isn&apos;t a link element in @hit_test_result context
/// </return>

	public static string GetLinkUri(this MentorLake.WebKit2.WebKitHitTestResultHandle hit_test_result)
	{
		if (hit_test_result.IsInvalid) throw new Exception("Invalid handle (WebKitHitTestResultHandle)");
		return WebKitHitTestResultHandleExterns.webkit_hit_test_result_get_link_uri(hit_test_result);
	}

/// <summary>
/// <para>
/// Gets the value of the #WebKitHitTestResult:media-uri property.
/// </para>
/// </summary>

/// <param name="hit_test_result">
/// a #WebKitHitTestResult
/// </param>
/// <return>
/// the URI of the media element in the coordinates of the Hit Test,
///    or %NULL if there isn&apos;t a media element in @hit_test_result context
/// </return>

	public static string GetMediaUri(this MentorLake.WebKit2.WebKitHitTestResultHandle hit_test_result)
	{
		if (hit_test_result.IsInvalid) throw new Exception("Invalid handle (WebKitHitTestResultHandle)");
		return WebKitHitTestResultHandleExterns.webkit_hit_test_result_get_media_uri(hit_test_result);
	}

}

internal class WebKitHitTestResultHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_hit_test_result_context_is_editable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitHitTestResultHandle>))] MentorLake.WebKit2.WebKitHitTestResultHandle hit_test_result);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_hit_test_result_context_is_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitHitTestResultHandle>))] MentorLake.WebKit2.WebKitHitTestResultHandle hit_test_result);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_hit_test_result_context_is_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitHitTestResultHandle>))] MentorLake.WebKit2.WebKitHitTestResultHandle hit_test_result);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_hit_test_result_context_is_media([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitHitTestResultHandle>))] MentorLake.WebKit2.WebKitHitTestResultHandle hit_test_result);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_hit_test_result_context_is_scrollbar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitHitTestResultHandle>))] MentorLake.WebKit2.WebKitHitTestResultHandle hit_test_result);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_hit_test_result_context_is_selection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitHitTestResultHandle>))] MentorLake.WebKit2.WebKitHitTestResultHandle hit_test_result);

	[DllImport(WebKit2Library.Name)]
	internal static extern uint webkit_hit_test_result_get_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitHitTestResultHandle>))] MentorLake.WebKit2.WebKitHitTestResultHandle hit_test_result);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_hit_test_result_get_image_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitHitTestResultHandle>))] MentorLake.WebKit2.WebKitHitTestResultHandle hit_test_result);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_hit_test_result_get_link_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitHitTestResultHandle>))] MentorLake.WebKit2.WebKitHitTestResultHandle hit_test_result);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_hit_test_result_get_link_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitHitTestResultHandle>))] MentorLake.WebKit2.WebKitHitTestResultHandle hit_test_result);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_hit_test_result_get_link_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitHitTestResultHandle>))] MentorLake.WebKit2.WebKitHitTestResultHandle hit_test_result);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_hit_test_result_get_media_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitHitTestResultHandle>))] MentorLake.WebKit2.WebKitHitTestResultHandle hit_test_result);

}
