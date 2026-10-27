namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Represents a plugin, enabling fine-grained control.
/// </para>
/// <para>
/// This object represents a single plugin, found while scanning the
/// various platform plugin directories. This object can be used to get
/// more information about a plugin, and enable/disable it, allowing
/// fine-grained control of plugins. The list of available plugins can
/// be obtained from the #WebKitWebContext, with
/// webkit_web_context_get_plugins().
/// </para>
/// </summary>

public class WebKitPluginHandle : GObjectHandle
{
}

public static class WebKitPluginHandleExtensions
{
/// <summary>
/// <para>
/// Obtain the plugin description.
/// </para>
/// </summary>

/// <param name="plugin">
/// a #WebKitPlugin
/// </param>
/// <return>
/// description, as a string.
/// </return>

	public static string GetDescription(this MentorLake.WebKit2.WebKitPluginHandle plugin)
	{
		if (plugin.IsInvalid) throw new Exception("Invalid handle (WebKitPluginHandle)");
		return WebKitPluginHandleExterns.webkit_plugin_get_description(plugin);
	}

/// <summary>
/// <para>
/// Get information about MIME types handled by the plugin.
/// </para>
/// <para>
/// Get information about MIME types handled by the plugin,
/// as a list of #WebKitMimeInfo.
/// </para>
/// </summary>

/// <param name="plugin">
/// a #WebKitPlugin
/// </param>
/// <return>
/// a #GList of #WebKitMimeInfo.
/// </return>

	public static MentorLake.GLib.GListHandle GetMimeInfoList(this MentorLake.WebKit2.WebKitPluginHandle plugin)
	{
		if (plugin.IsInvalid) throw new Exception("Invalid handle (WebKitPluginHandle)");
		return WebKitPluginHandleExterns.webkit_plugin_get_mime_info_list(plugin);
	}

/// <summary>
/// <para>
/// Obtain the plugin name.
/// </para>
/// </summary>

/// <param name="plugin">
/// a #WebKitPlugin
/// </param>
/// <return>
/// name, as a string.
/// </return>

	public static string GetName(this MentorLake.WebKit2.WebKitPluginHandle plugin)
	{
		if (plugin.IsInvalid) throw new Exception("Invalid handle (WebKitPluginHandle)");
		return WebKitPluginHandleExterns.webkit_plugin_get_name(plugin);
	}

/// <summary>
/// <para>
/// Obtain the absolute path where the plugin is installed.
/// </para>
/// </summary>

/// <param name="plugin">
/// a #WebKitPlugin
/// </param>
/// <return>
/// path, as a string.
/// </return>

	public static string GetPath(this MentorLake.WebKit2.WebKitPluginHandle plugin)
	{
		if (plugin.IsInvalid) throw new Exception("Invalid handle (WebKitPluginHandle)");
		return WebKitPluginHandleExterns.webkit_plugin_get_path(plugin);
	}

}

internal class WebKitPluginHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_plugin_get_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitPluginHandle>))] MentorLake.WebKit2.WebKitPluginHandle plugin);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle webkit_plugin_get_mime_info_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitPluginHandle>))] MentorLake.WebKit2.WebKitPluginHandle plugin);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_plugin_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitPluginHandle>))] MentorLake.WebKit2.WebKitPluginHandle plugin);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_plugin_get_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitPluginHandle>))] MentorLake.WebKit2.WebKitPluginHandle plugin);

}
