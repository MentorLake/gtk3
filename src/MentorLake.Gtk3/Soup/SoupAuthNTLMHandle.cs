namespace MentorLake.Soup;

/// <summary>
/// <para>
/// HTTP-based NTLM authentication.
/// </para>
/// <para>
/// [class@Session]s do not support this type by default; if you want to
/// enable support for it, call [method@Session.add_feature_by_type],
/// passing %SOUP_TYPE_AUTH_NTLM.
/// </para>
/// </summary>

public class SoupAuthNTLMHandle : SoupAuthHandle
{
}

public static class SoupAuthNTLMHandleExtensions
{
}

internal class SoupAuthNTLMHandleExterns
{
}
