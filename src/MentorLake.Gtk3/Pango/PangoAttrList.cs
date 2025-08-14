namespace MentorLake.Pango;

/// <summary>
/// <para>
/// A `PangoAttrList` represents a list of attributes that apply to a section
/// of text.
/// </para>
/// <para>
/// The attributes in a `PangoAttrList` are, in general, allowed to overlap in
/// an arbitrary fashion. However, if the attributes are manipulated only through
/// [method@Pango.AttrList.change], the overlap between properties will meet
/// stricter criteria.
/// </para>
/// <para>
/// Since the `PangoAttrList` structure is stored as a linear list, it is not
/// suitable for storing attributes for large amounts of text. In general, you
/// should not use a single `PangoAttrList` for more than one paragraph of text.
/// </para>
/// </summary>

public class PangoAttrListHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Create a new empty attribute list with a reference
/// count of one.
/// </para>
/// </summary>

/// <return>
/// the newly allocated
///   `PangoAttrList`, which should be freed with
///   [method@Pango.AttrList.unref]
/// </return>

	public static MentorLake.Pango.PangoAttrListHandle New()
	{
		return PangoAttrListExterns.pango_attr_list_new();
	}

}


public static class PangoAttrListExtensions
{
/// <summary>
/// <para>
/// Insert the given attribute into the `PangoAttrList`.
/// </para>
/// <para>
/// It will replace any attributes of the same type
/// on that segment and be merged with any adjoining
/// attributes that are identical.
/// </para>
/// <para>
/// This function is slower than [method@Pango.AttrList.insert]
/// for creating an attribute list in order (potentially
/// much slower for large lists). However,
/// [method@Pango.AttrList.insert] is not suitable for
/// continually changing a set of attributes since it
/// never removes or combines existing attributes.
/// </para>
/// </summary>

/// <param name="list">
/// a `PangoAttrList`
/// </param>
/// <param name="attr">
/// the attribute to insert
/// </param>

	public static void Change(this MentorLake.Pango.PangoAttrListHandle list, MentorLake.Pango.PangoAttributeHandle attr)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (PangoAttrList)");
		PangoAttrListExterns.pango_attr_list_change(list, attr);
	}

/// <summary>
/// <para>
/// Copy @list and return an identical new list.
/// </para>
/// </summary>

/// <param name="list">
/// a `PangoAttrList`
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttrList`, with a reference count of one,
///   which should be freed with [method@Pango.AttrList.unref].
///   Returns %NULL if @list was %NULL.
/// </return>

	public static MentorLake.Pango.PangoAttrListHandle Copy(this MentorLake.Pango.PangoAttrListHandle list)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (PangoAttrList)");
		return PangoAttrListExterns.pango_attr_list_copy(list);
	}

/// <summary>
/// <para>
/// Checks whether @list and @other_list contain the same
/// attributes and whether those attributes apply to the
/// same ranges.
/// </para>
/// <para>
/// Beware that this will return wrong values if any list
/// contains duplicates.
/// </para>
/// </summary>

/// <param name="list">
/// a `PangoAttrList`
/// </param>
/// <param name="other_list">
/// the other `PangoAttrList`
/// </param>
/// <return>
/// %TRUE if the lists are equal, %FALSE if
///   they aren't
/// </return>

	public static bool Equal(this MentorLake.Pango.PangoAttrListHandle list, MentorLake.Pango.PangoAttrListHandle other_list)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (PangoAttrList)");
		return PangoAttrListExterns.pango_attr_list_equal(list, other_list);
	}

/// <summary>
/// <para>
/// Given a `PangoAttrList` and callback function, removes
/// any elements of @list for which @func returns %TRUE and
/// inserts them into a new list.
/// </para>
/// </summary>

/// <param name="list">
/// a `PangoAttrList`
/// </param>
/// <param name="func">
/// callback function;
///   returns %TRUE if an attribute should be filtered out
/// </param>
/// <param name="data">
/// Data to be passed to @func
/// </param>
/// <return>
/// the new
///   `PangoAttrList` or %NULL if no attributes of the
///   given types were found
/// </return>

	public static MentorLake.Pango.PangoAttrListHandle Filter(this MentorLake.Pango.PangoAttrListHandle list, MentorLake.Pango.PangoAttrFilterFunc func, IntPtr data)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (PangoAttrList)");
		return PangoAttrListExterns.pango_attr_list_filter(list, func, data);
	}

/// <summary>
/// <para>
/// Gets a list of all attributes in @list.
/// </para>
/// </summary>

/// <param name="list">
/// a `PangoAttrList`
/// </param>
/// <return>
/// 
///   a list of all attributes in @list. To free this value,
///   call [method@Pango.Attribute.destroy] on each value and
///   g_slist_free() on the list.
/// </return>

	public static MentorLake.GLib.GSListHandle GetAttributes(this MentorLake.Pango.PangoAttrListHandle list)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (PangoAttrList)");
		return PangoAttrListExterns.pango_attr_list_get_attributes(list);
	}

/// <summary>
/// <para>
/// Create a iterator initialized to the beginning of the list.
/// </para>
/// <para>
/// @list must not be modified until this iterator is freed.
/// </para>
/// </summary>

/// <param name="list">
/// a `PangoAttrList`
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttrIterator`, which should be freed with
///   [method@Pango.AttrIterator.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttrIteratorHandle GetIterator(this MentorLake.Pango.PangoAttrListHandle list)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (PangoAttrList)");
		return PangoAttrListExterns.pango_attr_list_get_iterator(list);
	}

/// <summary>
/// <para>
/// Insert the given attribute into the `PangoAttrList`.
/// </para>
/// <para>
/// It will be inserted after all other attributes with a
/// matching @start_index.
/// </para>
/// </summary>

/// <param name="list">
/// a `PangoAttrList`
/// </param>
/// <param name="attr">
/// the attribute to insert
/// </param>

	public static void Insert(this MentorLake.Pango.PangoAttrListHandle list, MentorLake.Pango.PangoAttributeHandle attr)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (PangoAttrList)");
		PangoAttrListExterns.pango_attr_list_insert(list, attr);
	}

/// <summary>
/// <para>
/// Insert the given attribute into the `PangoAttrList`.
/// </para>
/// <para>
/// It will be inserted before all other attributes with a
/// matching @start_index.
/// </para>
/// </summary>

/// <param name="list">
/// a `PangoAttrList`
/// </param>
/// <param name="attr">
/// the attribute to insert
/// </param>

	public static void InsertBefore(this MentorLake.Pango.PangoAttrListHandle list, MentorLake.Pango.PangoAttributeHandle attr)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (PangoAttrList)");
		PangoAttrListExterns.pango_attr_list_insert_before(list, attr);
	}

/// <summary>
/// <para>
/// Increase the reference count of the given attribute
/// list by one.
/// </para>
/// </summary>

/// <param name="list">
/// a `PangoAttrList`
/// </param>
/// <return>
/// The attribute list passed in
/// </return>

	public static MentorLake.Pango.PangoAttrListHandle Ref(this MentorLake.Pango.PangoAttrListHandle list)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (PangoAttrList)");
		return PangoAttrListExterns.pango_attr_list_ref(list);
	}

/// <summary>
/// <para>
/// This function opens up a hole in @list, fills it
/// in with attributes from the left, and then merges
/// @other on top of the hole.
/// </para>
/// <para>
/// This operation is equivalent to stretching every attribute
/// that applies at position @pos in @list by an amount @len,
/// and then calling [method@Pango.AttrList.change] with a copy
/// of each attribute in @other in sequence (offset in position
/// by @pos, and limited in length to @len).
/// </para>
/// <para>
/// This operation proves useful for, for instance, inserting
/// a pre-edit string in the middle of an edit buffer.
/// </para>
/// <para>
/// For backwards compatibility, the function behaves differently
/// when @len is 0. In this case, the attributes from @other are
/// not imited to @len, and are just overlayed on top of @list.
/// </para>
/// <para>
/// This mode is useful for merging two lists of attributes together.
/// </para>
/// </summary>

/// <param name="list">
/// a `PangoAttrList`
/// </param>
/// <param name="other">
/// another `PangoAttrList`
/// </param>
/// <param name="pos">
/// the position in @list at which to insert @other
/// </param>
/// <param name="len">
/// the length of the spliced segment. (Note that this
///   must be specified since the attributes in @other may only
///   be present at some subsection of this range)
/// </param>

	public static void Splice(this MentorLake.Pango.PangoAttrListHandle list, MentorLake.Pango.PangoAttrListHandle other, int pos, int len)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (PangoAttrList)");
		PangoAttrListExterns.pango_attr_list_splice(list, other, pos, len);
	}

/// <summary>
/// <para>
/// Serializes a `PangoAttrList` to a string.
/// </para>
/// <para>
/// In the resulting string, serialized attributes are separated by newlines or commas.
/// Individual attributes are serialized to a string of the form
/// </para>
/// <para>
///     [START END] TYPE VALUE
/// </para>
/// <para>
/// Where START and END are the indices (with -1 being accepted in place
/// of MAXUINT), TYPE is the nickname of the attribute value type, e.g.
/// _weight_ or _stretch_, and the value is serialized according to its type:
/// </para>
/// <para>
/// Optionally, START and END can be omitted to indicate unlimited extent.
/// </para>
/// <para>
/// - enum values as nick or numeric value
/// - boolean values as _true_ or _false_
/// - integers and floats as numbers
/// - strings as string, optionally quoted
/// - font features as quoted string
/// - PangoLanguage as string
/// - PangoFontDescription as serialized by [method@Pango.FontDescription.to_string], quoted
/// - PangoColor as serialized by [method@Pango.Color.to_string]
/// </para>
/// <para>
/// Examples:
/// </para>
/// <para>
///     0 10 foreground red, 5 15 weight bold, 0 200 font-desc "Sans 10"
/// </para>
/// <para>
///     0 -1 weight 700
///     0 100 family Times
/// </para>
/// <para>
///     weight bold
/// </para>
/// <para>
/// To parse the returned value, use [func@Pango.AttrList.from_string].
/// </para>
/// <para>
/// Note that shape attributes can not be serialized.
/// </para>
/// </summary>

/// <param name="list">
/// a `PangoAttrList`
/// </param>
/// <return>
/// a newly allocated string
/// </return>

	public static string ToString(this MentorLake.Pango.PangoAttrListHandle list)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (PangoAttrList)");
		return PangoAttrListExterns.pango_attr_list_to_string(list);
	}

/// <summary>
/// <para>
/// Decrease the reference count of the given attribute
/// list by one.
/// </para>
/// <para>
/// If the result is zero, free the attribute list
/// and the attributes it contains.
/// </para>
/// </summary>

/// <param name="list">
/// a `PangoAttrList`
/// </param>

	public static void Unref(this MentorLake.Pango.PangoAttrListHandle list)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (PangoAttrList)");
		PangoAttrListExterns.pango_attr_list_unref(list);
	}

/// <summary>
/// <para>
/// Update indices of attributes in @list for a change in the
/// text they refer to.
/// </para>
/// <para>
/// The change that this function applies is removing @remove
/// bytes at position @pos and inserting @add bytes instead.
/// </para>
/// <para>
/// Attributes that fall entirely in the (@pos, @pos + @remove)
/// range are removed.
/// </para>
/// <para>
/// Attributes that start or end inside the (@pos, @pos + @remove)
/// range are shortened to reflect the removal.
/// </para>
/// <para>
/// Attributes start and end positions are updated if they are
/// behind @pos + @remove.
/// </para>
/// </summary>

/// <param name="list">
/// a `PangoAttrList`
/// </param>
/// <param name="pos">
/// the position of the change
/// </param>
/// <param name="remove">
/// the number of removed bytes
/// </param>
/// <param name="add">
/// the number of added bytes
/// </param>

	public static void Update(this MentorLake.Pango.PangoAttrListHandle list, int pos, int remove, int add)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (PangoAttrList)");
		PangoAttrListExterns.pango_attr_list_update(list, pos, remove, add);
	}


	public static PangoAttrList Dereference(this PangoAttrListHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoAttrList>(x.DangerousGetHandle());
}
internal class PangoAttrListExterns
{
	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))]
	internal static extern MentorLake.Pango.PangoAttrListHandle pango_attr_list_new();

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_attr_list_change([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))] MentorLake.Pango.PangoAttributeHandle attr);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))]
	internal static extern MentorLake.Pango.PangoAttrListHandle pango_attr_list_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle list);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_attr_list_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle other_list);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))]
	internal static extern MentorLake.Pango.PangoAttrListHandle pango_attr_list_filter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle list, MentorLake.Pango.PangoAttrFilterFunc func, IntPtr data);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle pango_attr_list_get_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle list);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrIteratorHandle>))]
	internal static extern MentorLake.Pango.PangoAttrIteratorHandle pango_attr_list_get_iterator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle list);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_attr_list_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))] MentorLake.Pango.PangoAttributeHandle attr);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_attr_list_insert_before([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))] MentorLake.Pango.PangoAttributeHandle attr);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))]
	internal static extern MentorLake.Pango.PangoAttrListHandle pango_attr_list_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle list);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_attr_list_splice([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle other, int pos, int len);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string pango_attr_list_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle list);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_attr_list_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle list);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_attr_list_update([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle list, int pos, int remove, int add);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))]
	internal static extern MentorLake.Pango.PangoAttrListHandle pango_attr_list_from_string(string text);

}

/// <summary>
/// <para>
/// A `PangoAttrList` represents a list of attributes that apply to a section
/// of text.
/// </para>
/// <para>
/// The attributes in a `PangoAttrList` are, in general, allowed to overlap in
/// an arbitrary fashion. However, if the attributes are manipulated only through
/// [method@Pango.AttrList.change], the overlap between properties will meet
/// stricter criteria.
/// </para>
/// <para>
/// Since the `PangoAttrList` structure is stored as a linear list, it is not
/// suitable for storing attributes for large amounts of text. In general, you
/// should not use a single `PangoAttrList` for more than one paragraph of text.
/// </para>
/// </summary>

public struct PangoAttrList
{
/// <summary>
/// <para>
/// Deserializes a `PangoAttrList` from a string.
/// </para>
/// <para>
/// This is the counterpart to [method@Pango.AttrList.to_string].
/// See that functions for details about the format.
/// </para>
/// </summary>

/// <param name="text">
/// a string
/// </param>
/// <return>
/// a new `PangoAttrList`
/// </return>

	public static MentorLake.Pango.PangoAttrListHandle FromString(string text)
	{
		return PangoAttrListExterns.pango_attr_list_from_string(text);
	}

}
