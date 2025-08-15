namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GThemedIcon` is an implementation of [iface@Gio.Icon] that supports icon
/// themes.
/// </para>
/// <para>
/// `GThemedIcon` contains a list of all of the icons present in an icon
/// theme, so that icons can be looked up quickly. `GThemedIcon` does
/// not provide actual pixmaps for icons, just the icon names.
/// Ideally something like [method@Gtk.IconTheme.choose_icon] should be used to
/// resolve the list of names so that fallback icons work nicely with
/// themes that inherit other themes.
/// </para>
/// </summary>

public class GThemedIconHandle : GObjectHandle, GIconHandle
{
/// <summary>
/// <para>
/// Creates a new themed icon for @iconname.
/// </para>
/// </summary>

/// <param name="iconname">
/// a string containing an icon name.
/// </param>
/// <return>
/// a new #GThemedIcon.
/// </return>

	public static MentorLake.Gio.GThemedIconHandle New(string iconname)
	{
		return GThemedIconHandleExterns.g_themed_icon_new(iconname);
	}

/// <summary>
/// <para>
/// Creates a new themed icon for @iconnames.
/// </para>
/// </summary>

/// <param name="iconnames">
/// an array of strings containing icon names.
/// </param>
/// <param name="len">
/// the length of the @iconnames array, or -1 if @iconnames is
///     %NULL-terminated
/// </param>
/// <return>
/// a new #GThemedIcon
/// </return>

	public static MentorLake.Gio.GThemedIconHandle NewFromNames(string[] iconnames, int len)
	{
		return GThemedIconHandleExterns.g_themed_icon_new_from_names(iconnames, len);
	}

/// <summary>
/// <para>
/// Creates a new themed icon for @iconname, and all the names
/// that can be created by shortening @iconname at &apos;-&apos; characters.
/// </para>
/// <para>
/// In the following example, @icon1 and @icon2 are equivalent:
/// <code>
/// const char *names[] = {
/// const char *names[] = {
///   &quot;gnome-dev-cdrom-audio&quot;,
///   &quot;gnome-dev-cdrom&quot;,
///   &quot;gnome-dev&quot;,
///   &quot;gnome&quot;
/// };
/// 
/// icon1 = g_themed_icon_new_from_names (names, 4);
/// icon2 = g_themed_icon_new_with_default_fallbacks (&quot;gnome-dev-cdrom-audio&quot;);
/// </code>
/// </para>
/// </summary>

/// <param name="iconname">
/// a string containing an icon name
/// </param>
/// <return>
/// a new #GThemedIcon.
/// </return>

	public static MentorLake.Gio.GThemedIconHandle NewWithDefaultFallbacks(string iconname)
	{
		return GThemedIconHandleExterns.g_themed_icon_new_with_default_fallbacks(iconname);
	}

}

public static class GThemedIconHandleExtensions
{
/// <summary>
/// <para>
/// Append a name to the list of icons from within @icon.
/// </para>
/// <para>
/// Note that doing so invalidates the hash computed by prior calls
/// to g_icon_hash().
/// </para>
/// </summary>

/// <param name="icon">
/// a #GThemedIcon
/// </param>
/// <param name="iconname">
/// name of icon to append to list of icons from within @icon.
/// </param>

	public static T AppendName<T>(this T icon, string iconname) where T : GThemedIconHandle
	{
		if (icon.IsInvalid) throw new Exception("Invalid handle (GThemedIconHandle)");
		GThemedIconHandleExterns.g_themed_icon_append_name(icon, iconname);
		return icon;
	}

/// <summary>
/// <para>
/// Gets the names of icons from within @icon.
/// </para>
/// </summary>

/// <param name="icon">
/// a #GThemedIcon.
/// </param>
/// <return>
/// a list of icon names.
/// </return>

	public static string[] GetNames(this MentorLake.Gio.GThemedIconHandle icon)
	{
		if (icon.IsInvalid) throw new Exception("Invalid handle (GThemedIconHandle)");
		return GThemedIconHandleExterns.g_themed_icon_get_names(icon);
	}

/// <summary>
/// <para>
/// Prepend a name to the list of icons from within @icon.
/// </para>
/// <para>
/// Note that doing so invalidates the hash computed by prior calls
/// to g_icon_hash().
/// </para>
/// </summary>

/// <param name="icon">
/// a #GThemedIcon
/// </param>
/// <param name="iconname">
/// name of icon to prepend to list of icons from within @icon.
/// </param>

	public static T PrependName<T>(this T icon, string iconname) where T : GThemedIconHandle
	{
		if (icon.IsInvalid) throw new Exception("Invalid handle (GThemedIconHandle)");
		GThemedIconHandleExterns.g_themed_icon_prepend_name(icon, iconname);
		return icon;
	}

}

internal class GThemedIconHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GThemedIconHandle>))]
	internal static extern MentorLake.Gio.GThemedIconHandle g_themed_icon_new(string iconname);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GThemedIconHandle>))]
	internal static extern MentorLake.Gio.GThemedIconHandle g_themed_icon_new_from_names(string[] iconnames, int len);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GThemedIconHandle>))]
	internal static extern MentorLake.Gio.GThemedIconHandle g_themed_icon_new_with_default_fallbacks(string iconname);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_themed_icon_append_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GThemedIconHandle>))] MentorLake.Gio.GThemedIconHandle icon, string iconname);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_themed_icon_get_names([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GThemedIconHandle>))] MentorLake.Gio.GThemedIconHandle icon);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_themed_icon_prepend_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GThemedIconHandle>))] MentorLake.Gio.GThemedIconHandle icon, string iconname);

}
