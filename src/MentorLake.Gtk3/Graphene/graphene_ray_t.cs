namespace MentorLake.Graphene;

/// <summary>
/// <para>
/// A ray emitted from an origin in a given direction.
/// </para>
/// <para>
/// The contents of the `graphene_ray_t` structure are private, and should not
/// be modified directly.
/// </para>
/// </summary>

public class graphene_ray_tHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Allocates a new #graphene_ray_t structure.
/// </para>
/// <para>
/// The contents of the returned structure are undefined.
/// </para>
/// </summary>

/// <return>
/// the newly allocated #graphene_ray_t.
///   Use graphene_ray_free() to free the resources allocated by
///   this function
/// </return>

	public static MentorLake.Graphene.graphene_ray_tHandle Alloc()
	{
		return graphene_ray_tExterns.graphene_ray_alloc();
	}

}


public static class graphene_ray_tExtensions
{
/// <summary>
/// <para>
/// Checks whether the two given #graphene_ray_t are equal.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_ray_t
/// </param>
/// <param name="b">
/// a #graphene_ray_t
/// </param>
/// <return>
/// `true` if the given rays are equal
/// </return>

	public static bool Equal(this MentorLake.Graphene.graphene_ray_tHandle a, MentorLake.Graphene.graphene_ray_tHandle b)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_ray_t)");
		return graphene_ray_tExterns.graphene_ray_equal(a, b);
	}

/// <summary>
/// <para>
/// Frees the resources allocated by graphene_ray_alloc().
/// </para>
/// </summary>

/// <param name="r">
/// a #graphene_ray_t
/// </param>

	public static void Free(this MentorLake.Graphene.graphene_ray_tHandle r)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_ray_t)");
		graphene_ray_tExterns.graphene_ray_free(r);
	}

/// <summary>
/// <para>
/// Computes the point on the given #graphene_ray_t that is closest to the
/// given point @p.
/// </para>
/// </summary>

/// <param name="r">
/// a #graphene_ray_t
/// </param>
/// <param name="p">
/// a #graphene_point3d_t
/// </param>
/// <param name="res">
/// return location for the closest point3d
/// </param>

	public static void GetClosestPointToPoint(this MentorLake.Graphene.graphene_ray_tHandle r, MentorLake.Graphene.graphene_point3d_tHandle p, out MentorLake.Graphene.graphene_point3d_t res)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_ray_t)");
		graphene_ray_tExterns.graphene_ray_get_closest_point_to_point(r, p, out res);
	}

/// <summary>
/// <para>
/// Retrieves the direction of the given #graphene_ray_t.
/// </para>
/// </summary>

/// <param name="r">
/// a #graphene_ray_t
/// </param>
/// <param name="direction">
/// return location for the direction
/// </param>

	public static void GetDirection(this MentorLake.Graphene.graphene_ray_tHandle r, out MentorLake.Graphene.graphene_vec3_t direction)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_ray_t)");
		graphene_ray_tExterns.graphene_ray_get_direction(r, out direction);
	}

/// <summary>
/// <para>
/// Computes the distance of the origin of the given #graphene_ray_t from the
/// given plane.
/// </para>
/// <para>
/// If the ray does not intersect the plane, this function returns `INFINITY`.
/// </para>
/// </summary>

/// <param name="r">
/// a #graphene_ray_t
/// </param>
/// <param name="p">
/// a #graphene_plane_t
/// </param>
/// <return>
/// the distance of the origin of the ray from the plane
/// </return>

	public static float GetDistanceToPlane(this MentorLake.Graphene.graphene_ray_tHandle r, MentorLake.Graphene.graphene_plane_tHandle p)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_ray_t)");
		return graphene_ray_tExterns.graphene_ray_get_distance_to_plane(r, p);
	}

/// <summary>
/// <para>
/// Computes the distance of the closest approach between the
/// given #graphene_ray_t @r and the point @p.
/// </para>
/// <para>
/// The closest approach to a ray from a point is the distance
/// between the point and the projection of the point on the
/// ray itself.
/// </para>
/// </summary>

/// <param name="r">
/// a #graphene_ray_t
/// </param>
/// <param name="p">
/// a #graphene_point3d_t
/// </param>
/// <return>
/// the distance of the point
/// </return>

	public static float GetDistanceToPoint(this MentorLake.Graphene.graphene_ray_tHandle r, MentorLake.Graphene.graphene_point3d_tHandle p)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_ray_t)");
		return graphene_ray_tExterns.graphene_ray_get_distance_to_point(r, p);
	}

/// <summary>
/// <para>
/// Retrieves the origin of the given #graphene_ray_t.
/// </para>
/// </summary>

/// <param name="r">
/// a #graphene_ray_t
/// </param>
/// <param name="origin">
/// return location for the origin
/// </param>

	public static void GetOrigin(this MentorLake.Graphene.graphene_ray_tHandle r, out MentorLake.Graphene.graphene_point3d_t origin)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_ray_t)");
		graphene_ray_tExterns.graphene_ray_get_origin(r, out origin);
	}

/// <summary>
/// <para>
/// Retrieves the coordinates of a point at the distance @t along the
/// given #graphene_ray_t.
/// </para>
/// </summary>

/// <param name="r">
/// a #graphene_ray_t
/// </param>
/// <param name="t">
/// the distance along the ray
/// </param>
/// <param name="position">
/// return location for the position
/// </param>

	public static void GetPositionAt(this MentorLake.Graphene.graphene_ray_tHandle r, float t, out MentorLake.Graphene.graphene_point3d_t position)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_ray_t)");
		graphene_ray_tExterns.graphene_ray_get_position_at(r, t, out position);
	}

/// <summary>
/// <para>
/// Initializes the given #graphene_ray_t using the given @origin
/// and @direction values.
/// </para>
/// </summary>

/// <param name="r">
/// the #graphene_ray_t to initialize
/// </param>
/// <param name="origin">
/// the origin of the ray
/// </param>
/// <param name="direction">
/// the direction vector
/// </param>
/// <return>
/// the initialized ray
/// </return>

	public static MentorLake.Graphene.graphene_ray_tHandle Init(this MentorLake.Graphene.graphene_ray_tHandle r, MentorLake.Graphene.graphene_point3d_tHandle origin, MentorLake.Graphene.graphene_vec3_tHandle direction)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_ray_t)");
		return graphene_ray_tExterns.graphene_ray_init(r, origin, direction);
	}

/// <summary>
/// <para>
/// Initializes the given #graphene_ray_t using the origin and direction
/// values of another #graphene_ray_t.
/// </para>
/// </summary>

/// <param name="r">
/// the #graphene_ray_t to initialize
/// </param>
/// <param name="src">
/// a #graphene_ray_t
/// </param>
/// <return>
/// the initialized ray
/// </return>

	public static MentorLake.Graphene.graphene_ray_tHandle InitFromRay(this MentorLake.Graphene.graphene_ray_tHandle r, MentorLake.Graphene.graphene_ray_tHandle src)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_ray_t)");
		return graphene_ray_tExterns.graphene_ray_init_from_ray(r, src);
	}

/// <summary>
/// <para>
/// Initializes the given #graphene_ray_t using the given vectors.
/// </para>
/// </summary>

/// <param name="r">
/// the #graphene_ray_t to initialize
/// </param>
/// <param name="origin">
/// a #graphene_vec3_t
/// </param>
/// <param name="direction">
/// a #graphene_vec3_t
/// </param>
/// <return>
/// the initialized ray
/// </return>

	public static MentorLake.Graphene.graphene_ray_tHandle InitFromVec3(this MentorLake.Graphene.graphene_ray_tHandle r, MentorLake.Graphene.graphene_vec3_tHandle origin, MentorLake.Graphene.graphene_vec3_tHandle direction)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_ray_t)");
		return graphene_ray_tExterns.graphene_ray_init_from_vec3(r, origin, direction);
	}

/// <summary>
/// <para>
/// Intersects the given #graphene_ray_t @r with the given
/// #graphene_box_t @b.
/// </para>
/// </summary>

/// <param name="r">
/// a #graphene_ray_t
/// </param>
/// <param name="b">
/// a #graphene_box_t
/// </param>
/// <param name="t_out">
/// the distance of the point on the ray that intersects the box
/// </param>
/// <return>
/// the type of intersection
/// </return>

	public static MentorLake.Graphene.graphene_ray_intersection_kind_t IntersectBox(this MentorLake.Graphene.graphene_ray_tHandle r, MentorLake.Graphene.graphene_box_tHandle b, out float t_out)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_ray_t)");
		return graphene_ray_tExterns.graphene_ray_intersect_box(r, b, out t_out);
	}

/// <summary>
/// <para>
/// Intersects the given #graphene_ray_t @r with the given
/// #graphene_sphere_t @s.
/// </para>
/// </summary>

/// <param name="r">
/// a #graphene_ray_t
/// </param>
/// <param name="s">
/// a #graphene_sphere_t
/// </param>
/// <param name="t_out">
/// the distance of the point on the ray that intersects the sphere
/// </param>
/// <return>
/// the type of intersection
/// </return>

	public static MentorLake.Graphene.graphene_ray_intersection_kind_t IntersectSphere(this MentorLake.Graphene.graphene_ray_tHandle r, MentorLake.Graphene.graphene_sphere_tHandle s, out float t_out)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_ray_t)");
		return graphene_ray_tExterns.graphene_ray_intersect_sphere(r, s, out t_out);
	}

/// <summary>
/// <para>
/// Intersects the given #graphene_ray_t @r with the given
/// #graphene_triangle_t @t.
/// </para>
/// </summary>

/// <param name="r">
/// a #graphene_ray_t
/// </param>
/// <param name="t">
/// a #graphene_triangle_t
/// </param>
/// <param name="t_out">
/// the distance of the point on the ray that intersects the triangle
/// </param>
/// <return>
/// the type of intersection
/// </return>

	public static MentorLake.Graphene.graphene_ray_intersection_kind_t IntersectTriangle(this MentorLake.Graphene.graphene_ray_tHandle r, MentorLake.Graphene.graphene_triangle_tHandle t, out float t_out)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_ray_t)");
		return graphene_ray_tExterns.graphene_ray_intersect_triangle(r, t, out t_out);
	}

/// <summary>
/// <para>
/// Checks whether the given #graphene_ray_t @r intersects the
/// given #graphene_box_t @b.
/// </para>
/// <para>
/// See also: graphene_ray_intersect_box()
/// </para>
/// </summary>

/// <param name="r">
/// a #graphene_ray_t
/// </param>
/// <param name="b">
/// a #graphene_box_t
/// </param>
/// <return>
/// `true` if the ray intersects the box
/// </return>

	public static bool IntersectsBox(this MentorLake.Graphene.graphene_ray_tHandle r, MentorLake.Graphene.graphene_box_tHandle b)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_ray_t)");
		return graphene_ray_tExterns.graphene_ray_intersects_box(r, b);
	}

/// <summary>
/// <para>
/// Checks if the given #graphene_ray_t @r intersects the
/// given #graphene_sphere_t @s.
/// </para>
/// <para>
/// See also: graphene_ray_intersect_sphere()
/// </para>
/// </summary>

/// <param name="r">
/// a #graphene_ray_t
/// </param>
/// <param name="s">
/// a #graphene_sphere_t
/// </param>
/// <return>
/// `true` if the ray intersects the sphere
/// </return>

	public static bool IntersectsSphere(this MentorLake.Graphene.graphene_ray_tHandle r, MentorLake.Graphene.graphene_sphere_tHandle s)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_ray_t)");
		return graphene_ray_tExterns.graphene_ray_intersects_sphere(r, s);
	}

/// <summary>
/// <para>
/// Checks whether the given #graphene_ray_t @r intersects the
/// given #graphene_triangle_t @b.
/// </para>
/// <para>
/// See also: graphene_ray_intersect_triangle()
/// </para>
/// </summary>

/// <param name="r">
/// a #graphene_ray_t
/// </param>
/// <param name="t">
/// a #graphene_triangle_t
/// </param>
/// <return>
/// `true` if the ray intersects the triangle
/// </return>

	public static bool IntersectsTriangle(this MentorLake.Graphene.graphene_ray_tHandle r, MentorLake.Graphene.graphene_triangle_tHandle t)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_ray_t)");
		return graphene_ray_tExterns.graphene_ray_intersects_triangle(r, t);
	}


	public static graphene_ray_t Dereference(this graphene_ray_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<graphene_ray_t>(x.DangerousGetHandle());
}
internal class graphene_ray_tExterns
{
	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_ray_tHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_ray_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_ray_tHandle graphene_ray_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_ray_tHandle>))] MentorLake.Graphene.graphene_ray_tHandle r, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle origin, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle direction);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_ray_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_ray_tHandle graphene_ray_init_from_ray([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_ray_tHandle>))] MentorLake.Graphene.graphene_ray_tHandle r, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_ray_tHandle>))] MentorLake.Graphene.graphene_ray_tHandle src);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_ray_tHandle>))]
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

/// <summary>
/// <para>
/// A ray emitted from an origin in a given direction.
/// </para>
/// <para>
/// The contents of the `graphene_ray_t` structure are private, and should not
/// be modified directly.
/// </para>
/// </summary>

public struct graphene_ray_t
{
}
