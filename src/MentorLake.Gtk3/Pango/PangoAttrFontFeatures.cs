namespace MentorLake.Pango;

/// <summary>
/// <para>
/// The `PangoAttrFontFeatures` structure is used to represent OpenType
/// font features as an attribute.
/// </para>
/// </summary>

public class PangoAttrFontFeaturesHandle : BaseSafeHandle
{
}


public static class PangoAttrFontFeaturesExtensions
{

	public static PangoAttrFontFeatures Dereference(this PangoAttrFontFeaturesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoAttrFontFeatures>(x.DangerousGetHandle());
}
internal class PangoAttrFontFeaturesExterns
{
	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_font_features_new(string features);

}

/// <summary>
/// <para>
/// The `PangoAttrFontFeatures` structure is used to represent OpenType
/// font features as an attribute.
/// </para>
/// </summary>

public struct PangoAttrFontFeatures
{
	/// <summary>
/// <para>
/// the common portion of the attribute
/// </para>
/// </summary>

public PangoAttribute attr;
	/// <summary>
/// <para>
/// the features, as a string in CSS syntax
/// </para>
/// </summary>

public string features;
/// <summary>
/// <para>
/// Create a new font features tag attribute.
/// </para>
/// <para>
/// You can use this attribute to select OpenType font features like small-caps,
/// alternative glyphs, ligatures, etc. for fonts that support them.
/// </para>
/// </summary>

/// <param name="features">
/// a string with OpenType font features, with the syntax of the [CSS
/// font-feature-settings property](https://www.w3.org/TR/css-fonts-4/#font-rend-desc)
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle New(string features)
	{
		return PangoAttrFontFeaturesExterns.pango_attr_font_features_new(features);
	}

}
