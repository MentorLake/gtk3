namespace MentorLake.Atk;


public class AtkGObjectAccessibleClassHandle : BaseSafeHandle
{
}


public static class AtkGObjectAccessibleClassExtensions
{

	public static AtkGObjectAccessibleClass Dereference(this AtkGObjectAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkGObjectAccessibleClass>(x.DangerousGetHandle());
}
internal class AtkGObjectAccessibleClassExterns
{
}


public struct AtkGObjectAccessibleClass
{
	
public AtkObjectClass parent_class;
	
public AtkFunction pad1;
	
public AtkFunction pad2;
}
