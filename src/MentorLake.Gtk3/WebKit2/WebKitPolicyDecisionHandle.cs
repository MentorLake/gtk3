namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// A pending policy decision.
/// </para>
/// <para>
/// Often WebKit allows the client to decide the policy for certain
/// operations. For instance, a client may want to open a link in a new
/// tab, block a navigation entirely, query the user or trigger a download
/// instead of a navigation. In these cases WebKit will fire the
/// #WebKitWebView::decide-policy signal with a #WebKitPolicyDecision
/// object. If the signal handler does nothing, WebKit will act as if
/// webkit_policy_decision_use() was called as soon as signal handling
/// completes. To make a policy decision asynchronously, simply increment
/// the reference count of the #WebKitPolicyDecision object.
/// </para>
/// </summary>

public class WebKitPolicyDecisionHandle : GObjectHandle
{
}

public static class WebKitPolicyDecisionHandleExtensions
{
/// <summary>
/// <para>
/// Spawn a download from this decision.
/// </para>
/// </summary>

/// <param name="decision">
/// a #WebKitPolicyDecision
/// </param>

	public static T Download<T>(this T decision) where T : WebKitPolicyDecisionHandle
	{
		if (decision.IsInvalid) throw new Exception("Invalid handle (WebKitPolicyDecisionHandle)");
		WebKitPolicyDecisionHandleExterns.webkit_policy_decision_download(decision);
		return decision;
	}

/// <summary>
/// <para>
/// #WebKitResponsePolicyDecision, this would cancel the request.
/// </para>
/// <para>
/// Ignore the action which triggered this decision. For instance, for a
/// #WebKitResponsePolicyDecision, this would cancel the request.
/// </para>
/// </summary>

/// <param name="decision">
/// a #WebKitPolicyDecision
/// </param>

	public static T Ignore<T>(this T decision) where T : WebKitPolicyDecisionHandle
	{
		if (decision.IsInvalid) throw new Exception("Invalid handle (WebKitPolicyDecisionHandle)");
		WebKitPolicyDecisionHandleExterns.webkit_policy_decision_ignore(decision);
		return decision;
	}

/// <summary>
/// <para>
/// Accept the action which triggered this decision.
/// </para>
/// </summary>

/// <param name="decision">
/// a #WebKitPolicyDecision
/// </param>

	public static T Use<T>(this T decision) where T : WebKitPolicyDecisionHandle
	{
		if (decision.IsInvalid) throw new Exception("Invalid handle (WebKitPolicyDecisionHandle)");
		WebKitPolicyDecisionHandleExterns.webkit_policy_decision_use(decision);
		return decision;
	}

/// <summary>
/// <para>
/// Accept the navigation action and continue with provided @policies.
/// </para>
/// <para>
/// Accept the navigation action which triggered this decision, and
/// continue with @policies affecting all subsequent loads of resources
/// in the origin associated with the accepted navigation action.
/// </para>
/// <para>
/// For example, a navigation decision to a video sharing website may
/// be accepted under the priviso no movies are allowed to autoplay. The
/// autoplay policy in this case would be set in the @policies.
/// </para>
/// </summary>

/// <param name="decision">
/// a #WebKitPolicyDecision
/// </param>
/// <param name="policies">
/// a #WebKitWebsitePolicies
/// </param>

	public static T UseWithPolicies<T>(this T decision, MentorLake.WebKit2.WebKitWebsitePoliciesHandle policies) where T : WebKitPolicyDecisionHandle
	{
		if (decision.IsInvalid) throw new Exception("Invalid handle (WebKitPolicyDecisionHandle)");
		WebKitPolicyDecisionHandleExterns.webkit_policy_decision_use_with_policies(decision, policies);
		return decision;
	}

}

internal class WebKitPolicyDecisionHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_policy_decision_download([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitPolicyDecisionHandle>))] MentorLake.WebKit2.WebKitPolicyDecisionHandle decision);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_policy_decision_ignore([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitPolicyDecisionHandle>))] MentorLake.WebKit2.WebKitPolicyDecisionHandle decision);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_policy_decision_use([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitPolicyDecisionHandle>))] MentorLake.WebKit2.WebKitPolicyDecisionHandle decision);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_policy_decision_use_with_policies([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitPolicyDecisionHandle>))] MentorLake.WebKit2.WebKitPolicyDecisionHandle decision, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsitePoliciesHandle>))] MentorLake.WebKit2.WebKitWebsitePoliciesHandle policies);

}
