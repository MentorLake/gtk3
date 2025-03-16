namespace MentorLake.Vulkan;

public class VkPhysicalDeviceShaderAtomicInt64FeaturesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceShaderAtomicInt64FeaturesExtensions
{

	public static VkPhysicalDeviceShaderAtomicInt64Features Dereference(this VkPhysicalDeviceShaderAtomicInt64FeaturesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceShaderAtomicInt64Features>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceShaderAtomicInt64FeaturesExterns
{
}

public struct VkPhysicalDeviceShaderAtomicInt64Features
{
}
