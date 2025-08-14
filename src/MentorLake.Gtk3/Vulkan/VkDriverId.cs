namespace MentorLake.Vulkan;


public class VkDriverIdHandle : BaseSafeHandle
{
}


public static class VkDriverIdExtensions
{

	public static VkDriverId Dereference(this VkDriverIdHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDriverId>(x.DangerousGetHandle());
}
internal class VkDriverIdExterns
{
}


public struct VkDriverId
{
}
