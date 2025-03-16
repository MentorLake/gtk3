namespace MentorLake.Graphene;

public class graphene_point_tHandle : BaseSafeHandle
{
	public static MentorLake.Graphene.graphene_point_tHandle Alloc()
	{
		return graphene_point_tExterns.graphene_point_alloc();
	}

}


public static class graphene_point_tExtensions
{
	public static float Distance(this MentorLake.Graphene.graphene_point_tHandle a, MentorLake.Graphene.graphene_point_tHandle b, out float d_x, out float d_y)
	{
		return graphene_point_tExterns.graphene_point_distance(a, b, out d_x, out d_y);
	}

	public static bool Equal(this MentorLake.Graphene.graphene_point_tHandle a, MentorLake.Graphene.graphene_point_tHandle b)
	{
		return graphene_point_tExterns.graphene_point_equal(a, b);
	}

	public static void Free(this MentorLake.Graphene.graphene_point_tHandle p)
	{
		graphene_point_tExterns.graphene_point_free(p);
	}

	public static MentorLake.Graphene.graphene_point_tHandle Init(this MentorLake.Graphene.graphene_point_tHandle p, float x, float y)
	{
		return graphene_point_tExterns.graphene_point_init(p, x, y);
	}

	public static MentorLake.Graphene.graphene_point_tHandle InitFromPoint(this MentorLake.Graphene.graphene_point_tHandle p, MentorLake.Graphene.graphene_point_tHandle src)
	{
		return graphene_point_tExterns.graphene_point_init_from_point(p, src);
	}

	public static MentorLake.Graphene.graphene_point_tHandle InitFromVec2(this MentorLake.Graphene.graphene_point_tHandle p, MentorLake.Graphene.graphene_vec2_tHandle src)
	{
		return graphene_point_tExterns.graphene_point_init_from_vec2(p, src);
	}

	public static void Interpolate(this MentorLake.Graphene.graphene_point_tHandle a, MentorLake.Graphene.graphene_point_tHandle b, double factor, out MentorLake.Graphene.graphene_point_t res)
	{
		graphene_point_tExterns.graphene_point_interpolate(a, b, factor, out res);
	}

	public static bool Near(this MentorLake.Graphene.graphene_point_tHandle a, MentorLake.Graphene.graphene_point_tHandle b, float epsilon)
	{
		return graphene_point_tExterns.graphene_point_near(a, b, epsilon);
	}

	public static void ToVec2(this MentorLake.Graphene.graphene_point_tHandle p, out MentorLake.Graphene.graphene_vec2_t v)
	{
		graphene_point_tExterns.graphene_point_to_vec2(p, out v);
	}


	public static graphene_point_t Dereference(this graphene_point_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<graphene_point_t>(x.DangerousGetHandle());
}
internal class graphene_point_tExterns
{
	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_point_tHandle graphene_point_alloc();

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_point_distance([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))] MentorLake.Graphene.graphene_point_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))] MentorLake.Graphene.graphene_point_tHandle b, out float d_x, out float d_y);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_point_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))] MentorLake.Graphene.graphene_point_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))] MentorLake.Graphene.graphene_point_tHandle b);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_point_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))] MentorLake.Graphene.graphene_point_tHandle p);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_point_tHandle graphene_point_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))] MentorLake.Graphene.graphene_point_tHandle p, float x, float y);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_point_tHandle graphene_point_init_from_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))] MentorLake.Graphene.graphene_point_tHandle p, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))] MentorLake.Graphene.graphene_point_tHandle src);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_point_tHandle graphene_point_init_from_vec2([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))] MentorLake.Graphene.graphene_point_tHandle p, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle src);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_point_interpolate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))] MentorLake.Graphene.graphene_point_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))] MentorLake.Graphene.graphene_point_tHandle b, double factor, out MentorLake.Graphene.graphene_point_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_point_near([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))] MentorLake.Graphene.graphene_point_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))] MentorLake.Graphene.graphene_point_tHandle b, float epsilon);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_point_to_vec2([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))] MentorLake.Graphene.graphene_point_tHandle p, out MentorLake.Graphene.graphene_vec2_t v);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_point_tHandle graphene_point_zero();

}

public struct graphene_point_t
{
	public float x;
	public float y;
	public static MentorLake.Graphene.graphene_point_tHandle Zero()
	{
		return graphene_point_tExterns.graphene_point_zero();
	}

}
