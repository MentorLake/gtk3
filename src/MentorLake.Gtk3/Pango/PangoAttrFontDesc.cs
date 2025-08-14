namespace MentorLake.Pango;

/// <summary>
/// <para>
/// The `PangoAttrFontDesc` structure is used to store an attribute that
/// sets all aspects of the font description at once.
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// The `PangoAttrFontDesc` structure is used to store an attribute that
/// sets all aspects of the font description at once.
/// </para>
/// </summary>

public struct PangoAttrFontDesc
{
	/// <summary>
/// <para>
/// the common portion of the attribute
/// </para>
/// </summary>

public PangoAttribute attr;
	/// <summary>
/// <para>
/// the font description which is the value of this attribute
/// </para>
/// </summary>

public IntPtr desc;
/// <summary>
/// <para>
/// Create a new font description attribute.
/// </para>
/// <para>
/// This attribute allows setting family, style, weight, variant,
/// stretch, and size simultaneously.
/// </para>
/// </summary>

/// <param name="desc">
/// the font description
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle New(MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		return PangoAttrFontDescExterns.pango_attr_font_desc_new(desc);
	}

}
