namespace MentorLake.Atk;

/// <summary>
/// <para>
/// The ATK interface which represents the toplevel
///  container for document content.
/// </para>
/// <para>
/// The AtkDocument interface should be supported by any object whose
/// content is a representation or view of a document.  The AtkDocument
/// interface should appear on the toplevel container for the document
/// content; however AtkDocument instances may be nested (i.e. an
/// AtkDocument may be a descendant of another AtkDocument) in those
/// cases where one document contains "embedded content" which can
/// reasonably be considered a document in its own right.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Retrieves the value of the given @attribute_name inside @document.
/// </para>
/// </summary>

/// <param name="document">
/// a #GObject instance that implements AtkDocumentIface
/// </param>
/// <param name="attribute_name">
/// a character string representing the name of the attribute
///   whose value is being queried.
/// </param>
/// <return>
/// a string value associated with the named
///    attribute for this document, or %NULL if a value for
///    @attribute_name has not been specified for this document.
/// </return>

	public static string GetAttributeValue(this MentorLake.Atk.AtkDocumentHandle document, string attribute_name)
	{
		if (document.IsInvalid) throw new Exception("Invalid handle (AtkDocumentHandle)");
		return AtkDocumentHandleExterns.atk_document_get_attribute_value(document, attribute_name);
	}

/// <summary>
/// <para>
/// Gets an AtkAttributeSet which describes document-wide
///          attributes as name-value pairs.
/// </para>
/// </summary>

/// <param name="document">
/// a #GObject instance that implements AtkDocumentIface
/// </param>
/// <return>
/// An AtkAttributeSet containing the explicitly
///          set name-value-pair attributes associated with this document
///          as a whole.
/// </return>

	public static MentorLake.Atk.AtkAttributeSetHandle GetAttributes(this MentorLake.Atk.AtkDocumentHandle document)
	{
		if (document.IsInvalid) throw new Exception("Invalid handle (AtkDocumentHandle)");
		return AtkDocumentHandleExterns.atk_document_get_attributes(document);
	}

/// <summary>
/// <para>
/// Retrieves the current page number inside @document.
/// </para>
/// </summary>

/// <param name="document">
/// the #AtkDocument
/// </param>
/// <return>
/// the current page number inside @document, or -1 if
///   not implemented, not know by the implementor, or irrelevant.
/// </return>

	public static int GetCurrentPageNumber(this MentorLake.Atk.AtkDocumentHandle document)
	{
		if (document.IsInvalid) throw new Exception("Invalid handle (AtkDocumentHandle)");
		return AtkDocumentHandleExterns.atk_document_get_current_page_number(document);
	}

/// <summary>
/// <para>
/// Gets a %gpointer that points to an instance of the DOM.  It is
/// up to the caller to check atk_document_get_type to determine
/// how to cast this pointer.
/// </para>
/// </summary>

/// <param name="document">
/// a #GObject instance that implements AtkDocumentIface
/// </param>
/// <return>
/// a %gpointer that points to an instance of the DOM.
/// </return>

	public static IntPtr GetDocument(this MentorLake.Atk.AtkDocumentHandle document)
	{
		if (document.IsInvalid) throw new Exception("Invalid handle (AtkDocumentHandle)");
		return AtkDocumentHandleExterns.atk_document_get_document(document);
	}

/// <summary>
/// <para>
/// Gets a string indicating the document type.
/// </para>
/// </summary>

/// <param name="document">
/// a #GObject instance that implements AtkDocumentIface
/// </param>
/// <return>
/// a string indicating the document type
/// </return>

	public static string GetDocumentType(this MentorLake.Atk.AtkDocumentHandle document)
	{
		if (document.IsInvalid) throw new Exception("Invalid handle (AtkDocumentHandle)");
		return AtkDocumentHandleExterns.atk_document_get_document_type(document);
	}

/// <summary>
/// <para>
/// Gets a UTF-8 string indicating the POSIX-style LC_MESSAGES locale
///          of the content of this document instance.  Individual
///          text substrings or images within this document may have
///          a different locale, see atk_text_get_attributes and
///          atk_image_get_image_locale.
/// </para>
/// </summary>

/// <param name="document">
/// a #GObject instance that implements AtkDocumentIface
/// </param>
/// <return>
/// a UTF-8 string indicating the POSIX-style LC_MESSAGES
///          locale of the document content as a whole, or NULL if
///          the document content does not specify a locale.
/// </return>

	public static string GetLocale(this MentorLake.Atk.AtkDocumentHandle document)
	{
		if (document.IsInvalid) throw new Exception("Invalid handle (AtkDocumentHandle)");
		return AtkDocumentHandleExterns.atk_document_get_locale(document);
	}

/// <summary>
/// <para>
/// Retrieves the total number of pages inside @document.
/// </para>
/// </summary>

/// <param name="document">
/// the #AtkDocument
/// </param>
/// <return>
/// total page count of @document, or -1 if not implemented,
///   not know by the implementor or irrelevant.
/// </return>

	public static int GetPageCount(this MentorLake.Atk.AtkDocumentHandle document)
	{
		if (document.IsInvalid) throw new Exception("Invalid handle (AtkDocumentHandle)");
		return AtkDocumentHandleExterns.atk_document_get_page_count(document);
	}

/// <summary>
/// <para>
/// Returns an array of AtkTextSelections within this document.
/// </para>
/// </summary>

/// <param name="document">
/// an #AtkDocument
/// </param>
/// <return>
/// a GArray of
/// AtkTextSelection structures representing the selection.
/// </return>

	public static MentorLake.GLib.GArrayHandle GetTextSelections(this MentorLake.Atk.AtkDocumentHandle document)
	{
		if (document.IsInvalid) throw new Exception("Invalid handle (AtkDocumentHandle)");
		return AtkDocumentHandleExterns.atk_document_get_text_selections(document);
	}

/// <summary>
/// <para>
/// Sets the value for the given @attribute_name inside @document.
/// </para>
/// </summary>

/// <param name="document">
/// a #GObject instance that implements #AtkDocumentIface
/// </param>
/// <param name="attribute_name">
/// a character string representing the name of the attribute
///   whose value is being set.
/// </param>
/// <param name="attribute_value">
/// a string value to be associated with @attribute_name.
/// </param>
/// <return>
/// %TRUE if @attribute_value is successfully associated
///   with @attribute_name for this @document, and %FALSE if if the
///   document does not allow the attribute to be modified
/// </return>

	public static bool SetAttributeValue(this MentorLake.Atk.AtkDocumentHandle document, string attribute_name, string attribute_value)
	{
		if (document.IsInvalid) throw new Exception("Invalid handle (AtkDocumentHandle)");
		return AtkDocumentHandleExterns.atk_document_set_attribute_value(document, attribute_name, attribute_value);
	}

/// <summary>
/// <para>
/// Makes 1 or more selections within this document denoted by the given
/// array of AtkTextSelections. Any existing physical selection (inside or
/// outside this document) is replaced by the new selections. All objects within
/// the given selection ranges must be descendants of this document. Otherwise
/// FALSE will be returned.
/// </para>
/// </summary>

/// <param name="document">
/// an #AtkDocument.
/// </param>
/// <param name="selections">
/// a GArray of AtkTextSelections
///              to be selected.
/// </param>
/// <return>
/// TRUE if the selection was made successfully; FALSE otherwise.
/// </return>

	public static bool SetTextSelections(this MentorLake.Atk.AtkDocumentHandle document, MentorLake.GLib.GArrayHandle selections)
	{
		if (document.IsInvalid) throw new Exception("Invalid handle (AtkDocumentHandle)");
		return AtkDocumentHandleExterns.atk_document_set_text_selections(document, selections);
	}

}

internal class AtkDocumentHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_document_get_attribute_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkDocumentHandleImpl>))] MentorLake.Atk.AtkDocumentHandle document, string attribute_name);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkAttributeSetHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GArrayHandle>))]
	internal static extern MentorLake.GLib.GArrayHandle atk_document_get_text_selections([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkDocumentHandleImpl>))] MentorLake.Atk.AtkDocumentHandle document);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_document_set_attribute_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkDocumentHandleImpl>))] MentorLake.Atk.AtkDocumentHandle document, string attribute_name, string attribute_value);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_document_set_text_selections([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkDocumentHandleImpl>))] MentorLake.Atk.AtkDocumentHandle document, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GArrayHandle>))] MentorLake.GLib.GArrayHandle selections);

}
