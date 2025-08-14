namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Structure used for scatter/gather data input.
/// You generally pass in an array of #GInputVectors
/// and the operation will store the read data starting in the
/// first buffer, switching to the next as needed.
/// </para>
/// </summary>

public class GInputVectorHandle : BaseSafeHandle
{
}


public static class GInputVectorExtensions
{

	public static GInputVector Dereference(this GInputVectorHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GInputVector>(x.DangerousGetHandle());
}
internal class GInputVectorExterns
{
}

/// <summary>
/// <para>
/// Structure used for scatter/gather data input.
/// You generally pass in an array of #GInputVectors
/// and the operation will store the read data starting in the
/// first buffer, switching to the next as needed.
/// </para>
/// </summary>

public struct GInputVector
{
	/// <summary>
/// <para>
/// Pointer to a buffer where data will be written.
/// </para>
/// </summary>

public IntPtr buffer;
	/// <summary>
/// <para>
/// the available size in @buffer.
/// </para>
/// </summary>

public UIntPtr size;
}
