namespace MentorLake.Graphene;

/// <summary>
/// <para>
/// A structure capable of holding a vector with four dimensions: x, y, z, and w.
/// </para>
/// <para>
/// The contents of the #graphene_vec4_t structure are private and should
/// never be accessed directly.
/// </para>
/// </summary>

public class graphene_vec4_tHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Allocates a new #graphene_vec4_t structure.
/// </para>
/// <para>
/// The contents of the returned structure are undefined.
/// </para>
/// <para>
/// Use graphene_vec4_init() to initialize the vector.
/// </para>
/// </summary>

/// <return>
/// the newly allocated #graphene_vec4_t
///   structure. Use graphene_vec4_free() to free the resources allocated
///   by this function.
/// </return>

	public static MentorLake.Graphene.graphene_vec4_tHandle Alloc()
	{
		return graphene_vec4_tExterns.graphene_vec4_alloc();
	}

}


public static class graphene_vec4_tExtensions
{
/// <summary>
/// <para>
/// Adds each component of the two given vectors.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_vec4_t
/// </param>
/// <param name="b">
/// a #graphene_vec4_t
/// </param>
/// <param name="res">
/// return location for the resulting vector
/// </param>

	public static void Add(this MentorLake.Graphene.graphene_vec4_tHandle a, MentorLake.Graphene.graphene_vec4_tHandle b, out MentorLake.Graphene.graphene_vec4_t res)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_vec4_t)");
		graphene_vec4_tExterns.graphene_vec4_add(a, b, out res);
	}

/// <summary>
/// <para>
/// Divides each component of the first operand @a by the corresponding
/// component of the second operand @b, and places the results into the
/// vector @res.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_vec4_t
/// </param>
/// <param name="b">
/// a #graphene_vec4_t
/// </param>
/// <param name="res">
/// return location for the resulting vector
/// </param>

	public static void Divide(this MentorLake.Graphene.graphene_vec4_tHandle a, MentorLake.Graphene.graphene_vec4_tHandle b, out MentorLake.Graphene.graphene_vec4_t res)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_vec4_t)");
		graphene_vec4_tExterns.graphene_vec4_divide(a, b, out res);
	}

/// <summary>
/// <para>
/// Computes the dot product of the two given vectors.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_vec4_t
/// </param>
/// <param name="b">
/// a #graphene_vec4_t
/// </param>
/// <return>
/// the value of the dot product
/// </return>

	public static float Dot(this MentorLake.Graphene.graphene_vec4_tHandle a, MentorLake.Graphene.graphene_vec4_tHandle b)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_vec4_t)");
		return graphene_vec4_tExterns.graphene_vec4_dot(a, b);
	}

/// <summary>
/// <para>
/// Checks whether the two given #graphene_vec4_t are equal.
/// </para>
/// </summary>

/// <param name="v1">
/// a #graphene_vec4_t
/// </param>
/// <param name="v2">
/// a #graphene_vec4_t
/// </param>
/// <return>
/// `true` if the two vectors are equal, and false otherwise
/// </return>

	public static bool Equal(this MentorLake.Graphene.graphene_vec4_tHandle v1, MentorLake.Graphene.graphene_vec4_tHandle v2)
	{
		if (v1.IsInvalid) throw new Exception("Invalid handle (graphene_vec4_t)");
		return graphene_vec4_tExterns.graphene_vec4_equal(v1, v2);
	}

/// <summary>
/// <para>
/// Frees the resources allocated by @v
/// </para>
/// </summary>

/// <param name="v">
/// a #graphene_vec4_t
/// </param>

	public static void Free(this MentorLake.Graphene.graphene_vec4_tHandle v)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec4_t)");
		graphene_vec4_tExterns.graphene_vec4_free(v);
	}

/// <summary>
/// <para>
/// Retrieves the value of the fourth component of the given #graphene_vec4_t.
/// </para>
/// </summary>

/// <param name="v">
/// a #graphene_vec4_t
/// </param>
/// <return>
/// the value of the fourth component
/// </return>

	public static float GetW(this MentorLake.Graphene.graphene_vec4_tHandle v)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec4_t)");
		return graphene_vec4_tExterns.graphene_vec4_get_w(v);
	}

/// <summary>
/// <para>
/// Retrieves the value of the first component of the given #graphene_vec4_t.
/// </para>
/// </summary>

/// <param name="v">
/// a #graphene_vec4_t
/// </param>
/// <return>
/// the value of the first component
/// </return>

	public static float GetX(this MentorLake.Graphene.graphene_vec4_tHandle v)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec4_t)");
		return graphene_vec4_tExterns.graphene_vec4_get_x(v);
	}

/// <summary>
/// <para>
/// Creates a #graphene_vec2_t that contains the first two components
/// of the given #graphene_vec4_t.
/// </para>
/// </summary>

/// <param name="v">
/// a #graphene_vec4_t
/// </param>
/// <param name="res">
/// return location for a #graphene_vec2_t
/// </param>

	public static void GetXy(this MentorLake.Graphene.graphene_vec4_tHandle v, out MentorLake.Graphene.graphene_vec2_t res)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec4_t)");
		graphene_vec4_tExterns.graphene_vec4_get_xy(v, out res);
	}

/// <summary>
/// <para>
/// Creates a #graphene_vec3_t that contains the first three components
/// of the given #graphene_vec4_t.
/// </para>
/// </summary>

/// <param name="v">
/// a #graphene_vec4_t
/// </param>
/// <param name="res">
/// return location for a graphene_vec3_t
/// </param>

	public static void GetXyz(this MentorLake.Graphene.graphene_vec4_tHandle v, out MentorLake.Graphene.graphene_vec3_t res)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec4_t)");
		graphene_vec4_tExterns.graphene_vec4_get_xyz(v, out res);
	}

/// <summary>
/// <para>
/// Retrieves the value of the second component of the given #graphene_vec4_t.
/// </para>
/// </summary>

/// <param name="v">
/// a #graphene_vec4_t
/// </param>
/// <return>
/// the value of the second component
/// </return>

	public static float GetY(this MentorLake.Graphene.graphene_vec4_tHandle v)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec4_t)");
		return graphene_vec4_tExterns.graphene_vec4_get_y(v);
	}

/// <summary>
/// <para>
/// Retrieves the value of the third component of the given #graphene_vec4_t.
/// </para>
/// </summary>

/// <param name="v">
/// a #graphene_vec4_t
/// </param>
/// <return>
/// the value of the third component
/// </return>

	public static float GetZ(this MentorLake.Graphene.graphene_vec4_tHandle v)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec4_t)");
		return graphene_vec4_tExterns.graphene_vec4_get_z(v);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_vec4_t using the given values.
/// </para>
/// <para>
/// This function can be called multiple times.
/// </para>
/// </summary>

/// <param name="v">
/// a #graphene_vec4_t
/// </param>
/// <param name="x">
/// the X field of the vector
/// </param>
/// <param name="y">
/// the Y field of the vector
/// </param>
/// <param name="z">
/// the Z field of the vector
/// </param>
/// <param name="w">
/// the W field of the vector
/// </param>
/// <return>
/// a pointer to the initialized
///   vector
/// </return>

	public static MentorLake.Graphene.graphene_vec4_tHandle Init(this MentorLake.Graphene.graphene_vec4_tHandle v, float x, float y, float z, float w)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec4_t)");
		return graphene_vec4_tExterns.graphene_vec4_init(v, x, y, z, w);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_vec4_t with the values inside the given array.
/// </para>
/// </summary>

/// <param name="v">
/// a #graphene_vec4_t
/// </param>
/// <param name="src">
/// an array of four floating point values
/// </param>
/// <return>
/// the initialized vector
/// </return>

	public static MentorLake.Graphene.graphene_vec4_tHandle InitFromFloat(this MentorLake.Graphene.graphene_vec4_tHandle v, float[] src)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec4_t)");
		return graphene_vec4_tExterns.graphene_vec4_init_from_float(v, src);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_vec4_t using the components of a
/// #graphene_vec2_t and the values of @z and @w.
/// </para>
/// </summary>

/// <param name="v">
/// a #graphene_vec4_t
/// </param>
/// <param name="src">
/// a #graphene_vec2_t
/// </param>
/// <param name="z">
/// the value for the third component of @v
/// </param>
/// <param name="w">
/// the value for the fourth component of @v
/// </param>
/// <return>
/// the initialized vector
/// </return>

	public static MentorLake.Graphene.graphene_vec4_tHandle InitFromVec2(this MentorLake.Graphene.graphene_vec4_tHandle v, MentorLake.Graphene.graphene_vec2_tHandle src, float z, float w)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec4_t)");
		return graphene_vec4_tExterns.graphene_vec4_init_from_vec2(v, src, z, w);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_vec4_t using the components of a
/// #graphene_vec3_t and the value of @w.
/// </para>
/// </summary>

/// <param name="v">
/// a #graphene_vec4_t
/// </param>
/// <param name="src">
/// a #graphene_vec3_t
/// </param>
/// <param name="w">
/// the value for the fourth component of @v
/// </param>
/// <return>
/// the initialized vector
/// </return>

	public static MentorLake.Graphene.graphene_vec4_tHandle InitFromVec3(this MentorLake.Graphene.graphene_vec4_tHandle v, MentorLake.Graphene.graphene_vec3_tHandle src, float w)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec4_t)");
		return graphene_vec4_tExterns.graphene_vec4_init_from_vec3(v, src, w);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_vec4_t using the components of
/// another #graphene_vec4_t.
/// </para>
/// </summary>

/// <param name="v">
/// a #graphene_vec4_t
/// </param>
/// <param name="src">
/// a #graphene_vec4_t
/// </param>
/// <return>
/// the initialized vector
/// </return>

	public static MentorLake.Graphene.graphene_vec4_tHandle InitFromVec4(this MentorLake.Graphene.graphene_vec4_tHandle v, MentorLake.Graphene.graphene_vec4_tHandle src)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec4_t)");
		return graphene_vec4_tExterns.graphene_vec4_init_from_vec4(v, src);
	}

/// <summary>
/// <para>
/// Linearly interpolates @v1 and @v2 using the given @factor.
/// </para>
/// </summary>

/// <param name="v1">
/// a #graphene_vec4_t
/// </param>
/// <param name="v2">
/// a #graphene_vec4_t
/// </param>
/// <param name="factor">
/// the interpolation factor
/// </param>
/// <param name="res">
/// the interpolated vector
/// </param>

	public static void Interpolate(this MentorLake.Graphene.graphene_vec4_tHandle v1, MentorLake.Graphene.graphene_vec4_tHandle v2, double factor, out MentorLake.Graphene.graphene_vec4_t res)
	{
		if (v1.IsInvalid) throw new Exception("Invalid handle (graphene_vec4_t)");
		graphene_vec4_tExterns.graphene_vec4_interpolate(v1, v2, factor, out res);
	}

/// <summary>
/// <para>
/// Computes the length of the given #graphene_vec4_t.
/// </para>
/// </summary>

/// <param name="v">
/// a #graphene_vec4_t
/// </param>
/// <return>
/// the length of the vector
/// </return>

	public static float Length(this MentorLake.Graphene.graphene_vec4_tHandle v)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec4_t)");
		return graphene_vec4_tExterns.graphene_vec4_length(v);
	}

/// <summary>
/// <para>
/// Compares each component of the two given vectors and creates a
/// vector that contains the maximum values.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_vec4_t
/// </param>
/// <param name="b">
/// a #graphene_vec4_t
/// </param>
/// <param name="res">
/// return location for the result vector
/// </param>

	public static void Max(this MentorLake.Graphene.graphene_vec4_tHandle a, MentorLake.Graphene.graphene_vec4_tHandle b, out MentorLake.Graphene.graphene_vec4_t res)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_vec4_t)");
		graphene_vec4_tExterns.graphene_vec4_max(a, b, out res);
	}

/// <summary>
/// <para>
/// Compares each component of the two given vectors and creates a
/// vector that contains the minimum values.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_vec4_t
/// </param>
/// <param name="b">
/// a #graphene_vec4_t
/// </param>
/// <param name="res">
/// return location for the result vector
/// </param>

	public static void Min(this MentorLake.Graphene.graphene_vec4_tHandle a, MentorLake.Graphene.graphene_vec4_tHandle b, out MentorLake.Graphene.graphene_vec4_t res)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_vec4_t)");
		graphene_vec4_tExterns.graphene_vec4_min(a, b, out res);
	}

/// <summary>
/// <para>
/// Multiplies each component of the two given vectors.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_vec4_t
/// </param>
/// <param name="b">
/// a #graphene_vec4_t
/// </param>
/// <param name="res">
/// return location for the resulting vector
/// </param>

	public static void Multiply(this MentorLake.Graphene.graphene_vec4_tHandle a, MentorLake.Graphene.graphene_vec4_tHandle b, out MentorLake.Graphene.graphene_vec4_t res)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_vec4_t)");
		graphene_vec4_tExterns.graphene_vec4_multiply(a, b, out res);
	}

/// <summary>
/// <para>
/// Compares the two given #graphene_vec4_t vectors and checks
/// whether their values are within the given @epsilon.
/// </para>
/// </summary>

/// <param name="v1">
/// a #graphene_vec4_t
/// </param>
/// <param name="v2">
/// a #graphene_vec4_t
/// </param>
/// <param name="epsilon">
/// the threshold between the two vectors
/// </param>
/// <return>
/// `true` if the two vectors are near each other
/// </return>

	public static bool Near(this MentorLake.Graphene.graphene_vec4_tHandle v1, MentorLake.Graphene.graphene_vec4_tHandle v2, float epsilon)
	{
		if (v1.IsInvalid) throw new Exception("Invalid handle (graphene_vec4_t)");
		return graphene_vec4_tExterns.graphene_vec4_near(v1, v2, epsilon);
	}

/// <summary>
/// <para>
/// Negates the given #graphene_vec4_t.
/// </para>
/// </summary>

/// <param name="v">
/// a #graphene_vec4_t
/// </param>
/// <param name="res">
/// return location for the result vector
/// </param>

	public static void Negate(this MentorLake.Graphene.graphene_vec4_tHandle v, out MentorLake.Graphene.graphene_vec4_t res)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec4_t)");
		graphene_vec4_tExterns.graphene_vec4_negate(v, out res);
	}

/// <summary>
/// <para>
/// Normalizes the given #graphene_vec4_t.
/// </para>
/// </summary>

/// <param name="v">
/// a #graphene_vec4_t
/// </param>
/// <param name="res">
/// return location for the normalized
///   vector
/// </param>

	public static void Normalize(this MentorLake.Graphene.graphene_vec4_tHandle v, out MentorLake.Graphene.graphene_vec4_t res)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec4_t)");
		graphene_vec4_tExterns.graphene_vec4_normalize(v, out res);
	}

/// <summary>
/// <para>
/// Multiplies all components of the given vector with the given scalar @factor.
/// </para>
/// </summary>

/// <param name="v">
/// a #graphene_vec4_t
/// </param>
/// <param name="factor">
/// the scalar factor
/// </param>
/// <param name="res">
/// return location for the result vector
/// </param>

	public static void Scale(this MentorLake.Graphene.graphene_vec4_tHandle v, float factor, out MentorLake.Graphene.graphene_vec4_t res)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec4_t)");
		graphene_vec4_tExterns.graphene_vec4_scale(v, factor, out res);
	}

/// <summary>
/// <para>
/// Subtracts from each component of the first operand @a the
/// corresponding component of the second operand @b and places
/// each result into the components of @res.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_vec4_t
/// </param>
/// <param name="b">
/// a #graphene_vec4_t
/// </param>
/// <param name="res">
/// return location for the resulting vector
/// </param>

	public static void Subtract(this MentorLake.Graphene.graphene_vec4_tHandle a, MentorLake.Graphene.graphene_vec4_tHandle b, out MentorLake.Graphene.graphene_vec4_t res)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_vec4_t)");
		graphene_vec4_tExterns.graphene_vec4_subtract(a, b, out res);
	}

/// <summary>
/// <para>
/// Stores the components of the given #graphene_vec4_t into an array
/// of floating point values.
/// </para>
/// </summary>

/// <param name="v">
/// a #graphene_vec4_t
/// </param>
/// <param name="dest">
/// return location for
///   an array of floating point values
/// </param>

	public static void ToFloat(this MentorLake.Graphene.graphene_vec4_tHandle v, out float[] dest)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec4_t)");
		graphene_vec4_tExterns.graphene_vec4_to_float(v, out dest);
	}


	public static graphene_vec4_t Dereference(this graphene_vec4_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<graphene_vec4_t>(x.DangerousGetHandle());
}
internal class graphene_vec4_tExterns
{
	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_vec4_tHandle graphene_vec4_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle v, float x, float y, float z, float w);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_vec4_tHandle graphene_vec4_init_from_float([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle v, float[] src);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_vec4_tHandle graphene_vec4_init_from_vec2([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle v, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle src, float z, float w);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_vec4_tHandle graphene_vec4_init_from_vec3([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle v, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle src, float w);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))]
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
	internal static extern void graphene_vec4_to_float([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle v, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] out float[] dest);

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

/// <summary>
/// <para>
/// A structure capable of holding a vector with four dimensions: x, y, z, and w.
/// </para>
/// <para>
/// The contents of the #graphene_vec4_t structure are private and should
/// never be accessed directly.
/// </para>
/// </summary>

public struct graphene_vec4_t
{
/// <summary>
/// <para>
/// Retrieves a pointer to a #graphene_vec4_t with all its
/// components set to 1.
/// </para>
/// </summary>

/// <return>
/// a constant vector
/// </return>

	public static MentorLake.Graphene.graphene_vec4_tHandle One()
	{
		return graphene_vec4_tExterns.graphene_vec4_one();
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

	public static MentorLake.Graphene.graphene_vec4_tHandle WAxis()
	{
		return graphene_vec4_tExterns.graphene_vec4_w_axis();
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

	public static MentorLake.Graphene.graphene_vec4_tHandle XAxis()
	{
		return graphene_vec4_tExterns.graphene_vec4_x_axis();
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

	public static MentorLake.Graphene.graphene_vec4_tHandle YAxis()
	{
		return graphene_vec4_tExterns.graphene_vec4_y_axis();
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

	public static MentorLake.Graphene.graphene_vec4_tHandle ZAxis()
	{
		return graphene_vec4_tExterns.graphene_vec4_z_axis();
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

	public static MentorLake.Graphene.graphene_vec4_tHandle Zero()
	{
		return graphene_vec4_tExterns.graphene_vec4_zero();
	}

}
