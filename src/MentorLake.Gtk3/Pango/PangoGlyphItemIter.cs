namespace MentorLake.Pango;

public class PangoGlyphItemIterHandle : BaseSafeHandle
{
}


public static class PangoGlyphItemIterExtensions
{
	public static MentorLake.Pango.PangoGlyphItemIterHandle Copy(this MentorLake.Pango.PangoGlyphItemIterHandle orig)
	{
		return PangoGlyphItemIterExterns.pango_glyph_item_iter_copy(orig);
	}

	public static void Free(this MentorLake.Pango.PangoGlyphItemIterHandle iter)
	{
		PangoGlyphItemIterExterns.pango_glyph_item_iter_free(iter);
	}

	public static bool InitEnd(this MentorLake.Pango.PangoGlyphItemIterHandle iter, MentorLake.Pango.PangoGlyphItemHandle glyph_item, string text)
	{
		return PangoGlyphItemIterExterns.pango_glyph_item_iter_init_end(iter, glyph_item, text);
	}

	public static bool InitStart(this MentorLake.Pango.PangoGlyphItemIterHandle iter, MentorLake.Pango.PangoGlyphItemHandle glyph_item, string text)
	{
		return PangoGlyphItemIterExterns.pango_glyph_item_iter_init_start(iter, glyph_item, text);
	}

	public static bool NextCluster(this MentorLake.Pango.PangoGlyphItemIterHandle iter)
	{
		return PangoGlyphItemIterExterns.pango_glyph_item_iter_next_cluster(iter);
	}

	public static bool PrevCluster(this MentorLake.Pango.PangoGlyphItemIterHandle iter)
	{
		return PangoGlyphItemIterExterns.pango_glyph_item_iter_prev_cluster(iter);
	}


	public static PangoGlyphItemIter Dereference(this PangoGlyphItemIterHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoGlyphItemIter>(x.DangerousGetHandle());
}
internal class PangoGlyphItemIterExterns
{
	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoGlyphItemIterHandle pango_glyph_item_iter_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphItemIterHandle>))] MentorLake.Pango.PangoGlyphItemIterHandle orig);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_glyph_item_iter_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphItemIterHandle>))] MentorLake.Pango.PangoGlyphItemIterHandle iter);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_glyph_item_iter_init_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphItemIterHandle>))] MentorLake.Pango.PangoGlyphItemIterHandle iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphItemHandle>))] MentorLake.Pango.PangoGlyphItemHandle glyph_item, string text);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_glyph_item_iter_init_start([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphItemIterHandle>))] MentorLake.Pango.PangoGlyphItemIterHandle iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphItemHandle>))] MentorLake.Pango.PangoGlyphItemHandle glyph_item, string text);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_glyph_item_iter_next_cluster([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphItemIterHandle>))] MentorLake.Pango.PangoGlyphItemIterHandle iter);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_glyph_item_iter_prev_cluster([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphItemIterHandle>))] MentorLake.Pango.PangoGlyphItemIterHandle iter);

}

public struct PangoGlyphItemIter
{
	public IntPtr glyph_item;
	public string text;
	public int start_glyph;
	public int start_index;
	public int start_char;
	public int end_glyph;
	public int end_index;
	public int end_char;
}
