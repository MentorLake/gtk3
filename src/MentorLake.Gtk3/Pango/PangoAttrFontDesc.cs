namespace MentorLake.Gtk3.Pango;

public class PangoAttrFontDescHandle : BaseSafeHandle
{
}


public static class PangoAttrFontDescHandleExtensions
{
	public static PangoAttributeHandle New(PangoFontDescriptionHandle desc)
	{
		return PangoAttrFontDescExterns.pango_attr_font_desc_new(desc);
	}

}
internal class PangoAttrFontDescExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern PangoAttributeHandle pango_attr_font_desc_new(PangoFontDescriptionHandle desc);

}

public struct PangoAttrFontDesc
{
	public PangoAttribute attr;
	public PangoFontDescriptionHandle desc;
}
