namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Information about a MIME type.
/// </para>
/// </summary>

public class WebKitMimeInfoHandle : BaseSafeHandle
{
}


public static class WebKitMimeInfoExtensions
{
/// <summary>
/// <para>
/// Gets the description of the MIME type.
/// </para>
/// </summary>

/// <param name="info">
/// a #WebKitMimeInfo
/// </param>
/// <return>
/// description, as a string.
/// </return>

	public static string GetDescription(this MentorLake.WebKit2.WebKitMimeInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (WebKitMimeInfo)");
		return WebKitMimeInfoExterns.webkit_mime_info_get_description(info);
	}

/// <summary>
/// <para>
/// Get the list of file extensions associated to the MIME type.
/// </para>
/// </summary>

/// <param name="info">
/// a #WebKitMimeInfo
/// </param>
/// <return>
/// a
///     %NULL-terminated array of strings
/// </return>

	public static string[] GetExtensions(this MentorLake.WebKit2.WebKitMimeInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (WebKitMimeInfo)");
		return WebKitMimeInfoExterns.webkit_mime_info_get_extensions(info);
	}

/// <summary>
/// <para>
/// Gets the MIME type.
/// </para>
/// </summary>

/// <param name="info">
/// a #WebKitMimeInfo
/// </param>
/// <return>
/// MIME type, as a string.
/// </return>

	public static string GetMimeType(this MentorLake.WebKit2.WebKitMimeInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (WebKitMimeInfo)");
		return WebKitMimeInfoExterns.webkit_mime_info_get_mime_type(info);
	}

/// <summary>
/// <para>
/// Atomically increments the reference count of @info by one.
/// </para>
/// <para>
/// This function is MT-safe and may be called from any thread.
/// </para>
/// </summary>

/// <param name="info">
/// a #WebKitMimeInfo
/// </param>
/// <return>
/// The passed in #WebKitMimeInfo
/// </return>

	public static MentorLake.WebKit2.WebKitMimeInfoHandle Ref(this MentorLake.WebKit2.WebKitMimeInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (WebKitMimeInfo)");
		return WebKitMimeInfoExterns.webkit_mime_info_ref(info);
	}

/// <summary>
/// <para>
/// Atomically decrements the reference count of @info by one.
/// </para>
/// <para>
/// If the reference count drops to 0, all memory allocated by the #WebKitMimeInfo is
/// released. This function is MT-safe and may be called from any
/// thread.
/// </para>
/// </summary>

/// <param name="info">
/// a #WebKitMimeInfo
/// </param>

	public static void Unref(this MentorLake.WebKit2.WebKitMimeInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (WebKitMimeInfo)");
		WebKitMimeInfoExterns.webkit_mime_info_unref(info);
	}


	public static WebKitMimeInfo Dereference(this WebKitMimeInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitMimeInfo>(x.DangerousGetHandle());
}
internal class WebKitMimeInfoExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_mime_info_get_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitMimeInfoHandle>))] MentorLake.WebKit2.WebKitMimeInfoHandle info);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] webkit_mime_info_get_extensions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitMimeInfoHandle>))] MentorLake.WebKit2.WebKitMimeInfoHandle info);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_mime_info_get_mime_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitMimeInfoHandle>))] MentorLake.WebKit2.WebKitMimeInfoHandle info);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitMimeInfoHandle>))]
	internal static extern MentorLake.WebKit2.WebKitMimeInfoHandle webkit_mime_info_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitMimeInfoHandle>))] MentorLake.WebKit2.WebKitMimeInfoHandle info);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_mime_info_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitMimeInfoHandle>))] MentorLake.WebKit2.WebKitMimeInfoHandle info);

}

/// <summary>
/// <para>
/// Information about a MIME type.
/// </para>
/// </summary>

public struct WebKitMimeInfo
{
}
