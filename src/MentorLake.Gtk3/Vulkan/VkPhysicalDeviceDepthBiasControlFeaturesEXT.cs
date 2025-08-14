namespace MentorLake.Vulkan;


public class VkPhysicalDeviceDepthBiasControlFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceDepthBiasControlFeaturesEXTExtensions
{

	public static VkPhysicalDeviceDepthBiasControlFeaturesEXT Dereference(this VkPhysicalDeviceDepthBiasControlFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceDepthBiasControlFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceDepthBiasControlFeaturesEXTExterns
{
}


public struct VkPhysicalDeviceDepthBiasControlFeaturesEXT
{
}
