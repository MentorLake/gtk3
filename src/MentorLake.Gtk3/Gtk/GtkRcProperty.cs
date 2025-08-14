namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

public class GtkRcPropertyHandle : BaseSafeHandle
{
}


public static class GtkRcPropertyExtensions
{

	public static GtkRcProperty Dereference(this GtkRcPropertyHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRcProperty>(x.DangerousGetHandle());
}
internal class GtkRcPropertyExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_rc_property_parse_border([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle gstring, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle property_value);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_rc_property_parse_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle gstring, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle property_value);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_rc_property_parse_enum([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle gstring, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle property_value);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_rc_property_parse_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle gstring, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle property_value);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_rc_property_parse_requisition([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle gstring, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle property_value);

}

/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

public struct GtkRcProperty
{
	/// <summary>
/// <para>
/// quark-ified type identifier
/// </para>
/// </summary>

public GQuark type_name;
	/// <summary>
/// <para>
/// quark-ified property identifier like
///   “GtkScrollbar::spacing”
/// </para>
/// </summary>

public GQuark property_name;
	/// <summary>
/// <para>
/// field similar to one found in #GtkSettingsValue
/// </para>
/// </summary>

public string origin;
	/// <summary>
/// <para>
/// field similar to one found in #GtkSettingsValue
/// </para>
/// </summary>

public GValue value;
/// <summary>
/// <para>
/// A #GtkRcPropertyParser for use with gtk_settings_install_property_parser()
/// or gtk_widget_class_install_style_property_parser() which parses
/// borders in the form
/// `"{ left, right, top, bottom }"` for integers
/// left, right, top and bottom.
/// </para>
/// </summary>

/// <param name="pspec">
/// a #GParamSpec
/// </param>
/// <param name="gstring">
/// the #GString to be parsed
/// </param>
/// <param name="property_value">
/// a #GValue which must hold boxed values.
/// </param>
/// <return>
/// %TRUE if @gstring could be parsed and @property_value
/// has been set to the resulting #GtkBorder.
/// </return>

	public static bool ParseBorder(MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GLib.GStringHandle gstring, MentorLake.GObject.GValueHandle property_value)
	{
		return GtkRcPropertyExterns.gtk_rc_property_parse_border(pspec, gstring, property_value);
	}

/// <summary>
/// <para>
/// A #GtkRcPropertyParser for use with gtk_settings_install_property_parser()
/// or gtk_widget_class_install_style_property_parser() which parses a
/// color given either by its name or in the form
/// `{ red, green, blue }` where red, green and
/// blue are integers between 0 and 65535 or floating-point numbers
/// between 0 and 1.
/// </para>
/// </summary>

/// <param name="pspec">
/// a #GParamSpec
/// </param>
/// <param name="gstring">
/// the #GString to be parsed
/// </param>
/// <param name="property_value">
/// a #GValue which must hold #GdkColor values.
/// </param>
/// <return>
/// %TRUE if @gstring could be parsed and @property_value
/// has been set to the resulting #GdkColor.
/// </return>

	public static bool ParseColor(MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GLib.GStringHandle gstring, MentorLake.GObject.GValueHandle property_value)
	{
		return GtkRcPropertyExterns.gtk_rc_property_parse_color(pspec, gstring, property_value);
	}

/// <summary>
/// <para>
/// A #GtkRcPropertyParser for use with gtk_settings_install_property_parser()
/// or gtk_widget_class_install_style_property_parser() which parses a single
/// enumeration value.
/// </para>
/// <para>
/// The enumeration value can be specified by its name, its nickname or
/// its numeric value. For consistency with flags parsing, the value
/// may be surrounded by parentheses.
/// </para>
/// </summary>

/// <param name="pspec">
/// a #GParamSpec
/// </param>
/// <param name="gstring">
/// the #GString to be parsed
/// </param>
/// <param name="property_value">
/// a #GValue which must hold enum values.
/// </param>
/// <return>
/// %TRUE if @gstring could be parsed and @property_value
/// has been set to the resulting #GEnumValue.
/// </return>

	public static bool ParseEnum(MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GLib.GStringHandle gstring, MentorLake.GObject.GValueHandle property_value)
	{
		return GtkRcPropertyExterns.gtk_rc_property_parse_enum(pspec, gstring, property_value);
	}

/// <summary>
/// <para>
/// A #GtkRcPropertyParser for use with gtk_settings_install_property_parser()
/// or gtk_widget_class_install_style_property_parser() which parses flags.
/// </para>
/// <para>
/// Flags can be specified by their name, their nickname or
/// numerically. Multiple flags can be specified in the form
/// `"( flag1 | flag2 | ... )"`.
/// </para>
/// </summary>

/// <param name="pspec">
/// a #GParamSpec
/// </param>
/// <param name="gstring">
/// the #GString to be parsed
/// </param>
/// <param name="property_value">
/// a #GValue which must hold flags values.
/// </param>
/// <return>
/// %TRUE if @gstring could be parsed and @property_value
/// has been set to the resulting flags value.
/// </return>

	public static bool ParseFlags(MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GLib.GStringHandle gstring, MentorLake.GObject.GValueHandle property_value)
	{
		return GtkRcPropertyExterns.gtk_rc_property_parse_flags(pspec, gstring, property_value);
	}

/// <summary>
/// <para>
/// A #GtkRcPropertyParser for use with gtk_settings_install_property_parser()
/// or gtk_widget_class_install_style_property_parser() which parses a
/// requisition in the form
/// `"{ width, height }"` for integers %width and %height.
/// </para>
/// </summary>

/// <param name="pspec">
/// a #GParamSpec
/// </param>
/// <param name="gstring">
/// the #GString to be parsed
/// </param>
/// <param name="property_value">
/// a #GValue which must hold boxed values.
/// </param>
/// <return>
/// %TRUE if @gstring could be parsed and @property_value
/// has been set to the resulting #GtkRequisition.
/// </return>

	public static bool ParseRequisition(MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GLib.GStringHandle gstring, MentorLake.GObject.GValueHandle property_value)
	{
		return GtkRcPropertyExterns.gtk_rc_property_parse_requisition(pspec, gstring, property_value);
	}

}
