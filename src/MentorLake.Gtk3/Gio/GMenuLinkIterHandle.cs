namespace MentorLake.Gio;

/// <summary>
/// <para>
/// #GMenuLinkIter is an opaque structure type.  You must access it using
/// the functions below.
/// </para>
/// </summary>

public class GMenuLinkIterHandle : GObjectHandle
{
}

public static class GMenuLinkIterHandleExtensions
{
/// <summary>
/// <para>
/// Gets the name of the link at the current iterator position.
/// </para>
/// <para>
/// The iterator is not advanced.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GMenuLinkIter
/// </param>
/// <return>
/// the type of the link
/// </return>

	public static string GetName(this MentorLake.Gio.GMenuLinkIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GMenuLinkIterHandle)");
		return GMenuLinkIterHandleExterns.g_menu_link_iter_get_name(iter);
	}

/// <summary>
/// <para>
/// This function combines g_menu_link_iter_next() with
/// g_menu_link_iter_get_name() and g_menu_link_iter_get_value().
/// </para>
/// <para>
/// First the iterator is advanced to the next (possibly first) link.
/// If that fails, then %FALSE is returned and there are no other effects.
/// </para>
/// <para>
/// If successful, @out_link and @value are set to the name and #GMenuModel
/// of the link that has just been advanced to.  At this point,
/// g_menu_link_iter_get_name() and g_menu_link_iter_get_value() will return the
/// same values again.
/// </para>
/// <para>
/// The value returned in @out_link remains valid for as long as the iterator
/// remains at the current position.  The value returned in @value must
/// be unreffed using g_object_unref() when it is no longer in use.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GMenuLinkIter
/// </param>
/// <param name="out_link">
/// the name of the link
/// </param>
/// <param name="value">
/// the linked #GMenuModel
/// </param>
/// <return>
/// %TRUE on success, or %FALSE if there is no additional link
/// </return>

	public static bool GetNext(this MentorLake.Gio.GMenuLinkIterHandle iter, out string out_link, out MentorLake.Gio.GMenuModelHandle value)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GMenuLinkIterHandle)");
		return GMenuLinkIterHandleExterns.g_menu_link_iter_get_next(iter, out out_link, out value);
	}

/// <summary>
/// <para>
/// Gets the linked #GMenuModel at the current iterator position.
/// </para>
/// <para>
/// The iterator is not advanced.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GMenuLinkIter
/// </param>
/// <return>
/// the #GMenuModel that is linked to
/// </return>

	public static MentorLake.Gio.GMenuModelHandle GetValue(this MentorLake.Gio.GMenuLinkIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GMenuLinkIterHandle)");
		return GMenuLinkIterHandleExterns.g_menu_link_iter_get_value(iter);
	}

/// <summary>
/// <para>
/// Attempts to advance the iterator to the next (possibly first)
/// link.
/// </para>
/// <para>
/// %TRUE is returned on success, or %FALSE if there are no more links.
/// </para>
/// <para>
/// You must call this function when you first acquire the iterator to
/// advance it to the first link (and determine if the first link exists
/// at all).
/// </para>
/// </summary>

/// <param name="iter">
/// a #GMenuLinkIter
/// </param>
/// <return>
/// %TRUE on success, or %FALSE when there are no more links
/// </return>

	public static bool Next(this MentorLake.Gio.GMenuLinkIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GMenuLinkIterHandle)");
		return GMenuLinkIterHandleExterns.g_menu_link_iter_next(iter);
	}

}

internal class GMenuLinkIterHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_menu_link_iter_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuLinkIterHandle>))] MentorLake.Gio.GMenuLinkIterHandle iter);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_menu_link_iter_get_next([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuLinkIterHandle>))] MentorLake.Gio.GMenuLinkIterHandle iter, out string out_link, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] out MentorLake.Gio.GMenuModelHandle value);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))]
	internal static extern MentorLake.Gio.GMenuModelHandle g_menu_link_iter_get_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuLinkIterHandle>))] MentorLake.Gio.GMenuLinkIterHandle iter);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_menu_link_iter_next([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuLinkIterHandle>))] MentorLake.Gio.GMenuLinkIterHandle iter);

}
