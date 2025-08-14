namespace MentorLake.Graphene;

/// <summary>
/// <para>
/// A 3D box, described as the volume between a minimum and
/// a maximum vertices.
/// </para>
/// </summary>

public class graphene_box_tHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Allocates a new #graphene_box_t.
/// </para>
/// <para>
/// The contents of the returned structure are undefined.
/// </para>
/// </summary>

/// <return>
/// the newly allocated #graphene_box_t structure.
///   Use graphene_box_free() to free the resources allocated by this function
/// </return>

	public static MentorLake.Graphene.graphene_box_tHandle Alloc()
	{
		return graphene_box_tExterns.graphene_box_alloc();
	}

}


public static class graphene_box_tExtensions
{
/// <summary>
/// <para>
/// Checks whether the #graphene_box_t @a contains the given
/// #graphene_box_t @b.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_box_t
/// </param>
/// <param name="b">
/// a #graphene_box_t
/// </param>
/// <return>
/// `true` if the box is contained in the given box
/// </return>

	public static bool ContainsBox(this MentorLake.Graphene.graphene_box_tHandle a, MentorLake.Graphene.graphene_box_tHandle b)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_box_t)");
		return graphene_box_tExterns.graphene_box_contains_box(a, b);
	}

/// <summary>
/// <para>
/// Checks whether @box contains the given @point.
/// </para>
/// </summary>

/// <param name="box">
/// a #graphene_box_t
/// </param>
/// <param name="point">
/// the coordinates to check
/// </param>
/// <return>
/// `true` if the point is contained in the given box
/// </return>

	public static bool ContainsPoint(this MentorLake.Graphene.graphene_box_tHandle box, MentorLake.Graphene.graphene_point3d_tHandle point)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (graphene_box_t)");
		return graphene_box_tExterns.graphene_box_contains_point(box, point);
	}

/// <summary>
/// <para>
/// Checks whether the two given boxes are equal.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_box_t
/// </param>
/// <param name="b">
/// a #graphene_box_t
/// </param>
/// <return>
/// `true` if the boxes are equal
/// </return>

	public static bool Equal(this MentorLake.Graphene.graphene_box_tHandle a, MentorLake.Graphene.graphene_box_tHandle b)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_box_t)");
		return graphene_box_tExterns.graphene_box_equal(a, b);
	}

/// <summary>
/// <para>
/// Expands the dimensions of @box to include the coordinates at @point.
/// </para>
/// </summary>

/// <param name="box">
/// a #graphene_box_t
/// </param>
/// <param name="point">
/// the coordinates of the point to include
/// </param>
/// <param name="res">
/// return location for the expanded box
/// </param>

	public static void Expand(this MentorLake.Graphene.graphene_box_tHandle box, MentorLake.Graphene.graphene_point3d_tHandle point, out MentorLake.Graphene.graphene_box_t res)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (graphene_box_t)");
		graphene_box_tExterns.graphene_box_expand(box, point, out res);
	}

/// <summary>
/// <para>
/// Expands the dimensions of @box by the given @scalar value.
/// </para>
/// <para>
/// If @scalar is positive, the #graphene_box_t will grow; if @scalar is
/// negative, the #graphene_box_t will shrink.
/// </para>
/// </summary>

/// <param name="box">
/// a #graphene_box_t
/// </param>
/// <param name="scalar">
/// a scalar value
/// </param>
/// <param name="res">
/// return location for the expanded box
/// </param>

	public static void ExpandScalar(this MentorLake.Graphene.graphene_box_tHandle box, float scalar, out MentorLake.Graphene.graphene_box_t res)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (graphene_box_t)");
		graphene_box_tExterns.graphene_box_expand_scalar(box, scalar, out res);
	}

/// <summary>
/// <para>
/// Expands the dimensions of @box to include the coordinates of the
/// given vector.
/// </para>
/// </summary>

/// <param name="box">
/// a #graphene_box_t
/// </param>
/// <param name="vec">
/// the coordinates of the point to include, as a #graphene_vec3_t
/// </param>
/// <param name="res">
/// return location for the expanded box
/// </param>

	public static void ExpandVec3(this MentorLake.Graphene.graphene_box_tHandle box, MentorLake.Graphene.graphene_vec3_tHandle vec, out MentorLake.Graphene.graphene_box_t res)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (graphene_box_t)");
		graphene_box_tExterns.graphene_box_expand_vec3(box, vec, out res);
	}

/// <summary>
/// <para>
/// Frees the resources allocated by graphene_box_alloc().
/// </para>
/// </summary>

/// <param name="box">
/// a #graphene_box_t
/// </param>

	public static void Free(this MentorLake.Graphene.graphene_box_tHandle box)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (graphene_box_t)");
		graphene_box_tExterns.graphene_box_free(box);
	}

/// <summary>
/// <para>
/// Computes the bounding #graphene_sphere_t capable of containing the given
/// #graphene_box_t.
/// </para>
/// </summary>

/// <param name="box">
/// a #graphene_box_t
/// </param>
/// <param name="sphere">
/// return location for the bounding sphere
/// </param>

	public static void GetBoundingSphere(this MentorLake.Graphene.graphene_box_tHandle box, out MentorLake.Graphene.graphene_sphere_t sphere)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (graphene_box_t)");
		graphene_box_tExterns.graphene_box_get_bounding_sphere(box, out sphere);
	}

/// <summary>
/// <para>
/// Retrieves the coordinates of the center of a #graphene_box_t.
/// </para>
/// </summary>

/// <param name="box">
/// a #graphene_box_t
/// </param>
/// <param name="center">
/// return location for the coordinates of
///   the center
/// </param>

	public static void GetCenter(this MentorLake.Graphene.graphene_box_tHandle box, out MentorLake.Graphene.graphene_point3d_t center)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (graphene_box_t)");
		graphene_box_tExterns.graphene_box_get_center(box, out center);
	}

/// <summary>
/// <para>
/// Retrieves the size of the @box on the Z axis.
/// </para>
/// </summary>

/// <param name="box">
/// a #graphene_box_t
/// </param>
/// <return>
/// the depth of the box
/// </return>

	public static float GetDepth(this MentorLake.Graphene.graphene_box_tHandle box)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (graphene_box_t)");
		return graphene_box_tExterns.graphene_box_get_depth(box);
	}

/// <summary>
/// <para>
/// Retrieves the size of the @box on the Y axis.
/// </para>
/// </summary>

/// <param name="box">
/// a #graphene_box_t
/// </param>
/// <return>
/// the height of the box
/// </return>

	public static float GetHeight(this MentorLake.Graphene.graphene_box_tHandle box)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (graphene_box_t)");
		return graphene_box_tExterns.graphene_box_get_height(box);
	}

/// <summary>
/// <para>
/// Retrieves the coordinates of the maximum point of the given
/// #graphene_box_t.
/// </para>
/// </summary>

/// <param name="box">
/// a #graphene_box_t
/// </param>
/// <param name="max">
/// return location for the maximum point
/// </param>

	public static void GetMax(this MentorLake.Graphene.graphene_box_tHandle box, out MentorLake.Graphene.graphene_point3d_t max)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (graphene_box_t)");
		graphene_box_tExterns.graphene_box_get_max(box, out max);
	}

/// <summary>
/// <para>
/// Retrieves the coordinates of the minimum point of the given
/// #graphene_box_t.
/// </para>
/// </summary>

/// <param name="box">
/// a #graphene_box_t
/// </param>
/// <param name="min">
/// return location for the minimum point
/// </param>

	public static void GetMin(this MentorLake.Graphene.graphene_box_tHandle box, out MentorLake.Graphene.graphene_point3d_t min)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (graphene_box_t)");
		graphene_box_tExterns.graphene_box_get_min(box, out min);
	}

/// <summary>
/// <para>
/// Retrieves the size of the box on all three axes, and stores
/// it into the given @size vector.
/// </para>
/// </summary>

/// <param name="box">
/// a #graphene_box_t
/// </param>
/// <param name="size">
/// return location for the size
/// </param>

	public static void GetSize(this MentorLake.Graphene.graphene_box_tHandle box, out MentorLake.Graphene.graphene_vec3_t size)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (graphene_box_t)");
		graphene_box_tExterns.graphene_box_get_size(box, out size);
	}

/// <summary>
/// <para>
/// Computes the vertices of the given #graphene_box_t.
/// </para>
/// </summary>

/// <param name="box">
/// a #graphene_box_t
/// </param>
/// <param name="vertices">
/// return location for an array
///   of 8 #graphene_vec3_t
/// </param>

	public static void GetVertices(this MentorLake.Graphene.graphene_box_tHandle box, out MentorLake.Graphene.graphene_vec3_t[] vertices)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (graphene_box_t)");
		graphene_box_tExterns.graphene_box_get_vertices(box, out vertices);
	}

/// <summary>
/// <para>
/// Retrieves the size of the @box on the X axis.
/// </para>
/// </summary>

/// <param name="box">
/// a #graphene_box_t
/// </param>
/// <return>
/// the width of the box
/// </return>

	public static float GetWidth(this MentorLake.Graphene.graphene_box_tHandle box)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (graphene_box_t)");
		return graphene_box_tExterns.graphene_box_get_width(box);
	}

/// <summary>
/// <para>
/// Initializes the given #graphene_box_t with two vertices.
/// </para>
/// </summary>

/// <param name="box">
/// the #graphene_box_t to initialize
/// </param>
/// <param name="min">
/// the coordinates of the minimum vertex
/// </param>
/// <param name="max">
/// the coordinates of the maximum vertex
/// </param>
/// <return>
/// the initialized #graphene_box_t
/// </return>

	public static MentorLake.Graphene.graphene_box_tHandle Init(this MentorLake.Graphene.graphene_box_tHandle box, MentorLake.Graphene.graphene_point3d_tHandle min, MentorLake.Graphene.graphene_point3d_tHandle max)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (graphene_box_t)");
		return graphene_box_tExterns.graphene_box_init(box, min, max);
	}

/// <summary>
/// <para>
/// Initializes the given #graphene_box_t with the vertices of
/// another #graphene_box_t.
/// </para>
/// </summary>

/// <param name="box">
/// the #graphene_box_t to initialize
/// </param>
/// <param name="src">
/// a #graphene_box_t
/// </param>
/// <return>
/// the initialized #graphene_box_t
/// </return>

	public static MentorLake.Graphene.graphene_box_tHandle InitFromBox(this MentorLake.Graphene.graphene_box_tHandle box, MentorLake.Graphene.graphene_box_tHandle src)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (graphene_box_t)");
		return graphene_box_tExterns.graphene_box_init_from_box(box, src);
	}

/// <summary>
/// <para>
/// Initializes the given #graphene_box_t with the given array
/// of vertices.
/// </para>
/// <para>
/// If @n_points is 0, the returned box is initialized with
/// graphene_box_empty().
/// </para>
/// </summary>

/// <param name="box">
/// the #graphene_box_t to initialize
/// </param>
/// <param name="n_points">
/// the number #graphene_point3d_t in the @points array
/// </param>
/// <param name="points">
/// an array of #graphene_point3d_t
/// </param>
/// <return>
/// the initialized #graphene_box_t
/// </return>

	public static MentorLake.Graphene.graphene_box_tHandle InitFromPoints(this MentorLake.Graphene.graphene_box_tHandle box, uint n_points, MentorLake.Graphene.graphene_point3d_t[] points)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (graphene_box_t)");
		return graphene_box_tExterns.graphene_box_init_from_points(box, n_points, points);
	}

/// <summary>
/// <para>
/// Initializes the given #graphene_box_t with two vertices
/// stored inside #graphene_vec3_t.
/// </para>
/// </summary>

/// <param name="box">
/// the #graphene_box_t to initialize
/// </param>
/// <param name="min">
/// the coordinates of the minimum vertex
/// </param>
/// <param name="max">
/// the coordinates of the maximum vertex
/// </param>
/// <return>
/// the initialized #graphene_box_t
/// </return>

	public static MentorLake.Graphene.graphene_box_tHandle InitFromVec3(this MentorLake.Graphene.graphene_box_tHandle box, MentorLake.Graphene.graphene_vec3_tHandle min, MentorLake.Graphene.graphene_vec3_tHandle max)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (graphene_box_t)");
		return graphene_box_tExterns.graphene_box_init_from_vec3(box, min, max);
	}

/// <summary>
/// <para>
/// Initializes the given #graphene_box_t with the given array
/// of vertices.
/// </para>
/// <para>
/// If @n_vectors is 0, the returned box is initialized with
/// graphene_box_empty().
/// </para>
/// </summary>

/// <param name="box">
/// the #graphene_box_t to initialize
/// </param>
/// <param name="n_vectors">
/// the number #graphene_point3d_t in the @vectors array
/// </param>
/// <param name="vectors">
/// an array of #graphene_vec3_t
/// </param>
/// <return>
/// the initialized #graphene_box_t
/// </return>

	public static MentorLake.Graphene.graphene_box_tHandle InitFromVectors(this MentorLake.Graphene.graphene_box_tHandle box, uint n_vectors, MentorLake.Graphene.graphene_vec3_t[] vectors)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (graphene_box_t)");
		return graphene_box_tExterns.graphene_box_init_from_vectors(box, n_vectors, vectors);
	}

/// <summary>
/// <para>
/// Intersects the two given #graphene_box_t.
/// </para>
/// <para>
/// If the two boxes do not intersect, @res will contain a degenerate box
/// initialized with graphene_box_empty().
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_box_t
/// </param>
/// <param name="b">
/// a #graphene_box_t
/// </param>
/// <param name="res">
/// return location for the result
/// </param>
/// <return>
/// true if the two boxes intersect
/// </return>

	public static bool Intersection(this MentorLake.Graphene.graphene_box_tHandle a, MentorLake.Graphene.graphene_box_tHandle b, out MentorLake.Graphene.graphene_box_t res)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_box_t)");
		return graphene_box_tExterns.graphene_box_intersection(a, b, out res);
	}

/// <summary>
/// <para>
/// Unions the two given #graphene_box_t.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_box_t
/// </param>
/// <param name="b">
/// the box to union to @a
/// </param>
/// <param name="res">
/// return location for the result
/// </param>

	public static void Union(this MentorLake.Graphene.graphene_box_tHandle a, MentorLake.Graphene.graphene_box_tHandle b, out MentorLake.Graphene.graphene_box_t res)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_box_t)");
		graphene_box_tExterns.graphene_box_union(a, b, out res);
	}


	public static graphene_box_t Dereference(this graphene_box_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<graphene_box_t>(x.DangerousGetHandle());
}
internal class graphene_box_tExterns
{
	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_box_tHandle graphene_box_alloc();

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_box_contains_box([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle b);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_box_contains_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle point);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_box_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle b);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_box_expand([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle point, out MentorLake.Graphene.graphene_box_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_box_expand_scalar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle box, float scalar, out MentorLake.Graphene.graphene_box_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_box_expand_vec3([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle vec, out MentorLake.Graphene.graphene_box_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_box_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle box);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_box_get_bounding_sphere([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle box, out MentorLake.Graphene.graphene_sphere_t sphere);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_box_get_center([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle box, out MentorLake.Graphene.graphene_point3d_t center);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_box_get_depth([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle box);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_box_get_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle box);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_box_get_max([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle box, out MentorLake.Graphene.graphene_point3d_t max);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_box_get_min([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle box, out MentorLake.Graphene.graphene_point3d_t min);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_box_get_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle box, out MentorLake.Graphene.graphene_vec3_t size);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_box_get_vertices([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle box, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] out MentorLake.Graphene.graphene_vec3_t[] vertices);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_box_get_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle box);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_box_tHandle graphene_box_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle min, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle max);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_box_tHandle graphene_box_init_from_box([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle src);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_box_tHandle graphene_box_init_from_points([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle box, uint n_points, MentorLake.Graphene.graphene_point3d_t[] points);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_box_tHandle graphene_box_init_from_vec3([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle min, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle max);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_box_tHandle graphene_box_init_from_vectors([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle box, uint n_vectors, MentorLake.Graphene.graphene_vec3_t[] vectors);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_box_intersection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle b, out MentorLake.Graphene.graphene_box_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_box_union([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle b, out MentorLake.Graphene.graphene_box_t res);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_box_tHandle graphene_box_empty();

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_box_tHandle graphene_box_infinite();

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_box_tHandle graphene_box_minus_one();

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_box_tHandle graphene_box_one();

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_box_tHandle graphene_box_one_minus_one();

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_box_tHandle graphene_box_zero();

}

/// <summary>
/// <para>
/// A 3D box, described as the volume between a minimum and
/// a maximum vertices.
/// </para>
/// </summary>

public struct graphene_box_t
{
/// <summary>
/// <para>
/// A degenerate #graphene_box_t that can only be expanded.
/// </para>
/// <para>
/// The returned value is owned by Graphene and should not be modified or freed.
/// </para>
/// </summary>

/// <return>
/// a #graphene_box_t
/// </return>

	public static MentorLake.Graphene.graphene_box_tHandle Empty()
	{
		return graphene_box_tExterns.graphene_box_empty();
	}

/// <summary>
/// <para>
/// A degenerate #graphene_box_t that cannot be expanded.
/// </para>
/// <para>
/// The returned value is owned by Graphene and should not be modified or freed.
/// </para>
/// </summary>

/// <return>
/// a #graphene_box_t
/// </return>

	public static MentorLake.Graphene.graphene_box_tHandle Infinite()
	{
		return graphene_box_tExterns.graphene_box_infinite();
	}

/// <summary>
/// <para>
/// A #graphene_box_t with the minimum vertex set at (-1, -1, -1) and the
/// maximum vertex set at (0, 0, 0).
/// </para>
/// <para>
/// The returned value is owned by Graphene and should not be modified or freed.
/// </para>
/// </summary>

/// <return>
/// a #graphene_box_t
/// </return>

	public static MentorLake.Graphene.graphene_box_tHandle MinusOne()
	{
		return graphene_box_tExterns.graphene_box_minus_one();
	}

/// <summary>
/// <para>
/// A #graphene_box_t with the minimum vertex set at (0, 0, 0) and the
/// maximum vertex set at (1, 1, 1).
/// </para>
/// <para>
/// The returned value is owned by Graphene and should not be modified or freed.
/// </para>
/// </summary>

/// <return>
/// a #graphene_box_t
/// </return>

	public static MentorLake.Graphene.graphene_box_tHandle One()
	{
		return graphene_box_tExterns.graphene_box_one();
	}

/// <summary>
/// <para>
/// A #graphene_box_t with the minimum vertex set at (-1, -1, -1) and the
/// maximum vertex set at (1, 1, 1).
/// </para>
/// <para>
/// The returned value is owned by Graphene and should not be modified or freed.
/// </para>
/// </summary>

/// <return>
/// a #graphene_box_t
/// </return>

	public static MentorLake.Graphene.graphene_box_tHandle OneMinusOne()
	{
		return graphene_box_tExterns.graphene_box_one_minus_one();
	}

/// <summary>
/// <para>
/// A #graphene_box_t with both the minimum and maximum vertices set at (0, 0, 0).
/// </para>
/// <para>
/// The returned value is owned by Graphene and should not be modified or freed.
/// </para>
/// </summary>

/// <return>
/// a #graphene_box_t
/// </return>

	public static MentorLake.Graphene.graphene_box_tHandle Zero()
	{
		return graphene_box_tExterns.graphene_box_zero();
	}

}
