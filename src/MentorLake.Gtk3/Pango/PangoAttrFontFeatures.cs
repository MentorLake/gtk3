namespace MentorLake.Pango;

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

public struct PangoAttrFontFeatures
{
	public PangoAttribute attr;
	public string features;
	public static MentorLake.Pango.PangoAttributeHandle New(string features)
	{
		return PangoAttrFontFeaturesExterns.pango_attr_font_features_new(features);
	}

}
