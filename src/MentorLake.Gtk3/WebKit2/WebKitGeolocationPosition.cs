namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// An opaque struct to provide position updates to a #WebKitGeolocationManager.
/// </para>
/// <para>
/// WebKitGeolocationPosition is an opaque struct used to provide position updates to a
/// #WebKitGeolocationManager using webkit_geolocation_manager_update_position().
/// </para>
/// </summary>

public class WebKitGeolocationPositionHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Create a new #WebKitGeolocationPosition.
/// </para>
/// </summary>

/// <param name="latitude">
/// a valid latitude in degrees
/// </param>
/// <param name="longitude">
/// a valid longitude in degrees
/// </param>
/// <param name="accuracy">
/// accuracy of location in meters
/// </param>
/// <return>
/// a newly created #WebKitGeolocationPosition
/// </return>

	public static MentorLake.WebKit2.WebKitGeolocationPositionHandle New(double latitude, double longitude, double accuracy)
	{
		return WebKitGeolocationPositionExterns.webkit_geolocation_position_new(latitude, longitude, accuracy);
	}

}


public static class WebKitGeolocationPositionExtensions
{
/// <summary>
/// <para>
/// Make a copy of the #WebKitGeolocationPosition.
/// </para>
/// </summary>

/// <param name="position">
/// a #WebKitGeolocationPosition
/// </param>
/// <return>
/// a copy of @position
/// </return>

	public static MentorLake.WebKit2.WebKitGeolocationPositionHandle Copy(this MentorLake.WebKit2.WebKitGeolocationPositionHandle position)
	{
		if (position.IsInvalid) throw new Exception("Invalid handle (WebKitGeolocationPosition)");
		return WebKitGeolocationPositionExterns.webkit_geolocation_position_copy(position);
	}

/// <summary>
/// <para>
/// Free the #WebKitGeolocationPosition
/// </para>
/// </summary>

/// <param name="position">
/// a #WebKitGeolocationPosition
/// </param>

	public static void Free(this MentorLake.WebKit2.WebKitGeolocationPositionHandle position)
	{
		if (position.IsInvalid) throw new Exception("Invalid handle (WebKitGeolocationPosition)");
		WebKitGeolocationPositionExterns.webkit_geolocation_position_free(position);
	}

/// <summary>
/// <para>
/// Set the @position altitude.
/// </para>
/// </summary>

/// <param name="position">
/// a #WebKitGeolocationPosition
/// </param>
/// <param name="altitude">
/// altitude in meters
/// </param>

	public static void SetAltitude(this MentorLake.WebKit2.WebKitGeolocationPositionHandle position, double altitude)
	{
		if (position.IsInvalid) throw new Exception("Invalid handle (WebKitGeolocationPosition)");
		WebKitGeolocationPositionExterns.webkit_geolocation_position_set_altitude(position, altitude);
	}

/// <summary>
/// <para>
/// Set the accuracy of @position altitude.
/// </para>
/// </summary>

/// <param name="position">
/// a #WebKitGeolocationPosition
/// </param>
/// <param name="altitude_accuracy">
/// accuracy of position altitude in meters
/// </param>

	public static void SetAltitudeAccuracy(this MentorLake.WebKit2.WebKitGeolocationPositionHandle position, double altitude_accuracy)
	{
		if (position.IsInvalid) throw new Exception("Invalid handle (WebKitGeolocationPosition)");
		WebKitGeolocationPositionExterns.webkit_geolocation_position_set_altitude_accuracy(position, altitude_accuracy);
	}

/// <summary>
/// <para>
/// Set the @position heading.
/// </para>
/// <para>
/// Set the @position heading, as a positive angle between the direction of movement and the North
/// direction, in clockwise direction.
/// </para>
/// </summary>

/// <param name="position">
/// a #WebKitGeolocationPosition
/// </param>
/// <param name="heading">
/// heading in degrees
/// </param>

	public static void SetHeading(this MentorLake.WebKit2.WebKitGeolocationPositionHandle position, double heading)
	{
		if (position.IsInvalid) throw new Exception("Invalid handle (WebKitGeolocationPosition)");
		WebKitGeolocationPositionExterns.webkit_geolocation_position_set_heading(position, heading);
	}

/// <summary>
/// <para>
/// Set the @position speed.
/// </para>
/// </summary>

/// <param name="position">
/// a #WebKitGeolocationPosition
/// </param>
/// <param name="speed">
/// speed in meters per second
/// </param>

	public static void SetSpeed(this MentorLake.WebKit2.WebKitGeolocationPositionHandle position, double speed)
	{
		if (position.IsInvalid) throw new Exception("Invalid handle (WebKitGeolocationPosition)");
		WebKitGeolocationPositionExterns.webkit_geolocation_position_set_speed(position, speed);
	}

/// <summary>
/// <para>
/// Set the @position timestamp.
/// </para>
/// <para>
/// By default it&apos;s the time when the @position was created.
/// </para>
/// </summary>

/// <param name="position">
/// a #WebKitGeolocationPosition
/// </param>
/// <param name="timestamp">
/// timestamp in seconds since the epoch, or 0 to use current time
/// </param>

	public static void SetTimestamp(this MentorLake.WebKit2.WebKitGeolocationPositionHandle position, ulong timestamp)
	{
		if (position.IsInvalid) throw new Exception("Invalid handle (WebKitGeolocationPosition)");
		WebKitGeolocationPositionExterns.webkit_geolocation_position_set_timestamp(position, timestamp);
	}


	public static WebKitGeolocationPosition Dereference(this WebKitGeolocationPositionHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitGeolocationPosition>(x.DangerousGetHandle());
}
internal class WebKitGeolocationPositionExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitGeolocationPositionHandle>))]
	internal static extern MentorLake.WebKit2.WebKitGeolocationPositionHandle webkit_geolocation_position_new(double latitude, double longitude, double accuracy);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitGeolocationPositionHandle>))]
	internal static extern MentorLake.WebKit2.WebKitGeolocationPositionHandle webkit_geolocation_position_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitGeolocationPositionHandle>))] MentorLake.WebKit2.WebKitGeolocationPositionHandle position);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_geolocation_position_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitGeolocationPositionHandle>))] MentorLake.WebKit2.WebKitGeolocationPositionHandle position);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_geolocation_position_set_altitude([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitGeolocationPositionHandle>))] MentorLake.WebKit2.WebKitGeolocationPositionHandle position, double altitude);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_geolocation_position_set_altitude_accuracy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitGeolocationPositionHandle>))] MentorLake.WebKit2.WebKitGeolocationPositionHandle position, double altitude_accuracy);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_geolocation_position_set_heading([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitGeolocationPositionHandle>))] MentorLake.WebKit2.WebKitGeolocationPositionHandle position, double heading);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_geolocation_position_set_speed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitGeolocationPositionHandle>))] MentorLake.WebKit2.WebKitGeolocationPositionHandle position, double speed);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_geolocation_position_set_timestamp([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitGeolocationPositionHandle>))] MentorLake.WebKit2.WebKitGeolocationPositionHandle position, ulong timestamp);

}

/// <summary>
/// <para>
/// An opaque struct to provide position updates to a #WebKitGeolocationManager.
/// </para>
/// <para>
/// WebKitGeolocationPosition is an opaque struct used to provide position updates to a
/// #WebKitGeolocationManager using webkit_geolocation_manager_update_position().
/// </para>
/// </summary>

public struct WebKitGeolocationPosition
{
}
