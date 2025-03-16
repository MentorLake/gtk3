namespace MentorLake.Atk;

public class AtkSelectionIfaceHandle : BaseSafeHandle
{
}


public static class AtkSelectionIfaceExtensions
{

	public static AtkSelectionIface Dereference(this AtkSelectionIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkSelectionIface>(x.DangerousGetHandle());
}
internal class AtkSelectionIfaceExterns
{
}

public struct AtkSelectionIface
{
	public GTypeInterface parent;
	public IntPtr add_selection;
	public IntPtr clear_selection;
	public IntPtr ref_selection;
	public IntPtr get_selection_count;
	public IntPtr is_child_selected;
	public IntPtr remove_selection;
	public IntPtr select_all_selection;
	public IntPtr selection_changed;
}
