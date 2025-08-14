namespace MentorLake.Pango;

/// <summary>
/// <para>
/// A `PangoLayoutLine` represents one of the lines resulting from laying
/// out a paragraph via `PangoLayout`.
/// </para>
/// <para>
/// `PangoLayoutLine` structures are obtained by calling
/// [method@Pango.Layout.get_line] and are only valid until the text,
/// attributes, or settings of the parent `PangoLayout` are modified.
/// </para>
/// </summary>

public class PangoLayoutLineHandle : BaseSafeHandle
{
}


public static class PangoLayoutLineExtensions
{
/// <summary>
/// <para>
/// Computes the logical and ink extents of a layout line.
/// </para>
/// <para>
/// See [method@Pango.Font.get_glyph_extents] for details
/// about the interpretation of the rectangles.
/// </para>
/// </summary>

/// <param name="line">
/// a `PangoLayoutLine`
/// </param>
/// <param name="ink_rect">
/// rectangle used to store the extents of
///   the glyph string as drawn
/// </param>
/// <param name="logical_rect">
/// rectangle used to store the logical
///   extents of the glyph string
/// </param>

	public static void GetExtents(this MentorLake.Pango.PangoLayoutLineHandle line, out MentorLake.Pango.PangoRectangle ink_rect, out MentorLake.Pango.PangoRectangle logical_rect)
	{
		if (line.IsInvalid) throw new Exception("Invalid handle (PangoLayoutLine)");
		PangoLayoutLineExterns.pango_layout_line_get_extents(line, out ink_rect, out logical_rect);
	}

/// <summary>
/// <para>
/// Computes the height of the line, as the maximum of the heights
/// of fonts used in this line.
/// </para>
/// <para>
/// Note that the actual baseline-to-baseline distance between lines
/// of text is influenced by other factors, such as
/// [method@Pango.Layout.set_spacing] and
/// [method@Pango.Layout.set_line_spacing].
/// </para>
/// </summary>

/// <param name="line">
/// a `PangoLayoutLine`
/// </param>
/// <param name="height">
/// return location for the line height
/// </param>

	public static void GetHeight(this MentorLake.Pango.PangoLayoutLineHandle line, out int height)
	{
		if (line.IsInvalid) throw new Exception("Invalid handle (PangoLayoutLine)");
		PangoLayoutLineExterns.pango_layout_line_get_height(line, out height);
	}

/// <summary>
/// <para>
/// Returns the length of the line, in bytes.
/// </para>
/// </summary>

/// <param name="line">
/// a `PangoLayoutLine`
/// </param>
/// <return>
/// the length of the line
/// </return>

	public static int GetLength(this MentorLake.Pango.PangoLayoutLineHandle line)
	{
		if (line.IsInvalid) throw new Exception("Invalid handle (PangoLayoutLine)");
		return PangoLayoutLineExterns.pango_layout_line_get_length(line);
	}

/// <summary>
/// <para>
/// Computes the logical and ink extents of @layout_line in device units.
/// </para>
/// <para>
/// This function just calls [method@Pango.LayoutLine.get_extents] followed by
/// two [func@extents_to_pixels] calls, rounding @ink_rect and @logical_rect
/// such that the rounded rectangles fully contain the unrounded one (that is,
/// passes them as first argument to [func@extents_to_pixels]).
/// </para>
/// </summary>

/// <param name="layout_line">
/// a `PangoLayoutLine`
/// </param>
/// <param name="ink_rect">
/// rectangle used to store the extents of
///   the glyph string as drawn
/// </param>
/// <param name="logical_rect">
/// rectangle used to store the logical
///   extents of the glyph string
/// </param>

	public static void GetPixelExtents(this MentorLake.Pango.PangoLayoutLineHandle layout_line, out MentorLake.Pango.PangoRectangle ink_rect, out MentorLake.Pango.PangoRectangle logical_rect)
	{
		if (layout_line.IsInvalid) throw new Exception("Invalid handle (PangoLayoutLine)");
		PangoLayoutLineExterns.pango_layout_line_get_pixel_extents(layout_line, out ink_rect, out logical_rect);
	}

/// <summary>
/// <para>
/// Returns the resolved direction of the line.
/// </para>
/// </summary>

/// <param name="line">
/// a `PangoLayoutLine`
/// </param>
/// <return>
/// the resolved direction of the line
/// </return>

	public static MentorLake.Pango.PangoDirection GetResolvedDirection(this MentorLake.Pango.PangoLayoutLineHandle line)
	{
		if (line.IsInvalid) throw new Exception("Invalid handle (PangoLayoutLine)");
		return PangoLayoutLineExterns.pango_layout_line_get_resolved_direction(line);
	}

/// <summary>
/// <para>
/// Returns the start index of the line, as byte index
/// into the text of the layout.
/// </para>
/// </summary>

/// <param name="line">
/// a `PangoLayoutLine`
/// </param>
/// <return>
/// the start index of the line
/// </return>

	public static int GetStartIndex(this MentorLake.Pango.PangoLayoutLineHandle line)
	{
		if (line.IsInvalid) throw new Exception("Invalid handle (PangoLayoutLine)");
		return PangoLayoutLineExterns.pango_layout_line_get_start_index(line);
	}

/// <summary>
/// <para>
/// Gets a list of visual ranges corresponding to a given logical range.
/// </para>
/// <para>
/// This list is not necessarily minimal - there may be consecutive
/// ranges which are adjacent. The ranges will be sorted from left to
/// right. The ranges are with respect to the left edge of the entire
/// layout, not with respect to the line.
/// </para>
/// </summary>

/// <param name="line">
/// a `PangoLayoutLine`
/// </param>
/// <param name="start_index">
/// Start byte index of the logical range. If this value
///   is less than the start index for the line, then the first range
///   will extend all the way to the leading edge of the layout. Otherwise,
///   it will start at the leading edge of the first character.
/// </param>
/// <param name="end_index">
/// Ending byte index of the logical range. If this value is
///   greater than the end index for the line, then the last range will
///   extend all the way to the trailing edge of the layout. Otherwise,
///   it will end at the trailing edge of the last character.
/// </param>
/// <param name="ranges">
/// location to
///   store a pointer to an array of ranges. The array will be of length
///   `2*n_ranges`, with each range starting at `(*ranges)[2*n]` and of
///   width `(*ranges)[2*n + 1] - (*ranges)[2*n]`. This array must be freed
///   with g_free(). The coordinates are relative to the layout and are in
///   Pango units.
/// </param>
/// <param name="n_ranges">
/// The number of ranges stored in @ranges
/// </param>

	public static void GetXRanges(this MentorLake.Pango.PangoLayoutLineHandle line, int start_index, int end_index, out int[] ranges, out int n_ranges)
	{
		if (line.IsInvalid) throw new Exception("Invalid handle (PangoLayoutLine)");
		PangoLayoutLineExterns.pango_layout_line_get_x_ranges(line, start_index, end_index, out ranges, out n_ranges);
	}

/// <summary>
/// <para>
/// Converts an index within a line to a X position.
/// </para>
/// </summary>

/// <param name="line">
/// a `PangoLayoutLine`
/// </param>
/// <param name="index_">
/// byte offset of a grapheme within the layout
/// </param>
/// <param name="trailing">
/// an integer indicating the edge of the grapheme to retrieve
///   the position of. If > 0, the trailing edge of the grapheme,
///   if 0, the leading of the grapheme
/// </param>
/// <param name="x_pos">
/// location to store the x_offset (in Pango units)
/// </param>

	public static void IndexToX(this MentorLake.Pango.PangoLayoutLineHandle line, int index_, bool trailing, out int x_pos)
	{
		if (line.IsInvalid) throw new Exception("Invalid handle (PangoLayoutLine)");
		PangoLayoutLineExterns.pango_layout_line_index_to_x(line, index_, trailing, out x_pos);
	}

/// <summary>
/// <para>
/// Returns whether this is the first line of the paragraph.
/// </para>
/// </summary>

/// <param name="line">
/// a `PangoLayoutLine`
/// </param>
/// <return>
/// %TRUE if this is the first line
/// </return>

	public static bool IsParagraphStart(this MentorLake.Pango.PangoLayoutLineHandle line)
	{
		if (line.IsInvalid) throw new Exception("Invalid handle (PangoLayoutLine)");
		return PangoLayoutLineExterns.pango_layout_line_is_paragraph_start(line);
	}

/// <summary>
/// <para>
/// Increase the reference count of a `PangoLayoutLine` by one.
/// </para>
/// </summary>

/// <param name="line">
/// a `PangoLayoutLine`
/// </param>
/// <return>
/// the line passed in.
/// </return>

	public static MentorLake.Pango.PangoLayoutLineHandle Ref(this MentorLake.Pango.PangoLayoutLineHandle line)
	{
		if (line.IsInvalid) throw new Exception("Invalid handle (PangoLayoutLine)");
		return PangoLayoutLineExterns.pango_layout_line_ref(line);
	}

/// <summary>
/// <para>
/// Decrease the reference count of a `PangoLayoutLine` by one.
/// </para>
/// <para>
/// If the result is zero, the line and all associated memory
/// will be freed.
/// </para>
/// </summary>

/// <param name="line">
/// a `PangoLayoutLine`
/// </param>

	public static void Unref(this MentorLake.Pango.PangoLayoutLineHandle line)
	{
		if (line.IsInvalid) throw new Exception("Invalid handle (PangoLayoutLine)");
		PangoLayoutLineExterns.pango_layout_line_unref(line);
	}

/// <summary>
/// <para>
/// Converts from x offset to the byte index of the corresponding character
/// within the text of the layout.
/// </para>
/// <para>
/// If @x_pos is outside the line, @index_ and @trailing will point to the very
/// first or very last position in the line. This determination is based on the
/// resolved direction of the paragraph; for example, if the resolved direction
/// is right-to-left, then an X position to the right of the line (after it)
/// results in 0 being stored in @index_ and @trailing. An X position to the
/// left of the line results in @index_ pointing to the (logical) last grapheme
/// in the line and @trailing being set to the number of characters in that
/// grapheme. The reverse is true for a left-to-right line.
/// </para>
/// </summary>

/// <param name="line">
/// a `PangoLayoutLine`
/// </param>
/// <param name="x_pos">
/// the X offset (in Pango units) from the left edge of the line.
/// </param>
/// <param name="index_">
/// location to store calculated byte index for the grapheme
///   in which the user clicked
/// </param>
/// <param name="trailing">
/// location to store an integer indicating where in the
///   grapheme the user clicked. It will either be zero, or the number of
///   characters in the grapheme. 0 represents the leading edge of the grapheme.
/// </param>
/// <return>
/// %FALSE if @x_pos was outside the line, %TRUE if inside
/// </return>

	public static bool XToIndex(this MentorLake.Pango.PangoLayoutLineHandle line, int x_pos, out int index_, out int trailing)
	{
		if (line.IsInvalid) throw new Exception("Invalid handle (PangoLayoutLine)");
		return PangoLayoutLineExterns.pango_layout_line_x_to_index(line, x_pos, out index_, out trailing);
	}


	public static PangoLayoutLine Dereference(this PangoLayoutLineHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoLayoutLine>(x.DangerousGetHandle());
}
internal class PangoLayoutLineExterns
{
	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_line_get_extents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutLineHandle>))] MentorLake.Pango.PangoLayoutLineHandle line, out MentorLake.Pango.PangoRectangle ink_rect, out MentorLake.Pango.PangoRectangle logical_rect);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_line_get_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutLineHandle>))] MentorLake.Pango.PangoLayoutLineHandle line, out int height);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_layout_line_get_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutLineHandle>))] MentorLake.Pango.PangoLayoutLineHandle line);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_line_get_pixel_extents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutLineHandle>))] MentorLake.Pango.PangoLayoutLineHandle layout_line, out MentorLake.Pango.PangoRectangle ink_rect, out MentorLake.Pango.PangoRectangle logical_rect);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoDirection pango_layout_line_get_resolved_direction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutLineHandle>))] MentorLake.Pango.PangoLayoutLineHandle line);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_layout_line_get_start_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutLineHandle>))] MentorLake.Pango.PangoLayoutLineHandle line);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_line_get_x_ranges([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutLineHandle>))] MentorLake.Pango.PangoLayoutLineHandle line, int start_index, int end_index, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] out int[] ranges, out int n_ranges);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_line_index_to_x([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutLineHandle>))] MentorLake.Pango.PangoLayoutLineHandle line, int index_, bool trailing, out int x_pos);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_layout_line_is_paragraph_start([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutLineHandle>))] MentorLake.Pango.PangoLayoutLineHandle line);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutLineHandle>))]
	internal static extern MentorLake.Pango.PangoLayoutLineHandle pango_layout_line_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutLineHandle>))] MentorLake.Pango.PangoLayoutLineHandle line);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_line_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutLineHandle>))] MentorLake.Pango.PangoLayoutLineHandle line);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_layout_line_x_to_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutLineHandle>))] MentorLake.Pango.PangoLayoutLineHandle line, int x_pos, out int index_, out int trailing);

}

/// <summary>
/// <para>
/// A `PangoLayoutLine` represents one of the lines resulting from laying
/// out a paragraph via `PangoLayout`.
/// </para>
/// <para>
/// `PangoLayoutLine` structures are obtained by calling
/// [method@Pango.Layout.get_line] and are only valid until the text,
/// attributes, or settings of the parent `PangoLayout` are modified.
/// </para>
/// </summary>

public struct PangoLayoutLine
{
	/// <summary>
/// <para>
/// the layout this line belongs to, might be %NULL
/// </para>
/// </summary>

public IntPtr layout;
	/// <summary>
/// <para>
/// start of line as byte index into layout->text
/// </para>
/// </summary>

public int start_index;
	/// <summary>
/// <para>
/// length of line in bytes
/// </para>
/// </summary>

public int length;
	/// <summary>
/// <para>
/// list of runs in the
///   line, from left to right
/// </para>
/// </summary>

public IntPtr runs;
	/// <summary>
/// <para>
/// #TRUE if this is the first line of the paragraph
/// </para>
/// </summary>

public uint is_paragraph_start;
	/// <summary>
/// <para>
/// #Resolved PangoDirection of line
/// </para>
/// </summary>

public uint resolved_dir;
}
