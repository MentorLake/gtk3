namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Defines a part of a CSS document. Because sections are nested into
/// one another, you can use gtk_css_section_get_parent() to get the
/// containing region.
/// </para>
/// </summary>

public class GtkCssSectionHandle : BaseSafeHandle
{
}


public static class GtkCssSectionExtensions
{
/// <summary>
/// <para>
/// Returns the line in the CSS document where this section end.
/// The line number is 0-indexed, so the first line of the document
/// will return 0.
/// This value may change in future invocations of this function if
/// @section is not yet parsed completely. This will for example
/// happen in the GtkCssProvider::parsing-error signal.
/// The end position and line may be identical to the start
/// position and line for sections which failed to parse anything
/// successfully.
/// </para>
/// </summary>

/// <param name="section">
/// the section
/// </param>
/// <return>
/// the line number
/// </return>

	public static uint GetEndLine(this MentorLake.Gtk.GtkCssSectionHandle section)
	{
		if (section.IsInvalid) throw new Exception("Invalid handle (GtkCssSection)");
		return GtkCssSectionExterns.gtk_css_section_get_end_line(section);
	}

/// <summary>
/// <para>
/// Returns the offset in bytes from the start of the current line
/// returned via gtk_css_section_get_end_line().
/// This value may change in future invocations of this function if
/// @section is not yet parsed completely. This will for example
/// happen in the GtkCssProvider::parsing-error signal.
/// The end position and line may be identical to the start
/// position and line for sections which failed to parse anything
/// successfully.
/// </para>
/// </summary>

/// <param name="section">
/// the section
/// </param>
/// <return>
/// the offset in bytes from the start of the line.
/// </return>

	public static uint GetEndPosition(this MentorLake.Gtk.GtkCssSectionHandle section)
	{
		if (section.IsInvalid) throw new Exception("Invalid handle (GtkCssSection)");
		return GtkCssSectionExterns.gtk_css_section_get_end_position(section);
	}

/// <summary>
/// <para>
/// Gets the file that @section was parsed from. If no such file exists,
/// for example because the CSS was loaded via
/// @gtk_css_provider_load_from_data(), then %NULL is returned.
/// </para>
/// </summary>

/// <param name="section">
/// the section
/// </param>
/// <return>
/// the #GFile that @section was parsed from
///     or %NULL if @section was parsed from other data
/// </return>

	public static MentorLake.Gio.GFileHandle GetFile(this MentorLake.Gtk.GtkCssSectionHandle section)
	{
		if (section.IsInvalid) throw new Exception("Invalid handle (GtkCssSection)");
		return GtkCssSectionExterns.gtk_css_section_get_file(section);
	}

/// <summary>
/// <para>
/// Gets the parent section for the given @section. The parent section is
/// the section that contains this @section. A special case are sections of
/// type #GTK_CSS_SECTION_DOCUMENT. Their parent will either be %NULL
/// if they are the original CSS document that was loaded by
/// gtk_css_provider_load_from_file() or a section of type
/// #GTK_CSS_SECTION_IMPORT if it was loaded with an import rule from
/// a different file.
/// </para>
/// </summary>

/// <param name="section">
/// the section
/// </param>
/// <return>
/// the parent section or %NULL if none
/// </return>

	public static MentorLake.Gtk.GtkCssSectionHandle GetParent(this MentorLake.Gtk.GtkCssSectionHandle section)
	{
		if (section.IsInvalid) throw new Exception("Invalid handle (GtkCssSection)");
		return GtkCssSectionExterns.gtk_css_section_get_parent(section);
	}

/// <summary>
/// <para>
/// Gets the type of information that @section describes.
/// </para>
/// </summary>

/// <param name="section">
/// the section
/// </param>
/// <return>
/// the type of @section
/// </return>

	public static MentorLake.Gtk.GtkCssSectionType GetSectionType(this MentorLake.Gtk.GtkCssSectionHandle section)
	{
		if (section.IsInvalid) throw new Exception("Invalid handle (GtkCssSection)");
		return GtkCssSectionExterns.gtk_css_section_get_section_type(section);
	}

/// <summary>
/// <para>
/// Returns the line in the CSS document where this section starts.
/// The line number is 0-indexed, so the first line of the document
/// will return 0.
/// </para>
/// </summary>

/// <param name="section">
/// the section
/// </param>
/// <return>
/// the line number
/// </return>

	public static uint GetStartLine(this MentorLake.Gtk.GtkCssSectionHandle section)
	{
		if (section.IsInvalid) throw new Exception("Invalid handle (GtkCssSection)");
		return GtkCssSectionExterns.gtk_css_section_get_start_line(section);
	}

/// <summary>
/// <para>
/// Returns the offset in bytes from the start of the current line
/// returned via gtk_css_section_get_start_line().
/// </para>
/// </summary>

/// <param name="section">
/// the section
/// </param>
/// <return>
/// the offset in bytes from the start of the line.
/// </return>

	public static uint GetStartPosition(this MentorLake.Gtk.GtkCssSectionHandle section)
	{
		if (section.IsInvalid) throw new Exception("Invalid handle (GtkCssSection)");
		return GtkCssSectionExterns.gtk_css_section_get_start_position(section);
	}

/// <summary>
/// <para>
/// Increments the reference count on @section.
/// </para>
/// </summary>

/// <param name="section">
/// a #GtkCssSection
/// </param>
/// <return>
/// @section itself.
/// </return>

	public static MentorLake.Gtk.GtkCssSectionHandle Ref(this MentorLake.Gtk.GtkCssSectionHandle section)
	{
		if (section.IsInvalid) throw new Exception("Invalid handle (GtkCssSection)");
		return GtkCssSectionExterns.gtk_css_section_ref(section);
	}

/// <summary>
/// <para>
/// Decrements the reference count on @section, freeing the
/// structure if the reference count reaches 0.
/// </para>
/// </summary>

/// <param name="section">
/// a #GtkCssSection
/// </param>

	public static void Unref(this MentorLake.Gtk.GtkCssSectionHandle section)
	{
		if (section.IsInvalid) throw new Exception("Invalid handle (GtkCssSection)");
		GtkCssSectionExterns.gtk_css_section_unref(section);
	}


	public static GtkCssSection Dereference(this GtkCssSectionHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCssSection>(x.DangerousGetHandle());
}
internal class GtkCssSectionExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_css_section_get_end_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCssSectionHandle>))] MentorLake.Gtk.GtkCssSectionHandle section);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_css_section_get_end_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCssSectionHandle>))] MentorLake.Gtk.GtkCssSectionHandle section);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle gtk_css_section_get_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCssSectionHandle>))] MentorLake.Gtk.GtkCssSectionHandle section);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCssSectionHandle>))]
	internal static extern MentorLake.Gtk.GtkCssSectionHandle gtk_css_section_get_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCssSectionHandle>))] MentorLake.Gtk.GtkCssSectionHandle section);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkCssSectionType gtk_css_section_get_section_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCssSectionHandle>))] MentorLake.Gtk.GtkCssSectionHandle section);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_css_section_get_start_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCssSectionHandle>))] MentorLake.Gtk.GtkCssSectionHandle section);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_css_section_get_start_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCssSectionHandle>))] MentorLake.Gtk.GtkCssSectionHandle section);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCssSectionHandle>))]
	internal static extern MentorLake.Gtk.GtkCssSectionHandle gtk_css_section_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCssSectionHandle>))] MentorLake.Gtk.GtkCssSectionHandle section);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_css_section_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCssSectionHandle>))] MentorLake.Gtk.GtkCssSectionHandle section);

}

/// <summary>
/// <para>
/// Defines a part of a CSS document. Because sections are nested into
/// one another, you can use gtk_css_section_get_parent() to get the
/// containing region.
/// </para>
/// </summary>

public struct GtkCssSection
{
}
