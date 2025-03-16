namespace MentorLake.GLib;

public class GRandHandle : BaseSafeHandle
{
	public static MentorLake.GLib.GRandHandle New()
	{
		return GRandExterns.g_rand_new();
	}

	public static MentorLake.GLib.GRandHandle NewWithSeed(uint seed)
	{
		return GRandExterns.g_rand_new_with_seed(seed);
	}

	public static MentorLake.GLib.GRandHandle NewWithSeedArray(uint seed, uint seed_length)
	{
		return GRandExterns.g_rand_new_with_seed_array(seed, seed_length);
	}

}


public static class GRandExtensions
{
	public static MentorLake.GLib.GRandHandle Copy(this MentorLake.GLib.GRandHandle rand_)
	{
		return GRandExterns.g_rand_copy(rand_);
	}

	public static double Double(this MentorLake.GLib.GRandHandle rand_)
	{
		return GRandExterns.g_rand_double(rand_);
	}

	public static double DoubleRange(this MentorLake.GLib.GRandHandle rand_, double begin, double end)
	{
		return GRandExterns.g_rand_double_range(rand_, begin, end);
	}

	public static void Free(this MentorLake.GLib.GRandHandle rand_)
	{
		GRandExterns.g_rand_free(rand_);
	}

	public static uint Int(this MentorLake.GLib.GRandHandle rand_)
	{
		return GRandExterns.g_rand_int(rand_);
	}

	public static int IntRange(this MentorLake.GLib.GRandHandle rand_, int begin, int end)
	{
		return GRandExterns.g_rand_int_range(rand_, begin, end);
	}

	public static void SetSeed(this MentorLake.GLib.GRandHandle rand_, uint seed)
	{
		GRandExterns.g_rand_set_seed(rand_, seed);
	}

	public static void SetSeedArray(this MentorLake.GLib.GRandHandle rand_, uint seed, uint seed_length)
	{
		GRandExterns.g_rand_set_seed_array(rand_, seed, seed_length);
	}


	public static GRand Dereference(this GRandHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GRand>(x.DangerousGetHandle());
}
internal class GRandExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GRandHandle g_rand_new();

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GRandHandle g_rand_new_with_seed(uint seed);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GRandHandle g_rand_new_with_seed_array(uint seed, uint seed_length);

	[DllImport(GLibLibrary.Name)]
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

public struct GRand
{
}
