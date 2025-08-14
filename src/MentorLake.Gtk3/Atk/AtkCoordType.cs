namespace MentorLake.Atk;

/// <summary>
/// <para>
/// Specifies how xy coordinates are to be interpreted. Used by functions such
/// as atk_component_get_position() and atk_text_get_character_extents()
/// </para>
/// </summary>

[Flags]
public enum AtkCoordType
{
/// <summary>
/// <para>
/// specifies xy coordinates relative to the screen
/// </para>
/// </summary>

	ATK_XY_SCREEN = 0,
/// <summary>
/// <para>
/// specifies xy coordinates relative to the widget's
/// top-level window
/// </para>
/// </summary>

	ATK_XY_WINDOW = 1,
/// <summary>
/// <para>
/// specifies xy coordinates relative to the widget's
/// immediate parent. Since: 2.30
/// </para>
/// </summary>

	ATK_XY_PARENT = 2
}
