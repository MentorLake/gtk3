namespace MentorLake.Pango;

/// <summary>
/// <para>
/// A `PangoContext` stores global information used to control the
/// itemization process.
/// </para>
/// <para>
/// The information stored by `PangoContext` includes the fontmap used
/// to look up fonts, and default values such as the default language,
/// default gravity, or default font.
/// </para>
/// <para>
/// To obtain a `PangoContext`, use [method@Pango.FontMap.create_context].
/// </para>
/// </summary>

public class PangoContextHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new `PangoContext` initialized to default values.
/// </para>
/// <para>
/// This function is not particularly useful as it should always
/// be followed by a [method@Pango.Context.set_font_map] call, and the
/// function [method@Pango.FontMap.create_context] does these two steps
/// together and hence users are recommended to use that.
/// </para>
/// <para>
/// If you are using Pango as part of a higher-level system,
/// that system may have it&apos;s own way of create a `PangoContext`.
/// For instance, the GTK toolkit has, among others,
/// `gtk_widget_get_pango_context()`. Use those instead.
/// </para>
/// </summary>

/// <return>
/// the newly allocated `PangoContext`, which should
///   be freed with g_object_unref().
/// </return>

	public static MentorLake.Pango.PangoContextHandle New()
	{
		return PangoContextHandleExterns.pango_context_new();
	}

}

public static class PangoContextHandleExtensions
{
/// <summary>
/// <para>
/// Forces a change in the context, which will cause any `PangoLayout`
/// using this context to re-layout.
/// </para>
/// <para>
/// This function is only useful when implementing a new backend
/// for Pango, something applications won&apos;t do. Backends should
/// call this function if they have attached extra data to the context
/// and such data is changed.
/// </para>
/// </summary>

/// <param name="context">
/// a `PangoContext`
/// </param>

	public static T Changed<T>(this T context) where T : PangoContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		PangoContextHandleExterns.pango_context_changed(context);
		return context;
	}

/// <summary>
/// <para>
/// Retrieves the base direction for the context.
/// </para>
/// <para>
/// See [method@Pango.Context.set_base_dir].
/// </para>
/// </summary>

/// <param name="context">
/// a `PangoContext`
/// </param>
/// <return>
/// the base direction for the context.
/// </return>

	public static MentorLake.Pango.PangoDirection GetBaseDir(this MentorLake.Pango.PangoContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		return PangoContextHandleExterns.pango_context_get_base_dir(context);
	}

/// <summary>
/// <para>
/// Retrieves the base gravity for the context.
/// </para>
/// <para>
/// See [method@Pango.Context.set_base_gravity].
/// </para>
/// </summary>

/// <param name="context">
/// a `PangoContext`
/// </param>
/// <return>
/// the base gravity for the context.
/// </return>

	public static MentorLake.Pango.PangoGravity GetBaseGravity(this MentorLake.Pango.PangoContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		return PangoContextHandleExterns.pango_context_get_base_gravity(context);
	}

/// <summary>
/// <para>
/// Retrieve the default font description for the context.
/// </para>
/// </summary>

/// <param name="context">
/// a `PangoContext`
/// </param>
/// <return>
/// a pointer to the context&apos;s default font
///   description. This value must not be modified or freed.
/// </return>

	public static MentorLake.Pango.PangoFontDescriptionHandle GetFontDescription(this MentorLake.Pango.PangoContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		return PangoContextHandleExterns.pango_context_get_font_description(context);
	}

/// <summary>
/// <para>
/// Gets the `PangoFontMap` used to look up fonts for this context.
/// </para>
/// </summary>

/// <param name="context">
/// a `PangoContext`
/// </param>
/// <return>
/// the font map for the.
///   `PangoContext` This value is owned by Pango and should not be
///   unreferenced.
/// </return>

	public static MentorLake.Pango.PangoFontMapHandle GetFontMap(this MentorLake.Pango.PangoContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		return PangoContextHandleExterns.pango_context_get_font_map(context);
	}

/// <summary>
/// <para>
/// Retrieves the gravity for the context.
/// </para>
/// <para>
/// This is similar to [method@Pango.Context.get_base_gravity],
/// except for when the base gravity is %PANGO_GRAVITY_AUTO for
/// which [func@Pango.Gravity.get_for_matrix] is used to return the
/// gravity from the current context matrix.
/// </para>
/// </summary>

/// <param name="context">
/// a `PangoContext`
/// </param>
/// <return>
/// the resolved gravity for the context.
/// </return>

	public static MentorLake.Pango.PangoGravity GetGravity(this MentorLake.Pango.PangoContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		return PangoContextHandleExterns.pango_context_get_gravity(context);
	}

/// <summary>
/// <para>
/// Retrieves the gravity hint for the context.
/// </para>
/// <para>
/// See [method@Pango.Context.set_gravity_hint] for details.
/// </para>
/// </summary>

/// <param name="context">
/// a `PangoContext`
/// </param>
/// <return>
/// the gravity hint for the context.
/// </return>

	public static MentorLake.Pango.PangoGravityHint GetGravityHint(this MentorLake.Pango.PangoContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		return PangoContextHandleExterns.pango_context_get_gravity_hint(context);
	}

/// <summary>
/// <para>
/// Retrieves the global language tag for the context.
/// </para>
/// </summary>

/// <param name="context">
/// a `PangoContext`
/// </param>
/// <return>
/// the global language tag.
/// </return>

	public static MentorLake.Pango.PangoLanguageHandle GetLanguage(this MentorLake.Pango.PangoContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		return PangoContextHandleExterns.pango_context_get_language(context);
	}

/// <summary>
/// <para>
/// Gets the transformation matrix that will be applied when
/// rendering with this context.
/// </para>
/// <para>
/// See [method@Pango.Context.set_matrix].
/// </para>
/// </summary>

/// <param name="context">
/// a `PangoContext`
/// </param>
/// <return>
/// the matrix, or %NULL if no
///   matrix has been set (which is the same as the identity matrix).
///   The returned matrix is owned by Pango and must not be modified
///   or freed.
/// </return>

	public static MentorLake.Pango.PangoMatrixHandle GetMatrix(this MentorLake.Pango.PangoContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		return PangoContextHandleExterns.pango_context_get_matrix(context);
	}

/// <summary>
/// <para>
/// Get overall metric information for a particular font description.
/// </para>
/// <para>
/// Since the metrics may be substantially different for different scripts,
/// a language tag can be provided to indicate that the metrics should be
/// retrieved that correspond to the script(s) used by that language.
/// </para>
/// <para>
/// The `PangoFontDescription` is interpreted in the same way as by [func@itemize],
/// and the family name may be a comma separated list of names. If characters
/// from multiple of these families would be used to render the string, then
/// the returned fonts would be a composite of the metrics for the fonts loaded
/// for the individual families.
/// </para>
/// </summary>

/// <param name="context">
/// a `PangoContext`
/// </param>
/// <param name="desc">
/// a `PangoFontDescription` structure. %NULL means that the
///   font description from the context will be used.
/// </param>
/// <param name="language">
/// language tag used to determine which script to get
///   the metrics for. %NULL means that the language tag from the context
///   will be used. If no language tag is set on the context, metrics
///   for the default language (as determined by [func@Pango.Language.get_default]
///   will be returned.
/// </param>
/// <return>
/// a `PangoFontMetrics` object. The caller must call
///   [method@Pango.FontMetrics.unref] when finished using the object.
/// </return>

	public static MentorLake.Pango.PangoFontMetricsHandle GetMetrics(this MentorLake.Pango.PangoContextHandle context, MentorLake.Pango.PangoFontDescriptionHandle desc, MentorLake.Pango.PangoLanguageHandle language)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		return PangoContextHandleExterns.pango_context_get_metrics(context, desc, language);
	}

/// <summary>
/// <para>
/// Returns whether font rendering with this context should
/// round glyph positions and widths.
/// </para>
/// </summary>

/// <param name="context">
/// a `PangoContext`
/// </param>

	public static bool GetRoundGlyphPositions(this MentorLake.Pango.PangoContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		return PangoContextHandleExterns.pango_context_get_round_glyph_positions(context);
	}

/// <summary>
/// <para>
/// Returns the current serial number of @context.
/// </para>
/// <para>
/// The serial number is initialized to an small number larger than zero
/// when a new context is created and is increased whenever the context
/// is changed using any of the setter functions, or the `PangoFontMap` it
/// uses to find fonts has changed. The serial may wrap, but will never
/// have the value 0. Since it can wrap, never compare it with &quot;less than&quot;,
/// always use &quot;not equals&quot;.
/// </para>
/// <para>
/// This can be used to automatically detect changes to a `PangoContext`,
/// and is only useful when implementing objects that need update when their
/// `PangoContext` changes, like `PangoLayout`.
/// </para>
/// </summary>

/// <param name="context">
/// a `PangoContext`
/// </param>
/// <return>
/// The current serial number of @context.
/// </return>

	public static uint GetSerial(this MentorLake.Pango.PangoContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		return PangoContextHandleExterns.pango_context_get_serial(context);
	}

/// <summary>
/// <para>
/// List all families for a context.
/// </para>
/// </summary>

/// <param name="context">
/// a `PangoContext`
/// </param>
/// <param name="families">
/// location
///   to store a pointer to an array of `PangoFontFamily`. This array should
///   be freed with g_free().
/// </param>
/// <param name="n_families">
/// location to store the number of elements in @descs
/// </param>

	public static T ListFamilies<T>(this T context, out MentorLake.Pango.PangoFontFamilyHandle[] families, out int n_families) where T : PangoContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		PangoContextHandleExterns.pango_context_list_families(context, out families, out n_families);
		return context;
	}

/// <summary>
/// <para>
/// Loads the font in one of the fontmaps in the context
/// that is the closest match for @desc.
/// </para>
/// </summary>

/// <param name="context">
/// a `PangoContext`
/// </param>
/// <param name="desc">
/// a `PangoFontDescription` describing the font to load
/// </param>
/// <return>
/// the newly allocated `PangoFont`
///   that was loaded, or %NULL if no font matched.
/// </return>

	public static MentorLake.Pango.PangoFontHandle LoadFont(this MentorLake.Pango.PangoContextHandle context, MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		return PangoContextHandleExterns.pango_context_load_font(context, desc);
	}

/// <summary>
/// <para>
/// Load a set of fonts in the context that can be used to render
/// a font matching @desc.
/// </para>
/// </summary>

/// <param name="context">
/// a `PangoContext`
/// </param>
/// <param name="desc">
/// a `PangoFontDescription` describing the fonts to load
/// </param>
/// <param name="language">
/// a `PangoLanguage` the fonts will be used for
/// </param>
/// <return>
/// the newly allocated
///   `PangoFontset` loaded, or %NULL if no font matched.
/// </return>

	public static MentorLake.Pango.PangoFontsetHandle LoadFontset(this MentorLake.Pango.PangoContextHandle context, MentorLake.Pango.PangoFontDescriptionHandle desc, MentorLake.Pango.PangoLanguageHandle language)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		return PangoContextHandleExterns.pango_context_load_fontset(context, desc, language);
	}

/// <summary>
/// <para>
/// Sets the base direction for the context.
/// </para>
/// <para>
/// The base direction is used in applying the Unicode bidirectional
/// algorithm; if the @direction is %PANGO_DIRECTION_LTR or
/// %PANGO_DIRECTION_RTL, then the value will be used as the paragraph
/// direction in the Unicode bidirectional algorithm. A value of
/// %PANGO_DIRECTION_WEAK_LTR or %PANGO_DIRECTION_WEAK_RTL is used only
/// for paragraphs that do not contain any strong characters themselves.
/// </para>
/// </summary>

/// <param name="context">
/// a `PangoContext`
/// </param>
/// <param name="direction">
/// the new base direction
/// </param>

	public static T SetBaseDir<T>(this T context, MentorLake.Pango.PangoDirection direction) where T : PangoContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		PangoContextHandleExterns.pango_context_set_base_dir(context, direction);
		return context;
	}

/// <summary>
/// <para>
/// Sets the base gravity for the context.
/// </para>
/// <para>
/// The base gravity is used in laying vertical text out.
/// </para>
/// </summary>

/// <param name="context">
/// a `PangoContext`
/// </param>
/// <param name="gravity">
/// the new base gravity
/// </param>

	public static T SetBaseGravity<T>(this T context, MentorLake.Pango.PangoGravity gravity) where T : PangoContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		PangoContextHandleExterns.pango_context_set_base_gravity(context, gravity);
		return context;
	}

/// <summary>
/// <para>
/// Set the default font description for the context
/// </para>
/// </summary>

/// <param name="context">
/// a `PangoContext`
/// </param>
/// <param name="desc">
/// the new pango font description
/// </param>

	public static T SetFontDescription<T>(this T context, MentorLake.Pango.PangoFontDescriptionHandle desc) where T : PangoContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		PangoContextHandleExterns.pango_context_set_font_description(context, desc);
		return context;
	}

/// <summary>
/// <para>
/// Sets the font map to be searched when fonts are looked-up
/// in this context.
/// </para>
/// <para>
/// This is only for internal use by Pango backends, a `PangoContext`
/// obtained via one of the recommended methods should already have a
/// suitable font map.
/// </para>
/// </summary>

/// <param name="context">
/// a `PangoContext`
/// </param>
/// <param name="font_map">
/// the `PangoFontMap` to set.
/// </param>

	public static T SetFontMap<T>(this T context, MentorLake.Pango.PangoFontMapHandle font_map) where T : PangoContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		PangoContextHandleExterns.pango_context_set_font_map(context, font_map);
		return context;
	}

/// <summary>
/// <para>
/// Sets the gravity hint for the context.
/// </para>
/// <para>
/// The gravity hint is used in laying vertical text out, and
/// is only relevant if gravity of the context as returned by
/// [method@Pango.Context.get_gravity] is set to %PANGO_GRAVITY_EAST
/// or %PANGO_GRAVITY_WEST.
/// </para>
/// </summary>

/// <param name="context">
/// a `PangoContext`
/// </param>
/// <param name="hint">
/// the new gravity hint
/// </param>

	public static T SetGravityHint<T>(this T context, MentorLake.Pango.PangoGravityHint hint) where T : PangoContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		PangoContextHandleExterns.pango_context_set_gravity_hint(context, hint);
		return context;
	}

/// <summary>
/// <para>
/// Sets the global language tag for the context.
/// </para>
/// <para>
/// The default language for the locale of the running process
/// can be found using [func@Pango.Language.get_default].
/// </para>
/// </summary>

/// <param name="context">
/// a `PangoContext`
/// </param>
/// <param name="language">
/// the new language tag.
/// </param>

	public static T SetLanguage<T>(this T context, MentorLake.Pango.PangoLanguageHandle language) where T : PangoContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		PangoContextHandleExterns.pango_context_set_language(context, language);
		return context;
	}

/// <summary>
/// <para>
/// Sets the transformation matrix that will be applied when rendering
/// with this context.
/// </para>
/// <para>
/// Note that reported metrics are in the user space coordinates before
/// the application of the matrix, not device-space coordinates after the
/// application of the matrix. So, they don&apos;t scale with the matrix, though
/// they may change slightly for different matrices, depending on how the
/// text is fit to the pixel grid.
/// </para>
/// </summary>

/// <param name="context">
/// a `PangoContext`
/// </param>
/// <param name="matrix">
/// a `PangoMatrix`, or %NULL to unset any existing
/// matrix. (No matrix set is the same as setting the identity matrix.)
/// </param>

	public static T SetMatrix<T>(this T context, MentorLake.Pango.PangoMatrixHandle matrix) where T : PangoContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		PangoContextHandleExterns.pango_context_set_matrix(context, matrix);
		return context;
	}

/// <summary>
/// <para>
/// Sets whether font rendering with this context should
/// round glyph positions and widths to integral positions,
/// in device units.
/// </para>
/// <para>
/// This is useful when the renderer can&apos;t handle subpixel
/// positioning of glyphs.
/// </para>
/// <para>
/// The default value is to round glyph positions, to remain
/// compatible with previous Pango behavior.
/// </para>
/// </summary>

/// <param name="context">
/// a `PangoContext`
/// </param>
/// <param name="round_positions">
/// whether to round glyph positions
/// </param>

	public static T SetRoundGlyphPositions<T>(this T context, bool round_positions) where T : PangoContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		PangoContextHandleExterns.pango_context_set_round_glyph_positions(context, round_positions);
		return context;
	}

}

internal class PangoContextHandleExterns
{
	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))]
	internal static extern MentorLake.Pango.PangoContextHandle pango_context_new();

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_context_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoDirection pango_context_get_base_dir([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoGravity pango_context_get_base_gravity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))]
	internal static extern MentorLake.Pango.PangoFontDescriptionHandle pango_context_get_font_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))]
	internal static extern MentorLake.Pango.PangoFontMapHandle pango_context_get_font_map([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoGravity pango_context_get_gravity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoGravityHint pango_context_get_gravity_hint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLanguageHandle>))]
	internal static extern MentorLake.Pango.PangoLanguageHandle pango_context_get_language([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoMatrixHandle>))]
	internal static extern MentorLake.Pango.PangoMatrixHandle pango_context_get_matrix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMetricsHandle>))]
	internal static extern MentorLake.Pango.PangoFontMetricsHandle pango_context_get_metrics([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLanguageHandle>))] MentorLake.Pango.PangoLanguageHandle language);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_context_get_round_glyph_positions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context);

	[DllImport(PangoLibrary.Name)]
	internal static extern uint pango_context_get_serial([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_context_list_families([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontFamilyHandle>))] out MentorLake.Pango.PangoFontFamilyHandle[] families, out int n_families);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))]
	internal static extern MentorLake.Pango.PangoFontHandle pango_context_load_font([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Pango.PangoFontsetHandle>))]
	internal static extern MentorLake.Pango.PangoFontsetHandle pango_context_load_fontset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLanguageHandle>))] MentorLake.Pango.PangoLanguageHandle language);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_context_set_base_dir([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context, MentorLake.Pango.PangoDirection direction);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_context_set_base_gravity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context, MentorLake.Pango.PangoGravity gravity);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_context_set_font_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_context_set_font_map([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))] MentorLake.Pango.PangoFontMapHandle font_map);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_context_set_gravity_hint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context, MentorLake.Pango.PangoGravityHint hint);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_context_set_language([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLanguageHandle>))] MentorLake.Pango.PangoLanguageHandle language);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_context_set_matrix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoMatrixHandle>))] MentorLake.Pango.PangoMatrixHandle matrix);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_context_set_round_glyph_positions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context, bool round_positions);

}
