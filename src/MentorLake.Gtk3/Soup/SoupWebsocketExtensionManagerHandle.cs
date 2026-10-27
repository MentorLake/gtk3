namespace MentorLake.Soup;

/// <summary>
/// <para>
/// SoupWebsocketExtensionManager is the [iface@SessionFeature] that handles WebSockets
/// extensions for a [class@Session].
/// </para>
/// <para>
/// A [class@WebsocketExtensionManager] is added to the session by default, and normally
/// you don&apos;t need to worry about it at all. However, if you want to
/// disable WebSocket extensions, you can remove the feature from the
/// session with [method@Session.remove_feature_by_type] or disable it on
/// individual requests with [method@Message.disable_feature].
/// </para>
/// </summary>

public class SoupWebsocketExtensionManagerHandle : GObjectHandle, SoupSessionFeatureHandle
{
}

public static class SoupWebsocketExtensionManagerHandleExtensions
{
}

internal class SoupWebsocketExtensionManagerHandleExterns
{
}
