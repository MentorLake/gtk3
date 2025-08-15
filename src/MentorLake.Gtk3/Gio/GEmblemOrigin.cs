namespace MentorLake.Gio;

/// <summary>
/// <para>
/// GEmblemOrigin is used to add information about the origin of the emblem
/// to #GEmblem.
/// </para>
/// </summary>

[Flags]
public enum GEmblemOrigin
{
/// <summary>
/// <para>
/// Emblem of unknown origin
/// </para>
/// </summary>

	G_EMBLEM_ORIGIN_UNKNOWN = 0,
/// <summary>
/// <para>
/// Emblem adds device-specific information
/// </para>
/// </summary>

	G_EMBLEM_ORIGIN_DEVICE = 1,
/// <summary>
/// <para>
/// Emblem depicts live metadata, such as &quot;readonly&quot;
/// </para>
/// </summary>

	G_EMBLEM_ORIGIN_LIVEMETADATA = 2,
/// <summary>
/// <para>
/// Emblem comes from a user-defined tag, e.g. set by nautilus (in the future)
/// </para>
/// </summary>

	G_EMBLEM_ORIGIN_TAG = 3
}
