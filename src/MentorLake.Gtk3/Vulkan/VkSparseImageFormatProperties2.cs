namespace MentorLake.Vulkan;

public class VkSparseImageFormatProperties2Handle : BaseSafeHandle
{
}


public static class VkSparseImageFormatProperties2Extensions
{

	public static VkSparseImageFormatProperties2 Dereference(this VkSparseImageFormatProperties2Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSparseImageFormatProperties2>(x.DangerousGetHandle());
}
internal class VkSparseImageFormatProperties2Externs
{
}

public struct VkSparseImageFormatProperties2
{
}
