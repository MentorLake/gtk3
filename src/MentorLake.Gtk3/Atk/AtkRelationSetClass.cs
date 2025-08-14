namespace MentorLake.Atk;


public class AtkRelationSetClassHandle : BaseSafeHandle
{
}


public static class AtkRelationSetClassExtensions
{

	public static AtkRelationSetClass Dereference(this AtkRelationSetClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkRelationSetClass>(x.DangerousGetHandle());
}
internal class AtkRelationSetClassExterns
{
}


public struct AtkRelationSetClass
{
	
public GObjectClass parent;
	
public AtkFunction pad1;
	
public AtkFunction pad2;
}
