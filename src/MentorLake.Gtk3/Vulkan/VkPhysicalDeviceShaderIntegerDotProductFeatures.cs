namespace MentorLake.Vulkan;

public class VkPhysicalDeviceShaderIntegerDotProductFeaturesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceShaderIntegerDotProductFeaturesExtensions
{

	public static VkPhysicalDeviceShaderIntegerDotProductFeatures Dereference(this VkPhysicalDeviceShaderIntegerDotProductFeaturesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceShaderIntegerDotProductFeatures>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceShaderIntegerDotProductFeaturesExterns
{
}

public struct VkPhysicalDeviceShaderIntegerDotProductFeatures
{
}
