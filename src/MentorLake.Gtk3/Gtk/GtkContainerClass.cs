namespace MentorLake.Gtk;

public class GtkContainerClassHandle : BaseSafeHandle
{
}


public static class GtkContainerClassExtensions
{
	public static MentorLake.GObject.GParamSpecHandle FindChildProperty(this MentorLake.GObject.GObjectClassHandle cclass, string property_name)
	{
		if (cclass.IsInvalid || cclass.IsClosed) throw new Exception("Invalid or closed handle (GtkContainerClass)");
		return GtkContainerClassExterns.gtk_container_class_find_child_property(cclass, property_name);
	}

	public static void HandleBorderWidth(this MentorLake.Gtk.GtkContainerClassHandle klass)
	{
		if (klass.IsInvalid || klass.IsClosed) throw new Exception("Invalid or closed handle (GtkContainerClass)");
		GtkContainerClassExterns.gtk_container_class_handle_border_width(klass);
	}

	public static void InstallChildProperties(this MentorLake.Gtk.GtkContainerClassHandle cclass, uint n_pspecs, MentorLake.GObject.GParamSpecHandle[] pspecs)
	{
		if (cclass.IsInvalid || cclass.IsClosed) throw new Exception("Invalid or closed handle (GtkContainerClass)");
		GtkContainerClassExterns.gtk_container_class_install_child_properties(cclass, n_pspecs, pspecs);
	}

	public static void InstallChildProperty(this MentorLake.Gtk.GtkContainerClassHandle cclass, uint property_id, MentorLake.GObject.GParamSpecHandle pspec)
	{
		if (cclass.IsInvalid || cclass.IsClosed) throw new Exception("Invalid or closed handle (GtkContainerClass)");
		GtkContainerClassExterns.gtk_container_class_install_child_property(cclass, property_id, pspec);
	}

	public static MentorLake.GObject.GParamSpecHandle[] ListChildProperties(this MentorLake.GObject.GObjectClassHandle cclass, out uint n_properties)
	{
		if (cclass.IsInvalid || cclass.IsClosed) throw new Exception("Invalid or closed handle (GtkContainerClass)");
		return GtkContainerClassExterns.gtk_container_class_list_child_properties(cclass, out n_properties);
	}


	public static GtkContainerClass Dereference(this GtkContainerClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkContainerClass>(x.DangerousGetHandle());
}
internal class GtkContainerClassExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GObject.GParamSpecHandle gtk_container_class_find_child_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectClassHandle>))] MentorLake.GObject.GObjectClassHandle cclass, string property_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_class_handle_border_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerClassHandle>))] MentorLake.Gtk.GtkContainerClassHandle klass);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_class_install_child_properties([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerClassHandle>))] MentorLake.Gtk.GtkContainerClassHandle cclass, uint n_pspecs, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 1, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle[] pspecs);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_class_install_child_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerClassHandle>))] MentorLake.Gtk.GtkContainerClassHandle cclass, uint property_id, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GObject.GParamSpecHandle[] gtk_container_class_list_child_properties([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectClassHandle>))] MentorLake.GObject.GObjectClassHandle cclass, out uint n_properties);

}

public struct GtkContainerClass
{
	public GtkWidgetClass parent_class;
	public IntPtr add;
	public IntPtr remove;
	public IntPtr check_resize;
	public IntPtr forall;
	public IntPtr set_focus_child;
	public IntPtr child_type;
	public IntPtr composite_name;
	public IntPtr set_child_property;
	public IntPtr get_child_property;
	public IntPtr get_path_for_child;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
	public IntPtr _gtk_reserved5;
	public IntPtr _gtk_reserved6;
	public IntPtr _gtk_reserved7;
	public IntPtr _gtk_reserved8;
}
