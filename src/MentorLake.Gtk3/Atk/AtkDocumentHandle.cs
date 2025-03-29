namespace MentorLake.Atk;

public interface AtkDocumentHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class AtkDocumentHandleImpl : BaseSafeHandle, AtkDocumentHandle
{
}

public static class AtkDocumentHandleExtensions
{
	public static string GetAttributeValue(this MentorLake.Atk.AtkDocumentHandle document, string attribute_name)
	{
		if (document.IsInvalid || document.IsClosed) throw new Exception("Invalid or closed handle (AtkDocumentHandle)");
		return AtkDocumentHandleExterns.atk_document_get_attribute_value(document, attribute_name);
	}

	public static MentorLake.Atk.AtkAttributeSetHandle GetAttributes(this MentorLake.Atk.AtkDocumentHandle document)
	{
		if (document.IsInvalid || document.IsClosed) throw new Exception("Invalid or closed handle (AtkDocumentHandle)");
		return AtkDocumentHandleExterns.atk_document_get_attributes(document);
	}

	public static int GetCurrentPageNumber(this MentorLake.Atk.AtkDocumentHandle document)
	{
		if (document.IsInvalid || document.IsClosed) throw new Exception("Invalid or closed handle (AtkDocumentHandle)");
		return AtkDocumentHandleExterns.atk_document_get_current_page_number(document);
	}

	public static IntPtr GetDocument(this MentorLake.Atk.AtkDocumentHandle document)
	{
		if (document.IsInvalid || document.IsClosed) throw new Exception("Invalid or closed handle (AtkDocumentHandle)");
		return AtkDocumentHandleExterns.atk_document_get_document(document);
	}

	public static string GetDocumentType(this MentorLake.Atk.AtkDocumentHandle document)
	{
		if (document.IsInvalid || document.IsClosed) throw new Exception("Invalid or closed handle (AtkDocumentHandle)");
		return AtkDocumentHandleExterns.atk_document_get_document_type(document);
	}

	public static string GetLocale(this MentorLake.Atk.AtkDocumentHandle document)
	{
		if (document.IsInvalid || document.IsClosed) throw new Exception("Invalid or closed handle (AtkDocumentHandle)");
		return AtkDocumentHandleExterns.atk_document_get_locale(document);
	}

	public static int GetPageCount(this MentorLake.Atk.AtkDocumentHandle document)
	{
		if (document.IsInvalid || document.IsClosed) throw new Exception("Invalid or closed handle (AtkDocumentHandle)");
		return AtkDocumentHandleExterns.atk_document_get_page_count(document);
	}

	public static MentorLake.GLib.GArrayHandle GetTextSelections(this MentorLake.Atk.AtkDocumentHandle document)
	{
		if (document.IsInvalid || document.IsClosed) throw new Exception("Invalid or closed handle (AtkDocumentHandle)");
		return AtkDocumentHandleExterns.atk_document_get_text_selections(document);
	}

	public static bool SetAttributeValue(this MentorLake.Atk.AtkDocumentHandle document, string attribute_name, string attribute_value)
	{
		if (document.IsInvalid || document.IsClosed) throw new Exception("Invalid or closed handle (AtkDocumentHandle)");
		return AtkDocumentHandleExterns.atk_document_set_attribute_value(document, attribute_name, attribute_value);
	}

	public static bool SetTextSelections(this MentorLake.Atk.AtkDocumentHandle document, MentorLake.GLib.GArrayHandle selections)
	{
		if (document.IsInvalid || document.IsClosed) throw new Exception("Invalid or closed handle (AtkDocumentHandle)");
		return AtkDocumentHandleExterns.atk_document_set_text_selections(document, selections);
	}

}

internal class AtkDocumentHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_document_get_attribute_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkDocumentHandleImpl>))] MentorLake.Atk.AtkDocumentHandle document, string attribute_name);

	[DllImport(AtkLibrary.Name)]
	internal static extern MentorLake.Atk.AtkAttributeSetHandle atk_document_get_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkDocumentHandleImpl>))] MentorLake.Atk.AtkDocumentHandle document);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_document_get_current_page_number([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkDocumentHandleImpl>))] MentorLake.Atk.AtkDocumentHandle document);

	[DllImport(AtkLibrary.Name)]
	internal static extern IntPtr atk_document_get_document([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkDocumentHandleImpl>))] MentorLake.Atk.AtkDocumentHandle document);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_document_get_document_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkDocumentHandleImpl>))] MentorLake.Atk.AtkDocumentHandle document);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_document_get_locale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkDocumentHandleImpl>))] MentorLake.Atk.AtkDocumentHandle document);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_document_get_page_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkDocumentHandleImpl>))] MentorLake.Atk.AtkDocumentHandle document);

	[DllImport(AtkLibrary.Name)]
	internal static extern MentorLake.GLib.GArrayHandle atk_document_get_text_selections([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkDocumentHandleImpl>))] MentorLake.Atk.AtkDocumentHandle document);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_document_set_attribute_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkDocumentHandleImpl>))] MentorLake.Atk.AtkDocumentHandle document, string attribute_name, string attribute_value);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_document_set_text_selections([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkDocumentHandleImpl>))] MentorLake.Atk.AtkDocumentHandle document, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GArrayHandle>))] MentorLake.GLib.GArrayHandle selections);

}
