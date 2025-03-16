namespace MentorLake.Atk;

public class AtkNoOpObjectFactoryClassHandle : BaseSafeHandle
{
}


public static class AtkNoOpObjectFactoryClassExtensions
{

	public static AtkNoOpObjectFactoryClass Dereference(this AtkNoOpObjectFactoryClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkNoOpObjectFactoryClass>(x.DangerousGetHandle());
}
internal class AtkNoOpObjectFactoryClassExterns
{
}

public struct AtkNoOpObjectFactoryClass
{
	public AtkObjectFactoryClass parent_class;
}
