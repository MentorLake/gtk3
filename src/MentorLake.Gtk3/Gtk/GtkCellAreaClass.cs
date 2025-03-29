namespace MentorLake.Gtk;

public class GtkCellAreaClassHandle : BaseSafeHandle
{
}


public static class GtkCellAreaClassExtensions
{
	public static MentorLake.GObject.GParamSpecHandle FindCellProperty(this MentorLake.Gtk.GtkCellAreaClassHandle aclass, string property_name)
	{
		if (aclass.IsInvalid || aclass.IsClosed) throw new Exception("Invalid or closed handle (GtkCellAreaClass)");
		return GtkCellAreaClassExterns.gtk_cell_area_class_find_cell_property(aclass, property_name);
	}

	public static void InstallCellProperty(this MentorLake.Gtk.GtkCellAreaClassHandle aclass, uint property_id, MentorLake.GObject.GParamSpecHandle pspec)
	{
		if (aclass.IsInvalid || aclass.IsClosed) throw new Exception("Invalid or closed handle (GtkCellAreaClass)");
		GtkCellAreaClassExterns.gtk_cell_area_class_install_cell_property(aclass, property_id, pspec);
	}

	public static MentorLake.GObject.GParamSpecHandle[] ListCellProperties(this MentorLake.Gtk.GtkCellAreaClassHandle aclass, out uint n_properties)
	{
		if (aclass.IsInvalid || aclass.IsClosed) throw new Exception("Invalid or closed handle (GtkCellAreaClass)");
		return GtkCellAreaClassExterns.gtk_cell_area_class_list_cell_properties(aclass, out n_properties);
	}


	public static GtkCellAreaClass Dereference(this GtkCellAreaClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCellAreaClass>(x.DangerousGetHandle());
}
internal class GtkCellAreaClassExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GObject.GParamSpecHandle gtk_cell_area_class_find_cell_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaClassHandle>))] MentorLake.Gtk.GtkCellAreaClassHandle aclass, string property_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_class_install_cell_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaClassHandle>))] MentorLake.Gtk.GtkCellAreaClassHandle aclass, uint property_id, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GObject.GParamSpecHandle[] gtk_cell_area_class_list_cell_properties([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaClassHandle>))] MentorLake.Gtk.GtkCellAreaClassHandle aclass, out uint n_properties);

}

public struct GtkCellAreaClass
{
	public IntPtr add;
	public IntPtr remove;
	public IntPtr @foreach;
	public IntPtr foreach_alloc;
	public IntPtr @event;
	public IntPtr render;
	public IntPtr apply_attributes;
	public IntPtr create_context;
	public IntPtr copy_context;
	public IntPtr get_request_mode;
	public IntPtr get_preferred_width;
	public IntPtr get_preferred_height_for_width;
	public IntPtr get_preferred_height;
	public IntPtr get_preferred_width_for_height;
	public IntPtr set_cell_property;
	public IntPtr get_cell_property;
	public IntPtr focus;
	public IntPtr is_activatable;
	public IntPtr activate;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
	public IntPtr _gtk_reserved5;
	public IntPtr _gtk_reserved6;
	public IntPtr _gtk_reserved7;
	public IntPtr _gtk_reserved8;
}
