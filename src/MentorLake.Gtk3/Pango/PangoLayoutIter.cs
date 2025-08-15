namespace MentorLake.Pango;

/// <summary>
/// <para>
/// A `PangoLayoutIter` can be used to iterate over the visual
/// extents of a `PangoLayout`.
/// </para>
/// <para>
/// To obtain a `PangoLayoutIter`, use [method@Pango.Layout.get_iter].
/// </para>
/// <para>
/// The `PangoLayoutIter` structure is opaque, and has no user-visible fields.
/// </para>
/// </summary>

public class PangoLayoutIterHandle : BaseSafeHandle
{
}


public static class PangoLayoutIterExtensions
{
/// <summary>
/// <para>
/// Determines whether @iter is on the last line of the layout.
/// </para>
/// </summary>

/// <param name="iter">
/// a `PangoLayoutIter`
/// </param>
/// <return>
/// %TRUE if @iter is on the last line
/// </return>

	public static bool AtLastLine(this MentorLake.Pango.PangoLayoutIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoLayoutIter)");
		return PangoLayoutIterExterns.pango_layout_iter_at_last_line(iter);
	}

/// <summary>
/// <para>
/// Copies a `PangoLayoutIter`.
/// </para>
/// </summary>

/// <param name="iter">
/// a `PangoLayoutIter`
/// </param>
/// <return>
/// the newly allocated `PangoLayoutIter`
/// </return>

	public static MentorLake.Pango.PangoLayoutIterHandle Copy(this MentorLake.Pango.PangoLayoutIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoLayoutIter)");
		return PangoLayoutIterExterns.pango_layout_iter_copy(iter);
	}

/// <summary>
/// <para>
/// Frees an iterator that&apos;s no longer in use.
/// </para>
/// </summary>

/// <param name="iter">
/// a `PangoLayoutIter`, may be %NULL
/// </param>

	public static void Free(this MentorLake.Pango.PangoLayoutIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoLayoutIter)");
		PangoLayoutIterExterns.pango_layout_iter_free(iter);
	}

/// <summary>
/// <para>
/// Gets the Y position of the current line&apos;s baseline, in layout
/// coordinates.
/// </para>
/// <para>
/// Layout coordinates have the origin at the top left of the entire layout.
/// </para>
/// </summary>

/// <param name="iter">
/// a `PangoLayoutIter`
/// </param>
/// <return>
/// baseline of current line
/// </return>

	public static int GetBaseline(this MentorLake.Pango.PangoLayoutIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoLayoutIter)");
		return PangoLayoutIterExterns.pango_layout_iter_get_baseline(iter);
	}

/// <summary>
/// <para>
/// Gets the extents of the current character, in layout coordinates.
/// </para>
/// <para>
/// Layout coordinates have the origin at the top left of the entire layout.
/// </para>
/// <para>
/// Only logical extents can sensibly be obtained for characters;
/// ink extents make sense only down to the level of clusters.
/// </para>
/// </summary>

/// <param name="iter">
/// a `PangoLayoutIter`
/// </param>
/// <param name="logical_rect">
/// rectangle to fill with
///   logical extents
/// </param>

	public static void GetCharExtents(this MentorLake.Pango.PangoLayoutIterHandle iter, out MentorLake.Pango.PangoRectangle logical_rect)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoLayoutIter)");
		PangoLayoutIterExterns.pango_layout_iter_get_char_extents(iter, out logical_rect);
	}

/// <summary>
/// <para>
/// Gets the extents of the current cluster, in layout coordinates.
/// </para>
/// <para>
/// Layout coordinates have the origin at the top left of the entire layout.
/// </para>
/// </summary>

/// <param name="iter">
/// a `PangoLayoutIter`
/// </param>
/// <param name="ink_rect">
/// rectangle to fill with ink extents
/// </param>
/// <param name="logical_rect">
/// rectangle to fill with logical extents
/// </param>

	public static void GetClusterExtents(this MentorLake.Pango.PangoLayoutIterHandle iter, out MentorLake.Pango.PangoRectangle ink_rect, out MentorLake.Pango.PangoRectangle logical_rect)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoLayoutIter)");
		PangoLayoutIterExterns.pango_layout_iter_get_cluster_extents(iter, out ink_rect, out logical_rect);
	}

/// <summary>
/// <para>
/// Gets the current byte index.
/// </para>
/// <para>
/// Note that iterating forward by char moves in visual order,
/// not logical order, so indexes may not be sequential. Also,
/// the index may be equal to the length of the text in the
/// layout, if on the %NULL run (see [method@Pango.LayoutIter.get_run]).
/// </para>
/// </summary>

/// <param name="iter">
/// a `PangoLayoutIter`
/// </param>
/// <return>
/// current byte index
/// </return>

	public static int GetIndex(this MentorLake.Pango.PangoLayoutIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoLayoutIter)");
		return PangoLayoutIterExterns.pango_layout_iter_get_index(iter);
	}

/// <summary>
/// <para>
/// Gets the layout associated with a `PangoLayoutIter`.
/// </para>
/// </summary>

/// <param name="iter">
/// a `PangoLayoutIter`
/// </param>
/// <return>
/// the layout associated with @iter
/// </return>

	public static MentorLake.Pango.PangoLayoutHandle GetLayout(this MentorLake.Pango.PangoLayoutIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoLayoutIter)");
		return PangoLayoutIterExterns.pango_layout_iter_get_layout(iter);
	}

/// <summary>
/// <para>
/// Obtains the extents of the `PangoLayout` being iterated over.
/// </para>
/// </summary>

/// <param name="iter">
/// a `PangoLayoutIter`
/// </param>
/// <param name="ink_rect">
/// rectangle to fill with ink extents
/// </param>
/// <param name="logical_rect">
/// rectangle to fill with logical extents
/// </param>

	public static void GetLayoutExtents(this MentorLake.Pango.PangoLayoutIterHandle iter, out MentorLake.Pango.PangoRectangle ink_rect, out MentorLake.Pango.PangoRectangle logical_rect)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoLayoutIter)");
		PangoLayoutIterExterns.pango_layout_iter_get_layout_extents(iter, out ink_rect, out logical_rect);
	}

/// <summary>
/// <para>
/// Gets the current line.
/// </para>
/// <para>
/// Use the faster [method@Pango.LayoutIter.get_line_readonly] if
/// you do not plan to modify the contents of the line (glyphs,
/// glyph widths, etc.).
/// </para>
/// </summary>

/// <param name="iter">
/// a `PangoLayoutIter`
/// </param>
/// <return>
/// the current line
/// </return>

	public static MentorLake.Pango.PangoLayoutLineHandle GetLine(this MentorLake.Pango.PangoLayoutIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoLayoutIter)");
		return PangoLayoutIterExterns.pango_layout_iter_get_line(iter);
	}

/// <summary>
/// <para>
/// Obtains the extents of the current line.
/// </para>
/// <para>
/// Extents are in layout coordinates (origin is the top-left corner
/// of the entire `PangoLayout`). Thus the extents returned by this
/// function will be the same width/height but not at the same x/y
/// as the extents returned from [method@Pango.LayoutLine.get_extents].
/// </para>
/// </summary>

/// <param name="iter">
/// a `PangoLayoutIter`
/// </param>
/// <param name="ink_rect">
/// rectangle to fill with ink extents
/// </param>
/// <param name="logical_rect">
/// rectangle to fill with logical extents
/// </param>

	public static void GetLineExtents(this MentorLake.Pango.PangoLayoutIterHandle iter, out MentorLake.Pango.PangoRectangle ink_rect, out MentorLake.Pango.PangoRectangle logical_rect)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoLayoutIter)");
		PangoLayoutIterExterns.pango_layout_iter_get_line_extents(iter, out ink_rect, out logical_rect);
	}

/// <summary>
/// <para>
/// Gets the current line for read-only access.
/// </para>
/// <para>
/// This is a faster alternative to [method@Pango.LayoutIter.get_line],
/// but the user is not expected to modify the contents of the line
/// (glyphs, glyph widths, etc.).
/// </para>
/// </summary>

/// <param name="iter">
/// a `PangoLayoutIter`
/// </param>
/// <return>
/// the current line, that should not be
///   modified
/// </return>

	public static MentorLake.Pango.PangoLayoutLineHandle GetLineReadonly(this MentorLake.Pango.PangoLayoutIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoLayoutIter)");
		return PangoLayoutIterExterns.pango_layout_iter_get_line_readonly(iter);
	}

/// <summary>
/// <para>
/// Divides the vertical space in the `PangoLayout` being iterated over
/// between the lines in the layout, and returns the space belonging to
/// the current line.
/// </para>
/// <para>
/// A line&apos;s range includes the line&apos;s logical extents. plus half of the
/// spacing above and below the line, if [method@Pango.Layout.set_spacing]
/// has been called to set layout spacing. The Y positions are in layout
/// coordinates (origin at top left of the entire layout).
/// </para>
/// <para>
/// Note: Since 1.44, Pango uses line heights for placing lines, and there
/// may be gaps between the ranges returned by this function.
/// </para>
/// </summary>

/// <param name="iter">
/// a `PangoLayoutIter`
/// </param>
/// <param name="y0_">
/// start of line
/// </param>
/// <param name="y1_">
/// end of line
/// </param>

	public static void GetLineYrange(this MentorLake.Pango.PangoLayoutIterHandle iter, out int y0_, out int y1_)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoLayoutIter)");
		PangoLayoutIterExterns.pango_layout_iter_get_line_yrange(iter, out y0_, out y1_);
	}

/// <summary>
/// <para>
/// Gets the current run.
/// </para>
/// <para>
/// When iterating by run, at the end of each line, there&apos;s a position
/// with a %NULL run, so this function can return %NULL. The %NULL run
/// at the end of each line ensures that all lines have at least one run,
/// even lines consisting of only a newline.
/// </para>
/// <para>
/// Use the faster [method@Pango.LayoutIter.get_run_readonly] if you do not
/// plan to modify the contents of the run (glyphs, glyph widths, etc.).
/// </para>
/// </summary>

/// <param name="iter">
/// a `PangoLayoutIter`
/// </param>
/// <return>
/// the current run
/// </return>

	public static MentorLake.Pango.PangoLayoutRunHandle GetRun(this MentorLake.Pango.PangoLayoutIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoLayoutIter)");
		return PangoLayoutIterExterns.pango_layout_iter_get_run(iter);
	}

/// <summary>
/// <para>
/// Gets the Y position of the current run&apos;s baseline, in layout
/// coordinates.
/// </para>
/// <para>
/// Layout coordinates have the origin at the top left of the entire layout.
/// </para>
/// <para>
/// The run baseline can be different from the line baseline, for
/// example due to superscript or subscript positioning.
/// </para>
/// </summary>

/// <param name="iter">
/// a `PangoLayoutIter`
/// </param>

	public static int GetRunBaseline(this MentorLake.Pango.PangoLayoutIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoLayoutIter)");
		return PangoLayoutIterExterns.pango_layout_iter_get_run_baseline(iter);
	}

/// <summary>
/// <para>
/// Gets the extents of the current run in layout coordinates.
/// </para>
/// <para>
/// Layout coordinates have the origin at the top left of the entire layout.
/// </para>
/// </summary>

/// <param name="iter">
/// a `PangoLayoutIter`
/// </param>
/// <param name="ink_rect">
/// rectangle to fill with ink extents
/// </param>
/// <param name="logical_rect">
/// rectangle to fill with logical extents
/// </param>

	public static void GetRunExtents(this MentorLake.Pango.PangoLayoutIterHandle iter, out MentorLake.Pango.PangoRectangle ink_rect, out MentorLake.Pango.PangoRectangle logical_rect)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoLayoutIter)");
		PangoLayoutIterExterns.pango_layout_iter_get_run_extents(iter, out ink_rect, out logical_rect);
	}

/// <summary>
/// <para>
/// Gets the current run for read-only access.
/// </para>
/// <para>
/// When iterating by run, at the end of each line, there&apos;s a position
/// with a %NULL run, so this function can return %NULL. The %NULL run
/// at the end of each line ensures that all lines have at least one run,
/// even lines consisting of only a newline.
/// </para>
/// <para>
/// This is a faster alternative to [method@Pango.LayoutIter.get_run],
/// but the user is not expected to modify the contents of the run (glyphs,
/// glyph widths, etc.).
/// </para>
/// </summary>

/// <param name="iter">
/// a `PangoLayoutIter`
/// </param>
/// <return>
/// the current run, that
///   should not be modified
/// </return>

	public static MentorLake.Pango.PangoLayoutRunHandle GetRunReadonly(this MentorLake.Pango.PangoLayoutIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoLayoutIter)");
		return PangoLayoutIterExterns.pango_layout_iter_get_run_readonly(iter);
	}

/// <summary>
/// <para>
/// Moves @iter forward to the next character in visual order.
/// </para>
/// <para>
/// If @iter was already at the end of the layout, returns %FALSE.
/// </para>
/// </summary>

/// <param name="iter">
/// a `PangoLayoutIter`
/// </param>
/// <return>
/// whether motion was possible
/// </return>

	public static bool NextChar(this MentorLake.Pango.PangoLayoutIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoLayoutIter)");
		return PangoLayoutIterExterns.pango_layout_iter_next_char(iter);
	}

/// <summary>
/// <para>
/// Moves @iter forward to the next cluster in visual order.
/// </para>
/// <para>
/// If @iter was already at the end of the layout, returns %FALSE.
/// </para>
/// </summary>

/// <param name="iter">
/// a `PangoLayoutIter`
/// </param>
/// <return>
/// whether motion was possible
/// </return>

	public static bool NextCluster(this MentorLake.Pango.PangoLayoutIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoLayoutIter)");
		return PangoLayoutIterExterns.pango_layout_iter_next_cluster(iter);
	}

/// <summary>
/// <para>
/// Moves @iter forward to the start of the next line.
/// </para>
/// <para>
/// If @iter is already on the last line, returns %FALSE.
/// </para>
/// </summary>

/// <param name="iter">
/// a `PangoLayoutIter`
/// </param>
/// <return>
/// whether motion was possible
/// </return>

	public static bool NextLine(this MentorLake.Pango.PangoLayoutIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoLayoutIter)");
		return PangoLayoutIterExterns.pango_layout_iter_next_line(iter);
	}

/// <summary>
/// <para>
/// Moves @iter forward to the next run in visual order.
/// </para>
/// <para>
/// If @iter was already at the end of the layout, returns %FALSE.
/// </para>
/// </summary>

/// <param name="iter">
/// a `PangoLayoutIter`
/// </param>
/// <return>
/// whether motion was possible
/// </return>

	public static bool NextRun(this MentorLake.Pango.PangoLayoutIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoLayoutIter)");
		return PangoLayoutIterExterns.pango_layout_iter_next_run(iter);
	}


	public static PangoLayoutIter Dereference(this PangoLayoutIterHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoLayoutIter>(x.DangerousGetHandle());
}
internal class PangoLayoutIterExterns
{
	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_layout_iter_at_last_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutIterHandle>))] MentorLake.Pango.PangoLayoutIterHandle iter);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutIterHandle>))]
	internal static extern MentorLake.Pango.PangoLayoutIterHandle pango_layout_iter_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutIterHandle>))] MentorLake.Pango.PangoLayoutIterHandle iter);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_iter_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutIterHandle>))] MentorLake.Pango.PangoLayoutIterHandle iter);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_layout_iter_get_baseline([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutIterHandle>))] MentorLake.Pango.PangoLayoutIterHandle iter);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_iter_get_char_extents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutIterHandle>))] MentorLake.Pango.PangoLayoutIterHandle iter, out MentorLake.Pango.PangoRectangle logical_rect);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_iter_get_cluster_extents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutIterHandle>))] MentorLake.Pango.PangoLayoutIterHandle iter, out MentorLake.Pango.PangoRectangle ink_rect, out MentorLake.Pango.PangoRectangle logical_rect);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_layout_iter_get_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutIterHandle>))] MentorLake.Pango.PangoLayoutIterHandle iter);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))]
	internal static extern MentorLake.Pango.PangoLayoutHandle pango_layout_iter_get_layout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutIterHandle>))] MentorLake.Pango.PangoLayoutIterHandle iter);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_iter_get_layout_extents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutIterHandle>))] MentorLake.Pango.PangoLayoutIterHandle iter, out MentorLake.Pango.PangoRectangle ink_rect, out MentorLake.Pango.PangoRectangle logical_rect);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutLineHandle>))]
	internal static extern MentorLake.Pango.PangoLayoutLineHandle pango_layout_iter_get_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutIterHandle>))] MentorLake.Pango.PangoLayoutIterHandle iter);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_iter_get_line_extents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutIterHandle>))] MentorLake.Pango.PangoLayoutIterHandle iter, out MentorLake.Pango.PangoRectangle ink_rect, out MentorLake.Pango.PangoRectangle logical_rect);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutLineHandle>))]
	internal static extern MentorLake.Pango.PangoLayoutLineHandle pango_layout_iter_get_line_readonly([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutIterHandle>))] MentorLake.Pango.PangoLayoutIterHandle iter);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_iter_get_line_yrange([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutIterHandle>))] MentorLake.Pango.PangoLayoutIterHandle iter, out int y0_, out int y1_);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutRunHandle>))]
	internal static extern MentorLake.Pango.PangoLayoutRunHandle pango_layout_iter_get_run([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutIterHandle>))] MentorLake.Pango.PangoLayoutIterHandle iter);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_layout_iter_get_run_baseline([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutIterHandle>))] MentorLake.Pango.PangoLayoutIterHandle iter);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_iter_get_run_extents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutIterHandle>))] MentorLake.Pango.PangoLayoutIterHandle iter, out MentorLake.Pango.PangoRectangle ink_rect, out MentorLake.Pango.PangoRectangle logical_rect);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutRunHandle>))]
	internal static extern MentorLake.Pango.PangoLayoutRunHandle pango_layout_iter_get_run_readonly([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutIterHandle>))] MentorLake.Pango.PangoLayoutIterHandle iter);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_layout_iter_next_char([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutIterHandle>))] MentorLake.Pango.PangoLayoutIterHandle iter);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_layout_iter_next_cluster([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutIterHandle>))] MentorLake.Pango.PangoLayoutIterHandle iter);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_layout_iter_next_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutIterHandle>))] MentorLake.Pango.PangoLayoutIterHandle iter);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_layout_iter_next_run([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutIterHandle>))] MentorLake.Pango.PangoLayoutIterHandle iter);

}

/// <summary>
/// <para>
/// A `PangoLayoutIter` can be used to iterate over the visual
/// extents of a `PangoLayout`.
/// </para>
/// <para>
/// To obtain a `PangoLayoutIter`, use [method@Pango.Layout.get_iter].
/// </para>
/// <para>
/// The `PangoLayoutIter` structure is opaque, and has no user-visible fields.
/// </para>
/// </summary>

public struct PangoLayoutIter
{
}
