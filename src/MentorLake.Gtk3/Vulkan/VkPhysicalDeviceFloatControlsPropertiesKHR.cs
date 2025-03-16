namespace MentorLake.Vulkan;

public class VkPhysicalDeviceFloatControlsPropertiesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceFloatControlsPropertiesKHRExtensions
{

	public static VkPhysicalDeviceFloatControlsPropertiesKHR Dereference(this VkPhysicalDeviceFloatControlsPropertiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceFloatControlsPropertiesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceFloatControlsPropertiesKHRExterns
{
}

public struct VkPhysicalDeviceFloatControlsPropertiesKHR
{
}
