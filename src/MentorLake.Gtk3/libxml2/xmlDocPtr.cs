namespace MentorLake.libxml2;

public class xmlDocPtrHandle : BaseSafeHandle
{
}


public static class xmlDocPtrExtensions
{

	public static xmlDocPtr Dereference(this xmlDocPtrHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<xmlDocPtr>(x.DangerousGetHandle());
}
internal class xmlDocPtrExterns
{
}

public struct xmlDocPtr
{
}
