namespace MentorLake.libxml2;

public class xmlNsPtrHandle : BaseSafeHandle
{
}


public static class xmlNsPtrExtensions
{

	public static xmlNsPtr Dereference(this xmlNsPtrHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<xmlNsPtr>(x.DangerousGetHandle());
}
internal class xmlNsPtrExterns
{
}

public struct xmlNsPtr
{
}
