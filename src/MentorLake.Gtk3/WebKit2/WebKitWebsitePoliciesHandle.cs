namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// View specific website policies.
/// </para>
/// <para>
/// WebKitWebsitePolicies allows you to configure per-page policies,
/// currently only autoplay policies are supported.
/// </para>
/// </summary>

public class WebKitWebsitePoliciesHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Create a new #WebKitWebsitePolicies.
/// </para>
/// </summary>

/// <return>
/// the newly created #WebKitWebsitePolicies
/// </return>

	public static MentorLake.WebKit2.WebKitWebsitePoliciesHandle New()
	{
		return WebKitWebsitePoliciesHandleExterns.webkit_website_policies_new();
	}

/// <summary>
/// <para>
/// Create a new #WebKitWebsitePolicies with given policies.
/// </para>
/// <para>
/// Create a new #WebKitWebsitePolicies with policies given as variadic
/// arguments.
/// </para>
/// </summary>

/// <param name="first_policy_name">
/// name of the first policy to set
/// </param>
/// <param name="@__arglist">
/// value of first policy, followed by more policies, %NULL-terminated
/// </param>
/// <return>
/// the newly created #WebKitWebsitePolicies
/// 
/// ```c
/// WebKitWebsitePolicies *default_website_policies = webkit_website_policies_new_with_policies(
///     &quot;autoplay&quot;, WEBKIT_AUTOPLAY_DENY,
///     NULL);
/// 
/// // ...
/// 
/// WebKitWebView *view = WEBKIT_WEB_VIEW(g_object_new(WEBKIT_TYPE_WEB_VIEW,
///     &quot;web-context&quot;, ctx,
///     &quot;settings&quot;, settings,
///     &quot;user-content-manager&quot;, content_manager,
///     &quot;website-policies&quot;, default_website_policies,
///     NULL));
/// 
/// // ...
/// ```
/// </return>

	public static MentorLake.WebKit2.WebKitWebsitePoliciesHandle NewWithPolicies(string first_policy_name, IntPtr @__arglist)
	{
		return WebKitWebsitePoliciesHandleExterns.webkit_website_policies_new_with_policies(first_policy_name, @__arglist);
	}

}

public static class WebKitWebsitePoliciesHandleExtensions
{
/// <summary>
/// <para>
/// Get the #WebKitWebsitePolicies:autoplay property.
/// </para>
/// </summary>

/// <param name="policies">
/// a #WebKitWebsitePolicies
/// </param>
/// <return>
/// #WebKitAutoplayPolicy
/// </return>

	public static MentorLake.WebKit2.WebKitAutoplayPolicy GetAutoplayPolicy(this MentorLake.WebKit2.WebKitWebsitePoliciesHandle policies)
	{
		if (policies.IsInvalid) throw new Exception("Invalid handle (WebKitWebsitePoliciesHandle)");
		return WebKitWebsitePoliciesHandleExterns.webkit_website_policies_get_autoplay_policy(policies);
	}

}

internal class WebKitWebsitePoliciesHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsitePoliciesHandle>))]
	internal static extern MentorLake.WebKit2.WebKitWebsitePoliciesHandle webkit_website_policies_new();

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsitePoliciesHandle>))]
	internal static extern MentorLake.WebKit2.WebKitWebsitePoliciesHandle webkit_website_policies_new_with_policies(string first_policy_name, IntPtr @__arglist);

	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.WebKit2.WebKitAutoplayPolicy webkit_website_policies_get_autoplay_policy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsitePoliciesHandle>))] MentorLake.WebKit2.WebKitWebsitePoliciesHandle policies);

}
