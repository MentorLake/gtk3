namespace MentorLake.Graphene;

/// <summary>
/// <para>
/// A point with two coordinates.
/// </para>
/// </summary>

public class graphene_point_tHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Allocates a new #graphene_point_t structure.
/// </para>
/// <para>
/// The coordinates of the returned point are (0, 0).
/// </para>
/// <para>
/// It's possible to chain this function with graphene_point_init()
/// or graphene_point_init_from_point(), e.g.:
/// </para>
/// <para>
/// |[<!-- language="C" -->
///   graphene_point_t *
///   point_new (float x, float y)
///   {
///     return graphene_point_init (graphene_point_alloc (), x, y);
///   }
/// </para>
/// <para>
///   graphene_point_t *
///   point_copy (const graphene_point_t *p)
///   {
///     return graphene_point_init_from_point (graphene_point_alloc (), p);
///   }
/// ]|
/// </para>
/// </summary>

/// <return>
/// the newly allocated #graphene_point_t.
///   Use graphene_point_free() to free the resources allocated by
///   this function.
/// </return>

	public static MentorLake.Graphene.graphene_point_tHandle Alloc()
	{
		return graphene_point_tExterns.graphene_point_alloc();
	}

}


public static class graphene_point_tExtensions
{
/// <summary>
/// <para>
/// Computes the distance between @a and @b.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_point_t
/// </param>
/// <param name="b">
/// a #graphene_point_t
/// </param>
/// <param name="d_x">
/// distance component on the X axis
/// </param>
/// <param name="d_y">
/// distance component on the Y axis
/// </param>
/// <return>
/// the distance between the two points
/// </return>

	public static float Distance(this MentorLake.Graphene.graphene_point_tHandle a, MentorLake.Graphene.graphene_point_tHandle b, out float d_x, out float d_y)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_point_t)");
		return graphene_point_tExterns.graphene_point_distance(a, b, out d_x, out d_y);
	}

/// <summary>
/// <para>
/// Checks if the two points @a and @b point to the same
/// coordinates.
/// </para>
/// <para>
/// This function accounts for floating point fluctuations; if
/// you want to control the fuzziness of the match, you can use
/// graphene_point_near() instead.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_point_t
/// </param>
/// <param name="b">
/// a #graphene_point_t
/// </param>
/// <return>
/// `true` if the points have the same coordinates
/// </return>

	public static bool Equal(this MentorLake.Graphene.graphene_point_tHandle a, MentorLake.Graphene.graphene_point_tHandle b)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_point_t)");
		return graphene_point_tExterns.graphene_point_equal(a, b);
	}

/// <summary>
/// <para>
/// Frees the resources allocated by graphene_point_alloc().
/// </para>
/// </summary>

/// <param name="p">
/// a #graphene_point_t
/// </param>

	public static void Free(this MentorLake.Graphene.graphene_point_tHandle p)
	{
		if (p.IsInvalid) throw new Exception("Invalid handle (graphene_point_t)");
		graphene_point_tExterns.graphene_point_free(p);
	}

/// <summary>
/// <para>
/// Initializes @p to the given @x and @y coordinates.
/// </para>
/// <para>
/// It's safe to call this function multiple times.
/// </para>
/// </summary>

/// <param name="p">
/// a #graphene_point_t
/// </param>
/// <param name="x">
/// the X coordinate
/// </param>
/// <param name="y">
/// the Y coordinate
/// </param>
/// <return>
/// the initialized point
/// </return>

	public static MentorLake.Graphene.graphene_point_tHandle Init(this MentorLake.Graphene.graphene_point_tHandle p, float x, float y)
	{
		if (p.IsInvalid) throw new Exception("Invalid handle (graphene_point_t)");
		return graphene_point_tExterns.graphene_point_init(p, x, y);
	}

/// <summary>
/// <para>
/// Initializes @p with the same coordinates of @src.
/// </para>
/// </summary>

/// <param name="p">
/// a #graphene_point_t
/// </param>
/// <param name="src">
/// the #graphene_point_t to use
/// </param>
/// <return>
/// the initialized point
/// </return>

	public static MentorLake.Graphene.graphene_point_tHandle InitFromPoint(this MentorLake.Graphene.graphene_point_tHandle p, MentorLake.Graphene.graphene_point_tHandle src)
	{
		if (p.IsInvalid) throw new Exception("Invalid handle (graphene_point_t)");
		return graphene_point_tExterns.graphene_point_init_from_point(p, src);
	}

/// <summary>
/// <para>
/// Initializes @p with the coordinates inside the given #graphene_vec2_t.
/// </para>
/// </summary>

/// <param name="p">
/// the #graphene_point_t to initialize
/// </param>
/// <param name="src">
/// a #graphene_vec2_t
/// </param>
/// <return>
/// the initialized point
/// </return>

	public static MentorLake.Graphene.graphene_point_tHandle InitFromVec2(this MentorLake.Graphene.graphene_point_tHandle p, MentorLake.Graphene.graphene_vec2_tHandle src)
	{
		if (p.IsInvalid) throw new Exception("Invalid handle (graphene_point_t)");
		return graphene_point_tExterns.graphene_point_init_from_vec2(p, src);
	}

/// <summary>
/// <para>
/// Linearly interpolates the coordinates of @a and @b using the
/// given @factor.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_point_t
/// </param>
/// <param name="b">
/// a #graphene_point_t
/// </param>
/// <param name="factor">
/// the linear interpolation factor
/// </param>
/// <param name="res">
/// return location for the interpolated
///   point
/// </param>

	public static void Interpolate(this MentorLake.Graphene.graphene_point_tHandle a, MentorLake.Graphene.graphene_point_tHandle b, double factor, out MentorLake.Graphene.graphene_point_t res)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_point_t)");
		graphene_point_tExterns.graphene_point_interpolate(a, b, factor, out res);
	}

/// <summary>
/// <para>
/// Checks whether the two points @a and @b are within
/// the threshold of @epsilon.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_point_t
/// </param>
/// <param name="b">
/// a #graphene_point_t
/// </param>
/// <param name="epsilon">
/// threshold between the two points
/// </param>
/// <return>
/// `true` if the distance is within @epsilon
/// </return>

	public static bool Near(this MentorLake.Graphene.graphene_point_tHandle a, MentorLake.Graphene.graphene_point_tHandle b, float epsilon)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_point_t)");
		return graphene_point_tExterns.graphene_point_near(a, b, epsilon);
	}

/// <summary>
/// <para>
/// Stores the coordinates of the given #graphene_point_t into a
/// #graphene_vec2_t.
/// </para>
/// </summary>

/// <param name="p">
/// a #graphene_point_t
/// </param>
/// <param name="v">
/// return location for the vertex
/// </param>

	public static void ToVec2(this MentorLake.Graphene.graphene_point_tHandle p, out MentorLake.Graphene.graphene_vec2_t v)
	{
		if (p.IsInvalid) throw new Exception("Invalid handle (graphene_point_t)");
		graphene_point_tExterns.graphene_point_to_vec2(p, out v);
	}


	public static graphene_point_t Dereference(this graphene_point_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<graphene_point_t>(x.DangerousGetHandle());
}
internal class graphene_point_tExterns
{
	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_point_tHandle graphene_point_alloc();

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_point_distance([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))] MentorLake.Graphene.graphene_point_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))] MentorLake.Graphene.graphene_point_tHandle b, out float d_x, out float d_y);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_point_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))] MentorLake.Graphene.graphene_point_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))] MentorLake.Graphene.graphene_point_tHandle b);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_point_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))] MentorLake.Graphene.graphene_point_tHandle p);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_point_tHandle graphene_point_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))] MentorLake.Graphene.graphene_point_tHandle p, float x, float y);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_point_tHandle graphene_point_init_from_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))] MentorLake.Graphene.graphene_point_tHandle p, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))] MentorLake.Graphene.graphene_point_tHandle src);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_point_tHandle graphene_point_init_from_vec2([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))] MentorLake.Graphene.graphene_point_tHandle p, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle src);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_point_interpolate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))] MentorLake.Graphene.graphene_point_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))] MentorLake.Graphene.graphene_point_tHandle b, double factor, out MentorLake.Graphene.graphene_point_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_point_near([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))] MentorLake.Graphene.graphene_point_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))] MentorLake.Graphene.graphene_point_tHandle b, float epsilon);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_point_to_vec2([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))] MentorLake.Graphene.graphene_point_tHandle p, out MentorLake.Graphene.graphene_vec2_t v);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_point_tHandle graphene_point_zero();

}

/// <summary>
/// <para>
/// A point with two coordinates.
/// </para>
/// </summary>

public struct graphene_point_t
{
	/// <summary>
/// <para>
/// the X coordinate of the point
/// </para>
/// </summary>

public float x;
	/// <summary>
/// <para>
/// the Y coordinate of the point
/// </para>
/// </summary>

public float y;
/// <summary>
/// <para>
/// Returns a point fixed at (0, 0).
/// </para>
/// </summary>

/// <return>
/// a fixed point
/// </return>

	public static MentorLake.Graphene.graphene_point_tHandle Zero()
	{
		return graphene_point_tExterns.graphene_point_zero();
	}

}
