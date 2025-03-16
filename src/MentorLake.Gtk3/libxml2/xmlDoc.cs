namespace MentorLake.libxml2;

public class xmlDocHandle : BaseSafeHandle
{
}


public static class xmlDocExtensions
{

	public static xmlDoc Dereference(this xmlDocHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<xmlDoc>(x.DangerousGetHandle());
}
internal class xmlDocExterns
{
}

public struct xmlDoc
{
}
