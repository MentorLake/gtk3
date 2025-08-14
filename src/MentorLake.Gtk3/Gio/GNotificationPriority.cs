namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Priority levels for #GNotifications.
/// </para>
/// </summary>

[Flags]
public enum GNotificationPriority
{
/// <summary>
/// <para>
/// the default priority, to be used for the
///   majority of notifications (for example email messages, software updates,
///   completed download/sync operations)
/// </para>
/// </summary>

	G_NOTIFICATION_PRIORITY_NORMAL = 0,
/// <summary>
/// <para>
/// for notifications that do not require
///   immediate attention - typically used for contextual background
///   information, such as contact birthdays or local weather
/// </para>
/// </summary>

	G_NOTIFICATION_PRIORITY_LOW = 1,
/// <summary>
/// <para>
/// for events that require more attention,
///   usually because responses are time-sensitive (for example chat and SMS
///   messages or alarms)
/// </para>
/// </summary>

	G_NOTIFICATION_PRIORITY_HIGH = 2,
/// <summary>
/// <para>
/// for urgent notifications, or notifications
///   that require a response in a short space of time (for example phone calls
///   or emergency warnings)
/// </para>
/// </summary>

	G_NOTIFICATION_PRIORITY_URGENT = 3
}
