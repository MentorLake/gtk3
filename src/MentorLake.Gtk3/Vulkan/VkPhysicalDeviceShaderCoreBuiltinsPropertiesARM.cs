namespace MentorLake.Vulkan;

public class VkPhysicalDeviceShaderCoreBuiltinsPropertiesARMHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceShaderCoreBuiltinsPropertiesARMExtensions
{

	public static VkPhysicalDeviceShaderCoreBuiltinsPropertiesARM Dereference(this VkPhysicalDeviceShaderCoreBuiltinsPropertiesARMHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceShaderCoreBuiltinsPropertiesARM>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceShaderCoreBuiltinsPropertiesARMExterns
{
}

public struct VkPhysicalDeviceShaderCoreBuiltinsPropertiesARM
{
}
