namespace MentorLake.Soup;

/// <summary>
/// <para>
/// HTTP client-side authentication handler.
/// </para>
/// <para>
/// [class@AuthManager] is the [iface@SessionFeature] that handles HTTP
/// authentication for a [class@Session].
/// </para>
/// <para>
/// A [class@AuthManager] is added to the session by default, and normally
/// you don&apos;t need to worry about it at all. However, if you want to
/// disable HTTP authentication, you can remove the feature from the
/// session with [method@Session.remove_feature_by_type] or disable it on
/// individual requests with [method@Message.disable_feature].
/// </para>
/// <para>
/// You can use this with [method@Session.remove_feature_by_type] or
/// [method@Message.disable_feature].
/// </para>
/// <para>
/// (Although this type has only been publicly visible since libsoup 2.42, it has
/// always existed in the background, and you can use `g_type_from_name
/// (&quot;SoupAuthManager&quot;)` to get its [alias@GObject.Type] in earlier releases.)
/// </para>
/// </summary>

public class SoupAuthManagerHandle : GObjectHandle, SoupSessionFeatureHandle
{
}

public static class SoupAuthManagerHandleExtensions
{
/// <summary>
/// <para>
/// Clear all credentials cached by @manager.
/// </para>
/// </summary>

/// <param name="manager">
/// a #SoupAuthManager
/// </param>

	public static T ClearCachedCredentials<T>(this T manager) where T : SoupAuthManagerHandle
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (SoupAuthManagerHandle)");
		SoupAuthManagerHandleExterns.soup_auth_manager_clear_cached_credentials(manager);
		return manager;
	}

/// <summary>
/// <para>
/// Records that @auth is to be used under @uri, as though a
/// WWW-Authenticate header had been received at that URI.
/// </para>
/// <para>
/// This can be used to &quot;preload&quot; @manager&apos;s auth cache, to avoid an extra HTTP
/// round trip in the case where you know ahead of time that a 401 response will
/// be returned.
/// </para>
/// <para>
/// This is only useful for authentication types where the initial
/// Authorization header does not depend on any additional information
/// from the server. (Eg, Basic or NTLM, but not Digest.)
/// </para>
/// </summary>

/// <param name="manager">
/// a #SoupAuthManager
/// </param>
/// <param name="uri">
/// the #GUri under which @auth is to be used
/// </param>
/// <param name="auth">
/// the #SoupAuth to use
/// </param>

	public static T UseAuth<T>(this T manager, MentorLake.GLib.GUriHandle uri, MentorLake.Soup.SoupAuthHandle auth) where T : SoupAuthManagerHandle
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (SoupAuthManagerHandle)");
		SoupAuthManagerHandleExterns.soup_auth_manager_use_auth(manager, uri, auth);
		return manager;
	}

}

internal class SoupAuthManagerHandleExterns
{
	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_auth_manager_clear_cached_credentials([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupAuthManagerHandle>))] MentorLake.Soup.SoupAuthManagerHandle manager);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_auth_manager_use_auth([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupAuthManagerHandle>))] MentorLake.Soup.SoupAuthManagerHandle manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle uri, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupAuthHandle>))] MentorLake.Soup.SoupAuthHandle auth);

}
