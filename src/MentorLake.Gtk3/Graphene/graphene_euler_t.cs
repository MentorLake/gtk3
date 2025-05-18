namespace MentorLake.Graphene;

public class graphene_euler_tHandle : BaseSafeHandle
{
	public static MentorLake.Graphene.graphene_euler_tHandle Alloc()
	{
		return graphene_euler_tExterns.graphene_euler_alloc();
	}

}


public static class graphene_euler_tExtensions
{
	public static bool Equal(this MentorLake.Graphene.graphene_euler_tHandle a, MentorLake.Graphene.graphene_euler_tHandle b)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_euler_t)");
		return graphene_euler_tExterns.graphene_euler_equal(a, b);
	}

	public static void Free(this MentorLake.Graphene.graphene_euler_tHandle e)
	{
		if (e.IsInvalid) throw new Exception("Invalid handle (graphene_euler_t)");
		graphene_euler_tExterns.graphene_euler_free(e);
	}

	public static float GetAlpha(this MentorLake.Graphene.graphene_euler_tHandle e)
	{
		if (e.IsInvalid) throw new Exception("Invalid handle (graphene_euler_t)");
		return graphene_euler_tExterns.graphene_euler_get_alpha(e);
	}

	public static float GetBeta(this MentorLake.Graphene.graphene_euler_tHandle e)
	{
		if (e.IsInvalid) throw new Exception("Invalid handle (graphene_euler_t)");
		return graphene_euler_tExterns.graphene_euler_get_beta(e);
	}

	public static float GetGamma(this MentorLake.Graphene.graphene_euler_tHandle e)
	{
		if (e.IsInvalid) throw new Exception("Invalid handle (graphene_euler_t)");
		return graphene_euler_tExterns.graphene_euler_get_gamma(e);
	}

	public static MentorLake.Graphene.graphene_euler_order_t GetOrder(this MentorLake.Graphene.graphene_euler_tHandle e)
	{
		if (e.IsInvalid) throw new Exception("Invalid handle (graphene_euler_t)");
		return graphene_euler_tExterns.graphene_euler_get_order(e);
	}

	public static float GetX(this MentorLake.Graphene.graphene_euler_tHandle e)
	{
		if (e.IsInvalid) throw new Exception("Invalid handle (graphene_euler_t)");
		return graphene_euler_tExterns.graphene_euler_get_x(e);
	}

	public static float GetY(this MentorLake.Graphene.graphene_euler_tHandle e)
	{
		if (e.IsInvalid) throw new Exception("Invalid handle (graphene_euler_t)");
		return graphene_euler_tExterns.graphene_euler_get_y(e);
	}

	public static float GetZ(this MentorLake.Graphene.graphene_euler_tHandle e)
	{
		if (e.IsInvalid) throw new Exception("Invalid handle (graphene_euler_t)");
		return graphene_euler_tExterns.graphene_euler_get_z(e);
	}

	public static MentorLake.Graphene.graphene_euler_tHandle Init(this MentorLake.Graphene.graphene_euler_tHandle e, float x, float y, float z)
	{
		if (e.IsInvalid) throw new Exception("Invalid handle (graphene_euler_t)");
		return graphene_euler_tExterns.graphene_euler_init(e, x, y, z);
	}

	public static MentorLake.Graphene.graphene_euler_tHandle InitFromEuler(this MentorLake.Graphene.graphene_euler_tHandle e, MentorLake.Graphene.graphene_euler_tHandle src)
	{
		if (e.IsInvalid) throw new Exception("Invalid handle (graphene_euler_t)");
		return graphene_euler_tExterns.graphene_euler_init_from_euler(e, src);
	}

	public static MentorLake.Graphene.graphene_euler_tHandle InitFromMatrix(this MentorLake.Graphene.graphene_euler_tHandle e, MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_euler_order_t order)
	{
		if (e.IsInvalid) throw new Exception("Invalid handle (graphene_euler_t)");
		return graphene_euler_tExterns.graphene_euler_init_from_matrix(e, m, order);
	}

	public static MentorLake.Graphene.graphene_euler_tHandle InitFromQuaternion(this MentorLake.Graphene.graphene_euler_tHandle e, MentorLake.Graphene.graphene_quaternion_tHandle q, MentorLake.Graphene.graphene_euler_order_t order)
	{
		if (e.IsInvalid) throw new Exception("Invalid handle (graphene_euler_t)");
		return graphene_euler_tExterns.graphene_euler_init_from_quaternion(e, q, order);
	}

	public static MentorLake.Graphene.graphene_euler_tHandle InitFromRadians(this MentorLake.Graphene.graphene_euler_tHandle e, float x, float y, float z, MentorLake.Graphene.graphene_euler_order_t order)
	{
		if (e.IsInvalid) throw new Exception("Invalid handle (graphene_euler_t)");
		return graphene_euler_tExterns.graphene_euler_init_from_radians(e, x, y, z, order);
	}

	public static MentorLake.Graphene.graphene_euler_tHandle InitFromVec3(this MentorLake.Graphene.graphene_euler_tHandle e, MentorLake.Graphene.graphene_vec3_tHandle v, MentorLake.Graphene.graphene_euler_order_t order)
	{
		if (e.IsInvalid) throw new Exception("Invalid handle (graphene_euler_t)");
		return graphene_euler_tExterns.graphene_euler_init_from_vec3(e, v, order);
	}

	public static MentorLake.Graphene.graphene_euler_tHandle InitWithOrder(this MentorLake.Graphene.graphene_euler_tHandle e, float x, float y, float z, MentorLake.Graphene.graphene_euler_order_t order)
	{
		if (e.IsInvalid) throw new Exception("Invalid handle (graphene_euler_t)");
		return graphene_euler_tExterns.graphene_euler_init_with_order(e, x, y, z, order);
	}

	public static void Reorder(this MentorLake.Graphene.graphene_euler_tHandle e, MentorLake.Graphene.graphene_euler_order_t order, out MentorLake.Graphene.graphene_euler_t res)
	{
		if (e.IsInvalid) throw new Exception("Invalid handle (graphene_euler_t)");
		graphene_euler_tExterns.graphene_euler_reorder(e, order, out res);
	}

	public static void ToMatrix(this MentorLake.Graphene.graphene_euler_tHandle e, out MentorLake.Graphene.graphene_matrix_t res)
	{
		if (e.IsInvalid) throw new Exception("Invalid handle (graphene_euler_t)");
		graphene_euler_tExterns.graphene_euler_to_matrix(e, out res);
	}

	public static void ToQuaternion(this MentorLake.Graphene.graphene_euler_tHandle e, out MentorLake.Graphene.graphene_quaternion_t res)
	{
		if (e.IsInvalid) throw new Exception("Invalid handle (graphene_euler_t)");
		graphene_euler_tExterns.graphene_euler_to_quaternion(e, out res);
	}

	public static void ToVec3(this MentorLake.Graphene.graphene_euler_tHandle e, out MentorLake.Graphene.graphene_vec3_t res)
	{
		if (e.IsInvalid) throw new Exception("Invalid handle (graphene_euler_t)");
		graphene_euler_tExterns.graphene_euler_to_vec3(e, out res);
	}


	public static graphene_euler_t Dereference(this graphene_euler_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<graphene_euler_t>(x.DangerousGetHandle());
}
internal class graphene_euler_tExterns
{
	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_euler_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_euler_tHandle graphene_euler_alloc();

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_euler_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_euler_tHandle>))] MentorLake.Graphene.graphene_euler_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_euler_tHandle>))] MentorLake.Graphene.graphene_euler_tHandle b);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_euler_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_euler_tHandle>))] MentorLake.Graphene.graphene_euler_tHandle e);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_euler_get_alpha([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_euler_tHandle>))] MentorLake.Graphene.graphene_euler_tHandle e);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_euler_get_beta([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_euler_tHandle>))] MentorLake.Graphene.graphene_euler_tHandle e);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_euler_get_gamma([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_euler_tHandle>))] MentorLake.Graphene.graphene_euler_tHandle e);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_euler_order_t graphene_euler_get_order([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_euler_tHandle>))] MentorLake.Graphene.graphene_euler_tHandle e);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_euler_get_x([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_euler_tHandle>))] MentorLake.Graphene.graphene_euler_tHandle e);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_euler_get_y([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_euler_tHandle>))] MentorLake.Graphene.graphene_euler_tHandle e);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_euler_get_z([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_euler_tHandle>))] MentorLake.Graphene.graphene_euler_tHandle e);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_euler_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_euler_tHandle graphene_euler_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_euler_tHandle>))] MentorLake.Graphene.graphene_euler_tHandle e, float x, float y, float z);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_euler_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_euler_tHandle graphene_euler_init_from_euler([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_euler_tHandle>))] MentorLake.Graphene.graphene_euler_tHandle e, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_euler_tHandle>))] MentorLake.Graphene.graphene_euler_tHandle src);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_euler_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_euler_tHandle graphene_euler_init_from_matrix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_euler_tHandle>))] MentorLake.Graphene.graphene_euler_tHandle e, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_euler_order_t order);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_euler_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_euler_tHandle graphene_euler_init_from_quaternion([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_euler_tHandle>))] MentorLake.Graphene.graphene_euler_tHandle e, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))] MentorLake.Graphene.graphene_quaternion_tHandle q, MentorLake.Graphene.graphene_euler_order_t order);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_euler_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_euler_tHandle graphene_euler_init_from_radians([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_euler_tHandle>))] MentorLake.Graphene.graphene_euler_tHandle e, float x, float y, float z, MentorLake.Graphene.graphene_euler_order_t order);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_euler_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_euler_tHandle graphene_euler_init_from_vec3([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_euler_tHandle>))] MentorLake.Graphene.graphene_euler_tHandle e, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle v, MentorLake.Graphene.graphene_euler_order_t order);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_euler_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_euler_tHandle graphene_euler_init_with_order([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_euler_tHandle>))] MentorLake.Graphene.graphene_euler_tHandle e, float x, float y, float z, MentorLake.Graphene.graphene_euler_order_t order);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_euler_reorder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_euler_tHandle>))] MentorLake.Graphene.graphene_euler_tHandle e, MentorLake.Graphene.graphene_euler_order_t order, out MentorLake.Graphene.graphene_euler_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_euler_to_matrix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_euler_tHandle>))] MentorLake.Graphene.graphene_euler_tHandle e, out MentorLake.Graphene.graphene_matrix_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_euler_to_quaternion([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_euler_tHandle>))] MentorLake.Graphene.graphene_euler_tHandle e, out MentorLake.Graphene.graphene_quaternion_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_euler_to_vec3([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_euler_tHandle>))] MentorLake.Graphene.graphene_euler_tHandle e, out MentorLake.Graphene.graphene_vec3_t res);

}

public struct graphene_euler_t
{
}
