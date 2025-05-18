namespace MentorLake.Pango;

public class PangoAttrFontDescHandle : BaseSafeHandle
{
}


public static class PangoAttrFontDescExtensions
{

	public static PangoAttrFontDesc Dereference(this PangoAttrFontDescHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoAttrFontDesc>(x.DangerousGetHandle());
}
internal class PangoAttrFontDescExterns
{
	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_font_desc_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

}

public struct PangoAttrFontDesc
{
	public PangoAttribute attr;
	public IntPtr desc;
	public static MentorLake.Pango.PangoAttributeHandle New(MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		return PangoAttrFontDescExterns.pango_attr_font_desc_new(desc);
	}

}
