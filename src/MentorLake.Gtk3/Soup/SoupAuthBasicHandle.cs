namespace MentorLake.Soup;

/// <summary>
/// <para>
/// HTTP &quot;Basic&quot; authentication.
/// </para>
/// <para>
/// [class@Session]s support this by default; if you want to disable
/// support for it, call [method@Session.remove_feature_by_type],
/// passing %SOUP_TYPE_AUTH_BASIC.
/// </para>
/// </summary>

public class SoupAuthBasicHandle : SoupAuthHandle
{
}

public static class SoupAuthBasicHandleExtensions
{
}

internal class SoupAuthBasicHandleExterns
{
}
