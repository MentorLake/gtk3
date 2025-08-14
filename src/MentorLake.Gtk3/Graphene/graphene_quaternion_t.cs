namespace MentorLake.Graphene;

/// <summary>
/// <para>
/// A quaternion.
/// </para>
/// <para>
/// The contents of the #graphene_quaternion_t structure are private
/// and should never be accessed directly.
/// </para>
/// </summary>

public class graphene_quaternion_tHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Allocates a new #graphene_quaternion_t.
/// </para>
/// <para>
/// The contents of the returned value are undefined.
/// </para>
/// </summary>

/// <return>
/// the newly allocated #graphene_quaternion_t
/// </return>

	public static MentorLake.Graphene.graphene_quaternion_tHandle Alloc()
	{
		return graphene_quaternion_tExterns.graphene_quaternion_alloc();
	}

}


public static class graphene_quaternion_tExtensions
{
/// <summary>
/// <para>
/// Adds two #graphene_quaternion_t @a and @b.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_quaternion_t
/// </param>
/// <param name="b">
/// a #graphene_quaternion_t
/// </param>
/// <param name="res">
/// the result of the operation
/// </param>

	public static void Add(this MentorLake.Graphene.graphene_quaternion_tHandle a, MentorLake.Graphene.graphene_quaternion_tHandle b, out MentorLake.Graphene.graphene_quaternion_t res)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_quaternion_t)");
		graphene_quaternion_tExterns.graphene_quaternion_add(a, b, out res);
	}

/// <summary>
/// <para>
/// Computes the dot product of two #graphene_quaternion_t.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_quaternion_t
/// </param>
/// <param name="b">
/// a #graphene_quaternion_t
/// </param>
/// <return>
/// the value of the dot products
/// </return>

	public static float Dot(this MentorLake.Graphene.graphene_quaternion_tHandle a, MentorLake.Graphene.graphene_quaternion_tHandle b)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_quaternion_t)");
		return graphene_quaternion_tExterns.graphene_quaternion_dot(a, b);
	}

/// <summary>
/// <para>
/// Checks whether the given quaternions are equal.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_quaternion_t
/// </param>
/// <param name="b">
/// a #graphene_quaternion_t
/// </param>
/// <return>
/// `true` if the quaternions are equal
/// </return>

	public static bool Equal(this MentorLake.Graphene.graphene_quaternion_tHandle a, MentorLake.Graphene.graphene_quaternion_tHandle b)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_quaternion_t)");
		return graphene_quaternion_tExterns.graphene_quaternion_equal(a, b);
	}

/// <summary>
/// <para>
/// Releases the resources allocated by graphene_quaternion_alloc().
/// </para>
/// </summary>

/// <param name="q">
/// a #graphene_quaternion_t
/// </param>

	public static void Free(this MentorLake.Graphene.graphene_quaternion_tHandle q)
	{
		if (q.IsInvalid) throw new Exception("Invalid handle (graphene_quaternion_t)");
		graphene_quaternion_tExterns.graphene_quaternion_free(q);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_quaternion_t using the given four values.
/// </para>
/// </summary>

/// <param name="q">
/// a #graphene_quaternion_t
/// </param>
/// <param name="x">
/// the first component of the quaternion
/// </param>
/// <param name="y">
/// the second component of the quaternion
/// </param>
/// <param name="z">
/// the third component of the quaternion
/// </param>
/// <param name="w">
/// the fourth component of the quaternion
/// </param>
/// <return>
/// the initialized quaternion
/// </return>

	public static MentorLake.Graphene.graphene_quaternion_tHandle Init(this MentorLake.Graphene.graphene_quaternion_tHandle q, float x, float y, float z, float w)
	{
		if (q.IsInvalid) throw new Exception("Invalid handle (graphene_quaternion_t)");
		return graphene_quaternion_tExterns.graphene_quaternion_init(q, x, y, z, w);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_quaternion_t using an @angle on a
/// specific @axis.
/// </para>
/// </summary>

/// <param name="q">
/// a #graphene_quaternion_t
/// </param>
/// <param name="angle">
/// the rotation on a given axis, in degrees
/// </param>
/// <param name="axis">
/// the axis of rotation, expressed as a vector
/// </param>
/// <return>
/// the initialized quaternion
/// </return>

	public static MentorLake.Graphene.graphene_quaternion_tHandle InitFromAngleVec3(this MentorLake.Graphene.graphene_quaternion_tHandle q, float angle, MentorLake.Graphene.graphene_vec3_tHandle axis)
	{
		if (q.IsInvalid) throw new Exception("Invalid handle (graphene_quaternion_t)");
		return graphene_quaternion_tExterns.graphene_quaternion_init_from_angle_vec3(q, angle, axis);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_quaternion_t using the values of
/// the [Euler angles](http://en.wikipedia.org/wiki/Euler_angles)
/// on each axis.
/// </para>
/// <para>
/// See also: graphene_quaternion_init_from_euler()
/// </para>
/// </summary>

/// <param name="q">
/// a #graphene_quaternion_t
/// </param>
/// <param name="deg_x">
/// rotation angle on the X axis (yaw), in degrees
/// </param>
/// <param name="deg_y">
/// rotation angle on the Y axis (pitch), in degrees
/// </param>
/// <param name="deg_z">
/// rotation angle on the Z axis (roll), in degrees
/// </param>
/// <return>
/// the initialized quaternion
/// </return>

	public static MentorLake.Graphene.graphene_quaternion_tHandle InitFromAngles(this MentorLake.Graphene.graphene_quaternion_tHandle q, float deg_x, float deg_y, float deg_z)
	{
		if (q.IsInvalid) throw new Exception("Invalid handle (graphene_quaternion_t)");
		return graphene_quaternion_tExterns.graphene_quaternion_init_from_angles(q, deg_x, deg_y, deg_z);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_quaternion_t using the given #graphene_euler_t.
/// </para>
/// </summary>

/// <param name="q">
/// the #graphene_quaternion_t to initialize
/// </param>
/// <param name="e">
/// a #graphene_euler_t
/// </param>
/// <return>
/// the initialized #graphene_quaternion_t
/// </return>

	public static MentorLake.Graphene.graphene_quaternion_tHandle InitFromEuler(this MentorLake.Graphene.graphene_quaternion_tHandle q, MentorLake.Graphene.graphene_euler_tHandle e)
	{
		if (q.IsInvalid) throw new Exception("Invalid handle (graphene_quaternion_t)");
		return graphene_quaternion_tExterns.graphene_quaternion_init_from_euler(q, e);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_quaternion_t using the rotation components
/// of a transformation matrix.
/// </para>
/// </summary>

/// <param name="q">
/// a #graphene_quaternion_t
/// </param>
/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <return>
/// the initialized quaternion
/// </return>

	public static MentorLake.Graphene.graphene_quaternion_tHandle InitFromMatrix(this MentorLake.Graphene.graphene_quaternion_tHandle q, MentorLake.Graphene.graphene_matrix_tHandle m)
	{
		if (q.IsInvalid) throw new Exception("Invalid handle (graphene_quaternion_t)");
		return graphene_quaternion_tExterns.graphene_quaternion_init_from_matrix(q, m);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_quaternion_t with the values from @src.
/// </para>
/// </summary>

/// <param name="q">
/// a #graphene_quaternion_t
/// </param>
/// <param name="src">
/// a #graphene_quaternion_t
/// </param>
/// <return>
/// the initialized quaternion
/// </return>

	public static MentorLake.Graphene.graphene_quaternion_tHandle InitFromQuaternion(this MentorLake.Graphene.graphene_quaternion_tHandle q, MentorLake.Graphene.graphene_quaternion_tHandle src)
	{
		if (q.IsInvalid) throw new Exception("Invalid handle (graphene_quaternion_t)");
		return graphene_quaternion_tExterns.graphene_quaternion_init_from_quaternion(q, src);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_quaternion_t using the values of
/// the [Euler angles](http://en.wikipedia.org/wiki/Euler_angles)
/// on each axis.
/// </para>
/// <para>
/// See also: graphene_quaternion_init_from_euler()
/// </para>
/// </summary>

/// <param name="q">
/// a #graphene_quaternion_t
/// </param>
/// <param name="rad_x">
/// rotation angle on the X axis (yaw), in radians
/// </param>
/// <param name="rad_y">
/// rotation angle on the Y axis (pitch), in radians
/// </param>
/// <param name="rad_z">
/// rotation angle on the Z axis (roll), in radians
/// </param>
/// <return>
/// the initialized quaternion
/// </return>

	public static MentorLake.Graphene.graphene_quaternion_tHandle InitFromRadians(this MentorLake.Graphene.graphene_quaternion_tHandle q, float rad_x, float rad_y, float rad_z)
	{
		if (q.IsInvalid) throw new Exception("Invalid handle (graphene_quaternion_t)");
		return graphene_quaternion_tExterns.graphene_quaternion_init_from_radians(q, rad_x, rad_y, rad_z);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_quaternion_t with the values from @src.
/// </para>
/// </summary>

/// <param name="q">
/// a #graphene_quaternion_t
/// </param>
/// <param name="src">
/// a #graphene_vec4_t
/// </param>
/// <return>
/// the initialized quaternion
/// </return>

	public static MentorLake.Graphene.graphene_quaternion_tHandle InitFromVec4(this MentorLake.Graphene.graphene_quaternion_tHandle q, MentorLake.Graphene.graphene_vec4_tHandle src)
	{
		if (q.IsInvalid) throw new Exception("Invalid handle (graphene_quaternion_t)");
		return graphene_quaternion_tExterns.graphene_quaternion_init_from_vec4(q, src);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_quaternion_t using the identity
/// transformation.
/// </para>
/// </summary>

/// <param name="q">
/// a #graphene_quaternion_t
/// </param>
/// <return>
/// the initialized quaternion
/// </return>

	public static MentorLake.Graphene.graphene_quaternion_tHandle InitIdentity(this MentorLake.Graphene.graphene_quaternion_tHandle q)
	{
		if (q.IsInvalid) throw new Exception("Invalid handle (graphene_quaternion_t)");
		return graphene_quaternion_tExterns.graphene_quaternion_init_identity(q);
	}

/// <summary>
/// <para>
/// Inverts a #graphene_quaternion_t, and returns the conjugate
/// quaternion of @q.
/// </para>
/// </summary>

/// <param name="q">
/// a #graphene_quaternion_t
/// </param>
/// <param name="res">
/// return location for the inverted
///   quaternion
/// </param>

	public static void Invert(this MentorLake.Graphene.graphene_quaternion_tHandle q, out MentorLake.Graphene.graphene_quaternion_t res)
	{
		if (q.IsInvalid) throw new Exception("Invalid handle (graphene_quaternion_t)");
		graphene_quaternion_tExterns.graphene_quaternion_invert(q, out res);
	}

/// <summary>
/// <para>
/// Multiplies two #graphene_quaternion_t @a and @b.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_quaternion_t
/// </param>
/// <param name="b">
/// a #graphene_quaternion_t
/// </param>
/// <param name="res">
/// the result of the operation
/// </param>

	public static void Multiply(this MentorLake.Graphene.graphene_quaternion_tHandle a, MentorLake.Graphene.graphene_quaternion_tHandle b, out MentorLake.Graphene.graphene_quaternion_t res)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_quaternion_t)");
		graphene_quaternion_tExterns.graphene_quaternion_multiply(a, b, out res);
	}

/// <summary>
/// <para>
/// Normalizes a #graphene_quaternion_t.
/// </para>
/// </summary>

/// <param name="q">
/// a #graphene_quaternion_t
/// </param>
/// <param name="res">
/// return location for the normalized
///   quaternion
/// </param>

	public static void Normalize(this MentorLake.Graphene.graphene_quaternion_tHandle q, out MentorLake.Graphene.graphene_quaternion_t res)
	{
		if (q.IsInvalid) throw new Exception("Invalid handle (graphene_quaternion_t)");
		graphene_quaternion_tExterns.graphene_quaternion_normalize(q, out res);
	}

/// <summary>
/// <para>
/// Scales all the elements of a #graphene_quaternion_t @q using
/// the given scalar factor.
/// </para>
/// </summary>

/// <param name="q">
/// a #graphene_quaternion_t
/// </param>
/// <param name="factor">
/// a scaling factor
/// </param>
/// <param name="res">
/// the result of the operation
/// </param>

	public static void Scale(this MentorLake.Graphene.graphene_quaternion_tHandle q, float factor, out MentorLake.Graphene.graphene_quaternion_t res)
	{
		if (q.IsInvalid) throw new Exception("Invalid handle (graphene_quaternion_t)");
		graphene_quaternion_tExterns.graphene_quaternion_scale(q, factor, out res);
	}

/// <summary>
/// <para>
/// Interpolates between the two given quaternions using a spherical
/// linear interpolation, or [SLERP](http://en.wikipedia.org/wiki/Slerp),
/// using the given interpolation @factor.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_quaternion_t
/// </param>
/// <param name="b">
/// a #graphene_quaternion_t
/// </param>
/// <param name="factor">
/// the linear interpolation factor
/// </param>
/// <param name="res">
/// return location for the interpolated
///   quaternion
/// </param>

	public static void Slerp(this MentorLake.Graphene.graphene_quaternion_tHandle a, MentorLake.Graphene.graphene_quaternion_tHandle b, float factor, out MentorLake.Graphene.graphene_quaternion_t res)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_quaternion_t)");
		graphene_quaternion_tExterns.graphene_quaternion_slerp(a, b, factor, out res);
	}

/// <summary>
/// <para>
/// Converts a quaternion into an @angle, @axis pair.
/// </para>
/// </summary>

/// <param name="q">
/// a #graphene_quaternion_t
/// </param>
/// <param name="angle">
/// return location for the angle, in degrees
/// </param>
/// <param name="axis">
/// return location for the rotation axis
/// </param>

	public static void ToAngleVec3(this MentorLake.Graphene.graphene_quaternion_tHandle q, out float angle, out MentorLake.Graphene.graphene_vec3_t axis)
	{
		if (q.IsInvalid) throw new Exception("Invalid handle (graphene_quaternion_t)");
		graphene_quaternion_tExterns.graphene_quaternion_to_angle_vec3(q, out angle, out axis);
	}

/// <summary>
/// <para>
/// Converts a #graphene_quaternion_t to its corresponding rotations
/// on the [Euler angles](http://en.wikipedia.org/wiki/Euler_angles)
/// on each axis.
/// </para>
/// </summary>

/// <param name="q">
/// a #graphene_quaternion_t
/// </param>
/// <param name="deg_x">
/// return location for the rotation angle on
///   the X axis (yaw), in degrees
/// </param>
/// <param name="deg_y">
/// return location for the rotation angle on
///   the Y axis (pitch), in degrees
/// </param>
/// <param name="deg_z">
/// return location for the rotation angle on
///   the Z axis (roll), in degrees
/// </param>

	public static void ToAngles(this MentorLake.Graphene.graphene_quaternion_tHandle q, out float deg_x, out float deg_y, out float deg_z)
	{
		if (q.IsInvalid) throw new Exception("Invalid handle (graphene_quaternion_t)");
		graphene_quaternion_tExterns.graphene_quaternion_to_angles(q, out deg_x, out deg_y, out deg_z);
	}

/// <summary>
/// <para>
/// Converts a quaternion into a transformation matrix expressing
/// the rotation defined by the #graphene_quaternion_t.
/// </para>
/// </summary>

/// <param name="q">
/// a #graphene_quaternion_t
/// </param>
/// <param name="m">
/// a #graphene_matrix_t
/// </param>

	public static void ToMatrix(this MentorLake.Graphene.graphene_quaternion_tHandle q, out MentorLake.Graphene.graphene_matrix_t m)
	{
		if (q.IsInvalid) throw new Exception("Invalid handle (graphene_quaternion_t)");
		graphene_quaternion_tExterns.graphene_quaternion_to_matrix(q, out m);
	}

/// <summary>
/// <para>
/// Converts a #graphene_quaternion_t to its corresponding rotations
/// on the [Euler angles](http://en.wikipedia.org/wiki/Euler_angles)
/// on each axis.
/// </para>
/// </summary>

/// <param name="q">
/// a #graphene_quaternion_t
/// </param>
/// <param name="rad_x">
/// return location for the rotation angle on
///   the X axis (yaw), in radians
/// </param>
/// <param name="rad_y">
/// return location for the rotation angle on
///   the Y axis (pitch), in radians
/// </param>
/// <param name="rad_z">
/// return location for the rotation angle on
///   the Z axis (roll), in radians
/// </param>

	public static void ToRadians(this MentorLake.Graphene.graphene_quaternion_tHandle q, out float rad_x, out float rad_y, out float rad_z)
	{
		if (q.IsInvalid) throw new Exception("Invalid handle (graphene_quaternion_t)");
		graphene_quaternion_tExterns.graphene_quaternion_to_radians(q, out rad_x, out rad_y, out rad_z);
	}

/// <summary>
/// <para>
/// Copies the components of a #graphene_quaternion_t into a
/// #graphene_vec4_t.
/// </para>
/// </summary>

/// <param name="q">
/// a #graphene_quaternion_t
/// </param>
/// <param name="res">
/// return location for a
///   #graphene_vec4_t
/// </param>

	public static void ToVec4(this MentorLake.Graphene.graphene_quaternion_tHandle q, out MentorLake.Graphene.graphene_vec4_t res)
	{
		if (q.IsInvalid) throw new Exception("Invalid handle (graphene_quaternion_t)");
		graphene_quaternion_tExterns.graphene_quaternion_to_vec4(q, out res);
	}


	public static graphene_quaternion_t Dereference(this graphene_quaternion_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<graphene_quaternion_t>(x.DangerousGetHandle());
}
internal class graphene_quaternion_tExterns
{
	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_quaternion_tHandle graphene_quaternion_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))] MentorLake.Graphene.graphene_quaternion_tHandle q, float x, float y, float z, float w);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_quaternion_tHandle graphene_quaternion_init_from_angle_vec3([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))] MentorLake.Graphene.graphene_quaternion_tHandle q, float angle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle axis);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_quaternion_tHandle graphene_quaternion_init_from_angles([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))] MentorLake.Graphene.graphene_quaternion_tHandle q, float deg_x, float deg_y, float deg_z);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_quaternion_tHandle graphene_quaternion_init_from_euler([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))] MentorLake.Graphene.graphene_quaternion_tHandle q, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_euler_tHandle>))] MentorLake.Graphene.graphene_euler_tHandle e);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_quaternion_tHandle graphene_quaternion_init_from_matrix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))] MentorLake.Graphene.graphene_quaternion_tHandle q, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_quaternion_tHandle graphene_quaternion_init_from_quaternion([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))] MentorLake.Graphene.graphene_quaternion_tHandle q, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))] MentorLake.Graphene.graphene_quaternion_tHandle src);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_quaternion_tHandle graphene_quaternion_init_from_radians([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))] MentorLake.Graphene.graphene_quaternion_tHandle q, float rad_x, float rad_y, float rad_z);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_quaternion_tHandle graphene_quaternion_init_from_vec4([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))] MentorLake.Graphene.graphene_quaternion_tHandle q, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle src);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))]
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

/// <summary>
/// <para>
/// A quaternion.
/// </para>
/// <para>
/// The contents of the #graphene_quaternion_t structure are private
/// and should never be accessed directly.
/// </para>
/// </summary>

public struct graphene_quaternion_t
{
}
