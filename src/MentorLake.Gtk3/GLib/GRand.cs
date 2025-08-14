namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The GRand struct is an opaque data structure. It should only be
/// accessed through the g_rand_* functions.
/// </para>
/// </summary>

public class GRandHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a new random number generator initialized with a seed taken
/// either from `/dev/urandom` (if existing) or from the current time
/// (as a fallback).
/// </para>
/// <para>
/// On Windows, the seed is taken from rand_s().
/// </para>
/// </summary>

/// <return>
/// the new #GRand
/// </return>

	public static MentorLake.GLib.GRandHandle New()
	{
		return GRandExterns.g_rand_new();
	}

/// <summary>
/// <para>
/// Creates a new random number generator initialized with @seed.
/// </para>
/// </summary>

/// <param name="seed">
/// a value to initialize the random number generator
/// </param>
/// <return>
/// the new #GRand
/// </return>

	public static MentorLake.GLib.GRandHandle NewWithSeed(uint seed)
	{
		return GRandExterns.g_rand_new_with_seed(seed);
	}

/// <summary>
/// <para>
/// Creates a new random number generator initialized with @seed.
/// </para>
/// </summary>

/// <param name="seed">
/// an array of seeds to initialize the random number generator
/// </param>
/// <param name="seed_length">
/// an array of seeds to initialize the random number
///     generator
/// </param>
/// <return>
/// the new #GRand
/// </return>

	public static MentorLake.GLib.GRandHandle NewWithSeedArray(uint seed, uint seed_length)
	{
		return GRandExterns.g_rand_new_with_seed_array(seed, seed_length);
	}

}


public static class GRandExtensions
{
/// <summary>
/// <para>
/// Copies a #GRand into a new one with the same exact state as before.
/// This way you can take a snapshot of the random number generator for
/// replaying later.
/// </para>
/// </summary>

/// <param name="rand_">
/// a #GRand
/// </param>
/// <return>
/// the new #GRand
/// </return>

	public static MentorLake.GLib.GRandHandle Copy(this MentorLake.GLib.GRandHandle rand_)
	{
		if (rand_.IsInvalid) throw new Exception("Invalid handle (GRand)");
		return GRandExterns.g_rand_copy(rand_);
	}

/// <summary>
/// <para>
/// Returns the next random #gdouble from @rand_ equally distributed over
/// the range [0..1).
/// </para>
/// </summary>

/// <param name="rand_">
/// a #GRand
/// </param>
/// <return>
/// a random number
/// </return>

	public static double Double(this MentorLake.GLib.GRandHandle rand_)
	{
		if (rand_.IsInvalid) throw new Exception("Invalid handle (GRand)");
		return GRandExterns.g_rand_double(rand_);
	}

/// <summary>
/// <para>
/// Returns the next random #gdouble from @rand_ equally distributed over
/// the range [@begin..@end).
/// </para>
/// </summary>

/// <param name="rand_">
/// a #GRand
/// </param>
/// <param name="begin">
/// lower closed bound of the interval
/// </param>
/// <param name="end">
/// upper open bound of the interval
/// </param>
/// <return>
/// a random number
/// </return>

	public static double DoubleRange(this MentorLake.GLib.GRandHandle rand_, double begin, double end)
	{
		if (rand_.IsInvalid) throw new Exception("Invalid handle (GRand)");
		return GRandExterns.g_rand_double_range(rand_, begin, end);
	}

/// <summary>
/// <para>
/// Frees the memory allocated for the #GRand.
/// </para>
/// </summary>

/// <param name="rand_">
/// a #GRand
/// </param>

	public static void Free(this MentorLake.GLib.GRandHandle rand_)
	{
		if (rand_.IsInvalid) throw new Exception("Invalid handle (GRand)");
		GRandExterns.g_rand_free(rand_);
	}

/// <summary>
/// <para>
/// Returns the next random #guint32 from @rand_ equally distributed over
/// the range [0..2^32-1].
/// </para>
/// </summary>

/// <param name="rand_">
/// a #GRand
/// </param>
/// <return>
/// a random number
/// </return>

	public static uint Int(this MentorLake.GLib.GRandHandle rand_)
	{
		if (rand_.IsInvalid) throw new Exception("Invalid handle (GRand)");
		return GRandExterns.g_rand_int(rand_);
	}

/// <summary>
/// <para>
/// Returns the next random #gint32 from @rand_ equally distributed over
/// the range [@begin..@end-1].
/// </para>
/// </summary>

/// <param name="rand_">
/// a #GRand
/// </param>
/// <param name="begin">
/// lower closed bound of the interval
/// </param>
/// <param name="end">
/// upper open bound of the interval
/// </param>
/// <return>
/// a random number
/// </return>

	public static int IntRange(this MentorLake.GLib.GRandHandle rand_, int begin, int end)
	{
		if (rand_.IsInvalid) throw new Exception("Invalid handle (GRand)");
		return GRandExterns.g_rand_int_range(rand_, begin, end);
	}

/// <summary>
/// <para>
/// Sets the seed for the random number generator #GRand to @seed.
/// </para>
/// </summary>

/// <param name="rand_">
/// a #GRand
/// </param>
/// <param name="seed">
/// a value to reinitialize the random number generator
/// </param>

	public static void SetSeed(this MentorLake.GLib.GRandHandle rand_, uint seed)
	{
		if (rand_.IsInvalid) throw new Exception("Invalid handle (GRand)");
		GRandExterns.g_rand_set_seed(rand_, seed);
	}

/// <summary>
/// <para>
/// Initializes the random number generator by an array of longs.
/// Array can be of arbitrary size, though only the first 624 values
/// are taken.  This function is useful if you have many low entropy
/// seeds, or if you require more then 32 bits of actual entropy for
/// your application.
/// </para>
/// </summary>

/// <param name="rand_">
/// a #GRand
/// </param>
/// <param name="seed">
/// array to initialize with
/// </param>
/// <param name="seed_length">
/// length of array
/// </param>

	public static void SetSeedArray(this MentorLake.GLib.GRandHandle rand_, uint seed, uint seed_length)
	{
		if (rand_.IsInvalid) throw new Exception("Invalid handle (GRand)");
		GRandExterns.g_rand_set_seed_array(rand_, seed, seed_length);
	}


	public static GRand Dereference(this GRandHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GRand>(x.DangerousGetHandle());
}
internal class GRandExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRandHandle>))]
	internal static extern MentorLake.GLib.GRandHandle g_rand_new();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRandHandle>))]
	internal static extern MentorLake.GLib.GRandHandle g_rand_new_with_seed(uint seed);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRandHandle>))]
	internal static extern MentorLake.GLib.GRandHandle g_rand_new_with_seed_array(uint seed, uint seed_length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRandHandle>))]
	internal static extern MentorLake.GLib.GRandHandle g_rand_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRandHandle>))] MentorLake.GLib.GRandHandle rand_);

	[DllImport(GLibLibrary.Name)]
	internal static extern double g_rand_double([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRandHandle>))] MentorLake.GLib.GRandHandle rand_);

	[DllImport(GLibLibrary.Name)]
	internal static extern double g_rand_double_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRandHandle>))] MentorLake.GLib.GRandHandle rand_, double begin, double end);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_rand_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRandHandle>))] MentorLake.GLib.GRandHandle rand_);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_rand_int([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRandHandle>))] MentorLake.GLib.GRandHandle rand_);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_rand_int_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRandHandle>))] MentorLake.GLib.GRandHandle rand_, int begin, int end);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_rand_set_seed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRandHandle>))] MentorLake.GLib.GRandHandle rand_, uint seed);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_rand_set_seed_array([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRandHandle>))] MentorLake.GLib.GRandHandle rand_, uint seed, uint seed_length);

}

/// <summary>
/// <para>
/// The GRand struct is an opaque data structure. It should only be
/// accessed through the g_rand_* functions.
/// </para>
/// </summary>

public struct GRand
{
}
