namespace MentorLake.HarfBuzz;

public class hb_blob_tHandle : BaseSafeHandle
{
}


public static class hb_blob_tExtensions
{

	public static hb_blob_t Dereference(this hb_blob_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_blob_t>(x.DangerousGetHandle());
}
internal class hb_blob_tExterns
{
}

public struct hb_blob_t
{
}
