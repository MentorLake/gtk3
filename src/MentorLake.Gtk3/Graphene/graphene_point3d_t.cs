namespace MentorLake.Graphene;

public class graphene_point3d_tHandle : BaseSafeHandle
{
	public static MentorLake.Graphene.graphene_point3d_tHandle Alloc()
	{
		return graphene_point3d_tExterns.graphene_point3d_alloc();
	}

}


public static class graphene_point3d_tExtensions
{
	public static void Cross(this MentorLake.Graphene.graphene_point3d_tHandle a, MentorLake.Graphene.graphene_point3d_tHandle b, out MentorLake.Graphene.graphene_point3d_t res)
	{
		if (a.IsInvalid || a.IsClosed) throw new Exception("Invalid or closed handle (graphene_point3d_t)");
		graphene_point3d_tExterns.graphene_point3d_cross(a, b, out res);
	}

	public static float Distance(this MentorLake.Graphene.graphene_point3d_tHandle a, MentorLake.Graphene.graphene_point3d_tHandle b, out MentorLake.Graphene.graphene_vec3_t delta)
	{
		if (a.IsInvalid || a.IsClosed) throw new Exception("Invalid or closed handle (graphene_point3d_t)");
		return graphene_point3d_tExterns.graphene_point3d_distance(a, b, out delta);
	}

	public static float Dot(this MentorLake.Graphene.graphene_point3d_tHandle a, MentorLake.Graphene.graphene_point3d_tHandle b)
	{
		if (a.IsInvalid || a.IsClosed) throw new Exception("Invalid or closed handle (graphene_point3d_t)");
		return graphene_point3d_tExterns.graphene_point3d_dot(a, b);
	}

	public static bool Equal(this MentorLake.Graphene.graphene_point3d_tHandle a, MentorLake.Graphene.graphene_point3d_tHandle b)
	{
		if (a.IsInvalid || a.IsClosed) throw new Exception("Invalid or closed handle (graphene_point3d_t)");
		return graphene_point3d_tExterns.graphene_point3d_equal(a, b);
	}

	public static void Free(this MentorLake.Graphene.graphene_point3d_tHandle p)
	{
		if (p.IsInvalid || p.IsClosed) throw new Exception("Invalid or closed handle (graphene_point3d_t)");
		graphene_point3d_tExterns.graphene_point3d_free(p);
	}

	public static MentorLake.Graphene.graphene_point3d_tHandle Init(this MentorLake.Graphene.graphene_point3d_tHandle p, float x, float y, float z)
	{
		if (p.IsInvalid || p.IsClosed) throw new Exception("Invalid or closed handle (graphene_point3d_t)");
		return graphene_point3d_tExterns.graphene_point3d_init(p, x, y, z);
	}

	public static MentorLake.Graphene.graphene_point3d_tHandle InitFromPoint(this MentorLake.Graphene.graphene_point3d_tHandle p, MentorLake.Graphene.graphene_point3d_tHandle src)
	{
		if (p.IsInvalid || p.IsClosed) throw new Exception("Invalid or closed handle (graphene_point3d_t)");
		return graphene_point3d_tExterns.graphene_point3d_init_from_point(p, src);
	}

	public static MentorLake.Graphene.graphene_point3d_tHandle InitFromVec3(this MentorLake.Graphene.graphene_point3d_tHandle p, MentorLake.Graphene.graphene_vec3_tHandle v)
	{
		if (p.IsInvalid || p.IsClosed) throw new Exception("Invalid or closed handle (graphene_point3d_t)");
		return graphene_point3d_tExterns.graphene_point3d_init_from_vec3(p, v);
	}

	public static void Interpolate(this MentorLake.Graphene.graphene_point3d_tHandle a, MentorLake.Graphene.graphene_point3d_tHandle b, double factor, out MentorLake.Graphene.graphene_point3d_t res)
	{
		if (a.IsInvalid || a.IsClosed) throw new Exception("Invalid or closed handle (graphene_point3d_t)");
		graphene_point3d_tExterns.graphene_point3d_interpolate(a, b, factor, out res);
	}

	public static float Length(this MentorLake.Graphene.graphene_point3d_tHandle p)
	{
		if (p.IsInvalid || p.IsClosed) throw new Exception("Invalid or closed handle (graphene_point3d_t)");
		return graphene_point3d_tExterns.graphene_point3d_length(p);
	}

	public static bool Near(this MentorLake.Graphene.graphene_point3d_tHandle a, MentorLake.Graphene.graphene_point3d_tHandle b, float epsilon)
	{
		if (a.IsInvalid || a.IsClosed) throw new Exception("Invalid or closed handle (graphene_point3d_t)");
		return graphene_point3d_tExterns.graphene_point3d_near(a, b, epsilon);
	}

	public static void Normalize(this MentorLake.Graphene.graphene_point3d_tHandle p, out MentorLake.Graphene.graphene_point3d_t res)
	{
		if (p.IsInvalid || p.IsClosed) throw new Exception("Invalid or closed handle (graphene_point3d_t)");
		graphene_point3d_tExterns.graphene_point3d_normalize(p, out res);
	}

	public static void NormalizeViewport(this MentorLake.Graphene.graphene_point3d_tHandle p, MentorLake.Graphene.graphene_rect_tHandle viewport, float z_near, float z_far, out MentorLake.Graphene.graphene_point3d_t res)
	{
		if (p.IsInvalid || p.IsClosed) throw new Exception("Invalid or closed handle (graphene_point3d_t)");
		graphene_point3d_tExterns.graphene_point3d_normalize_viewport(p, viewport, z_near, z_far, out res);
	}

	public static void Scale(this MentorLake.Graphene.graphene_point3d_tHandle p, float factor, out MentorLake.Graphene.graphene_point3d_t res)
	{
		if (p.IsInvalid || p.IsClosed) throw new Exception("Invalid or closed handle (graphene_point3d_t)");
		graphene_point3d_tExterns.graphene_point3d_scale(p, factor, out res);
	}

	public static void ToVec3(this MentorLake.Graphene.graphene_point3d_tHandle p, out MentorLake.Graphene.graphene_vec3_t v)
	{
		if (p.IsInvalid || p.IsClosed) throw new Exception("Invalid or closed handle (graphene_point3d_t)");
		graphene_point3d_tExterns.graphene_point3d_to_vec3(p, out v);
	}


	public static graphene_point3d_t Dereference(this graphene_point3d_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<graphene_point3d_t>(x.DangerousGetHandle());
}
internal class graphene_point3d_tExterns
{
	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_point3d_tHandle graphene_point3d_alloc();

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_point3d_cross([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle b, out MentorLake.Graphene.graphene_point3d_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_point3d_distance([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle b, out MentorLake.Graphene.graphene_vec3_t delta);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_point3d_dot([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle b);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_point3d_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle b);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_point3d_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle p);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_point3d_tHandle graphene_point3d_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle p, float x, float y, float z);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_point3d_tHandle graphene_point3d_init_from_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle p, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle src);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_point3d_tHandle graphene_point3d_init_from_vec3([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle p, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle v);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_point3d_interpolate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle b, double factor, out MentorLake.Graphene.graphene_point3d_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_point3d_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle p);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_point3d_near([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle b, float epsilon);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_point3d_normalize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle p, out MentorLake.Graphene.graphene_point3d_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_point3d_normalize_viewport([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle p, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle viewport, float z_near, float z_far, out MentorLake.Graphene.graphene_point3d_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_point3d_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle p, float factor, out MentorLake.Graphene.graphene_point3d_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_point3d_to_vec3([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle p, out MentorLake.Graphene.graphene_vec3_t v);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_point3d_tHandle graphene_point3d_zero();

}

public struct graphene_point3d_t
{
	public float x;
	public float y;
	public float z;
	public static MentorLake.Graphene.graphene_point3d_tHandle Zero()
	{
		return graphene_point3d_tExterns.graphene_point3d_zero();
	}

}
