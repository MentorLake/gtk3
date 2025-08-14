namespace MentorLake.Pango;

/// <summary>
/// <para>
/// The `PangoAttrLanguage` structure is used to represent attributes that
/// are languages.
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// The `PangoAttrLanguage` structure is used to represent attributes that
/// are languages.
/// </para>
/// </summary>

public struct PangoAttrLanguage
{
	/// <summary>
/// <para>
/// the common portion of the attribute
/// </para>
/// </summary>

public PangoAttribute attr;
	/// <summary>
/// <para>
/// the `PangoLanguage` which is the value of the attribute
/// </para>
/// </summary>

public IntPtr value;
/// <summary>
/// <para>
/// Create a new language tag attribute.
/// </para>
/// </summary>

/// <param name="language">
/// language tag
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle New(MentorLake.Pango.PangoLanguageHandle language)
	{
		return PangoAttrLanguageExterns.pango_attr_language_new(language);
	}

}
