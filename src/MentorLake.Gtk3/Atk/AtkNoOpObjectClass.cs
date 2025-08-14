namespace MentorLake.Atk;


public class AtkNoOpObjectClassHandle : BaseSafeHandle
{
}


public static class AtkNoOpObjectClassExtensions
{

	public static AtkNoOpObjectClass Dereference(this AtkNoOpObjectClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkNoOpObjectClass>(x.DangerousGetHandle());
}
internal class AtkNoOpObjectClassExterns
{
}


public struct AtkNoOpObjectClass
{
	
public AtkObjectClass parent_class;
}
