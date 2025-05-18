namespace MentorLake.Graphene;

public class GrapheneGlobalFunctions
{
	public static MentorLake.Graphene.graphene_box_tHandle BoxEmpty()
	{
		return GrapheneGlobalFunctionsExterns.graphene_box_empty();
	}

	public static MentorLake.Graphene.graphene_box_tHandle BoxInfinite()
	{
		return GrapheneGlobalFunctionsExterns.graphene_box_infinite();
	}

	public static MentorLake.Graphene.graphene_box_tHandle BoxMinusOne()
	{
		return GrapheneGlobalFunctionsExterns.graphene_box_minus_one();
	}

	public static MentorLake.Graphene.graphene_box_tHandle BoxOne()
	{
		return GrapheneGlobalFunctionsExterns.graphene_box_one();
	}

	public static MentorLake.Graphene.graphene_box_tHandle BoxOneMinusOne()
	{
		return GrapheneGlobalFunctionsExterns.graphene_box_one_minus_one();
	}

	public static MentorLake.Graphene.graphene_box_tHandle BoxZero()
	{
		return GrapheneGlobalFunctionsExterns.graphene_box_zero();
	}

	public static MentorLake.Graphene.graphene_point3d_tHandle Point3DZero()
	{
		return GrapheneGlobalFunctionsExterns.graphene_point3d_zero();
	}

	public static MentorLake.Graphene.graphene_point_tHandle PointZero()
	{
		return GrapheneGlobalFunctionsExterns.graphene_point_zero();
	}

	public static MentorLake.Graphene.graphene_rect_tHandle RectAlloc()
	{
		return GrapheneGlobalFunctionsExterns.graphene_rect_alloc();
	}

	public static MentorLake.Graphene.graphene_rect_tHandle RectZero()
	{
		return GrapheneGlobalFunctionsExterns.graphene_rect_zero();
	}

	public static MentorLake.Graphene.graphene_size_tHandle SizeZero()
	{
		return GrapheneGlobalFunctionsExterns.graphene_size_zero();
	}

	public static MentorLake.Graphene.graphene_vec2_tHandle Vec2One()
	{
		return GrapheneGlobalFunctionsExterns.graphene_vec2_one();
	}

	public static MentorLake.Graphene.graphene_vec2_tHandle Vec2XAxis()
	{
		return GrapheneGlobalFunctionsExterns.graphene_vec2_x_axis();
	}

	public static MentorLake.Graphene.graphene_vec2_tHandle Vec2YAxis()
	{
		return GrapheneGlobalFunctionsExterns.graphene_vec2_y_axis();
	}

	public static MentorLake.Graphene.graphene_vec2_tHandle Vec2Zero()
	{
		return GrapheneGlobalFunctionsExterns.graphene_vec2_zero();
	}

	public static MentorLake.Graphene.graphene_vec3_tHandle Vec3One()
	{
		return GrapheneGlobalFunctionsExterns.graphene_vec3_one();
	}

	public static MentorLake.Graphene.graphene_vec3_tHandle Vec3XAxis()
	{
		return GrapheneGlobalFunctionsExterns.graphene_vec3_x_axis();
	}

	public static MentorLake.Graphene.graphene_vec3_tHandle Vec3YAxis()
	{
		return GrapheneGlobalFunctionsExterns.graphene_vec3_y_axis();
	}

	public static MentorLake.Graphene.graphene_vec3_tHandle Vec3ZAxis()
	{
		return GrapheneGlobalFunctionsExterns.graphene_vec3_z_axis();
	}

	public static MentorLake.Graphene.graphene_vec3_tHandle Vec3Zero()
	{
		return GrapheneGlobalFunctionsExterns.graphene_vec3_zero();
	}

	public static MentorLake.Graphene.graphene_vec4_tHandle Vec4One()
	{
		return GrapheneGlobalFunctionsExterns.graphene_vec4_one();
	}

	public static MentorLake.Graphene.graphene_vec4_tHandle Vec4WAxis()
	{
		return GrapheneGlobalFunctionsExterns.graphene_vec4_w_axis();
	}

	public static MentorLake.Graphene.graphene_vec4_tHandle Vec4XAxis()
	{
		return GrapheneGlobalFunctionsExterns.graphene_vec4_x_axis();
	}

	public static MentorLake.Graphene.graphene_vec4_tHandle Vec4YAxis()
	{
		return GrapheneGlobalFunctionsExterns.graphene_vec4_y_axis();
	}

	public static MentorLake.Graphene.graphene_vec4_tHandle Vec4ZAxis()
	{
		return GrapheneGlobalFunctionsExterns.graphene_vec4_z_axis();
	}

	public static MentorLake.Graphene.graphene_vec4_tHandle Vec4Zero()
	{
		return GrapheneGlobalFunctionsExterns.graphene_vec4_zero();
	}

}

internal class GrapheneGlobalFunctionsExterns
{
	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_box_tHandle graphene_box_empty();

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_box_tHandle graphene_box_infinite();

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_box_tHandle graphene_box_minus_one();

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_box_tHandle graphene_box_one();

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_box_tHandle graphene_box_one_minus_one();

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_box_tHandle graphene_box_zero();

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_point3d_tHandle graphene_point3d_zero();

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_point_tHandle graphene_point_zero();

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_rect_tHandle graphene_rect_alloc();

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_rect_tHandle graphene_rect_zero();

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_size_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_size_tHandle graphene_size_zero();

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_vec2_tHandle graphene_vec2_one();

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_vec2_tHandle graphene_vec2_x_axis();

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_vec2_tHandle graphene_vec2_y_axis();

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_vec2_tHandle graphene_vec2_zero();

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

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_vec4_tHandle graphene_vec4_one();

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_vec4_tHandle graphene_vec4_w_axis();

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_vec4_tHandle graphene_vec4_x_axis();

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_vec4_tHandle graphene_vec4_y_axis();

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_vec4_tHandle graphene_vec4_z_axis();

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_vec4_tHandle graphene_vec4_zero();

}
