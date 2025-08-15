namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Data type for holding HarfBuzz&apos;s clustering behavior options. The cluster level
/// dictates one aspect of how HarfBuzz will treat non-base characters
/// during shaping.
/// </para>
/// <para>
/// In @HB_BUFFER_CLUSTER_LEVEL_MONOTONE_GRAPHEMES, non-base
/// characters are merged into the cluster of the base character that precedes them.
/// </para>
/// <para>
/// In @HB_BUFFER_CLUSTER_LEVEL_MONOTONE_CHARACTERS, non-base characters are initially
/// assigned their own cluster values, which are not merged into preceding base
/// clusters. This allows HarfBuzz to perform additional operations like reorder
/// sequences of adjacent marks.
/// </para>
/// <para>
/// @HB_BUFFER_CLUSTER_LEVEL_MONOTONE_GRAPHEMES is the default, because it maintains
/// backward compatibility with older versions of HarfBuzz. New client programs that
/// do not need to maintain such backward compatibility are recommended to use
/// @HB_BUFFER_CLUSTER_LEVEL_MONOTONE_CHARACTERS instead of the default.
/// </para>
/// </summary>

[Flags]
public enum hb_buffer_cluster_level_t
{
/// <summary>
/// <para>
/// Return cluster values grouped by graphemes into
///   monotone order.
/// </para>
/// </summary>

	HB_BUFFER_CLUSTER_LEVEL_MONOTONE_GRAPHEMES = 0,
/// <summary>
/// <para>
/// Return cluster values grouped into monotone order.
/// </para>
/// </summary>

	HB_BUFFER_CLUSTER_LEVEL_MONOTONE_CHARACTERS = 1,
/// <summary>
/// <para>
/// Don&apos;t group cluster values.
/// </para>
/// </summary>

	HB_BUFFER_CLUSTER_LEVEL_CHARACTERS = 2,
/// <summary>
/// <para>
/// Default cluster level,
///   equal to @HB_BUFFER_CLUSTER_LEVEL_MONOTONE_GRAPHEMES.
/// </para>
/// </summary>

	HB_BUFFER_CLUSTER_LEVEL_DEFAULT = 0
}
