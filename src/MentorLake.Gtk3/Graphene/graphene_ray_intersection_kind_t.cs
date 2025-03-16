namespace MentorLake.Graphene;

[Flags]
public enum graphene_ray_intersection_kind_t
{
	GRAPHENE_RAY_INTERSECTION_KIND_NONE = 0,
	GRAPHENE_RAY_INTERSECTION_KIND_ENTER = 1,
	GRAPHENE_RAY_INTERSECTION_KIND_LEAVE = 2
}
