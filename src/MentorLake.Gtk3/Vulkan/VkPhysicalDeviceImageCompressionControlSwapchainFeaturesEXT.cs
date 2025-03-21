namespace MentorLake.Vulkan;

public class VkPhysicalDeviceImageCompressionControlSwapchainFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceImageCompressionControlSwapchainFeaturesEXTExtensions
{

	public static VkPhysicalDeviceImageCompressionControlSwapchainFeaturesEXT Dereference(this VkPhysicalDeviceImageCompressionControlSwapchainFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceImageCompressionControlSwapchainFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceImageCompressionControlSwapchainFeaturesEXTExterns
{
}

public struct VkPhysicalDeviceImageCompressionControlSwapchainFeaturesEXT
{
}
