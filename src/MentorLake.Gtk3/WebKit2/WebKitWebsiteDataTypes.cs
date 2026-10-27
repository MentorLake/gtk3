namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values with flags representing types of Website data.
/// </para>
/// </summary>

[Flags]
public enum WebKitWebsiteDataTypes : uint
{
/// <summary>
/// <para>
/// Memory cache.
/// </para>
/// </summary>

	WEBKIT_WEBSITE_DATA_MEMORY_CACHE = 1,
/// <summary>
/// <para>
/// HTTP disk cache.
/// </para>
/// </summary>

	WEBKIT_WEBSITE_DATA_DISK_CACHE = 2,
/// <summary>
/// <para>
/// Offline web application cache.
/// </para>
/// </summary>

	WEBKIT_WEBSITE_DATA_OFFLINE_APPLICATION_CACHE = 4,
/// <summary>
/// <para>
/// Session storage data.
/// </para>
/// </summary>

	WEBKIT_WEBSITE_DATA_SESSION_STORAGE = 8,
/// <summary>
/// <para>
/// Local storage data.
/// </para>
/// </summary>

	WEBKIT_WEBSITE_DATA_LOCAL_STORAGE = 16,
/// <summary>
/// <para>
/// WebSQL databases. Deprecated 2.24
/// </para>
/// </summary>

	WEBKIT_WEBSITE_DATA_WEBSQL_DATABASES = 32,
/// <summary>
/// <para>
/// IndexedDB databases.
/// </para>
/// </summary>

	WEBKIT_WEBSITE_DATA_INDEXEDDB_DATABASES = 64,
/// <summary>
/// <para>
/// Plugins data. Deprecated 2.32
/// </para>
/// </summary>

	WEBKIT_WEBSITE_DATA_PLUGIN_DATA = 128,
/// <summary>
/// <para>
/// Cookies.
/// </para>
/// </summary>

	WEBKIT_WEBSITE_DATA_COOKIES = 256,
/// <summary>
/// <para>
/// Hash salt used to generate the device ids used by webpages. Since 2.24
/// </para>
/// </summary>

	WEBKIT_WEBSITE_DATA_DEVICE_ID_HASH_SALT = 512,
/// <summary>
/// <para>
/// HSTS cache. Since 2.26
/// </para>
/// </summary>

	WEBKIT_WEBSITE_DATA_HSTS_CACHE = 1024,
/// <summary>
/// <para>
/// Intelligent Tracking Prevention data. Since 2.30.
/// </para>
/// </summary>

	WEBKIT_WEBSITE_DATA_ITP = 2048,
/// <summary>
/// <para>
/// Service worker registrations. Since 2.30
/// </para>
/// </summary>

	WEBKIT_WEBSITE_DATA_SERVICE_WORKER_REGISTRATIONS = 4096,
/// <summary>
/// <para>
/// DOM (CacheStorage) cache. Since 2.30
/// </para>
/// </summary>

	WEBKIT_WEBSITE_DATA_DOM_CACHE = 8192,
/// <summary>
/// <para>
/// All types.
/// </para>
/// </summary>

	WEBKIT_WEBSITE_DATA_ALL = 16383
}
