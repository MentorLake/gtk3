namespace MentorLake.Atk;


public class AtkObjectClassHandle : BaseSafeHandle
{
}


public static class AtkObjectClassExtensions
{

	public static AtkObjectClass Dereference(this AtkObjectClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkObjectClass>(x.DangerousGetHandle());
}
internal class AtkObjectClassExterns
{
}


public struct AtkObjectClass
{
	
public GObjectClass parent;
	
public IntPtr get_name;
	
public IntPtr get_description;
	
public IntPtr get_parent;
	
public IntPtr get_n_children;
	
public IntPtr ref_child;
	
public IntPtr get_index_in_parent;
	
public IntPtr ref_relation_set;
	
public IntPtr get_role;
	
public IntPtr get_layer;
	
public IntPtr get_mdi_zorder;
	
public IntPtr ref_state_set;
	
public IntPtr set_name;
	
public IntPtr set_description;
	
public IntPtr set_parent;
	
public IntPtr set_role;
	/// <summary>
/// <para>
/// specifies a function to be called
///   when a property changes value. This virtual function is
///   deprecated since 2.12 and it should not be overriden. Connect
///   directly to property-change or notify signal instead.
/// </para>
/// </summary>

public IntPtr connect_property_change_handler;
	/// <summary>
/// <para>
/// removes a property changed handler
///   as returned by @connect_property_change_handler. This virtual
///   function is deprecated sice 2.12 and it should not be overriden.
/// </para>
/// </summary>

public IntPtr remove_property_change_handler;
	
public IntPtr initialize;
	
public IntPtr children_changed;
	/// <summary>
/// <para>
/// The signal handler which is executed when there is a
///   focus event for an object. This virtual function is deprecated
///   since 2.9.4 and it should not be overriden. Use
///   the #AtkObject::state-change "focused" signal instead.
/// </para>
/// </summary>

public IntPtr focus_event;
	
public IntPtr property_change;
	
public IntPtr state_change;
	
public IntPtr visible_data_changed;
	
public IntPtr active_descendant_changed;
	
public IntPtr get_attributes;
	
public IntPtr get_object_locale;
	
public AtkFunction pad1;
}
