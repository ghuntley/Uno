#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct MediaTimeRange 
	{
		// Forced skipping of method Windows.Media.MediaTimeRange.MediaTimeRange()
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  global::System.TimeSpan Start;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  global::System.TimeSpan End;
		#endif
	}
}