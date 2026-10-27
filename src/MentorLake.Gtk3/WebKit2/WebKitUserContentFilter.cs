namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// A compiled set of rules which applied to resource loads.
/// </para>
/// </summary>

public class WebKitUserContentFilterHandle : BaseSafeHandle
{
}


public static class WebKitUserContentFilterExtensions
{
/// <summary>
/// <para>
/// Obtain the identifier previously used to save the @user_content_filter.
/// </para>
/// <para>
/// Obtain the identifier previously used to save the @user_content_filter in the
/// #WebKitUserContentFilterStore.
/// </para>
/// </summary>

/// <param name="user_content_filter">
/// A #WebKitUserContentFilter
/// </param>
/// <return>
/// the identifier for the filter
/// </return>

	public static string GetIdentifier(this MentorLake.WebKit2.WebKitUserContentFilterHandle user_content_filter)
	{
		if (user_content_filter.IsInvalid) throw new Exception("Invalid handle (WebKitUserContentFilter)");
		return WebKitUserContentFilterExterns.webkit_user_content_filter_get_identifier(user_content_filter);
	}

/// <summary>
/// <para>
/// Atomically increments the reference count of @user_content_filter by one.
/// </para>
/// <para>
/// This function is MT-safe and may be called from any thread.
/// </para>
/// </summary>

/// <param name="user_content_filter">
/// A #WebKitUserContentFilter
/// </param>
/// <return>
/// the @user_content_filter passed in.
/// </return>

	public static MentorLake.WebKit2.WebKitUserContentFilterHandle Ref(this MentorLake.WebKit2.WebKitUserContentFilterHandle user_content_filter)
	{
		if (user_content_filter.IsInvalid) throw new Exception("Invalid handle (WebKitUserContentFilter)");
		return WebKitUserContentFilterExterns.webkit_user_content_filter_ref(user_content_filter);
	}

/// <summary>
/// <para>
/// Atomically decrements the reference count of @user_content_filter by one.
/// </para>
/// <para>
/// If the reference count drops to 0, all the memory allocated by the
/// #WebKitUserContentFilter is released. This function is MT-safe and may
/// be called from any thread.
/// </para>
/// </summary>

/// <param name="user_content_filter">
/// A #WebKitUserContentFilter
/// </param>

	public static void Unref(this MentorLake.WebKit2.WebKitUserContentFilterHandle user_content_filter)
	{
		if (user_content_filter.IsInvalid) throw new Exception("Invalid handle (WebKitUserContentFilter)");
		WebKitUserContentFilterExterns.webkit_user_content_filter_unref(user_content_filter);
	}


	public static WebKitUserContentFilter Dereference(this WebKitUserContentFilterHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitUserContentFilter>(x.DangerousGetHandle());
}
internal class WebKitUserContentFilterExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_user_content_filter_get_identifier([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserContentFilterHandle>))] MentorLake.WebKit2.WebKitUserContentFilterHandle user_content_filter);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserContentFilterHandle>))]
	internal static extern MentorLake.WebKit2.WebKitUserContentFilterHandle webkit_user_content_filter_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserContentFilterHandle>))] MentorLake.WebKit2.WebKitUserContentFilterHandle user_content_filter);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_user_content_filter_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitUserContentFilterHandle>))] MentorLake.WebKit2.WebKitUserContentFilterHandle user_content_filter);

}

/// <summary>
/// <para>
/// A compiled set of rules which applied to resource loads.
/// </para>
/// </summary>

public struct WebKitUserContentFilter
{
}
