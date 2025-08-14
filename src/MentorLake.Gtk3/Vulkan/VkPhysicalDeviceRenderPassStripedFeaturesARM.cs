namespace MentorLake.Vulkan;


public class VkPhysicalDeviceRenderPassStripedFeaturesARMHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceRenderPassStripedFeaturesARMExtensions
{

	public static VkPhysicalDeviceRenderPassStripedFeaturesARM Dereference(this VkPhysicalDeviceRenderPassStripedFeaturesARMHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceRenderPassStripedFeaturesARM>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceRenderPassStripedFeaturesARMExterns
{
}


public struct VkPhysicalDeviceRenderPassStripedFeaturesARM
{
}
