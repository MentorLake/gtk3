namespace MentorLake.Pango;

public class PangoFontDescriptionHandle : BaseSafeHandle
{
	public static MentorLake.Pango.PangoFontDescriptionHandle New()
	{
		return PangoFontDescriptionExterns.pango_font_description_new();
	}

}


public static class PangoFontDescriptionExtensions
{
	public static bool BetterMatch(this MentorLake.Pango.PangoFontDescriptionHandle desc, MentorLake.Pango.PangoFontDescriptionHandle old_match, MentorLake.Pango.PangoFontDescriptionHandle new_match)
	{
		return PangoFontDescriptionExterns.pango_font_description_better_match(desc, old_match, new_match);
	}

	public static MentorLake.Pango.PangoFontDescriptionHandle Copy(this MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		return PangoFontDescriptionExterns.pango_font_description_copy(desc);
	}

	public static MentorLake.Pango.PangoFontDescriptionHandle CopyStatic(this MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		return PangoFontDescriptionExterns.pango_font_description_copy_static(desc);
	}

	public static bool Equal(this MentorLake.Pango.PangoFontDescriptionHandle desc1, MentorLake.Pango.PangoFontDescriptionHandle desc2)
	{
		return PangoFontDescriptionExterns.pango_font_description_equal(desc1, desc2);
	}

	public static void Free(this MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		PangoFontDescriptionExterns.pango_font_description_free(desc);
	}

	public static string GetFamily(this MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		return PangoFontDescriptionExterns.pango_font_description_get_family(desc);
	}

	public static string GetFeatures(this MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		return PangoFontDescriptionExterns.pango_font_description_get_features(desc);
	}

	public static MentorLake.Pango.PangoGravity GetGravity(this MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		return PangoFontDescriptionExterns.pango_font_description_get_gravity(desc);
	}

	public static MentorLake.Pango.PangoFontMask GetSetFields(this MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		return PangoFontDescriptionExterns.pango_font_description_get_set_fields(desc);
	}

	public static int GetSize(this MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		return PangoFontDescriptionExterns.pango_font_description_get_size(desc);
	}

	public static bool GetSizeIsAbsolute(this MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		return PangoFontDescriptionExterns.pango_font_description_get_size_is_absolute(desc);
	}

	public static MentorLake.Pango.PangoStretch GetStretch(this MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		return PangoFontDescriptionExterns.pango_font_description_get_stretch(desc);
	}

	public static MentorLake.Pango.PangoStyle GetStyle(this MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		return PangoFontDescriptionExterns.pango_font_description_get_style(desc);
	}

	public static MentorLake.Pango.PangoVariant GetVariant(this MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		return PangoFontDescriptionExterns.pango_font_description_get_variant(desc);
	}

	public static string GetVariations(this MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		return PangoFontDescriptionExterns.pango_font_description_get_variations(desc);
	}

	public static MentorLake.Pango.PangoWeight GetWeight(this MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		return PangoFontDescriptionExterns.pango_font_description_get_weight(desc);
	}

	public static uint Hash(this MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		return PangoFontDescriptionExterns.pango_font_description_hash(desc);
	}

	public static void Merge(this MentorLake.Pango.PangoFontDescriptionHandle desc, MentorLake.Pango.PangoFontDescriptionHandle desc_to_merge, bool replace_existing)
	{
		PangoFontDescriptionExterns.pango_font_description_merge(desc, desc_to_merge, replace_existing);
	}

	public static void MergeStatic(this MentorLake.Pango.PangoFontDescriptionHandle desc, MentorLake.Pango.PangoFontDescriptionHandle desc_to_merge, bool replace_existing)
	{
		PangoFontDescriptionExterns.pango_font_description_merge_static(desc, desc_to_merge, replace_existing);
	}

	public static void SetAbsoluteSize(this MentorLake.Pango.PangoFontDescriptionHandle desc, double size)
	{
		PangoFontDescriptionExterns.pango_font_description_set_absolute_size(desc, size);
	}

	public static void SetFamily(this MentorLake.Pango.PangoFontDescriptionHandle desc, string family)
	{
		PangoFontDescriptionExterns.pango_font_description_set_family(desc, family);
	}

	public static void SetFamilyStatic(this MentorLake.Pango.PangoFontDescriptionHandle desc, string family)
	{
		PangoFontDescriptionExterns.pango_font_description_set_family_static(desc, family);
	}

	public static void SetFeatures(this MentorLake.Pango.PangoFontDescriptionHandle desc, string features)
	{
		PangoFontDescriptionExterns.pango_font_description_set_features(desc, features);
	}

	public static void SetFeaturesStatic(this MentorLake.Pango.PangoFontDescriptionHandle desc, string features)
	{
		PangoFontDescriptionExterns.pango_font_description_set_features_static(desc, features);
	}

	public static void SetGravity(this MentorLake.Pango.PangoFontDescriptionHandle desc, MentorLake.Pango.PangoGravity gravity)
	{
		PangoFontDescriptionExterns.pango_font_description_set_gravity(desc, gravity);
	}

	public static void SetSize(this MentorLake.Pango.PangoFontDescriptionHandle desc, int size)
	{
		PangoFontDescriptionExterns.pango_font_description_set_size(desc, size);
	}

	public static void SetStretch(this MentorLake.Pango.PangoFontDescriptionHandle desc, MentorLake.Pango.PangoStretch stretch)
	{
		PangoFontDescriptionExterns.pango_font_description_set_stretch(desc, stretch);
	}

	public static void SetStyle(this MentorLake.Pango.PangoFontDescriptionHandle desc, MentorLake.Pango.PangoStyle style)
	{
		PangoFontDescriptionExterns.pango_font_description_set_style(desc, style);
	}

	public static void SetVariant(this MentorLake.Pango.PangoFontDescriptionHandle desc, MentorLake.Pango.PangoVariant variant)
	{
		PangoFontDescriptionExterns.pango_font_description_set_variant(desc, variant);
	}

	public static void SetVariations(this MentorLake.Pango.PangoFontDescriptionHandle desc, string variations)
	{
		PangoFontDescriptionExterns.pango_font_description_set_variations(desc, variations);
	}

	public static void SetVariationsStatic(this MentorLake.Pango.PangoFontDescriptionHandle desc, string variations)
	{
		PangoFontDescriptionExterns.pango_font_description_set_variations_static(desc, variations);
	}

	public static void SetWeight(this MentorLake.Pango.PangoFontDescriptionHandle desc, MentorLake.Pango.PangoWeight weight)
	{
		PangoFontDescriptionExterns.pango_font_description_set_weight(desc, weight);
	}

	public static string ToFilename(this MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		return PangoFontDescriptionExterns.pango_font_description_to_filename(desc);
	}

	public static string ToString(this MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		return PangoFontDescriptionExterns.pango_font_description_to_string(desc);
	}

	public static void UnsetFields(this MentorLake.Pango.PangoFontDescriptionHandle desc, MentorLake.Pango.PangoFontMask to_unset)
	{
		PangoFontDescriptionExterns.pango_font_description_unset_fields(desc, to_unset);
	}


	public static PangoFontDescription Dereference(this PangoFontDescriptionHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoFontDescription>(x.DangerousGetHandle());
}
internal class PangoFontDescriptionExterns
{
	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoFontDescriptionHandle pango_font_description_new();

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_font_description_better_match([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle old_match, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle new_match);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoFontDescriptionHandle pango_font_description_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoFontDescriptionHandle pango_font_description_copy_static([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_font_description_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc2);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_description_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string pango_font_description_get_family([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string pango_font_description_get_features([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoGravity pango_font_description_get_gravity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoFontMask pango_font_description_get_set_fields([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_font_description_get_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_font_description_get_size_is_absolute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoStretch pango_font_description_get_stretch([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoStyle pango_font_description_get_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoVariant pango_font_description_get_variant([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string pango_font_description_get_variations([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoWeight pango_font_description_get_weight([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	internal static extern uint pango_font_description_hash([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_description_merge([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc_to_merge, bool replace_existing);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_description_merge_static([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc_to_merge, bool replace_existing);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_description_set_absolute_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc, double size);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_description_set_family([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc, string family);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_description_set_family_static([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc, string family);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_description_set_features([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc, string features);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_description_set_features_static([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc, string features);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_description_set_gravity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc, MentorLake.Pango.PangoGravity gravity);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_description_set_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc, int size);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_description_set_stretch([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc, MentorLake.Pango.PangoStretch stretch);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_description_set_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc, MentorLake.Pango.PangoStyle style);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_description_set_variant([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc, MentorLake.Pango.PangoVariant variant);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_description_set_variations([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc, string variations);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_description_set_variations_static([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc, string variations);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_description_set_weight([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc, MentorLake.Pango.PangoWeight weight);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string pango_font_description_to_filename([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string pango_font_description_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_description_unset_fields([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc, MentorLake.Pango.PangoFontMask to_unset);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoFontDescriptionHandle pango_font_description_from_string(string str);

}

public struct PangoFontDescription
{
	public static MentorLake.Pango.PangoFontDescriptionHandle FromString(string str)
	{
		return PangoFontDescriptionExterns.pango_font_description_from_string(str);
	}

}
