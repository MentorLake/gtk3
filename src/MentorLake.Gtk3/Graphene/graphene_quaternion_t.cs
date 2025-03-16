namespace MentorLake.Graphene;

public class graphene_quaternion_tHandle : BaseSafeHandle
{
	public static MentorLake.Graphene.graphene_quaternion_tHandle Alloc()
	{
		return graphene_quaternion_tExterns.graphene_quaternion_alloc();
	}

}


public static class graphene_quaternion_tExtensions
{
	public static void Add(this MentorLake.Graphene.graphene_quaternion_tHandle a, MentorLake.Graphene.graphene_quaternion_tHandle b, out MentorLake.Graphene.graphene_quaternion_t res)
	{
		graphene_quaternion_tExterns.graphene_quaternion_add(a, b, out res);
	}

	public static float Dot(this MentorLake.Graphene.graphene_quaternion_tHandle a, MentorLake.Graphene.graphene_quaternion_tHandle b)
	{
		return graphene_quaternion_tExterns.graphene_quaternion_dot(a, b);
	}

	public static bool Equal(this MentorLake.Graphene.graphene_quaternion_tHandle a, MentorLake.Graphene.graphene_quaternion_tHandle b)
	{
		return graphene_quaternion_tExterns.graphene_quaternion_equal(a, b);
	}

	public static void Free(this MentorLake.Graphene.graphene_quaternion_tHandle q)
	{
		graphene_quaternion_tExterns.graphene_quaternion_free(q);
	}

	public static MentorLake.Graphene.graphene_quaternion_tHandle Init(this MentorLake.Graphene.graphene_quaternion_tHandle q, float x, float y, float z, float w)
	{
		return graphene_quaternion_tExterns.graphene_quaternion_init(q, x, y, z, w);
	}

	public static MentorLake.Graphene.graphene_quaternion_tHandle InitFromAngleVec3(this MentorLake.Graphene.graphene_quaternion_tHandle q, float angle, MentorLake.Graphene.graphene_vec3_tHandle axis)
	{
		return graphene_quaternion_tExterns.graphene_quaternion_init_from_angle_vec3(q, angle, axis);
	}

	public static MentorLake.Graphene.graphene_quaternion_tHandle InitFromAngles(this MentorLake.Graphene.graphene_quaternion_tHandle q, float deg_x, float deg_y, float deg_z)
	{
		return graphene_quaternion_tExterns.graphene_quaternion_init_from_angles(q, deg_x, deg_y, deg_z);
	}

	public static MentorLake.Graphene.graphene_quaternion_tHandle InitFromEuler(this MentorLake.Graphene.graphene_quaternion_tHandle q, MentorLake.Graphene.graphene_euler_tHandle e)
	{
		return graphene_quaternion_tExterns.graphene_quaternion_init_from_euler(q, e);
	}

	public static MentorLake.Graphene.graphene_quaternion_tHandle InitFromMatrix(this MentorLake.Graphene.graphene_quaternion_tHandle q, MentorLake.Graphene.graphene_matrix_tHandle m)
	{
		return graphene_quaternion_tExterns.graphene_quaternion_init_from_matrix(q, m);
	}

	public static MentorLake.Graphene.graphene_quaternion_tHandle InitFromQuaternion(this MentorLake.Graphene.graphene_quaternion_tHandle q, MentorLake.Graphene.graphene_quaternion_tHandle src)
	{
		return graphene_quaternion_tExterns.graphene_quaternion_init_from_quaternion(q, src);
	}

	public static MentorLake.Graphene.graphene_quaternion_tHandle InitFromRadians(this MentorLake.Graphene.graphene_quaternion_tHandle q, float rad_x, float rad_y, float rad_z)
	{
		return graphene_quaternion_tExterns.graphene_quaternion_init_from_radians(q, rad_x, rad_y, rad_z);
	}

	public static MentorLake.Graphene.graphene_quaternion_tHandle InitFromVec4(this MentorLake.Graphene.graphene_quaternion_tHandle q, MentorLake.Graphene.graphene_vec4_tHandle src)
	{
		return graphene_quaternion_tExterns.graphene_quaternion_init_from_vec4(q, src);
	}

	public static MentorLake.Graphene.graphene_quaternion_tHandle InitIdentity(this MentorLake.Graphene.graphene_quaternion_tHandle q)
	{
		return graphene_quaternion_tExterns.graphene_quaternion_init_identity(q);
	}

	public static void Invert(this MentorLake.Graphene.graphene_quaternion_tHandle q, out MentorLake.Graphene.graphene_quaternion_t res)
	{
		graphene_quaternion_tExterns.graphene_quaternion_invert(q, out res);
	}

	public static void Multiply(this MentorLake.Graphene.graphene_quaternion_tHandle a, MentorLake.Graphene.graphene_quaternion_tHandle b, out MentorLake.Graphene.graphene_quaternion_t res)
	{
		graphene_quaternion_tExterns.graphene_quaternion_multiply(a, b, out res);
	}

	public static void Normalize(this MentorLake.Graphene.graphene_quaternion_tHandle q, out MentorLake.Graphene.graphene_quaternion_t res)
	{
		graphene_quaternion_tExterns.graphene_quaternion_normalize(q, out res);
	}

	public static void Scale(this MentorLake.Graphene.graphene_quaternion_tHandle q, float factor, out MentorLake.Graphene.graphene_quaternion_t res)
	{
		graphene_quaternion_tExterns.graphene_quaternion_scale(q, factor, out res);
	}

	public static void Slerp(this MentorLake.Graphene.graphene_quaternion_tHandle a, MentorLake.Graphene.graphene_quaternion_tHandle b, float factor, out MentorLake.Graphene.graphene_quaternion_t res)
	{
		graphene_quaternion_tExterns.graphene_quaternion_slerp(a, b, factor, out res);
	}

	public static void ToAngleVec3(this MentorLake.Graphene.graphene_quaternion_tHandle q, out float angle, out MentorLake.Graphene.graphene_vec3_t axis)
	{
		graphene_quaternion_tExterns.graphene_quaternion_to_angle_vec3(q, out angle, out axis);
	}

	public static void ToAngles(this MentorLake.Graphene.graphene_quaternion_tHandle q, out float deg_x, out float deg_y, out float deg_z)
	{
		graphene_quaternion_tExterns.graphene_quaternion_to_angles(q, out deg_x, out deg_y, out deg_z);
	}

	public static void ToMatrix(this MentorLake.Graphene.graphene_quaternion_tHandle q, out MentorLake.Graphene.graphene_matrix_t m)
	{
		graphene_quaternion_tExterns.graphene_quaternion_to_matrix(q, out m);
	}

	public static void ToRadians(this MentorLake.Graphene.graphene_quaternion_tHandle q, out float rad_x, out float rad_y, out float rad_z)
	{
		graphene_quaternion_tExterns.graphene_quaternion_to_radians(q, out rad_x, out rad_y, out rad_z);
	}

	public static void ToVec4(this MentorLake.Graphene.graphene_quaternion_tHandle q, out MentorLake.Graphene.graphene_vec4_t res)
	{
		graphene_quaternion_tExterns.graphene_quaternion_to_vec4(q, out res);
	}


	public static graphene_quaternion_t Dereference(this graphene_quaternion_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<graphene_quaternion_t>(x.DangerousGetHandle());
}
internal class graphene_quaternion_tExterns
{
	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_quaternion_tHandle graphene_quaternion_alloc();

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_quaternion_add([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))] MentorLake.Graphene.graphene_quaternion_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))] MentorLake.Graphene.graphene_quaternion_tHandle b, out MentorLake.Graphene.graphene_quaternion_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_quaternion_dot([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))] MentorLake.Graphene.graphene_quaternion_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))] MentorLake.Graphene.graphene_quaternion_tHandle b);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_quaternion_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))] MentorLake.Graphene.graphene_quaternion_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))] MentorLake.Graphene.graphene_quaternion_tHandle b);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_quaternion_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))] MentorLake.Graphene.graphene_quaternion_tHandle q);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_quaternion_tHandle graphene_quaternion_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))] MentorLake.Graphene.graphene_quaternion_tHandle q, float x, float y, float z, float w);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_quaternion_tHandle graphene_quaternion_init_from_angle_vec3([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))] MentorLake.Graphene.graphene_quaternion_tHandle q, float angle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle axis);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_quaternion_tHandle graphene_quaternion_init_from_angles([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))] MentorLake.Graphene.graphene_quaternion_tHandle q, float deg_x, float deg_y, float deg_z);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_quaternion_tHandle graphene_quaternion_init_from_euler([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))] MentorLake.Graphene.graphene_quaternion_tHandle q, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_euler_tHandle>))] MentorLake.Graphene.graphene_euler_tHandle e);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_quaternion_tHandle graphene_quaternion_init_from_matrix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))] MentorLake.Graphene.graphene_quaternion_tHandle q, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_quaternion_tHandle graphene_quaternion_init_from_quaternion([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))] MentorLake.Graphene.graphene_quaternion_tHandle q, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))] MentorLake.Graphene.graphene_quaternion_tHandle src);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_quaternion_tHandle graphene_quaternion_init_from_radians([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))] MentorLake.Graphene.graphene_quaternion_tHandle q, float rad_x, float rad_y, float rad_z);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_quaternion_tHandle graphene_quaternion_init_from_vec4([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))] MentorLake.Graphene.graphene_quaternion_tHandle q, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle src);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_quaternion_tHandle graphene_quaternion_init_identity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))] MentorLake.Graphene.graphene_quaternion_tHandle q);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_quaternion_invert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))] MentorLake.Graphene.graphene_quaternion_tHandle q, out MentorLake.Graphene.graphene_quaternion_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_quaternion_multiply([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))] MentorLake.Graphene.graphene_quaternion_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))] MentorLake.Graphene.graphene_quaternion_tHandle b, out MentorLake.Graphene.graphene_quaternion_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_quaternion_normalize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))] MentorLake.Graphene.graphene_quaternion_tHandle q, out MentorLake.Graphene.graphene_quaternion_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_quaternion_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))] MentorLake.Graphene.graphene_quaternion_tHandle q, float factor, out MentorLake.Graphene.graphene_quaternion_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_quaternion_slerp([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))] MentorLake.Graphene.graphene_quaternion_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))] MentorLake.Graphene.graphene_quaternion_tHandle b, float factor, out MentorLake.Graphene.graphene_quaternion_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_quaternion_to_angle_vec3([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))] MentorLake.Graphene.graphene_quaternion_tHandle q, out float angle, out MentorLake.Graphene.graphene_vec3_t axis);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_quaternion_to_angles([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))] MentorLake.Graphene.graphene_quaternion_tHandle q, out float deg_x, out float deg_y, out float deg_z);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_quaternion_to_matrix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))] MentorLake.Graphene.graphene_quaternion_tHandle q, out MentorLake.Graphene.graphene_matrix_t m);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_quaternion_to_radians([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))] MentorLake.Graphene.graphene_quaternion_tHandle q, out float rad_x, out float rad_y, out float rad_z);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_quaternion_to_vec4([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))] MentorLake.Graphene.graphene_quaternion_tHandle q, out MentorLake.Graphene.graphene_vec4_t res);

}

public struct graphene_quaternion_t
{
}
