namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Flags used when constructing an instance of a #GDBusProxy derived class.
/// </para>
/// </summary>

[Flags]
public enum GDBusProxyFlags : uint
{
/// <summary>
/// <para>
/// No flags set.
/// </para>
/// </summary>

	G_DBUS_PROXY_FLAGS_NONE = 0,
/// <summary>
/// <para>
/// Don&apos;t load properties.
/// </para>
/// </summary>

	G_DBUS_PROXY_FLAGS_DO_NOT_LOAD_PROPERTIES = 1,
/// <summary>
/// <para>
/// Don&apos;t connect to signals on the remote object.
/// </para>
/// </summary>

	G_DBUS_PROXY_FLAGS_DO_NOT_CONNECT_SIGNALS = 2,
/// <summary>
/// <para>
/// If the proxy is for a well-known name,
/// do not ask the bus to launch an owner during proxy initialization or a method call.
/// This flag is only meaningful in proxies for well-known names.
/// </para>
/// </summary>

	G_DBUS_PROXY_FLAGS_DO_NOT_AUTO_START = 4,
/// <summary>
/// <para>
/// If set, the property value for any __invalidated property__ will be (asynchronously) retrieved upon receiving the &amp;lt;see href=&quot;http://dbus.freedesktop.org/doc/dbus-specification.html#standard-interfaces-properties&quot;&amp;gt;PropertiesChanged&amp;lt;/see&amp;gt; D-Bus signal and the property will not cause emission of the #GDBusProxy::g-properties-changed signal. When the value is received the #GDBusProxy::g-properties-changed signal is emitted for the property along with the retrieved value. Since 2.32.
/// </para>
/// </summary>

	G_DBUS_PROXY_FLAGS_GET_INVALIDATED_PROPERTIES = 8,
/// <summary>
/// <para>
/// If the proxy is for a well-known name,
/// do not ask the bus to launch an owner during proxy initialization, but allow it to be
/// autostarted by a method call. This flag is only meaningful in proxies for well-known names,
/// and only if %G_DBUS_PROXY_FLAGS_DO_NOT_AUTO_START is not also specified.
/// </para>
/// </summary>

	G_DBUS_PROXY_FLAGS_DO_NOT_AUTO_START_AT_CONSTRUCTION = 16,
/// <summary>
/// <para>
/// Don&apos;t actually send the AddMatch D-Bus
///    call for this signal subscription. This gives you more control
///    over which match rules you add (but you must add them manually). (Since: 2.72)
/// </para>
/// </summary>

	G_DBUS_PROXY_FLAGS_NO_MATCH_RULE = 32
}
