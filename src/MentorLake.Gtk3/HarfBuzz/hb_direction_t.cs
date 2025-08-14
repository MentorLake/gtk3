namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// The direction of a text segment or buffer.
/// </para>
/// <para>
/// A segment can also be tested for horizontal or vertical
/// orientation (irrespective of specific direction) with
/// HB_DIRECTION_IS_HORIZONTAL() or HB_DIRECTION_IS_VERTICAL().
/// </para>
/// </summary>

[Flags]
public enum hb_direction_t
{
/// <summary>
/// <para>
/// Initial, unset direction.
/// </para>
/// </summary>

	HB_DIRECTION_INVALID = 0,
/// <summary>
/// <para>
/// Text is set horizontally from left to right.
/// </para>
/// </summary>

	HB_DIRECTION_LTR = 4,
/// <summary>
/// <para>
/// Text is set horizontally from right to left.
/// </para>
/// </summary>

	HB_DIRECTION_RTL = 5,
/// <summary>
/// <para>
/// Text is set vertically from top to bottom.
/// </para>
/// </summary>

	HB_DIRECTION_TTB = 6,
/// <summary>
/// <para>
/// Text is set vertically from bottom to top.
/// </para>
/// </summary>

	HB_DIRECTION_BTT = 7
}
