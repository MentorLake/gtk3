namespace MentorLake.fontconfig;

public class FcConfigHandle : BaseSafeHandle
{
}


public static class FcConfigExtensions
{

	public static FcConfig Dereference(this FcConfigHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<FcConfig>(x.DangerousGetHandle());
}
internal class FcConfigExterns
{
}

public struct FcConfig
{
}
