namespace MentorLake.Gtk3.Pango;

public class PangoAttrLanguageHandle : BaseSafeHandle
{
}


public static class PangoAttrLanguageHandleExtensions
{
	public static PangoAttributeHandle New(PangoLanguageHandle language)
	{
		return PangoAttrLanguageExterns.pango_attr_language_new(language);
	}

}
internal class PangoAttrLanguageExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern PangoAttributeHandle pango_attr_language_new(PangoLanguageHandle language);

}

public struct PangoAttrLanguage
{
	public PangoAttribute attr;
	public PangoLanguageHandle value;
}
