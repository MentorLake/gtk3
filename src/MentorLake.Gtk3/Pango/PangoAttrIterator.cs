namespace MentorLake.Pango;

/// <summary>
/// <para>
/// A `PangoAttrIterator` is used to iterate through a `PangoAttrList`.
/// </para>
/// <para>
/// A new iterator is created with [method@Pango.AttrList.get_iterator].
/// Once the iterator is created, it can be advanced through the style
/// changes in the text using [method@Pango.AttrIterator.next]. At each
/// style change, the range of the current style segment and the attributes
/// currently in effect can be queried.
/// </para>
/// </summary>

public class PangoAttrIteratorHandle : BaseSafeHandle
{
}


public static class PangoAttrIteratorExtensions
{
/// <summary>
/// <para>
/// Copy a `PangoAttrIterator`.
/// </para>
/// </summary>

/// <param name="iterator">
/// a `PangoAttrIterator`
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttrIterator`, which should be freed with
///   [method@Pango.AttrIterator.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttrIteratorHandle Copy(this MentorLake.Pango.PangoAttrIteratorHandle iterator)
	{
		if (iterator.IsInvalid) throw new Exception("Invalid handle (PangoAttrIterator)");
		return PangoAttrIteratorExterns.pango_attr_iterator_copy(iterator);
	}

/// <summary>
/// <para>
/// Destroy a `PangoAttrIterator` and free all associated memory.
/// </para>
/// </summary>

/// <param name="iterator">
/// a `PangoAttrIterator`
/// </param>

	public static void Destroy(this MentorLake.Pango.PangoAttrIteratorHandle iterator)
	{
		if (iterator.IsInvalid) throw new Exception("Invalid handle (PangoAttrIterator)");
		PangoAttrIteratorExterns.pango_attr_iterator_destroy(iterator);
	}

/// <summary>
/// <para>
/// Find the current attribute of a particular type
/// at the iterator location.
/// </para>
/// <para>
/// When multiple attributes of the same type overlap,
/// the attribute whose range starts closest to the
/// current location is used.
/// </para>
/// </summary>

/// <param name="iterator">
/// a `PangoAttrIterator`
/// </param>
/// <param name="type">
/// the type of attribute to find
/// </param>
/// <return>
/// the current
///   attribute of the given type, or %NULL if no attribute
///   of that type applies to the current location.
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle Get(this MentorLake.Pango.PangoAttrIteratorHandle iterator, MentorLake.Pango.PangoAttrType type)
	{
		if (iterator.IsInvalid) throw new Exception("Invalid handle (PangoAttrIterator)");
		return PangoAttrIteratorExterns.pango_attr_iterator_get(iterator, type);
	}

/// <summary>
/// <para>
/// Gets a list of all attributes at the current position of the
/// iterator.
/// </para>
/// </summary>

/// <param name="iterator">
/// a `PangoAttrIterator`
/// </param>
/// <return>
/// 
///   a list of all attributes for the current range. To free
///   this value, call [method@Pango.Attribute.destroy] on each
///   value and g_slist_free() on the list.
/// </return>

	public static MentorLake.GLib.GSListHandle GetAttrs(this MentorLake.Pango.PangoAttrIteratorHandle iterator)
	{
		if (iterator.IsInvalid) throw new Exception("Invalid handle (PangoAttrIterator)");
		return PangoAttrIteratorExterns.pango_attr_iterator_get_attrs(iterator);
	}

/// <summary>
/// <para>
/// Get the font and other attributes at the current
/// iterator position.
/// </para>
/// </summary>

/// <param name="iterator">
/// a `PangoAttrIterator`
/// </param>
/// <param name="desc">
/// a `PangoFontDescription` to fill in with the current
///   values. The family name in this structure will be set using
///   [method@Pango.FontDescription.set_family_static] using
///   values from an attribute in the `PangoAttrList` associated
///   with the iterator, so if you plan to keep it around, you
///   must call:
///   `pango_font_description_set_family (desc, pango_font_description_get_family (desc))`.
/// </param>
/// <param name="language">
/// location to store language tag
///   for item, or %NULL if none is found.
/// </param>
/// <param name="extra_attrs">
/// 
///   location in which to store a list of non-font attributes
///   at the the current position; only the highest priority
///   value of each attribute will be added to this list. In
///   order to free this value, you must call
///   [method@Pango.Attribute.destroy] on each member.
/// </param>

	public static void GetFont(this MentorLake.Pango.PangoAttrIteratorHandle iterator, MentorLake.Pango.PangoFontDescriptionHandle desc, out MentorLake.Pango.PangoLanguageHandle language, out MentorLake.GLib.GSListHandle extra_attrs)
	{
		if (iterator.IsInvalid) throw new Exception("Invalid handle (PangoAttrIterator)");
		PangoAttrIteratorExterns.pango_attr_iterator_get_font(iterator, desc, out language, out extra_attrs);
	}

/// <summary>
/// <para>
/// Advance the iterator until the next change of style.
/// </para>
/// </summary>

/// <param name="iterator">
/// a `PangoAttrIterator`
/// </param>
/// <return>
/// %FALSE if the iterator is at the end
///   of the list, otherwise %TRUE
/// </return>

	public static bool Next(this MentorLake.Pango.PangoAttrIteratorHandle iterator)
	{
		if (iterator.IsInvalid) throw new Exception("Invalid handle (PangoAttrIterator)");
		return PangoAttrIteratorExterns.pango_attr_iterator_next(iterator);
	}

/// <summary>
/// <para>
/// Get the range of the current segment.
/// </para>
/// <para>
/// Note that the stored return values are signed, not unsigned
/// like the values in `PangoAttribute`. To deal with this API
/// oversight, stored return values that wouldn&apos;t fit into
/// a signed integer are clamped to %G_MAXINT.
/// </para>
/// </summary>

/// <param name="iterator">
/// a PangoAttrIterator
/// </param>
/// <param name="start">
/// location to store the start of the range
/// </param>
/// <param name="end">
/// location to store the end of the range
/// </param>

	public static void Range(this MentorLake.Pango.PangoAttrIteratorHandle iterator, out int start, out int end)
	{
		if (iterator.IsInvalid) throw new Exception("Invalid handle (PangoAttrIterator)");
		PangoAttrIteratorExterns.pango_attr_iterator_range(iterator, out start, out end);
	}


	public static PangoAttrIterator Dereference(this PangoAttrIteratorHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoAttrIterator>(x.DangerousGetHandle());
}
internal class PangoAttrIteratorExterns
{
	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrIteratorHandle>))]
	internal static extern MentorLake.Pango.PangoAttrIteratorHandle pango_attr_iterator_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrIteratorHandle>))] MentorLake.Pango.PangoAttrIteratorHandle iterator);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_attr_iterator_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrIteratorHandle>))] MentorLake.Pango.PangoAttrIteratorHandle iterator);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_iterator_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrIteratorHandle>))] MentorLake.Pango.PangoAttrIteratorHandle iterator, MentorLake.Pango.PangoAttrType type);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle pango_attr_iterator_get_attrs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrIteratorHandle>))] MentorLake.Pango.PangoAttrIteratorHandle iterator);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_attr_iterator_get_font([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrIteratorHandle>))] MentorLake.Pango.PangoAttrIteratorHandle iterator, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLanguageHandle>))] out MentorLake.Pango.PangoLanguageHandle language, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] out MentorLake.GLib.GSListHandle extra_attrs);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_attr_iterator_next([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrIteratorHandle>))] MentorLake.Pango.PangoAttrIteratorHandle iterator);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_attr_iterator_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrIteratorHandle>))] MentorLake.Pango.PangoAttrIteratorHandle iterator, out int start, out int end);

}

/// <summary>
/// <para>
/// A `PangoAttrIterator` is used to iterate through a `PangoAttrList`.
/// </para>
/// <para>
/// A new iterator is created with [method@Pango.AttrList.get_iterator].
/// Once the iterator is created, it can be advanced through the style
/// changes in the text using [method@Pango.AttrIterator.next]. At each
/// style change, the range of the current style segment and the attributes
/// currently in effect can be queried.
/// </para>
/// </summary>

public struct PangoAttrIterator
{
}
