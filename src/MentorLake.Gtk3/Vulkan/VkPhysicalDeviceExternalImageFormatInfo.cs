namespace MentorLake.Vulkan;

public class VkPhysicalDeviceExternalImageFormatInfoHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceExternalImageFormatInfoExtensions
{

	public static VkPhysicalDeviceExternalImageFormatInfo Dereference(this VkPhysicalDeviceExternalImageFormatInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceExternalImageFormatInfo>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceExternalImageFormatInfoExterns
{
}

public struct VkPhysicalDeviceExternalImageFormatInfo
{
}
