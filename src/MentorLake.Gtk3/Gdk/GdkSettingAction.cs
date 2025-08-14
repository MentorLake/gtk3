namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Specifies the kind of modification applied to a setting in a
/// #GdkEventSetting.
/// </para>
/// </summary>

[Flags]
public enum GdkSettingAction
{
/// <summary>
/// <para>
/// a setting was added.
/// </para>
/// </summary>

	GDK_SETTING_ACTION_NEW = 0,
/// <summary>
/// <para>
/// a setting was changed.
/// </para>
/// </summary>

	GDK_SETTING_ACTION_CHANGED = 1,
/// <summary>
/// <para>
/// a setting was deleted.
/// </para>
/// </summary>

	GDK_SETTING_ACTION_DELETED = 2
}
