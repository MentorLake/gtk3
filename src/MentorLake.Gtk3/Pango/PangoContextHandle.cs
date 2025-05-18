namespace MentorLake.Pango;

public class PangoContextHandle : GObjectHandle
{
	public static MentorLake.Pango.PangoContextHandle New()
	{
		return PangoContextHandleExterns.pango_context_new();
	}

}

public static class PangoContextHandleExtensions
{
	public static T Changed<T>(this T context) where T : PangoContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		PangoContextHandleExterns.pango_context_changed(context);
		return context;
	}

	public static MentorLake.Pango.PangoDirection GetBaseDir(this MentorLake.Pango.PangoContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		return PangoContextHandleExterns.pango_context_get_base_dir(context);
	}

	public static MentorLake.Pango.PangoGravity GetBaseGravity(this MentorLake.Pango.PangoContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		return PangoContextHandleExterns.pango_context_get_base_gravity(context);
	}

	public static MentorLake.Pango.PangoFontDescriptionHandle GetFontDescription(this MentorLake.Pango.PangoContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		return PangoContextHandleExterns.pango_context_get_font_description(context);
	}

	public static MentorLake.Pango.PangoFontMapHandle GetFontMap(this MentorLake.Pango.PangoContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		return PangoContextHandleExterns.pango_context_get_font_map(context);
	}

	public static MentorLake.Pango.PangoGravity GetGravity(this MentorLake.Pango.PangoContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		return PangoContextHandleExterns.pango_context_get_gravity(context);
	}

	public static MentorLake.Pango.PangoGravityHint GetGravityHint(this MentorLake.Pango.PangoContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		return PangoContextHandleExterns.pango_context_get_gravity_hint(context);
	}

	public static MentorLake.Pango.PangoLanguageHandle GetLanguage(this MentorLake.Pango.PangoContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		return PangoContextHandleExterns.pango_context_get_language(context);
	}

	public static MentorLake.Pango.PangoMatrixHandle GetMatrix(this MentorLake.Pango.PangoContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		return PangoContextHandleExterns.pango_context_get_matrix(context);
	}

	public static MentorLake.Pango.PangoFontMetricsHandle GetMetrics(this MentorLake.Pango.PangoContextHandle context, MentorLake.Pango.PangoFontDescriptionHandle desc, MentorLake.Pango.PangoLanguageHandle language)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		return PangoContextHandleExterns.pango_context_get_metrics(context, desc, language);
	}

	public static bool GetRoundGlyphPositions(this MentorLake.Pango.PangoContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		return PangoContextHandleExterns.pango_context_get_round_glyph_positions(context);
	}

	public static uint GetSerial(this MentorLake.Pango.PangoContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		return PangoContextHandleExterns.pango_context_get_serial(context);
	}

	public static T ListFamilies<T>(this T context, out MentorLake.Pango.PangoFontFamilyHandle[] families, out int n_families) where T : PangoContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		PangoContextHandleExterns.pango_context_list_families(context, out families, out n_families);
		return context;
	}

	public static MentorLake.Pango.PangoFontHandle LoadFont(this MentorLake.Pango.PangoContextHandle context, MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		return PangoContextHandleExterns.pango_context_load_font(context, desc);
	}

	public static MentorLake.Pango.PangoFontsetHandle LoadFontset(this MentorLake.Pango.PangoContextHandle context, MentorLake.Pango.PangoFontDescriptionHandle desc, MentorLake.Pango.PangoLanguageHandle language)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		return PangoContextHandleExterns.pango_context_load_fontset(context, desc, language);
	}

	public static T SetBaseDir<T>(this T context, MentorLake.Pango.PangoDirection direction) where T : PangoContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		PangoContextHandleExterns.pango_context_set_base_dir(context, direction);
		return context;
	}

	public static T SetBaseGravity<T>(this T context, MentorLake.Pango.PangoGravity gravity) where T : PangoContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		PangoContextHandleExterns.pango_context_set_base_gravity(context, gravity);
		return context;
	}

	public static T SetFontDescription<T>(this T context, MentorLake.Pango.PangoFontDescriptionHandle desc) where T : PangoContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		PangoContextHandleExterns.pango_context_set_font_description(context, desc);
		return context;
	}

	public static T SetFontMap<T>(this T context, MentorLake.Pango.PangoFontMapHandle font_map) where T : PangoContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		PangoContextHandleExterns.pango_context_set_font_map(context, font_map);
		return context;
	}

	public static T SetGravityHint<T>(this T context, MentorLake.Pango.PangoGravityHint hint) where T : PangoContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		PangoContextHandleExterns.pango_context_set_gravity_hint(context, hint);
		return context;
	}

	public static T SetLanguage<T>(this T context, MentorLake.Pango.PangoLanguageHandle language) where T : PangoContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		PangoContextHandleExterns.pango_context_set_language(context, language);
		return context;
	}

	public static T SetMatrix<T>(this T context, MentorLake.Pango.PangoMatrixHandle matrix) where T : PangoContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (PangoContextHandle)");
		PangoContextHandleExterns.pango_context_set_matrix(context, matrix);
		return context;
	}

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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))]
	internal static extern MentorLake.Pango.PangoFontHandle pango_context_load_font([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontsetHandle>))]
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
