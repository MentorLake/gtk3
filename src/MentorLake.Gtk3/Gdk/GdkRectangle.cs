namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Defines the position and size of a rectangle. It is identical to
/// #cairo_rectangle_int_t.
/// </para>
/// </summary>

public class GdkRectangleHandle : BaseSafeHandle
{
}


public static class GdkRectangleExtensions
{
/// <summary>
/// <para>
/// Checks if the two given rectangles are equal.
/// </para>
/// </summary>

/// <param name="rect1">
/// a #GdkRectangle
/// </param>
/// <param name="rect2">
/// a #GdkRectangle
/// </param>
/// <return>
/// %TRUE if the rectangles are equal.
/// </return>

	public static bool Equal(this MentorLake.Gdk.GdkRectangleHandle rect1, MentorLake.Gdk.GdkRectangleHandle rect2)
	{
		if (rect1.IsInvalid) throw new Exception("Invalid handle (GdkRectangle)");
		return GdkRectangleExterns.gdk_rectangle_equal(rect1, rect2);
	}

/// <summary>
/// <para>
/// Calculates the intersection of two rectangles. It is allowed for
/// @dest to be the same as either @src1 or @src2. If the rectangles
/// do not intersect, @dest’s width and height is set to 0 and its x
/// and y values are undefined. If you are only interested in whether
/// the rectangles intersect, but not in the intersecting area itself,
/// pass %NULL for @dest.
/// </para>
/// </summary>

/// <param name="src1">
/// a #GdkRectangle
/// </param>
/// <param name="src2">
/// a #GdkRectangle
/// </param>
/// <param name="dest">
/// return location for the
/// intersection of @src1 and @src2, or %NULL
/// </param>
/// <return>
/// %TRUE if the rectangles intersect.
/// </return>

	public static bool Intersect(this MentorLake.Gdk.GdkRectangleHandle src1, MentorLake.Gdk.GdkRectangleHandle src2, out MentorLake.Gdk.GdkRectangle dest)
	{
		if (src1.IsInvalid) throw new Exception("Invalid handle (GdkRectangle)");
		return GdkRectangleExterns.gdk_rectangle_intersect(src1, src2, out dest);
	}

/// <summary>
/// <para>
/// Calculates the union of two rectangles.
/// The union of rectangles @src1 and @src2 is the smallest rectangle which
/// includes both @src1 and @src2 within it.
/// It is allowed for @dest to be the same as either @src1 or @src2.
/// </para>
/// <para>
/// Note that this function does not ignore 'empty' rectangles (ie. with
/// zero width or height).
/// </para>
/// </summary>

/// <param name="src1">
/// a #GdkRectangle
/// </param>
/// <param name="src2">
/// a #GdkRectangle
/// </param>
/// <param name="dest">
/// return location for the union of @src1 and @src2
/// </param>

	public static void Union(this MentorLake.Gdk.GdkRectangleHandle src1, MentorLake.Gdk.GdkRectangleHandle src2, out MentorLake.Gdk.GdkRectangle dest)
	{
		if (src1.IsInvalid) throw new Exception("Invalid handle (GdkRectangle)");
		GdkRectangleExterns.gdk_rectangle_union(src1, src2, out dest);
	}


	public static GdkRectangle Dereference(this GdkRectangleHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkRectangle>(x.DangerousGetHandle());
}
internal class GdkRectangleExterns
{
	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_rectangle_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle rect1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle rect2);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_rectangle_intersect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle src1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle src2, out MentorLake.Gdk.GdkRectangle dest);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_rectangle_union([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle src1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle src2, out MentorLake.Gdk.GdkRectangle dest);

}

/// <summary>
/// <para>
/// Defines the position and size of a rectangle. It is identical to
/// #cairo_rectangle_int_t.
/// </para>
/// </summary>

public struct GdkRectangle
{
	
public int x;
	
public int y;
	
public int width;
	
public int height;
}
