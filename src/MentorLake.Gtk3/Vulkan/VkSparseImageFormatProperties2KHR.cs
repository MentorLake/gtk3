namespace MentorLake.Vulkan;

public class VkSparseImageFormatProperties2KHRHandle : BaseSafeHandle
{
}


public static class VkSparseImageFormatProperties2KHRExtensions
{

	public static VkSparseImageFormatProperties2KHR Dereference(this VkSparseImageFormatProperties2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSparseImageFormatProperties2KHR>(x.DangerousGetHandle());
}
internal class VkSparseImageFormatProperties2KHRExterns
{
}

public struct VkSparseImageFormatProperties2KHR
{
}
