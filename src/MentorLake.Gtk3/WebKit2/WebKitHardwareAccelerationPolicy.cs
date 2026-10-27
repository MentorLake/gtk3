namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values used for determining the hardware acceleration policy.
/// </para>
/// </summary>

[Flags]
public enum WebKitHardwareAccelerationPolicy
{
/// <summary>
/// <para>
/// Hardware acceleration is enabled/disabled as request by web contents.
/// </para>
/// </summary>

	WEBKIT_HARDWARE_ACCELERATION_POLICY_ON_DEMAND = 0,
/// <summary>
/// <para>
/// Hardware acceleration is always enabled, even for websites not requesting it.
/// </para>
/// </summary>

	WEBKIT_HARDWARE_ACCELERATION_POLICY_ALWAYS = 1,
/// <summary>
/// <para>
/// Hardware acceleration is always disabled, even for websites requesting it.
/// </para>
/// </summary>

	WEBKIT_HARDWARE_ACCELERATION_POLICY_NEVER = 2
}
