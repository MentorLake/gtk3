namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values used to denote the various plugin and media errors.
/// </para>
/// </summary>

[Flags]
public enum WebKitPluginError
{
/// <summary>
/// <para>
/// Generic plugin load failure. Deprecated 2.32
/// </para>
/// </summary>

	WEBKIT_PLUGIN_ERROR_FAILED = 299,
/// <summary>
/// <para>
/// Load failure due to missing plugin. Deprecated 2.32
/// </para>
/// </summary>

	WEBKIT_PLUGIN_ERROR_CANNOT_FIND_PLUGIN = 200,
/// <summary>
/// <para>
/// Load failure due to inability to load plugin. Deprecated 2.32
/// </para>
/// </summary>

	WEBKIT_PLUGIN_ERROR_CANNOT_LOAD_PLUGIN = 201,
/// <summary>
/// <para>
/// Load failure due to missing Java support that is required to load plugin. Deprecated 2.32
/// </para>
/// </summary>

	WEBKIT_PLUGIN_ERROR_JAVA_UNAVAILABLE = 202,
/// <summary>
/// <para>
/// Load failure due to connection cancellation. Deprecated 2.32
/// </para>
/// </summary>

	WEBKIT_PLUGIN_ERROR_CONNECTION_CANCELLED = 203,
/// <summary>
/// <para>
/// Preliminary load failure for media content types. A new load will be started to perform the media load.
/// </para>
/// </summary>

	WEBKIT_PLUGIN_ERROR_WILL_HANDLE_LOAD = 204
}
