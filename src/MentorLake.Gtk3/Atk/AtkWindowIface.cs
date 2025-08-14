namespace MentorLake.Atk;


public class AtkWindowIfaceHandle : BaseSafeHandle
{
}


public static class AtkWindowIfaceExtensions
{

	public static AtkWindowIface Dereference(this AtkWindowIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkWindowIface>(x.DangerousGetHandle());
}
internal class AtkWindowIfaceExterns
{
}


public struct AtkWindowIface
{
	
public GTypeInterface parent;
}
