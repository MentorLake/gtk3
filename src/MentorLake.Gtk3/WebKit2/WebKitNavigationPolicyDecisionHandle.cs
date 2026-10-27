namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// A policy decision for navigation actions.
/// </para>
/// <para>
/// WebKitNavigationPolicyDecision represents a policy decision for events associated with
/// navigations. If the value of #WebKitNavigationPolicyDecision:mouse-button is not 0, then
/// the navigation was triggered by a mouse event.
/// </para>
/// </summary>

public class WebKitNavigationPolicyDecisionHandle : WebKitPolicyDecisionHandle
{
}

public static class WebKitNavigationPolicyDecisionHandleExtensions
{
/// <summary>
/// <para>
/// Gets the value of the #WebKitNavigationPolicyDecision:frame-name property.
/// </para>
/// </summary>

/// <param name="decision">
/// a #WebKitNavigationPolicyDecision
/// </param>
/// <return>
/// The name of the new frame this navigation action targets or %NULL
/// </return>

	public static string GetFrameName(this MentorLake.WebKit2.WebKitNavigationPolicyDecisionHandle decision)
	{
		if (decision.IsInvalid) throw new Exception("Invalid handle (WebKitNavigationPolicyDecisionHandle)");
		return WebKitNavigationPolicyDecisionHandleExterns.webkit_navigation_policy_decision_get_frame_name(decision);
	}

/// <summary>
/// <para>
/// Gets the value of the #WebKitNavigationPolicyDecision:modifiers property.
/// </para>
/// </summary>

/// <param name="decision">
/// a #WebKitNavigationPolicyDecision
/// </param>
/// <return>
/// The modifiers active if this decision was triggered by a mouse event
/// </return>

	public static uint GetModifiers(this MentorLake.WebKit2.WebKitNavigationPolicyDecisionHandle decision)
	{
		if (decision.IsInvalid) throw new Exception("Invalid handle (WebKitNavigationPolicyDecisionHandle)");
		return WebKitNavigationPolicyDecisionHandleExterns.webkit_navigation_policy_decision_get_modifiers(decision);
	}

/// <summary>
/// <para>
/// Gets the value of the #WebKitNavigationPolicyDecision:mouse-button property.
/// </para>
/// </summary>

/// <param name="decision">
/// a #WebKitNavigationPolicyDecision
/// </param>
/// <return>
/// The mouse button used if this decision was triggered by a mouse event or 0 otherwise
/// </return>

	public static uint GetMouseButton(this MentorLake.WebKit2.WebKitNavigationPolicyDecisionHandle decision)
	{
		if (decision.IsInvalid) throw new Exception("Invalid handle (WebKitNavigationPolicyDecisionHandle)");
		return WebKitNavigationPolicyDecisionHandleExterns.webkit_navigation_policy_decision_get_mouse_button(decision);
	}

/// <summary>
/// <para>
/// Gets the value of the #WebKitNavigationPolicyDecision:navigation-action property.
/// </para>
/// </summary>

/// <param name="decision">
/// a #WebKitNavigationPolicyDecision
/// </param>
/// <return>
/// The #WebKitNavigationAction triggering this policy decision.
/// </return>

	public static MentorLake.WebKit2.WebKitNavigationActionHandle GetNavigationAction(this MentorLake.WebKit2.WebKitNavigationPolicyDecisionHandle decision)
	{
		if (decision.IsInvalid) throw new Exception("Invalid handle (WebKitNavigationPolicyDecisionHandle)");
		return WebKitNavigationPolicyDecisionHandleExterns.webkit_navigation_policy_decision_get_navigation_action(decision);
	}

/// <summary>
/// <para>
/// Gets the value of the #WebKitNavigationPolicyDecision:navigation-type property.
/// </para>
/// </summary>

/// <param name="decision">
/// a #WebKitNavigationPolicyDecision
/// </param>
/// <return>
/// The type of navigation triggering this policy decision.
/// </return>

	public static MentorLake.WebKit2.WebKitNavigationType GetNavigationType(this MentorLake.WebKit2.WebKitNavigationPolicyDecisionHandle decision)
	{
		if (decision.IsInvalid) throw new Exception("Invalid handle (WebKitNavigationPolicyDecisionHandle)");
		return WebKitNavigationPolicyDecisionHandleExterns.webkit_navigation_policy_decision_get_navigation_type(decision);
	}

/// <summary>
/// <para>
/// Gets the value of the #WebKitNavigationPolicyDecision:request property.
/// </para>
/// </summary>

/// <param name="decision">
/// a #WebKitNavigationPolicyDecision
/// </param>
/// <return>
/// The URI request that is associated with this navigation
/// </return>

	public static MentorLake.WebKit2.WebKitURIRequestHandle GetRequest(this MentorLake.WebKit2.WebKitNavigationPolicyDecisionHandle decision)
	{
		if (decision.IsInvalid) throw new Exception("Invalid handle (WebKitNavigationPolicyDecisionHandle)");
		return WebKitNavigationPolicyDecisionHandleExterns.webkit_navigation_policy_decision_get_request(decision);
	}

}

internal class WebKitNavigationPolicyDecisionHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_navigation_policy_decision_get_frame_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitNavigationPolicyDecisionHandle>))] MentorLake.WebKit2.WebKitNavigationPolicyDecisionHandle decision);

	[DllImport(WebKit2Library.Name)]
	internal static extern uint webkit_navigation_policy_decision_get_modifiers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitNavigationPolicyDecisionHandle>))] MentorLake.WebKit2.WebKitNavigationPolicyDecisionHandle decision);

	[DllImport(WebKit2Library.Name)]
	internal static extern uint webkit_navigation_policy_decision_get_mouse_button([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitNavigationPolicyDecisionHandle>))] MentorLake.WebKit2.WebKitNavigationPolicyDecisionHandle decision);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitNavigationActionHandle>))]
	internal static extern MentorLake.WebKit2.WebKitNavigationActionHandle webkit_navigation_policy_decision_get_navigation_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitNavigationPolicyDecisionHandle>))] MentorLake.WebKit2.WebKitNavigationPolicyDecisionHandle decision);

	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.WebKit2.WebKitNavigationType webkit_navigation_policy_decision_get_navigation_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitNavigationPolicyDecisionHandle>))] MentorLake.WebKit2.WebKitNavigationPolicyDecisionHandle decision);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitURIRequestHandle>))]
	internal static extern MentorLake.WebKit2.WebKitURIRequestHandle webkit_navigation_policy_decision_get_request([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitNavigationPolicyDecisionHandle>))] MentorLake.WebKit2.WebKitNavigationPolicyDecisionHandle decision);

}
