namespace MentorLake.Graphene;

/// <summary>
/// <para>
/// A 4 vertex quadrilateral, as represented by four #graphene_point_t.
/// </para>
/// <para>
/// The contents of a #graphene_quad_t are private and should never be
/// accessed directly.
/// </para>
/// </summary>

public class graphene_quad_tHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Allocates a new #graphene_quad_t instance.
/// </para>
/// <para>
/// The contents of the returned instance are undefined.
/// </para>
/// </summary>

/// <return>
/// the newly created #graphene_quad_t instance
/// </return>

	public static MentorLake.Graphene.graphene_quad_tHandle Alloc()
	{
		return graphene_quad_tExterns.graphene_quad_alloc();
	}

}


public static class graphene_quad_tExtensions
{
/// <summary>
/// <para>
/// Computes the bounding rectangle of @q and places it into @r.
/// </para>
/// </summary>

/// <param name="q">
/// a #graphene_quad_t
/// </param>
/// <param name="r">
/// return location for a #graphene_rect_t
/// </param>

	public static void Bounds(this MentorLake.Graphene.graphene_quad_tHandle q, out MentorLake.Graphene.graphene_rect_t r)
	{
		if (q.IsInvalid) throw new Exception("Invalid handle (graphene_quad_t)");
		graphene_quad_tExterns.graphene_quad_bounds(q, out r);
	}

/// <summary>
/// <para>
/// Checks if the given #graphene_quad_t contains the given #graphene_point_t.
/// </para>
/// </summary>

/// <param name="q">
/// a #graphene_quad_t
/// </param>
/// <param name="p">
/// a #graphene_point_t
/// </param>
/// <return>
/// `true` if the point is inside the #graphene_quad_t
/// </return>

	public static bool Contains(this MentorLake.Graphene.graphene_quad_tHandle q, MentorLake.Graphene.graphene_point_tHandle p)
	{
		if (q.IsInvalid) throw new Exception("Invalid handle (graphene_quad_t)");
		return graphene_quad_tExterns.graphene_quad_contains(q, p);
	}

/// <summary>
/// <para>
/// Frees the resources allocated by graphene_quad_alloc()
/// </para>
/// </summary>

/// <param name="q">
/// a #graphene_quad_t
/// </param>

	public static void Free(this MentorLake.Graphene.graphene_quad_tHandle q)
	{
		if (q.IsInvalid) throw new Exception("Invalid handle (graphene_quad_t)");
		graphene_quad_tExterns.graphene_quad_free(q);
	}

/// <summary>
/// <para>
/// Retrieves the point of a #graphene_quad_t at the given index.
/// </para>
/// </summary>

/// <param name="q">
/// a #graphene_quad_t
/// </param>
/// <param name="index_">
/// the index of the point to retrieve
/// </param>
/// <return>
/// a #graphene_point_t
/// </return>

	public static MentorLake.Graphene.graphene_point_tHandle GetPoint(this MentorLake.Graphene.graphene_quad_tHandle q, uint index_)
	{
		if (q.IsInvalid) throw new Exception("Invalid handle (graphene_quad_t)");
		return graphene_quad_tExterns.graphene_quad_get_point(q, index_);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_quad_t with the given points.
/// </para>
/// </summary>

/// <param name="q">
/// the #graphene_quad_t to initialize
/// </param>
/// <param name="p1">
/// the first point of the quadrilateral
/// </param>
/// <param name="p2">
/// the second point of the quadrilateral
/// </param>
/// <param name="p3">
/// the third point of the quadrilateral
/// </param>
/// <param name="p4">
/// the fourth point of the quadrilateral
/// </param>
/// <return>
/// the initialized #graphene_quad_t
/// </return>

	public static MentorLake.Graphene.graphene_quad_tHandle Init(this MentorLake.Graphene.graphene_quad_tHandle q, MentorLake.Graphene.graphene_point_tHandle p1, MentorLake.Graphene.graphene_point_tHandle p2, MentorLake.Graphene.graphene_point_tHandle p3, MentorLake.Graphene.graphene_point_tHandle p4)
	{
		if (q.IsInvalid) throw new Exception("Invalid handle (graphene_quad_t)");
		return graphene_quad_tExterns.graphene_quad_init(q, p1, p2, p3, p4);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_quad_t using an array of points.
/// </para>
/// </summary>

/// <param name="q">
/// the #graphene_quad_t to initialize
/// </param>
/// <param name="points">
/// an array of 4 #graphene_point_t
/// </param>
/// <return>
/// the initialized #graphene_quad_t
/// </return>

	public static MentorLake.Graphene.graphene_quad_tHandle InitFromPoints(this MentorLake.Graphene.graphene_quad_tHandle q, MentorLake.Graphene.graphene_point_t[] points)
	{
		if (q.IsInvalid) throw new Exception("Invalid handle (graphene_quad_t)");
		return graphene_quad_tExterns.graphene_quad_init_from_points(q, points);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_quad_t using the four corners of the
/// given #graphene_rect_t.
/// </para>
/// </summary>

/// <param name="q">
/// the #graphene_quad_t to initialize
/// </param>
/// <param name="r">
/// a #graphene_rect_t
/// </param>
/// <return>
/// the initialized #graphene_quad_t
/// </return>

	public static MentorLake.Graphene.graphene_quad_tHandle InitFromRect(this MentorLake.Graphene.graphene_quad_tHandle q, MentorLake.Graphene.graphene_rect_tHandle r)
	{
		if (q.IsInvalid) throw new Exception("Invalid handle (graphene_quad_t)");
		return graphene_quad_tExterns.graphene_quad_init_from_rect(q, r);
	}


	public static graphene_quad_t Dereference(this graphene_quad_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<graphene_quad_t>(x.DangerousGetHandle());
}
internal class graphene_quad_tExterns
{
	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quad_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_quad_tHandle graphene_quad_alloc();

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_quad_bounds([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quad_tHandle>))] MentorLake.Graphene.graphene_quad_tHandle q, out MentorLake.Graphene.graphene_rect_t r);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_quad_contains([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quad_tHandle>))] MentorLake.Graphene.graphene_quad_tHandle q, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))] MentorLake.Graphene.graphene_point_tHandle p);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_quad_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quad_tHandle>))] MentorLake.Graphene.graphene_quad_tHandle q);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_point_tHandle graphene_quad_get_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quad_tHandle>))] MentorLake.Graphene.graphene_quad_tHandle q, uint index_);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quad_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_quad_tHandle graphene_quad_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quad_tHandle>))] MentorLake.Graphene.graphene_quad_tHandle q, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))] MentorLake.Graphene.graphene_point_tHandle p1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))] MentorLake.Graphene.graphene_point_tHandle p2, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))] MentorLake.Graphene.graphene_point_tHandle p3, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))] MentorLake.Graphene.graphene_point_tHandle p4);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quad_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_quad_tHandle graphene_quad_init_from_points([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quad_tHandle>))] MentorLake.Graphene.graphene_quad_tHandle q, MentorLake.Graphene.graphene_point_t[] points);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quad_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_quad_tHandle graphene_quad_init_from_rect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quad_tHandle>))] MentorLake.Graphene.graphene_quad_tHandle q, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r);

}

/// <summary>
/// <para>
/// A 4 vertex quadrilateral, as represented by four #graphene_point_t.
/// </para>
/// <para>
/// The contents of a #graphene_quad_t are private and should never be
/// accessed directly.
/// </para>
/// </summary>

public struct graphene_quad_t
{
}
