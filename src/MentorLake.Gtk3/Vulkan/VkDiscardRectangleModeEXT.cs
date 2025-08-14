namespace MentorLake.Vulkan;


public class VkDiscardRectangleModeEXTHandle : BaseSafeHandle
{
}


public static class VkDiscardRectangleModeEXTExtensions
{

	public static VkDiscardRectangleModeEXT Dereference(this VkDiscardRectangleModeEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDiscardRectangleModeEXT>(x.DangerousGetHandle());
}
internal class VkDiscardRectangleModeEXTExterns
{
}


public struct VkDiscardRectangleModeEXT
{
}
