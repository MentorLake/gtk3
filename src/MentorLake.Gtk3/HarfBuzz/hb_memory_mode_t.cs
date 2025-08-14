namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Data type holding the memory modes available to
/// client programs.
/// </para>
/// <para>
/// Regarding these various memory-modes:
/// </para>
/// <para>
/// - In no case shall the HarfBuzz client modify memory
///   that is passed to HarfBuzz in a blob.  If there is
///   any such possibility, @HB_MEMORY_MODE_DUPLICATE should be used
///   such that HarfBuzz makes a copy immediately,
/// </para>
/// <para>
/// - Use @HB_MEMORY_MODE_READONLY otherwise, unless you really really
///   really know what you are doing,
/// </para>
/// <para>
/// - @HB_MEMORY_MODE_WRITABLE is appropriate if you really made a
///   copy of data solely for the purpose of passing to
///   HarfBuzz and doing that just once (no reuse!),
/// </para>
/// <para>
/// - If the font is mmap()ed, it's okay to use
///   @HB_MEMORY_MODE_READONLY_MAY_MAKE_WRITABLE, however, using that mode
///   correctly is very tricky.  Use @HB_MEMORY_MODE_READONLY instead.
/// </para>
/// </summary>

[Flags]
public enum hb_memory_mode_t
{
/// <summary>
/// <para>
/// HarfBuzz immediately makes a copy of the data.
/// </para>
/// </summary>

	HB_MEMORY_MODE_DUPLICATE = 0,
/// <summary>
/// <para>
/// HarfBuzz client will never modify the data,
///     and HarfBuzz will never modify the data.
/// </para>
/// </summary>

	HB_MEMORY_MODE_READONLY = 1,
/// <summary>
/// <para>
/// HarfBuzz client made a copy of the data solely
///     for HarfBuzz, so HarfBuzz may modify the data.
/// </para>
/// </summary>

	HB_MEMORY_MODE_WRITABLE = 2,
/// <summary>
/// <para>
/// See above
/// </para>
/// </summary>

	HB_MEMORY_MODE_READONLY_MAY_MAKE_WRITABLE = 3
}
