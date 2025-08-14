namespace MentorLake.Atk;


public class AtkDocumentIfaceHandle : BaseSafeHandle
{
}


public static class AtkDocumentIfaceExtensions
{

	public static AtkDocumentIface Dereference(this AtkDocumentIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkDocumentIface>(x.DangerousGetHandle());
}
internal class AtkDocumentIfaceExterns
{
}


public struct AtkDocumentIface
{
	
public GTypeInterface parent;
	/// <summary>
/// <para>
/// gets a string indicating the document
///   type. This virtual function is deprecated since 2.12 and it
///   should not be overriden.
/// </para>
/// </summary>

public IntPtr get_document_type;
	/// <summary>
/// <para>
/// a #GObject instance that implements
///   AtkDocumentIface. This virtual method is deprecated since 2.12
///   and it should not be overriden.
/// </para>
/// </summary>

public IntPtr get_document;
	/// <summary>
/// <para>
/// gets locale. This virtual function is
///   deprecated since 2.7.90 and it should not be overriden.
/// </para>
/// </summary>

public IntPtr get_document_locale;
	/// <summary>
/// <para>
/// gets an AtkAttributeSet which describes
///   document-wide attributes as name-value pairs.
/// </para>
/// </summary>

public IntPtr get_document_attributes;
	/// <summary>
/// <para>
/// returns a string value assocciated
///   with the named attribute for this document, or NULL
/// </para>
/// </summary>

public IntPtr get_document_attribute_value;
	/// <summary>
/// <para>
/// sets the value of an attribute. Returns
///   TRUE on success, FALSE otherwise
/// </para>
/// </summary>

public IntPtr set_document_attribute;
	/// <summary>
/// <para>
/// gets the current page number. Since 2.12
/// </para>
/// </summary>

public IntPtr get_current_page_number;
	/// <summary>
/// <para>
/// gets the page count of the document. Since 2.12
/// </para>
/// </summary>

public IntPtr get_page_count;
	
public IntPtr get_text_selections;
	
public IntPtr set_text_selections;
}
