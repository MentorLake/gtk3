namespace MentorLake.Vulkan;

public class VkPhysicalDeviceShaderAtomicFloat2FeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceShaderAtomicFloat2FeaturesEXTExtensions
{

	public static VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT Dereference(this VkPhysicalDeviceShaderAtomicFloat2FeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceShaderAtomicFloat2FeaturesEXTExterns
{
}

public struct VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT
{
}
