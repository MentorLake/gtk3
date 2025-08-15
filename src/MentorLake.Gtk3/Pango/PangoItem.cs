namespace MentorLake.Pango;

/// <summary>
/// <para>
/// The `PangoItem` structure stores information about a segment of text.
/// </para>
/// <para>
/// You typically obtain `PangoItems` by itemizing a piece of text
/// with [func@itemize].
/// </para>
/// </summary>

public class PangoItemHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a new `PangoItem` structure initialized to default values.
/// </para>
/// </summary>

/// <return>
/// the newly allocated `PangoItem`, which should
///   be freed with [method@Pango.Item.free].
/// </return>

	public static MentorLake.Pango.PangoItemHandle New()
	{
		return PangoItemExterns.pango_item_new();
	}

}


public static class PangoItemExtensions
{
/// <summary>
/// <para>
/// Add attributes to a `PangoItem`.
/// </para>
/// <para>
/// The idea is that you have attributes that don&apos;t affect itemization,
/// such as font features, so you filter them out using
/// [method@Pango.AttrList.filter], itemize your text, then reapply the
/// attributes to the resulting items using this function.
/// </para>
/// <para>
/// The @iter should be positioned before the range of the item,
/// and will be advanced past it. This function is meant to be called
/// in a loop over the items resulting from itemization, while passing
/// the iter to each call.
/// </para>
/// </summary>

/// <param name="item">
/// a `PangoItem`
/// </param>
/// <param name="iter">
/// a `PangoAttrIterator`
/// </param>

	public static void ApplyAttrs(this MentorLake.Pango.PangoItemHandle item, MentorLake.Pango.PangoAttrIteratorHandle iter)
	{
		if (item.IsInvalid) throw new Exception("Invalid handle (PangoItem)");
		PangoItemExterns.pango_item_apply_attrs(item, iter);
	}

/// <summary>
/// <para>
/// Copy an existing `PangoItem` structure.
/// </para>
/// </summary>

/// <param name="item">
/// a `PangoItem`
/// </param>
/// <return>
/// the newly allocated `PangoItem`
/// </return>

	public static MentorLake.Pango.PangoItemHandle Copy(this MentorLake.Pango.PangoItemHandle item)
	{
		if (item.IsInvalid) throw new Exception("Invalid handle (PangoItem)");
		return PangoItemExterns.pango_item_copy(item);
	}

/// <summary>
/// <para>
/// Free a `PangoItem` and all associated memory.
/// </para>
/// </summary>

/// <param name="item">
/// a `PangoItem`, may be %NULL
/// </param>

	public static void Free(this MentorLake.Pango.PangoItemHandle item)
	{
		if (item.IsInvalid) throw new Exception("Invalid handle (PangoItem)");
		PangoItemExterns.pango_item_free(item);
	}

/// <summary>
/// <para>
/// Returns the character offset of the item from the beginning
/// of the itemized text.
/// </para>
/// <para>
/// If the item has not been obtained from Pango&apos;s itemization
/// machinery, then the character offset is not available. In
/// that case, this function returns -1.
/// </para>
/// </summary>

/// <param name="item">
/// a `PangoItem`
/// </param>
/// <return>
/// the character offset of the item from the beginning
///   of the itemized text, or -1
/// </return>

	public static int GetCharOffset(this MentorLake.Pango.PangoItemHandle item)
	{
		if (item.IsInvalid) throw new Exception("Invalid handle (PangoItem)");
		return PangoItemExterns.pango_item_get_char_offset(item);
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
/// @split_offset is the length of the first item in chars, and must be
/// provided because the text used to generate the item isn&apos;t available,
/// so `pango_item_split()` can&apos;t count the char length of the split items
/// itself.
/// </para>
/// </summary>

/// <param name="orig">
/// a `PangoItem`
/// </param>
/// <param name="split_index">
/// byte index of position to split item, relative to the
///   start of the item
/// </param>
/// <param name="split_offset">
/// number of chars between start of @orig and @split_index
/// </param>
/// <return>
/// new item representing text before @split_index, which
///   should be freed with [method@Pango.Item.free].
/// </return>

	public static MentorLake.Pango.PangoItemHandle Split(this MentorLake.Pango.PangoItemHandle orig, int split_index, int split_offset)
	{
		if (orig.IsInvalid) throw new Exception("Invalid handle (PangoItem)");
		return PangoItemExterns.pango_item_split(orig, split_index, split_offset);
	}


	public static PangoItem Dereference(this PangoItemHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoItem>(x.DangerousGetHandle());
}
internal class PangoItemExterns
{
	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoItemHandle>))]
	internal static extern MentorLake.Pango.PangoItemHandle pango_item_new();

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_item_apply_attrs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoItemHandle>))] MentorLake.Pango.PangoItemHandle item, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrIteratorHandle>))] MentorLake.Pango.PangoAttrIteratorHandle iter);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoItemHandle>))]
	internal static extern MentorLake.Pango.PangoItemHandle pango_item_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoItemHandle>))] MentorLake.Pango.PangoItemHandle item);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_item_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoItemHandle>))] MentorLake.Pango.PangoItemHandle item);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_item_get_char_offset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoItemHandle>))] MentorLake.Pango.PangoItemHandle item);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoItemHandle>))]
	internal static extern MentorLake.Pango.PangoItemHandle pango_item_split([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoItemHandle>))] MentorLake.Pango.PangoItemHandle orig, int split_index, int split_offset);

}

/// <summary>
/// <para>
/// The `PangoItem` structure stores information about a segment of text.
/// </para>
/// <para>
/// You typically obtain `PangoItems` by itemizing a piece of text
/// with [func@itemize].
/// </para>
/// </summary>

public struct PangoItem
{
	/// <summary>
/// <para>
/// byte offset of the start of this item in text.
/// </para>
/// </summary>

public int offset;
	/// <summary>
/// <para>
/// length of this item in bytes.
/// </para>
/// </summary>

public int length;
	/// <summary>
/// <para>
/// number of Unicode characters in the item.
/// </para>
/// </summary>

public int num_chars;
	/// <summary>
/// <para>
/// analysis results for the item.
/// </para>
/// </summary>

public PangoAnalysis analysis;
}
