namespace MentorLake.libxml2;

public class xmlTextReaderPtrHandle : BaseSafeHandle
{
}


public static class xmlTextReaderPtrExtensions
{

	public static xmlTextReaderPtr Dereference(this xmlTextReaderPtrHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<xmlTextReaderPtr>(x.DangerousGetHandle());
}
internal class xmlTextReaderPtrExterns
{
}

public struct xmlTextReaderPtr
{
}
