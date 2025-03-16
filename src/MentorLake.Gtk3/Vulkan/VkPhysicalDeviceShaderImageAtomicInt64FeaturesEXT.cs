namespace MentorLake.Vulkan;

public class VkPhysicalDeviceShaderImageAtomicInt64FeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceShaderImageAtomicInt64FeaturesEXTExtensions
{

	public static VkPhysicalDeviceShaderImageAtomicInt64FeaturesEXT Dereference(this VkPhysicalDeviceShaderImageAtomicInt64FeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceShaderImageAtomicInt64FeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceShaderImageAtomicInt64FeaturesEXTExterns
{
}

public struct VkPhysicalDeviceShaderImageAtomicInt64FeaturesEXT
{
}
