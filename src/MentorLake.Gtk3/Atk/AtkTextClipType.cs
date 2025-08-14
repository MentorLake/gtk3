namespace MentorLake.Atk;

/// <summary>
/// <para>
/// Describes the type of clipping required.
/// </para>
/// </summary>

[Flags]
public enum AtkTextClipType
{
/// <summary>
/// <para>
/// No clipping to be done
/// </para>
/// </summary>

	ATK_TEXT_CLIP_NONE = 0,
/// <summary>
/// <para>
/// Text clipped by min coordinate is omitted
/// </para>
/// </summary>

	ATK_TEXT_CLIP_MIN = 1,
/// <summary>
/// <para>
/// Text clipped by max coordinate is omitted
/// </para>
/// </summary>

	ATK_TEXT_CLIP_MAX = 2,
/// <summary>
/// <para>
/// Only text fully within mix/max bound is retained
/// </para>
/// </summary>

	ATK_TEXT_CLIP_BOTH = 3
}
