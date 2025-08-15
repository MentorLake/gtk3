namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// A #GdkFrameTimings object holds timing information for a single frame
/// of the application’s displays. To retrieve #GdkFrameTimings objects,
/// use gdk_frame_clock_get_timings() or gdk_frame_clock_get_current_timings().
/// The information in #GdkFrameTimings is useful for precise synchronization
/// of video with the event or audio streams, and for measuring
/// quality metrics for the application’s display, such as latency and jitter.
/// </para>
/// </summary>

public class GdkFrameTimingsHandle : BaseSafeHandle
{
}


public static class GdkFrameTimingsExtensions
{
/// <summary>
/// <para>
/// The timing information in a #GdkFrameTimings is filled in
/// incrementally as the frame as drawn and passed off to the
/// window system for processing and display to the user. The
/// accessor functions for #GdkFrameTimings can return 0 to
/// indicate an unavailable value for two reasons: either because
/// the information is not yet available, or because it isn&apos;t
/// available at all. Once gdk_frame_timings_get_complete() returns
/// %TRUE for a frame, you can be certain that no further values
/// will become available and be stored in the #GdkFrameTimings.
/// </para>
/// </summary>

/// <param name="timings">
/// a #GdkFrameTimings
/// </param>
/// <return>
/// %TRUE if all information that will be available
///  for the frame has been filled in.
/// </return>

	public static bool GetComplete(this MentorLake.Gdk.GdkFrameTimingsHandle timings)
	{
		if (timings.IsInvalid) throw new Exception("Invalid handle (GdkFrameTimings)");
		return GdkFrameTimingsExterns.gdk_frame_timings_get_complete(timings);
	}

/// <summary>
/// <para>
/// Gets the frame counter value of the #GdkFrameClock when this
/// this frame was drawn.
/// </para>
/// </summary>

/// <param name="timings">
/// a #GdkFrameTimings
/// </param>
/// <return>
/// the frame counter value for this frame
/// </return>

	public static long GetFrameCounter(this MentorLake.Gdk.GdkFrameTimingsHandle timings)
	{
		if (timings.IsInvalid) throw new Exception("Invalid handle (GdkFrameTimings)");
		return GdkFrameTimingsExterns.gdk_frame_timings_get_frame_counter(timings);
	}

/// <summary>
/// <para>
/// Returns the frame time for the frame. This is the time value
/// that is typically used to time animations for the frame. See
/// gdk_frame_clock_get_frame_time().
/// </para>
/// </summary>

/// <param name="timings">
/// A #GdkFrameTimings
/// </param>
/// <return>
/// the frame time for the frame, in the timescale
///  of g_get_monotonic_time()
/// </return>

	public static long GetFrameTime(this MentorLake.Gdk.GdkFrameTimingsHandle timings)
	{
		if (timings.IsInvalid) throw new Exception("Invalid handle (GdkFrameTimings)");
		return GdkFrameTimingsExterns.gdk_frame_timings_get_frame_time(timings);
	}

/// <summary>
/// <para>
/// Gets the predicted time at which this frame will be displayed. Although
/// no predicted time may be available, if one is available, it will
/// be available while the frame is being generated, in contrast to
/// gdk_frame_timings_get_presentation_time(), which is only available
/// after the frame has been presented. In general, if you are simply
/// animating, you should use gdk_frame_clock_get_frame_time() rather
/// than this function, but this function is useful for applications
/// that want exact control over latency. For example, a movie player
/// may want this information for Audio/Video synchronization.
/// </para>
/// </summary>

/// <param name="timings">
/// a #GdkFrameTimings
/// </param>
/// <return>
/// The predicted time at which the frame will be presented,
///  in the timescale of g_get_monotonic_time(), or 0 if no predicted
///  presentation time is available.
/// </return>

	public static long GetPredictedPresentationTime(this MentorLake.Gdk.GdkFrameTimingsHandle timings)
	{
		if (timings.IsInvalid) throw new Exception("Invalid handle (GdkFrameTimings)");
		return GdkFrameTimingsExterns.gdk_frame_timings_get_predicted_presentation_time(timings);
	}

/// <summary>
/// <para>
/// Reurns the presentation time. This is the time at which the frame
/// became visible to the user.
/// </para>
/// </summary>

/// <param name="timings">
/// a #GdkFrameTimings
/// </param>
/// <return>
/// the time the frame was displayed to the user, in the
///  timescale of g_get_monotonic_time(), or 0 if no presentation
///  time is available. See gdk_frame_timings_get_complete()
/// </return>

	public static long GetPresentationTime(this MentorLake.Gdk.GdkFrameTimingsHandle timings)
	{
		if (timings.IsInvalid) throw new Exception("Invalid handle (GdkFrameTimings)");
		return GdkFrameTimingsExterns.gdk_frame_timings_get_presentation_time(timings);
	}

/// <summary>
/// <para>
/// Gets the natural interval between presentation times for
/// the display that this frame was displayed on. Frame presentation
/// usually happens during the “vertical blanking interval”.
/// </para>
/// </summary>

/// <param name="timings">
/// a #GdkFrameTimings
/// </param>
/// <return>
/// the refresh interval of the display, in microseconds,
///  or 0 if the refresh interval is not available.
///  See gdk_frame_timings_get_complete().
/// </return>

	public static long GetRefreshInterval(this MentorLake.Gdk.GdkFrameTimingsHandle timings)
	{
		if (timings.IsInvalid) throw new Exception("Invalid handle (GdkFrameTimings)");
		return GdkFrameTimingsExterns.gdk_frame_timings_get_refresh_interval(timings);
	}

/// <summary>
/// <para>
/// Increases the reference count of @timings.
/// </para>
/// </summary>

/// <param name="timings">
/// a #GdkFrameTimings
/// </param>
/// <return>
/// @timings
/// </return>

	public static MentorLake.Gdk.GdkFrameTimingsHandle Ref(this MentorLake.Gdk.GdkFrameTimingsHandle timings)
	{
		if (timings.IsInvalid) throw new Exception("Invalid handle (GdkFrameTimings)");
		return GdkFrameTimingsExterns.gdk_frame_timings_ref(timings);
	}

/// <summary>
/// <para>
/// Decreases the reference count of @timings. If @timings
/// is no longer referenced, it will be freed.
/// </para>
/// </summary>

/// <param name="timings">
/// a #GdkFrameTimings
/// </param>

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

/// <summary>
/// <para>
/// A #GdkFrameTimings object holds timing information for a single frame
/// of the application’s displays. To retrieve #GdkFrameTimings objects,
/// use gdk_frame_clock_get_timings() or gdk_frame_clock_get_current_timings().
/// The information in #GdkFrameTimings is useful for precise synchronization
/// of video with the event or audio streams, and for measuring
/// quality metrics for the application’s display, such as latency and jitter.
/// </para>
/// </summary>

public struct GdkFrameTimings
{
}
