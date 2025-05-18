namespace MentorLake.Pango;

public class PangoAttrLanguageHandle : BaseSafeHandle
{
}


public static class PangoAttrLanguageExtensions
{

	public static PangoAttrLanguage Dereference(this PangoAttrLanguageHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoAttrLanguage>(x.DangerousGetHandle());
}
internal class PangoAttrLanguageExterns
{
	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_language_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLanguageHandle>))] MentorLake.Pango.PangoLanguageHandle language);

}

public struct PangoAttrLanguage
{
	public PangoAttribute attr;
	public IntPtr value;
	public static MentorLake.Pango.PangoAttributeHandle New(MentorLake.Pango.PangoLanguageHandle language)
	{
		return PangoAttrLanguageExterns.pango_attr_language_new(language);
	}

}
