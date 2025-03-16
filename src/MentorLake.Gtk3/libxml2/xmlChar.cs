namespace MentorLake.libxml2;

public class xmlCharHandle : BaseSafeHandle
{
}


public static class xmlCharExtensions
{

	public static xmlChar Dereference(this xmlCharHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<xmlChar>(x.DangerousGetHandle());
}
internal class xmlCharExterns
{
}

public struct xmlChar
{
}
