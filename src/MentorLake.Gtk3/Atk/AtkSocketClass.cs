namespace MentorLake.Atk;


public class AtkSocketClassHandle : BaseSafeHandle
{
}


public static class AtkSocketClassExtensions
{

	public static AtkSocketClass Dereference(this AtkSocketClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkSocketClass>(x.DangerousGetHandle());
}
internal class AtkSocketClassExterns
{
}


public struct AtkSocketClass
{
	
public AtkObjectClass parent_class;
	
public IntPtr embed;
}
