namespace MentorLake.PangoCairo;

/// <summary>
/// <para>
/// `PangoCairoFontMap` is an interface exported by font maps for
/// use with Cairo.
/// </para>
/// <para>
/// The actual type of the font map will depend on the particular
/// font technology Cairo was compiled to use.
/// </para>
/// </summary>

public interface PangoCairoFontMapHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class PangoCairoFontMapHandleImpl : BaseSafeHandle, PangoCairoFontMapHandle
{
}

public static class PangoCairoFontMapHandleExtensions
{
/// <summary>
/// <para>
/// Create a `PangoContext` for the given fontmap.
/// </para>
/// </summary>

/// <param name="fontmap">
/// a `PangoCairoFontMap`
/// </param>
/// <return>
/// the newly created context; free with g_object_unref().
/// </return>

	public static MentorLake.Pango.PangoContextHandle CreateContext(this MentorLake.PangoCairo.PangoCairoFontMapHandle fontmap)
	{
		if (fontmap.IsInvalid) throw new Exception("Invalid handle (PangoCairoFontMapHandle)");
		return PangoCairoFontMapHandleExterns.pango_cairo_font_map_create_context(fontmap);
	}

/// <summary>
/// <para>
/// Gets the type of Cairo font backend that @fontmap uses.
/// </para>
/// </summary>

/// <param name="fontmap">
/// a `PangoCairoFontMap`
/// </param>
/// <return>
/// the `cairo_font_type_t` cairo font backend type
/// </return>

	public static MentorLake.cairo.cairo_font_type_t GetFontType(this MentorLake.PangoCairo.PangoCairoFontMapHandle fontmap)
	{
		if (fontmap.IsInvalid) throw new Exception("Invalid handle (PangoCairoFontMapHandle)");
		return PangoCairoFontMapHandleExterns.pango_cairo_font_map_get_font_type(fontmap);
	}

/// <summary>
/// <para>
/// Gets the resolution for the fontmap.
/// </para>
/// <para>
/// See [method@PangoCairo.FontMap.set_resolution].
/// </para>
/// </summary>

/// <param name="fontmap">
/// a `PangoCairoFontMap`
/// </param>
/// <return>
/// the resolution in &quot;dots per inch&quot;
/// </return>

	public static double GetResolution(this MentorLake.PangoCairo.PangoCairoFontMapHandle fontmap)
	{
		if (fontmap.IsInvalid) throw new Exception("Invalid handle (PangoCairoFontMapHandle)");
		return PangoCairoFontMapHandleExterns.pango_cairo_font_map_get_resolution(fontmap);
	}

/// <summary>
/// <para>
/// Sets a default `PangoCairoFontMap` to use with Cairo.
/// </para>
/// <para>
/// This can be used to change the Cairo font backend that the
/// default fontmap uses for example. The old default font map
/// is unreffed and the new font map referenced.
/// </para>
/// <para>
/// Note that since Pango 1.32.6, the default fontmap is per-thread.
/// This function only changes the default fontmap for
/// the current thread. Default fontmaps of existing threads
/// are not changed. Default fontmaps of any new threads will
/// still be created using [func@PangoCairo.FontMap.new].
/// </para>
/// <para>
/// A value of %NULL for @fontmap will cause the current default
/// font map to be released and a new default font map to be created
/// on demand, using [func@PangoCairo.FontMap.new].
/// </para>
/// </summary>

/// <param name="fontmap">
/// The new default font map
/// </param>

	public static T SetDefault<T>(this T fontmap) where T : PangoCairoFontMapHandle
	{
		if (fontmap.IsInvalid) throw new Exception("Invalid handle (PangoCairoFontMapHandle)");
		PangoCairoFontMapHandleExterns.pango_cairo_font_map_set_default(fontmap);
		return fontmap;
	}

/// <summary>
/// <para>
/// Sets the resolution for the fontmap.
/// </para>
/// <para>
/// This is a scale factor between
/// points specified in a `PangoFontDescription` and Cairo units. The
/// default value is 96, meaning that a 10 point font will be 13
/// units high. (10 * 96. / 72. = 13.3).
/// </para>
/// </summary>

/// <param name="fontmap">
/// a `PangoCairoFontMap`
/// </param>
/// <param name="dpi">
/// the resolution in &quot;dots per inch&quot;. (Physical inches aren&apos;t actually
///   involved; the terminology is conventional.)
/// </param>

	public static T SetResolution<T>(this T fontmap, double dpi) where T : PangoCairoFontMapHandle
	{
		if (fontmap.IsInvalid) throw new Exception("Invalid handle (PangoCairoFontMapHandle)");
		PangoCairoFontMapHandleExterns.pango_cairo_font_map_set_resolution(fontmap, dpi);
		return fontmap;
	}

/// <summary>
/// <para>
/// Gets a default `PangoCairoFontMap` to use with Cairo.
/// </para>
/// <para>
/// Note that the type of the returned object will depend on the
/// particular font backend Cairo was compiled to use; you generally
/// should only use the `PangoFontMap` and `PangoCairoFontMap`
/// interfaces on the returned object.
/// </para>
/// <para>
/// The default Cairo fontmap can be changed by using
/// [method@PangoCairo.FontMap.set_default]. This can be used to
/// change the Cairo font backend that the default fontmap uses
/// for example.
/// </para>
/// <para>
/// Note that since Pango 1.32.6, the default fontmap is per-thread.
/// Each thread gets its own default fontmap. In this way, PangoCairo
/// can be used safely from multiple threads.
/// </para>
/// </summary>

/// <return>
/// the default PangoCairo fontmap
///  for the current thread. This object is owned by Pango and must
///  not be freed.
/// </return>

	public static MentorLake.Pango.PangoFontMapHandle GetDefault()
	{
		return PangoCairoFontMapHandleExterns.pango_cairo_font_map_get_default();
	}

/// <summary>
/// <para>
/// Creates a new `PangoCairoFontMap` object.
/// </para>
/// <para>
/// A fontmap is used to cache information about available fonts,
/// and holds certain global parameters such as the resolution.
/// In most cases, you can use `func@PangoCairo.font_map_get_default]
/// instead.
/// </para>
/// <para>
/// Note that the type of the returned object will depend
/// on the particular font backend Cairo was compiled to use;
/// You generally should only use the `PangoFontMap` and
/// `PangoCairoFontMap` interfaces on the returned object.
/// </para>
/// <para>
/// You can override the type of backend returned by using an
/// environment variable %PANGOCAIRO_BACKEND. Supported types,
/// based on your build, are fc (fontconfig), win32, and coretext.
/// If requested type is not available, NULL is returned. Ie.
/// this is only useful for testing, when at least two backends
/// are compiled in.
/// </para>
/// </summary>

/// <return>
/// the newly allocated `PangoFontMap`,
///   which should be freed with g_object_unref().
/// </return>

	public static MentorLake.Pango.PangoFontMapHandle New()
	{
		return PangoCairoFontMapHandleExterns.pango_cairo_font_map_new();
	}

/// <summary>
/// <para>
/// Creates a new `PangoCairoFontMap` object of the type suitable
/// to be used with cairo font backend of type @fonttype.
/// </para>
/// <para>
/// In most cases one should simply use [func@PangoCairo.FontMap.new], or
/// in fact in most of those cases, just use [func@PangoCairo.FontMap.get_default].
/// </para>
/// </summary>

/// <param name="fonttype">
/// desired #cairo_font_type_t
/// </param>
/// <return>
/// the newly allocated
///   `PangoFontMap` of suitable type which should be freed with
///   g_object_unref(), or %NULL if the requested cairo font backend
///   is not supported / compiled in.
/// </return>

	public static MentorLake.Pango.PangoFontMapHandle NewForFontType(MentorLake.cairo.cairo_font_type_t fonttype)
	{
		return PangoCairoFontMapHandleExterns.pango_cairo_font_map_new_for_font_type(fonttype);
	}

}

internal class PangoCairoFontMapHandleExterns
{
	[DllImport(PangoCairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))]
	internal static extern MentorLake.Pango.PangoContextHandle pango_cairo_font_map_create_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoCairo.PangoCairoFontMapHandleImpl>))] MentorLake.PangoCairo.PangoCairoFontMapHandle fontmap);

	[DllImport(PangoCairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_font_type_t pango_cairo_font_map_get_font_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoCairo.PangoCairoFontMapHandleImpl>))] MentorLake.PangoCairo.PangoCairoFontMapHandle fontmap);

	[DllImport(PangoCairoLibrary.Name)]
	internal static extern double pango_cairo_font_map_get_resolution([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoCairo.PangoCairoFontMapHandleImpl>))] MentorLake.PangoCairo.PangoCairoFontMapHandle fontmap);

	[DllImport(PangoCairoLibrary.Name)]
	internal static extern void pango_cairo_font_map_set_default([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoCairo.PangoCairoFontMapHandleImpl>))] MentorLake.PangoCairo.PangoCairoFontMapHandle fontmap);

	[DllImport(PangoCairoLibrary.Name)]
	internal static extern void pango_cairo_font_map_set_resolution([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoCairo.PangoCairoFontMapHandleImpl>))] MentorLake.PangoCairo.PangoCairoFontMapHandle fontmap, double dpi);

	[DllImport(PangoCairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))]
	internal static extern MentorLake.Pango.PangoFontMapHandle pango_cairo_font_map_get_default();

	[DllImport(PangoCairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))]
	internal static extern MentorLake.Pango.PangoFontMapHandle pango_cairo_font_map_new();

	[DllImport(PangoCairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))]
	internal static extern MentorLake.Pango.PangoFontMapHandle pango_cairo_font_map_new_for_font_type(MentorLake.cairo.cairo_font_type_t fonttype);

}
