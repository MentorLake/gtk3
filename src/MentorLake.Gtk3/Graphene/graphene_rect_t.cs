namespace MentorLake.Graphene;

public class graphene_rect_tHandle : BaseSafeHandle
{
}


public static class graphene_rect_tExtensions
{
	public static bool ContainsPoint(this MentorLake.Graphene.graphene_rect_tHandle r, MentorLake.Graphene.graphene_point_tHandle p)
	{
		return graphene_rect_tExterns.graphene_rect_contains_point(r, p);
	}

	public static bool ContainsRect(this MentorLake.Graphene.graphene_rect_tHandle a, MentorLake.Graphene.graphene_rect_tHandle b)
	{
		return graphene_rect_tExterns.graphene_rect_contains_rect(a, b);
	}

	public static bool Equal(this MentorLake.Graphene.graphene_rect_tHandle a, MentorLake.Graphene.graphene_rect_tHandle b)
	{
		return graphene_rect_tExterns.graphene_rect_equal(a, b);
	}

	public static void Expand(this MentorLake.Graphene.graphene_rect_tHandle r, MentorLake.Graphene.graphene_point_tHandle p, out MentorLake.Graphene.graphene_rect_t res)
	{
		graphene_rect_tExterns.graphene_rect_expand(r, p, out res);
	}

	public static void Free(this MentorLake.Graphene.graphene_rect_tHandle r)
	{
		graphene_rect_tExterns.graphene_rect_free(r);
	}

	public static float GetArea(this MentorLake.Graphene.graphene_rect_tHandle r)
	{
		return graphene_rect_tExterns.graphene_rect_get_area(r);
	}

	public static void GetBottomLeft(this MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_point_t p)
	{
		graphene_rect_tExterns.graphene_rect_get_bottom_left(r, out p);
	}

	public static void GetBottomRight(this MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_point_t p)
	{
		graphene_rect_tExterns.graphene_rect_get_bottom_right(r, out p);
	}

	public static void GetCenter(this MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_point_t p)
	{
		graphene_rect_tExterns.graphene_rect_get_center(r, out p);
	}

	public static float GetHeight(this MentorLake.Graphene.graphene_rect_tHandle r)
	{
		return graphene_rect_tExterns.graphene_rect_get_height(r);
	}

	public static void GetTopLeft(this MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_point_t p)
	{
		graphene_rect_tExterns.graphene_rect_get_top_left(r, out p);
	}

	public static void GetTopRight(this MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_point_t p)
	{
		graphene_rect_tExterns.graphene_rect_get_top_right(r, out p);
	}

	public static void GetVertices(this MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_vec2_t[] vertices)
	{
		graphene_rect_tExterns.graphene_rect_get_vertices(r, out vertices);
	}

	public static float GetWidth(this MentorLake.Graphene.graphene_rect_tHandle r)
	{
		return graphene_rect_tExterns.graphene_rect_get_width(r);
	}

	public static float GetX(this MentorLake.Graphene.graphene_rect_tHandle r)
	{
		return graphene_rect_tExterns.graphene_rect_get_x(r);
	}

	public static float GetY(this MentorLake.Graphene.graphene_rect_tHandle r)
	{
		return graphene_rect_tExterns.graphene_rect_get_y(r);
	}

	public static MentorLake.Graphene.graphene_rect_tHandle Init(this MentorLake.Graphene.graphene_rect_tHandle r, float x, float y, float width, float height)
	{
		return graphene_rect_tExterns.graphene_rect_init(r, x, y, width, height);
	}

	public static MentorLake.Graphene.graphene_rect_tHandle InitFromRect(this MentorLake.Graphene.graphene_rect_tHandle r, MentorLake.Graphene.graphene_rect_tHandle src)
	{
		return graphene_rect_tExterns.graphene_rect_init_from_rect(r, src);
	}

	public static MentorLake.Graphene.graphene_rect_tHandle Inset(this MentorLake.Graphene.graphene_rect_tHandle r, float d_x, float d_y)
	{
		return graphene_rect_tExterns.graphene_rect_inset(r, d_x, d_y);
	}

	public static void InsetR(this MentorLake.Graphene.graphene_rect_tHandle r, float d_x, float d_y, out MentorLake.Graphene.graphene_rect_t res)
	{
		graphene_rect_tExterns.graphene_rect_inset_r(r, d_x, d_y, out res);
	}

	public static void Interpolate(this MentorLake.Graphene.graphene_rect_tHandle a, MentorLake.Graphene.graphene_rect_tHandle b, double factor, out MentorLake.Graphene.graphene_rect_t res)
	{
		graphene_rect_tExterns.graphene_rect_interpolate(a, b, factor, out res);
	}

	public static bool Intersection(this MentorLake.Graphene.graphene_rect_tHandle a, MentorLake.Graphene.graphene_rect_tHandle b, out MentorLake.Graphene.graphene_rect_t res)
	{
		return graphene_rect_tExterns.graphene_rect_intersection(a, b, out res);
	}

	public static MentorLake.Graphene.graphene_rect_tHandle Normalize(this MentorLake.Graphene.graphene_rect_tHandle r)
	{
		return graphene_rect_tExterns.graphene_rect_normalize(r);
	}

	public static void NormalizeR(this MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_rect_t res)
	{
		graphene_rect_tExterns.graphene_rect_normalize_r(r, out res);
	}

	public static MentorLake.Graphene.graphene_rect_tHandle Offset(this MentorLake.Graphene.graphene_rect_tHandle r, float d_x, float d_y)
	{
		return graphene_rect_tExterns.graphene_rect_offset(r, d_x, d_y);
	}

	public static void OffsetR(this MentorLake.Graphene.graphene_rect_tHandle r, float d_x, float d_y, out MentorLake.Graphene.graphene_rect_t res)
	{
		graphene_rect_tExterns.graphene_rect_offset_r(r, d_x, d_y, out res);
	}

	public static void Round(this MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_rect_t res)
	{
		graphene_rect_tExterns.graphene_rect_round(r, out res);
	}

	public static void RoundExtents(this MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_rect_t res)
	{
		graphene_rect_tExterns.graphene_rect_round_extents(r, out res);
	}

	public static MentorLake.Graphene.graphene_rect_tHandle RoundToPixel(this MentorLake.Graphene.graphene_rect_tHandle r)
	{
		return graphene_rect_tExterns.graphene_rect_round_to_pixel(r);
	}

	public static void Scale(this MentorLake.Graphene.graphene_rect_tHandle r, float s_h, float s_v, out MentorLake.Graphene.graphene_rect_t res)
	{
		graphene_rect_tExterns.graphene_rect_scale(r, s_h, s_v, out res);
	}

	public static void Union(this MentorLake.Graphene.graphene_rect_tHandle a, MentorLake.Graphene.graphene_rect_tHandle b, out MentorLake.Graphene.graphene_rect_t res)
	{
		graphene_rect_tExterns.graphene_rect_union(a, b, out res);
	}


	public static graphene_rect_t Dereference(this graphene_rect_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<graphene_rect_t>(x.DangerousGetHandle());
}
internal class graphene_rect_tExterns
{
	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_rect_contains_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))] MentorLake.Graphene.graphene_point_tHandle p);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_rect_contains_rect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle b);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_rect_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle b);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_rect_expand([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))] MentorLake.Graphene.graphene_point_tHandle p, out MentorLake.Graphene.graphene_rect_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_rect_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_rect_get_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_rect_get_bottom_left([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_point_t p);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_rect_get_bottom_right([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_point_t p);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_rect_get_center([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_point_t p);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_rect_get_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_rect_get_top_left([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_point_t p);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_rect_get_top_right([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_point_t p);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_rect_get_vertices([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_vec2_t[] vertices);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_rect_get_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_rect_get_x([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_rect_get_y([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_rect_tHandle graphene_rect_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r, float x, float y, float width, float height);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_rect_tHandle graphene_rect_init_from_rect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle src);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_rect_tHandle graphene_rect_inset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r, float d_x, float d_y);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_rect_inset_r([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r, float d_x, float d_y, out MentorLake.Graphene.graphene_rect_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_rect_interpolate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle b, double factor, out MentorLake.Graphene.graphene_rect_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_rect_intersection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle b, out MentorLake.Graphene.graphene_rect_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_rect_tHandle graphene_rect_normalize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_rect_normalize_r([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_rect_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_rect_tHandle graphene_rect_offset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r, float d_x, float d_y);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_rect_offset_r([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r, float d_x, float d_y, out MentorLake.Graphene.graphene_rect_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_rect_round([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_rect_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_rect_round_extents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_rect_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_rect_tHandle graphene_rect_round_to_pixel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_rect_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r, float s_h, float s_v, out MentorLake.Graphene.graphene_rect_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_rect_union([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle b, out MentorLake.Graphene.graphene_rect_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_rect_tHandle graphene_rect_alloc();

	[DllImport(GrapheneLibrary.Name)]
	internal static extern MentorLake.Graphene.graphene_rect_tHandle graphene_rect_zero();

}

public struct graphene_rect_t
{
	public graphene_point_t origin;
	public graphene_size_t size;
	public static MentorLake.Graphene.graphene_rect_tHandle Alloc()
	{
		return graphene_rect_tExterns.graphene_rect_alloc();
	}

	public static MentorLake.Graphene.graphene_rect_tHandle Zero()
	{
		return graphene_rect_tExterns.graphene_rect_zero();
	}

}
