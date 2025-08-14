namespace MentorLake.Atk;


public class AtkHyperlinkClassHandle : BaseSafeHandle
{
}


public static class AtkHyperlinkClassExtensions
{

	public static AtkHyperlinkClass Dereference(this AtkHyperlinkClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkHyperlinkClass>(x.DangerousGetHandle());
}
internal class AtkHyperlinkClassExterns
{
}


public struct AtkHyperlinkClass
{
	
public GObjectClass parent;
	
public IntPtr get_uri;
	
public IntPtr get_object;
	
public IntPtr get_end_index;
	
public IntPtr get_start_index;
	
public IntPtr is_valid;
	
public IntPtr get_n_anchors;
	
public IntPtr link_state;
	
public IntPtr is_selected_link;
	
public IntPtr link_activated;
	
public AtkFunction pad1;
}
