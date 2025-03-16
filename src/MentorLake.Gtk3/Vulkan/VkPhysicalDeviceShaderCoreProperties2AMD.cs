namespace MentorLake.Vulkan;

public class VkPhysicalDeviceShaderCoreProperties2AMDHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceShaderCoreProperties2AMDExtensions
{

	public static VkPhysicalDeviceShaderCoreProperties2AMD Dereference(this VkPhysicalDeviceShaderCoreProperties2AMDHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceShaderCoreProperties2AMD>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceShaderCoreProperties2AMDExterns
{
}

public struct VkPhysicalDeviceShaderCoreProperties2AMD
{
}
