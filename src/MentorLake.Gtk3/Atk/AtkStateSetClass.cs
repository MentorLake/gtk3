namespace MentorLake.Atk;

public class AtkStateSetClassHandle : BaseSafeHandle
{
}


public static class AtkStateSetClassExtensions
{

	public static AtkStateSetClass Dereference(this AtkStateSetClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkStateSetClass>(x.DangerousGetHandle());
}
internal class AtkStateSetClassExterns
{
}

public struct AtkStateSetClass
{
	public GObjectClass parent;
}
