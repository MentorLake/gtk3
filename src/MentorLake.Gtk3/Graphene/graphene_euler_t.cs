namespace MentorLake.Graphene;

/// <summary>
/// <para>
/// Describe a rotation using Euler angles.
/// </para>
/// <para>
/// The contents of the #graphene_euler_t structure are private
/// and should never be accessed directly.
/// </para>
/// </summary>

public class graphene_euler_tHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Allocates a new #graphene_euler_t.
/// </para>
/// <para>
/// The contents of the returned structure are undefined.
/// </para>
/// </summary>

/// <return>
/// the newly allocated #graphene_euler_t
/// </return>

	public static MentorLake.Graphene.graphene_euler_tHandle Alloc()
	{
		return graphene_euler_tExterns.graphene_euler_alloc();
	}

}


public static class graphene_euler_tExtensions
{
/// <summary>
/// <para>
/// Checks if two #graphene_euler_t are equal.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_euler_t
/// </param>
/// <param name="b">
/// a #graphene_euler_t
/// </param>
/// <return>
/// `true` if the two #graphene_euler_t are equal
/// </return>

	public static bool Equal(this MentorLake.Graphene.graphene_euler_tHandle a, MentorLake.Graphene.graphene_euler_tHandle b)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_euler_t)");
		return graphene_euler_tExterns.graphene_euler_equal(a, b);
	}

/// <summary>
/// <para>
/// Frees the resources allocated by graphene_euler_alloc().
/// </para>
/// </summary>

/// <param name="e">
/// a #graphene_euler_t
/// </param>

	public static void Free(this MentorLake.Graphene.graphene_euler_tHandle e)
	{
		if (e.IsInvalid) throw new Exception("Invalid handle (graphene_euler_t)");
		graphene_euler_tExterns.graphene_euler_free(e);
	}

/// <summary>
/// <para>
/// Retrieves the first component of the Euler angle vector,
/// depending on the order of rotation.
/// </para>
/// <para>
/// See also: graphene_euler_get_x()
/// </para>
/// </summary>

/// <param name="e">
/// a #graphene_euler_t
/// </param>
/// <return>
/// the first component of the Euler angle vector, in radians
/// </return>

	public static float GetAlpha(this MentorLake.Graphene.graphene_euler_tHandle e)
	{
		if (e.IsInvalid) throw new Exception("Invalid handle (graphene_euler_t)");
		return graphene_euler_tExterns.graphene_euler_get_alpha(e);
	}

/// <summary>
/// <para>
/// Retrieves the second component of the Euler angle vector,
/// depending on the order of rotation.
/// </para>
/// <para>
/// See also: graphene_euler_get_y()
/// </para>
/// </summary>

/// <param name="e">
/// a #graphene_euler_t
/// </param>
/// <return>
/// the second component of the Euler angle vector, in radians
/// </return>

	public static float GetBeta(this MentorLake.Graphene.graphene_euler_tHandle e)
	{
		if (e.IsInvalid) throw new Exception("Invalid handle (graphene_euler_t)");
		return graphene_euler_tExterns.graphene_euler_get_beta(e);
	}

/// <summary>
/// <para>
/// Retrieves the third component of the Euler angle vector,
/// depending on the order of rotation.
/// </para>
/// <para>
/// See also: graphene_euler_get_z()
/// </para>
/// </summary>

/// <param name="e">
/// a #graphene_euler_t
/// </param>
/// <return>
/// the third component of the Euler angle vector, in radians
/// </return>

	public static float GetGamma(this MentorLake.Graphene.graphene_euler_tHandle e)
	{
		if (e.IsInvalid) throw new Exception("Invalid handle (graphene_euler_t)");
		return graphene_euler_tExterns.graphene_euler_get_gamma(e);
	}

/// <summary>
/// <para>
/// Retrieves the order used to apply the rotations described in the
/// #graphene_euler_t structure, when converting to and from other
/// structures, like #graphene_quaternion_t and #graphene_matrix_t.
/// </para>
/// <para>
/// This function does not return the %GRAPHENE_EULER_ORDER_DEFAULT
/// enumeration value; it will return the effective order of rotation
/// instead.
/// </para>
/// </summary>

/// <param name="e">
/// a #graphene_euler_t
/// </param>
/// <return>
/// the order used to apply the rotations
/// </return>

	public static MentorLake.Graphene.graphene_euler_order_t GetOrder(this MentorLake.Graphene.graphene_euler_tHandle e)
	{
		if (e.IsInvalid) throw new Exception("Invalid handle (graphene_euler_t)");
		return graphene_euler_tExterns.graphene_euler_get_order(e);
	}

/// <summary>
/// <para>
/// Retrieves the rotation angle on the X axis, in degrees.
/// </para>
/// </summary>

/// <param name="e">
/// a #graphene_euler_t
/// </param>
/// <return>
/// the rotation angle
/// </return>

	public static float GetX(this MentorLake.Graphene.graphene_euler_tHandle e)
	{
		if (e.IsInvalid) throw new Exception("Invalid handle (graphene_euler_t)");
		return graphene_euler_tExterns.graphene_euler_get_x(e);
	}

/// <summary>
/// <para>
/// Retrieves the rotation angle on the Y axis, in degrees.
/// </para>
/// </summary>

/// <param name="e">
/// a #graphene_euler_t
/// </param>
/// <return>
/// the rotation angle
/// </return>

	public static float GetY(this MentorLake.Graphene.graphene_euler_tHandle e)
	{
		if (e.IsInvalid) throw new Exception("Invalid handle (graphene_euler_t)");
		return graphene_euler_tExterns.graphene_euler_get_y(e);
	}

/// <summary>
/// <para>
/// Retrieves the rotation angle on the Z axis, in degrees.
/// </para>
/// </summary>

/// <param name="e">
/// a #graphene_euler_t
/// </param>
/// <return>
/// the rotation angle
/// </return>

	public static float GetZ(this MentorLake.Graphene.graphene_euler_tHandle e)
	{
		if (e.IsInvalid) throw new Exception("Invalid handle (graphene_euler_t)");
		return graphene_euler_tExterns.graphene_euler_get_z(e);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_euler_t using the given angles.
/// </para>
/// <para>
/// The order of the rotations is %GRAPHENE_EULER_ORDER_DEFAULT.
/// </para>
/// </summary>

/// <param name="e">
/// the #graphene_euler_t to initialize
/// </param>
/// <param name="x">
/// rotation angle on the X axis, in degrees
/// </param>
/// <param name="y">
/// rotation angle on the Y axis, in degrees
/// </param>
/// <param name="z">
/// rotation angle on the Z axis, in degrees
/// </param>
/// <return>
/// the initialized #graphene_euler_t
/// </return>

	public static MentorLake.Graphene.graphene_euler_tHandle Init(this MentorLake.Graphene.graphene_euler_tHandle e, float x, float y, float z)
	{
		if (e.IsInvalid) throw new Exception("Invalid handle (graphene_euler_t)");
		return graphene_euler_tExterns.graphene_euler_init(e, x, y, z);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_euler_t using the angles and order of
/// another #graphene_euler_t.
/// </para>
/// <para>
/// If the #graphene_euler_t @src is %NULL, this function is equivalent
/// to calling graphene_euler_init() with all angles set to 0.
/// </para>
/// </summary>

/// <param name="e">
/// the #graphene_euler_t to initialize
/// </param>
/// <param name="src">
/// a #graphene_euler_t
/// </param>
/// <return>
/// the initialized #graphene_euler_t
/// </return>

	public static MentorLake.Graphene.graphene_euler_tHandle InitFromEuler(this MentorLake.Graphene.graphene_euler_tHandle e, MentorLake.Graphene.graphene_euler_tHandle src)
	{
		if (e.IsInvalid) throw new Exception("Invalid handle (graphene_euler_t)");
		return graphene_euler_tExterns.graphene_euler_init_from_euler(e, src);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_euler_t using the given rotation matrix.
/// </para>
/// <para>
/// If the #graphene_matrix_t @m is %NULL, the #graphene_euler_t will
/// be initialized with all angles set to 0.
/// </para>
/// </summary>

/// <param name="e">
/// the #graphene_euler_t to initialize
/// </param>
/// <param name="m">
/// a rotation matrix
/// </param>
/// <param name="order">
/// the order used to apply the rotations
/// </param>
/// <return>
/// the initialized #graphene_euler_t
/// </return>

	public static MentorLake.Graphene.graphene_euler_tHandle InitFromMatrix(this MentorLake.Graphene.graphene_euler_tHandle e, MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_euler_order_t order)
	{
		if (e.IsInvalid) throw new Exception("Invalid handle (graphene_euler_t)");
		return graphene_euler_tExterns.graphene_euler_init_from_matrix(e, m, order);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_euler_t using the given normalized quaternion.
/// </para>
/// <para>
/// If the #graphene_quaternion_t @q is %NULL, the #graphene_euler_t will
/// be initialized with all angles set to 0.
/// </para>
/// </summary>

/// <param name="e">
/// a #graphene_euler_t
/// </param>
/// <param name="q">
/// a normalized #graphene_quaternion_t
/// </param>
/// <param name="order">
/// the order used to apply the rotations
/// </param>
/// <return>
/// the initialized #graphene_euler_t
/// </return>

	public static MentorLake.Graphene.graphene_euler_tHandle InitFromQuaternion(this MentorLake.Graphene.graphene_euler_tHandle e, MentorLake.Graphene.graphene_quaternion_tHandle q, MentorLake.Graphene.graphene_euler_order_t order)
	{
		if (e.IsInvalid) throw new Exception("Invalid handle (graphene_euler_t)");
		return graphene_euler_tExterns.graphene_euler_init_from_quaternion(e, q, order);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_euler_t using the given angles
/// and order of rotation.
/// </para>
/// </summary>

/// <param name="e">
/// the #graphene_euler_t to initialize
/// </param>
/// <param name="x">
/// rotation angle on the X axis, in radians
/// </param>
/// <param name="y">
/// rotation angle on the Y axis, in radians
/// </param>
/// <param name="z">
/// rotation angle on the Z axis, in radians
/// </param>
/// <param name="order">
/// order of rotations
/// </param>
/// <return>
/// the initialized #graphene_euler_t
/// </return>

	public static MentorLake.Graphene.graphene_euler_tHandle InitFromRadians(this MentorLake.Graphene.graphene_euler_tHandle e, float x, float y, float z, MentorLake.Graphene.graphene_euler_order_t order)
	{
		if (e.IsInvalid) throw new Exception("Invalid handle (graphene_euler_t)");
		return graphene_euler_tExterns.graphene_euler_init_from_radians(e, x, y, z, order);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_euler_t using the angles contained in a
/// #graphene_vec3_t.
/// </para>
/// <para>
/// If the #graphene_vec3_t @v is %NULL, the #graphene_euler_t will be
/// initialized with all angles set to 0.
/// </para>
/// </summary>

/// <param name="e">
/// the #graphene_euler_t to initialize
/// </param>
/// <param name="v">
/// a #graphene_vec3_t containing the rotation
///   angles in degrees
/// </param>
/// <param name="order">
/// the order used to apply the rotations
/// </param>
/// <return>
/// the initialized #graphene_euler_t
/// </return>

	public static MentorLake.Graphene.graphene_euler_tHandle InitFromVec3(this MentorLake.Graphene.graphene_euler_tHandle e, MentorLake.Graphene.graphene_vec3_tHandle v, MentorLake.Graphene.graphene_euler_order_t order)
	{
		if (e.IsInvalid) throw new Exception("Invalid handle (graphene_euler_t)");
		return graphene_euler_tExterns.graphene_euler_init_from_vec3(e, v, order);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_euler_t with the given angles and @order.
/// </para>
/// </summary>

/// <param name="e">
/// the #graphene_euler_t to initialize
/// </param>
/// <param name="x">
/// rotation angle on the X axis, in degrees
/// </param>
/// <param name="y">
/// rotation angle on the Y axis, in degrees
/// </param>
/// <param name="z">
/// rotation angle on the Z axis, in degrees
/// </param>
/// <param name="order">
/// the order used to apply the rotations
/// </param>
/// <return>
/// the initialized #graphene_euler_t
/// </return>

	public static MentorLake.Graphene.graphene_euler_tHandle InitWithOrder(this MentorLake.Graphene.graphene_euler_tHandle e, float x, float y, float z, MentorLake.Graphene.graphene_euler_order_t order)
	{
		if (e.IsInvalid) throw new Exception("Invalid handle (graphene_euler_t)");
		return graphene_euler_tExterns.graphene_euler_init_with_order(e, x, y, z, order);
	}

/// <summary>
/// <para>
/// Reorders a #graphene_euler_t using @order.
/// </para>
/// <para>
/// This function is equivalent to creating a #graphene_quaternion_t from the
/// given #graphene_euler_t, and then converting the quaternion into another
/// #graphene_euler_t.
/// </para>
/// </summary>

/// <param name="e">
/// a #graphene_euler_t
/// </param>
/// <param name="order">
/// the new order
/// </param>
/// <param name="res">
/// return location for the reordered
///   #graphene_euler_t
/// </param>

	public static void Reorder(this MentorLake.Graphene.graphene_euler_tHandle e, MentorLake.Graphene.graphene_euler_order_t order, out MentorLake.Graphene.graphene_euler_t res)
	{
		if (e.IsInvalid) throw new Exception("Invalid handle (graphene_euler_t)");
		graphene_euler_tExterns.graphene_euler_reorder(e, order, out res);
	}

/// <summary>
/// <para>
/// Converts a #graphene_euler_t into a transformation matrix expressing
/// the extrinsic composition of rotations described by the Euler angles.
/// </para>
/// <para>
/// The rotations are applied over the reference frame axes in the order
/// associated with the #graphene_euler_t; for instance, if the order
/// used to initialize @e is %GRAPHENE_EULER_ORDER_XYZ:
/// </para>
/// <para>
///  * the first rotation moves the body around the X axis with
///    an angle φ
///  * the second rotation moves the body around the Y axis with
///    an angle of ϑ
///  * the third rotation moves the body around the Z axis with
///    an angle of ψ
/// </para>
/// <para>
/// The rotation sign convention is right-handed, to preserve compatibility
/// between Euler-based, quaternion-based, and angle-axis-based rotations.
/// </para>
/// </summary>

/// <param name="e">
/// a #graphene_euler_t
/// </param>
/// <param name="res">
/// return location for a #graphene_matrix_t
/// </param>

	public static void ToMatrix(this MentorLake.Graphene.graphene_euler_tHandle e, out MentorLake.Graphene.graphene_matrix_t res)
	{
		if (e.IsInvalid) throw new Exception("Invalid handle (graphene_euler_t)");
		graphene_euler_tExterns.graphene_euler_to_matrix(e, out res);
	}

/// <summary>
/// <para>
/// Converts a #graphene_euler_t into a #graphene_quaternion_t.
/// </para>
/// </summary>

/// <param name="e">
/// a #graphene_euler_t
/// </param>
/// <param name="res">
/// return location for a #graphene_quaternion_t
/// </param>

	public static void ToQuaternion(this MentorLake.Graphene.graphene_euler_tHandle e, out MentorLake.Graphene.graphene_quaternion_t res)
	{
		if (e.IsInvalid) throw new Exception("Invalid handle (graphene_euler_t)");
		graphene_euler_tExterns.graphene_euler_to_quaternion(e, out res);
	}

/// <summary>
/// <para>
/// Retrieves the angles of a #graphene_euler_t and initializes a
/// #graphene_vec3_t with them.
/// </para>
/// </summary>

/// <param name="e">
/// a #graphene_euler_t
/// </param>
/// <param name="res">
/// return location for a #graphene_vec3_t
/// </param>

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

/// <summary>
/// <para>
/// Describe a rotation using Euler angles.
/// </para>
/// <para>
/// The contents of the #graphene_euler_t structure are private
/// and should never be accessed directly.
/// </para>
/// </summary>

public struct graphene_euler_t
{
}
