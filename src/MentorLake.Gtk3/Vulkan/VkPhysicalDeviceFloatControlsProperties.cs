namespace MentorLake.Vulkan;


public class VkPhysicalDeviceFloatControlsPropertiesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceFloatControlsPropertiesExtensions
{

	public static VkPhysicalDeviceFloatControlsProperties Dereference(this VkPhysicalDeviceFloatControlsPropertiesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceFloatControlsProperties>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceFloatControlsPropertiesExterns
{
}


public struct VkPhysicalDeviceFloatControlsProperties
{
}
