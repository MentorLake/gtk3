namespace MentorLake.Graphene;

public class GrapheneGlobalFunctions
{
/// <summary>
/// <para>
/// A degenerate #graphene_box_t that can only be expanded.
/// </para>
/// <para>
/// The returned value is owned by Graphene and should not be modified or freed.
/// </para>
/// </summary>

/// <return>
/// a #graphene_box_t
/// </return>

	public static MentorLake.Graphene.graphene_box_tHandle BoxEmpty()
	{
		return GrapheneGlobalFunctionsExterns.graphene_box_empty();
	}

/// <summary>
/// <para>
/// A degenerate #graphene_box_t that cannot be expanded.
/// </para>
/// <para>
/// The returned value is owned by Graphene and should not be modified or freed.
/// </para>
/// </summary>

/// <return>
/// a #graphene_box_t
/// </return>

	public static MentorLake.Graphene.graphene_box_tHandle BoxInfinite()
	{
		return GrapheneGlobalFunctionsExterns.graphene_box_infinite();
	}

/// <summary>
/// <para>
/// A #graphene_box_t with the minimum vertex set at (-1, -1, -1) and the
/// maximum vertex set at (0, 0, 0).
/// </para>
/// <para>
/// The returned value is owned by Graphene and should not be modified or freed.
/// </para>
/// </summary>

/// <return>
/// a #graphene_box_t
/// </return>

	public static MentorLake.Graphene.graphene_box_tHandle BoxMinusOne()
	{
		return GrapheneGlobalFunctionsExterns.graphene_box_minus_one();
	}

/// <summary>
/// <para>
/// A #graphene_box_t with the minimum vertex set at (0, 0, 0) and the
/// maximum vertex set at (1, 1, 1).
/// </para>
/// <para>
/// The returned value is owned by Graphene and should not be modified or freed.
/// </para>
/// </summary>

/// <return>
/// a #graphene_box_t
/// </return>

	public static MentorLake.Graphene.graphene_box_tHandle BoxOne()
	{
		return GrapheneGlobalFunctionsExterns.graphene_box_one();
	}

/// <summary>
/// <para>
/// A #graphene_box_t with the minimum vertex set at (-1, -1, -1) and the
/// maximum vertex set at (1, 1, 1).
/// </para>
/// <para>
/// The returned value is owned by Graphene and should not be modified or freed.
/// </para>
/// </summary>

/// <return>
/// a #graphene_box_t
/// </return>

	public static MentorLake.Graphene.graphene_box_tHandle BoxOneMinusOne()
	{
		return GrapheneGlobalFunctionsExterns.graphene_box_one_minus_one();
	}

/// <summary>
/// <para>
/// A #graphene_box_t with both the minimum and maximum vertices set at (0, 0, 0).
/// </para>
/// <para>
/// The returned value is owned by Graphene and should not be modified or freed.
/// </para>
/// </summary>

/// <return>
/// a #graphene_box_t
/// </return>

	public static MentorLake.Graphene.graphene_box_tHandle BoxZero()
	{
		return GrapheneGlobalFunctionsExterns.graphene_box_zero();
	}

/// <summary>
/// <para>
/// Retrieves a constant point with all three coordinates set to 0.
/// </para>
/// </summary>

/// <return>
/// a zero point
/// </return>

	public static MentorLake.Graphene.graphene_point3d_tHandle Point3DZero()
	{
		return GrapheneGlobalFunctionsExterns.graphene_point3d_zero();
	}

/// <summary>
/// <para>
/// Returns a point fixed at (0, 0).
/// </para>
/// </summary>

/// <return>
/// a fixed point
/// </return>

	public static MentorLake.Graphene.graphene_point_tHandle PointZero()
	{
		return GrapheneGlobalFunctionsExterns.graphene_point_zero();
	}

/// <summary>
/// <para>
/// Allocates a new #graphene_rect_t.
/// </para>
/// <para>
/// The contents of the returned rectangle are undefined.
/// </para>
/// </summary>

/// <return>
/// the newly allocated rectangle
/// </return>

	public static MentorLake.Graphene.graphene_rect_tHandle RectAlloc()
	{
		return GrapheneGlobalFunctionsExterns.graphene_rect_alloc();
	}

/// <summary>
/// <para>
/// Returns a degenerate rectangle with origin fixed at (0, 0) and
/// a size of 0, 0.
/// </para>
/// </summary>

/// <return>
/// a fixed rectangle
/// </return>

	public static MentorLake.Graphene.graphene_rect_tHandle RectZero()
	{
		return GrapheneGlobalFunctionsExterns.graphene_rect_zero();
	}

/// <summary>
/// <para>
/// A constant pointer to a zero #graphene_size_t, useful for
/// equality checks and interpolations.
/// </para>
/// </summary>

/// <return>
/// a constant size
/// </return>

	public static MentorLake.Graphene.graphene_size_tHandle SizeZero()
	{
		return GrapheneGlobalFunctionsExterns.graphene_size_zero();
	}

/// <summary>
/// <para>
/// Retrieves a constant vector with (1, 1) components.
/// </para>
/// </summary>

/// <return>
/// the one vector
/// </return>

	public static MentorLake.Graphene.graphene_vec2_tHandle Vec2One()
	{
		return GrapheneGlobalFunctionsExterns.graphene_vec2_one();
	}

/// <summary>
/// <para>
/// Retrieves a constant vector with (1, 0) components.
/// </para>
/// </summary>

/// <return>
/// the X axis vector
/// </return>

	public static MentorLake.Graphene.graphene_vec2_tHandle Vec2XAxis()
	{
		return GrapheneGlobalFunctionsExterns.graphene_vec2_x_axis();
	}

/// <summary>
/// <para>
/// Retrieves a constant vector with (0, 1) components.
/// </para>
/// </summary>

/// <return>
/// the Y axis vector
/// </return>

	public static MentorLake.Graphene.graphene_vec2_tHandle Vec2YAxis()
	{
		return GrapheneGlobalFunctionsExterns.graphene_vec2_y_axis();
	}

/// <summary>
/// <para>
/// Retrieves a constant vector with (0, 0) components.
/// </para>
/// </summary>

/// <return>
/// the zero vector
/// </return>

	public static MentorLake.Graphene.graphene_vec2_tHandle Vec2Zero()
	{
		return GrapheneGlobalFunctionsExterns.graphene_vec2_zero();
	}

/// <summary>
/// <para>
/// Provides a constant pointer to a vector with three components,
/// all sets to 1.
/// </para>
/// </summary>

/// <return>
/// a constant vector
/// </return>

	public static MentorLake.Graphene.graphene_vec3_tHandle Vec3One()
	{
		return GrapheneGlobalFunctionsExterns.graphene_vec3_one();
	}

/// <summary>
/// <para>
/// Provides a constant pointer to a vector with three components
/// with values set to (1, 0, 0).
/// </para>
/// </summary>

/// <return>
/// a constant vector
/// </return>

	public static MentorLake.Graphene.graphene_vec3_tHandle Vec3XAxis()
	{
		return GrapheneGlobalFunctionsExterns.graphene_vec3_x_axis();
	}

/// <summary>
/// <para>
/// Provides a constant pointer to a vector with three components
/// with values set to (0, 1, 0).
/// </para>
/// </summary>

/// <return>
/// a constant vector
/// </return>

	public static MentorLake.Graphene.graphene_vec3_tHandle Vec3YAxis()
	{
		return GrapheneGlobalFunctionsExterns.graphene_vec3_y_axis();
	}

/// <summary>
/// <para>
/// Provides a constant pointer to a vector with three components
/// with values set to (0, 0, 1).
/// </para>
/// </summary>

/// <return>
/// a constant vector
/// </return>

	public static MentorLake.Graphene.graphene_vec3_tHandle Vec3ZAxis()
	{
		return GrapheneGlobalFunctionsExterns.graphene_vec3_z_axis();
	}

/// <summary>
/// <para>
/// Provides a constant pointer to a vector with three components,
/// all sets to 0.
/// </para>
/// </summary>

/// <return>
/// a constant vector
/// </return>

	public static MentorLake.Graphene.graphene_vec3_tHandle Vec3Zero()
	{
		return GrapheneGlobalFunctionsExterns.graphene_vec3_zero();
	}

/// <summary>
/// <para>
/// Retrieves a pointer to a #graphene_vec4_t with all its
/// components set to 1.
/// </para>
/// </summary>

/// <return>
/// a constant vector
/// </return>

	public static MentorLake.Graphene.graphene_vec4_tHandle Vec4One()
	{
		return GrapheneGlobalFunctionsExterns.graphene_vec4_one();
	}

/// <summary>
/// <para>
/// Retrieves a pointer to a #graphene_vec4_t with its
/// components set to (0, 0, 0, 1).
/// </para>
/// </summary>

/// <return>
/// a constant vector
/// </return>

	public static MentorLake.Graphene.graphene_vec4_tHandle Vec4WAxis()
	{
		return GrapheneGlobalFunctionsExterns.graphene_vec4_w_axis();
	}

/// <summary>
/// <para>
/// Retrieves a pointer to a #graphene_vec4_t with its
/// components set to (1, 0, 0, 0).
/// </para>
/// </summary>

/// <return>
/// a constant vector
/// </return>

	public static MentorLake.Graphene.graphene_vec4_tHandle Vec4XAxis()
	{
		return GrapheneGlobalFunctionsExterns.graphene_vec4_x_axis();
	}

/// <summary>
/// <para>
/// Retrieves a pointer to a #graphene_vec4_t with its
/// components set to (0, 1, 0, 0).
/// </para>
/// </summary>

/// <return>
/// a constant vector
/// </return>

	public static MentorLake.Graphene.graphene_vec4_tHandle Vec4YAxis()
	{
		return GrapheneGlobalFunctionsExterns.graphene_vec4_y_axis();
	}

/// <summary>
/// <para>
/// Retrieves a pointer to a #graphene_vec4_t with its
/// components set to (0, 0, 1, 0).
/// </para>
/// </summary>

/// <return>
/// a constant vector
/// </return>

	public static MentorLake.Graphene.graphene_vec4_tHandle Vec4ZAxis()
	{
		return GrapheneGlobalFunctionsExterns.graphene_vec4_z_axis();
	}

/// <summary>
/// <para>
/// Retrieves a pointer to a #graphene_vec4_t with all its
/// components set to 0.
/// </para>
/// </summary>

/// <return>
/// a constant vector
/// </return>

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
