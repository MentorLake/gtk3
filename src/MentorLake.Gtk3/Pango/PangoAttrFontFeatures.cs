namespace MentorLake.Gtk3.Pango;

public class PangoAttrFontFeaturesHandle : BaseSafeHandle
{
}


public static class PangoAttrFontFeaturesHandleExtensions
{
	public static PangoAttributeHandle New(string features)
	{
		return PangoAttrFontFeaturesExterns.pango_attr_font_features_new(features);
	}

}
internal class PangoAttrFontFeaturesExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern PangoAttributeHandle pango_attr_font_features_new(string features);

}

public struct PangoAttrFontFeatures
{
	public PangoAttribute attr;
	public string features;
}
