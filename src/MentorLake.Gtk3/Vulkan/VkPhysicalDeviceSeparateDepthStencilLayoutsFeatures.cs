namespace MentorLake.Vulkan;

public class VkPhysicalDeviceSeparateDepthStencilLayoutsFeaturesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceSeparateDepthStencilLayoutsFeaturesExtensions
{

	public static VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures Dereference(this VkPhysicalDeviceSeparateDepthStencilLayoutsFeaturesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceSeparateDepthStencilLayoutsFeaturesExterns
{
}

public struct VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures
{
}
