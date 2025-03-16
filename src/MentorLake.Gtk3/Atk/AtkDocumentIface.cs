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
	public IntPtr get_document_type;
	public IntPtr get_document;
	public IntPtr get_document_locale;
	public IntPtr get_document_attributes;
	public IntPtr get_document_attribute_value;
	public IntPtr set_document_attribute;
	public IntPtr get_current_page_number;
	public IntPtr get_page_count;
	public IntPtr get_text_selections;
	public IntPtr set_text_selections;
}
