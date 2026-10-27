namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// This query represents a user&apos;s choice to allow or deny access to &quot;powerful features&quot; of the
/// platform, as specified in the [Permissions W3C
/// Specification](https://w3c.github.io/permissions/).
/// </para>
/// <para>
/// When signalled by the #WebKitWebView through the `query-permission-state` signal, the application
/// has to eventually respond, via `webkit_permission_state_query_finish()`, whether it grants,
/// denies or requests a dedicated permission prompt for the given query.
/// </para>
/// <para>
/// When a #WebKitPermissionStateQuery is not handled by the user, the user-agent is instructed to
/// `prompt` the user for the given permission.
/// </para>
/// </summary>

public class WebKitPermissionStateQueryHandle : BaseSafeHandle
{
}


public static class WebKitPermissionStateQueryExtensions
{
/// <summary>
/// <para>
/// Notify the web-engine of the selected permission state for the given query. This function should
/// only be called as a response to the `WebKitWebView::query-permission-state` signal.
/// </para>
/// </summary>

/// <param name="query">
/// a #WebKitPermissionStateQuery
/// </param>
/// <param name="state">
/// a #WebKitPermissionState
/// </param>

	public static void Finish(this MentorLake.WebKit2.WebKitPermissionStateQueryHandle query, MentorLake.WebKit2.WebKitPermissionState state)
	{
		if (query.IsInvalid) throw new Exception("Invalid handle (WebKitPermissionStateQuery)");
		WebKitPermissionStateQueryExterns.webkit_permission_state_query_finish(query, state);
	}

/// <summary>
/// <para>
/// Get the permission name for which access is being queried.
/// </para>
/// </summary>

/// <param name="query">
/// a #WebKitPermissionStateQuery
/// </param>
/// <return>
/// the permission name for @query
/// </return>

	public static string GetName(this MentorLake.WebKit2.WebKitPermissionStateQueryHandle query)
	{
		if (query.IsInvalid) throw new Exception("Invalid handle (WebKitPermissionStateQuery)");
		return WebKitPermissionStateQueryExterns.webkit_permission_state_query_get_name(query);
	}

/// <summary>
/// <para>
/// Get the permission origin for which access is being queried.
/// </para>
/// </summary>

/// <param name="query">
/// a #WebKitPermissionStateQuery
/// </param>
/// <return>
/// A #WebKitSecurityOrigin representing the origin from which the
/// @query was emitted.
/// </return>

	public static MentorLake.WebKit2.WebKitSecurityOriginHandle GetSecurityOrigin(this MentorLake.WebKit2.WebKitPermissionStateQueryHandle query)
	{
		if (query.IsInvalid) throw new Exception("Invalid handle (WebKitPermissionStateQuery)");
		return WebKitPermissionStateQueryExterns.webkit_permission_state_query_get_security_origin(query);
	}

/// <summary>
/// <para>
/// Atomically increments the reference count of @query by one.
/// </para>
/// <para>
/// This function is MT-safe and may be called from any thread.
/// </para>
/// </summary>

/// <param name="query">
/// a #WebKitPermissionStateQuery
/// </param>
/// <return>
/// The passed #WebKitPermissionStateQuery
/// </return>

	public static MentorLake.WebKit2.WebKitPermissionStateQueryHandle Ref(this MentorLake.WebKit2.WebKitPermissionStateQueryHandle query)
	{
		if (query.IsInvalid) throw new Exception("Invalid handle (WebKitPermissionStateQuery)");
		return WebKitPermissionStateQueryExterns.webkit_permission_state_query_ref(query);
	}

/// <summary>
/// <para>
/// Atomically decrements the reference count of @query by one.
/// </para>
/// <para>
/// If the reference count drops to 0, all memory allocated by #WebKitPermissionStateQuery is
/// released. This function is MT-safe and may be called from any thread.
/// </para>
/// </summary>

/// <param name="query">
/// a #WebKitPermissionStateQuery
/// </param>

	public static void Unref(this MentorLake.WebKit2.WebKitPermissionStateQueryHandle query)
	{
		if (query.IsInvalid) throw new Exception("Invalid handle (WebKitPermissionStateQuery)");
		WebKitPermissionStateQueryExterns.webkit_permission_state_query_unref(query);
	}


	public static WebKitPermissionStateQuery Dereference(this WebKitPermissionStateQueryHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitPermissionStateQuery>(x.DangerousGetHandle());
}
internal class WebKitPermissionStateQueryExterns
{
	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_permission_state_query_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitPermissionStateQueryHandle>))] MentorLake.WebKit2.WebKitPermissionStateQueryHandle query, MentorLake.WebKit2.WebKitPermissionState state);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_permission_state_query_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitPermissionStateQueryHandle>))] MentorLake.WebKit2.WebKitPermissionStateQueryHandle query);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSecurityOriginHandle>))]
	internal static extern MentorLake.WebKit2.WebKitSecurityOriginHandle webkit_permission_state_query_get_security_origin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitPermissionStateQueryHandle>))] MentorLake.WebKit2.WebKitPermissionStateQueryHandle query);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitPermissionStateQueryHandle>))]
	internal static extern MentorLake.WebKit2.WebKitPermissionStateQueryHandle webkit_permission_state_query_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitPermissionStateQueryHandle>))] MentorLake.WebKit2.WebKitPermissionStateQueryHandle query);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_permission_state_query_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitPermissionStateQueryHandle>))] MentorLake.WebKit2.WebKitPermissionStateQueryHandle query);

}

/// <summary>
/// <para>
/// This query represents a user&apos;s choice to allow or deny access to &quot;powerful features&quot; of the
/// platform, as specified in the [Permissions W3C
/// Specification](https://w3c.github.io/permissions/).
/// </para>
/// <para>
/// When signalled by the #WebKitWebView through the `query-permission-state` signal, the application
/// has to eventually respond, via `webkit_permission_state_query_finish()`, whether it grants,
/// denies or requests a dedicated permission prompt for the given query.
/// </para>
/// <para>
/// When a #WebKitPermissionStateQuery is not handled by the user, the user-agent is instructed to
/// `prompt` the user for the given permission.
/// </para>
/// </summary>

public struct WebKitPermissionStateQuery
{
}
