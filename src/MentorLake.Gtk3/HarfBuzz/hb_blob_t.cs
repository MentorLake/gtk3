namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Data type for blobs. A blob wraps a chunk of binary
/// data and facilitates its lifecycle management between
/// a client program and HarfBuzz.
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// Data type for blobs. A blob wraps a chunk of binary
/// data and facilitates its lifecycle management between
/// a client program and HarfBuzz.
/// </para>
/// </summary>

public struct hb_blob_t
{
}
