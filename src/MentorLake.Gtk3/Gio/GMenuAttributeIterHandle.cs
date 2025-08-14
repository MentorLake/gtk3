namespace MentorLake.Gio;

/// <summary>
/// <para>
/// #GMenuAttributeIter is an opaque structure type.  You must access it
/// using the functions below.
/// </para>
/// </summary>

public class GMenuAttributeIterHandle : GObjectHandle
{
}

public static class GMenuAttributeIterHandleExtensions
{
/// <summary>
/// <para>
/// Gets the name of the attribute at the current iterator position, as
/// a string.
/// </para>
/// <para>
/// The iterator is not advanced.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GMenuAttributeIter
/// </param>
/// <return>
/// the name of the attribute
/// </return>

	public static string GetName(this MentorLake.Gio.GMenuAttributeIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GMenuAttributeIterHandle)");
		return GMenuAttributeIterHandleExterns.g_menu_attribute_iter_get_name(iter);
	}

/// <summary>
/// <para>
/// This function combines g_menu_attribute_iter_next() with
/// g_menu_attribute_iter_get_name() and g_menu_attribute_iter_get_value().
/// </para>
/// <para>
/// First the iterator is advanced to the next (possibly first) attribute.
/// If that fails, then %FALSE is returned and there are no other
/// effects.
/// </para>
/// <para>
/// If successful, @name and @value are set to the name and value of the
/// attribute that has just been advanced to.  At this point,
/// g_menu_attribute_iter_get_name() and g_menu_attribute_iter_get_value() will
/// return the same values again.
/// </para>
/// <para>
/// The value returned in @name remains valid for as long as the iterator
/// remains at the current position.  The value returned in @value must
/// be unreffed using g_variant_unref() when it is no longer in use.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GMenuAttributeIter
/// </param>
/// <param name="out_name">
/// the type of the attribute
/// </param>
/// <param name="value">
/// the attribute value
/// </param>
/// <return>
/// %TRUE on success, or %FALSE if there is no additional
///     attribute
/// </return>

	public static bool GetNext(this MentorLake.Gio.GMenuAttributeIterHandle iter, out string out_name, out MentorLake.GLib.GVariantHandle value)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GMenuAttributeIterHandle)");
		return GMenuAttributeIterHandleExterns.g_menu_attribute_iter_get_next(iter, out out_name, out value);
	}

/// <summary>
/// <para>
/// Gets the value of the attribute at the current iterator position.
/// </para>
/// <para>
/// The iterator is not advanced.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GMenuAttributeIter
/// </param>
/// <return>
/// the value of the current attribute
/// </return>

	public static MentorLake.GLib.GVariantHandle GetValue(this MentorLake.Gio.GMenuAttributeIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GMenuAttributeIterHandle)");
		return GMenuAttributeIterHandleExterns.g_menu_attribute_iter_get_value(iter);
	}

/// <summary>
/// <para>
/// Attempts to advance the iterator to the next (possibly first)
/// attribute.
/// </para>
/// <para>
/// %TRUE is returned on success, or %FALSE if there are no more
/// attributes.
/// </para>
/// <para>
/// You must call this function when you first acquire the iterator
/// to advance it to the first attribute (and determine if the first
/// attribute exists at all).
/// </para>
/// </summary>

/// <param name="iter">
/// a #GMenuAttributeIter
/// </param>
/// <return>
/// %TRUE on success, or %FALSE when there are no more attributes
/// </return>

	public static bool Next(this MentorLake.Gio.GMenuAttributeIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GMenuAttributeIterHandle)");
		return GMenuAttributeIterHandleExterns.g_menu_attribute_iter_next(iter);
	}

}

internal class GMenuAttributeIterHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_menu_attribute_iter_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuAttributeIterHandle>))] MentorLake.Gio.GMenuAttributeIterHandle iter);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_menu_attribute_iter_get_next([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuAttributeIterHandle>))] MentorLake.Gio.GMenuAttributeIterHandle iter, out string out_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] out MentorLake.GLib.GVariantHandle value);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_menu_attribute_iter_get_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuAttributeIterHandle>))] MentorLake.Gio.GMenuAttributeIterHandle iter);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_menu_attribute_iter_next([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuAttributeIterHandle>))] MentorLake.Gio.GMenuAttributeIterHandle iter);

}
