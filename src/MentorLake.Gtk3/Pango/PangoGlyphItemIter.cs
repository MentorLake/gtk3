namespace MentorLake.Pango;

/// <summary>
/// <para>
/// A `PangoGlyphItemIter` is an iterator over the clusters in a
/// `PangoGlyphItem`.
/// </para>
/// <para>
/// The *forward direction* of the iterator is the logical direction of text.
/// That is, with increasing @start_index and @start_char values. If @glyph_item
/// is right-to-left (that is, if `glyph_item->item->analysis.level` is odd),
/// then @start_glyph decreases as the iterator moves forward.  Moreover,
/// in right-to-left cases, @start_glyph is greater than @end_glyph.
/// </para>
/// <para>
/// An iterator should be initialized using either
/// pango_glyph_item_iter_init_start() or
/// pango_glyph_item_iter_init_end(), for forward and backward iteration
/// respectively, and walked over using any desired mixture of
/// pango_glyph_item_iter_next_cluster() and
/// pango_glyph_item_iter_prev_cluster().
/// </para>
/// <para>
/// A common idiom for doing a forward iteration over the clusters is:
/// </para>
/// <para>
/// ```
/// PangoGlyphItemIter cluster_iter;
/// gboolean have_cluster;
/// </para>
/// <para>
/// for (have_cluster = pango_glyph_item_iter_init_start (&cluster_iter,
///                                                       glyph_item, text);
///      have_cluster;
///      have_cluster = pango_glyph_item_iter_next_cluster (&cluster_iter))
/// {
///   ...
/// }
/// ```
/// </para>
/// <para>
/// Note that @text is the start of the text for layout, which is then
/// indexed by `glyph_item->item->offset` to get to the text of @glyph_item.
/// The @start_index and @end_index values can directly index into @text. The
/// @start_glyph, @end_glyph, @start_char, and @end_char values however are
/// zero-based for the @glyph_item.  For each cluster, the item pointed at by
/// the start variables is included in the cluster while the one pointed at by
/// end variables is not.
/// </para>
/// <para>
/// None of the members of a `PangoGlyphItemIter` should be modified manually.
/// </para>
/// </summary>

public class PangoGlyphItemIterHandle : BaseSafeHandle
{
}


public static class PangoGlyphItemIterExtensions
{
/// <summary>
/// <para>
/// Make a shallow copy of an existing `PangoGlyphItemIter` structure.
/// </para>
/// </summary>

/// <param name="orig">
/// a `PangoGlyphItem`Iter
/// </param>
/// <return>
/// the newly allocated `PangoGlyphItemIter`
/// </return>

	public static MentorLake.Pango.PangoGlyphItemIterHandle Copy(this MentorLake.Pango.PangoGlyphItemIterHandle orig)
	{
		if (orig.IsInvalid) throw new Exception("Invalid handle (PangoGlyphItemIter)");
		return PangoGlyphItemIterExterns.pango_glyph_item_iter_copy(orig);
	}

/// <summary>
/// <para>
/// Frees a `PangoGlyphItem`Iter.
/// </para>
/// </summary>

/// <param name="iter">
/// a `PangoGlyphItemIter`
/// </param>

	public static void Free(this MentorLake.Pango.PangoGlyphItemIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoGlyphItemIter)");
		PangoGlyphItemIterExterns.pango_glyph_item_iter_free(iter);
	}

/// <summary>
/// <para>
/// Initializes a `PangoGlyphItemIter` structure to point to the
/// last cluster in a glyph item.
/// </para>
/// <para>
/// See `PangoGlyphItemIter` for details of cluster orders.
/// </para>
/// </summary>

/// <param name="iter">
/// a `PangoGlyphItemIter`
/// </param>
/// <param name="glyph_item">
/// the glyph item to iterate over
/// </param>
/// <param name="text">
/// text corresponding to the glyph item
/// </param>
/// <return>
/// %FALSE if there are no clusters in the glyph item
/// </return>

	public static bool InitEnd(this MentorLake.Pango.PangoGlyphItemIterHandle iter, MentorLake.Pango.PangoGlyphItemHandle glyph_item, string text)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoGlyphItemIter)");
		return PangoGlyphItemIterExterns.pango_glyph_item_iter_init_end(iter, glyph_item, text);
	}

/// <summary>
/// <para>
/// Initializes a `PangoGlyphItemIter` structure to point to the
/// first cluster in a glyph item.
/// </para>
/// <para>
/// See `PangoGlyphItemIter` for details of cluster orders.
/// </para>
/// </summary>

/// <param name="iter">
/// a `PangoGlyphItemIter`
/// </param>
/// <param name="glyph_item">
/// the glyph item to iterate over
/// </param>
/// <param name="text">
/// text corresponding to the glyph item
/// </param>
/// <return>
/// %FALSE if there are no clusters in the glyph item
/// </return>

	public static bool InitStart(this MentorLake.Pango.PangoGlyphItemIterHandle iter, MentorLake.Pango.PangoGlyphItemHandle glyph_item, string text)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoGlyphItemIter)");
		return PangoGlyphItemIterExterns.pango_glyph_item_iter_init_start(iter, glyph_item, text);
	}

/// <summary>
/// <para>
/// Advances the iterator to the next cluster in the glyph item.
/// </para>
/// <para>
/// See `PangoGlyphItemIter` for details of cluster orders.
/// </para>
/// </summary>

/// <param name="iter">
/// a `PangoGlyphItemIter`
/// </param>
/// <return>
/// %TRUE if the iterator was advanced,
///   %FALSE if we were already on the  last cluster.
/// </return>

	public static bool NextCluster(this MentorLake.Pango.PangoGlyphItemIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoGlyphItemIter)");
		return PangoGlyphItemIterExterns.pango_glyph_item_iter_next_cluster(iter);
	}

/// <summary>
/// <para>
/// Moves the iterator to the preceding cluster in the glyph item.
/// See `PangoGlyphItemIter` for details of cluster orders.
/// </para>
/// </summary>

/// <param name="iter">
/// a `PangoGlyphItemIter`
/// </param>
/// <return>
/// %TRUE if the iterator was moved,
///   %FALSE if we were already on the first cluster.
/// </return>

	public static bool PrevCluster(this MentorLake.Pango.PangoGlyphItemIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoGlyphItemIter)");
		return PangoGlyphItemIterExterns.pango_glyph_item_iter_prev_cluster(iter);
	}


	public static PangoGlyphItemIter Dereference(this PangoGlyphItemIterHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoGlyphItemIter>(x.DangerousGetHandle());
}
internal class PangoGlyphItemIterExterns
{
	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphItemIterHandle>))]
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

/// <summary>
/// <para>
/// A `PangoGlyphItemIter` is an iterator over the clusters in a
/// `PangoGlyphItem`.
/// </para>
/// <para>
/// The *forward direction* of the iterator is the logical direction of text.
/// That is, with increasing @start_index and @start_char values. If @glyph_item
/// is right-to-left (that is, if `glyph_item->item->analysis.level` is odd),
/// then @start_glyph decreases as the iterator moves forward.  Moreover,
/// in right-to-left cases, @start_glyph is greater than @end_glyph.
/// </para>
/// <para>
/// An iterator should be initialized using either
/// pango_glyph_item_iter_init_start() or
/// pango_glyph_item_iter_init_end(), for forward and backward iteration
/// respectively, and walked over using any desired mixture of
/// pango_glyph_item_iter_next_cluster() and
/// pango_glyph_item_iter_prev_cluster().
/// </para>
/// <para>
/// A common idiom for doing a forward iteration over the clusters is:
/// </para>
/// <para>
/// ```
/// PangoGlyphItemIter cluster_iter;
/// gboolean have_cluster;
/// </para>
/// <para>
/// for (have_cluster = pango_glyph_item_iter_init_start (&cluster_iter,
///                                                       glyph_item, text);
///      have_cluster;
///      have_cluster = pango_glyph_item_iter_next_cluster (&cluster_iter))
/// {
///   ...
/// }
/// ```
/// </para>
/// <para>
/// Note that @text is the start of the text for layout, which is then
/// indexed by `glyph_item->item->offset` to get to the text of @glyph_item.
/// The @start_index and @end_index values can directly index into @text. The
/// @start_glyph, @end_glyph, @start_char, and @end_char values however are
/// zero-based for the @glyph_item.  For each cluster, the item pointed at by
/// the start variables is included in the cluster while the one pointed at by
/// end variables is not.
/// </para>
/// <para>
/// None of the members of a `PangoGlyphItemIter` should be modified manually.
/// </para>
/// </summary>

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
