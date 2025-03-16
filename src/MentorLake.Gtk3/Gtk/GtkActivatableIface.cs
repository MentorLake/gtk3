namespace MentorLake.Gtk;

public class GtkActivatableIfaceHandle : BaseSafeHandle
{
}


public static class GtkActivatableIfaceExtensions
{

	public static GtkActivatableIface Dereference(this GtkActivatableIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkActivatableIface>(x.DangerousGetHandle());
}
internal class GtkActivatableIfaceExterns
{
}

public struct GtkActivatableIface
{
	public IntPtr update;
	public IntPtr sync_action_properties;
}
