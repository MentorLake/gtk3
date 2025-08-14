namespace MentorLake.Graphene;

/// <summary>
/// <para>
/// The type of intersection.
/// </para>
/// </summary>

[Flags]
public enum graphene_ray_intersection_kind_t
{
/// <summary>
/// <para>
/// No intersection
/// </para>
/// </summary>

	GRAPHENE_RAY_INTERSECTION_KIND_NONE = 0,
/// <summary>
/// <para>
/// The ray is entering the intersected
///   object
/// </para>
/// </summary>

	GRAPHENE_RAY_INTERSECTION_KIND_ENTER = 1,
/// <summary>
/// <para>
/// The ray is leaving the intersected
///   object
/// </para>
/// </summary>

	GRAPHENE_RAY_INTERSECTION_KIND_LEAVE = 2
}
