namespace MentorLake.Gdk;

public class GdkFrameTimingsHandle : BaseSafeHandle
{
}


public static class GdkFrameTimingsExtensions
{
	public static bool GetComplete(this MentorLake.Gdk.GdkFrameTimingsHandle timings)
	{
		if (timings.IsInvalid) throw new Exception("Invalid handle (GdkFrameTimings)");
		return GdkFrameTimingsExterns.gdk_frame_timings_get_complete(timings);
	}

	public static long GetFrameCounter(this MentorLake.Gdk.GdkFrameTimingsHandle timings)
	{
		if (timings.IsInvalid) throw new Exception("Invalid handle (GdkFrameTimings)");
		return GdkFrameTimingsExterns.gdk_frame_timings_get_frame_counter(timings);
	}

	public static long GetFrameTime(this MentorLake.Gdk.GdkFrameTimingsHandle timings)
	{
		if (timings.IsInvalid) throw new Exception("Invalid handle (GdkFrameTimings)");
		return GdkFrameTimingsExterns.gdk_frame_timings_get_frame_time(timings);
	}

	public static long GetPredictedPresentationTime(this MentorLake.Gdk.GdkFrameTimingsHandle timings)
	{
		if (timings.IsInvalid) throw new Exception("Invalid handle (GdkFrameTimings)");
		return GdkFrameTimingsExterns.gdk_frame_timings_get_predicted_presentation_time(timings);
	}

	public static long GetPresentationTime(this MentorLake.Gdk.GdkFrameTimingsHandle timings)
	{
		if (timings.IsInvalid) throw new Exception("Invalid handle (GdkFrameTimings)");
		return GdkFrameTimingsExterns.gdk_frame_timings_get_presentation_time(timings);
	}

	public static long GetRefreshInterval(this MentorLake.Gdk.GdkFrameTimingsHandle timings)
	{
		if (timings.IsInvalid) throw new Exception("Invalid handle (GdkFrameTimings)");
		return GdkFrameTimingsExterns.gdk_frame_timings_get_refresh_interval(timings);
	}

	public static MentorLake.Gdk.GdkFrameTimingsHandle Ref(this MentorLake.Gdk.GdkFrameTimingsHandle timings)
	{
		if (timings.IsInvalid) throw new Exception("Invalid handle (GdkFrameTimings)");
		return GdkFrameTimingsExterns.gdk_frame_timings_ref(timings);
	}

	public static void Unref(this MentorLake.Gdk.GdkFrameTimingsHandle timings)
	{
		if (timings.IsInvalid) throw new Exception("Invalid handle (GdkFrameTimings)");
		GdkFrameTimingsExterns.gdk_frame_timings_unref(timings);
	}


	public static GdkFrameTimings Dereference(this GdkFrameTimingsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkFrameTimings>(x.DangerousGetHandle());
}
internal class GdkFrameTimingsExterns
{
	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_frame_timings_get_complete([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkFrameTimingsHandle>))] MentorLake.Gdk.GdkFrameTimingsHandle timings);

	[DllImport(GdkLibrary.Name)]
	internal static extern long gdk_frame_timings_get_frame_counter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkFrameTimingsHandle>))] MentorLake.Gdk.GdkFrameTimingsHandle timings);

	[DllImport(GdkLibrary.Name)]
	internal static extern long gdk_frame_timings_get_frame_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkFrameTimingsHandle>))] MentorLake.Gdk.GdkFrameTimingsHandle timings);

	[DllImport(GdkLibrary.Name)]
	internal static extern long gdk_frame_timings_get_predicted_presentation_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkFrameTimingsHandle>))] MentorLake.Gdk.GdkFrameTimingsHandle timings);

	[DllImport(GdkLibrary.Name)]
	internal static extern long gdk_frame_timings_get_presentation_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkFrameTimingsHandle>))] MentorLake.Gdk.GdkFrameTimingsHandle timings);

	[DllImport(GdkLibrary.Name)]
	internal static extern long gdk_frame_timings_get_refresh_interval([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkFrameTimingsHandle>))] MentorLake.Gdk.GdkFrameTimingsHandle timings);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkFrameTimingsHandle>))]
	internal static extern MentorLake.Gdk.GdkFrameTimingsHandle gdk_frame_timings_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkFrameTimingsHandle>))] MentorLake.Gdk.GdkFrameTimingsHandle timings);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_frame_timings_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkFrameTimingsHandle>))] MentorLake.Gdk.GdkFrameTimingsHandle timings);

}

public struct GdkFrameTimings
{
}
