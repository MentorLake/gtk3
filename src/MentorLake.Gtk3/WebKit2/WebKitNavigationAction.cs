namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Provides details about interaction resulting in a resource load.
/// </para>
/// </summary>

public class WebKitNavigationActionHandle : BaseSafeHandle
{
}


public static class WebKitNavigationActionExtensions
{
/// <summary>
/// <para>
/// Make a copy of @navigation.
/// </para>
/// </summary>

/// <param name="navigation">
/// a #WebKitNavigationAction
/// </param>
/// <return>
/// A copy of passed in #WebKitNavigationAction
/// </return>

	public static MentorLake.WebKit2.WebKitNavigationActionHandle Copy(this MentorLake.WebKit2.WebKitNavigationActionHandle navigation)
	{
		if (navigation.IsInvalid) throw new Exception("Invalid handle (WebKitNavigationAction)");
		return WebKitNavigationActionExterns.webkit_navigation_action_copy(navigation);
	}

/// <summary>
/// <para>
/// Free the #WebKitNavigationAction
/// </para>
/// </summary>

/// <param name="navigation">
/// a #WebKitNavigationAction
/// </param>

	public static void Free(this MentorLake.WebKit2.WebKitNavigationActionHandle navigation)
	{
		if (navigation.IsInvalid) throw new Exception("Invalid handle (WebKitNavigationAction)");
		WebKitNavigationActionExterns.webkit_navigation_action_free(navigation);
	}

/// <summary>
/// <para>
/// Gets the @navigation target frame name. For example if navigation was triggered by clicking a
/// link with a target attribute equal to &quot;_blank&quot;, this will return the value of that attribute.
/// In all other cases this function will return %NULL.
/// </para>
/// </summary>

/// <param name="navigation">
/// a #WebKitNavigationAction
/// </param>
/// <return>
/// The name of the new frame this navigation action targets or %NULL
/// </return>

	public static string GetFrameName(this MentorLake.WebKit2.WebKitNavigationActionHandle navigation)
	{
		if (navigation.IsInvalid) throw new Exception("Invalid handle (WebKitNavigationAction)");
		return WebKitNavigationActionExterns.webkit_navigation_action_get_frame_name(navigation);
	}

/// <summary>
/// <para>
/// Return the modifier keys.
/// </para>
/// <para>
/// Return a bitmask of #GdkModifierType values describing the modifier keys that were in effect
/// when the navigation was requested
/// </para>
/// </summary>

/// <param name="navigation">
/// a #WebKitNavigationAction
/// </param>
/// <return>
/// the modifier keys
/// </return>

	public static uint GetModifiers(this MentorLake.WebKit2.WebKitNavigationActionHandle navigation)
	{
		if (navigation.IsInvalid) throw new Exception("Invalid handle (WebKitNavigationAction)");
		return WebKitNavigationActionExterns.webkit_navigation_action_get_modifiers(navigation);
	}

/// <summary>
/// <para>
/// Return the number of the mouse button that triggered the navigation.
/// </para>
/// <para>
/// Return the number of the mouse button that triggered the navigation, or 0 if
/// the navigation was not started by a mouse event.
/// </para>
/// </summary>

/// <param name="navigation">
/// a #WebKitNavigationAction
/// </param>
/// <return>
/// the mouse button number or 0
/// </return>

	public static uint GetMouseButton(this MentorLake.WebKit2.WebKitNavigationActionHandle navigation)
	{
		if (navigation.IsInvalid) throw new Exception("Invalid handle (WebKitNavigationAction)");
		return WebKitNavigationActionExterns.webkit_navigation_action_get_mouse_button(navigation);
	}

/// <summary>
/// <para>
/// Return the type of action that triggered the navigation.
/// </para>
/// </summary>

/// <param name="navigation">
/// a #WebKitNavigationAction
/// </param>
/// <return>
/// a #WebKitNavigationType
/// </return>

	public static MentorLake.WebKit2.WebKitNavigationType GetNavigationType(this MentorLake.WebKit2.WebKitNavigationActionHandle navigation)
	{
		if (navigation.IsInvalid) throw new Exception("Invalid handle (WebKitNavigationAction)");
		return WebKitNavigationActionExterns.webkit_navigation_action_get_navigation_type(navigation);
	}

/// <summary>
/// <para>
/// Return the #WebKitURIRequest associated with the navigation action.
/// </para>
/// <para>
/// Modifications to the returned object are &amp;lt;emphasis&amp;gt;not&amp;lt;/emphasis&amp;gt; taken
/// into account when the request is sent over the network, and is intended
/// only to aid in evaluating whether a navigation action should be taken or
/// not. To modify requests before they are sent over the network the
/// #WebKitPage::send-request signal can be used instead.
/// </para>
/// </summary>

/// <param name="navigation">
/// a #WebKitNavigationAction
/// </param>
/// <return>
/// a #WebKitURIRequest
/// </return>

	public static MentorLake.WebKit2.WebKitURIRequestHandle GetRequest(this MentorLake.WebKit2.WebKitNavigationActionHandle navigation)
	{
		if (navigation.IsInvalid) throw new Exception("Invalid handle (WebKitNavigationAction)");
		return WebKitNavigationActionExterns.webkit_navigation_action_get_request(navigation);
	}

/// <summary>
/// <para>
/// Returns whether the @navigation was redirected.
/// </para>
/// </summary>

/// <param name="navigation">
/// a #WebKitNavigationAction
/// </param>
/// <return>
/// %TRUE if the original navigation was redirected, %FALSE otherwise.
/// </return>

	public static bool IsRedirect(this MentorLake.WebKit2.WebKitNavigationActionHandle navigation)
	{
		if (navigation.IsInvalid) throw new Exception("Invalid handle (WebKitNavigationAction)");
		return WebKitNavigationActionExterns.webkit_navigation_action_is_redirect(navigation);
	}

/// <summary>
/// <para>
/// Return whether the navigation was triggered by a user gesture like a mouse click.
/// </para>
/// </summary>

/// <param name="navigation">
/// a #WebKitNavigationAction
/// </param>
/// <return>
/// whether navigation action is a user gesture
/// </return>

	public static bool IsUserGesture(this MentorLake.WebKit2.WebKitNavigationActionHandle navigation)
	{
		if (navigation.IsInvalid) throw new Exception("Invalid handle (WebKitNavigationAction)");
		return WebKitNavigationActionExterns.webkit_navigation_action_is_user_gesture(navigation);
	}


	public static WebKitNavigationAction Dereference(this WebKitNavigationActionHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitNavigationAction>(x.DangerousGetHandle());
}
internal class WebKitNavigationActionExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitNavigationActionHandle>))]
	internal static extern MentorLake.WebKit2.WebKitNavigationActionHandle webkit_navigation_action_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitNavigationActionHandle>))] MentorLake.WebKit2.WebKitNavigationActionHandle navigation);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_navigation_action_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitNavigationActionHandle>))] MentorLake.WebKit2.WebKitNavigationActionHandle navigation);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_navigation_action_get_frame_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitNavigationActionHandle>))] MentorLake.WebKit2.WebKitNavigationActionHandle navigation);

	[DllImport(WebKit2Library.Name)]
	internal static extern uint webkit_navigation_action_get_modifiers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitNavigationActionHandle>))] MentorLake.WebKit2.WebKitNavigationActionHandle navigation);

	[DllImport(WebKit2Library.Name)]
	internal static extern uint webkit_navigation_action_get_mouse_button([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitNavigationActionHandle>))] MentorLake.WebKit2.WebKitNavigationActionHandle navigation);

	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.WebKit2.WebKitNavigationType webkit_navigation_action_get_navigation_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitNavigationActionHandle>))] MentorLake.WebKit2.WebKitNavigationActionHandle navigation);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitURIRequestHandle>))]
	internal static extern MentorLake.WebKit2.WebKitURIRequestHandle webkit_navigation_action_get_request([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitNavigationActionHandle>))] MentorLake.WebKit2.WebKitNavigationActionHandle navigation);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_navigation_action_is_redirect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitNavigationActionHandle>))] MentorLake.WebKit2.WebKitNavigationActionHandle navigation);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_navigation_action_is_user_gesture([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitNavigationActionHandle>))] MentorLake.WebKit2.WebKitNavigationActionHandle navigation);

}

/// <summary>
/// <para>
/// Provides details about interaction resulting in a resource load.
/// </para>
/// </summary>

public struct WebKitNavigationAction
{
}
