using System.Security.Cryptography;
using Cosmcs.Base;
using Cosmcs.Crypto;
using Cosmcs.Crypto.Secp256k1;

namespace CardchainCs.ThrowawayAccount
{
	class ThrowawayAccount
	{
		public PrivateKey PrivateKey { get; }
		public PublicKey PublicKey { get; }
		public AccountId AccountId { get; }

		public ThrowawayAccount()
		{
			PrivateKey = new PrivateKey(GetRandomBytes());
			PublicKey = PrivateKey.PublicKey();
			AccountId = PublicKey.AccountId("cc");
		}

		static byte[] GetRandomBytes()
		{
			var bytes = new byte[32];
			RandomNumberGenerator.Create().GetBytes(bytes);
			return bytes;
		}
	}
}