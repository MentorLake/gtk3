namespace MentorLake.Vulkan;


public class VkComponentTypeKHRHandle : BaseSafeHandle
{
}


public static class VkComponentTypeKHRExtensions
{

	public static VkComponentTypeKHR Dereference(this VkComponentTypeKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkComponentTypeKHR>(x.DangerousGetHandle());
}
internal class VkComponentTypeKHRExterns
{
}


public struct VkComponentTypeKHR
{
}
