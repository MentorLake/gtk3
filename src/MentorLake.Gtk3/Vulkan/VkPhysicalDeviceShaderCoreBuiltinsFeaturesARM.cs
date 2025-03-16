namespace MentorLake.Vulkan;

public class VkPhysicalDeviceShaderCoreBuiltinsFeaturesARMHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceShaderCoreBuiltinsFeaturesARMExtensions
{

	public static VkPhysicalDeviceShaderCoreBuiltinsFeaturesARM Dereference(this VkPhysicalDeviceShaderCoreBuiltinsFeaturesARMHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceShaderCoreBuiltinsFeaturesARM>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceShaderCoreBuiltinsFeaturesARMExterns
{
}

public struct VkPhysicalDeviceShaderCoreBuiltinsFeaturesARM
{
}
