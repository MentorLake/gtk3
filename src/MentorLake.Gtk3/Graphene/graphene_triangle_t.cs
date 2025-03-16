namespace MentorLake.Graphene;

public class graphene_triangle_tHandle : BaseSafeHandle
{
	public static MentorLake.Graphene.graphene_triangle_tHandle Alloc()
	{
		return graphene_triangle_tExterns.graphene_triangle_alloc();
	}

}


public static class graphene_triangle_tExtensions
{
	public static bool ContainsPoint(this MentorLake.Graphene.graphene_triangle_tHandle t, MentorLake.Graphene.graphene_point3d_tHandle p)
	{
		return graphene_triangle_tExterns.graphene_triangle_contains_point(t, p);
	}

	public static bool Equal(this MentorLake.Graphene.graphene_triangle_tHandle a, MentorLake.Graphene.graphene_triangle_tHandle b)
	{
		return graphene_triangle_tExterns.graphene_triangle_equal(a, b);
	}

	public static void Free(this MentorLake.Graphene.graphene_triangle_tHandle t)
	{
		graphene_triangle_tExterns.graphene_triangle_free(t);
	}

	public static float GetArea(this MentorLake.Graphene.graphene_triangle_tHandle t)
	{
		return graphene_triangle_tExterns.graphene_triangle_get_area(t);
	}

	public static bool GetBarycoords(this MentorLake.Graphene.graphene_triangle_tHandle t, MentorLake.Graphene.graphene_point3d_tHandle p, out MentorLake.Graphene.graphene_vec2_t res)
	{
		return graphene_triangle_tExterns.graphene_triangle_get_barycoords(t, p, out res);
	}

	public static void GetBoundingBox(this MentorLake.Graphene.graphene_triangle_tHandle t, out MentorLake.Graphene.graphene_box_t res)
	{
		graphene_triangle_tExterns.graphene_triangle_get_bounding_box(t, out res);
	}

	public static void GetMidpoint(this MentorLake.Graphene.graphene_triangle_tHandle t, out MentorLake.Graphene.graphene_point3d_t res)
	{
		graphene_triangle_tExterns.graphene_triangle_get_midpoint(t, out res);
	}

	public static void GetNormal(this MentorLake.Graphene.graphene_triangle_tHandle t, out MentorLake.Graphene.graphene_vec3_t res)
	{
		graphene_triangle_tExterns.graphene_triangle_get_normal(t, out res);
	}

	public static void GetPlane(this MentorLake.Graphene.graphene_triangle_tHandle t, out MentorLake.Graphene.graphene_plane_t res)
	{
		graphene_triangle_tExterns.graphene_triangle_get_plane(t, out res);
	}

	public static void GetPoints(this MentorLake.Graphene.graphene_triangle_tHandle t, out MentorLake.Graphene.graphene_point3d_t a, out MentorLake.Graphene.graphene_point3d_t b, out MentorLake.Graphene.graphene_point3d_t c)
	{
		graphene_triangle_tExterns.graphene_triangle_get_points(t, out a, out b, out c);
	}

	public static bool GetUv(this MentorLake.Graphene.graphene_triangle_tHandle t, MentorLake.Graphene.graphene_point3d_tHandle p, MentorLake.Graphene.graphene_vec2_tHandle uv_a, MentorLake.Graphene.graphene_vec2_tHandle uv_b, MentorLake.Graphene.graphene_vec2_tHandle uv_c, out MentorLake.Graphene.graphene_vec2_t res)
	{
		return graphene_triangle_tExterns.graphene_triangle_get_uv(t, p, uv_a, uv_b, uv_c, out res);
	}

	public static void GetVertices(this MentorLake.Graphene.graphene_triangle_tHandle t, out MentorLake.Graphene.graphene_vec3_t a, out MentorLake.Graphene.graphene_vec3_t b, out MentorLake.Graphene.graphene_vec3_t c)
	{
		graphene_triangle_tExterns.graphene_triangle_get_vertices(t, out a, out b, out c);
	}

	public static MentorLake.Graphene.graphene_triangle_tHandle InitFromFloat(this MentorLake.Graphene.graphene_triangle_tHandle t, float[] a, float[] b, float[] c)
	{
		return graphene_triangle_tExterns.graphene_triangle_init_from_float(t, a, b, c);
	}

	public static MentorLake.Graphene.graphene_triangle_tHandle InitFromPoint3D(this MentorLake.Graphene.graphene_triangle_tHandle t, MentorLake.Graphene.graphene_point3d_tHandle a, MentorLake.Graphene.graphene_point3d_tHandle b, MentorLake.Graphene.graphene_point3d_tHandle c)
	{
		return graphene_triangle_tExterns.graphene_triangle_init_from_point3d(t, a, b, c);
	}

	public static MentorLake.Graphene.graphene_triangle_tHandle InitFromVec3(this MentorLake.Graphene.graphene_triangle_tHandle t, MentorLake.Graphene.graphene_vec3_tHandle a, MentorLake.Graphene.graphene_vec3_tHandle b, MentorLake.Graphene.graphene_vec3_tHandle c)
	{
		return graphene_triangle_tExterns.graphene_triangle_init_from_vec3(t, a, b, c);
	}


	public static graphene_triangle_t Dereference(this graphene_triangle_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<graphene_triangle_t>(x.DangerousGetHandle());
}
internal class graphene_triangle_tExterns
{
	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_triangle_tHandle graphene_triangle_alloc();

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_triangle_contains_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_triangle_tHandle>))] MentorLake.Graphene.graphene_triangle_tHandle t, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle p);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_triangle_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_triangle_tHandle>))] MentorLake.Graphene.graphene_triangle_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_triangle_tHandle>))] MentorLake.Graphene.graphene_triangle_tHandle b);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_triangle_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_triangle_tHandle>))] MentorLake.Graphene.graphene_triangle_tHandle t);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_triangle_get_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_triangle_tHandle>))] MentorLake.Graphene.graphene_triangle_tHandle t);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_triangle_get_barycoords([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_triangle_tHandle>))] MentorLake.Graphene.graphene_triangle_tHandle t, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle p, out MentorLake.Graphene.graphene_vec2_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_triangle_get_bounding_box([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_triangle_tHandle>))] MentorLake.Graphene.graphene_triangle_tHandle t, out MentorLake.Graphene.graphene_box_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_triangle_get_midpoint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_triangle_tHandle>))] MentorLake.Graphene.graphene_triangle_tHandle t, out MentorLake.Graphene.graphene_point3d_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_triangle_get_normal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_triangle_tHandle>))] MentorLake.Graphene.graphene_triangle_tHandle t, out MentorLake.Graphene.graphene_vec3_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_triangle_get_plane([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_triangle_tHandle>))] MentorLake.Graphene.graphene_triangle_tHandle t, out MentorLake.Graphene.graphene_plane_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_triangle_get_points([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_triangle_tHandle>))] MentorLake.Graphene.graphene_triangle_tHandle t, out MentorLake.Graphene.graphene_point3d_t a, out MentorLake.Graphene.graphene_point3d_t b, out MentorLake.Graphene.graphene_point3d_t c);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_triangle_get_uv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_triangle_tHandle>))] MentorLake.Graphene.graphene_triangle_tHandle t, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle p, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle uv_a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle uv_b, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle uv_c, out MentorLake.Graphene.graphene_vec2_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_triangle_get_vertices([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_triangle_tHandle>))] MentorLake.Graphene.graphene_triangle_tHandle t, out MentorLake.Graphene.graphene_vec3_t a, out MentorLake.Graphene.graphene_vec3_t b, out MentorLake.Graphene.graphene_vec3_t c);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_triangle_tHandle graphene_triangle_init_from_float([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_triangle_tHandle>))] MentorLake.Graphene.graphene_triangle_tHandle t, float[] a, float[] b, float[] c);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_triangle_tHandle graphene_triangle_init_from_point3d([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_triangle_tHandle>))] MentorLake.Graphene.graphene_triangle_tHandle t, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle b, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle c);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_triangle_tHandle graphene_triangle_init_from_vec3([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_triangle_tHandle>))] MentorLake.Graphene.graphene_triangle_tHandle t, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle b, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle c);

}

public struct graphene_triangle_t
{
}
