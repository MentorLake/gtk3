namespace MentorLake.fontconfig;


public class FcPatternHandle : BaseSafeHandle
{
}


public static class FcPatternExtensions
{

	public static FcPattern Dereference(this FcPatternHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<FcPattern>(x.DangerousGetHandle());
}
internal class FcPatternExterns
{
}


public struct FcPattern
{
}
