namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Structure used for scatter/gather data output.
/// You generally pass in an array of #GOutputVectors
/// and the operation will use all the buffers as if they were
/// one buffer.
/// </para>
/// </summary>

public class GOutputVectorHandle : BaseSafeHandle
{
}


public static class GOutputVectorExtensions
{

	public static GOutputVector Dereference(this GOutputVectorHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GOutputVector>(x.DangerousGetHandle());
}
internal class GOutputVectorExterns
{
}

/// <summary>
/// <para>
/// Structure used for scatter/gather data output.
/// You generally pass in an array of #GOutputVectors
/// and the operation will use all the buffers as if they were
/// one buffer.
/// </para>
/// </summary>

public struct GOutputVector
{
	/// <summary>
/// <para>
/// Pointer to a buffer of data to read.
/// </para>
/// </summary>

public IntPtr buffer;
	/// <summary>
/// <para>
/// the size of @buffer.
/// </para>
/// </summary>

public UIntPtr size;
}
