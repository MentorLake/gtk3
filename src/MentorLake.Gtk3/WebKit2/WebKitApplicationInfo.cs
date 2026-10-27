namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Information about an application running in automation mode.
/// </para>
/// </summary>

public class WebKitApplicationInfoHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a new #WebKitApplicationInfo
/// </para>
/// </summary>

/// <return>
/// the newly created #WebKitApplicationInfo.
/// </return>

	public static MentorLake.WebKit2.WebKitApplicationInfoHandle New()
	{
		return WebKitApplicationInfoExterns.webkit_application_info_new();
	}

}


public static class WebKitApplicationInfoExtensions
{
/// <summary>
/// <para>
/// Get the name of the application.
/// </para>
/// <para>
/// If webkit_application_info_set_name() hasn&apos;t been
/// called with a valid name, this returns g_get_prgname().
/// </para>
/// </summary>

/// <param name="info">
/// a #WebKitApplicationInfo
/// </param>
/// <return>
/// the application name
/// </return>

	public static string GetName(this MentorLake.WebKit2.WebKitApplicationInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (WebKitApplicationInfo)");
		return WebKitApplicationInfoExterns.webkit_application_info_get_name(info);
	}

/// <summary>
/// <para>
/// Get the application version previously set with webkit_application_info_set_version().
/// </para>
/// </summary>

/// <param name="info">
/// a #WebKitApplicationInfo
/// </param>
/// <param name="major">
/// return location for the major version number
/// </param>
/// <param name="minor">
/// return location for the minor version number
/// </param>
/// <param name="micro">
/// return location for the micro version number
/// </param>

	public static void GetVersion(this MentorLake.WebKit2.WebKitApplicationInfoHandle info, out ulong major, out ulong minor, out ulong micro)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (WebKitApplicationInfo)");
		WebKitApplicationInfoExterns.webkit_application_info_get_version(info, out major, out minor, out micro);
	}

/// <summary>
/// <para>
/// Atomically increments the reference count of @info by one.
/// </para>
/// <para>
/// This
/// function is MT-safe and may be called from any thread.
/// </para>
/// </summary>

/// <param name="info">
/// a #WebKitApplicationInfo
/// </param>
/// <return>
/// The passed in #WebKitApplicationInfo
/// </return>

	public static MentorLake.WebKit2.WebKitApplicationInfoHandle Ref(this MentorLake.WebKit2.WebKitApplicationInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (WebKitApplicationInfo)");
		return WebKitApplicationInfoExterns.webkit_application_info_ref(info);
	}

/// <summary>
/// <para>
/// Set the name of the application.
/// </para>
/// <para>
/// If not provided, or %NULL is passed,
/// g_get_prgname() will be used.
/// </para>
/// </summary>

/// <param name="info">
/// a #WebKitApplicationInfo
/// </param>
/// <param name="name">
/// the application name
/// </param>

	public static void SetName(this MentorLake.WebKit2.WebKitApplicationInfoHandle info, string name)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (WebKitApplicationInfo)");
		WebKitApplicationInfoExterns.webkit_application_info_set_name(info, name);
	}

/// <summary>
/// <para>
/// Set the application version.
/// </para>
/// <para>
/// If the application doesn&apos;t use the format
/// major.minor.micro you can pass 0 as the micro to use major.minor, or pass
/// 0 as both micro and minor to use only major number. Any other format must
/// be converted to major.minor.micro so that it can be used in version comparisons.
/// </para>
/// </summary>

/// <param name="info">
/// a #WebKitApplicationInfo
/// </param>
/// <param name="major">
/// the major version number
/// </param>
/// <param name="minor">
/// the minor version number
/// </param>
/// <param name="micro">
/// the micro version number
/// </param>

	public static void SetVersion(this MentorLake.WebKit2.WebKitApplicationInfoHandle info, ulong major, ulong minor, ulong micro)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (WebKitApplicationInfo)");
		WebKitApplicationInfoExterns.webkit_application_info_set_version(info, major, minor, micro);
	}

/// <summary>
/// <para>
/// Atomically decrements the reference count of @info by one.
/// </para>
/// <para>
/// If the
/// reference count drops to 0, all memory allocated by the #WebKitApplicationInfo is
/// released. This function is MT-safe and may be called from any
/// thread.
/// </para>
/// </summary>

/// <param name="info">
/// a #WebKitApplicationInfo
/// </param>

	public static void Unref(this MentorLake.WebKit2.WebKitApplicationInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (WebKitApplicationInfo)");
		WebKitApplicationInfoExterns.webkit_application_info_unref(info);
	}


	public static WebKitApplicationInfo Dereference(this WebKitApplicationInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitApplicationInfo>(x.DangerousGetHandle());
}
internal class WebKitApplicationInfoExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitApplicationInfoHandle>))]
	internal static extern MentorLake.WebKit2.WebKitApplicationInfoHandle webkit_application_info_new();

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_application_info_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitApplicationInfoHandle>))] MentorLake.WebKit2.WebKitApplicationInfoHandle info);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_application_info_get_version([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitApplicationInfoHandle>))] MentorLake.WebKit2.WebKitApplicationInfoHandle info, out ulong major, out ulong minor, out ulong micro);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitApplicationInfoHandle>))]
	internal static extern MentorLake.WebKit2.WebKitApplicationInfoHandle webkit_application_info_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitApplicationInfoHandle>))] MentorLake.WebKit2.WebKitApplicationInfoHandle info);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_application_info_set_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitApplicationInfoHandle>))] MentorLake.WebKit2.WebKitApplicationInfoHandle info, string name);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_application_info_set_version([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitApplicationInfoHandle>))] MentorLake.WebKit2.WebKitApplicationInfoHandle info, ulong major, ulong minor, ulong micro);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_application_info_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitApplicationInfoHandle>))] MentorLake.WebKit2.WebKitApplicationInfoHandle info);

}

/// <summary>
/// <para>
/// Information about an application running in automation mode.
/// </para>
/// </summary>

public struct WebKitApplicationInfo
{
}
