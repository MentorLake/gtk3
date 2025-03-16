namespace MentorLake.Vulkan;

public class VkPhysicalDeviceShaderAtomicInt64FeaturesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceShaderAtomicInt64FeaturesKHRExtensions
{

	public static VkPhysicalDeviceShaderAtomicInt64FeaturesKHR Dereference(this VkPhysicalDeviceShaderAtomicInt64FeaturesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceShaderAtomicInt64FeaturesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceShaderAtomicInt64FeaturesKHRExterns
{
}

public struct VkPhysicalDeviceShaderAtomicInt64FeaturesKHR
{
}
