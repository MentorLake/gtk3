namespace MentorLake.Gio;

/// <summary>
/// <para>
/// #GPasswordSave is used to indicate the lifespan of a saved password.
/// </para>
/// <para>
/// #Gvfs stores passwords in the Gnome keyring when this flag allows it
/// to, and later retrieves it again from there.
/// </para>
/// </summary>

[Flags]
public enum GPasswordSave
{
/// <summary>
/// <para>
/// never save a password.
/// </para>
/// </summary>

	G_PASSWORD_SAVE_NEVER = 0,
/// <summary>
/// <para>
/// save a password for the session.
/// </para>
/// </summary>

	G_PASSWORD_SAVE_FOR_SESSION = 1,
/// <summary>
/// <para>
/// save a password permanently.
/// </para>
/// </summary>

	G_PASSWORD_SAVE_PERMANENTLY = 2
}
