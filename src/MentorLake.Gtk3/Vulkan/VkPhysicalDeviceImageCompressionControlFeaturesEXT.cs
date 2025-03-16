namespace MentorLake.Vulkan;

public class VkPhysicalDeviceImageCompressionControlFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceImageCompressionControlFeaturesEXTExtensions
{

	public static VkPhysicalDeviceImageCompressionControlFeaturesEXT Dereference(this VkPhysicalDeviceImageCompressionControlFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceImageCompressionControlFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceImageCompressionControlFeaturesEXTExterns
{
}

public struct VkPhysicalDeviceImageCompressionControlFeaturesEXT
{
}
