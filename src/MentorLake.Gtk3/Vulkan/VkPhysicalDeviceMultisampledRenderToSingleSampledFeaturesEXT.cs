namespace MentorLake.Vulkan;

public class VkPhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXTExtensions
{

	public static VkPhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT Dereference(this VkPhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXTExterns
{
}

public struct VkPhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT
{
}
