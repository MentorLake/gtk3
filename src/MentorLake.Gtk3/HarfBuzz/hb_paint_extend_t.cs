namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// The values of this enumeration determine how color values
/// outside the minimum and maximum defined offset on a #hb_color_line_t
/// are determined.
/// </para>
/// <para>
/// See the OpenType spec [COLR](https://learn.microsoft.com/en-us/typography/opentype/spec/colr)
/// section for details.
/// </para>
/// </summary>

[Flags]
public enum hb_paint_extend_t
{
/// <summary>
/// <para>
/// Outside the defined interval,
///   the color of the closest color stop is used.
/// </para>
/// </summary>

	HB_PAINT_EXTEND_PAD = 0,
/// <summary>
/// <para>
/// The color line is repeated over
///   repeated multiples of the defined interval
/// </para>
/// </summary>

	HB_PAINT_EXTEND_REPEAT = 1,
/// <summary>
/// <para>
/// The color line is repeated over
///      repeated intervals, as for the repeat mode.
///      However, in each repeated interval, the ordering of
///      color stops is the reverse of the adjacent interval.
/// </para>
/// </summary>

	HB_PAINT_EXTEND_REFLECT = 2
}
