namespace MentorLake.Graphene;

/// <summary>
/// <para>
/// A 2D plane that extends infinitely in a 3D volume.
/// </para>
/// <para>
/// The contents of the `graphene_plane_t` are private, and should not be
/// modified directly.
/// </para>
/// </summary>

public class graphene_plane_tHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Allocates a new #graphene_plane_t structure.
/// </para>
/// <para>
/// The contents of the returned structure are undefined.
/// </para>
/// </summary>

/// <return>
/// the newly allocated #graphene_plane_t.
///   Use graphene_plane_free() to free the resources allocated by
///   this function
/// </return>

	public static MentorLake.Graphene.graphene_plane_tHandle Alloc()
	{
		return graphene_plane_tExterns.graphene_plane_alloc();
	}

}


public static class graphene_plane_tExtensions
{
/// <summary>
/// <para>
/// Computes the distance of @point from a #graphene_plane_t.
/// </para>
/// </summary>

/// <param name="p">
/// a #graphene_plane_t
/// </param>
/// <param name="point">
/// a #graphene_point3d_t
/// </param>
/// <return>
/// the distance of the given #graphene_point3d_t from the plane
/// </return>

	public static float Distance(this MentorLake.Graphene.graphene_plane_tHandle p, MentorLake.Graphene.graphene_point3d_tHandle point)
	{
		if (p.IsInvalid) throw new Exception("Invalid handle (graphene_plane_t)");
		return graphene_plane_tExterns.graphene_plane_distance(p, point);
	}

/// <summary>
/// <para>
/// Checks whether the two given #graphene_plane_t are equal.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_plane_t
/// </param>
/// <param name="b">
/// a #graphene_plane_t
/// </param>
/// <return>
/// `true` if the given planes are equal
/// </return>

	public static bool Equal(this MentorLake.Graphene.graphene_plane_tHandle a, MentorLake.Graphene.graphene_plane_tHandle b)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_plane_t)");
		return graphene_plane_tExterns.graphene_plane_equal(a, b);
	}

/// <summary>
/// <para>
/// Frees the resources allocated by graphene_plane_alloc().
/// </para>
/// </summary>

/// <param name="p">
/// a #graphene_plane_t
/// </param>

	public static void Free(this MentorLake.Graphene.graphene_plane_tHandle p)
	{
		if (p.IsInvalid) throw new Exception("Invalid handle (graphene_plane_t)");
		graphene_plane_tExterns.graphene_plane_free(p);
	}

/// <summary>
/// <para>
/// Retrieves the distance along the normal vector of the
/// given #graphene_plane_t from the origin.
/// </para>
/// </summary>

/// <param name="p">
/// a #graphene_plane_t
/// </param>
/// <return>
/// the constant value of the plane
/// </return>

	public static float GetConstant(this MentorLake.Graphene.graphene_plane_tHandle p)
	{
		if (p.IsInvalid) throw new Exception("Invalid handle (graphene_plane_t)");
		return graphene_plane_tExterns.graphene_plane_get_constant(p);
	}

/// <summary>
/// <para>
/// Retrieves the normal vector pointing towards the origin of the
/// given #graphene_plane_t.
/// </para>
/// </summary>

/// <param name="p">
/// a #graphene_plane_t
/// </param>
/// <param name="normal">
/// return location for the normal vector
/// </param>

	public static void GetNormal(this MentorLake.Graphene.graphene_plane_tHandle p, out MentorLake.Graphene.graphene_vec3_t normal)
	{
		if (p.IsInvalid) throw new Exception("Invalid handle (graphene_plane_t)");
		graphene_plane_tExterns.graphene_plane_get_normal(p, out normal);
	}

/// <summary>
/// <para>
/// Initializes the given #graphene_plane_t using the given @normal vector
/// and @constant values.
/// </para>
/// </summary>

/// <param name="p">
/// the #graphene_plane_t to initialize
/// </param>
/// <param name="normal">
/// a unit length normal vector defining the plane
///   pointing towards the origin; if unset, we use the X axis by default
/// </param>
/// <param name="constant">
/// the distance from the origin to the plane along the
///   normal vector; the sign determines the half-space occupied by the
///   plane
/// </param>
/// <return>
/// the initialized plane
/// </return>

	public static MentorLake.Graphene.graphene_plane_tHandle Init(this MentorLake.Graphene.graphene_plane_tHandle p, MentorLake.Graphene.graphene_vec3_tHandle normal, float constant)
	{
		if (p.IsInvalid) throw new Exception("Invalid handle (graphene_plane_t)");
		return graphene_plane_tExterns.graphene_plane_init(p, normal, constant);
	}

/// <summary>
/// <para>
/// Initializes the given #graphene_plane_t using the normal
/// vector and constant of another #graphene_plane_t.
/// </para>
/// </summary>

/// <param name="p">
/// the #graphene_plane_t to initialize
/// </param>
/// <param name="src">
/// a #graphene_plane_t
/// </param>
/// <return>
/// the initialized plane
/// </return>

	public static MentorLake.Graphene.graphene_plane_tHandle InitFromPlane(this MentorLake.Graphene.graphene_plane_tHandle p, MentorLake.Graphene.graphene_plane_tHandle src)
	{
		if (p.IsInvalid) throw new Exception("Invalid handle (graphene_plane_t)");
		return graphene_plane_tExterns.graphene_plane_init_from_plane(p, src);
	}

/// <summary>
/// <para>
/// Initializes the given #graphene_plane_t using the given normal vector
/// and an arbitrary co-planar point.
/// </para>
/// </summary>

/// <param name="p">
/// the #graphene_plane_t to initialize
/// </param>
/// <param name="normal">
/// a normal vector defining the plane pointing towards the origin
/// </param>
/// <param name="point">
/// a #graphene_point3d_t
/// </param>
/// <return>
/// the initialized plane
/// </return>

	public static MentorLake.Graphene.graphene_plane_tHandle InitFromPoint(this MentorLake.Graphene.graphene_plane_tHandle p, MentorLake.Graphene.graphene_vec3_tHandle normal, MentorLake.Graphene.graphene_point3d_tHandle point)
	{
		if (p.IsInvalid) throw new Exception("Invalid handle (graphene_plane_t)");
		return graphene_plane_tExterns.graphene_plane_init_from_point(p, normal, point);
	}

/// <summary>
/// <para>
/// Initializes the given #graphene_plane_t using the 3 provided co-planar
/// points.
/// </para>
/// <para>
/// The winding order is counter-clockwise, and determines which direction
/// the normal vector will point.
/// </para>
/// </summary>

/// <param name="p">
/// the #graphene_plane_t to initialize
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
/// the initialized plane
/// </return>

	public static MentorLake.Graphene.graphene_plane_tHandle InitFromPoints(this MentorLake.Graphene.graphene_plane_tHandle p, MentorLake.Graphene.graphene_point3d_tHandle a, MentorLake.Graphene.graphene_point3d_tHandle b, MentorLake.Graphene.graphene_point3d_tHandle c)
	{
		if (p.IsInvalid) throw new Exception("Invalid handle (graphene_plane_t)");
		return graphene_plane_tExterns.graphene_plane_init_from_points(p, a, b, c);
	}

/// <summary>
/// <para>
/// Initializes the given #graphene_plane_t using the components of
/// the given #graphene_vec4_t vector.
/// </para>
/// </summary>

/// <param name="p">
/// the #graphene_plane_t to initialize
/// </param>
/// <param name="src">
/// a #graphene_vec4_t containing the normal vector in its first
///   three components, and the distance in its fourth component
/// </param>
/// <return>
/// the initialized plane
/// </return>

	public static MentorLake.Graphene.graphene_plane_tHandle InitFromVec4(this MentorLake.Graphene.graphene_plane_tHandle p, MentorLake.Graphene.graphene_vec4_tHandle src)
	{
		if (p.IsInvalid) throw new Exception("Invalid handle (graphene_plane_t)");
		return graphene_plane_tExterns.graphene_plane_init_from_vec4(p, src);
	}

/// <summary>
/// <para>
/// Negates the normal vector and constant of a #graphene_plane_t, effectively
/// mirroring the plane across the origin.
/// </para>
/// </summary>

/// <param name="p">
/// a #graphene_plane_t
/// </param>
/// <param name="res">
/// return location for the negated plane
/// </param>

	public static void Negate(this MentorLake.Graphene.graphene_plane_tHandle p, out MentorLake.Graphene.graphene_plane_t res)
	{
		if (p.IsInvalid) throw new Exception("Invalid handle (graphene_plane_t)");
		graphene_plane_tExterns.graphene_plane_negate(p, out res);
	}

/// <summary>
/// <para>
/// Normalizes the vector of the given #graphene_plane_t,
/// and adjusts the constant accordingly.
/// </para>
/// </summary>

/// <param name="p">
/// a #graphene_plane_t
/// </param>
/// <param name="res">
/// return location for the normalized plane
/// </param>

	public static void Normalize(this MentorLake.Graphene.graphene_plane_tHandle p, out MentorLake.Graphene.graphene_plane_t res)
	{
		if (p.IsInvalid) throw new Exception("Invalid handle (graphene_plane_t)");
		graphene_plane_tExterns.graphene_plane_normalize(p, out res);
	}

/// <summary>
/// <para>
/// Transforms a #graphene_plane_t @p using the given @matrix
/// and @normal_matrix.
/// </para>
/// <para>
/// If @normal_matrix is %NULL, a transformation matrix for the plane
/// normal will be computed from @matrix. If you are transforming
/// multiple planes using the same @matrix it's recommended to compute
/// the normal matrix beforehand to avoid incurring in the cost of
/// recomputing it every time.
/// </para>
/// </summary>

/// <param name="p">
/// a #graphene_plane_t
/// </param>
/// <param name="matrix">
/// a #graphene_matrix_t
/// </param>
/// <param name="normal_matrix">
/// a #graphene_matrix_t
/// </param>
/// <param name="res">
/// the transformed plane
/// </param>

	public static void Transform(this MentorLake.Graphene.graphene_plane_tHandle p, MentorLake.Graphene.graphene_matrix_tHandle matrix, MentorLake.Graphene.graphene_matrix_tHandle normal_matrix, out MentorLake.Graphene.graphene_plane_t res)
	{
		if (p.IsInvalid) throw new Exception("Invalid handle (graphene_plane_t)");
		graphene_plane_tExterns.graphene_plane_transform(p, matrix, normal_matrix, out res);
	}


	public static graphene_plane_t Dereference(this graphene_plane_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<graphene_plane_t>(x.DangerousGetHandle());
}
internal class graphene_plane_tExterns
{
	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_plane_tHandle graphene_plane_alloc();

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_plane_distance([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))] MentorLake.Graphene.graphene_plane_tHandle p, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle point);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_plane_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))] MentorLake.Graphene.graphene_plane_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))] MentorLake.Graphene.graphene_plane_tHandle b);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_plane_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))] MentorLake.Graphene.graphene_plane_tHandle p);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_plane_get_constant([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))] MentorLake.Graphene.graphene_plane_tHandle p);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_plane_get_normal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))] MentorLake.Graphene.graphene_plane_tHandle p, out MentorLake.Graphene.graphene_vec3_t normal);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_plane_tHandle graphene_plane_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))] MentorLake.Graphene.graphene_plane_tHandle p, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle normal, float constant);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_plane_tHandle graphene_plane_init_from_plane([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))] MentorLake.Graphene.graphene_plane_tHandle p, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))] MentorLake.Graphene.graphene_plane_tHandle src);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_plane_tHandle graphene_plane_init_from_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))] MentorLake.Graphene.graphene_plane_tHandle p, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle normal, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle point);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_plane_tHandle graphene_plane_init_from_points([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))] MentorLake.Graphene.graphene_plane_tHandle p, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle b, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle c);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_plane_tHandle graphene_plane_init_from_vec4([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))] MentorLake.Graphene.graphene_plane_tHandle p, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle src);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_plane_negate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))] MentorLake.Graphene.graphene_plane_tHandle p, out MentorLake.Graphene.graphene_plane_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_plane_normalize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))] MentorLake.Graphene.graphene_plane_tHandle p, out MentorLake.Graphene.graphene_plane_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_plane_transform([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))] MentorLake.Graphene.graphene_plane_tHandle p, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle matrix, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle normal_matrix, out MentorLake.Graphene.graphene_plane_t res);

}

/// <summary>
/// <para>
/// A 2D plane that extends infinitely in a 3D volume.
/// </para>
/// <para>
/// The contents of the `graphene_plane_t` are private, and should not be
/// modified directly.
/// </para>
/// </summary>

public struct graphene_plane_t
{
}
