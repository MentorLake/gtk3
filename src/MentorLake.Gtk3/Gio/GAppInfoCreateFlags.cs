namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Flags used when creating a #GAppInfo.
/// </para>
/// </summary>

[Flags]
public enum GAppInfoCreateFlags : uint
{
/// <summary>
/// <para>
/// No flags.
/// </para>
/// </summary>

	G_APP_INFO_CREATE_NONE = 0,
/// <summary>
/// <para>
/// Application opens in a terminal window.
/// </para>
/// </summary>

	G_APP_INFO_CREATE_NEEDS_TERMINAL = 1,
/// <summary>
/// <para>
/// Application supports URI arguments.
/// </para>
/// </summary>

	G_APP_INFO_CREATE_SUPPORTS_URIS = 2,
/// <summary>
/// <para>
/// Application supports startup notification. Since 2.26
/// </para>
/// </summary>

	G_APP_INFO_CREATE_SUPPORTS_STARTUP_NOTIFICATION = 4
}
