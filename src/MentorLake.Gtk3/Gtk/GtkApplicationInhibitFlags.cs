namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Types of user actions that may be blocked by gtk_application_inhibit().
/// </para>
/// </summary>

[Flags]
public enum GtkApplicationInhibitFlags : uint
{
/// <summary>
/// <para>
/// Inhibit ending the user session
///     by logging out or by shutting down the computer
/// </para>
/// </summary>

	GTK_APPLICATION_INHIBIT_LOGOUT = 1,
/// <summary>
/// <para>
/// Inhibit user switching
/// </para>
/// </summary>

	GTK_APPLICATION_INHIBIT_SWITCH = 2,
/// <summary>
/// <para>
/// Inhibit suspending the
///     session or computer
/// </para>
/// </summary>

	GTK_APPLICATION_INHIBIT_SUSPEND = 4,
/// <summary>
/// <para>
/// Inhibit the session being
///     marked as idle (and possibly locked)
/// </para>
/// </summary>

	GTK_APPLICATION_INHIBIT_IDLE = 8
}
