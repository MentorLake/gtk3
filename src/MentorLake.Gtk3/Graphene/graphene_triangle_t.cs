namespace MentorLake.Graphene;

/// <summary>
/// <para>
/// A triangle.
/// </para>
/// </summary>

public class graphene_triangle_tHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Allocates a new #graphene_triangle_t.
/// </para>
/// <para>
/// The contents of the returned structure are undefined.
/// </para>
/// </summary>

/// <return>
/// the newly allocated #graphene_triangle_t
///   structure. Use graphene_triangle_free() to free the resources
///   allocated by this function
/// </return>

	public static MentorLake.Graphene.graphene_triangle_tHandle Alloc()
	{
		return graphene_triangle_tExterns.graphene_triangle_alloc();
	}

}


public static class graphene_triangle_tExtensions
{
/// <summary>
/// <para>
/// Checks whether the given triangle @t contains the point @p.
/// </para>
/// </summary>

/// <param name="t">
/// a #graphene_triangle_t
/// </param>
/// <param name="p">
/// a #graphene_point3d_t
/// </param>
/// <return>
/// `true` if the point is inside the triangle
/// </return>

	public static bool ContainsPoint(this MentorLake.Graphene.graphene_triangle_tHandle t, MentorLake.Graphene.graphene_point3d_tHandle p)
	{
		if (t.IsInvalid) throw new Exception("Invalid handle (graphene_triangle_t)");
		return graphene_triangle_tExterns.graphene_triangle_contains_point(t, p);
	}

/// <summary>
/// <para>
/// Checks whether the two given #graphene_triangle_t are equal.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_triangle_t
/// </param>
/// <param name="b">
/// a #graphene_triangle_t
/// </param>
/// <return>
/// `true` if the triangles are equal
/// </return>

	public static bool Equal(this MentorLake.Graphene.graphene_triangle_tHandle a, MentorLake.Graphene.graphene_triangle_tHandle b)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_triangle_t)");
		return graphene_triangle_tExterns.graphene_triangle_equal(a, b);
	}

/// <summary>
/// <para>
/// Frees the resources allocated by graphene_triangle_alloc().
/// </para>
/// </summary>

/// <param name="t">
/// a #graphene_triangle_t
/// </param>

	public static void Free(this MentorLake.Graphene.graphene_triangle_tHandle t)
	{
		if (t.IsInvalid) throw new Exception("Invalid handle (graphene_triangle_t)");
		graphene_triangle_tExterns.graphene_triangle_free(t);
	}

/// <summary>
/// <para>
/// Computes the area of the given #graphene_triangle_t.
/// </para>
/// </summary>

/// <param name="t">
/// a #graphene_triangle_t
/// </param>
/// <return>
/// the area of the triangle
/// </return>

	public static float GetArea(this MentorLake.Graphene.graphene_triangle_tHandle t)
	{
		if (t.IsInvalid) throw new Exception("Invalid handle (graphene_triangle_t)");
		return graphene_triangle_tExterns.graphene_triangle_get_area(t);
	}

/// <summary>
/// <para>
/// Computes the [barycentric coordinates](http://en.wikipedia.org/wiki/Barycentric_coordinate_system)
/// of the given point @p.
/// </para>
/// <para>
/// The point @p must lie on the same plane as the triangle @t; if the
/// point is not coplanar, the result of this function is undefined.
/// </para>
/// <para>
/// If we place the origin in the coordinates of the triangle's A point,
/// the barycentric coordinates are `u`, which is on the AC vector; and `v`
/// which is on the AB vector:
/// </para>
/// <para>
/// ![](triangle-barycentric.png)
/// </para>
/// <para>
/// The returned #graphene_vec2_t contains the following values, in order:
/// </para>
/// <para>
///  - `res.x = u`
///  - `res.y = v`
/// </para>
/// </summary>

/// <param name="t">
/// a #graphene_triangle_t
/// </param>
/// <param name="p">
/// a #graphene_point3d_t
/// </param>
/// <param name="res">
/// return location for the vector
///   with the barycentric coordinates
/// </param>
/// <return>
/// `true` if the barycentric coordinates are valid
/// </return>

	public static bool GetBarycoords(this MentorLake.Graphene.graphene_triangle_tHandle t, MentorLake.Graphene.graphene_point3d_tHandle p, out MentorLake.Graphene.graphene_vec2_t res)
	{
		if (t.IsInvalid) throw new Exception("Invalid handle (graphene_triangle_t)");
		return graphene_triangle_tExterns.graphene_triangle_get_barycoords(t, p, out res);
	}

/// <summary>
/// <para>
/// Computes the bounding box of the given #graphene_triangle_t.
/// </para>
/// </summary>

/// <param name="t">
/// a #graphene_triangle_t
/// </param>
/// <param name="res">
/// return location for the box
/// </param>

	public static void GetBoundingBox(this MentorLake.Graphene.graphene_triangle_tHandle t, out MentorLake.Graphene.graphene_box_t res)
	{
		if (t.IsInvalid) throw new Exception("Invalid handle (graphene_triangle_t)");
		graphene_triangle_tExterns.graphene_triangle_get_bounding_box(t, out res);
	}

/// <summary>
/// <para>
/// Computes the coordinates of the midpoint of the given #graphene_triangle_t.
/// </para>
/// <para>
/// The midpoint G is the [centroid](https://en.wikipedia.org/wiki/Centroid#Triangle_centroid)
/// of the triangle, i.e. the intersection of its medians.
/// </para>
/// </summary>

/// <param name="t">
/// a #graphene_triangle_t
/// </param>
/// <param name="res">
/// return location for the coordinates of
///   the midpoint
/// </param>

	public static void GetMidpoint(this MentorLake.Graphene.graphene_triangle_tHandle t, out MentorLake.Graphene.graphene_point3d_t res)
	{
		if (t.IsInvalid) throw new Exception("Invalid handle (graphene_triangle_t)");
		graphene_triangle_tExterns.graphene_triangle_get_midpoint(t, out res);
	}

/// <summary>
/// <para>
/// Computes the normal vector of the given #graphene_triangle_t.
/// </para>
/// </summary>

/// <param name="t">
/// a #graphene_triangle_t
/// </param>
/// <param name="res">
/// return location for the normal vector
/// </param>

	public static void GetNormal(this MentorLake.Graphene.graphene_triangle_tHandle t, out MentorLake.Graphene.graphene_vec3_t res)
	{
		if (t.IsInvalid) throw new Exception("Invalid handle (graphene_triangle_t)");
		graphene_triangle_tExterns.graphene_triangle_get_normal(t, out res);
	}

/// <summary>
/// <para>
/// Computes the plane based on the vertices of the given #graphene_triangle_t.
/// </para>
/// </summary>

/// <param name="t">
/// a #graphene_triangle_t
/// </param>
/// <param name="res">
/// return location for the plane
/// </param>

	public static void GetPlane(this MentorLake.Graphene.graphene_triangle_tHandle t, out MentorLake.Graphene.graphene_plane_t res)
	{
		if (t.IsInvalid) throw new Exception("Invalid handle (graphene_triangle_t)");
		graphene_triangle_tExterns.graphene_triangle_get_plane(t, out res);
	}

/// <summary>
/// <para>
/// Retrieves the three vertices of the given #graphene_triangle_t and returns
/// their coordinates as #graphene_point3d_t.
/// </para>
/// </summary>

/// <param name="t">
/// a #graphene_triangle_t
/// </param>
/// <param name="a">
/// return location for the coordinates
///   of the first vertex
/// </param>
/// <param name="b">
/// return location for the coordinates
///   of the second vertex
/// </param>
/// <param name="c">
/// return location for the coordinates
///   of the third vertex
/// </param>

	public static void GetPoints(this MentorLake.Graphene.graphene_triangle_tHandle t, out MentorLake.Graphene.graphene_point3d_t a, out MentorLake.Graphene.graphene_point3d_t b, out MentorLake.Graphene.graphene_point3d_t c)
	{
		if (t.IsInvalid) throw new Exception("Invalid handle (graphene_triangle_t)");
		graphene_triangle_tExterns.graphene_triangle_get_points(t, out a, out b, out c);
	}

/// <summary>
/// <para>
/// Computes the UV coordinates of the given point @p.
/// </para>
/// <para>
/// The point @p must lie on the same plane as the triangle @t; if the point
/// is not coplanar, the result of this function is undefined. If @p is %NULL,
/// the point will be set in (0, 0, 0).
/// </para>
/// <para>
/// The UV coordinates will be placed in the @res vector:
/// </para>
/// <para>
///  - `res.x = u`
///  - `res.y = v`
/// </para>
/// <para>
/// See also: graphene_triangle_get_barycoords()
/// </para>
/// </summary>

/// <param name="t">
/// a #graphene_triangle_t
/// </param>
/// <param name="p">
/// a #graphene_point3d_t
/// </param>
/// <param name="uv_a">
/// the UV coordinates of the first point
/// </param>
/// <param name="uv_b">
/// the UV coordinates of the second point
/// </param>
/// <param name="uv_c">
/// the UV coordinates of the third point
/// </param>
/// <param name="res">
/// a vector containing the UV coordinates
///   of the given point @p
/// </param>
/// <return>
/// `true` if the coordinates are valid
/// </return>

	public static bool GetUv(this MentorLake.Graphene.graphene_triangle_tHandle t, MentorLake.Graphene.graphene_point3d_tHandle p, MentorLake.Graphene.graphene_vec2_tHandle uv_a, MentorLake.Graphene.graphene_vec2_tHandle uv_b, MentorLake.Graphene.graphene_vec2_tHandle uv_c, out MentorLake.Graphene.graphene_vec2_t res)
	{
		if (t.IsInvalid) throw new Exception("Invalid handle (graphene_triangle_t)");
		return graphene_triangle_tExterns.graphene_triangle_get_uv(t, p, uv_a, uv_b, uv_c, out res);
	}

/// <summary>
/// <para>
/// Retrieves the three vertices of the given #graphene_triangle_t.
/// </para>
/// </summary>

/// <param name="t">
/// a #graphene_triangle_t
/// </param>
/// <param name="a">
/// return location for the first vertex
/// </param>
/// <param name="b">
/// return location for the second vertex
/// </param>
/// <param name="c">
/// return location for the third vertex
/// </param>

	public static void GetVertices(this MentorLake.Graphene.graphene_triangle_tHandle t, out MentorLake.Graphene.graphene_vec3_t a, out MentorLake.Graphene.graphene_vec3_t b, out MentorLake.Graphene.graphene_vec3_t c)
	{
		if (t.IsInvalid) throw new Exception("Invalid handle (graphene_triangle_t)");
		graphene_triangle_tExterns.graphene_triangle_get_vertices(t, out a, out b, out c);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_triangle_t using the three given arrays
/// of floating point values, each representing the coordinates of
/// a point in 3D space.
/// </para>
/// </summary>

/// <param name="t">
/// the #graphene_triangle_t to initialize
/// </param>
/// <param name="a">
/// an array of 3 floating point values
/// </param>
/// <param name="b">
/// an array of 3 floating point values
/// </param>
/// <param name="c">
/// an array of 3 floating point values
/// </param>
/// <return>
/// the initialized #graphene_triangle_t
/// </return>

	public static MentorLake.Graphene.graphene_triangle_tHandle InitFromFloat(this MentorLake.Graphene.graphene_triangle_tHandle t, float[] a, float[] b, float[] c)
	{
		if (t.IsInvalid) throw new Exception("Invalid handle (graphene_triangle_t)");
		return graphene_triangle_tExterns.graphene_triangle_init_from_float(t, a, b, c);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_triangle_t using the three given 3D points.
/// </para>
/// </summary>

/// <param name="t">
/// the #graphene_triangle_t to initialize
/// </param>
/// <param name="a">
/// a #graphene_point3d_t
/// </param>
/// <param name="b">
/// a #graphene_point3d_t
/// </param>
/// <param name="c">
/// a #graphene_point3d_t
/// </param>
/// <return>
/// the initialized #graphene_triangle_t
/// </return>

	public static MentorLake.Graphene.graphene_triangle_tHandle InitFromPoint3D(this MentorLake.Graphene.graphene_triangle_tHandle t, MentorLake.Graphene.graphene_point3d_tHandle a, MentorLake.Graphene.graphene_point3d_tHandle b, MentorLake.Graphene.graphene_point3d_tHandle c)
	{
		if (t.IsInvalid) throw new Exception("Invalid handle (graphene_triangle_t)");
		return graphene_triangle_tExterns.graphene_triangle_init_from_point3d(t, a, b, c);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_triangle_t using the three given vectors.
/// </para>
/// </summary>

/// <param name="t">
/// the #graphene_triangle_t to initialize
/// </param>
/// <param name="a">
/// a #graphene_vec3_t
/// </param>
/// <param name="b">
/// a #graphene_vec3_t
/// </param>
/// <param name="c">
/// a #graphene_vec3_t
/// </param>
/// <return>
/// the initialized #graphene_triangle_t
/// </return>

	public static MentorLake.Graphene.graphene_triangle_tHandle InitFromVec3(this MentorLake.Graphene.graphene_triangle_tHandle t, MentorLake.Graphene.graphene_vec3_tHandle a, MentorLake.Graphene.graphene_vec3_tHandle b, MentorLake.Graphene.graphene_vec3_tHandle c)
	{
		if (t.IsInvalid) throw new Exception("Invalid handle (graphene_triangle_t)");
		return graphene_triangle_tExterns.graphene_triangle_init_from_vec3(t, a, b, c);
	}


	public static graphene_triangle_t Dereference(this graphene_triangle_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<graphene_triangle_t>(x.DangerousGetHandle());
}
internal class graphene_triangle_tExterns
{
	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_triangle_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_triangle_tHandle graphene_triangle_alloc();

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_triangle_contains_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_triangle_tHandle>))] MentorLake.Graphene.graphene_triangle_tHandle t, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle p);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_triangle_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_triangle_tHandle>))] MentorLake.Graphene.graphene_triangle_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_triangle_tHandle>))] MentorLake.Graphene.graphene_triangle_tHandle b);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_triangle_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_triangle_tHandle>))] MentorLake.Graphene.graphene_triangle_tHandle t);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_triangle_get_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_triangle_tHandle>))] MentorLake.Graphene.graphene_triangle_tHandle t);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_triangle_get_barycoords([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_triangle_tHandle>))] MentorLake.Graphene.graphene_triangle_tHandle t, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle p, out MentorLake.Graphene.graphene_vec2_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_triangle_get_bounding_box([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_triangle_tHandle>))] MentorLake.Graphene.graphene_triangle_tHandle t, out MentorLake.Graphene.graphene_box_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_triangle_get_midpoint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_triangle_tHandle>))] MentorLake.Graphene.graphene_triangle_tHandle t, out MentorLake.Graphene.graphene_point3d_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_triangle_get_normal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_triangle_tHandle>))] MentorLake.Graphene.graphene_triangle_tHandle t, out MentorLake.Graphene.graphene_vec3_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_triangle_get_plane([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_triangle_tHandle>))] MentorLake.Graphene.graphene_triangle_tHandle t, out MentorLake.Graphene.graphene_plane_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_triangle_get_points([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_triangle_tHandle>))] MentorLake.Graphene.graphene_triangle_tHandle t, out MentorLake.Graphene.graphene_point3d_t a, out MentorLake.Graphene.graphene_point3d_t b, out MentorLake.Graphene.graphene_point3d_t c);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_triangle_get_uv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_triangle_tHandle>))] MentorLake.Graphene.graphene_triangle_tHandle t, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle p, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle uv_a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle uv_b, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle uv_c, out MentorLake.Graphene.graphene_vec2_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_triangle_get_vertices([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_triangle_tHandle>))] MentorLake.Graphene.graphene_triangle_tHandle t, out MentorLake.Graphene.graphene_vec3_t a, out MentorLake.Graphene.graphene_vec3_t b, out MentorLake.Graphene.graphene_vec3_t c);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_triangle_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_triangle_tHandle graphene_triangle_init_from_float([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_triangle_tHandle>))] MentorLake.Graphene.graphene_triangle_tHandle t, float[] a, float[] b, float[] c);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_triangle_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_triangle_tHandle graphene_triangle_init_from_point3d([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_triangle_tHandle>))] MentorLake.Graphene.graphene_triangle_tHandle t, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle b, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle c);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_triangle_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_triangle_tHandle graphene_triangle_init_from_vec3([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_triangle_tHandle>))] MentorLake.Graphene.graphene_triangle_tHandle t, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle b, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle c);

}

/// <summary>
/// <para>
/// A triangle.
/// </para>
/// </summary>

public struct graphene_triangle_t
{
}
