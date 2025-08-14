namespace MentorLake.Graphene;

/// <summary>
/// <para>
/// The location and size of a rectangle region.
/// </para>
/// <para>
/// The width and height of a #graphene_rect_t can be negative; for instance,
/// a #graphene_rect_t with an origin of [ 0, 0 ] and a size of [ 10, 10 ] is
/// equivalent to a #graphene_rect_t with an origin of [ 10, 10 ] and a size
/// of [ -10, -10 ].
/// </para>
/// <para>
/// Application code can normalize rectangles using graphene_rect_normalize();
/// this function will ensure that the width and height of a rectangle are
/// positive values. All functions taking a #graphene_rect_t as an argument
/// will internally operate on a normalized copy; all functions returning a
/// #graphene_rect_t will always return a normalized rectangle.
/// </para>
/// </summary>

public class graphene_rect_tHandle : BaseSafeHandle
{
}


public static class graphene_rect_tExtensions
{
/// <summary>
/// <para>
/// Checks whether a #graphene_rect_t contains the given coordinates.
/// </para>
/// </summary>

/// <param name="r">
/// a #graphene_rect_t
/// </param>
/// <param name="p">
/// a #graphene_point_t
/// </param>
/// <return>
/// `true` if the rectangle contains the point
/// </return>

	public static bool ContainsPoint(this MentorLake.Graphene.graphene_rect_tHandle r, MentorLake.Graphene.graphene_point_tHandle p)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_rect_t)");
		return graphene_rect_tExterns.graphene_rect_contains_point(r, p);
	}

/// <summary>
/// <para>
/// Checks whether a #graphene_rect_t fully contains the given
/// rectangle.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_rect_t
/// </param>
/// <param name="b">
/// a #graphene_rect_t
/// </param>
/// <return>
/// `true` if the rectangle @a fully contains @b
/// </return>

	public static bool ContainsRect(this MentorLake.Graphene.graphene_rect_tHandle a, MentorLake.Graphene.graphene_rect_tHandle b)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_rect_t)");
		return graphene_rect_tExterns.graphene_rect_contains_rect(a, b);
	}

/// <summary>
/// <para>
/// Checks whether the two given rectangle are equal.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_rect_t
/// </param>
/// <param name="b">
/// a #graphene_rect_t
/// </param>
/// <return>
/// `true` if the rectangles are equal
/// </return>

	public static bool Equal(this MentorLake.Graphene.graphene_rect_tHandle a, MentorLake.Graphene.graphene_rect_tHandle b)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_rect_t)");
		return graphene_rect_tExterns.graphene_rect_equal(a, b);
	}

/// <summary>
/// <para>
/// Expands a #graphene_rect_t to contain the given #graphene_point_t.
/// </para>
/// </summary>

/// <param name="r">
/// a #graphene_rect_t
/// </param>
/// <param name="p">
/// a #graphene_point_t
/// </param>
/// <param name="res">
/// return location for the expanded rectangle
/// </param>

	public static void Expand(this MentorLake.Graphene.graphene_rect_tHandle r, MentorLake.Graphene.graphene_point_tHandle p, out MentorLake.Graphene.graphene_rect_t res)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_rect_t)");
		graphene_rect_tExterns.graphene_rect_expand(r, p, out res);
	}

/// <summary>
/// <para>
/// Frees the resources allocated by graphene_rect_alloc().
/// </para>
/// </summary>

/// <param name="r">
/// a #graphene_rect_t
/// </param>

	public static void Free(this MentorLake.Graphene.graphene_rect_tHandle r)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_rect_t)");
		graphene_rect_tExterns.graphene_rect_free(r);
	}

/// <summary>
/// <para>
/// Compute the area of given normalized rectangle.
/// </para>
/// </summary>

/// <param name="r">
/// a #graphene_rect_t
/// </param>
/// <return>
/// the area of the normalized rectangle
/// </return>

	public static float GetArea(this MentorLake.Graphene.graphene_rect_tHandle r)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_rect_t)");
		return graphene_rect_tExterns.graphene_rect_get_area(r);
	}

/// <summary>
/// <para>
/// Retrieves the coordinates of the bottom-left corner of the given rectangle.
/// </para>
/// </summary>

/// <param name="r">
/// a #graphene_rect_t
/// </param>
/// <param name="p">
/// return location for a #graphene_point_t
/// </param>

	public static void GetBottomLeft(this MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_point_t p)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_rect_t)");
		graphene_rect_tExterns.graphene_rect_get_bottom_left(r, out p);
	}

/// <summary>
/// <para>
/// Retrieves the coordinates of the bottom-right corner of the given rectangle.
/// </para>
/// </summary>

/// <param name="r">
/// a #graphene_rect_t
/// </param>
/// <param name="p">
/// return location for a #graphene_point_t
/// </param>

	public static void GetBottomRight(this MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_point_t p)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_rect_t)");
		graphene_rect_tExterns.graphene_rect_get_bottom_right(r, out p);
	}

/// <summary>
/// <para>
/// Retrieves the coordinates of the center of the given rectangle.
/// </para>
/// </summary>

/// <param name="r">
/// a #graphene_rect_t
/// </param>
/// <param name="p">
/// return location for a #graphene_point_t
/// </param>

	public static void GetCenter(this MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_point_t p)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_rect_t)");
		graphene_rect_tExterns.graphene_rect_get_center(r, out p);
	}

/// <summary>
/// <para>
/// Retrieves the normalized height of the given rectangle.
/// </para>
/// </summary>

/// <param name="r">
/// a #graphene_rect_t
/// </param>
/// <return>
/// the normalized height of the rectangle
/// </return>

	public static float GetHeight(this MentorLake.Graphene.graphene_rect_tHandle r)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_rect_t)");
		return graphene_rect_tExterns.graphene_rect_get_height(r);
	}

/// <summary>
/// <para>
/// Retrieves the coordinates of the top-left corner of the given rectangle.
/// </para>
/// </summary>

/// <param name="r">
/// a #graphene_rect_t
/// </param>
/// <param name="p">
/// return location for a #graphene_point_t
/// </param>

	public static void GetTopLeft(this MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_point_t p)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_rect_t)");
		graphene_rect_tExterns.graphene_rect_get_top_left(r, out p);
	}

/// <summary>
/// <para>
/// Retrieves the coordinates of the top-right corner of the given rectangle.
/// </para>
/// </summary>

/// <param name="r">
/// a #graphene_rect_t
/// </param>
/// <param name="p">
/// return location for a #graphene_point_t
/// </param>

	public static void GetTopRight(this MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_point_t p)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_rect_t)");
		graphene_rect_tExterns.graphene_rect_get_top_right(r, out p);
	}

/// <summary>
/// <para>
/// Computes the four vertices of a #graphene_rect_t.
/// </para>
/// </summary>

/// <param name="r">
/// a #graphene_rect_t
/// </param>
/// <param name="vertices">
/// return location for an array
///  of 4 #graphene_vec2_t
/// </param>

	public static void GetVertices(this MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_vec2_t[] vertices)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_rect_t)");
		graphene_rect_tExterns.graphene_rect_get_vertices(r, out vertices);
	}

/// <summary>
/// <para>
/// Retrieves the normalized width of the given rectangle.
/// </para>
/// </summary>

/// <param name="r">
/// a #graphene_rect_t
/// </param>
/// <return>
/// the normalized width of the rectangle
/// </return>

	public static float GetWidth(this MentorLake.Graphene.graphene_rect_tHandle r)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_rect_t)");
		return graphene_rect_tExterns.graphene_rect_get_width(r);
	}

/// <summary>
/// <para>
/// Retrieves the normalized X coordinate of the origin of the given
/// rectangle.
/// </para>
/// </summary>

/// <param name="r">
/// a #graphene_rect_t
/// </param>
/// <return>
/// the normalized X coordinate of the rectangle
/// </return>

	public static float GetX(this MentorLake.Graphene.graphene_rect_tHandle r)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_rect_t)");
		return graphene_rect_tExterns.graphene_rect_get_x(r);
	}

/// <summary>
/// <para>
/// Retrieves the normalized Y coordinate of the origin of the given
/// rectangle.
/// </para>
/// </summary>

/// <param name="r">
/// a #graphene_rect_t
/// </param>
/// <return>
/// the normalized Y coordinate of the rectangle
/// </return>

	public static float GetY(this MentorLake.Graphene.graphene_rect_tHandle r)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_rect_t)");
		return graphene_rect_tExterns.graphene_rect_get_y(r);
	}

/// <summary>
/// <para>
/// Initializes the given #graphene_rect_t with the given values.
/// </para>
/// <para>
/// This function will implicitly normalize the #graphene_rect_t
/// before returning.
/// </para>
/// </summary>

/// <param name="r">
/// a #graphene_rect_t
/// </param>
/// <param name="x">
/// the X coordinate of the @graphene_rect_t.origin
/// </param>
/// <param name="y">
/// the Y coordinate of the @graphene_rect_t.origin
/// </param>
/// <param name="width">
/// the width of the @graphene_rect_t.size
/// </param>
/// <param name="height">
/// the height of the @graphene_rect_t.size
/// </param>
/// <return>
/// the initialized rectangle
/// </return>

	public static MentorLake.Graphene.graphene_rect_tHandle Init(this MentorLake.Graphene.graphene_rect_tHandle r, float x, float y, float width, float height)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_rect_t)");
		return graphene_rect_tExterns.graphene_rect_init(r, x, y, width, height);
	}

/// <summary>
/// <para>
/// Initializes @r using the given @src rectangle.
/// </para>
/// <para>
/// This function will implicitly normalize the #graphene_rect_t
/// before returning.
/// </para>
/// </summary>

/// <param name="r">
/// a #graphene_rect_t
/// </param>
/// <param name="src">
/// a #graphene_rect_t
/// </param>
/// <return>
/// the initialized rectangle
/// </return>

	public static MentorLake.Graphene.graphene_rect_tHandle InitFromRect(this MentorLake.Graphene.graphene_rect_tHandle r, MentorLake.Graphene.graphene_rect_tHandle src)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_rect_t)");
		return graphene_rect_tExterns.graphene_rect_init_from_rect(r, src);
	}

/// <summary>
/// <para>
/// Changes the given rectangle to be smaller, or larger depending on the
/// given inset parameters.
/// </para>
/// <para>
/// To create an inset rectangle, use positive @d_x or @d_y values; to
/// create a larger, encompassing rectangle, use negative @d_x or @d_y
/// values.
/// </para>
/// <para>
/// The origin of the rectangle is offset by @d_x and @d_y, while the size
/// is adjusted by `(2 * @d_x, 2 * @d_y)`. If @d_x and @d_y are positive
/// values, the size of the rectangle is decreased; if @d_x and @d_y are
/// negative values, the size of the rectangle is increased.
/// </para>
/// <para>
/// If the size of the resulting inset rectangle has a negative width or
/// height then the size will be set to zero.
/// </para>
/// </summary>

/// <param name="r">
/// a #graphene_rect_t
/// </param>
/// <param name="d_x">
/// the horizontal inset
/// </param>
/// <param name="d_y">
/// the vertical inset
/// </param>
/// <return>
/// the inset rectangle
/// </return>

	public static MentorLake.Graphene.graphene_rect_tHandle Inset(this MentorLake.Graphene.graphene_rect_tHandle r, float d_x, float d_y)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_rect_t)");
		return graphene_rect_tExterns.graphene_rect_inset(r, d_x, d_y);
	}

/// <summary>
/// <para>
/// Changes the given rectangle to be smaller, or larger depending on the
/// given inset parameters.
/// </para>
/// <para>
/// To create an inset rectangle, use positive @d_x or @d_y values; to
/// create a larger, encompassing rectangle, use negative @d_x or @d_y
/// values.
/// </para>
/// <para>
/// The origin of the rectangle is offset by @d_x and @d_y, while the size
/// is adjusted by `(2 * @d_x, 2 * @d_y)`. If @d_x and @d_y are positive
/// values, the size of the rectangle is decreased; if @d_x and @d_y are
/// negative values, the size of the rectangle is increased.
/// </para>
/// <para>
/// If the size of the resulting inset rectangle has a negative width or
/// height then the size will be set to zero.
/// </para>
/// </summary>

/// <param name="r">
/// a #graphene_rect_t
/// </param>
/// <param name="d_x">
/// the horizontal inset
/// </param>
/// <param name="d_y">
/// the vertical inset
/// </param>
/// <param name="res">
/// return location for the inset rectangle
/// </param>

	public static void InsetR(this MentorLake.Graphene.graphene_rect_tHandle r, float d_x, float d_y, out MentorLake.Graphene.graphene_rect_t res)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_rect_t)");
		graphene_rect_tExterns.graphene_rect_inset_r(r, d_x, d_y, out res);
	}

/// <summary>
/// <para>
/// Linearly interpolates the origin and size of the two given
/// rectangles.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_rect_t
/// </param>
/// <param name="b">
/// a #graphene_rect_t
/// </param>
/// <param name="factor">
/// the linear interpolation factor
/// </param>
/// <param name="res">
/// return location for the
///   interpolated rectangle
/// </param>

	public static void Interpolate(this MentorLake.Graphene.graphene_rect_tHandle a, MentorLake.Graphene.graphene_rect_tHandle b, double factor, out MentorLake.Graphene.graphene_rect_t res)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_rect_t)");
		graphene_rect_tExterns.graphene_rect_interpolate(a, b, factor, out res);
	}

/// <summary>
/// <para>
/// Computes the intersection of the two given rectangles.
/// </para>
/// <para>
/// ![](rectangle-intersection.png)
/// </para>
/// <para>
/// The intersection in the image above is the blue outline.
/// </para>
/// <para>
/// If the two rectangles do not intersect, @res will contain
/// a degenerate rectangle with origin in (0, 0) and a size of 0.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_rect_t
/// </param>
/// <param name="b">
/// a #graphene_rect_t
/// </param>
/// <param name="res">
/// return location for
///   a #graphene_rect_t
/// </param>
/// <return>
/// `true` if the two rectangles intersect
/// </return>

	public static bool Intersection(this MentorLake.Graphene.graphene_rect_tHandle a, MentorLake.Graphene.graphene_rect_tHandle b, out MentorLake.Graphene.graphene_rect_t res)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_rect_t)");
		return graphene_rect_tExterns.graphene_rect_intersection(a, b, out res);
	}

/// <summary>
/// <para>
/// Normalizes the passed rectangle.
/// </para>
/// <para>
/// This function ensures that the size of the rectangle is made of
/// positive values, and that the origin is the top-left corner of
/// the rectangle.
/// </para>
/// </summary>

/// <param name="r">
/// a #graphene_rect_t
/// </param>
/// <return>
/// the normalized rectangle
/// </return>

	public static MentorLake.Graphene.graphene_rect_tHandle Normalize(this MentorLake.Graphene.graphene_rect_tHandle r)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_rect_t)");
		return graphene_rect_tExterns.graphene_rect_normalize(r);
	}

/// <summary>
/// <para>
/// Normalizes the passed rectangle.
/// </para>
/// <para>
/// This function ensures that the size of the rectangle is made of
/// positive values, and that the origin is in the top-left corner
/// of the rectangle.
/// </para>
/// </summary>

/// <param name="r">
/// a #graphene_rect_t
/// </param>
/// <param name="res">
/// the return location for the
///   normalized rectangle
/// </param>

	public static void NormalizeR(this MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_rect_t res)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_rect_t)");
		graphene_rect_tExterns.graphene_rect_normalize_r(r, out res);
	}

/// <summary>
/// <para>
/// Offsets the origin by @d_x and @d_y.
/// </para>
/// <para>
/// The size of the rectangle is unchanged.
/// </para>
/// </summary>

/// <param name="r">
/// a #graphene_rect_t
/// </param>
/// <param name="d_x">
/// the horizontal offset
/// </param>
/// <param name="d_y">
/// the vertical offset
/// </param>
/// <return>
/// the offset rectangle
/// </return>

	public static MentorLake.Graphene.graphene_rect_tHandle Offset(this MentorLake.Graphene.graphene_rect_tHandle r, float d_x, float d_y)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_rect_t)");
		return graphene_rect_tExterns.graphene_rect_offset(r, d_x, d_y);
	}

/// <summary>
/// <para>
/// Offsets the origin of the given rectangle by @d_x and @d_y.
/// </para>
/// <para>
/// The size of the rectangle is left unchanged.
/// </para>
/// </summary>

/// <param name="r">
/// a #graphene_rect_t
/// </param>
/// <param name="d_x">
/// the horizontal offset
/// </param>
/// <param name="d_y">
/// the vertical offset
/// </param>
/// <param name="res">
/// return location for the offset
///   rectangle
/// </param>

	public static void OffsetR(this MentorLake.Graphene.graphene_rect_tHandle r, float d_x, float d_y, out MentorLake.Graphene.graphene_rect_t res)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_rect_t)");
		graphene_rect_tExterns.graphene_rect_offset_r(r, d_x, d_y, out res);
	}

/// <summary>
/// <para>
/// Rounds the origin and size of the given rectangle to
/// their nearest integer values; the rounding is guaranteed
/// to be large enough to have an area bigger or equal to the
/// original rectangle, but might not fully contain its extents.
/// Use graphene_rect_round_extents() in case you need to round
/// to a rectangle that covers fully the original one.
/// </para>
/// <para>
/// This function is the equivalent of calling `floor` on
/// the coordinates of the origin, and `ceil` on the size.
/// </para>
/// </summary>

/// <param name="r">
/// a #graphene_rect_t
/// </param>
/// <param name="res">
/// return location for the
///   rounded rectangle
/// </param>

	public static void Round(this MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_rect_t res)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_rect_t)");
		graphene_rect_tExterns.graphene_rect_round(r, out res);
	}

/// <summary>
/// <para>
/// Rounds the origin of the given rectangle to its nearest
/// integer value and and recompute the size so that the
/// rectangle is large enough to contain all the conrners
/// of the original rectangle.
/// </para>
/// <para>
/// This function is the equivalent of calling `floor` on
/// the coordinates of the origin, and recomputing the size
/// calling `ceil` on the bottom-right coordinates.
/// </para>
/// <para>
/// If you want to be sure that the rounded rectangle
/// completely covers the area that was covered by the
/// original rectangle — i.e. you want to cover the area
/// including all its corners — this function will make sure
/// that the size is recomputed taking into account the ceiling
/// of the coordinates of the bottom-right corner.
/// If the difference between the original coordinates and the
/// coordinates of the rounded rectangle is greater than the
/// difference between the original size and and the rounded
/// size, then the move of the origin would not be compensated
/// by a move in the anti-origin, leaving the corners of the
/// original rectangle outside the rounded one.
/// </para>
/// </summary>

/// <param name="r">
/// a #graphene_rect_t
/// </param>
/// <param name="res">
/// return location for the
///   rectangle with rounded extents
/// </param>

	public static void RoundExtents(this MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_rect_t res)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_rect_t)");
		graphene_rect_tExterns.graphene_rect_round_extents(r, out res);
	}

/// <summary>
/// <para>
/// Rounds the origin and the size of the given rectangle to
/// their nearest integer values; the rounding is guaranteed
/// to be large enough to contain the original rectangle.
/// </para>
/// </summary>

/// <param name="r">
/// a #graphene_rect_t
/// </param>
/// <return>
/// the pixel-aligned rectangle.
/// </return>

	public static MentorLake.Graphene.graphene_rect_tHandle RoundToPixel(this MentorLake.Graphene.graphene_rect_tHandle r)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_rect_t)");
		return graphene_rect_tExterns.graphene_rect_round_to_pixel(r);
	}

/// <summary>
/// <para>
/// Scales the size and origin of a rectangle horizontaly by @s_h,
/// and vertically by @s_v. The result @res is normalized.
/// </para>
/// </summary>

/// <param name="r">
/// a #graphene_rect_t
/// </param>
/// <param name="s_h">
/// horizontal scale factor
/// </param>
/// <param name="s_v">
/// vertical scale factor
/// </param>
/// <param name="res">
/// return location for the
///   scaled rectangle
/// </param>

	public static void Scale(this MentorLake.Graphene.graphene_rect_tHandle r, float s_h, float s_v, out MentorLake.Graphene.graphene_rect_t res)
	{
		if (r.IsInvalid) throw new Exception("Invalid handle (graphene_rect_t)");
		graphene_rect_tExterns.graphene_rect_scale(r, s_h, s_v, out res);
	}

/// <summary>
/// <para>
/// Computes the union of the two given rectangles.
/// </para>
/// <para>
/// ![](rectangle-union.png)
/// </para>
/// <para>
/// The union in the image above is the blue outline.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_rect_t
/// </param>
/// <param name="b">
/// a #graphene_rect_t
/// </param>
/// <param name="res">
/// return location for a #graphene_rect_t
/// </param>

	public static void Union(this MentorLake.Graphene.graphene_rect_tHandle a, MentorLake.Graphene.graphene_rect_tHandle b, out MentorLake.Graphene.graphene_rect_t res)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_rect_t)");
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
	internal static extern void graphene_rect_get_vertices([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] out MentorLake.Graphene.graphene_vec2_t[] vertices);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_rect_get_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_rect_get_x([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_rect_get_y([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_rect_tHandle graphene_rect_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r, float x, float y, float width, float height);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_rect_tHandle graphene_rect_init_from_rect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle src);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_rect_tHandle graphene_rect_inset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r, float d_x, float d_y);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_rect_inset_r([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r, float d_x, float d_y, out MentorLake.Graphene.graphene_rect_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_rect_interpolate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle b, double factor, out MentorLake.Graphene.graphene_rect_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_rect_intersection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle b, out MentorLake.Graphene.graphene_rect_t res);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_rect_tHandle graphene_rect_normalize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_rect_normalize_r([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_rect_t res);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_rect_tHandle graphene_rect_offset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r, float d_x, float d_y);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_rect_offset_r([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r, float d_x, float d_y, out MentorLake.Graphene.graphene_rect_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_rect_round([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_rect_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_rect_round_extents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_rect_t res);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_rect_tHandle graphene_rect_round_to_pixel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_rect_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r, float s_h, float s_v, out MentorLake.Graphene.graphene_rect_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_rect_union([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle b, out MentorLake.Graphene.graphene_rect_t res);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_rect_tHandle graphene_rect_alloc();

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_rect_tHandle graphene_rect_zero();

}

/// <summary>
/// <para>
/// The location and size of a rectangle region.
/// </para>
/// <para>
/// The width and height of a #graphene_rect_t can be negative; for instance,
/// a #graphene_rect_t with an origin of [ 0, 0 ] and a size of [ 10, 10 ] is
/// equivalent to a #graphene_rect_t with an origin of [ 10, 10 ] and a size
/// of [ -10, -10 ].
/// </para>
/// <para>
/// Application code can normalize rectangles using graphene_rect_normalize();
/// this function will ensure that the width and height of a rectangle are
/// positive values. All functions taking a #graphene_rect_t as an argument
/// will internally operate on a normalized copy; all functions returning a
/// #graphene_rect_t will always return a normalized rectangle.
/// </para>
/// </summary>

public struct graphene_rect_t
{
	/// <summary>
/// <para>
/// the coordinates of the origin of the rectangle
/// </para>
/// </summary>

public graphene_point_t origin;
	/// <summary>
/// <para>
/// the size of the rectangle
/// </para>
/// </summary>

public graphene_size_t size;
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

	public static MentorLake.Graphene.graphene_rect_tHandle Alloc()
	{
		return graphene_rect_tExterns.graphene_rect_alloc();
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

	public static MentorLake.Graphene.graphene_rect_tHandle Zero()
	{
		return graphene_rect_tExterns.graphene_rect_zero();
	}

}
