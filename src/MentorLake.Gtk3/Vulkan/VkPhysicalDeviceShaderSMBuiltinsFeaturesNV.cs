namespace MentorLake.Vulkan;


public class VkPhysicalDeviceShaderSMBuiltinsFeaturesNVHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceShaderSMBuiltinsFeaturesNVExtensions
{

	public static VkPhysicalDeviceShaderSMBuiltinsFeaturesNV Dereference(this VkPhysicalDeviceShaderSMBuiltinsFeaturesNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceShaderSMBuiltinsFeaturesNV>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceShaderSMBuiltinsFeaturesNVExterns
{
}


public struct VkPhysicalDeviceShaderSMBuiltinsFeaturesNV
{
}
