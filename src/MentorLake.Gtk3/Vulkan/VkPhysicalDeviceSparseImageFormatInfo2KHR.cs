namespace MentorLake.Vulkan;


public class VkPhysicalDeviceSparseImageFormatInfo2KHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceSparseImageFormatInfo2KHRExtensions
{

	public static VkPhysicalDeviceSparseImageFormatInfo2KHR Dereference(this VkPhysicalDeviceSparseImageFormatInfo2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceSparseImageFormatInfo2KHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceSparseImageFormatInfo2KHRExterns
{
}


public struct VkPhysicalDeviceSparseImageFormatInfo2KHR
{
}
