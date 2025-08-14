namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Base class for containers.
/// </para>
/// </summary>

public class GtkContainerClassHandle : BaseSafeHandle
{
}


public static class GtkContainerClassExtensions
{
/// <summary>
/// <para>
/// Finds a child property of a container class by name.
/// </para>
/// </summary>

/// <param name="cclass">
/// a #GtkContainerClass
/// </param>
/// <param name="property_name">
/// the name of the child property to find
/// </param>
/// <return>
/// the #GParamSpec of the child
///     property or %NULL if @class has no child property with that
///     name.
/// </return>

	public static MentorLake.GObject.GParamSpecHandle FindChildProperty(this MentorLake.GObject.GObjectClassHandle cclass, string property_name)
	{
		if (cclass.IsInvalid) throw new Exception("Invalid handle (GtkContainerClass)");
		return GtkContainerClassExterns.gtk_container_class_find_child_property(cclass, property_name);
	}

/// <summary>
/// <para>
/// Modifies a subclass of #GtkContainerClass to automatically add and
/// remove the border-width setting on GtkContainer.  This allows the
/// subclass to ignore the border width in its size request and
/// allocate methods. The intent is for a subclass to invoke this
/// in its class_init function.
/// </para>
/// <para>
/// gtk_container_class_handle_border_width() is necessary because it
/// would break API too badly to make this behavior the default. So
/// subclasses must “opt in” to the parent class handling border_width
/// for them.
/// </para>
/// </summary>

/// <param name="klass">
/// the class struct of a #GtkContainer subclass
/// </param>

	public static void HandleBorderWidth(this MentorLake.Gtk.GtkContainerClassHandle klass)
	{
		if (klass.IsInvalid) throw new Exception("Invalid handle (GtkContainerClass)");
		GtkContainerClassExterns.gtk_container_class_handle_border_width(klass);
	}

/// <summary>
/// <para>
/// Installs child properties on a container class.
/// </para>
/// </summary>

/// <param name="cclass">
/// a #GtkContainerClass
/// </param>
/// <param name="n_pspecs">
/// the length of the #GParamSpec array
/// </param>
/// <param name="pspecs">
/// the #GParamSpec array defining the new
///     child properties
/// </param>

	public static void InstallChildProperties(this MentorLake.Gtk.GtkContainerClassHandle cclass, uint n_pspecs, MentorLake.GObject.GParamSpecHandle[] pspecs)
	{
		if (cclass.IsInvalid) throw new Exception("Invalid handle (GtkContainerClass)");
		GtkContainerClassExterns.gtk_container_class_install_child_properties(cclass, n_pspecs, pspecs);
	}

/// <summary>
/// <para>
/// Installs a child property on a container class.
/// </para>
/// </summary>

/// <param name="cclass">
/// a #GtkContainerClass
/// </param>
/// <param name="property_id">
/// the id for the property
/// </param>
/// <param name="pspec">
/// the #GParamSpec for the property
/// </param>

	public static void InstallChildProperty(this MentorLake.Gtk.GtkContainerClassHandle cclass, uint property_id, MentorLake.GObject.GParamSpecHandle pspec)
	{
		if (cclass.IsInvalid) throw new Exception("Invalid handle (GtkContainerClass)");
		GtkContainerClassExterns.gtk_container_class_install_child_property(cclass, property_id, pspec);
	}

/// <summary>
/// <para>
/// Returns all child properties of a container class.
/// </para>
/// </summary>

/// <param name="cclass">
/// a #GtkContainerClass
/// </param>
/// <param name="n_properties">
/// location to return the number of child properties found
/// </param>
/// <return>
/// 
///     a newly allocated %NULL-terminated array of #GParamSpec*.
///     The array must be freed with g_free().
/// </return>

	public static MentorLake.GObject.GParamSpecHandle[] ListChildProperties(this MentorLake.GObject.GObjectClassHandle cclass, out uint n_properties)
	{
		if (cclass.IsInvalid) throw new Exception("Invalid handle (GtkContainerClass)");
		return GtkContainerClassExterns.gtk_container_class_list_child_properties(cclass, out n_properties);
	}


	public static GtkContainerClass Dereference(this GtkContainerClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkContainerClass>(x.DangerousGetHandle());
}
internal class GtkContainerClassExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))]
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

/// <summary>
/// <para>
/// Base class for containers.
/// </para>
/// </summary>

public struct GtkContainerClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GtkWidgetClass parent_class;
	/// <summary>
/// <para>
/// Signal emitted when a widget is added to container.
/// </para>
/// </summary>

public IntPtr add;
	/// <summary>
/// <para>
/// Signal emitted when a widget is removed from container.
/// </para>
/// </summary>

public IntPtr remove;
	/// <summary>
/// <para>
/// Signal emitted when a size recalculation is needed.
/// </para>
/// </summary>

public IntPtr check_resize;
	/// <summary>
/// <para>
/// Invokes callback on each child of container. The callback handler
///    may remove the child.
/// </para>
/// </summary>

public IntPtr forall;
	/// <summary>
/// <para>
/// Sets the focused child of container.
/// </para>
/// </summary>

public IntPtr set_focus_child;
	/// <summary>
/// <para>
/// Returns the type of the children supported by the container.
/// </para>
/// </summary>

public IntPtr child_type;
	/// <summary>
/// <para>
/// Gets a widget’s composite name. Deprecated: 3.10.
/// </para>
/// </summary>

public IntPtr composite_name;
	/// <summary>
/// <para>
/// Set a property on a child of container.
/// </para>
/// </summary>

public IntPtr set_child_property;
	/// <summary>
/// <para>
/// Get a property from a child of container.
/// </para>
/// </summary>

public IntPtr get_child_property;
	/// <summary>
/// <para>
/// Get path representing entire widget hierarchy
///    from the toplevel down to and including @child.
/// </para>
/// </summary>

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
