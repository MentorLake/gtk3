namespace MentorLake.Vulkan;

public class VkBufferViewHandle : BaseSafeHandle
{
}


public static class VkBufferViewExtensions
{

	public static VkBufferView Dereference(this VkBufferViewHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBufferView>(x.DangerousGetHandle());
}
internal class VkBufferViewExterns
{
}

public struct VkBufferView
{
}
