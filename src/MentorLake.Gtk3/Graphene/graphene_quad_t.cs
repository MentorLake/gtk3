namespace MentorLake.Graphene;

public class graphene_quad_tHandle : BaseSafeHandle
{
	public static MentorLake.Graphene.graphene_quad_tHandle Alloc()
	{
		return graphene_quad_tExterns.graphene_quad_alloc();
	}

}


public static class graphene_quad_tExtensions
{
	public static void Bounds(this MentorLake.Graphene.graphene_quad_tHandle q, out MentorLake.Graphene.graphene_rect_t r)
	{
		if (q.IsInvalid) throw new Exception("Invalid handle (graphene_quad_t)");
		graphene_quad_tExterns.graphene_quad_bounds(q, out r);
	}

	public static bool Contains(this MentorLake.Graphene.graphene_quad_tHandle q, MentorLake.Graphene.graphene_point_tHandle p)
	{
		if (q.IsInvalid) throw new Exception("Invalid handle (graphene_quad_t)");
		return graphene_quad_tExterns.graphene_quad_contains(q, p);
	}

	public static void Free(this MentorLake.Graphene.graphene_quad_tHandle q)
	{
		if (q.IsInvalid) throw new Exception("Invalid handle (graphene_quad_t)");
		graphene_quad_tExterns.graphene_quad_free(q);
	}

	public static MentorLake.Graphene.graphene_point_tHandle GetPoint(this MentorLake.Graphene.graphene_quad_tHandle q, uint index_)
	{
		if (q.IsInvalid) throw new Exception("Invalid handle (graphene_quad_t)");
		return graphene_quad_tExterns.graphene_quad_get_point(q, index_);
	}

	public static MentorLake.Graphene.graphene_quad_tHandle Init(this MentorLake.Graphene.graphene_quad_tHandle q, MentorLake.Graphene.graphene_point_tHandle p1, MentorLake.Graphene.graphene_point_tHandle p2, MentorLake.Graphene.graphene_point_tHandle p3, MentorLake.Graphene.graphene_point_tHandle p4)
	{
		if (q.IsInvalid) throw new Exception("Invalid handle (graphene_quad_t)");
		return graphene_quad_tExterns.graphene_quad_init(q, p1, p2, p3, p4);
	}

	public static MentorLake.Graphene.graphene_quad_tHandle InitFromPoints(this MentorLake.Graphene.graphene_quad_tHandle q, MentorLake.Graphene.graphene_point_t[] points)
	{
		if (q.IsInvalid) throw new Exception("Invalid handle (graphene_quad_t)");
		return graphene_quad_tExterns.graphene_quad_init_from_points(q, points);
	}

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

public struct graphene_quad_t
{
}
