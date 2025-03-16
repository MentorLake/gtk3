namespace MentorLake.Vulkan;

public class VkPhysicalDeviceShaderCorePropertiesARMHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceShaderCorePropertiesARMExtensions
{

	public static VkPhysicalDeviceShaderCorePropertiesARM Dereference(this VkPhysicalDeviceShaderCorePropertiesARMHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceShaderCorePropertiesARM>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceShaderCorePropertiesARMExterns
{
}

public struct VkPhysicalDeviceShaderCorePropertiesARM
{
}
