namespace MentorLake.Graphene;

public class graphene_box_tHandle : BaseSafeHandle
{
	public static MentorLake.Graphene.graphene_box_tHandle Alloc()
	{
		return graphene_box_tExterns.graphene_box_alloc();
	}

}


public static class graphene_box_tExtensions
{
	public static bool ContainsBox(this MentorLake.Graphene.graphene_box_tHandle a, MentorLake.Graphene.graphene_box_tHandle b)
	{
		if (a.IsInvalid || a.IsClosed) throw new Exception("Invalid or closed handle (graphene_box_t)");
		return graphene_box_tExterns.graphene_box_contains_box(a, b);
	}

	public static bool ContainsPoint(this MentorLake.Graphene.graphene_box_tHandle box, MentorLake.Graphene.graphene_point3d_tHandle point)
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (graphene_box_t)");
		return graphene_box_tExterns.graphene_box_contains_point(box, point);
	}

	public static bool Equal(this MentorLake.Graphene.graphene_box_tHandle a, MentorLake.Graphene.graphene_box_tHandle b)
	{
		if (a.IsInvalid || a.IsClosed) throw new Exception("Invalid or closed handle (graphene_box_t)");
		return graphene_box_tExterns.graphene_box_equal(a, b);
	}

	public static void Expand(this MentorLake.Graphene.graphene_box_tHandle box, MentorLake.Graphene.graphene_point3d_tHandle point, out MentorLake.Graphene.graphene_box_t res)
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (graphene_box_t)");
		graphene_box_tExterns.graphene_box_expand(box, point, out res);
	}

	public static void ExpandScalar(this MentorLake.Graphene.graphene_box_tHandle box, float scalar, out MentorLake.Graphene.graphene_box_t res)
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (graphene_box_t)");
		graphene_box_tExterns.graphene_box_expand_scalar(box, scalar, out res);
	}

	public static void ExpandVec3(this MentorLake.Graphene.graphene_box_tHandle box, MentorLake.Graphene.graphene_vec3_tHandle vec, out MentorLake.Graphene.graphene_box_t res)
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (graphene_box_t)");
		graphene_box_tExterns.graphene_box_expand_vec3(box, vec, out res);
	}

	public static void Free(this MentorLake.Graphene.graphene_box_tHandle box)
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (graphene_box_t)");
		graphene_box_tExterns.graphene_box_free(box);
	}

	public static void GetBoundingSphere(this MentorLake.Graphene.graphene_box_tHandle box, out MentorLake.Graphene.graphene_sphere_t sphere)
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (graphene_box_t)");
		graphene_box_tExterns.graphene_box_get_bounding_sphere(box, out sphere);
	}

	public static void GetCenter(this MentorLake.Graphene.graphene_box_tHandle box, out MentorLake.Graphene.graphene_point3d_t center)
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (graphene_box_t)");
		graphene_box_tExterns.graphene_box_get_center(box, out center);
	}

	public static float GetDepth(this MentorLake.Graphene.graphene_box_tHandle box)
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (graphene_box_t)");
		return graphene_box_tExterns.graphene_box_get_depth(box);
	}

	public static float GetHeight(this MentorLake.Graphene.graphene_box_tHandle box)
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (graphene_box_t)");
		return graphene_box_tExterns.graphene_box_get_height(box);
	}

	public static void GetMax(this MentorLake.Graphene.graphene_box_tHandle box, out MentorLake.Graphene.graphene_point3d_t max)
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (graphene_box_t)");
		graphene_box_tExterns.graphene_box_get_max(box, out max);
	}

	public static void GetMin(this MentorLake.Graphene.graphene_box_tHandle box, out MentorLake.Graphene.graphene_point3d_t min)
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (graphene_box_t)");
		graphene_box_tExterns.graphene_box_get_min(box, out min);
	}

	public static void GetSize(this MentorLake.Graphene.graphene_box_tHandle box, out MentorLake.Graphene.graphene_vec3_t size)
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (graphene_box_t)");
		graphene_box_tExterns.graphene_box_get_size(box, out size);
	}

	public static void GetVertices(this MentorLake.Graphene.graphene_box_tHandle box, out MentorLake.Graphene.graphene_vec3_t[] vertices)
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (graphene_box_t)");
		graphene_box_tExterns.graphene_box_get_vertices(box, out vertices);
	}

	public static float GetWidth(this MentorLake.Graphene.graphene_box_tHandle box)
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (graphene_box_t)");
		return graphene_box_tExterns.graphene_box_get_width(box);
	}

	public static MentorLake.Graphene.graphene_box_tHandle Init(this MentorLake.Graphene.graphene_box_tHandle box, MentorLake.Graphene.graphene_point3d_tHandle min, MentorLake.Graphene.graphene_point3d_tHandle max)
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (graphene_box_t)");
		return graphene_box_tExterns.graphene_box_init(box, min, max);
	}

	public static MentorLake.Graphene.graphene_box_tHandle InitFromBox(this MentorLake.Graphene.graphene_box_tHandle box, MentorLake.Graphene.graphene_box_tHandle src)
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (graphene_box_t)");
		return graphene_box_tExterns.graphene_box_init_from_box(box, src);
	}

	public static MentorLake.Graphene.graphene_box_tHandle InitFromPoints(this MentorLake.Graphene.graphene_box_tHandle box, uint n_points, MentorLake.Graphene.graphene_point3d_t[] points)
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (graphene_box_t)");
		return graphene_box_tExterns.graphene_box_init_from_points(box, n_points, points);
	}

	public static MentorLake.Graphene.graphene_box_tHandle InitFromVec3(this MentorLake.Graphene.graphene_box_tHandle box, MentorLake.Graphene.graphene_vec3_tHandle min, MentorLake.Graphene.graphene_vec3_tHandle max)
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (graphene_box_t)");
		return graphene_box_tExterns.graphene_box_init_from_vec3(box, min, max);
	}

	public static MentorLake.Graphene.graphene_box_tHandle InitFromVectors(this MentorLake.Graphene.graphene_box_tHandle box, uint n_vectors, MentorLake.Graphene.graphene_vec3_t[] vectors)
	{
		if (box.IsInvalid || box.IsClosed) throw new Exception("Invalid or closed handle (graphene_box_t)");
		return graphene_box_tExterns.graphene_box_init_from_vectors(box, n_vectors, vectors);
	}

	public static bool Intersection(this MentorLake.Graphene.graphene_box_tHandle a, MentorLake.Graphene.graphene_box_tHandle b, out MentorLake.Graphene.graphene_box_t res)
	{
		if (a.IsInvalid || a.IsClosed) throw new Exception("Invalid or closed handle (graphene_box_t)");
		return graphene_box_tExterns.graphene_box_intersection(a, b, out res);
	}

	public static void Union(this MentorLake.Graphene.graphene_box_tHandle a, MentorLake.Graphene.graphene_box_tHandle b, out MentorLake.Graphene.graphene_box_t res)
	{
		if (a.IsInvalid || a.IsClosed) throw new Exception("Invalid or closed handle (graphene_box_t)");
		graphene_box_tExterns.graphene_box_union(a, b, out res);
	}


	public static graphene_box_t Dereference(this graphene_box_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<graphene_box_t>(x.DangerousGetHandle());
}
internal class graphene_box_tExterns
{
	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_box_tHandle graphene_box_alloc();

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_box_contains_box([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle b);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_box_contains_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle point);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_box_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle b);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_box_expand([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle point, out MentorLake.Graphene.graphene_box_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_box_expand_scalar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle box, float scalar, out MentorLake.Graphene.graphene_box_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_box_expand_vec3([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle vec, out MentorLake.Graphene.graphene_box_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_box_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle box);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_box_get_bounding_sphere([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle box, out MentorLake.Graphene.graphene_sphere_t sphere);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_box_get_center([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle box, out MentorLake.Graphene.graphene_point3d_t center);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_box_get_depth([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle box);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_box_get_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle box);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_box_get_max([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle box, out MentorLake.Graphene.graphene_point3d_t max);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_box_get_min([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle box, out MentorLake.Graphene.graphene_point3d_t min);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_box_get_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle box, out MentorLake.Graphene.graphene_vec3_t size);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_box_get_vertices([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle box, out MentorLake.Graphene.graphene_vec3_t[] vertices);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_box_get_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle box);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_box_tHandle graphene_box_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle min, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle max);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_box_tHandle graphene_box_init_from_box([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle src);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_box_tHandle graphene_box_init_from_points([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle box, uint n_points, MentorLake.Graphene.graphene_point3d_t[] points);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_box_tHandle graphene_box_init_from_vec3([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle min, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle max);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_box_tHandle graphene_box_init_from_vectors([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle box, uint n_vectors, MentorLake.Graphene.graphene_vec3_t[] vectors);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_box_intersection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle b, out MentorLake.Graphene.graphene_box_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_box_union([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle b, out MentorLake.Graphene.graphene_box_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_box_tHandle graphene_box_empty();

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_box_tHandle graphene_box_infinite();

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_box_tHandle graphene_box_minus_one();

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_box_tHandle graphene_box_one();

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_box_tHandle graphene_box_one_minus_one();

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_box_tHandle graphene_box_zero();

}

public struct graphene_box_t
{
	public static MentorLake.Graphene.graphene_box_tHandle Empty()
	{
		return graphene_box_tExterns.graphene_box_empty();
	}

	public static MentorLake.Graphene.graphene_box_tHandle Infinite()
	{
		return graphene_box_tExterns.graphene_box_infinite();
	}

	public static MentorLake.Graphene.graphene_box_tHandle MinusOne()
	{
		return graphene_box_tExterns.graphene_box_minus_one();
	}

	public static MentorLake.Graphene.graphene_box_tHandle One()
	{
		return graphene_box_tExterns.graphene_box_one();
	}

	public static MentorLake.Graphene.graphene_box_tHandle OneMinusOne()
	{
		return graphene_box_tExterns.graphene_box_one_minus_one();
	}

	public static MentorLake.Graphene.graphene_box_tHandle Zero()
	{
		return graphene_box_tExterns.graphene_box_zero();
	}

}
