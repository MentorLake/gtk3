namespace MentorLake.Gtk3.Atk;

public interface AtkDocumentHandle
{
}

internal class AtkDocumentHandleImpl : BaseSafeHandle, AtkDocumentHandle
{
}

public static class AtkDocumentHandleExtensions
{
	public static string GetAttributeValue(this AtkDocumentHandle document, string attribute_name)
	{
		return AtkDocumentExterns.atk_document_get_attribute_value(document, attribute_name);
	}

	public static AtkAttributeSetHandle GetAttributes(this AtkDocumentHandle document)
	{
		return AtkDocumentExterns.atk_document_get_attributes(document);
	}

	public static int GetCurrentPageNumber(this AtkDocumentHandle document)
	{
		return AtkDocumentExterns.atk_document_get_current_page_number(document);
	}

	public static IntPtr GetDocument(this AtkDocumentHandle document)
	{
		return AtkDocumentExterns.atk_document_get_document(document);
	}

	public static string GetDocumentType(this AtkDocumentHandle document)
	{
		return AtkDocumentExterns.atk_document_get_document_type(document);
	}

	public static string GetLocale(this AtkDocumentHandle document)
	{
		return AtkDocumentExterns.atk_document_get_locale(document);
	}

	public static int GetPageCount(this AtkDocumentHandle document)
	{
		return AtkDocumentExterns.atk_document_get_page_count(document);
	}

	public static bool SetAttributeValue(this AtkDocumentHandle document, string attribute_name, string attribute_value)
	{
		return AtkDocumentExterns.atk_document_set_attribute_value(document, attribute_name, attribute_value);
	}

}

internal class AtkDocumentExterns
{
	[DllImport(Libraries.Atk)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_document_get_attribute_value(AtkDocumentHandle document, string attribute_name);

	[DllImport(Libraries.Atk)]
	internal static extern AtkAttributeSetHandle atk_document_get_attributes(AtkDocumentHandle document);

	[DllImport(Libraries.Atk)]
	internal static extern int atk_document_get_current_page_number(AtkDocumentHandle document);

	[DllImport(Libraries.Atk)]
	internal static extern IntPtr atk_document_get_document(AtkDocumentHandle document);

	[DllImport(Libraries.Atk)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_document_get_document_type(AtkDocumentHandle document);

	[DllImport(Libraries.Atk)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_document_get_locale(AtkDocumentHandle document);

	[DllImport(Libraries.Atk)]
	internal static extern int atk_document_get_page_count(AtkDocumentHandle document);

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_document_set_attribute_value(AtkDocumentHandle document, string attribute_name, string attribute_value);

}
