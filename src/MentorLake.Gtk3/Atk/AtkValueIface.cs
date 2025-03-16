namespace MentorLake.Atk;

public class AtkValueIfaceHandle : BaseSafeHandle
{
}


public static class AtkValueIfaceExtensions
{

	public static AtkValueIface Dereference(this AtkValueIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkValueIface>(x.DangerousGetHandle());
}
internal class AtkValueIfaceExterns
{
}

public struct AtkValueIface
{
	public GTypeInterface parent;
	public IntPtr get_current_value;
	public IntPtr get_maximum_value;
	public IntPtr get_minimum_value;
	public IntPtr set_current_value;
	public IntPtr get_minimum_increment;
	public IntPtr get_value_and_text;
	public IntPtr get_range;
	public IntPtr get_increment;
	public IntPtr get_sub_ranges;
	public IntPtr set_value;
}
