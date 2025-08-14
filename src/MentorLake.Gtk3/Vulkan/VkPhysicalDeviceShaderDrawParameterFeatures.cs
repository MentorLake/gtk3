namespace MentorLake.Vulkan;


public class VkPhysicalDeviceShaderDrawParameterFeaturesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceShaderDrawParameterFeaturesExtensions
{

	public static VkPhysicalDeviceShaderDrawParameterFeatures Dereference(this VkPhysicalDeviceShaderDrawParameterFeaturesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceShaderDrawParameterFeatures>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceShaderDrawParameterFeaturesExterns
{
}


public struct VkPhysicalDeviceShaderDrawParameterFeatures
{
}
