namespace MentorLake.Pango;

public class PangoLayoutIterHandle : BaseSafeHandle
{
}


public static class PangoLayoutIterExtensions
{
	public static bool AtLastLine(this MentorLake.Pango.PangoLayoutIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoLayoutIter)");
		return PangoLayoutIterExterns.pango_layout_iter_at_last_line(iter);
	}

	public static MentorLake.Pango.PangoLayoutIterHandle Copy(this MentorLake.Pango.PangoLayoutIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoLayoutIter)");
		return PangoLayoutIterExterns.pango_layout_iter_copy(iter);
	}

	public static void Free(this MentorLake.Pango.PangoLayoutIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoLayoutIter)");
		PangoLayoutIterExterns.pango_layout_iter_free(iter);
	}

	public static int GetBaseline(this MentorLake.Pango.PangoLayoutIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoLayoutIter)");
		return PangoLayoutIterExterns.pango_layout_iter_get_baseline(iter);
	}

	public static void GetCharExtents(this MentorLake.Pango.PangoLayoutIterHandle iter, out MentorLake.Pango.PangoRectangle logical_rect)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoLayoutIter)");
		PangoLayoutIterExterns.pango_layout_iter_get_char_extents(iter, out logical_rect);
	}

	public static void GetClusterExtents(this MentorLake.Pango.PangoLayoutIterHandle iter, out MentorLake.Pango.PangoRectangle ink_rect, out MentorLake.Pango.PangoRectangle logical_rect)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoLayoutIter)");
		PangoLayoutIterExterns.pango_layout_iter_get_cluster_extents(iter, out ink_rect, out logical_rect);
	}

	public static int GetIndex(this MentorLake.Pango.PangoLayoutIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoLayoutIter)");
		return PangoLayoutIterExterns.pango_layout_iter_get_index(iter);
	}

	public static MentorLake.Pango.PangoLayoutHandle GetLayout(this MentorLake.Pango.PangoLayoutIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoLayoutIter)");
		return PangoLayoutIterExterns.pango_layout_iter_get_layout(iter);
	}

	public static void GetLayoutExtents(this MentorLake.Pango.PangoLayoutIterHandle iter, out MentorLake.Pango.PangoRectangle ink_rect, out MentorLake.Pango.PangoRectangle logical_rect)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoLayoutIter)");
		PangoLayoutIterExterns.pango_layout_iter_get_layout_extents(iter, out ink_rect, out logical_rect);
	}

	public static MentorLake.Pango.PangoLayoutLineHandle GetLine(this MentorLake.Pango.PangoLayoutIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoLayoutIter)");
		return PangoLayoutIterExterns.pango_layout_iter_get_line(iter);
	}

	public static void GetLineExtents(this MentorLake.Pango.PangoLayoutIterHandle iter, out MentorLake.Pango.PangoRectangle ink_rect, out MentorLake.Pango.PangoRectangle logical_rect)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoLayoutIter)");
		PangoLayoutIterExterns.pango_layout_iter_get_line_extents(iter, out ink_rect, out logical_rect);
	}

	public static MentorLake.Pango.PangoLayoutLineHandle GetLineReadonly(this MentorLake.Pango.PangoLayoutIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoLayoutIter)");
		return PangoLayoutIterExterns.pango_layout_iter_get_line_readonly(iter);
	}

	public static void GetLineYrange(this MentorLake.Pango.PangoLayoutIterHandle iter, out int y0_, out int y1_)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoLayoutIter)");
		PangoLayoutIterExterns.pango_layout_iter_get_line_yrange(iter, out y0_, out y1_);
	}

	public static MentorLake.Pango.PangoLayoutRunHandle GetRun(this MentorLake.Pango.PangoLayoutIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoLayoutIter)");
		return PangoLayoutIterExterns.pango_layout_iter_get_run(iter);
	}

	public static int GetRunBaseline(this MentorLake.Pango.PangoLayoutIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoLayoutIter)");
		return PangoLayoutIterExterns.pango_layout_iter_get_run_baseline(iter);
	}

	public static void GetRunExtents(this MentorLake.Pango.PangoLayoutIterHandle iter, out MentorLake.Pango.PangoRectangle ink_rect, out MentorLake.Pango.PangoRectangle logical_rect)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoLayoutIter)");
		PangoLayoutIterExterns.pango_layout_iter_get_run_extents(iter, out ink_rect, out logical_rect);
	}

	public static MentorLake.Pango.PangoLayoutRunHandle GetRunReadonly(this MentorLake.Pango.PangoLayoutIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoLayoutIter)");
		return PangoLayoutIterExterns.pango_layout_iter_get_run_readonly(iter);
	}

	public static bool NextChar(this MentorLake.Pango.PangoLayoutIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoLayoutIter)");
		return PangoLayoutIterExterns.pango_layout_iter_next_char(iter);
	}

	public static bool NextCluster(this MentorLake.Pango.PangoLayoutIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoLayoutIter)");
		return PangoLayoutIterExterns.pango_layout_iter_next_cluster(iter);
	}

	public static bool NextLine(this MentorLake.Pango.PangoLayoutIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoLayoutIter)");
		return PangoLayoutIterExterns.pango_layout_iter_next_line(iter);
	}

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

public struct PangoLayoutIter
{
}
