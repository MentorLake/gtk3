namespace MentorLake.Graphene;

public class graphene_ray_tHandle : BaseSafeHandle
{
	public static MentorLake.Graphene.graphene_ray_tHandle Alloc()
	{
		return graphene_ray_tExterns.graphene_ray_alloc();
	}

}


public static class graphene_ray_tExtensions
{
	public static bool Equal(this MentorLake.Graphene.graphene_ray_tHandle a, MentorLake.Graphene.graphene_ray_tHandle b)
	{
		return graphene_ray_tExterns.graphene_ray_equal(a, b);
	}

	public static void Free(this MentorLake.Graphene.graphene_ray_tHandle r)
	{
		graphene_ray_tExterns.graphene_ray_free(r);
	}

	public static void GetClosestPointToPoint(this MentorLake.Graphene.graphene_ray_tHandle r, MentorLake.Graphene.graphene_point3d_tHandle p, out MentorLake.Graphene.graphene_point3d_t res)
	{
		graphene_ray_tExterns.graphene_ray_get_closest_point_to_point(r, p, out res);
	}

	public static void GetDirection(this MentorLake.Graphene.graphene_ray_tHandle r, out MentorLake.Graphene.graphene_vec3_t direction)
	{
		graphene_ray_tExterns.graphene_ray_get_direction(r, out direction);
	}

	public static float GetDistanceToPlane(this MentorLake.Graphene.graphene_ray_tHandle r, MentorLake.Graphene.graphene_plane_tHandle p)
	{
		return graphene_ray_tExterns.graphene_ray_get_distance_to_plane(r, p);
	}

	public static float GetDistanceToPoint(this MentorLake.Graphene.graphene_ray_tHandle r, MentorLake.Graphene.graphene_point3d_tHandle p)
	{
		return graphene_ray_tExterns.graphene_ray_get_distance_to_point(r, p);
	}

	public static void GetOrigin(this MentorLake.Graphene.graphene_ray_tHandle r, out MentorLake.Graphene.graphene_point3d_t origin)
	{
		graphene_ray_tExterns.graphene_ray_get_origin(r, out origin);
	}

	public static void GetPositionAt(this MentorLake.Graphene.graphene_ray_tHandle r, float t, out MentorLake.Graphene.graphene_point3d_t position)
	{
		graphene_ray_tExterns.graphene_ray_get_position_at(r, t, out position);
	}

	public static MentorLake.Graphene.graphene_ray_tHandle Init(this MentorLake.Graphene.graphene_ray_tHandle r, MentorLake.Graphene.graphene_point3d_tHandle origin, MentorLake.Graphene.graphene_vec3_tHandle direction)
	{
		return graphene_ray_tExterns.graphene_ray_init(r, origin, direction);
	}

	public static MentorLake.Graphene.graphene_ray_tHandle InitFromRay(this MentorLake.Graphene.graphene_ray_tHandle r, MentorLake.Graphene.graphene_ray_tHandle src)
	{
		return graphene_ray_tExterns.graphene_ray_init_from_ray(r, src);
	}

	public static MentorLake.Graphene.graphene_ray_tHandle InitFromVec3(this MentorLake.Graphene.graphene_ray_tHandle r, MentorLake.Graphene.graphene_vec3_tHandle origin, MentorLake.Graphene.graphene_vec3_tHandle direction)
	{
		return graphene_ray_tExterns.graphene_ray_init_from_vec3(r, origin, direction);
	}

	public static MentorLake.Graphene.graphene_ray_intersection_kind_t IntersectBox(this MentorLake.Graphene.graphene_ray_tHandle r, MentorLake.Graphene.graphene_box_tHandle b, out float t_out)
	{
		return graphene_ray_tExterns.graphene_ray_intersect_box(r, b, out t_out);
	}

	public static MentorLake.Graphene.graphene_ray_intersection_kind_t IntersectSphere(this MentorLake.Graphene.graphene_ray_tHandle r, MentorLake.Graphene.graphene_sphere_tHandle s, out float t_out)
	{
		return graphene_ray_tExterns.graphene_ray_intersect_sphere(r, s, out t_out);
	}

	public static MentorLake.Graphene.graphene_ray_intersection_kind_t IntersectTriangle(this MentorLake.Graphene.graphene_ray_tHandle r, MentorLake.Graphene.graphene_triangle_tHandle t, out float t_out)
	{
		return graphene_ray_tExterns.graphene_ray_intersect_triangle(r, t, out t_out);
	}

	public static bool IntersectsBox(this MentorLake.Graphene.graphene_ray_tHandle r, MentorLake.Graphene.graphene_box_tHandle b)
	{
		return graphene_ray_tExterns.graphene_ray_intersects_box(r, b);
	}

	public static bool IntersectsSphere(this MentorLake.Graphene.graphene_ray_tHandle r, MentorLake.Graphene.graphene_sphere_tHandle s)
	{
		return graphene_ray_tExterns.graphene_ray_intersects_sphere(r, s);
	}

	public static bool IntersectsTriangle(this MentorLake.Graphene.graphene_ray_tHandle r, MentorLake.Graphene.graphene_triangle_tHandle t)
	{
		return graphene_ray_tExterns.graphene_ray_intersects_triangle(r, t);
	}


	public static graphene_ray_t Dereference(this graphene_ray_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<graphene_ray_t>(x.DangerousGetHandle());
}
internal class graphene_ray_tExterns
{
	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_ray_tHandle graphene_ray_alloc();

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_ray_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_ray_tHandle>))] MentorLake.Graphene.graphene_ray_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_ray_tHandle>))] MentorLake.Graphene.graphene_ray_tHandle b);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_ray_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_ray_tHandle>))] MentorLake.Graphene.graphene_ray_tHandle r);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_ray_get_closest_point_to_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_ray_tHandle>))] MentorLake.Graphene.graphene_ray_tHandle r, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle p, out MentorLake.Graphene.graphene_point3d_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_ray_get_direction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_ray_tHandle>))] MentorLake.Graphene.graphene_ray_tHandle r, out MentorLake.Graphene.graphene_vec3_t direction);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_ray_get_distance_to_plane([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_ray_tHandle>))] MentorLake.Graphene.graphene_ray_tHandle r, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))] MentorLake.Graphene.graphene_plane_tHandle p);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_ray_get_distance_to_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_ray_tHandle>))] MentorLake.Graphene.graphene_ray_tHandle r, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle p);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_ray_get_origin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_ray_tHandle>))] MentorLake.Graphene.graphene_ray_tHandle r, out MentorLake.Graphene.graphene_point3d_t origin);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_ray_get_position_at([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_ray_tHandle>))] MentorLake.Graphene.graphene_ray_tHandle r, float t, out MentorLake.Graphene.graphene_point3d_t position);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_ray_tHandle graphene_ray_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_ray_tHandle>))] MentorLake.Graphene.graphene_ray_tHandle r, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle origin, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle direction);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_ray_tHandle graphene_ray_init_from_ray([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_ray_tHandle>))] MentorLake.Graphene.graphene_ray_tHandle r, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_ray_tHandle>))] MentorLake.Graphene.graphene_ray_tHandle src);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_ray_tHandle graphene_ray_init_from_vec3([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_ray_tHandle>))] MentorLake.Graphene.graphene_ray_tHandle r, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle origin, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle direction);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_ray_intersection_kind_t graphene_ray_intersect_box([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_ray_tHandle>))] MentorLake.Graphene.graphene_ray_tHandle r, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle b, out float t_out);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_ray_intersection_kind_t graphene_ray_intersect_sphere([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_ray_tHandle>))] MentorLake.Graphene.graphene_ray_tHandle r, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_sphere_tHandle>))] MentorLake.Graphene.graphene_sphere_tHandle s, out float t_out);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_ray_intersection_kind_t graphene_ray_intersect_triangle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_ray_tHandle>))] MentorLake.Graphene.graphene_ray_tHandle r, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_triangle_tHandle>))] MentorLake.Graphene.graphene_triangle_tHandle t, out float t_out);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_ray_intersects_box([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_ray_tHandle>))] MentorLake.Graphene.graphene_ray_tHandle r, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle b);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_ray_intersects_sphere([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_ray_tHandle>))] MentorLake.Graphene.graphene_ray_tHandle r, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_sphere_tHandle>))] MentorLake.Graphene.graphene_sphere_tHandle s);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_ray_intersects_triangle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_ray_tHandle>))] MentorLake.Graphene.graphene_ray_tHandle r, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_triangle_tHandle>))] MentorLake.Graphene.graphene_triangle_tHandle t);

}

public struct graphene_ray_t
{
}
