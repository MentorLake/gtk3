namespace MentorLake.Atk;

public class AtkRelationClassHandle : BaseSafeHandle
{
}


public static class AtkRelationClassExtensions
{

	public static AtkRelationClass Dereference(this AtkRelationClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkRelationClass>(x.DangerousGetHandle());
}
internal class AtkRelationClassExterns
{
}

public struct AtkRelationClass
{
	public GObjectClass parent;
}
