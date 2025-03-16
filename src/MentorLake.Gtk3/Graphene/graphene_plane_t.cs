namespace MentorLake.Graphene;

public class graphene_plane_tHandle : BaseSafeHandle
{
	public static MentorLake.Graphene.graphene_plane_tHandle Alloc()
	{
		return graphene_plane_tExterns.graphene_plane_alloc();
	}

}


public static class graphene_plane_tExtensions
{
	public static float Distance(this MentorLake.Graphene.graphene_plane_tHandle p, MentorLake.Graphene.graphene_point3d_tHandle point)
	{
		return graphene_plane_tExterns.graphene_plane_distance(p, point);
	}

	public static bool Equal(this MentorLake.Graphene.graphene_plane_tHandle a, MentorLake.Graphene.graphene_plane_tHandle b)
	{
		return graphene_plane_tExterns.graphene_plane_equal(a, b);
	}

	public static void Free(this MentorLake.Graphene.graphene_plane_tHandle p)
	{
		graphene_plane_tExterns.graphene_plane_free(p);
	}

	public static float GetConstant(this MentorLake.Graphene.graphene_plane_tHandle p)
	{
		return graphene_plane_tExterns.graphene_plane_get_constant(p);
	}

	public static void GetNormal(this MentorLake.Graphene.graphene_plane_tHandle p, out MentorLake.Graphene.graphene_vec3_t normal)
	{
		graphene_plane_tExterns.graphene_plane_get_normal(p, out normal);
	}

	public static MentorLake.Graphene.graphene_plane_tHandle Init(this MentorLake.Graphene.graphene_plane_tHandle p, MentorLake.Graphene.graphene_vec3_tHandle normal, float constant)
	{
		return graphene_plane_tExterns.graphene_plane_init(p, normal, constant);
	}

	public static MentorLake.Graphene.graphene_plane_tHandle InitFromPlane(this MentorLake.Graphene.graphene_plane_tHandle p, MentorLake.Graphene.graphene_plane_tHandle src)
	{
		return graphene_plane_tExterns.graphene_plane_init_from_plane(p, src);
	}

	public static MentorLake.Graphene.graphene_plane_tHandle InitFromPoint(this MentorLake.Graphene.graphene_plane_tHandle p, MentorLake.Graphene.graphene_vec3_tHandle normal, MentorLake.Graphene.graphene_point3d_tHandle point)
	{
		return graphene_plane_tExterns.graphene_plane_init_from_point(p, normal, point);
	}

	public static MentorLake.Graphene.graphene_plane_tHandle InitFromPoints(this MentorLake.Graphene.graphene_plane_tHandle p, MentorLake.Graphene.graphene_point3d_tHandle a, MentorLake.Graphene.graphene_point3d_tHandle b, MentorLake.Graphene.graphene_point3d_tHandle c)
	{
		return graphene_plane_tExterns.graphene_plane_init_from_points(p, a, b, c);
	}

	public static MentorLake.Graphene.graphene_plane_tHandle InitFromVec4(this MentorLake.Graphene.graphene_plane_tHandle p, MentorLake.Graphene.graphene_vec4_tHandle src)
	{
		return graphene_plane_tExterns.graphene_plane_init_from_vec4(p, src);
	}

	public static void Negate(this MentorLake.Graphene.graphene_plane_tHandle p, out MentorLake.Graphene.graphene_plane_t res)
	{
		graphene_plane_tExterns.graphene_plane_negate(p, out res);
	}

	public static void Normalize(this MentorLake.Graphene.graphene_plane_tHandle p, out MentorLake.Graphene.graphene_plane_t res)
	{
		graphene_plane_tExterns.graphene_plane_normalize(p, out res);
	}

	public static void Transform(this MentorLake.Graphene.graphene_plane_tHandle p, MentorLake.Graphene.graphene_matrix_tHandle matrix, MentorLake.Graphene.graphene_matrix_tHandle normal_matrix, out MentorLake.Graphene.graphene_plane_t res)
	{
		graphene_plane_tExterns.graphene_plane_transform(p, matrix, normal_matrix, out res);
	}


	public static graphene_plane_t Dereference(this graphene_plane_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<graphene_plane_t>(x.DangerousGetHandle());
}
internal class graphene_plane_tExterns
{
	[DllImport(GrapheneLibrary.Name)]
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
	internal static extern MentorLake.Graphene.graphene_plane_tHandle graphene_plane_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))] MentorLake.Graphene.graphene_plane_tHandle p, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle normal, float constant);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_plane_tHandle graphene_plane_init_from_plane([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))] MentorLake.Graphene.graphene_plane_tHandle p, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))] MentorLake.Graphene.graphene_plane_tHandle src);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_plane_tHandle graphene_plane_init_from_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))] MentorLake.Graphene.graphene_plane_tHandle p, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle normal, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle point);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_plane_tHandle graphene_plane_init_from_points([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))] MentorLake.Graphene.graphene_plane_tHandle p, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle b, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle c);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_plane_tHandle graphene_plane_init_from_vec4([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))] MentorLake.Graphene.graphene_plane_tHandle p, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle src);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_plane_negate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))] MentorLake.Graphene.graphene_plane_tHandle p, out MentorLake.Graphene.graphene_plane_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_plane_normalize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))] MentorLake.Graphene.graphene_plane_tHandle p, out MentorLake.Graphene.graphene_plane_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_plane_transform([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_plane_tHandle>))] MentorLake.Graphene.graphene_plane_tHandle p, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle matrix, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle normal_matrix, out MentorLake.Graphene.graphene_plane_t res);

}

public struct graphene_plane_t
{
}
