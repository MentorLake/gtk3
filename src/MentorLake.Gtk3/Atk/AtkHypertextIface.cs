namespace MentorLake.Atk;


public class AtkHypertextIfaceHandle : BaseSafeHandle
{
}


public static class AtkHypertextIfaceExtensions
{

	public static AtkHypertextIface Dereference(this AtkHypertextIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkHypertextIface>(x.DangerousGetHandle());
}
internal class AtkHypertextIfaceExterns
{
}


public struct AtkHypertextIface
{
	
public GTypeInterface parent;
	
public IntPtr get_link;
	
public IntPtr get_n_links;
	
public IntPtr get_link_index;
	
public IntPtr link_selected;
}
