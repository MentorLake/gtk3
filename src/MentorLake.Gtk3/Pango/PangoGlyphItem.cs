namespace MentorLake.Pango;

/// <summary>
/// <para>
/// A `PangoGlyphItem` is a pair of a `PangoItem` and the glyphs
/// resulting from shaping the items text.
/// </para>
/// <para>
/// As an example of the usage of `PangoGlyphItem`, the results
/// of shaping text with `PangoLayout` is a list of `PangoLayoutLine`,
/// each of which contains a list of `PangoGlyphItem`.
/// </para>
/// </summary>

public class PangoGlyphItemHandle : BaseSafeHandle
{
}


public static class PangoGlyphItemExtensions
{
/// <summary>
/// <para>
/// Splits a shaped item (`PangoGlyphItem`) into multiple items based
/// on an attribute list.
/// </para>
/// <para>
/// The idea is that if you have attributes that don&apos;t affect shaping,
/// such as color or underline, to avoid affecting shaping, you filter
/// them out ([method@Pango.AttrList.filter]), apply the shaping process
/// and then reapply them to the result using this function.
/// </para>
/// <para>
/// All attributes that start or end inside a cluster are applied
/// to that cluster; for instance, if half of a cluster is underlined
/// and the other-half strikethrough, then the cluster will end
/// up with both underline and strikethrough attributes. In these
/// cases, it may happen that @item-&amp;gt;extra_attrs for some of the
/// result items can have multiple attributes of the same type.
/// </para>
/// <para>
/// This function takes ownership of @glyph_item; it will be reused
/// as one of the elements in the list.
/// </para>
/// </summary>

/// <param name="glyph_item">
/// a shaped item
/// </param>
/// <param name="text">
/// text that @list applies to
/// </param>
/// <param name="list">
/// a `PangoAttrList`
/// </param>
/// <return>
/// a
///   list of glyph items resulting from splitting @glyph_item. Free
///   the elements using [method@Pango.GlyphItem.free], the list using
///   g_slist_free().
/// </return>

	public static MentorLake.GLib.GSListHandle ApplyAttrs(this MentorLake.Pango.PangoGlyphItemHandle glyph_item, string text, MentorLake.Pango.PangoAttrListHandle list)
	{
		if (glyph_item.IsInvalid) throw new Exception("Invalid handle (PangoGlyphItem)");
		return PangoGlyphItemExterns.pango_glyph_item_apply_attrs(glyph_item, text, list);
	}

/// <summary>
/// <para>
/// Make a deep copy of an existing `PangoGlyphItem` structure.
/// </para>
/// </summary>

/// <param name="orig">
/// a `PangoGlyphItem`
/// </param>
/// <return>
/// the newly allocated `PangoGlyphItem`
/// </return>

	public static MentorLake.Pango.PangoGlyphItemHandle Copy(this MentorLake.Pango.PangoGlyphItemHandle orig)
	{
		if (orig.IsInvalid) throw new Exception("Invalid handle (PangoGlyphItem)");
		return PangoGlyphItemExterns.pango_glyph_item_copy(orig);
	}

/// <summary>
/// <para>
/// Frees a `PangoGlyphItem` and resources to which it points.
/// </para>
/// </summary>

/// <param name="glyph_item">
/// a `PangoGlyphItem`
/// </param>

	public static void Free(this MentorLake.Pango.PangoGlyphItemHandle glyph_item)
	{
		if (glyph_item.IsInvalid) throw new Exception("Invalid handle (PangoGlyphItem)");
		PangoGlyphItemExterns.pango_glyph_item_free(glyph_item);
	}

/// <summary>
/// <para>
/// Given a `PangoGlyphItem` and the corresponding text, determine the
/// width corresponding to each character.
/// </para>
/// <para>
/// When multiple characters compose a single cluster, the width of the
/// entire cluster is divided equally among the characters.
/// </para>
/// <para>
/// See also [method@Pango.GlyphString.get_logical_widths].
/// </para>
/// </summary>

/// <param name="glyph_item">
/// a `PangoGlyphItem`
/// </param>
/// <param name="text">
/// text that @glyph_item corresponds to
///   (glyph_item-&amp;gt;item-&amp;gt;offset is an offset from the
///   start of @text)
/// </param>
/// <param name="logical_widths">
/// an array whose length is the number of
///   characters in glyph_item (equal to glyph_item-&amp;gt;item-&amp;gt;num_chars)
///   to be filled in with the resulting character widths.
/// </param>

	public static void GetLogicalWidths(this MentorLake.Pango.PangoGlyphItemHandle glyph_item, string text, int[] logical_widths)
	{
		if (glyph_item.IsInvalid) throw new Exception("Invalid handle (PangoGlyphItem)");
		PangoGlyphItemExterns.pango_glyph_item_get_logical_widths(glyph_item, text, logical_widths);
	}

/// <summary>
/// <para>
/// Adds spacing between the graphemes of @glyph_item to
/// give the effect of typographic letter spacing.
/// </para>
/// </summary>

/// <param name="glyph_item">
/// a `PangoGlyphItem`
/// </param>
/// <param name="text">
/// text that @glyph_item corresponds to
///   (glyph_item-&amp;gt;item-&amp;gt;offset is an offset from the
///   start of @text)
/// </param>
/// <param name="log_attrs">
/// logical attributes for the item
///   (the first logical attribute refers to the position
///   before the first character in the item)
/// </param>
/// <param name="letter_spacing">
/// amount of letter spacing to add
///   in Pango units. May be negative, though too large
///   negative values will give ugly results.
/// </param>

	public static void LetterSpace(this MentorLake.Pango.PangoGlyphItemHandle glyph_item, string text, MentorLake.Pango.PangoLogAttr[] log_attrs, int letter_spacing)
	{
		if (glyph_item.IsInvalid) throw new Exception("Invalid handle (PangoGlyphItem)");
		PangoGlyphItemExterns.pango_glyph_item_letter_space(glyph_item, text, log_attrs, letter_spacing);
	}

/// <summary>
/// <para>
/// Modifies @orig to cover only the text after @split_index, and
/// returns a new item that covers the text before @split_index that
/// used to be in @orig.
/// </para>
/// <para>
/// You can think of @split_index as the length of the returned item.
/// @split_index may not be 0, and it may not be greater than or equal
/// to the length of @orig (that is, there must be at least one byte
/// assigned to each item, you can&apos;t create a zero-length item).
/// </para>
/// <para>
/// This function is similar in function to pango_item_split() (and uses
/// it internally.)
/// </para>
/// </summary>

/// <param name="orig">
/// a `PangoItem`
/// </param>
/// <param name="text">
/// text to which positions in @orig apply
/// </param>
/// <param name="split_index">
/// byte index of position to split item, relative to the
///   start of the item
/// </param>
/// <return>
/// the newly allocated item
///   representing text before @split_index, which should be freed
///   with pango_glyph_item_free().
/// </return>

	public static MentorLake.Pango.PangoGlyphItemHandle Split(this MentorLake.Pango.PangoGlyphItemHandle orig, string text, int split_index)
	{
		if (orig.IsInvalid) throw new Exception("Invalid handle (PangoGlyphItem)");
		return PangoGlyphItemExterns.pango_glyph_item_split(orig, text, split_index);
	}


	public static PangoGlyphItem Dereference(this PangoGlyphItemHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoGlyphItem>(x.DangerousGetHandle());
}
internal class PangoGlyphItemExterns
{
	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle pango_glyph_item_apply_attrs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphItemHandle>))] MentorLake.Pango.PangoGlyphItemHandle glyph_item, string text, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle list);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphItemHandle>))]
	internal static extern MentorLake.Pango.PangoGlyphItemHandle pango_glyph_item_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphItemHandle>))] MentorLake.Pango.PangoGlyphItemHandle orig);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_glyph_item_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphItemHandle>))] MentorLake.Pango.PangoGlyphItemHandle glyph_item);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_glyph_item_get_logical_widths([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphItemHandle>))] MentorLake.Pango.PangoGlyphItemHandle glyph_item, string text, int[] logical_widths);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_glyph_item_letter_space([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphItemHandle>))] MentorLake.Pango.PangoGlyphItemHandle glyph_item, string text, MentorLake.Pango.PangoLogAttr[] log_attrs, int letter_spacing);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphItemHandle>))]
	internal static extern MentorLake.Pango.PangoGlyphItemHandle pango_glyph_item_split([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphItemHandle>))] MentorLake.Pango.PangoGlyphItemHandle orig, string text, int split_index);

}

/// <summary>
/// <para>
/// A `PangoGlyphItem` is a pair of a `PangoItem` and the glyphs
/// resulting from shaping the items text.
/// </para>
/// <para>
/// As an example of the usage of `PangoGlyphItem`, the results
/// of shaping text with `PangoLayout` is a list of `PangoLayoutLine`,
/// each of which contains a list of `PangoGlyphItem`.
/// </para>
/// </summary>

public struct PangoGlyphItem
{
	/// <summary>
/// <para>
/// corresponding `PangoItem`
/// </para>
/// </summary>

public IntPtr item;
	/// <summary>
/// <para>
/// corresponding `PangoGlyphString`
/// </para>
/// </summary>

public IntPtr glyphs;
	/// <summary>
/// <para>
/// shift of the baseline, relative to the baseline
///   of the containing line. Positive values shift upwards
/// </para>
/// </summary>

public int y_offset;
	/// <summary>
/// <para>
/// horizontal displacement to apply before the
///   glyph item. Positive values shift right
/// </para>
/// </summary>

public int start_x_offset;
	/// <summary>
/// <para>
/// horizontal displacement to apply after th
///   glyph item. Positive values shift right
/// </para>
/// </summary>

public int end_x_offset;
}
