namespace MentorLake.libxml2;

public class xmlTextWriterPtrHandle : BaseSafeHandle
{
}


public static class xmlTextWriterPtrExtensions
{

	public static xmlTextWriterPtr Dereference(this xmlTextWriterPtrHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<xmlTextWriterPtr>(x.DangerousGetHandle());
}
internal class xmlTextWriterPtrExterns
{
}

public struct xmlTextWriterPtr
{
}
