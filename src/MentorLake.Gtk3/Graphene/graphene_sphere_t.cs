namespace MentorLake.Graphene;

/// <summary>
/// <para>
/// A sphere, represented by its center and radius.
/// </para>
/// </summary>

public class graphene_sphere_tHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Allocates a new #graphene_sphere_t.
/// </para>
/// <para>
/// The contents of the newly allocated structure are undefined.
/// </para>
/// </summary>

/// <return>
/// the newly allocated #graphene_sphere_t. Use
///   graphene_sphere_free() to free the resources allocated by this function
/// </return>

	public static MentorLake.Graphene.graphene_sphere_tHandle Alloc()
	{
		return graphene_sphere_tExterns.graphene_sphere_alloc();
	}

}


public static class graphene_sphere_tExtensions
{
/// <summary>
/// <para>
/// Checks whether the given @point is contained in the volume
/// of a #graphene_sphere_t.
/// </para>
/// </summary>

/// <param name="s">
/// a #graphene_sphere_t
/// </param>
/// <param name="point">
/// a #graphene_point3d_t
/// </param>
/// <return>
/// `true` if the sphere contains the point
/// </return>

	public static bool ContainsPoint(this MentorLake.Graphene.graphene_sphere_tHandle s, MentorLake.Graphene.graphene_point3d_tHandle point)
	{
		if (s.IsInvalid) throw new Exception("Invalid handle (graphene_sphere_t)");
		return graphene_sphere_tExterns.graphene_sphere_contains_point(s, point);
	}

/// <summary>
/// <para>
/// Computes the distance of the given @point from the surface of
/// a #graphene_sphere_t.
/// </para>
/// </summary>

/// <param name="s">
/// a #graphene_sphere_t
/// </param>
/// <param name="point">
/// a #graphene_point3d_t
/// </param>
/// <return>
/// the distance of the point
/// </return>

	public static float Distance(this MentorLake.Graphene.graphene_sphere_tHandle s, MentorLake.Graphene.graphene_point3d_tHandle point)
	{
		if (s.IsInvalid) throw new Exception("Invalid handle (graphene_sphere_t)");
		return graphene_sphere_tExterns.graphene_sphere_distance(s, point);
	}

/// <summary>
/// <para>
/// Checks whether two #graphene_sphere_t are equal.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_sphere_t
/// </param>
/// <param name="b">
/// a #graphene_sphere_t
/// </param>
/// <return>
/// `true` if the spheres are equal
/// </return>

	public static bool Equal(this MentorLake.Graphene.graphene_sphere_tHandle a, MentorLake.Graphene.graphene_sphere_tHandle b)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_sphere_t)");
		return graphene_sphere_tExterns.graphene_sphere_equal(a, b);
	}

/// <summary>
/// <para>
/// Frees the resources allocated by graphene_sphere_alloc().
/// </para>
/// </summary>

/// <param name="s">
/// a #graphene_sphere_t
/// </param>

	public static void Free(this MentorLake.Graphene.graphene_sphere_tHandle s)
	{
		if (s.IsInvalid) throw new Exception("Invalid handle (graphene_sphere_t)");
		graphene_sphere_tExterns.graphene_sphere_free(s);
	}

/// <summary>
/// <para>
/// Computes the bounding box capable of containing the
/// given #graphene_sphere_t.
/// </para>
/// </summary>

/// <param name="s">
/// a #graphene_sphere_t
/// </param>
/// <param name="box">
/// return location for the bounding box
/// </param>

	public static void GetBoundingBox(this MentorLake.Graphene.graphene_sphere_tHandle s, out MentorLake.Graphene.graphene_box_t box)
	{
		if (s.IsInvalid) throw new Exception("Invalid handle (graphene_sphere_t)");
		graphene_sphere_tExterns.graphene_sphere_get_bounding_box(s, out box);
	}

/// <summary>
/// <para>
/// Retrieves the coordinates of the center of a #graphene_sphere_t.
/// </para>
/// </summary>

/// <param name="s">
/// a #graphene_sphere_t
/// </param>
/// <param name="center">
/// return location for the coordinates of
///   the center
/// </param>

	public static void GetCenter(this MentorLake.Graphene.graphene_sphere_tHandle s, out MentorLake.Graphene.graphene_point3d_t center)
	{
		if (s.IsInvalid) throw new Exception("Invalid handle (graphene_sphere_t)");
		graphene_sphere_tExterns.graphene_sphere_get_center(s, out center);
	}

/// <summary>
/// <para>
/// Retrieves the radius of a #graphene_sphere_t.
/// </para>
/// </summary>

/// <param name="s">
/// a #graphene_sphere_t
/// </param>

	public static float GetRadius(this MentorLake.Graphene.graphene_sphere_tHandle s)
	{
		if (s.IsInvalid) throw new Exception("Invalid handle (graphene_sphere_t)");
		return graphene_sphere_tExterns.graphene_sphere_get_radius(s);
	}

/// <summary>
/// <para>
/// Initializes the given #graphene_sphere_t with the given @center and @radius.
/// </para>
/// </summary>

/// <param name="s">
/// the #graphene_sphere_t to initialize
/// </param>
/// <param name="center">
/// the coordinates of the center of the sphere, or %NULL
///   for a center in (0, 0, 0)
/// </param>
/// <param name="radius">
/// the radius of the sphere
/// </param>
/// <return>
/// the initialized #graphene_sphere_t
/// </return>

	public static MentorLake.Graphene.graphene_sphere_tHandle Init(this MentorLake.Graphene.graphene_sphere_tHandle s, MentorLake.Graphene.graphene_point3d_tHandle center, float radius)
	{
		if (s.IsInvalid) throw new Exception("Invalid handle (graphene_sphere_t)");
		return graphene_sphere_tExterns.graphene_sphere_init(s, center, radius);
	}

/// <summary>
/// <para>
/// Initializes the given #graphene_sphere_t using the given array
/// of 3D coordinates so that the sphere includes them.
/// </para>
/// <para>
/// The center of the sphere can either be specified, or will be center
/// of the 3D volume that encompasses all @points.
/// </para>
/// </summary>

/// <param name="s">
/// the #graphene_sphere_t to initialize
/// </param>
/// <param name="n_points">
/// the number of #graphene_point3d_t in the @points array
/// </param>
/// <param name="points">
/// an array of #graphene_point3d_t
/// </param>
/// <param name="center">
/// the center of the sphere
/// </param>
/// <return>
/// the initialized #graphene_sphere_t
/// </return>

	public static MentorLake.Graphene.graphene_sphere_tHandle InitFromPoints(this MentorLake.Graphene.graphene_sphere_tHandle s, uint n_points, MentorLake.Graphene.graphene_point3d_t[] points, MentorLake.Graphene.graphene_point3d_tHandle center)
	{
		if (s.IsInvalid) throw new Exception("Invalid handle (graphene_sphere_t)");
		return graphene_sphere_tExterns.graphene_sphere_init_from_points(s, n_points, points, center);
	}

/// <summary>
/// <para>
/// Initializes the given #graphene_sphere_t using the given array
/// of 3D coordinates so that the sphere includes them.
/// </para>
/// <para>
/// The center of the sphere can either be specified, or will be center
/// of the 3D volume that encompasses all @vectors.
/// </para>
/// </summary>

/// <param name="s">
/// the #graphene_sphere_t to initialize
/// </param>
/// <param name="n_vectors">
/// the number of #graphene_vec3_t in the @vectors array
/// </param>
/// <param name="vectors">
/// an array of #graphene_vec3_t
/// </param>
/// <param name="center">
/// the center of the sphere
/// </param>
/// <return>
/// the initialized #graphene_sphere_t
/// </return>

	public static MentorLake.Graphene.graphene_sphere_tHandle InitFromVectors(this MentorLake.Graphene.graphene_sphere_tHandle s, uint n_vectors, MentorLake.Graphene.graphene_vec3_t[] vectors, MentorLake.Graphene.graphene_point3d_tHandle center)
	{
		if (s.IsInvalid) throw new Exception("Invalid handle (graphene_sphere_t)");
		return graphene_sphere_tExterns.graphene_sphere_init_from_vectors(s, n_vectors, vectors, center);
	}

/// <summary>
/// <para>
/// Checks whether the sphere has a zero radius.
/// </para>
/// </summary>

/// <param name="s">
/// a #graphene_sphere_t
/// </param>
/// <return>
/// `true` if the sphere is empty
/// </return>

	public static bool IsEmpty(this MentorLake.Graphene.graphene_sphere_tHandle s)
	{
		if (s.IsInvalid) throw new Exception("Invalid handle (graphene_sphere_t)");
		return graphene_sphere_tExterns.graphene_sphere_is_empty(s);
	}

/// <summary>
/// <para>
/// Translates the center of the given #graphene_sphere_t using the @point
/// coordinates as the delta of the translation.
/// </para>
/// </summary>

/// <param name="s">
/// a #graphene_sphere_t
/// </param>
/// <param name="point">
/// the coordinates of the translation
/// </param>
/// <param name="res">
/// return location for the translated sphere
/// </param>

	public static void Translate(this MentorLake.Graphene.graphene_sphere_tHandle s, MentorLake.Graphene.graphene_point3d_tHandle point, out MentorLake.Graphene.graphene_sphere_t res)
	{
		if (s.IsInvalid) throw new Exception("Invalid handle (graphene_sphere_t)");
		graphene_sphere_tExterns.graphene_sphere_translate(s, point, out res);
	}


	public static graphene_sphere_t Dereference(this graphene_sphere_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<graphene_sphere_t>(x.DangerousGetHandle());
}
internal class graphene_sphere_tExterns
{
	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_sphere_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_sphere_tHandle graphene_sphere_alloc();

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_sphere_contains_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_sphere_tHandle>))] MentorLake.Graphene.graphene_sphere_tHandle s, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle point);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_sphere_distance([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_sphere_tHandle>))] MentorLake.Graphene.graphene_sphere_tHandle s, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle point);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_sphere_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_sphere_tHandle>))] MentorLake.Graphene.graphene_sphere_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_sphere_tHandle>))] MentorLake.Graphene.graphene_sphere_tHandle b);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_sphere_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_sphere_tHandle>))] MentorLake.Graphene.graphene_sphere_tHandle s);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_sphere_get_bounding_box([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_sphere_tHandle>))] MentorLake.Graphene.graphene_sphere_tHandle s, out MentorLake.Graphene.graphene_box_t box);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_sphere_get_center([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_sphere_tHandle>))] MentorLake.Graphene.graphene_sphere_tHandle s, out MentorLake.Graphene.graphene_point3d_t center);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_sphere_get_radius([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_sphere_tHandle>))] MentorLake.Graphene.graphene_sphere_tHandle s);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_sphere_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_sphere_tHandle graphene_sphere_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_sphere_tHandle>))] MentorLake.Graphene.graphene_sphere_tHandle s, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle center, float radius);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_sphere_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_sphere_tHandle graphene_sphere_init_from_points([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_sphere_tHandle>))] MentorLake.Graphene.graphene_sphere_tHandle s, uint n_points, MentorLake.Graphene.graphene_point3d_t[] points, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle center);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_sphere_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_sphere_tHandle graphene_sphere_init_from_vectors([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_sphere_tHandle>))] MentorLake.Graphene.graphene_sphere_tHandle s, uint n_vectors, MentorLake.Graphene.graphene_vec3_t[] vectors, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle center);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_sphere_is_empty([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_sphere_tHandle>))] MentorLake.Graphene.graphene_sphere_tHandle s);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_sphere_translate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_sphere_tHandle>))] MentorLake.Graphene.graphene_sphere_tHandle s, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle point, out MentorLake.Graphene.graphene_sphere_t res);

}

/// <summary>
/// <para>
/// A sphere, represented by its center and radius.
/// </para>
/// </summary>

public struct graphene_sphere_t
{
}
