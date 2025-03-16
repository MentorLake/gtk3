namespace MentorLake.fontconfig;

public class FcCharSetHandle : BaseSafeHandle
{
}


public static class FcCharSetExtensions
{

	public static FcCharSet Dereference(this FcCharSetHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<FcCharSet>(x.DangerousGetHandle());
}
internal class FcCharSetExterns
{
}

public struct FcCharSet
{
}
