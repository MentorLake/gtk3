namespace MentorLake.Graphene;

/// <summary>
/// <para>
/// A structure capable of holding a vector with two dimensions, x and y.
/// </para>
/// <para>
/// The contents of the #graphene_vec2_t structure are private and should
/// never be accessed directly.
/// </para>
/// </summary>

public class graphene_vec2_tHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Allocates a new #graphene_vec2_t structure.
/// </para>
/// <para>
/// The contents of the returned structure are undefined.
/// </para>
/// <para>
/// Use graphene_vec2_init() to initialize the vector.
/// </para>
/// </summary>

/// <return>
/// the newly allocated #graphene_vec2_t
///   structure. Use graphene_vec2_free() to free the resources allocated
///   by this function.
/// </return>

	public static MentorLake.Graphene.graphene_vec2_tHandle Alloc()
	{
		return graphene_vec2_tExterns.graphene_vec2_alloc();
	}

}


public static class graphene_vec2_tExtensions
{
/// <summary>
/// <para>
/// Adds each component of the two passed vectors and places
/// each result into the components of @res.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_vec2_t
/// </param>
/// <param name="b">
/// a #graphene_vec2_t
/// </param>
/// <param name="res">
/// return location for the result
/// </param>

	public static void Add(this MentorLake.Graphene.graphene_vec2_tHandle a, MentorLake.Graphene.graphene_vec2_tHandle b, out MentorLake.Graphene.graphene_vec2_t res)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_vec2_t)");
		graphene_vec2_tExterns.graphene_vec2_add(a, b, out res);
	}

/// <summary>
/// <para>
/// Divides each component of the first operand @a by the corresponding
/// component of the second operand @b, and places the results into the
/// vector @res.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_vec2_t
/// </param>
/// <param name="b">
/// a #graphene_vec2_t
/// </param>
/// <param name="res">
/// return location for the result
/// </param>

	public static void Divide(this MentorLake.Graphene.graphene_vec2_tHandle a, MentorLake.Graphene.graphene_vec2_tHandle b, out MentorLake.Graphene.graphene_vec2_t res)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_vec2_t)");
		graphene_vec2_tExterns.graphene_vec2_divide(a, b, out res);
	}

/// <summary>
/// <para>
/// Computes the dot product of the two given vectors.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_vec2_t
/// </param>
/// <param name="b">
/// a #graphene_vec2_t
/// </param>
/// <return>
/// the dot product of the vectors
/// </return>

	public static float Dot(this MentorLake.Graphene.graphene_vec2_tHandle a, MentorLake.Graphene.graphene_vec2_tHandle b)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_vec2_t)");
		return graphene_vec2_tExterns.graphene_vec2_dot(a, b);
	}

/// <summary>
/// <para>
/// Checks whether the two given #graphene_vec2_t are equal.
/// </para>
/// </summary>

/// <param name="v1">
/// a #graphene_vec2_t
/// </param>
/// <param name="v2">
/// a #graphene_vec2_t
/// </param>
/// <return>
/// `true` if the two vectors are equal, and false otherwise
/// </return>

	public static bool Equal(this MentorLake.Graphene.graphene_vec2_tHandle v1, MentorLake.Graphene.graphene_vec2_tHandle v2)
	{
		if (v1.IsInvalid) throw new Exception("Invalid handle (graphene_vec2_t)");
		return graphene_vec2_tExterns.graphene_vec2_equal(v1, v2);
	}

/// <summary>
/// <para>
/// Frees the resources allocated by @v
/// </para>
/// </summary>

/// <param name="v">
/// a #graphene_vec2_t
/// </param>

	public static void Free(this MentorLake.Graphene.graphene_vec2_tHandle v)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec2_t)");
		graphene_vec2_tExterns.graphene_vec2_free(v);
	}

/// <summary>
/// <para>
/// Retrieves the X component of the #graphene_vec2_t.
/// </para>
/// </summary>

/// <param name="v">
/// a #graphene_vec2_t
/// </param>
/// <return>
/// the value of the X component
/// </return>

	public static float GetX(this MentorLake.Graphene.graphene_vec2_tHandle v)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec2_t)");
		return graphene_vec2_tExterns.graphene_vec2_get_x(v);
	}

/// <summary>
/// <para>
/// Retrieves the Y component of the #graphene_vec2_t.
/// </para>
/// </summary>

/// <param name="v">
/// a #graphene_vec2_t
/// </param>
/// <return>
/// the value of the Y component
/// </return>

	public static float GetY(this MentorLake.Graphene.graphene_vec2_tHandle v)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec2_t)");
		return graphene_vec2_tExterns.graphene_vec2_get_y(v);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_vec2_t using the given values.
/// </para>
/// <para>
/// This function can be called multiple times.
/// </para>
/// </summary>

/// <param name="v">
/// a #graphene_vec2_t
/// </param>
/// <param name="x">
/// the X field of the vector
/// </param>
/// <param name="y">
/// the Y field of the vector
/// </param>
/// <return>
/// the initialized vector
/// </return>

	public static MentorLake.Graphene.graphene_vec2_tHandle Init(this MentorLake.Graphene.graphene_vec2_tHandle v, float x, float y)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec2_t)");
		return graphene_vec2_tExterns.graphene_vec2_init(v, x, y);
	}

/// <summary>
/// <para>
/// Initializes @v with the contents of the given array.
/// </para>
/// </summary>

/// <param name="v">
/// a #graphene_vec2_t
/// </param>
/// <param name="src">
/// an array of floating point values
///   with at least two elements
/// </param>
/// <return>
/// the initialized vector
/// </return>

	public static MentorLake.Graphene.graphene_vec2_tHandle InitFromFloat(this MentorLake.Graphene.graphene_vec2_tHandle v, float[] src)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec2_t)");
		return graphene_vec2_tExterns.graphene_vec2_init_from_float(v, src);
	}

/// <summary>
/// <para>
/// Copies the contents of @src into @v.
/// </para>
/// </summary>

/// <param name="v">
/// a #graphene_vec2_t
/// </param>
/// <param name="src">
/// a #graphene_vec2_t
/// </param>
/// <return>
/// the initialized vector
/// </return>

	public static MentorLake.Graphene.graphene_vec2_tHandle InitFromVec2(this MentorLake.Graphene.graphene_vec2_tHandle v, MentorLake.Graphene.graphene_vec2_tHandle src)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec2_t)");
		return graphene_vec2_tExterns.graphene_vec2_init_from_vec2(v, src);
	}

/// <summary>
/// <para>
/// Linearly interpolates @v1 and @v2 using the given @factor.
/// </para>
/// </summary>

/// <param name="v1">
/// a #graphene_vec2_t
/// </param>
/// <param name="v2">
/// a #graphene_vec2_t
/// </param>
/// <param name="factor">
/// the interpolation factor
/// </param>
/// <param name="res">
/// the interpolated vector
/// </param>

	public static void Interpolate(this MentorLake.Graphene.graphene_vec2_tHandle v1, MentorLake.Graphene.graphene_vec2_tHandle v2, double factor, out MentorLake.Graphene.graphene_vec2_t res)
	{
		if (v1.IsInvalid) throw new Exception("Invalid handle (graphene_vec2_t)");
		graphene_vec2_tExterns.graphene_vec2_interpolate(v1, v2, factor, out res);
	}

/// <summary>
/// <para>
/// Computes the length of the given vector.
/// </para>
/// </summary>

/// <param name="v">
/// a #graphene_vec2_t
/// </param>
/// <return>
/// the length of the vector
/// </return>

	public static float Length(this MentorLake.Graphene.graphene_vec2_tHandle v)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec2_t)");
		return graphene_vec2_tExterns.graphene_vec2_length(v);
	}

/// <summary>
/// <para>
/// Compares the two given vectors and places the maximum
/// values of each component into @res.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_vec2_t
/// </param>
/// <param name="b">
/// a #graphene_vec2_t
/// </param>
/// <param name="res">
/// the resulting vector
/// </param>

	public static void Max(this MentorLake.Graphene.graphene_vec2_tHandle a, MentorLake.Graphene.graphene_vec2_tHandle b, out MentorLake.Graphene.graphene_vec2_t res)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_vec2_t)");
		graphene_vec2_tExterns.graphene_vec2_max(a, b, out res);
	}

/// <summary>
/// <para>
/// Compares the two given vectors and places the minimum
/// values of each component into @res.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_vec2_t
/// </param>
/// <param name="b">
/// a #graphene_vec2_t
/// </param>
/// <param name="res">
/// the resulting vector
/// </param>

	public static void Min(this MentorLake.Graphene.graphene_vec2_tHandle a, MentorLake.Graphene.graphene_vec2_tHandle b, out MentorLake.Graphene.graphene_vec2_t res)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_vec2_t)");
		graphene_vec2_tExterns.graphene_vec2_min(a, b, out res);
	}

/// <summary>
/// <para>
/// Multiplies each component of the two passed vectors and places
/// each result into the components of @res.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_vec2_t
/// </param>
/// <param name="b">
/// a #graphene_vec2_t
/// </param>
/// <param name="res">
/// return location for the result
/// </param>

	public static void Multiply(this MentorLake.Graphene.graphene_vec2_tHandle a, MentorLake.Graphene.graphene_vec2_tHandle b, out MentorLake.Graphene.graphene_vec2_t res)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_vec2_t)");
		graphene_vec2_tExterns.graphene_vec2_multiply(a, b, out res);
	}

/// <summary>
/// <para>
/// Compares the two given #graphene_vec2_t vectors and checks
/// whether their values are within the given @epsilon.
/// </para>
/// </summary>

/// <param name="v1">
/// a #graphene_vec2_t
/// </param>
/// <param name="v2">
/// a #graphene_vec2_t
/// </param>
/// <param name="epsilon">
/// the threshold between the two vectors
/// </param>
/// <return>
/// `true` if the two vectors are near each other
/// </return>

	public static bool Near(this MentorLake.Graphene.graphene_vec2_tHandle v1, MentorLake.Graphene.graphene_vec2_tHandle v2, float epsilon)
	{
		if (v1.IsInvalid) throw new Exception("Invalid handle (graphene_vec2_t)");
		return graphene_vec2_tExterns.graphene_vec2_near(v1, v2, epsilon);
	}

/// <summary>
/// <para>
/// Negates the given #graphene_vec2_t.
/// </para>
/// </summary>

/// <param name="v">
/// a #graphene_vec2_t
/// </param>
/// <param name="res">
/// return location for the result vector
/// </param>

	public static void Negate(this MentorLake.Graphene.graphene_vec2_tHandle v, out MentorLake.Graphene.graphene_vec2_t res)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec2_t)");
		graphene_vec2_tExterns.graphene_vec2_negate(v, out res);
	}

/// <summary>
/// <para>
/// Computes the normalized vector for the given vector @v.
/// </para>
/// </summary>

/// <param name="v">
/// a #graphene_vec2_t
/// </param>
/// <param name="res">
/// return location for the
///   normalized vector
/// </param>

	public static void Normalize(this MentorLake.Graphene.graphene_vec2_tHandle v, out MentorLake.Graphene.graphene_vec2_t res)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec2_t)");
		graphene_vec2_tExterns.graphene_vec2_normalize(v, out res);
	}

/// <summary>
/// <para>
/// Multiplies all components of the given vector with the given scalar @factor.
/// </para>
/// </summary>

/// <param name="v">
/// a #graphene_vec2_t
/// </param>
/// <param name="factor">
/// the scalar factor
/// </param>
/// <param name="res">
/// return location for the result vector
/// </param>

	public static void Scale(this MentorLake.Graphene.graphene_vec2_tHandle v, float factor, out MentorLake.Graphene.graphene_vec2_t res)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec2_t)");
		graphene_vec2_tExterns.graphene_vec2_scale(v, factor, out res);
	}

/// <summary>
/// <para>
/// Subtracts from each component of the first operand @a the
/// corresponding component of the second operand @b and places
/// each result into the components of @res.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_vec2_t
/// </param>
/// <param name="b">
/// a #graphene_vec2_t
/// </param>
/// <param name="res">
/// return location for the result
/// </param>

	public static void Subtract(this MentorLake.Graphene.graphene_vec2_tHandle a, MentorLake.Graphene.graphene_vec2_tHandle b, out MentorLake.Graphene.graphene_vec2_t res)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_vec2_t)");
		graphene_vec2_tExterns.graphene_vec2_subtract(a, b, out res);
	}

/// <summary>
/// <para>
/// Stores the components of @v into an array.
/// </para>
/// </summary>

/// <param name="v">
/// a #graphene_vec2_t
/// </param>
/// <param name="dest">
/// return location
///   for an array of floating point values with at least 2 elements
/// </param>

	public static void ToFloat(this MentorLake.Graphene.graphene_vec2_tHandle v, out float[] dest)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (graphene_vec2_t)");
		graphene_vec2_tExterns.graphene_vec2_to_float(v, out dest);
	}


	public static graphene_vec2_t Dereference(this graphene_vec2_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<graphene_vec2_t>(x.DangerousGetHandle());
}
internal class graphene_vec2_tExterns
{
	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_vec2_tHandle graphene_vec2_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle v, float x, float y);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_vec2_tHandle graphene_vec2_init_from_float([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle v, float[] src);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))]
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
	internal static extern void graphene_vec2_to_float([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec2_tHandle>))] MentorLake.Graphene.graphene_vec2_tHandle v, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] out float[] dest);

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

}

/// <summary>
/// <para>
/// A structure capable of holding a vector with two dimensions, x and y.
/// </para>
/// <para>
/// The contents of the #graphene_vec2_t structure are private and should
/// never be accessed directly.
/// </para>
/// </summary>

public struct graphene_vec2_t
{
/// <summary>
/// <para>
/// Retrieves a constant vector with (1, 1) components.
/// </para>
/// </summary>

/// <return>
/// the one vector
/// </return>

	public static MentorLake.Graphene.graphene_vec2_tHandle One()
	{
		return graphene_vec2_tExterns.graphene_vec2_one();
	}

/// <summary>
/// <para>
/// Retrieves a constant vector with (1, 0) components.
/// </para>
/// </summary>

/// <return>
/// the X axis vector
/// </return>

	public static MentorLake.Graphene.graphene_vec2_tHandle XAxis()
	{
		return graphene_vec2_tExterns.graphene_vec2_x_axis();
	}

/// <summary>
/// <para>
/// Retrieves a constant vector with (0, 1) components.
/// </para>
/// </summary>

/// <return>
/// the Y axis vector
/// </return>

	public static MentorLake.Graphene.graphene_vec2_tHandle YAxis()
	{
		return graphene_vec2_tExterns.graphene_vec2_y_axis();
	}

/// <summary>
/// <para>
/// Retrieves a constant vector with (0, 0) components.
/// </para>
/// </summary>

/// <return>
/// the zero vector
/// </return>

	public static MentorLake.Graphene.graphene_vec2_tHandle Zero()
	{
		return graphene_vec2_tExterns.graphene_vec2_zero();
	}

}
