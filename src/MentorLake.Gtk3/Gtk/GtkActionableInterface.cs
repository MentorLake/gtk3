namespace MentorLake.Gtk;

public class GtkActionableInterfaceHandle : BaseSafeHandle
{
}


public static class GtkActionableInterfaceExtensions
{

	public static GtkActionableInterface Dereference(this GtkActionableInterfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkActionableInterface>(x.DangerousGetHandle());
}
internal class GtkActionableInterfaceExterns
{
}

public struct GtkActionableInterface
{
	public IntPtr get_action_name;
	public IntPtr set_action_name;
	public IntPtr get_action_target_value;
	public IntPtr set_action_target_value;
}
