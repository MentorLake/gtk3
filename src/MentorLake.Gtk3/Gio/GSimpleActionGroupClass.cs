namespace MentorLake.Gio;

public class GSimpleActionGroupClassHandle : BaseSafeHandle
{
}


public static class GSimpleActionGroupClassExtensions
{

	public static GSimpleActionGroupClass Dereference(this GSimpleActionGroupClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSimpleActionGroupClass>(x.DangerousGetHandle());
}
internal class GSimpleActionGroupClassExterns
{
}

public struct GSimpleActionGroupClass
{
}
