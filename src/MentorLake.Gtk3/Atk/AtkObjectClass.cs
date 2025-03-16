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
	public IntPtr connect_property_change_handler;
	public IntPtr remove_property_change_handler;
	public IntPtr initialize;
	public IntPtr children_changed;
	public IntPtr focus_event;
	public IntPtr property_change;
	public IntPtr state_change;
	public IntPtr visible_data_changed;
	public IntPtr active_descendant_changed;
	public IntPtr get_attributes;
	public IntPtr get_object_locale;
	public AtkFunction pad1;
}
