namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values previously used to denote the different events which can trigger
/// the detection of insecure content. Since 2.46, WebKit generally no longer
/// loads insecure content in secure contexts.
/// </para>
/// </summary>

[Flags]
public enum WebKitInsecureContentEvent
{
/// <summary>
/// <para>
/// Insecure content has been detected by
/// trying to execute any kind of logic (e.g. a script) from an
/// untrusted source.
/// </para>
/// </summary>

	WEBKIT_INSECURE_CONTENT_RUN = 0,
/// <summary>
/// <para>
/// Insecure content has been
/// detected by trying to display any kind of resource (e.g. an image)
/// from an untrusted source.
/// </para>
/// </summary>

	WEBKIT_INSECURE_CONTENT_DISPLAYED = 1
}
