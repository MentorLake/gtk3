namespace MentorLake.Vulkan;


public class VkComponentTypeNVHandle : BaseSafeHandle
{
}


public static class VkComponentTypeNVExtensions
{

	public static VkComponentTypeNV Dereference(this VkComponentTypeNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkComponentTypeNV>(x.DangerousGetHandle());
}
internal class VkComponentTypeNVExterns
{
}


public struct VkComponentTypeNV
{
}
