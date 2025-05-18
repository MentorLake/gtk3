namespace MentorLake.Gtk;

public class GtkCssSectionHandle : BaseSafeHandle
{
}


public static class GtkCssSectionExtensions
{
	public static uint GetEndLine(this MentorLake.Gtk.GtkCssSectionHandle section)
	{
		if (section.IsInvalid) throw new Exception("Invalid handle (GtkCssSection)");
		return GtkCssSectionExterns.gtk_css_section_get_end_line(section);
	}

	public static uint GetEndPosition(this MentorLake.Gtk.GtkCssSectionHandle section)
	{
		if (section.IsInvalid) throw new Exception("Invalid handle (GtkCssSection)");
		return GtkCssSectionExterns.gtk_css_section_get_end_position(section);
	}

	public static MentorLake.Gio.GFileHandle GetFile(this MentorLake.Gtk.GtkCssSectionHandle section)
	{
		if (section.IsInvalid) throw new Exception("Invalid handle (GtkCssSection)");
		return GtkCssSectionExterns.gtk_css_section_get_file(section);
	}

	public static MentorLake.Gtk.GtkCssSectionHandle GetParent(this MentorLake.Gtk.GtkCssSectionHandle section)
	{
		if (section.IsInvalid) throw new Exception("Invalid handle (GtkCssSection)");
		return GtkCssSectionExterns.gtk_css_section_get_parent(section);
	}

	public static MentorLake.Gtk.GtkCssSectionType GetSectionType(this MentorLake.Gtk.GtkCssSectionHandle section)
	{
		if (section.IsInvalid) throw new Exception("Invalid handle (GtkCssSection)");
		return GtkCssSectionExterns.gtk_css_section_get_section_type(section);
	}

	public static uint GetStartLine(this MentorLake.Gtk.GtkCssSectionHandle section)
	{
		if (section.IsInvalid) throw new Exception("Invalid handle (GtkCssSection)");
		return GtkCssSectionExterns.gtk_css_section_get_start_line(section);
	}

	public static uint GetStartPosition(this MentorLake.Gtk.GtkCssSectionHandle section)
	{
		if (section.IsInvalid) throw new Exception("Invalid handle (GtkCssSection)");
		return GtkCssSectionExterns.gtk_css_section_get_start_position(section);
	}

	public static MentorLake.Gtk.GtkCssSectionHandle Ref(this MentorLake.Gtk.GtkCssSectionHandle section)
	{
		if (section.IsInvalid) throw new Exception("Invalid handle (GtkCssSection)");
		return GtkCssSectionExterns.gtk_css_section_ref(section);
	}

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

public struct GtkCssSection
{
}
