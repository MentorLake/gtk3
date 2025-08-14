namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkTargetFlags enumeration is used to specify
/// constraints on a #GtkTargetEntry.
/// </para>
/// </summary>

[Flags]
public enum GtkTargetFlags : uint
{
/// <summary>
/// <para>
/// If this is set, the target will only be selected
///   for drags within a single application.
/// </para>
/// </summary>

	GTK_TARGET_SAME_APP = 1,
/// <summary>
/// <para>
/// If this is set, the target will only be selected
///   for drags within a single widget.
/// </para>
/// </summary>

	GTK_TARGET_SAME_WIDGET = 2,
/// <summary>
/// <para>
/// If this is set, the target will not be selected
///   for drags within a single application.
/// </para>
/// </summary>

	GTK_TARGET_OTHER_APP = 4,
/// <summary>
/// <para>
/// If this is set, the target will not be selected
///   for drags withing a single widget.
/// </para>
/// </summary>

	GTK_TARGET_OTHER_WIDGET = 8
}
