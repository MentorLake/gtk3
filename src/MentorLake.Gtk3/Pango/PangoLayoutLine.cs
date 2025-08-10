namespace MentorLake.Pango;

public class PangoLayoutLineHandle : BaseSafeHandle
{
}


public static class PangoLayoutLineExtensions
{
	public static void GetExtents(this MentorLake.Pango.PangoLayoutLineHandle line, out MentorLake.Pango.PangoRectangle ink_rect, out MentorLake.Pango.PangoRectangle logical_rect)
	{
		if (line.IsInvalid) throw new Exception("Invalid handle (PangoLayoutLine)");
		PangoLayoutLineExterns.pango_layout_line_get_extents(line, out ink_rect, out logical_rect);
	}

	public static void GetHeight(this MentorLake.Pango.PangoLayoutLineHandle line, out int height)
	{
		if (line.IsInvalid) throw new Exception("Invalid handle (PangoLayoutLine)");
		PangoLayoutLineExterns.pango_layout_line_get_height(line, out height);
	}

	public static int GetLength(this MentorLake.Pango.PangoLayoutLineHandle line)
	{
		if (line.IsInvalid) throw new Exception("Invalid handle (PangoLayoutLine)");
		return PangoLayoutLineExterns.pango_layout_line_get_length(line);
	}

	public static void GetPixelExtents(this MentorLake.Pango.PangoLayoutLineHandle layout_line, out MentorLake.Pango.PangoRectangle ink_rect, out MentorLake.Pango.PangoRectangle logical_rect)
	{
		if (layout_line.IsInvalid) throw new Exception("Invalid handle (PangoLayoutLine)");
		PangoLayoutLineExterns.pango_layout_line_get_pixel_extents(layout_line, out ink_rect, out logical_rect);
	}

	public static MentorLake.Pango.PangoDirection GetResolvedDirection(this MentorLake.Pango.PangoLayoutLineHandle line)
	{
		if (line.IsInvalid) throw new Exception("Invalid handle (PangoLayoutLine)");
		return PangoLayoutLineExterns.pango_layout_line_get_resolved_direction(line);
	}

	public static int GetStartIndex(this MentorLake.Pango.PangoLayoutLineHandle line)
	{
		if (line.IsInvalid) throw new Exception("Invalid handle (PangoLayoutLine)");
		return PangoLayoutLineExterns.pango_layout_line_get_start_index(line);
	}

	public static void GetXRanges(this MentorLake.Pango.PangoLayoutLineHandle line, int start_index, int end_index, out int[] ranges, out int n_ranges)
	{
		if (line.IsInvalid) throw new Exception("Invalid handle (PangoLayoutLine)");
		PangoLayoutLineExterns.pango_layout_line_get_x_ranges(line, start_index, end_index, out ranges, out n_ranges);
	}

	public static void IndexToX(this MentorLake.Pango.PangoLayoutLineHandle line, int index_, bool trailing, out int x_pos)
	{
		if (line.IsInvalid) throw new Exception("Invalid handle (PangoLayoutLine)");
		PangoLayoutLineExterns.pango_layout_line_index_to_x(line, index_, trailing, out x_pos);
	}

	public static bool IsParagraphStart(this MentorLake.Pango.PangoLayoutLineHandle line)
	{
		if (line.IsInvalid) throw new Exception("Invalid handle (PangoLayoutLine)");
		return PangoLayoutLineExterns.pango_layout_line_is_paragraph_start(line);
	}

	public static MentorLake.Pango.PangoLayoutLineHandle Ref(this MentorLake.Pango.PangoLayoutLineHandle line)
	{
		if (line.IsInvalid) throw new Exception("Invalid handle (PangoLayoutLine)");
		return PangoLayoutLineExterns.pango_layout_line_ref(line);
	}

	public static void Unref(this MentorLake.Pango.PangoLayoutLineHandle line)
	{
		if (line.IsInvalid) throw new Exception("Invalid handle (PangoLayoutLine)");
		PangoLayoutLineExterns.pango_layout_line_unref(line);
	}

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

public struct PangoLayoutLine
{
	public IntPtr layout;
	public int start_index;
	public int length;
	public IntPtr runs;
	public uint is_paragraph_start;
	public uint resolved_dir;
}
