namespace MentorLake.Atk;

/// <summary>
/// <para>
/// AtkAttribute is a string name/value pair representing a generic
/// attribute. This can be used to expose additional information from
/// an accessible object as a whole (see atk_object_get_attributes())
/// or an document (see atk_document_get_attributes()). In the case of
/// text attributes (see atk_text_get_default_attributes()),
/// #AtkTextAttribute enum defines all the possible text attribute
/// names. You can use atk_text_attribute_get_name() to get the string
/// name from the enum value. See also atk_text_attribute_for_name()
/// and atk_text_attribute_get_value() for more information.
/// </para>
/// <para>
/// A string name/value pair representing a generic attribute.
/// </para>
/// </summary>

public class AtkAttributeHandle : BaseSafeHandle
{
}


public static class AtkAttributeExtensions
{

	public static AtkAttribute Dereference(this AtkAttributeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkAttribute>(x.DangerousGetHandle());
}
internal class AtkAttributeExterns
{
	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_attribute_set_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkAttributeSetHandle>))] MentorLake.Atk.AtkAttributeSetHandle attrib_set);

}

/// <summary>
/// <para>
/// AtkAttribute is a string name/value pair representing a generic
/// attribute. This can be used to expose additional information from
/// an accessible object as a whole (see atk_object_get_attributes())
/// or an document (see atk_document_get_attributes()). In the case of
/// text attributes (see atk_text_get_default_attributes()),
/// #AtkTextAttribute enum defines all the possible text attribute
/// names. You can use atk_text_attribute_get_name() to get the string
/// name from the enum value. See also atk_text_attribute_for_name()
/// and atk_text_attribute_get_value() for more information.
/// </para>
/// <para>
/// A string name/value pair representing a generic attribute.
/// </para>
/// </summary>

public struct AtkAttribute
{
	/// <summary>
/// <para>
/// The attribute name.
/// </para>
/// </summary>

public string name;
	/// <summary>
/// <para>
/// the value of the attribute, represented as a string.
/// </para>
/// </summary>

public string value;
/// <summary>
/// <para>
/// Frees the memory used by an #AtkAttributeSet, including all its
/// #AtkAttributes.
/// </para>
/// </summary>

/// <param name="attrib_set">
/// The #AtkAttributeSet to free
/// </param>

	public static void SetFree(MentorLake.Atk.AtkAttributeSetHandle attrib_set)
	{
		AtkAttributeExterns.atk_attribute_set_free(attrib_set);
	}

}
