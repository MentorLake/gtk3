namespace MentorLake.Pango;

public class PangoGlyphItemHandle : BaseSafeHandle
{
}


public static class PangoGlyphItemExtensions
{
	public static MentorLake.GLib.GSListHandle ApplyAttrs(this MentorLake.Pango.PangoGlyphItemHandle glyph_item, string text, MentorLake.Pango.PangoAttrListHandle list)
	{
		return PangoGlyphItemExterns.pango_glyph_item_apply_attrs(glyph_item, text, list);
	}

	public static MentorLake.Pango.PangoGlyphItemHandle Copy(this MentorLake.Pango.PangoGlyphItemHandle orig)
	{
		return PangoGlyphItemExterns.pango_glyph_item_copy(orig);
	}

	public static void Free(this MentorLake.Pango.PangoGlyphItemHandle glyph_item)
	{
		PangoGlyphItemExterns.pango_glyph_item_free(glyph_item);
	}

	public static void GetLogicalWidths(this MentorLake.Pango.PangoGlyphItemHandle glyph_item, string text, int[] logical_widths)
	{
		PangoGlyphItemExterns.pango_glyph_item_get_logical_widths(glyph_item, text, logical_widths);
	}

	public static void LetterSpace(this MentorLake.Pango.PangoGlyphItemHandle glyph_item, string text, MentorLake.Pango.PangoLogAttr[] log_attrs, int letter_spacing)
	{
		PangoGlyphItemExterns.pango_glyph_item_letter_space(glyph_item, text, log_attrs, letter_spacing);
	}

	public static MentorLake.Pango.PangoGlyphItemHandle Split(this MentorLake.Pango.PangoGlyphItemHandle orig, string text, int split_index)
	{
		return PangoGlyphItemExterns.pango_glyph_item_split(orig, text, split_index);
	}


	public static PangoGlyphItem Dereference(this PangoGlyphItemHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoGlyphItem>(x.DangerousGetHandle());
}
internal class PangoGlyphItemExterns
{
	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.GLib.GSListHandle pango_glyph_item_apply_attrs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphItemHandle>))] MentorLake.Pango.PangoGlyphItemHandle glyph_item, string text, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle list);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoGlyphItemHandle pango_glyph_item_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphItemHandle>))] MentorLake.Pango.PangoGlyphItemHandle orig);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_glyph_item_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphItemHandle>))] MentorLake.Pango.PangoGlyphItemHandle glyph_item);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_glyph_item_get_logical_widths([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphItemHandle>))] MentorLake.Pango.PangoGlyphItemHandle glyph_item, string text, int[] logical_widths);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_glyph_item_letter_space([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphItemHandle>))] MentorLake.Pango.PangoGlyphItemHandle glyph_item, string text, MentorLake.Pango.PangoLogAttr[] log_attrs, int letter_spacing);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoGlyphItemHandle pango_glyph_item_split([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphItemHandle>))] MentorLake.Pango.PangoGlyphItemHandle orig, string text, int split_index);

}

public struct PangoGlyphItem
{
	public IntPtr item;
	public IntPtr glyphs;
	public int y_offset;
	public int start_x_offset;
	public int end_x_offset;
}
