namespace MentorLake.libxml2;

public class xmlNodePtrHandle : BaseSafeHandle
{
}


public static class xmlNodePtrExtensions
{

	public static xmlNodePtr Dereference(this xmlNodePtrHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<xmlNodePtr>(x.DangerousGetHandle());
}
internal class xmlNodePtrExterns
{
}

public struct xmlNodePtr
{
}
