namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values representing the duration for which a credential persists.
/// </para>
/// </summary>

[Flags]
public enum WebKitCredentialPersistence
{
/// <summary>
/// <para>
/// Credential does not persist
/// </para>
/// </summary>

	WEBKIT_CREDENTIAL_PERSISTENCE_NONE = 0,
/// <summary>
/// <para>
/// Credential persists for session only
/// </para>
/// </summary>

	WEBKIT_CREDENTIAL_PERSISTENCE_FOR_SESSION = 1,
/// <summary>
/// <para>
/// Credential persists permanently
/// </para>
/// </summary>

	WEBKIT_CREDENTIAL_PERSISTENCE_PERMANENT = 2
}
