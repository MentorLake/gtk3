namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// A policy decision for resource responses.
/// </para>
/// <para>
/// WebKitResponsePolicyDecision represents a policy decision for a
/// resource response, whether from the network or the local system.
/// A very common use case for these types of decision is deciding
/// whether or not to download a particular resource or to load it
/// normally.
/// </para>
/// </summary>

public class WebKitResponsePolicyDecisionHandle : WebKitPolicyDecisionHandle
{
}

public static class WebKitResponsePolicyDecisionHandleExtensions
{
/// <summary>
/// <para>
/// Return the #WebKitURIRequest associated with the response decision.
/// </para>
/// <para>
/// Modifications to the returned object are &amp;lt;emphasis&amp;gt;not&amp;lt;/emphasis&amp;gt; taken
/// into account when the request is sent over the network, and is intended
/// only to aid in evaluating whether a response decision should be taken or
/// not. To modify requests before they are sent over the network the
/// #WebKitPage::send-request signal can be used instead.
/// </para>
/// </summary>

/// <param name="decision">
/// a #WebKitResponsePolicyDecision
/// </param>
/// <return>
/// The URI request that is associated with this policy decision.
/// </return>

	public static MentorLake.WebKit2.WebKitURIRequestHandle GetRequest(this MentorLake.WebKit2.WebKitResponsePolicyDecisionHandle decision)
	{
		if (decision.IsInvalid) throw new Exception("Invalid handle (WebKitResponsePolicyDecisionHandle)");
		return WebKitResponsePolicyDecisionHandleExterns.webkit_response_policy_decision_get_request(decision);
	}

/// <summary>
/// <para>
/// Gets the value of the #WebKitResponsePolicyDecision:response property.
/// </para>
/// </summary>

/// <param name="decision">
/// a #WebKitResponsePolicyDecision
/// </param>
/// <return>
/// The URI response that is associated with this policy decision.
/// </return>

	public static MentorLake.WebKit2.WebKitURIResponseHandle GetResponse(this MentorLake.WebKit2.WebKitResponsePolicyDecisionHandle decision)
	{
		if (decision.IsInvalid) throw new Exception("Invalid handle (WebKitResponsePolicyDecisionHandle)");
		return WebKitResponsePolicyDecisionHandleExterns.webkit_response_policy_decision_get_response(decision);
	}

/// <summary>
/// <para>
/// Gets whether the request is the main frame main resource
/// </para>
/// </summary>

/// <param name="decision">
/// a #WebKitResponsePolicyDecision
/// </param>
/// <return>
/// %TRUE if the request is the main frame main resouce or %FALSE otherwise
/// </return>

	public static bool IsMainFrameMainResource(this MentorLake.WebKit2.WebKitResponsePolicyDecisionHandle decision)
	{
		if (decision.IsInvalid) throw new Exception("Invalid handle (WebKitResponsePolicyDecisionHandle)");
		return WebKitResponsePolicyDecisionHandleExterns.webkit_response_policy_decision_is_main_frame_main_resource(decision);
	}

/// <summary>
/// <para>
/// Gets whether the MIME type of the response can be displayed in the #WebKitWebView.
/// </para>
/// <para>
/// Gets whether the MIME type of the response can be displayed in the #WebKitWebView
/// that triggered this policy decision request. See also webkit_web_view_can_show_mime_type().
/// </para>
/// </summary>

/// <param name="decision">
/// a #WebKitResponsePolicyDecision
/// </param>
/// <return>
/// %TRUE if the MIME type of the response is supported or %FALSE otherwise
/// </return>

	public static bool IsMimeTypeSupported(this MentorLake.WebKit2.WebKitResponsePolicyDecisionHandle decision)
	{
		if (decision.IsInvalid) throw new Exception("Invalid handle (WebKitResponsePolicyDecisionHandle)");
		return WebKitResponsePolicyDecisionHandleExterns.webkit_response_policy_decision_is_mime_type_supported(decision);
	}

}

internal class WebKitResponsePolicyDecisionHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitURIRequestHandle>))]
	internal static extern MentorLake.WebKit2.WebKitURIRequestHandle webkit_response_policy_decision_get_request([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitResponsePolicyDecisionHandle>))] MentorLake.WebKit2.WebKitResponsePolicyDecisionHandle decision);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitURIResponseHandle>))]
	internal static extern MentorLake.WebKit2.WebKitURIResponseHandle webkit_response_policy_decision_get_response([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitResponsePolicyDecisionHandle>))] MentorLake.WebKit2.WebKitResponsePolicyDecisionHandle decision);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_response_policy_decision_is_main_frame_main_resource([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitResponsePolicyDecisionHandle>))] MentorLake.WebKit2.WebKitResponsePolicyDecisionHandle decision);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_response_policy_decision_is_mime_type_supported([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitResponsePolicyDecisionHandle>))] MentorLake.WebKit2.WebKitResponsePolicyDecisionHandle decision);

}
