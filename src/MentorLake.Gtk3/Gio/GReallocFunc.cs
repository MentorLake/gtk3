namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Changes the size of the memory block pointed to by @data to
/// @size bytes.
/// </para>
/// <para>
/// The function should have the same semantics as realloc().
/// </para>
/// </summary>

/// <param name="data">
/// memory block to reallocate
/// </param>
/// <param name="size">
/// size to reallocate @data to
/// </param>
/// <return>
/// a pointer to the reallocated memory
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate IntPtr GReallocFunc(IntPtr data, UIntPtr size);
