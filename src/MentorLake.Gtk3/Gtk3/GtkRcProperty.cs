namespace MentorLake.Gtk3.Gtk3;

public class GtkRcPropertyHandle : BaseSafeHandle
{
}


public static class GtkRcPropertyHandleExtensions
{
	public static bool ParseBorder(GParamSpecHandle pspec, GStringHandle gstring, GValueHandle property_value)
	{
		return GtkRcPropertyExterns.gtk_rc_property_parse_border(pspec, gstring, property_value);
	}

	public static bool ParseColor(GParamSpecHandle pspec, GStringHandle gstring, GValueHandle property_value)
	{
		return GtkRcPropertyExterns.gtk_rc_property_parse_color(pspec, gstring, property_value);
	}

	public static bool ParseEnum(GParamSpecHandle pspec, GStringHandle gstring, GValueHandle property_value)
	{
		return GtkRcPropertyExterns.gtk_rc_property_parse_enum(pspec, gstring, property_value);
	}

	public static bool ParseFlags(GParamSpecHandle pspec, GStringHandle gstring, GValueHandle property_value)
	{
		return GtkRcPropertyExterns.gtk_rc_property_parse_flags(pspec, gstring, property_value);
	}

	public static bool ParseRequisition(GParamSpecHandle pspec, GStringHandle gstring, GValueHandle property_value)
	{
		return GtkRcPropertyExterns.gtk_rc_property_parse_requisition(pspec, gstring, property_value);
	}

}
internal class GtkRcPropertyExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_rc_property_parse_border(GParamSpecHandle pspec, GStringHandle gstring, GValueHandle property_value);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_rc_property_parse_color(GParamSpecHandle pspec, GStringHandle gstring, GValueHandle property_value);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_rc_property_parse_enum(GParamSpecHandle pspec, GStringHandle gstring, GValueHandle property_value);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_rc_property_parse_flags(GParamSpecHandle pspec, GStringHandle gstring, GValueHandle property_value);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_rc_property_parse_requisition(GParamSpecHandle pspec, GStringHandle gstring, GValueHandle property_value);

}

public struct GtkRcProperty
{
	public GQuark type_name;
	public GQuark property_name;
	public string origin;
	public GValue value;
}
