namespace MentorLake.Atk;


public class AtkHyperlinkImplIfaceHandle : BaseSafeHandle
{
}


public static class AtkHyperlinkImplIfaceExtensions
{

	public static AtkHyperlinkImplIface Dereference(this AtkHyperlinkImplIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkHyperlinkImplIface>(x.DangerousGetHandle());
}
internal class AtkHyperlinkImplIfaceExterns
{
}


public struct AtkHyperlinkImplIface
{
	
public GTypeInterface parent;
	
public IntPtr get_hyperlink;
}
