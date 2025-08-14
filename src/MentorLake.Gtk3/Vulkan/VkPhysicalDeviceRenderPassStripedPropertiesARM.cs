namespace MentorLake.Vulkan;


public class VkPhysicalDeviceRenderPassStripedPropertiesARMHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceRenderPassStripedPropertiesARMExtensions
{

	public static VkPhysicalDeviceRenderPassStripedPropertiesARM Dereference(this VkPhysicalDeviceRenderPassStripedPropertiesARMHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceRenderPassStripedPropertiesARM>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceRenderPassStripedPropertiesARMExterns
{
}


public struct VkPhysicalDeviceRenderPassStripedPropertiesARM
{
}
