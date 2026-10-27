namespace MentorLake.Soup;

/// <summary>
/// <para>
/// HTTP &quot;Digest&quot; authentication.
/// </para>
/// <para>
/// [class@Session]s support this by default; if you want to disable
/// support for it, call [method@Session.remove_feature_by_type]
/// passing %SOUP_TYPE_AUTH_DIGEST.
/// </para>
/// </summary>

public class SoupAuthDigestHandle : SoupAuthHandle
{
}

public static class SoupAuthDigestHandleExtensions
{
}

internal class SoupAuthDigestHandleExterns
{
}
