namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GIcon` is a very minimal interface for icons. It provides functions
/// for checking the equality of two icons, hashing of icons and
/// serializing an icon to and from strings.
/// </para>
/// <para>
/// `GIcon` does not provide the actual pixmap for the icon as this is out
/// of GIO&apos;s scope, however implementations of `GIcon` may contain the name
/// of an icon (see [class@Gio.ThemedIcon]), or the path to an icon
/// (see [iface@Gio.LoadableIcon]).
/// </para>
/// <para>
/// To obtain a hash of a `GIcon`, see [method@Gio.Icon.hash].
/// </para>
/// <para>
/// To check if two `GIcon`s are equal, see [method@Gio.Icon.equal].
/// </para>
/// <para>
/// For serializing a `GIcon`, use [method@Gio.Icon.serialize] and
/// [func@Gio.Icon.deserialize].
/// </para>
/// <para>
/// If you want to consume `GIcon` (for example, in a toolkit) you must
/// be prepared to handle at least the three following cases:
/// [iface@Gio.LoadableIcon], [class@Gio.ThemedIcon] and [class@Gio.EmblemedIcon].
/// It may also make sense to have fast-paths for other cases (like handling
/// &amp;lt;see href=&quot;https://docs.gtk.org/gdk-pixbuf/class.Pixbuf.html&quot;&amp;gt;GdkPixbuf&amp;lt;/see&amp;gt; directly,
/// for example) but all compliant `GIcon` implementations outside of GIO must
/// implement [iface@Gio.LoadableIcon].
/// </para>
/// <para>
/// If your application or library provides one or more `GIcon`
/// implementations you need to ensure that your new implementation also
/// implements [iface@Gio.LoadableIcon].  Additionally, you must provide an
/// implementation of [method@Gio.Icon.serialize] that gives a result that is
/// understood by [func@Gio.Icon.deserialize], yielding one of the built-in
/// icon types.
/// </para>
/// </summary>

public interface GIconHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GIconHandleImpl : BaseSafeHandle, GIconHandle
{
}

public static class GIconHandleExtensions
{
/// <summary>
/// <para>
/// Checks if two icons are equal.
/// </para>
/// </summary>

/// <param name="icon1">
/// pointer to the first #GIcon.
/// </param>
/// <param name="icon2">
/// pointer to the second #GIcon.
/// </param>
/// <return>
/// %TRUE if @icon1 is equal to @icon2. %FALSE otherwise.
/// </return>

	public static bool Equal(this MentorLake.Gio.GIconHandle icon1, MentorLake.Gio.GIconHandle icon2)
	{
		if (icon1.IsInvalid) throw new Exception("Invalid handle (GIconHandle)");
		return GIconHandleExterns.g_icon_equal(icon1, icon2);
	}

/// <summary>
/// <para>
/// Gets a hash for an icon.
/// </para>
/// </summary>

/// <param name="icon">
/// #gconstpointer to an icon object.
/// </param>
/// <return>
/// a #guint containing a hash for the @icon, suitable for
///   use in a #GHashTable or similar data structure.
/// </return>

	public static uint Hash(this MentorLake.Gio.GIconHandle icon)
	{
		if (icon.IsInvalid) throw new Exception("Invalid handle (GIconHandle)");
		return GIconHandleExterns.g_icon_hash(icon);
	}

/// <summary>
/// <para>
/// Serializes a #GIcon into a #GVariant. An equivalent #GIcon can be retrieved
/// back by calling g_icon_deserialize() on the returned value.
/// As serialization will avoid using raw icon data when possible, it only
/// makes sense to transfer the #GVariant between processes on the same machine,
/// (as opposed to over the network), and within the same file system namespace.
/// </para>
/// </summary>

/// <param name="icon">
/// a #GIcon
/// </param>
/// <return>
/// a #GVariant, or %NULL when serialization fails. The #GVariant will not be floating.
/// </return>

	public static MentorLake.GLib.GVariantHandle Serialize(this MentorLake.Gio.GIconHandle icon)
	{
		if (icon.IsInvalid) throw new Exception("Invalid handle (GIconHandle)");
		return GIconHandleExterns.g_icon_serialize(icon);
	}

/// <summary>
/// <para>
/// Generates a textual representation of @icon that can be used for
/// serialization such as when passing @icon to a different process or
/// saving it to persistent storage. Use g_icon_new_for_string() to
/// get @icon back from the returned string.
/// </para>
/// <para>
/// The encoding of the returned string is proprietary to #GIcon except
/// in the following two cases
/// </para>
/// <para>
/// - If @icon is a #GFileIcon, the returned string is a native path
///   (such as `/path/to/my icon.png`) without escaping
///   if the #GFile for @icon is a native file.  If the file is not
///   native, the returned string is the result of g_file_get_uri()
///   (such as `sftp://path/to/my%20icon.png`).
/// </para>
/// <para>
/// - If @icon is a #GThemedIcon with exactly one name and no fallbacks,
///   the encoding is simply the name (such as `network-server`).
/// </para>
/// </summary>

/// <param name="icon">
/// a #GIcon.
/// </param>
/// <return>
/// An allocated NUL-terminated UTF8 string or
/// %NULL if @icon can&apos;t be serialized. Use g_free() to free.
/// </return>

	public static string ToString(this MentorLake.Gio.GIconHandle icon)
	{
		if (icon.IsInvalid) throw new Exception("Invalid handle (GIconHandle)");
		return GIconHandleExterns.g_icon_to_string(icon);
	}

/// <summary>
/// <para>
/// Deserializes a #GIcon previously serialized using g_icon_serialize().
/// </para>
/// </summary>

/// <param name="value">
/// a #GVariant created with g_icon_serialize()
/// </param>
/// <return>
/// a #GIcon, or %NULL when deserialization fails.
/// </return>

	public static MentorLake.Gio.GIconHandle Deserialize(MentorLake.GLib.GVariantHandle value)
	{
		return GIconHandleExterns.g_icon_deserialize(value);
	}

/// <summary>
/// <para>
/// Generate a #GIcon instance from @str. This function can fail if
/// @str is not valid - see g_icon_to_string() for discussion.
/// </para>
/// <para>
/// If your application or library provides one or more #GIcon
/// implementations you need to ensure that each #GType is registered
/// with the type system prior to calling g_icon_new_for_string().
/// </para>
/// </summary>

/// <param name="str">
/// A string obtained via g_icon_to_string().
/// </param>
/// <return>
/// An object implementing the #GIcon
///          interface or %NULL if @error is set.
/// </return>

	public static MentorLake.Gio.GIconHandle NewForString(string str)
	{
		var externCallResult = GIconHandleExterns.g_icon_new_for_string(str, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class GIconHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern bool g_icon_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon2);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_icon_hash([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_icon_serialize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_icon_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))]
	internal static extern MentorLake.Gio.GIconHandle g_icon_deserialize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))]
	internal static extern MentorLake.Gio.GIconHandle g_icon_new_for_string(string str, out MentorLake.GLib.GErrorHandle error);

}
