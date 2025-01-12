namespace MentorLake.Gtk3.Gtk3;

public class GtkCssSectionHandle : BaseSafeHandle
{
}


public static class GtkCssSectionHandleExtensions
{
	public static uint GetEndLine(this GtkCssSectionHandle section)
	{
		return GtkCssSectionExterns.gtk_css_section_get_end_line(section);
	}

	public static uint GetEndPosition(this GtkCssSectionHandle section)
	{
		return GtkCssSectionExterns.gtk_css_section_get_end_position(section);
	}

	public static GFileHandle GetFile(this GtkCssSectionHandle section)
	{
		return GtkCssSectionExterns.gtk_css_section_get_file(section);
	}

	public static GtkCssSectionHandle GetParent(this GtkCssSectionHandle section)
	{
		return GtkCssSectionExterns.gtk_css_section_get_parent(section);
	}

	public static GtkCssSectionType GetSectionType(this GtkCssSectionHandle section)
	{
		return GtkCssSectionExterns.gtk_css_section_get_section_type(section);
	}

	public static uint GetStartLine(this GtkCssSectionHandle section)
	{
		return GtkCssSectionExterns.gtk_css_section_get_start_line(section);
	}

	public static uint GetStartPosition(this GtkCssSectionHandle section)
	{
		return GtkCssSectionExterns.gtk_css_section_get_start_position(section);
	}

	public static GtkCssSectionHandle Ref(this GtkCssSectionHandle section)
	{
		return GtkCssSectionExterns.gtk_css_section_ref(section);
	}

	public static GtkCssSectionHandle Unref(this GtkCssSectionHandle section)
	{
		GtkCssSectionExterns.gtk_css_section_unref(section);
		return section;
	}

}
internal class GtkCssSectionExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_css_section_get_end_line(GtkCssSectionHandle section);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_css_section_get_end_position(GtkCssSectionHandle section);

	[DllImport(Libraries.Gtk3)]
	internal static extern GFileHandle gtk_css_section_get_file(GtkCssSectionHandle section);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkCssSectionHandle gtk_css_section_get_parent(GtkCssSectionHandle section);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkCssSectionType gtk_css_section_get_section_type(GtkCssSectionHandle section);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_css_section_get_start_line(GtkCssSectionHandle section);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_css_section_get_start_position(GtkCssSectionHandle section);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkCssSectionHandle gtk_css_section_ref(GtkCssSectionHandle section);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_css_section_unref(GtkCssSectionHandle section);

}

public struct GtkCssSection
{
}
