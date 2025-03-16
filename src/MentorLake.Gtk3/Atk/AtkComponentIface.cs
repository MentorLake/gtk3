namespace MentorLake.Atk;

public class AtkComponentIfaceHandle : BaseSafeHandle
{
}


public static class AtkComponentIfaceExtensions
{

	public static AtkComponentIface Dereference(this AtkComponentIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkComponentIface>(x.DangerousGetHandle());
}
internal class AtkComponentIfaceExterns
{
}

public struct AtkComponentIface
{
	public IntPtr add_focus_handler;
	public IntPtr contains;
	public IntPtr ref_accessible_at_point;
	public IntPtr get_extents;
	public IntPtr get_position;
	public IntPtr get_size;
	public IntPtr grab_focus;
	public IntPtr remove_focus_handler;
	public IntPtr set_extents;
	public IntPtr set_position;
	public IntPtr set_size;
	public IntPtr get_layer;
	public IntPtr get_mdi_zorder;
	public IntPtr bounds_changed;
	public IntPtr get_alpha;
	public IntPtr scroll_to;
	public IntPtr scroll_to_point;
}
