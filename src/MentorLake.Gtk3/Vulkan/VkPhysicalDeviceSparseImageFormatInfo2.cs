namespace MentorLake.Vulkan;

public class VkPhysicalDeviceSparseImageFormatInfo2Handle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceSparseImageFormatInfo2Extensions
{

	public static VkPhysicalDeviceSparseImageFormatInfo2 Dereference(this VkPhysicalDeviceSparseImageFormatInfo2Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceSparseImageFormatInfo2>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceSparseImageFormatInfo2Externs
{
}

public struct VkPhysicalDeviceSparseImageFormatInfo2
{
}
