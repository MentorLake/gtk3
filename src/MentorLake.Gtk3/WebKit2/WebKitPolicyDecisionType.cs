namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values used for determining the type of a policy decision during
/// #WebKitWebView::decide-policy.
/// </para>
/// </summary>

[Flags]
public enum WebKitPolicyDecisionType
{
/// <summary>
/// <para>
/// This type of policy decision
///   is requested when WebKit is about to navigate to a new page in either the
///   main frame or a subframe. Acceptable policy decisions are either
///   webkit_policy_decision_use() or webkit_policy_decision_ignore(). This
///   type of policy decision is always a #WebKitNavigationPolicyDecision.
/// </para>
/// </summary>

	WEBKIT_POLICY_DECISION_TYPE_NAVIGATION_ACTION = 0,
/// <summary>
/// <para>
/// This type of policy decision
///   is requested when WebKit is about to create a new window. Acceptable policy
///   decisions are either webkit_policy_decision_use() or
///   webkit_policy_decision_ignore(). This type of policy decision is always
///   a #WebKitNavigationPolicyDecision. These decisions are useful for implementing
///   special actions for new windows, such as forcing the new window to open
///   in a tab when a keyboard modifier is active or handling a special
///   target attribute on &amp;lt;a&amp;gt; elements.
/// </para>
/// </summary>

	WEBKIT_POLICY_DECISION_TYPE_NEW_WINDOW_ACTION = 1,
/// <summary>
/// <para>
/// This type of decision is used when WebKit has
///   received a response for a network resource and is about to start the load.
///   Note that these resources include all subresources of a page such as images
///   and stylesheets as well as main documents. Appropriate policy responses to
///   this decision are webkit_policy_decision_use(), webkit_policy_decision_ignore(),
///   or webkit_policy_decision_download(). This type of policy decision is always
///   a #WebKitResponsePolicyDecision. This decision is useful for forcing
///   some types of resources to be downloaded rather than rendered in the WebView
///   or to block the transfer of resources entirely.
/// </para>
/// </summary>

	WEBKIT_POLICY_DECISION_TYPE_RESPONSE = 2
}
