namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Data stored locally by a web site.
/// </para>
/// <para>
/// WebKitWebsiteData represents data stored in the client by a particular website.
/// A website is normally a set of URLs grouped by domain name. You can get the website name,
/// which is usually the domain, with webkit_website_data_get_name().
/// Documents loaded from the file system, like file:// URIs, are all grouped in the same WebKitWebsiteData
/// with the name &quot;Local files&quot;.
/// </para>
/// <para>
/// A website can store different types of data in the client side. #WebKitWebsiteDataTypes is an enum containing
/// all the possible data types; use webkit_website_data_get_types() to get the bitmask of data types.
/// It&apos;s also possible to know the size of the data stored for some of the #WebKitWebsiteDataTypes by using
/// webkit_website_data_get_size().
/// </para>
/// <para>
/// A list of WebKitWebsiteData can be retrieved with webkit_website_data_manager_fetch(). See #WebKitWebsiteDataManager
/// for more information.
/// </para>
/// </summary>

public class WebKitWebsiteDataHandle : BaseSafeHandle
{
}


public static class WebKitWebsiteDataExtensions
{
/// <summary>
/// <para>
/// Gets the name of #WebKitWebsiteData.
/// </para>
/// <para>
/// This is the website name, normally represented by
/// a domain or host name. All local documents are grouped in the same #WebKitWebsiteData using
/// the name &quot;Local files&quot;.
/// </para>
/// </summary>

/// <param name="website_data">
/// a #WebKitWebsiteData
/// </param>
/// <return>
/// the website name of @website_data.
/// </return>

	public static string GetName(this MentorLake.WebKit2.WebKitWebsiteDataHandle website_data)
	{
		if (website_data.IsInvalid) throw new Exception("Invalid handle (WebKitWebsiteData)");
		return WebKitWebsiteDataExterns.webkit_website_data_get_name(website_data);
	}

/// <summary>
/// <para>
/// Gets the size of the data of types @types in a #WebKitWebsiteData.
/// </para>
/// <para>
/// Note that currently the data size is only known for the %WEBKIT_WEBSITE_DATA_DISK_CACHE,
/// %WEBKIT_WEBSITE_DATA_LOCAL_STORAGE, %WEBKIT_WEBSITE_DATA_INDEXEDDB_DATABASES and
/// %WEBKIT_WEBSITE_DATA_DOM_CACHE data types, so for all other types 0 will be returned.
/// </para>
/// </summary>

/// <param name="website_data">
/// a #WebKitWebsiteData
/// </param>
/// <param name="types">
/// a bitmask  of #WebKitWebsiteDataTypes
/// </param>
/// <return>
/// the size of @website_data for the given @types.
/// </return>

	public static ulong GetSize(this MentorLake.WebKit2.WebKitWebsiteDataHandle website_data, MentorLake.WebKit2.WebKitWebsiteDataTypes types)
	{
		if (website_data.IsInvalid) throw new Exception("Invalid handle (WebKitWebsiteData)");
		return WebKitWebsiteDataExterns.webkit_website_data_get_size(website_data, types);
	}

/// <summary>
/// <para>
/// Gets the types of data stored in the client for a #WebKitWebsiteData.
/// </para>
/// <para>
/// These are the
/// types actually present, not the types queried with webkit_website_data_manager_fetch().
/// </para>
/// </summary>

/// <param name="website_data">
/// a #WebKitWebsiteData
/// </param>
/// <return>
/// a bitmask of #WebKitWebsiteDataTypes in @website_data
/// </return>

	public static MentorLake.WebKit2.WebKitWebsiteDataTypes GetTypes(this MentorLake.WebKit2.WebKitWebsiteDataHandle website_data)
	{
		if (website_data.IsInvalid) throw new Exception("Invalid handle (WebKitWebsiteData)");
		return WebKitWebsiteDataExterns.webkit_website_data_get_types(website_data);
	}

/// <summary>
/// <para>
/// Atomically increments the reference count of @website_data by one.
/// </para>
/// <para>
/// This function is MT-safe and may be called from any thread.
/// </para>
/// </summary>

/// <param name="website_data">
/// a #WebKitWebsiteData
/// </param>
/// <return>
/// The passed #WebKitWebsiteData
/// </return>

	public static MentorLake.WebKit2.WebKitWebsiteDataHandle Ref(this MentorLake.WebKit2.WebKitWebsiteDataHandle website_data)
	{
		if (website_data.IsInvalid) throw new Exception("Invalid handle (WebKitWebsiteData)");
		return WebKitWebsiteDataExterns.webkit_website_data_ref(website_data);
	}

/// <summary>
/// <para>
/// Atomically decrements the reference count of @website_data by one.
/// </para>
/// <para>
/// If the reference count drops to 0, all memory allocated by
/// #WebKitWebsiteData is released. This function is MT-safe and may be
/// called from any thread.
/// </para>
/// </summary>

/// <param name="website_data">
/// A #WebKitWebsiteData
/// </param>

	public static void Unref(this MentorLake.WebKit2.WebKitWebsiteDataHandle website_data)
	{
		if (website_data.IsInvalid) throw new Exception("Invalid handle (WebKitWebsiteData)");
		WebKitWebsiteDataExterns.webkit_website_data_unref(website_data);
	}


	public static WebKitWebsiteData Dereference(this WebKitWebsiteDataHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitWebsiteData>(x.DangerousGetHandle());
}
internal class WebKitWebsiteDataExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_website_data_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsiteDataHandle>))] MentorLake.WebKit2.WebKitWebsiteDataHandle website_data);

	[DllImport(WebKit2Library.Name)]
	internal static extern ulong webkit_website_data_get_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsiteDataHandle>))] MentorLake.WebKit2.WebKitWebsiteDataHandle website_data, MentorLake.WebKit2.WebKitWebsiteDataTypes types);

	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.WebKit2.WebKitWebsiteDataTypes webkit_website_data_get_types([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsiteDataHandle>))] MentorLake.WebKit2.WebKitWebsiteDataHandle website_data);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsiteDataHandle>))]
	internal static extern MentorLake.WebKit2.WebKitWebsiteDataHandle webkit_website_data_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsiteDataHandle>))] MentorLake.WebKit2.WebKitWebsiteDataHandle website_data);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_website_data_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsiteDataHandle>))] MentorLake.WebKit2.WebKitWebsiteDataHandle website_data);

}

/// <summary>
/// <para>
/// Data stored locally by a web site.
/// </para>
/// <para>
/// WebKitWebsiteData represents data stored in the client by a particular website.
/// A website is normally a set of URLs grouped by domain name. You can get the website name,
/// which is usually the domain, with webkit_website_data_get_name().
/// Documents loaded from the file system, like file:// URIs, are all grouped in the same WebKitWebsiteData
/// with the name &quot;Local files&quot;.
/// </para>
/// <para>
/// A website can store different types of data in the client side. #WebKitWebsiteDataTypes is an enum containing
/// all the possible data types; use webkit_website_data_get_types() to get the bitmask of data types.
/// It&apos;s also possible to know the size of the data stored for some of the #WebKitWebsiteDataTypes by using
/// webkit_website_data_get_size().
/// </para>
/// <para>
/// A list of WebKitWebsiteData can be retrieved with webkit_website_data_manager_fetch(). See #WebKitWebsiteDataManager
/// for more information.
/// </para>
/// </summary>

public struct WebKitWebsiteData
{
}
