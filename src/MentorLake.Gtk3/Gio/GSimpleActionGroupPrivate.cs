namespace MentorLake.Gio;


public class GSimpleActionGroupPrivateHandle : BaseSafeHandle
{
}


public static class GSimpleActionGroupPrivateExtensions
{

	public static GSimpleActionGroupPrivate Dereference(this GSimpleActionGroupPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSimpleActionGroupPrivate>(x.DangerousGetHandle());
}
internal class GSimpleActionGroupPrivateExterns
{
}


public struct GSimpleActionGroupPrivate
{
}
