namespace MentorLake.Vulkan;


public class VkPhysicalDeviceConditionalRenderingFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceConditionalRenderingFeaturesEXTExtensions
{

	public static VkPhysicalDeviceConditionalRenderingFeaturesEXT Dereference(this VkPhysicalDeviceConditionalRenderingFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceConditionalRenderingFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceConditionalRenderingFeaturesEXTExterns
{
}


public struct VkPhysicalDeviceConditionalRenderingFeaturesEXT
{
}
