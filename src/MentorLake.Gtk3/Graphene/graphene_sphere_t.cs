namespace MentorLake.Graphene;

public class graphene_sphere_tHandle : BaseSafeHandle
{
	public static MentorLake.Graphene.graphene_sphere_tHandle Alloc()
	{
		return graphene_sphere_tExterns.graphene_sphere_alloc();
	}

}


public static class graphene_sphere_tExtensions
{
	public static bool ContainsPoint(this MentorLake.Graphene.graphene_sphere_tHandle s, MentorLake.Graphene.graphene_point3d_tHandle point)
	{
		return graphene_sphere_tExterns.graphene_sphere_contains_point(s, point);
	}

	public static float Distance(this MentorLake.Graphene.graphene_sphere_tHandle s, MentorLake.Graphene.graphene_point3d_tHandle point)
	{
		return graphene_sphere_tExterns.graphene_sphere_distance(s, point);
	}

	public static bool Equal(this MentorLake.Graphene.graphene_sphere_tHandle a, MentorLake.Graphene.graphene_sphere_tHandle b)
	{
		return graphene_sphere_tExterns.graphene_sphere_equal(a, b);
	}

	public static void Free(this MentorLake.Graphene.graphene_sphere_tHandle s)
	{
		graphene_sphere_tExterns.graphene_sphere_free(s);
	}

	public static void GetBoundingBox(this MentorLake.Graphene.graphene_sphere_tHandle s, out MentorLake.Graphene.graphene_box_t box)
	{
		graphene_sphere_tExterns.graphene_sphere_get_bounding_box(s, out box);
	}

	public static void GetCenter(this MentorLake.Graphene.graphene_sphere_tHandle s, out MentorLake.Graphene.graphene_point3d_t center)
	{
		graphene_sphere_tExterns.graphene_sphere_get_center(s, out center);
	}

	public static float GetRadius(this MentorLake.Graphene.graphene_sphere_tHandle s)
	{
		return graphene_sphere_tExterns.graphene_sphere_get_radius(s);
	}

	public static MentorLake.Graphene.graphene_sphere_tHandle Init(this MentorLake.Graphene.graphene_sphere_tHandle s, MentorLake.Graphene.graphene_point3d_tHandle center, float radius)
	{
		return graphene_sphere_tExterns.graphene_sphere_init(s, center, radius);
	}

	public static MentorLake.Graphene.graphene_sphere_tHandle InitFromPoints(this MentorLake.Graphene.graphene_sphere_tHandle s, uint n_points, MentorLake.Graphene.graphene_point3d_t[] points, MentorLake.Graphene.graphene_point3d_tHandle center)
	{
		return graphene_sphere_tExterns.graphene_sphere_init_from_points(s, n_points, points, center);
	}

	public static MentorLake.Graphene.graphene_sphere_tHandle InitFromVectors(this MentorLake.Graphene.graphene_sphere_tHandle s, uint n_vectors, MentorLake.Graphene.graphene_vec3_t[] vectors, MentorLake.Graphene.graphene_point3d_tHandle center)
	{
		return graphene_sphere_tExterns.graphene_sphere_init_from_vectors(s, n_vectors, vectors, center);
	}

	public static bool IsEmpty(this MentorLake.Graphene.graphene_sphere_tHandle s)
	{
		return graphene_sphere_tExterns.graphene_sphere_is_empty(s);
	}

	public static void Translate(this MentorLake.Graphene.graphene_sphere_tHandle s, MentorLake.Graphene.graphene_point3d_tHandle point, out MentorLake.Graphene.graphene_sphere_t res)
	{
		graphene_sphere_tExterns.graphene_sphere_translate(s, point, out res);
	}


	public static graphene_sphere_t Dereference(this graphene_sphere_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<graphene_sphere_t>(x.DangerousGetHandle());
}
internal class graphene_sphere_tExterns
{
	[DllImport(GrapheneLibrary.Name)]
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
	internal static extern MentorLake.Graphene.graphene_sphere_tHandle graphene_sphere_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_sphere_tHandle>))] MentorLake.Graphene.graphene_sphere_tHandle s, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle center, float radius);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_sphere_tHandle graphene_sphere_init_from_points([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_sphere_tHandle>))] MentorLake.Graphene.graphene_sphere_tHandle s, uint n_points, MentorLake.Graphene.graphene_point3d_t[] points, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle center);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_sphere_tHandle graphene_sphere_init_from_vectors([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_sphere_tHandle>))] MentorLake.Graphene.graphene_sphere_tHandle s, uint n_vectors, MentorLake.Graphene.graphene_vec3_t[] vectors, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle center);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_sphere_is_empty([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_sphere_tHandle>))] MentorLake.Graphene.graphene_sphere_tHandle s);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_sphere_translate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_sphere_tHandle>))] MentorLake.Graphene.graphene_sphere_tHandle s, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle point, out MentorLake.Graphene.graphene_sphere_t res);

}

public struct graphene_sphere_t
{
}
