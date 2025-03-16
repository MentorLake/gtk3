namespace MentorLake.Atk;

public class AtkActionIfaceHandle : BaseSafeHandle
{
}


public static class AtkActionIfaceExtensions
{

	public static AtkActionIface Dereference(this AtkActionIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkActionIface>(x.DangerousGetHandle());
}
internal class AtkActionIfaceExterns
{
}

public struct AtkActionIface
{
	public IntPtr do_action;
	public IntPtr get_n_actions;
	public IntPtr get_description;
	public IntPtr get_name;
	public IntPtr get_keybinding;
	public IntPtr set_description;
	public IntPtr get_localized_name;
}
