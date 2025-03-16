namespace MentorLake.Graphene;

public class graphene_frustum_tHandle : BaseSafeHandle
{
	public static MentorLake.Graphene.graphene_frustum_tHandle Alloc()
	{
		return graphene_frustum_tExterns.graphene_frustum_alloc();
	}

}


public static class graphene_frustum_tExtensions
{
	public static bool ContainsPoint(this MentorLake.Graphene.graphene_frustum_tHandle f, MentorLake.Graphene.graphene_point3d_tHandle point)
	{
		return graphene_frustum_tExterns.graphene_frustum_contains_point(f, point);
	}

	public static bool Equal(this MentorLake.Graphene.graphene_frustum_tHandle a, MentorLake.Graphene.graphene_frustum_tHandle b)
	{
		return graphene_frustum_tExterns.graphene_frustum_equal(a, b);
	}

	public static void Free(this MentorLake.Graphene.graphene_frustum_tHandle f)
	{
		graphene_frustum_tExterns.graphene_frustum_free(f);
	}

	public static void GetPlanes(this MentorLake.Graphene.graphene_frustum_tHandle f, out MentorLake.Graphene.graphene_plane_t[] planes)
	{
		graphene_frustum_tExterns.graphene_frustum_get_planes(f, out planes);
	}

	public static MentorLake.Graphene.graphene_frustum_tHandle Init(this MentorLake.Graphene.graphene_frustum_tHandle f, MentorLake.Graphene.graphene_plane_tHandle p0, MentorLake.Graphene.graphene_plane_tHandle p1, MentorLake.Graphene.graphene_plane_tHandle p2, MentorLake.Graphene.graphene_plane_tHandle p3, MentorLake.Graphene.graphene_plane_tHandle p4, MentorLake.Graphene.graphene_plane_tHandle p5)
	{
		return graphene_frustum_tExterns.graphene_frustum_init(f, p0, p1, p2, p3, p4, p5);
	}

	public static MentorLake.Graphene.graphene_frustum_tHandle InitFromFrustum(this MentorLake.Graphene.graphene_frustum_tHandle f, MentorLake.Graphene.graphene_frustum_tHandle src)
	{
		return graphene_frustum_tExterns.graphene_frustum_init_from_frustum(f, src);
	}

	public static MentorLake.Graphene.graphene_frustum_tHandle InitFromMatrix(this MentorLake.Graphene.graphene_frustum_tHandle f, MentorLake.Graphene.graphene_matrix_tHandle matrix)
	{
		return graphene_frustum_tExterns.graphene_frustum_init_from_matrix(f, matrix);
	}

	public static bool IntersectsBox(this MentorLake.Graphene.graphene_frustum_tHandle f, MentorLake.Graphene.graphene_box_tHandle box)
	{
		return graphene_frustum_tExterns.graphene_frustum_intersects_box(f, box);
	}

	public static bool IntersectsSphere(this MentorLake.Graphene.graphene_frustum_tHandle f, MentorLake.Graphene.graphene_sphere_tHandle sphere)
	{
		return graphene_frustum_tExterns.graphene_frustum_intersects_sphere(f, sphere);
	}


	public static graphene_frustum_t Dereference(this graphene_frustum_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<graphene_frustum_t>(x.DangerousGetHandle());
}
internal class graphene_frustum_tExterns
{
	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_frustum_tHandle graphene_frustum_alloc();

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_frustum_contains_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_frustum_tHandle>))] MentorLake.Graphene.graphene_frustum_tHandle f, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle point);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_frustum_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_frustum_tHandle>))] MentorLake.Graphene.graphene_frustum_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_frustum_tHandle>))] MentorLake.Graphene.graphene_frustum_tHandle b);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_frustum_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_frustum_tHandle>))] MentorLake.Graphene.graphene_frustum_tHandle f);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_frustum_get_planes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_frustum_tHandle>))] MentorLake.Graphene.graphene_frustum_tHandle f, out MentorLake.Graphene.graphene_plane_t[] planes);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_frustum_tHandle graphene_frustum_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_frustum_tHandle>))] MentorLake.Graphene.graphene_frustum_tHandle f, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))] MentorLake.Graphene.graphene_plane_tHandle p0, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))] MentorLake.Graphene.graphene_plane_tHandle p1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))] MentorLake.Graphene.graphene_plane_tHandle p2, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))] MentorLake.Graphene.graphene_plane_tHandle p3, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))] MentorLake.Graphene.graphene_plane_tHandle p4, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))] MentorLake.Graphene.graphene_plane_tHandle p5);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_frustum_tHandle graphene_frustum_init_from_frustum([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_frustum_tHandle>))] MentorLake.Graphene.graphene_frustum_tHandle f, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_frustum_tHandle>))] MentorLake.Graphene.graphene_frustum_tHandle src);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_frustum_tHandle graphene_frustum_init_from_matrix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_frustum_tHandle>))] MentorLake.Graphene.graphene_frustum_tHandle f, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle matrix);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_frustum_intersects_box([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_frustum_tHandle>))] MentorLake.Graphene.graphene_frustum_tHandle f, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle box);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_frustum_intersects_sphere([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_frustum_tHandle>))] MentorLake.Graphene.graphene_frustum_tHandle f, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_sphere_tHandle>))] MentorLake.Graphene.graphene_sphere_tHandle sphere);

}

public struct graphene_frustum_t
{
}
