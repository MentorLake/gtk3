namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Used to change the appearance of an outline typically provided by a #GtkFrame.
/// </para>
/// <para>
/// Note that many themes do not differentiate the appearance of the
/// various shadow types: Either their is no visible shadow (@GTK_SHADOW_NONE),
/// or there is (any other value).
/// </para>
/// </summary>

[Flags]
public enum GtkShadowType
{
/// <summary>
/// <para>
/// No outline.
/// </para>
/// </summary>

	GTK_SHADOW_NONE = 0,
/// <summary>
/// <para>
/// The outline is bevelled inwards.
/// </para>
/// </summary>

	GTK_SHADOW_IN = 1,
/// <summary>
/// <para>
/// The outline is bevelled outwards like a button.
/// </para>
/// </summary>

	GTK_SHADOW_OUT = 2,
/// <summary>
/// <para>
/// The outline has a sunken 3d appearance.
/// </para>
/// </summary>

	GTK_SHADOW_ETCHED_IN = 3,
/// <summary>
/// <para>
/// The outline has a raised 3d appearance.
/// </para>
/// </summary>

	GTK_SHADOW_ETCHED_OUT = 4
}
