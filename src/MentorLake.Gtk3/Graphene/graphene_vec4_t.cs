namespace MentorLake.Graphene;

public class graphene_vec4_tHandle : BaseSafeHandle
{
	public static MentorLake.Graphene.graphene_vec4_tHandle Alloc()
	{
		return graphene_vec4_tExterns.graphene_vec4_alloc();
	}

}


public static class graphene_vec4_tExtensions
{
	public static void Add(this MentorLake.Graphene.graphene_vec4_tHandle a, MentorLake.Graphene.graphene_vec4_tHandle b, out MentorLake.Graphene.graphene_vec4_t res)
	{
		graphene_vec4_tExterns.graphene_vec4_add(a, b, out res);
	}

	public static void Divide(this MentorLake.Graphene.graphene_vec4_tHandle a, MentorLake.Graphene.graphene_vec4_tHandle b, out MentorLake.Graphene.graphene_vec4_t res)
	{
		graphene_vec4_tExterns.graphene_vec4_divide(a, b, out res);
	}

	public static float Dot(this MentorLake.Graphene.graphene_vec4_tHandle a, MentorLake.Graphene.graphene_vec4_tHandle b)
	{
		return graphene_vec4_tExterns.graphene_vec4_dot(a, b);
	}

	public static bool Equal(this MentorLake.Graphene.graphene_vec4_tHandle v1, MentorLake.Graphene.graphene_vec4_tHandle v2)
	{
		return graphene_vec4_tExterns.graphene_vec4_equal(v1, v2);
	}

	public static void Free(this MentorLake.Graphene.graphene_vec4_tHandle v)
	{
		graphene_vec4_tExterns.graphene_vec4_free(v);
	}

	public static float GetW(this MentorLake.Graphene.graphene_vec4_tHandle v)
	{
		return graphene_vec4_tExterns.graphene_vec4_get_w(v);
	}

	public static float GetX(this MentorLake.Graphene.graphene_vec4_tHandle v)
	{
		return graphene_vec4_tExterns.graphene_vec4_get_x(v);
	}

	public static void GetXy(this MentorLake.Graphene.graphene_vec4_tHandle v, out MentorLake.Graphene.graphene_vec2_t res)
	{
		graphene_vec4_tExterns.graphene_vec4_get_xy(v, out res);
	}

	public static void GetXyz(this MentorLake.Graphene.graphene_vec4_tHandle v, out MentorLake.Graphene.graphene_vec3_t res)
	{
		graphene_vec4_tExterns.graphene_vec4_get_xyz(v, out res);
	}

	public static float GetY(this MentorLake.Graphene.graphene_vec4_tHandle v)
	{
		return graphene_vec4_tExterns.graphene_vec4_get_y(v);
	}

	public static float GetZ(this MentorLake.Graphene.graphene_vec4_tHandle v)
	{
		return graphene_vec4_tExterns.graphene_vec4_get_z(v);
	}

	public static MentorLake.Graphene.graphene_vec4_tHandle Init(this MentorLake.Graphene.graphene_vec4_tHandle v, float x, float y, float z, float w)
	{
		return graphene_vec4_tExterns.graphene_vec4_init(v, x, y, z, w);
	}

	public static MentorLake.Graphene.graphene_vec4_tHandle InitFromFloat(this MentorLake.Graphene.graphene_vec4_tHandle v, float[] src)
	{
		return graphene_vec4_tExterns.graphene_vec4_init_from_float(v, src);
	}

	public static MentorLake.Graphene.graphene_vec4_tHandle InitFromVec2(this MentorLake.Graphene.graphene_vec4_tHandle v, MentorLake.Graphene.graphene_vec2_tHandle src, float z, float w)
	{
		return graphene_vec4_tExterns.graphene_vec4_init_from_vec2(v, src, z, w);
	}

	public static MentorLake.Graphene.graphene_vec4_tHandle InitFromVec3(this MentorLake.Graphene.graphene_vec4_tHandle v, MentorLake.Graphene.graphene_vec3_tHandle src, float w)
	{
		return graphene_vec4_tExterns.graphene_vec4_init_from_vec3(v, src, w);
	}

	public static MentorLake.Graphene.graphene_vec4_tHandle InitFromVec4(this MentorLake.Graphene.graphene_vec4_tHandle v, MentorLake.Graphene.graphene_vec4_tHandle src)
	{
		return graphene_vec4_tExterns.graphene_vec4_init_from_vec4(v, src);
	}

	public static void Interpolate(this MentorLake.Graphene.graphene_vec4_tHandle v1, MentorLake.Graphene.graphene_vec4_tHandle v2, double factor, out MentorLake.Graphene.graphene_vec4_t res)
	{
		graphene_vec4_tExterns.graphene_vec4_interpolate(v1, v2, factor, out res);
	}

	public static float Length(this MentorLake.Graphene.graphene_vec4_tHandle v)
	{
		return graphene_vec4_tExterns.graphene_vec4_length(v);
	}

	public static void Max(this MentorLake.Graphene.graphene_vec4_tHandle a, MentorLake.Graphene.graphene_vec4_tHandle b, out MentorLake.Graphene.graphene_vec4_t res)
	{
		graphene_vec4_tExterns.graphene_vec4_max(a, b, out res);
	}

	public static void Min(this MentorLake.Graphene.graphene_vec4_tHandle a, MentorLake.Graphene.graphene_vec4_tHandle b, out MentorLake.Graphene.graphene_vec4_t res)
	{
		graphene_vec4_tExterns.graphene_vec4_min(a, b, out res);
	}

	public static void Multiply(this MentorLake.Graphene.graphene_vec4_tHandle a, MentorLake.Graphene.graphene_vec4_tHandle b, out MentorLake.Graphene.graphene_vec4_t res)
	{
		graphene_vec4_tExterns.graphene_vec4_multiply(a, b, out res);
	}

	public static bool Near(this MentorLake.Graphene.graphene_vec4_tHandle v1, MentorLake.Graphene.graphene_vec4_tHandle v2, float epsilon)
	{
		return graphene_vec4_tExterns.graphene_vec4_near(v1, v2, epsilon);
	}

	public static void Negate(this MentorLake.Graphene.graphene_vec4_tHandle v, out MentorLake.Graphene.graphene_vec4_t res)
	{
		graphene_vec4_tExterns.graphene_vec4_negate(v, out res);
	}

	public static void Normalize(this MentorLake.Graphene.graphene_vec4_tHandle v, out MentorLake.Graphene.graphene_vec4_t res)
	{
		graphene_vec4_tExterns.graphene_vec4_normalize(v, out res);
	}

	public static void Scale(this MentorLake.Graphene.graphene_vec4_tHandle v, float factor, out MentorLake.Graphene.graphene_vec4_t res)
	{
		graphene_vec4_tExterns.graphene_vec4_scale(v, factor, out res);
	}

	public static void Subtract(this MentorLake.Graphene.graphene_vec4_tHandle a, MentorLake.Graphene.graphene_vec4_tHandle b, out MentorLake.Graphene.graphene_vec4_t res)
	{
		graphene_vec4_tExterns.graphene_vec4_subtract(a, b, out res);
	}

	public static void ToFloat(this MentorLake.Graphene.graphene_vec4_tHandle v, out float[] dest)
	{
		graphene_vec4_tExterns.graphene_vec4_to_float(v, out dest);
	}


	public static graphene_vec4_t Dereference(this graphene_vec4_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<graphene_vec4_t>(x.DangerousGetHandle());
}
internal class graphene_vec4_tExterns
{
	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_vec4_tHandle graphene_vec4_alloc();

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec4_add([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle b, out MentorLake.Graphene.graphene_vec4_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec4_divide([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle b, out MentorLake.Graphene.graphene_vec4_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_vec4_dot([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle b);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_vec4_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle v1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle v2);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec4_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle v);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_vec4_get_w([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle v);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_vec4_get_x([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle v);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec4_get_xy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle v, out MentorLake.Graphene.graphene_vec2_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec4_get_xyz([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle v, out MentorLake.Graphene.graphene_vec3_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_vec4_get_y([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle v);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_vec4_get_z([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle v);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_vec4_tHandle graphene_vec4_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle v, float x, float y, float z, float w);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_vec4_tHandle graphene_vec4_init_from_float([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle v, float[] src);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_vec4_tHandle graphene_vec4_init_from_vec2([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle v, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle src, float z, float w);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_vec4_tHandle graphene_vec4_init_from_vec3([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle v, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle src, float w);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_vec4_tHandle graphene_vec4_init_from_vec4([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle v, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle src);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec4_interpolate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle v1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle v2, double factor, out MentorLake.Graphene.graphene_vec4_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_vec4_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle v);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec4_max([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle b, out MentorLake.Graphene.graphene_vec4_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec4_min([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle b, out MentorLake.Graphene.graphene_vec4_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec4_multiply([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle b, out MentorLake.Graphene.graphene_vec4_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_vec4_near([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle v1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle v2, float epsilon);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec4_negate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle v, out MentorLake.Graphene.graphene_vec4_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec4_normalize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle v, out MentorLake.Graphene.graphene_vec4_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec4_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle v, float factor, out MentorLake.Graphene.graphene_vec4_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec4_subtract([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle b, out MentorLake.Graphene.graphene_vec4_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec4_to_float([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle v, out float[] dest);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_vec4_tHandle graphene_vec4_one();

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_vec4_tHandle graphene_vec4_w_axis();

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_vec4_tHandle graphene_vec4_x_axis();

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_vec4_tHandle graphene_vec4_y_axis();

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_vec4_tHandle graphene_vec4_z_axis();

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_vec4_tHandle graphene_vec4_zero();

}

public struct graphene_vec4_t
{
	public static MentorLake.Graphene.graphene_vec4_tHandle One()
	{
		return graphene_vec4_tExterns.graphene_vec4_one();
	}

	public static MentorLake.Graphene.graphene_vec4_tHandle WAxis()
	{
		return graphene_vec4_tExterns.graphene_vec4_w_axis();
	}

	public static MentorLake.Graphene.graphene_vec4_tHandle XAxis()
	{
		return graphene_vec4_tExterns.graphene_vec4_x_axis();
	}

	public static MentorLake.Graphene.graphene_vec4_tHandle YAxis()
	{
		return graphene_vec4_tExterns.graphene_vec4_y_axis();
	}

	public static MentorLake.Graphene.graphene_vec4_tHandle ZAxis()
	{
		return graphene_vec4_tExterns.graphene_vec4_z_axis();
	}

	public static MentorLake.Graphene.graphene_vec4_tHandle Zero()
	{
		return graphene_vec4_tExterns.graphene_vec4_zero();
	}

}
