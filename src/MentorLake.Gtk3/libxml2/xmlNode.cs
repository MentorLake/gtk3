namespace MentorLake.libxml2;

public class xmlNodeHandle : BaseSafeHandle
{
}


public static class xmlNodeExtensions
{

	public static xmlNode Dereference(this xmlNodeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<xmlNode>(x.DangerousGetHandle());
}
internal class xmlNodeExterns
{
}

public struct xmlNode
{
}
