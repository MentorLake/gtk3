namespace MentorLake.Gtk;

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

public struct GtkRcProperty
{
	public GQuark type_name;
	public GQuark property_name;
	public string origin;
	public GValue value;
	public static bool ParseBorder(MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GLib.GStringHandle gstring, MentorLake.GObject.GValueHandle property_value)
	{
		return GtkRcPropertyExterns.gtk_rc_property_parse_border(pspec, gstring, property_value);
	}

	public static bool ParseColor(MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GLib.GStringHandle gstring, MentorLake.GObject.GValueHandle property_value)
	{
		return GtkRcPropertyExterns.gtk_rc_property_parse_color(pspec, gstring, property_value);
	}

	public static bool ParseEnum(MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GLib.GStringHandle gstring, MentorLake.GObject.GValueHandle property_value)
	{
		return GtkRcPropertyExterns.gtk_rc_property_parse_enum(pspec, gstring, property_value);
	}

	public static bool ParseFlags(MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GLib.GStringHandle gstring, MentorLake.GObject.GValueHandle property_value)
	{
		return GtkRcPropertyExterns.gtk_rc_property_parse_flags(pspec, gstring, property_value);
	}

	public static bool ParseRequisition(MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GLib.GStringHandle gstring, MentorLake.GObject.GValueHandle property_value)
	{
		return GtkRcPropertyExterns.gtk_rc_property_parse_requisition(pspec, gstring, property_value);
	}

}
