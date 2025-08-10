namespace MentorLake.Graphene;

public class graphene_vec3_tHandle : BaseSafeHandle
{
	public static MentorLake.Graphene.graphene_vec3_tHandle Alloc()
	{
		return graphene_vec3_tExterns.graphene_vec3_alloc();
	}

}


public static class graphene_vec3_tExtensions
{
	public static void Add(this MentorLake.Graphene.graphene_vec3_tHandle a, MentorLake.Graphene.graphene_vec3_tHandle b, out MentorLake.Graphene.graphene_vec3_t res)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_vec3_t)");
		graphene_vec3_tExterns.graphene_vec3_add(a, b, out res);
	}

	public static void Cross(this MentorLake.Graphene.graphene_vec3_tHandle a, MentorLake.Graphene.graphene_vec3_tHandle b, out MentorLake.Graphene.graphene_vec3_t res)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_vec3_t)");
		graphene_vec3_tExterns.graphene_vec3_cross(a, b, out res);
	}

	public static void Divide(this MentorLake.Graphene.graphene_vec3_tHandle a, MentorLake.Graphene.graphene_vec3_tHandle b, out MentorLake.Graphene.graphene_vec3_t res)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_vec3_t)");
		graphene_vec3_tExterns.graphene_vec3_divide(a, b, out res);
	}

	public static float Dot(this MentorLake.Graphene.graphene_vec3_tHandle a, MentorLake.Graphene.graphene_vec3_tHandle b)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_vec3_t)");
		return graphene_vec3_tExterns.graphene_vec3_dot(a, b);
	}

	public static bool Equal(this MentorLake.Graphene.graphene_vec3_tHandle v1, MentorLake.Graphene.graphene_vec3_tHandle v2)
	{
		if (v1.IsInvalid) throw new Exception("Invalid handle (graphene_vec3_t)");
		return graphene_vec3_tExterns.graphene_vec3_equal(v1, v2);
	}

	public static void Free(this MentorLake.Graphene.graphene_vec3_tHandle v)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec3_t)");
		graphene_vec3_tExterns.graphene_vec3_free(v);
	}

	public static float GetX(this MentorLake.Graphene.graphene_vec3_tHandle v)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec3_t)");
		return graphene_vec3_tExterns.graphene_vec3_get_x(v);
	}

	public static void GetXy(this MentorLake.Graphene.graphene_vec3_tHandle v, out MentorLake.Graphene.graphene_vec2_t res)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec3_t)");
		graphene_vec3_tExterns.graphene_vec3_get_xy(v, out res);
	}

	public static void GetXy0(this MentorLake.Graphene.graphene_vec3_tHandle v, out MentorLake.Graphene.graphene_vec3_t res)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec3_t)");
		graphene_vec3_tExterns.graphene_vec3_get_xy0(v, out res);
	}

	public static void GetXyz0(this MentorLake.Graphene.graphene_vec3_tHandle v, out MentorLake.Graphene.graphene_vec4_t res)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec3_t)");
		graphene_vec3_tExterns.graphene_vec3_get_xyz0(v, out res);
	}

	public static void GetXyz1(this MentorLake.Graphene.graphene_vec3_tHandle v, out MentorLake.Graphene.graphene_vec4_t res)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec3_t)");
		graphene_vec3_tExterns.graphene_vec3_get_xyz1(v, out res);
	}

	public static void GetXyzw(this MentorLake.Graphene.graphene_vec3_tHandle v, float w, out MentorLake.Graphene.graphene_vec4_t res)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec3_t)");
		graphene_vec3_tExterns.graphene_vec3_get_xyzw(v, w, out res);
	}

	public static float GetY(this MentorLake.Graphene.graphene_vec3_tHandle v)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec3_t)");
		return graphene_vec3_tExterns.graphene_vec3_get_y(v);
	}

	public static float GetZ(this MentorLake.Graphene.graphene_vec3_tHandle v)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec3_t)");
		return graphene_vec3_tExterns.graphene_vec3_get_z(v);
	}

	public static MentorLake.Graphene.graphene_vec3_tHandle Init(this MentorLake.Graphene.graphene_vec3_tHandle v, float x, float y, float z)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec3_t)");
		return graphene_vec3_tExterns.graphene_vec3_init(v, x, y, z);
	}

	public static MentorLake.Graphene.graphene_vec3_tHandle InitFromFloat(this MentorLake.Graphene.graphene_vec3_tHandle v, float[] src)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec3_t)");
		return graphene_vec3_tExterns.graphene_vec3_init_from_float(v, src);
	}

	public static MentorLake.Graphene.graphene_vec3_tHandle InitFromVec3(this MentorLake.Graphene.graphene_vec3_tHandle v, MentorLake.Graphene.graphene_vec3_tHandle src)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec3_t)");
		return graphene_vec3_tExterns.graphene_vec3_init_from_vec3(v, src);
	}

	public static void Interpolate(this MentorLake.Graphene.graphene_vec3_tHandle v1, MentorLake.Graphene.graphene_vec3_tHandle v2, double factor, out MentorLake.Graphene.graphene_vec3_t res)
	{
		if (v1.IsInvalid) throw new Exception("Invalid handle (graphene_vec3_t)");
		graphene_vec3_tExterns.graphene_vec3_interpolate(v1, v2, factor, out res);
	}

	public static float Length(this MentorLake.Graphene.graphene_vec3_tHandle v)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec3_t)");
		return graphene_vec3_tExterns.graphene_vec3_length(v);
	}

	public static void Max(this MentorLake.Graphene.graphene_vec3_tHandle a, MentorLake.Graphene.graphene_vec3_tHandle b, out MentorLake.Graphene.graphene_vec3_t res)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_vec3_t)");
		graphene_vec3_tExterns.graphene_vec3_max(a, b, out res);
	}

	public static void Min(this MentorLake.Graphene.graphene_vec3_tHandle a, MentorLake.Graphene.graphene_vec3_tHandle b, out MentorLake.Graphene.graphene_vec3_t res)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_vec3_t)");
		graphene_vec3_tExterns.graphene_vec3_min(a, b, out res);
	}

	public static void Multiply(this MentorLake.Graphene.graphene_vec3_tHandle a, MentorLake.Graphene.graphene_vec3_tHandle b, out MentorLake.Graphene.graphene_vec3_t res)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_vec3_t)");
		graphene_vec3_tExterns.graphene_vec3_multiply(a, b, out res);
	}

	public static bool Near(this MentorLake.Graphene.graphene_vec3_tHandle v1, MentorLake.Graphene.graphene_vec3_tHandle v2, float epsilon)
	{
		if (v1.IsInvalid) throw new Exception("Invalid handle (graphene_vec3_t)");
		return graphene_vec3_tExterns.graphene_vec3_near(v1, v2, epsilon);
	}

	public static void Negate(this MentorLake.Graphene.graphene_vec3_tHandle v, out MentorLake.Graphene.graphene_vec3_t res)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec3_t)");
		graphene_vec3_tExterns.graphene_vec3_negate(v, out res);
	}

	public static void Normalize(this MentorLake.Graphene.graphene_vec3_tHandle v, out MentorLake.Graphene.graphene_vec3_t res)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec3_t)");
		graphene_vec3_tExterns.graphene_vec3_normalize(v, out res);
	}

	public static void Scale(this MentorLake.Graphene.graphene_vec3_tHandle v, float factor, out MentorLake.Graphene.graphene_vec3_t res)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec3_t)");
		graphene_vec3_tExterns.graphene_vec3_scale(v, factor, out res);
	}

	public static void Subtract(this MentorLake.Graphene.graphene_vec3_tHandle a, MentorLake.Graphene.graphene_vec3_tHandle b, out MentorLake.Graphene.graphene_vec3_t res)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_vec3_t)");
		graphene_vec3_tExterns.graphene_vec3_subtract(a, b, out res);
	}

	public static void ToFloat(this MentorLake.Graphene.graphene_vec3_tHandle v, out float[] dest)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec3_t)");
		graphene_vec3_tExterns.graphene_vec3_to_float(v, out dest);
	}


	public static graphene_vec3_t Dereference(this graphene_vec3_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<graphene_vec3_t>(x.DangerousGetHandle());
}
internal class graphene_vec3_tExterns
{
	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_vec3_tHandle graphene_vec3_alloc();

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec3_add([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle b, out MentorLake.Graphene.graphene_vec3_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec3_cross([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle b, out MentorLake.Graphene.graphene_vec3_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec3_divide([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle b, out MentorLake.Graphene.graphene_vec3_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_vec3_dot([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle b);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_vec3_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle v1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle v2);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec3_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle v);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_vec3_get_x([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle v);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec3_get_xy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle v, out MentorLake.Graphene.graphene_vec2_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec3_get_xy0([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle v, out MentorLake.Graphene.graphene_vec3_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec3_get_xyz0([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle v, out MentorLake.Graphene.graphene_vec4_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec3_get_xyz1([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle v, out MentorLake.Graphene.graphene_vec4_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec3_get_xyzw([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle v, float w, out MentorLake.Graphene.graphene_vec4_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_vec3_get_y([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle v);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_vec3_get_z([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle v);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_vec3_tHandle graphene_vec3_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle v, float x, float y, float z);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_vec3_tHandle graphene_vec3_init_from_float([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle v, float[] src);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_vec3_tHandle graphene_vec3_init_from_vec3([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle v, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle src);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec3_interpolate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle v1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle v2, double factor, out MentorLake.Graphene.graphene_vec3_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_vec3_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle v);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec3_max([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle b, out MentorLake.Graphene.graphene_vec3_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec3_min([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle b, out MentorLake.Graphene.graphene_vec3_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec3_multiply([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle b, out MentorLake.Graphene.graphene_vec3_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_vec3_near([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle v1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle v2, float epsilon);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec3_negate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle v, out MentorLake.Graphene.graphene_vec3_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec3_normalize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle v, out MentorLake.Graphene.graphene_vec3_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec3_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle v, float factor, out MentorLake.Graphene.graphene_vec3_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec3_subtract([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle b, out MentorLake.Graphene.graphene_vec3_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_vec3_to_float([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle v, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] out float[] dest);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_vec3_tHandle graphene_vec3_one();

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_vec3_tHandle graphene_vec3_x_axis();

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_vec3_tHandle graphene_vec3_y_axis();

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_vec3_tHandle graphene_vec3_z_axis();

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_vec3_tHandle graphene_vec3_zero();

}

public struct graphene_vec3_t
{
	public static MentorLake.Graphene.graphene_vec3_tHandle One()
	{
		return graphene_vec3_tExterns.graphene_vec3_one();
	}

	public static MentorLake.Graphene.graphene_vec3_tHandle XAxis()
	{
		return graphene_vec3_tExterns.graphene_vec3_x_axis();
	}

	public static MentorLake.Graphene.graphene_vec3_tHandle YAxis()
	{
		return graphene_vec3_tExterns.graphene_vec3_y_axis();
	}

	public static MentorLake.Graphene.graphene_vec3_tHandle ZAxis()
	{
		return graphene_vec3_tExterns.graphene_vec3_z_axis();
	}

	public static MentorLake.Graphene.graphene_vec3_tHandle Zero()
	{
		return graphene_vec3_tExterns.graphene_vec3_zero();
	}

}
