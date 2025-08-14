namespace MentorLake.Graphene;

/// <summary>
/// <para>
/// A 3D volume delimited by 2D clip planes.
/// </para>
/// <para>
/// The contents of the `graphene_frustum_t` are private, and should not be
/// modified directly.
/// </para>
/// </summary>

public class graphene_frustum_tHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Allocates a new #graphene_frustum_t structure.
/// </para>
/// <para>
/// The contents of the returned structure are undefined.
/// </para>
/// </summary>

/// <return>
/// the newly allocated #graphene_frustum_t
///   structure. Use graphene_frustum_free() to free the resources
///   allocated by this function.
/// </return>

	public static MentorLake.Graphene.graphene_frustum_tHandle Alloc()
	{
		return graphene_frustum_tExterns.graphene_frustum_alloc();
	}

}


public static class graphene_frustum_tExtensions
{
/// <summary>
/// <para>
/// Checks whether a point is inside the volume defined by the given
/// #graphene_frustum_t.
/// </para>
/// </summary>

/// <param name="f">
/// a #graphene_frustum_t
/// </param>
/// <param name="point">
/// a #graphene_point3d_t
/// </param>
/// <return>
/// `true` if the point is inside the frustum
/// </return>

	public static bool ContainsPoint(this MentorLake.Graphene.graphene_frustum_tHandle f, MentorLake.Graphene.graphene_point3d_tHandle point)
	{
		if (f.IsInvalid) throw new Exception("Invalid handle (graphene_frustum_t)");
		return graphene_frustum_tExterns.graphene_frustum_contains_point(f, point);
	}

/// <summary>
/// <para>
/// Checks whether the two given #graphene_frustum_t are equal.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_frustum_t
/// </param>
/// <param name="b">
/// a #graphene_frustum_t
/// </param>
/// <return>
/// `true` if the given frustums are equal
/// </return>

	public static bool Equal(this MentorLake.Graphene.graphene_frustum_tHandle a, MentorLake.Graphene.graphene_frustum_tHandle b)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_frustum_t)");
		return graphene_frustum_tExterns.graphene_frustum_equal(a, b);
	}

/// <summary>
/// <para>
/// Frees the resources allocated by graphene_frustum_alloc().
/// </para>
/// </summary>

/// <param name="f">
/// a #graphene_frustum_t
/// </param>

	public static void Free(this MentorLake.Graphene.graphene_frustum_tHandle f)
	{
		if (f.IsInvalid) throw new Exception("Invalid handle (graphene_frustum_t)");
		graphene_frustum_tExterns.graphene_frustum_free(f);
	}

/// <summary>
/// <para>
/// Retrieves the planes that define the given #graphene_frustum_t.
/// </para>
/// </summary>

/// <param name="f">
/// a #graphene_frustum_t
/// </param>
/// <param name="planes">
/// return location for an array
///   of 6 #graphene_plane_t
/// </param>

	public static void GetPlanes(this MentorLake.Graphene.graphene_frustum_tHandle f, out MentorLake.Graphene.graphene_plane_t[] planes)
	{
		if (f.IsInvalid) throw new Exception("Invalid handle (graphene_frustum_t)");
		graphene_frustum_tExterns.graphene_frustum_get_planes(f, out planes);
	}

/// <summary>
/// <para>
/// Initializes the given #graphene_frustum_t using the provided
/// clipping planes.
/// </para>
/// </summary>

/// <param name="f">
/// the #graphene_frustum_t to initialize
/// </param>
/// <param name="p0">
/// a clipping plane
/// </param>
/// <param name="p1">
/// a clipping plane
/// </param>
/// <param name="p2">
/// a clipping plane
/// </param>
/// <param name="p3">
/// a clipping plane
/// </param>
/// <param name="p4">
/// a clipping plane
/// </param>
/// <param name="p5">
/// a clipping plane
/// </param>
/// <return>
/// the initialized frustum
/// </return>

	public static MentorLake.Graphene.graphene_frustum_tHandle Init(this MentorLake.Graphene.graphene_frustum_tHandle f, MentorLake.Graphene.graphene_plane_tHandle p0, MentorLake.Graphene.graphene_plane_tHandle p1, MentorLake.Graphene.graphene_plane_tHandle p2, MentorLake.Graphene.graphene_plane_tHandle p3, MentorLake.Graphene.graphene_plane_tHandle p4, MentorLake.Graphene.graphene_plane_tHandle p5)
	{
		if (f.IsInvalid) throw new Exception("Invalid handle (graphene_frustum_t)");
		return graphene_frustum_tExterns.graphene_frustum_init(f, p0, p1, p2, p3, p4, p5);
	}

/// <summary>
/// <para>
/// Initializes the given #graphene_frustum_t using the clipping
/// planes of another #graphene_frustum_t.
/// </para>
/// </summary>

/// <param name="f">
/// the #graphene_frustum_t to initialize
/// </param>
/// <param name="src">
/// a #graphene_frustum_t
/// </param>
/// <return>
/// the initialized frustum
/// </return>

	public static MentorLake.Graphene.graphene_frustum_tHandle InitFromFrustum(this MentorLake.Graphene.graphene_frustum_tHandle f, MentorLake.Graphene.graphene_frustum_tHandle src)
	{
		if (f.IsInvalid) throw new Exception("Invalid handle (graphene_frustum_t)");
		return graphene_frustum_tExterns.graphene_frustum_init_from_frustum(f, src);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_frustum_t using the given @matrix.
/// </para>
/// </summary>

/// <param name="f">
/// a #graphene_frustum_t
/// </param>
/// <param name="matrix">
/// a #graphene_matrix_t
/// </param>
/// <return>
/// the initialized frustum
/// </return>

	public static MentorLake.Graphene.graphene_frustum_tHandle InitFromMatrix(this MentorLake.Graphene.graphene_frustum_tHandle f, MentorLake.Graphene.graphene_matrix_tHandle matrix)
	{
		if (f.IsInvalid) throw new Exception("Invalid handle (graphene_frustum_t)");
		return graphene_frustum_tExterns.graphene_frustum_init_from_matrix(f, matrix);
	}

/// <summary>
/// <para>
/// Checks whether the given @box intersects a plane of
/// a #graphene_frustum_t.
/// </para>
/// </summary>

/// <param name="f">
/// a #graphene_frustum_t
/// </param>
/// <param name="box">
/// a #graphene_box_t
/// </param>
/// <return>
/// `true` if the box intersects the frustum
/// </return>

	public static bool IntersectsBox(this MentorLake.Graphene.graphene_frustum_tHandle f, MentorLake.Graphene.graphene_box_tHandle box)
	{
		if (f.IsInvalid) throw new Exception("Invalid handle (graphene_frustum_t)");
		return graphene_frustum_tExterns.graphene_frustum_intersects_box(f, box);
	}

/// <summary>
/// <para>
/// Checks whether the given @sphere intersects a plane of
/// a #graphene_frustum_t.
/// </para>
/// </summary>

/// <param name="f">
/// a #graphene_frustum_t
/// </param>
/// <param name="sphere">
/// a #graphene_sphere_t
/// </param>
/// <return>
/// `true` if the sphere intersects the frustum
/// </return>

	public static bool IntersectsSphere(this MentorLake.Graphene.graphene_frustum_tHandle f, MentorLake.Graphene.graphene_sphere_tHandle sphere)
	{
		if (f.IsInvalid) throw new Exception("Invalid handle (graphene_frustum_t)");
		return graphene_frustum_tExterns.graphene_frustum_intersects_sphere(f, sphere);
	}


	public static graphene_frustum_t Dereference(this graphene_frustum_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<graphene_frustum_t>(x.DangerousGetHandle());
}
internal class graphene_frustum_tExterns
{
	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_frustum_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_frustum_tHandle graphene_frustum_alloc();

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_frustum_contains_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_frustum_tHandle>))] MentorLake.Graphene.graphene_frustum_tHandle f, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle point);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_frustum_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_frustum_tHandle>))] MentorLake.Graphene.graphene_frustum_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_frustum_tHandle>))] MentorLake.Graphene.graphene_frustum_tHandle b);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_frustum_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_frustum_tHandle>))] MentorLake.Graphene.graphene_frustum_tHandle f);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_frustum_get_planes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_frustum_tHandle>))] MentorLake.Graphene.graphene_frustum_tHandle f, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] out MentorLake.Graphene.graphene_plane_t[] planes);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_frustum_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_frustum_tHandle graphene_frustum_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_frustum_tHandle>))] MentorLake.Graphene.graphene_frustum_tHandle f, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))] MentorLake.Graphene.graphene_plane_tHandle p0, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))] MentorLake.Graphene.graphene_plane_tHandle p1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))] MentorLake.Graphene.graphene_plane_tHandle p2, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))] MentorLake.Graphene.graphene_plane_tHandle p3, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))] MentorLake.Graphene.graphene_plane_tHandle p4, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))] MentorLake.Graphene.graphene_plane_tHandle p5);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_frustum_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_frustum_tHandle graphene_frustum_init_from_frustum([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_frustum_tHandle>))] MentorLake.Graphene.graphene_frustum_tHandle f, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_frustum_tHandle>))] MentorLake.Graphene.graphene_frustum_tHandle src);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_frustum_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_frustum_tHandle graphene_frustum_init_from_matrix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_frustum_tHandle>))] MentorLake.Graphene.graphene_frustum_tHandle f, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle matrix);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_frustum_intersects_box([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_frustum_tHandle>))] MentorLake.Graphene.graphene_frustum_tHandle f, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle box);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_frustum_intersects_sphere([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_frustum_tHandle>))] MentorLake.Graphene.graphene_frustum_tHandle f, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_sphere_tHandle>))] MentorLake.Graphene.graphene_sphere_tHandle sphere);

}

/// <summary>
/// <para>
/// A 3D volume delimited by 2D clip planes.
/// </para>
/// <para>
/// The contents of the `graphene_frustum_t` are private, and should not be
/// modified directly.
/// </para>
/// </summary>

public struct graphene_frustum_t
{
}
