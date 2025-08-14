namespace MentorLake.Gtk;


public class GtkIconSourceHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkIconSource. A #GtkIconSource contains a #GdkPixbuf (or
/// image filename) that serves as the base image for one or more of the
/// icons in a #GtkIconSet, along with a specification for which icons in the
/// icon set will be based on that pixbuf or image file. An icon set contains
/// a set of icons that represent “the same” logical concept in different states,
/// different global text directions, and different sizes.
/// </para>
/// <para>
/// So for example a web browser’s “Back to Previous Page” icon might
/// point in a different direction in Hebrew and in English; it might
/// look different when insensitive; and it might change size depending
/// on toolbar mode (small/large icons). So a single icon set would
/// contain all those variants of the icon. #GtkIconSet contains a list
/// of #GtkIconSource from which it can derive specific icon variants in
/// the set.
/// </para>
/// <para>
/// In the simplest case, #GtkIconSet contains one source pixbuf from
/// which it derives all variants. The convenience function
/// gtk_icon_set_new_from_pixbuf() handles this case; if you only have
/// one source pixbuf, just use that function.
/// </para>
/// <para>
/// If you want to use a different base pixbuf for different icon
/// variants, you create multiple icon sources, mark which variants
/// they’ll be used to create, and add them to the icon set with
/// gtk_icon_set_add_source().
/// </para>
/// <para>
/// By default, the icon source has all parameters wildcarded. That is,
/// the icon source will be used as the base icon for any desired text
/// direction, widget state, or icon size.
/// </para>
/// </summary>

/// <return>
/// a new #GtkIconSource
/// </return>

	public static MentorLake.Gtk.GtkIconSourceHandle New()
	{
		return GtkIconSourceExterns.gtk_icon_source_new();
	}

}


public static class GtkIconSourceExtensions
{
/// <summary>
/// <para>
/// Creates a copy of @source; mostly useful for language bindings.
/// </para>
/// </summary>

/// <param name="source">
/// a #GtkIconSource
/// </param>
/// <return>
/// a new #GtkIconSource
/// </return>

	public static MentorLake.Gtk.GtkIconSourceHandle Copy(this MentorLake.Gtk.GtkIconSourceHandle source)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GtkIconSource)");
		return GtkIconSourceExterns.gtk_icon_source_copy(source);
	}

/// <summary>
/// <para>
/// Frees a dynamically-allocated icon source, along with its
/// filename, size, and pixbuf fields if those are not %NULL.
/// </para>
/// </summary>

/// <param name="source">
/// a #GtkIconSource
/// </param>

	public static void Free(this MentorLake.Gtk.GtkIconSourceHandle source)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GtkIconSource)");
		GtkIconSourceExterns.gtk_icon_source_free(source);
	}

/// <summary>
/// <para>
/// Obtains the text direction this icon source applies to. The return
/// value is only useful/meaningful if the text direction is not
/// wildcarded.
/// </para>
/// </summary>

/// <param name="source">
/// a #GtkIconSource
/// </param>
/// <return>
/// text direction this source matches
/// </return>

	public static MentorLake.Gtk.GtkTextDirection GetDirection(this MentorLake.Gtk.GtkIconSourceHandle source)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GtkIconSource)");
		return GtkIconSourceExterns.gtk_icon_source_get_direction(source);
	}

/// <summary>
/// <para>
/// Gets the value set by gtk_icon_source_set_direction_wildcarded().
/// </para>
/// </summary>

/// <param name="source">
/// a #GtkIconSource
/// </param>
/// <return>
/// %TRUE if this icon source is a base for any text direction variant
/// </return>

	public static bool GetDirectionWildcarded(this MentorLake.Gtk.GtkIconSourceHandle source)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GtkIconSource)");
		return GtkIconSourceExterns.gtk_icon_source_get_direction_wildcarded(source);
	}

/// <summary>
/// <para>
/// Retrieves the source filename, or %NULL if none is set. The
/// filename is not a copy, and should not be modified or expected to
/// persist beyond the lifetime of the icon source.
/// </para>
/// </summary>

/// <param name="source">
/// a #GtkIconSource
/// </param>
/// <return>
/// image filename. This string must not
/// be modified or freed.
/// </return>

	public static string GetFilename(this MentorLake.Gtk.GtkIconSourceHandle source)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GtkIconSource)");
		return GtkIconSourceExterns.gtk_icon_source_get_filename(source);
	}

/// <summary>
/// <para>
/// Retrieves the source icon name, or %NULL if none is set. The
/// icon_name is not a copy, and should not be modified or expected to
/// persist beyond the lifetime of the icon source.
/// </para>
/// </summary>

/// <param name="source">
/// a #GtkIconSource
/// </param>
/// <return>
/// icon name. This string must not be modified or freed.
/// </return>

	public static string GetIconName(this MentorLake.Gtk.GtkIconSourceHandle source)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GtkIconSource)");
		return GtkIconSourceExterns.gtk_icon_source_get_icon_name(source);
	}

/// <summary>
/// <para>
/// Retrieves the source pixbuf, or %NULL if none is set.
/// In addition, if a filename source is in use, this
/// function in some cases will return the pixbuf from
/// loaded from the filename. This is, for example, true
/// for the GtkIconSource passed to the #GtkStyle render_icon()
/// virtual function. The reference count on the pixbuf is
/// not incremented.
/// </para>
/// </summary>

/// <param name="source">
/// a #GtkIconSource
/// </param>
/// <return>
/// source pixbuf
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle GetPixbuf(this MentorLake.Gtk.GtkIconSourceHandle source)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GtkIconSource)");
		return GtkIconSourceExterns.gtk_icon_source_get_pixbuf(source);
	}

/// <summary>
/// <para>
/// Obtains the icon size this source applies to. The return value
/// is only useful/meaningful if the icon size is not wildcarded.
/// </para>
/// </summary>

/// <param name="source">
/// a #GtkIconSource
/// </param>
/// <return>
/// icon size (#GtkIconSize) this source matches.
/// </return>

	public static MentorLake.Gtk.GtkIconSize GetSize(this MentorLake.Gtk.GtkIconSourceHandle source)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GtkIconSource)");
		return GtkIconSourceExterns.gtk_icon_source_get_size(source);
	}

/// <summary>
/// <para>
/// Gets the value set by gtk_icon_source_set_size_wildcarded().
/// </para>
/// </summary>

/// <param name="source">
/// a #GtkIconSource
/// </param>
/// <return>
/// %TRUE if this icon source is a base for any icon size variant
/// </return>

	public static bool GetSizeWildcarded(this MentorLake.Gtk.GtkIconSourceHandle source)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GtkIconSource)");
		return GtkIconSourceExterns.gtk_icon_source_get_size_wildcarded(source);
	}

/// <summary>
/// <para>
/// Obtains the widget state this icon source applies to. The return
/// value is only useful/meaningful if the widget state is not
/// wildcarded.
/// </para>
/// </summary>

/// <param name="source">
/// a #GtkIconSource
/// </param>
/// <return>
/// widget state this source matches
/// </return>

	public static MentorLake.Gtk.GtkStateType GetState(this MentorLake.Gtk.GtkIconSourceHandle source)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GtkIconSource)");
		return GtkIconSourceExterns.gtk_icon_source_get_state(source);
	}

/// <summary>
/// <para>
/// Gets the value set by gtk_icon_source_set_state_wildcarded().
/// </para>
/// </summary>

/// <param name="source">
/// a #GtkIconSource
/// </param>
/// <return>
/// %TRUE if this icon source is a base for any widget state variant
/// </return>

	public static bool GetStateWildcarded(this MentorLake.Gtk.GtkIconSourceHandle source)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GtkIconSource)");
		return GtkIconSourceExterns.gtk_icon_source_get_state_wildcarded(source);
	}

/// <summary>
/// <para>
/// Sets the text direction this icon source is intended to be used
/// with.
/// </para>
/// <para>
/// Setting the text direction on an icon source makes no difference
/// if the text direction is wildcarded. Therefore, you should usually
/// call gtk_icon_source_set_direction_wildcarded() to un-wildcard it
/// in addition to calling this function.
/// </para>
/// </summary>

/// <param name="source">
/// a #GtkIconSource
/// </param>
/// <param name="direction">
/// text direction this source applies to
/// </param>

	public static void SetDirection(this MentorLake.Gtk.GtkIconSourceHandle source, MentorLake.Gtk.GtkTextDirection direction)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GtkIconSource)");
		GtkIconSourceExterns.gtk_icon_source_set_direction(source, direction);
	}

/// <summary>
/// <para>
/// If the text direction is wildcarded, this source can be used
/// as the base image for an icon in any #GtkTextDirection.
/// If the text direction is not wildcarded, then the
/// text direction the icon source applies to should be set
/// with gtk_icon_source_set_direction(), and the icon source
/// will only be used with that text direction.
/// </para>
/// <para>
/// #GtkIconSet prefers non-wildcarded sources (exact matches) over
/// wildcarded sources, and will use an exact match when possible.
/// </para>
/// </summary>

/// <param name="source">
/// a #GtkIconSource
/// </param>
/// <param name="setting">
/// %TRUE to wildcard the text direction
/// </param>

	public static void SetDirectionWildcarded(this MentorLake.Gtk.GtkIconSourceHandle source, bool setting)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GtkIconSource)");
		GtkIconSourceExterns.gtk_icon_source_set_direction_wildcarded(source, setting);
	}

/// <summary>
/// <para>
/// Sets the name of an image file to use as a base image when creating
/// icon variants for #GtkIconSet. The filename must be absolute.
/// </para>
/// </summary>

/// <param name="source">
/// a #GtkIconSource
/// </param>
/// <param name="filename">
/// image file to use
/// </param>

	public static void SetFilename(this MentorLake.Gtk.GtkIconSourceHandle source, string filename)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GtkIconSource)");
		GtkIconSourceExterns.gtk_icon_source_set_filename(source, filename);
	}

/// <summary>
/// <para>
/// Sets the name of an icon to look up in the current icon theme
/// to use as a base image when creating icon variants for #GtkIconSet.
/// </para>
/// </summary>

/// <param name="source">
/// a #GtkIconSource
/// </param>
/// <param name="icon_name">
/// name of icon to use
/// </param>

	public static void SetIconName(this MentorLake.Gtk.GtkIconSourceHandle source, string icon_name)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GtkIconSource)");
		GtkIconSourceExterns.gtk_icon_source_set_icon_name(source, icon_name);
	}

/// <summary>
/// <para>
/// Sets a pixbuf to use as a base image when creating icon variants
/// for #GtkIconSet.
/// </para>
/// </summary>

/// <param name="source">
/// a #GtkIconSource
/// </param>
/// <param name="pixbuf">
/// pixbuf to use as a source
/// </param>

	public static void SetPixbuf(this MentorLake.Gtk.GtkIconSourceHandle source, MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GtkIconSource)");
		GtkIconSourceExterns.gtk_icon_source_set_pixbuf(source, pixbuf);
	}

/// <summary>
/// <para>
/// Sets the icon size this icon source is intended to be used
/// with.
/// </para>
/// <para>
/// Setting the icon size on an icon source makes no difference
/// if the size is wildcarded. Therefore, you should usually
/// call gtk_icon_source_set_size_wildcarded() to un-wildcard it
/// in addition to calling this function.
/// </para>
/// </summary>

/// <param name="source">
/// a #GtkIconSource
/// </param>
/// <param name="size">
/// icon size (#GtkIconSize) this source applies to
/// </param>

	public static void SetSize(this MentorLake.Gtk.GtkIconSourceHandle source, MentorLake.Gtk.GtkIconSize size)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GtkIconSource)");
		GtkIconSourceExterns.gtk_icon_source_set_size(source, size);
	}

/// <summary>
/// <para>
/// If the icon size is wildcarded, this source can be used as the base
/// image for an icon of any size.  If the size is not wildcarded, then
/// the size the source applies to should be set with
/// gtk_icon_source_set_size() and the icon source will only be used
/// with that specific size.
/// </para>
/// <para>
/// #GtkIconSet prefers non-wildcarded sources (exact matches) over
/// wildcarded sources, and will use an exact match when possible.
/// </para>
/// <para>
/// #GtkIconSet will normally scale wildcarded source images to produce
/// an appropriate icon at a given size, but will not change the size
/// of source images that match exactly.
/// </para>
/// </summary>

/// <param name="source">
/// a #GtkIconSource
/// </param>
/// <param name="setting">
/// %TRUE to wildcard the widget state
/// </param>

	public static void SetSizeWildcarded(this MentorLake.Gtk.GtkIconSourceHandle source, bool setting)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GtkIconSource)");
		GtkIconSourceExterns.gtk_icon_source_set_size_wildcarded(source, setting);
	}

/// <summary>
/// <para>
/// Sets the widget state this icon source is intended to be used
/// with.
/// </para>
/// <para>
/// Setting the widget state on an icon source makes no difference
/// if the state is wildcarded. Therefore, you should usually
/// call gtk_icon_source_set_state_wildcarded() to un-wildcard it
/// in addition to calling this function.
/// </para>
/// </summary>

/// <param name="source">
/// a #GtkIconSource
/// </param>
/// <param name="state">
/// widget state this source applies to
/// </param>

	public static void SetState(this MentorLake.Gtk.GtkIconSourceHandle source, MentorLake.Gtk.GtkStateType state)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GtkIconSource)");
		GtkIconSourceExterns.gtk_icon_source_set_state(source, state);
	}

/// <summary>
/// <para>
/// If the widget state is wildcarded, this source can be used as the
/// base image for an icon in any #GtkStateType.  If the widget state
/// is not wildcarded, then the state the source applies to should be
/// set with gtk_icon_source_set_state() and the icon source will
/// only be used with that specific state.
/// </para>
/// <para>
/// #GtkIconSet prefers non-wildcarded sources (exact matches) over
/// wildcarded sources, and will use an exact match when possible.
/// </para>
/// <para>
/// #GtkIconSet will normally transform wildcarded source images to
/// produce an appropriate icon for a given state, for example
/// lightening an image on prelight, but will not modify source images
/// that match exactly.
/// </para>
/// </summary>

/// <param name="source">
/// a #GtkIconSource
/// </param>
/// <param name="setting">
/// %TRUE to wildcard the widget state
/// </param>

	public static void SetStateWildcarded(this MentorLake.Gtk.GtkIconSourceHandle source, bool setting)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GtkIconSource)");
		GtkIconSourceExterns.gtk_icon_source_set_state_wildcarded(source, setting);
	}


	public static GtkIconSource Dereference(this GtkIconSourceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkIconSource>(x.DangerousGetHandle());
}
internal class GtkIconSourceExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))]
	internal static extern MentorLake.Gtk.GtkIconSourceHandle gtk_icon_source_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))]
	internal static extern MentorLake.Gtk.GtkIconSourceHandle gtk_icon_source_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_source_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTextDirection gtk_icon_source_get_direction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_icon_source_get_direction_wildcarded([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_icon_source_get_filename([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_icon_source_get_icon_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_icon_source_get_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkIconSize gtk_icon_source_get_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_icon_source_get_size_wildcarded([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkStateType gtk_icon_source_get_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_icon_source_get_state_wildcarded([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_source_set_direction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source, MentorLake.Gtk.GtkTextDirection direction);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_source_set_direction_wildcarded([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_source_set_filename([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source, string filename);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_source_set_icon_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source, string icon_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_source_set_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_source_set_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source, MentorLake.Gtk.GtkIconSize size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_source_set_size_wildcarded([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_source_set_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source, MentorLake.Gtk.GtkStateType state);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_source_set_state_wildcarded([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source, bool setting);

}


public struct GtkIconSource
{
}
