namespace MentorLake.Vulkan;

public class VkPhysicalDeviceSwapchainMaintenance1FeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceSwapchainMaintenance1FeaturesEXTExtensions
{

	public static VkPhysicalDeviceSwapchainMaintenance1FeaturesEXT Dereference(this VkPhysicalDeviceSwapchainMaintenance1FeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceSwapchainMaintenance1FeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceSwapchainMaintenance1FeaturesEXTExterns
{
}

public struct VkPhysicalDeviceSwapchainMaintenance1FeaturesEXT
{
}
