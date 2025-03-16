namespace MentorLake.Atk;

public class AtkRegistryClassHandle : BaseSafeHandle
{
}


public static class AtkRegistryClassExtensions
{

	public static AtkRegistryClass Dereference(this AtkRegistryClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkRegistryClass>(x.DangerousGetHandle());
}
internal class AtkRegistryClassExterns
{
}

public struct AtkRegistryClass
{
	public GObjectClass parent_class;
}
