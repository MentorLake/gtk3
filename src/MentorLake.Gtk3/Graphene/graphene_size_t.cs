namespace MentorLake.Graphene;

/// <summary>
/// <para>
/// A size.
/// </para>
/// </summary>

public class graphene_size_tHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Allocates a new #graphene_size_t.
/// </para>
/// <para>
/// The contents of the returned value are undefined.
/// </para>
/// </summary>

/// <return>
/// the newly allocated #graphene_size_t
/// </return>

	public static MentorLake.Graphene.graphene_size_tHandle Alloc()
	{
		return graphene_size_tExterns.graphene_size_alloc();
	}

}


public static class graphene_size_tExtensions
{
/// <summary>
/// <para>
/// Checks whether the two give #graphene_size_t are equal.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_size_t
/// </param>
/// <param name="b">
/// a #graphene_size_t
/// </param>
/// <return>
/// `true` if the sizes are equal
/// </return>

	public static bool Equal(this MentorLake.Graphene.graphene_size_tHandle a, MentorLake.Graphene.graphene_size_tHandle b)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_size_t)");
		return graphene_size_tExterns.graphene_size_equal(a, b);
	}

/// <summary>
/// <para>
/// Frees the resources allocated by graphene_size_alloc().
/// </para>
/// </summary>

/// <param name="s">
/// a #graphene_size_t
/// </param>

	public static void Free(this MentorLake.Graphene.graphene_size_tHandle s)
	{
		if (s.IsInvalid) throw new Exception("Invalid handle (graphene_size_t)");
		graphene_size_tExterns.graphene_size_free(s);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_size_t using the given @width and @height.
/// </para>
/// </summary>

/// <param name="s">
/// a #graphene_size_t
/// </param>
/// <param name="width">
/// the width
/// </param>
/// <param name="height">
/// the height
/// </param>
/// <return>
/// the initialized #graphene_size_t
/// </return>

	public static MentorLake.Graphene.graphene_size_tHandle Init(this MentorLake.Graphene.graphene_size_tHandle s, float width, float height)
	{
		if (s.IsInvalid) throw new Exception("Invalid handle (graphene_size_t)");
		return graphene_size_tExterns.graphene_size_init(s, width, height);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_size_t using the width and height of
/// the given @src.
/// </para>
/// </summary>

/// <param name="s">
/// a #graphene_size_t
/// </param>
/// <param name="src">
/// a #graphene_size_t
/// </param>
/// <return>
/// the initialized #graphene_size_t
/// </return>

	public static MentorLake.Graphene.graphene_size_tHandle InitFromSize(this MentorLake.Graphene.graphene_size_tHandle s, MentorLake.Graphene.graphene_size_tHandle src)
	{
		if (s.IsInvalid) throw new Exception("Invalid handle (graphene_size_t)");
		return graphene_size_tExterns.graphene_size_init_from_size(s, src);
	}

/// <summary>
/// <para>
/// Linearly interpolates the two given #graphene_size_t using the given
/// interpolation @factor.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_size_t
/// </param>
/// <param name="b">
/// a #graphene_size_t
/// </param>
/// <param name="factor">
/// the linear interpolation factor
/// </param>
/// <param name="res">
/// return location for the interpolated size
/// </param>

	public static void Interpolate(this MentorLake.Graphene.graphene_size_tHandle a, MentorLake.Graphene.graphene_size_tHandle b, double factor, out MentorLake.Graphene.graphene_size_t res)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_size_t)");
		graphene_size_tExterns.graphene_size_interpolate(a, b, factor, out res);
	}

/// <summary>
/// <para>
/// Scales the components of a #graphene_size_t using the given @factor.
/// </para>
/// </summary>

/// <param name="s">
/// a #graphene_size_t
/// </param>
/// <param name="factor">
/// the scaling factor
/// </param>
/// <param name="res">
/// return location for the scaled size
/// </param>

	public static void Scale(this MentorLake.Graphene.graphene_size_tHandle s, float factor, out MentorLake.Graphene.graphene_size_t res)
	{
		if (s.IsInvalid) throw new Exception("Invalid handle (graphene_size_t)");
		graphene_size_tExterns.graphene_size_scale(s, factor, out res);
	}


	public static graphene_size_t Dereference(this graphene_size_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<graphene_size_t>(x.DangerousGetHandle());
}
internal class graphene_size_tExterns
{
	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_size_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_size_tHandle graphene_size_alloc();

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_size_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_size_tHandle>))] MentorLake.Graphene.graphene_size_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_size_tHandle>))] MentorLake.Graphene.graphene_size_tHandle b);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_size_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_size_tHandle>))] MentorLake.Graphene.graphene_size_tHandle s);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_size_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_size_tHandle graphene_size_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_size_tHandle>))] MentorLake.Graphene.graphene_size_tHandle s, float width, float height);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_size_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_size_tHandle graphene_size_init_from_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_size_tHandle>))] MentorLake.Graphene.graphene_size_tHandle s, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_size_tHandle>))] MentorLake.Graphene.graphene_size_tHandle src);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_size_interpolate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_size_tHandle>))] MentorLake.Graphene.graphene_size_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_size_tHandle>))] MentorLake.Graphene.graphene_size_tHandle b, double factor, out MentorLake.Graphene.graphene_size_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_size_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_size_tHandle>))] MentorLake.Graphene.graphene_size_tHandle s, float factor, out MentorLake.Graphene.graphene_size_t res);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_size_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_size_tHandle graphene_size_zero();

}

/// <summary>
/// <para>
/// A size.
/// </para>
/// </summary>

public struct graphene_size_t
{
	/// <summary>
/// <para>
/// the width
/// </para>
/// </summary>

public float width;
	/// <summary>
/// <para>
/// the height
/// </para>
/// </summary>

public float height;
/// <summary>
/// <para>
/// A constant pointer to a zero #graphene_size_t, useful for
/// equality checks and interpolations.
/// </para>
/// </summary>

/// <return>
/// a constant size
/// </return>

	public static MentorLake.Graphene.graphene_size_tHandle Zero()
	{
		return graphene_size_tExterns.graphene_size_zero();
	}

}
