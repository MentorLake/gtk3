namespace MentorLake.Graphene;

public class graphene_vec2_tHandle : BaseSafeHandle
{
	public static MentorLake.Graphene.graphene_vec2_tHandle Alloc()
	{
		return graphene_vec2_tExterns.graphene_vec2_alloc();
	}

}


public static class graphene_vec2_tExtensions
{
	public static void Add(this MentorLake.Graphene.graphene_vec2_tHandle a, MentorLake.Graphene.graphene_vec2_tHandle b, out MentorLake.Graphene.graphene_vec2_t res)
	{
		graphene_vec2_tExterns.graphene_vec2_add(a, b, out res);
	}

	public static void Divide(this MentorLake.Graphene.graphene_vec2_tHandle a, MentorLake.Graphene.graphene_vec2_tHandle b, out MentorLake.Graphene.graphene_vec2_t res)
	{
		graphene_vec2_tExterns.graphene_vec2_divide(a, b, out res);
	}

	public static float Dot(this MentorLake.Graphene.graphene_vec2_tHandle a, MentorLake.Graphene.graphene_vec2_tHandle b)
	{
		return graphene_vec2_tExterns.graphene_vec2_dot(a, b);
	}

	public static bool Equal(this MentorLake.Graphene.graphene_vec2_tHandle v1, MentorLake.Graphene.graphene_vec2_tHandle v2)
	{
		return graphene_vec2_tExterns.graphene_vec2_equal(v1, v2);
	}

	public static void Free(this MentorLake.Graphene.graphene_vec2_tHandle v)
	{
		graphene_vec2_tExterns.graphene_vec2_free(v);
	}

	public static float GetX(this MentorLake.Graphene.graphene_vec2_tHandle v)
	{
		return graphene_vec2_tExterns.graphene_vec2_get_x(v);
	}

	public static float GetY(this MentorLake.Graphene.graphene_vec2_tHandle v)
	{
		return graphene_vec2_tExterns.graphene_vec2_get_y(v);
	}

	public static MentorLake.Graphene.graphene_vec2_tHandle Init(this MentorLake.Graphene.graphene_vec2_tHandle v, float x, float y)
	{
		return graphene_vec2_tExterns.graphene_vec2_init(v, x, y);
	}

	public static MentorLake.Graphene.graphene_vec2_tHandle InitFromFloat(this MentorLake.Graphene.graphene_vec2_tHandle v, float[] src)
	{
		return graphene_vec2_tExterns.graphene_vec2_init_from_float(v, src);
	}

	public static MentorLake.Graphene.graphene_vec2_tHandle InitFromVec2(this MentorLake.Graphene.graphene_vec2_tHandle v, MentorLake.Graphene.graphene_vec2_tHandle src)
	{
		return graphene_vec2_tExterns.graphene_vec2_init_from_vec2(v, src);
	}

	public static void Interpolate(this MentorLake.Graphene.graphene_vec2_tHandle v1, MentorLake.Graphene.graphene_vec2_tHandle v2, double factor, out MentorLake.Graphene.graphene_vec2_t res)
	{
		graphene_vec2_tExterns.graphene_vec2_interpolate(v1, v2, factor, out res);
	}

	public static float Length(this MentorLake.Graphene.graphene_vec2_tHandle v)
	{
		return graphene_vec2_tExterns.graphene_vec2_length(v);
	}

	public static void Max(this MentorLake.Graphene.graphene_vec2_tHandle a, MentorLake.Graphene.graphene_vec2_tHandle b, out MentorLake.Graphene.graphene_vec2_t res)
	{
		graphene_vec2_tExterns.graphene_vec2_max(a, b, out res);
	}

	public static void Min(this MentorLake.Graphene.graphene_vec2_tHandle a, MentorLake.Graphene.graphene_vec2_tHandle b, out MentorLake.Graphene.graphene_vec2_t res)
	{
		graphene_vec2_tExterns.graphene_vec2_min(a, b, out res);
	}

	public static void Multiply(this MentorLake.Graphene.graphene_vec2_tHandle a, MentorLake.Graphene.graphene_vec2_tHandle b, out MentorLake.Graphene.graphene_vec2_t res)
	{
		graphene_vec2_tExterns.graphene_vec2_multiply(a, b, out res);
	}

	public static bool Near(this MentorLake.Graphene.graphene_vec2_tHandle v1, MentorLake.Graphene.graphene_vec2_tHandle v2, float epsilon)
	{
		return graphene_vec2_tExterns.graphene_vec2_near(v1, v2, epsilon);
	}

	public static void Negate(this MentorLake.Graphene.graphene_vec2_tHandle v, out MentorLake.Graphene.graphene_vec2_t res)
	{
		graphene_vec2_tExterns.graphene_vec2_negate(v, out res);
	}

	public static void Normalize(this MentorLake.Graphene.graphene_vec2_tHandle v, out MentorLake.Graphene.graphene_vec2_t res)
	{
		graphene_vec2_tExterns.graphene_vec2_normalize(v, out res);
	}

	public static void Scale(this MentorLake.Graphene.graphene_vec2_tHandle v, float factor, out MentorLake.Graphene.graphene_vec2_t res)
	{
		graphene_vec2_tExterns.graphene_vec2_scale(v, factor, out res);
	}

	public static void Subtract(this MentorLake.Graphene.graphene_vec2_tHandle a, MentorLake.Graphene.graphene_vec2_tHandle b, out MentorLake.Graphene.graphene_vec2_t res)
	{
		graphene_vec2_tExterns.graphene_vec2_subtract(a, b, out res);
	}

	public static void ToFloat(this MentorLake.Graphene.graphene_vec2_tHandle v, out float[] dest)
	{
		graphene_vec2_tExterns.graphene_vec2_to_float(v, out dest);
	}


	public static graphene_vec2_t Dereference(this graphene_vec2_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<graphene_vec2_t>(x.DangerousGetHandle());
}
internal class graphene_vec2_tExterns
{
	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_vec2_tHandle graphene_vec2_alloc();

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec2_add([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle b, out MentorLake.Graphene.graphene_vec2_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec2_divide([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle b, out MentorLake.Graphene.graphene_vec2_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_vec2_dot([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle b);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_vec2_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle v1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle v2);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec2_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle v);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_vec2_get_x([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle v);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_vec2_get_y([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle v);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_vec2_tHandle graphene_vec2_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle v, float x, float y);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_vec2_tHandle graphene_vec2_init_from_float([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle v, float[] src);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_vec2_tHandle graphene_vec2_init_from_vec2([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle v, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle src);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec2_interpolate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle v1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle v2, double factor, out MentorLake.Graphene.graphene_vec2_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_vec2_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle v);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec2_max([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle b, out MentorLake.Graphene.graphene_vec2_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec2_min([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle b, out MentorLake.Graphene.graphene_vec2_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec2_multiply([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle b, out MentorLake.Graphene.graphene_vec2_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_vec2_near([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle v1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle v2, float epsilon);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec2_negate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle v, out MentorLake.Graphene.graphene_vec2_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec2_normalize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle v, out MentorLake.Graphene.graphene_vec2_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec2_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle v, float factor, out MentorLake.Graphene.graphene_vec2_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec2_subtract([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle b, out MentorLake.Graphene.graphene_vec2_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec2_to_float([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle v, out float[] dest);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_vec2_tHandle graphene_vec2_one();

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_vec2_tHandle graphene_vec2_x_axis();

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_vec2_tHandle graphene_vec2_y_axis();

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_vec2_tHandle graphene_vec2_zero();

}

public struct graphene_vec2_t
{
	public static MentorLake.Graphene.graphene_vec2_tHandle One()
	{
		return graphene_vec2_tExterns.graphene_vec2_one();
	}

	public static MentorLake.Graphene.graphene_vec2_tHandle XAxis()
	{
		return graphene_vec2_tExterns.graphene_vec2_x_axis();
	}

	public static MentorLake.Graphene.graphene_vec2_tHandle YAxis()
	{
		return graphene_vec2_tExterns.graphene_vec2_y_axis();
	}

	public static MentorLake.Graphene.graphene_vec2_tHandle Zero()
	{
		return graphene_vec2_tExterns.graphene_vec2_zero();
	}

}
