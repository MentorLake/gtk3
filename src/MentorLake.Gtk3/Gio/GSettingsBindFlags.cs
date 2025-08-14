namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Flags used when creating a binding. These flags determine in which
/// direction the binding works. The default is to synchronize in both
/// directions.
/// </para>
/// </summary>

[Flags]
public enum GSettingsBindFlags : uint
{
/// <summary>
/// <para>
/// Equivalent to `G_SETTINGS_BIND_GET|G_SETTINGS_BIND_SET`
/// </para>
/// </summary>

	G_SETTINGS_BIND_DEFAULT = 0,
/// <summary>
/// <para>
/// Update the #GObject property when the setting changes.
///     It is an error to use this flag if the property is not writable.
/// </para>
/// </summary>

	G_SETTINGS_BIND_GET = 1,
/// <summary>
/// <para>
/// Update the setting when the #GObject property changes.
///     It is an error to use this flag if the property is not readable.
/// </para>
/// </summary>

	G_SETTINGS_BIND_SET = 2,
/// <summary>
/// <para>
/// Do not try to bind a "sensitivity" property to the writability of the setting
/// </para>
/// </summary>

	G_SETTINGS_BIND_NO_SENSITIVITY = 4,
/// <summary>
/// <para>
/// When set in addition to %G_SETTINGS_BIND_GET, set the #GObject property
///     value initially from the setting, but do not listen for changes of the setting
/// </para>
/// </summary>

	G_SETTINGS_BIND_GET_NO_CHANGES = 8,
/// <summary>
/// <para>
/// When passed to g_settings_bind(), uses a pair of mapping functions that invert
///     the boolean value when mapping between the setting and the property.  The setting and property must both
///     be booleans.  You cannot pass this flag to g_settings_bind_with_mapping().
/// </para>
/// </summary>

	G_SETTINGS_BIND_INVERT_BOOLEAN = 16
}
